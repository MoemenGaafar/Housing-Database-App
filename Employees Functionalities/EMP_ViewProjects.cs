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
        }

        private void PEMP_ViewProjects_Load(object sender, EventArgs e)
        {
            if (Type == "Projects")
               dt = controllerObj.SelectProjectByPEMPID(ID,"All","All");
            else if (Type == "Housing")
               dt = controllerObj.SelectProjectByHEMPID(ID, "All", "All");
            else
                dt = controllerObj.SelectProjectByMEMPID(ID, "All", "All");


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
            comboBox_Status.Text = "";
            comboBox_City.Text = "";
        }

        private void comboBox_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Type == "Projects")
                dt = controllerObj.SelectProjectByPEMPID(ID, (string)comboBox_Status.SelectedItem, (string)comboBox_City.SelectedItem);
            else if (Type == "Housing")
                dt = controllerObj.SelectProjectByHEMPID(ID, (string)comboBox_Status.SelectedItem, (string)comboBox_City.SelectedItem);
            else
                dt = controllerObj.SelectProjectByMEMPID(ID, (string)comboBox_Status.SelectedItem, (string)comboBox_City.SelectedItem);

            dataGridView_Projects.DataSource = dt;
            dataGridView_Projects.Refresh();
        }

        private void comboBox_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Type == "Projects")
                dt = controllerObj.SelectProjectByPEMPID(ID, (string)comboBox_Status.SelectedItem, (string)comboBox_City.SelectedItem);
            else if (Type == "Housing")
                dt = controllerObj.SelectProjectByHEMPID(ID, (string)comboBox_Status.SelectedItem, (string)comboBox_City.SelectedItem);
            else
                dt = controllerObj.SelectProjectByMEMPID(ID, (string)comboBox_Status.SelectedItem, (string)comboBox_City.SelectedItem);

            dataGridView_Projects.DataSource = dt;
            dataGridView_Projects.Refresh();
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
    }
}
