using SupermarketManagementApp.BUS;
using SupermarketManagementApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementApp.GUI.Invoice.CustomerInvoice
{
    public partial class FormDetailCustomerInvoice : Form
    {
        private CustomerInvoiceBUS customerInvoiceBUS;
        public FormDetailCustomerInvoice(long id)
        {
            InitializeComponent();
            customerInvoiceBUS = CustomerInvoiceBUS.GetInstance();
            loadInvoiceDetails(id);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Print invoice
        private Bitmap memoryImage;
        private Size s;

        private void CaptureScreen()
        {
            s = this.ClientSize;
            memoryImage = new Bitmap(s.Width, s.Height);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, -10, s);
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void HideButton()
        {
            btnPrint.Visible = false;
            btnClose.Visible = false;   
        }

        private void ShowButton()
        {
            btnPrint.Visible = true;
            btnClose.Visible = true;    
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                HideButton();
                this.Refresh();
                Application.DoEvents();

                CaptureScreen();
                printDocument.DefaultPageSettings.PaperSize = new PaperSize("Print invoice", s.Width + 23, s.Height + 17);
                printDocument.Print();
            }
            catch (Exception ex)
            {
                msgBoxError.Show(ex.Message, "Error");
            }
            finally
            {
                ShowButton();
            }
        }
        #endregion


        private async void loadInvoiceDetails(long id)
        {
            // Giả sử bạn có một danh sách các đối tượng InvoiceDetail
            Result<DTO.CustomerInvoice> result = await customerInvoiceBUS.getCustomerInvoiceDetailByID(id);
            if (result.IsSuccess)
            {
                
                this.lbaelInvoiceID.Text = "Invoice " + result.Data.CustomerInvoiceID.ToString();
                this.labelCustomerName.Text = result.Data.Customer.CustomerName;
                this.labelPhoneNumber.Text = result.Data.Customer.PhoneNumber.ToString();
                this.labelEmployeeName.Text = result.Data.Employee.EmployeeName;
                this.labelInvoiceDate.Text = result.Data.DatePayment.Value.ToString("dd/MM/yyyy HH/mm/ss");
                double TotalAmount = 0;
                // Duyệt qua danh sách InvoiceDetail
                foreach (DTO.CustomerInvoiceDetail customerInvoiceDetail in result.Data.CustomerInvoiceDetails)
                {
                    // Tạo một TableLayoutPanel mới
                    TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
                    tableLayoutPanel.Size = new Size(582, 30);
                    tableLayoutPanel.Padding = new Padding(0, 10, 0, 0);

                    tableLayoutPanel.ColumnCount = 4;
                    tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.64735F));
                    tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.17069F));
                    tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.25604F));
                    tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.92593F));
                    tableLayoutPanel.Dock = DockStyle.Top;

                    // Tạo và thêm các label vào TableLayoutPanel
                    Label labelProductName = new Label();
                    labelProductName.Text = customerInvoiceDetail.Product.ProductName;
                    labelProductName.Margin = new Padding(9, 0, 0, 0);
                    tableLayoutPanel.Controls.Add(labelProductName, 0, 0);

                    Label labelQuantity = new Label();
                    labelQuantity.Text = customerInvoiceDetail.ProductQuantity.ToString();
                    labelQuantity.Margin = new Padding(0, 0, 0, 0);
                    tableLayoutPanel.Controls.Add(labelQuantity, 1, 0);

                    Label labelUnitPrice = new Label();
                    labelUnitPrice.Text = customerInvoiceDetail.Product.UnitPrice.ToString();
                    labelUnitPrice.Margin = new Padding(0);
                    tableLayoutPanel.Controls.Add(labelUnitPrice, 2, 0);

                    Label labelTotalPrice = new Label();
                    labelTotalPrice.Text = (customerInvoiceDetail.ProductQuantity * customerInvoiceDetail.Product.UnitPrice).ToString();
                    labelTotalPrice.Margin = new Padding(0);
                    tableLayoutPanel.Controls.Add(labelTotalPrice, 3, 0);

                    // Thêm TableLayoutPanel vào panelInvoiceDetail
                    panelInvoiceDetails.Controls.Add(tableLayoutPanel);

                    TotalAmount += customerInvoiceDetail.ProductQuantity * customerInvoiceDetail.Product.UnitPrice;
                }
                // Đặt văn hóa phù hợp
                System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("vi-VN");

                // Định dạng số thành chuỗi theo định dạng tiền tệ
                labelTotalAmount.RightToLeft = RightToLeft.Yes;
                labelTotalAmount.Text = TotalAmount.ToString("N0", culture) + " VND";
            }
            else
            {
                msgBoxError.Show(result.ErrorMessage);
            }

        }
    }

    public class InvoiceDetail
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }

        public InvoiceDetail() { }

        public InvoiceDetail(string productName, int quantity, double unitPrice, double totalPrice)
        {
            ProductName = productName;
            Quantity = quantity;
            UnitPrice = unitPrice;
            TotalPrice = totalPrice;
        }
    }
}
