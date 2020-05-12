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
using System.Windows.Forms.VisualStyles;

namespace Housing_Database_Project
{
    public partial class CompanyFunctionalities : Form
    {
        private int ID;
        public CompanyFunctionalities(int id)
        {
            ID = id;
            InitializeComponent();
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompanyFunctionalities_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void button_ChangePass_Click(object sender, EventArgs e)
        {
            new ChangePassword("Company").Show(this);
            this.Hide();
        }

        private void button_ViewProjs_Click(object sender, EventArgs e)
        {
            new EMP_ViewProjects(ID, "Company").Show(this);
            this.Hide();
        }

        private void button_ViewTrans_Click(object sender, EventArgs e)
        {
            new EMP_ViewTrans(ID, "Company").Show(this);
            this.Hide();
        }
    }
}
