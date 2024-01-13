using Guna.UI2.WinForms;
using SupermarketManagementApp.BUS;
using SupermarketManagementApp.DTO;
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
using static System.Net.Mime.MediaTypeNames;

namespace SupermarketManagementApp.GUI.Product.ProductOnShelf
{
    public partial class FormDetailProductOnShelf : Form
    {
        private int totalShelfCapacity = 0;
        private int usedShelfCapacity = 0;
        private FormShelfMap formProductShelfManagement;
        private ShelfBUS shelfBUS;
        private Dictionary<int, ShelfDetail> dictionaryShelf;
        private List<DTO.Product> listProduct;
        private ProductBUS productBUS;
        private List<string> listProductName;
        public FormDetailProductOnShelf(FormShelfMap formProductShelfManagement,int shelfID, int totalCapacity, string name)
        {
            this.formProductShelfManagement = formProductShelfManagement;
            shelfBUS = ShelfBUS.GetInstance();
            productBUS = ProductBUS.GetInstance();
            InitializeComponent();
            this.totalShelfCapacity = totalCapacity;
            this.labelName.Text = name;
            totalShelfCapacity = 50000;
            dictionaryShelf = new Dictionary<int, ShelfDetail>();
            getShelf(shelfID);
        }
        private async void getShelf(int id)
        {
            Result<DTO.Shelf> result = await shelfBUS.getShelfByID(id);
            Result<IEnumerable<DTO.Product>> resultProduct = await productBUS.getAllProduct();
            if(resultProduct.IsSuccess) {
                this.listProduct = resultProduct.Data.ToList();
                listProductName = listProduct.Select(p=>p.ProductName).ToList();
            }
            if(result.IsSuccess)
            {
                foreach(ShelfDetail shelfDetail in result.Data.ShelfDetails)
                {
                    dictionaryShelf[shelfDetail.ShelfDetailID] = new ShelfDetail() {ShelfDetailID = shelfDetail.ShelfDetailID
                        , ShelfID = shelfDetail.ShelfID, Shelf = shelfDetail.Shelf, Product = shelfDetail.Product, ProductID = shelfDetail.ProductID, ProductQuantity = shelfDetail.ProductQuantity};
                    int layerUsedCapacity = 0;

                    if (shelfDetail.Product != null)
                    {
                        layerUsedCapacity = shelfDetail.ProductQuantity * shelfDetail.Product.ProductCapacity;
                    }    
                    panelLayerContainer.Controls.Add(ShelfLayer(layerUsedCapacity, result.Data.LayerCapacity, dictionaryShelf[shelfDetail.ShelfDetailID]));

                }
            }    
        }
        List<string> products = new List<string>
            {
                "Abc",
                "bac",
                "cdad",
            };

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            List<ShelfDetail> shelfDetails = dictionaryShelf.Values.ToList();
            Result<List<ShelfDetail>> result = await shelfBUS.updateShelfDetail(shelfDetails);
            if(result.IsSuccess)
            {
                MessageBox.Show("Update shelf success");
                this.Close();

            }
            else
            {
                MessageBox.Show(result.ErrorMessage, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }
        }

        private void UpdateProgressBar(Guna2ProgressBar progressBar, int used, int total)
        {
            progressBar.Value = used;
            progressBar.Maximum = total;

            int remaining = total - used;
            if (used <= total)
            {
                progressBar.ProgressColor = Color.ForestGreen;
                progressBar.ProgressColor2 = Color.ForestGreen;
            }
            else
            {
                progressBar.ProgressColor = Color.Firebrick;
                progressBar.ProgressColor2 = Color.Firebrick;
            }

            progressBar.Text = ("Capacity: " + used + " used, " + remaining + " remaining.");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
/*            int layerUsedCapacity = 0;
            int layerTotalCapacity = 2000;
            panelLayerContainer.Controls.Add(ShelfLayer(layerUsedCapacity, layerTotalCapacity));

            layerUsedCapacity = 23;
            layerTotalCapacity = 1000;
            panelLayerContainer.Controls.Add(ShelfLayer(layerUsedCapacity, layerTotalCapacity));    */
        }

