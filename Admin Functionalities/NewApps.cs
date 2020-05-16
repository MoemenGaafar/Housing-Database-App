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
    public partial class NewApps : Form
    {
        private Controller controllerObj = new Controller();
        public NewApps()
        {
            InitializeComponent();
                       
            DataTable dp = controllerObj.GetAllProjectIDs();
            CitProject.DataSource = dp;
            CitProject.DisplayMember = "ID";
            CitProject.ValueMember = "ID";
            DataTable dp2 = controllerObj.GetAllProjectIDs();
            ComProject.DataSource = dp2;
            ComProject.DisplayMember = "ID";
            ComProject.ValueMember = "ID";
            CitProject.SelectedIndex = -1;
            ComProject.SelectedIndex = -1;


            DataTable C = controllerObj.GetAllCompanies();
            ComCompany.DataSource = C;
            ComCompany.ValueMember = "Company ID";
            ComCompany.DisplayMember = "Company";
            ComCompany.SelectedIndex = -1;

            DataTable C2 = controllerObj.GetAllCitizens();
            CitCitizen.DataSource = C2;
            CitCitizen.DisplayMember = "NationalId";
            CitCitizen.ValueMember = "NationalID";
            CitCitizen.SelectedIndex = -1;           
        }

        private void NewApps_Load(object sender, EventArgs e)
        {

        }

        private void NewApps_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void CitProject_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            if (CitProject.SelectedIndex != -1)
            {
                DataTable du = controllerObj.GetUnsoldUnitsOfProject(Convert.ToInt32(CitProject.SelectedValue));
                CitUnit.DataSource = du;
                CitUnit.DisplayMember = "ID";
                CitUnit.ValueMember = "ID";
                CitUnit.Refresh();
            }
        }

        private void ComAdd_Click(object sender, EventArgs e)
        {
            if (ComCompany.SelectedIndex == -1 || ComProject.SelectedIndex == -1 || ComPrice.Value > 0)
                MessageBox.Show("Please fill all required fields first.");
            DataTable C = controllerObj.CountCitApplicationsbyCitizen(Convert.ToInt32(CitCitizen.Text));
            int count = Convert.ToInt32(C.Rows[0][0]);
            if (count >= 3)
            {
                bool Choice;
                using (Force force = new Force())
                {
                    force.ShowDialog(this);
                    Choice = force.choice;
                }
                if (Choice == false)
                    return;
            }
            int done = controllerObj.CreateCitApplication(Convert.ToInt32(CitProject.SelectedValue), Convert.ToInt32(CitUnit.SelectedValue), Convert.ToInt32(CitCitizen.SelectedValue));
            if (done > 0)
            {
                MessageBox.Show("Application added successfully. ");
                ViewApplications f = new ViewApplications(-1);
                f.Show(this.Owner.Owner);
                this.Owner.Close();
                this.Close();
            }
            else
                MessageBox.Show("An error occured. Make sure no application to this project way filled for this company before.");
        }

        private void CitAdd_Click(object sender, EventArgs e)
        {
            if (CitCitizen.SelectedIndex == -1 || CitUnit.SelectedIndex == -1 || CitProject.SelectedIndex == -1)
                MessageBox.Show("Please fill all required fields first."); 
            DataTable C = controllerObj.CountCitApplicationsbyCitizen(Convert.ToInt32(CitCitizen.Text));
            int count = Convert.ToInt32(C.Rows[0][0]);
            if (count >= 3)
            {
                bool Choice; 
                using (Force force = new Force())
                {
                    force.ShowDialog(this);
                    Choice = force.choice;
                }
                if (Choice == false)
                    return; 
            }
            int done = controllerObj.CreateCitApplication(Convert.ToInt32(CitProject.SelectedValue), Convert.ToInt32(CitUnit.SelectedValue), Convert.ToInt32(CitCitizen.SelectedValue));
            if (done > 0)
            {
                MessageBox.Show("Application added successfully..");
                ViewApplications f = new ViewApplications(-1);
                f.Show(this.Owner.Owner);
                this.Owner.Close(); 
                this.Close(); 
            }
            else
                MessageBox.Show("An error occured. Make sure no other application to this unit is filled for this citizen.");
        }
    }
}
