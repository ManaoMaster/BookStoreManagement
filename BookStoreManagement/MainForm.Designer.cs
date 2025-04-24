namespace BookStoreManagement
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lblCurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStaffName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReturnBooks = new System.Windows.Forms.Button();
            this.btnRentBooks = new System.Windows.Forms.Button();
            this.btnSellBooks = new System.Windows.Forms.Button();
            this.btnManageMembers = new System.Windows.Forms.Button();
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(-24, -3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(200, 20, 200, 20);
            this.label1.Size = new System.Drawing.Size(743, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bookstore Management";
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCurrentTime,
            this.lblStaffName,
            this.lblUserRole});
            this.statusStripMain.Location = new System.Drawing.Point(0, 455);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(675, 22);
            this.statusStripMain.TabIndex = 8;
            this.statusStripMain.Text = "statusStrip1";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(-5, 70);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(340, 0, 340, 0);
            this.label5.Size = new System.Drawing.Size(680, 13);
            this.label5.TabIndex = 9;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(356, 307);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnLogout.Size = new System.Drawing.Size(219, 66);
            this.btnLogout.TabIndex = 14;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReturnBooks
            // 
            this.btnReturnBooks.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnReturnBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnReturnBooks.Image = global::BookStoreManagement.Properties.Resources.undo;
            this.btnReturnBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnBooks.Location = new System.Drawing.Point(99, 307);
            this.btnReturnBooks.Name = "btnReturnBooks";
            this.btnReturnBooks.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnReturnBooks.Size = new System.Drawing.Size(219, 66);
            this.btnReturnBooks.TabIndex = 13;
            this.btnReturnBooks.Text = "Return Books ";
            this.btnReturnBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturnBooks.UseVisualStyleBackColor = false;
            this.btnReturnBooks.Click += new System.EventHandler(this.btnReturnBooks_Click);
            // 
            // btnRentBooks
            // 
            this.btnRentBooks.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnRentBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnRentBooks.Image = global::BookStoreManagement.Properties.Resources.rent_signal;
            this.btnRentBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRentBooks.Location = new System.Drawing.Point(356, 217);
            this.btnRentBooks.Name = "btnRentBooks";
            this.btnRentBooks.Padding = new System.Windows.Forms.Padding(30, 0, 40, 0);
            this.btnRentBooks.Size = new System.Drawing.Size(219, 66);
            this.btnRentBooks.TabIndex = 12;
            this.btnRentBooks.Text = "Rent Books";
            this.btnRentBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRentBooks.UseVisualStyleBackColor = false;
            this.btnRentBooks.Click += new System.EventHandler(this.btnRentBooks_Click);
            // 
            // btnSellBooks
            // 
            this.btnSellBooks.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSellBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnSellBooks.Image = global::BookStoreManagement.Properties.Resources.sell;
            this.btnSellBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSellBooks.Location = new System.Drawing.Point(99, 217);
            this.btnSellBooks.Name = "btnSellBooks";
            this.btnSellBooks.Padding = new System.Windows.Forms.Padding(30, 0, 40, 0);
            this.btnSellBooks.Size = new System.Drawing.Size(219, 66);
            this.btnSellBooks.TabIndex = 11;
            this.btnSellBooks.Text = "Sell Books ";
            this.btnSellBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSellBooks.UseVisualStyleBackColor = false;
            this.btnSellBooks.Click += new System.EventHandler(this.btnSellBooks_Click);
            // 
            // btnManageMembers
            // 
            this.btnManageMembers.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnManageMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnManageMembers.Image = global::BookStoreManagement.Properties.Resources.member_search;
            this.btnManageMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageMembers.Location = new System.Drawing.Point(356, 129);
            this.btnManageMembers.Name = "btnManageMembers";
            this.btnManageMembers.Padding = new System.Windows.Forms.Padding(30, 0, 25, 0);
            this.btnManageMembers.Size = new System.Drawing.Size(219, 66);
            this.btnManageMembers.TabIndex = 10;
            this.btnManageMembers.Text = "Manage Members";
            this.btnManageMembers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageMembers.UseVisualStyleBackColor = false;
            this.btnManageMembers.Click += new System.EventHandler(this.btnManageMembers_Click);
            // 
            // btnManageBooks
            // 
            this.btnManageBooks.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnManageBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnManageBooks.Image = global::BookStoreManagement.Properties.Resources.book_alt;
            this.btnManageBooks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageBooks.Location = new System.Drawing.Point(99, 129);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Padding = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.btnManageBooks.Size = new System.Drawing.Size(219, 66);
            this.btnManageBooks.TabIndex = 7;
            this.btnManageBooks.Text = "Manage Books";
            this.btnManageBooks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnManageBooks.UseVisualStyleBackColor = false;
            this.btnManageBooks.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(675, 477);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReturnBooks);
            this.Controls.Add(this.btnRentBooks);
            this.Controls.Add(this.btnSellBooks);
            this.Controls.Add(this.btnManageMembers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.btnManageBooks);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentTime;
        private System.Windows.Forms.ToolStripStatusLabel lblStaffName;
        private System.Windows.Forms.ToolStripStatusLabel lblUserRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnManageMembers;
        private System.Windows.Forms.Button btnSellBooks;
        private System.Windows.Forms.Button btnRentBooks;
        private System.Windows.Forms.Button btnReturnBooks;
        private System.Windows.Forms.Button btnLogout;
    }
}