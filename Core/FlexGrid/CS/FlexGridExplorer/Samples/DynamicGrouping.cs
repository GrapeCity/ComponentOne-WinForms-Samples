using C1.Win.FlexGrid;
using FlexGridExplorer.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples
{
    public partial class DynamicGrouping : UserControl
    {
        private string previousColumn;
        public DynamicGrouping()
        {
            InitializeComponent();

            // initialize groupBy combo
            cmbGroup.DropDownStyle = (C1.Win.Input.DropDownStyle)ComboBoxStyle.DropDownList;
            cmbGroup.Items.Add("None");
            cmbGroup.Items.Add("CategoryName");
            cmbGroup.Items.Add("LastName");
            cmbGroup.Items.Add("ProductName");
            cmbGroup.Items.Add("ShipCountry");

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

        private void CmbGroup_SelectedItemChanged(object sender, EventArgs e)
        {
            if (cmbGroup.Text == "None")
            {
                // clear grouping
                flexGrid.GroupDescriptions = null;
            }
            else
            {
                // change FlexGrid grouping according to the end-user selection
                C1.Win.FlexGrid.GroupDescription gd = new C1.Win.FlexGrid.GroupDescription(cmbGroup.Text);
                flexGrid.GroupDescriptions = new List<C1.Win.FlexGrid.GroupDescription>() { gd };
            }
            UpdateColumnVisibility();
        }

        // get a DataTable
        DataTable GetDataTable()
        {
            var rs = "SELECT Employees.LastName, Orders.ShipCountry, Categories.CategoryName, " +
                "Products.ProductName, Orders.OrderDate, [Quantity]*[Products].[UnitPrice] AS [Sale Amount] " +
                "FROM (Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) " +
                "INNER JOIN ((Employees INNER JOIN Orders ON Employees.EmployeeID = Orders.EmployeeID) " +
                "INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) " +
                "ON Products.ProductID = [Order Details].ProductID " +
                "ORDER BY Employees.LastName, Orders.ShipCountry, Categories.CategoryName;";

            return DataSource.GetRows(rs);
        }

        private void c1CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateColumnVisibility();
        }

        private void UpdateColumnVisibility()
        {
            var currentColumn = cmbGroup.Text;

            if (currentColumn == "None") return;

            // Make the previously hidden column visible
            if (!string.IsNullOrEmpty(previousColumn) && previousColumn != currentColumn)
            {
                flexGrid.Cols[previousColumn].Visible = true;
            }

            // Update the visibility of the currently selected column
            flexGrid.Cols[currentColumn].Visible = !c1CheckBox1.Checked;

            previousColumn = currentColumn;
        }
    }
}
