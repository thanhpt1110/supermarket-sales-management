namespace SupermarketManagementApp.GUI.Account
{
    partial class FormCreateAccount
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
            this.borderLessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.labelForm = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtBoxUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelRequired1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelUsername = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelPassword = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelEmployeeID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cbBoxEmployeeID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbBoxRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelRole = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtBoxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // borderLessForm
            // 
            this.borderLessForm.ContainerControl = this;
            this.borderLessForm.DockIndicatorTransparencyValue = 0.6D;
            this.borderLessForm.ResizeForm = false;
            this.borderLessForm.TransparentWhileDrag = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BorderRadius = 15;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Silver;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(250, 530);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(140, 40);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BorderRadius = 15;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(410, 530);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelForm
            // 
            this.labelForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelForm.BackColor = System.Drawing.Color.Transparent;
            this.labelForm.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForm.Location = new System.Drawing.Point(200, 30);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(199, 39);
            this.labelForm.TabIndex = 5;
            this.labelForm.Text = "Create Account";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.cbBoxRole);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel1.Controls.Add(this.labelRole);
            this.guna2Panel1.Controls.Add(this.cbBoxEmployeeID);
            this.guna2Panel1.Controls.Add(this.labelRequired1);
            this.guna2Panel1.Controls.Add(this.txtBoxPassword);
            this.guna2Panel1.Controls.Add(this.labelUsername);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel1.Controls.Add(this.labelEmployeeID);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.labelPassword);
            this.guna2Panel1.Controls.Add(this.txtBoxUsername);
            this.guna2Panel1.Location = new System.Drawing.Point(50, 100);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(500, 400);
            this.guna2Panel1.TabIndex = 4;
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.BorderColor = System.Drawing.Color.Black;
            this.txtBoxUsername.BorderRadius = 5;
            this.txtBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxUsername.DefaultText = "";
            this.txtBoxUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxUsername.Location = new System.Drawing.Point(50, 230);
            this.txtBoxUsername.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.PasswordChar = '\0';
            this.txtBoxUsername.PlaceholderText = "";
            this.txtBoxUsername.SelectedText = "";
            this.txtBoxUsername.Size = new System.Drawing.Size(400, 36);
            this.txtBoxUsername.TabIndex = 2;
            this.txtBoxUsername.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // labelRequired1
            // 
            this.labelRequired1.BackColor = System.Drawing.Color.Transparent;
            this.labelRequired1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRequired1.ForeColor = System.Drawing.Color.Red;
            this.labelRequired1.Location = new System.Drawing.Point(124, 199);
            this.labelRequired1.Name = "labelRequired1";
            this.labelRequired1.Size = new System.Drawing.Size(10, 23);
            this.labelRequired1.TabIndex = 1;
            this.labelRequired1.Text = "*";
            // 
            // labelUsername
            // 
            this.labelUsername.BackColor = System.Drawing.Color.Transparent;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(50, 199);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(74, 23);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "Username";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(122, 297);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(10, 23);
            this.guna2HtmlLabel1.TabIndex = 4;
            this.guna2HtmlLabel1.Text = "*";
            // 
            // labelPassword
            // 
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(50, 297);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(70, 23);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(140, 21);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(10, 23);
            this.guna2HtmlLabel3.TabIndex = 7;
            this.guna2HtmlLabel3.Text = "*";
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.labelEmployeeID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmployeeID.Location = new System.Drawing.Point(50, 21);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(90, 23);
            this.labelEmployeeID.TabIndex = 10;
            this.labelEmployeeID.Text = "Employee ID";
            // 
            // cbBoxEmployeeID
            // 
            this.cbBoxEmployeeID.BackColor = System.Drawing.Color.Transparent;
            this.cbBoxEmployeeID.BorderColor = System.Drawing.Color.Black;
            this.cbBoxEmployeeID.BorderRadius = 5;
            this.cbBoxEmployeeID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBoxEmployeeID.DropDownHeight = 100;
            this.cbBoxEmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxEmployeeID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBoxEmployeeID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBoxEmployeeID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxEmployeeID.ForeColor = System.Drawing.Color.Black;
            this.cbBoxEmployeeID.IntegralHeight = false;
            this.cbBoxEmployeeID.ItemHeight = 30;
            this.cbBoxEmployeeID.Items.AddRange(new object[] {
            "NV001",
            "NV001",
            "NV001"});
            this.cbBoxEmployeeID.Location = new System.Drawing.Point(50, 50);
            this.cbBoxEmployeeID.Name = "cbBoxEmployeeID";
            this.cbBoxEmployeeID.Size = new System.Drawing.Size(400, 36);
            this.cbBoxEmployeeID.TabIndex = 1;
            this.cbBoxEmployeeID.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // cbBoxRole
            // 
            this.cbBoxRole.BackColor = System.Drawing.Color.Transparent;
            this.cbBoxRole.BorderColor = System.Drawing.Color.Black;
            this.cbBoxRole.BorderRadius = 5;
            this.cbBoxRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBoxRole.DropDownHeight = 100;
            this.cbBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBoxRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbBoxRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBoxRole.ForeColor = System.Drawing.Color.Black;
            this.cbBoxRole.IntegralHeight = false;
            this.cbBoxRole.ItemHeight = 30;
            this.cbBoxRole.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Employee"});
            this.cbBoxRole.Location = new System.Drawing.Point(50, 138);
            this.cbBoxRole.MaxDropDownItems = 5;
            this.cbBoxRole.Name = "cbBoxRole";
            this.cbBoxRole.Size = new System.Drawing.Size(400, 36);
            this.cbBoxRole.TabIndex = 4;
            this.cbBoxRole.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Red;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(84, 109);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(10, 23);
            this.guna2HtmlLabel4.TabIndex = 10;
            this.guna2HtmlLabel4.Text = "*";
            // 
            // labelRole
            // 
            this.labelRole.BackColor = System.Drawing.Color.Transparent;
            this.labelRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(50, 109);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(34, 23);
            this.labelRole.TabIndex = 9;
            this.labelRole.Text = "Role";
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BorderColor = System.Drawing.Color.Black;
            this.txtBoxPassword.BorderRadius = 5;
            this.txtBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxPassword.DefaultText = "";
            this.txtBoxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBoxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBoxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBoxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBoxPassword.IconRight = global::SupermarketManagementApp.Properties.Resources.hide_password;
            this.txtBoxPassword.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxPassword.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtBoxPassword.Location = new System.Drawing.Point(50, 328);
            this.txtBoxPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '●';
            this.txtBoxPassword.PlaceholderText = "";
            this.txtBoxPassword.SelectedText = "";
            this.txtBoxPassword.Size = new System.Drawing.Size(400, 36);
            this.txtBoxPassword.TabIndex = 3;
            this.txtBoxPassword.TextOffset = new System.Drawing.Point(5, 0);
            this.txtBoxPassword.UseSystemPasswordChar = true;
            // 
            // FormCreateAccount
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.labelForm);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pro Market";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm borderLessForm;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelForm;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxUsername;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelRequired1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelUsername;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelEmployeeID;
        private Guna.UI2.WinForms.Guna2TextBox txtBoxPassword;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelPassword;
        private Guna.UI2.WinForms.Guna2ComboBox cbBoxEmployeeID;
        private Guna.UI2.WinForms.Guna2ComboBox cbBoxRole;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelRole;
    }
}