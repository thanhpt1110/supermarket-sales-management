using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Input;
using LiveCharts;
using LiveCharts.Definitions.Charts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using Guna.UI2.WinForms;
using SupermarketManagementApp.BUS;
using SupermarketManagementApp.Utils;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;
using System.Globalization;
using LiveCharts.Defaults;
using System.Windows.Media.TextFormatting;
using SupermarketManagementApp.DTO;

namespace SupermarketManagementApp.GUI
{
    public partial class FormDashboard : Form
    {
        //Customer Invoices
        private List<SupermarketManagementApp.DTO.CustomerInvoice> customerInvoices = null;
        private CustomerInvoiceBUS customerInvoiceBUS = null;

        private List<SupermarketManagementApp.DTO.Product> products = null;
        private ProductBUS productBUS = null;

        private List<SupermarketManagementApp.DTO.CustomerInvoiceDetail> customerInvoiceDetails = null;
        private CustomerInvoiceDetailBUS customerInvoiceDetailBUS = null;

        public FormDashboard()
        {
            customerInvoiceBUS = CustomerInvoiceBUS.GetInstance();
            productBUS = ProductBUS.GetInstance();
            customerInvoiceDetailBUS = CustomerInvoiceDetailBUS.GetInstance();
            InitializeComponent();
            LoadTopSellProducts();
            InitAllCustomerInvoice();
            
        }

        public async void InitAllCustomerInvoice()
        {
            Result<IEnumerable<DTO.CustomerInvoice>> cusInvoiceResult = await customerInvoiceBUS.getAllCustomerInvoice();
            if (cusInvoiceResult.IsSuccess)
            {
                this.customerInvoices = cusInvoiceResult.Data.ToList();
            }

            Load();
        }

        public void Load()
        {
            LoadChart();
            CalcTodayRevenue();
            CalcOrder();
        }

        #region RevenueChart
        private void LoadChart()
        {
            revenueChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Labels = GetMonthLabels(), // Implement this method to get month labels
                Separator = new Separator { Step = 1 }
            });

            PopulateChartData();
        }
        private string[] GetMonthLabels()
        {
            return new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        }

        private void PopulateChartData()
        {

            // Tạo một List<double> để lưu trữ tổng TotalAmount cho mỗi tháng
            List<double> monthlyTotalAmounts = new List<double>();

            // Khởi tạo giá trị 0 cho tất cả các tháng từ tháng 1 đến tháng 12
            for (int i = 1; i <= 12; i++)
            {
                monthlyTotalAmounts.Add(0.0);
            }

            // Lặp qua dữ liệu để tính tổng TotalAmount cho mỗi tháng
            foreach (var invoice in customerInvoices)
            {
                if (invoice.DatePayment.HasValue && invoice.DatePayment.Value.Year == DateTime.Now.Year && invoice.DatePayment.Value <= DateTime.Now)
                {
                    // Lấy chỉ số của tháng từ ngày thanh toán của hóa đơn
                    int monthIndex = invoice.DatePayment.Value.Month;

                    // Cộng thêm vào tổng của tháng đó
                    monthlyTotalAmounts[monthIndex - 1] += (double)invoice.TotalAmount;
                }
            }

            // Sample data for illustration purposes
            //List<double> dataPoints = new List<double> { 1200, 1500, 2000, 1800, 2500, 3000, 2800, 3200, 3500, 4000, 2000, 1500 };

            revenueChart.Series.Add(new LineSeries { Title = "Monthly Revenue", Values = new ChartValues<double>(monthlyTotalAmounts) });
        }
        #endregion

        #region TopSellProducts
        public async void LoadTopSellProducts()
        {
            dtgvTopSellProducts.ColumnHeadersDefaultCellStyle.Font = new Font(dtgvTopSellProducts.Font, FontStyle.Bold);
            dtgvTopSellProducts.DefaultCellStyle.Font = new Font("Segoe UI", 12);

            // Add the first row with data
            //dtgvTopSellProducts.Rows.Add("#1", "Laptop", 563);
            //dtgvTopSellProducts.Rows.Add("#2", "Iphone", 235);
            //dtgvTopSellProducts.Rows.Add("#3", "Balo UIT", 127);

            Result<IEnumerable<DTO.Product>> productResult = await productBUS.getAllProduct();

            if (productResult.IsSuccess)
            {
                this.products = productResult.Data.ToList();
            }

            Result<IEnumerable<DTO.CustomerInvoiceDetail>> cusInvoiceDetailResult = await customerInvoiceDetailBUS.getAllCustomerInvoiceDetail();
            if (cusInvoiceDetailResult.IsSuccess)
            {
                this.customerInvoiceDetails = cusInvoiceDetailResult.Data.ToList();
            }

            var groupedList = (from customerInvoiceDetail in customerInvoiceDetails
                              join product in products on customerInvoiceDetail.ProductID equals product.ProductID
                              group customerInvoiceDetail by new { product.ProductID, product.ProductName } into grouped
                              select new
                              {
                                  ProductID = grouped.Key.ProductID,
                                  ProductName = grouped.Key.ProductName,
                                  TotalQuantity = grouped.Sum(x => x.ProductQuantity)
                              })
                              .OrderByDescending(x =>x.TotalQuantity)
                              .Take(3);


            int top = 1;
            foreach ( var item in groupedList )
            {
                dtgvTopSellProducts.Rows.Add(new object[] { "#"+top, item.ProductName, item.TotalQuantity });
                top++;
            }
        }
        #endregion

        #region TodaySale

        private void CenterLabelInPanel(Guna2HtmlLabel label, Guna2Panel panel)
        {
            int x = (panel.Width - label.Width) / 2;
            int y = (panel.Height - label.Height) / 2;

            // Đặt lại vị trí của Label
            label.Location = new System.Drawing.Point(x, y);
        }

        private void CalcTodayRevenue()
        {
            double todayRevenue = 0;
            foreach (var invoice in customerInvoices)
            {
                if (invoice.DatePayment.HasValue && invoice.DatePayment.Value.Day == DateTime.Now.Day && invoice.DatePayment.Value.Year == DateTime.Now.Year)
                {
                    // Cộng thêm vào tổng của ngày 
                    todayRevenue += (double)invoice.TotalAmount;
                }
            }
            lbtodayRevenue.Text = string.Format("{0:N0}", todayRevenue);

            CenterLabelInPanel(lbtodayRevenue,pnRevenue);
        }

        private void CalcOrder()
        {
            int calc = 0;
            foreach (var invoice in customerInvoices)
            {
                if (invoice.DatePayment.HasValue && invoice.DatePayment.Value.Day == DateTime.Now.Day && invoice.DatePayment.Value.Year == DateTime.Now.Year)
                {
                    //Tăng biến thêm 1
                    calc++;
                }
            }
            lbOrder.Text = calc.ToString();

            CenterLabelInPanel(lbOrder, pnOrder);
        }
        #endregion
    }
}
