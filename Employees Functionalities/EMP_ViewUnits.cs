using DBapplication;
using Housing_Database_Project.Company_Functionalities;
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
    public partial class EMP_ViewUnits : Form
    {
        private Controller controllerObj;
        private int ID; //Project ID 
        private string Type; //Employee, Project, Company, Admin
        private DataTable dt;
        public EMP_ViewUnits(int id, string type)
        {
            ID = id;
            Type = type;
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void EMP_ViewUnits_Load(object sender, EventArgs e)
        {
            if (Type == "Employee")
            {
                dt = controllerObj.SelectUnitByHEMPID(ID, "All", -1);
                comboBox_Project.Items.Add("All");
                for (int intCount = 0; intCount < dt.Rows.Count; intCount++)
                {
                    var val = dt.Rows[intCount]["Project ID"].ToString();
                    if (!comboBox_Project.Items.Contains(val))
                    {
                        comboBox_Project.Items.Add(val);
                    }
                }
            }
            else
            {
                comboBox_Project.Enabled = false;
                comboBox_Project.Text = Convert.ToString(ID);
                dt = controllerObj.SelectAllUnitsByProject(ID, "All");
            }

            if (Type == "Company" || Type == "Admin") button_AddUnits.Visible = true;
            if (Type == "Admin")
            {
                Delete.Visible = true;
                Status.Visible = true;
                DataTable C = controllerObj.GetAllCitizens();
                Citizen.DataSource = C;
                Citizen.DisplayMember = "NationalID";
                Citizen.ValueMember = "NationalID";
            }

            dataGridView_Units.DataSource = dt;
            dataGridView_Units.Refresh();

           
        }

        private void comboBox_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox_Project.SelectedItem == "All")
            {
                dt = controllerObj.SelectUnitByHEMPID(ID, (string)comboBox_Status.SelectedItem, -1);
            }
            else
            {
                if (Type == "Employee")
                    dt = controllerObj.SelectUnitByHEMPID(ID, (string)comboBox_Status.SelectedItem, Convert.ToInt32(comboBox_Project.SelectedItem));
                else
                    dt = controllerObj.SelectAllUnitsByProject(ID, (string)comboBox_Status.SelectedItem);
            }
            dataGridView_Units.DataSource = dt;
            dataGridView_Units.Refresh();
        }

        private void comboBox_Project_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox_Project.SelectedItem == "All")
            {
                dt = controllerObj.SelectUnitByHEMPID(ID, (string)comboBox_Status.SelectedItem, -1);
            }
            else
            {
                dt = controllerObj.SelectUnitByHEMPID(ID, (string)comboBox_Status.SelectedItem, Convert.ToInt32(comboBox_Project.SelectedItem));
            }
            dataGridView_Units.DataSource = dt;
            dataGridView_Units.Refresh();
        }

        private void button_AddUnits_Click(object sender, EventArgs e)
        {
            new AddUnits(ID).Show();
        }

        private void Status_Click(object sender, EventArgs e)
        {
            if (dataGridView_Units.SelectedRows.Count == 1)
            {
                if(dataGridView_Units.SelectedRows[0].Cells["Status"].Value.ToString() == "Not Sold")
                {
                    label2.Visible = true;
                    Citizen.Visible = true;
                    Confirm.Visible = true;
                    MessageBox.Show("Please select the citizen buying this unit.");
                }
                else
                {
                    int done = controllerObj.UnsellUnit(ID, Convert.ToInt32(dataGridView_Units.SelectedRows[0].Cells["Unit Number"].Value.ToString()));
                    if (done > 0)
                    {
                        MessageBox.Show("Unit status changed to Unsold.");
                        string s = String.IsNullOrWhiteSpace(comboBox_Status.Text) ? "All" : comboBox_Status.Text;
                        dt = controllerObj.SelectAllUnitsByProject(ID, s);
                        dataGridView_Units.DataSource = dt;
                        dataGridView_Units.Refresh();
                    }
                    else
                        MessageBox.Show("Error encoutered. Action aborted");
                }
           
            }
            else
            {
                MessageBox.Show("Please select ONE ENTIRE ROW!");
            }

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Units.SelectedRows.Count == 1)
            {
                int done = controllerObj.DeleteUnit(ID, Convert.ToInt32(dataGridView_Units.SelectedRows[0].Cells["Unit Number"].Value.ToString()));
                if (done > 0)
                {
                    MessageBox.Show("Unit deleted Successfully!");
                    string s = String.IsNullOrWhiteSpace(comboBox_Status.Text) ? "All" : comboBox_Status.Text; 
                    dt = controllerObj.SelectAllUnitsByProject(ID, s);
                    dataGridView_Units.DataSource = dt;
                    dataGridView_Units.Refresh();
                }
                else
                    MessageBox.Show("Error encoutered. Action aborted");
            }
            else
            {
                MessageBox.Show("Please select ONE ENTIRE ROW!");
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (dataGridView_Units.SelectedRows.Count == 1)
            {
                if (Citizen.SelectedIndex != -1)
                {
                    int done = controllerObj.ClaimCitApplication(Convert.ToInt32(Citizen.SelectedValue), ID, Convert.ToInt32(dataGridView_Units.SelectedRows[0].Cells["Unit Number"].Value.ToString()));
                    if (done > 0)
                    {
                        MessageBox.Show("Unit status changed to Sold.");
                        string s = String.IsNullOrWhiteSpace(comboBox_Status.Text) ? "All" : comboBox_Status.Text;
                        dt = controllerObj.SelectAllUnitsByProject(ID, s);
                        dataGridView_Units.DataSource = dt;
                        dataGridView_Units.Refresh();
                    }
                    else
                        MessageBox.Show("Error encoutered. Action aborted");
                }
                else
                    MessageBox.Show("Please select a valid citizen ID");

            }
            else
            {
                MessageBox.Show("Please select ONE ENTIRE ROW!");
            }
        }
    }


}
