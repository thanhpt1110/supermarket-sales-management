using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementApp.GUI.Invoice.CustomerInvoice
{
    public partial class FormCreateCustomerInvoice : Form
    {
        public FormCreateCustomerInvoice()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel newLine = new FlowLayoutPanel();
            newLine.Dock = DockStyle.Top;

            newLine.Controls.Add(childPanelInput("Product Name", "txtProductName"));
            newLine.Controls.Add(childPanelInput("Product Name", "txtProductName"));
            newLine.Controls.Add(childPanelInput("Product Name", "txtProductName"));
            newLine.Controls.Add(childPanelInput("Product Name", "txtProductName"));

            panelOrderInformation.Controls.Add(newLine);
        }

        private Guna2Panel childPanelInput(string labelText, string controlName)
        {
            Guna2Panel currentPanel = new Guna2Panel();

            // Label for control
            Label labelControl = new Label();
            labelControl.Text = labelText;
            labelControl.BackColor = Color.Transparent;
            labelControl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            labelControl.Location = new Point(244, 24);
            labelControl.Name = "label" + controlName;
            labelControl.Size = new Size(45, 23);
            labelControl.TabIndex = 13;
            // currentPanel.Controls.Add(labelControl);

            // Label required field
            Guna2HtmlLabel labelRequired = new Guna2HtmlLabel();
            labelRequired.BackColor = Color.Transparent;
            labelRequired.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            labelRequired.ForeColor = Color.Red;
            labelRequired.Location = new Point(137, 24);
            labelRequired.Name = "labelRequired" + controlName;
            labelRequired.Size = new Size(10, 23);
            labelRequired.TabIndex = 7;
            labelRequired.Text = "*";
            currentPanel.Controls.Add(labelRequired);

            // Text box for input
            Guna2TextBox textBox = new Guna2TextBox();
            textBox.BorderColor = System.Drawing.Color.Black;
            textBox.BorderRadius = 5;
            textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            textBox.DefaultText = "";
            textBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            textBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            textBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            textBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            textBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            textBox.Location = new System.Drawing.Point(5, 34);
            textBox.Margin = new System.Windows.Forms.Padding(5);
            textBox.MaxLength = 10;
            textBox.Name = controlName;
            textBox.PasswordChar = '\0';
            textBox.PlaceholderText = "";
            textBox.SelectedText = "";
            textBox.Size = new System.Drawing.Size(155, 36);
            textBox.TabIndex = 12;
            textBox.TextOffset = new System.Drawing.Point(5, 0);
            currentPanel.Controls.Add(textBox);

            return currentPanel;
        }
    }
}
