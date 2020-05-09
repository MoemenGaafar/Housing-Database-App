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
    public partial class SignUpCitizen : Form
    {
        private Controller controllerObj;
        public SignUpCitizen()
        {
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void SignUpCitizen_Load(object sender, EventArgs e)
        {

        }

        private void checkBox_Devil_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Devil.Checked) Btn_SignUp.Enabled = true;
            else Btn_SignUp.Enabled = false;
        }

        private void button_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignUpCitizen_FormClosed(object sender, FormClosedEventArgs e)
        {
                if (e.CloseReason == CloseReason.UserClosing)
                    Owner.Show();
        }

        private void Btn_SignUp_Click(object sender, EventArgs e)
        {
            if (TxtBx_Nationalid.Text == "" || textBox_Firstname.Text == "" || textBox_Lastname.Text == "" || textBox_PriceAccom.Text == ""
                || textBox_Salary.Text == "" || textBox_City.Text == "" || TxtBx_pass.Text == "" || !(radioButton_Male.Checked  || radioButton_Female.Checked) 
                || !(radioButton_Yes.Checked || radioButton_No.Checked))
                MessageBox.Show("Please fill all the required fields!");
            else if (TxtBx_pass.Text != TxtBox_PassAgain.Text)
                MessageBox.Show("Passwords must match!");
            else
            {
                char sex;
                if (radioButton_Male.Checked) sex = 'M';
                else sex = 'F';

                bool ownsOther;
                if (radioButton_Yes.Checked) ownsOther = true;
                else ownsOther = false;

                int r = controllerObj.SignUpCitizen(Convert.ToInt32(TxtBx_Nationalid.Text), TxtBx_pass.Text, textBox_Firstname.Text, textBox_Lastname.Text, sex,
                   Convert.ToInt32(textBox_Salary.Text), ownsOther, textBox_City.Text, dateTimePicker1.Value, Convert.ToInt32(textBox_PriceAccom.Text));

                if (r > 0) 
                    MessageBox.Show("Citizen Signed Up Successfully!");
                else
                    MessageBox.Show("Error Encoutered While Signing up...");
            }
        }
    }
}
