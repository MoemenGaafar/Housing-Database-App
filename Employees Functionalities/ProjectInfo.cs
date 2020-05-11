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
    public partial class ProjectInfo : Form
    {
        private int PID;
        public ProjectInfo(int pid)
        {
            PID = pid;
            InitializeComponent();
        }

        private void ProjectInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
