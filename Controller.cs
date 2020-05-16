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

        public DataTable SelectAllUnits()
        {
            string StoredProcedureName = StoredProcedures.SelectAllUnits;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable SelectProjectCities()
        {
            string StoredProcedureName = StoredProcedures.SelectProjectCities;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable SelectProjectsByCity(string City)
        {
            string StoredProcedureName = StoredProcedures.SelectProjectsByCity;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@City", City);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectUnitsByCity(string City)
        {
            string StoredProcedureName = StoredProcedures.SelectUnitsByCity;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@City", City);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectUnitsByProject(int PID)
        {
            string StoredProcedureName = StoredProcedures.SelectUnitsByProject;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", PID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectUnitsByPrice(int Price)
        {
            string StoredProcedureName = StoredProcedures.SelectUnitsByPrice;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Price", Price);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectUnitsByProjectAndPrice(int Price, int PID)
        {
            string StoredProcedureName = StoredProcedures.SelectUnitsByProjectAndPrice;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Price", Price);
            Parameters.Add("@PID", PID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectUnitsByPriceAndCity(int Price, string City)
        {
            string StoredProcedureName = StoredProcedures.SelectUnitsByPriceAndCity;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Price", Price);
            Parameters.Add("@City", City);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable CountCitApplicationsbyCitizen(int Citizen)
        {
            string StoredProcedureName = StoredProcedures.CountCitApplicationsbyCitizen;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Citizen", Citizen);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetUnsoldUnitsOfProject(int Project)
        {
            string StoredProcedureName = StoredProcedures.GetUnsoldUnitsOfProject;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Project", Project);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int CreateCitApplication(int Project, int Unit, int Citizen)
        {
            string StoredProcedureName = StoredProcedures.CreateCitApplication;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Project", Project);
            Parameters.Add("@Unit", Unit);
            Parameters.Add("@Citizen", Citizen);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetCitApplicationsByCitizen(int Citizen)
        {
            string StoredProcedureName = StoredProcedures.GetCitApplicationsByCitizen;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Citizen", Citizen);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetWaitingCitApplicationsByCitizen(int Citizen)
        {
            string StoredProcedureName = StoredProcedures.GetWaitingCitApplicationsByCitizen;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Citizen", Citizen);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetAcceptedCitApplicationsByCitizen(int Citizen)
        {
            string StoredProcedureName = StoredProcedures.GetAcceptedCitApplicationsByCitizen;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Citizen", Citizen);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetDoneCitApplicationsByCitizen(int Citizen)
        {
            string StoredProcedureName = StoredProcedures.GetDoneCitApplicationsByCitizen;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Citizen", Citizen);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int DeleteCitApplication(int Citizen, int Project, int Unit)
        {
            string StoredProcedureName = StoredProcedures.DeleteCitApplication;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Project", Project);
            Parameters.Add("@Unit", Unit);
            Parameters.Add("@Citizen", Citizen);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int ClaimCitApplication(int Citizen, int Project, int Unit)
        {
            string StoredProcedureName = StoredProcedures.ClaimCitApplication;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Project", Project);
            Parameters.Add("@Unit", Unit);
            Parameters.Add("@Citizen", Citizen);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int GiveUpCitApplication(int Citizen, int Project, int Unit)
        {
            string StoredProcedureName = StoredProcedures.GiveUpCitApplication;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Project", Project);
            Parameters.Add("@Unit", Unit);
            Parameters.Add("@Citizen", Citizen);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetUnitsOfCitApplicationsByProjectAndCitizen(int Citizen, int Project)
        {
            string StoredProcedureName = StoredProcedures.GetUnitsOfCitApplicationsByProjectAndCitizen;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Project", Project);
            Parameters.Add("@Citizen", Citizen);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectTransactionsByCitizen(int Citizen, int Project, int Unit, string Bank)
        {
            string StoredProcedureName = StoredProcedures.SelectTransactionsByCitizen;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Bank", Bank);
            Parameters.Add("@Project", Project);
            Parameters.Add("@Unit", Unit);
            Parameters.Add("@Citizen", Citizen);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectDependentsByCitizen(int Citizen)
        {
            string StoredProcedureName = StoredProcedures.SelectDependentsByCitizen;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Citizen", Citizen);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int AddDependent(string Name, int Citizen, DateTime Birth, int Salary, char Relationship)
        {
            string StoredProcedureName = StoredProcedures.AddDependent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", Name);
            Parameters.Add("@Citizen", Citizen);
            Parameters.Add("@Birth", Birth);
            Parameters.Add("@Salary", Salary);
            Parameters.Add("@Relationship", Relationship);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AlterDependentSalary(string Name, int Citizen, int Salary)
        {
            string StoredProcedureName = StoredProcedures.AlterDependentSalary;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", Name);
            Parameters.Add("@Citizen", Citizen);
            Parameters.Add("@Salary", Salary);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int RemoveDependent(string Name, int Citizen)
        {
            string StoredProcedureName = StoredProcedures.RemoveDependent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", Name);
            Parameters.Add("@Citizen", Citizen);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AlterDependentName(string Name, int Citizen, string newName)
        {
            string StoredProcedureName = StoredProcedures.AlterDependentName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", Name);
            Parameters.Add("@Citizen", Citizen);
            Parameters.Add("@newName", newName);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AlterDependentBirthdate(string Name, int Citizen, DateTime Birth)
        {
            string StoredProcedureName = StoredProcedures.AlterDependentBirthdate;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", Name);
            Parameters.Add("@Citizen", Citizen);
            Parameters.Add("@Birth", Birth);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        /////////////////////////////////////// Sign Up Queries /////////////////////////////////////////////
        
        public DataTable GetAccess(string Entity)
        {
            string StoredProcedureName = StoredProcedures.GetAccess;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Entity", Entity);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        
        public int SignUpBank(string name, string password, int transfees)
        {
            string StoredProcedureName = StoredProcedures.Insert_Bank;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            Parameters.Add("@Password", password);
            Parameters.Add("@TranFees", transfees);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int SignUpCompany(string name, string password, int NoCompleteProj,int NoCurrentProj, int Rating, int AvgProjectCost)
        {
            string StoredProcedureName = StoredProcedures.Insert_Company;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Password", password);
            Parameters.Add("@Name", name);
            Parameters.Add("@NoCompleteProj", NoCompleteProj);
            Parameters.Add("@NoCurrentProj", NoCurrentProj);
            Parameters.Add("@Rating", Rating);
            Parameters.Add("@AvgProjectCost", AvgProjectCost);
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

        public int SignUpEmployee(int id, string password, string firstname, string lastname, char sex, char type, DateTime birthdate, int NoCompleteProj, int NoCurrentProj)
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
            Parameters.Add("@NoCompleteProj", NoCompleteProj);
            Parameters.Add("@NoCurrentProj", NoCurrentProj);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int SignUpAdmin(string Name, string password)
        {
            string StoredProcedureName = StoredProcedures.Insert_Admin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", Name);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        /////////////////////////////////////// M Employee Functionalities  ///////////////////////////////////////////
        public DataTable GetAllProjectEmployees()
        {
            string StoredProcedureName = StoredProcedures.GetAllProjectEmployees;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetAllManagers()
        {
            string StoredProcedureName = StoredProcedures.GetAllManagers;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetAllHousingEmployeesNotInProject(int pid)
        {
            string StoredProcedureName = StoredProcedures.GetAllHousingEmployeesNotInProject;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", pid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectProjectByID(int pid)
        {
            string StoredProcedureName = StoredProcedures.SelectProjectByID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", pid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetNumberofComAppsByProject(int pid)
        {
            string StoredProcedureName = StoredProcedures.GetNumberofComAppsByProject;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", pid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }


        public DataTable SelectHousingEmpsByProject(int pid)
        {
            string StoredProcedureName = StoredProcedures.SelectHousingEmpsByProject;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", pid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetNumberofCitAppsByProject(int pid)
        {
            string StoredProcedureName = StoredProcedures.GetNumberofCitAppsByProject;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", pid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int AssignHousingEmployee(int pid, int eid)
        {
            string StoredProcedureName = StoredProcedures.AssignHousingEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", pid);
            Parameters.Add("@EID", eid);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetAllCompanies()
        {
            string StoredProcedureName = StoredProcedures.GetAllCompanies;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetAllEmployees()
        {
            string StoredProcedureName = StoredProcedures.GetAllEmployees;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable SelectProjectByCompany(int cid)
        {
            string StoredProcedureName = StoredProcedures.SelectProjectByCompany;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID", cid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectProjectByEmployee(int eid, string type)
        {
            char Etype;
            switch (type)
            {
                case "Housing": Etype = 'H'; break;
                case "Projects": Etype = 'P'; break;
                default: Etype = 'M'; break;
            }
            string StoredProcedureName = StoredProcedures.SelectProjectByEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@EID", eid);
            Parameters.Add("@EType", Etype);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public int Insert_Project(string city, int price, int mgrEmpID, int projEmpID)
        {
            string StoredProcedureName = StoredProcedures.Insert_Project;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@City", city);
            Parameters.Add("@MEmployeeID", mgrEmpID);
            Parameters.Add("@PricePRoom", price);
            Parameters.Add("@PEmployeeID", projEmpID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable SelectProjectByMEMPID(int ID, string statusFilter, string cityFilter)
        {
            char status;
            switch (statusFilter)
            {
                case "All Units Sold":
                    {
                        status = 'F';
                        break;
                    }
                case "Posted":
                    {
                        status = 'P';
                        break;
                    }
                case "Started":
                    {
                        status = 'S';
                        break;
                    }
                case "Launched":
                    {
                        status = 'L';
                        break;
                    }
                default:
                    {
                        status = 'A';
                        break;
                    }
            }
            string StoredProcedureName = StoredProcedures.SelectProjectByMEMPID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NationalID", ID);
            Parameters.Add("@PStatus", status);
            Parameters.Add("@City", cityFilter);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectAppByMEMPID(int ID, string statusFilter, int projectFilter, string client)
        {
            char status;
            switch (statusFilter)
            {
                case "Waiting":
                    {
                        status = 'W';
                        break;
                    }
                case "Accepted":
                    {
                        status = 'A';
                        break;
                    }
                case "Rejected":
                    {
                        status = 'R';
                        break;
                    }
                case "Done":
                    {
                        status = 'D';
                        break;
                    }
                default:
                    {
                        status = 'L';
                        break;
                    }
            }
            string StoredProcedureName;
            if (client == "Company")
            {
                if (ID == -1) //Admin
                    StoredProcedureName = StoredProcedures.SelectAllComApps;
                else
                    StoredProcedureName = StoredProcedures.SelectComAppByMEMPID;
            }
            else
            {
                if (ID == -1) //Admin
                    StoredProcedureName = StoredProcedures.SelectAllCitApps;
                else
                    StoredProcedureName = StoredProcedures.SelectCitAppByMEMPID;
            }

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            if (ID != -1)
                Parameters.Add("@NationalID", ID);
            Parameters.Add("@AStatus", status);
            Parameters.Add("@ProjectID", projectFilter);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectCitizenByID(int id)
        {
            string StoredProcedureName = StoredProcedures.SelectCitizenByID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NationalID", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectCompaniesByMEMPID(int id)
        {
            string StoredProcedureName = StoredProcedures.SelectCompaniesByMEMPID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NationalID", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectProjectByCompanyMEMPID(int pid, int cid)
        {
            string StoredProcedureName = StoredProcedures.SelectProjectByCompanyMEMPID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", pid);
            Parameters.Add("@CID", cid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectEmployeesByMEMPID(int id)
        {
            string StoredProcedureName = StoredProcedures.SelectEmployeesByMEMPID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NationalID", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectProjectByEmployeeMEMPID(int MID, int EID, string type)
        {
            char Etype;
            switch (type)
            {
                case "Housing": Etype = 'H'; break;
                case "Projects": Etype = 'P'; break;
                default: Etype = 'M'; break;
            }
            string StoredProcedureName = StoredProcedures.SelectProjectByEmployeeMEMPID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@MID", MID);
            Parameters.Add("@EID", EID);
            Parameters.Add("@EType", Etype);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectCompanyTransactionsByMEMPID(int MID, string bankName, int companyID)
        {
            string StoredProcedureName = StoredProcedures.SelectCompanyTransactionsByMEMPID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@MID", MID);
            Parameters.Add("@BankName", bankName);
            Parameters.Add("@CompanyID", companyID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectCitizenTransactionsByMEMPID(int MID, string bankName, int citizenID)
        {
            string StoredProcedureName = StoredProcedures.SelectCitizenTransactionsByMEMPID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@MID", MID);
            Parameters.Add("@BankName", bankName);
            Parameters.Add("@CitizenID", citizenID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectAllUnitsByProject(int pid, string statusFilter)
        {
            bool? status;
            switch (statusFilter)
            {
                case "Sold":
                    {
                        status = true;
                        break;
                    }
                case "Not Sold":
                    {
                        status = false;
                        break;
                    }
                default:
                    {
                        status = null;
                        break;
                    }
            }
            string StoredProcedureName = StoredProcedures.SelectAllUnitsByProject;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", pid);
            if (!(status is null))
                Parameters.Add("@UStatus", status);
            else
                Parameters.Add("@UStatus", DBNull.Value);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        /////////////////////////////////////// P Employee Functionalities ///////////////////////////////////////////
        public DataTable SelectProjectByPEMPID(int ID, string statusFilter, string cityFilter)
        {
            char status;
            switch (statusFilter)
            {
                case "All Units Sold":
                    {
                        status = 'F';
                        break;
                    }
                case "Posted":
                    {
                        status = 'P';
                        break;
                    }
                case "Started":
                    {
                        status = 'S';
                        break;
                    }
                case "Launched":
                    {
                        status = 'L';
                        break;
                    }
                default:
                    {
                        status = 'A';
                        break;
                    }
            }
            string StoredProcedureName = StoredProcedures.SelectProjectByPEMPID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NationalID", ID);
            Parameters.Add("@PStatus", status);
            Parameters.Add("@City", cityFilter);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
    


        public DataTable SelectAppByID(int ID, string statusFilter, int projectFilter, string type)
        {
            char status;
            switch (statusFilter)
            {
                case "Waiting":
                    {
                        status = 'W';
                        break;
                    }
                case "Accepted":
                    {
                        status = 'A';
                        break;
                    }
                case "Rejected":
                    {
                        status = 'R';
                        break;
                    }
                case "Done":
                    {
                        status = 'D';
                        break;
                    }
                default:
                    {
                        status = 'L';
                        break;
                    }
            }
            string StoredProcedureName;

            if (type == "Projects")
                StoredProcedureName = StoredProcedures.SelectComAppByPEMPID;
            else if (type == "Housing")
                StoredProcedureName = StoredProcedures.SelectCitAppByHEMPID;
            else
                StoredProcedureName = StoredProcedures.SelectComAppByCompanyID;


            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            if (type == "Company")
                Parameters.Add("@CID", ID);
            else
                Parameters.Add("@NationalID", ID);
            Parameters.Add("@AStatus", status);
            Parameters.Add("@ProjectID", projectFilter);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int ChangeComApplicationStatus(int projectID, string companyName, char newStatus)
        {
            string StoredProcedureName = StoredProcedures.ChangeComApplicationStatus;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ProjectID", projectID);
            Parameters.Add("@CompanyName", companyName);
            Parameters.Add("@NewStatus", newStatus);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable SelectAllBanks()
        {
            string StoredProcedureName = StoredProcedures.SelectAllBanks;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectTransByEMPID(int ID, string bankName, string clientName, string type)
        {
            string StoredProcedureName;
            if (type == "Projects")
                StoredProcedureName = StoredProcedures.SelectTransByPEMPID;
            else 
                StoredProcedureName = StoredProcedures.SelectTransByHEMPID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NationalID", ID);
            Parameters.Add("@BankName", bankName);
            if (type == "Projects")
                Parameters.Add("@CompanyName", clientName);
            else
                Parameters.Add("@CitizenName", clientName);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }


        /////////////////////////////////////// H Employee Functionalities ///////////////////////////////////////////

        public DataTable SelectProjectAdmin(string statusFilter, string cityFilter)
        {
            char status;
            switch (statusFilter)
            {
                case "All Units Sold":
                    {
                        status = 'F';
                        break;
                    }
                case "Posted":
                    {
                        status = 'P';
                        break;
                    }
                case "Started":
                    {
                        status = 'S';
                        break;
                    }
                case "Launched":
                    {
                        status = 'L';
                        break;
                    }
                default:
                    {
                        status = 'A';
                        break;
                    }
            }
            string StoredProcedureName = StoredProcedures.SelectProjectAdmin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PStatus", status);
            Parameters.Add("@City", cityFilter);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectProjectByHEMPID(int ID, string statusFilter, string cityFilter)
        {
            char status;
            switch (statusFilter)
            {
                case "All Units Sold":
                    {
                        status = 'F';
                        break;
                    }
                case "Posted":
                    {
                        status = 'P';
                        break;
                    }
                case "Started":
                    {
                        status = 'S';
                        break;
                    }
                case "Launched":
                    {
                        status = 'L';
                        break;
                    }
                default:
                    {
                        status = 'A';
                        break;
                    }
            }
            string StoredProcedureName = StoredProcedures.SelectProjectByHEMPID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NationalID", ID);
            Parameters.Add("@PStatus", status);
            Parameters.Add("@City", cityFilter);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable SelectUnitByHEMPID(int ID, string statusFilter, int projectFilter)
        {
            bool? status;
            switch (statusFilter)
            {
                case "Sold":
                    {
                        status = true;
                        break;
                    }
                case "Not Sold":
                    {
                        status = false;
                        break;
                    }
                default:
                    {
                        status = null;
                        break;
                    }
            }
            string StoredProcedureName = StoredProcedures.SelectUnitByHEMPID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NationalID", ID);
            if (!(status is null))
                Parameters.Add("@UStatus", status);
            else
                Parameters.Add("@UStatus", DBNull.Value);
            Parameters.Add("@ProjectID", projectFilter);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int ChangeCitApplicationStatus(int projectID, int unitID, int citizenID, char newStatus)
        {
            string StoredProcedureName = StoredProcedures.ChangeCitApplicationStatus;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ProjectID", projectID);
            Parameters.Add("@UnitID", unitID);
            Parameters.Add("@CitizenID", citizenID);
            Parameters.Add("@NewStatus", newStatus);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        /////////////////////////////////////// Company Functionalities ///////////////////////////////////////////
        public DataTable SelectProjectByCompanyID(int ID, string statusFilter, string cityFilter)
        {
            char status;
            switch (statusFilter)
            {
                case "All Units Sold":
                    {
                        status = 'F';
                        break;
                    }
                case "Posted":
                    {
                        status = 'P';
                        break;
                    }
                case "Started":
                    {
                        status = 'S';
                        break;
                    }
                case "Launched":
                    {
                        status = 'L';
                        break;
                    }
                default:
                    {
                        status = 'A';
                        break;
                    }
            }
            string StoredProcedureName = StoredProcedures.SelectProjectByCompanyID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID", ID);
            Parameters.Add("@PStatus", status);
            Parameters.Add("@City", cityFilter);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int AddUnitToProject(int pid, int numRooms)
        {
            string StoredProcedureName = StoredProcedures.AddUnitToProject;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", pid);
            Parameters.Add("@NumRooms", numRooms);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable SelectTransByCompanyID(int ID, string bankName)
        {
            string StoredProcedureName = StoredProcedures.SelectTransByCompanyID;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID", ID);
            Parameters.Add("@BankName", bankName);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        /// Admn functions \\\
        
        public int DeleteCitTransaction(long TID)
        {
            string StoredProcedureName = StoredProcedures.DeleteCitTransaction;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@TID", TID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteComTransaction(long TID)
        {
            string StoredProcedureName = StoredProcedures.DeleteComTransaction;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@TID", TID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetCitTransaction(long TID)
        {
            string StoredProcedureName = StoredProcedures.GetCitTransaction;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@TID", TID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetComTransaction(long TID)
        {
            string StoredProcedureName = StoredProcedures.GetComTransaction;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@TID", TID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int EditCitTransaction(long TID, string BankName, int EmployeeID, int CitizenID, int ProjectID, int UnitID, int Amount)
        {
            string StoredProcedureName = StoredProcedures.EditCitTransaction;
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

        public int EditComTransaction(long TID, string BankName, int EmployeeID, int CompanyID, int Amount)
        {
            string StoredProcedureName = StoredProcedures.EditComTransaction;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@TID", TID);
            Parameters.Add("@BankName", BankName);
            Parameters.Add("@EmployeeID", EmployeeID);
            Parameters.Add("@CompanyID", CompanyID);
            Parameters.Add("@Amount", Amount);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetAccessTable()
        {
            string StoredProcedureName = StoredProcedures.GetAccessTable;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public int EditAccess(string Entity, string Pass)
        {
            string StoredProcedureName = StoredProcedures.EditAccess;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Entity", Entity);
            Parameters.Add("@Pass", Pass);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable IsHighAdmin(string Username)
        {
            string StoredProcedureName = StoredProcedures.IsHighAdmin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetNumberofCompanyApplications(int cid)
        {
            string StoredProcedureName = StoredProcedures.GetNumberofCompanyApplications;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID", cid);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        
        public int ChangeComApplicationStatusByCompanyID(int pid, int cid, char newStatus)
        {
            string StoredProcedureName = StoredProcedures.ChangeComApplicationStatusByCompanyID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", pid);
            Parameters.Add("@CID", cid);
            Parameters.Add("@NewStatus", newStatus);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable SelectPostedProjects(int cid, int minRoomPrice, string city)
        {
            string StoredProcedureName = StoredProcedures.SelectPostedProjects;

            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID", cid);
            Parameters.Add("@MinRoomPrice", minRoomPrice);
            Parameters.Add("@City", city);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int ApplyToProject(int pid, int cid, int bid)
        {
            string StoredProcedureName = StoredProcedures.ApplyToProject;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", pid);
            Parameters.Add("@CID", cid);
            Parameters.Add("@BiddingPrice", bid);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int LaunchProject(int pid)
        {
            string StoredProcedureName = StoredProcedures.LaunchProject;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@PID", pid);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable SelectAdmins()
        {
            string StoredProcedureName = StoredProcedures.SelectAdmins;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public int AddAdmin(string Username, string Password)
        {
            string StoredProcedureName = StoredProcedures.AddAdmin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username);
            Parameters.Add("@Password", Password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteAdmin(string Username)
        {
            string StoredProcedureName = StoredProcedures.DeleteAdmin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int ChangeAdminPassword(string Username, string Password)
        {
            string StoredProcedureName = StoredProcedures.ChangeAdminPassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username);
            Parameters.Add("@Password", Password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int MakeHighAdmin(string Username)
        {
            string StoredProcedureName = StoredProcedures.MakeHighAdmin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", Username);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetAllCitizens()
        {
            string StoredProcedureName = StoredProcedures.GetAllCitizens;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public int DeleteComApplication(int Project, string Company)
        {
            string StoredProcedureName = StoredProcedures.DeleteComApplication;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Company", Company);
            Parameters.Add("@Project", Project);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteProject(int Project)
        {
            string StoredProcedureName = StoredProcedures.DeleteProject;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Project", Project);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int ChangeProjectStatus(int Project, string status)
        {
            char NewStatus = 'S';
            switch (status)
            {
                case "All Units Sold":
                    {
                        NewStatus = 'F';
                        break;
                    }
                case "Posted":
                    {
                        NewStatus = 'P';
                        break;
                    }
                case "Started":
                    {
                        NewStatus = 'S';
                        break;
                    }
                case "Launched":
                    {
                        NewStatus = 'L';
                        break;
                    }
            }

            string StoredProcedureName = StoredProcedures.ChangeProjectStatus;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NewStatus", NewStatus);
            Parameters.Add("@Project", Project);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int AssignCompany(int Project, int Company)
        {
            string StoredProcedureName = StoredProcedures.AssignCompany;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Company", Company);
            Parameters.Add("@Project", Project);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int UpdateProject(char Status, int ID, string City, int MEmployeeID, int PEmployeeID, int PricePRoom, int CompanyID, DateTime StartingDate, DateTime LaunchingDate)
        {
            string StoredProcedureName = StoredProcedures.UpdateProject;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Status", Status);
            Parameters.Add("@ID", ID);
            Parameters.Add("@City", City);
            Parameters.Add("@MEmployeeID", MEmployeeID);
            Parameters.Add("@PEmployeeID", PEmployeeID);
            Parameters.Add("@PricePRoom", PricePRoom);
            Parameters.Add("@CompanyID", CompanyID);
            Parameters.Add("@StartingDate", StartingDate);
            Parameters.Add("@LaunchingDate", LaunchingDate);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        
        public int DeleteUnit(int ProjectID, int ID)
        {
            string StoredProcedureName = StoredProcedures.DeleteUnit;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ProjectID", ProjectID);
            Parameters.Add("@ID", ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int UnsellUnit(int ProjectID, int ID)
        {
            string StoredProcedureName = StoredProcedures.UnsellUnit;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ProjectID", ProjectID);
            Parameters.Add("@ID", ID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable SelectAllManagerEmployees()
        {
            string StoredProcedureName = StoredProcedures.SelectAllManagerEmployees;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable SelectAllProjectsEmployees()
        {
            string StoredProcedureName = StoredProcedures.SelectAllProjectsEmployees;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable SelectAllHousingEmployees()
        {
            string StoredProcedureName = StoredProcedures.SelectAllHousingEmployees;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public int ChangeBiddingPrice(int Project, string Company, int Price)
        {
            string StoredProcedureName = StoredProcedures.ChangeBiddingPrice;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Project", Project);
            Parameters.Add("@Company", Company);
            Parameters.Add("@Price", Price);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteCitizen(int NationalID)
        {
            string StoredProcedureName = StoredProcedures.DeleteCitizen;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NationalID", NationalID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int UpdateCitizen(int OldID, int NationalID, string Password, string FirstName, string LastName, DateTime BirthDate, int Salary, char Sex, string CurentCity, bool OwnsCurrent, int CurrentAccommPrice)
        {
            string StoredProcedureName = StoredProcedures.UpdateCitizen;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@OldID", OldID);
            Parameters.Add("@NationalID", NationalID);
            Parameters.Add("@Password", Password);
            Parameters.Add("@FirstName", FirstName);
            Parameters.Add("@LastName", LastName);
            Parameters.Add("@BirthDate", BirthDate);
            Parameters.Add("@Salary", Salary);
            Parameters.Add("@Sex", Sex);
            Parameters.Add("@CurentCity", CurentCity);
            Parameters.Add("@OwnsCurrent", OwnsCurrent);
            Parameters.Add("@CurrentAccommPrice", CurrentAccommPrice);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetAllBanks()
        {
            string StoredProcedureName = StoredProcedures.GetAllBanks;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable SelectBankByName(string Name)
        {
            string StoredProcedureName = StoredProcedures.SelectBankByName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", Name);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int UpdateBank(string oldName, string Name, string Password, int TranFees)
        {
            string StoredProcedureName = StoredProcedures.UpdateBank;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@oldName", oldName);
            Parameters.Add("@Name", Name);
            Parameters.Add("@Password", Password);
            Parameters.Add("@TranFees", TranFees);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteBank(string Name)
        {
            string StoredProcedureName = StoredProcedures.DeleteBank;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", Name);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable SelectEmployeeByID(int NationalID)
        {
            string StoredProcedureName = StoredProcedures.SelectEmployeeByID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NationalID", NationalID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int UpdateEmployee(int oldID, int NationalID, string Password, string FirstName, string LastName, char Sex, char EType, DateTime StartDate, int NoCompleteProj, int NoCurrentProj)
        {
            string StoredProcedureName = StoredProcedures.UpdateEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@oldID", oldID);
            Parameters.Add("@NationalID", NationalID);
            Parameters.Add("@Password", Password);
            Parameters.Add("@FirstName", FirstName);
            Parameters.Add("@LastName", LastName);
            Parameters.Add("@Sex", Sex);
            Parameters.Add("@EType", EType);
            Parameters.Add("@StartDate", StartDate);
            Parameters.Add("@NoCompleteProj", NoCompleteProj);
            Parameters.Add("@NoCurrentProj", NoCurrentProj);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteEmployee(int NationalID)
        {
            string StoredProcedureName = StoredProcedures.DeleteEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NationalID", NationalID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable SelectCompanyByID(int CID)
        {
            string StoredProcedureName = StoredProcedures.SelectCompanyByID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID", CID);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public int UpdateCompanyRating(int CID, int Rating)
        {
            string StoredProcedureName = StoredProcedures.UpdateCompanyRating;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID", CID);
            Parameters.Add("@Rating", Rating);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int UpdateCompany(int CID, string Name, string Password, int NoCompleteProj, int NoCurrentProj, int Rating, int AvgProjectCost)
        {
            string StoredProcedureName = StoredProcedures.UpdateCompany;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID", CID);
            Parameters.Add("@Name", Name);
            Parameters.Add("@Password", Password);
            Parameters.Add("@NoCompleteProj", NoCompleteProj);
            Parameters.Add("@NoCurrentProj", NoCurrentProj);
            Parameters.Add("@AvgProjectCost", AvgProjectCost);
            Parameters.Add("@Rating", Rating);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteCompany(int CID)
        {
            string StoredProcedureName = StoredProcedures.DeleteCompany;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CID", CID);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
    }
}
