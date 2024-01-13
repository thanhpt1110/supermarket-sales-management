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

namespace SupermarketManagementApp.GUI.Product.ProductType
{
    public partial class FormProductTypeManagement : Form
    {
        #region Declare variable
        private Guna2DataGridView gridView = null;
        private FormMain formMain = null;
        private Timer searchTimer = null;
        private ProductTypeBUS productTypeBUS = null;
        #endregion
        private List<SupermarketManagementApp.DTO.ProductType> productTypes = null;
        public FormProductTypeManagement(FormMain formMain)
        {
            this.formMain = formMain;
            productTypeBUS = ProductTypeBUS.GetInstance();
            InitializeComponent();
            CustomStyleGridView();
            UpdateScrollBarValues();
            InitAllProductType();
            InitTimer();
        }

        public FormProductTypeManagement()
        {
            productTypeBUS = ProductTypeBUS.GetInstance();
            InitializeComponent();
            CustomStyleGridView();
            UpdateScrollBarValues();
            InitAllProductType();
            InitTimer();
        }
        public async void InitAllProductType()
        {
            Result<IEnumerable<DTO.ProductType>> productTypeResult = await productTypeBUS.getAllProductType();
            if (productTypeResult.IsSuccess)
            {
                this.productTypes = productTypeResult.Data.ToList();
            }
            else
            {

            }
            LoadGridData();
        }
        private void LoadGridData()
        {
            gridView.Rows.Clear();
            foreach (var productType in productTypes)
            {
                gridView.Rows.Add(new object[] { null, productType.ProductTypeID, productType.ProductTypeName, productType.Description,productType.MinTemperature, productType.MaxTemperature });
            }
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
                if (e.ColumnIndex >= 2 && e.ColumnIndex <= 5)
                {
                    gridView.Cursor = Cursors.Hand;
                    return;
                }
            }

            // Nếu không phải là header của cột và nằm trong khoảng cột 4, 5, đặt kiểu cursor thành Hand
            if (e.RowIndex >= 0 && (e.ColumnIndex == 6 || e.ColumnIndex == 7))
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
                using (FormCreateProductType formCreateProductType = new FormCreateProductType(this))
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
                if (gridView.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();
                    XcelApp.Application.Workbooks.Add(Type.Missing);

                    int row = gridView.Rows.Count;
                    int col = gridView.Columns.Count;

                    // Get Header text of Column
                    for (int i = 1; i < col - 2 + 1; i++)
                    {
                        if (i == 1) continue;
                        XcelApp.Cells[1, i - 1] = gridView.Columns[i - 1].HeaderText;
                    }

                    // Get data of cells
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 1; j < col - 2; j++)
                        {
                            XcelApp.Cells[i + 2, j] = gridView.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    XcelApp.Columns.AutoFit();
                    XcelApp.Visible = true;
                }
                else
                {
                    msgBoxError.Parent = formMain;
                    msgBoxError.Show("Error");
                }
            }
            catch (Exception ex)
            {
                msgBoxError.Parent = formMain;
                msgBoxError.Show(ex.Message, "Error");
            }
        }

        private async void gridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    // Update
                    FormBackground formBackground = new FormBackground(formMain);
                    try
                    {
                        using (FormUpdateProductType formUpdateProductType = new FormUpdateProductType(this, int.Parse(gridView.Rows[y].Cells[1].Value.ToString())))
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
                else if (e.ColumnIndex == 7)
                {
                    // Delete
                    msgBoxDelete.Parent = formMain;
                    DialogResult dr = msgBoxDelete.Show();
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            try
                            {
                                Result<bool> result = await productTypeBUS.deteleProductType(int.Parse(gridView.Rows[y].Cells[1].Value.ToString()));
                                if (result.IsSuccess)
                                {
                                    MessageBox.Show("Remove Product Type successfully!", "Success", MessageBoxButtons.OK);
                                    InitAllProductType();
                                }
                                else
                                {
                                    msgBoxError.Show(result.ErrorMessage, "Error");

                                }
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

        #region Init timer event
        private void InitTimer()
        {
            searchTimer = new Timer();
            searchTimer.Interval = 300;
            searchTimer.Tick += SearchTimer_Tick;
        }
        private async void SearchTimer_Tick(object sender, EventArgs e)
        {
            this.searchTimer.Stop();
            Result<IEnumerable<DTO.ProductType>> result = await productTypeBUS.findProductTypeByName(txtBoxSearchProductType.Text);
            this.productTypes = result.Data.ToList();
            LoadGridData();
        }
        #endregion

        #region Text changed event
        private void txtBoxSearchProductType_TextChanged_1(object sender, EventArgs e)
        {
            this.searchTimer.Stop();
            this.searchTimer.Start();
        }

        #endregion


    }
}
