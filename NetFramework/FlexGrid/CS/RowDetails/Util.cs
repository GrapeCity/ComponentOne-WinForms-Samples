using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RowDetails
{
    public static class Util
    {
        public static string GetConnectionString()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            var conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }

        public static void FillTable(DataSet ds, string tableName, string conn)
        {
            tableName = tableName.Trim();
            string sql = string.Format("select * from [{0}]", tableName);
            var da = new OleDbDataAdapter(sql, conn);
            da.Fill(ds, tableName);
        }
    }
}
