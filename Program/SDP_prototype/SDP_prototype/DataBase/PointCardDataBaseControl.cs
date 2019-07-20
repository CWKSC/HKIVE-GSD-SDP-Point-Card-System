using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_prototype
{
    class PointCardDataBaseControl
    {

        public static string pointCardID;

        public static string activePwd;
        public static int retailValue;
        public static int goldCoins;
        public static int remainLuckyDrawTimes;
        public static string status;
        public static string generationDate;

        #region Get Data

        public static string GetData(string targetColumn)
        {
            return GetData_ByColumn("PointCardID", pointCardID, targetColumn);
        }

        public static string GetData_ByColumn(string column, string value, string targetColumn)
        {
            return DataBaseControl.GetData("PointCard", column, value, targetColumn);
        }

        public static void Load()
        {
            try
            {
                activePwd            = GetData("ActivePwd");
                retailValue          = int.Parse(GetData("RetailValue"));
                goldCoins            = int.Parse(GetData("GoldCoins"));
                remainLuckyDrawTimes = int.Parse(GetData("RemainLuckyDrawTimes"));
                status               = GetData("Status");
                generationDate       = GetData("GenerationDate");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        #endregion


        #region Updata 

        public static void Updata()
        {
            Updata("ActivePwd", activePwd);
            Updata("RetailValue", retailValue.ToString());
            Updata("GoldCoins", goldCoins.ToString());
            Updata("RemainLuckyDrawTimes", remainLuckyDrawTimes.ToString());
            Updata("Status", status);
            Updata("GenerationDate", generationDate);
        }

        public static void Updata(string updataColumn, string updataValue)
        {
            DataBaseControl.Updata("PointCard", "PointCardID", pointCardID, updataColumn, updataValue);
        }

        public static void Updata_ActivePwd(string updataValue)
        {
            activePwd = updataValue;
            Updata("ActivePwd", updataValue);
        }
        public static void Updata_RetailValue(int updataValue)
        {
            retailValue = updataValue;
            Updata("RetailValue", updataValue.ToString());
        }
        public static void Updata_GoldCoins(int updataValue)
        {
            goldCoins = updataValue;
            Updata("GoldCoins", updataValue.ToString());
        }
        public static void Updata_RemainLuckyDrawTimes(int updataValue)
        {
            remainLuckyDrawTimes = updataValue;
            Updata("RemainLuckyDrawTimes", updataValue.ToString());
        }
        public static void Updata_Status(string updataValue)
        {
            status = updataValue;
            Updata("Status", updataValue);
        }
        public static void Updata_GenerationDate(string updataValue)
        {
            generationDate = updataValue;
            Updata("Status", updataValue);
        }

        #endregion


        #region Insert

        public static void Insert()
        {
            string insertSql = "INSERT INTO PointCard " +
                " VALUES( '" + pointCardID          + "', '" +
                               activePwd            + "', " +
                               retailValue          +  ", " +
                               goldCoins            +  ", " + 
                               remainLuckyDrawTimes +  ", '" +
                               status               + "', '" +
                               generationDate       + "');" ;

            DataBaseControl.ExecuteSql(insertSql);
        }

        #endregion

    }
}
