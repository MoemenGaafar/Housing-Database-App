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

        public DataTable GetTransactionFee(string name)
        {
            string StoredProcedureName = StoredProcedures.GetTransactionFee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int ChangeTransactionFee(string name, int fee)
        {
            string StoredProcedureName = StoredProcedures.ChangeTransactionFee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            Parameters.Add("@Fee", fee);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int ChangePassword_Citizen(int id, string password)
        {
            string StoredProcedureName = StoredProcedures.ChangePassword_Citizen;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NationalId", id);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int ChangePassword_Employee(int id, string password)
        {
            string StoredProcedureName = StoredProcedures.ChangePassword_Employee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NationalId", id);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int ChangePassword_Company(int id, string password)
        {
            string StoredProcedureName = StoredProcedures.ChangePassword_Company;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID", id);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int ChangePassword_Bank(string name, string password)
        {
            string StoredProcedureName = StoredProcedures.ChangePassword_Bank;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int ChangePassword_Admin(string name, string password)
        {
            string StoredProcedureName = StoredProcedures.ChangePassword_Admin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Add_CitTransaction(long TID, string BankName, int EmployeeID, int CitizenID, int ProjectID, int UnitID, int Amount)
        {
            string StoredProcedureName = StoredProcedures.Add_CitTransaction;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@TID", TID);
            Parameters.Add("@BankName", BankName);
            Parameters.Add("@EmployeeID", EmployeeID);
            Parameters.Add("@CitizenID", CitizenID);
            Parameters.Add("@ProjectID", ProjectID);
            Parameters.Add("@UnitID", UnitID);
            Parameters.Add("@Amount", Amount);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Add_ComTransaction(long TID, string BankName, int EmployeeID, int CompanyID, int Amount)
        {
            string StoredProcedureName = StoredProcedures.Add_ComTransaction;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@TID", TID);
            Parameters.Add("@BankName", BankName);
            Parameters.Add("@EmployeeID", EmployeeID);
            Parameters.Add("@CompanyID", CompanyID);
            Parameters.Add("@Amount", Amount);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetAllProjectIDs()
        {
            string StoredProcedureName = StoredProcedures.GetAllProjectIDs;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable SelectAllCompanies()
        {
            string StoredProcedureName = StoredProcedures.SelectAllCompanies;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable SelectAllCompanyBankTransactions(string name)
        {
            string StoredProcedureName = StoredProcedures.SelectAllCompanyBankTransactions;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable SelectCompanyBankTransactions(string name, int CID)
        {
            string StoredProcedureName = StoredProcedures.SelectCompanyBankTransactions;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            Parameters.Add("@CID", CID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable SelectAllCitizenBankTransactions(string name)
        {
            string StoredProcedureName = StoredProcedures.SelectAllCitizenBankTransactions;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable SelectCitizenBankTransactions(string name, int CID)
        {
            string StoredProcedureName = StoredProcedures.SelectCitizenBankTransactions;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            Parameters.Add("@CID", CID);
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
