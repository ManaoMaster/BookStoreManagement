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
using static BookStoreManagement.SellBooks;

namespace BookStoreManagement
{
    public partial class RentBooks : Form
    {
        public int BookId;
        public string BookName;
        public decimal UnitPrice;
        public int Quantity;

        public class RentItem
        {
            public int BookId;
            public string BookName;
            public decimal UnitPrice;
            public int Quantity;
            public DateTime DueDate; // เพิ่ม
            public string Status => "Rented"; // หรือจะให้เลือกได้ทีหลัง
            public decimal TotalPrice => UnitPrice * Quantity;
        }


        List<RentItem> rentItems = new List<RentItem>();
        decimal discountPercent = 0;


        public RentBooks()
        {
            InitializeComponent();
        }

        private void RentBooks_Load(object sender, EventArgs e)
        {
            ShareUsage.StartTimer(lblCurrentTime, lblStaffName, lblUserRole);

            // โหลดหนังสือ
            DataTable books = DBHelper.ExecuteSelect("SELECT book_id, title FROM books");
            cbBook.DisplayMember = "title";
            cbBook.ValueMember = "book_id";
            cbBook.DataSource = books;


            // โหลดสมาชิก
            DataTable members = DBHelper.ExecuteSelect("SELECT member_id, full_name FROM members");
            cbMember.DisplayMember = "full_name";
            cbMember.ValueMember = "member_id";
            cbMember.DataSource = members;

            RefreshRentGrid();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rentItems.Count == 0) return;

            string memberId = cbMember.SelectedValue.ToString();
            string staffId = ShareUsage.StaffId;

            foreach (var item in rentItems)
            {
                // ตรวจสอบจำนวนหนังสือในสต็อก
                var stockObj = DBHelper.ExecuteScalar("SELECT quantity FROM books WHERE book_id = @id", new SqlParameter("@id", item.BookId));
                int currentStock = stockObj != null ? Convert.ToInt32(stockObj) : 0;

                if (currentStock < item.Quantity)
                {
                    MessageBox.Show($"หนังสือ \"{item.BookName}\" มีจำนวนไม่เพียงพอในสต็อก (เหลือ {currentStock} เล่ม)", "สต็อกไม่เพียงพอ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // บันทึกการเช่า
                string rentQuery = @"
INSERT INTO rentals (rent_date, due_date, status, member_id, staff_id, book_id, quantity, rent_price_per_unit)
VALUES (GETDATE(), @due_date, @status, @member_id, @staff_id, @book_id, @qty, @price)";
                DBHelper.ExecuteNonQuery(rentQuery,
                    new SqlParameter("@member_id", memberId),
                    new SqlParameter("@staff_id", staffId),
                    new SqlParameter("@book_id", item.BookId),
                    new SqlParameter("@qty", item.Quantity),
                    new SqlParameter("@price", item.UnitPrice),
                    new SqlParameter("@due_date", item.DueDate),
                    new SqlParameter("@status", item.Status)
                );

                // อัปเดตจำนวนหนังสือในสต็อก
                string updateStockQuery = "UPDATE books SET quantity = quantity - @qty WHERE book_id = @book_id";
                DBHelper.ExecuteNonQuery(updateStockQuery,
                    new SqlParameter("@qty", item.Quantity),
                    new SqlParameter("@book_id", item.BookId)
                );

                // บันทึกลงใน book_inventory_logs
                string logQuery = @"
INSERT INTO book_inventory_logs (book_id, book_title, quantity_added, added_by_staff_id, added_date,status)
VALUES (@book_id, @book_title, @quantity_added, @staff_id, GETDATE(),@status)";
                DBHelper.ExecuteNonQuery(logQuery,
                    new SqlParameter("@book_id", item.BookId),
                    new SqlParameter("@book_title", item.BookName),
                    new SqlParameter("@quantity_added", -item.Quantity), // ใช้ค่าลบเพื่อแสดงการเช่า
                    new SqlParameter("@staff_id", staffId),
                    new SqlParameter("@status", "เช่า")
                );
            }

            MessageBox.Show("บันทึกการเช่าหนังสือเรียบร้อยแล้ว", "สำเร็จ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshRentGrid();
            ClearAll();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            ShareUsage.BackToMain(this);
        }

        private void cbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            int bookId = (int)cbBook.SelectedValue;
            var priceObj = DBHelper.ExecuteScalar("SELECT price FROM books WHERE book_id = @id", new SqlParameter("@id", bookId));
            if (priceObj != null)
            {
                lblPrice.Text = Convert.ToDecimal(priceObj).ToString("0.00");
                CalculateTotalPrice();
            }
        }

        private void numQuantity_ValueChanged(object sender, EventArgs e)
        {
            int bookId = (int)cbBook.SelectedValue;
            var priceObj = DBHelper.ExecuteScalar("SELECT price FROM books WHERE book_id = @id", new SqlParameter("@id", bookId));
            if (priceObj != null)
            {
                lblPrice.Text = Convert.ToDecimal(priceObj).ToString("0.00");
                CalculateTotalPrice();
            }
        }
        private void CalculateTotalPrice()
        {
            if (decimal.TryParse(lblPrice.Text, out decimal price))
            {
                int qty = (int)numQuantity.Value;
                lblItemTotal.Text = (price * qty).ToString("0.00");
            }
            else
            {
                lblItemTotal.Text = "0.00";
            }
        }

        private void cbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            int memberId = (int)cbMember.SelectedValue;

            // ดึง member_type_id จาก members
            var row = DBHelper.ExecuteSelect("SELECT member_type_id FROM members WHERE member_id = @id",
                new SqlParameter("@id", memberId)).Rows[0];

            int memberTypeId = Convert.ToInt32(row["member_type_id"]);

            // ตั้งค่าชื่อและ % discount ตาม id แบบ hardcode
            string memberType;
            switch (memberTypeId)
            {
                case 1:
                    memberType = "Premium";
                    discountPercent = 15;
                    break;
                case 2:
                    memberType = "Student";
                    discountPercent = 10;
                    break;
                case 3:
                    memberType = "Standard";
                    discountPercent = 5;
                    break;
                default:
                    memberType = "ทั่วไป";
                    discountPercent = 0;
                    break;
            }

            lblMemberType.Text = memberType;
            lblDiscountPercent.Text = discountPercent.ToString("0") + "%";
            CalculateFinalPrice();
        }

