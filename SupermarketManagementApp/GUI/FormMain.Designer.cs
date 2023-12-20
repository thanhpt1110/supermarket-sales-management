namespace SupermarketManagementApp
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.quote = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.appName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelAccount = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSignOut = new Guna.UI2.WinForms.Guna2ImageButton();
            this.accountName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.accountRole = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.avatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelMenuSidebar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnStatistic = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.panelSubInvoice = new Guna.UI2.WinForms.Guna2Panel();
            this.btnManageSupplierInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageCustomerInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.btnInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.panelSubProduct = new Guna.UI2.WinForms.Guna2Panel();
            this.btnProductInInventory = new Guna.UI2.WinForms.Guna2Button();
            this.btnProductOnShelf = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageProductType = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageShelf = new Guna.UI2.WinForms.Guna2Button();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.panelChildForm = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelVersion = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelCopyright = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.msgBoxConfirm = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panelAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.panelMenuSidebar.SuspendLayout();
            this.panelSubInvoice.SuspendLayout();
            this.panelSubProduct.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.panelHeader.Controls.Add(this.guna2PictureBox1);
            this.panelHeader.Controls.Add(this.quote);
            this.panelHeader.Controls.Add(this.appName);
            this.panelHeader.Controls.Add(this.panelAccount);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(984, 127);
            this.panelHeader.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::SupermarketManagementApp.Properties.Resources.supermarket_logo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(19, 5);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(100, 100);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 6;
            this.guna2PictureBox1.TabStop = false;
            // 
            // quote
            // 
            this.quote.BackColor = System.Drawing.Color.Transparent;
            this.quote.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quote.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quote.Location = new System.Drawing.Point(125, 65);
            this.quote.Name = "quote";
            this.quote.Size = new System.Drawing.Size(203, 27);
            this.quote.TabIndex = 5;
            this.quote.Text = "Help you manage easily";
            // 
            // appName
            // 
            this.appName.BackColor = System.Drawing.Color.Transparent;
            this.appName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.ForeColor = System.Drawing.Color.DarkOrange;
            this.appName.Location = new System.Drawing.Point(125, 16);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(173, 47);
            this.appName.TabIndex = 5;
            this.appName.Text = "Pro Market";
            // 
            // panelAccount
            // 
            this.panelAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.panelAccount.Controls.Add(this.btnSignOut);
            this.panelAccount.Controls.Add(this.accountName);
            this.panelAccount.Controls.Add(this.accountRole);
            this.panelAccount.Controls.Add(this.avatar);
            this.panelAccount.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAccount.Location = new System.Drawing.Point(685, 0);
            this.panelAccount.Name = "panelAccount";
            this.panelAccount.Size = new System.Drawing.Size(299, 127);
            this.panelAccount.TabIndex = 1;
            // 
            // btnSignOut
            // 
            this.btnSignOut.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSignOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignOut.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSignOut.Image = global::SupermarketManagementApp.Properties.Resources.sign_out;
            this.btnSignOut.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSignOut.ImageRotate = 0F;
            this.btnSignOut.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSignOut.Location = new System.Drawing.Point(224, 50);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSignOut.Size = new System.Drawing.Size(30, 30);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // accountName
            // 
            this.accountName.BackColor = System.Drawing.Color.Transparent;
            this.accountName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.accountName.Location = new System.Drawing.Point(94, 67);
            this.accountName.Name = "accountName";
            this.accountName.Size = new System.Drawing.Size(108, 27);
            this.accountName.TabIndex = 4;
            this.accountName.Text = "Tuan Thanh";
            // 
            // accountRole
            // 
            this.accountRole.BackColor = System.Drawing.Color.Transparent;
            this.accountRole.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountRole.ForeColor = System.Drawing.Color.Red;
            this.accountRole.Location = new System.Drawing.Point(94, 34);
            this.accountRole.Name = "accountRole";
            this.accountRole.Size = new System.Drawing.Size(62, 27);
            this.accountRole.TabIndex = 3;
            this.accountRole.Text = "Admin";
            // 
            // avatar
            // 
            this.avatar.Cursor = System.Windows.Forms.Cursors.Default;
            this.avatar.ImageRotate = 0F;
            this.avatar.Location = new System.Drawing.Point(12, 30);
            this.avatar.Name = "avatar";
            this.avatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.avatar.Size = new System.Drawing.Size(64, 64);
            this.avatar.TabIndex = 2;
            this.avatar.TabStop = false;
            // 
            // panelMenuSidebar
            // 
            this.panelMenuSidebar.AutoRoundedCorners = true;
            this.panelMenuSidebar.AutoScroll = true;
            this.panelMenuSidebar.BackColor = System.Drawing.Color.White;
            this.panelMenuSidebar.BorderRadius = 156;
            this.panelMenuSidebar.Controls.Add(this.btnStatistic);
            this.panelMenuSidebar.Controls.Add(this.btnManageAccount);
            this.panelMenuSidebar.Controls.Add(this.btnManageEmployee);
            this.panelMenuSidebar.Controls.Add(this.btnManageCustomer);
            this.panelMenuSidebar.Controls.Add(this.panelSubInvoice);
            this.panelMenuSidebar.Controls.Add(this.btnInvoice);
            this.panelMenuSidebar.Controls.Add(this.panelSubProduct);
            this.panelMenuSidebar.Controls.Add(this.btnProduct);
            this.panelMenuSidebar.Controls.Add(this.btnManageShelf);
            this.panelMenuSidebar.Controls.Add(this.btnDashboard);
            this.panelMenuSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuSidebar.FillColor = System.Drawing.Color.White;
            this.panelMenuSidebar.Location = new System.Drawing.Point(0, 127);
            this.panelMenuSidebar.Name = "panelMenuSidebar";
            this.panelMenuSidebar.Size = new System.Drawing.Size(315, 718);
            this.panelMenuSidebar.TabIndex = 1;
            // 
            // btnStatistic
            // 
            this.btnStatistic.BackColor = System.Drawing.Color.Transparent;
            this.btnStatistic.BorderRadius = 25;
            this.btnStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatistic.CustomImages.Image = global::SupermarketManagementApp.Properties.Resources.black_stats;
            this.btnStatistic.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStatistic.CustomImages.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnStatistic.CustomImages.ImageSize = new System.Drawing.Size(26, 26);
            this.btnStatistic.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatistic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatistic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatistic.FillColor = System.Drawing.Color.Transparent;
            this.btnStatistic.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.ForeColor = System.Drawing.Color.Black;
            this.btnStatistic.ImageOffset = new System.Drawing.Point(0, 5);
            this.btnStatistic.Location = new System.Drawing.Point(0, 715);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(298, 55);
            this.btnStatistic.TabIndex = 14;
            this.btnStatistic.Text = "View Report && Statistic";
            this.btnStatistic.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStatistic.TextOffset = new System.Drawing.Point(70, -2);
            this.btnStatistic.Click += new System.EventHandler(this.btnStatistic_Click);
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnManageAccount.BorderRadius = 25;
            this.btnManageAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageAccount.CustomImages.Image = global::SupermarketManagementApp.Properties.Resources.black_account;
            this.btnManageAccount.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageAccount.CustomImages.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnManageAccount.CustomImages.ImageSize = new System.Drawing.Size(26, 26);
            this.btnManageAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageAccount.FillColor = System.Drawing.Color.Transparent;
            this.btnManageAccount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAccount.ForeColor = System.Drawing.Color.Black;
            this.btnManageAccount.ImageOffset = new System.Drawing.Point(0, 5);
            this.btnManageAccount.Location = new System.Drawing.Point(0, 660);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(298, 55);
            this.btnManageAccount.TabIndex = 13;
            this.btnManageAccount.Text = "Account";
            this.btnManageAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageAccount.TextOffset = new System.Drawing.Point(70, -2);
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // btnManageEmployee
            // 
            this.btnManageEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnManageEmployee.BorderRadius = 25;
            this.btnManageEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageEmployee.CustomImages.Image = global::SupermarketManagementApp.Properties.Resources.black_employee;
            this.btnManageEmployee.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageEmployee.CustomImages.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnManageEmployee.CustomImages.ImageSize = new System.Drawing.Size(26, 26);
            this.btnManageEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageEmployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageEmployee.FillColor = System.Drawing.Color.Transparent;
            this.btnManageEmployee.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnManageEmployee.ImageOffset = new System.Drawing.Point(0, 5);
            this.btnManageEmployee.Location = new System.Drawing.Point(0, 605);
            this.btnManageEmployee.Name = "btnManageEmployee";
            this.btnManageEmployee.Size = new System.Drawing.Size(298, 55);
            this.btnManageEmployee.TabIndex = 12;
            this.btnManageEmployee.Text = "Employee";
            this.btnManageEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageEmployee.TextOffset = new System.Drawing.Point(70, -2);
            this.btnManageEmployee.Click += new System.EventHandler(this.btnManageEmployee_Click);
            // 
            // btnManageCustomer
            // 
            this.btnManageCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnManageCustomer.BorderRadius = 25;
            this.btnManageCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageCustomer.CustomImages.Image = global::SupermarketManagementApp.Properties.Resources.black_customer;
            this.btnManageCustomer.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageCustomer.CustomImages.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnManageCustomer.CustomImages.ImageSize = new System.Drawing.Size(26, 26);
            this.btnManageCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageCustomer.FillColor = System.Drawing.Color.Transparent;
            this.btnManageCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCustomer.ForeColor = System.Drawing.Color.Black;
            this.btnManageCustomer.ImageOffset = new System.Drawing.Point(0, 5);
            this.btnManageCustomer.Location = new System.Drawing.Point(0, 550);
            this.btnManageCustomer.Name = "btnManageCustomer";
            this.btnManageCustomer.Size = new System.Drawing.Size(298, 55);
            this.btnManageCustomer.TabIndex = 11;
            this.btnManageCustomer.Text = "Customer";
            this.btnManageCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageCustomer.TextOffset = new System.Drawing.Point(70, -2);
            this.btnManageCustomer.Click += new System.EventHandler(this.btnManageCustomer_Click);
            // 
            // panelSubInvoice
            // 
            this.panelSubInvoice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.panelSubInvoice.Controls.Add(this.btnManageSupplierInvoice);
            this.panelSubInvoice.Controls.Add(this.btnManageCustomerInvoice);
            this.panelSubInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubInvoice.Location = new System.Drawing.Point(0, 440);
            this.panelSubInvoice.Name = "panelSubInvoice";
            this.panelSubInvoice.Size = new System.Drawing.Size(298, 110);
            this.panelSubInvoice.TabIndex = 15;
            // 
            // btnManageSupplierInvoice
            // 
            this.btnManageSupplierInvoice.BackColor = System.Drawing.Color.Transparent;
            this.btnManageSupplierInvoice.BorderRadius = 25;
            this.btnManageSupplierInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageSupplierInvoice.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageSupplierInvoice.CustomImages.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnManageSupplierInvoice.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnManageSupplierInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageSupplierInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageSupplierInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageSupplierInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageSupplierInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageSupplierInvoice.FillColor = System.Drawing.Color.Transparent;
            this.btnManageSupplierInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageSupplierInvoice.ForeColor = System.Drawing.Color.Black;
            this.btnManageSupplierInvoice.ImageOffset = new System.Drawing.Point(0, 5);
            this.btnManageSupplierInvoice.Location = new System.Drawing.Point(0, 55);
            this.btnManageSupplierInvoice.Name = "btnManageSupplierInvoice";
            this.btnManageSupplierInvoice.Size = new System.Drawing.Size(298, 55);
            this.btnManageSupplierInvoice.TabIndex = 11;
            this.btnManageSupplierInvoice.Text = "Supplier Invoice";
            this.btnManageSupplierInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageSupplierInvoice.TextOffset = new System.Drawing.Point(70, -2);
            this.btnManageSupplierInvoice.Click += new System.EventHandler(this.btnManageSupplierInvoice_Click);
            // 
            // btnManageCustomerInvoice
            // 
            this.btnManageCustomerInvoice.BackColor = System.Drawing.Color.Transparent;
            this.btnManageCustomerInvoice.BorderRadius = 25;
            this.btnManageCustomerInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageCustomerInvoice.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageCustomerInvoice.CustomImages.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnManageCustomerInvoice.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnManageCustomerInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageCustomerInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageCustomerInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageCustomerInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageCustomerInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageCustomerInvoice.FillColor = System.Drawing.Color.Transparent;
            this.btnManageCustomerInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCustomerInvoice.ForeColor = System.Drawing.Color.Black;
            this.btnManageCustomerInvoice.ImageOffset = new System.Drawing.Point(0, 5);
            this.btnManageCustomerInvoice.Location = new System.Drawing.Point(0, 0);
            this.btnManageCustomerInvoice.Name = "btnManageCustomerInvoice";
            this.btnManageCustomerInvoice.Size = new System.Drawing.Size(298, 55);
            this.btnManageCustomerInvoice.TabIndex = 10;
            this.btnManageCustomerInvoice.Text = "Customer Invoice";
            this.btnManageCustomerInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageCustomerInvoice.TextOffset = new System.Drawing.Point(70, -2);
            this.btnManageCustomerInvoice.Click += new System.EventHandler(this.btnManageCustomerInvoice_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackColor = System.Drawing.Color.Transparent;
            this.btnInvoice.BorderRadius = 25;
            this.btnInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInvoice.CustomImages.Image = global::SupermarketManagementApp.Properties.Resources.black_invoice;
            this.btnInvoice.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInvoice.CustomImages.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnInvoice.CustomImages.ImageSize = new System.Drawing.Size(26, 26);
            this.btnInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInvoice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInvoice.FillColor = System.Drawing.Color.Transparent;
            this.btnInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.ForeColor = System.Drawing.Color.Black;
            this.btnInvoice.Image = global::SupermarketManagementApp.Properties.Resources.black_caret_down;
            this.btnInvoice.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnInvoice.ImageOffset = new System.Drawing.Point(20, -1);
            this.btnInvoice.ImageSize = new System.Drawing.Size(30, 30);
            this.btnInvoice.Location = new System.Drawing.Point(0, 385);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(298, 55);
            this.btnInvoice.TabIndex = 8;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInvoice.TextOffset = new System.Drawing.Point(70, -2);
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // panelSubProduct
            // 
            this.panelSubProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.panelSubProduct.Controls.Add(this.btnProductInInventory);
            this.panelSubProduct.Controls.Add(this.btnProductOnShelf);
            this.panelSubProduct.Controls.Add(this.btnManageProductType);
            this.panelSubProduct.Controls.Add(this.btnManageProduct);
            this.panelSubProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubProduct.Location = new System.Drawing.Point(0, 165);
            this.panelSubProduct.Name = "panelSubProduct";
            this.panelSubProduct.Size = new System.Drawing.Size(298, 220);
            this.panelSubProduct.TabIndex = 16;
            // 
            // btnProductInInventory
            // 
            this.btnProductInInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnProductInInventory.BorderRadius = 25;
            this.btnProductInInventory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductInInventory.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProductInInventory.CustomImages.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnProductInInventory.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnProductInInventory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductInInventory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductInInventory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductInInventory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductInInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductInInventory.FillColor = System.Drawing.Color.Transparent;
            this.btnProductInInventory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductInInventory.ForeColor = System.Drawing.Color.Black;
            this.btnProductInInventory.ImageOffset = new System.Drawing.Point(0, 5);
            this.btnProductInInventory.Location = new System.Drawing.Point(0, 165);
            this.btnProductInInventory.Name = "btnProductInInventory";
            this.btnProductInInventory.Size = new System.Drawing.Size(298, 55);
            this.btnProductInInventory.TabIndex = 8;
            this.btnProductInInventory.Text = "Product in Inventory";
            this.btnProductInInventory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProductInInventory.TextOffset = new System.Drawing.Point(70, -2);
            this.btnProductInInventory.Click += new System.EventHandler(this.btnProductInInventory_Click);
            // 
            // btnProductOnShelf
            // 
            this.btnProductOnShelf.BackColor = System.Drawing.Color.Transparent;
            this.btnProductOnShelf.BorderRadius = 25;
            this.btnProductOnShelf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductOnShelf.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProductOnShelf.CustomImages.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnProductOnShelf.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnProductOnShelf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductOnShelf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductOnShelf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductOnShelf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductOnShelf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductOnShelf.FillColor = System.Drawing.Color.Transparent;
            this.btnProductOnShelf.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductOnShelf.ForeColor = System.Drawing.Color.Black;
            this.btnProductOnShelf.ImageOffset = new System.Drawing.Point(0, 5);
            this.btnProductOnShelf.Location = new System.Drawing.Point(0, 110);
            this.btnProductOnShelf.Name = "btnProductOnShelf";
            this.btnProductOnShelf.Size = new System.Drawing.Size(298, 55);
            this.btnProductOnShelf.TabIndex = 7;
            this.btnProductOnShelf.Text = "Product on Shelf";
            this.btnProductOnShelf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProductOnShelf.TextOffset = new System.Drawing.Point(70, -2);
            this.btnProductOnShelf.Click += new System.EventHandler(this.btnProductOnShelf_Click);
            // 
            // btnManageProductType
            // 
            this.btnManageProductType.BackColor = System.Drawing.Color.Transparent;
            this.btnManageProductType.BorderRadius = 25;
            this.btnManageProductType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageProductType.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageProductType.CustomImages.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnManageProductType.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnManageProductType.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageProductType.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageProductType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageProductType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageProductType.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageProductType.FillColor = System.Drawing.Color.Transparent;
            this.btnManageProductType.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProductType.ForeColor = System.Drawing.Color.Black;
            this.btnManageProductType.ImageOffset = new System.Drawing.Point(0, 5);
            this.btnManageProductType.Location = new System.Drawing.Point(0, 55);
            this.btnManageProductType.Name = "btnManageProductType";
            this.btnManageProductType.Size = new System.Drawing.Size(298, 55);
            this.btnManageProductType.TabIndex = 6;
            this.btnManageProductType.Text = "Product Type";
            this.btnManageProductType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageProductType.TextOffset = new System.Drawing.Point(70, -2);
            this.btnManageProductType.Click += new System.EventHandler(this.btnManageProductType_Click);
            // 
            // btnManageProduct
            // 
            this.btnManageProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnManageProduct.BorderRadius = 25;
            this.btnManageProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageProduct.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageProduct.CustomImages.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnManageProduct.CustomImages.ImageSize = new System.Drawing.Size(30, 30);
            this.btnManageProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageProduct.FillColor = System.Drawing.Color.Transparent;
            this.btnManageProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageProduct.ForeColor = System.Drawing.Color.Black;
            this.btnManageProduct.ImageOffset = new System.Drawing.Point(0, 5);
            this.btnManageProduct.Location = new System.Drawing.Point(0, 0);
            this.btnManageProduct.Name = "btnManageProduct";
            this.btnManageProduct.Size = new System.Drawing.Size(298, 55);
            this.btnManageProduct.TabIndex = 5;
            this.btnManageProduct.Text = "Manage Product";
            this.btnManageProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageProduct.TextOffset = new System.Drawing.Point(70, -2);
            this.btnManageProduct.Click += new System.EventHandler(this.btnManageProduct_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.BorderRadius = 25;
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.CustomImages.Image = global::SupermarketManagementApp.Properties.Resources.black_product;
            this.btnProduct.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduct.CustomImages.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnProduct.CustomImages.ImageSize = new System.Drawing.Size(26, 26);
            this.btnProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FillColor = System.Drawing.Color.Transparent;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.Black;
            this.btnProduct.Image = global::SupermarketManagementApp.Properties.Resources.black_caret_down;
            this.btnProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnProduct.ImageOffset = new System.Drawing.Point(20, -1);
            this.btnProduct.ImageSize = new System.Drawing.Size(30, 30);
            this.btnProduct.Location = new System.Drawing.Point(0, 110);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(298, 55);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.Text = "Product";
            this.btnProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduct.TextOffset = new System.Drawing.Point(70, -2);
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnManageShelf
            // 
            this.btnManageShelf.BackColor = System.Drawing.Color.Transparent;
            this.btnManageShelf.BorderRadius = 25;
            this.btnManageShelf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageShelf.CustomImages.Image = global::SupermarketManagementApp.Properties.Resources.black_shelf;
            this.btnManageShelf.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageShelf.CustomImages.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnManageShelf.CustomImages.ImageSize = new System.Drawing.Size(26, 26);
            this.btnManageShelf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageShelf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageShelf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageShelf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageShelf.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageShelf.FillColor = System.Drawing.Color.Transparent;
            this.btnManageShelf.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageShelf.ForeColor = System.Drawing.Color.Black;
            this.btnManageShelf.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnManageShelf.ImageOffset = new System.Drawing.Point(0, 5);
            this.btnManageShelf.Location = new System.Drawing.Point(0, 55);
            this.btnManageShelf.Name = "btnManageShelf";
            this.btnManageShelf.Size = new System.Drawing.Size(298, 55);
            this.btnManageShelf.TabIndex = 2;
            this.btnManageShelf.Text = "Shelf";
            this.btnManageShelf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageShelf.TextOffset = new System.Drawing.Point(70, -2);
            this.btnManageShelf.Click += new System.EventHandler(this.btnManageShelf_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BorderRadius = 25;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.CustomImages.Image = global::SupermarketManagementApp.Properties.Resources.black_gauge;
            this.btnDashboard.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.CustomImages.ImageOffset = new System.Drawing.Point(20, 0);
            this.btnDashboard.CustomImages.ImageSize = new System.Drawing.Size(26, 26);
            this.btnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.ImageOffset = new System.Drawing.Point(0, 5);
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(298, 55);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDashboard.TextOffset = new System.Drawing.Point(70, -2);
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(315, 127);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(669, 718);
            this.panelChildForm.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(0)))), ((int)(((byte)(103)))));
            this.guna2Panel1.Controls.Add(this.labelVersion);
            this.guna2Panel1.Controls.Add(this.labelCopyright);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(315, 801);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(669, 44);
            this.guna2Panel1.TabIndex = 3;
            // 
            // labelVersion
            // 
            this.labelVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.White;
            this.labelVersion.Location = new System.Drawing.Point(563, 13);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(78, 19);
            this.labelVersion.TabIndex = 1;
            this.labelVersion.Text = "Version 1.0.0";
            // 
            // labelCopyright
            // 
            this.labelCopyright.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCopyright.BackColor = System.Drawing.Color.Transparent;
            this.labelCopyright.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.ForeColor = System.Drawing.Color.White;
            this.labelCopyright.Location = new System.Drawing.Point(20, 13);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(305, 19);
            this.labelCopyright.TabIndex = 0;
            this.labelCopyright.Text = "Copyright © 2023 by TBD Team. All rights reserved.";
            // 
            // msgBoxConfirm
            // 
            this.msgBoxConfirm.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.msgBoxConfirm.Caption = "Sign Out";
            this.msgBoxConfirm.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.msgBoxConfirm.Parent = this;
            this.msgBoxConfirm.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msgBoxConfirm.Text = "Are you sure you want to sign out?";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 845);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelMenuSidebar);
            this.Controls.Add(this.panelHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pro Market";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panelAccount.ResumeLayout(false);
            this.panelAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.panelMenuSidebar.ResumeLayout(false);
            this.panelSubInvoice.ResumeLayout(false);
            this.panelSubProduct.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private Guna.UI2.WinForms.Guna2Panel panelMenuSidebar;
        private Guna.UI2.WinForms.Guna2Panel panelAccount;
        private Guna.UI2.WinForms.Guna2CirclePictureBox avatar;
        private Guna.UI2.WinForms.Guna2HtmlLabel accountRole;
        private Guna.UI2.WinForms.Guna2HtmlLabel accountName;
        private Guna.UI2.WinForms.Guna2HtmlLabel quote;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel appName;
        private Guna.UI2.WinForms.Guna2Button btnDashboard;
        private Guna.UI2.WinForms.Guna2Button btnProduct;
        private Guna.UI2.WinForms.Guna2Button btnManageShelf;
        private Guna.UI2.WinForms.Guna2Button btnInvoice;
        private Guna.UI2.WinForms.Guna2Button btnManageCustomer;
        private Guna.UI2.WinForms.Guna2Button btnManageAccount;
        private Guna.UI2.WinForms.Guna2Button btnManageEmployee;
        private Guna.UI2.WinForms.Guna2Button btnStatistic;
        private Guna.UI2.WinForms.Guna2Panel panelSubInvoice;
        private Guna.UI2.WinForms.Guna2Button btnManageSupplierInvoice;
        private Guna.UI2.WinForms.Guna2Button btnManageCustomerInvoice;
        private Guna.UI2.WinForms.Guna2Panel panelSubProduct;
        private Guna.UI2.WinForms.Guna2Button btnProductOnShelf;
        private Guna.UI2.WinForms.Guna2Button btnManageProductType;
        private Guna.UI2.WinForms.Guna2Button btnManageProduct;
        private Guna.UI2.WinForms.Guna2Button btnProductInInventory;
        private Guna.UI2.WinForms.Guna2Panel panelChildForm;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelVersion;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelCopyright;
        private Guna.UI2.WinForms.Guna2ImageButton btnSignOut;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxConfirm;
    }
}

