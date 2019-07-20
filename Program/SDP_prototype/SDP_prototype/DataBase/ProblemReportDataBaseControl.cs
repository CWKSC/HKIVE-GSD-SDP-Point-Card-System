using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_prototype
{
    class ProblemReportDataBaseControl
    {
        public static System.Data.DataTable dataTable = new System.Data.DataTable();

        public static string[] problemReportIDs;
        public static string[] titles;
        public static string[] details;

        public static string problemReportID = "";
        public static string title;
        public static string detail;

        #region Load

        public static void Load()
        {
            DataBaseControl.Load(dataTable, "SELECT * FROM ProblemReport ");
            problemReportIDs = new string[dataTable.Rows.Count];
            titles = new string[dataTable.Rows.Count];
            details = new string[dataTable.Rows.Count];
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                problemReportIDs[i] = dataTable.Rows[i]["ProblemReportID"].ToString();
                titles[i] = dataTable.Rows[i]["Title"].ToString();
                details[i] = dataTable.Rows[i]["Detail"].ToString();
            }
        }

        #endregion


        #region Insert

        public static void Insert()
        {
            string insertSql = "INSERT INTO ProblemReport " +
                " VALUES( '" + "R" + (SystemDataBaseControl.Get_ProblemReportNum() + 1).ToString().PadLeft(7, '0')
                + "', '" + PlayerDataBaseControl.playerID + "', '" + title + "', '" + detail + "' );";
            DataBaseControl.ExecuteSql(insertSql);
        }

        #endregion
    }
}
