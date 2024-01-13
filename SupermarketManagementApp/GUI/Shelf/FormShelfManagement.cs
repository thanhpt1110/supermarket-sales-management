﻿using Guna.UI2.WinForms;
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
        public FormShelfManagement(FormMain formMain)
        {
            this.formMain = formMain;
            shelfBUS = ShelfBUS.GetInstance();
            InitializeComponent();
            CustomStyleGridView();
            InitAllShelf();
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
                LoadGridData();

            }
            else
            {
                MessageBox.Show(shelfResult.ErrorMessage);
            }
        }
        private void LoadGridData()
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
                if (e.ColumnIndex >= 1 && e.ColumnIndex <= 5)
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
        private void btnCreateShelf_Click(object sender, EventArgs e)
        {
            FormBackground formBackground = new FormBackground(formMain);
            try
            {
                using (FormCreateShelf formCreateShelf = new FormCreateShelf())
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
                msgBoxError.Parent = formMain;
                msgBoxError.Show();
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

                                string[] parts = gridView.Rows[y].Cells[1].Value.ToString().Split(' ');
                                string cutString = parts[1];
                                Result<bool> result = await shelfBUS.deleteShelf(int.Parse(cutString));
                                if (result.IsSuccess)
                                {
                                    MessageBox.Show("Remove Sheft successfully!", "Success", MessageBoxButtons.OK);
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
    }
}
