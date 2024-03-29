﻿using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Definitions.Charts;
using LiveCharts.WinForms;
using SupermarketManagementApp.DTO;
using System.Windows.Forms.DataVisualization.Charting;
using SupermarketManagementApp.BUS;
using SupermarketManagementApp.Utils;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;
using System.Web.UI.WebControls;
using LiveCharts.Wpf.Charts.Base;
using System.Windows.Controls;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using Guna.UI2.WinForms;
using System.Diagnostics;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Windows;

namespace SupermarketManagementApp.GUI.Report_Statistic
{
    public partial class FormReport_Statistic : Form
    {
        #region Declare specific Variable type
        //Customer Invoices
        private List<SupermarketManagementApp.DTO.CustomerInvoice> customerInvoices = null;
        private CustomerInvoiceBUS customerInvoiceBUS = null;

        //Products
        private List<SupermarketManagementApp.DTO.Product> products = null;
        private ProductBUS productBUS = null;

        //Customers
        private List<SupermarketManagementApp.DTO.Customer> customers = null;
        private CustomerBUS customerBUS = null;
        #endregion

        public FormReport_Statistic()
        {
            InitializeComponent();
            
            customerInvoiceBUS = CustomerInvoiceBUS.GetInstance();
            productBUS = ProductBUS.GetInstance();
            customerBUS = CustomerBUS.GetInstance();
            InitAllCustomerInvoice();
            InitAllProduct();
            InitAllCustomer();
        }

        public async void InitAllCustomerInvoice()
        {
            Result<IEnumerable<DTO.CustomerInvoice>> cusInvoiceResult = await customerInvoiceBUS.getAllCustomerInvoice();
            if (cusInvoiceResult.IsSuccess)
            {
                this.customerInvoices = cusInvoiceResult.Data.ToList().OrderBy(p=>p.DatePayment).ToList();
            }

            DisplayChartData();
        }

        private void DisplayChartData()
        {
            dtpkTo.Value = DateTime.Now;
            dtpkFrom.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

            // Xóa các dữ liệu hiện tại trên Chart (nếu có)
            RevenueChart.Series.Clear();

            // Tạo một loạt dữ liệu mới
            Series series = new Series("TotalAmountSeries");
            series.ChartType = SeriesChartType.RangeColumn;

            //foreach (var invoice in customerInvoices)
            //{
            //    if (invoice.DatePayment.HasValue && invoice.DatePayment.Value.Year == DateTime.Now.Year && invoice.DatePayment.Value.Month == DateTime.Now.Month)
            //    {
            //        series.Points.AddXY(invoice.DatePayment.Value, invoice.TotalAmount);
            //    }
            //}

            Dictionary<string, double> weeklyTotalAmounts = new Dictionary<string, double>();
            // Tạo một loạt dữ liệu mới

            foreach (var invoice in customerInvoices)
            {
                if (invoice.DatePayment.HasValue && invoice.DatePayment.Value.Year == DateTime.Now.Year && invoice.DatePayment.Value.Month == DateTime.Now.Month)
                {
                    string dayteKey = $"({invoice.DatePayment.Value.Year}-{invoice.DatePayment.Value.Month}-{invoice.DatePayment.Value.Day})";
                    
                    // Kiểm tra xem khóa có trong Dictionary chưa
                    if (weeklyTotalAmounts.ContainsKey(dayteKey))
                    {
                        // Nếu có, cộng thêm vào tổng
                        weeklyTotalAmounts[dayteKey] += (double)invoice.TotalAmount;
                    }
                    else
                    {
                        // Nếu chưa, thêm vào Dictionary với giá trị là TotalAmount
                        weeklyTotalAmounts.Add(dayteKey, (double)invoice.TotalAmount);
                    }
                }
            }

            // Thêm loạt dữ liệu vào Chart
            // Thêm dữ liệu từ Dictionary vào loạt dữ liệu
            foreach (var entry in weeklyTotalAmounts)
            {
                series.Points.AddXY(entry.Key, entry.Value);
            }

            // Thêm loạt dữ liệu vào Chart
            RevenueChart.Series.Add(series);

            // Cài đặt các thuộc tính hiển thị trên Chart
            RevenueChart.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            RevenueChart.ChartAreas[0].AxisY.MajorGrid.Enabled = true;

            // Đặt tên cho các trục và đồ thị
            RevenueChart.ChartAreas[0].AxisX.Title = "DatePayment";
            RevenueChart.ChartAreas[0].AxisY.Title = "TotalAmount";
        }

