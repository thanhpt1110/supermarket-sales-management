﻿using Guna.UI2.WinForms;
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

namespace SupermarketManagementApp.GUI.Invoice.SupplierInvoice
{
    public partial class FormSupplierInvoiceManagement : Form
    {
        #region Declare variable
        private Guna2DataGridView gridView = null;
        private FormMain formMain = null;
        EmployeeBUS employeeBUS = null;
        private Timer searchTimer = null;
        private SupplierInvoiceBUS supplierInvoiceBUS = null;
        #endregion
        private List<SupermarketManagementApp.DTO.SupplierInvoice> supplierInvoices = null;
        public FormSupplierInvoiceManagement(FormMain formMain)
        {
            this.formMain = formMain;
            supplierInvoiceBUS = SupplierInvoiceBUS.GetInstance();
            employeeBUS = EmployeeBUS.GetInstance();
            InitializeComponent();
            CustomStyleGridView();
            InitAllSupplierInvoice();
        }

        public FormSupplierInvoiceManagement()
        {
            supplierInvoiceBUS = SupplierInvoiceBUS.GetInstance();
            employeeBUS = EmployeeBUS.GetInstance();
            InitializeComponent();
            CustomStyleGridView();
            InitAllSupplierInvoice();
        }
        public async void InitAllSupplierInvoice()
        {
            Result<IEnumerable<DTO.SupplierInvoice>> supplierInvoiceResult = await supplierInvoiceBUS.getAllSupplierInvoice();
            if (supplierInvoiceResult.IsSuccess)
            {
                this.supplierInvoices = supplierInvoiceResult.Data.ToList();
            }
            LoadGridData();
        }
        private void LoadGridData()
        {
            gridView.Rows.Clear();
            foreach (var supplierInvoice in supplierInvoices)
            {
                string TotalAmount = string.Format("{0:N0} VND", supplierInvoice.TotalAmount);
                gridView.Rows.Add(new object[] { null, supplierInvoice.SupplierInvoiceID, supplierInvoice.Employee.EmployeeName, supplierInvoice.SupplierName, supplierInvoice.DatePayment.ToString("dd/MM/yyyy"), TotalAmount });
            }
            UpdateScrollBarValues();
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
            int delta = e.Delta; // Số "bước" mà chuột đã cuộn, có thể là dương hoặc âm
            // Cập nhật giá trị của ScrollBar tùy chỉnh khi DataGridView được cuộn
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
                if (e.ColumnIndex >= 2 && e.ColumnIndex <= 5)
                {
                    gridView.Cursor = Cursors.Hand;
                    return;
                }
            }

            // Nếu không phải là header của cột và nằm trong khoảng cột 4, 5, đặt kiểu cursor thành Hand
            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                gridView.Cursor = Cursors.Hand;
                return;
            }

            // Nếu không phải là header của cột hoặc không phải là cột 4, 5, đặt kiểu cursor mặc định
            gridView.Cursor = Cursors.Default;
        }
        #endregion

        #region Click event
        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            FormBackground formBackground = new FormBackground(formMain);
            try
            {
                using (FormCreateSupplierInvoice formCreateSupplierInvoice = new FormCreateSupplierInvoice(this))
                {
                    formBackground.Owner = formMain;
                    formBackground.Show();
                    formCreateSupplierInvoice.Owner = formBackground;
                    formCreateSupplierInvoice.ShowDialog();
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

        private void gridViewMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int x = e.ColumnIndex, y = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 6)
                {
                    // View infor details
                    FormBackground formBackground = new FormBackground(formMain);
                    try
                    {
                        using (FormDetailSupplierInvoice formDetailSupplierInvoice = new FormDetailSupplierInvoice(long.Parse(gridView.Rows[y].Cells[1].Value.ToString())))
                        {
                            formBackground.Owner = formMain;
                            formBackground.Show();
                            formDetailSupplierInvoice.Owner = formBackground;
                            formDetailSupplierInvoice.ShowDialog();
                            formBackground.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        msgBoxError.Parent = formMain;
                        msgBoxError.Show(ex.Message, "Error");
                    }
                }
            }
        }
        #endregion
    }
}
