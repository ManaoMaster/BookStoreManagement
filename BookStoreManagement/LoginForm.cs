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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("กรุณากรอก ชื่อผู้ใช้");
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("กรุณากรอก รหัสผ่าน");
                return;
            }

            string query = "SELECT * FROM staff WHERE username = @username AND password = @password";

            DataTable result = DBHelper.ExecuteSelect(query, 
                new SqlParameter("@username",txtUsername.Text.Trim()),
                new SqlParameter("@password",txtPassword.Text.Trim())
                );

            if (result.Rows.Count > 0)
            {
                // ล็อกอินสำเร็จ
                DataRow row = result.Rows[0];
                ShareUsage.StaffId = row["staff_id"].ToString();
                ShareUsage.FullName = row["full_name"].ToString();
                ShareUsage.Role = row["role"].ToString();

                // อาจเปิดหน้าหลักหรือเก็บค่า session
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.Show();
            }
            else
            {
                // ล็อกอินไม่ผ่าน
                MessageBox.Show("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
