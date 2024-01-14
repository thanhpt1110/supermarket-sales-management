using Guna.UI2.WinForms;
using SupermarketManagementApp.BUS;
using SupermarketManagementApp.GUI.Product;
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
    public partial class FormShelfManagement : Form
    {
        #region Declare variable
        private Guna2DataGridView gridView = null;
        private FormMain formMain = null;
        #endregion
        private ShelfBUS shelfBUS = null;
        private List<DTO.Shelf> shelves = null;
        private ProductTypeBUS productTypeBUS = null;
        private Timer timer = null;
        public FormShelfManagement(FormMain formMain)
        {
          
            this.formMain = formMain;
            shelfBUS = ShelfBUS.GetInstance();
            productTypeBUS = ProductTypeBUS.GetInstance();
            InitializeComponent();
            CustomStyleGridView();
            msgBoxInfo.Parent = formMain;
            msgBoxError.Parent = formMain;
            timer = new Timer();
            timer.Interval = 300;
            timer.Tick += Timer_Tick;
            InitAllShelf();
        }

        private async void Timer_Tick(object sender, EventArgs e)
        {
            Result<IEnumerable<DTO.Shelf>> shelfResult = await shelfBUS.getAllShelf();
            if (shelfResult.IsSuccess)
            {
                this.shelves = shelfResult.Data
                .Where(p => p.ProductType.ProductTypeName.IndexOf(txtBoxSearchShelf.Text, StringComparison.OrdinalIgnoreCase) != -1)
                .ToList();
                await LoadGridData();
            }
            else
            {
                msgBoxError.Show(shelfResult.ErrorMessage);
            }
            timer.Stop();
        }

        public FormShelfManagement()
        {
            InitializeComponent();
            CustomStyleGridView();
        }

        #region Load grid event
        public async void InitAllShelf()
        {
            Result<IEnumerable<DTO.Shelf>> shelfResult = await shelfBUS.getAllShelf();
            if (shelfResult.IsSuccess)
            {
                this.shelves = shelfResult.Data.ToList();
                await LoadGridData();

            }
            else
            {
                MessageBox.Show(shelfResult.ErrorMessage);
            }
        }
        private async Task LoadGridData()
        {
            gridView.Rows.Clear();
            foreach (var shelf in shelves)
            {
                int capacityLoad = 0;
                foreach(var shelfDetail in shelf.ShelfDetails)
                {
                    if (shelfDetail.Product != null)
                    {
                        capacityLoad += shelfDetail.Product.ProductCapacity * shelfDetail.ProductQuantity;
                    }    
                }    
                if(shelf.ProductType == null)
                {
                    Result<DTO.ProductType> result = await productTypeBUS.findProductTypeByID(shelf.ProductTypeID);
                    shelf.ProductType = result.Data;
                }    
                gridView.Rows.Add(new object[] { null, "Shelf " + shelf.ShelfID.ToString(), shelf.ProductType.ProductTypeName, shelf.LayerQuantity
                    , capacityLoad.ToString() + "/" + (shelf.LayerCapacity*shelf.LayerQuantity).ToString(), shelf.Status });
            }
            UpdateScrollBarValues();
        }
        #endregion

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
            // Khi rời khỏi ô, đặt kiểu cursor mặc định
            gridView.Cursor = Cursors.Default;
        }

        private void gridViewMain_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Kiểm tra xem có phải là header của cột không
            if (e.RowIndex == -1)
            {
                // Kiểm tra xem có phải là header của cột 2, 3, 4 hoặc header của cột 4, 5
                if (e.ColumnIndex >= 1 && e.ColumnIndex <= 4)
                {
                    gridView.Cursor = Cursors.Hand;
                    return;
                }
            }

            // Nếu không phải là header của cột và nằm trong khoảng cột 4, 5, đặt kiểu cursor thành Hand
            if (e.RowIndex >= 0 && (e.ColumnIndex == 6))
            {
                gridView.Cursor = Cursors.Hand;
                return;
            }

            // Nếu không phải là header của cột hoặc không phải là cột 4, 5, đặt kiểu cursor mặc định
            gridView.Cursor = Cursors.Default;
        }
        #endregion

        #region Click event
        private void btnCreateShelf_Click(object sender, EventArgs e)
        {
            FormBackground formBackground = new FormBackground(formMain);
            try
            {
                using (FormCreateShelf formCreateShelf = new FormCreateShelf(this))
                {
                    formBackground.Owner = formMain;
                    formBackground.Show();
                    formCreateShelf.Owner = formBackground;
                    formCreateShelf.ShowDialog();
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
                    for (int i = 1; i < col - 1 + 1; i++)
                    {
                        if (i == 1) continue;
                        XcelApp.Cells[1, i - 1] = gridView.Columns[i - 1].HeaderText;
                    }

                    // Get data of cells
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 1; j < col - 1; j++)
                        {
                            XcelApp.Cells[i + 2, j] = gridView.Rows[i].Cells[j].Value.ToString();
                        }
                    }

                    XcelApp.Columns.AutoFit();
                    XcelApp.Visible = true;
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
                /*if (e.ColumnIndex == 6)
                {
                    // Update
                    FormBackground formBackground = new FormBackground(formMain);
                    try
                    {
                        using (FormUpdateShelf formUpdateShelf = new FormUpdateShelf())
                        {
                            formBackground.Owner = formMain;
                            formBackground.Show();
                            formUpdateShelf.Owner = formBackground;
                            formUpdateShelf.ShowDialog();
                            formBackground.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        msgBoxError.Parent = formMain;
                        msgBoxError.Show(ex.Message, "Error");
                    }
                }*/
                if (e.ColumnIndex == 6)
                {
                    // Delete
                    msgBoxDelete.Parent = formMain;
                    DialogResult dr = msgBoxDelete.Show();
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            try
                            {

                                string[] parts = gridView.Rows[y].Cells[1].Value.ToString().Split(' ');
                                string cutString = parts[1];
                                Result<bool> result = await shelfBUS.deleteShelf(int.Parse(cutString));
                                if (result.IsSuccess)
                                {
                                    msgBoxInfo.Show("Remove Sheft successfully!");
                                    InitAllShelf();
                                }
                                else
                                {
                                    msgBoxError.Parent = formMain;
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

        private  void txtBoxSearchShelf_TextChanged(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
        }
    }
}
