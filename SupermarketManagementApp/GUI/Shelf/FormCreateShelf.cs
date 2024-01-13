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

namespace SupermarketManagementApp.GUI.Shelf
{
    public partial class FormCreateShelf : Form
    {
        private ProductTypeBUS productTypeBUS = null;
        private ShelfBUS shelfBUS = null;
        private FormShelfManagement formShelfManagement = null;
        public FormCreateShelf(FormShelfManagement formShelfManagement)
        {
            InitializeComponent();
            productTypeBUS = ProductTypeBUS.GetInstance();
            shelfBUS = ShelfBUS.GetInstance();
            loadProductData();
            this.formShelfManagement = formShelfManagement;
        }
        private async void loadProductData()
        {
            Result<IEnumerable<DTO.ProductType>> result = await productTypeBUS.getAllProductType();
            if (result.IsSuccess)
            {
                cbBoxShelfType.DataSource = result.Data;
                cbBoxShelfType.DisplayMember = "ProductTypeName"; // Hiển thị thuộc tính "Ten" của đối tượng
                cbBoxShelfType.ValueMember = "ProductTypeID";    // Sử dụng thuộc tính "Id" của đối tượng khi chọn mục
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {         
                DTO.Shelf shelf = new DTO.Shelf();
                shelf.ShelfFloor = int.Parse(txtBoxShelfFloor.Text);
                shelf.LayerCapacity = int.Parse(txtBoxLayerCapacity.Text);
                shelf.LayerQuantity = int.Parse(txtBoxNumberOfLayer.Text);
                shelf.ProductTypeID = int.Parse(cbBoxShelfType.SelectedValue.ToString());
                shelf.Status = "Available";
                Result<DTO.Shelf> resultShelf = await shelfBUS.AddShelf(shelf);
                if(resultShelf.IsSuccess)
                {
                    formShelfManagement.InitAllShelf();
                    MessageBox.Show("Create shelf success");
                    this.Close();
                }
                else
                {
                    MessageBox.Show(resultShelf.ErrorMessage);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtBoxLayerCapacity_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtBoxLayerCapacity.Text) && !string.IsNullOrEmpty(txtBoxLayerCapacity.Text))
                txtBoxTotalCapacity.Text = (int.Parse(txtBoxLayerCapacity.Text.Trim()) * int.Parse(txtBoxNumberOfLayer.Text.Trim())).ToString();
            else
            {
                txtBoxTotalCapacity.Text = "0";
            }
        }

        private void txtBoxNumberOfLayer_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxLayerCapacity.Text) && !string.IsNullOrEmpty(txtBoxLayerCapacity.Text))
                txtBoxTotalCapacity.Text = (int.Parse(txtBoxLayerCapacity.Text.Trim()) * int.Parse(txtBoxNumberOfLayer.Text.Trim())).ToString();
            else
            {
                txtBoxTotalCapacity.Text = "0";
            }
        }
    }
}
