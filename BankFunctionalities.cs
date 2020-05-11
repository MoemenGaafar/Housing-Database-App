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
    public partial class BankFunctionalities : Form
    {
        private Controller controllerObj = new Controller(); 
        private string name; 
        public BankFunctionalities(string n)
        {
            name = n; 
            InitializeComponent();
            DataTable dt = controllerObj.GetTransactionFee(name);
            TF2.Text = Convert.ToString(dt.Rows[0]["TranFees"]);
            TF4.Enabled = false;
            Confirm.Enabled = false; 
        }

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BankFunctionalities_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void BankFunctionalities_Load(object sender, EventArgs e)
        {

        }

        private void Btn_ChangePass_Click(object sender, EventArgs e)
        {
           new ChangePassword("Bank").Show(this);
            
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            bool isNumber = true;

            foreach (char c in TF4.Text)
            {
                if (c < '0' || c > '9')
                    isNumber = false;
            }

            if (isNumber)
            {
                int c = controllerObj.ChangeTransactionFee(name, Convert.ToByte(TF4.Text));
                if (c != 0)
                {
                    DataTable dt = controllerObj.GetTransactionFee(name);
                    TF2.Text = Convert.ToString(dt.Rows[0]["TranFees"]);
                    MessageBox.Show("Fees changed successfully");
                }
                else
                    MessageBox.Show("Error ocurred while changes fees");
            }
            else
                MessageBox.Show("Please enter a valid fee");
        }

        private void Btn_ChangeFees_Click(object sender, EventArgs e)
        {
            TF4.Enabled = true;
            Confirm.Enabled = true; 
        }

        private void NewTransaction_Click(object sender, EventArgs e)
        {
            new NewTransaction(name).Show(this);
            this.Hide(); 
        }

        private void CompletedTransactions_Click(object sender, EventArgs e)
        {
            new ViewTransactions(name).Show(this);
            this.Hide(); 
        }

        
    }
}
