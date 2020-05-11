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
    public partial class ViewCompanies : Form
    {
        private Controller controllerObj;
        private DataTable dt;
        public ViewCompanies()
        {
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void ViewCompanies_Load(object sender, EventArgs e)
        {
            dt = controllerObj.GetAllCompanies();
            dataGridView_Companies.DataSource = dt;
            dataGridView_Companies.Refresh();
        }


        private void listBox_Projects_DoubleClick(object sender, EventArgs e)
        {
            new ProjectInfo(Convert.ToInt32(listBox_Projects.SelectedValue.ToString()), dt.Rows[listBox_Projects.SelectedIndex]["Project Status"].ToString()).Show(this);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_ViewProjs_Click(object sender, EventArgs e)
        {
            if (dataGridView_Companies.SelectedRows.Count == 1)
            {
                dt = controllerObj.SelectProjectByCompany(Convert.ToInt32(dataGridView_Companies.SelectedRows[0].Cells["Company ID"].Value));
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

        private void ViewCompanies_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
    }
}
