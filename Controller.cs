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
        public int SignUpBank(string name, string password, int transfees)
        {
            string StoredProcedureName = StoredProcedures.Insert_Bank;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            Parameters.Add("@Password", password);
            Parameters.Add("@TranFees", transfees);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int SignUpCompany(string name, string password, int rating, int compproj, int currproj, int avgcost)
        {
            string StoredProcedureName = StoredProcedures.Insert_Company;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Password", password);
            Parameters.Add("@Name", name);
            Parameters.Add("@NoCompleteProj", compproj);
            Parameters.Add("@NoCurrentProj", currproj);
            Parameters.Add("@Rating", rating);
            Parameters.Add("@AvgProjectCost", avgcost);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int SignUpCitizen(int id, string password, string firstname, string lastname, char sex, int salary,
            bool ownscurrent, string city, DateTime birthdate, int currentprice)
        {
            string StoredProcedureName = StoredProcedures.Insert_Citizen;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NationalId", id);
            Parameters.Add("@Password", password);
            Parameters.Add("@FirstName", firstname);
            Parameters.Add("@LastName", lastname);
            Parameters.Add("@BirthDate", birthdate);
            Parameters.Add("@Salary", salary);
            Parameters.Add("@Sex", sex);
            Parameters.Add("@CurentCity", city);
            Parameters.Add("@OwnsCurrent", ownscurrent);
            Parameters.Add("@CurrentAccommPrice", currentprice);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int SignUpEmployee(int id, string password, string firstname, string lastname, char sex, int compproj,
             int currproj, char type, DateTime birthdate)
        {
            string StoredProcedureName = StoredProcedures.Insert_Employee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NationalId", id);
            Parameters.Add("@Password", password);
            Parameters.Add("@FirstName", firstname);
            Parameters.Add("@LastName", lastname);
            Parameters.Add("@StartDate", birthdate);
            Parameters.Add("@EType", type);
            Parameters.Add("@Sex", sex);
            Parameters.Add("@NoCompleteProj", compproj);
            Parameters.Add("@NoCurrentProj", currproj);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
