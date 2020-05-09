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
    public partial class PEMP_ViewApps : Form
    {
        private Controller controllerObj;
        private int ID;
        private DataTable dt;
        public PEMP_ViewApps(int id)
        {
            ID = id;
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void PEMP_ViewApps_Load(object sender, EventArgs e)
        {
            dt = controllerObj.SelectComAppByPEMPID(ID, "All", -1); //A project ID of -1 refers to ALL IDs
            comboBox_ProjectID.Items.Add("All");
            for (int intCount = 0; intCount < dt.Rows.Count; intCount++)
            {
                var val = dt.Rows[intCount]["Project ID"].ToString();
                if (!comboBox_ProjectID.Items.Contains(val))
                {
                    comboBox_ProjectID.Items.Add(val);
                }
            }
            comboBox_ProjectID.SelectedIndex = 0;
            comboBox_Status.SelectedIndex = 0;
            dataGridView_Apps.DataSource = dt;
            dataGridView_Apps.Refresh();
        }

        private void comboBox_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox_ProjectID.SelectedItem == "All")
            {
                dt = controllerObj.SelectComAppByPEMPID(ID, (string)comboBox_Status.SelectedItem, -1);
            }
            else
            {
                dt = controllerObj.SelectComAppByPEMPID(ID, (string)comboBox_Status.SelectedItem, Convert.ToInt32(comboBox_ProjectID.SelectedItem));
            }
            dataGridView_Apps.DataSource = dt;
            dataGridView_Apps.Refresh();
        }

        private void comboBox_ProjectID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox_ProjectID.SelectedItem == "All")
            {
                dt = controllerObj.SelectComAppByPEMPID(ID, (string)comboBox_Status.SelectedItem, -1);
            }
            else
            {
                dt = controllerObj.SelectComAppByPEMPID(ID, (string)comboBox_Status.SelectedItem, Convert.ToInt32(comboBox_ProjectID.SelectedItem));
            }
            dataGridView_Apps.DataSource = dt;
            dataGridView_Apps.Refresh();
        }

        private void button_Accept_Click(object sender, EventArgs e)
        {
            if (dataGridView_Apps.SelectedRows.Count > 1) MessageBox.Show("Please select only one row at a time!");
            else if (Convert.ToChar(dataGridView_Apps.SelectedRows[0].Cells["Application Status"].Value) != 'W')
                MessageBox.Show("The selected transaction must be WAITING!");
            else
            {
                int r = controllerObj.ChangeComApplicationStatus(Convert.ToInt32(dataGridView_Apps.SelectedRows[0].Cells["Project ID"].Value),
                    dataGridView_Apps.SelectedRows[0].Cells["Company"].Value.ToString(), 'A');
                if (r > 0) MessageBox.Show("Application Accepted!");
                else MessageBox.Show("Error Accepting Application..");
                if ((string)comboBox_ProjectID.SelectedItem == "All")
                    dt = controllerObj.SelectComAppByPEMPID(ID, (string)comboBox_Status.SelectedItem, -1);
                else
                    dt = controllerObj.SelectComAppByPEMPID(ID, (string)comboBox_Status.SelectedItem, Convert.ToInt32(comboBox_ProjectID.SelectedItem));
                dataGridView_Apps.DataSource = dt;
                dataGridView_Apps.Refresh();
            }
        }

        private void button_Reject_Click(object sender, EventArgs e)
        {
            if (dataGridView_Apps.SelectedRows.Count > 1) MessageBox.Show("Please select only one row at a time!");
            else if (Convert.ToChar(dataGridView_Apps.SelectedRows[0].Cells["Application Status"].Value) != 'W')
                MessageBox.Show("The selected transaction must be WAITING!");
            else
            {
                int r = controllerObj.ChangeComApplicationStatus(Convert.ToInt32(dataGridView_Apps.SelectedRows[0].Cells["Project ID"].Value),
                    dataGridView_Apps.SelectedRows[0].Cells["Company"].Value.ToString(), 'R');
                if (r > 0) MessageBox.Show("Application Rejected!");
                else MessageBox.Show("Error Rejecting Application..");
                if ((string)comboBox_ProjectID.SelectedItem == "All")
                    dt = controllerObj.SelectComAppByPEMPID(ID, (string)comboBox_Status.SelectedItem, -1);
                else
                    dt = controllerObj.SelectComAppByPEMPID(ID, (string)comboBox_Status.SelectedItem, Convert.ToInt32(comboBox_ProjectID.SelectedItem));
                dataGridView_Apps.DataSource = dt;
                dataGridView_Apps.Refresh();
            }
        }

        private void PEMP_ViewApps_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
    }
}
