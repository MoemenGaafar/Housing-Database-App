using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBapplication
{
    public class StoredProcedures
    {
        public static string CheckPassword_Citizen = "CheckPassword_Citizen";
        //INPUT: National ID, Password - OUTPUT: All
        public static string CheckPassword_Employee = "CheckPassword_Employee";
        //INPUT: National ID, Password - OUTPUT: All
        public static string CheckPassword_Company = "CheckPassword_Company";
        //INPUT: Company ID, Password - OUTPUT: All
        public static string CheckPassword_Bank = "CheckPassword_Bank";
        //INPUT: Name, Password - OUTPUT: All
        public static string CheckPassword_Admin = "CheckPassword_Admin";
        //INPUT: Username, Password - OUTPUT: All

        public static string Insert_Citizen = "Insert_Citizen";
        //Input: All Parameters - OUTPUT: Inserts and returns more than 0 if successful
        public static string Insert_Bank = "Insert_Bank";
        //Input: All Parameters - OUTPUT: Inserts and returns more than 0 if successful
        public static string Insert_Company = "Insert_Company";
        //Input: All Parameters - OUTPUT: Inserts and returns more than 0 if successful
        public static string Insert_Employee = "Insert_Employee";
        //Input: All Parameters - OUTPUT: Inserts and returns more than 0 if successful

        public static string ChangePassword_Citizen = "ChangePassword_Citizen";
        //INPUT: National ID, Password - OUTPUT: none
        public static string ChangePassword_Employee = "ChangePassword_Employee";
        //INPUT: National ID, Password - OUTPUT: none
        public static string ChangePassword_Company = "ChangePassword_Company";
        //INPUT: Company ID, Password - OUTPUT: none
        public static string ChangePassword_Bank = "ChangePassword_Bank";
        //INPUT: Name, Password - OUTPUT: none
        public static string ChangePassword_Admin = "ChangePassword_Admin";
        //INPUT: Username, Password - OUTPUT: none

        public static string GetTransactionFee = "GetTransactionFee";
        //INPUT: Name - OUTPUT: Transaction Fee
        public static string ChangeTransactionFee = "ChangeTransactionFee";
        //INPUT: Name, Fee - Output: None
        public static string Add_CitTransaction = "Add_CitTransaction";
        //INPUT:all CitTransaction attributes - Output: None
        public static string Add_ComTransaction = "Add_ComTransaction";
        //INPUT:all ComTransaction attributes - Output: None
        public static string GetAllProjectIDs = "GetAllProjectIDs";
        //INPUT:none - Output: Project IDs
        public static string SelectAllCompanies = "SelectAllCompanies";
        //INPUT:none - Output: CID, Name
        public static string SelectAllCompanyBankTransactions = "SelectAllCompanyBankTransactions";
        //INPUT: Bank name - Output: all ComTransaction attributes
        public static string SelectCompanyBankTransactions = "SelectCompanyBankTransactions";
        //INPUT: Bank name and Company ID - Output: all ComTransaction attributes
        public static string SelectAllCitizenBankTransactions = "SelectAllCitizenBankTransactions";
        //INPUT: Bank name - Output: all ComTransaction attributes
        public static string SelectCitizenBankTransactions = "SelectCitizenBankTransactions";
        //INPUT: Bank name and Citizen ID- Output: all ComTransaction attributes

        public static string SelectProjectByPEMPID = "SelectProjectByPEMPID";
        //INPUT: P Employee National ID, Filters - OUTPUT: All Projects assigned to him
        public static string SelectComAppByPEMPID = "SelectComAppByPEMPID";
        //INPUT: Projects Emp. NationalId - OUTPUT: All company applications associated with him
        public static string ChangeComApplicationStatus = "ChangeComApplicationStatus";
        //INPUT: Project ID, Company Name, New Application Status - OUTPUT: Updates Status
        public static string SelectAllBanks = "SelectAllBanks";
        //INPUT: none - OUTPUT: All
        public static string SelectTransByPEMPID = "SelectTransByPEMPID";
        //INPUT: Projects Emp. NationalId, Filters - OUTPUT: All company transactions associated with him

        public static string SelectProjectByHEMPID = "SelectProjectByHEMPID";
        //INPUT: H Employee National ID, Filters - OUTPUT: All Projects assigned to him
        public static string SelectUnitByHEMPID = "SelectUnitByHEMPID";
        //INPUT: H Employee National ID, Filters - OUTPUT: All Units assigned to him
        public static string SelectCitAppByHEMPID = "SelectCitAppByHEMPID";
        //INPUT: H Emp. NationalId - OUTPUT: All citizen applications associated with him
        public static string ChangeCitApplicationStatus = "ChangeCitApplicationStatus";
        //INPUT: Project ID, Unit ID, Citizen ID New Application Status - OUTPUT: Updates Status
        public static string SelectTransByHEMPID = "SelectTransByHEMPID";
        //INPUT: H Emp. NationalId, Filters - OUTPUT: All citizen transactions associated with him

        public static string GetAllProjectEmployees = "GetAllProjectEmployees";
        //INPUT:none - Output: Project Employees Info
        public static string Insert_Project = "Insert_Project";
        //INPUT: City, RoomPrice, Project Emp ID - Output: none
        public static string GetAllCompanies = "GetAllCompanies";
        //INPUT:none - Output: Everything
        public static string SelectProjectByCompany = "SelectProjectByCompany";
        //INPUT: CID - Output: ProjectIDs related to it
        public static string GetAllEmployees = "GetAllEmployees";
        //INPUT:none - Output: Everything
        public static string SelectProjectByEmployee = "SelectProjectByEmployee";
        //INPUT: Employee NationalID and type - Output: ProjectIDs related to it
    //    public static string SelectComTransByMEMPID = "SelectComTransByMEMPID";
        //INPUT: H Employee National ID, Filters - OUTPUT: All Projects assigned to him
     //   public static string SelectCitTransByMEMPID = "SelectCitTransByMEMPID";
        //INPUT: H Employee National ID, Filters - OUTPUT: All Projects assigned to him
        public static string SelectProjectByMEMPID = "SelectProjectByMEMPID";
        //INPUT: M Employee National ID, Filters - OUTPUT: All Projects assigned to him
        public static string SelectAllComApps = "SelectAllComApps";
        //INPUT: Project ID, Status - Output: All associated ComApps
        public static string SelectAllCitApps = "SelectAllCitApps";
        //INPUT: Project ID, Status, M Emp ID - Output: All associated ComApps
        public static string SelectComAppByMEMPID = "SelectComAppByMEMPID";
        //INPUT: Project ID, Status, M Emp ID - Output: All associated CitApps
        public static string SelectCitAppByMEMPID = "SelectCitAppByMEMPID";
        //INPUT: Project ID, Status, M Emp ID - Output: All associated CitApps
    }
}