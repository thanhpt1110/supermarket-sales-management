namespace SupermarketManagementApp.GUI.Product.ProductOnShelf
{
    partial class FormDetailProductOnShelf
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
            this.panelLayerContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.labelForm = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.shelfCapacity = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.borderLessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.msgBoxError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // panelLayerContainer
            // 
            this.panelLayerContainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLayerContainer.AutoScroll = true;
            this.panelLayerContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panelLayerContainer.Location = new System.Drawing.Point(50, 140);
            this.panelLayerContainer.Name = "panelLayerContainer";
            this.panelLayerContainer.Size = new System.Drawing.Size(900, 550);
            this.panelLayerContainer.TabIndex = 0;
            // 
            // labelForm
            // 
            this.labelForm.BackColor = System.Drawing.Color.Transparent;
            this.labelForm.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm.Location = new System.Drawing.Point(415, 30);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(154, 32);
            this.labelForm.TabIndex = 1;
            this.labelForm.Text = "Shelf 101 - Grain";
            // 
            // shelfCapacity
            // 
            this.shelfCapacity.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.shelfCapacity.BorderRadius = 15;
            this.shelfCapacity.BorderThickness = 1;
            this.shelfCapacity.FillColor = System.Drawing.Color.Gray;
            this.shelfCapacity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shelfCapacity.ForeColor = System.Drawing.Color.White;
            this.shelfCapacity.Location = new System.Drawing.Point(50, 80);
            this.shelfCapacity.Name = "shelfCapacity";
            this.shelfCapacity.ProgressColor = System.Drawing.Color.ForestGreen;
            this.shelfCapacity.ProgressColor2 = System.Drawing.Color.ForestGreen;
            this.shelfCapacity.ShowText = true;
            this.shelfCapacity.Size = new System.Drawing.Size(900, 30);
            this.shelfCapacity.TabIndex = 15;
            this.shelfCapacity.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            this.shelfCapacity.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.BorderRadius = 15;
            this.btnClose.BorderThickness = 2;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClose.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnClose.Location = new System.Drawing.Point(650, 725);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(140, 40);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.TextOffset = new System.Drawing.Point(0, -1);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BorderRadius = 15;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(810, 725);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 40);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextOffset = new System.Drawing.Point(0, -1);
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // borderLessForm
            // 
            this.borderLessForm.ContainerControl = this;
            this.borderLessForm.DockIndicatorTransparencyValue = 0.6D;
            this.borderLessForm.ResizeForm = false;
            this.borderLessForm.TransparentWhileDrag = true;
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
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(50, 17);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 18;
            this.guna2Button1.Text = "Add new line";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // FormDetailProductOnShelf
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.shelfCapacity);
            this.Controls.Add(this.labelForm);
            this.Controls.Add(this.panelLayerContainer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDetailProductOnShelf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDetailProductOnShelf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelLayerContainer;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelForm;
        private Guna.UI2.WinForms.Guna2ProgressBar shelfCapacity;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderLessForm;
        private Guna.UI2.WinForms.Guna2MessageDialog msgBoxError;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}