namespace BookStoreManagement
{
    partial class SellBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellBooks));
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStripSellBooks = new System.Windows.Forms.StatusStrip();
            this.lblCurrentTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStaffName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupSellInfo = new System.Windows.Forms.GroupBox();
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
            this.btnClearSaleInfo = new System.Windows.Forms.Button();
            this.btnAddToSale = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvSaleItems = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblDiscountAmount = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblFinalPrice = new System.Windows.Forms.Label();
            this.btnConfirmSale = new System.Windows.Forms.Button();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.statusStripSellBooks.SuspendLayout();
            this.groupSellInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(-2, -3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(260, 20, 260, 20);
            this.label1.Size = new System.Drawing.Size(683, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sell Books";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(0, 68);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(340, 0, 340, 0);
            this.label5.Size = new System.Drawing.Size(680, 13);
            this.label5.TabIndex = 22;
            // 
            // statusStripSellBooks
            // 
            this.statusStripSellBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCurrentTime,
            this.lblStaffName,
            this.lblUserRole});
            this.statusStripSellBooks.Location = new System.Drawing.Point(0, 596);
            this.statusStripSellBooks.Name = "statusStripSellBooks";
            this.statusStripSellBooks.Size = new System.Drawing.Size(671, 22);
            this.statusStripSellBooks.TabIndex = 25;
            this.statusStripSellBooks.Text = "statusStrip1";
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
            // groupSellInfo
            // 
            this.groupSellInfo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupSellInfo.Controls.Add(this.lblDiscountPercent);
            this.groupSellInfo.Controls.Add(this.label25);
            this.groupSellInfo.Controls.Add(this.lblMemberType);
            this.groupSellInfo.Controls.Add(this.label23);
            this.groupSellInfo.Controls.Add(this.numQuantity);
            this.groupSellInfo.Controls.Add(this.label11);
            this.groupSellInfo.Controls.Add(this.label10);
            this.groupSellInfo.Controls.Add(this.lblItemTotal);
            this.groupSellInfo.Controls.Add(this.lblPrice);
            this.groupSellInfo.Controls.Add(this.label6);
            this.groupSellInfo.Controls.Add(this.cbMember);
            this.groupSellInfo.Controls.Add(this.cbBook);
            this.groupSellInfo.Controls.Add(this.label8);
            this.groupSellInfo.Controls.Add(this.btnClearSaleInfo);
            this.groupSellInfo.Controls.Add(this.btnAddToSale);
            this.groupSellInfo.Controls.Add(this.label4);
            this.groupSellInfo.Controls.Add(this.label3);
            this.groupSellInfo.Controls.Add(this.label2);
            this.groupSellInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupSellInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupSellInfo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupSellInfo.Location = new System.Drawing.Point(31, 106);
            this.groupSellInfo.Name = "groupSellInfo";
            this.groupSellInfo.Size = new System.Drawing.Size(281, 341);
            this.groupSellInfo.TabIndex = 26;
            this.groupSellInfo.TabStop = false;
            this.groupSellInfo.Text = "Sell Info Section";
            // 
            // lblDiscountPercent
            // 
            this.lblDiscountPercent.AutoSize = true;
            this.lblDiscountPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDiscountPercent.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDiscountPercent.Location = new System.Drawing.Point(225, 268);
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
            this.label25.Location = new System.Drawing.Point(19, 266);
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
            // btnClearSaleInfo
            // 
            this.btnClearSaleInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnClearSaleInfo.Location = new System.Drawing.Point(228, 0);
            this.btnClearSaleInfo.Name = "btnClearSaleInfo";
            this.btnClearSaleInfo.Size = new System.Drawing.Size(53, 23);
            this.btnClearSaleInfo.TabIndex = 13;
            this.btnClearSaleInfo.Text = "clear";
            this.btnClearSaleInfo.UseVisualStyleBackColor = true;
            this.btnClearSaleInfo.Click += new System.EventHandler(this.btnClearSaleInfo_Click);
            // 
            // btnAddToSale
            // 
            this.btnAddToSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnAddToSale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAddToSale.Location = new System.Drawing.Point(150, 298);
            this.btnAddToSale.Name = "btnAddToSale";
            this.btnAddToSale.Size = new System.Drawing.Size(116, 27);
            this.btnAddToSale.TabIndex = 10;
            this.btnAddToSale.Text = "Add to Sale";
            this.btnAddToSale.UseVisualStyleBackColor = true;
            this.btnAddToSale.Click += new System.EventHandler(this.btnAddToSale_Click);
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
            this.label12.Location = new System.Drawing.Point(335, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 18);
            this.label12.TabIndex = 28;
            this.label12.Text = "Sale Items :";
            // 
            // dgvSaleItems
            // 
            this.dgvSaleItems.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvSaleItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSaleItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSaleItems.Location = new System.Drawing.Point(337, 144);
            this.dgvSaleItems.Name = "dgvSaleItems";
            this.dgvSaleItems.Size = new System.Drawing.Size(301, 303);
            this.dgvSaleItems.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label13.Location = new System.Drawing.Point(30, 468);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(305, 90, 305, 0);
            this.label13.Size = new System.Drawing.Size(610, 103);
            this.label13.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label14.Location = new System.Drawing.Point(100, 482);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 18);
            this.label14.TabIndex = 28;
            this.label14.Text = "Grand Total :";
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblGrandTotal.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblGrandTotal.Location = new System.Drawing.Point(369, 484);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(25, 16);
            this.lblGrandTotal.TabIndex = 28;
            this.lblGrandTotal.Text = "XX";
            this.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(420, 481);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 18);
            this.label16.TabIndex = 28;
            this.label16.Text = "Baht";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(100, 511);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 18);
            this.label17.TabIndex = 30;
            this.label17.Text = "Discount :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(100, 541);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 18);
            this.label18.TabIndex = 31;
            this.label18.Text = "FInal Price :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(420, 511);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(38, 18);
            this.label19.TabIndex = 32;
            this.label19.Text = "Baht";
            // 
            // lblDiscountAmount
            // 
            this.lblDiscountAmount.AutoSize = true;
            this.lblDiscountAmount.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblDiscountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblDiscountAmount.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblDiscountAmount.Location = new System.Drawing.Point(369, 513);
            this.lblDiscountAmount.Name = "lblDiscountAmount";
            this.lblDiscountAmount.Size = new System.Drawing.Size(25, 16);
            this.lblDiscountAmount.TabIndex = 33;
            this.lblDiscountAmount.Text = "XX";
            this.lblDiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label21.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label21.Location = new System.Drawing.Point(420, 541);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 18);
            this.label21.TabIndex = 34;
            this.label21.Text = "Baht";
            // 
            // lblFinalPrice
            // 
            this.lblFinalPrice.AutoSize = true;
            this.lblFinalPrice.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblFinalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblFinalPrice.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblFinalPrice.Location = new System.Drawing.Point(369, 543);
            this.lblFinalPrice.Name = "lblFinalPrice";
            this.lblFinalPrice.Size = new System.Drawing.Size(25, 16);
            this.lblFinalPrice.TabIndex = 35;
            this.lblFinalPrice.Text = "XX";
            this.lblFinalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnConfirmSale
            // 
            this.btnConfirmSale.CausesValidation = false;
            this.btnConfirmSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConfirmSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.btnConfirmSale.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmSale.Location = new System.Drawing.Point(497, 496);
            this.btnConfirmSale.Name = "btnConfirmSale";
            this.btnConfirmSale.Size = new System.Drawing.Size(116, 51);
            this.btnConfirmSale.TabIndex = 28;
            this.btnConfirmSale.Text = "Confirm Sale";
            this.btnConfirmSale.UseVisualStyleBackColor = true;
            this.btnConfirmSale.Click += new System.EventHandler(this.btnConfirmSale_Click);
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnBackToMain.Image = global::BookStoreManagement.Properties.Resources.angle_square_left_1_;
            this.btnBackToMain.Location = new System.Drawing.Point(574, 14);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(64, 41);
            this.btnBackToMain.TabIndex = 23;
            this.btnBackToMain.UseVisualStyleBackColor = false;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // SellBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(671, 618);
            this.Controls.Add(this.btnConfirmSale);
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
            this.Controls.Add(this.dgvSaleItems);
            this.Controls.Add(this.groupSellInfo);
            this.Controls.Add(this.statusStripSellBooks);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SellBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellBooks";
            this.Load += new System.EventHandler(this.SellBooks_Load);
            this.statusStripSellBooks.ResumeLayout(false);
            this.statusStripSellBooks.PerformLayout();
            this.groupSellInfo.ResumeLayout(false);
            this.groupSellInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSaleItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.StatusStrip statusStripSellBooks;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentTime;
        private System.Windows.Forms.ToolStripStatusLabel lblStaffName;
        private System.Windows.Forms.ToolStripStatusLabel lblUserRole;
        private System.Windows.Forms.GroupBox groupSellInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnClearSaleInfo;
        private System.Windows.Forms.Button btnAddToSale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMember;
        private System.Windows.Forms.ComboBox cbBook;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblItemTotal;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvSaleItems;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblDiscountAmount;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblFinalPrice;
        private System.Windows.Forms.Button btnConfirmSale;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblMemberType;
        private System.Windows.Forms.Label lblDiscountPercent;
        private System.Windows.Forms.Label label25;
    }
}