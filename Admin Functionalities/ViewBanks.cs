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
    public partial class ViewBanks : Form
    {
        private Controller controllerObj = new Controller();
        public ViewBanks()
        {
            InitializeComponent();
            DataTable T = controllerObj.GetAllBanks();
            dataGridView1.DataSource = T;
            BankName.Items.Add("All");
            for (int intCount = 0; intCount < T.Rows.Count; intCount++)
            {
                var val = T.Rows[intCount]["Name"].ToString();
                BankName.Items.Add(val);
            }
            BankName.SelectedIndex = 0;
        }

        private void RefreshGrid()
        {
            DataTable C;

            if (BankName.SelectedIndex == 0)
            {
                C = controllerObj.GetAllBanks();
                dataGridView1.DataSource = C;
            }
            else
            {
                C = controllerObj.SelectBankByName(Convert.ToString(BankName.SelectedItem));
                dataGridView1.DataSource = C;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            new Housing_Database_Project.Sign_Up_Forms.SignUpBank(true).Show(this);
            this.Hide(); 
        }

        private void ViewBanks_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                Owner.Show();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                MessageBox.Show("Please select one row to perform action on.");
            else
            {
                int done = controllerObj.DeleteBank(Convert.ToString(dataGridView1.SelectedRows[0].Cells["Name"].Value));
                if (done > 0)
                {
                    MessageBox.Show("Bank deleted successfully.");
                    RefreshGrid();
                    BankName.Items.Clear(); 
                    DataTable C = controllerObj.GetAllBanks();
                    dataGridView1.DataSource = C;
                    BankName.Items.Add("All");
                    for (int intCount = 0; intCount < C.Rows.Count; intCount++)
                    {
                        var val = C.Rows[intCount]["Name"].ToString();
                        BankName.Items.Add(val);
                    }

                }
                else
                    MessageBox.Show("An error occured.");
            }
            }

        private void BankName_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid(); 
        }

        private void ViewTrans_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                MessageBox.Show("Please select one row to perform action on.");
            else
            {
                new ViewTransactions(Convert.ToString(dataGridView1.SelectedRows[0].Cells["Name"].Value), 0).Show(this);
                this.Hide();
            }
        }

        private void NewTrans_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                MessageBox.Show("Please select one row to perform action on.");
            else
            {
                new NewTransaction(Convert.ToString(dataGridView1.SelectedRows[0].Cells["Name"].Value)).Show(this);
                this.Hide();
            }
        }

        private void Info_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                MessageBox.Show("Please select one row to perform action on.");
            else
            {
                new Housing_Database_Project.Sign_Up_Forms.SignUpBank(Convert.ToString(dataGridView1.SelectedRows[0].Cells["Name"].Value)).Show(this);
                this.Hide();
            }
        }
    }
}
