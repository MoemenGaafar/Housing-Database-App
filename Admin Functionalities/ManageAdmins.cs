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

namespace Housing_Database_Project
{
    public partial class ManageAdmins : Form
    {
        private Controller controllerObj = new Controller();
        private int isHigh; 
        public ManageAdmins(int i)
        {
            isHigh = i; 
            InitializeComponent();
            if (isHigh == 0)
            {
                Confirm.Hide();
                MakeHigh.Hide();
                newPass.Hide();
                Delete.Hide();
                label2.Hide();
                label3.Hide();
                label4.Hide();             
            }

            DataTable dt = controllerObj.SelectAdmins();
            dataGridView1.DataSource = dt; 
        }

        private void ManageAdmins_Load(object sender, EventArgs e)
        {

        }

        private void ManageAdmins_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(newPass.Text))
                MessageBox.Show("Please enter a valid new password");
            else
            {
                if (dataGridView1.SelectedRows.Count != 1)
                    MessageBox.Show("Please select onw row to act on.");
                else
                {
                    int i = dataGridView1.SelectedRows[0].Index; 
                    int done = controllerObj.ChangeAdminPassword(Convert.ToString(dataGridView1.Rows[i].Cells[0].Value), newPass.Text);
                    if (done > 0)
                    {
                        MessageBox.Show("Password modified Successfully!");
                        DataTable dt = controllerObj.SelectAdmins();
                        dataGridView1.DataSource = dt;
                    }
                    else
                        MessageBox.Show("Error encoutered. Action aborted");
                }
            }
        }

        private void MakeHigh_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                MessageBox.Show("Please select onw row to act on.");
            else
            {
                int i = dataGridView1.SelectedRows[0].Index;
                int done = controllerObj.MakeHighAdmin(Convert.ToString(dataGridView1.Rows[i].Cells[0].Value));
                if (done > 0)
                {
                    MessageBox.Show("High admin altered successfully. You will now be logged out.");
                    this.Owner.Close();
                    this.Close();
                }
                else
                    MessageBox.Show("Error encoutered. Action aborted");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                MessageBox.Show("Please select onw row to act on.");
            else
            {
                int i = dataGridView1.SelectedRows[0].Index;
                int done = controllerObj.DeleteAdmin(Convert.ToString(dataGridView1.Rows[i].Cells[0].Value));
                if (done > 0)
                {
                    MessageBox.Show("Administrator deleted successfully");
                    DataTable dt = controllerObj.SelectAdmins();
                    dataGridView1.DataSource = dt;
                }
                else
                    MessageBox.Show("Error encoutered. Action aborted");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(addPass.Text) || String.IsNullOrWhiteSpace(addName.Text))
                MessageBox.Show("Please enter a valid username and password");
            else
            {
               int done = controllerObj.AddAdmin(addName.Text, addPass.Text);
               if (done > 0)
               {
                    MessageBox.Show("Admin added Successfully!");
                    DataTable dt = controllerObj.SelectAdmins();
                    dataGridView1.DataSource = dt;
               }
               else
                    MessageBox.Show("Error encoutered. Action aborted");
                
            }
        }

    }
}
