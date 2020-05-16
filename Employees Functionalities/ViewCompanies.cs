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
    public partial class ViewCompanies : Form
    {
        private int ID; //Manager ID, -1 if Admin
        private Controller controllerObj;
        private DataTable dt;
        public ViewCompanies(int id)
        {
            ID = id;
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void ViewCompanies_Load(object sender, EventArgs e)
        {
            if (ID == -1) //Admin
            {
                dt = controllerObj.GetAllCompanies();
                Info.Visible = true;
                Delete.Visible = true;
                Add.Visible = true; 
            }
            else
            {
                dt = controllerObj.SelectCompaniesByMEMPID(ID);
                label_Title.Text = "Affiliated Companies";
            }

            dataGridView_Companies.DataSource = dt;
            dataGridView_Companies.Refresh();
            CompanyName.DataSource = dt;
            CompanyName.DisplayMember = "Company";
            CompanyName.ValueMember = "Company ID";
        }

        private void RefreshGrid()
        {
            dt = controllerObj.GetAllCompanies();
            dataGridView_Companies.DataSource = dt;
            CompanyName.DataSource = dt;
            CompanyName.DisplayMember = "Company";
            CompanyName.ValueMember = "Company ID";
        }

        private void listBox_Projects_DoubleClick(object sender, EventArgs e)
        {
            string Type;
            if (ID == -1) Type = "Admin";
            else Type = "Manager";
            new ProjectInfo(Convert.ToInt32(listBox_Projects.SelectedValue.ToString()), dt.Rows[listBox_Projects.SelectedIndex]["Project Status"].ToString()).Show(this);
        }


        private void button_ViewProjs_Click(object sender, EventArgs e)
        {
            if (dataGridView_Companies.SelectedRows.Count == 1)
            {
                if (ID == -1) //Admin
                    dt = controllerObj.SelectProjectByCompany(Convert.ToInt32(dataGridView_Companies.SelectedRows[0].Cells["Company ID"].Value));
                else
                    dt = controllerObj.SelectProjectByCompanyMEMPID(ID, Convert.ToInt32(dataGridView_Companies.SelectedRows[0].Cells["Company ID"].Value));

                if (dt is null)
                {
                    label3.Visible = false;
                    listBox_Projects.DataSource = null;
                    listBox_Projects.Items.Clear();
                    listBox_Projects.Items.Add("No Assigned Projects");
                }
                else
                {
                    label3.Visible = true;
                    listBox_Projects.DataSource = dt;
                    listBox_Projects.ValueMember = "ID";
                    listBox_Projects.Refresh();
                }
            }
            else
            {
                MessageBox.Show("Please select ONE ENTIRE ROW!");
            }
        }

        private void ViewCompanies_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            new Housing_Database_Project.Sign_Up_Forms.SignUpCompany(true).Show(this);
            this.Hide();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Companies.SelectedRows.Count != 1)
                MessageBox.Show("Please select one row to perform action on.");
            else
            {
                int done = controllerObj.DeleteCompany(Convert.ToInt32(dataGridView_Companies.SelectedRows[0].Cells["Company ID"].Value));
                if (done > 0)
                {
                    MessageBox.Show("Company deleted successfully.");
                    RefreshGrid();
                }
                else
                    MessageBox.Show("An error occured.");
            }
        }

        private void Rate_Click(object sender, EventArgs e)
        {
            if (dataGridView_Companies.SelectedRows.Count != 1)
                MessageBox.Show("Please select one row to perform action on.");
            else
            {
                if (String.IsNullOrWhiteSpace(Rating.Text))
                    MessageBox.Show("Please enter a valid rating to give the company.");
                else
                {
                    int done = controllerObj.UpdateCompanyRating(Convert.ToInt32(dataGridView_Companies.SelectedRows[0].Cells["Company ID"].Value), Convert.ToInt32(Rating.Value));
                    if (done > 0)
                    {
                        MessageBox.Show("Company rating changed successfully.");
                        if (ID == -1)
                            RefreshGrid();
                        else
                        {
                            dt = controllerObj.SelectCompaniesByMEMPID(ID);
                            dataGridView_Companies.DataSource = dt;
                            dataGridView_Companies.Refresh();
                            CompanyName.DataSource = dt;
                            CompanyName.DisplayMember = "Company";
                            CompanyName.ValueMember = "Company ID";
                        }
                    }
                    else
                        MessageBox.Show("An error occured.");
                }
            }
        }

        private void Info_Click(object sender, EventArgs e)
        {
            if (dataGridView_Companies.SelectedRows.Count != 1)
                MessageBox.Show("Please select one row to perform action on.");
            else
            {
                new Housing_Database_Project.Sign_Up_Forms.SignUpCompany(Convert.ToInt32(dataGridView_Companies.SelectedRows[0].Cells["Company ID"].Value)).Show(this);
                this.Hide();
            }
        }
    }
}
