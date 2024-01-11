namespace SupermarketManagementApp.GUI.Product.ProductOnShelf
{
    partial class FormProductShelfManagement
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
            this.msgBoxInfo = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgBoxDelete = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgBoxError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtBoxSearchShelf = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelShelfContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.filterFloor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
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
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.FillWeight = 50F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::SupermarketManagementApp.Properties.Resources.grid_invoice;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 68;
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
            this.txtBoxSearchShelf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxSearchShelf.Name = "txtBoxSearchShelf";
            this.txtBoxSearchShelf.PasswordChar = '\0';
            this.txtBoxSearchShelf.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtBoxSearchShelf.PlaceholderText = "Enter shelf type";
            this.txtBoxSearchShelf.SelectedText = "";
            this.txtBoxSearchShelf.Size = new System.Drawing.Size(285, 45);
            this.txtBoxSearchShelf.TabIndex = 15;
            this.txtBoxSearchShelf.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // panelShelfContainer
            // 
            this.panelShelfContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelShelfContainer.AutoScroll = true;
            this.panelShelfContainer.Location = new System.Drawing.Point(45, 136);
            this.panelShelfContainer.Name = "panelShelfContainer";
            this.panelShelfContainer.Size = new System.Drawing.Size(891, 535);
            this.panelShelfContainer.TabIndex = 19;
            // 
            // filterFloor
            // 
            this.filterFloor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.filterFloor.BackColor = System.Drawing.Color.Transparent;
            this.filterFloor.BorderColor = System.Drawing.Color.DarkGray;
            this.filterFloor.BorderRadius = 5;
            this.filterFloor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.filterFloor.DropDownHeight = 150;
            this.filterFloor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterFloor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.filterFloor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.filterFloor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterFloor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.filterFloor.IntegralHeight = false;
            this.filterFloor.ItemHeight = 30;
            this.filterFloor.Items.AddRange(new object[] {
            "Floor 1",
            "Floor 2",
            "Floor 3",
            "Floor 4",
            "Floor 5"});
            this.filterFloor.ItemsAppearance.ForeColor = System.Drawing.Color.Black;
            this.filterFloor.Location = new System.Drawing.Point(723, 44);
            this.filterFloor.MaxDropDownItems = 5;
            this.filterFloor.Name = "filterFloor";
            this.filterFloor.Size = new System.Drawing.Size(180, 36);
            this.filterFloor.TabIndex = 20;
            this.filterFloor.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // FormProductShelfManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.filterFloor);
            this.Controls.Add(this.panelShelfContainer);
            this.Controls.Add(this.txtBoxSearchShelf);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormProductShelfManagement";
            this.Text = "FormProductShelfManagement";
            this.Shown += new System.EventHandler(this.FormProductShelfManagement_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtBoxSearchShelf;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxInfo;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxDelete;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxError;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.FlowLayoutPanel panelShelfContainer;
        private Guna.UI2.WinForms.Guna2ComboBox filterFloor;
    }
}