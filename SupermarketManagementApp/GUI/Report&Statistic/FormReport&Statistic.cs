using LiveCharts.Wpf;
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
using Org.BouncyCastle.Utilities;
using System.Windows.Media.Animation;

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
                this.customerInvoices = cusInvoiceResult.Data.ToList();
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

            foreach (var invoice in customerInvoices)
            {
                if (invoice.DatePayment.HasValue && invoice.DatePayment.Value.Year == DateTime.Now.Year && invoice.DatePayment.Value.Month == DateTime.Now.Month)
                {
                    series.Points.AddXY(invoice.DatePayment.Value, invoice.TotalAmount);
                }
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

            // Tạo một loạt dữ liệu mới
            Series series = new Series("TotalAmountSeries");
            series.ChartType = SeriesChartType.Column;

            foreach (var invoice in customerInvoices)
            {
                if (invoice.DatePayment.HasValue && invoice.DatePayment.Value > firstDayOfWeek.AddDays(-1) && invoice.DatePayment.Value <= currentDate)
                {
                    // Thêm dữ liệu với trục X là tên thứ trong tuần
                    series.Points.AddXY(invoice.DatePayment.Value.ToString("dddd"), invoice.TotalAmount);
                }
            }

            // Thêm loạt dữ liệu vào Chart
            RevenueChart.Series.Add(series);

            // Cài đặt các thuộc tính hiển thị trên Chart
            RevenueChart.ChartAreas[0].AxisX.MajorGrid.Enabled = true;
            RevenueChart.ChartAreas[0].AxisY.MajorGrid.Enabled = true;

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

            foreach (var invoice in customerInvoices)
            {
                if (invoice.DatePayment.HasValue && invoice.DatePayment.Value >= dtpkFrom.Value && invoice.DatePayment.Value <= dtpkTo.Value)
                {
                    series.Points.AddXY(invoice.DatePayment.Value, invoice.TotalAmount);
                }
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
                dtgvCustomers.Rows.Add(new object[] { top , x.CustomerName, x.TotalAmount });
                top++;
            }
            /*dtgvCustomers.Columns[0].Width = 50; // Cột đầu tiên
            dtgvCustomers.Columns[2].Width = (int)(dtgvCustomers.Width * 0.6);
            dtgvCustomers.Columns[3].Width = (int)(dtgvCustomers.Width * 0.4);*/
        }
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

                iTextSharp.text.Font hfont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20f, iTextSharp.text.Font.BOLD);
                iTextSharp.text.Font tfont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10f, iTextSharp.text.Font.ITALIC);
                iTextSharp.text.Font font = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14f);

                Paragraph Title = new Paragraph("Report", hfont);
                Title.Alignment = Element.ALIGN_CENTER;
                document.Add(Title);

                Paragraph timeline = new Paragraph(DateTime.Now.ToString(), tfont);
                timeline.SpacingBefore = 14f;
                timeline.Alignment = Element.ALIGN_CENTER;
                document.Add(timeline);

                Paragraph r1 = new Paragraph("", font);
                r1.Alignment = Element.ALIGN_LEFT;
                document.Add(r1);

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
                    table.AddCell(new Phrase(dtgvProducts.Columns[i].HeaderText));
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
                            table.AddCell(new Phrase(dtgvProducts[j, i].Value.ToString()));
                        }
                    }
                }
                table.SpacingBefore = 14f;
                table.SpacingAfter = 14f;
                document.Add(table);



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
                    CusTable.AddCell(new Phrase(dtgvCustomers.Columns[i].HeaderText));
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
                for (int i = 0; i < cusRow; i++)
                {
                    for (int j = 0; j < dtgvCustomers.Columns.Count; j++)
                    {
                        if (dtgvCustomers[j, i].Value != null)
                        {
                            CusTable.AddCell(new Phrase(dtgvCustomers[j, i].Value.ToString()));
                        }
                    }
                }
                CusTable.SpacingBefore = 14f;
                CusTable.SpacingAfter = 14f;
                document.Add(CusTable);
                


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
                txtReporter.IndentationRight = 30 ;
                txtReporter.SpacingBefore = 20f; 
                txtReporter.SpacingAfter = 10f;
                document.Add(txtReporter);

                Paragraph txtName = new Paragraph(GlobalVariable.LoggedAccount.Employee.EmployeeName, tfont);
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
