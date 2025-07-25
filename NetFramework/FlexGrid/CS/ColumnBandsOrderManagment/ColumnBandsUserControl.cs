using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using C1.Win.FlexGrid;
using C1.Win.Themes;

namespace ColumnBandsOrderManagment
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
            SetUpColSpan();
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

        /// <summary>
        /// Setup C1FlexGrid with data.
        /// </summary>
        private void SetupC1FlexGrid()
        {
            flexGrid1.BeginUpdate();
            flexGrid1.DataSource = GetDataSource();
            flexGrid1.AutoSizeCols();
            flexGrid1.AutoSizeRows();
            flexGrid1.GroupDescriptions = new List<GroupDescription>() { new GroupDescription("CompanyName") };
            flexGrid1.Cols[1].Width = 300;
            flexGrid1.EndUpdate();
            
        }

        /// <summary>
        /// Setup the colSpan property for ColumnBandView
        /// </summary>
        private void SetUpColSpan()
        {
            band2.ColSpan = 1;
            band5.ColSpan = 5;
        }

        #region DataSource
        private DataTable GetDataSource()
        {
            string rs = @"
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