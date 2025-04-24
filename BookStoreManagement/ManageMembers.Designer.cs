namespace BookStoreManagement
{
    partial class ManageMembers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageMembers));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupMemberInfo = new System.Windows.Forms.GroupBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.mtbPhone = new System.Windows.Forms.MaskedTextBox();
            this.mtbIdCard = new System.Windows.Forms.MaskedTextBox();
            this.rtbAddress = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClearMemberForm = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnEditMember = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.cbMembershipType = new System.Windows.Forms.ComboBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.statusStripManageMembers = new System.Windows.Forms.StatusStrip();
            this.lblCurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStaffName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSearchIDCard = new System.Windows.Forms.Button();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.mtbSearchIdCard = new System.Windows.Forms.MaskedTextBox();
            this.groupMemberInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.statusStripManageMembers.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(-1, -2);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(210, 20, 200, 20);
            this.label1.Size = new System.Drawing.Size(673, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "Manage Members";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(-8, 70);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(340, 0, 340, 0);
            this.label5.Size = new System.Drawing.Size(680, 13);
            this.label5.TabIndex = 21;
            // 
            // groupMemberInfo
            // 
            this.groupMemberInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupMemberInfo.Controls.Add(this.dtpBirthDate);
            this.groupMemberInfo.Controls.Add(this.mtbPhone);
            this.groupMemberInfo.Controls.Add(this.mtbIdCard);
            this.groupMemberInfo.Controls.Add(this.rtbAddress);
            this.groupMemberInfo.Controls.Add(this.label10);
            this.groupMemberInfo.Controls.Add(this.label7);
            this.groupMemberInfo.Controls.Add(this.txtEmail);
            this.groupMemberInfo.Controls.Add(this.label8);
            this.groupMemberInfo.Controls.Add(this.btnClearMemberForm);
            this.groupMemberInfo.Controls.Add(this.btnDeleteMember);
            this.groupMemberInfo.Controls.Add(this.btnEditMember);
            this.groupMemberInfo.Controls.Add(this.btnAddMember);
            this.groupMemberInfo.Controls.Add(this.cbMembershipType);
            this.groupMemberInfo.Controls.Add(this.txtFullName);
            this.groupMemberInfo.Controls.Add(this.label6);
            this.groupMemberInfo.Controls.Add(this.label4);
            this.groupMemberInfo.Controls.Add(this.label3);
            this.groupMemberInfo.Controls.Add(this.label2);
            this.groupMemberInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupMemberInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupMemberInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupMemberInfo.Location = new System.Drawing.Point(43, 113);
            this.groupMemberInfo.Name = "groupMemberInfo";
            this.groupMemberInfo.Size = new System.Drawing.Size(281, 424);
            this.groupMemberInfo.TabIndex = 22;
            this.groupMemberInfo.TabStop = false;
            this.groupMemberInfo.Text = "Member Info Section";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dtpBirthDate.Location = new System.Drawing.Point(103, 122);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(152, 21);
            this.dtpBirthDate.TabIndex = 40;
            // 
            // mtbPhone
            // 
            this.mtbPhone.Location = new System.Drawing.Point(91, 202);
            this.mtbPhone.Mask = "000-000-0000";
            this.mtbPhone.Name = "mtbPhone";
            this.mtbPhone.Size = new System.Drawing.Size(164, 24);
            this.mtbPhone.TabIndex = 22;
            // 
            // mtbIdCard
            // 
            this.mtbIdCard.Location = new System.Drawing.Point(91, 35);
            this.mtbIdCard.Mask = "0-0000-00000-00-0";
            this.mtbIdCard.Name = "mtbIdCard";
            this.mtbIdCard.Size = new System.Drawing.Size(164, 24);
            this.mtbIdCard.TabIndex = 21;
            this.mtbIdCard.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.mtbIdCard.TextChanged += new System.EventHandler(this.mtbIdCard_TextChanged);
            // 
            // rtbAddress
            // 
            this.rtbAddress.Location = new System.Drawing.Point(99, 248);
            this.rtbAddress.Name = "rtbAddress";
            this.rtbAddress.Size = new System.Drawing.Size(156, 73);
            this.rtbAddress.TabIndex = 20;
            this.rtbAddress.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(19, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 18);
            this.label10.TabIndex = 19;
            this.label10.Text = "Address  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(19, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Phone :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(78, 161);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 24);
            this.txtEmail.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(19, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Membership :";
            // 
            // btnClearMemberForm
            // 
            this.btnClearMemberForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnClearMemberForm.Location = new System.Drawing.Point(228, 0);
            this.btnClearMemberForm.Name = "btnClearMemberForm";
            this.btnClearMemberForm.Size = new System.Drawing.Size(53, 23);
            this.btnClearMemberForm.TabIndex = 13;
            this.btnClearMemberForm.Text = "clear";
            this.btnClearMemberForm.UseVisualStyleBackColor = true;
            this.btnClearMemberForm.Click += new System.EventHandler(this.btnClearMemberForm_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnDeleteMember.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteMember.Location = new System.Drawing.Point(185, 388);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteMember.TabIndex = 12;
            this.btnDeleteMember.Text = "Delete";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnEditMember
            // 
            this.btnEditMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnEditMember.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditMember.Location = new System.Drawing.Point(104, 388);
            this.btnEditMember.Name = "btnEditMember";
            this.btnEditMember.Size = new System.Drawing.Size(75, 23);
            this.btnEditMember.TabIndex = 11;
            this.btnEditMember.Text = "Edit";
            this.btnEditMember.UseVisualStyleBackColor = true;
            this.btnEditMember.Click += new System.EventHandler(this.btnEditMember_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAddMember.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddMember.Location = new System.Drawing.Point(23, 388);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(75, 23);
            this.btnAddMember.TabIndex = 10;
            this.btnAddMember.Text = "Add";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // cbMembershipType
            // 
            this.cbMembershipType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbMembershipType.FormattingEnabled = true;
            this.cbMembershipType.Location = new System.Drawing.Point(123, 341);
            this.cbMembershipType.Name = "cbMembershipType";
            this.cbMembershipType.Size = new System.Drawing.Size(135, 24);
            this.cbMembershipType.TabIndex = 9;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(112, 80);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(143, 24);
            this.txtFullName.TabIndex = 6;
            this.txtFullName.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(19, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(19, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Birth Date :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(19, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Full Name  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(19, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID Card :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(354, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "All Members :";
            // 
            // dgvMembers
            // 
            this.dgvMembers.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(355, 186);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.Size = new System.Drawing.Size(274, 351);
            this.dgvMembers.TabIndex = 23;
            this.dgvMembers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellClick);
            this.dgvMembers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMembers_CellContentClick);
            // 
            // statusStripManageMembers
            // 
            this.statusStripManageMembers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCurrentTime,
            this.lblStaffName,
            this.lblUserRole});
            this.statusStripManageMembers.Location = new System.Drawing.Point(0, 562);
            this.statusStripManageMembers.Name = "statusStripManageMembers";
            this.statusStripManageMembers.Size = new System.Drawing.Size(670, 22);
            this.statusStripManageMembers.TabIndex = 24;
            this.statusStripManageMembers.Text = "statusStrip1";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.BackColor = System.Drawing.SystemColors.Window;
            this.lblCurrentTime.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(117, 17);
            this.lblCurrentTime.Text = "toolStripStatusLabel1";
            // 
            // lblStaffName
            // 
            this.lblStaffName.BackColor = System.Drawing.SystemColors.Window;
            this.lblStaffName.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblStaffName.Name = "lblStaffName";
            this.lblStaffName.Size = new System.Drawing.Size(117, 17);
            this.lblStaffName.Text = "toolStripStatusLabel2";
            // 
            // lblUserRole
            // 
            this.lblUserRole.BackColor = System.Drawing.SystemColors.Window;
            this.lblUserRole.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserRole.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUserRole.Name = "lblUserRole";
            this.lblUserRole.Size = new System.Drawing.Size(117, 17);
            this.lblUserRole.Text = "toolStripStatusLabel3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(352, 156);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.label11.Size = new System.Drawing.Size(90, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Search ID Card";
            // 
            // btnSearchIDCard
            // 
            this.btnSearchIDCard.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnSearchIDCard.Image = global::BookStoreManagement.Properties.Resources.search;
            this.btnSearchIDCard.Location = new System.Drawing.Point(605, 153);
            this.btnSearchIDCard.Name = "btnSearchIDCard";
            this.btnSearchIDCard.Size = new System.Drawing.Size(23, 24);
            this.btnSearchIDCard.TabIndex = 25;
            this.btnSearchIDCard.UseVisualStyleBackColor = false;
            this.btnSearchIDCard.Click += new System.EventHandler(this.btnSearchIDCard_Click);
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBackToMain.Image = global::BookStoreManagement.Properties.Resources.angle_square_left_1_;
            this.btnBackToMain.Location = new System.Drawing.Point(567, 18);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(64, 41);
            this.btnBackToMain.TabIndex = 20;
            this.btnBackToMain.UseVisualStyleBackColor = false;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // mtbSearchIdCard
            // 
            this.mtbSearchIdCard.Location = new System.Drawing.Point(447, 155);
            this.mtbSearchIdCard.Mask = "0-0000-00000-00-0";
            this.mtbSearchIdCard.Name = "mtbSearchIdCard";
            this.mtbSearchIdCard.Size = new System.Drawing.Size(151, 20);
            this.mtbSearchIdCard.TabIndex = 42;
            // 
            // ManageMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(670, 584);
            this.Controls.Add(this.mtbSearchIdCard);
            this.Controls.Add(this.btnSearchIDCard);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.statusStripManageMembers);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupMemberInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManageMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageMembers";
            this.Load += new System.EventHandler(this.ManageMembers_Load);
            this.groupMemberInfo.ResumeLayout(false);
            this.groupMemberInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.statusStripManageMembers.ResumeLayout(false);
            this.statusStripManageMembers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupMemberInfo;
        private System.Windows.Forms.Button btnClearMemberForm;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnEditMember;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.ComboBox cbMembershipType;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.StatusStrip statusStripManageMembers;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentTime;
        private System.Windows.Forms.ToolStripStatusLabel lblStaffName;
        private System.Windows.Forms.ToolStripStatusLabel lblUserRole;
        private System.Windows.Forms.MaskedTextBox mtbIdCard;
        private System.Windows.Forms.MaskedTextBox mtbPhone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSearchIDCard;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.MaskedTextBox mtbSearchIdCard;
    }
}