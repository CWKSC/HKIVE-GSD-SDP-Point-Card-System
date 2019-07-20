using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_prototype
{
    class CSMDataBaseControl
    {

        public static string CSMID = "";

        public static string CSMAccountName;
        public static string CSMPassword;
        public static string CSMName;
        public static string CSMEmail;
        public static string CSMProfile;
        public static bool isEnglish;

        #region Get Data

        public static string GetData(string targetColumn)
        {
            return GetData_ByColumn("CSMID", CSMID, targetColumn);
        }

        public static string GetData_ByColumn(string column, string value, string targetColumn)
        {
            return DataBaseControl.GetData("CSM", column, value, targetColumn);
        }

        public static void Load()
        {
            try
            {
                CSMAccountName = GetData("CSMAccountName");
                CSMPassword    = GetData("CSMPassword");
                CSMName        = GetData("CSMName");
                CSMEmail       = GetData("CSMEmail");
                CSMProfile     = GetData("CSMProfile");
                isEnglish      = bool.Parse(GetData("isEnglish"));
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
            return DataBaseControl.MatchingOneColumn_OfTable("CSM", columnName, target);
        }

        public static bool MatchingAccountName(string target)
        {
            return MatchingOneColumn("CSMAccountName", target);
        }
        public static bool MatchingPassword(string target)
        {
            return MatchingOneColumn("CSMPassword", target);
        }
        public static bool MatchingEmail(string target)
        {
            return MatchingOneColumn("CSMEmail", target);
        }


        #endregion


        #region Matching Two Column

        public static bool MatchingTwoColumn(string columnOne, string columnOneValue,
            string columnTwo, string columnTwoValue)
        {
            return DataBaseControl.MatchingTwoColumn_OfTable("CSM", columnOne, columnOneValue, columnTwo, columnTwoValue);
        }

        public static bool MatchingAccountPassword(string accountName, string password)
        {
            return MatchingTwoColumn("CSMAccountName", accountName, "CSMPassword", password);
        }
        public static bool MatchingEmailPassword(string email, string password)
        {
            return MatchingTwoColumn("CSMEmail", email, "CSMPassword", password);
        }

        #endregion


        #region Updata 

        public static void Updata_All()
        {
            Updata("CSMAccountName", CSMAccountName);
            Updata("CSMPassword", CSMPassword);
            Updata("CSMName", CSMName);
            Updata("CSMEmail", CSMEmail);
            Updata("CSMProfile", CSMProfile);
            Updata("isEnglish", isEnglish.ToString());
        }

        public static void Updata(string updataColumn, string updataValue)
        {
            DataBaseControl.Updata("CSM", "CSMID", CSMID, updataColumn, updataValue);
        }

        public static void Updata_CSMAccountName(string updataValue)
        {
            CSMAccountName = updataValue;
            Updata("CSMAccountName", updataValue);
        }
        public static void Updata_CSMPassword(string updataValue)
        {
            CSMPassword = updataValue;
            Updata("CSMPassword", updataValue);
        }
        public static void Updata_CSMName(string updataValue)
        {
            CSMName = updataValue;
            Updata("CSMName", updataValue);
        }
        public static void Updata_CSMEmail(string updataValue)
        {
            CSMEmail = updataValue;
            Updata("CSMEmail", updataValue);
        }
        public static void Updata_CSMProfile(string updataValue)
        {
            CSMProfile = updataValue;
            Updata("CSMProfile", updataValue);
        }
        public static void Updata_isEnglish(bool updataValue)
        {
            isEnglish = updataValue;
            string updateSql = "UPDATE CSM SET isEnglish = " + updataValue +
                " WHERE CSMID = \'" + CSMID + "\' ;";
            DataBaseControl.ExecuteSql(updateSql);
        }

        #endregion

    }
}
