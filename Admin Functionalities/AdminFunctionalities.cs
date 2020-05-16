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
    public partial class AdminFunctionalities : Form
    {
        private Controller controllerObj = new Controller();
        private int isHigh; 
        public AdminFunctionalities(int i)
        {
            isHigh = i; 
            InitializeComponent();
        }

        private void AdminFunctionalities_Load(object sender, EventArgs e)
        {

        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminFunctionalities_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void Password_Click(object sender, EventArgs e)
        {
            new ChangePassword("Admin").Show(this);
            this.Hide();
        }

        private void Transactions_Click(object sender, EventArgs e)
        {
            new ViewTransactions("All", 0).Show(this);
            this.Hide();
        }

        private void Access_Click(object sender, EventArgs e)
        {
            new Access().Show(this);
            this.Hide(); 
        }

        private void Admins_Click(object sender, EventArgs e)
        {
            new ManageAdmins(isHigh).Show(this);
            this.Hide(); 
        }

        private void Applications_Click(object sender, EventArgs e)
        {
            new ViewApplications(-1).Show(this);
            this.Hide(); 
        }

        private void Projects_Click(object sender, EventArgs e)
        {
            new Housing_Database_Project.Employees_Functionalities.EMP_ViewProjects(-1, "Admin").Show(this);
            this.Hide();
        
        }

        private void Citizens_Click(object sender, EventArgs e)
        {
            new ViewCitizens().Show(this);
            this.Hide(); 
        }

        private void Banks_Click(object sender, EventArgs e)
        {
            new ViewBanks().Show(this);
            this.Hide(); 
        }

        private void Employees_Click(object sender, EventArgs e)
        {
            new Housing_Database_Project.Employees_Functionalities.ViewEmployees(-1).Show(this);
            this.Hide(); 
        }
    }
}
