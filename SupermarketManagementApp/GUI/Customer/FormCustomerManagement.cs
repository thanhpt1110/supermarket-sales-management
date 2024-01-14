using Guna.UI2.WinForms;
using SupermarketManagementApp.GUI.Account;
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
using SupermarketManagementApp.DAO;
using SupermarketManagementApp.BUS;
using SupermarketManagementApp.DTO;

namespace SupermarketManagementApp.GUI.Customer
{
    public partial class FormCustomerManagement : Form
    {
        #region Declare variable
        private Guna2DataGridView gridView = null;
        private FormMain formMain = null;
        private Timer searchTimer = null;
        #endregion

        #region Declare specific Variable type
        private List<SupermarketManagementApp.DTO.Customer> customers = null;
        private CustomerBUS customerBUS = null;
        #endregion

        public FormCustomerManagement(FormMain formMain)
        {
            this.formMain = formMain;
            customerBUS = CustomerBUS.GetInstance();
            InitializeComponent();
            CustomStyleGridView();
            InitAllCustomer();
            msgBoxInfo.Parent = formMain;
            InitTimer();
        }

        public FormCustomerManagement()
        {
            InitializeComponent();
            CustomStyleGridView();
            InitAllCustomer();
            InitTimer();
        }

        #region Load grid event
        public async void InitAllCustomer()
        {
            Result<IEnumerable<DTO.Customer>> customerResult = await customerBUS.GetAllCustomer();
            if (customerResult.IsSuccess)
            {
                this.customers = customerResult.Data.ToList();
                LoadGridData();

            }
            else
            {
                msgBoxError.Show(customerResult.ErrorMessage);
            }
        }
        private void LoadGridData()
        {
            gridView.Rows.Clear();
            foreach (var customer in customers)
            {
                gridView.Rows.Add(new object[] { null, customer.CustomerID, customer.CustomerName, customer.PhoneNumber, customer.Birthday.ToString("dd/MM/yyyy"), customer.Gender });
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
            int delta = e.Delta; // Số "bước" mà chuột đã cuộn, có thể là dương hoặc âm

            // Cập nhật giá trị của ScrollBar tùy chỉnh khi DataGridView được cuộn
            int newScrollBarValue = scrollBar.Value - delta / 120;
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
        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            FormBackground formBackground = new FormBackground(formMain);
            try
            {
                using (FormCreateCustomer formCreateCustomer = new FormCreateCustomer(this))
                {
                    formBackground.Owner = formMain;
                    formBackground.Show();
                    formCreateCustomer.Owner = formBackground;
                    formCreateCustomer.ShowDialog();
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
                        using (FormUpdateCustomer formUpdateCustomer = new FormUpdateCustomer(this, int.Parse(gridView.Rows[y].Cells[1].Value.ToString())))
                        {
                            formBackground.Owner = formMain;
                            formBackground.Show();
                            formUpdateCustomer.Owner = formBackground;
                            formUpdateCustomer.ShowDialog();
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
                                Result<bool> result = await customerBUS.removeCustomerByID(int.Parse(gridView.Rows[y].Cells[1].Value.ToString()));
                                if (result.IsSuccess)
                                {
                                    msgBoxInfo.Show("Remove successfully!");
                                    InitAllCustomer();
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
            Result<IEnumerable<DTO.Customer>> result = await customerBUS.searchCustomerByName(txtBoxSearchCustomer.Text);
            this.customers = result.Data.ToList();
            LoadGridData();
        }
        #endregion
        #region Text changed event
        private void txtBoxSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            this.searchTimer.Stop();
            this.searchTimer.Start();
        }
        #endregion
    }
}
