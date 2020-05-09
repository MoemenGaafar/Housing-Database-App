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
    public partial class PEMP_ViewTrans : Form
    {
        private Controller controllerObj;
        private int ID;
        private DataTable dt;
        public PEMP_ViewTrans(int id)
        {
            ID = id;
            controllerObj = new Controller();
            InitializeComponent();
        }
        private void PEMP_ViewTrans_Load(object sender, EventArgs e)
        {
            dt = controllerObj.SelectAllCompanies();
            comboBox_Company.DataSource = dt;
            comboBox_Company.DisplayMember = "Name";
            comboBox_Company.ValueMember = "Name";

            dt = controllerObj.SelectAllBanks();
            comboBox_Bank.DataSource = dt;
            comboBox_Bank.DisplayMember = "Name";
            comboBox_Bank.ValueMember = "Name";

            comboBox_Bank.SelectedIndex = -1;
            comboBox_Company.SelectedIndex = -1;

            dt = controllerObj.SelectTransByPEMPID(ID,"All","All");
            dataGridView_Trans.DataSource = dt;
            dataGridView_Trans.Refresh();
        }

        private void comboBox_Bank_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_Company.SelectedIndex == -1)
                    dt = controllerObj.SelectTransByPEMPID(ID, (string)comboBox_Bank.SelectedValue, "All");
                else
                    dt = controllerObj.SelectTransByPEMPID(ID, (string)comboBox_Bank.SelectedValue, (string)comboBox_Company.SelectedValue);
            }
            catch
            {
                dt = controllerObj.SelectTransByPEMPID(ID, "All", "All");
            }
            dataGridView_Trans.DataSource = dt;
            dataGridView_Trans.Refresh();
        }

        private void comboBox_Company_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_Bank.SelectedIndex == -1)
                    dt = controllerObj.SelectTransByPEMPID(ID, "All", (string)comboBox_Company.SelectedValue);
                else
                    dt = controllerObj.SelectTransByPEMPID(ID, (string)comboBox_Bank.SelectedValue, (string)comboBox_Company.SelectedValue);
            }
            catch
            {
                dt = controllerObj.SelectTransByPEMPID(ID, "All", "All");
            }
            dataGridView_Trans.DataSource = dt;
            dataGridView_Trans.Refresh();
        }

        private void button_NoFilter_Click(object sender, EventArgs e)
        {
            comboBox_Bank.SelectedIndex = -1;
            comboBox_Company.SelectedIndex = -1;
            dt = controllerObj.SelectTransByPEMPID(ID, "All", "All");
            dataGridView_Trans.DataSource = dt;
            dataGridView_Trans.Refresh();
        }
    }
}
