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

namespace Housing_Database_Project.Employees_Functionalities
{
    public partial class EMP_ViewTrans : Form
    {
        private Controller controllerObj;
        private int ID;
        private string Type;
        private DataTable dt;
        public EMP_ViewTrans(int id, string type)
        {
            Type = type;
            ID = id;
            controllerObj = new Controller();
            InitializeComponent();
        }
        private void PEMP_ViewTrans_Load(object sender, EventArgs e)
        {
            if (Type == "Housing")
            {
                label_Client.Text = "Citizen";
                label_Title.Text = "Citizen Transactions";
            }
            else if (Type == "Company")
            {
                comboBox_Company.Enabled = false;
            }

            if (Type == "Company")
                dt = controllerObj.SelectTransByCompanyID(ID, "All");
            else
                dt = controllerObj.SelectTransByEMPID(ID, "All", "All", Type);

            for (int intCount = 0; intCount < dt.Rows.Count; intCount++)
            {
                var val = "";
                if (Type == "Projects")
                    val = dt.Rows[intCount]["Company"].ToString();
                else if (Type == "Housing")
                    val = dt.Rows[intCount]["Citizen"].ToString();

                var val2 = dt.Rows[intCount]["Bank"].ToString();
                if (!comboBox_Company.Items.Contains(val))
                {
                    comboBox_Company.Items.Add(val);
                }
                if (!comboBox_Bank.Items.Contains(val2))
                {
                    comboBox_Bank.Items.Add(val2);
                }
            }

            comboBox_Bank.Text = "";
            comboBox_Company.Text = "";

            dataGridView_Trans.DataSource = dt;
            dataGridView_Trans.Refresh();
        }

        private void comboBox_Bank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Type == "Company")
            {
                    dt = controllerObj.SelectTransByCompanyID(ID, comboBox_Bank.SelectedItem.ToString());
            }
            else
            {
                if (comboBox_Company.Text == "")
                    dt = controllerObj.SelectTransByEMPID(ID, comboBox_Bank.SelectedItem.ToString(), "All", Type);
                else
                    dt = controllerObj.SelectTransByEMPID(ID, comboBox_Bank.SelectedItem.ToString(), comboBox_Company.SelectedItem.ToString(), Type);
            }
            dataGridView_Trans.DataSource = dt;
            dataGridView_Trans.Refresh();
        }

        private void comboBox_Company_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (comboBox_Bank.Text == "")
                    dt = controllerObj.SelectTransByEMPID(ID, "All", comboBox_Company.SelectedItem.ToString(), Type);
                else
                    dt = controllerObj.SelectTransByEMPID(ID, comboBox_Bank.SelectedItem.ToString(), comboBox_Company.SelectedItem.ToString(), Type);
            dataGridView_Trans.DataSource = dt;
            dataGridView_Trans.Refresh();
        }

        private void button_NoFilter_Click(object sender, EventArgs e)
        {
            if (Type == "Company")
            {
                comboBox_Bank.Text = "";
                dt = controllerObj.SelectTransByCompanyID(ID, "All");
                dataGridView_Trans.DataSource = dt;
                dataGridView_Trans.Refresh();
            }
            else
            {
                comboBox_Bank.Text = "";
                comboBox_Company.Text = "";
                dt = controllerObj.SelectTransByEMPID(ID, "All", "All", Type);
                dataGridView_Trans.DataSource = dt;
                dataGridView_Trans.Refresh();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void EMP_ViewTrans_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }
    }
}
