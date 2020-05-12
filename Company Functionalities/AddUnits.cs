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
    public partial class AddUnits : Form
    {
        private Controller controllerObj;
        private int ID;
        public AddUnits(int id)
        {
            controllerObj = new Controller();
            ID = id;
            InitializeComponent();
        }

        private void label_ProjID_Click(object sender, EventArgs e)
        {

        }

        private void AddUnits_Load(object sender, EventArgs e)
        {
            label_ProjID.Text = ID.ToString();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            int r, sumR = 0;
            if (textBox_NumUnits.Text != "" && textBox_NumRooms.Text != "")
            {
                for (int i = 0; i < Convert.ToInt32(textBox_NumUnits.Text); i++)
                {
                    r = controllerObj.AddUnitToProject(ID, Convert.ToInt32(textBox_NumRooms.Text));
                    sumR += r;
                }
                if (sumR == Convert.ToInt32(textBox_NumUnits.Text))
                    MessageBox.Show("Units Added Successfully!");
                else
                    MessageBox.Show("Error Adding Units..");
            }
            else
            {
                MessageBox.Show("Please Fill All Fields!");
            }
        }
    }
}
