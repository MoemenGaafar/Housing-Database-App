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

namespace Housing_Database_Project.Company_Functionalities
{
    public partial class SetBiddingPrice : Form
    {
        private int PID, CID;
        private Controller controllerObj;
        public SetBiddingPrice(int pid, int cid)
        {
            controllerObj = new Controller();
            PID = pid;
            CID = cid;
            InitializeComponent();
        }

        private void button_Bid_Click(object sender, EventArgs e)
        {
            int r = controllerObj.ApplyToProject(PID, CID, Convert.ToInt32(textBox_BiddingPrice.Text.ToString()));
            if (r > 0) MessageBox.Show("Application Submitted Successfully!");
            else MessageBox.Show("Error Submitting Application..");
        }

        private void SetBiddingPrice_FormClosed(object sender, FormClosedEventArgs e)
        {
 
        }

        private void SetBiddingPrice_Load(object sender, EventArgs e)
        {
            label_ProjID.Text = PID.ToString();
        }
    }
}
