using Guna.UI2.WinForms;
using SupermarketManagementApp.BUS;
using SupermarketManagementApp.DTO;
using SupermarketManagementApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementApp.GUI.Invoice.SupplierInvoice
{
    public partial class FormCreateSupplierInvoice : Form
    {
        private const int INVENTORY_CAPACITY = 500000;
        private double used = 0;
        private double remaining = 0;
        private List<string> listProductName;
        private List<DTO.Product> listProduct;
        private List<string> listSelectedProductName;
        private List<DTO.Product> listSelectedProduct;
        private ProductBUS productBUS;
        private SupplierInvoiceBUS supplierInvoiceBUS;
        private Dictionary<string,DTO.SupplierInvoiceDetail> productDictionary;
        private InvetoryDetailBUS invetoryDetailBUS;
        private int inventoryNumber;
        public FormCreateSupplierInvoice()
        {
            InitializeComponent();
            productBUS = ProductBUS.GetInstance();
            supplierInvoiceBUS = SupplierInvoiceBUS.GetInstance();
            invetoryDetailBUS = InvetoryDetailBUS.GetInstance();
            productDictionary = new Dictionary<string, DTO.SupplierInvoiceDetail>();
            loadProduct();
            LoadFirstCapacity();

        }
        private async void loadProduct()
        {
            Result<IEnumerable<DTO.Product>> productResult = await productBUS.getAllProduct();
            if (productResult.IsSuccess)
            {
                listProduct = productResult.Data.ToList();
                listProductName = listProduct.Select(p=>p.ProductName).ToList();
            }
            else
            {
                MessageBox.Show(productResult.ErrorMessage);
                this.Close();
            }
        }
        private async void LoadFirstCapacity()
        {
            Result<float> reuslt = await invetoryDetailBUS.getCapacityOfInventory();
            if (reuslt.IsSuccess)
            {
                used = reuslt.Data;
                inventoryNumber = (int)reuslt.Data;
            }
            UpdateAvailableCapacity();
        }    
        private void UpdateAvailableCapacity()
        {
            availableCapacity.Minimum = 0;
            availableCapacity.Maximum = INVENTORY_CAPACITY;
            availableCapacity.Value = (int)used;
            remaining = INVENTORY_CAPACITY - used;
            availableCapacity.Text = ("Capacity: " + used + " used, " + remaining + " remaining.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnCheckOut_ClickAsync(object sender, EventArgs e)
        {
            Result<DTO.SupplierInvoice> supplierResult = await supplierInvoiceBUS.AddNewSupplierInvoice(productDictionary, this.txtBoxCustomerName.Text);
            if(supplierResult.IsSuccess)
            {
                MessageBox.Show("Create invoice successfully");
                this.Close();
            }
            else
            {
                MessageBox.Show(supplierResult.ErrorMessage,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel newLine = new FlowLayoutPanel();
            newLine.Dock = DockStyle.Top;
            newLine.Name = "FlowPanel"+panelOrderInformation.Controls.Count.ToString();
            newLine.Controls.Add(panelProductName("Product Name", "txtProductName", newLine));
            newLine.Controls.Add(panelQuantity("Quantity", "txtQuantity", newLine));
            newLine.Controls.Add(panelUnitPrice("Unit Price", "txtUnitPrice", newLine));
            newLine.Controls.Add(panelTotalPrice("Total Price", "txtTotalPrice", newLine));
            newLine.Controls.Add(panelCapacity("Capacity", "txtCapacity", newLine));
            newLine.Controls.Add(panelTotalCapacity("Total Capacity", "txtTotalCapacity", newLine));
            productDictionary[newLine.Name] = new DTO.SupplierInvoiceDetail();
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
            textBox.AutoCompleteCustomSource.AddRange(listProductName.ToArray());
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBox.TextChanged += (sender, e) =>
            {
                productDictionary[currentLine.Name].Product = listProduct.FirstOrDefault(p=>p.ProductName == textBox.Text);
                string PriceText = "0";
                string capacityText = "0";

                if (productDictionary[currentLine.Name].Product!=null)
                {
                    var product = productDictionary[currentLine.Name].Product;
                    MessageBox.Show(product.ProductName);
                    PriceText = (product.UnitPrice * product.UnitConversion).ToString();
                    capacityText = (product.ProductCapacity * product.UnitConversion).ToString();
                }    
                foreach (Control control in currentLine.Controls)
                {
                    if (control.Name == "panelUnitPrice")
                    {
                        foreach (Control control2 in control.Controls)
                        {
                            if (control2.Name == "txtUnitPrice")
                            {
                                control2.Text = PriceText;
                                break;
                            }
                        }
                    }
                    if (control.Name == "panelCapacity")
                    {
                        foreach (Control control2 in control.Controls)
                        {
                            if (control2.Name == "txtCapacity")
                            {
                                control2.Text = capacityText;
                                break;
                            }
                        }
                    }
                }
                // Find text box for Capacity
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
            textBox.TextOffset = new System.Drawing.Point(5, 0);

            textBox.TextChanged += (sender, e) =>
            {
                Control unitPrice = new Control();
                Control totalPrice = new Control();
                Control capacity = new Control();
                Control totalCapacity = new Control();

                if (textBox.Text == String.Empty)
                {
                    textBox.Text = "0";
                }
                productDictionary[currentLine.Name].ProductQuantity = int.Parse(textBox.Text);
                // Find text box for Total Price
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

                // Find text box for Unit Price
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

                // Find text box for Total Capacity
                foreach (Control control in currentLine.Controls)
                {
                    if (control.Name == "panelTotalCapacity")
                    {
                        foreach (Control control2 in control.Controls)
                        {
                            if (control2.Name == "txtTotalCapacity")
                            {
                                totalCapacity = control2;
                                break;
                            }
                        }
                    }
                }

                // Find text box for Capacity
                foreach (Control control in currentLine.Controls)
                {
                    if (control.Name == "panelCapacity")
                    {
                        foreach (Control control2 in control.Controls)
                        {
                            if (control2.Name == "txtCapacity")
                            {
                                capacity = control2;
                                break;
                            }
                        }
                    }
                }

                double unitPriceValue, quantityValue, capacityValue;
                if (double.TryParse(textBox.Text, out quantityValue))
                {
                    if (double.TryParse(unitPrice.Text, out unitPriceValue))
                    {
                        totalPrice.Text = (unitPriceValue * quantityValue).ToString();
                    }

                    if (double.TryParse(capacity.Text, out capacityValue))
                    {
                        totalCapacity.Text = (capacityValue * quantityValue).ToString();
                    }
                }
                else
                {
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
            textBox.Text = "0";
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

        private Guna2Panel panelCapacity(string labelText, string controlName, FlowLayoutPanel currentLine)
        {
            Guna2Panel currentPanel = new Guna2Panel();
            currentPanel.Dock = DockStyle.Bottom;
            currentPanel.Name = "panelCapacity";

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
            textBox.Text = "50";
            textBox.TextOffset = new System.Drawing.Point(5, 0);
            currentPanel.Controls.Add(textBox);

            return currentPanel;
        }

        private Guna2Panel panelTotalCapacity(string labelText, string controlName, FlowLayoutPanel currentLine)
        {
            Guna2Panel currentPanel = new Guna2Panel();
            currentPanel.Dock = DockStyle.Bottom;
            currentPanel.Name = "panelTotalCapacity";

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
                double totalCapacity = 0;

                foreach (FlowLayoutPanel line in panelOrderInformation.Controls)
                {
                    foreach (Control control in line.Controls)
                    {
                        if (control.Name == "panelTotalCapacity")
                        {
                            foreach (Control control2 in control.Controls)
                            {
                                if (control2.Name == "txtTotalCapacity")
                                {
                                    double value;
                                    if (double.TryParse(control2.Text, out value))
                                    {
                                        totalCapacity += value;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }
                
                used = totalCapacity + inventoryNumber;
                UpdateAvailableCapacity();
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
            buttonRemove.Margin = new System.Windows.Forms.Padding(10, 35, 3, 3);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            buttonRemove.PressedColor = System.Drawing.Color.Transparent;
            buttonRemove.Size = new System.Drawing.Size(56, 40);
            buttonRemove.TabIndex = 4;

            buttonRemove.Click += (sender, e) =>
            {
                panelOrderInformation.Controls.Remove(lineToRemove);
                double totalAmount = 0;
                productDictionary.Remove(lineToRemove.Name);
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

                double totalCapacity = 0;

                foreach (FlowLayoutPanel line in panelOrderInformation.Controls)
                {
                    foreach (Control control in line.Controls)
                    {
                        if (control.Name == "panelTotalCapacity")
                        {
                            foreach (Control control2 in control.Controls)
                            {
                                if (control2.Name == "txtTotalCapacity")
                                {
                                    double value;
                                    if (double.TryParse(control2.Text, out value))
                                    {
                                        totalCapacity += value;
                                    }
                                    break;
                                }
                            }
                        }
                    }
                }

                used = totalCapacity;
                UpdateAvailableCapacity();
            };

            return buttonRemove;
        }
    }
}
