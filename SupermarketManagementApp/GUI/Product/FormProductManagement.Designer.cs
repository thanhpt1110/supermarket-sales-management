﻿namespace SupermarketManagementApp.GUI.Product
{
    partial class FormProductManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExportExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreateProduct = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.scrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.gridViewMain = new Guna.UI2.WinForms.Guna2DataGridView();
            this.icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WholeSaleUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetailUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitConversion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Info = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtBoxSearchProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.msgBoxError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgBoxDelete = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgBoxInfo = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            this.SuspendLayout();
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
            this.btnExportExcel.Location = new System.Drawing.Point(570, 35);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(169, 45);
            this.btnExportExcel.TabIndex = 7;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.TextOffset = new System.Drawing.Point(0, -1);
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateProduct.BorderRadius = 15;
            this.btnCreateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateProduct.FillColor = System.Drawing.Color.ForestGreen;
            this.btnCreateProduct.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateProduct.ForeColor = System.Drawing.Color.White;
            this.btnCreateProduct.Location = new System.Drawing.Point(760, 35);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(180, 45);
            this.btnCreateProduct.TabIndex = 6;
            this.btnCreateProduct.Text = "Create Product";
            this.btnCreateProduct.TextOffset = new System.Drawing.Point(0, -1);
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
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
            this.guna2ShadowPanel1.TabIndex = 8;
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
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gridViewMain.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridViewMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridViewMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridViewMain.ColumnHeadersHeight = 50;
            this.gridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.icon,
            this.ProductID,
            this.ProductName,
            this.ProductType,
            this.UnitPrice,
            this.WholeSaleUnit,
            this.RetailUnit,
            this.UnitConversion,
            this.Info,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewMain.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridViewMain.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gridViewMain.Location = new System.Drawing.Point(28, 3);
            this.gridViewMain.Name = "gridViewMain";
            this.gridViewMain.ReadOnly = true;
            this.gridViewMain.RowHeadersVisible = false;
            this.gridViewMain.RowHeadersWidth = 51;
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
            this.gridViewMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewMain_CellClick);
            this.gridViewMain.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewMain_CellMouseLeave);
            this.gridViewMain.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridViewMain_CellMouseMove);
            // 
            // icon
            // 
            this.icon.FillWeight = 50F;
            this.icon.HeaderText = "";
            this.icon.Image = global::SupermarketManagementApp.Properties.Resources.grid_product;
            this.icon.MinimumWidth = 6;
            this.icon.Name = "icon";
            this.icon.ReadOnly = true;
            this.icon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.MinimumWidth = 6;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.FillWeight = 150F;
            this.ProductName.HeaderText = "Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // ProductType
            // 
            this.ProductType.FillWeight = 110F;
            this.ProductType.HeaderText = "Type";
            this.ProductType.MinimumWidth = 6;
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.MinimumWidth = 6;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // WholeSaleUnit
            // 
            this.WholeSaleUnit.FillWeight = 120F;
            this.WholeSaleUnit.HeaderText = "Wholesale Unit";
            this.WholeSaleUnit.MinimumWidth = 6;
            this.WholeSaleUnit.Name = "WholeSaleUnit";
            this.WholeSaleUnit.ReadOnly = true;
            // 
            // RetailUnit
            // 
            this.RetailUnit.HeaderText = "Retail Unit";
            this.RetailUnit.MinimumWidth = 6;
            this.RetailUnit.Name = "RetailUnit";
            this.RetailUnit.ReadOnly = true;
            // 
            // UnitConversion
            // 
            this.UnitConversion.HeaderText = "Conversion";
            this.UnitConversion.MinimumWidth = 6;
            this.UnitConversion.Name = "UnitConversion";
            this.UnitConversion.ReadOnly = true;
            // 
            // Info
            // 
            this.Info.FillWeight = 70F;
            this.Info.HeaderText = "";
            this.Info.Image = global::SupermarketManagementApp.Properties.Resources.grid_info;
            this.Info.MinimumWidth = 6;
            this.Info.Name = "Info";
            this.Info.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 50F;
            this.Edit.HeaderText = "";
            this.Edit.Image = global::SupermarketManagementApp.Properties.Resources.grid_edit;
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 50F;
            this.Delete.HeaderText = "";
            this.Delete.Image = global::SupermarketManagementApp.Properties.Resources.grid_delete;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::SupermarketManagementApp.Properties.Resources.grid_account;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 71;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::SupermarketManagementApp.Properties.Resources.grid_edit;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.Width = 139;
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::SupermarketManagementApp.Properties.Resources.grid_delete;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn3.Width = 139;
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
            this.txtBoxSearchProduct.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSearchProduct.Name = "txtBoxSearchProduct";
            this.txtBoxSearchProduct.PasswordChar = '\0';
            this.txtBoxSearchProduct.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBoxSearchProduct.PlaceholderText = "Enter product";
            this.txtBoxSearchProduct.SelectedText = "";
            this.txtBoxSearchProduct.Size = new System.Drawing.Size(285, 45);
            this.txtBoxSearchProduct.TabIndex = 7;
            this.txtBoxSearchProduct.TextOffset = new System.Drawing.Point(5, 0);
            this.txtBoxSearchProduct.TextChanged += new System.EventHandler(this.txtBoxSearchProduct_TextChanged);
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
            // msgBoxDelete
            // 
            this.msgBoxDelete.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.msgBoxDelete.Caption = "Delete File";
            this.msgBoxDelete.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.msgBoxDelete.Parent = null;
            this.msgBoxDelete.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msgBoxDelete.Text = "Are you sure you want to delete this file?";
            // 
            // msgBoxInfo
            // 
            this.msgBoxInfo.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgBoxInfo.Caption = "Information";
            this.msgBoxInfo.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.msgBoxInfo.Parent = null;
            this.msgBoxInfo.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msgBoxInfo.Text = "Create Product successfully!";
            // 
            // FormProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.txtBoxSearchProduct);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnCreateProduct);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FormProductManagement";
            this.Text = "FormProductManagement";
            this.guna2ShadowPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI2.WinForms.Guna2Button btnExportExcel;
        private Guna.UI2.WinForms.Guna2Button btnCreateProduct;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2VScrollBar scrollBar;
        private Guna.UI2.WinForms.Guna2DataGridView gridViewMain;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxSearchProduct;
        private System.Windows.Forms.DataGridViewImageColumn icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn WholeSaleUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetailUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitConversion;
        private System.Windows.Forms.DataGridViewImageColumn Info;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxError;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxDelete;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxInfo;
    }
}