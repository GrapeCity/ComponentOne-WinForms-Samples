using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace TrueDBGridExplorer.Samples
{
    using TrueDBGridExplorer.Data;

    public partial class AggregateFooter : UserControl
    {
        private C1.Win.TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;

        public AggregateFooter()
        {
            InitializeComponent();
            InitializeTrueDBGrid();
        }

        private void InitializeTrueDBGrid()
        {
            c1TrueDBGrid1 = new C1.Win.TrueDBGrid.C1TrueDBGrid();
            ((ISupportInitialize)c1TrueDBGrid1).BeginInit();
            SuspendLayout();
            c1TrueDBGrid1.Dock = DockStyle.Fill;
            Controls.Add(c1TrueDBGrid1);
            Name = "Overview";            
            ((ISupportInitialize)c1TrueDBGrid1).EndInit();
            ResumeLayout(false);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            string sql = @"
                SELECT Distinct 
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

            c1TrueDBGrid1.ColumnFooters = true;
            c1TrueDBGrid1.DataSource = DataSource.GetRows(sql);
            c1TrueDBGrid1.Splits[0].DisplayColumns["Product"].MinWidth = 120;
            c1TrueDBGrid1.Splits[0].DisplayColumns["UnitPrice"].DataColumn.NumberFormat = "n2";
            c1TrueDBGrid1.Splits[0].DisplayColumns["ExtendedPrice"].DataColumn.NumberFormat = "n2";
            
            c1TrueDBGrid1.Splits[0].DisplayColumns["UnitPrice"].DataColumn.FooterExpression = "\"Max \" & CSng(Max([UnitPrice]))";
            c1TrueDBGrid1.Splits[0].DisplayColumns["Quantity"].DataColumn.FooterExpression = "\"Max \" & CSng(Max([Quantity]))";
            c1TrueDBGrid1.Splits[0].DisplayColumns["Discount"].DataColumn.FooterExpression = "\"Max \" & CSng(Max([Discount]))";
            c1TrueDBGrid1.Splits[0].DisplayColumns["ExtendedPrice"].DataColumn.FooterExpression = "\"Max \" & CSng(Max([ExtendedPrice]))";
        }
    }
}
