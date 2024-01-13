using SupermarketManagementApp.BUS;
using SupermarketManagementApp.DTO;
using SupermarketManagementApp.GUI.Account;
using SupermarketManagementApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementApp.GUI.Product.ProductType
{
    public partial class FormUpdateProductType : Form
    {
        private DTO.ProductType productType;
        private ProductTypeBUS productTypeBUS;
        private List<string> listProductTypeID = new List<string>();
        private FormProductTypeManagement formProductTypeManagement;
        public FormUpdateProductType(FormProductTypeManagement formProductTypeManagement, int id)
        {
            InitializeComponent();
            msgBoxInfo.Parent = this;
            msgBoxError.Parent = this;
            msgBoxDelete.Parent = this;
            productTypeBUS = ProductTypeBUS.GetInstance();
            this.formProductTypeManagement = formProductTypeManagement;
            loadProductType(id);
        }
        private async void loadProductType(int _id)
        {
            Result<DTO.ProductType> result = await productTypeBUS.getProductTypeByID(_id);
            productType = new DTO.ProductType();
            if (result.IsSuccess)
            {
                this.productType.ProductTypeID = result.Data.ProductTypeID;
                this.txtProductTypeName.Text = result.Data.ProductTypeName;
                this.txtProductTypeDes.Text = result.Data.Description;
                this.txtProductTypeMinTem.Text = result.Data.MinTemperature.ToString();
                this.txtProductTypeMaxTem.Text = result.Data.MaxTemperature.ToString();
            }
            else
            {
                msgBoxError.Show("Load ProductType failed!!");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            productType.ProductTypeName = txtProductTypeName.Text;
            productType.Description = txtProductTypeDes.Text;
            productType.MinTemperature = int.Parse(txtProductTypeMinTem.Text);
            productType.MaxTemperature = int.Parse(txtProductTypeMaxTem.Text);

            Result<DTO.ProductType> result = await productTypeBUS.updateProductType(productType);
            if (result.IsSuccess)
            {
                msgBoxInfo.Show("Update Account successfully!");
                this.formProductTypeManagement.InitAllProductType();
                this.Close();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }
    }
}
