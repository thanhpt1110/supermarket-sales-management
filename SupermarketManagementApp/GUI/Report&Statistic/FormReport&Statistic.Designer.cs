namespace SupermarketManagementApp.GUI.Report_Statistic
{
    partial class FormReport_Statistic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExportPDF = new Guna.UI2.WinForms.Guna2Button();
            this.dtpkFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnWeek = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonth = new Guna.UI2.WinForms.Guna2Button();
            this.btnYear = new Guna.UI2.WinForms.Guna2Button();
            this.dtpkTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.scrollBarProduct = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.dtgvProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelMonthRevenue = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.RevenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelRevenue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.scrollBarCustomer = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.dtgvCustomers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Top = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).BeginInit();
            this.panelMonthRevenue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RevenueChart)).BeginInit();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportPDF.BorderRadius = 15;
            this.btnExportPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportPDF.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExportPDF.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExportPDF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExportPDF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExportPDF.FillColor = System.Drawing.Color.Orange;
            this.btnExportPDF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPDF.ForeColor = System.Drawing.Color.Black;
            this.btnExportPDF.Location = new System.Drawing.Point(1389, 30);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(161, 45);
            this.btnExportPDF.TabIndex = 9;
            this.btnExportPDF.Text = "Export PDF";
            this.btnExportPDF.TextOffset = new System.Drawing.Point(0, -1);
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // dtpkFrom
            // 
            this.dtpkFrom.Checked = true;
            this.dtpkFrom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkFrom.Location = new System.Drawing.Point(103, 30);
            this.dtpkFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkFrom.Name = "dtpkFrom";
            this.dtpkFrom.Size = new System.Drawing.Size(267, 45);
            this.dtpkFrom.TabIndex = 11;
            this.dtpkFrom.Value = new System.DateTime(2024, 1, 10, 13, 27, 12, 63);
            this.dtpkFrom.ValueChanged += new System.EventHandler(this.dtpkValueChanged);
            // 
            // btnWeek
            // 
            this.btnWeek.BorderThickness = 2;
            this.btnWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWeek.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWeek.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWeek.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWeek.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWeek.FillColor = System.Drawing.Color.ForestGreen;
            this.btnWeek.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWeek.ForeColor = System.Drawing.Color.White;
            this.btnWeek.Location = new System.Drawing.Point(722, 30);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(114, 45);
            this.btnWeek.TabIndex = 12;
            this.btnWeek.Text = "1 Week";
            this.btnWeek.TextOffset = new System.Drawing.Point(0, -1);
            this.btnWeek.Click += new System.EventHandler(this.btnWeek_Click);
            // 
            // btnMonth
            // 
            this.btnMonth.BorderThickness = 2;
            this.btnMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMonth.FillColor = System.Drawing.Color.ForestGreen;
            this.btnMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonth.ForeColor = System.Drawing.Color.White;
            this.btnMonth.Location = new System.Drawing.Point(834, 30);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(114, 45);
            this.btnMonth.TabIndex = 12;
            this.btnMonth.Text = "1 Month";
            this.btnMonth.TextOffset = new System.Drawing.Point(0, -1);
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // btnYear
            // 
            this.btnYear.BorderThickness = 2;
            this.btnYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYear.FillColor = System.Drawing.Color.ForestGreen;
            this.btnYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYear.ForeColor = System.Drawing.Color.White;
            this.btnYear.Location = new System.Drawing.Point(946, 30);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(114, 45);
            this.btnYear.TabIndex = 12;
            this.btnYear.Text = "1 Year";
            this.btnYear.TextOffset = new System.Drawing.Point(0, -1);
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // dtpkTo
            // 
            this.dtpkTo.Checked = true;
            this.dtpkTo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkTo.Location = new System.Drawing.Point(416, 30);
            this.dtpkTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkTo.Name = "dtpkTo";
            this.dtpkTo.Size = new System.Drawing.Size(273, 45);
            this.dtpkTo.TabIndex = 15;
            this.dtpkTo.Value = new System.DateTime(2024, 1, 10, 13, 27, 12, 63);
            this.dtpkTo.ValueChanged += new System.EventHandler(this.dtpkValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "To";
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel2.Controls.Add(this.scrollBarProduct);
            this.guna2ShadowPanel2.Controls.Add(this.dtgvProducts);
            this.guna2ShadowPanel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2ShadowPanel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2ShadowPanel2.Location = new System.Drawing.Point(50, 522);
            this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.Padding = new System.Windows.Forms.Padding(4);
            this.guna2ShadowPanel2.Radius = 20;
            this.guna2ShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel2.ShadowDepth = 255;
            this.guna2ShadowPanel2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel2.Size = new System.Drawing.Size(704, 344);
            this.guna2ShadowPanel2.TabIndex = 17;
            // 
            // scrollBarProduct
            // 
            this.scrollBarProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scrollBarProduct.FillColor = System.Drawing.Color.White;
            this.scrollBarProduct.InUpdate = false;
            this.scrollBarProduct.LargeChange = 9;
            this.scrollBarProduct.Location = new System.Drawing.Point(637, 103);
            this.scrollBarProduct.Maximum = 12;
            this.scrollBarProduct.Minimum = 1;
            this.scrollBarProduct.MouseWheelBarPartitions = 15;
            this.scrollBarProduct.Name = "scrollBarProduct";
            this.scrollBarProduct.ScrollbarSize = 20;
            this.scrollBarProduct.Size = new System.Drawing.Size(20, 190);
            this.scrollBarProduct.SmallChange = 2;
            this.scrollBarProduct.TabIndex = 5;
            this.scrollBarProduct.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.scrollBarProduct.Value = 1;
            this.scrollBarProduct.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarProduct_Scroll);
            // 
            // dtgvProducts
            // 
            this.dtgvProducts.AllowUserToAddRows = false;
            this.dtgvProducts.AllowUserToDeleteRows = false;
            this.dtgvProducts.AllowUserToResizeColumns = false;
            this.dtgvProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dtgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgvProducts.ColumnHeadersHeight = 50;
            this.dtgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ProductName,
            this.Remaining});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvProducts.DefaultCellStyle = dataGridViewCellStyle13;
            this.dtgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvProducts.Location = new System.Drawing.Point(65, 54);
            this.dtgvProducts.Name = "dtgvProducts";
            this.dtgvProducts.ReadOnly = true;
            this.dtgvProducts.RowHeadersVisible = false;
            this.dtgvProducts.RowHeadersWidth = 51;
            this.dtgvProducts.RowTemplate.DividerHeight = 1;
            this.dtgvProducts.RowTemplate.Height = 55;
            this.dtgvProducts.RowTemplate.ReadOnly = true;
            this.dtgvProducts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvProducts.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgvProducts.Size = new System.Drawing.Size(554, 239);
            this.dtgvProducts.TabIndex = 4;
            this.dtgvProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvProducts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvProducts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvProducts.ThemeStyle.HeaderStyle.Height = 50;
            this.dtgvProducts.ThemeStyle.ReadOnly = true;
            this.dtgvProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvProducts.ThemeStyle.RowsStyle.Height = 55;
            this.dtgvProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvProducts.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewProduct_CellMouseLeave);
            this.dtgvProducts.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridViewProduct_CellMouseMove);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProductName
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ProductName.DefaultCellStyle = dataGridViewCellStyle11;
            this.ProductName.FillWeight = 200F;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Remaining
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Remaining.DefaultCellStyle = dataGridViewCellStyle12;
            this.Remaining.HeaderText = "Remaining";
            this.Remaining.MinimumWidth = 6;
            this.Remaining.Name = "Remaining";
            this.Remaining.ReadOnly = true;
            this.Remaining.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(65, 16);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(235, 38);
            this.guna2HtmlLabel1.TabIndex = 3;
            this.guna2HtmlLabel1.Text = " Low Stock Products";
            // 
            // panelMonthRevenue
            // 
            this.panelMonthRevenue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMonthRevenue.BackColor = System.Drawing.Color.Transparent;
            this.panelMonthRevenue.Controls.Add(this.RevenueChart);
            this.panelMonthRevenue.Controls.Add(this.labelRevenue);
            this.panelMonthRevenue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelMonthRevenue.Location = new System.Drawing.Point(50, 102);
            this.panelMonthRevenue.Name = "panelMonthRevenue";
            this.panelMonthRevenue.Padding = new System.Windows.Forms.Padding(4);
            this.panelMonthRevenue.Radius = 20;
            this.panelMonthRevenue.ShadowColor = System.Drawing.Color.Black;
            this.panelMonthRevenue.ShadowDepth = 255;
            this.panelMonthRevenue.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.panelMonthRevenue.Size = new System.Drawing.Size(1500, 397);
            this.panelMonthRevenue.TabIndex = 18;
            // 
            // RevenueChart
            // 
            this.RevenueChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.RevenueChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.RevenueChart.Legends.Add(legend2);
            this.RevenueChart.Location = new System.Drawing.Point(65, 66);
            this.RevenueChart.Name = "RevenueChart";
            this.RevenueChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.RevenueChart.Series.Add(series2);
            this.RevenueChart.Size = new System.Drawing.Size(1370, 291);
            this.RevenueChart.TabIndex = 3;
            this.RevenueChart.Text = "chart1";
            // 
            // labelRevenue
            // 
            this.labelRevenue.BackColor = System.Drawing.Color.Transparent;
            this.labelRevenue.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRevenue.Location = new System.Drawing.Point(65, 22);
            this.labelRevenue.Name = "labelRevenue";
            this.labelRevenue.Size = new System.Drawing.Size(104, 38);
            this.labelRevenue.TabIndex = 2;
            this.labelRevenue.Text = "Revenue";
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.scrollBarCustomer);
            this.guna2ShadowPanel1.Controls.Add(this.dtgvCustomers);
            this.guna2ShadowPanel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(846, 522);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.Padding = new System.Windows.Forms.Padding(4);
            this.guna2ShadowPanel1.Radius = 20;
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.ShadowDepth = 255;
            this.guna2ShadowPanel1.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(704, 344);
            this.guna2ShadowPanel1.TabIndex = 19;
            // 
            // scrollBarCustomer
            // 
            this.scrollBarCustomer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.scrollBarCustomer.FillColor = System.Drawing.Color.White;
            this.scrollBarCustomer.InUpdate = false;
            this.scrollBarCustomer.LargeChange = 10;
            this.scrollBarCustomer.Location = new System.Drawing.Point(652, 103);
            this.scrollBarCustomer.Minimum = 1;
            this.scrollBarCustomer.MouseWheelBarPartitions = 15;
            this.scrollBarCustomer.Name = "scrollBarCustomer";
            this.scrollBarCustomer.ScrollbarSize = 19;
            this.scrollBarCustomer.Size = new System.Drawing.Size(19, 190);
            this.scrollBarCustomer.SmallChange = 2;
            this.scrollBarCustomer.TabIndex = 6;
            this.scrollBarCustomer.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.scrollBarCustomer.ThumbSize = 1F;
            this.scrollBarCustomer.Value = 1;
            this.scrollBarCustomer.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarCustomer_Scroll);
            // 
            // dtgvCustomers
            // 
            this.dtgvCustomers.AllowUserToAddRows = false;
            this.dtgvCustomers.AllowUserToDeleteRows = false;
            this.dtgvCustomers.AllowUserToResizeColumns = false;
            this.dtgvCustomers.AllowUserToResizeRows = false;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            this.dtgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dtgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dtgvCustomers.ColumnHeadersHeight = 50;
            this.dtgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Top,
            this.Name,
            this.Total});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvCustomers.DefaultCellStyle = dataGridViewCellStyle16;
            this.dtgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvCustomers.Location = new System.Drawing.Point(65, 54);
            this.dtgvCustomers.Name = "dtgvCustomers";
            this.dtgvCustomers.ReadOnly = true;
            this.dtgvCustomers.RowHeadersVisible = false;
            this.dtgvCustomers.RowHeadersWidth = 51;
            this.dtgvCustomers.RowTemplate.DividerHeight = 1;
            this.dtgvCustomers.RowTemplate.Height = 55;
            this.dtgvCustomers.RowTemplate.ReadOnly = true;
            this.dtgvCustomers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvCustomers.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgvCustomers.Size = new System.Drawing.Size(570, 239);
            this.dtgvCustomers.TabIndex = 4;
            this.dtgvCustomers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvCustomers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvCustomers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvCustomers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvCustomers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvCustomers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvCustomers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvCustomers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvCustomers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvCustomers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvCustomers.ThemeStyle.HeaderStyle.Height = 50;
            this.dtgvCustomers.ThemeStyle.ReadOnly = true;
            this.dtgvCustomers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvCustomers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvCustomers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvCustomers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvCustomers.ThemeStyle.RowsStyle.Height = 55;
            this.dtgvCustomers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvCustomers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvCustomers.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewCustomer_CellMouseLeave);
            this.dtgvCustomers.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridViewCustomer_CellMouseMove);
            // 
            // Top
            // 
            this.Top.FillWeight = 50F;
            this.Top.HeaderText = "Top";
            this.Top.MinimumWidth = 6;
            this.Top.Name = "Top";
            this.Top.ReadOnly = true;
            // 
            // Name
            // 
            this.Name.FillWeight = 200F;
            this.Name.HeaderText = "Customer Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.FillWeight = 150F;
            this.Total.HeaderText = "Total Amount";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(65, 16);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(181, 38);
            this.guna2HtmlLabel2.TabIndex = 3;
            this.guna2HtmlLabel2.Text = "Top Customers";
            // 
            // FormReport_Statistic
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1607, 889);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Controls.Add(this.panelMonthRevenue);
            this.Controls.Add(this.guna2ShadowPanel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpkTo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.btnWeek);
            this.Controls.Add(this.dtpkFrom);
            this.Controls.Add(this.btnExportPDF);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            
            this.Text = "FormReport_Statistic";
            this.guna2ShadowPanel2.ResumeLayout(false);
            this.guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).EndInit();
            this.panelMonthRevenue.ResumeLayout(false);
            this.panelMonthRevenue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RevenueChart)).EndInit();
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExportPDF;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkFrom;
        private Guna.UI2.WinForms.Guna2Button btnWeek;
        private Guna.UI2.WinForms.Guna2Button btnMonth;
        private Guna.UI2.WinForms.Guna2Button btnYear;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpkTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvProducts;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel panelMonthRevenue;
        private System.Windows.Forms.DataVisualization.Charting.Chart RevenueChart;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelRevenue;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView dtgvCustomers;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remaining;
        private System.Windows.Forms.DataGridViewTextBoxColumn Top;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private Guna.UI2.WinForms.Guna2VScrollBar scrollBarProduct;
        private Guna.UI2.WinForms.Guna2VScrollBar scrollBarCustomer;
    }
}