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
    public partial class SignUp : Form
    {
        private Controller controllerObj;
        public SignUp()
        {
            InitializeComponent();
            controllerObj = new Controller();
            Size = new System.Drawing.Size(450,195);
            comboBox_AccType.SelectedIndex = -1;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) Btn_SignUp.Enabled = true;
            else Btn_SignUp.Enabled = false;
        }

        private void comboBox_AccType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((string)comboBox_AccType.SelectedItem == "Bank")
            {
                label2.Text = "Transaction Fees";
                Size = new System.Drawing.Size((int)(0.8 * 548), (int)(0.8 * 461));
            }
        }

        private void Btn_SignUp_Click(object sender, EventArgs e)
        {
           //int r = controllerObj.SignUpBank(TxtBx_username.Text, TxtBx_pass.Text, Convert.ToInt32(textBox2.Text));
           // if (r > 0) MessageBox.Show("Bank Signed Up Successfully!");
           // else MessageBox.Show("Error Encoutered While Signing up...");
        }
    }
}
