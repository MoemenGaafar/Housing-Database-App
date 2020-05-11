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
        private Controller controllerObj;
        private DataTable dt;
        public ViewEmployees()
        {
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void ViewEmployees_Load(object sender, EventArgs e)
        {
            dt = controllerObj.GetAllEmployees();
            dataGridView_Employees.DataSource = dt;
            dataGridView_Employees.Refresh();
        }

        private void button_ViewProjs_Click(object sender, EventArgs e)
        {
            if (dataGridView_Employees.SelectedRows.Count == 1)
            {
                dt = controllerObj.SelectProjectByEmployee(Convert.ToInt32(dataGridView_Employees.SelectedRows[0].Cells["National ID"].Value),
                    dataGridView_Employees.SelectedRows[0].Cells["Position"].Value.ToString());
                if (!(dt is null))
                    label3.Visible = true;
                listBox_Projects.DataSource = dt;
                listBox_Projects.ValueMember = "ID";
                listBox_Projects.Refresh();
            }
            else
            {
                MessageBox.Show("Please select ONE ENTIRE ROW!");
            }
        }

        private void listBox_Projects_DoubleClick(object sender, EventArgs e)
        {
            new ProjectInfo(Convert.ToInt32(listBox_Projects.SelectedValue.ToString())).Show(this);
        }

        private void ViewEmployees_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
    }
}
