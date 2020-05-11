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
        private int ID;
        private DataTable dt;
        public NewProject(int id)
        {
            ID = id;
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                int r = controllerObj.Insert_Project(textBox_City.Text, Convert.ToInt32(textBox_RoomPrice.Text), ID, Convert.ToInt32(comboBox_ProjEmps.SelectedValue));
                if (r > 0)
                    MessageBox.Show("Project Added Successfully!");
                else
                    MessageBox.Show("Error Encoutered While Adding Project...");
            }
        }
    }
}
