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
        private int ID;
        private DataTable dt;
        public ViewApplications(int id)
        {
            ID = id;
            controllerObj = new Controller();
            InitializeComponent();
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
            if (comboBox_From.SelectedIndex == 1) button_ViewCit.Enabled = true;

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
    }
}
