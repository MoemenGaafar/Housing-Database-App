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
    public partial class CitizenInfo : Form
    {
        private int ID;
        public CitizenInfo(int id)
        {
            ID = id;
            InitializeComponent();
        }

        private void CitizenInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
