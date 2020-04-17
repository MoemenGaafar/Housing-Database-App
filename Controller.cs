using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        private DBManager dbMan; // A Reference of type DBManager 
                                 // (Initially NULL; NO DBManager Object is created yet)

        public Controller()
        {
            dbMan = new DBManager(); // Create the DBManager Object
        }

        //checks the username/password and returns the priviledges associated with this user
        //Returns 0 in case of error
        public bool CheckPassword_Citizen(int id, string password)
        {
            string query = "SELECT * FROM Citizen WHERE NationalId = '" + id + "' AND Password = '" + password + "';";
            object placeholder = dbMan.ExecuteScalar(query);
            if (placeholder == null) return false;
            else return true;
        }
        public bool CheckPassword_Employee(int id, string password)
        {
            string query = "SELECT * FROM Employee WHERE NationalId = '" + id + "' AND Password = '" + password + "';";
            object placeholder = dbMan.ExecuteScalar(query);
            if (placeholder == null) return false;
            else return true;
        }

        public bool CheckPassword_Company(int id, string password)
        {
            string query = "SELECT * FROM Company WHERE CID = '" + id + "' AND Password = '" + password + "';";
            object placeholder = dbMan.ExecuteScalar(query);
            if (placeholder == null) return false;
            else return true;
        }

        public bool CheckPassword_Bank(string name, string password)
        {
            string query = "SELECT * FROM Bank WHERE Name = '" + name + "' AND Password = '" + password + "';";
            object placeholder = dbMan.ExecuteScalar(query);
            if (placeholder == null) return false;
            else return true;
        }

        public bool CheckPassword_Admin(string name, string password)
        {
            string query = "SELECT * FROM Administrator WHERE Username = '" + name + "' AND Password = '" + password + "';";
            object placeholder = dbMan.ExecuteScalar(query);
            if (placeholder == null) return false;
            else return true;
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
