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

namespace Housing_Database_Project.Sign_Up_Forms
{
    public partial class SignUpCompany : Form
    {
        private Controller controllerObj;
        private bool Admin;
        private int ID;
        public SignUpCompany(bool a = false)
        {
            controllerObj = new Controller();
            Admin = a; 
            InitializeComponent();
            if (!Admin)
            {
                foreach (Control c in Controls)
                    c.Hide();
                title.Show();
                L1.Show();
                button_Back.Show();
                Verify.Show();
                Access.Show();
            }
            else
            {
                L1.Hide();
                Verify.Hide();
                Access.Hide();
            }
        }

        public SignUpCompany(int i)
        {
            controllerObj = new Controller();
            InitializeComponent();
            ID = i;
            L1.Hide();
            Verify.Hide();
            Access.Hide();
            Btn_SignUp.Hide();
            label6.Hide();
            textBox_PassAgain.Hide();
            checkBox_Devil.Hide();
            Save.Visible = true;
            textBox_Pass.PasswordChar = '\0';

            DataTable dt = controllerObj.SelectCompanyByID(ID);
            textBox_Name.Text = Convert.ToString(dt.Rows[0]["Company"]);
            textBox_Pass.Text = Convert.ToString(dt.Rows[0]["Password"]);
            Current.Value = Convert.ToInt32(dt.Rows[0]["Number of Current Projects"]);
            Complete.Value = Convert.ToInt32(dt.Rows[0]["Number of Completed Projects"]);
            Cost.Value = Convert.ToInt32(dt.Rows[0]["Average Project Cost"]);
            Rating.Value = Convert.ToInt32(dt.Rows[0]["Rating"]);
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_Devil_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Devil.Checked) Btn_SignUp.Enabled = true;
            else Btn_SignUp.Enabled = false;
        }

        private void SignUpCompany_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void Btn_SignUp_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text == "" || textBox_Pass.Text == "")
                MessageBox.Show("Please fill all the required fields!");
            else if (textBox_Pass.Text != textBox_PassAgain.Text)
                MessageBox.Show("Passwords must match!");
            else
            {
                int cm, cr, cs, r; 
                if (Admin)
                {
                    cm = Convert.ToInt32(Complete.Value);
                    cr = Convert.ToInt32(Current.Value);
                    r = Convert.ToInt32(Rating.Value);
                    cs = Convert.ToInt32(Cost.Value); 
                }
                else
                {
                    cm = 0;
                    cr = 0;
                    cs = 0;
                    r = 0; 
                }

                int done = controllerObj.SignUpCompany(textBox_Name.Text, textBox_Pass.Text, cm, cr, r , cs);
                if (done > 0)
                {
                    MessageBox.Show("Company Signed Up Successfully!");
                    if (Admin)
                    {
                        new Housing_Database_Project.Employees_Functionalities.ViewCompanies(-1).Show(this.Owner.Owner);
                        this.Owner.Close();
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Error Encoutered While Signing up...");
            }
        }

        private void Verify_Click(object sender, EventArgs e)
        {
            string Pass = Convert.ToString(controllerObj.GetAccess("Company").Rows[0][0]);
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
                label2.Visible = false;
                label3.Visible = false;
                label1.Visible = false;
                label4.Visible = false; 
                Current.Visible = false;
                Complete.Visible = false;
                Cost.Visible = false;
                Rating.Visible = false; 
                Save.Visible = false; 
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox_Name.Text) ||
                String.IsNullOrWhiteSpace(textBox_Pass.Text) ||
                String.IsNullOrWhiteSpace(Current.Text) ||
                String.IsNullOrWhiteSpace(Complete.Text) ||
                String.IsNullOrWhiteSpace(Cost.Text) ||
                String.IsNullOrWhiteSpace(Rating.Text) )
                MessageBox.Show("Please fill all required fields before trying to Save");
            else
            {
                int done = controllerObj.UpdateCompany(ID, textBox_Name.Text, textBox_Pass.Text, Convert.ToInt32(Complete.Value), 
                     Convert.ToInt32(Current.Value), Convert.ToInt32(Rating.Value), Convert.ToInt32(Cost.Value));
                if (done > 0)
                {
                    MessageBox.Show("Company information updated successfully.");
                    new Housing_Database_Project.Employees_Functionalities.ViewCompanies(-1).Show(this.Owner.Owner);
                    this.Owner.Close();
                    this.Close();
                }
                else
                    MessageBox.Show("Error encountered. Action aborted.");
            }
        }
    }
}
