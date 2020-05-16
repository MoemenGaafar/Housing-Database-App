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
        private string type; //"cit" or "com" for editing
        private long TID; //Transaction Id for editing 
        public NewTransaction(string n)
        {
            name = n;
            InitializeComponent();
            ComEdit.Hide();
            CitEdit.Hide(); 
            if (name != "All")
            {
                Labelidk.Hide();
                label12.Hide();
                BankCit.Hide();
                BankCom.Hide();
                BankCit.SelectedIndex = -1;
                BankCom.SelectedIndex = -1;
            }
            else
            {
                DataTable dB = controllerObj.SelectAllBanks();
                BankCit.DataSource = dB;
                BankCit.DisplayMember = "Bank Name";
                BankCit.ValueMember = "Bank Name";
                BankCom.DataSource = dB;
                BankCom.DisplayMember = "Bank Name";
                BankCom.ValueMember = "Bank Name";
                BankCit.SelectedIndex = -1;
                BankCom.SelectedIndex = -1;

            }
             


        }

        public NewTransaction(long T, string t)
        {
            TID = T;
            type = t; 
            InitializeComponent();
            ComAdd.Hide();
            CitAdd.Hide();
            TIDCit.ReadOnly = true;
            TIDCom.ReadOnly = true;

            DataTable dB = controllerObj.SelectAllBanks();
            BankCit.DataSource = dB;
            BankCit.DisplayMember = "Bank Name";
            BankCit.ValueMember = "Bank Name";
            BankCom.DataSource = dB;
            BankCom.DisplayMember = "Bank Name";
            BankCom.ValueMember = "Bank Name";

            
            if (type == "Cit")
            {
                TIDCit.Text = Convert.ToString(TID); 
                DataTable U = controllerObj.GetCitTransaction(TID);
                EIDCit.Text = Convert.ToString(U.Rows[0]["EmployeeID"]);
                Cit.Text = Convert.ToString(U.Rows[0]["CitizenID"]);
                BankCit.Text = Convert.ToString(U.Rows[0]["BankName"]);
                Project.Text = Convert.ToString(U.Rows[0]["ProjectID"]);
                Unit.Text = Convert.ToString(U.Rows[0]["UnitID"]);
                AmountCit.Text = Convert.ToString(U.Rows[0]["Amount"]);

                
            }
            if (type == "Com")
            {
                TIDCom.Text = Convert.ToString(TID);
                DataTable U = controllerObj.GetComTransaction(TID);
                EIDCom.Text = Convert.ToString(U.Rows[0]["EmployeeID"]);
                Com.Text = Convert.ToString(U.Rows[0]["CompanyID"]);
                BankCom.Text = Convert.ToString(U.Rows[0]["BankName"]);
                AmountCom.Text = Convert.ToString(U.Rows[0]["Amount"]);

                
            }

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

            if (EIDCom.SelectedIndex == -1)
            {
                errors = errors + "Employee name is not valid \n";
                isCorrect = false;
            }


            if (Com.SelectedIndex == -1)
            {
                errors = errors + "Company name is not valid \n";
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

            if (name == "All")
            {
                if (BankCom.SelectedIndex == -1)
                {
                    errors = errors + "Bank name is not valid \n";
                    isCorrect = false;
                }
            }

            if (isCorrect)
            {
                int found = controllerObj.Add_ComTransaction(Convert.ToInt64(TIDCom.Text), (BankCom.SelectedIndex == -1) ? name : BankCom.SelectedValue.ToString(), Convert.ToInt32(EIDCom.SelectedValue), Convert.ToInt32(Com.SelectedValue), Convert.ToInt32(AmountCom.Text));
                if (found != 0)
                {
                    MessageBox.Show("Transaction added successfully.  Click View to refresh.");
                    TIDCom.Clear();
                    EIDCom.SelectedIndex = -1;
                    Com.SelectedIndex = -1;
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

            if (EIDCit.SelectedIndex == -1)
            {
                errors = errors + "Employee name is not valid \n";
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

            if (Project.SelectedIndex == -1)
            {
                errors = errors + "Project number is not valid \n";
                isCorrect = false;
            }

            if (Unit.SelectedIndex == -1)
            {
                errors = errors + "Unit number is not valid \n";
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

            if (name == "All")
            {
                if (BankCit.SelectedIndex == -1)
                {
                    errors = errors + "Bank name is not valid \n";
                    isCorrect = false;
                }
            }

            if (isCorrect)
            {
                int found = controllerObj.Add_CitTransaction(Convert.ToInt64(TIDCit.Text), (BankCit.SelectedIndex == -1) ? name : BankCit.SelectedValue.ToString(), Convert.ToInt32(EIDCit.SelectedValue), Convert.ToInt32(Cit.Text), Convert.ToInt32(Project.Text), Convert.ToInt32(Unit.Text), Convert.ToInt32(AmountCit.Text));
                if (found != 0)
                {
                    MessageBox.Show("Transaction added successfully.  Click View to refresh.");
                    TIDCit.Clear();
                    EIDCit.SelectedIndex = -1;
                    Cit.SelectedIndex = -1; 
                    Unit.SelectedIndex = -1;
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

        private void CitEdit_Click(object sender, EventArgs e)
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

            if (EIDCit.SelectedIndex == -1)
            {
                errors = errors + "Employee name is not valid \n";
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

            if (Project.SelectedIndex == -1)
            {
                errors = errors + "Project number is not valid \n";
                isCorrect = false;
            }

            if (Unit.SelectedIndex == -1)
            {
                errors = errors + "Unit number is not valid \n";
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

            if (name == "All")
            {
                if (BankCit.SelectedIndex == -1)
                {
                    errors = errors + "Bank name is not valid \n";
                    isCorrect = false;
                }
            }

            if (isCorrect)
            {
                int found = controllerObj.EditCitTransaction(Convert.ToInt64(TIDCit.Text), (BankCit.SelectedIndex == -1) ? name : BankCit.SelectedValue.ToString(), Convert.ToInt32(EIDCit.SelectedValue), Convert.ToInt32(Cit.Text), Convert.ToInt32(Project.Text), Convert.ToInt32(Unit.Text), Convert.ToInt32(AmountCit.Text));
                if (found != 0)
                {
                    MessageBox.Show("Transaction edited successfully.  Click View to refresh.");
                }
                else
                    MessageBox.Show("An error occurred. Check that the Citizen, Employee, Project, and Unit IDs are correct");

            }
            else
                MessageBox.Show(errors);
        }

        private void ComEdit_Click(object sender, EventArgs e)
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

            if (EIDCom.SelectedIndex == -1)
            {
                errors = errors + "Employee name is not valid \n";
                isCorrect = false;
            }

            if (Com.SelectedIndex == -1)
            {
                errors = errors + "Company name is not valid \n";
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

            if (name == "All")
            {
                if (BankCom.SelectedIndex == -1)
                {
                    errors = errors + "Bank name is not valid \n";
                    isCorrect = false;
                }
            }

            if (isCorrect)
            {
                int found = controllerObj.EditComTransaction(Convert.ToInt64(TIDCom.Text), (BankCom.SelectedIndex == -1) ? name : BankCom.SelectedValue.ToString(), Convert.ToInt32(EIDCom.SelectedValue), Convert.ToInt32(Com.SelectedValue), Convert.ToInt32(AmountCom.Text));
                if (found != 0)
                {
                    MessageBox.Show("Transaction edited successfully.  Click View to refresh.");
                }
                else
                    MessageBox.Show("An error occurred. Check that the Company and Employee IDs are correct");

            }
            else
                MessageBox.Show(errors);
        }

        private void Project_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Project.SelectedIndex != -1)
            {
                DataTable du = controllerObj.SelectAllUnitsByProject(Convert.ToInt32(Project.SelectedValue), "All");
                Unit.DataSource = du;
                Unit.DisplayMember = "Unit Number";
                Unit.ValueMember = "Unit Number";
                Unit.Refresh();
            }
        }

        private void NewTransaction_Load(object sender, EventArgs e)
        {

            DataTable C = controllerObj.SelectAllCompanies();
            Com.DataSource = C;
            Com.DisplayMember = "Name";
            Com.ValueMember = "CID";

            DataTable C2 = controllerObj.GetAllCitizens();
            Cit.DataSource = C2;
            Cit.DisplayMember = "NationalID";
            Cit.ValueMember = "NationalID";

            DataTable EH = controllerObj.SelectAllHousingEmployees();
            EIDCit.DataSource = EH;
            EIDCit.DisplayMember = "Employee Name";
            EIDCit.ValueMember = "National ID";

            DataTable EP = controllerObj.GetAllProjectEmployees();
            EIDCom.DataSource = EP;
            EIDCom.DisplayMember = "Employee Name";
            EIDCom.ValueMember = "National ID";

            Project.DisplayMember = "ID";
            Project.ValueMember = "ID";
            DataTable P = controllerObj.GetAllProjectIDs();
            Project.DataSource = P;

            if (name != null)
            {
                Project.SelectedIndex = -1;
                Unit.SelectedIndex = -1;
                Com.SelectedIndex = -1;
                EIDCom.SelectedIndex = -1;
                EIDCit.SelectedIndex = -1;
                Cit.SelectedIndex = -1;
            }

            if (type == "Cit")
            {
                Com.SelectedIndex = -1;
                EIDCom.SelectedIndex = -1;
                BankCom.SelectedIndex = -1;
            }

            if (type == "Com")
            {
                Project.SelectedIndex = -1;
                Unit.SelectedIndex = -1;
                EIDCit.SelectedIndex = -1;
                Cit.SelectedIndex = -1;
                BankCit.SelectedIndex = -1;
            }
            

        }
    }
}
