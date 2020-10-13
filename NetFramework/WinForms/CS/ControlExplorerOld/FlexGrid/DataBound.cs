using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;

namespace ControlExplorer.FlexGrid
{
    public partial class DataBound : C1DemoForm
    {
        private bool _delayedScroll;
        private bool _showScrollTips;

        public DataBound()
        {
            InitializeComponent();
            AddProperty("AllowMerging", c1FlexGrid1);
            AddProperty("AllowFreezing", c1FlexGrid1);
            AddProperty("AllowDragging", c1FlexGrid1);
            AddPropertyColumnBreak();
            AddProperty("DelayedScroll", this);
            AddProperty("ShowScrollTips", this);
            AddProperty("ShowCellLabels", c1FlexGrid1);    
        }

        private void DataBound_Load(object sender, EventArgs e)
        {
            //set datasource
            c1FlexGrid1.DataSource = DemoDataSource("EmployeeOrders");
            //set merging, dragging and freezing permissions
            c1FlexGrid1.AllowMerging = AllowMergingEnum.RestrictCols;
            c1FlexGrid1.AllowDragging = AllowDraggingEnum.Both;
            c1FlexGrid1.AllowFreezing = AllowFreezingEnum.Both;
            foreach (Column c in c1FlexGrid1.Cols)
            {
                c.AllowMerging = true;
            }
            //apply some formatting
            c1FlexGrid1.Cols["Product"].Width = 100;
            c1FlexGrid1.Cols["UnitPrice"].Format = "c";
            c1FlexGrid1.Cols["ExtendedPrice"].Format = "c";
            //sort grid by specified column
            c1FlexGrid1.Sort(SortFlags.Ascending, 1, 2);
            c1FlexGrid1.Cols.Frozen = 2;
            c1FlexGrid1.Rows.Frozen = 3;
            //set scroll options
            _delayedScroll = true;
            _showScrollTips = true;
            SetScrollOptions();

            //Add the grouped heading row
            c1FlexGrid1.Rows[0].Move(1);
            c1FlexGrid1[0, 1] = "Order Details";
            c1FlexGrid1[0, 2] = "Order Details";
            c1FlexGrid1[0, 3] = "Customers";
            c1FlexGrid1[0, 4] = "Customers";
            c1FlexGrid1[0, 5] = "Employees";
            c1FlexGrid1[0, 6] = "Products";
            c1FlexGrid1[0, 7] = "Products";
            c1FlexGrid1[0, 8] = "Products";
            c1FlexGrid1[0, 9] = "Products";
            c1FlexGrid1[0, 10] = "Total";
            c1FlexGrid1.Rows[0].AllowMerging = true;
            c1FlexGrid1.Rows[0].StyleNew.TextAlign = TextAlignEnum.CenterCenter;

        }

        private void c1FlexGrid1_ShowScrollTip(object sender, C1.Win.C1FlexGrid.ToolTipEventArgs e)
        {    
            if (c1FlexGrid1.SortColumn != null)
            {
                //Display values from sorted column in tooltip
                e.ToolTipText = c1FlexGrid1.SortColumn.Name + ": " + c1FlexGrid1[e.Row, c1FlexGrid1.SortColumn.Index].ToString() + "\nRow: " + e.Row.ToString();
            }
            else
            {
                //Display OrderDate column values in tooltip
                e.ToolTipText = "OrderDate: " + ((DateTime)(c1FlexGrid1[e.Row, "OrderDate"])).ToShortDateString() + "\nRow: " + e.Row.ToString();
            }
        }

        /*
         * Custom Properties for this demo
         * */
        public bool DelayedScroll
        {
            get
            {
                return _delayedScroll;
            }
            set
            {
                _delayedScroll = value;
                SetScrollOptions();
            }
        }

        public bool ShowScrollTips
        {
            get
            {
                return _showScrollTips;
            }
            set
            {
                _showScrollTips = value;
                SetScrollOptions();
            }
        }

        private void SetScrollOptions()
        {
            if (_delayedScroll && _showScrollTips)
            {
                this.c1FlexGrid1.ScrollOptions = ((C1.Win.C1FlexGrid.ScrollFlags)((C1.Win.C1FlexGrid.ScrollFlags.DelayedScroll | C1.Win.C1FlexGrid.ScrollFlags.ShowScrollTips)));
            }
            else if (_delayedScroll)
            {
                this.c1FlexGrid1.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.DelayedScroll;
            }
            else if (_showScrollTips)
            {
                this.c1FlexGrid1.ScrollOptions = C1.Win.C1FlexGrid.ScrollFlags.ShowScrollTips;
            }
            else
            {
                this.c1FlexGrid1.ScrollOptions = ScrollFlags.None;
            }
        }
    }
}
