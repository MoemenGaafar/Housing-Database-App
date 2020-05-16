using DBapplication;
using Housing_Database_Project.Employees_Functionalities;
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
    public partial class ViewApplications : Form
    {
        private Controller controllerObj;
        private int ID; // -1 if admin, EID if employee
        private DataTable dt;
        public ViewApplications(int id)
        {
            ID = id;
            controllerObj = new Controller();
            InitializeComponent();
            if (ID == -1)
            {
                button_ViewCit.Hide();
                label6.Visible = true;
                ChangePrice.Visible = true;
                ConfirmPrice.Visible = true;
            }
            else
            {
                Delete.Hide();
                Add.Hide();
                ConfirmStatus.Hide();
                label5.Hide();
                ChangeStatus.Hide();
            }
        }

        private void ViewApplications_Load(object sender, EventArgs e)
        {
            dt = controllerObj.SelectAppByMEMPID(ID, "All", -1, "Company"); //A project ID of -1 refers to ALL IDs
            dataGridView_Apps.DataSource = dt;
            dataGridView_Apps.Refresh();
            comboBox_ProjectID.Items.Add("All");
            for (int intCount = 0; intCount < dt.Rows.Count; intCount++)
            {
                var val = dt.Rows[intCount]["Project ID"].ToString();
                if (!comboBox_ProjectID.Items.Contains(val))
                {
                    comboBox_ProjectID.Items.Add(val);
                }
            }
            comboBox_From.SelectedIndex = 0;
            comboBox_ProjectID.Text = "All";
            comboBox_Status.Text = "All";
        }

        private void comboBox_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox_ProjectID.SelectedItem == "All")
            {
                dt = controllerObj.SelectAppByMEMPID(ID, (string)comboBox_Status.SelectedItem, -1, (string)comboBox_From.SelectedItem);
            }
            else
            {
                dt = controllerObj.SelectAppByMEMPID(ID, (string)comboBox_Status.SelectedItem, Convert.ToInt32(comboBox_ProjectID.SelectedItem), (string)comboBox_From.SelectedItem);
            }
            dataGridView_Apps.DataSource = dt;
            dataGridView_Apps.Refresh();
        }

        private void comboBox_ProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox_ProjectID.SelectedItem == "All")
            {
                dt = controllerObj.SelectAppByMEMPID(ID, (string)comboBox_Status.SelectedItem, -1, (string)comboBox_From.SelectedItem);
            }
            else
            {
                dt = controllerObj.SelectAppByMEMPID(ID, (string)comboBox_Status.SelectedItem, Convert.ToInt32(comboBox_ProjectID.SelectedItem), (string)comboBox_From.SelectedItem);
            }
            dataGridView_Apps.DataSource = dt;
            dataGridView_Apps.Refresh();
        }

        private void comboBox_From_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Status.SelectedIndex = 0;
            comboBox_ProjectID.SelectedIndex = 0;
            if (comboBox_From.SelectedIndex == 1)
            {
                button_ViewCit.Enabled = true;
                label6.Visible = false;
                ChangePrice.Visible = false;
                ConfirmPrice.Visible = false;
            }
            else
            {
                if (ID == -1)
                {
                    label6.Visible = true;
                    ChangePrice.Visible = true;
                    ConfirmPrice.Visible = true;
                }
            }

            if ((string)comboBox_ProjectID.SelectedItem == "All")
            {
                dt = controllerObj.SelectAppByMEMPID(ID, (string)comboBox_Status.SelectedItem, -1, (string)comboBox_From.SelectedItem);
            }
            else
            {
                dt = controllerObj.SelectAppByMEMPID(ID, (string)comboBox_Status.SelectedItem, Convert.ToInt32(comboBox_ProjectID.SelectedItem), (string)comboBox_From.SelectedItem);
            }
            comboBox_ProjectID.Items.Clear();
            comboBox_ProjectID.Items.Add("All");
            for (int intCount = 0; intCount < dt.Rows.Count; intCount++)
            {
                var val = dt.Rows[intCount]["Project ID"].ToString();
                if (!comboBox_ProjectID.Items.Contains(val))
                {
                    comboBox_ProjectID.Items.Add(val);
                }
            }
            dataGridView_Apps.DataSource = dt;
            dataGridView_Apps.Refresh();
        }

        private void button_ViewCit_Click(object sender, EventArgs e)
        {
            if (dataGridView_Apps.SelectedRows.Count == 1)
            {
                new CitizenInfo(Convert.ToInt32(dataGridView_Apps.SelectedRows[0].Cells["Citizen ID"].Value)).Show(this);
            }
            else
            {
                MessageBox.Show("Please select ONE ENTIRE ROW!");
            }
        }

        private void ViewApplications_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            new NewApps().Show(this);
            this.Hide(); 
        }

        private void ConfirmStatus_Click(object sender, EventArgs e)
        {
            if (ChangeStatus.SelectedIndex == -1)
                MessageBox.Show("Please select a valid new status");
            else if (dataGridView_Apps.SelectedRows.Count != 1)
                MessageBox.Show("Please select one row to perform action on.");
            else
            {
                int p = -1;
                if (comboBox_ProjectID.Text != "All")
                    p = Convert.ToInt32(comboBox_ProjectID.Text);

                char status = 'W';
                if (ChangeStatus.SelectedIndex == 0)
                    status = 'W'; 
                else if (ChangeStatus.SelectedIndex == 1)
                    status = 'A';
                else if (ChangeStatus.SelectedIndex == 2)
                    status = 'R';
                else if (ChangeStatus.SelectedIndex == 3)
                    status = 'D';

                
                if (comboBox_From.SelectedIndex == 1)
                {
                    int done = controllerObj.ChangeCitApplicationStatus(Convert.ToInt32(dataGridView_Apps.SelectedRows[0].Cells["Project ID"].Value), Convert.ToInt32(dataGridView_Apps.SelectedRows[0].Cells["Unit Number"].Value), Convert.ToInt32(dataGridView_Apps.SelectedRows[0].Cells["Citizen National ID"].Value), status);
                    if (done > 0)
                    {
                        MessageBox.Show("Status Changes successfully.");
                        dt = controllerObj.SelectAppByMEMPID(ID, comboBox_Status.Text, p, "Citizen"); 
                        dataGridView_Apps.DataSource = dt;
                        dataGridView_Apps.Refresh();
                    }
                    else
                        MessageBox.Show("An error occured.");
                }
                else if (comboBox_From.SelectedIndex == 0)
                {
                    int done = controllerObj.ChangeComApplicationStatus(Convert.ToInt32(dataGridView_Apps.SelectedRows[0].Cells["Project ID"].Value), Convert.ToString(dataGridView_Apps.SelectedRows[0].Cells["Company Name"].Value), status);
                    if (done > 0)
                    {
                        MessageBox.Show("Status Changes successfully.");
                        dt = controllerObj.SelectAppByMEMPID(ID, comboBox_Status.Text, p, "Company"); 
                        dataGridView_Apps.DataSource = dt;
                        dataGridView_Apps.Refresh();
                    }
                    else
                        MessageBox.Show("An error occured.");
                }
            }


        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Apps.SelectedRows.Count != 1)
                MessageBox.Show("Please select one row to perform action on.");
            else
            {
                int p = -1;
                if (comboBox_ProjectID.Text != "All")
                    p = Convert.ToInt32(comboBox_ProjectID.Text); 

                if (comboBox_From.SelectedIndex == 1)
                {
                    int done = controllerObj.DeleteCitApplication(Convert.ToInt32(dataGridView_Apps.SelectedRows[0].Cells["Citizen National ID"].Value), Convert.ToInt32(dataGridView_Apps.SelectedRows[0].Cells["Project ID"].Value), Convert.ToInt32(dataGridView_Apps.SelectedRows[0].Cells["Unit Number"].Value));
                    if (done > 0)
                    {
                        MessageBox.Show("Application deleted successfully.");
                        dt = controllerObj.SelectAppByMEMPID(ID, comboBox_Status.Text, p, "Citizen"); 
                        dataGridView_Apps.DataSource = dt;
                        dataGridView_Apps.Refresh();
                    }
                    else
                        MessageBox.Show("An error occured.");
                }
                else if (comboBox_From.SelectedIndex == 0)
                {
                    int done = controllerObj.DeleteComApplication(Convert.ToInt32(dataGridView_Apps.SelectedRows[0].Cells["Project ID"].Value), Convert.ToString(dataGridView_Apps.SelectedRows[0].Cells["Company Name"].Value));
                    if (done > 0)
                    {
                        MessageBox.Show("Application deleted successfully.");
                        dt = controllerObj.SelectAppByMEMPID(ID, comboBox_Status.Text, p, "Company"); 
                        dataGridView_Apps.DataSource = dt;
                        dataGridView_Apps.Refresh();
                    }
                    else
                        MessageBox.Show("An error occured.");
                }
            }
        }

        private void ConfirmPrice_Click(object sender, EventArgs e)
        {
            if (ChangePrice.Value <= 0)
                MessageBox.Show("Please select a valid bidding price");
            else
            {
                if (dataGridView_Apps.SelectedRows.Count != 1)
                    MessageBox.Show("Please select one row to perform action on.");
                else
                {
                    int p = -1;
                    if (comboBox_ProjectID.Text != "All")
                        p = Convert.ToInt32(comboBox_ProjectID.Text);
                    int done = controllerObj.ChangeBiddingPrice(Convert.ToInt32(dataGridView_Apps.SelectedRows[0].Cells["Project ID"].Value), Convert.ToString(dataGridView_Apps.SelectedRows[0].Cells["Company Name"].Value), Convert.ToInt32(ChangePrice.Value));
                    if (done > 0)
                    {
                        MessageBox.Show("Bidding Price Changed Successfully.");
                        dt = controllerObj.SelectAppByMEMPID(ID, comboBox_Status.Text, p, "Company");
                        dataGridView_Apps.DataSource = dt;
                        dataGridView_Apps.Refresh();
                    }
                    else
                        MessageBox.Show("An error occured.");




                }

            }
        }

       
    }
}
