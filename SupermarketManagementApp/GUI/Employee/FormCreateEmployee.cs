﻿using SupermarketManagementApp.BUS;
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
            SupermarketManagementApp.DAO.Employee employee = new SupermarketManagementApp.DAO.Employee();
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
                    MessageBox.Show("Added new employee Success");
                    formEmployeeManagement.InitAllEmployee();
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show(employeeResult.ErrorMessage);
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
