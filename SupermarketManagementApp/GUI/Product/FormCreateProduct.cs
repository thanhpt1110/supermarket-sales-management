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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementApp.GUI.Product
{
    public partial class FormCreateProduct : Form
    {
        ProductTypeBUS productTypeBUS = null;
        private ProductBUS productBUS = null;
        private List<string> listProductId = new List<string>();
        private FormProductManagement formProductManagement;
        public FormCreateProduct(FormProductManagement formProductManagement)
        {
            InitializeComponent();
            productBUS = ProductBUS.GetInstance();
            productTypeBUS = ProductTypeBUS.GetInstance();
            this.formProductManagement = formProductManagement;
            loadProductData();
        }

        private async void loadProductData()
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
            DTO.Product product = new DTO.Product();
            product.ProductName = txtBoxProductName.Text;
            product.UnitPrice = double.Parse(txtUnitConversion.Text);
            product.WholeSaleUnit = txtBoxWholesaleUnit.Text;
            product.RetailUnit = txtBoxRetailUnit.Text;
            product.ProductCapacity = int.Parse(txtBoxProductCapacity.Text);
            product.UnitConversion = int.Parse(txtUnitConversion.Text);
            product.ProductTypeID = int.Parse(cbBoxProductType.SelectedValue.ToString());
            
            Result<DTO.Product> result = await productBUS.createNewProduct(product);
            if (result.IsSuccess)
            {
                MessageBox.Show("Create Product successfully!");
                formProductManagement.InitAllProduct();
                this.Close();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
                return;
            }
        }
    }
}
