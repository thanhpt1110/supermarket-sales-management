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
using SupermarketManagementApp.Properties;
using SupermarketManagementApp.BUS;
using SupermarketManagementApp.Utils;

namespace SupermarketManagementApp.GUI.Account
{
    public partial class FormCreateAccount : Form
    {
        EmployeeBUS employeeBUS = null;
        private AccountBUS accountBUS = null;
        private List<string> listEmployeeID = new List<string>();
        private FormAccountManagement formAccountManagement;
        public FormCreateAccount(FormAccountManagement formAccountManagement)
        {
            InitializeComponent();
            msgBoxInfo.Parent = this;
            msgBoxError.Parent = this;
            txtBoxPassword.IconRightClick += txtBoxPassword_IconRightClick;
            accountBUS = AccountBUS.GetInstance();
            employeeBUS = EmployeeBUS.GetInstance();
            this.formAccountManagement = formAccountManagement;
            loadEmployeeData();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private async void loadEmployeeData()
        {
            Result<IEnumerable<DTO.Employee>> result = await employeeBUS.GetAllEmployee();
            if(result.IsSuccess)
            {
                cbBoxEmployeeID.DataSource = result.Data;
                cbBoxEmployeeID.DisplayMember = "EmployeeID"; // Hiển thị thuộc tính "Ten" của đối tượng
                cbBoxEmployeeID.ValueMember = "EmployeeID";    // Sử dụng thuộc tính "Id" của đối tượng khi chọn mục
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            DTO.Account account = new DTO.Account();
            account.Username = txtBoxUsername.Text;
            account.Password = txtBoxPassword.Text;
            account.Role = this.cbBoxRole.Text;
            account.EmployeeID = int.Parse(cbBoxEmployeeID.Text);
            Result<DTO.Account> result = await accountBUS.createNewAccount(account);
            if (result.IsSuccess)
            {
                msgBoxInfo.Show("Create account success!");
                formAccountManagement.InitAllAccount();
            }
            else
            {
                msgBoxError.Show(result.ErrorMessage);
                return;
            }
            this.Close();
        }

        private void txtBoxPassword_IconRightClick(object sender, EventArgs e)
        {
            if (txtBoxPassword.UseSystemPasswordChar)
            {
                txtBoxPassword.UseSystemPasswordChar = false;
                txtBoxPassword.PasswordChar = '\0'; // '\0' là ký tự không hiển thị
                txtBoxPassword.IconRight = Resources.show_password;
            }
            else
            {
                txtBoxPassword.UseSystemPasswordChar = true;
                txtBoxPassword.PasswordChar = '●'; // Hoặc bạn có thể sử dụng một ký tự khác để thay thế
                txtBoxPassword.IconRight = Resources.hide_password;
            }
        }
    }
}
