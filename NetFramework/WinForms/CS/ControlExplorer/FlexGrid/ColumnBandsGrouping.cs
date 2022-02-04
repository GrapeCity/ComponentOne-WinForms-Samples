using System.Collections.Generic;
using C1.Win.C1FlexGrid;

namespace ControlExplorer.FlexGrid
{
    public partial class ColumnBandsGrouping : C1DemoForm
    {
        public ColumnBandsGrouping()
        {
            InitializeComponent();

            SetupC1FlexGrid();
        }

        /// <summary>
        /// Setup C1FlexGrid with data
        /// </summary>
        private void SetupC1FlexGrid()
        {
            flexGrid1.BeginUpdate();

            string sql = @"
                SELECT Distinct 
	                Orders.[OrderID],
                    Products.ProductID,
	                Products.ProductName, 
	                Orders.OrderDate, 
                    Orders.ShippedDate as DeliveryDate,
                    Orders.ShipCountry,
                    Orders.ShipCity,
                    Orders.ShipAddress,
	                Customers.CompanyName, 
	                [Order Details].UnitPrice AS UnitPrice, 
	                [Order Details].Quantity, 
	                [Order Details].Discount, 
	                ([Order Details].[UnitPrice]*[Quantity]*(1-[Discount])/100)*100 as Amount 
	                FROM Shippers 
		                INNER JOIN (Products 
		                INNER JOIN ((Employees 
		                INNER JOIN (Customers 
		                INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) ON Employees.EmployeeID = Orders.EmployeeID) 
		                INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) ON Products.ProductID = [Order Details].ProductID)
			                ON Shippers.ShipperID = Orders.ShipVia; ";

            flexGrid1.DataSource = DemoDataSource(sql, true);
            flexGrid1.AutoSizeCols();
            flexGrid1.AutoSizeRows();
            flexGrid1.GroupDescriptions = new List<GroupDescription>() { new GroupDescription("CompanyName") };
            flexGrid1.Cols[1].Width = 300;
            flexGrid1.EndUpdate();
        }
    }
}