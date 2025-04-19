using C1.Win.FlexGrid;
using FlexGridExplorer.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples
{
    public partial class GroupingPanel : UserControl
    {
        public GroupingPanel()
        {
            InitializeComponent();
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
            // set up SQL statement
            var rs = "SELECT Employees.LastName, Orders.ShipCountry, Categories.CategoryName, " +
                "Products.ProductName, Orders.OrderDate, [Quantity]*[Products].[UnitPrice] AS [Sale Amount] " +
                "FROM (Categories INNER JOIN Products ON Categories.CategoryID = Products.CategoryID) " +
                "INNER JOIN ((Employees INNER JOIN Orders ON Employees.EmployeeID = Orders.EmployeeID) " +
                "INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID) " +
                "ON Products.ProductID = [Order Details].ProductID " +
                "ORDER BY Employees.LastName, Orders.ShipCountry, Categories.CategoryName;";

            // return data table
            return DataSource.GetRows(rs);
        }

        private void expandCb_CheckedChanged(object sender, EventArgs e)
        {
            groupPanel.AutoExpandAllGroups = expandCb.Checked;
            RefreshGroupPanel();
        }

        private void HideCb_CheckedChanged(object sender, EventArgs e)
        {
            groupPanel.HideGroupedColumns = hideCb.Checked;
            RefreshGroupPanel();
        }

        private void clearCb_CheckedChanged(object sender, EventArgs e)
        {
            groupPanel.ShowClearButton = clearCb.Checked;
            RefreshGroupPanel();
        }

        private void RefreshGroupPanel()
        {
            // Temporarily ungroup and regroup to force update
            var groupedColumns = groupPanel.FlexGrid.GroupDescriptions;
            groupPanel.FlexGrid.GroupDescriptions = null;
            // Reassign grouped columns to reinitialize the layout
            groupPanel.FlexGrid.GroupDescriptions = groupedColumns;
        }
    }
}
