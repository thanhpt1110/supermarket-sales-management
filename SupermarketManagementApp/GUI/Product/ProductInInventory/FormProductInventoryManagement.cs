using Guna.UI2.WinForms;
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
        private const int INVENTORY_CAPACITY = 100;

        public FormProductInventoryManagement()
        {
            InitializeComponent();
        }

        public FormProductInventoryManagement(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            this.gridView = gridViewMain;
            CustomStyleGridView();
            LoadGridData();
            LoadAvailableCapacity();
            UpdateScrollBarValues();
        }

        private void LoadAvailableCapacity()
        {
            availableCapacity.Minimum = 0;
            availableCapacity.Maximum = INVENTORY_CAPACITY;

            int used = 39;
            availableCapacity.Value = used;

            int remaining = INVENTORY_CAPACITY - used;
            availableCapacity.Text = ("Capacity: " + used + " used, " + remaining + " remaining.");
        }

        private void LoadGridData()
        {
            gridView.Rows.Add(new object[] { null, "Bakery", 12, 10, 120, null });
            gridView.Rows.Add(new object[] { null, "Bakery", 12, 10, 120, null });
            gridView.Rows.Add(new object[] { null, "Bakery", 12, 10, 120, null });
            gridView.Rows.Add(new object[] { null, "Bakery", 12, 10, 120, null });
            gridView.Rows.Add(new object[] { null, "Bakery", 12, 10, 120, null });
            gridView.Rows.Add(new object[] { null, "Bakery", 12, 10, 120, null });
            gridView.Rows.Add(new object[] { null, "Bakery", 12, 10, 120, null });
            gridView.Rows.Add(new object[] { null, "Bakery", 12, 10, 120, null });
            gridView.Rows.Add(new object[] { null, "Bakery", 12, 10, 120, null });
            gridView.Rows.Add(new object[] { null, "Bakery", 12, 10, 120, null });
            gridView.Rows.Add(new object[] { null, "Bakery", 12, 10, 120, null });
            gridView.Rows.Add(new object[] { null, "Bakery", 12, 10, 120, null });
            gridView.Rows.Add(new object[] { null, "Bakery", 12, 10, 120, null });
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
