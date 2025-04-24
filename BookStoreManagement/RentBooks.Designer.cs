namespace BookStoreManagement
{
    partial class RentBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentBooks));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStripRentBooks = new System.Windows.Forms.StatusStrip();
            this.lblCurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStaffName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupRentInfo = new System.Windows.Forms.GroupBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.label27 = new System.Windows.Forms.Label();
            this.lblDiscountPercent = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblMemberType = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblItemTotal = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMember = new System.Windows.Forms.ComboBox();
            this.cbBook = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClearRentInfo = new System.Windows.Forms.Button();
            this.btnAddToRent = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvRentItems = new System.Windows.Forms.DataGridView();
            this.btnConfirmRent = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.statusStripRentBooks.SuspendLayout();
            this.groupRentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(-5, -2);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(250, 20, 265, 20);
            this.label1.Size = new System.Drawing.Size(690, 73);
            this.label1.TabIndex = 5;
            this.label1.Text = "Rent Books";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(-2, 65);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(340, 0, 350, 0);
            this.label5.Size = new System.Drawing.Size(690, 13);
            this.label5.TabIndex = 11;
            // 
            // statusStripRentBooks
            // 
            this.statusStripRentBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCurrentTime,
            this.lblStaffName,
            this.lblUserRole});
            this.statusStripRentBooks.Location = new System.Drawing.Point(0, 619);
            this.statusStripRentBooks.Name = "statusStripRentBooks";
            this.statusStripRentBooks.Size = new System.Drawing.Size(681, 22);
            this.statusStripRentBooks.TabIndex = 21;
            this.statusStripRentBooks.Text = "statusStrip1";
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
            // groupRentInfo
            // 
            this.groupRentInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupRentInfo.Controls.Add(this.dtpDueDate);
            this.groupRentInfo.Controls.Add(this.label27);
            this.groupRentInfo.Controls.Add(this.lblDiscountPercent);
            this.groupRentInfo.Controls.Add(this.label25);
            this.groupRentInfo.Controls.Add(this.lblMemberType);
            this.groupRentInfo.Controls.Add(this.label23);
            this.groupRentInfo.Controls.Add(this.numQuantity);
            this.groupRentInfo.Controls.Add(this.label11);
            this.groupRentInfo.Controls.Add(this.label10);
            this.groupRentInfo.Controls.Add(this.lblItemTotal);
            this.groupRentInfo.Controls.Add(this.lblPrice);
            this.groupRentInfo.Controls.Add(this.label6);
            this.groupRentInfo.Controls.Add(this.cbMember);
            this.groupRentInfo.Controls.Add(this.cbBook);
            this.groupRentInfo.Controls.Add(this.label8);
            this.groupRentInfo.Controls.Add(this.btnClearRentInfo);
            this.groupRentInfo.Controls.Add(this.btnAddToRent);
            this.groupRentInfo.Controls.Add(this.label4);
            this.groupRentInfo.Controls.Add(this.label3);
            this.groupRentInfo.Controls.Add(this.label2);
            this.groupRentInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupRentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupRentInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupRentInfo.Location = new System.Drawing.Point(39, 104);
            this.groupRentInfo.Name = "groupRentInfo";
            this.groupRentInfo.Size = new System.Drawing.Size(281, 367);
            this.groupRentInfo.TabIndex = 27;
            this.groupRentInfo.TabStop = false;
            this.groupRentInfo.Text = "Rent Info Section";
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dtpDueDate.Location = new System.Drawing.Point(114, 296);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(152, 21);
            this.dtpDueDate.TabIndex = 39;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label27.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label27.Location = new System.Drawing.Point(19, 296);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(74, 18);
            this.label27.TabIndex = 38;
            this.label27.Text = "Due Date:";
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDiscountPercent.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDiscountPercent.Location = new System.Drawing.Point(225, 265);
            this.lblDiscountPercent.Name = "lblDiscountPercent";
            this.lblDiscountPercent.Size = new System.Drawing.Size(27, 16);
            this.lblDiscountPercent.TabIndex = 37;
            this.lblDiscountPercent.Text = "x%";
            this.lblDiscountPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label25.Location = new System.Drawing.Point(19, 263);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(75, 18);
            this.label25.TabIndex = 36;
            this.label25.Text = "Discount :";
            // 
            // lblMemberType
            // 
            this.lblMemberType.AutoSize = true;
            this.lblMemberType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblMemberType.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMemberType.Location = new System.Drawing.Point(225, 233);
            this.lblMemberType.Name = "lblMemberType";
            this.lblMemberType.Size = new System.Drawing.Size(31, 16);
            this.lblMemberType.TabIndex = 29;
            this.lblMemberType.Text = "VIP";
            this.lblMemberType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label23.Location = new System.Drawing.Point(19, 231);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(107, 18);
            this.label23.TabIndex = 28;
            this.label23.Text = "Member Type :";
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.numQuantity.Location = new System.Drawing.Point(121, 152);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(145, 22);
            this.numQuantity.TabIndex = 27;
            this.numQuantity.ValueChanged += new System.EventHandler(this.numQuantity_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(219, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Baht";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(219, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Baht";
            // 
            // lblItemTotal
            // 
            this.lblItemTotal.AutoSize = true;
            this.lblItemTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblItemTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblItemTotal.Location = new System.Drawing.Point(188, 114);
            this.lblItemTotal.Name = "lblItemTotal";
            this.lblItemTotal.Size = new System.Drawing.Size(25, 16);
            this.lblItemTotal.TabIndex = 20;
            this.lblItemTotal.Text = "XX";
            this.lblItemTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPrice.Location = new System.Drawing.Point(188, 78);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(25, 16);
            this.lblPrice.TabIndex = 19;
            this.lblPrice.Text = "XX";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(19, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "Quantity :";
            // 
            // cbMember
            // 
            this.cbMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbMember.FormattingEnabled = true;
            this.cbMember.Location = new System.Drawing.Point(123, 191);
            this.cbMember.Name = "cbMember";
            this.cbMember.Size = new System.Drawing.Size(143, 24);
            this.cbMember.TabIndex = 17;
            this.cbMember.SelectedIndexChanged += new System.EventHandler(this.cbMember_SelectedIndexChanged);
            // 
            // cbBook
            // 
            this.cbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cbBook.FormattingEnabled = true;
            this.cbBook.Location = new System.Drawing.Point(121, 38);
            this.cbBook.Name = "cbBook";
            this.cbBook.Size = new System.Drawing.Size(143, 24);
            this.cbBook.TabIndex = 16;
            this.cbBook.SelectedIndexChanged += new System.EventHandler(this.cbBook_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(19, 193);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Member :";
            // 
            // btnClearRentInfo
            // 
            this.btnClearRentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnClearRentInfo.Location = new System.Drawing.Point(228, 0);
            this.btnClearRentInfo.Name = "btnClearRentInfo";
            this.btnClearRentInfo.Size = new System.Drawing.Size(53, 23);
            this.btnClearRentInfo.TabIndex = 13;
            this.btnClearRentInfo.Text = "clear";
            this.btnClearRentInfo.UseVisualStyleBackColor = true;
            // 
            // btnAddToRent
            // 
            this.btnAddToRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAddToRent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddToRent.Location = new System.Drawing.Point(150, 332);
            this.btnAddToRent.Name = "btnAddToRent";
            this.btnAddToRent.Size = new System.Drawing.Size(116, 27);
            this.btnAddToRent.TabIndex = 10;
            this.btnAddToRent.Text = "Add to Sale";
            this.btnAddToRent.UseVisualStyleBackColor = true;
            this.btnAddToRent.Click += new System.EventHandler(this.btnAddToRent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(19, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(19, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Price  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(19, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label12.Location = new System.Drawing.Point(348, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 18);
            this.label12.TabIndex = 39;
            this.label12.Text = "Rent Items :";
            // 
            // dgvRentItems
            // 
            this.dgvRentItems.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvRentItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRentItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentItems.Location = new System.Drawing.Point(346, 142);
            this.dgvRentItems.Name = "dgvRentItems";
            this.dgvRentItems.Size = new System.Drawing.Size(301, 329);
            this.dgvRentItems.TabIndex = 38;
            // 
            // btnConfirmRent
            // 
            this.btnConfirmRent.CausesValidation = false;
            this.btnConfirmRent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmRent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnConfirmRent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmRent.Location = new System.Drawing.Point(503, 519);
            this.btnConfirmRent.Name = "btnConfirmRent";
            this.btnConfirmRent.Size = new System.Drawing.Size(116, 51);
            this.btnConfirmRent.TabIndex = 40;
            this.btnConfirmRent.Text = "Confirm Rent";
            this.btnConfirmRent.UseVisualStyleBackColor = true;
            this.btnConfirmRent.Click += new System.EventHandler(this.button2_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(426, 538);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 18);
            this.label21.TabIndex = 49;
            this.label21.Text = "Baht";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblFinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblFinalPrice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFinalPrice.Location = new System.Drawing.Point(375, 566);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(25, 16);
            this.lblFinalPrice.TabIndex = 50;
            this.lblFinalPrice.Text = "XX";
            this.lblFinalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblFinalPrice.Click += new System.EventHandler(this.label22_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(426, 534);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 18);
            this.label19.TabIndex = 47;
            this.label19.Text = "Baht";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblDiscountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDiscountAmount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDiscountAmount.Location = new System.Drawing.Point(375, 536);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(25, 16);
            this.lblDiscountAmount.TabIndex = 48;
            this.lblDiscountAmount.Text = "XX";
            this.lblDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDiscountAmount.Click += new System.EventHandler(this.label20_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(106, 564);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 18);
            this.label18.TabIndex = 46;
            this.label18.Text = "FInal Price :";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(106, 534);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 18);
            this.label17.TabIndex = 45;
            this.label17.Text = "Discount :";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(426, 504);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 18);
            this.label16.TabIndex = 41;
            this.label16.Text = "Baht";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblGrandTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGrandTotal.Location = new System.Drawing.Point(375, 507);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(25, 16);
            this.lblGrandTotal.TabIndex = 42;
            this.lblGrandTotal.Text = "XX";
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblGrandTotal.Click += new System.EventHandler(this.label15_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(106, 505);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 18);
            this.label14.TabIndex = 43;
            this.label14.Text = "Grand Total :";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label13.Location = new System.Drawing.Point(37, 492);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(305, 90, 305, 0);
            this.label13.Size = new System.Drawing.Size(610, 103);
            this.label13.TabIndex = 44;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label28.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label28.Location = new System.Drawing.Point(426, 565);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(38, 18);
            this.label28.TabIndex = 51;
            this.label28.Text = "Baht";
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBackToMain.Image = global::BookStoreManagement.Properties.Resources.angle_square_left_1_;
            this.btnBackToMain.Location = new System.Drawing.Point(568, 12);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(64, 41);
            this.btnBackToMain.TabIndex = 20;
            this.btnBackToMain.UseVisualStyleBackColor = false;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // RentBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(681, 641);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.btnConfirmRent);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblFinalPrice);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblDiscountAmount);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupRentInfo);
            this.Controls.Add(this.dgvRentItems);
            this.Controls.Add(this.statusStripRentBooks);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RentBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RentBooks";
            this.Load += new System.EventHandler(this.RentBooks_Load);
            this.statusStripRentBooks.ResumeLayout(false);
            this.statusStripRentBooks.PerformLayout();
            this.groupRentInfo.ResumeLayout(false);
            this.groupRentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.StatusStrip statusStripRentBooks;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentTime;
        private System.Windows.Forms.ToolStripStatusLabel lblStaffName;
        private System.Windows.Forms.ToolStripStatusLabel lblUserRole;
        private System.Windows.Forms.GroupBox groupRentInfo;
        private System.Windows.Forms.Label lblDiscountPercent;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblMemberType;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblItemTotal;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMember;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClearRentInfo;
        private System.Windows.Forms.Button btnAddToRent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvRentItems;
        private System.Windows.Forms.Button btnConfirmRent;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
    }
}