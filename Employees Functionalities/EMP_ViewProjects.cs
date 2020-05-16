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
    public partial class EMP_ViewProjects : Form
    {
        private Controller controllerObj;
        private int ID;
        private string Type;
        private DataTable dt;
        public EMP_ViewProjects(int id, string type)
        {
            ID = id;
            Type = type;
            controllerObj = new Controller();
            InitializeComponent();
            if (Type != "Admin")
            {
                Add.Hide();
                Delete.Hide();
                label2.Hide();
                label5.Hide();
                StatusText.Hide();
                Confirm.Hide();
                newStatus.Hide();
                Company.Hide(); 
            }
            else
            {
                label5.Hide();
                Company.Hide();
                DataTable C = controllerObj.SelectAllCompanies();
                Company.DataSource = C;
                Company.DisplayMember = "Name";
                Company.ValueMember = "CID";
                button_ViewProj.Text = "Edit Selected"; 
            }
        }

        private void PEMP_ViewProjects_Load(object sender, EventArgs e)
        {
            if (Type == "Projects")
                dt = controllerObj.SelectProjectByPEMPID(ID, "All", "All");
            else if (Type == "Housing")
                dt = controllerObj.SelectProjectByHEMPID(ID, "All", "All");
            else if (Type == "Manager")
                dt = controllerObj.SelectProjectByMEMPID(ID, "All", "All");
            else if (Type == "Company")
                dt = controllerObj.SelectProjectByCompanyID(ID, "All", "All");
            else if (Type == "Admin")
            {
                dt = controllerObj.SelectProjectAdmin("All", "All");
                label1.Text = "Projects"; 
            }




            dataGridView_Projects.DataSource = dt;
            dataGridView_Projects.Refresh();

            comboBox_City.Items.Add("All");
            for (int intCount = 0; intCount < dt.Rows.Count; intCount++)
            {
                var val = dt.Rows[intCount]["City"].ToString();
                if (!comboBox_City.Items.Contains(val))
                {
                    comboBox_City.Items.Add(val);
                }
            }

            if (Type == "Company") comboBox_Status.Items.Remove("Posted");

            comboBox_Status.Text = "";
            comboBox_City.Text = "";
        }

        private void RefreshGrid()
        {
            string c, s;
            if (comboBox_Status.SelectedIndex != -1 && comboBox_Status.SelectedIndex != 0)
                s = (string)comboBox_Status.SelectedItem;
            else
                s = "All";
            if (comboBox_City.SelectedIndex != -1 && comboBox_City.SelectedIndex != 0)
                c = (string)comboBox_City.SelectedItem;
            else
                c = "All";

            DataTable R = controllerObj.SelectProjectAdmin(s, c);
            dataGridView_Projects.DataSource = R;
            dataGridView_Projects.Refresh();

        }

        private void comboBox_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_City.SelectedIndex != -1)
            {
                if (Type == "Projects")
                    dt = controllerObj.SelectProjectByPEMPID(ID, (string)comboBox_Status.SelectedItem, (string)comboBox_City.SelectedItem);
                else if (Type == "Housing")
                    dt = controllerObj.SelectProjectByHEMPID(ID, (string)comboBox_Status.SelectedItem, (string)comboBox_City.SelectedItem);
                else if (Type == "Manager")
                    dt = controllerObj.SelectProjectByMEMPID(ID, (string)comboBox_Status.SelectedItem, (string)comboBox_City.SelectedItem);
                else if (Type == "Company")
                    dt = controllerObj.SelectProjectByCompanyID(ID, (string)comboBox_Status.SelectedItem, (string)comboBox_City.SelectedItem);
                else if (Type == "Admin")
                    dt = controllerObj.SelectProjectAdmin((string)comboBox_Status.SelectedItem, (string)comboBox_City.SelectedItem);

                dataGridView_Projects.DataSource = dt;
                dataGridView_Projects.Refresh();
            }
        }

        

        private void comboBox_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Status.SelectedIndex != -1)
            {
                if (Type == "Projects")
                    dt = controllerObj.SelectProjectByPEMPID(ID, (string)comboBox_Status.SelectedItem, (string)comboBox_City.SelectedItem);
                else if (Type == "Housing")
                    dt = controllerObj.SelectProjectByHEMPID(ID, (string)comboBox_Status.SelectedItem, (string)comboBox_City.SelectedItem);
                else if (Type == "Manager")
                    dt = controllerObj.SelectProjectByMEMPID(ID, (string)comboBox_Status.SelectedItem, (string)comboBox_City.SelectedItem);
                else if (Type == "Company")
                    dt = controllerObj.SelectProjectByCompanyID(ID, (string)comboBox_Status.SelectedItem, (string)comboBox_City.SelectedItem);
                else if (Type == "Admin")
                    dt = controllerObj.SelectProjectAdmin((string)comboBox_Status.SelectedItem, (string)comboBox_City.SelectedItem);

                dataGridView_Projects.DataSource = dt;
                dataGridView_Projects.Refresh();
            }
        }

        private void PEMP_ViewProjects_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void button_ViewProj_Click(object sender, EventArgs e)
        {
            if (dataGridView_Projects.SelectedRows.Count == 1)
            {
                new ProjectInfo(Convert.ToInt32(dataGridView_Projects.SelectedRows[0].Cells["Project ID"].Value.ToString()), Type).Show(this);
            }
            else
            {
                MessageBox.Show("Please select ONE ENTIRE ROW!");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Projects.SelectedRows.Count == 1)
            {
                int done = controllerObj.DeleteProject(Convert.ToInt32(dataGridView_Projects.SelectedRows[0].Cells["Project ID"].Value.ToString()));
                if (done > 0)
                {
                    MessageBox.Show("Project deleted Successfully!");
                    RefreshGrid();
                }
                else
                    MessageBox.Show("Error encoutered. Action aborted");
            }
            else
            {
                MessageBox.Show("Please select ONE ENTIRE ROW!");
            }

        }

        private void Add_Click(object sender, EventArgs e)
        {
            new NewProject(-1).Show(this);
            this.Hide(); 
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (dataGridView_Projects.SelectedRows.Count == 1)
            {
                int found; 
                if (newStatus.Text == "Started" || newStatus.Text == "Launched" || newStatus.Text == "All Units Sold" )
                {
                    if (Company.SelectedIndex == -1)
                    {
                        MessageBox.Show("Please select a company to assign this project to before setting its status to staerted");
                        return; 
                    }
                    found = controllerObj.ChangeProjectStatus(Convert.ToInt32(dataGridView_Projects.SelectedRows[0].Cells["Project ID"].Value.ToString()), (string)newStatus.Text);
                    int found2 = controllerObj.AssignCompany(Convert.ToInt32(dataGridView_Projects.SelectedRows[0].Cells["Project ID"].Value.ToString()), Convert.ToInt32(Company.SelectedValue)); 
                    if (found > 0 && found2 > 0)
                    {
                        MessageBox.Show("Status changed Successfully! Starting and/or launching date were set to today. You can Alter them through the Edit button.");
                        RefreshGrid(); 
                    }
                    else
                        MessageBox.Show("Error encoutered. Action aborted");
                    label5.Hide();
                    Company.Hide();

                }
                else
                {
                    found = controllerObj.ChangeProjectStatus(Convert.ToInt32(dataGridView_Projects.SelectedRows[0].Cells["Project ID"].Value.ToString()), (string)newStatus.Text);
                    if (found > 0)
                    {
                        MessageBox.Show("Status changed Successfully!");
                        RefreshGrid(); 
                    }
                    else
                        MessageBox.Show("Error encoutered. Action aborted");
                }
            }
            else
            {
                MessageBox.Show("Please select one entire row to perform this action on!");
            }
        }

        private void newStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (newStatus.Text == "Started" || newStatus.Text == "Launched" || newStatus.Text == "All Units Sold")
            {
                label5.Show();
                Company.Show();
                MessageBox.Show("Select a company to assign this project to."); 
            }

        }
    }
}
