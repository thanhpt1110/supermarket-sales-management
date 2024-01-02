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
using System.Windows.Forms;

namespace SupermarketManagementApp.GUI.Invoice.CustomerInvoice
{
    public partial class FormCustomerInvoiceManagement : Form
    {
        #region Declare variable
        private Guna2DataGridView gridView = null;
        private FormMain formMain = null;
        #endregion

        public FormCustomerInvoiceManagement(FormMain formMain)
        {
            this.formMain = formMain;

            InitializeComponent();
            CustomStyleGridView();
            LoadGridData();
            UpdateScrollBarValues();
        }

        public FormCustomerInvoiceManagement()
        {
            InitializeComponent();
            CustomStyleGridView();
            LoadGridData();
            UpdateScrollBarValues();
        }

        private void LoadGridData()
        {
            gridView.Rows.Add(new object[] { null, "Sophia Johnson", "John Doe", "15/04/2022", "1,200,000" });
            gridView.Rows.Add(new object[] { null, "Liam Wilson", "Alice Smith", "21/08/2022", "800,000" });
            gridView.Rows.Add(new object[] { null, "Ava Smith", "Bob Miller", "08/06/2022", "1,500,000" });
            gridView.Rows.Add(new object[] { null, "Noah Davis", "Eva Wilson", "14/03/2022", "950,000" });
            gridView.Rows.Add(new object[] { null, "Emma Miller", "Chris Anderson", "02/12/2022", "700,000" });
            gridView.Rows.Add(new object[] { null, "Lucas White", "Sophie Lee", "25/10/2022", "1,300,000" });
            gridView.Rows.Add(new object[] { null, "Olivia Taylor", "David Brown", "18/07/2022", "1,100,000" });
            gridView.Rows.Add(new object[] { null, "Ethan Brown", "Emily White", "03/09/2022", "1,800,000" });
            gridView.Rows.Add(new object[] { null, "Isabella Jackson", "Michael Taylor", "30/04/2022", "1,600,000" });
            gridView.Rows.Add(new object[] { null, "Mason Harris", "Olivia Johnson", "09/01/2022", "1,000,000" });
            gridView.Rows.Add(new object[] { null, "Amelia Moore", "Daniel Miller", "12/11/2022", "1,750,000" });
            gridView.Rows.Add(new object[] { null, "Oliver Harris", "Sophia Davis", "01/07/2022", "1,450,000" });
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
            int delta = e.Delta; // Số "bước" mà chuột đã cuộn, có thể là dương hoặc âm
            // Cập nhật giá trị của ScrollBar tùy chỉnh khi DataGridView được cuộn
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
                if (e.ColumnIndex >= 1 && e.ColumnIndex <= 4)
                {
                    gridView.Cursor = Cursors.Hand;
                    return;
                }
            }

            // Nếu không phải là header của cột và nằm trong khoảng cột 4, 5, đặt kiểu cursor thành Hand
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
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
                using (FormCreateCustomerInvoice formCreateCustomerInvoice = new FormCreateCustomerInvoice())
                {
                    formBackground.Owner = formMain;
                    formBackground.Show();
                    formCreateCustomerInvoice.Owner = formBackground;
                    formCreateCustomerInvoice.ShowDialog();
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
                if (e.ColumnIndex == 5)
                {
                    // View infor details
                    FormBackground formBackground = new FormBackground(formMain);
                    try
                    {
                        using (FormDetailCustomerInvoice formDetailCustomerInvoice = new FormDetailCustomerInvoice())
                        {
                            formBackground.Owner = formMain;
                            formBackground.Show();
                            formDetailCustomerInvoice.Owner = formBackground;
                            formDetailCustomerInvoice.ShowDialog();
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
