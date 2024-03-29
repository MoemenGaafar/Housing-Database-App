﻿using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Housing_Database_Project.Sign_Up_Forms
{
    public partial class SignUpAdmin : Form
    {
        private Controller controllerObj = new Controller();
        public SignUpAdmin()
        {
            InitializeComponent();
            foreach (Control c in Controls)
                c.Hide();
            title.Show();
            L1.Show();
            button_Back.Show();
            Verify.Show();
            Access.Show();
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Verify_Click(object sender, EventArgs e)
        {
            string Pass = Convert.ToString(controllerObj.GetAccess("Admin").Rows[0][0]);
            if (Access.Text != Pass)
                MessageBox.Show("Incorrect Pass code.");
            else
            {
                foreach (Control c in Controls)
                    c.Show();
                L1.Hide();
                button_Back.Hide();
                Verify.Hide();
                Access.Hide();
            }
        }

        private void Btn_SignUp_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "" || textBox_Pass.Text == "" )
                MessageBox.Show("Please fill all the required fields!");
            else if (textBox_Pass.Text != textBox_PassAgain.Text)
                MessageBox.Show("Passwords must match!");
            else
            {
                int r = controllerObj.SignUpAdmin(textBox_Name.Text, textBox_Pass.Text);
                if (r > 0)
                    MessageBox.Show("Admin Signed Up Successfully!");
                else
                    MessageBox.Show("Error Encoutered While Signing up...");
            }
        }

        private void checkBox_Devil_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Devil.Checked) Btn_SignUp.Enabled = true;
            else Btn_SignUp.Enabled = false;
        }

        private void SignUpAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
    }
}