        #region ClickEvent
        private void btnWeek_Click(object sender, EventArgs e)
        {
            #region ChangeDateTimePicker
            // Lấy thời gian hiện tại
            DateTime currentDate = DateTime.Now;

            // Đặt giá trị cho dtpkTo là thời gian hiện tại
            dtpkTo.Value = currentDate;

            // Tính toán ngày đầu tiên của tuần hiện tại
            DateTime firstDayOfWeek = currentDate.AddDays(-(int)currentDate.DayOfWeek + 1);

            // Đặt giá trị cho dtpkFrom là ngày đầu tiên của tuần hiện tại
            dtpkFrom.Value = firstDayOfWeek;
            #endregion

            #region Chart
            // Xóa các dữ liệu hiện tại trên Chart (nếu có)
            RevenueChart.Series.Clear();

            Dictionary<string, double> weeklyTotalAmounts = new Dictionary<string, double>();
            // Tạo một loạt dữ liệu mới

            foreach (var invoice in customerInvoices)
            {
                if (invoice.DatePayment.HasValue && invoice.DatePayment.Value > firstDayOfWeek.AddDays(-1) && invoice.DatePayment.Value <= currentDate)
                {
                    string dayteKey = $"{invoice.DatePayment.Value.Year}-{invoice.DatePayment.Value.Month}-{invoice.DatePayment.Value.Date}";

                    // Kiểm tra xem khóa có trong Dictionary chưa
                    if (weeklyTotalAmounts.ContainsKey(dayteKey))
                    {
                        // Nếu có, cộng thêm vào tổng
                        weeklyTotalAmounts[dayteKey] += (double)invoice.TotalAmount;
                    }
                    else
                    {
                        // Nếu chưa, thêm vào Dictionary với giá trị là TotalAmount
                        weeklyTotalAmounts.Add(dayteKey, (double)invoice.TotalAmount);
                    }
                }
            }

            // Thêm loạt dữ liệu vào Chart
            Series series = new Series("TotalAmountSeries");
            series.ChartType = SeriesChartType.Column;

            // Thêm dữ liệu từ Dictionary vào loạt dữ liệu
            foreach (var entry in weeklyTotalAmounts)
            {
                series.Points.AddXY(entry.Key, entry.Value);
            }

            // Thêm loạt dữ liệu vào Chart
            RevenueChart.Series.Add(series);

            // Cài đặt các thuộc tính hiển thị trên Chart
            RevenueChart.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            RevenueChart.ChartAreas[0].AxisY.MajorGrid.Enabled = true;
            RevenueChart.ChartAreas[0].AxisX.LabelStyle.Format = "dddd";

            // Đặt tên cho các trục và đồ thị
            RevenueChart.ChartAreas[0].AxisY.Title = "TotalAmount";
            #endregion
        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            #region ChangeDateTimePicker
            // Lấy thời gian hiện tại
            DateTime currentDate = DateTime.Now;

            // Đặt giá trị cho dtpkTo là thời gian hiện tại
            dtpkTo.Value = currentDate;

            // Đặt giá trị cho dtpkFrom là ngày đầu tiên của tháng hiện tại
            DateTime fromDate = new DateTime(currentDate.Year, currentDate.Month, 1);
            dtpkFrom.Value = fromDate;
            #endregion

            DisplayChartData();
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            #region ChangeDateTimePicker
            // Lấy thời gian hiện tại
            DateTime currentDate = DateTime.Now;

            // Đặt giá trị cho dtpkTo là thời gian hiện tại
            dtpkTo.Value = currentDate;

            // Đặt giá trị cho dtpkFrom là ngày đầu tiên của năm hiện tại
            DateTime fromDate = new DateTime(currentDate.Year, 1, 1);
            dtpkFrom.Value = fromDate;
            #endregion

            #region Chart
            // Xóa các dữ liệu hiện tại trên Chart (nếu có)
            RevenueChart.Series.Clear();

            // Tạo một Dictionary để lưu trữ tổng TotalAmount cho mỗi tháng
            Dictionary<string, double> monthlyTotalAmounts = new Dictionary<string, double>();

            // Lặp qua dữ liệu để tính tổng TotalAmount cho mỗi tháng
            foreach (var invoice in customerInvoices)
            {
                if (invoice.DatePayment.HasValue && invoice.DatePayment.Value.Year == DateTime.Now.Year && invoice.DatePayment.Value <= currentDate)
                {
                    // Tạo một khóa cho tháng và năm
                    string monthKey = $"{invoice.DatePayment.Value.Year}-{invoice.DatePayment.Value.Month}";

                    // Kiểm tra xem khóa có trong Dictionary chưa
                    if (monthlyTotalAmounts.ContainsKey(monthKey))
                    {
                        // Nếu có, cộng thêm vào tổng
                        monthlyTotalAmounts[monthKey] += (double)invoice.TotalAmount;
                    }
                    else
                    {
                        // Nếu chưa, thêm vào Dictionary với giá trị là TotalAmount
                        monthlyTotalAmounts.Add(monthKey, (double)invoice.TotalAmount);
                    }
                }
            }

            // Tạo một loạt dữ liệu mới
            Series series = new Series("TotalAmountSeries");
            series.ChartType = SeriesChartType.Column;

            // Thêm dữ liệu từ Dictionary vào loạt dữ liệu
            foreach (var entry in monthlyTotalAmounts)
            {
                series.Points.AddXY(entry.Key, entry.Value);
            }

            // Thêm loạt dữ liệu vào Chart
            RevenueChart.Series.Add(series);

            // Cài đặt các thuộc tính hiển thị trên Chart
            RevenueChart.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            RevenueChart.ChartAreas[0].AxisY.MajorGrid.Enabled = true;

            // Đặt tên cho các trục và đồ thị
            RevenueChart.ChartAreas[0].AxisX.Title = "Month";
            RevenueChart.ChartAreas[0].AxisY.Title = "TotalAmount";
            RevenueChart.ChartAreas[0].AxisX.LabelStyle.Format = "MM/yyyy";
            #endregion
        }

