using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleExplorer
{
    public static class DataSource
    {
        #region "private methods"

        private static string databaseFileName = @"\NORTHWND.db";
        private static List<KeyValuePair<int, string>> paths = new List<KeyValuePair<int, string>>()
            {
                new KeyValuePair<int, string>(1, Environment.CurrentDirectory),
                new KeyValuePair<int, string>(2, Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common")
            };
        public static string GetPathDb()
        {
            var existsDb = paths.Select(x => new
            {
                Priority = x.Key,
                Path = x.Value + databaseFileName,
                Exists = File.Exists(x.Value + databaseFileName)
            }).Where(x => x.Exists)
              .OrderBy(x => x.Priority)
              .FirstOrDefault()?.Path ?? "";

            return existsDb;
        }
        private static bool CheckDatabase()
        {
            var existsPathDb = GetPathDb();
            if (string.IsNullOrEmpty(existsPathDb))
            {
                var message = $"File {databaseFileName} not found! {Environment.NewLine}" +
                    $"{string.Join(Environment.NewLine, paths.Select(x => x.Value).ToArray())}";
                MessageBox.Show(message, "Error");

                return false;
            }

            return true;
        }
        private static IEnumerable<DataColumn> CreateColumns(SqliteDataReader reader, IEnumerable<string> imageColumns = null)
        {
            var columns = new List<DataColumn>();
            var dateColumnNames = new List<string>()
            { "datetime", "date"};

            if(reader.HasRows )
            {
                // Create base columns 
                var schemaTable = reader.GetSchemaTable();
                columns = (from s in schemaTable.Rows.Cast<DataRow>() select s)
                    .Select(x => new
                    {
                        // Name field
                        ColumnName = x["ColumnName"].ToString(),
                        // Database type
                        DataTypeName = x["DataTypeName"].ToString().ToLower(),
                        // System type
                        SystemType = Type.GetType(x["DataType"].ToString())
                    })
                    .Select(x => new DataColumn()
                    {
                        ColumnName = x.ColumnName,
                        DataType =  
                                    // Check type as date
                                    dateColumnNames.Any(y => y == x.DataTypeName) ? typeof(DateTime) :
                                    imageColumns != null ? 
                                        // Check type as image
                                        imageColumns.Any(y => y == x.ColumnName) ? typeof(Image) : x.SystemType
                                    : x.SystemType
                    }).ToList();
            }

            return columns;
        }
        private static Image Base64ToImage(string base64String)
        {
            // Convert base 64 string to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            // Convert byte[] to Image
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }

        static string CountryToRegion(string country)
        {
            if (country == "US")
                return "America";
            else if (country == "Japan" || country == "China")
                return "Asia";
            else
                return "Europe";
        }

        #endregion

        public static DataTable DemoDataSource(string member)
        {
            string sql = "SELECT * FROM Products";
            DataTable dt = new DataTable();
            if (member.Equals("EmployeeOrders"))
            {
                sql = "SELECT DISTINCTROW Orders.OrderID, Orders.OrderDate, Shippers.CompanyName, Customers.Country, [FirstName] & \" \" & [LastName] AS Salesperson, Products.ProductName AS Product, [Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount, CCur([Order Details].[UnitPrice]*[Quantity]*(1-[Discount])/100)*100 AS ExtendedPrice FROM Shippers INNER JOIN (Products INNER JOIN ((Employees INNER JOIN (Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) ON Employees.EmployeeID = Orders.EmployeeID) INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) ON Products.ProductID = [Order Details].ProductID) ON Shippers.ShipperID = Orders.ShipVia;";
            }
            else if (member.Equals("Invoices"))
            {
                sql = "SELECT DISTINCTROW Orders.ShipName, Orders.ShipAddress, Orders.ShipCity, Orders.ShipRegion, Orders.ShipPostalCode, Orders.ShipCountry, Orders.CustomerID, Customers.CompanyName, Customers.Address, Customers.City, Customers.Region, Customers.PostalCode, Customers.Country, [FirstName] & \" \" & [LastName] AS Salesperson, Orders.OrderID, Orders.OrderDate, Orders.RequiredDate, Orders.ShippedDate, Shippers.CompanyName, [Order Details].ProductID, Products.ProductName, [Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount, CCur([Order Details].[UnitPrice]*[Quantity]*(1-[Discount])/100)*100 AS ExtendedPrice, Orders.Freight FROM Shippers INNER JOIN (Products INNER JOIN ((Employees INNER JOIN (Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) ON Employees.EmployeeID = Orders.EmployeeID) INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) ON Products.ProductID = [Order Details].ProductID) ON Shippers.ShipperID = Orders.ShipVia;";
            }
            else if (member.Equals("Customers"))
            {
                sql = "SELECT * FROM Customers";
            }
            else if (member.Equals("Customers_OrderByCountry"))
            {
                sql = "SELECT * FROM Customers ORDER BY Country";
            }
            else if (member.Equals("Employees"))
            {
                sql = "SELECT * FROM Employees";
            }
            else if (member.Equals("Products"))
            {
                sql = "SELECT * FROM Products";
            }
            else if (member.Equals("Products2"))
            {
                sql = "SELECT ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, Discontinued FROM Products";
            }
            else if (member.Equals("Composer"))
            {
                sql = "SELECT * FROM Composer";
            }
            else if (member.Equals("Suppliers"))
            {
                sql = "SELECT * FROM Suppliers";
            }
            else if (member.Equals("Orders"))
            {
                sql = "SELECT * FROM Orders";
            }
            else if (member.Equals("TotalSales"))
            {
                sql = "SELECT ROUND(Sum(([Order Details].UnitPrice * Quantity) * (1 - [Order Details].Discount)), 2) AS[Sales] FROM [Order Details]";
            }
            else if (member.Equals("Sales"))
            {
                sql = "SELECT DISTINCT " +
                    "([Order Details].UnitPrice * Quantity) * (1 - [Order Details].Discount) AS [Sales], " +
                    "Orders_olap.OrderDate AS [OrderDate], " +
                    "Products.ProductID AS [Product], " +
                    "Customers_olap.CompanyID AS [Customer], " +
                    "Customers_olap.CountryID AS [Country], " +
                    "Employees.EmployeeID AS [Employee], " +
                    "Categories.CategoryID AS [Category] " +
                "FROM  " +
                    "(Companies INNER JOIN " +
                    "(Countries INNER JOIN  " +
                    "(Employees INNER JOIN " +
                    "(Customers_olap INNER JOIN " +
                    "(Orders_olap INNER JOIN " +
                    "([Order Details] INNER JOIN " +
                    "(Products INNER JOIN Categories " +
                    "ON Categories.CategoryID = Products.CategoryID) " +
                    "ON Products.ProductID = [Order Details].ProductID) " +
                    "ON Orders_olap.OrderID = [Order Details].OrderID) " +
                    "ON Customers_olap.CustomerID = Orders_olap.CustomerID) " +
                    "ON Employees.EmployeeID = Orders_olap.EmployeeID) " +
                    "ON Countries.CountryID = Customers_olap.CountryID) " +
                    "ON Companies.CompanyID = Customers_olap.CountryID);";
            }
            else if (member.Equals("SalesTop10"))
            {
                sql = "SELECT " +
                    "([Order Details].UnitPrice * Quantity) * (1 - [Order Details].Discount) AS [Sales], " +
                    "Orders_olap.OrderDate AS [OrderDate], " +
                    "Products.ProductID AS [Product], " +
                    "Customers_olap.CompanyID AS [Customer], " +
                    "Customers_olap.CountryID AS [Country], " +
                    "Employees.EmployeeID AS [Employee], " +
                    "Categories.CategoryID AS [Category] " +
                "FROM  " +
                    "(Companies INNER JOIN " +
                    "(Countries INNER JOIN  " +
                    "(Employees INNER JOIN " +
                    "(Customers_olap INNER JOIN " +
                    "(Orders_olap INNER JOIN " +
                    "([Order Details] INNER JOIN " +
                    "(Products INNER JOIN Categories " +
                    "ON Categories.CategoryID = Products.CategoryID) " +
                    "ON Products.ProductID = [Order Details].ProductID) " +
                    "ON Orders_olap.OrderID = [Order Details].OrderID) " +
                    "ON Customers_olap.CustomerID = Orders_olap.CustomerID) " +
                    "ON Employees.EmployeeID = Orders_olap.EmployeeID) " +
                    "ON Countries.CountryID = Customers_olap.CountryID) " +
                    "ON Companies.CompanyID = Customers_olap.CountryID) LIMIT 10;";
            }
            else if (member.Equals("SalesByCountry"))
            {
                sql = "SELECT DISTINCT " +
                    "Round(Sum(([Order Details].UnitPrice * Quantity) * (1 - [Order Details].Discount)), 2) AS[Sales], " +
                    "Customers.Country AS[Country] " +
                "FROM " +
                    "(Employees INNER JOIN " +
                    "(Customers INNER JOIN " +
                    "(Orders INNER JOIN " +
                    "([Order Details] INNER JOIN " +
                    "(Products INNER JOIN Categories " +
                    "ON Categories.CategoryID = Products.CategoryID) " +
                    "ON Products.ProductID = [Order Details].ProductID) " +
                    "ON Orders.OrderID = [Order Details].OrderID) " +
                    "ON Customers.CustomerID = Orders.CustomerID) " +
                    "On Employees.EmployeeID = Orders.EmployeeID) " +
                "GROUP BY " +
                    "Customers.Country";
            }
            else if (member.Equals("SalesByEmployee"))
            {
                sql = "SELECT DISTINCT " +
                    "Round(Sum(([Order Details].UnitPrice * Quantity) * (1 - [Order Details].Discount)), 2) AS[Sales], " +
                    "Employees.LastName AS [Employee] " +
                "FROM " +
                    "(Employees INNER JOIN " +
                    "(Customers INNER JOIN " +
                    "(Orders INNER JOIN " +
                    "([Order Details] INNER JOIN " +
                    "(Products INNER JOIN Categories " +
                    "ON Categories.CategoryID = Products.CategoryID) " +
                    "ON Products.ProductID = [Order Details].ProductID) " +
                    "ON Orders.OrderID = [Order Details].OrderID) " +
                    "ON Customers.CustomerID = Orders.CustomerID) " +
                    "On Employees.EmployeeID = Orders.EmployeeID) " +
                "GROUP BY " +
                    "LastName";
            }
            else if (member.Equals("LookupCategory"))
            {
                sql = "SELECT [CategoryID], [CategoryName] FROM Categories";
            }
            else if (member.Equals("LookupCountry"))
            {
                sql = "SELECT [CountryID], [CountryName] FROM [Countries]";
            }
            else if (member.Equals("LookupCustomer"))
            {
                sql = "SELECT [CompanyID], [CompanyName] FROM [Companies]";
            }
            else if (member.Equals("LookupEmployee"))
            {
                sql = "SELECT Employees.EmployeeID, [LastName] + ', ' + [FirstName] AS Name FROM Employees";
            }
            else if (member.Equals("LookupProduct"))
            {
                sql = "SELECT [ProductID],[ProductName] FROM Products";
            }
            
            return GetRows(sql);
        }


        public static DataTable GetRows(string queryString, 
            string tableName = "Result", IEnumerable<string> imageColumns = null)
        {
            var table = new DataTable(tableName);
            var existsPathDb = GetPathDb();
            if (!CheckDatabase())
                return null;

            var connectionString = String.Format("Data Source={0}", existsPathDb);
            using (SqliteConnection connection = new SqliteConnection(connectionString))
            {
                using (SqliteCommand command = new SqliteCommand(queryString, connection))
                {
                    // Open SQLite database
                    connection.Open();
                    var reader = command.ExecuteReader();
                    var columns = CreateColumns(reader, imageColumns);
                    table.Columns.AddRange(columns.ToArray());

                    if (columns.Any())
                    {
                        while (reader.Read())
                        {
                            // Fill table
                            var row = table.NewRow();
                            var arrayColumns = columns.ToArray();
                            Enumerable.Range(0, reader.FieldCount)
                                .ToList()
                                .ForEach(x =>
                                {
                                    var currentColumns = arrayColumns[x];
                                    bool IsImageColumn = imageColumns == null ? false :
                                            imageColumns.Any(y => y == currentColumns.ColumnName) ? true : false;

                                    if (IsImageColumn)
                                        row[x] = Base64ToImage(reader[x].ToString());
                                    else
                                        row[x] = reader[x];
                                });

                            table.Rows.Add(row);
                        }

                        return table;
                    }
                }
            }

            return null;
        }

        public static DataTable CreateSampleDataTable(int nrows)
        {
            var rnd = new Random();

            var dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Product", typeof(string));
            dt.Columns.Add("Region", typeof(string));
            dt.Columns.Add("Country", typeof(string));
            dt.Columns.Add("Sales", typeof(int));
            dt.Columns.Add("Downloads", typeof(int));

            var countries = "US,Germany,UK,Japan,China,Italy,Spain".Split(',');
            var products = "Wijmo,Olap".Split(',');

            for (var i = 0; i < nrows; i++)
            {
                var country = countries[rnd.Next(countries.Length)];
                dt.Rows.Add(new object[] {
                        rnd.Next(),
                        products[rnd.Next(products.Length)],
                        CountryToRegion(country),
                        country,
                        rnd.Next(10000),
                        rnd.Next(10000)
                    }
                );
            }

            return dt;
        }
    }
}
