﻿using SupermarketManagementApp.BUS;
using SupermarketManagementApp.Properties;
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

namespace SupermarketManagementApp.GUI
{
    public partial class FormLogin : Form
    {
        private AccountBUS accountBUS;
        public FormLogin()
        {
            InitializeComponent();
            accountBUS = AccountBUS.GetInstance();
            txtBoxPassword.IconRightClick += txtBoxPassword_IconRightClick;
        }

        private void labelForgotPassword_Click(object sender, EventArgs e)
        {
            
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

        private async void btnSignIn_Click(object sender, EventArgs e)
        {
            Result<DTO.Account> result = await accountBUS.loginAccount(txtBoxUsername.Text, txtBoxPassword.Text);
            if (result.IsSuccess)
            {
                GlobalVariable.LoggedAccount = result.Data;
                FormMain formMain = new FormMain();
                this.Hide();
                formMain.ShowDialog();
                this.Close();
            } 
            else
            {
                msgBoxError.Show(result.ErrorMessage);
            }
        }
    }
}
