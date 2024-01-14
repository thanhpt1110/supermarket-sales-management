namespace SupermarketManagementApp.GUI.Shelf
{
    partial class FormShelfManagement
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
            this.txtBoxSearchShelf = new Guna.UI2.WinForms.Guna2TextBox();
            this.scrollBar = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.gridViewMain = new Guna.UI2.WinForms.Guna2DataGridView();
            this.icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.ShelfName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShelfType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LayerQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.msgBoxError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.btnExportExcel = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreateShelf = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.msgBoxDelete = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.msgBoxInfo = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxSearchShelf
            // 
            this.txtBoxSearchShelf.BackColor = System.Drawing.Color.Transparent;
            this.txtBoxSearchShelf.BorderColor = System.Drawing.Color.DarkGray;
            this.txtBoxSearchShelf.BorderRadius = 5;
            this.txtBoxSearchShelf.BorderThickness = 2;
            this.txtBoxSearchShelf.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxSearchShelf.DefaultText = "";
            this.txtBoxSearchShelf.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxSearchShelf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxSearchShelf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxSearchShelf.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxSearchShelf.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtBoxSearchShelf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchShelf.ForeColor = System.Drawing.Color.Black;
            this.txtBoxSearchShelf.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtBoxSearchShelf.IconRight = global::SupermarketManagementApp.Properties.Resources.silver_search;
            this.txtBoxSearchShelf.IconRightOffset = new System.Drawing.Point(15, -1);
            this.txtBoxSearchShelf.IconRightSize = new System.Drawing.Size(25, 25);
            this.txtBoxSearchShelf.Location = new System.Drawing.Point(45, 35);
            this.txtBoxSearchShelf.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSearchShelf.Name = "txtBoxSearchShelf";
            this.txtBoxSearchShelf.PasswordChar = '\0';
            this.txtBoxSearchShelf.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBoxSearchShelf.PlaceholderText = "Enter shelf";
            this.txtBoxSearchShelf.SelectedText = "";
            this.txtBoxSearchShelf.Size = new System.Drawing.Size(285, 45);
            this.txtBoxSearchShelf.TabIndex = 10;
            this.txtBoxSearchShelf.TextOffset = new System.Drawing.Point(5, 0);
            this.txtBoxSearchShelf.TextChanged += new System.EventHandler(this.txtBoxSearchShelf_TextChanged);
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
            this.ShelfName,
            this.ShelfType,
            this.LayerQuantity,
            this.Capacity,
            this.Status,
            this.Delete});
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
            this.icon.Image = global::SupermarketManagementApp.Properties.Resources.grid_shelf;
            this.icon.MinimumWidth = 6;
            this.icon.Name = "icon";
            this.icon.ReadOnly = true;
            this.icon.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ShelfName
            // 
            this.ShelfName.FillWeight = 140F;
            this.ShelfName.HeaderText = "Shelf Name";
            this.ShelfName.MinimumWidth = 6;
            this.ShelfName.Name = "ShelfName";
            this.ShelfName.ReadOnly = true;
            // 
            // ShelfType
            // 
            this.ShelfType.HeaderText = "Type";
            this.ShelfType.MinimumWidth = 6;
            this.ShelfType.Name = "ShelfType";
            this.ShelfType.ReadOnly = true;
            // 
            // LayerQuantity
            // 
            this.LayerQuantity.FillWeight = 140F;
            this.LayerQuantity.HeaderText = "Layer Quantity ";
            this.LayerQuantity.MinimumWidth = 6;
            this.LayerQuantity.Name = "LayerQuantity";
            this.LayerQuantity.ReadOnly = true;
            // 
            // Capacity
            // 
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.MinimumWidth = 6;
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.FillWeight = 140F;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Image = global::SupermarketManagementApp.Properties.Resources.grid_delete;
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.btnExportExcel.TabIndex = 11;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.TextOffset = new System.Drawing.Point(0, -1);
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnCreateShelf
            // 
            this.btnCreateShelf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateShelf.BorderRadius = 15;
            this.btnCreateShelf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateShelf.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateShelf.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateShelf.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateShelf.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateShelf.FillColor = System.Drawing.Color.ForestGreen;
            this.btnCreateShelf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateShelf.ForeColor = System.Drawing.Color.White;
            this.btnCreateShelf.Location = new System.Drawing.Point(760, 35);
            this.btnCreateShelf.Name = "btnCreateShelf";
            this.btnCreateShelf.Size = new System.Drawing.Size(180, 45);
            this.btnCreateShelf.TabIndex = 9;
            this.btnCreateShelf.Text = "Create Shelf";
            this.btnCreateShelf.TextOffset = new System.Drawing.Point(0, -1);
            this.btnCreateShelf.Click += new System.EventHandler(this.btnCreateShelf_Click);
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
            // msgBoxDelete
            // 
            this.msgBoxDelete.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.msgBoxDelete.Caption = "Delete File";
            this.msgBoxDelete.Icon = Guna.UI2.WinForms.MessageDialogIcon.Warning;
            this.msgBoxDelete.Parent = null;
            this.msgBoxDelete.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.msgBoxDelete.Text = "Are you sure you want to delete this file?";
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
            this.guna2ShadowPanel1.TabIndex = 12;
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
            // FormShelfManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.txtBoxSearchShelf);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnCreateShelf);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormShelfManagement";
            this.Text = "FormShelfManagement";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMain)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtBoxSearchShelf;
        private Guna.UI2.WinForms.Guna2VScrollBar scrollBar;
        private Guna.UI2.WinForms.Guna2DataGridView gridViewMain;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxError;
        private Guna.UI2.WinForms.Guna2Button btnExportExcel;
        private Guna.UI2.WinForms.Guna2Button btnCreateShelf;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxDelete;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxInfo;
        private System.Windows.Forms.DataGridViewImageColumn icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShelfName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShelfType;
        private System.Windows.Forms.DataGridViewTextBoxColumn LayerQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}