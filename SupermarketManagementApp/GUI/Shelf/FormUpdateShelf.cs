using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementApp.GUI.Shelf
{
    public partial class FormUpdateShelf : Form
    {
        public FormUpdateShelf()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxLayerCapacity_TextChanged(object sender, EventArgs e)
        {
            txtBoxTotalCapacity.Text = txtBoxLayerCapacity.Text.Trim();
        }
    }
}
