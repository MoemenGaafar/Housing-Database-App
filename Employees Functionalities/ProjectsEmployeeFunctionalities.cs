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

namespace Housing_Database_Project
{
    public partial class ProjectsEmployeeFunctionalities : Form
    {
        private int ID;
        public ProjectsEmployeeFunctionalities(int id)
        {
            ID = id;
            InitializeComponent();
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProjectsEmployeeFunctionalities_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void ProjectsEmployeeFunctionalities_Load(object sender, EventArgs e)
        {

        }

        private void button_ViewProjs_Click(object sender, EventArgs e)
        {
            new EMP_ViewProjects(ID,"Projects").Show(this);
            this.Hide();
        }

        private void button_ViewApps_Click(object sender, EventArgs e)
        {
            new EMP_ViewApps(ID, "Projects").Show(this);
            this.Hide();
        }

        private void button_ViewTrans_Click(object sender, EventArgs e)
        {
            new EMP_ViewTrans(ID, "Projects").Show(this);
            this.Hide();
        }

        private void button_ChangePass_Click(object sender, EventArgs e)
        {
            new ChangePassword("Employee").Show(this);
            this.Hide();
        }
    }
}
