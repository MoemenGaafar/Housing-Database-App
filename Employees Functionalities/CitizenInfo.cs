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

namespace Housing_Database_Project.Employees_Functionalities
{
    public partial class CitizenInfo : Form
    {
        private int ID;
        private bool Admin = false; 
        private DataTable dt;
        private Controller controllerObj;
        public CitizenInfo(int id, bool a = false)
        {
            ID = id;
            Admin = a; 
            controllerObj = new Controller();
            InitializeComponent();

            if (Admin)
            {
                Save.Visible = true;
                button_ViewDeps.Hide();
                label1.Visible = true;
                Password.Visible = true;
            }
        }

        private void CitizenInfo_Load(object sender, EventArgs e)
        {
            dt = controllerObj.SelectCitizenByID(ID);
            TxtBx_Nationalid.Text = Convert.ToString(dt.Rows[0]["NationalID"]);
            textBox_Firstname.Text = Convert.ToString(dt.Rows[0]["First Name"]);
            textBox_Lastname.Text = Convert.ToString(dt.Rows[0]["Last Name"]);
            textBox_City.Text = Convert.ToString(dt.Rows[0]["Current City"]);
            textBox_PriceAccom.Text = Convert.ToString(dt.Rows[0]["Current Accommodation Price"]);
            textBox_Salary.Text = Convert.ToString(dt.Rows[0]["Salary"]);
            dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0]["BirthDate"]);

            if (Convert.ToString(dt.Rows[0]["Sex"]) == "Male") radioButton_Male.Checked = true;
            else radioButton_Female.Checked = true;

            if (Convert.ToBoolean(dt.Rows[0]["OwnsCurrent"])) radioButton_Yes.Checked = true;
            else radioButton_No.Checked = true;

            if (Admin)
            {
                Password.Text = Convert.ToString(dt.Rows[0]["Password"]);
            }

            
        }

        private void button_ViewDeps_Click(object sender, EventArgs e)
        {
            new CitizenDependents("Employee", ID).Show(this);
            this.Hide();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TxtBx_Nationalid.Text) || String.IsNullOrWhiteSpace(textBox_Firstname.Text) || String.IsNullOrWhiteSpace(textBox_Lastname.Text) ||
                String.IsNullOrWhiteSpace(textBox_City.Text) || String.IsNullOrWhiteSpace(textBox_PriceAccom.Text) || String.IsNullOrWhiteSpace(textBox_Salary.Text) ||
                String.IsNullOrWhiteSpace(Password.Text) || (radioButton_Male.Checked == false && radioButton_Female.Checked == false) ||
                (radioButton_Yes.Checked == false && radioButton_No.Checked == false))
                MessageBox.Show("Please fill all required fields before trying to save."); 
            else
            {
                char s;
                bool o;

                if (radioButton_Male.Checked == true)
                    s = 'M';
                else
                    s = 'F';

                if (radioButton_Yes.Checked == true)
                    o = true;
                else
                    o = false;

                int done = controllerObj.UpdateCitizen(ID, Convert.ToInt32(TxtBx_Nationalid.Text), Password.Text, textBox_Firstname.Text,
                   textBox_Lastname.Text, dateTimePicker1.Value, Convert.ToInt32(textBox_Salary.Text), s,
                   textBox_City.Text, o, Convert.ToInt32(textBox_PriceAccom.Text));
                if (done > 0)
                {
                    MessageBox.Show("Citizen information updated successfully.");
                    new ViewCitizens().Show(this.Owner.Owner);
                    this.Owner.Close();
                    this.Close(); 

                }
                else
                    MessageBox.Show("Error encountered. Action aborted."); 
            }
            
        }

        private void CitizenInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
             if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
    }
}
