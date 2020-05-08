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
        public SignUpCompany()
        {
            controllerObj = new Controller();
            InitializeComponent();
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
            if (textBox_Name.Text == "" || textBox_Pass.Text == "" || textBox_Rating.Text == "" || textBox_CurrProj.Text == "" || textBox_CompProj.Text == ""
                || textBox_AvgCost.Text == "")
                MessageBox.Show("Please fill all the required fields!");
            else if (textBox_Pass.Text != textBox_PassAgain.Text)
                MessageBox.Show("Passwords must match!");
            else if (Convert.ToInt32(textBox_Rating.Text) > 100)
                MessageBox.Show("Ratings must be between 0 and 100! (not 100 factorial)");
            else
            {
                int r = controllerObj.SignUpCompany(textBox_Name.Text, textBox_Pass.Text, Convert.ToInt32(textBox_Rating.Text), 
                    Convert.ToInt32(textBox_CompProj.Text), Convert.ToInt32(textBox_CompProj.Text), Convert.ToInt32(textBox_AvgCost.Text));
                if (r > 0)
                    MessageBox.Show("Company Signed Up Successfully!");
                else
                    MessageBox.Show("Error Encoutered While Signing up...");
            }
        }
    }
}
