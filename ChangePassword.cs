using DBapplication;
using System;
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
    public partial class ChangePassword : Form
    {
        private Controller controllerObj = new Controller();
        private string type;
        private string username; 
        public ChangePassword(string t)
        {
            type = t; 
            InitializeComponent();
            NewPassword.Enabled = false;
            Confirm.Enabled = false; 
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

       
        private void Check_Click(object sender, EventArgs e)
        {
            DataTable found = null;
            try
            {
                if (type == "Citizen")
                {
                    found = controllerObj.CheckPassword_Citizen(Convert.ToInt32(TxtBx_username.Text), TxtBx_pass.Text);
                }
                else if (type == "Employee")
                {
                    found = controllerObj.CheckPassword_Employee(Convert.ToInt32(TxtBx_username.Text), TxtBx_pass.Text);
                }
                else if (type == "Company")
                {
                    found = controllerObj.CheckPassword_Company(Convert.ToInt32(TxtBx_username.Text), TxtBx_pass.Text);
                }
                else if (type == "Bank")
                {
                    found = controllerObj.CheckPassword_Bank(TxtBx_username.Text, TxtBx_pass.Text);
                }
                else if (type == "Admin")
                {
                    found = controllerObj.CheckPassword_Admin(TxtBx_username.Text, TxtBx_pass.Text);
                }

                if (found == null) MessageBox.Show("WRONG USERNAME OR PASSWORD!!!");
                else
                {
                    MessageBox.Show("Type in your new password");
                    NewPassword.Enabled = true;
                    Confirm.Enabled = true;
                    username = TxtBx_username.Text; 
                }
            }

            catch
            {
                MessageBox.Show("WRONG USERNAME OR PASSWORD!!!");
            }
            TxtBx_username.Clear();
            TxtBx_pass.Clear();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(NewPassword.Text))
            {
                int found = 0;
                if (type == "Citizen")
                {
                    found = controllerObj.ChangePassword_Citizen(Convert.ToInt32(username), NewPassword.Text);
                }
                else if (type == "Employee")
                {
                    found = controllerObj.ChangePassword_Employee(Convert.ToInt32(username), NewPassword.Text);
                }
                else if (type == "Company")
                {
                    found = controllerObj.ChangePassword_Company(Convert.ToInt32(username), NewPassword.Text);
                }
                else if (type == "Bank")
                {
                    found = controllerObj.ChangePassword_Bank(username, NewPassword.Text);
                }
                else if (type == "Admin")
                {
                    found = controllerObj.ChangePassword_Admin(username, NewPassword.Text);
                }
                if (found != 0)
                {
                    MessageBox.Show("Password changed successfully");
                    this.Close(); 
                }
                else MessageBox.Show("An error occured");
            }
            else MessageBox.Show("Please enter a new password");

        }

        private void ChangePassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
    }
}
