using System;
using System.Windows.Forms;

namespace ControlExplorer.FlexGrid
{
    public partial class ColumnBandsLayout : C1DemoForm
    {
        public ColumnBandsLayout()
        {
            InitializeComponent();

            SetupC1FlexGrid();
            SetupComboBox();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((LayoutOption)comboBox1.SelectedIndex)
            {
                case LayoutOption.Traditional:                  
                    c1FlexGridBandedView1.FlexGrid = null;
                    c1FlexGridBandedView2.FlexGrid = null;
                    break;
                case LayoutOption.Compact:
                    c1FlexGridBandedView2.FlexGrid = null;
                    c1FlexGridBandedView1.FlexGrid = flexGrid1;
                    break;
                case LayoutOption.Detailed:
                    c1FlexGridBandedView1.FlexGrid = null;
                    c1FlexGridBandedView2.FlexGrid = flexGrid1;
                    break;
            }
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
	                Orders.OrderDate, 
	                Shippers.CompanyName, 
	                Customers.Country AS Country, 
                    [FirstName] + ' ' + [LastName] As Saler, 
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

            flexGrid1.DataSource = DemoDataSource(sql,true);
            flexGrid1.AutoSizeCols();
            flexGrid1.AutoSizeRows();
            flexGrid1.EndUpdate();
        }

        /// <summary>
        /// Setup ComboBox with data
        /// </summary>
        private void SetupComboBox()
        {
            var values = Enum.GetValues(typeof(LayoutOption));
            foreach (var value in values)
                comboBox1.Items.Add(value);
            comboBox1.SelectedIndex = 0;
        }
    }

    public enum LayoutOption
    {
        Traditional,
        Compact,
        Detailed
    }
}