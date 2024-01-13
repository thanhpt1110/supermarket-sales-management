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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExportPDF = new Guna.UI2.WinForms.Guna2Button();
            this.dtpkFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnWeek = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonth = new Guna.UI2.WinForms.Guna2Button();
            this.btnYear = new Guna.UI2.WinForms.Guna2Button();
            this.dtpkTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dtgvProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panelMonthRevenue = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.RevenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelRevenue = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dtgvCustomers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dtpkFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpkFrom.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkFrom.Location = new System.Drawing.Point(138, 30);
            this.dtpkFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkFrom.Name = "dtpkFrom";
            this.dtpkFrom.Size = new System.Drawing.Size(253, 45);
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
            this.btnWeek.Location = new System.Drawing.Point(781, 30);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(114, 45);
            this.btnWeek.TabIndex = 12;
            this.btnWeek.Text = "1 Tuần";
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
            this.btnMonth.Location = new System.Drawing.Point(893, 30);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(114, 45);
            this.btnMonth.TabIndex = 12;
            this.btnMonth.Text = "1 Tháng";
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
            this.btnYear.Location = new System.Drawing.Point(1005, 30);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(114, 45);
            this.btnYear.TabIndex = 12;
            this.btnYear.Text = "1 Năm";
            this.btnYear.TextOffset = new System.Drawing.Point(0, -1);
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // dtpkTo
            // 
            this.dtpkTo.Checked = true;
            this.dtpkTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpkTo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpkTo.Location = new System.Drawing.Point(498, 30);
            this.dtpkTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpkTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpkTo.Name = "dtpkTo";
            this.dtpkTo.Size = new System.Drawing.Size(256, 45);
            this.dtpkTo.TabIndex = 15;
            this.dtpkTo.Value = new System.DateTime(2024, 1, 10, 13, 27, 12, 63);
            this.dtpkTo.ValueChanged += new System.EventHandler(this.dtpkValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Đến ngày";
            // 
            // guna2ShadowPanel2
            // 
            this.guna2ShadowPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ShadowPanel2.BackColor = System.Drawing.Color.Transparent;
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
            // dtgvProducts
            // 
            this.dtgvProducts.AllowUserToAddRows = false;
            this.dtgvProducts.AllowUserToDeleteRows = false;
            this.dtgvProducts.AllowUserToResizeColumns = false;
            this.dtgvProducts.AllowUserToResizeRows = false;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.White;
            this.dtgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dtgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dtgvProducts.ColumnHeadersHeight = 50;
            this.dtgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ProductName,
            this.Remaining});
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvProducts.DefaultCellStyle = dataGridViewCellStyle25;
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
            this.dtgvProducts.Size = new System.Drawing.Size(574, 239);
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
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ProductName.DefaultCellStyle = dataGridViewCellStyle23;
            this.ProductName.FillWeight = 200F;
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Remaining
            // 
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.Remaining.DefaultCellStyle = dataGridViewCellStyle24;
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
            chartArea3.Name = "ChartArea1";
            this.RevenueChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.RevenueChart.Legends.Add(legend3);
            this.RevenueChart.Location = new System.Drawing.Point(65, 66);
            this.RevenueChart.Name = "RevenueChart";
            this.RevenueChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.RevenueChart.Series.Add(series3);
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
            // dtgvCustomers
            // 
            this.dtgvCustomers.AllowUserToAddRows = false;
            this.dtgvCustomers.AllowUserToDeleteRows = false;
            this.dtgvCustomers.AllowUserToResizeColumns = false;
            this.dtgvCustomers.AllowUserToResizeRows = false;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            this.dtgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle26;
            this.dtgvCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dtgvCustomers.ColumnHeadersHeight = 50;
            this.dtgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvCustomers.DefaultCellStyle = dataGridViewCellStyle30;
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
            this.dtgvCustomers.Size = new System.Drawing.Size(574, 239);
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
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Top";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewTextBoxColumn2.FillWeight = 200F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Customer Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle29;
            this.dataGridViewTextBoxColumn3.HeaderText = "Total payment";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            this.Name = "FormReport_Statistic";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}