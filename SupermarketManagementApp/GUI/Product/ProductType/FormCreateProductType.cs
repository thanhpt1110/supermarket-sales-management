using SupermarketManagementApp.BUS;
using SupermarketManagementApp.GUI.Account;
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

namespace SupermarketManagementApp.GUI.Product.ProductType
{
    public partial class FormCreateProductType : Form
    {
        private ProductTypeBUS productTypeBUS = null;
        private FormProductTypeManagement formProductTypeManagement;
        public FormCreateProductType(FormProductTypeManagement formProductTypeManagement)
        {
            InitializeComponent();
            productTypeBUS = ProductTypeBUS.GetInstance();
            this.formProductTypeManagement = formProductTypeManagement;
            msgBoxInfo.Parent = this;
            msgBoxError.Parent = this;
            msgBoxDelete.Parent = this;
           
        }

      

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            DTO.ProductType productType = new DTO.ProductType();
            productType.ProductTypeName = txtProductTypeName.Text;
            productType.Description = txtProductTypeDes.Text;
            productType.MinTemperature = int.Parse(txtProductTypeMinTem.Text);
            productType.MaxTemperature = int.Parse(txtProductTypeMaxTem.Text);

            Result<DTO.ProductType> result = await productTypeBUS.createNewProductType(productType);
            if (result.IsSuccess)
            {
                msgBoxInfo.Show("Create new ProductType successfully!");
                formProductTypeManagement.InitAllProductType();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
                return;
            }
            this.Close();
        }
    }
}
