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
        //INPUT: Bank name - Output: all ComTransaction attributes with company name
        public static string SelectCompanyBankTransactions = "SelectCompanyBankTransactions";
        //INPUT: Bank name and Company ID - Output: all ComTransaction attributes with company name
        public static string SelectAllCitizenBankTransactions = "SelectAllCitizenBankTransactions";
        //INPUT: Bank name - Output: all ComTransaction attributes
        public static string SelectCitizenBankTransactions = "SelectCitizenBankTransactions";
        //INPUT: Bank name and Citizen ID- Output: all ComTransaction attributes



        public static string SelectAllUnits = "SelectAllUnits";
        //INPUT: none - OUTPUT: All available Unit attributes 
        public static string SelectUnitsByProject = "SelectUnitsByProject";
        //INPUT: project # - OUTPUT: All available Unit attributes
        public static string SelectUnitsByPrice = "SelectUnitsByPrice";
        //INPUT: max price - OUTPUT: All available Unit attributes
        public static string SelectUnitsByProjectAndPrice = "SelectUnitsByProjectAndPrice";
        //INPUT: project # and max price - OUTPUT: All available Unit attributes
        public static string CountCitApplicationsbyCitizen = "CountCitApplicationsbyCitizen";
        //INPUT: CitizenID - OUTPUT: all CitApplication attributes and price
        public static string GetUnsoldUnitsOfProject = "GetUnsoldUnitsOfProject"; 
        //INPUT: ProjectID - OUTPUT: unitID of unsold units 
        public static string CreateCitApplication = "CreateCitApplication";
        //INPUT: all CitApplication attributes - OUTPUT: none
        public static string GetCitApplicationsByCitizen = "GetCitApplicationsByCitizen";
        //INPUT: CitizenID - OUTPUT: all CitApplication attributes and price
        public static string GetWaitingCitApplicationsByCitizen = "GetWaitingCitApplicationsByCitizen";
        //INPUT: CitizenID - OUTPUT: all waiting CitApplication attributes and price 
        public static string GetAcceptedCitApplicationsByCitizen = "GetAcceptedCitApplicationsByCitizen";
        //INPUT: CitizenID - OUTPUT: all accepted CitApplication attributes and price
        public static string GetDoneCitApplicationsByCitizen = "GetDoneCitApplicationsByCitizen";
        //INPUT: CitizenID - OUTPUT: all done CitApplication attributes and price
        public static string DeleteCitApplication = "DeleteCitApplication";
        //INPUT: CitizenID, project ID, unit ID - OUTPUT: none
        public static string ClaimCitApplication = "ClaimCitApplication";
        //INPUT: CitizenID, project ID, unit ID - OUTPUT: none (converts application status to 'D')
        public static string GiveUpCitApplication = "GiveUpCitApplication";
        //INPUT: CitizenID, project ID, unit ID - OUTPUT: none (converts application status to 'R')
        public static string GetUnitsOfCitApplicationsByProjectAndCitizen = "GetUnitsOfCitApplicationsByProjectAndCitizen"; 
        //INPUT: CitizenID, ProjectID - OUTPUT: UnitID
        public static string SelectTransactionsByCitizen = "SelectTransactionsByCitizen";
        //INPUT: CitizenID, project ID, unit ID, Bank name - OUTPUT: all transaction attributes
        public static string SelectDependentsByCitizen = "SelectDependentsByCitizen";
        //INPUT: CitizenID - OUTPUT: all dependent attributes 
        public static string AddDependent = "AddDependent";
        //INPUT: all dependent attributes - OUTPUT: none
        public static string AlterDependentSalary = "AlterDependentSalary";
        //INPUT: citizen ID, Dependent Name, Salary - OUTPUT: none
        public static string RemoveDependent = "RemoveDependent";
        //INPUT: citizen ID, Dependent Name - OUTPUT: none
        public static string AlterDependentName = "AlterDependentName";
        //INPUT: citizen ID, Dependent Name, newName - OUTPUT: none
        public static string AlterDependentBirthdate = "AlterDependentBirthdate";
        //INPUT: citizen ID, Dependent Name, Birthdate - OUTPUT: none
    }
}