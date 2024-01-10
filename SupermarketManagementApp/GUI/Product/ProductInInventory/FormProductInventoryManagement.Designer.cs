namespace SupermarketManagementApp.GUI.Product.ProductInInventory
{
    partial class FormProductInventoryManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBoxSearchProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnExportExcel = new Guna.UI2.WinForms.Guna2Button();
            this.msgBoxInfo = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgBoxDelete = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgBoxError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.scrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.gridViewMain = new Guna.UI2.WinForms.Guna2DataGridView();
            this.availableCapacity = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxSearchProduct
            // 
            this.txtBoxSearchProduct.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxSearchProduct.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBoxSearchProduct.BorderRadius = 5;
            this.txtBoxSearchProduct.BorderThickness = 2;
            this.txtBoxSearchProduct.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSearchProduct.DefaultText = "";
            this.txtBoxSearchProduct.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxSearchProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxSearchProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxSearchProduct.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxSearchProduct.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtBoxSearchProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchProduct.ForeColor = System.Drawing.Color.Black;
            this.txtBoxSearchProduct.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtBoxSearchProduct.IconRight = global::SupermarketManagementApp.Properties.Resources.silver_search;
            this.txtBoxSearchProduct.IconRightOffset = new System.Drawing.Point(15, -1);
            this.txtBoxSearchProduct.IconRightSize = new System.Drawing.Size(25, 25);
            this.txtBoxSearchProduct.Location = new System.Drawing.Point(45, 35);
            this.txtBoxSearchProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxSearchProduct.Name = "txtBoxSearchProduct";
            this.txtBoxSearchProduct.PasswordChar = '\0';
            this.txtBoxSearchProduct.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBoxSearchProduct.PlaceholderText = "Enter product name";
            this.txtBoxSearchProduct.SelectedText = "";
            this.txtBoxSearchProduct.Size = new System.Drawing.Size(285, 45);
            this.txtBoxSearchProduct.TabIndex = 8;
            this.txtBoxSearchProduct.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportExcel.BorderRadius = 15;
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportExcel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportExcel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportExcel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportExcel.FillColor = System.Drawing.Color.Orange;
            this.btnExportExcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExportExcel.Location = new System.Drawing.Point(771, 35);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(169, 45);
            this.btnExportExcel.TabIndex = 10;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.TextOffset = new System.Drawing.Point(0, -1);
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // msgBoxInfo
            // 
            this.msgBoxInfo.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgBoxInfo.Caption = "Information";
            this.msgBoxInfo.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.msgBoxInfo.Parent = null;
            this.msgBoxInfo.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msgBoxInfo.Text = "Create account successfully!";
            // 
            // msgBoxDelete
            // 
            this.msgBoxDelete.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.msgBoxDelete.Caption = "Delete File";
            this.msgBoxDelete.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.msgBoxDelete.Parent = null;
            this.msgBoxDelete.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msgBoxDelete.Text = "Are you sure you want to delete this file?";
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
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.scrollBar);
            this.guna2ShadowPanel1.Controls.Add(this.gridViewMain);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(45, 130);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 20;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 255;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(903, 535);
            this.guna2ShadowPanel1.TabIndex = 11;
            // 
            // scrollBar
            // 
            this.scrollBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scrollBar.FillColor = System.Drawing.Color.White;
            this.scrollBar.InUpdate = false;
            this.scrollBar.LargeChange = 10;
            this.scrollBar.Location = new System.Drawing.Point(863, 53);
            this.scrollBar.Minimum = 1;
            this.scrollBar.MouseWheelBarPartitions = 15;
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.ScrollbarSize = 17;
            this.scrollBar.Size = new System.Drawing.Size(17, 447);
            this.scrollBar.SmallChange = 2;
            this.scrollBar.TabIndex = 1;
            this.scrollBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.scrollBar.Value = 1;
            this.scrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBar_Scroll);
            // 
            // gridViewMain
            // 
            this.gridViewMain.AllowUserToAddRows = false;
            this.gridViewMain.AllowUserToDeleteRows = false;
            this.gridViewMain.AllowUserToResizeColumns = false;
            this.gridViewMain.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gridViewMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridViewMain.ColumnHeadersHeight = 50;
            this.gridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.icon,
            this.ProductName,
            this.Capacity,
            this.ProductCapacity,
            this.TotalCapacity});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewMain.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridViewMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridViewMain.Location = new System.Drawing.Point(28, 3);
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.ReadOnly = true;
            this.gridViewMain.RowHeadersVisible = false;
            this.gridViewMain.RowTemplate.DividerHeight = 1;
            this.gridViewMain.RowTemplate.Height = 55;
            this.gridViewMain.RowTemplate.ReadOnly = true;
            this.gridViewMain.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewMain.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gridViewMain.Size = new System.Drawing.Size(821, 496);
            this.gridViewMain.TabIndex = 0;
            this.gridViewMain.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewMain.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gridViewMain.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gridViewMain.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gridViewMain.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gridViewMain.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gridViewMain.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridViewMain.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gridViewMain.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gridViewMain.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewMain.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gridViewMain.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewMain.ThemeStyle.HeaderStyle.Height = 50;
            this.gridViewMain.ThemeStyle.ReadOnly = true;
            this.gridViewMain.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gridViewMain.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridViewMain.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewMain.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridViewMain.ThemeStyle.RowsStyle.Height = 55;
            this.gridViewMain.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridViewMain.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gridViewMain.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewMain_CellMouseLeave);
            this.gridViewMain.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridViewMain_CellMouseMove);
            // 
            // availableCapacity
            // 
            this.availableCapacity.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.availableCapacity.BorderRadius = 15;
            this.availableCapacity.BorderThickness = 1;
            this.availableCapacity.FillColor = System.Drawing.Color.DarkGray;
            this.availableCapacity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableCapacity.ForeColor = System.Drawing.Color.White;
            this.availableCapacity.Location = new System.Drawing.Point(354, 35);
            this.availableCapacity.Name = "availableCapacity";
            this.availableCapacity.ProgressColor = System.Drawing.Color.ForestGreen;
            this.availableCapacity.ProgressColor2 = System.Drawing.Color.ForestGreen;
            this.availableCapacity.ShowText = true;
            this.availableCapacity.Size = new System.Drawing.Size(309, 45);
            this.availableCapacity.TabIndex = 14;
            this.availableCapacity.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            this.availableCapacity.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // icon
            // 
            this.icon.FillWeight = 50F;
            this.icon.HeaderText = "";
            this.icon.Image = global::SupermarketManagementApp.Properties.Resources.grid_invoice;
            this.icon.Name = "icon";
            this.icon.ReadOnly = true;
            this.icon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProductName
            // 
            this.ProductName.FillWeight = 200F;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Quantity";
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            // 
            // ProductCapacity
            // 
            this.ProductCapacity.FillWeight = 120F;
            this.ProductCapacity.HeaderText = "Capacity";
            this.ProductCapacity.Name = "ProductCapacity";
            this.ProductCapacity.ReadOnly = true;
            // 
            // TotalCapacity
            // 
            this.TotalCapacity.FillWeight = 130F;
            this.TotalCapacity.HeaderText = "Total Capacity";
            this.TotalCapacity.Name = "TotalCapacity";
            this.TotalCapacity.ReadOnly = true;
            // 
            // FormProductInventoryManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.availableCapacity);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.txtBoxSearchProduct);
            this.Controls.Add(this.btnExportExcel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormProductInventoryManagement";
            this.ShowInTaskbar = false;
            this.Text = "FormProductInventoryManagement";
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtBoxSearchProduct;
        private Guna.UI2.WinForms.Guna2Button btnExportExcel;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxInfo;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxDelete;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxError;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2VScrollBar scrollBar;
        private Guna.UI2.WinForms.Guna2DataGridView gridViewMain;
        private Guna.UI2.WinForms.Guna2ProgressBar availableCapacity;
        private System.Windows.Forms.DataGridViewImageColumn icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCapacity;
    }
}