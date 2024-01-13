using SupermarketManagementApp.BUS;
using SupermarketManagementApp.DTO;
using SupermarketManagementApp.GUI.Employee;
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

namespace SupermarketManagementApp.GUI.Customer
{
    public partial class FormUpdateCustomer : Form
    {
        private DTO.Customer customer;
        private CustomerBUS customerBUS;
        private FormCustomerManagement formCustomerManagement;
        public FormUpdateCustomer()
        {
            InitializeComponent();
        }
        public FormUpdateCustomer(FormCustomerManagement formCustomerManagement, long id)
        {
            this.formCustomerManagement = formCustomerManagement;
            customerBUS = CustomerBUS.GetInstance();
            InitializeComponent();
            msgBoxInfo.Parent = this;
            msgBoxError.Parent = this;
            loadCustomer(id);
        }
        private async void loadCustomer(long _id)
        {
            Result<DTO.Customer> result = await customerBUS.getCustomerByID(_id);
            customer = new DTO.Customer();
            if (result.IsSuccess)
            {
                this.customer.CustomerID = result.Data.CustomerID;
                this.txtBoxCustomerName.Text = result.Data.CustomerName;
                this.txtBoxPhoneNumber.Text = result.Data.PhoneNumber;
                this.cbBoxGender.Text = result.Data.Gender;
                this.birthDayPicker.Value = result.Data.Birthday;
            }
            else
            {
                MessageBox.Show("Load customer failed!!");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            customer.Birthday = birthDayPicker.Value.Date;
            customer.PhoneNumber = txtBoxPhoneNumber.Text;
            customer.CustomerName = txtBoxCustomerName.Text;
            customer.Gender = cbBoxGender.Text;
            Result<DTO.Customer> result = await customerBUS.updateCustomer(customer);
            if (result.IsSuccess)
            {
                msgBoxInfo.Show("Update customer successfully!");
                this.formCustomerManagement.InitAllCustomer();
                this.Close();
            }
            else
            {
                msgBoxError.Show(result.ErrorMessage);
            }
        }
    }
}
