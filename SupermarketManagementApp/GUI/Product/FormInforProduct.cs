using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementApp.GUI.Product
{
    public partial class FormInforProduct : Form
    {
        public FormInforProduct()
        {
            InitializeComponent();
            this.txtProductName.Text = "Test UI";
            this.txtBoxDescription.Text = "Description";    
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