        private void btnAddToRent_Click(object sender, EventArgs e)
        {
            if (cbBook.SelectedItem != null && decimal.TryParse(lblPrice.Text, out decimal unitPrice))
            {
                int qty = (int)numQuantity.Value;
                if (qty > 0)
                {
                    var item = new RentItem
                    {
                        BookId = (int)cbBook.SelectedValue,
                        BookName = cbBook.Text,
                        UnitPrice = unitPrice,
                        Quantity = qty,
                        DueDate = dtpDueDate.Value
                    };
                    rentItems.Clear();
                    rentItems.Add(item);


                    RefreshRentGrid();
                    CalculateFinalPrice();
                }
            }
        }

        private void RefreshRentGrid()
        {
            string query = @"
    SELECT 
        l.log_id,
        l.added_date AS rent_date,
        s.full_name AS StaffName,
        l.book_title AS BookName,
        ABS(l.quantity_added) AS QuantityRented,
        b.price,
        ABS(l.quantity_added) * b.price AS TotalPrice,
        l.status AS Status
    FROM book_inventory_logs l
    INNER JOIN staff s ON l.added_by_staff_id = s.staff_id
    INNER JOIN books b ON l.book_id = b.book_id
    WHERE l.status IN (N'เช่า', N'คืน')
    ORDER BY l.added_date DESC";

            DataTable dt = DBHelper.ExecuteSelect(query);
            dgvRentItems.DataSource = dt;
        }


        private void CalculateFinalPrice()
        {
            decimal grandTotal = rentItems.Sum(s => s.TotalPrice);
            decimal discountAmount = grandTotal * (discountPercent / 100);
            decimal finalPrice = grandTotal - discountAmount;

            lblGrandTotal.Text = grandTotal.ToString("0.00");
            lblDiscountAmount.Text = discountAmount.ToString("0.00");
            lblFinalPrice.Text = finalPrice.ToString("0.00");
        }
        private void ClearAll()
        {
            // ล้างรายการขาย
            rentItems.Clear();

            // รีเซ็ต dropdowns
            if (cbBook.Items.Count > 0) cbBook.SelectedIndex = 0;
            if (cbMember.Items.Count > 0) cbMember.SelectedIndex = 0;

            // รีเซ็ตจำนวน
            numQuantity.Value = 1;

            // เคลียร์ labels
            lblPrice.Text = "0.00";
            lblItemTotal.Text = "0.00";
            lblGrandTotal.Text = "0.00";
            lblDiscountAmount.Text = "0.00";
            lblFinalPrice.Text = "0.00";
            lblDiscountPercent.Text = "-";
            lblMemberType.Text = "-";

            // โหลดรายการใหม่ (จะเห็นว่าขายล่าสุดหายไป)
            RefreshRentGrid();
        }
    }


}
