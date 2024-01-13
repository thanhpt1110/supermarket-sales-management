using SupermarketManagementApp.BUS;
using SupermarketManagementApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementApp.GUI.Employee
{
    public partial class FormCreateEmployee : Form
    {
        private EmployeeBUS employeeBUS;
        private FormEmployeeManagement formEmployeeManagement;
        public FormCreateEmployee(FormEmployeeManagement formEmployeeManagement)
        {
            InitializeComponent();
            employeeBUS = EmployeeBUS.GetInstance();
            this.formEmployeeManagement = formEmployeeManagement;
            msgBoxError.Parent = this;
            msgBoxInfo.Parent = this;
        }
        public FormCreateEmployee()
        {
            InitializeComponent();
            employeeBUS = EmployeeBUS.GetInstance();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            DTO.Employee employee = new DTO.Employee();
            employee.EmployeeName = this.txtBoxCustomerName.Text;
            employee.Gender = this.cbBoxGender.Text;
            employee.Birthday = this.birthDayPicker.Value;
            employee.PhoneNumber = this.txtBoxPhoneNumber.Text; 
            employee.IdCardNumber = this.txtBoxIdCardNumber.Text;
            try
            {
                var employeeResult = await employeeBUS.AddEmployee(employee);
                if(employeeResult.IsSuccess )
                {
                    msgBoxInfo.Show("Added new employee Success");
                    formEmployeeManagement.InitAllEmployee();
                    this.Close();
                    return;
                }
                else
                {
                    msgBoxError.Show(employeeResult.ErrorMessage);
                    return;
                }
            }
            catch (Exception ex)
            {
                msgBoxError.Show(ex.Message);
            }
        }
    }
}
