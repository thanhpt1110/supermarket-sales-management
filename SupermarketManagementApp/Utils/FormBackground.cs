﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementApp.Utils
{
    public partial class FormBackground : Form
    {
        private FormMain formMain;
        public FormBackground()
        {
            InitializeComponent();
        }

        public FormBackground(FormMain formMain)
        {
            InitializeComponent();  
            this.formMain = formMain;
        }

        private void FormBackground_Load(object sender, EventArgs e)
        {
            this.Size = formMain.Size;
            this.Location = formMain.Location;
            this.Owner = formMain;
        }
    }
}
