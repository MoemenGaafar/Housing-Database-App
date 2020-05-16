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
        private int ID; // 0 for admin, -1 for bank, EID for manager 
        private Controller controllerObj = new Controller();
        private string name;
        private string type; //"cit" or "com"
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
            if (ID != 0)
            {
                Edit.Hide();
                Delete.Hide(); 
                TID.Hide();
            }
            comboBox_Bank.SelectedIndex = -1;
            if (ID != 0 && ID != -1)
            {
                Add.Visible = false; 
            }


        }

        private void View_Click(object sender, EventArgs e)
        {
            DataTable T = null;
            if (ID == -1 || ID == 0) //Admin or Bank
            {
                if (From.SelectedIndex == 0)
                {
                    if (Company.SelectedIndex == -1)
                        T = controllerObj.SelectAllCompanyBankTransactions((comboBox_Bank.SelectedIndex == -1) ? name : comboBox_Bank.SelectedItem.ToString());
                    else
                        T = controllerObj.SelectCompanyBankTransactions((comboBox_Bank.SelectedIndex == -1) ? name : comboBox_Bank.SelectedItem.ToString(), Convert.ToInt32(Company.SelectedValue));
                }
                else if (From.SelectedIndex == 1)
                {
                    if (String.IsNullOrWhiteSpace(Citizen.Text))
                        T = controllerObj.SelectAllCitizenBankTransactions((comboBox_Bank.SelectedIndex == -1) ? name : comboBox_Bank.SelectedItem.ToString());
                    else
                        T = controllerObj.SelectCitizenBankTransactions((comboBox_Bank.SelectedIndex == -1) ? name : comboBox_Bank.SelectedItem.ToString(), Convert.ToInt32(Citizen.Text));
                }
            }
            else //Manager
            {
                if (From.SelectedIndex == 0)
                {
                    if (Company.SelectedIndex == -1)
                        T = controllerObj.SelectCompanyTransactionsByMEMPID(ID, (comboBox_Bank.SelectedIndex == -1) ? name : comboBox_Bank.SelectedItem.ToString(), -1);
                    else
                        T = controllerObj.SelectCompanyTransactionsByMEMPID(ID, (comboBox_Bank.SelectedIndex == -1) ? name : comboBox_Bank.SelectedItem.ToString(), Convert.ToInt32(Company.SelectedValue));
                }
                else if (From.SelectedIndex == 1)
                {
                    if (String.IsNullOrWhiteSpace(Citizen.Text))
                        T = controllerObj.SelectCitizenTransactionsByMEMPID(ID, (comboBox_Bank.SelectedIndex == -1) ? name : comboBox_Bank.SelectedItem.ToString(), -1);
                    else
                        T = controllerObj.SelectCitizenTransactionsByMEMPID(ID, (comboBox_Bank.SelectedIndex == -1)? name: comboBox_Bank.SelectedItem.ToString(), Convert.ToInt32(Citizen.Text));
                }
            }

            dataGridView1.DataSource = T;
            dataGridView1.Refresh(); 
            if (ID == 0)
            {
                TID.DataSource = T;
                TID.DisplayMember = "Transaction ID";
                TID.ValueMember = "Transaction ID";
                if (From.SelectedIndex == 0)
                {
                    type = "Com"; 
                }
                else if (From.SelectedIndex == 1)
                    type = "Cit"; 

            }
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

        private void Edit_Click(object sender, EventArgs e)
        {
            new NewTransaction(Convert.ToInt64(TID.SelectedValue), type).Show(this); 
        }

        private void ViewTransactions_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            new NewTransaction(name).Show(this);
            this.Hide(); 
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (type == "Cit")
            {
                int r = controllerObj.DeleteCitTransaction(Convert.ToInt64(TID.SelectedValue));
                if (r > 0)
                    MessageBox.Show("Transaction deleted Successfully! Click View to refresh.");
                else
                    MessageBox.Show("Error encoutered. Action aborted.");
            }

            else if (type == "Com")
            {
                int r = controllerObj.DeleteComTransaction(Convert.ToInt64(TID.SelectedValue));
                if (r > 0)
                    MessageBox.Show("Transaction deleted Successfully!  Click View to refresh.");
                else
                    MessageBox.Show("Error encoutered. Action aborted.");
            }
        }
    }
}
