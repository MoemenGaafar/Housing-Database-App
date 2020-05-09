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

        public static string SelectProjectByPEMPID = "SelectProjectByPEMPID";
        //INPUT: Projects Emp. NationalId - OUTPUT: All Projects assigned to him
    }
}