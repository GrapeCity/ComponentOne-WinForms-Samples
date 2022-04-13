using System;
using System.Collections.Generic;
using System.Windows.Forms;
using C1.Win.FlexGrid;
using FlexGridExplorer.Data;

namespace FlexGridExplorer.Samples
{
    public partial class ColumnBandsGrouping : UserControl
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

            flexGrid1.DataSource = DataSource.GetRows(sql);            
            flexGrid1.AutoSizeCols();
            flexGrid1.AutoSizeRows();
            flexGrid1.GroupDescriptions = new List<GroupDescription>() { new GroupDescription("CompanyName") };
            flexGrid1.Cols[1].Width = 400;
            flexGrid1.EndUpdate();
        }
    }
}