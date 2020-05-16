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
    public partial class CitizenPayments : Form
    {
        private Controller controllerObj = new Controller();
        private int ID;
        private string bank = ""; 
        private int project = 0, unit = 0; 
        public CitizenPayments(int i)
        {
            ID = i; 
            InitializeComponent();
            DataTable dt = controllerObj.GetDoneCitApplicationsByCitizen(ID);
            dataGridView1.DataSource = dt;
            DataTable dp = controllerObj.SelectTransactionsByCitizen(ID, project, unit, bank);
            dataGridView2.DataSource = dp;

            if (dp != null)
            {

                for (int intCount = 0; intCount < dp.Rows.Count; intCount++)
                {
                    var val = dp.Rows[intCount]["BankName"];

                    if (!BankView.Items.Contains(val))
                    {
                        BankView.Items.Add(val);
                    }
                }

                for (int intCount = 0; intCount < dp.Rows.Count; intCount++)
                {
                    var val = dp.Rows[intCount]["ProjectID"];

                    if (!ProjectView.Items.Contains(val))
                    {
                        ProjectView.Items.Add(val);
                    }
                }
            }

            DataTable C = controllerObj.SelectCitizenByID(ID);
            CitizenID.Text = Convert.ToString(C.Rows[0]["First Name"]) + Convert.ToString(C.Rows[0]["Last Name"]);
        }

       

        private void CitizenPayments_Load(object sender, EventArgs e)
        {

        }

       
        private void ProjectView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProjectView.SelectedIndex != -1)
            {
                project = Convert.ToInt32(ProjectView.SelectedItem);
                DataTable du = controllerObj.GetUnitsOfCitApplicationsByProjectAndCitizen(ID, project);
                UnitView.DataSource = du;
                UnitView.ValueMember = "UnitID";
                UnitView.DisplayMember = "UnitID";
                UnitView.Refresh(); 
            }
            else
            {
                unit = 0;
                UnitView.DataSource = null; 
            }
           
        }

        private void CitizenPayments_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void View_Click(object sender, EventArgs e)
        {
            if (BankView.SelectedIndex != -1)
            {
                bank = Convert.ToString(BankView.SelectedItem);
            }
            else
                bank = "";

            if (ProjectView.SelectedIndex != -1)
            {
                project = Convert.ToInt32(ProjectView.SelectedItem);
            }
            else
            {
                project = 0;
                unit = 0; 
            }
            

            if (project !=0 && UnitView.SelectedIndex != -1)
            {
                unit = Convert.ToInt32(UnitView.SelectedValue);
            }
            else
                unit = 0;


            DataTable D = controllerObj.SelectTransactionsByCitizen(ID, project, unit, bank);
            dataGridView2.DataSource = D; 
        }
    }
}
