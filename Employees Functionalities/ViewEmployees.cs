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
        private int ID; //Manger ID or -1 if Admin
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
            {
                dt = controllerObj.GetAllEmployees();
                Add.Visible = true;
                Delete.Visible = true; 
            }
            else
            {
                label_Title.Text = "Your Employees";
                dt = controllerObj.SelectEmployeesByMEMPID(ID);
                Info.Hide();
            }
            dataGridView_Employees.DataSource = dt;
            dataGridView_Employees.Refresh();
            EmployeeName.DataSource = dt;
            EmployeeName.DisplayMember = "Name";
            EmployeeName.ValueMember = "National ID"; 

        }

        private void RefreshGrid()
        {
            DataTable C;
            C = controllerObj.GetAllEmployees();
            dataGridView_Employees.DataSource = C;
            EmployeeName.DataSource = C;
            EmployeeName.DisplayMember = "Name";
            EmployeeName.ValueMember = "National ID";
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
            string Type;
            if (ID == -1) Type = "Admin";
            else Type = "Manager";
            new ProjectInfo(Convert.ToInt32(listBox_Projects.SelectedValue.ToString()), Type).Show(this);
        }

        private void ViewEmployees_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
        

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Employees.SelectedRows.Count != 1)
                MessageBox.Show("Please select one row to perform action on.");
            else
            {
                int done = controllerObj.DeleteEmployee(Convert.ToInt32(dataGridView_Employees.SelectedRows[0].Cells["National ID"].Value));
                if (done > 0)
                {
                    MessageBox.Show("Employee deleted successfully.");     
                    RefreshGrid();           
                }
                else
                    MessageBox.Show("An error occured.");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            new Housing_Database_Project.Sign_Up_Forms.SignUpEmployee(true).Show(this);
            this.Hide(); 
        }

        private void Info_Click(object sender, EventArgs e)
        {
            if (dataGridView_Employees.SelectedRows.Count != 1)
                MessageBox.Show("Please select one row to perform action on.");
            else
            {
                new Housing_Database_Project.Sign_Up_Forms.SignUpEmployee(Convert.ToInt32(dataGridView_Employees.SelectedRows[0].Cells["National ID"].Value)).Show(this);
                this.Hide();
            }
        }
    }
}