        private Guna2Panel ShelfLayer(int layerUsedCapacity, int layerTotalCapacity, ShelfDetail shelfDetail) 
        {
            #region Declare control
            Guna2Panel shelfLayer = new Guna2Panel();

            Guna2HtmlLabel labelProductName = new Guna2HtmlLabel();
            Guna2HtmlLabel labelQuantity = new Guna2HtmlLabel();
            Guna2HtmlLabel labelCapacity = new Guna2HtmlLabel();
            Guna2HtmlLabel labelTotalCapacity = new Guna2HtmlLabel();

            Guna2TextBox txtBoxProductName = new Guna2TextBox();
            Guna2TextBox txtBoxQuantity = new Guna2TextBox();
            Guna2TextBox txtBoxCapacity = new Guna2TextBox();
            Guna2TextBox txtBoxTotalCapacity = new Guna2TextBox();

            Guna2ProgressBar layerCapacity = new Guna2ProgressBar();
            #endregion

            #region Custom Layer UI
            shelfLayer.Anchor = System.Windows.Forms.AnchorStyles.None;
            shelfLayer.BorderColor = System.Drawing.Color.Black;
            shelfLayer.CustomBorderColor = System.Drawing.Color.Black;
            shelfLayer.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            shelfLayer.Location = new System.Drawing.Point(10, 10);
            shelfLayer.Margin = new System.Windows.Forms.Padding(20, 5, 2, 5);
            shelfLayer.Name = "layerShelf";
            shelfLayer.Size = new System.Drawing.Size(860, 125);
            shelfLayer.TabIndex = 0;
            #endregion

            #region Custom lable Product Name
            labelProductName.BackColor = System.Drawing.Color.Transparent;
            labelProductName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            labelProductName.Location = new System.Drawing.Point(21, 4);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new System.Drawing.Size(103, 23);
            labelProductName.TabIndex = 19;
            labelProductName.Text = "Product Name";
            #endregion

            #region Custom lable Quantity
            labelQuantity.BackColor = System.Drawing.Color.Transparent;
            labelQuantity.Location = new System.Drawing.Point(280, 4);
            labelQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            labelQuantity.Name = "labelProductName";
            labelQuantity.Size = new System.Drawing.Size(103, 23);
            labelQuantity.TabIndex = 19;
            labelQuantity.Text = "Quantity";
            #endregion

            #region Custom lable Capacity
            labelCapacity.BackColor = System.Drawing.Color.Transparent;
            labelCapacity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            labelCapacity.Location = new System.Drawing.Point(452, 4);
            labelCapacity.Name = "labelCapacity";
            labelCapacity.Size = new System.Drawing.Size(103, 23);
            labelCapacity.TabIndex = 19;
            labelCapacity.Text = "Capacity";
            #endregion

            #region Custom lable Total Capacity
            labelTotalCapacity.BackColor = System.Drawing.Color.Transparent;
            labelTotalCapacity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            labelTotalCapacity.Location = new System.Drawing.Point(659, 4);
            labelTotalCapacity.Name = "labelTotalCapacity";
            labelTotalCapacity.Size = new System.Drawing.Size(103, 23);
            labelTotalCapacity.TabIndex = 19;
            labelTotalCapacity.Text = "Total Capacity";
            #endregion

            #region Custom text box Product Name
            txtBoxProductName.BorderColor = System.Drawing.Color.Black;
            txtBoxProductName.BorderRadius = 5;
            txtBoxProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtBoxProductName.DefaultText = "";
            txtBoxProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            txtBoxProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            txtBoxProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            txtBoxProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            txtBoxProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            txtBoxProductName.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtBoxProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            txtBoxProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            txtBoxProductName.Margin = new System.Windows.Forms.Padding(5);
            txtBoxProductName.MaxLength = 10;
            txtBoxProductName.Location = new Point(21, 35);
            txtBoxProductName.Name = "txtBoxProductName";
            txtBoxProductName.PasswordChar = '\0';
            txtBoxProductName.PlaceholderText = "";
            txtBoxProductName.SelectedText = "";
            txtBoxProductName.Size = new System.Drawing.Size(221, 36);
            txtBoxProductName.TabIndex = 12;
            if (shelfDetail.Product != null)
                txtBoxProductName.Text = shelfDetail.Product.ProductName;
            else
                txtBoxProductName.Text = "";
            txtBoxProductName.TextOffset = new System.Drawing.Point(5, 0);
            txtBoxProductName.AutoCompleteCustomSource.AddRange(listProductName.ToArray());
            txtBoxProductName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBoxProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtBoxProductName.TextChanged += (sender, e) =>
            {
                var productSearch = listProduct.FirstOrDefault(p => p.ProductName == txtBoxProductName.Text);
                dictionaryShelf[shelfDetail.ShelfDetailID].Product = productSearch;
                if (productSearch != null)
                    txtBoxCapacity.Text = productSearch.ProductCapacity.ToString();
                else
                {
                    txtBoxCapacity.Text = "0";
                    dictionaryShelf[shelfDetail.ShelfDetailID].ProductID = null;
                }
            };
            #endregion

            #region Custom text box Quantity
            txtBoxQuantity.BorderColor = System.Drawing.Color.Black;
            txtBoxQuantity.BorderRadius = 5;
            txtBoxQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtBoxQuantity.DefaultText = "";
            txtBoxQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            txtBoxQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            txtBoxQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            txtBoxQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            txtBoxQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            txtBoxQuantity.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtBoxQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            txtBoxQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            txtBoxQuantity.Margin = new System.Windows.Forms.Padding(5);
            txtBoxQuantity.MaxLength = 10;
            txtBoxQuantity.Location = new Point(280, 35);
            txtBoxQuantity.Name = "txtBoxQuantity";
            txtBoxQuantity.PasswordChar = '\0';
            txtBoxQuantity.PlaceholderText = "";
            txtBoxQuantity.SelectedText = "";
            txtBoxQuantity.Size = new System.Drawing.Size(139, 36);
            txtBoxQuantity.TabIndex = 12;
            txtBoxQuantity.Text = shelfDetail.ProductQuantity.ToString();
            txtBoxQuantity.TextOffset = new System.Drawing.Point(5, 0);

            txtBoxQuantity.TextChanged += (sender, e) =>
            {
                if (txtBoxQuantity.Text == string.Empty)
                {
                    txtBoxQuantity.Text = "0";
                    shelfDetail.ProductQuantity = 0;
                }
                int quantityValue, capacityValue;
                if (int.TryParse(txtBoxQuantity.Text, out quantityValue) && int.TryParse(txtBoxCapacity.Text, out capacityValue))
                {
                    shelfDetail.ProductQuantity = quantityValue;
                    int _totalCapacity = quantityValue * capacityValue;
                    layerUsedCapacity = _totalCapacity;
                    txtBoxTotalCapacity.Text = _totalCapacity.ToString();
                }
                else
                {
                    msgBoxError.Parent = this;
                    msgBoxError.Show("Please enter number only!");
                }

            };
            #endregion

            #region Custom text box Capacity
            txtBoxCapacity.BorderColor = Color.Black;
            txtBoxCapacity.BorderRadius = 5;
            txtBoxCapacity.DefaultText = "";
            txtBoxCapacity.DisabledState.BorderColor = System.Drawing.Color.Black;
            txtBoxCapacity.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke;
            txtBoxCapacity.DisabledState.ForeColor = System.Drawing.Color.Black;
            txtBoxCapacity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            txtBoxCapacity.Enabled = false;
            txtBoxCapacity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            txtBoxCapacity.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtBoxCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            txtBoxCapacity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            txtBoxCapacity.Location = new System.Drawing.Point(452, 35);
            txtBoxCapacity.Margin = new System.Windows.Forms.Padding(5);
            txtBoxCapacity.MaxLength = 10;
            txtBoxCapacity.Name = "txtBoxCapacity";
            txtBoxCapacity.PasswordChar = '\0';
            txtBoxCapacity.PlaceholderText = "";
            txtBoxCapacity.SelectedText = "";
            txtBoxCapacity.Size = new System.Drawing.Size(175, 36);
            txtBoxCapacity.TabIndex = 15;
            if(shelfDetail.Product!=null)
            {
                txtBoxCapacity.Text = shelfDetail.Product.ProductCapacity.ToString();
            }
            else
            {
                txtBoxCapacity.Text = "0";
            }
            txtBoxCapacity.TextOffset = new System.Drawing.Point(5, 0);
            #endregion

            #region Custom text box TotalCapacity
            txtBoxTotalCapacity.BorderColor = Color.Black;
            txtBoxTotalCapacity.BorderRadius = 5;
            txtBoxTotalCapacity.DefaultText = "";
            txtBoxTotalCapacity.DisabledState.BorderColor = System.Drawing.Color.Black;
            txtBoxTotalCapacity.DisabledState.FillColor = System.Drawing.Color.WhiteSmoke;
            txtBoxTotalCapacity.DisabledState.ForeColor = System.Drawing.Color.Black;
            txtBoxTotalCapacity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            txtBoxTotalCapacity.Enabled = false;
            txtBoxTotalCapacity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            txtBoxTotalCapacity.Font = new System.Drawing.Font("Segoe UI", 12F);
            txtBoxTotalCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            txtBoxTotalCapacity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            txtBoxTotalCapacity.Location = new System.Drawing.Point(659, 35);
            txtBoxTotalCapacity.Margin = new System.Windows.Forms.Padding(5);
            txtBoxTotalCapacity.MaxLength = 10;
            txtBoxTotalCapacity.Name = "txtBoxTotalCapacity";
            txtBoxTotalCapacity.PasswordChar = '\0';
            txtBoxTotalCapacity.PlaceholderText = "";
            txtBoxTotalCapacity.SelectedText = "";
            txtBoxTotalCapacity.Size = new System.Drawing.Size(175, 36);
            txtBoxTotalCapacity.TabIndex = 15;
            if (shelfDetail.Product != null)
                txtBoxTotalCapacity.Text = (shelfDetail.Product.ProductCapacity * shelfDetail.ProductQuantity).ToString();
            else
                txtBoxCapacity.Text = "0";
            txtBoxTotalCapacity.TextOffset = new System.Drawing.Point(5, 0);

            txtBoxTotalCapacity.TextChanged += (sender, e) =>
            {
                usedShelfCapacity = 0;

                foreach (Guna2Panel layer in panelLayerContainer.Controls)
                {
                    foreach (Control control in layer.Controls)
                    {
                        if (control.Name == "txtBoxTotalCapacity")
                        {
                            int value;
                            if (int.TryParse(control.Text, out value))
                            {
                                usedShelfCapacity += value;
                            }
                            break;
                        }
                    }
                }
                UpdateProgressBar(shelfCapacity, usedShelfCapacity, totalShelfCapacity);
                UpdateProgressBar(layerCapacity, layerUsedCapacity, layerTotalCapacity);
            };
            #endregion

            #region Custom layer capacity
            layerCapacity.Minimum = 0;
            layerCapacity.Maximum = layerTotalCapacity;
            layerCapacity.Value = layerUsedCapacity;
            layerCapacity.BorderColor = System.Drawing.Color.WhiteSmoke;
            layerCapacity.BorderRadius = 10;
            layerCapacity.BorderThickness = 1;
            layerCapacity.FillColor = System.Drawing.Color.Gray;
            layerCapacity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            layerCapacity.ForeColor = System.Drawing.Color.White;
            layerCapacity.Location = new System.Drawing.Point(23, 89);
            layerCapacity.Name = "layerCapacity";
            layerCapacity.ProgressColor = System.Drawing.Color.ForestGreen;
            layerCapacity.ProgressColor2 = System.Drawing.Color.ForestGreen;
            layerCapacity.ShowText = true;
            layerCapacity.Size = new System.Drawing.Size(813, 20);
            layerCapacity.TabIndex = 24;
            layerCapacity.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            layerCapacity.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            #endregion

            // Add controls here
            shelfLayer.Controls.Add(labelProductName);
            shelfLayer.Controls.Add(labelQuantity);
            shelfLayer.Controls.Add(labelCapacity);
            shelfLayer.Controls.Add(labelTotalCapacity);

            shelfLayer.Controls.Add(txtBoxProductName);
            shelfLayer.Controls.Add(txtBoxQuantity);
            shelfLayer.Controls.Add(txtBoxCapacity);
            shelfLayer.Controls.Add(txtBoxTotalCapacity);

            UpdateProgressBar(layerCapacity, layerUsedCapacity, layerTotalCapacity);
            shelfLayer.Controls.Add(layerCapacity);
            return shelfLayer;
        }
    }
}
