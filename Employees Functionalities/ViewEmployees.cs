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
    public partial class ViewEmployees : Form
    {
        private int ID;
        private Controller controllerObj;
        private DataTable dt;
        public ViewEmployees(int id)
        {
            ID = id;
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void ViewEmployees_Load(object sender, EventArgs e)
        {
            if (ID == -1) //Admin
                dt = controllerObj.GetAllEmployees();
            else
            {
                label_Title.Text = "Your Employees";
                dt = controllerObj.SelectEmployeesByMEMPID(ID);
            }
            dataGridView_Employees.DataSource = dt;
            dataGridView_Employees.Refresh();
        }

        private void button_ViewProjs_Click(object sender, EventArgs e)
        {
            if (dataGridView_Employees.SelectedRows.Count == 1)
            {
                if (ID == -1) //Admin
                    dt = controllerObj.SelectProjectByEmployee(Convert.ToInt32(dataGridView_Employees.SelectedRows[0].Cells["National ID"].Value),
                    dataGridView_Employees.SelectedRows[0].Cells["Position"].Value.ToString());
                else
                    dt = controllerObj.SelectProjectByEmployeeMEMPID(ID, Convert.ToInt32(dataGridView_Employees.SelectedRows[0].Cells["National ID"].Value),
                        dataGridView_Employees.SelectedRows[0].Cells["Position"].Value.ToString());
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

        private void listBox_Projects_DoubleClick(object sender, EventArgs e)
        {
            new ProjectInfo(Convert.ToInt32(listBox_Projects.SelectedValue.ToString()), dt.Rows[listBox_Projects.SelectedIndex]["Project Status"].ToString()).Show(this);
        }

        private void ViewEmployees_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
    }
}
