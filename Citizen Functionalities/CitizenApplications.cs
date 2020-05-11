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
    public partial class CitizenApplications : Form
    {
        private Controller controllerObj = new Controller();
        private int ID; 
        public CitizenApplications(int i)
        {
            ID = i; 
            InitializeComponent();
            DataTable A1 = controllerObj.GetCitApplicationsByCitizen(ID);
            DataTable A2 = controllerObj.GetAcceptedCitApplicationsByCitizen(ID);

            dataGridView1.DataSource = A1;
            dataGridView2.DataSource = A2;

            ProjectDelete.DataSource = A1;
            UnitDelete.DataSource = A1;
            ProjectAccept.DataSource = A2;
            UnitAccept.DataSource = A2;

            ProjectDelete.ValueMember = "ProjectID";
            UnitDelete.ValueMember = "UnitID"; 
            ProjectAccept.ValueMember = "ProjectID";
            UnitAccept.ValueMember = "UnitID";

        }

        private void CitizenApplications_Load(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (ProjectDelete.SelectedIndex != -1 && UnitDelete.SelectedIndex != -1)
            {
                int found = controllerObj.DeleteCitApplication(ID, Convert.ToInt32(ProjectDelete.SelectedValue), Convert.ToInt32(UnitDelete.SelectedValue));
                if (found != 0)
                {
                    MessageBox.Show("Application deleted successfully");

                    DataTable A1 = controllerObj.GetCitApplicationsByCitizen(ID);

                    dataGridView1.DataSource = A1;

                    ProjectDelete.DataSource = A1;
                    UnitDelete.DataSource = A1;

                    ProjectDelete.ValueMember = "ProjectID";
                    UnitDelete.ValueMember = "UnitID";
                }
                else
                    MessageBox.Show("Error Occurred! Action aborted."); 
            }
        }

        private void Claim_Click(object sender, EventArgs e)
        {
            if (ProjectAccept.SelectedIndex != -1 && UnitAccept.SelectedIndex != -1)
            {
                int found = controllerObj.ClaimCitApplication(ID, Convert.ToInt32(ProjectAccept.SelectedValue), Convert.ToInt32(UnitAccept.SelectedValue));
                if (found != 0)
                {
                    MessageBox.Show("Unit claimed successfully. Click Manage Payments to review your due payments.");

                    DataTable A2 = controllerObj.GetAcceptedCitApplicationsByCitizen(ID);

                    dataGridView2.DataSource = A2;

                    ProjectAccept.DataSource = A2;
                    UnitAccept.DataSource = A2;

                    ProjectAccept.ValueMember = "ProjectID";
                    UnitAccept.ValueMember = "UnitID";

                }
                else
                    MessageBox.Show("Error Occurred! Action aborted.");
            }
        }

        private void GiveUp_Click(object sender, EventArgs e)
        {
            if (ProjectAccept.SelectedIndex != -1 && UnitAccept.SelectedIndex != -1)
            {
                int found = controllerObj.GiveUpCitApplication(ID, Convert.ToInt32(ProjectAccept.SelectedValue), Convert.ToInt32(UnitAccept.SelectedValue));
                if (found != 0)
                {
                    MessageBox.Show("Unit removed successfully. Unit's application status will become 'Rejected'");

                    DataTable A2 = controllerObj.GetAcceptedCitApplicationsByCitizen(ID);

                    dataGridView2.DataSource = A2;

                    ProjectAccept.DataSource = A2;
                    UnitAccept.DataSource = A2;

                    ProjectAccept.ValueMember = "ProjectID";
                    UnitAccept.ValueMember = "UnitID";
                }
                else
                    MessageBox.Show("Error Occurred! Action aborted.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CitizenPayments(ID).Show(this);
            this.Hide(); 
        }

        private void CitizenApplications_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
    }
}