        private void dtpkValueChanged(object sender, EventArgs e)
        {
            // Xóa các dữ liệu hiện tại trên Chart (nếu có)
            RevenueChart.Series.Clear();

            // Tạo một loạt dữ liệu mới
            Series series = new Series("TotalAmountSeries");
            series.ChartType = SeriesChartType.Column;

            //foreach (var invoice in customerInvoices)
            //{
            //    if (invoice.DatePayment.HasValue && invoice.DatePayment.Value >= dtpkFrom.Value && invoice.DatePayment.Value <= dtpkTo.Value)
            //    {
            //        series.Points.AddXY(invoice.DatePayment.Value, invoice.TotalAmount);
            //    }
            //}
            Dictionary<string, double> weeklyTotalAmounts = new Dictionary<string, double>();
            // Tạo một loạt dữ liệu mới


            // Thêm loạt dữ liệu vào Chart
            // Thêm dữ liệu từ Dictionary vào loạt dữ liệu
            foreach (var entry in weeklyTotalAmounts)
            {
                series.Points.AddXY(entry.Key, entry.Value);
            }


            // Thêm loạt dữ liệu vào Chart
            RevenueChart.Series.Add(series);

            // Cài đặt các thuộc tính hiển thị trên Chart
            RevenueChart.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            RevenueChart.ChartAreas[0].AxisY.MajorGrid.Enabled = true;

            // Đặt tên cho các trục và đồ thị
            RevenueChart.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yyyy";
            RevenueChart.ChartAreas[0].AxisX.Title = "DatePayment";
            RevenueChart.ChartAreas[0].AxisY.Title = "TotalAmount";
        }

        #endregion

        #region Load Grid Data
        public async void InitAllProduct()
        {
            Result<IEnumerable<DTO.Product>> productResult = await productBUS.getAllProduct();

            if (productResult.IsSuccess)
            {
                this.products = productResult.Data.OrderBy(p => p.ProductCapacity).ToList();
            }

            dtgvProducts.Rows.Clear();
            foreach (var product in products)
            {
                dtgvProducts.Rows.Add(new object[] { product.ProductID, product.ProductName, product.ProductCapacity });
            }
            CustomStyleProductGridView();
        }

