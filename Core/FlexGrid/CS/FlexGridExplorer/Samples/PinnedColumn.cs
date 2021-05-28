using FlexGridExplorer.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples
{
    public partial class PinnedColumn : UserControl
    {
        public PinnedColumn()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            string sql = @"
                SELECT Distinct 
	                Orders.[OrderID], 
	                Orders.OrderDate, 
	                Shippers.CompanyName, 
	                Customers.Country AS Country, 
	                [FirstName] + ' ' + [LastName] AS Salesperson, 
	                Products.ProductName AS Product, 
	                [Order Details].UnitPrice AS UnitPrice, 
	                [Order Details].Quantity, 
	                [Order Details].Discount, 
	                ([Order Details].[UnitPrice]*[Quantity]*(1-[Discount])/100)*100 as ExtendedPrice 
	                FROM Shippers 
		                INNER JOIN (Products 
		                INNER JOIN ((Employees 
		                INNER JOIN (Customers 
		                INNER JOIN Orders ON Customers.CustomerID = Orders.CustomerID) ON Employees.EmployeeID = Orders.EmployeeID) 
		                INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) ON Products.ProductID = [Order Details].ProductID)
			                ON Shippers.ShipperID = Orders.ShipVia; ";

            FillFlexGrid(c1FlexGrid1,sql);
            FillFlexGrid(c1FlexGrid2,sql);
        }

        private void FillFlexGrid(C1.Win.FlexGrid.C1FlexGrid c1FlexGrid, string sql)
        {
            c1FlexGrid.DataSource = DataSource.GetRows(sql);
            foreach (C1.Win.FlexGrid.Column c in c1FlexGrid.Cols)
            {
                c.AllowMerging = true;
            }
            c1FlexGrid.Cols["Product"].MinWidth = 120;
            c1FlexGrid.Cols["Product"].StarWidth = "*";
            c1FlexGrid.Cols["UnitPrice"].Format = "n2";
            c1FlexGrid.Cols["ExtendedPrice"].Format = "n2";
        }

    }
}
