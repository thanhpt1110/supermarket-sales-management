﻿using Guna.UI2.WinForms;
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

namespace SupermarketManagementApp.GUI.Invoice.CustomerInvoice
{
    public partial class FormCreateCustomerInvoice : Form
    {
        private DTO.CustomerInvoice customerInvoice;
        private DTO.Customer customer;
        private CustomerInvoiceBUS customerInvoiceBUS;
        private CustomerBUS customerBUS;
        private Dictionary<string, CustomerInvoiceDetail> customerInvoiceDictionary;
        private ProductBUS productBUS;
        private List<DTO.Customer> customers;
        private Timer searchTimer;
        private FormCustomerInvoiceManagement FormCustomerInvoiceManagement;
        List<DTO.Product> products = new List<DTO.Product>
            {
                new DTO.Product
                {
                    ProductID = 1,
                    ProductTypeID = 1,
                    ProductName = "Product1",
                    UnitPrice = 10.5,
                    WholeSaleUnit = "Box",
                    RetailUnit = "Piece",
                    UnitConversion = 12,
                    ProductCapacity = 100
                },
                new DTO.Product
                {
                    ProductID = 2,
                    ProductTypeID = 2,
                    ProductName = "Product2",
                    UnitPrice = 15.75,
                    WholeSaleUnit = "Carton",
                    RetailUnit = "Unit",
                    UnitConversion = 10,
                    ProductCapacity = 50
                },
                // Add more products as needed
            };

        public FormCreateCustomerInvoice()
        {
            InitializeComponent();
            msgBoxError.Parent = this;
            msgBoxInfo.Parent = this;
            customerInvoiceDictionary = new Dictionary<string, CustomerInvoiceDetail>();
            customerInvoice = new DTO.CustomerInvoice();
            customerBUS = CustomerBUS.GetInstance();
            productBUS = ProductBUS.GetInstance();
            customerInvoiceBUS = CustomerInvoiceBUS.GetInstance();
            LoadProduct();
            LoadListCustomer();
            InitTimer();
        }

