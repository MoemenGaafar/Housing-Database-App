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
    public partial class EMP_ViewUnits : Form
    {
        private Controller controllerObj;
        private int ID;
        private DataTable dt;
        public EMP_ViewUnits(int id)
        {
            ID = id;
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void EMP_ViewUnits_Load(object sender, EventArgs e)
        {
            dt = controllerObj.SelectUnitByHEMPID(ID, "All", -1);

            dataGridView_Units.DataSource = dt;
            dataGridView_Units.Refresh();

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

        private void comboBox_Status_SelectedIndexChanged(object sender, EventArgs e)
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
    }


}
