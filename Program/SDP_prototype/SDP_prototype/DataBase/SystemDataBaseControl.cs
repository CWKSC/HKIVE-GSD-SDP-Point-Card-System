using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDP_prototype
{
    class SystemDataBaseControl
    {

        #region PlayerNum

        public static int Get_PlayerNum()
        {
            DataBaseControl.Load("SELECT * FROM System;");
            return int.Parse(DataBaseControl.dataTable.Rows[0]["PlayerNum"].ToString());
        }

        public static void Updata_PlayerNum(int value)
        {
            string updateSql = "UPDATE System SET PlayerNum = " + value + ";";
            DataBaseControl.ExecuteSql(updateSql);
        }

        public static void Updata_PlayerNum_PlusOne()
        {
            string updateSql = "UPDATE System SET PlayerNum = PlayerNum + 1;";
            DataBaseControl.ExecuteSql(updateSql);
        }

        #endregion


        #region PointCardNum

        public static int Get_PointCardNum()
        {
            DataBaseControl.Load("SELECT * FROM System;");
            return int.Parse(DataBaseControl.dataTable.Rows[0]["PointCardNum"].ToString());
        }

        public static void Updata_PointCardNum(int value)
        {
            string updateSql = "UPDATE System SET PointCardNum = " + value + ";";
            DataBaseControl.ExecuteSql(updateSql);
        }

        public static void Updata_PointCardNum_PlusOne()
        {
            string updateSql = "UPDATE System SET PointCardNum = PointCardNum + 1;";
            DataBaseControl.ExecuteSql(updateSql);
        }

        #endregion


        #region ProblemReportNum

        public static int Get_ProblemReportNum()
        {
            DataBaseControl.Load("SELECT * FROM System;");
            return int.Parse(DataBaseControl.dataTable.Rows[0]["ProblemReportNum"].ToString());
        }

        public static void Updata_ProblemReportNum(int value)
        {
            string updateSql = "UPDATE System SET ProblemReportNum = " + value + ";";
            DataBaseControl.ExecuteSql(updateSql);
        }

        public static void Updata_ProblemReportNum_PlusOne()
        {
            string updateSql = "UPDATE System SET ProblemReportNum = ProblemReportNum + 1;";
            DataBaseControl.ExecuteSql(updateSql);
        }

        #endregion



    }
}
