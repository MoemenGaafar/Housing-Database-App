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
        private int ID;
        private Controller controllerObj = new Controller();
        private string name;
        public ViewTransactions(string n, int id)
        {
            ID = id;
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
            if (ID == -1) //Admin or Bank
            {
                if (From.SelectedIndex == 0)
                {
                    if (Company.SelectedIndex == -1)
                        T = controllerObj.SelectAllCompanyBankTransactions(name);
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
            }
            else //Manager
            {
                if (From.SelectedIndex == 0)
                {
                    if (Company.SelectedIndex == -1)
                        T = controllerObj.SelectCompanyTransactionsByMEMPID(ID, name, -1);
                    else
                        T = controllerObj.SelectCompanyTransactionsByMEMPID(ID, name, Convert.ToInt32(Company.SelectedValue));
                }
                else if (From.SelectedIndex == 1)
                {
                    if (String.IsNullOrWhiteSpace(Citizen.Text))
                        T = controllerObj.SelectCitizenTransactionsByMEMPID(ID, name, -1);
                    else
                        T = controllerObj.SelectCitizenTransactionsByMEMPID(ID, name, Convert.ToInt32(Citizen.Text));
                }
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

        private void ViewTransactions_Load(object sender, EventArgs e)
        {
            if (name == "All")
            {
                label_Bank.Visible = true;
                comboBox_Bank.Visible = true;
                DataTable dt = controllerObj.SelectAllBanks();
                comboBox_Bank.Items.Add("All");
                for (int intCount = 0; intCount < dt.Rows.Count; intCount++)
                {
                    var val = dt.Rows[intCount]["Bank Name"].ToString();
                    if (!comboBox_Bank.Items.Contains(val))
                    {
                        comboBox_Bank.Items.Add(val);
                    }
                }
            }

            if (ID != -1) label3.Visible = true;
        }

        private void comboBox_Bank_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = comboBox_Bank.SelectedItem.ToString();
        }
    }
}
