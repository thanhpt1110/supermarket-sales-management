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
        private AccountBUS accountBUS = null;
        public FormCreateAccount()
        {
            InitializeComponent();
            txtBoxPassword.IconRightClick += txtBoxPassword_IconRightClick;
            accountBUS = AccountBUS.GetInstance();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            DTO.Account account = new DTO.Account();
            account.Username = txtBoxUsername.Text;
            account.Password = txtBoxPassword.Text;
            account.Role = this.cbBoxRole.SelectedText;
            account.EmployeeID = 1; // Để tạm
            Result<DTO.Account> result = await accountBUS.createNewAccount(account);
            if (result.IsSuccess)
            {
                MessageBox.Show("Create account success");
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
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
