using SupermarketManagementApp.BUS;
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
using System.Windows.Media.Animation;

namespace SupermarketManagementApp.GUI.Employee
{
    public partial class FormUpdateEmployee : Form
    {
        private DAO.Employee employee;
        private EmployeeBUS employeeBUS;
        private FormEmployeeManagement formEmployeeManagement;
        public FormUpdateEmployee()
        {
            InitializeComponent();
        }
        public FormUpdateEmployee(FormEmployeeManagement formEmployeeManagement,long id)
        {
            this.formEmployeeManagement = formEmployeeManagement;
            employeeBUS = EmployeeBUS.GetInstance();
            InitializeComponent();
            loadEmployee(id);
        }
        private async void loadEmployee(long _id)
        {
            Result<DAO.Employee> result = await employeeBUS.findEmployeeByID(_id);
            if(result.IsSuccess)
            {
                this.employee = result.Data;
                this.txtBoxEmployeeName.Text = employee.EmployeeName;
                this.txtBoxIdCardNumber.Text = employee.IdCardNumber;
                this.txtBoxPhoneNumber.Text = employee.PhoneNumber;
                this.cbBoxGender.Text = employee.Gender;
                this.birthDayPicker.Value = employee.Birthday;
            }
            else
            {
                MessageBox.Show("Load employee failed!!");
                this.Close();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_ClickAsync(object sender, EventArgs e)
        {
            employee.Birthday = birthDayPicker.Value.Date;
            employee.PhoneNumber = txtBoxPhoneNumber.Text;
            employee.EmployeeName = txtBoxEmployeeName.Text;
            employee.IdCardNumber = txtBoxIdCardNumber.Text;
            employee.Gender = cbBoxGender.Text;
            Result<DAO.Employee> result = await employeeBUS.updateEmployee(employee);
            if(result.IsSuccess)
            {
                MessageBox.Show("Update employee success");
                this.formEmployeeManagement.InitAllEmployee();
                this.Close();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }
    }
}
