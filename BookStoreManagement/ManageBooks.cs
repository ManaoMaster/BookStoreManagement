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
    public partial class ManageBooks : Form
    {
        private int selectedBookId = -1;

        public ManageBooks()
        {
            InitializeComponent();
        }

        private void ManageBooks_Load(object sender, EventArgs e)
        {
            ShareUsage.StartTimer(lblCurrentTime, lblStaffName, lblUserRole);


            RefreshAllViews();

            btnEditBook.Enabled = false;
            btnDeleteBook.Enabled = false;
        }

        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            ShareUsage.BackToMain(this);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {



            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtRentPrice.Text) ||
                
                cbBookType.SelectedIndex < 0)
            {
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบทุกช่อง");
                return;
            }

            if (numQuantity.Value <= 0)
            {
                MessageBox.Show("จำนวนหนังสือต้องมากกว่า 0");
                return;
            }

            if (!decimal.TryParse(txtPrice.Text.Trim(), out decimal price))
            {
                MessageBox.Show("ราคาขายต้องเป็นตัวเลขเท่านั้น");
                return;
            }

            if (!decimal.TryParse(txtRentPrice.Text.Trim(), out decimal rentPrice))
            {
                MessageBox.Show("ราคาเช่าต้องเป็นตัวเลขเท่านั้น");
                return;
            }

            string insertBookQuery = @"
                INSERT INTO books (title, book_type_id, rent_price, price, quantity)
                OUTPUT INSERTED.book_id
                VALUES (@title, @book_type_id, @rent_price, @price, @quantity)";


            int bookId = (int)DBHelper.ExecuteScalar(insertBookQuery,
    new SqlParameter("@title", txtTitle.Text.Trim()),
    new SqlParameter("@price", decimal.Parse(txtPrice.Text.Trim())),
    new SqlParameter("@rent_price", decimal.Parse(txtRentPrice.Text.Trim())),
    new SqlParameter("@quantity", numQuantity.Value),
    new SqlParameter("@book_type_id", cbBookType.SelectedIndex + 1));

            string insertLogQuery = @"
