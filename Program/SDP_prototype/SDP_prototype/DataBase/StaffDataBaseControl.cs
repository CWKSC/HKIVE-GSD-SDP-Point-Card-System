using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_prototype
{
    class StaffDataBaseControl
    {
        public static string staffID = "";

        public static string staffAccountName;
        public static string staffPassword;
        public static string staffName;
        public static string staffEmail;
        public static string staffProfile;
        public static bool isEnglish;

        #region Get Data

        public static string GetData(string targetColumn)
        {
            return GetData_ByColumn("StaffID", staffID, targetColumn);
        }

        public static string GetData_ByColumn(string column, string value, string targetColumn)
        {
            return DataBaseControl.GetData("Staff", column, value, targetColumn);
        }

        public static void Load()
        {
            try
            {
                staffAccountName = GetData("StaffAccountName");
                staffPassword    = GetData("StaffPassword");
                staffName        = GetData("StaffName");
                staffEmail       = GetData("StaffEmail");
                staffProfile     = GetData("StaffProfile");
                isEnglish        = bool.Parse(GetData("isEnglish"));
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        #endregion


        #region Matcing One Column

        public static bool MatchingOneColumn(string columnName, string target)
        {
            return DataBaseControl.MatchingOneColumn_OfTable("Staff", columnName, target);
        }

        public static bool MatchingAccountName(string target)
        {
            return MatchingOneColumn("StaffAccountName", target);
        }
        public static bool MatchingPassword(string target)
        {
            return MatchingOneColumn("StaffPassword", target);
        }
        public static bool MatchingEmail(string target)
        {
            return MatchingOneColumn("StaffEmail", target);
        }


        #endregion


        #region Matching Two Column

        public static bool MatchingTwoColumn(string columnOne, string columnOneValue,
            string columnTwo, string columnTwoValue)
        {
            return DataBaseControl.MatchingTwoColumn_OfTable("Staff", columnOne, columnOneValue, columnTwo, columnTwoValue);
        }

        public static bool MatchingAccountPassword(string accountName, string password)
        {
            return MatchingTwoColumn("StaffAccountName", accountName, "StaffPassword", password);
        }
        public static bool MatchingEmailPassword(string email, string password)
        {
            return MatchingTwoColumn("StaffEmail", email, "StaffPassword", password);
        }

        #endregion


        #region Updata 

        public static void Updata_All()
        {
            Updata("PlayerAccountName", staffAccountName);
            Updata("PlayerPassword", staffPassword);
            Updata("PlayerName", staffName);
            Updata("PlayerEmail", staffEmail);
            Updata("PlayerProfile", staffProfile);
            Updata("isEnglish", isEnglish.ToString());
        }

        public static void Updata(string updataColumn, string updataValue)
        {
            DataBaseControl.Updata("Staff", "StaffID", staffID, updataColumn, updataValue);
        }

        public static void Updata_StaffAccountName(string updataValue)
        {
            staffAccountName = updataValue;
            Updata("StaffAccountName", updataValue);
        }
        public static void Updata_StaffPassword(string updataValue)
        {
            staffPassword = updataValue;
            Updata("StaffPassword", updataValue);
        }
        public static void Updata_StaffName(string updataValue)
        {
            staffName = updataValue;
            Updata("StaffName", updataValue);
        }
        public static void Updata_StaffEmail(string updataValue)
        {
            staffEmail = updataValue;
            Updata("StaffEmail", updataValue);
        }
        public static void Updata_StaffProfile(string updataValue)
        {
            staffProfile = updataValue;
            Updata("StaffProfile", updataValue);
        }
        public static void Updata_isEnglish(bool updataValue)
        {
            isEnglish = updataValue;
            string updateSql = "UPDATE Staff SET isEnglish = " + updataValue +
                " WHERE StaffID = \'" + staffID + "\' ;";
            DataBaseControl.ExecuteSql(updateSql);
        }

        #endregion

    }
}
