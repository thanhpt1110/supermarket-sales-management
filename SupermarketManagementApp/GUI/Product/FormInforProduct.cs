using SupermarketManagementApp.BUS;
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

namespace SupermarketManagementApp.GUI.Product
{
    public partial class FormInforProduct : Form
    {
        private DTO.Product product;
        ProductTypeBUS productTypeBUS = null;
        private ProductBUS productBUS = null;
        private List<string> listProductId = new List<string>();
        private FormProductManagement formProductManagement;

        public FormInforProduct(FormProductManagement formProductManagement, int id)
        {
            InitializeComponent();
            productBUS = ProductBUS.GetInstance();
            productTypeBUS = ProductTypeBUS.GetInstance();
            this.formProductManagement = formProductManagement;
            loadProduct(id);
        }
        private async void loadProduct(int _id)
        {
            
            Result<DTO.Product> result = await productBUS.getProductByID(_id);
            product = new DTO.Product();
            if (result.IsSuccess)
            {
                this.product.ProductID = result.Data.ProductID;
                
                this.txtBoxProductType.Text = result.Data.ProductTypeID.ToString();
                this.txtProductName.Text = result.Data.ProductName;
                this.txtBoxUnitPrice.Text = result.Data.UnitPrice.ToString();
                this.txtBoxCapacity.Text = result.Data.ProductCapacity.ToString();
                this.txtBoxWholesaleUnit.Text = result.Data.WholeSaleUnit;
                this.txtBoxRetailUnit.Text = result.Data.RetailUnit;
                this.txtBoxUnitConversion.Text = result.Data.UnitConversion.ToString();
                this.txtBoxDescription.Text = result.Data.ProductType.Description;
                this.txtBoxMinTemp.Text = result.Data.ProductType.MinTemperature.ToString();
                this.txtBoxMaxTemp.Text = result.Data.ProductType.MaxTemperature.ToString();

            }
            else
            {
                MessageBox.Show("Load Product failed!!");
                this.Close();
            }
        }
        

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
