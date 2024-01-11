using SupermarketManagementApp.BUS;
using SupermarketManagementApp.GUI.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementApp.GUI.Customer
{
    public partial class FormCreateCustomer : Form
    {
        private CustomerBUS customerBUS;
        private FormCustomerManagement formCustomerManagement;
        public FormCreateCustomer(FormCustomerManagement formCustomerManagement)
        {
            InitializeComponent();
            customerBUS = CustomerBUS.GetInstance();
            this.formCustomerManagement = formCustomerManagement;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            DTO.Customer customer = new DTO.Customer();
            customer.CustomerName = this.txtBoxCustomerName.Text;
            customer.Gender = this.cbBoxGender.Text;
            customer.Birthday = this.birthDayPicker.Value;
            customer.PhoneNumber = this.txtBoxPhoneNumber.Text;
            
            
            try
            {
                var customerResult = await customerBUS.AddCustomer(customer);
                if (customerResult.IsSuccess)
                {
                    MessageBox.Show("Added new employee Success");
                    formCustomerManagement.InitAllCustomer();
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show(customerResult.ErrorMessage);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
