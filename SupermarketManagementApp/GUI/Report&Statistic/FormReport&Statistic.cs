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
            InitAllCustomerInvoice();
            InitAllProduct();
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
                this.products = productResult.Data.ToList();
            }

            dtgvProducts.Rows.Clear();
            foreach (var product in products)
            {
                dtgvProducts.Rows.Add(new object[] { product.ProductID, product.ProductName, product.ProductCapacity });
            }
        }

        //public async void InitAllCustomer()
        //{
        //    Result<IEnumerable<DTO.Customer>> customerResult = await customerBUS.getall
        //    if (productResult.IsSuccess)
        //    {
        //        this.products = productResult.Data.ToList();
        //    }

        //    dtgvProducts.Rows.Clear();
        //    foreach (var product in products)
        //    {
        //        dtgvProducts.Rows.Add(new object[] { product.ProductID, product.ProductName, product.ProductCapacity });
        //    }
        //}
        #endregion

        #region Export
        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            ExportToPdf("C:\\Users\\thanh\\Downloads\\Statictis.pdf");
        }

        public void ExportToPdf(string filePath)
        {
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
            timeline.Alignment = Element.ALIGN_CENTER;
            document.Add(timeline);

            Paragraph r = new Paragraph("Revenue", font);
            r.Alignment = Element.ALIGN_LEFT;
            document.Add(r); 

            // Tạo đối tượng PdfPTable với 1 cột
            PdfPTable chartTable = new PdfPTable(1);

            // Chuyển đổi biểu đồ thành hình ảnh
            using (MemoryStream ms = new MemoryStream())
            {
                RevenueChart.SaveImage(ms, ChartImageFormat.Png);
                iTextSharp.text.Image chartImage = iTextSharp.text.Image.GetInstance(ms.ToArray());

                // Đặt kích thước của hình ảnh
                chartImage.ScaleToFit(500, 300);

                // Tạo một ô chứa hình ảnh
                PdfPCell cell = new PdfPCell(chartImage);

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

            Paragraph product = new Paragraph("Product", font);
            Title.Alignment = Element.ALIGN_LEFT;
            document.Add(product);

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
            for (int i = 0; i < dtgvProducts.Rows.Count; i++)
            {
                for (int j = 0; j < dtgvProducts.Rows.Count; j++)
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

            // Đóng tài liệu
            document.Close();

            Process.Start(filePath);
        }
        #endregion
    }
}
