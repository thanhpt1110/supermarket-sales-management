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
        List<string> productNames = new List<string>()
        {
            "abc xyz",
            "abc ",
            "dsa",
            // Thêm tên sản phẩm khác vào đây
        };

        public FormCreateCustomerInvoice()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel newLine = new FlowLayoutPanel();
            newLine.Dock = DockStyle.Top;

            newLine.Controls.Add(panelProductName("Product Name", "txtProductName", newLine));
            newLine.Controls.Add(panelQuantity("Quantity", "txtQuantity", newLine));
            newLine.Controls.Add(panelUnitPrice("Unit Price", "txtUnitPrice", newLine));
            newLine.Controls.Add(panelTotalPrice("Total Price", "txtTotalPrice", newLine));
            
            newLine.Controls.Add(buttonRemoveProduct(newLine));
            panelOrderInformation.Controls.Add(newLine);
        }

        private Guna2Panel panelProductName(string labelText, string controlName, FlowLayoutPanel currentLine)
        {
            Guna2Panel currentPanel = new Guna2Panel();
            currentPanel.Dock = DockStyle.Bottom;
            currentPanel.Size = new Size(270, 100);
            currentPanel.Name = "panelProductName";

            // Label for control
            Label labelControl = new Label();
            labelControl.AutoSize = true;
            labelControl.Text = labelText;
            labelControl.BackColor = Color.Transparent;
            labelControl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            labelControl.Location = new Point(3, 3);
            labelControl.Name = "label" + controlName;
            labelControl.TabIndex = 13;
            currentPanel.Controls.Add(labelControl);

            // Label required field
            Guna2HtmlLabel labelRequired = new Guna2HtmlLabel();
            labelRequired.AutoSize = true;
            labelRequired.BackColor = Color.Transparent;
            labelRequired.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            labelRequired.ForeColor = Color.Red;
            labelRequired.Location = new Point(labelControl.Location.X + labelControl.Width + 3, 3);
            labelRequired.Name = "labelRequired" + controlName;
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
            textBox.Margin = new System.Windows.Forms.Padding(5);
            textBox.MaxLength = 10;
            textBox.Location = new Point(5, 34);
            textBox.Name = controlName;
            textBox.PasswordChar = '\0';
            textBox.PlaceholderText = "";
            textBox.SelectedText = "";
            textBox.Size = new System.Drawing.Size(220, 36);
            textBox.TabIndex = 12;
            textBox.TextOffset = new System.Drawing.Point(5, 0);

            textBox.AutoCompleteCustomSource.AddRange(productNames.ToArray());
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBox.TextChanged += (sender, e) =>
            {
                foreach (Control control in currentLine.Controls)
                {
                    if (control.Name == "panelUnitPrice")
                    {
                        foreach (Control control2 in control.Controls)
                        {
                            if (control2.Name == "txtUnitPrice")
                            {
                                // control2.Text = textBox.Text;
                                return;
                            }
                        }
                    }
                }
            };

            currentPanel.Controls.Add(textBox);

            return currentPanel;
        }

        private Guna2Panel panelQuantity(string labelText, string controlName, FlowLayoutPanel currentLine)
        {
            Guna2Panel currentPanel = new Guna2Panel();
            currentPanel.Dock = DockStyle.Bottom;
            currentPanel.Size = new Size(150, 100);
            currentPanel.Name = "panelQuantity";

            // Label for control
            Label labelControl = new Label();
            labelControl.AutoSize = true;
            labelControl.Text = labelText;
            labelControl.BackColor = Color.Transparent;
            labelControl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            labelControl.Location = new Point(3, 3);
            labelControl.Name = "label" + controlName;
            labelControl.TabIndex = 13;
            currentPanel.Controls.Add(labelControl);

            // Label required field
            Guna2HtmlLabel labelRequired = new Guna2HtmlLabel();
            labelRequired.AutoSize = true;
            labelRequired.BackColor = Color.Transparent;
            labelRequired.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            labelRequired.ForeColor = Color.Red;
            labelRequired.Location = new Point(labelControl.Location.X + labelControl.Width + 3, 3);
            labelRequired.Name = "labelRequired" + controlName;
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
            textBox.Margin = new System.Windows.Forms.Padding(5);
            textBox.MaxLength = 10;
            textBox.Location = new Point(5, 34);
            textBox.Name = controlName;
            textBox.PasswordChar = '\0';
            textBox.PlaceholderText = "";
            textBox.SelectedText = "";
            textBox.Size = new System.Drawing.Size(100, 36);
            textBox.TabIndex = 12;
            textBox.Text = "0";
            textBox.TextOffset = new System.Drawing.Point(5, 0);

            textBox.TextChanged += (sender, e) =>
            {
                Control unitPrice = new Control();
                Control totalPrice = new Control();

                if (textBox.Text == String.Empty)
                {
                    textBox.Text = "0";
                }

                foreach (Control control in currentLine.Controls)
                {
                    if (control.Name == "panelTotalPrice")
                    {
                        foreach (Control control2 in control.Controls)
                        {
                            if (control2.Name == "txtTotalPrice")
                            {
                                totalPrice = control2;
                                break;
                            }
                        }
                    }
                }

                foreach (Control control in currentLine.Controls)
                {
                    if (control.Name == "panelUnitPrice")
                    {
                        foreach (Control control2 in control.Controls)
                        {
                            if (control2.Name == "txtUnitPrice")
                            {
                                unitPrice = control2;
                                break;
                            }
                        }
                    }
                }

                double unitPriceValue, quantityValue;

                // Kiểm tra xem các giá trị có thể chuyển đổi thành double không
                if (double.TryParse(unitPrice.Text, out unitPriceValue) && double.TryParse(textBox.Text, out quantityValue))
                {
                    // Thực hiện phép nhân và cập nhật giá trị cho totalPrice
                    totalPrice.Text = (unitPriceValue * quantityValue).ToString();
                }
                else
                {
                    // Xử lý trường hợp không thể chuyển đổi giá trị
                    msgBoxError.Parent = this;
                    msgBoxError.Show("Please enter number only!");
                }
            };

            currentPanel.Controls.Add(textBox);
            return currentPanel;
        }

        private Guna2Panel panelUnitPrice(string labelText, string controlName, FlowLayoutPanel currentLine)
        {
            Guna2Panel currentPanel = new Guna2Panel();
            currentPanel.Dock = DockStyle.Bottom;
            currentPanel.Name = "panelUnitPrice";

            // Label for control
            Label labelControl = new Label();
            labelControl.AutoSize = true;
            labelControl.Text = labelText;
            labelControl.BackColor = Color.Transparent;
            labelControl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            labelControl.Location = new Point(3, 3);
            labelControl.Name = "label" + controlName;
            labelControl.TabIndex = 13;
            currentPanel.Controls.Add(labelControl);

            // Text box for input
            Guna2TextBox textBox = new Guna2TextBox();
            textBox.BorderColor = Color.Black;
            textBox.BorderRadius = 5;
            textBox.DefaultText = "";
            textBox.DisabledState.BorderColor = System.Drawing.Color.Black;
            textBox.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke;
            textBox.DisabledState.ForeColor = System.Drawing.Color.Black;
            textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            textBox.Enabled = false;
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
            textBox.TabIndex = 15;
            textBox.Text = "5000";
            textBox.TextOffset = new System.Drawing.Point(5, 0);
            currentPanel.Controls.Add(textBox);

            return currentPanel;
        }

        private Guna2Panel panelTotalPrice(string labelText, string controlName, FlowLayoutPanel currentLine)
        {
            Guna2Panel currentPanel = new Guna2Panel();
            currentPanel.Dock = DockStyle.Bottom;
            currentPanel.Name = "panelTotalPrice";

            // Label for control
            Label labelControl = new Label();
            labelControl.AutoSize = true;
            labelControl.Text = labelText;
            labelControl.BackColor = Color.Transparent;
            labelControl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            labelControl.Location = new Point(3, 3);
            labelControl.Name = "label" + controlName;
            labelControl.TabIndex = 13;
            currentPanel.Controls.Add(labelControl);

            // Text box for input
            Guna2TextBox textBox = new Guna2TextBox();
            textBox.BorderColor = Color.Black;
            textBox.BorderRadius = 5;
            textBox.DefaultText = "";
            textBox.DisabledState.BorderColor = System.Drawing.Color.Black;
            textBox.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke;
            textBox.DisabledState.ForeColor = System.Drawing.Color.Black;
            textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            textBox.Enabled = false;
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
            textBox.TabIndex = 15;
            textBox.Text = "0";
            textBox.TextOffset = new System.Drawing.Point(5, 0);
            currentPanel.Controls.Add(textBox);

            textBox.TextChanged += (sender, e) =>
            {
                double totalAmount = 0;

                foreach (FlowLayoutPanel line in panelOrderInformation.Controls)
                {
                    foreach (Control control in line.Controls)
                    {
                        if (control.Name == "panelTotalPrice")
                        {
                            foreach (Control control2 in control.Controls)
                            {
                                if (control2.Name == "txtTotalPrice")
                                {
                                    double value;
                                    if (double.TryParse(control2.Text, out value))
                                    {
                                        totalAmount += value;
                                    }   
                                    break;
                                }
                            }
                        }
                    }
                }

                // Đặt văn hóa phù hợp
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");

                // Định dạng số thành chuỗi theo định dạng tiền tệ
                labelTotalAmount.RightToLeft = RightToLeft.Yes;
                labelTotalAmount.Text = totalAmount.ToString("N0", culture) + " VND";
            };

            return currentPanel;
        }

        private Guna2Button buttonRemoveProduct(FlowLayoutPanel lineToRemove)
        {
            Guna2Button buttonRemove = new Guna2Button();

            buttonRemove.BackColor = System.Drawing.Color.Transparent;
            buttonRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            buttonRemove.DefaultAutoSize = true;
            buttonRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            buttonRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            buttonRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            buttonRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            buttonRemove.FillColor = System.Drawing.Color.Transparent;
            buttonRemove.Font = new System.Drawing.Font("Segoe UI", 9F);
            buttonRemove.ForeColor = System.Drawing.Color.White;
            buttonRemove.Image = global::SupermarketManagementApp.Properties.Resources.remove_product;
            buttonRemove.ImageSize = new System.Drawing.Size(30, 30);
            buttonRemove.Location = new System.Drawing.Point(856, 30);
            buttonRemove.Margin = new System.Windows.Forms.Padding(20, 35, 3, 3);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            buttonRemove.PressedColor = System.Drawing.Color.Transparent;
            buttonRemove.Size = new System.Drawing.Size(56, 40);
            buttonRemove.TabIndex = 4;

            buttonRemove.Click += (sender, e) =>
            {
                panelOrderInformation.Controls.Remove(lineToRemove);
                double totalAmount = 0;

                foreach (FlowLayoutPanel line in panelOrderInformation.Controls)
                {
                    foreach (Control control in line.Controls)
                    {
                        if (control.Name == "panelTotalPrice")
                        {
                            foreach (Control control2 in control.Controls)
                            {
                                if (control2.Name == "txtTotalPrice")
                                {
                                    double value;
                                    if (double.TryParse(control2.Text, out value))
                                    {
                                        totalAmount += value;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }

                // Đặt văn hóa phù hợp
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");

                // Định dạng số thành chuỗi theo định dạng tiền tệ
                labelTotalAmount.RightToLeft = RightToLeft.Yes;
                labelTotalAmount.Text = totalAmount.ToString("N0", culture) + " VND";
            };

            return buttonRemove;
        }
    }
}
