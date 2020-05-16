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
        private bool Admin;
        private int ID; 
        public SignUpEmployee(bool a = false)
        {
            Admin = a; 
            controllerObj = new Controller();
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
                label2.Visible = true;
                label3.Visible = true;
                Current.Visible = true;
                Complete.Visible = true;
            }
            
        }

        public SignUpEmployee(int i)
        {
            controllerObj = new Controller();
            InitializeComponent();
            ID = i;
            L1.Hide();
            Verify.Hide();
            Access.Hide();
            Btn_SignUp.Hide();
            label1.Hide();
            TxtBox_PassAgain.Hide();
            checkBox_Devil.Hide();
            Save.Visible = true;
            TxtBx_pass.PasswordChar = '\0'; 

            DataTable dt = controllerObj.SelectEmployeeByID(ID);
            TxtBx_Nationalid.Text = Convert.ToString(dt.Rows[0]["National ID"]);
            TxtBx_pass.Text = Convert.ToString(dt.Rows[0]["Password"]);
            string name = Convert.ToString(dt.Rows[0]["Name"]);
            string[] words = name.Split(' ');
            textBox_Firstname.Text = words[0];
            textBox_Lastname.Text = words[1];
            if (Convert.ToString(dt.Rows[0]["Sex"]) == "Male") radioButton_Male.Checked = true;
            else radioButton_Female.Checked = true;
            if (Convert.ToString(dt.Rows[0]["Position"]) == "Manager") radioButton_Manager.Checked = true; 
            else if (Convert.ToString(dt.Rows[0]["Position"]) == "Projects") radioButton_Projects.Checked = true;
            else radioButton_Housing.Checked = true;
            dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0]["Start Date"]);
            Current.Value = Convert.ToInt32(dt.Rows[0]["Number of Current Projects"]);
            Complete.Value = Convert.ToInt32(dt.Rows[0]["Number of Completed Projects"]);

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

                int cm, cr; 
                if (Admin)
                {
                    cm = Convert.ToInt32(Complete.Value);
                    cr = Convert.ToInt32(Current.Value); 
                }
                else
                {
                    cm = 0;
                    cr = 0; 
                }

                int r = controllerObj.SignUpEmployee(Convert.ToInt32(TxtBx_Nationalid.Text), TxtBx_pass.Text, textBox_Firstname.Text, textBox_Lastname.Text, sex,
                    type, dateTimePicker1.Value, cm, cr);

                if (r > 0)
                {
                    MessageBox.Show("Employee Signed Up Successfully!");
                    if (Admin)
                    {
                        new Housing_Database_Project.Employees_Functionalities.ViewEmployees(-1).Show(this.Owner.Owner);
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
                label2.Visible = false;
                label3.Visible = false;
                Current.Visible = false;
                Complete.Visible = false;
                Save.Hide(); 
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(TxtBx_Nationalid.Text) ||
                String.IsNullOrWhiteSpace(TxtBx_pass.Text) ||
                String.IsNullOrWhiteSpace(textBox_Firstname.Text) ||
                String.IsNullOrWhiteSpace(textBox_Lastname.Text) ||
                String.IsNullOrWhiteSpace(Current.Text) ||
                String.IsNullOrWhiteSpace(Complete.Text) ||
                (radioButton_Male.Checked == false && radioButton_Female.Checked == false) ||
                (radioButton_Manager.Checked == false && radioButton_Projects.Checked == false && radioButton_Housing.Checked == false))
            {
                MessageBox.Show("Please fill all required fields.");
            }
            else
            {
                char s;
                char p;

                if (radioButton_Male.Checked == true)
                    s = 'M';
                else
                    s = 'F';

                if (radioButton_Manager.Checked == true)
                    p = 'M';
                else if (radioButton_Projects.Checked == true)
                    p = 'P';
                else
                    p = 'H'; 

                int done = controllerObj.UpdateEmployee(ID, Convert.ToInt32(TxtBx_Nationalid.Text), TxtBx_pass.Text,
                    textBox_Firstname.Text, textBox_Lastname.Text, s, p, dateTimePicker1.Value, Convert.ToInt32(Complete.Value), Convert.ToInt32(Current.Value));
                if (done > 0)
                {
                    MessageBox.Show("Employee information updated successfully.");
                    new Housing_Database_Project.Employees_Functionalities.ViewEmployees(-1).Show(this.Owner.Owner);
                    this.Owner.Close();
                    this.Close();
                }
                else
                    MessageBox.Show("Error encountered. Action aborted.");
            }
        }
    }
}
