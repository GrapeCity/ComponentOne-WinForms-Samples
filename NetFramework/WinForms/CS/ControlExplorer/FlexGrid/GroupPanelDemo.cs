using C1.Win.C1FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.FlexGrid
{
    public partial class GroupPanelDemo : C1DemoForm
    {
        public GroupPanelDemo()
        {
            InitializeComponent();

            AddProperty("AutoExpandAllGroups", groupPanel);
            AddProperty("HideGroupedColumns", groupPanel);
            AddProperty("ShowClearButton", groupPanel);
        }

        private void GroupPanel_Load(object sender, EventArgs e)
        {
            InitGrid();
        }

        private void InitGrid()
        {
            flexGrid.DataSource = GetDataTable();
            flexGrid.AllowMerging = AllowMergingEnum.Nodes;
            flexGrid.Cols["Sale Amount"].Format = "N2";

            flexGrid.AutoSizeCols(10);
        }

        // get a DataTable
        DataTable GetDataTable()
        {
            // set up connection string
            var conn = DemoConnectionString;

            // set up SQL statement
            var rs = "SELECT Employees.LastName, Orders.ShipCountry, Categories.CategoryName, " +
                "Products.ProductName, Orders.OrderDate, [Quantity]*[Products].[UnitPrice] AS [Sale Amount] " +
                "FROM (Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) " +
                "INNER JOIN ((Employees INNER JOIN Orders ON Employees.EmployeeID = Orders.EmployeeID) " +
                "INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) " +
                "ON Products.ProductID = [Order Details].ProductID " +
                "ORDER BY Employees.LastName, Orders.ShipCountry, Categories.CategoryName;";

            // retrieve data into DataSet
            var da = new OleDbDataAdapter(rs, conn);
            var ds = new DataSet();
            da.Fill(ds);

            // return data table
            return ds.Tables[0];
        }
    }
}
