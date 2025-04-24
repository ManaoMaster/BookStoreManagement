using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreManagement
{
    public partial class ManageMembers : Form
    {
        private int selectedMemberId = -1;

        public ManageMembers()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private bool ValidateForm()
        {

            if (mtbIdCard.Text.Trim().Length-4 != 13)
            {
                MessageBox.Show("กรุณากรอกเลขบัตรประชาชนให้ครบ 13 หลัก");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("กรุณากรอกชื่อ-นามสกุล");
                return false;
            }
            if (!IsValidEmail(txtEmail.Text.Trim()))
            {
                MessageBox.Show("รูปแบบอีเมลไม่ถูกต้อง");
                return false;
            }
            if (mtbPhone.Text.Trim().Length < 9)
            {
                MessageBox.Show("กรุณากรอกเบอร์โทรให้ถูกต้อง");
                return false;
            }
            if (string.IsNullOrWhiteSpace(rtbAddress.Text))
            {
                MessageBox.Show("กรุณากรอกที่อยู่");
                return false;
            }
            if (cbMembershipType.SelectedIndex == -1)
            {
                MessageBox.Show("กรุณาเลือกประเภทสมาชิก");
                return false;
            }

            return true;
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void ManageMembers_Load(object sender, EventArgs e)
        {
            ShareUsage.StartTimer(lblCurrentTime, lblStaffName, lblUserRole);

            // โหลด ComboBox Member Type
            string query = "SELECT member_type_name FROM member_types";
            DataTable dt = DBHelper.ExecuteSelect(query);
            foreach (DataRow row in dt.Rows)
            {
                cbMembershipType.Items.Add(row["member_type_name"].ToString());
            }

            // โหลดตารางสมาชิก
            RefreshAllViews();
        }
        private void RefreshAllViews()
        {
            string query = @"
            SELECT 
                m.member_id,
                m.id_card AS [รหัสบัตรประชาชน],
                m.full_name AS [ชื่อ-นามสกุล],
                m.birth_date AS [วันเกิด],
                m.email AS [อีเมล],
                m.phone AS [เบอร์โทร],
                m.address AS [ที่อยู่],
                mt.member_type_name AS [ประเภทสมาชิก]
            FROM members m
            LEFT JOIN member_types mt ON m.member_type_id = mt.member_type_id";

            dgvMembers.DataSource = DBHelper.ExecuteSelect(query);
        }


        private void btnBackToMain_Click(object sender, EventArgs e)
        {
            ShareUsage.BackToMain(this);
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {

            if (!ValidateForm()) return;

            string checkQuery = "SELECT COUNT(*) FROM members WHERE id_card = @id_card";
            int exists = Convert.ToInt32(DBHelper.ExecuteScalar(checkQuery, new SqlParameter("@id_card", mtbIdCard.Text.Trim())));
            if (exists > 0)
            {
                MessageBox.Show("มีสมาชิกที่ใช้เลขบัตรนี้อยู่แล้ว");
                return;
            }

            string query = @"
            INSERT INTO members (id_card, full_name, birth_date, email, phone, address, member_type_id)
            VALUES (@id_card, @full_name, @birth_date, @email, @phone, @address, @type_id)";



            int result = DBHelper.ExecuteNonQuery(query,
                new SqlParameter("@id_card", mtbIdCard.Text.Trim()),
                new SqlParameter("@full_name", txtFullName.Text.Trim()),
                new SqlParameter("@birth_date", dtpBirthDate.Value),
                new SqlParameter("@email", txtEmail.Text.Trim()),
                new SqlParameter("@phone", mtbPhone.Text.Trim()),
                new SqlParameter("@address", rtbAddress.Text.Trim()),
                new SqlParameter("@type_id", cbMembershipType.SelectedIndex + 1));

            if (result > 0)
            {
                MessageBox.Show("เพิ่มสมาชิกเรียบร้อย");
                RefreshAllViews();
                ClearForm();
            }
        }

        private void mtbIdCard_TextChanged(object sender, EventArgs e)
        {
            //string idCard = mtbIdCard.Text.Trim();
            //if (idCard.Length >= 13)
            //{
            //    string query = "SELECT * FROM members WHERE id_card = @id_card";
            //    DataTable dt = DBHelper.ExecuteSelect(query, new SqlParameter("@id_card", idCard));
            //    if (dt.Rows.Count > 0)
            //    {
            //        DataRow row = dt.Rows[0];
            //        selectedMemberId = Convert.ToInt32(row["member_id"]);
            //        txtFullName.Text = row["full_name"].ToString();
            //        dtpBirthDate.Value = Convert.ToDateTime(row["birth_date"]);
            //        txtEmail.Text = row["email"].ToString();
            //        mtbPhone.Text = row["phone"].ToString();
            //        rtbAddress.Text = row["address"].ToString();

            //        string typeName = GetMemberTypeName((int)row["member_type_id"]);
            //        int index = cbMembershipType.Items.IndexOf(typeName);
            //        if (index >= 0) cbMembershipType.SelectedIndex = index;

            //        btnAddMember.Enabled = false;
            //        btnEditMember.Enabled = true;
            //        btnDeleteMember.Enabled = true;
            //    }
            //    else
            //    {
            //        selectedMemberId = -1;
            //        btnAddMember.Enabled = true;
            //        btnEditMember.Enabled = false;
            //        btnDeleteMember.Enabled = false;
            //    }
            //}
        }
        private string GetMemberTypeName(int memberTypeId)
        {
            string query = "SELECT member_type_name FROM member_types WHERE member_type_id = @id";
            object result = DBHelper.ExecuteScalar(query, new SqlParameter("@id", memberTypeId));
            return result?.ToString();
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            if (selectedMemberId > 0)
            {
                // ตรวจสอบการกรอกข้อมูลให้ครบถ้วนก่อนทำการแก้ไข
                if (!ValidateForm()) return;

                // ตรวจสอบว่า id_card นี้มีอยู่ในระบบแล้วหรือยัง (แต่ไม่รวมของสมาชิกคนนี้)
                string checkQuery = "SELECT COUNT(*) FROM members WHERE id_card = @id_card AND member_id != @member_id";
                int exists = Convert.ToInt32(DBHelper.ExecuteScalar(checkQuery,
                    new SqlParameter("@id_card", mtbIdCard.Text.Trim()),
                    new SqlParameter("@member_id", selectedMemberId)));

                if (exists > 0)
                {
                    MessageBox.Show("มีสมาชิกคนอื่นใช้เลขบัตรนี้แล้ว");
                    return;
                }

                string query = @"
            UPDATE members SET 
                id_card = @id_card,
                full_name = @full_name,
                birth_date = @birth_date,
                email = @email,
                phone = @phone,
                address = @address,
                member_type_id = @type_id
            WHERE member_id = @member_id";

                int result = DBHelper.ExecuteNonQuery(query,
                    new SqlParameter("@id_card", mtbIdCard.Text.Trim()),
                    new SqlParameter("@full_name", txtFullName.Text.Trim()),
                    new SqlParameter("@birth_date", dtpBirthDate.Value),
                    new SqlParameter("@email", txtEmail.Text.Trim()),
                    new SqlParameter("@phone", mtbPhone.Text.Trim()),
                    new SqlParameter("@address", rtbAddress.Text.Trim()),
                    new SqlParameter("@type_id", cbMembershipType.SelectedIndex + 1),
                    new SqlParameter("@member_id", selectedMemberId));

                if (result > 0)
                {
                    MessageBox.Show("แก้ไขข้อมูลสมาชิกเรียบร้อย");
                    RefreshAllViews();
                    ClearForm();
                }
            }
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (selectedMemberId > 0)
            {
                var confirm = MessageBox.Show("ยืนยันการลบสมาชิก?", "ยืนยัน", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    string query = "DELETE FROM members WHERE member_id = @id";
                    int result = DBHelper.ExecuteNonQuery(query, new SqlParameter("@id", selectedMemberId));
                    if (result > 0)
                    {
                        MessageBox.Show("ลบข้อมูลสมาชิกแล้ว");
                        RefreshAllViews();
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("ไม่สามารถลบสมาชิกได้");
                    }
                }
            }
            else
            {
                MessageBox.Show("กรุณาเลือกสมาชิกก่อนลบ");
            }
        }


        private void btnClearMemberForm_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            selectedMemberId = -1;
            mtbIdCard.Clear();
            txtFullName.Clear();
            txtEmail.Clear();
            mtbPhone.Clear();
            rtbAddress.Clear();
            cbMembershipType.SelectedIndex = -1;
            dtpBirthDate.Value = DateTime.Today;

            btnAddMember.Enabled = true;
            btnEditMember.Enabled = false;
            btnDeleteMember.Enabled = false;
        }

        private void btnSearchIDCard_Click(object sender, EventArgs e)
        {
            string idCard = mtbSearchIdCard.Text.Trim();
            if (!string.IsNullOrEmpty(idCard))
            {
                string query = @"
        SELECT 
            m.member_id,
            m.id_card AS [รหัสบัตรประชาชน],
            m.full_name AS [ชื่อ-นามสกุล],
            m.birth_date AS [วันเกิด],
            m.email AS [อีเมล],
            m.phone AS [เบอร์โทร],
            m.address AS [ที่อยู่],
            mt.member_type_name AS [ประเภทสมาชิก]
        FROM members m
        LEFT JOIN member_types mt ON m.member_type_id = mt.member_type_id
        WHERE m.id_card = @id_card";

                DataTable dt = DBHelper.ExecuteSelect(query, new SqlParameter("@id_card", idCard));
                dgvMembers.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("ไม่พบสมาชิกที่ค้นหา");
                }
            }
            else
            {
                MessageBox.Show("กรุณากรอกเลขบัตรประชาชน");
            }
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvMembers.Rows[e.RowIndex].Cells["รหัสบัตรประชาชน"].Value == null)
                return;

            DataGridViewRow row = dgvMembers.Rows[e.RowIndex];
            string idCard = row.Cells["รหัสบัตรประชาชน"].Value.ToString();

            string query = "SELECT * FROM members WHERE id_card = @id_card";
            DataTable dt = DBHelper.ExecuteSelect(query, new SqlParameter("@id_card", idCard));

            if (dt.Rows.Count > 0)
            {
                DataRow data = dt.Rows[0];
                selectedMemberId = Convert.ToInt32(data["member_id"]);
                mtbIdCard.Text = data["id_card"].ToString();
                txtFullName.Text = data["full_name"].ToString();
                dtpBirthDate.Value = Convert.ToDateTime(data["birth_date"]);
                txtEmail.Text = data["email"].ToString();
                mtbPhone.Text = data["phone"].ToString();
                rtbAddress.Text = data["address"].ToString();

                string typeName = GetMemberTypeName((int)data["member_type_id"]);
                int index = cbMembershipType.Items.IndexOf(typeName);
                if (index >= 0) cbMembershipType.SelectedIndex = index;

                btnAddMember.Enabled = false;
                btnEditMember.Enabled = true;
                btnDeleteMember.Enabled = true;
            }
        }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
