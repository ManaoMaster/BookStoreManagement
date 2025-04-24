using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreManagement
{
    internal class ShareUsage
    {

        // ข้อมูลผู้ใช้งานที่ล็อกอิน



            public static string StaffId { get; set; }
            public static string FullName { get; set; }
            public static string Role { get; set; }






        // ฟังก์ชันสำหรับเริ่มนับเวลาและอัพเดท ToolStripStatusLabel
        public static void StartTimer(ToolStripStatusLabel statusLabel1, ToolStripStatusLabel statusLabel2, ToolStripStatusLabel statusLabel3)
        {

            String label2 = "พร้อมใช้งาน";
            // แสดง StaffId ใน toolStripStatusLabel1
            statusLabel1.Text = ShareUsage.FullName;

            // แสดงวันที่ใน toolStripStatusLabel3
            statusLabel3.Text = DateTime.Now.ToString("yyyy-MM-dd");

            // เริ่มนับเวลา

            statusLabel2.Text = label2;
        }
        



        // ใช้สำหรับอัปเดตเวลาใน StatusStrip
        public static string GetCurrentTime()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }


        public static void SetStatusInfo(
            ToolStripStatusLabel lblTime,
            ToolStripStatusLabel lblUser,
            ToolStripStatusLabel lblRole
        )
        {
            lblTime.Text = "Time: " + GetCurrentTime();
            lblUser.Text = "User: " + FullName;
            lblRole.Text = "Role: " + Role;
        }




        // ใช้สำหรับ Back to Main Menu
        public static void BackToMain(Form currentForm)
        {
            MainForm main = new MainForm();
            main.Show();
            currentForm.Hide();
        }

    }
}
