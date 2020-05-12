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

namespace Housing_Database_Project.Company_Functionalities
{
    public partial class ApplyToProjects : Form
    {
        private Controller controllerObj;
        private int ID;
        private DataTable dt;
        public ApplyToProjects(int id)
        {
            controllerObj = new Controller();
            ID = id;
            InitializeComponent();
        }

        private void ApplyToProjects_Load(object sender, EventArgs e)
        {
            dt = controllerObj.SelectPostedProjects(0, "All"); //Room Price of 0 means All Room Prices
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
        }

        private void button_Retrieve_Click(object sender, EventArgs e)
        {
            if (comboBox_City.SelectedIndex == -1) comboBox_City.SelectedItem = "All";

            if (String.IsNullOrWhiteSpace(textBox_RoomPrice.Text))
            {
                dt = controllerObj.SelectPostedProjects(0, comboBox_City.SelectedItem.ToString()); //Room Price of 0 means All Room Prices
            }
            else
            {
                dt = controllerObj.SelectPostedProjects(Convert.ToInt32(textBox_RoomPrice.Text), comboBox_City.SelectedItem.ToString());
            }
            dataGridView_Projects.DataSource = dt;
            dataGridView_Projects.Refresh();
        }

        private void button_ViewProj_Click(object sender, EventArgs e)
        {
            if (dataGridView_Projects.SelectedRows.Count == 1)
            {
                new ProjectInfo(Convert.ToInt32(dataGridView_Projects.SelectedRows[0].Cells["Project ID"].Value.ToString()), "Company").Show(this);
            }
            else
            {
                MessageBox.Show("Please select ONE ENTIRE ROW!");
            }
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            if (dataGridView_Projects.SelectedRows.Count == 1)
            {
                new SetBiddingPrice(Convert.ToInt32(dataGridView_Projects.SelectedRows[0].Cells["Project ID"].Value.ToString()), ID).Show();
            }
            else
            {
                MessageBox.Show("Please select ONE ENTIRE ROW!");
            }
        }

        private void ApplyToProjects_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
    }
}
