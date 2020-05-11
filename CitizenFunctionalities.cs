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
    public partial class CitizenFunctionalities : Form
    {
        private Controller controllerObj = new Controller();
        private int ID; 
        public CitizenFunctionalities(int i)
        {
            ID = i; 
            InitializeComponent();
        }

        private void CitizenFunctionalities_Load(object sender, EventArgs e)
        {

        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CitizenFunctionalities_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void Units_Click(object sender, EventArgs e)
        {
            new Units('C', ID).Show(this); 
        }

        private void Applications_Click(object sender, EventArgs e)
        {
            new CitizenApplications(ID).Show(this); 
        }

        private void Transactions_Click(object sender, EventArgs e)
        {
            new CitizenPayments(ID).Show(); 
        }

        private void Password_Click(object sender, EventArgs e)
        {
            new ChangePassword("Citizen").Show();
        }
    }
}
