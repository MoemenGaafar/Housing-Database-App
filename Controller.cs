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
        public DataTable CheckPassword_Citizen(int id, string password)
        {
            string StoredProcedureName = StoredProcedures.CheckPassword_Citizen;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NationalId", id);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable CheckPassword_Employee(int id, string password)
        {
            string StoredProcedureName = StoredProcedures.CheckPassword_Employee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NationalId", id);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable CheckPassword_Company(int id, string password)
        {
            string StoredProcedureName = StoredProcedures.CheckPassword_Company;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID", id);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable CheckPassword_Bank(string name, string password)
        {
            string StoredProcedureName = StoredProcedures.CheckPassword_Bank;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable CheckPassword_Admin(string name, string password)
        {
            string StoredProcedureName = StoredProcedures.CheckPassword_Admin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        /////////////////////////////////////// Sign Up Queries /////////////////////////////////////////////
        //public int SignUpBank(string name, string password, int transfees)
        //{
        //    string query = "INSERT INTO Bank Values('" + name + "', '" + password + "', '" + transfees + "');";
        //    return dbMan.ExecuteNonQuery(query);
        //}

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
