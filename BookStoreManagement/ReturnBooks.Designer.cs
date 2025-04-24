namespace BookStoreManagement
{
    partial class ReturnBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBooks));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.statusStripReturnBooks = new System.Windows.Forms.StatusStrip();
            this.lblCurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStaffName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupReturnInfo = new System.Windows.Forms.GroupBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.cbMember = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClearReturn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvUnreturnedRentals = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.btnConfirmReturn = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblFinalTotal = new System.Windows.Forms.Label();
            this.lblTotalFine = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTotalRent = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.statusStripReturnBooks.SuspendLayout();
            this.groupReturnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnreturnedRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(-6, -2);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(250, 20, 260, 20);
            this.label1.Size = new System.Drawing.Size(722, 73);
            this.label1.TabIndex = 5;
            this.label1.Text = "Return Books ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(-4, 70);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(340, 0, 340, 0);
            this.label5.Size = new System.Drawing.Size(680, 13);
            this.label5.TabIndex = 23;
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBackToMain.Image = global::BookStoreManagement.Properties.Resources.angle_square_left_1_;
            this.btnBackToMain.Location = new System.Drawing.Point(575, 15);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(64, 41);
            this.btnBackToMain.TabIndex = 24;
            this.btnBackToMain.UseVisualStyleBackColor = false;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // statusStripReturnBooks
            // 
            this.statusStripReturnBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCurrentTime,
            this.lblStaffName,
            this.lblUserRole});
            this.statusStripReturnBooks.Location = new System.Drawing.Point(0, 596);
            this.statusStripReturnBooks.Name = "statusStripReturnBooks";
            this.statusStripReturnBooks.Size = new System.Drawing.Size(662, 22);
            this.statusStripReturnBooks.TabIndex = 26;
            this.statusStripReturnBooks.Text = "statusStrip1";
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
            // groupReturnInfo
            // 
            this.groupReturnInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupReturnInfo.Controls.Add(this.dtpReturnDate);
            this.groupReturnInfo.Controls.Add(this.label27);
            this.groupReturnInfo.Controls.Add(this.cbMember);
            this.groupReturnInfo.Controls.Add(this.label8);
            this.groupReturnInfo.Controls.Add(this.btnClearReturn);
            this.groupReturnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupReturnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupReturnInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupReturnInfo.Location = new System.Drawing.Point(40, 118);
            this.groupReturnInfo.Name = "groupReturnInfo";
            this.groupReturnInfo.Size = new System.Drawing.Size(585, 119);
            this.groupReturnInfo.TabIndex = 28;
            this.groupReturnInfo.TabStop = false;
            this.groupReturnInfo.Text = "Return Info Section";
            this.groupReturnInfo.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dtpReturnDate.Location = new System.Drawing.Point(123, 78);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(145, 21);
            this.dtpReturnDate.TabIndex = 39;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label27.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label27.Location = new System.Drawing.Point(19, 78);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(91, 18);
            this.label27.TabIndex = 38;
            this.label27.Text = "Return Date:";
            // 
            // cbMember
            // 
            this.cbMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbMember.FormattingEnabled = true;
            this.cbMember.Location = new System.Drawing.Point(123, 38);
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(143, 24);
            this.cbMember.TabIndex = 17;
            this.cbMember.SelectedIndexChanged += new System.EventHandler(this.cbMember_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(19, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Member :";
            // 
            // btnClearReturn
            // 
            this.btnClearReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnClearReturn.Location = new System.Drawing.Point(526, 0);
            this.btnClearReturn.Name = "btnClearReturn";
            this.btnClearReturn.Size = new System.Drawing.Size(53, 23);
            this.btnClearReturn.TabIndex = 13;
            this.btnClearReturn.Text = "clear";
            this.btnClearReturn.UseVisualStyleBackColor = true;
            this.btnClearReturn.Click += new System.EventHandler(this.btnClearReturn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(40, 256);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(158, 18);
            this.label12.TabIndex = 41;
            this.label12.Text = "Rentals Not Returned :";
            // 
            // dgvUnreturnedRentals
            // 
            this.dgvUnreturnedRentals.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvUnreturnedRentals.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUnreturnedRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnreturnedRentals.Location = new System.Drawing.Point(40, 290);
            this.dgvUnreturnedRentals.Name = "dgvUnreturnedRentals";
            this.dgvUnreturnedRentals.Size = new System.Drawing.Size(585, 129);
            this.dgvUnreturnedRentals.TabIndex = 40;
            this.dgvUnreturnedRentals.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnreturnedRentals_CellValueChanged);
            this.dgvUnreturnedRentals.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvUnreturnedRentals_CurrentCellDirtyStateChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label13.Location = new System.Drawing.Point(39, 439);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(290, 120, 295, 0);
            this.label13.Size = new System.Drawing.Size(585, 133);
            this.label13.TabIndex = 45;
            // 
            // btnConfirmReturn
            // 
            this.btnConfirmReturn.CausesValidation = false;
            this.btnConfirmReturn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnConfirmReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmReturn.Location = new System.Drawing.Point(474, 481);
            this.btnConfirmReturn.Name = "btnConfirmReturn";
            this.btnConfirmReturn.Size = new System.Drawing.Size(116, 51);
            this.btnConfirmReturn.TabIndex = 46;
            this.btnConfirmReturn.Text = "Confirm Return";
            this.btnConfirmReturn.UseVisualStyleBackColor = true;
            this.btnConfirmReturn.Click += new System.EventHandler(this.btnConfirmReturn_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label28.Location = new System.Drawing.Point(379, 527);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(38, 18);
            this.label28.TabIndex = 60;
            this.label28.Text = "Baht";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(379, 500);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 18);
            this.label21.TabIndex = 58;
            this.label21.Text = "Baht";
            // 
            // lblFinalTotal
            // 
            this.lblFinalTotal.AutoSize = true;
            this.lblFinalTotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblFinalTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblFinalTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFinalTotal.Location = new System.Drawing.Point(328, 528);
            this.lblFinalTotal.Name = "lblFinalTotal";
            this.lblFinalTotal.Size = new System.Drawing.Size(25, 16);
            this.lblFinalTotal.TabIndex = 59;
            this.lblFinalTotal.Text = "XX";
            this.lblFinalTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalFine
            // 
            this.lblTotalFine.AutoSize = true;
            this.lblTotalFine.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTotalFine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTotalFine.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotalFine.Location = new System.Drawing.Point(328, 498);
            this.lblTotalFine.Name = "lblTotalFine";
            this.lblTotalFine.Size = new System.Drawing.Size(25, 16);
            this.lblTotalFine.TabIndex = 57;
            this.lblTotalFine.Text = "XX";
            this.lblTotalFine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(59, 526);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(84, 18);
            this.label18.TabIndex = 56;
            this.label18.Text = "FInal Total :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(59, 496);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 18);
            this.label17.TabIndex = 55;
            this.label17.Text = "Total Fine :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(379, 466);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 18);
            this.label16.TabIndex = 52;
            this.label16.Text = "Baht";
            // 
            // lblTotalRent
            // 
            this.lblTotalRent.AutoSize = true;
            this.lblTotalRent.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblTotalRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblTotalRent.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTotalRent.Location = new System.Drawing.Point(328, 469);
            this.lblTotalRent.Name = "lblTotalRent";
            this.lblTotalRent.Size = new System.Drawing.Size(25, 16);
            this.lblTotalRent.TabIndex = 53;
            this.lblTotalRent.Text = "XX";
            this.lblTotalRent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(59, 467);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 18);
            this.label14.TabIndex = 54;
            this.label14.Text = "Total Rent :";
            // 
            // ReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(662, 618);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblFinalTotal);
            this.Controls.Add(this.lblTotalFine);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblTotalRent);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnConfirmReturn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvUnreturnedRentals);
            this.Controls.Add(this.groupReturnInfo);
            this.Controls.Add(this.statusStripReturnBooks);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReturnBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBooks";
            this.Load += new System.EventHandler(this.ReturnBooks_Load);
            this.statusStripReturnBooks.ResumeLayout(false);
            this.statusStripReturnBooks.PerformLayout();
            this.groupReturnInfo.ResumeLayout(false);
            this.groupReturnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnreturnedRentals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.StatusStrip statusStripReturnBooks;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentTime;
        private System.Windows.Forms.ToolStripStatusLabel lblStaffName;
        private System.Windows.Forms.ToolStripStatusLabel lblUserRole;
        private System.Windows.Forms.GroupBox groupReturnInfo;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.ComboBox cbMember;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClearReturn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvUnreturnedRentals;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnConfirmReturn;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblFinalTotal;
        private System.Windows.Forms.Label lblTotalFine;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTotalRent;
        private System.Windows.Forms.Label label14;
    }
}