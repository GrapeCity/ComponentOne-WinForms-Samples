using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace EmployeesListWithFilter
{
    public class DataProvider
    {
        public IEnumerable<Employee> GetEmployees()
        {
            var carsTable = GetDataTableCars();
            foreach (DataRow row in carsTable.Rows)
            {
                yield return new Employee
                {
                    EmployeeID = row.Field<int>("EmployeeID"),
                    LastName = row.Field<string>("LastName"),
                    FirstName = row.Field<string>("FirstName"),
                    Title = row.Field<string>("Title"),
                    TitleOfCourtesy = row.Field<string>("TitleOfCourtesy"),
                    BirthDate = row.Field<DateTime>("BirthDate"),
                    HireDate = row.Field<DateTime>("HireDate"),
                    Address = row.Field<string>("Address"),
                    City = row.Field<string>("City"),
                    Region = row.Field<string>("Region"),
                    PostalCode = row.Field<string>("PostalCode"),
                    Country = row.Field<string>("Country"),
                    HomePhone = row.Field<string>("HomePhone"),
                    Extension = row.Field<string>("Extension"),
                    Photo = row.Field<byte[]>("Photo"),
                    Notes = row.Field<string>("Notes"),
                    ReportsTo = row.Field<int?>("ReportsTo")
                };
            }
        }

        private static DataTable GetDataTableCars()
        {
            string rs = "select * from Employees;";
            string cn = GetConnectionString();
            OleDbDataAdapter da = new OleDbDataAdapter(rs, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        private static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
