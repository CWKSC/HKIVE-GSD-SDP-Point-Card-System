using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace SDP_prototype
{
    class DataBaseControl
    {
        public static DataTable dataTable = new DataTable();

        public static string connStr = "Provider=Microsoft.ACE.OLEDB.12.0; "
                                         + "Data Source = SDPfinalver.accdb;";

        public static void Load(DataTable dataTable, string sqlStr)
        {
            try
            {
                OleDbDataAdapter oleDbDataAdapter = new OleDbDataAdapter(sqlStr, connStr);

                dataTable.Clear();
                oleDbDataAdapter.Fill(dataTable);
                oleDbDataAdapter.Dispose();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        public static void Load(string sqlStr)
        {
            Load(dataTable, sqlStr);
        }

        #region Matching DataBase Column and value

        public static bool MatchingOneColumn_OfTable(string tableName, string column, string value)
        {
            // Check Exist in Table //
            DataBaseControl.Load(dataTable, "SELECT * FROM " + tableName +
                " WHERE StrComp(" + column + ", '" + value + "', 0) = 0 ; ");
            if (dataTable.Rows.Count != 0) return true;

            return false;
        }

        public static bool MatchingTwoColumn_OfTable(string tableName, 
            string columnOne, string columnOneValue, string columnTwo, string columnTwoValue)
        {
            // Check Exist in Table //
            DataBaseControl.Load(dataTable, "SELECT * FROM " + tableName +
                " WHERE StrComp(" + columnOne + ", '" + columnOneValue + "', 0) = 0 AND" +
                      " StrComp(" + columnTwo + ", '" + columnTwoValue + "', 0) = 0;");
            if (dataTable.Rows.Count != 0) return true;

            return false;
        }

        #endregion


        #region Matching One Column in Table

        #region Matching Account Name in All Table

        // Matching Account Name in All three Table
        public static bool MatchingAccountName_OfAllTable(string target)
        {

            if (PlayerDataBaseControl.MatchingPlayerAccountName(target)) return true;
            if (StaffDataBaseControl.MatchingAccountName(target)) return true;
            if (CSMDataBaseControl.MatchingAccountName(target)) return true;

            // Do not Exist in All Data Table
            return false;
        }

        #endregion

        #region Matching Email in Table

        // Matching Account Name in All three Table
        public static bool MatchingEmail_OfAllTable(string target)
        {

            if (PlayerDataBaseControl.MatchingEmail(target)) return true;
            if (StaffDataBaseControl.MatchingEmail(target)) return true;
            if (CSMDataBaseControl.MatchingEmail(target)) return true;

            // Do not Exist in All Data Table
            return false;
        }

        #endregion

        #endregion


        #region Matching Two Column in Table

        #region Matching Two Column in correspond Table

        // Matching Two Column in correspond Table //
        public static bool MatchingTwoColumn_OfStaffTable(string columnOne, string columnOneValue,
            string columnTwo, string columnTwoValue)
        {
            return MatchingTwoColumn_OfTable("Staff", columnOne, columnOneValue, columnTwo, columnTwoValue);
        }
        public static bool MatchingTwoColumn_OfCSMTable(string columnOne, string columnOneValue,
            string columnTwo, string columnTwoValue)
        {
            return MatchingTwoColumn_OfTable("CSM", columnOne, columnOneValue, columnTwo, columnTwoValue);
        }
        public static bool MatchingTwoColumn_OfPointCardTable(string columnOne, string columnOneValue,
            string columnTwo, string columnTwoValue)
        {
            return MatchingTwoColumn_OfTable("PointCard", columnOne, columnOneValue, columnTwo, columnTwoValue);
        }

        #endregion 

        #region Matching Account and Password in correspond Table 

        // Matching Account and Password in correspond Table //

        public static bool MatchingAccountPassword_InStaffTable(string accountName, string password)
        {
            return MatchingTwoColumn_OfStaffTable("StaffAccountName", accountName, "StaffPassword", password);
        }
        public static bool MatchingAccountPassword_InCSMTable(string accountName, string password)
        {
            return MatchingTwoColumn_OfCSMTable("CSMAccountName", accountName, "CSMPassword", password);
        }

        #endregion

        #region Matching Email and Password in correspond Table 

        // Matching Account and Password in correspond Table //
        
        public static bool MatchingEmailPassword_InStaffTable(string email, string password)
        {
            return MatchingTwoColumn_OfStaffTable("StaffEmail", email, "StaffPassword", password);
        }
        public static bool MatchingEmailPassword_InCSMTable(string email, string password)
        {
            return MatchingTwoColumn_OfCSMTable("CSMEmail", email, "CSMPassword", password);
        }

        #endregion

        #region Matching PointCardID and ActivePwd

        public static bool MatchingPointCardIDActivePwd_InPointCardTable(string pointCardID, string activePassword)
        {
            return MatchingTwoColumn_OfPointCardTable("PointCardID", pointCardID, "ActivePwd", activePassword);
        }

        #endregion

        #endregion


        #region Get Data

        public static string GetData(string table, string column, string value, string targetColumn)
        {
            try
            {
                string selectSql = "SELECT " + targetColumn + " FROM " + table +
                " WHERE " + column + " = '" + value + "' ;";
                Load(dataTable, selectSql);
                return dataTable.Rows[0][targetColumn].ToString();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return "";
            }
        }

        
        public static string GetData_OfStaffTable(string column, string value, string targetColumn)
        {
            return GetData("Staff", column, value, targetColumn);
        }
        public static string GetData_OfCSMTable(string column, string value, string targetColumn)
        {
            return GetData("CSM", column, value, targetColumn);
        }
        public static string GetData_OfGameTable(string column, string value, string targetColumn)
        {
            return GetData("Game", column, value, targetColumn);
        }
        public static string GetData_OfGSDWarZoneTable(string column, string value, string targetColumn)
        {
            return GetData("GSDWarZone", column, value, targetColumn);
        }
        public static string GetData_OfGSDF1RaceTable(string column, string value, string targetColumn)
        {
            return GetData("GSDF1Race", column, value, targetColumn);
        }
        public static string GetData_OfPointCardTable(string column, string value, string targetColumn)
        {
            return GetData("PointCard", column, value, targetColumn);
        }


        
        public static string GetData_OfPointCardTable_ByPointCardID(string value, string targetColumn)
        {
            return GetData_OfPointCardTable("PointCardID", value, targetColumn);
        }

        #endregion


        #region Execute SQL 

        public static void ExecuteSql(string sql)
        {
            OleDbConnection oleDbConnection = new OleDbConnection(connStr);
            OleDbCommand oleDbCommand = new OleDbCommand(sql, oleDbConnection);
            oleDbConnection.Open();
            oleDbCommand.ExecuteNonQuery();
            oleDbConnection.Close();
        }

        #endregion


        #region Updata

        public static void Updata(string table, string column, string value, string updataColumn, string updataValue)
        {
            string updateSql = "UPDATE " + table + " SET " + updataColumn + " = '" + updataValue + "'" +
                " WHERE " + column + " = '" + value + "' ;" ;
            ExecuteSql(updateSql);
        }

        #endregion



    }

}
