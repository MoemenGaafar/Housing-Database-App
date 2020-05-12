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
    public partial class CitizenInfo : Form
    {
        private int ID;
        private DataTable dt;
        private Controller controllerObj;
        public CitizenInfo(int id)
        {
            ID = id;
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void CitizenInfo_Load(object sender, EventArgs e)
        {
            dt = controllerObj.SelectCitizenByID(ID);
            TxtBx_Nationalid.Text = Convert.ToString(dt.Rows[0]["NationalID"]);
            textBox_Firstname.Text = Convert.ToString(dt.Rows[0]["FirstName"]);
            textBox_Lastname.Text = Convert.ToString(dt.Rows[0]["LastName"]);
            textBox_City.Text = Convert.ToString(dt.Rows[0]["CurentCity"]);
            textBox_PriceAccom.Text = Convert.ToString(dt.Rows[0]["CurrentAccommPrice"]);
            textBox_Salary.Text = Convert.ToString(dt.Rows[0]["Salary"]);
            dateTimePicker1.Value = Convert.ToDateTime(dt.Rows[0]["BirthDate"]);

            if (Convert.ToChar(dt.Rows[0]["Sex"]) == 'M') radioButton_Male.Checked = true;
            else radioButton_Female.Checked = true;

            if (Convert.ToBoolean(dt.Rows[0]["OwnsCurrent"])) radioButton_Yes.Checked = true;
            else radioButton_No.Checked = true;
        }

        private void button_ViewDeps_Click(object sender, EventArgs e)
        {
            new CitizenDependents("Employee", ID).Show(this);
            this.Hide();
        }
    }
}
