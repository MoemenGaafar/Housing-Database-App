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
            dt = controllerObj.SelectTransByEMPID(ID, "All", "All", Type);
            dataGridView_Trans.DataSource = dt;
            dataGridView_Trans.Refresh();

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

            if (Type == "Housing") {
                label_Client.Text = "Citizen";
                label_Title.Text = "Citizen Transactions"; 
            }
        }

        private void comboBox_Bank_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (comboBox_Company.Text == "")
                    dt = controllerObj.SelectTransByEMPID(ID, (string)comboBox_Bank.SelectedItem, "All", Type);
                else
                    dt = controllerObj.SelectTransByEMPID(ID, (string)comboBox_Bank.SelectedItem, (string)comboBox_Company.SelectedItem, Type);
            dataGridView_Trans.DataSource = dt;
            dataGridView_Trans.Refresh();
        }

        private void comboBox_Company_SelectedIndexChanged(object sender, EventArgs e)
        {
                if (comboBox_Bank.Text == "")
                    dt = controllerObj.SelectTransByEMPID(ID, "All", (string)comboBox_Company.SelectedItem, Type);
                else
                    dt = controllerObj.SelectTransByEMPID(ID, (string)comboBox_Bank.SelectedItem, (string)comboBox_Company.SelectedItem, Type);
            dataGridView_Trans.DataSource = dt;
            dataGridView_Trans.Refresh();
        }

        private void button_NoFilter_Click(object sender, EventArgs e)
        {
            comboBox_Bank.Text = "";
            comboBox_Company.Text = "";
            dt = controllerObj.SelectTransByEMPID(ID, "All", "All", Type);
            dataGridView_Trans.DataSource = dt;
            dataGridView_Trans.Refresh();
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
