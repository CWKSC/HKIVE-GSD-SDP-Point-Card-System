using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_prototype
{
    class TopUpHistoryDataBaseControl
    {

        public static System.Data.DataTable dataTable = new System.Data.DataTable();

        public static string[] PointCardIDs;
        public static string[] TopUpDates;

        public static string topUpDate = null;

        #region Load

        public static void Load()
        {
            DataBaseControl.Load(dataTable, "SELECT * FROM TopUpHistory " +
                " WHERE StrComp( PlayerID, '" + PlayerDataBaseControl.playerID + "', 0) = 0 ; ");
            PointCardIDs = new string[dataTable.Rows.Count];
            TopUpDates = new string[dataTable.Rows.Count];
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                PointCardIDs[i] = dataTable.Rows[i]["PointCardID"].ToString();
                TopUpDates[i] = dataTable.Rows[i]["TopUpDate"].ToString();
            }
        }

        #endregion


        #region Insert

        public static void Insert(string topUpData)
        {
            string insertSql = "INSERT INTO TopUpHistory " +
                " VALUES( '"+ PlayerDataBaseControl.playerID + "', '" + PointCardDataBaseControl.pointCardID + "', '" + topUpData +  "' );" ;
            DataBaseControl.ExecuteSql(insertSql);
        }

        public static void Insert()
        {
            Insert(topUpDate);
        }

        #endregion


    }
}
