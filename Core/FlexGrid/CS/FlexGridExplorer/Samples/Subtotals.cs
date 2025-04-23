using C1.Win.FlexGrid;
using FlexGridExplorer.Data;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples
{
    public partial class Subtotals : UserControl
    {
        private DataView _dataView;
        public Subtotals()
        {
            InitializeComponent();
        }

        private void NewSubtotals_Load(object sender, EventArgs e)
        {
            c1FlexGrid1.BeginUpdate();
            var sql = @"
                        SELECT 
                            Employees.FirstName || ' ' || Employees.LastName AS Salesperson,
                            Customers.Country,
                            Shippers.CompanyName,
                            Products.ProductName,
                            Orders.OrderDate,
                            CAST([Order Details].UnitPrice * [Order Details].Quantity * (1 - [Order Details].Discount) AS NUMERIC) AS Amount
                        FROM Orders
                        INNER JOIN Shippers ON Shippers.ShipperID = Orders.ShipVia
                        INNER JOIN Customers ON Customers.CustomerID = Orders.CustomerID
                        INNER JOIN Employees ON Employees.EmployeeID = Orders.EmployeeID
                        INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID
                        INNER JOIN Products ON Products.ProductID = [Order Details].ProductID;
                        ";
            DataTable originalData = DataSource.GetRows(sql);
            _dataView = new DataView(originalData);

            // Set the DataView as the data source
            c1FlexGrid1.DataSource = _dataView;

            // set up grid layout/behavior
            c1FlexGrid1.AllowSorting = AllowSortingEnum.None;
            c1FlexGrid1.AllowMerging = AllowMergingEnum.Nodes;
            c1FlexGrid1.ExtendLastCol = true;
            c1FlexGrid1.Cols[0].Width = 25;
            c1FlexGrid1.Tree.Style = TreeStyleFlags.Simple;
            c1FlexGrid1.Tree.Column = 1;

            // set up grid styles
            c1FlexGrid1.Styles.Normal.Border.Style = BorderStyleEnum.None;
            c1FlexGrid1.Styles.Normal.Trimming = StringTrimming.EllipsisCharacter;

            // right align Amount column
            c1FlexGrid1.Cols["Amount"].TextAlign = TextAlignEnum.RightCenter;
            c1FlexGrid1.Cols["Amount"].TextAlignFixed = TextAlignEnum.RightCenter;
            c1FlexGrid1.Cols["Amount"].Format = "C";

            // prevent user from dragging last three columns
            c1FlexGrid1.Cols[4].AllowDragging = false;
            c1FlexGrid1.Cols[5].AllowDragging = false;
            c1FlexGrid1.Cols[6].AllowDragging = false;

            // apply default sort order
            Sort();
            c1FlexGrid1_AfterDataRefresh(null, null);
            c1FlexGrid1.EndUpdate();
        }

        private void c1FlexGrid1_AfterDataRefresh(object sender, ListChangedEventArgs e)
        {
            // total on Amount
            int totalOn = c1FlexGrid1.Cols.Count - 1;
            string caption = "Total for {0}";

            // calculate three levels of totals
            c1FlexGrid1.Subtotal(AggregateEnum.Sum, 0, 1, totalOn, caption);
            c1FlexGrid1.Subtotal(AggregateEnum.Sum, 1, 2, totalOn, caption);
            c1FlexGrid1.Subtotal(AggregateEnum.Sum, 2, 3, totalOn, caption);

            //int totalOn = fg.Cols.Count - 1;
            c1FlexGrid1.Subtotal(AggregateEnum.Sum, -1, -1, totalOn, "Grand Total");
            c1FlexGrid1.Tree.Show(1);

            // auto size the grid to accommodate tree
            c1FlexGrid1.AutoSizeCols();
            c1FlexGrid1.AutoSizeCols(1, 1, 1000, 3, 30, AutoSizeFlags.IgnoreHidden);
        }

        private void c1FlexGrid1_AfterDragColumn(object sender, DragRowColEventArgs e)
        {
            // Sort the recordset when the user drags columns.
            // This will cause a data refresh, removing all subtotals and
            // firing the AfterDataRefresh event, which rebuilds the subtotals.
            Sort();

            // Rebuild the subtotals and tree
            c1FlexGrid1_AfterDataRefresh(null, null);
        }

        private void Sort()
        {
            // Apply sort to the DataView
            string sortExpression = c1FlexGrid1.Cols[1].Name + ", " + c1FlexGrid1.Cols[2].Name + ", " + c1FlexGrid1.Cols[3].Name;
            _dataView.Sort = sortExpression;
        }
    }
}
