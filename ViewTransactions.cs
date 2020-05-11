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
    public partial class ViewTransactions : Form
    {
        private Controller controllerObj = new Controller();
        private string name;
        public ViewTransactions(string n)
        {
            name = n;
            InitializeComponent();
            DataTable dt = controllerObj.SelectAllCompanies();
            Company.DataSource = dt;
            Company.DisplayMember = "Name";
            Company.ValueMember = "CID"; 
            Company.SelectedIndex = -1; 
            From.SelectedIndex = -1;
            Citizen.Enabled = false;
            Company.Enabled = false;
            
        }

        private void View_Click(object sender, EventArgs e)
        {
            DataTable T = null; 
            if (From.SelectedIndex == 0)
            {
                if (Company.SelectedIndex == -1)
                    T= controllerObj.SelectAllCompanyBankTransactions(name);
                else
                    T = controllerObj.SelectCompanyBankTransactions(name, Convert.ToInt32(Company.SelectedValue));
            }
            else if (From.SelectedIndex == 1)
            {
                if (String.IsNullOrWhiteSpace(Citizen.Text))
                    T = controllerObj.SelectAllCitizenBankTransactions(name);
                else
                    T = controllerObj.SelectCitizenBankTransactions(name, Convert.ToInt32(Citizen.Text));

            }

            dataGridView1.DataSource = T;
            dataGridView1.Refresh(); 
        }

        private void From_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (From.SelectedIndex == 0)
            {
                Company.Enabled = true;
                Citizen.Enabled = false;
            }
            else if (From.SelectedIndex == 1)
            {
                Citizen.Enabled = true;
                Company.Enabled = false;
            }
        }

     }
}
