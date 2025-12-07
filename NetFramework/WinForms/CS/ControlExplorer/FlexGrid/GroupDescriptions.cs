using C1.Win.FlexGrid;
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
    public partial class GroupDescriptions : C1DemoForm
    {
        public GroupDescriptions()
        {
            InitializeComponent();
            AddProperty("HideGroupedColumns", flexGrid);

            // initialize groupBy combo
            cmbGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGroup.Items.Add("None");
            cmbGroup.Items.Add("CategoryName");
            cmbGroup.Items.Add("LastName");
            cmbGroup.Items.Add("ProductName");
            cmbGroup.Items.Add("ShipCountry");
            cmbGroup.SelectedValueChanged += CmbGroup_SelectedValueChanged;

            // initialize grid
            flexGrid.DataSource = GetDataTable();
            flexGrid.AllowMerging = AllowMergingEnum.Nodes;
            flexGrid.AutoSizeCols(10);

            // add aggregate to "Sale Amount" column
            var col = flexGrid.Cols["Sale Amount"];
            col.Aggregate = AggregateEnum.Sum;
            col.Format = "N2";

            cmbGroup.SelectedIndex = 1;
        }

        private void CmbGroup_SelectedValueChanged(object sender, EventArgs e)
        {
            if ((string)cmbGroup.SelectedItem == "None")
            {
                // clear grouping
                flexGrid.GroupDescriptions = null;
            }
            else
            {
                // change FlexGrid grouping according to the end-user selection
                C1.Win.FlexGrid.GroupDescription gd = new C1.Win.FlexGrid.GroupDescription((string)cmbGroup.SelectedItem);
                flexGrid.GroupDescriptions = new List<C1.Win.FlexGrid.GroupDescription>() { gd };
            }
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