        public async void InitAllCustomer()
        {
            Result<IEnumerable<DTO.Customer>> customerResult = await customerBUS.GetAllCustomer();
            if (customerResult.IsSuccess)
            {
                this.customers = customerResult.Data.ToList();
            }

            var groupedList = from customer in customers
                              join invoice in customerInvoices on customer.CustomerID equals invoice.CustomerID
                              group invoice by new { customer.CustomerID, customer.CustomerName } into grouped
                              select new
                              {
                                  CustomerID = grouped.Key.CustomerID,
                                  CustomerName = grouped.Key.CustomerName,
                                  TotalAmount = grouped.Sum(x => x.TotalAmount)
                              };

            var sortedList = groupedList.OrderByDescending(item => item.TotalAmount);

            int top = 1;
            foreach (var x in sortedList)
            {
                dtgvCustomers.Rows.Add(new object[] { top, x.CustomerName, string.Format("{0:N0} VND", x.TotalAmount) });
                top++;
            }
            CustomStyleCustomerGridView();
        }
        #endregion

        #region Customize data grid

        #region Datagrid for Product
        private void CustomStyleProductGridView()
        {
            dtgvProducts.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(dtgvProducts.Font, System.Drawing.FontStyle.Bold);
            dtgvProducts.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12);
            UpdateScrollBarProductValues();
        }

        private void UpdateScrollBarProductValues()
        {
            scrollBarProduct.Minimum = 0;

            int numberOfRows = dtgvProducts.Rows.Count;
            scrollBarProduct.Maximum = numberOfRows - 1;

            if (numberOfRows <= dtgvProducts.DisplayedRowCount(false))
            {
                scrollBarProduct.Visible = false;
            }
            else
            {
                scrollBarProduct.Visible = true;
            }
            scrollBarProduct.Value = dtgvProducts.FirstDisplayedScrollingRowIndex;
            dtgvProducts.MouseWheel += GridViewProduct_MouseWheel;
        }

        private void GridViewProduct_MouseWheel(object sender, MouseEventArgs e)
        {
            if (!scrollBarProduct.Visible)
            {
                return;
            }

            int delta = e.Delta;
            int newScrollBarValue = scrollBarProduct.Value - delta / 100;
            scrollBarProduct.Value = Math.Max(scrollBarProduct.Minimum, Math.Min(scrollBarProduct.Maximum, newScrollBarValue));
        }

        private void scrollBarProduct_Scroll(object sender, ScrollEventArgs e)
        {
            if (scrollBarProduct.Visible)
            {
                dtgvProducts.FirstDisplayedScrollingRowIndex = scrollBarProduct.Value;
            }
        }

