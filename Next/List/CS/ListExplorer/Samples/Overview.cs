using System;
using System.Windows.Forms;

namespace ListExplorer.Samples
{
    using ListExplorer.Data;

    public partial class Overview : UserControl
    {
        private BindingSource _bindingSource = new BindingSource();

        public Overview()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

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

            _bindingSource.DataSource = DataSource.GetRows(sql);
            c1List1.DataSource = _bindingSource;            
            c1List1.Splits[0].DisplayColumns["Product"].MinWidth = 120;
            c1List1.Splits[0].DisplayColumns["UnitPrice"].DataColumn.NumberFormat = "n2";
            c1List1.Splits[0].DisplayColumns["ExtendedPrice"].DataColumn.NumberFormat = "n2";

            c1Combo1.DataSource = _bindingSource;
            c1Combo1.DisplayMember = "Product";
            c1Combo1.DropDownWidth = 400;
        }
    }
}
