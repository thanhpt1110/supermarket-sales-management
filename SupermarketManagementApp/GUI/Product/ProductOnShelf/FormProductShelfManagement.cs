using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementApp.GUI.Product.ProductOnShelf
{
    public partial class FormProductShelfManagement : Form
    {
        private FormMain formMain;
        public FormProductShelfManagement()
        {
            InitializeComponent();
        }

        public FormProductShelfManagement(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;   
        }

    }
}
