using Guna.UI2.WinForms;
using SupermarketManagementApp.BUS;
using SupermarketManagementApp.DTO;
using SupermarketManagementApp.GUI.Invoice.CustomerInvoice;
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

namespace SupermarketManagementApp.GUI.Product.ProductInInventory
{
    public partial class FormProductInventoryManagement : Form
    {
        private FormMain formMain;
        private Guna2DataGridView gridView = null;
        private  float INVENTORY_CAPACITY = StaticGlobal.SYSTEM_CAPACITY;
        private int usedInventoryCapacity = 0;
        private InvetoryDetailBUS invetoryDetailBUS = null;
        public FormProductInventoryManagement()
        {
            InitializeComponent();
        }

        public FormProductInventoryManagement(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.gridView = gridViewMain;
            invetoryDetailBUS = InvetoryDetailBUS.GetInstance();
            CustomStyleGridView();
            LoadGridData();
            UpdateProgressBar();
            UpdateScrollBarValues();
        }

        private void UpdateProgressBar()
        {
            availableCapacity.Value = usedInventoryCapacity;
            availableCapacity.Maximum = (int) INVENTORY_CAPACITY;

            int remaining =(int) INVENTORY_CAPACITY - usedInventoryCapacity;
            if (usedInventoryCapacity <= INVENTORY_CAPACITY)
            {
                availableCapacity.ProgressColor = Color.ForestGreen;
                availableCapacity.ProgressColor2 = Color.ForestGreen;
            }
            else
            {
                availableCapacity.ProgressColor = Color.Firebrick;
                availableCapacity.ProgressColor2 = Color.Firebrick;
            }
            availableCapacity.Text = ("Capacity: " + usedInventoryCapacity + " used, " + remaining + " remaining.");
        }

        private async void LoadGridData()
        {
            Result<IEnumerable<InventoryDetail>> result = await invetoryDetailBUS.getAllInventoryDetail();
            foreach(InventoryDetail inventoryDetail in result.Data) {
                usedInventoryCapacity += inventoryDetail.ProductQuantity * inventoryDetail.Product.ProductCapacity;
                gridView.Rows.Add(new object[] { null, inventoryDetail.Product.ProductName, inventoryDetail.ProductQuantity, inventoryDetail.Product.ProductCapacity, inventoryDetail.ProductQuantity * inventoryDetail.Product.ProductCapacity, null });
            }
            UpdateProgressBar();
            UpdateScrollBarValues();
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
                    for (int i = 1; i < col + 1; i++)
                    {
                        if (i == 1) continue;
                        XcelApp.Cells[1, i - 1] = gridView.Columns[i - 1].HeaderText;
                    }

                    // Get data of cells
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 1; j < col; j++)
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
            if (!scrollBar.Visible)
            {
                return;
            }
            int delta = e.Delta;
            int newScrollBarValue = scrollBar.Value - delta / 100;
            scrollBar.Value = Math.Max(scrollBar.Minimum, Math.Min(scrollBar.Maximum, newScrollBarValue));
        }

        private void scrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            if (scrollBar.Visible)
            {
                gridView.FirstDisplayedScrollingRowIndex = scrollBar.Value;
            }
        }

        private void gridViewMain_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            gridView.Cursor = Cursors.Default;
        }

        private void gridViewMain_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                if (e.ColumnIndex >= 1 && e.ColumnIndex <= 4)
                {
                    gridView.Cursor = Cursors.Hand;
                    return;
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                gridView.Cursor = Cursors.Hand;
                return;
            }

            gridView.Cursor = Cursors.Default;
        }
        #endregion
    }
}
