using System;
using System.Data;
using System.Data.OleDb;

namespace DataBinding
{
    public static class DataSource
    {
        public static DataTable GetDataSource(string request)
        {
            var cn = GetConnectionString();
            var da = new OleDbDataAdapter(request, cn);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        static string GetConnectionString()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            var conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
