using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShareUsage.StartTimer(lblCurrentTime, lblStaffName, lblUserRole);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManageBooks manage = new ManageBooks();
            manage.Show();
            this.Hide();

        }

        private void btnManageMembers_Click(object sender, EventArgs e)
        {
            ManageMembers members = new ManageMembers();
            members.Show();
            this.Hide();
        }

        private void btnSellBooks_Click(object sender, EventArgs e)
        {
            SellBooks books = new SellBooks();
            books.Show();
            this.Hide();
        }

        private void btnRentBooks_Click(object sender, EventArgs e)
        {
            RentBooks books = new RentBooks();
            books.Show();
            this.Hide();
        }

        private void btnReturnBooks_Click(object sender, EventArgs e)
        {
            ReturnBooks books = new ReturnBooks();
            books.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
