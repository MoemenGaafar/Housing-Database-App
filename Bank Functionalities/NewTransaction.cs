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
    public partial class NewTransaction : Form
    {
        private Controller controllerObj = new Controller();
        private string name;
        public NewTransaction(string n)
        {
            name = n; 
            InitializeComponent();
            DataTable dt = controllerObj.GetAllProjectIDs();
            Project.DataSource = dt;
            Project.DisplayMember = "ID"; 
        }


        private void ComAdd_Click(object sender, EventArgs e)
        {
            string errors = "Your input has errors including: \n";
            bool isNumber = true;
            bool isCorrect = true;
            foreach (char c in TIDCom.Text)
            {
                if (c < '0' || c > '9')
                    isNumber = false;
            }
            if (!isNumber || String.IsNullOrWhiteSpace(TIDCom.Text))
            {
                errors = errors + "Transaction ID is not valid \n";
                isCorrect = false;
            }

            isNumber = true;
            foreach (char c in EIDCom.Text)
            {
                if (c < '0' || c > '9')
                    isNumber = false;
            }
            if (!isNumber || String.IsNullOrWhiteSpace(EIDCom.Text))
            {
                errors = errors + "Employee ID is not valid \n";
                isCorrect = false;
            }

            isNumber = true;
            foreach (char c in Com.Text)
            {
                if (c < '0' || c > '9')
                    isNumber = false;
            }
            if (!isNumber || String.IsNullOrWhiteSpace(Com.Text))
            {
                errors = errors + "Company ID is not valid \n";
                isCorrect = false;
            }
            
            isNumber = true;
            foreach (char c in AmountCom.Text)
            {
                if (c < '0' || c > '9')
                    isNumber = false;
            }
            if (!isNumber || String.IsNullOrWhiteSpace(AmountCom.Text))
            {
                errors = errors + "Amount is not valid \n";
                isCorrect = false;
            }

            if (isCorrect)
            {
                int found = controllerObj.Add_ComTransaction(Convert.ToInt64(TIDCom.Text), name, Convert.ToInt32(EIDCom.Text), Convert.ToInt32(Com.Text), Convert.ToInt32(AmountCom.Text));
                if (found != 0)
                {
                    MessageBox.Show("Transaction added successfully");
                    TIDCom.Clear();
                    EIDCom.Clear();
                    Com.Clear();
                    AmountCom.Clear();
                }
                else
                    MessageBox.Show("An error occurred. Check that the Company and Employee IDs are correct");

            }
            else
                MessageBox.Show(errors);
        }

        private void CitAdd_Click(object sender, EventArgs e)
        {
            string errors = "Your input has errors including: \n"; 
            bool isNumber = true;
            bool isCorrect = true; 
            foreach (char c in TIDCit.Text)
            {
                    if (c < '0' || c > '9')
                        isNumber = false;
            }
            if (!isNumber || String.IsNullOrWhiteSpace(TIDCit.Text))
            {
                errors = errors + "Transaction ID is not valid \n";
                isCorrect = false;
            }

            isNumber = true;
            foreach (char c in EIDCit.Text)
            {
                if (c < '0' || c > '9')
                    isNumber = false;
            }
            if (!isNumber || String.IsNullOrWhiteSpace(EIDCit.Text))
            {
                errors = errors + "Employee ID is not valid \n";
                isCorrect = false;
            }

            isNumber = true;
            foreach (char c in Cit.Text)
            {
                if (c < '0' || c > '9')
                    isNumber = false;
            }
            if (!isNumber || String.IsNullOrWhiteSpace(Cit.Text))
            {
                errors = errors + "Citizen ID is not valid \n";
                isCorrect = false;
            }

            isNumber = true;
            foreach (char c in Project.Text)
            {
                if (c < '0' || c > '9')
                    isNumber = false;
            }
            if (!isNumber || String.IsNullOrWhiteSpace(Project.Text))
            {
                errors = errors + "Project ID is not valid \n";
                isCorrect = false;
            }

            isNumber = true;
            foreach (char c in Unit.Text)
            {
                if (c < '0' || c > '9')
                    isNumber = false;
            }
            if (!isNumber || String.IsNullOrWhiteSpace(Unit.Text))
            {
                errors = errors + "Unit ID is not valid \n";
                isCorrect = false;
            }

            isNumber = true;
            foreach (char c in AmountCit.Text)
            {
                if (c < '0' || c > '9')
                    isNumber = false;
            }
            if (!isNumber || String.IsNullOrWhiteSpace(AmountCit.Text))
            {
                errors = errors + "Amount is not valid \n";
                isCorrect = false;
            }

            if (isCorrect)
            {
                int found = controllerObj.Add_CitTransaction(Convert.ToInt64(TIDCit.Text), name, Convert.ToInt32(EIDCit.Text), Convert.ToInt32(Cit.Text), Convert.ToInt32(Project.Text), Convert.ToInt32(Unit.Text), Convert.ToInt32(AmountCit.Text));
                if (found != 0)
                {
                    MessageBox.Show("Transaction added successfully");
                    TIDCit.Clear();
                    EIDCit.Clear();
                    Cit.Clear();
                    Unit.Clear();
                    AmountCit.Clear();
                    

                }
                else
                    MessageBox.Show("An error occurred. Check that the Citizen, Employee, Project, and Unit IDs are correct");

            }
            else
                MessageBox.Show(errors);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void NewTransaction_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
    }
}
