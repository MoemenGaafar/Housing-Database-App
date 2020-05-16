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
    public partial class NewProject : Form
    {
        private Controller controllerObj;
        private int ID; //Manager ID, -1 if admin 
        private DataTable dt;
        public NewProject(int id)
        {
            ID = id;
            controllerObj = new Controller();
            InitializeComponent();
            if (ID != -1)
            {
                label3.Hide();
                Manager.Hide(); 
            }
            else
            {
                DataTable M = controllerObj.GetAllManagers();
                Manager.DataSource = M;
                Manager.DisplayMember = "Employee Name";
                Manager.ValueMember = "National ID";
                Manager.SelectedIndex = -1;
            }
        }
        
        private void NewProject_Load(object sender, EventArgs e)
        {
            dt = controllerObj.GetAllProjectEmployees();
            comboBox_ProjEmps.DataSource = dt;
            comboBox_ProjEmps.DisplayMember = "Employee Name";
            comboBox_ProjEmps.ValueMember = "National ID";
            comboBox_ProjEmps.SelectedIndex = -1;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_City.Text == "" || textBox_RoomPrice.Text == "" || comboBox_ProjEmps.SelectedIndex == -1)
                MessageBox.Show("Please fill all the required fields!");
            else
            {
                int i;
                if (ID == -1)
                    i = Convert.ToInt32(Manager.SelectedValue);
                else
                    i = ID; 

                int r = controllerObj.Insert_Project(textBox_City.Text, Convert.ToInt32(textBox_RoomPrice.Text), i, Convert.ToInt32(comboBox_ProjEmps.SelectedValue));
                if (r > 0)
                {
                    MessageBox.Show("Project Added Successfully!");
                    if (ID == -1)
                    {
                        new EMP_ViewProjects(-1, "Admin").Show(this.Owner.Owner);
                        this.Owner.Close(); 
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Error Encoutered While Adding Project...");
            }
        }

        private void NewProject_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
    }
}
