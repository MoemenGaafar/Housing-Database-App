﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Housing_Database_Project
{
    public partial class CompanyFunctionalities : Form
    {
        public CompanyFunctionalities()
        {
            InitializeComponent();
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompanyFunctionalities_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
    }
}