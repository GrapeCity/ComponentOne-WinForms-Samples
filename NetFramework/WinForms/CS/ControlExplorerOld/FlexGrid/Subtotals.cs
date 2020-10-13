using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace ControlExplorer.FlexGrid
{
    public partial class Subtotals : C1DemoForm
    {
        public Subtotals()
        {
            InitializeComponent();
        }

        private void NewSubtotals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'c1DemoDataSet.Invoices' table. You can move, or remove it, as needed.
            this.invoicesTableAdapter.Fill(this.c1DemoDataSet.Invoices);

            // set up grid layout/behavior
            c1FlexGrid1.AllowSorting = AllowSortingEnum.None;
            c1FlexGrid1.AllowMerging = AllowMergingEnum.Nodes;
            //c1FlexGrid1.SelectionMode = SelectionModeEnum.Cell;
            c1FlexGrid1.ExtendLastCol = true;
            c1FlexGrid1.Cols[0].Width = c1FlexGrid1.Cols.DefaultSize / 4;
            c1FlexGrid1.Tree.Style = TreeStyleFlags.Simple;
            c1FlexGrid1.Tree.Column = 1;

            // set up grid styles
            c1FlexGrid1.Styles.Normal.Border.Style = BorderStyleEnum.None;
            c1FlexGrid1.Styles.Normal.Trimming = StringTrimming.EllipsisCharacter;

            // right align Amount column
            c1FlexGrid1.Cols["ExtendedPrice"].TextAlign = TextAlignEnum.RightCenter;
            c1FlexGrid1.Cols["ExtendedPrice"].TextAlignFixed = TextAlignEnum.RightCenter;
            c1FlexGrid1.Cols["ExtendedPrice"].Format = "C";

            // prevent user from dragging last three columns
            c1FlexGrid1.Cols[4].AllowDragging = false;
            c1FlexGrid1.Cols[5].AllowDragging = false;
            c1FlexGrid1.Cols[6].AllowDragging = false;

            // apply default sort order
            Sort();
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
        }

        private void Sort()
        {
            string sort = c1FlexGrid1.Cols[1].Name + ", " + c1FlexGrid1.Cols[2].Name + ", " + c1FlexGrid1.Cols[3].Name;
            invoicesBindingSource.Sort = sort;
        }

    }
}
