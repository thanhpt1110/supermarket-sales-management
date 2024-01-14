using SupermarketManagementApp.BUS;
using SupermarketManagementApp.DTO;
using SupermarketManagementApp.GUI.Employee;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SupermarketManagementApp.GUI.Account
{
    public partial class FormUpdateAccount : Form
    {
        private DTO.Account account;
        private AccountBUS accountBUS;
        EmployeeBUS employeeBUS = null;
        private List<string> listEmployeeID = new List<string>();
        private FormAccountManagement formAccountManagement;
        public FormUpdateAccount(FormAccountManagement formAccountManagement, int id)
        {
            InitializeComponent();
            msgBoxError.Parent = this;
            this.msgBoxInfo.Parent = this;
            accountBUS = AccountBUS.GetInstance();
            employeeBUS = EmployeeBUS.GetInstance();
            this.formAccountManagement = formAccountManagement;
            txtBoxPassword.IconRightClick += txtBoxPassword_IconRightClick;
            loadAccount(id);
           
        }
        private async void loadAccount(int _id)
        {
            await loadEmployeeData();
            Result<DTO.Account> result = await accountBUS.getAccountByID(_id);
            account = new DTO.Account();
            if (result.IsSuccess)
            {
                this.account.AccountID = result.Data.AccountID;
                this.cbBoxEmployeeID.Text = result.Data.EmployeeID.ToString();
                this.cbBoxRole.Text = result.Data.Role;
                this.txtBoxUsername.Text = result.Data.Username;
                this.txtBoxPassword.Text = result.Data.Password;
                this.Close();
            }
            else
            {
                msgBoxError.Show("Load employee failed!!");
                this.Close();
            }
        }

        private async Task loadEmployeeData()
        {
            Result<IEnumerable<DTO.Employee>> result = await employeeBUS.GetAllEmployee();
            if (result.IsSuccess)
            {
                cbBoxEmployeeID.DataSource = result.Data;
                cbBoxEmployeeID.DisplayMember = "EmployeeID"; // Hiển thị thuộc tính "Ten" của đối tượng
                cbBoxEmployeeID.ValueMember = "EmployeeID";    // Sử dụng thuộc tính "Id" của đối tượng khi chọn mục
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            account.Role = cbBoxRole.Text;
            account.Username= txtBoxUsername.Text;
            account.Password= txtBoxPassword.Text;
            Result<DTO.Account> result = await accountBUS.updateAccount(account);
            if (result.IsSuccess)
            {
                msgBoxInfo.Show("Update Account successfully!");
                this.formAccountManagement.InitAllAccount();
                this.Close();
            }
            else
            {
                msgBoxError.Show(result.ErrorMessage);
            }
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
