namespace SupermarketManagementApp.GUI
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dtgvTopSellProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Top = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnOrder = new Guna.UI2.WinForms.Guna2Panel();
            this.lbOrder = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnRevenue = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbtodayRevenue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.labelTodaySale = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelMonthRevenue = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.labelMonthRevenue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.revenueChart = new LiveCharts.WinForms.CartesianChart();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1.SuspendLayout();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTopSellProducts)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            this.pnOrder.SuspendLayout();
            this.pnRevenue.SuspendLayout();
            this.panelMonthRevenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.guna2Panel1.Controls.Add(this.guna2ShadowPanel2);
            this.guna2Panel1.Controls.Add(this.guna2ShadowPanel1);
            this.guna2Panel1.Controls.Add(this.panelMonthRevenue);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(14, 18, 14, 18);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1625, 871);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.dtgvTopSellProducts);
            this.guna2ShadowPanel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(784, 523);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Padding = new System.Windows.Forms.Padding(4);
            this.guna2ShadowPanel2.Radius = 20;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.ShadowDepth = 255;
            this.guna2ShadowPanel2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(797, 315);
            this.guna2ShadowPanel2.TabIndex = 11;
            // 
            // dtgvTopSellProducts
            // 
            this.dtgvTopSellProducts.AllowUserToAddRows = false;
            this.dtgvTopSellProducts.AllowUserToDeleteRows = false;
            this.dtgvTopSellProducts.AllowUserToResizeColumns = false;
            this.dtgvTopSellProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvTopSellProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvTopSellProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvTopSellProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvTopSellProducts.ColumnHeadersHeight = 50;
            this.dtgvTopSellProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Top,
            this.ProductName,
            this.TotalOrder});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvTopSellProducts.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgvTopSellProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvTopSellProducts.Location = new System.Drawing.Point(40, 54);
            this.dtgvTopSellProducts.Name = "dtgvTopSellProducts";
            this.dtgvTopSellProducts.ReadOnly = true;
            this.dtgvTopSellProducts.RowHeadersVisible = false;
            this.dtgvTopSellProducts.RowHeadersWidth = 51;
            this.dtgvTopSellProducts.RowTemplate.DividerHeight = 1;
            this.dtgvTopSellProducts.RowTemplate.Height = 55;
            this.dtgvTopSellProducts.RowTemplate.ReadOnly = true;
            this.dtgvTopSellProducts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvTopSellProducts.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgvTopSellProducts.Size = new System.Drawing.Size(709, 210);
            this.dtgvTopSellProducts.TabIndex = 4;
            this.dtgvTopSellProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvTopSellProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvTopSellProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvTopSellProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvTopSellProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvTopSellProducts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvTopSellProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvTopSellProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvTopSellProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvTopSellProducts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvTopSellProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvTopSellProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvTopSellProducts.ThemeStyle.HeaderStyle.Height = 50;
            this.dtgvTopSellProducts.ThemeStyle.ReadOnly = true;
            this.dtgvTopSellProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvTopSellProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvTopSellProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvTopSellProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvTopSellProducts.ThemeStyle.RowsStyle.Height = 55;
            this.dtgvTopSellProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvTopSellProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Top
            // 
            this.Top.HeaderText = "Top";
            this.Top.MinimumWidth = 6;
            this.Top.Name = "Top";
            this.Top.ReadOnly = true;
            this.Top.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProductName
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ProductName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProductName.FillWeight = 200F;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TotalOrder
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.TotalOrder.DefaultCellStyle = dataGridViewCellStyle4;
            this.TotalOrder.HeaderText = "Total Orders";
            this.TotalOrder.MinimumWidth = 6;
            this.TotalOrder.Name = "TotalOrder";
            this.TotalOrder.ReadOnly = true;
            this.TotalOrder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(40, 16);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(200, 32);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = "Top Selling Products";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.pnOrder);
            this.guna2ShadowPanel1.Controls.Add(this.pnRevenue);
            this.guna2ShadowPanel1.Controls.Add(this.labelTodaySale);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(47, 523);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.guna2ShadowPanel1.Radius = 20;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 255;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(651, 315);
            this.guna2ShadowPanel1.TabIndex = 10;
            // 
            // pnOrder
            // 
            this.pnOrder.BackColor = System.Drawing.Color.Transparent;
            this.pnOrder.BorderColor = System.Drawing.Color.Silver;
            this.pnOrder.BorderRadius = 40;
            this.pnOrder.BorderThickness = 1;
            this.pnOrder.Controls.Add(this.guna2HtmlLabel5);
            this.pnOrder.Controls.Add(this.lbOrder);
            this.pnOrder.Controls.Add(this.guna2HtmlLabel3);
            this.pnOrder.FillColor = System.Drawing.Color.White;
            this.pnOrder.Location = new System.Drawing.Point(360, 71);
            this.pnOrder.Name = "pnOrder";
            this.pnOrder.Size = new System.Drawing.Size(240, 205);
            this.pnOrder.TabIndex = 8;
            // 
            // lbOrder
            // 
            this.lbOrder.BackColor = System.Drawing.Color.Transparent;
            this.lbOrder.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrder.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbOrder.Location = new System.Drawing.Point(99, 82);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(39, 32);
            this.lbOrder.TabIndex = 11;
            this.lbOrder.Text = "120";
            this.lbOrder.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(99, 10);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(52, 27);
            this.guna2HtmlLabel3.TabIndex = 10;
            this.guna2HtmlLabel3.Text = "Order";
            // 
            // pnRevenue
            // 
            this.pnRevenue.BackColor = System.Drawing.Color.Transparent;
            this.pnRevenue.BorderColor = System.Drawing.Color.Silver;
            this.pnRevenue.BorderRadius = 40;
            this.pnRevenue.BorderThickness = 1;
            this.pnRevenue.Controls.Add(this.guna2HtmlLabel4);
            this.pnRevenue.Controls.Add(this.lbtodayRevenue);
            this.pnRevenue.Controls.Add(this.guna2HtmlLabel2);
            this.pnRevenue.FillColor = System.Drawing.Color.White;
            this.pnRevenue.Location = new System.Drawing.Point(42, 71);
            this.pnRevenue.Name = "pnRevenue";
            this.pnRevenue.Size = new System.Drawing.Size(240, 205);
            this.pnRevenue.TabIndex = 7;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.ForestGreen;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(92, 155);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(49, 32);
            this.guna2HtmlLabel4.TabIndex = 10;
            this.guna2HtmlLabel4.Text = "VND";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbtodayRevenue
            // 
            this.lbtodayRevenue.BackColor = System.Drawing.Color.Transparent;
            this.lbtodayRevenue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtodayRevenue.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbtodayRevenue.Location = new System.Drawing.Point(81, 82);
            this.lbtodayRevenue.Name = "lbtodayRevenue";
            this.lbtodayRevenue.Size = new System.Drawing.Size(75, 32);
            this.lbtodayRevenue.TabIndex = 10;
            this.lbtodayRevenue.Text = "100000";
            this.lbtodayRevenue.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(77, 10);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(77, 27);
            this.guna2HtmlLabel2.TabIndex = 9;
            this.guna2HtmlLabel2.Text = "Revenue";
            // 
            // labelTodaySale
            // 
            this.labelTodaySale.BackColor = System.Drawing.Color.Transparent;
            this.labelTodaySale.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTodaySale.Location = new System.Drawing.Point(42, 16);
            this.labelTodaySale.Name = "labelTodaySale";
            this.labelTodaySale.Size = new System.Drawing.Size(107, 32);
            this.labelTodaySale.TabIndex = 3;
            this.labelTodaySale.Text = "Today Sale";
            // 
            // panelMonthRevenue
            // 
            this.panelMonthRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMonthRevenue.BackColor = System.Drawing.Color.Transparent;
            this.panelMonthRevenue.Controls.Add(this.labelMonthRevenue);
            this.panelMonthRevenue.Controls.Add(this.revenueChart);
            this.panelMonthRevenue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelMonthRevenue.Location = new System.Drawing.Point(47, 42);
            this.panelMonthRevenue.Name = "panelMonthRevenue";
            this.panelMonthRevenue.Padding = new System.Windows.Forms.Padding(4);
            this.panelMonthRevenue.Radius = 20;
            this.panelMonthRevenue.ShadowColor = System.Drawing.Color.Black;
            this.panelMonthRevenue.ShadowDepth = 255;
            this.panelMonthRevenue.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panelMonthRevenue.Size = new System.Drawing.Size(1534, 436);
            this.panelMonthRevenue.TabIndex = 9;
            // 
            // labelMonthRevenue
            // 
            this.labelMonthRevenue.BackColor = System.Drawing.Color.Transparent;
            this.labelMonthRevenue.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMonthRevenue.Location = new System.Drawing.Point(42, 22);
            this.labelMonthRevenue.Name = "labelMonthRevenue";
            this.labelMonthRevenue.Size = new System.Drawing.Size(170, 32);
            this.labelMonthRevenue.TabIndex = 2;
            this.labelMonthRevenue.Text = "Monthly Revenue";
            // 
            // revenueChart
            // 
            this.revenueChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.revenueChart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.revenueChart.Location = new System.Drawing.Point(51, 68);
            this.revenueChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.revenueChart.Name = "revenueChart";
            this.revenueChart.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.revenueChart.Size = new System.Drawing.Size(1444, 332);
            this.revenueChart.TabIndex = 1;
            this.revenueChart.Text = "cartesianChart1";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.ForestGreen;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(93, 155);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(54, 32);
            this.guna2HtmlLabel5.TabIndex = 12;
            this.guna2HtmlLabel5.Text = "Units";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1625, 871);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTopSellProducts)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            this.pnOrder.ResumeLayout(false);
            this.pnOrder.PerformLayout();
            this.pnRevenue.ResumeLayout(false);
            this.pnRevenue.PerformLayout();
            this.panelMonthRevenue.ResumeLayout(false);
            this.panelMonthRevenue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelMonthRevenue;
        private LiveCharts.WinForms.CartesianChart revenueChart;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelMonthRevenue;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelTodaySale;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvTopSellProducts;
        private Guna.UI2.WinForms.Guna2Panel pnRevenue;
        private Guna.UI2.WinForms.Guna2Panel pnOrder;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbtodayRevenue;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Top;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalOrder;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
    }
}