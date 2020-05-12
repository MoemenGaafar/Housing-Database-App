﻿using DBapplication;
using Housing_Database_Project.Company_Functionalities;
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
        private DataTable dt;
        private string Type; //Admin, Employee, Manager, Company
        private Controller controllerObj;
        public ProjectInfo(int pid, string type)
        {
            controllerObj = new Controller();
            Type = type;
            PID = pid;
            InitializeComponent();
        }

        private void LoadInfo()
        {
            dt = controllerObj.GetAllProjectEmployees();
            comboBox_ProjectsEmp.DataSource = dt;
            comboBox_ProjectsEmp.DisplayMember = "Employee Name";
            comboBox_ProjectsEmp.ValueMember = "National ID";

            dt = controllerObj.GetAllManagers();
            comboBox_Manager.DataSource = dt;
            comboBox_Manager.DisplayMember = "Employee Name";
            comboBox_Manager.ValueMember = "National ID";

            dt = controllerObj.SelectProjectByID(PID);
            textBox_ID.Text = Convert.ToString(PID);
            textBox_City.Text = dt.Rows[0]["City"].ToString();
            comboBox_Manager.SelectedValue = dt.Rows[0]["Manager ID"].ToString();
            comboBox_ProjectsEmp.SelectedValue = dt.Rows[0]["Projects Employee ID"].ToString();

            label_Status.Text = dt.Rows[0]["Project Status"].ToString();
            textBox_RoomPrice.Text = dt.Rows[0]["Room Price"].ToString();

            DataTable data;

            switch (dt.Rows[0]["Project Status"].ToString())
            {
                case "Posted":
                    {
                        label_numApps.Visible = true;
                        label_numAppsBeta.Visible = true;
                        data = controllerObj.GetNumberofComAppsByProject(PID);
                        label_numApps.Text = data.Rows[0]["Number of Applications"].ToString();
                        break;
                    }
                case "Started":
                    {
                        label_Company.Visible = true;
                        textBox_Company.Visible = true;
                        textBox_Company.Text = dt.Rows[0]["Company Name"].ToString();

                        label_StartDate.Visible = true;
                        dateTimePicker_StartDate.Visible = true;
                        dateTimePicker_StartDate.Value = Convert.ToDateTime(dt.Rows[0]["Starting Date"]);
                        if (Type == "Company" || Type == "Admin") button_Launch.Visible = true;
                        break;
                    }
                case "Launched":
                    {
                        label_Company.Visible = true;
                        textBox_Company.Visible = true;
                        textBox_Company.Text = dt.Rows[0]["Company Name"].ToString();

                        label_StartDate.Visible = true;
                        dateTimePicker_StartDate.Visible = true;
                        dateTimePicker_StartDate.Value = Convert.ToDateTime(dt.Rows[0]["Starting Date"]);

                        label_numApps.Visible = true;
                        label_numAppsBeta.Visible = true;
                        data = controllerObj.GetNumberofCitAppsByProject(PID);
                        label_numApps.Text = data.Rows[0]["Number of Applications"].ToString();
                        label_numAppsBeta.Text = "Number of Citizen Applications";

                        button_ViewUnits.Visible = true;

                        label_LaunchDate.Visible = true;
                        dateTimePicker_LaunchDate.Visible = true;
                        dateTimePicker_LaunchDate.Value = Convert.ToDateTime(dt.Rows[0]["Launching Date"]);

                        label_HousingEmp.Visible = true;
                        listBox_HousingEmps.Visible = true;
                        data = controllerObj.SelectHousingEmpsByProject(PID);
                        listBox_HousingEmps.DataSource = data;
                        listBox_HousingEmps.DisplayMember = "Employee Name";
                        listBox_HousingEmps.ValueMember = "National ID";
                        listBox_HousingEmps.Refresh();

                        if (Type == "Manager" || Type == "Admin")
                        {
                            data = controllerObj.GetAllHousingEmployeesNotInProject(PID);
                            comboBox_HousingEmps.Visible = true;
                            button_AssignHousing.Visible = true;
                            comboBox_HousingEmps.DataSource = data;
                            comboBox_HousingEmps.DisplayMember = "Employee Name";
                            comboBox_HousingEmps.ValueMember = "National ID";
                        }
                        else if (Type == "Company" || Type == "Admin")
                        {
                            button_AddUnits.Visible = true;
                        }
                        break;
                    }
                default:
                    {
                        label_Company.Visible = true;
                        textBox_Company.Visible = true;
                        textBox_Company.Text = dt.Rows[0]["Company Name"].ToString();

                        label_StartDate.Visible = true;
                        dateTimePicker_StartDate.Visible = true;
                        dateTimePicker_StartDate.Value = Convert.ToDateTime(dt.Rows[0]["Starting Date"]);

                        button_ViewUnits.Visible = true;

                        label_LaunchDate.Visible = true;
                        dateTimePicker_LaunchDate.Visible = true;
                        dateTimePicker_LaunchDate.Value = Convert.ToDateTime(dt.Rows[0]["Launching Date"]);

                        label_HousingEmp.Visible = true;
                        listBox_HousingEmps.Visible = true;
                        data = controllerObj.SelectHousingEmpsByProject(PID);
                        listBox_HousingEmps.DataSource = data;
                        listBox_HousingEmps.DisplayMember = "Employee Name";
                        listBox_HousingEmps.ValueMember = "National ID";
                        listBox_HousingEmps.Refresh();
                        break;
                    }
            }

            if (Type == "Company")
            {
                label_numApps.Visible = false;
                label_numAppsBeta.Visible = false;
            }
        }

        private void ProjectInfo_Load(object sender, EventArgs e)
        {
            LoadInfo();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button_ViewUnits_Click(object sender, EventArgs e)
        {
            new EMP_ViewUnits(PID, Type).Show(this);
            this.Hide();
        }

        private void button_AssignHousing_Click(object sender, EventArgs e)
        {
            if (comboBox_HousingEmps.SelectedIndex != -1)
            {
                int r = controllerObj.AssignHousingEmployee(PID, Convert.ToInt32(comboBox_HousingEmps.SelectedValue));
                if (r > 0)
                {
                    MessageBox.Show("Housing Employee Assigned Successfully!");
                    DataTable data = controllerObj.SelectHousingEmpsByProject(PID);
                    listBox_HousingEmps.DataSource = data;
                    listBox_HousingEmps.DisplayMember = "Employee Name";
                    listBox_HousingEmps.ValueMember = "National ID";
                    listBox_HousingEmps.Refresh();
                    data = controllerObj.GetAllHousingEmployeesNotInProject(PID);
                    comboBox_HousingEmps.DataSource = data;
                    comboBox_HousingEmps.DisplayMember = "Employee Name";
                    comboBox_HousingEmps.ValueMember = "National ID";
                }
                else
                    MessageBox.Show("Error Assigning Employee..");
            }
            else
                MessageBox.Show("Please select a housing employee first!");
        }

        private void button_AddUnits_Click(object sender, EventArgs e)
        {
            new AddUnits(PID).Show();
        }

        private void button_Launch_Click(object sender, EventArgs e)
        {
            int r = controllerObj.LaunchProject(PID);

            if (r > 0)
            {
                LoadInfo();

            }
            else
            {
                MessageBox.Show("Error Launching Project..");
            }
        }
    }
}
