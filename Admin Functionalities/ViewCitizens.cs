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
    public partial class ViewCitizens : Form
    {
        private Controller controllerObj = new Controller();
        public ViewCitizens()
        {
            InitializeComponent();
            DataTable C = controllerObj.GetAllCitizens();
            dataGridView1.DataSource = C;
            CitizenID.Items.Add("All");
            for (int intCount = 0; intCount < C.Rows.Count; intCount++)
            {
                var val = C.Rows[intCount]["NationalID"].ToString();
                CitizenID.Items.Add(val);
            }
            CitizenID.SelectedIndex = 0; 
        }

        private void ViewCitizens_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            new Housing_Database_Project.Sign_Up_Forms.SignUpCitizen(true).Show(this); 
        }

        private void RefreshGrid()
        {
            DataTable C;

            if (CitizenID.SelectedIndex == 0)
            {
                C = controllerObj.GetAllCitizens();
                dataGridView1.DataSource = C;
            }
            else
            {
                C = controllerObj.SelectCitizenByID(Convert.ToInt32(CitizenID.SelectedItem));
                dataGridView1.DataSource = C;
            }
        }

        private void CitizenID_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();             
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                MessageBox.Show("Please select one row to perform action on.");
            else
            {
                int done = controllerObj.DeleteCitizen(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["NationalID"].Value));
                if (done > 0)
                {
                    MessageBox.Show("Citizen deleted successfully.");
                    RefreshGrid();
                    DataTable C = controllerObj.GetAllCitizens();
                    dataGridView1.DataSource = C;
                    CitizenID.Items.Clear();
                    CitizenID.Items.Add("All");
                    for (int intCount = 0; intCount < C.Rows.Count; intCount++)
                    {
                        var val = C.Rows[intCount]["NationalID"].ToString();
                        CitizenID.Items.Add(val);
                    }

                }
                else
                    MessageBox.Show("An error occured.");
            }
        }

        private void Info_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                MessageBox.Show("Please select one row to perform action on.");
            else
            {
                new Housing_Database_Project.Employees_Functionalities.CitizenInfo(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["NationalID"].Value), true).Show(this);
                this.Hide(); 
            
            }

        }

        private void Dependents_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                MessageBox.Show("Please select one row to perform action on.");
            else
            {
                new CitizenDependents("Admin", Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["NationalID"].Value)).Show(this);
                this.Hide(); 
            }
        }

        private void Applications_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                MessageBox.Show("Please select one row to perform action on.");
            else
            {
                new CitizenApplications(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["NationalID"].Value)).Show(this);
                this.Hide(); 
            }
        }

        private void Payments_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                MessageBox.Show("Please select one row to perform action on.");
            else
            {
                new CitizenPayments(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["NationalID"].Value)).Show(this);
                this.Hide(); 
            }
        }

        private void ViewCitizens_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
    }
}
