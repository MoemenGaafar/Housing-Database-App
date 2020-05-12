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
    public partial class Units : Form
    {
        private Controller controllerObj = new Controller();
        private char user;
        private int ID;
        private int count = 0; 
        public Units(char u, int i)
        {
            user = u;
            ID = i; 
            InitializeComponent();
            if (user == 'E')
            {
                ProjectApply.Enabled = false;
                Unit.Enabled = false;
                Submit.Enabled = false;
                MaxApplications.Hide(); 
            }
            else
            {
                DataTable C = controllerObj.CountCitApplicationsbyCitizen(ID);
                count = Convert.ToInt32(C.Rows[0][0]);
                MaxApplications.Text = "Max. allowed active application and claimed units count = 3"; 
                YourApplications.Text = "Your active application and claimed units count =" + Convert.ToString(count); 
            }
            DataTable dt = controllerObj.SelectAllUnits();
            dataGridView1.DataSource = dt;
            DataTable dp = controllerObj.GetAllProjectIDs();
            ProjectSort.DataSource = dp;
            ProjectSort.DisplayMember = "ID";
            ProjectSort.ValueMember = "ID";
            DataTable dC = controllerObj.SelectProjectCities();
            City.DataSource = dC;
            City.DisplayMember = "City";
            City.ValueMember = "City"; 

            for (int intCount = 0; intCount < dt.Rows.Count; intCount++)
            {
                var val = dt.Rows[intCount]["ProjectID"];

                if (!ProjectApply.Items.Contains(val))
                {
                    ProjectApply.Items.Add(val);
                }
            }
            Unit.Hide();
            LabelUnit.Hide(); 
            Submit.Hide();
            City.SelectedIndex = -1;
            ProjectSort.SelectedIndex = -1; 

        }

        private void Units_Load(object sender, EventArgs e)
        {

        }

        private void View_Click(object sender, EventArgs e)
        {
            DataTable U = null; 
            if (!String.IsNullOrWhiteSpace(Price.Text))
            {
                bool isNumber = true;
                foreach (char c in Price.Text)
                {
                    if (c < '0' || c > '9')
                        isNumber = false;
                }
                if (!isNumber)
                    MessageBox.Show("Please insert a valid price");
                else if (ProjectSort.SelectedIndex == -1 && City.SelectedIndex == -1)
                {
                    U = controllerObj.SelectUnitsByPrice(Convert.ToInt32(Price.Text));
                }
                else if (ProjectSort.SelectedIndex == -1)
                {
                    U = controllerObj.SelectUnitsByPriceAndCity(Convert.ToInt32(Price.Text), Convert.ToString(City.SelectedValue));
                }
                else
                {
                    U = controllerObj.SelectUnitsByProjectAndPrice(Convert.ToInt32(Price.Text), Convert.ToInt32(ProjectSort.SelectedValue));
                }
            }
            else
            {
                if (ProjectSort.SelectedIndex == -1 && City.SelectedIndex == -1)
                {
                    U = controllerObj.SelectAllUnits();
                }
                if (ProjectSort.SelectedIndex == -1)
                {
                    U = controllerObj.SelectUnitsByCity(Convert.ToString(City.Text)); 
                }
                else
                {
                   U = controllerObj.SelectUnitsByProject(Convert.ToInt32(ProjectSort.SelectedValue));
                }
            }

            dataGridView1.DataSource = U; 
            
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            
            if (count >= 3)
                MessageBox.Show("You have already reached your application limit. Delete one of your existing applications to fill a new one.");
            else
            {
                if (ProjectApply.SelectedIndex == -1 || Unit.SelectedIndex == -1)
                    MessageBox.Show("Please select a project and a unit to apply to.");
                else
                {
                    int done = controllerObj.CreateCitApplication(Convert.ToInt32(ProjectApply.SelectedItem), Convert.ToInt32(Unit.SelectedValue), ID);
                    if (done != 0)
                    {
                        MessageBox.Show("Application added successfully. \n  Note that you can only submit one application to any one housing unit, so if you already had an application to this unit a new one wwas not submitted.");
                        DataTable C = controllerObj.CountCitApplicationsbyCitizen(ID);
                        count = Convert.ToInt32(C.Rows[0][0]);
                        YourApplications.Text = "Your active application and claimed units count =" + Convert.ToString(count);
                    }
                    else
                        MessageBox.Show("An error occured.");
                }
            }
        }

        private void ProjectApply_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable du = controllerObj.GetUnsoldUnitsOfProject(Convert.ToInt32(ProjectApply.SelectedItem));
            Unit.DataSource = du;
            Unit.DisplayMember = "ID";
            Unit.ValueMember = "ID";
            Unit.Refresh();
            Unit.Show();
            LabelUnit.Show(); 
            Submit.Show(); 
        }

        private void Manage_Click(object sender, EventArgs e)
        {
            new CitizenApplications(ID).Show(this);
        }

        private void Units_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(City.Text))
            {
                DataTable dL = controllerObj.SelectProjectsByCity(Convert.ToString(City.Text));
                ProjectSort.DataSource = dL;
                ProjectSort.DisplayMember = "ID";
                ProjectSort.ValueMember = "ID";
                ProjectSort.Refresh();
            }
        }
    }
}
