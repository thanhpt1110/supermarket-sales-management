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
using Guna.UI2.WinForms;
using SupermarketManagementApp.Properties;
using SupermarketManagementApp.Utils;

namespace SupermarketManagementApp.GUI.Account
{
    public partial class FormAccountManagement : Form
    {
        #region Declare variable
        private Guna2DataGridView gridView = null;
        private FormMain formMain = null;
        #endregion
        public FormAccountManagement(FormMain formMain)
        {
            this.formMain = formMain;

            InitializeComponent();
            CustomStyleGridView();
            LoadGridData();
            UpdateScrollBarValues();
        }
        public FormAccountManagement()
        {
            InitializeComponent();
            CustomStyleGridView();
            LoadGridData();
            UpdateScrollBarValues();
        }

        private void LoadGridData()
        {
            gridView.Rows.Add(new object[] { null, "John Doe", "john.doe123", "Admin" });
            gridView.Rows.Add(new object[] { null, "Alice Johnson", "alice.j", "Employee" });
            gridView.Rows.Add(new object[] { null, "Bob Smith", "bob.smith87", "Admin" });
            gridView.Rows.Add(new object[] { null, "Eva Martinez", "eva.m", "Admin" });
            gridView.Rows.Add(new object[] { null, "David Brown", "david.b", "Employee" });
            gridView.Rows.Add(new object[] { null, "Sophie Lee", "sophie.l", "Admin" });
            gridView.Rows.Add(new object[] { null, "Chris Anderson", "chris.a", "Employee" });
            gridView.Rows.Add(new object[] { null, "Emily White", "emily.w", "Manager" });
            gridView.Rows.Add(new object[] { null, "Michael Taylor", "michael.t", "Admin" });
            gridView.Rows.Add(new object[] { null, "Olivia Johnson", "olivia.j", "User" });
            gridView.Rows.Add(new object[] { null, "Daniel Miller", "daniel.m", "Employee" });
            gridView.Rows.Add(new object[] { null, "Sophia Davis", "sophia.d", "Admin" });
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
                if (e.ColumnIndex >= 1 && e.ColumnIndex <= 3)
                {
                    gridView.Cursor = Cursors.Hand;
                    return;
                }
            }

            // Nếu không phải là header của cột và nằm trong khoảng cột 4, 5, đặt kiểu cursor thành Hand
            if (e.RowIndex >= 0 && (e.ColumnIndex == 4 || e.ColumnIndex == 5))
            {
                gridView.Cursor = Cursors.Hand;
                return;
            }

            // Nếu không phải là header của cột hoặc không phải là cột 4, 5, đặt kiểu cursor mặc định
            gridView.Cursor = Cursors.Default;
        }
        #endregion

        #region Click event
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            FormBackground formBackground = new FormBackground(formMain);
            try
            {
                using (FormCreateAccount formCreateAccount = new FormCreateAccount())
                {
                    formBackground.Owner = formMain;
                    formBackground.Show();
                    formCreateAccount.Owner = formBackground;
                    formCreateAccount.ShowDialog();
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
                if (e.ColumnIndex == 4)
                {
                    // Update
                    FormBackground formBackground = new FormBackground(formMain);
                    try
                    {
                        using (FormUpdateAccount formUpdateAccount = new FormUpdateAccount())
                        {
                            formBackground.Owner = formMain;
                            formBackground.Show();
                            formUpdateAccount.Owner = formBackground;
                            formUpdateAccount.ShowDialog();
                            formBackground.Dispose();
                        }
                    }
                    catch (Exception ex)
                    {
                        msgBoxError.Parent = formMain;
                        msgBoxError.Show(ex.Message, "Error");
                    }
                }
                else if (e.ColumnIndex == 5)
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
