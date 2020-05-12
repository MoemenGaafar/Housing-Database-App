using Housing_Database_Project.Sign_Up_Forms;
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
    public partial class ManagerEmployeeFunctionalities : Form
    {
        private int ID;
        public ManagerEmployeeFunctionalities(int id)
        {
            ID = id;
            InitializeComponent();
        }

        private void button_ChangePass_Click(object sender, EventArgs e)
        {
            new ChangePassword("Employee").Show(this);
            this.Hide();
        }

        private void button_CreateProj_Click(object sender, EventArgs e)
        {
            new NewProject(ID).Show(this);
            this.Hide();
        }

        private void button_CreateEmp_Click(object sender, EventArgs e)
        {
            new SignUpEmployee().Show(this);
            this.Hide();
        }

        private void button_ViewComps_Click(object sender, EventArgs e)
        {
            new ViewCompanies(ID).Show(this);
            this.Hide();
        }

        private void button_ViewEmps_Click(object sender, EventArgs e)
        {
            new ViewEmployees(ID).Show(this);
            this.Hide();
        }

        private void button_ViewTrans_Click(object sender, EventArgs e)
        {
            new ViewTransactions("All", ID).Show(this);
            this.Hide();
        }

        private void button_ViewProjs_Click(object sender, EventArgs e)
        {
            new EMP_ViewProjects(ID, "Manager").Show(this);
            this.Hide();
        }

        private void button_ViewApps_Click(object sender, EventArgs e)
        {
            new ViewApplications(ID).Show(this);
            this.Hide();
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManagerEmployeeFunctionalities_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void ManagerEmployeeFunctionalities_Load(object sender, EventArgs e)
        {

        }
    }
}
