namespace BookStoreManagement
{
    partial class ManageBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBooks));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStripManageBooks = new System.Windows.Forms.StatusStrip();
            this.lblCurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStaffName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBookInfo = new System.Windows.Forms.GroupBox();
            this.btnClearBookInfo = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.cbBookType = new System.Windows.Forms.ComboBox();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtRentPrice = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAllBooks = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvInventoryLogs = new System.Windows.Forms.DataGridView();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.statusStripManageBooks.SuspendLayout();
            this.groupBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(-7, -2);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(210, 20, 200, 20);
            this.label1.Size = new System.Drawing.Size(630, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Manage Books";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(-4, 67);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(340, 0, 340, 0);
            this.label5.Size = new System.Drawing.Size(680, 13);
            this.label5.TabIndex = 10;
            // 
            // statusStripManageBooks
            // 
            this.statusStripManageBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCurrentTime,
            this.lblStaffName,
            this.lblUserRole});
            this.statusStripManageBooks.Location = new System.Drawing.Point(0, 604);
            this.statusStripManageBooks.Name = "statusStripManageBooks";
            this.statusStripManageBooks.Size = new System.Drawing.Size(611, 22);
            this.statusStripManageBooks.TabIndex = 11;
            this.statusStripManageBooks.Text = "statusStrip1";
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
            // groupBookInfo
            // 
            this.groupBookInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBookInfo.Controls.Add(this.btnClearBookInfo);
            this.groupBookInfo.Controls.Add(this.btnDeleteBook);
            this.groupBookInfo.Controls.Add(this.btnEditBook);
            this.groupBookInfo.Controls.Add(this.btnAddBook);
            this.groupBookInfo.Controls.Add(this.cbBookType);
            this.groupBookInfo.Controls.Add(this.numQuantity);
            this.groupBookInfo.Controls.Add(this.txtRentPrice);
            this.groupBookInfo.Controls.Add(this.txtPrice);
            this.groupBookInfo.Controls.Add(this.txtTitle);
            this.groupBookInfo.Controls.Add(this.label7);
            this.groupBookInfo.Controls.Add(this.label6);
            this.groupBookInfo.Controls.Add(this.label4);
            this.groupBookInfo.Controls.Add(this.label3);
            this.groupBookInfo.Controls.Add(this.label2);
            this.groupBookInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBookInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBookInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBookInfo.Location = new System.Drawing.Point(27, 109);
            this.groupBookInfo.Name = "groupBookInfo";
            this.groupBookInfo.Size = new System.Drawing.Size(281, 281);
            this.groupBookInfo.TabIndex = 12;
            this.groupBookInfo.TabStop = false;
            this.groupBookInfo.Text = "Book Info Section";
            // 
            // btnClearBookInfo
            // 
            this.btnClearBookInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnClearBookInfo.Location = new System.Drawing.Point(228, 0);
            this.btnClearBookInfo.Name = "btnClearBookInfo";
            this.btnClearBookInfo.Size = new System.Drawing.Size(53, 23);
            this.btnClearBookInfo.TabIndex = 13;
            this.btnClearBookInfo.Text = "clear";
            this.btnClearBookInfo.UseVisualStyleBackColor = true;
            this.btnClearBookInfo.Click += new System.EventHandler(this.btnClearBookInfo_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnDeleteBook.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeleteBook.Location = new System.Drawing.Point(184, 245);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBook.TabIndex = 12;
            this.btnDeleteBook.Text = "Delete";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnEditBook.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditBook.Location = new System.Drawing.Point(103, 245);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(75, 23);
            this.btnEditBook.TabIndex = 11;
            this.btnEditBook.Text = "Edit";
            this.btnEditBook.UseVisualStyleBackColor = true;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAddBook.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddBook.Location = new System.Drawing.Point(22, 245);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 10;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // cbBookType
            // 
            this.cbBookType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbBookType.FormattingEnabled = true;
            this.cbBookType.Location = new System.Drawing.Point(81, 80);
            this.cbBookType.Name = "cbBookType";
            this.cbBookType.Size = new System.Drawing.Size(178, 24);
            this.cbBookType.TabIndex = 9;
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.numQuantity.Location = new System.Drawing.Point(115, 202);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(144, 22);
            this.numQuantity.TabIndex = 8;
            // 
            // txtRentPrice
            // 
            this.txtRentPrice.Location = new System.Drawing.Point(115, 161);
            this.txtRentPrice.Name = "txtRentPrice";
            this.txtRentPrice.Size = new System.Drawing.Size(144, 24);
            this.txtRentPrice.TabIndex = 7;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(115, 119);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(143, 24);
            this.txtPrice.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(81, 38);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(178, 24);
            this.txtTitle.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(19, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quantity :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(19, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Rent Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(19, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(19, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Type :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(19, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title :";
            // 
            // dgvAllBooks
            // 
            this.dgvAllBooks.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvAllBooks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAllBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllBooks.Location = new System.Drawing.Point(336, 440);
            this.dgvAllBooks.Name = "dgvAllBooks";
            this.dgvAllBooks.Size = new System.Drawing.Size(251, 129);
            this.dgvAllBooks.TabIndex = 15;
            this.dgvAllBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllBooks_CellClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(335, 410);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "All Books :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(335, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Inventory Logs :";
            // 
            // dgvInventoryLogs
            // 
            this.dgvInventoryLogs.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvInventoryLogs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventoryLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventoryLogs.Location = new System.Drawing.Point(336, 146);
            this.dgvInventoryLogs.Name = "dgvInventoryLogs";
            this.dgvInventoryLogs.Size = new System.Drawing.Size(251, 243);
            this.dgvInventoryLogs.TabIndex = 17;
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBackToMain.Image = global::BookStoreManagement.Properties.Resources.angle_square_left_1_;
            this.btnBackToMain.Location = new System.Drawing.Point(523, 12);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(64, 41);
            this.btnBackToMain.TabIndex = 19;
            this.btnBackToMain.UseVisualStyleBackColor = false;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnClearLog.Location = new System.Drawing.Point(534, 109);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(53, 23);
            this.btnClearLog.TabIndex = 14;
            this.btnClearLog.Text = "clear";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // ManageBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(611, 626);
            this.Controls.Add(this.btnClearLog);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvInventoryLogs);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvAllBooks);
            this.Controls.Add(this.groupBookInfo);
            this.Controls.Add(this.statusStripManageBooks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ManageBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageBooks";
            this.Load += new System.EventHandler(this.ManageBooks_Load);
            this.statusStripManageBooks.ResumeLayout(false);
            this.statusStripManageBooks.PerformLayout();
            this.groupBookInfo.ResumeLayout(false);
            this.groupBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventoryLogs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStripManageBooks;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentTime;
        private System.Windows.Forms.ToolStripStatusLabel lblStaffName;
        private System.Windows.Forms.ToolStripStatusLabel lblUserRole;
        private System.Windows.Forms.GroupBox groupBookInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRentPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.ComboBox cbBookType;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnClearBookInfo;
        private System.Windows.Forms.DataGridView dgvAllBooks;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvInventoryLogs;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Button btnClearLog;
    }
}