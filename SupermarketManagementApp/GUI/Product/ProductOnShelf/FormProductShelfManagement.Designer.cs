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
            this.btnExportExcel = new Guna.UI2.WinForms.Guna2Button();
            this.msgBoxInfo = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgBoxDelete = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgBoxError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.txtBoxSearchProduct = new Guna.UI2.WinForms.Guna2TextBox();
            this.shelfCapacity = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowPanel1.SuspendLayout();
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
            this.btnExportExcel.Location = new System.Drawing.Point(767, 35);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(169, 45);
            this.btnExportExcel.TabIndex = 16;
            this.btnExportExcel.Text = "Export Excel";
            this.btnExportExcel.TextOffset = new System.Drawing.Point(0, -1);
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
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2ShadowPanel1.Controls.Add(this.shelfCapacity);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(45, 132);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Radius = 20;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 255;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(903, 108);
            this.guna2ShadowPanel1.TabIndex = 17;
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
            this.txtBoxSearchProduct.TabIndex = 15;
            this.txtBoxSearchProduct.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // shelfCapacity
            // 
            this.shelfCapacity.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.shelfCapacity.BorderRadius = 15;
            this.shelfCapacity.BorderThickness = 1;
            this.shelfCapacity.FillColor = System.Drawing.Color.Gray;
            this.shelfCapacity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shelfCapacity.ForeColor = System.Drawing.Color.White;
            this.shelfCapacity.Location = new System.Drawing.Point(60, 70);
            this.shelfCapacity.Name = "shelfCapacity";
            this.shelfCapacity.ProgressColor = System.Drawing.Color.ForestGreen;
            this.shelfCapacity.ProgressColor2 = System.Drawing.Color.ForestGreen;
            this.shelfCapacity.ShowText = true;
            this.shelfCapacity.Size = new System.Drawing.Size(785, 22);
            this.shelfCapacity.TabIndex = 19;
            this.shelfCapacity.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            this.shelfCapacity.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(379, 25);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(127, 23);
            this.guna2HtmlLabel1.TabIndex = 20;
            this.guna2HtmlLabel1.Text = "guna2HtmlLabel1";
            // 
            // FormProductShelfManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.txtBoxSearchProduct);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormProductShelfManagement";
            this.Text = "FormProductShelfManagement";
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtBoxSearchProduct;
        private Guna.UI2.WinForms.Guna2Button btnExportExcel;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxInfo;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxDelete;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxError;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI2.WinForms.Guna2ProgressBar shelfCapacity;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}