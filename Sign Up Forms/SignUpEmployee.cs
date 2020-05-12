using DBapplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Housing_Database_Project.Sign_Up_Forms
{
    public partial class SignUpEmployee : Form
    {
        private Controller controllerObj;
        public SignUpEmployee()
        {
            controllerObj = new Controller();
            InitializeComponent();
            foreach (Control c in Controls)
                c.Hide();
            title.Show();
            L1.Show();
            button_Back.Show();
            Verify.Show();
            Access.Show();
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

        private void SignUpEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void Btn_SignUp_Click(object sender, EventArgs e)
        {
            if (TxtBx_Nationalid.Text == "" || textBox_Firstname.Text == "" || textBox_Lastname.Text == "" || TxtBx_pass.Text == "" || !(radioButton_Male.Checked || radioButton_Female.Checked)
              || !(radioButton_Manager.Checked || radioButton_Housing.Checked || radioButton_Projects.Checked))
                MessageBox.Show("Please fill all the required fields!");
            else if (TxtBx_pass.Text != TxtBox_PassAgain.Text)
                MessageBox.Show("Passwords must match!");
            else
            {
                char sex;
                if (radioButton_Male.Checked) sex = 'M';
                else sex = 'F';

                char type;
                if (radioButton_Manager.Checked) type = 'M';
                else if (radioButton_Projects.Checked) type = 'P';
                else type = 'H';

                int r = controllerObj.SignUpEmployee(Convert.ToInt32(TxtBx_Nationalid.Text), TxtBx_pass.Text, textBox_Firstname.Text, textBox_Lastname.Text, sex,
                    type, dateTimePicker1.Value);

                if (r > 0)
                    MessageBox.Show("Employee Signed Up Successfully!");
                else
                    MessageBox.Show("Error Encoutered While Signing up...");
            }
        }

        private void Verify_Click(object sender, EventArgs e)
        {
            string Pass = Convert.ToString(controllerObj.GetAccess("Employee").Rows[0][0]);
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
    }
}
