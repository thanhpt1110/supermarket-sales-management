using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using SupermarketManagementApp.GUI.Account;
using SupermarketManagementApp.GUI.Report_Statistic;
using SupermarketManagementApp.GUI.Employee;
using SupermarketManagementApp.GUI.Customer;
using SupermarketManagementApp.GUI.Invoice.SupplierInvoice;
using SupermarketManagementApp.GUI.Invoice.CustomerInvoice;
using SupermarketManagementApp.GUI.Shelf;
using SupermarketManagementApp.GUI.Product;
using SupermarketManagementApp.GUI.Product.ProductType;
using SupermarketManagementApp.GUI.Product.ProductInInventory;
using SupermarketManagementApp.GUI.Product.ProductOnShelf;
using SupermarketManagementApp.GUI;
using SupermarketManagementApp.Properties;
using SupermarketManagementApp.Utils;

namespace SupermarketManagementApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            SetInitialCustom();
        }

        private void SetInitialCustom()
        {
            CloseSubMenu();
            SetColorButton(btnDashboard);
            btnDashboard.CustomImages.Image = Resources.white_gauge;
            OpenChildForm(new FormDashboard());
            accountName.Text = GlobalVariable.LoggedAccount.Employee.EmployeeName;
            ProcessUIAuthorization(GlobalVariable.LoggedAccount.Role);
        }

        #region Set color for button 
        private void SetDefaultColor()
        {
            // Background
            btnDashboard.FillColor = Color.Transparent;
            btnShelfMap.FillColor = Color.Transparent;
            btnManageShelf.FillColor = Color.Transparent;
            btnProduct.FillColor = Color.Transparent; 
                btnManageProduct.FillColor = Color.Transparent;
                btnManageProductType.FillColor = Color.Transparent;
                btnProductInInventory.FillColor = Color.Transparent;
            btnInvoice.FillColor = Color.Transparent;
                btnManageCustomerInvoice.FillColor = Color.Transparent;
                btnManageSupplierInvoice.FillColor = Color.Transparent;
            btnManageCustomer.FillColor = Color.Transparent;
            btnManageEmployee.FillColor = Color.Transparent;
            btnManageAccount.FillColor = Color.Transparent;
            btnStatistic.FillColor = Color.Transparent;

            // Fore color
            btnDashboard.ForeColor = Color.Black;
            btnManageShelf.ForeColor = Color.Black;
            btnShelfMap.ForeColor = Color.Black;
            btnProduct.ForeColor = Color.Black;
                btnManageProduct.ForeColor = Color.Black;
                btnManageProductType.ForeColor = Color.Black;
                btnProductInInventory.ForeColor = Color.Black;
            btnInvoice.ForeColor = Color.Black;
                btnManageCustomerInvoice.ForeColor = Color.Black;
                btnManageSupplierInvoice.ForeColor = Color.Black;
            btnManageCustomer.ForeColor = Color.Black;  
            btnManageEmployee.ForeColor = Color.Black;
            btnManageAccount.ForeColor = Color.Black;
            btnStatistic.ForeColor = Color.Black;

            // Image
            btnDashboard.CustomImages.Image = Resources.black_gauge;
            btnShelfMap.CustomImages.Image = Resources.black_shelf_map;
            btnManageShelf.CustomImages.Image = Resources.black_shelf;
            btnProduct.CustomImages.Image = Resources.black_product;
            btnInvoice.CustomImages.Image = Resources.black_invoice;
            btnManageCustomer.CustomImages.Image = Resources.black_customer;
            btnManageEmployee.CustomImages.Image = Resources.black_employee;
            btnManageAccount.CustomImages.Image = Resources.black_account;
            btnStatistic.CustomImages.Image = Resources.black_stats;
            btnProduct.Image = Resources.black_caret_down;
            btnInvoice.Image = Resources.black_caret_down;
        }

        private void SetColorButton(Guna2Button button)
        {
            button.FillColor = Color.FromArgb(45, 0, 103);
            button.ForeColor = Color.White;
        }
        #endregion

        #region Set visible for button
        private void CloseSubMenu()
        {
            HideVisibleForProduct();
            HideVisibleForInvoice();
        }

        private void HideVisibleForProduct()
        {
            panelSubProduct.Visible = false;
        }

        private void DisplayVisibleForProduct()
        {
            if (panelSubProduct.Visible == false)
            {
                panelSubProduct.Visible = true;
            }
        }

        private void HideVisibleForInvoice()
        {
            panelSubInvoice.Visible = false;
        }

        private void DisplayVisibleForInvoice()
        {
            if (panelSubInvoice.Visible == false)
            {
                panelSubInvoice.Visible = true;
            }
        }
        #endregion

        #region Process call child form
        private Form activeChildForm = null;
        private void OpenChildForm(Form childForm)
        {
            if (activeChildForm != null)
            {
                activeChildForm.Close();
            }

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;

            // Display child form 
            childForm.BringToFront();
            childForm.Show();   
        }
        #endregion

        #region Click event
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SetDefaultColor();
            CloseSubMenu();
            SetColorButton((Guna2Button)sender);
            btnDashboard.CustomImages.Image = Resources.white_gauge;
            OpenChildForm(new FormDashboard());
        }

        private void btnShelfMap_Click(object sender, EventArgs e)
        {
            SetDefaultColor();
            CloseSubMenu(); 
            SetColorButton((Guna2Button)sender);
            btnShelfMap.CustomImages.Image = Resources.white_shelf_map;
            OpenChildForm(new FormShelfMap(this));
        }

        private void btnManageShelf_Click(object sender, EventArgs e)
        {
            SetDefaultColor();
            CloseSubMenu();
            SetColorButton((Guna2Button)sender);
            btnManageShelf.CustomImages.Image = Resources.white_shelf;
            OpenChildForm(new FormShelfManagement(this));   
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            SetDefaultColor();
            if (panelSubProduct.Visible == true)
            {
                HideVisibleForProduct();
                btnProduct.CustomImages.Image = Resources.black_product;
                btnProduct.Image = Resources.black_caret_down;
            } 
            else
            {
                // Another submenu is open
                HideVisibleForInvoice();
                DisplayVisibleForProduct();
                SetColorButton((Guna2Button)sender);
                btnProduct.CustomImages.Image = Resources.white_product;
                btnProduct.Image = Resources.white_caret_down;
            }
        }

        private void btnManageProduct_Click(object sender, EventArgs e)
        {
            SetDefaultColor();
            SetColorButton((Guna2Button)sender);
            OpenChildForm(new FormProductManagement(this));
        }

        private void btnManageProductType_Click(object sender, EventArgs e)
        {
            SetDefaultColor();
            SetColorButton((Guna2Button)sender);
            OpenChildForm(new FormProductTypeManagement(this));
        }

        private void btnProductInInventory_Click(object sender, EventArgs e)
        {
            SetDefaultColor();
            SetColorButton((Guna2Button)sender);
            OpenChildForm(new FormProductInventoryManagement(this));
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            SetDefaultColor();
            if (panelSubInvoice.Visible == true)
            {
                HideVisibleForInvoice();
                btnInvoice.CustomImages.Image = Resources.black_invoice;
                btnInvoice.Image = Resources.black_caret_down;
            }
            else
            {
                // Another submenu is open
                HideVisibleForProduct();
                DisplayVisibleForInvoice();
                SetColorButton((Guna2Button)sender);
                btnInvoice.CustomImages.Image = Resources.white_invoice;
                btnInvoice.Image = Resources.white_caret_down;
            }
        }

        private void btnManageCustomerInvoice_Click(object sender, EventArgs e)
        {
            SetDefaultColor();
            SetColorButton((Guna2Button)sender);
            OpenChildForm(new FormCustomerInvoiceManagement(this));
        }

        private void btnManageSupplierInvoice_Click(object sender, EventArgs e)
        {
            SetDefaultColor();
            SetColorButton((Guna2Button)sender);
            OpenChildForm(new FormSupplierInvoiceManagement(this));
        }

        private void btnManageCustomer_Click(object sender, EventArgs e)
        {
            SetDefaultColor();
            CloseSubMenu();
            SetColorButton((Guna2Button)sender);
            btnManageCustomer.CustomImages.Image = Resources.white_customer;
            OpenChildForm(new FormCustomerManagement(this));
        }

        private void btnManageEmployee_Click(object sender, EventArgs e)
        {
            SetDefaultColor();
            CloseSubMenu();
            SetColorButton((Guna2Button)sender);
            btnManageEmployee.CustomImages.Image = Resources.white_employee;
            OpenChildForm(new FormEmployeeManagement(this));
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            SetDefaultColor();
            CloseSubMenu();
            SetColorButton((Guna2Button)sender);
            btnManageAccount.CustomImages.Image = Resources.white_account;
            OpenChildForm(new FormAccountManagement(this));
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            SetDefaultColor();
            CloseSubMenu();
            SetColorButton((Guna2Button)sender);
            btnStatistic.CustomImages.Image = Resources.white_stats;
            OpenChildForm(new FormReport_Statistic());
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult dr = msgBoxConfirm.Show();
            switch (dr)
            {
                case DialogResult.Yes:
                    try
                    {
                        GlobalVariable.LoggedAccount = null;
                        using (FormLogin formLogin = new FormLogin())
                        {
                            this.Hide();
                            formLogin.ShowDialog();
                            this.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        msgBoxConfirm.Parent = this;
                        msgBoxConfirm.Show(ex.Message, "Error");
                    }
                    break;
                case DialogResult.No:
                    break;
            }
        }
        #endregion

        #region Authorization
        private void ProcessUIAuthorization(string userRole)
        {
            switch (userRole)
            {
                case "Admin":
                    btnManageAccount.Visible = true;
                    btnManageEmployee.Visible = true;   
                    btnStatistic.Visible = true;
                    break;

                case "Manager":
                    btnManageAccount.Visible = false;
                    btnStatistic.Visible = true;
                    btnManageEmployee.Visible = true;
                    break;

                case "Employee":
                    btnManageAccount.Visible = false;
                    btnStatistic.Visible = false;
                    btnManageEmployee.Visible = false;
                    break;

                default:
                    btnManageAccount.Visible = false;
                    btnStatistic.Visible = false;
                    btnManageEmployee.Visible = false;
                    break;
            }
        }

        // Enum định nghĩa các vai trò người dùng
        #endregion
    }
}
