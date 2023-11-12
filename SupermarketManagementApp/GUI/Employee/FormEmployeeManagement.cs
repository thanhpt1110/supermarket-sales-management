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

namespace SupermarketManagementApp.GUI.Employee
{
    public partial class FormEmployeeManagement : Form
    {
        #region Declare variable
        private Guna2DataGridView gridView = null;
        private FormMain formMain = null;
        #endregion

        public FormEmployeeManagement(FormMain formMain)
        {
            this.formMain = formMain;

            InitializeComponent();
            CustomStyleGridView();
            LoadGridData();
            UpdateScrollBarValues();
        }

        public FormEmployeeManagement()
        {
            InitializeComponent();
            CustomStyleGridView();
            LoadGridData();
            UpdateScrollBarValues();
        }

        private void LoadGridData()
        {
            gridView.Rows.Add(new object[] { null, "Phan Tuấn Thành", "29/01/2003", "0914777666","051203001122" });
            gridView.Rows.Add(new object[] { null, "Phan Tuấn Thành", "29/01/2003", "0914777666","051203001122" });
            gridView.Rows.Add(new object[] { null, "Phan Tuấn Thành", "29/01/2003", "0914777666","051203001122" });
            gridView.Rows.Add(new object[] { null, "Phan Tuấn Thành", "29/01/2003", "0914777666","051203001122" });
            gridView.Rows.Add(new object[] { null, "Phan Tuấn Thành", "29/01/2003", "0914777666","051203001122" });
            gridView.Rows.Add(new object[] { null, "Phan Tuấn Thành", "29/01/2003", "0914777666","051203001122" });
            gridView.Rows.Add(new object[] { null, "Phan Tuấn Thành", "29/01/2003", "0914777666","051203001122" });
            gridView.Rows.Add(new object[] { null, "Phan Tuấn Thành", "29/01/2003", "0914777666","051203001122" });
            gridView.Rows.Add(new object[] { null, "Phan Tuấn Thành", "29/01/2003", "0914777666","051203001122" });
            gridView.Rows.Add(new object[] { null, "Phan Tuấn Thành", "29/01/2003", "0914777666","051203001122" });
            gridView.Rows.Add(new object[] { null, "Phan Tuấn Thành", "29/01/2003", "0914777666","051203001122" });
           
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
        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            FormBackground formBackground = new FormBackground(formMain);
            try
            {
                using (FormCreateEmployee formCreateEmployee = new FormCreateEmployee())
                {
                    // formBackground.Owner = formMain;
                    formBackground.Show();
                    formCreateEmployee.Owner = formBackground;
                    formCreateEmployee.ShowDialog();
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
                        using (FormUpdateEmployee formUpdateEmployee = new FormUpdateEmployee())
                        {
                            formBackground.Owner = formMain;
                            formBackground.Show();
                            formUpdateEmployee.Owner = formBackground;
                            formUpdateEmployee.ShowDialog();
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
