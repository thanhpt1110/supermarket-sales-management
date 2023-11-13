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

namespace SupermarketManagementApp.GUI.Account
{
    public partial class FormCreateAccount : Form
    {
        public FormCreateAccount()
        {
            InitializeComponent();
            txtBoxPassword.IconRightClick += txtBoxPassword_IconRightClick;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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
