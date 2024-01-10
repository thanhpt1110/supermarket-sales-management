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

namespace SupermarketManagementApp.GUI
{
    public partial class FormDashboard : Form
    {
        public FormDashboard() 
        {
            InitializeComponent();
            LoadChart();
            LoadTopSellProducts();
        }

        #region RevenueChart
        private void LoadChart()
        {
            revenueChart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Revenue"
            });

            revenueChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Months",
                Labels = GetMonthLabels(), // Implement this method to get month labels
                Separator = new Separator { Step = 1 }
            });

            PopulateChartData();
        }
        private string[] GetMonthLabels()
        {
            return new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
        }

        // Implement this method to populate the chart with data
        private void PopulateChartData()
        {
            // Sample data for illustration purposes
            List<double> dataPoints = new List<double> { 1200, 1500, 2000, 1800, 2500, 3000, 2800, 3200, 3500, 4000 };

            revenueChart.Series.Add(new LineSeries { Title = "Monthly Revenue", Values = new ChartValues<double>(dataPoints) });
        }
        #endregion

        #region TopSellProducts
        public void LoadTopSellProducts()
        {
            dtgvTopSellProducts.ColumnHeadersDefaultCellStyle.Font = new Font(dtgvTopSellProducts.Font, FontStyle.Bold);
            dtgvTopSellProducts.DefaultCellStyle.Font = new Font("Segoe UI", 12);

            // Add the first row with data
            dtgvTopSellProducts.Rows.Add("#1", "Laptop", 563);
            dtgvTopSellProducts.Rows.Add("#2", "Iphone", 235);
            dtgvTopSellProducts.Rows.Add("#3", "Balo UIT", 127);
        }

        #endregion
    }
}
