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
    public partial class Force : Form
    {
        public bool choice; 
        public Force()
        {
            InitializeComponent();
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            choice = true;
            this.Close(); 
        }

        private void No_Click(object sender, EventArgs e)
        {
            choice = false;
            this.Close(); 
        }
    }
}
