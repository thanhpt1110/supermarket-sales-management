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
        private DTO.Employee employee;
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
            Result<DTO.Employee> result = await employeeBUS.findEmployeeByID(_id);
            employee = new DTO.Employee();
            if (result.IsSuccess)
            {
                this.employee.EmployeeID = result.Data.EmployeeID;
                this.txtBoxEmployeeName.Text = result.Data.EmployeeName;
                this.txtBoxIdCardNumber.Text = result.Data.IdCardNumber;
                this.txtBoxPhoneNumber.Text = result.Data.PhoneNumber;
                this.cbBoxGender.Text = result.Data.Gender;
                this.birthDayPicker.Value = result.Data.Birthday;
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
            Result<DTO.Employee> result = await employeeBUS.updateEmployee(employee);
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
