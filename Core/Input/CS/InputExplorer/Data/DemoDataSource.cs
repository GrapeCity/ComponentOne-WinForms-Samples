using System;
using System.Data;
using System.Data.SqlClient;

namespace InputExplorer.Data
{
    public class DemoDataSource
    {
        static private SqlConnection _connection;

        static string GetConnectionString()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common\NORTHWND.MDF";
            var conn = @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename={0};Integrated Security=True;Connect Timeout=30";
            return string.Format(conn, path);
        }

        static public SqlConnection Connection
        {
            get 
            { 
                if(_connection == null)
                {
                    var str = GetConnectionString();
                    _connection = new SqlConnection()
                    {
                        ConnectionString = str
                    };
                }
                return _connection;
            }
        }

        static public DataTable Employees => GetDataSource("select * from Employees");

        static public DataTable GetDataSource(string query)
        {
            var da = new SqlDataAdapter(query, Connection);
            var dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
