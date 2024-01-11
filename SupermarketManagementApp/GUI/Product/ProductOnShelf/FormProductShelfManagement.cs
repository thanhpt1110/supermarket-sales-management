﻿using Guna.UI2.WinForms;
using SupermarketManagementApp.GUI.Invoice.SupplierInvoice;
using SupermarketManagementApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementApp.GUI.Product.ProductOnShelf
{
    public partial class FormProductShelfManagement : Form
    {
        private FormMain formMain;
        private int fixedWidthPanel = 0;
       
        // Tạo list để load thông tin shelves
        private (string ShelfID, string ShelfType, int UsedCapacity, int TotalCapacity)[] shelvesData;

        public FormProductShelfManagement()
        {
            InitializeComponent();
        }

        public FormProductShelfManagement(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            filterFloor.SelectedItem = "Floor 1";
        }

        // Phải load data trong sự kiện này thì UI mới cập nhật đúng
        private void FormProductShelfManagement_Shown(object sender, EventArgs e)
        {
            fixedWidthPanel = panelShelfContainer.Width - 25;
            LoadShelfData();
        }

        private void LoadShelfData()
        {
            shelvesData = new[]
            {
                ("101", "Grain", 38, 100),
                ("102", "Fruit", 50, 120),
                ("103", "Vegetable", 30, 80),
                ("104", "Dairy", 45, 90),
                ("105", "Meat", 60, 120),
                ("101", "Grain", 38, 100),
            };
            foreach (var shelfData in shelvesData)
            {
                string shelfName = "Shelf " + shelfData.ShelfID + " - " + shelfData.ShelfType;
                panelShelfContainer.Controls.Add(Shelf(shelfData.ShelfID, shelfName, shelfData.UsedCapacity, shelfData.TotalCapacity));
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {

        }

        private Guna2ShadowPanel Shelf(string shelfID, string shelfName, int usedCapacity, int totalCapacity)
        {
            Guna2ShadowPanel newShelf = new Guna2ShadowPanel();
            newShelf.Dock = DockStyle.Top;
            newShelf.Cursor = Cursors.Hand;
            newShelf.Size = new Size(fixedWidthPanel, 50);
            newShelf.Anchor = (AnchorStyles.Left | AnchorStyles.Right);
            newShelf.BackColor = Color.Transparent;
            newShelf.FillColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            newShelf.Location = new Point(20, 0);
            newShelf.Margin = new Padding(0, 10, 0, 20);
            newShelf.Name = shelfID;
            newShelf.Radius = 15;
            newShelf.ShadowColor = Color.Black;
            newShelf.ShadowDepth = 255;
            newShelf.ShadowStyle = Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            newShelf.Size = new Size(fixedWidthPanel, 100);

            newShelf.Controls.Add(ShelfLabel(shelfName));
            newShelf.Controls.Add(ShelfCapacity(usedCapacity, totalCapacity));

            newShelf.MouseMove += (sender, e) =>
            {
                newShelf.FillColor = Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            };

            newShelf.MouseLeave += (sender, e) =>
            {
                newShelf.FillColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            };

            newShelf.Click += (sender, e) =>
            {
                FormBackground formBackground = new FormBackground(formMain);
                try
                {
                    using (FormDetailProductOnShelf formDetailProductOnShelf = new FormDetailProductOnShelf())
                    {
                        formBackground.Owner = formMain;
                        formBackground.Show();
                        formDetailProductOnShelf.Owner = formBackground;
                        formDetailProductOnShelf.ShowDialog();
                        formBackground.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    msgBoxError.Parent = formMain;
                    msgBoxError.Show(ex.Message, "Error");
                }
            };

            return newShelf;
        }

        private Guna2HtmlLabel ShelfLabel(string shelfName)
        {
            Guna2HtmlLabel shelfLabel = new Guna2HtmlLabel();

            shelfLabel.BackColor = Color.Transparent;
            shelfLabel.Font = new Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            
            shelfLabel.Text = shelfName;
            shelfLabel.Name = "labelShelf";
            shelfLabel.TabIndex = 0;
            shelfLabel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            int startX = (fixedWidthPanel / 2 - shelfLabel.Size.Width / 2);
            shelfLabel.Location = new Point(startX, 13);

            return shelfLabel;  
        }

        private Guna2ProgressBar ShelfCapacity(int usedCapacity, int totalCapacity) 
        {
            Guna2ProgressBar shelfCapacity = new Guna2ProgressBar();

            shelfCapacity.BorderColor = System.Drawing.Color.WhiteSmoke;
            shelfCapacity.BorderRadius = 8;
            shelfCapacity.BorderThickness = 0;
            shelfCapacity.FillColor = System.Drawing.Color.Gray;
            shelfCapacity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            shelfCapacity.ForeColor = System.Drawing.Color.White;
            shelfCapacity.Name = "availableCapacity";
            shelfCapacity.ProgressColor = System.Drawing.Color.ForestGreen;
            shelfCapacity.ProgressColor2 = System.Drawing.Color.ForestGreen;
            shelfCapacity.ShowText = true;
            shelfCapacity.TabIndex = 15;
            shelfCapacity.TextMode = Guna.UI2.WinForms.Enums.ProgressBarTextMode.Custom;
            shelfCapacity.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;

            shelfCapacity.Size = new System.Drawing.Size(fixedWidthPanel - 70, 20);
            int startX = (fixedWidthPanel / 2 - shelfCapacity.Size.Width / 2);
            shelfCapacity.Location = new System.Drawing.Point(startX, 55);

            shelfCapacity.Minimum = 0;
            shelfCapacity.Maximum = totalCapacity;
            shelfCapacity.Value = usedCapacity;
            int remaining = totalCapacity - usedCapacity;
            shelfCapacity.Text = ("Capacity: " + usedCapacity + " used, " + remaining + " remaining.");

            return shelfCapacity;  
        }
    }
}
