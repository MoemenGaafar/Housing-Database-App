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
    public partial class CitizenDependents : Form
    {
        private Controller controllerObj = new Controller();
        private string type; //"Citizen", "Admin", "Employee"
        private int ID; 
        public CitizenDependents(string t, int CID)
        {
            type = t;
            ID = CID;
            InitializeComponent();
            DataTable dt = controllerObj.SelectDependentsByCitizen(ID);
            dataGridView1.DataSource = dt;
            NameRemove.DataSource = dt;
            NameRemove.ValueMember = "Name";
            NameRemove.DisplayMember = "Name"; 
            NameSalary.DataSource = dt;
            NameSalary.ValueMember = "Name";
            NameSalary.DisplayMember = "Name";
            NameName.DataSource = dt;
            NameName.ValueMember = "Name";
            NameName.DisplayMember = "Name";
            NameBirth.DataSource = dt;
            NameBirth.ValueMember = "Name";
            NameBirth.DisplayMember = "Name";

            if (type != "Admin")
            {
                Confirm2.Hide();
                Confirm3.Hide();
                label12.Hide();
                label13.Hide();
                label14.Hide();
                label15.Hide();
                label16.Hide();
                label17.Hide();
                NameName.Hide();
                NameNew.Hide();
                NameBirth.Hide();
                BirthdateNew.Hide();
                
            }

            if(type == "Employee")
            {
                label2.Hide();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                label9.Hide();
                label10.Hide();
                label11.Hide();
                Confirm.Hide();
                Remove.Hide();
                Add.Hide();
                NameAdd.Hide();
                NameRemove.Hide();
                NameSalary.Hide();
                Salary.Hide();
                SalaryNew.Hide(); 
                Birthdate.Hide();
                Relationship.Hide(); 

            }

            DataTable C = controllerObj.SelectCitizenByID(ID);
            CitizenID.Text = Convert.ToString(C.Rows[0]["First Name"]) + Convert.ToString(C.Rows[0]["Last Name"]);

        }

        private void CitizenDependents_Load(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            bool isNumber = true;
            foreach (char c in SalaryNew.Text)
            {
                if (c < '0' || c > '9')
                    isNumber = false;
            }
            if (!isNumber || String.IsNullOrWhiteSpace(SalaryNew.Text) || NameSalary.SelectedIndex == -1)
                MessageBox.Show("Please insert a valid salary and dependent name.");
            else
            {
                int done = controllerObj.AlterDependentSalary(Convert.ToString(NameSalary.SelectedValue), ID, Convert.ToInt32(SalaryNew.Text)); 
                if(done != 0)
                {
                    DataTable dt = controllerObj.SelectDependentsByCitizen(ID);
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("Salary altered successfully.");
                }
                else
                    MessageBox.Show("Error occured. Action aborted");
            }
           
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if ( NameRemove.SelectedIndex == -1)
                MessageBox.Show("Please insert a valid dependent name.");
            else
            {
                int done = controllerObj.RemoveDependent(Convert.ToString(NameRemove.SelectedValue), ID);
                if (done != 0)
                {
                    DataTable dt = controllerObj.SelectDependentsByCitizen(ID);
                    dataGridView1.DataSource = dt;
                    NameRemove.DataSource = dt;
                    NameRemove.ValueMember = "Name";
                    NameRemove.DisplayMember = "Name";
                    NameSalary.DataSource = dt;
                    NameSalary.ValueMember = "Name";
                    NameSalary.DisplayMember = "Name";
                    NameName.DataSource = dt;
                    NameName.ValueMember = "Name";
                    NameName.DisplayMember = "Name";
                    NameBirth.DataSource = dt;
                    NameBirth.ValueMember = "Name";
                    NameBirth.DisplayMember = "Name";

                    MessageBox.Show("Dependent removed successfully.");
                }
                else
                    MessageBox.Show("Error occured. Action aborted");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            bool isNumber = true;
            foreach (char c in SalaryNew.Text)
            {
                if (c < '0' || c > '9')
                    isNumber = false;
            }
            if (!isNumber || String.IsNullOrWhiteSpace(Salary.Text) || String.IsNullOrWhiteSpace(NameAdd.Text) || Relationship.SelectedIndex == -1 || !Birthdate.Checked)
                MessageBox.Show("Please insert a valid values for your dependent's information.");
            else
            {
                char R = 'O';
                if ((string)Relationship.SelectedItem == "Child")
                    R = 'C';
                else if ((string)Relationship.SelectedItem == "Parent")
                    R = 'P';
                else if ((string)Relationship.SelectedItem == "Spouse")
                    R = 'S';
                else if ((string)Relationship.SelectedItem == "Other")
                    R = 'O';

                int done = controllerObj.AddDependent(Convert.ToString(NameAdd.Text), ID, Birthdate.Value, Convert.ToInt32(Salary.Text), R);
                if (done != 0)
                {
                    DataTable dt = controllerObj.SelectDependentsByCitizen(ID);
                    dataGridView1.DataSource = dt;
                    NameRemove.DataSource = dt;
                    NameRemove.ValueMember = "Name";
                    NameRemove.DisplayMember = "Name";
                    NameSalary.DataSource = dt;
                    NameSalary.ValueMember = "Name";
                    NameSalary.DisplayMember = "Name";
                    NameName.DataSource = dt;
                    NameName.ValueMember = "Name";
                    NameName.DisplayMember = "Name";
                    NameBirth.DataSource = dt;
                    NameBirth.ValueMember = "Name";
                    NameBirth.DisplayMember = "Name";
                    MessageBox.Show("Dependent added successfully.");
                }
                else
                    MessageBox.Show("Error occured. Action aborted");
            }
        }

        private void CitizenDependents_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void Confirm2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(NameName.Text) || String.IsNullOrWhiteSpace(NameNew.Text))
                MessageBox.Show("Please insert a valid dependent name and new name.");
            else
            {
                int done = controllerObj.AlterDependentName(Convert.ToString(NameRemove.SelectedValue), ID, NameNew.Text);
                if (done != 0)
                {
                    DataTable dt = controllerObj.SelectDependentsByCitizen(ID);
                    dataGridView1.DataSource = dt;
                    NameRemove.DataSource = dt;
                    NameRemove.ValueMember = "Name";
                    NameRemove.DisplayMember = "Name";
                    NameSalary.DataSource = dt;
                    NameSalary.ValueMember = "Name";
                    NameSalary.DisplayMember = "Name";
                    NameName.DataSource = dt;
                    NameName.ValueMember = "Name";
                    NameName.DisplayMember = "Name";
                    NameBirth.DataSource = dt;
                    NameBirth.ValueMember = "Name";
                    NameBirth.DisplayMember = "Name";
                    MessageBox.Show("Name changed successfully.");
                }
                else
                    MessageBox.Show("Error occured. Action aborted");
            }
        }

        private void Confirm3_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(NameBirth.Text) || !BirthdateNew.Checked)
                MessageBox.Show("Please insert a valid dependent name and new birthday.");
            else
            {
                int done = controllerObj.AlterDependentBirthdate(Convert.ToString(NameRemove.SelectedValue), ID, BirthdateNew.Value);
                if (done != 0)
                {
                    DataTable dt = controllerObj.SelectDependentsByCitizen(ID);
                    dataGridView1.DataSource = dt;
                    NameRemove.DataSource = dt;
                    NameRemove.ValueMember = "Name";
                    NameRemove.DisplayMember = "Name";
                    NameSalary.DataSource = dt;
                    NameSalary.ValueMember = "Name";
                    NameSalary.DisplayMember = "Name";
                    NameName.DataSource = dt;
                    NameName.ValueMember = "Name";
                    NameName.DisplayMember = "Name";
                    NameBirth.DataSource = dt;
                    NameBirth.ValueMember = "Name";
                    NameBirth.DisplayMember = "Name";
                    MessageBox.Show("Birthday changed successfully.");
                }
                else
                    MessageBox.Show("Error occured. Action aborted");
            }
    }   }
}
