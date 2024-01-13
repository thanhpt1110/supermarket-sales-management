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

namespace SupermarketManagementApp.GUI.Product
{
    public partial class FormUpdateProduct : Form
    {
        private DTO.Product product;
        ProductTypeBUS productTypeBUS = null;
        private ProductBUS productBUS = null;
        private List<string> listProductId = new List<string>();
        private FormProductManagement formProductManagement;
        public FormUpdateProduct(FormProductManagement formProductManagement, int id)
        {
            InitializeComponent();
            msgBoxInfo.Parent = this;
            msgBoxError.Parent = this;
            msgBoxDelete.Parent = this;
            productBUS = ProductBUS.GetInstance();
            productTypeBUS = ProductTypeBUS.GetInstance();
            this.formProductManagement = formProductManagement;
            loadProduct(id);
        }

        private async void loadProduct(int _id)
        {
            await loadProductData();
            Result<DTO.Product> result = await productBUS.getProductByID(_id);
            product = new DTO.Product();
            if (result.IsSuccess)
            {
                this.product.ProductID = result.Data.ProductID;
                if(result.Data.ProductType==null)
                {
                    Result<DTO.ProductType> result1 = await productTypeBUS.findProductTypeByID(result.Data.ProductTypeID.Value);
                    if (result1.IsSuccess)
                        result.Data.ProductType = result1.Data;
                }    
                this.cbBoxProductType.Text = result.Data.ProductType.ProductTypeName;
                this.txtBoxProductName.Text = result.Data.ProductName;
                this.txtUnitPrice.Text = result.Data.UnitPrice.ToString();
                this.txtBoxProductCapacity.Text = result.Data.ProductCapacity.ToString();
                this.txtBoxWholesaleUnit.Text = result.Data.WholeSaleUnit;
                this.txtBoxRetailUnit.Text = result.Data.RetailUnit;
                this.txtUnitConversion.Text = result.Data.UnitConversion.ToString();

            }
            else
            {
                msgBoxError.Show("Load Product failed!!");
                this.Close();
            }
        }
        private async Task loadProductData()
        {
            Result<IEnumerable<DTO.ProductType>> result = await productTypeBUS.getAllProductType();
            if (result.IsSuccess)
            {
                cbBoxProductType.DataSource = result.Data;
                cbBoxProductType.DisplayMember = "ProductTypeName"; // Hiển thị thuộc tính "Ten" của đối tượng
                cbBoxProductType.ValueMember = "ProductTypeID";    // Sử dụng thuộc tính "Id" của đối tượng khi chọn mục
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }   

        private async void btnSave_Click(object sender, EventArgs e)
        {
            product.ProductName = txtBoxProductName.Text;
            product.ProductTypeID = int.Parse(cbBoxProductType.SelectedValue.ToString());
            product.UnitPrice = double.Parse(txtUnitPrice.Text);
            product.ProductCapacity = int.Parse(txtBoxProductCapacity.Text);
            product.WholeSaleUnit = txtBoxWholesaleUnit.Text;
            product.RetailUnit = txtBoxRetailUnit.Text;
            product.UnitConversion = int.Parse(txtUnitConversion.Text);
            Result<DTO.Product> result = await productBUS.updateProduct(product);
            if (result.IsSuccess)
            {
                msgBoxInfo.Show("Update Product successfully!");
                this.formProductManagement.InitAllProduct();
                this.Close();
            }
            else
            {
                msgBoxError.Show(result.ErrorMessage);
            }
        }
    }
}
