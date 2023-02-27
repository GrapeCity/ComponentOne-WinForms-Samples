using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using C1.Win.C1Themes;

namespace ColumnBandsLayout
{
    public enum LayoutOption
    {
        Traditional,
        Compact,
        Detailed
    }

    public partial class ColumnBandsUserControl : UserControl
    {
        public ColumnBandsUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializing the control.
        /// </summary>
        public void Init()
        {
            SetupC1FlexGrid();
        }

        /// <summary>
        /// Applyes C1Theme to the user control.
        /// </summary>
        public void ApplyTheme(string themeName)
        {
            var theme = C1ThemeController.GetThemeByName(themeName, false);
            C1ThemeController.ApplyThemeToControlTree(this, theme);
        }

        public void ApplyLayout(LayoutOption option) 
        {
            switch (option)
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
        /// Setup C1FlexGrid with data.
        /// </summary>
        private void SetupC1FlexGrid()
        {
            flexGrid1.BeginUpdate();
            flexGrid1.DataSource = GetDataSource();
            flexGrid1.AutoSizeCols();
            flexGrid1.AutoSizeRows();
            flexGrid1.EndUpdate();
        }

        #region DataSource
        private DataTable GetDataSource()
        {
            string rs = @"
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

            string cn = GetConnectionString();
            OleDbDataAdapter da = new OleDbDataAdapter(rs, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
        #endregion
    }
}