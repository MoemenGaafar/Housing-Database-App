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
    public partial class PEMP_ViewProjects : Form
    {
        private Controller controllerObj;
        private int ID;
        private DataTable dt;
        public PEMP_ViewProjects(int id)
        {
            ID = id;
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void PEMP_ViewProjects_Load(object sender, EventArgs e)
        {
            dt = controllerObj.SelectProjectByPEMPID(ID,"All","All");

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
            comboBox_Status.SelectedIndex = 0;
            comboBox_City.SelectedIndex = 0;
        }

        private void comboBox_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = controllerObj.SelectProjectByPEMPID(ID, (string)comboBox_Status.SelectedItem, (string)comboBox_City.SelectedItem);
            dataGridView_Projects.DataSource = dt;
            dataGridView_Projects.Refresh();
        }

        private void comboBox_City_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt = controllerObj.SelectProjectByPEMPID(ID, (string)comboBox_Status.SelectedItem, (string)comboBox_City.SelectedItem);
            dataGridView_Projects.DataSource = dt;
            dataGridView_Projects.Refresh();
        }
    }
}