INSERT INTO book_inventory_logs 
(book_id, book_title, quantity_added, added_by_staff_id, added_date)
VALUES (@book_id, @book_title, @quantity_added, @added_by_staff_id, @added_date)";
            DBHelper.ExecuteNonQuery(insertLogQuery,
                new SqlParameter("@book_id", bookId),
                new SqlParameter("@book_title", txtTitle.Text.Trim()),
                new SqlParameter("@quantity_added", numQuantity.Value),
                new SqlParameter("@added_by_staff_id", ShareUsage.StaffId),
                new SqlParameter("@added_date", DateTime.Now));

            MessageBox.Show("เพิ่มหนังสือสำเร็จ");
            RefreshAllViews();
        }

        private void dgvAllBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAllBooks.Rows[e.RowIndex];
                selectedBookId = Convert.ToInt32(row.Cells["book_id"].Value);

                string query = @"
        SELECT b.title, b.price, b.rent_price, b.quantity, bt.type_name 
        FROM books b
        LEFT JOIN book_types bt ON b.book_type_id = bt.book_type_id
        WHERE b.book_id = @book_id";
                DataTable dt = DBHelper.ExecuteSelect(query, new SqlParameter("@book_id", selectedBookId));

                if (dt.Rows.Count > 0)
                {
                    DataRow book = dt.Rows[0];
                    txtTitle.Text = book["title"].ToString();
                    txtPrice.Text = book["price"].ToString();
                    txtRentPrice.Text = book["rent_price"].ToString();
                    numQuantity.Value = Convert.ToDecimal(book["quantity"]);

                    string typeName = book["type_name"].ToString();
                    int index = cbBookType.Items.IndexOf(typeName);
                    if (index >= 0)
                        cbBookType.SelectedIndex = index;
                }

                btnAddBook.Enabled = false;
                btnEditBook.Enabled = true;
                btnDeleteBook.Enabled = true;
            }
        }

        private void btnEditBook_Click(object sender, EventArgs e)
        {
            if (selectedBookId > 0)
            {
                string updateQuery = @"
        UPDATE books SET 
            title = @title, 
            price = @price, 
            rent_price = @rent_price, 
            quantity = @quantity, 
            book_type_id = @type_id
        WHERE book_id = @book_id";
                int result = DBHelper.ExecuteNonQuery(updateQuery,
                    new SqlParameter("@title", txtTitle.Text.Trim()),
                    new SqlParameter("@price", txtPrice.Text.Trim()),
                    new SqlParameter("@rent_price", txtRentPrice.Text.Trim()),
                    new SqlParameter("@quantity", numQuantity.Value),
                    new SqlParameter("@type_id", cbBookType.SelectedIndex + 1),
                    new SqlParameter("@book_id", selectedBookId));

                if (result > 0)
                {
                    // เพิ่มบันทึกการแก้ไขลงใน book_inventory_logs
                    string insertLogQuery = @"
            INSERT INTO book_inventory_logs (book_id, quantity_added, added_by_staff_id, added_date,status)
            VALUES (@book_id, @quantity_added, @added_by_staff_id, @added_date,@status)";
                    DBHelper.ExecuteNonQuery(insertLogQuery,
                        new SqlParameter("@book_id", selectedBookId),
                        new SqlParameter("@quantity_added", numQuantity.Value),
                        new SqlParameter("@added_by_staff_id", ShareUsage.StaffId),
                        new SqlParameter("@added_date", DateTime.Now),
                        new SqlParameter("@status", "แก้ไข"));

                    MessageBox.Show("แก้ไขข้อมูลหนังสือสำเร็จ");
                    RefreshAllViews();
                }
                else
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการแก้ไข");
                }
            }
        }
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (selectedBookId > 0)
            {
                // ดึงข้อมูลหนังสือที่ต้องการลบ
                var result = DBHelper.ExecuteSelect(
                    "SELECT title FROM books WHERE book_id = @book_id",
                    new SqlParameter("@book_id", selectedBookId)
                );

                if (result.Rows.Count > 0)
                {
                    string bookTitle = result.Rows[0]["title"].ToString();

                    // ลบหนังสือออกจากตาราง books
                    int deleteResult = DBHelper.ExecuteNonQuery(
                        "DELETE FROM books WHERE book_id = @book_id",
                        new SqlParameter("@book_id", selectedBookId)
                    );

                    if (deleteResult > 0)
                    {
                        // บันทึก log การลบหนังสือ
                        string insertLogQuery = @"
INSERT INTO book_inventory_logs 
(book_id, book_title, quantity_added, added_by_staff_id, added_date, status)
VALUES (@book_id, @book_title, 0, @added_by_staff_id, @added_date, @status)";

                        DBHelper.ExecuteNonQuery(insertLogQuery,
                            new SqlParameter("@book_id", selectedBookId),
                            new SqlParameter("@book_title", bookTitle),
                            new SqlParameter("@added_by_staff_id", ShareUsage.StaffId),
                            new SqlParameter("@added_date", DateTime.Now),
                            new SqlParameter("@status", "Deleted") // บันทึกสถานะการลบ
                        );

                        MessageBox.Show("ลบหนังสือสำเร็จ");
                        RefreshAllViews(); // โหลดข้อมูลใหม่หลังจากลบหนังสือ
                    }
                    else
                    {
                        MessageBox.Show("เกิดข้อผิดพลาดในการลบหนังสือ");
                    }
                }
                else
                {
                    MessageBox.Show("ไม่พบข้อมูลหนังสือ");
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกหนังสือที่ต้องการลบ");
            }
        }









        private void btnClearBookInfo_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void RefreshAllViews()
        {
            // โหลดข้อมูลสำหรับ dgvAllBooks
            string allBooksQuery = @"
SELECT b.book_id, b.title AS [ชื่อหนังสือ], bt.type_name AS [ประเภท]
FROM books b
LEFT JOIN book_types bt ON b.book_type_id = bt.book_type_id";

            DataTable booksTable = DBHelper.ExecuteSelect(allBooksQuery);
            dgvAllBooks.DataSource = booksTable;

            // โหลดข้อมูลสำหรับ dgvInventoryLogs
            string logsQuery = @"
SELECT 
    log.log_id AS [รหัส],
    ISNULL(b.title, log.book_title) AS [รายการ],
    log.quantity_added AS [จำนวนที่เพิ่ม],
    s.full_name AS [เพิ่มโดย], 
    log.added_date AS [วันที่เพิ่ม],
    log.status AS [สถานะ]
FROM book_inventory_logs log
LEFT JOIN books b ON log.book_id = b.book_id
LEFT JOIN staff s ON log.added_by_staff_id = s.staff_id
ORDER BY log.log_id DESC";


            dgvAllBooks.Columns["book_id"].Visible = false;
            dgvInventoryLogs.DataSource = DBHelper.ExecuteSelect(logsQuery);

            // เติม ComboBox ประเภท
            cbBookType.Items.Clear();
            string addCbQuery = "SELECT type_name FROM book_types";
            DataTable dt = DBHelper.ExecuteSelect(addCbQuery);
            foreach (DataRow row in dt.Rows)
            {
                cbBookType.Items.Add(row["type_name"].ToString());
            }

            // ล้างช่องกรอก
            ClearForm();
        }



        private void ClearForm()
        {
            selectedBookId = -1;
            txtTitle.Clear();
            txtPrice.Clear();
            txtRentPrice.Clear();
            numQuantity.Value = 0;
            cbBookType.SelectedIndex = -1;

            btnAddBook.Enabled = true;
            btnEditBook.Enabled = false;
            btnDeleteBook.Enabled = false;
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {

        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("คุณแน่ใจหรือไม่ว่าต้องการลบประวัติทั้งหมด?", "ยืนยัน", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                string deleteLogsQuery = "DELETE FROM book_inventory_logs";
                int result = DBHelper.ExecuteNonQuery(deleteLogsQuery);

                if (result >= 0)
                {
                    MessageBox.Show("ลบประวัติทั้งหมดเรียบร้อยแล้ว", "สำเร็จ");
                    RefreshAllViews(); // โหลดข้อมูลใหม่
                }
                else
                {
                    MessageBox.Show("เกิดข้อผิดพลาดในการลบประวัติ", "ผิดพลาด");
                }
            }
        }

    }
}
