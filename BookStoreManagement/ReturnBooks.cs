using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreManagement
{
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            ShareUsage.BackToMain(this);
        }

        private void loadMembers()
        {
            ShareUsage.StartTimer(lblCurrentTime, lblStaffName, lblUserRole);
            DataTable members = DBHelper.ExecuteSelect("SELECT member_id, full_name FROM members");
            cbMember.DisplayMember = "full_name";
            cbMember.ValueMember = "member_id";
            cbMember.DataSource = members;
        }

        private void cbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadUnreturnedBooks();
        }

        private void LoadUnreturnedBooks()
        {

            if (cbMember.SelectedValue == null) return;

            int memberId = Convert.ToInt32(cbMember.SelectedValue);

            string query = @"
                SELECT 
                    r.rental_id, 
                    r.book_id, 
                    b.title,
                    b.rent_price AS rent_price, -- หรือเปลี่ยนชื่อถ้าใน book ใช้ชื่ออื่น
                    r.due_date
                FROM rentals r
                INNER JOIN Books b ON r.book_id = b.book_id
                WHERE r.member_id = @mid AND r.status = 'Rented'
            ";

            DataTable unreturnedBooks = DBHelper.ExecuteSelect(query,
                new SqlParameter("@mid", memberId)
            );

            dgvUnreturnedRentals.DataSource = unreturnedBooks;

        }

        private void CalculateTotal()
        {
            decimal totalRent = 0;
            decimal totalFine = 0;
            DateTime returnDate = dtpReturnDate.Value;

            foreach (DataGridViewRow row in dgvUnreturnedRentals.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Select"].Value) == true)
                {
                    decimal rent = Convert.ToDecimal(row.Cells["rent_price"].Value);
                    DateTime due = Convert.ToDateTime(row.Cells["due_date"].Value);

                    int lateDays = (returnDate - due).Days;
                    decimal fine = lateDays > 0 ? lateDays * 10 : 0;

                    totalRent += rent;
                    totalFine += fine;
                }
            }

            lblTotalRent.Text = totalRent.ToString("0.00");
            lblTotalFine.Text = totalFine.ToString("0.00");
            lblFinalTotal.Text = (totalRent + totalFine).ToString("0.00");
        }

        private void btnConfirmReturn_Click(object sender, EventArgs e)
        {
            DateTime returnDate = dtpReturnDate.Value;
            const decimal finePerDay = 10m;

            foreach (DataGridViewRow row in dgvUnreturnedRentals.Rows)
            {
                bool isSelected = false;

                if (row.Cells["Select"] is DataGridViewCheckBoxCell)
                {
                    isSelected = Convert.ToBoolean(row.Cells["Select"].Value);
                }

                if (isSelected)
                {
                    string rentalId = row.Cells["rental_id"].Value.ToString();
                    DateTime dueDate = Convert.ToDateTime(row.Cells["due_date"].Value);
                    

                    int daysLate = (returnDate - dueDate).Days;
                    decimal fineAmount = daysLate > 0 ? daysLate * finePerDay : 0;
                    decimal totalPrice;
                    decimal.TryParse( lblFinalTotal.Text, out totalPrice);

                    // INSERT ลงตาราง Return
                    string saleQuery = @"
                INSERT INTO returns (rental_id, staff_id, return_date, total_rent_price, fine_amount)
                VALUES (@rental_id, @staff_id, @return_date, @total_rent_price, @fine_amount)";

                    DBHelper.ExecuteNonQuery(saleQuery,
                        new SqlParameter("@rental_id", rentalId),
                        new SqlParameter("@staff_id", ShareUsage.StaffId),
                        new SqlParameter("@return_date", returnDate),
                        new SqlParameter("@total_rent_price", totalPrice),
                        new SqlParameter("@fine_amount", fineAmount));

                    // อัปเดตสถานะใน Rental เป็นคืนแล้ว
                    string updateQuery = "UPDATE rentals SET status = 'Returned' WHERE rental_id = @rental_id";

                    DBHelper.ExecuteNonQuery(updateQuery,
                        new SqlParameter("@rental_id", rentalId));

                    // 1. เพิ่มจำนวนหนังสือกลับเข้าคลัง
                    string updateBookQtyQuery = @"
UPDATE books
SET quantity = quantity + 1
WHERE book_id = @book_id";

                    DBHelper.ExecuteNonQuery(updateBookQtyQuery,
                        new SqlParameter("@book_id", row.Cells["book_id"].Value));

                    // 2. บันทึกลง log
                    string logQuery = @"
INSERT INTO book_inventory_logs 
(book_id, added_by_staff_id, quantity_added, book_title, added_date, status)
VALUES 
(@book_id, @staff_id, 1, @book_title, @added_date, N'คืน')";

                    DBHelper.ExecuteNonQuery(logQuery,
                        new SqlParameter("@book_id", row.Cells["book_id"].Value),
                        new SqlParameter("@staff_id", ShareUsage.StaffId),
                        new SqlParameter("@book_title", row.Cells["title"].Value.ToString()),
                        new SqlParameter("@added_date", returnDate)
                    );

                }
            }

            MessageBox.Show("บันทึกการคืนหนังสือเรียบร้อยแล้ว");
            ResetForm();
        }


        private void dgvUnreturnedRentals_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUnreturnedRentals.Columns[e.ColumnIndex].Name == "Select")
            {
                CalculateTotal(); // อัปเดตยอดเมื่อมีการเช็ค/ยกเลิกเช็ค
            }
        }

        private void dgvUnreturnedRentals_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvUnreturnedRentals.IsCurrentCellDirty)
            {
                dgvUnreturnedRentals.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            dgvUnreturnedRentals.AllowUserToAddRows = false; // ปิดแถวเปล่าอัตโนมัติ
            Allclear();
            AddCheckboxColumn();
            loadMembers();
            dtpReturnDate.Value = DateTime.Now;

            dgvUnreturnedRentals.CellValueChanged += dgvUnreturnedRentals_CellValueChanged;
            dgvUnreturnedRentals.CurrentCellDirtyStateChanged += dgvUnreturnedRentals_CurrentCellDirtyStateChanged;

        }

        private void AddCheckboxColumn()
        {
            if (!dgvUnreturnedRentals.Columns.Contains("Select"))
            {
                DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
                checkboxColumn.HeaderText = "Select";
                checkboxColumn.Name = "Select";
                checkboxColumn.Width = 50;
                dgvUnreturnedRentals.Columns.Insert(0, checkboxColumn);
            }
        }

        private void btnClearReturn_Click(object sender, EventArgs e)
        {
            Allclear();
        }

        private void Allclear()
        {
            foreach (DataGridViewRow row in dgvUnreturnedRentals.Rows)
            {
                if (row.Cells["Select"] is DataGridViewCheckBoxCell)
                {
                    row.Cells["Select"].Value = false;
                }
            }

            lblTotalRent.Text = "0.00";
            lblTotalFine.Text = "0.00";
            lblFinalTotal.Text = "0.00";
        }
        private void ResetForm()
        {
            // ล้าง DataGridView
            dgvUnreturnedRentals.Columns.Clear();
            dgvUnreturnedRentals.DataSource = null;

            // โหลดสมาชิกใหม่
            loadMembers();

            // รีเซ็ตวันที่
            dtpReturnDate.Value = DateTime.Now;

            // เคลียร์ยอด
            lblTotalRent.Text = "0.00";
            lblTotalFine.Text = "0.00";
            lblFinalTotal.Text = "0.00";

            // รีโหลด checkbox event handler ใหม่
            dgvUnreturnedRentals.CellValueChanged += dgvUnreturnedRentals_CellValueChanged;
            dgvUnreturnedRentals.CurrentCellDirtyStateChanged += dgvUnreturnedRentals_CurrentCellDirtyStateChanged;
        }

    }


}
