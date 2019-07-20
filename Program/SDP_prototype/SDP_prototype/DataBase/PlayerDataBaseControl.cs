using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_prototype
{
    class PlayerDataBaseControl
    {
        
        public static string playerID = "";

        public static string playerAccountName;
        public static string playerPassword;
        public static string playerName;
        public static string playerEmail;
        public static string playerProfile;
        public static int playerGoldCoins;
        public static bool isEnglish;

        #region Get Data

        public static string GetData(string targetColumn)
        {
            return GetData_ByColumn("PlayerID", playerID, targetColumn);
        }

        public static string GetData_ByColumn(string column, string value, string targetColumn)
        {
            return DataBaseControl.GetData("Player", column, value, targetColumn);
        }

        public static void Load()
        {
            try
            {
                playerAccountName = GetData("PlayerAccountName");
                playerPassword    = GetData("PlayerPassword");
                playerName        = GetData("PlayerName");
                playerEmail       = GetData("PlayerEmail");
                playerProfile     = GetData("PlayerProfile");
                playerGoldCoins   = int.Parse(GetData("PlayerGoldCoins"));
                isEnglish         = bool.Parse(GetData("isEnglish"));
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        public static void Load_PlayerID_By_PlayerAccountName()
        {
            playerID = GetData_ByColumn("PlayerAccountName", playerAccountName, "PlayerID");
        }

        public static void Load_PlayerID_By_PlayerAccountName(string playerAccountName)
        {
            playerID = GetData_ByColumn("PlayerAccountName", playerAccountName, "PlayerID");
        }

        #endregion


        #region Matcing One Column

        public static bool MatchingOneColumn(string columnName, string target)
        {
            return DataBaseControl.MatchingOneColumn_OfTable("Player", columnName, target);
        }

        public static bool MatchingPlayerAccountName(string target)
        {
            return MatchingOneColumn("PlayerAccountName", target);
        }
        public static bool MatchingPassword(string target)
        {
            return MatchingOneColumn("PlayerPassword", target);
        }
        public static bool MatchingEmail(string target)
        {
            return MatchingOneColumn("PlayerEmail", target);
        }
        

        #endregion


        #region Matching Two Column

        public static bool MatchingTwoColumn(string columnOne, string columnOneValue,
            string columnTwo, string columnTwoValue)
        {
            return DataBaseControl.MatchingTwoColumn_OfTable("Player", columnOne, columnOneValue, columnTwo, columnTwoValue);
        }

        public static bool MatchingAccountPassword(string accountName, string password)
        {
            return MatchingTwoColumn("PlayerAccountName", accountName, "PlayerPassword", password);
        }
        public static bool MatchingEmailPassword(string email, string password)
        {
            return MatchingTwoColumn("PlayerEmail", email, "PlayerPassword", password);
        }

        #endregion


        #region Updata 

        public static void Updata_All()
        {
            Updata("PlayerAccountName", playerAccountName);
            Updata("PlayerPassword", playerPassword);
            Updata("PlayerName", playerName);
            Updata("PlayerEmail", playerEmail);
            Updata("PlayerProfile", playerProfile);
            Updata("PlayerGoldCoins", playerGoldCoins.ToString());
            Updata("isEnglish", isEnglish.ToString());
        }

        public static void Updata(string updataColumn, string updataValue)
        {
            DataBaseControl.Updata("Player", "PlayerID", playerID, updataColumn, updataValue);
        }

        public static void Updata_PlayerAccountName(string updataValue)
        {
            playerAccountName = updataValue;
            Updata("PlayerAccountName", updataValue);
        }
        public static void Updata_PlayerPassword(string updataValue)
        {
            playerPassword = updataValue;
            Updata("PlayerPassword", updataValue);
        }
        public static void Updata_PlayerName(string updataValue)
        {
            playerName = updataValue;
            Updata("PlayerName", updataValue);
        }
        public static void Updata_PlayerEmail(string updataValue)
        {
            playerEmail = updataValue;
            Updata("PlayerEmail", updataValue);
        }
        public static void Updata_PlayerProfile(string updataValue)
        {
            playerProfile = updataValue;
            Updata("PlayerProfile", updataValue);
        }
        public static void Updata_PlayerGoldCoins(int updataValue)
        {
            playerGoldCoins = updataValue;
            Updata("PlayerGoldCoins", updataValue.ToString());
        }
        public static void Updata_isEnglish(bool updataValue)
        {
            isEnglish = updataValue;
            string updateSql = "UPDATE Player SET isEnglish = " + updataValue +
                " WHERE PlayerID = \'" + playerID + "\' ;";
            DataBaseControl.ExecuteSql(updateSql);
        }

        #endregion


        #region Insert

        public static void Insert(string playerAccountName, string playerPassword, string playerEmail)
        {
            string insertSql = "INSERT INTO Player(PlayerID, PlayerAccountName, PlayerPassword, PlayerEmail)" +
                " VALUES( \"P" + (SystemDataBaseControl.Get_PlayerNum() + 1).ToString().PadLeft(7, '0') + "\", \"" + playerAccountName + "\", \"" + playerPassword + "\", \"" + playerEmail + "\");";
            DataBaseControl.ExecuteSql(insertSql);

            SystemDataBaseControl.Updata_PlayerNum_PlusOne();
        }

        #endregion

    }
}