        private void gridViewProduct_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dtgvProducts.Cursor = Cursors.Default;
        }

        private void gridViewProduct_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                if (e.ColumnIndex >= 0 && e.ColumnIndex <= 2)
                {
                    dtgvProducts.Cursor = Cursors.Hand;
                    return;
                }
            }
            dtgvProducts.Cursor = Cursors.Default;
        }
        #endregion

        #region Datagrid for Customer
        private void CustomStyleCustomerGridView()
        {
            dtgvCustomers.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font(dtgvCustomers.Font, System.Drawing.FontStyle.Bold);
            dtgvCustomers.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 12);
            UpdateScrollBarCustomerValues();
        }

        private void UpdateScrollBarCustomerValues()
        {
            scrollBarCustomer.Minimum = 0;

            int numberOfRows = dtgvCustomers.Rows.Count;
            scrollBarCustomer.Maximum = numberOfRows - 1;

            if (numberOfRows <= dtgvCustomers.DisplayedRowCount(false))
            {
                scrollBarCustomer.Visible = false;
            }
            else
            {
                scrollBarCustomer.Visible = true;
            }
            scrollBarCustomer.Value = dtgvCustomers.FirstDisplayedScrollingRowIndex;
            dtgvCustomers.MouseWheel += GridViewCustomer_MouseWheel;
        }

        private void GridViewCustomer_MouseWheel(object sender, MouseEventArgs e)
        {
            if (!scrollBarCustomer.Visible)
            {
                return;
            }

            int delta = e.Delta;
            int newScrollBarValue = scrollBarCustomer.Value - delta / 100;
            scrollBarCustomer.Value = Math.Max(scrollBarCustomer.Minimum, Math.Min(scrollBarCustomer.Maximum, newScrollBarValue));
        }

        private void scrollBarCustomer_Scroll(object sender, ScrollEventArgs e)
        {
            if (scrollBarCustomer.Visible)
            {
                dtgvCustomers.FirstDisplayedScrollingRowIndex = scrollBarCustomer.Value;
            }
        }

        private void gridViewCustomer_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            dtgvCustomers.Cursor = Cursors.Default;
        }

        private void gridViewCustomer_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                if (e.ColumnIndex >= 0 && e.ColumnIndex <= 2)
                {
                    dtgvCustomers.Cursor = Cursors.Hand;
                    return;
                }
            }
            dtgvCustomers.Cursor = Cursors.Default;
        }
        #endregion

        #endregion
        
        #region Export
        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            ExportToPdf();
        }

        public void ExportToPdf()
        {
            // Create a SaveFileDialog to get the file path from the user
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save PDF File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                string filePath = saveFileDialog.FileName;

                // Tạo tài liệu PDF
                Document document = new Document();

                // Tạo đối tượng PdfWriter để ghi vào file PDF
                PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));

                // Mở tài liệu
                document.Open();

                iTextSharp.text.Font headerFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 13f, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font dataFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 13f, iTextSharp.text.Font.NORMAL);
                iTextSharp.text.Font hfont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 20f, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font tfont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10f, iTextSharp.text.Font.ITALIC);
                iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 14f);

                Paragraph Title = new Paragraph("Report", hfont);
                Title.Alignment = Element.ALIGN_CENTER;
                document.Add(Title);

                Paragraph timeline = new Paragraph("At " + DateTime.Now.ToString(), tfont);
                timeline.SpacingBefore = 14f;
                timeline.Alignment = Element.ALIGN_CENTER;
                document.Add(timeline);

                Paragraph r1 = new Paragraph("", font);
                r1.Alignment = Element.ALIGN_LEFT;
                document.Add(r1);

                Paragraph TopCustomer = new Paragraph("Top Customers", hfont);
                TopCustomer.IndentationLeft = 52;
                TopCustomer.SpacingBefore = 10f;
                TopCustomer.Alignment = Element.ALIGN_LEFT;
                document.Add(TopCustomer);

                ////THÊM BẢNG TOP KHÁCH HÀNG
                PdfPTable CusTable = new PdfPTable(dtgvCustomers.Columns.Count);

                //Đặt chiều rộng cột của bảng dựa trên kích thước của DataGridView
                float[] CusColumnWidths = new float[dtgvCustomers.Columns.Count];
                for (int i = 0; i < dtgvCustomers.Columns.Count; i++)
                {
                    CusColumnWidths[i] = (float)dtgvCustomers.Columns[i].Width;
                }
                CusTable.SetWidths(CusColumnWidths);

                // Thêm dòng tiêu đề từ DataGridView vào bảng PDF
                for (int i = 0; i < dtgvCustomers.Columns.Count; i++)
                {
                    CusTable.AddCell(new Phrase(dtgvCustomers.Columns[i].HeaderText, headerFont));
                }

                // Thêm dữ liệu từ DataGridView vào bảng PDF        
                int cusRow = 0;
                if (dtgvProducts.Rows.Count > 10)
                {
                    cusRow = 10;
                }
                else
                {
                    cusRow = dtgvProducts.Rows.Count;
                }
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < dtgvCustomers.Columns.Count; j++)
                    {
                        if (dtgvCustomers[j, i].Value != null)
                        {
                            CusTable.AddCell(new Phrase(dtgvCustomers[j, i].Value.ToString(), dataFont));
                        }
                    }
                }
                CusTable.SpacingBefore = 14f;
                CusTable.SpacingAfter = 14f;
                document.Add(CusTable);

                Paragraph LowStockProduct = new Paragraph("Low Stock Products", hfont);
                LowStockProduct.IndentationLeft = 52;
                LowStockProduct.SpacingBefore = 8f;
                LowStockProduct.Alignment = Element.ALIGN_LEFT;
                document.Add(LowStockProduct);

                ////THÊM BẢNG SẢN PHẦM CÒN 
                // Tạo số lượng cột của DataGridView
                PdfPTable table = new PdfPTable(dtgvProducts.Columns.Count);
                // Đặt chiều rộng cột của bảng dựa trên kích thước của DataGridView
                float[] columnWidths = new float[dtgvProducts.Columns.Count];
                for (int i = 0; i < dtgvProducts.Columns.Count; i++)
                {
                    columnWidths[i] = (float)dtgvProducts.Columns[i].Width;
                }
                table.SetWidths(columnWidths);

                // Thêm dòng tiêu đề từ DataGridView vào bảng PDF
                for (int i = 0; i < dtgvProducts.Columns.Count; i++)
                {
                    table.AddCell(new Phrase(dtgvProducts.Columns[i].HeaderText, headerFont));
                }

                // Thêm dữ liệu từ DataGridView vào bảng PDF
                int proRow = 0;
                if (dtgvProducts.Rows.Count > 10)
                {
                    proRow = 10;
                }
                else
                {
                    proRow = dtgvProducts.Rows.Count;
                }
                for (int i = 0; i < dtgvProducts.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgvProducts.Columns.Count; j++)
                    {
                        if (dtgvProducts[j, i].Value != null)
                        {
                            table.AddCell(new Phrase(dtgvProducts[j, i].Value.ToString(), dataFont));
                        }
                    }
                }
                table.SpacingBefore = 14f;
                table.SpacingAfter = 14f;
                document.Add(table);            


                //// THÊM BIỂU ĐỒ
                // Tạo đối tượng PdfPTable với 1 cột
                PdfPTable chartTable = new PdfPTable(1);
                chartTable.WidthPercentage = 100;
                chartTable.DefaultCell.Border = 0;

                // Chuyển đổi biểu đồ thành hình ảnh
                using (MemoryStream ms = new MemoryStream())
                {
                    RevenueChart.SaveImage(ms, ChartImageFormat.Png);
                    iTextSharp.text.Image chartImage = iTextSharp.text.Image.GetInstance(ms.ToArray());

                    // Đặt kích thước của hình ảnh
                    chartImage.ScaleToFit(500, 300);

                    // Tạo một ô chứa hình ảnh
                    PdfPCell cell = new PdfPCell(chartImage);
                    cell.Border = 0;

                    // Đặt căn giữa cho ô chứa hình ảnh
                    cell.HorizontalAlignment = Element.ALIGN_CENTER;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;

                    // Thêm ô chứa hình ảnh vào table
                    chartTable.AddCell(cell);
                }

                // Thêm table vào tài liệu PDF
                chartTable.SpacingBefore = 14f;
                chartTable.SpacingAfter = 14f;
                document.Add(chartTable);

                // Đặt tên cho biểu đồ
                Paragraph ChartName = new Paragraph("Revenue Chart from " + dtpkFrom.Value.ToShortDateString() + " to " + dtpkTo.Value.ToShortDateString(), tfont);
                ChartName.Alignment = Element.ALIGN_CENTER;
                document.Add(ChartName);


                ////KHAI BAO GOC PHAI
                Paragraph txtReporter = new Paragraph("Reporter", font);
                txtReporter.Alignment = Element.ALIGN_RIGHT;
                txtReporter.IndentationRight = 40;
                txtReporter.SpacingBefore = 20f; 
                txtReporter.SpacingAfter = 10f;
                document.Add(txtReporter);

                Paragraph txtName = new Paragraph(GlobalVariable.LoggedAccount.Employee.EmployeeName, headerFont);
                txtName.Alignment = Element.ALIGN_RIGHT;
                txtName.IndentationRight = 30;
                txtName.SpacingBefore = 20f;
                txtName.SpacingAfter = 10f;
                document.Add(txtName);

                // Đóng tài liệu
                document.Close();

                Process.Start(filePath);
            }
        }
        #endregion
    }
}