        public FormCreateCustomerInvoice(FormCustomerInvoiceManagement formCustomerInvoiceManagement)
        {
            InitializeComponent();
            this.FormCustomerInvoiceManagement = formCustomerInvoiceManagement;
            msgBoxError.Parent = this;
            msgBoxInfo.Parent = this;
            customerInvoiceDictionary = new Dictionary<string, CustomerInvoiceDetail>();
            customerInvoice = new DTO.CustomerInvoice();
            customerBUS = CustomerBUS.GetInstance();
            productBUS = ProductBUS.GetInstance();
            customerInvoiceBUS = CustomerInvoiceBUS.GetInstance();
            LoadProduct();
            LoadListCustomer();
            InitTimer();
        }
        private async void LoadProduct()
        {
            Result<IEnumerable<DTO.Product>> result;
            result = await productBUS.getAllProduct();
            if(result.IsSuccess)
            {
                this.products = result.Data.ToList();
            }
            else
            {
                msgBoxError.Parent = this;
                msgBoxError.Show("Load form failed");
            }
        }
        private async void LoadListCustomer()
        {
            Result<IEnumerable<DTO.Customer>> result;
            result = await customerBUS.GetAllCustomer();
            if (result.IsSuccess)
            {
                this.customers = result.Data.ToList();
                txtBoxCustomerName.AutoCompleteCustomSource.AddRange(customers.Select(p=>p.PhoneNumber).ToArray());
                txtBoxCustomerName.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtBoxCustomerName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            else
            {
                msgBoxError.Parent = this;
                msgBoxError.Show("Load form failed");
            }
        }
        private void LoadCustomerByPhoneNumber()
        {
            DTO.Customer findCustomer = customers.FirstOrDefault(p=>p.PhoneNumber == txtBoxPhoneNumber.Text);
            if(findCustomer != null)
            {
                this.customer = findCustomer;
            }    
        }
        #region Init timer event
        private void InitTimer()
        {
            searchTimer = new Timer();
            searchTimer.Interval = 300;
            searchTimer.Tick += SearchTimer_Tick;
        }
        private async void SearchTimer_Tick(object sender, EventArgs e)
        {
            this.searchTimer.Stop();
            LoadCustomerByPhoneNumber();
            LoadCustomer();
        }
        #endregion
        private void LoadCustomer()
        {
            if (customer != null)
            {
                this.txtBoxCustomerName.Text = customer.CustomerName;
                this.cbBoxGender.Text = customer.Gender;
                this.birthDayPicker.Value = customer.Birthday;
            }    
        }    
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnCheckOut_Click(object sender, EventArgs e)
        {
            if(customer==null)
            {
                customer = new DTO.Customer();
                customer.PhoneNumber = txtBoxPhoneNumber.Text;
                customer.Gender = cbBoxGender.Text;
                customer.CustomerName = txtBoxCustomerName.Text;
                customer.Birthday = DateTime.Now;
                Result<DTO.Customer> resultCustomer = await customerBUS.AddCustomer(customer);
                if(resultCustomer.IsSuccess)
                {
                    customer = resultCustomer.Data;
                }
                else
                {
                    msgBoxError.Show(resultCustomer.ErrorMessage);
                    return;
                }
            }
            customerInvoice.CustomerID = customer.CustomerID;
            customerInvoice.EmployeeID = GlobalVariable.LoggedAccount.EmployeeID;
            customerInvoice.CustomerInvoiceDetails = customerInvoiceDictionary.Values;
            Result<DTO.CustomerInvoice> result = await customerInvoiceBUS.AddNewCustomerInvoice(customerInvoice);
            if(result.IsSuccess)
            {
                msgBoxInfo.Parent = this;
                msgBoxInfo.Show("Create invoice success");
                FormCustomerInvoiceManagement.InitAllCustomerInvoice();
                this.Close();
            }
            else
            {
                msgBoxError.Show(result.ErrorMessage);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FlowLayoutPanel newLine = new FlowLayoutPanel();
            newLine.Dock = DockStyle.Top;
            newLine.Name =  DateTime.Now.ToString() + panelCustomerInformation.Controls.Count.ToString();
            customerInvoiceDictionary[newLine.Name] = new CustomerInvoiceDetail();
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
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
            foreach (DTO.Product product in products)
            {
                autoCompleteCollection.Add(product.ProductName);
            }
            textBox.AutoCompleteCustomSource = autoCompleteCollection;
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBox.TextChanged += (sender, e) =>
            {
                customerInvoiceDictionary[currentLine.Name].Product = products.FirstOrDefault(p => p.ProductName == textBox.Text);
                string PriceText = "0";
                string capacityText = "0";

                if (customerInvoiceDictionary[currentLine.Name].Product != null)
                {
                    var product = customerInvoiceDictionary[currentLine.Name].Product;
                    PriceText = product.UnitPrice.ToString();
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

                double unitPriceValue, quantityValue = 0;

                if (!string.IsNullOrEmpty(textBox.Text) && !double.TryParse(textBox.Text, out quantityValue))
                {
                    msgBoxError.Parent = this;
                    msgBoxError.Show("Please enter number only!");
                    return;
                }
                customerInvoiceDictionary[currentLine.Name].ProductQuantity = (int)quantityValue;
                

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

                if (double.TryParse(unitPrice.Text, out unitPriceValue))
                {
                    totalPrice.Text = (unitPriceValue * quantityValue).ToString();
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
                customerInvoiceDictionary.Remove(lineToRemove.Name);

                // Đặt văn hóa phù hợp
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");

                // Định dạng số thành chuỗi theo định dạng tiền tệ
                labelTotalAmount.RightToLeft = RightToLeft.Yes;
                labelTotalAmount.Text = totalAmount.ToString("N0", culture) + " VND";
            };

            return buttonRemove;
        }

        private void txtBoxPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            searchTimer.Stop();
            searchTimer.Start();
        }
    }
}
