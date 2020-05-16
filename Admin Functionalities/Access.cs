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
    public partial class Access : Form
    {
        private Controller controllerObj = new Controller();
        public Access()
        {
            InitializeComponent();
            DataTable dt = controllerObj.GetAccessTable();
            dataGridView1.DataSource = dt;
            User.DataSource = dt;
            User.DisplayMember = "User";
            User.ValueMember = "User"; 
        }

        private void Access_Load(object sender, EventArgs e)
        {

        }

        private void Access_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (User.SelectedIndex == -1 || Pass.Text == "")
                MessageBox.Show("Please fill all the required fields!");
            else if (Pass.Text != Pass2.Text)
                MessageBox.Show("Passwords must match!");
            else
            {
                int r = controllerObj.EditAccess(User.Text, Pass.Text);
                if (r > 0)
                {
                    MessageBox.Show("Pass code modified Successfully!");
                    DataTable dt = controllerObj.GetAccessTable();
                    dataGridView1.DataSource = dt;
                }
                else
                    MessageBox.Show("Error encoutered. Action aborted");
            }
        }

    }
}
