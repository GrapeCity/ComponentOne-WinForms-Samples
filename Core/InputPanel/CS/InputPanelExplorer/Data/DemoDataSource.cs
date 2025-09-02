using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace InputPanelExplorer.Data
{
    public static class DemoDataSource
    {
        private static readonly Dictionary<string, string> Queries = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
        {
            ["EmployeeOrders"] = "SELECT DISTINCTROW Orders.OrderID, Orders.OrderDate, Shippers.CompanyName, Customers.Country, [FirstName] & \" \" & [LastName] AS Salesperson, Products.ProductName AS Product, [Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount, CCur([Order Details].[UnitPrice]*[Quantity]*(1-[Discount])/100)*100 AS ExtendedPrice FROM Shippers INNER JOIN (Products INNER JOIN ((Employees INNER JOIN (Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) ON Employees.EmployeeID = Orders.EmployeeID) INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) ON Products.ProductID = [Order Details].ProductID) ON Shippers.ShipperID = Orders.ShipVia;",
            ["Invoices"] = "SELECT DISTINCTROW Orders.ShipName, Orders.ShipAddress, Orders.ShipCity, Orders.ShipRegion, Orders.ShipPostalCode, Orders.ShipCountry, Orders.CustomerID, Customers.CompanyName, Customers.Address, Customers.City, Customers.Region, Customers.PostalCode, Customers.Country, [FirstName] & \" \" & [LastName] AS Salesperson, Orders.OrderID, Orders.OrderDate, Orders.RequiredDate, Orders.ShippedDate, Shippers.CompanyName, [Order Details].ProductID, Products.ProductName, [Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount, CCur([Order Details].[UnitPrice]*[Quantity]*(1-[Discount])/100)*100 AS ExtendedPrice, Orders.Freight FROM Shippers INNER JOIN (Products INNER JOIN ((Employees INNER JOIN (Customers INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) ON Employees.EmployeeID = Orders.EmployeeID) INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) ON Products.ProductID = [Order Details].ProductID) ON Shippers.ShipperID = Orders.ShipVia;",
            ["Customers"] = "SELECT * FROM Customers",
            ["Customers_OrderByCountry"] = "SELECT * FROM Customers ORDER BY Country",
            ["Employees"] = "SELECT * FROM Employees",
            ["Products"] = "SELECT * FROM Products",
            ["Products2"] = "SELECT ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, Discontinued FROM Products",
            ["Composer"] = "SELECT * FROM Composer",
            ["Suppliers"] = "SELECT * FROM Suppliers",
            ["Orders"] = "SELECT * FROM Orders",
            ["TotalSales"] = "SELECT ROUND(Sum(([Order Details].UnitPrice * Quantity) * (1 - [Order Details].Discount)), 2) AS[Sales] FROM [Order Details]",
            ["Sales"] = "SELECT DISTINCT " +
                        "([Order Details].UnitPrice * Quantity) * (1 - [Order Details].Discount) AS [Sales], " +
                        "Orders_olap.OrderDate AS [OrderDate], " +
                        "Products.ProductID AS [Product], " +
                        "Customers_olap.CompanyID AS [Customer], " +
                        "Customers_olap.CountryID AS [Country], " +
                        "Employees.EmployeeID AS [Employee], " +
                        "Categories.CategoryID AS [Category] " +
                        "FROM (Companies INNER JOIN (Countries INNER JOIN (Employees INNER JOIN (Customers_olap INNER JOIN (Orders_olap INNER JOIN ([Order Details] INNER JOIN (Products INNER JOIN Categories ON Categories.CategoryID = Products.CategoryID) ON Products.ProductID = [Order Details].ProductID) ON Orders_olap.OrderID = [Order Details].OrderID) ON Customers_olap.CustomerID = Orders_olap.CustomerID) ON Employees.EmployeeID = Orders_olap.EmployeeID) ON Countries.CountryID = Customers_olap.CountryID) ON Companies.CompanyID = Customers_olap.CountryID);",
            ["SalesTop10"] = "SELECT TOP 10 " +
                        "([Order Details].UnitPrice * Quantity) * (1 - [Order Details].Discount) AS [Sales], " +
                        "Orders_olap.OrderDate AS [OrderDate], " +
                        "Products.ProductID AS [Product], " +
                        "Customers_olap.CompanyID AS [Customer], " +
                        "Customers_olap.CountryID AS [Country], " +
                        "Employees.EmployeeID AS [Employee], " +
                        "Categories.CategoryID AS [Category] " +
                        "FROM (Companies INNER JOIN (Countries INNER JOIN (Employees INNER JOIN (Customers_olap INNER JOIN (Orders_olap INNER JOIN ([Order Details] INNER JOIN (Products INNER JOIN Categories ON Categories.CategoryID = Products.CategoryID) ON Products.ProductID = [Order Details].ProductID) ON Orders_olap.OrderID = [Order Details].OrderID) ON Customers_olap.CustomerID = Orders_olap.CustomerID) ON Employees.EmployeeID = Orders_olap.EmployeeID) ON Countries.CountryID = Customers_olap.CountryID) ON Companies.CompanyID = Customers_olap.CountryID);",
            ["SalesByCountry"] = "SELECT DISTINCT Round(Sum(([Order Details].UnitPrice * Quantity) * (1 - [Order Details].Discount)), 2) AS[Sales], Customers.Country AS[Country] FROM (Employees INNER JOIN (Customers INNER JOIN (Orders INNER JOIN ([Order Details] INNER JOIN (Products INNER JOIN Categories ON Categories.CategoryID = Products.CategoryID) ON Products.ProductID = [Order Details].ProductID) ON Orders.OrderID = [Order Details].OrderID) ON Customers.CustomerID = Orders.CustomerID) On Employees.EmployeeID = Orders.EmployeeID) GROUP BY Customers.Country",
            ["SalesByEmployee"] = "SELECT DISTINCT Round(Sum(([Order Details].UnitPrice * Quantity) * (1 - [Order Details].Discount)), 2) AS[Sales], Employees.LastName AS [Employee] FROM (Employees INNER JOIN (Customers INNER JOIN (Orders INNER JOIN ([Order Details] INNER JOIN (Products INNER JOIN Categories ON Categories.CategoryID = Products.CategoryID) ON Products.ProductID = [Order Details].ProductID) ON Orders.OrderID = [Order Details].OrderID) ON Customers.CustomerID = Orders.CustomerID) On Employees.EmployeeID = Orders.EmployeeID) GROUP BY LastName",
            ["LookupCategory"] = "SELECT [CategoryID], [CategoryName] FROM Categories",
            ["LookupCountry"] = "SELECT [CountryID], [CountryName] FROM [Countries]",
            ["LookupCustomer"] = "SELECT [CompanyID], [CompanyName] FROM [Companies]",
            ["LookupEmployee"] = "SELECT Employees.EmployeeID, [LastName] + ', ' + [FirstName] AS Name FROM Employees",
            ["LookupProduct"] = "SELECT [ProductID],[ProductName] FROM Products"
        };

        public static DataTable DataSourceDemo(string member, bool custom)
        {
            string sql = "SELECT * FROM Products";

            if (custom)
            {
                sql = member;
            }
            else if (Queries.TryGetValue(member, out var query))
            {
                sql = query;
            }

            var dt = new DataTable();
            using (var da = new OleDbDataAdapter(sql, DemoConnectionString))
            {
                da.Fill(dt);
            }
            return dt;
        }

        public static string DemoConnectionString =>
            "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|C1Demo.mdb;Persist Security Info=False";
    }
}
