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
namespace SupermarketManagementApp.GUI.Customer
{
    public partial class FormCustomerManagement : Form
    {
        #region Declare variable
        private Guna2DataGridView gridView = null;
        private FormMain formMain = null;
        #endregion
        public FormCustomerManagement()
        {
            InitializeComponent();
            CustomStyleGridView();
            UpdateScrollBarValues();
            LoadGridData();

        }
        public FormCustomerManagement(FormMain formMain)
        {
            this.formMain = formMain;
            InitializeComponent();
            CustomStyleGridView();
            LoadGridData();
            UpdateScrollBarValues();

        }

        private void LoadGridData()
        {
            gridView.Rows.Add(new object[] { null, "Sophia Johnson", "0987654321", "15/04/1992", "Female" });
            gridView.Rows.Add(new object[] { null, "Liam Wilson", "0901122334", "21/08/1988", "Male" });
            gridView.Rows.Add(new object[] { null, "Ava Smith", "0977123456", "08/06/1997", "Female" });
            gridView.Rows.Add(new object[] { null, "Noah Davis", "0938111222", "14/03/1985", "Male" });
            gridView.Rows.Add(new object[] { null, "Emma Miller", "0914555666", "02/12/1990", "Female" });
            gridView.Rows.Add(new object[] { null, "Lucas White", "0966888999", "25/10/1993", "Male" });
            gridView.Rows.Add(new object[] { null, "Olivia Taylor", "0944777666", "18/07/1981", "Female" });
            gridView.Rows.Add(new object[] { null, "Ethan Brown", "0988333222", "03/09/1999", "Male" });
            gridView.Rows.Add(new object[] { null, "Isabella Jackson", "0914222111", "30/04/1987", "Female" });
            gridView.Rows.Add(new object[] { null, "Mason Harris", "0977999888", "09/01/1996", "Male" });
            gridView.Rows.Add(new object[] { null, "Amelia Moore", "0936555444", "12/11/1983", "Female" });
            gridView.Rows.Add(new object[] { null, "Oliver Harris", "0922333444", "01/07/1998", "Male" });
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
            int newScrollBarValue = scrollBar.Value - delta / 120;
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
            if (e.RowIndex >= 0 && (e.ColumnIndex == 5 || e.ColumnIndex == 6))
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
                using (FormCreateCustomer formCreateCustomer = new FormCreateCustomer())
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
                    // Update
                    FormBackground formBackground = new FormBackground(formMain);
                    try
                    {
                        using (FormUpdateCustomer formUpdateCustomer = new FormUpdateCustomer())
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
                else if (e.ColumnIndex == 6)
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
