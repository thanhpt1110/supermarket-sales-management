namespace SupermarketManagementApp.GUI.Invoice.SupplierInvoice
{
    partial class FormCreateSupplierInvoice
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
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.labelOrderInformation = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.borderLessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnCheckOut = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTotalAmount = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.msgBoxError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.panelCustomerInformation = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelCustomerName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtBoxCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelPhoneNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtBoxPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelForm = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelOrderInformation = new Guna.UI2.WinForms.Guna2Panel();
            this.labelCustomerInfor = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.availableCapacity = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelCustomerInformation.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.BorderThickness = 2;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.Location = new System.Drawing.Point(1150, 712);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 40);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextOffset = new System.Drawing.Point(0, -1);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // labelOrderInformation
            // 
            this.labelOrderInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelOrderInformation.BackColor = System.Drawing.Color.Transparent;
            this.labelOrderInformation.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderInformation.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelOrderInformation.Location = new System.Drawing.Point(78, 253);
            this.labelOrderInformation.Name = "labelOrderInformation";
            this.labelOrderInformation.Size = new System.Drawing.Size(179, 32);
            this.labelOrderInformation.TabIndex = 49;
            this.labelOrderInformation.Text = "Order Information";
            // 
            // borderLessForm
            // 
            this.borderLessForm.ContainerControl = this;
            this.borderLessForm.DockIndicatorTransparencyValue = 0.6D;
            this.borderLessForm.ResizeForm = false;
            this.borderLessForm.TransparentWhileDrag = true;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCheckOut.BorderRadius = 15;
            this.btnCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCheckOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCheckOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCheckOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.ForeColor = System.Drawing.Color.White;
            this.btnCheckOut.Location = new System.Drawing.Point(1310, 712);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(140, 40);
            this.btnCheckOut.TabIndex = 52;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.TextOffset = new System.Drawing.Point(0, -1);
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_ClickAsync);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.labelTotalAmount, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label, 0, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(46, 645);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(220, 40);
            this.tableLayoutPanel1.TabIndex = 51;
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAmount.ForeColor = System.Drawing.Color.Red;
            this.labelTotalAmount.Location = new System.Drawing.Point(144, 3);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(73, 34);
            this.labelTotalAmount.TabIndex = 26;
            this.labelTotalAmount.Text = "0 VNĐ";
            this.labelTotalAmount.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(3, 3);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(135, 32);
            this.label.TabIndex = 25;
            this.label.Text = "Total Amount:";
            this.label.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.Empty;
            this.btnAdd.BorderRadius = 15;
            this.btnAdd.BorderThickness = 2;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.Image = global::SupermarketManagementApp.Properties.Resources.add_product_invoice;
            this.btnAdd.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAdd.Location = new System.Drawing.Point(50, 712);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(49, 40);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.TextOffset = new System.Drawing.Point(0, -1);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // msgBoxError
            // 
            this.msgBoxError.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgBoxError.Caption = "Error";
            this.msgBoxError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.msgBoxError.Parent = null;
            this.msgBoxError.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msgBoxError.Text = "There were some errors, please try again later!";
            // 
            // panelCustomerInformation
            // 
            this.panelCustomerInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCustomerInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panelCustomerInformation.BorderColor = System.Drawing.Color.Black;
            this.panelCustomerInformation.Controls.Add(this.guna2HtmlLabel1);
            this.panelCustomerInformation.Controls.Add(this.labelCustomerName);
            this.panelCustomerInformation.Controls.Add(this.txtBoxCustomerName);
            this.panelCustomerInformation.Controls.Add(this.guna2HtmlLabel3);
            this.panelCustomerInformation.Controls.Add(this.labelPhoneNumber);
            this.panelCustomerInformation.Controls.Add(this.txtBoxPhoneNumber);
            this.panelCustomerInformation.Location = new System.Drawing.Point(50, 100);
            this.panelCustomerInformation.Name = "panelCustomerInformation";
            this.panelCustomerInformation.Size = new System.Drawing.Size(561, 115);
            this.panelCustomerInformation.TabIndex = 34;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(289, 24);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(10, 23);
            this.guna2HtmlLabel1.TabIndex = 12;
            this.guna2HtmlLabel1.Text = "*";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerName.Location = new System.Drawing.Point(244, 24);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(45, 23);
            this.labelCustomerName.TabIndex = 13;
            this.labelCustomerName.Text = "Name";
            // 
            // txtBoxCustomerName
            // 
            this.txtBoxCustomerName.BorderColor = System.Drawing.Color.Black;
            this.txtBoxCustomerName.BorderRadius = 5;
            this.txtBoxCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxCustomerName.DefaultText = "";
            this.txtBoxCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtBoxCustomerName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtBoxCustomerName.Location = new System.Drawing.Point(244, 55);
            this.txtBoxCustomerName.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxCustomerName.MaxLength = 0;
            this.txtBoxCustomerName.Name = "txtBoxCustomerName";
            this.txtBoxCustomerName.PasswordChar = '\0';
            this.txtBoxCustomerName.PlaceholderText = "";
            this.txtBoxCustomerName.SelectedText = "";
            this.txtBoxCustomerName.Size = new System.Drawing.Size(269, 36);
            this.txtBoxCustomerName.TabIndex = 2;
            this.txtBoxCustomerName.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(137, 24);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(10, 23);
            this.guna2HtmlLabel3.TabIndex = 7;
            this.guna2HtmlLabel3.Text = "*";
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhoneNumber.Location = new System.Drawing.Point(30, 24);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(106, 23);
            this.labelPhoneNumber.TabIndex = 10;
            this.labelPhoneNumber.Text = "Phone number";
            // 
            // txtBoxPhoneNumber
            // 
            this.txtBoxPhoneNumber.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBoxPhoneNumber.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBoxPhoneNumber.BorderColor = System.Drawing.Color.Black;
            this.txtBoxPhoneNumber.BorderRadius = 5;
            this.txtBoxPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxPhoneNumber.DefaultText = "";
            this.txtBoxPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtBoxPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtBoxPhoneNumber.Location = new System.Drawing.Point(30, 55);
            this.txtBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxPhoneNumber.MaxLength = 10;
            this.txtBoxPhoneNumber.Name = "txtBoxPhoneNumber";
            this.txtBoxPhoneNumber.PasswordChar = '\0';
            this.txtBoxPhoneNumber.PlaceholderText = "";
            this.txtBoxPhoneNumber.SelectedText = "";
            this.txtBoxPhoneNumber.Size = new System.Drawing.Size(155, 36);
            this.txtBoxPhoneNumber.TabIndex = 1;
            this.txtBoxPhoneNumber.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // labelForm
            // 
            this.labelForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelForm.BackColor = System.Drawing.Color.Transparent;
            this.labelForm.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelForm.Location = new System.Drawing.Point(510, 30);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(301, 39);
            this.labelForm.TabIndex = 33;
            this.labelForm.Text = "Create Supplier Invoice";
            // 
            // panelOrderInformation
            // 
            this.panelOrderInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOrderInformation.AutoScroll = true;
            this.panelOrderInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panelOrderInformation.BorderColor = System.Drawing.Color.Black;
            this.panelOrderInformation.Location = new System.Drawing.Point(50, 274);
            this.panelOrderInformation.MinimumSize = new System.Drawing.Size(1000, 0);
            this.panelOrderInformation.Name = "panelOrderInformation";
            this.panelOrderInformation.Padding = new System.Windows.Forms.Padding(20, 20, 30, 10);
            this.panelOrderInformation.Size = new System.Drawing.Size(1400, 350);
            this.panelOrderInformation.TabIndex = 48;
            // 
            // labelCustomerInfor
            // 
            this.labelCustomerInfor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCustomerInfor.BackColor = System.Drawing.Color.Transparent;
            this.labelCustomerInfor.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerInfor.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelCustomerInfor.Location = new System.Drawing.Point(78, 80);
            this.labelCustomerInfor.Name = "labelCustomerInfor";
            this.labelCustomerInfor.Size = new System.Drawing.Size(201, 32);
            this.labelCustomerInfor.TabIndex = 35;
            this.labelCustomerInfor.Text = "Supplier Information";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.Controls.Add(this.availableCapacity);
            this.guna2Panel1.Location = new System.Drawing.Point(689, 100);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(761, 115);
            this.guna2Panel1.TabIndex = 35;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.DarkOrange;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(728, 80);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(183, 32);
            this.guna2HtmlLabel2.TabIndex = 54;
            this.guna2HtmlLabel2.Text = "Inventory Capacity";
            // 
            // availableCapacity
            // 
            this.availableCapacity.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.availableCapacity.BorderRadius = 15;
            this.availableCapacity.BorderThickness = 1;
            this.availableCapacity.FillColor = System.Drawing.Color.DarkGray;
            this.availableCapacity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableCapacity.ForeColor = System.Drawing.Color.White;
            this.availableCapacity.Location = new System.Drawing.Point(39, 39);
            this.availableCapacity.Name = "availableCapacity";
            this.availableCapacity.ProgressColor = System.Drawing.Color.ForestGreen;
            this.availableCapacity.ProgressColor2 = System.Drawing.Color.ForestGreen;
            this.availableCapacity.ShowText = true;
            this.availableCapacity.Size = new System.Drawing.Size(681, 52);
            this.availableCapacity.TabIndex = 15;
            this.availableCapacity.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            this.availableCapacity.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // FormCreateSupplierInvoice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.labelCustomerInfor);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelOrderInformation);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panelCustomerInformation);
            this.Controls.Add(this.labelForm);
            this.Controls.Add(this.panelOrderInformation);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCreateSupplierInvoice";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCreateSupplierInvoice";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelCustomerInformation.ResumeLayout(false);
            this.panelCustomerInformation.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelOrderInformation;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderLessForm;
        private Guna.UI2.WinForms.Guna2Button btnCheckOut;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelTotalAmount;
        private Guna.UI2.WinForms.Guna2HtmlLabel label;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Panel panelCustomerInformation;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelCustomerName;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxCustomerName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxPhoneNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelForm;
        private Guna.UI2.WinForms.Guna2Panel panelOrderInformation;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelCustomerInfor;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxError;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ProgressBar availableCapacity;
    }
}