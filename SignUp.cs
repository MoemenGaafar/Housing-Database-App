using DBapplication;
using Housing_Database_Project.Sign_Up_Forms;
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
    public partial class SignUp : Form
    {
        private Controller controllerObj;
        public SignUp()
        {
            InitializeComponent();
            controllerObj = new Controller();
            comboBox_AccType.SelectedIndex = -1;
        }




        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void comboBox_AccType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            if ((string)comboBox_AccType.SelectedItem == "Bank")
            {
                new SignUpBank().Show(this);
            }
            else if ((string)comboBox_AccType.SelectedItem == "Citizen")
            {
                new SignUpCitizen().Show(this);
            }
            else if ((string)comboBox_AccType.SelectedItem == "Company")
            {
                new SignUpCompany().Show(this);
            }
            else if ((string)comboBox_AccType.SelectedItem == "Employee")
            {
                new SignUpEmployee().Show(this);
            }
            else if ((string)comboBox_AccType.SelectedItem == "Admin")
            {
                new SignUpAdmin().Show(this);
            }
            comboBox_AccType.SelectedIndex = -1;
        }
    }
}
