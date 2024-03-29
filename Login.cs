﻿using DBapplication;
using Housing_Database_Project.Employees_Functionalities;
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
    public partial class Login : Form
    {
        private Controller controllerObj;
        public Login()
        {
            InitializeComponent();
            controllerObj = new Controller();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            DataTable found = null;

            if (!(radioButton_Bank.Checked || radioButton_Citizen.Checked || radioButton_Company.Checked || radioButton_Employee.Checked || radioButton_Admin.Checked)
                 || TxtBx_username.Text == "" || TxtBx_pass.Text == "")
            {
                MessageBox.Show("Please Enter All Required Data and Pick an Account Type");
                return;
            }

            try
            {
                if (radioButton_Citizen.Checked)
                {
                    found = controllerObj.CheckPassword_Citizen(Convert.ToInt32(TxtBx_username.Text), TxtBx_pass.Text);
                    if (found != null)
                    {
                        CitizenFunctionalities CF = new CitizenFunctionalities(Convert.ToInt32(TxtBx_username.Text));
                        CF.Show(this);
                        this.Hide();
                    }
                }
                else if (radioButton_Employee.Checked)
                {
                    found = controllerObj.CheckPassword_Employee(Convert.ToInt32(TxtBx_username.Text), TxtBx_pass.Text);
                    if (found != null)
                    {
                        switch (Convert.ToChar(found.Rows[0]["EType"])){
                            case 'M':
                                {
                                    new ManagerEmployeeFunctionalities(Convert.ToInt32(found.Rows[0]["NationalId"])).Show(this);
                                    break;
                                }
                            case 'P':
                                {
                                    new ProjectsEmployeeFunctionalities(Convert.ToInt32(found.Rows[0]["NationalId"])).Show(this);
                                    break;
                                }
                            case 'H':
                                {
                                    new HousingEmployeeFunctionalities(Convert.ToInt32(found.Rows[0]["NationalId"])).Show(this);
                                    break;
                                }
                        }
                        this.Hide();
                    }
                }
                else if (radioButton_Company.Checked)
                {
                    found = controllerObj.CheckPassword_Company(Convert.ToInt32(TxtBx_username.Text), TxtBx_pass.Text);
                    if (found != null)
                    {
                        new CompanyFunctionalities(Convert.ToInt32(found.Rows[0]["CID"])).Show(this);
                        this.Hide();
                    }
                }
                else if (radioButton_Bank.Checked)
                {
                    found = controllerObj.CheckPassword_Bank(TxtBx_username.Text, TxtBx_pass.Text);
                    if (found != null)
                    {
                        BankFunctionalities BF = new BankFunctionalities(TxtBx_username.Text);
                        BF.Show(this);
                        this.Hide();
                    }
                }
                else if (radioButton_Admin.Checked)
                {
                    found = controllerObj.CheckPassword_Admin(TxtBx_username.Text, TxtBx_pass.Text);
                    if (found != null)
                    {
                        int isHigh = Convert.ToInt32(controllerObj.IsHighAdmin(TxtBx_username.Text).Rows[0][0]); 
                        AdminFunctionalities AF = new AdminFunctionalities(isHigh);
                        AF.Show(this);
                        this.Hide();
                    }
                }

                if(found == null) MessageBox.Show("WRONG USERNAME OR PASSWORD!!!");
                
            }
            catch
            {
                MessageBox.Show("WRONG USERNAME OR PASSWORD!!!");
            }
            TxtBx_pass.Clear();
            TxtBx_username.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_SignUp_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
        }

        
    }
}
