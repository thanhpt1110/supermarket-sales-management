using Guna.UI2.WinForms;
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
    public partial class FormProductTypeManagement : Form
    {
        #region Declare variable
        private Guna2DataGridView gridView = null;
        private FormMain formMain = null;
        #endregion

        public FormProductTypeManagement(FormMain formMain)
        {
            this.formMain = formMain;

            InitializeComponent();
            CustomStyleGridView();
            LoadGridData();
            UpdateScrollBarValues();
        }

        public FormProductTypeManagement()
        {
            InitializeComponent();
            CustomStyleGridView();
            LoadGridData();
            UpdateScrollBarValues();
        }

        private void LoadGridData()
        {
            gridView.Rows.Add(new object[] { null, "Dried goods", "Includes bread, powdered milk, canned goods, beverages, household items, groceries, snacks, toiletries cosmetic." });
            gridView.Rows.Add(new object[] { null, "Frozen foods", "Includes dairy products, meat, fish, chicken, fruit." });
            gridView.Rows.Add(new object[] { null, "Deli counter", "Place selling pre-cooked food." });
            gridView.Rows.Add(new object[] { null, "Electronics", "Includes electronic devices." });
            gridView.Rows.Add(new object[] { null, "Sporting goods", "Includes sports-related items." });
            gridView.Rows.Add(new object[] { null, "Pet supplies", "Includes items for pets." });
            gridView.Rows.Add(new object[] { null, "Fresh flowers", "Includes fresh flowers." });
            gridView.Rows.Add(new object[] { null, "Vegetables and Fruit", "Includes various vegetables and fruits." });
            gridView.Rows.Add(new object[] { null, "Beverages", "Includes various drinks." });
            gridView.Rows.Add(new object[] { null, "Snacks", "Includes various snacks." });
            gridView.Rows.Add(new object[] { null, "Dairy products", "Includes dairy products like yogurts, cheese." });
            gridView.Rows.Add(new object[] { null, "Household items", "Includes household items." });
            gridView.Rows.Add(new object[] { null, "Groceries", "Includes grocery items." });
            gridView.Rows.Add(new object[] { null, "Toiletries cosmetic", "Includes toiletries cosmetic items." });
            gridView.Rows.Add(new object[] { null, "Powdered milk", "Includes various powdered milk." });
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
                if (e.ColumnIndex >= 1 && e.ColumnIndex <= 2)
                {
                    gridView.Cursor = Cursors.Hand;
                    return;
                }
            }

            // Nếu không phải là header của cột và nằm trong khoảng cột 4, 5, đặt kiểu cursor thành Hand
            if (e.RowIndex >= 0 && (e.ColumnIndex == 3 || e.ColumnIndex == 4))
            {
                gridView.Cursor = Cursors.Hand;
                return;
            }

            // Nếu không phải là header của cột hoặc không phải là cột 4, 5, đặt kiểu cursor mặc định
            gridView.Cursor = Cursors.Default;
        }
        #endregion

        #region Click event
        private void btnCreateProductType_Click(object sender, EventArgs e)
        {
            FormBackground formBackground = new FormBackground(formMain);
            try
            {
                using (FormCreateProductType formCreateProductType = new FormCreateProductType())
                {
                    formBackground.Owner = formMain;
                    formBackground.Show();
                    formCreateProductType.Owner = formBackground;
                    formCreateProductType.ShowDialog();
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
                if (e.ColumnIndex == 3)
                {
                    // Update
                    FormBackground formBackground = new FormBackground(formMain);
                    try
                    {
                        using (FormUpdateProductType formUpdateProductType = new FormUpdateProductType())
                        {
                            formBackground.Owner = formMain;
                            formBackground.Show();
                            formUpdateProductType.Owner = formBackground;
                            formUpdateProductType.ShowDialog();
                            formBackground.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        msgBoxError.Parent = formMain;
                        msgBoxError.Show(ex.Message, "Error");
                    }
                }
                else if (e.ColumnIndex == 4)
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
