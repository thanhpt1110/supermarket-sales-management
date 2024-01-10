using Guna.UI2.WinForms;
using SupermarketManagementApp.GUI.Account;
using SupermarketManagementApp.GUI.Customer;
using SupermarketManagementApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SupermarketManagementApp.GUI.Product
{
    public partial class FormProductManagement : Form
    {
        #region Declare variable
        private Guna2DataGridView gridView = null;
        private FormMain formMain = null;
        #endregion

        public FormProductManagement(FormMain formMain)
        {
            this.formMain = formMain;

            InitializeComponent();
            CustomStyleGridView();
            LoadGridData();
            UpdateScrollBarValues();
        }

        public FormProductManagement()
        {
            InitializeComponent();
            CustomStyleGridView();
            LoadGridData();
            UpdateScrollBarValues();
        }

        private void LoadGridData()
        {
            gridView.Rows.Add(new object[] { null, "Milk", "Dairy", 25000, "Carton", "Bottle", 12 });
            gridView.Rows.Add(new object[] { null, "Bread", "Bakery", 18000, "Loaf", "Piece", 1 });
            gridView.Rows.Add(new object[] { null, "Rice", "Grains", 30000, "Bag", "Kilogram", 2 });
            gridView.Rows.Add(new object[] { null, "Chocolate", "Sweets", 35000, "Packet", "Bar", 5 });
            gridView.Rows.Add(new object[] { null, "Coffee", "Beverages", 40000, "Can", "Gram", 250 });
            gridView.Rows.Add(new object[] { null, "Eggs", "Dairy", 5000, "Dozen", "Unit", 12 });
            gridView.Rows.Add(new object[] { null, "Toothpaste", "Toiletries", 15000, "Tube", "Piece", 1 });
            gridView.Rows.Add(new object[] { null, "Apples", "Fruits", 12000, "Basket", "Kilogram", 5 });
            gridView.Rows.Add(new object[] { null, "Chicken Breast", "Meat", 70000, "Pack", "Kilogram", 1 });
            gridView.Rows.Add(new object[] { null, "Orange Juice", "Beverages", 25000, "Bottle", "Liter", 1 });
            gridView.Rows.Add(new object[] { null, "Potato Chips", "Snacks", 18000, "Pack", "Gram", 150 });
            gridView.Rows.Add(new object[] { null, "T-shirt", "Clothing", 80000, "Piece", "Piece", 1 });
        }

        #region Customize data grid
        private void CustomStyleGridView()
        {
            gridView = gridViewMain;
            gridView.ColumnHeadersDefaultCellStyle.Font = new Font(gridView.Font, FontStyle.Bold);
            gridView.DefaultCellStyle.Font = new Font("Segoe UI", 12);
        }

        private void UpdateScrollBarValues()
        {
            scrollBar.Minimum = 0;

            int numberOfRows = gridView.Rows.Count;
            scrollBar.Maximum = numberOfRows - 1;

            if (numberOfRows <= gridView.DisplayedRowCount(false))
            {
                scrollBar.Visible = false;
            }
            else
            {
                scrollBar.Visible = true;
            }
            scrollBar.Value = gridView.FirstDisplayedScrollingRowIndex;
            gridView.MouseWheel += GridView_MouseWheel;
        }

        private void GridView_MouseWheel(object sender, MouseEventArgs e)
        {
            int delta = e.Delta; 
            int newScrollBarValue = scrollBar.Value - delta / 100;
            scrollBar.Value = Math.Max(scrollBar.Minimum, Math.Min(scrollBar.Maximum, newScrollBarValue));
        }

        private void scrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            gridView.FirstDisplayedScrollingRowIndex = scrollBar.Value;
        }

        private void gridViewMain_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            // Khi rời khỏi ô, đặt kiểu cursor mặc định
            gridView.Cursor = Cursors.Default;
        }

        private void gridViewMain_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Kiểm tra xem có phải là header của cột không
            if (e.RowIndex == -1)
            {
                // Kiểm tra xem có phải là header của cột 2, 3, 4 hoặc header của cột 4, 5
                if (e.ColumnIndex >= 1 && e.ColumnIndex <= 6)
                {
                    gridView.Cursor = Cursors.Hand;
                    return;
                }
            }

            // Nếu không phải là header của cột và nằm trong khoảng cột 4, 5, đặt kiểu cursor thành Hand
            if (e.RowIndex >= 0 && (e.ColumnIndex == 7 || e.ColumnIndex == 8 || e.ColumnIndex == 9))
            {
                gridView.Cursor = Cursors.Hand;
                return;
            }

            // Nếu không phải là header của cột hoặc không phải là cột 4, 5, đặt kiểu cursor mặc định
            gridView.Cursor = Cursors.Default;
        }
        #endregion

        #region Click event
        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            FormBackground formBackground = new FormBackground(formMain);
            try
            {
                using (FormCreateProduct formCreateProduct = new FormCreateProduct())
                {
                    formBackground.Owner = formMain;
                    formBackground.Show();
                    formCreateProduct.Owner = formBackground;
                    formCreateProduct.ShowDialog();
                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                msgBoxError.Parent = formMain;
                msgBoxError.Show(ex.Message, "Error");
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                msgBoxError.Parent = formMain;
                msgBoxError.Show();
            }
            catch (Exception ex)
            {
                msgBoxError.Parent = formMain;
                msgBoxError.Show(ex.Message, "Error");
            }
        }

        private void gridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 7)
                {
                    // Update
                    FormBackground formBackground = new FormBackground(formMain);
                    try
                    {
                        using (FormInforProduct formInforProduct = new FormInforProduct())
                        {
                            formBackground.Owner = formMain;
                            formBackground.Show();
                            formInforProduct.Owner = formBackground;
                            formInforProduct.ShowDialog();
                            formBackground.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        msgBoxError.Parent = formMain;
                        msgBoxError.Show(ex.Message, "Error");
                    }
                }
                else if (e.ColumnIndex == 8)
                {
                    // Update
                    FormBackground formBackground = new FormBackground(formMain);
                    try
                    {
                        using (FormUpdateProduct formUpdateProduct = new FormUpdateProduct())
                        {
                            formBackground.Owner = formMain;
                            formBackground.Show();
                            formUpdateProduct.Owner = formBackground;
                            formUpdateProduct.ShowDialog();
                            formBackground.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        msgBoxError.Parent = formMain;
                        msgBoxError.Show(ex.Message, "Error");
                    }
                }
                else if (e.ColumnIndex == 9)
                {
                    // Delete
                    msgBoxDelete.Parent = formMain;
                    DialogResult dr = msgBoxDelete.Show();
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            try
                            {

                            }
                            catch (Exception ex)
                            {
                                msgBoxError.Parent = formMain;
                                msgBoxError.Show(ex.Message, "Error");
                            }
                            break;
                        case DialogResult.No:
                            break;
                    }
                }
            }
        }
        #endregion
    }
}
