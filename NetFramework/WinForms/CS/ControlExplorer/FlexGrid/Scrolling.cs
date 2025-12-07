using C1.Win.FlexGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControlExplorer.FlexGrid
{
    public class Scrolling : BaseDataBoundForm
    {
        private bool _delayedScroll = true;
        private bool _showScrollTips = true;

        public Scrolling()
        {
            AddProperty("DelayedScroll", this);
            AddProperty("ShowScrollTips", this);
            c1FlexGrid1.ShowScrollTip += c1FlexGrid1_ShowScrollTip;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //set scroll options
            SetScrollOptions();
        }

        private void c1FlexGrid1_ShowScrollTip(object sender, C1.Win.FlexGrid.ToolTipEventArgs e)
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
                this.c1FlexGrid1.ScrollOptions = ((C1.Win.FlexGrid.ScrollFlags)((C1.Win.FlexGrid.ScrollFlags.DelayedScroll | C1.Win.FlexGrid.ScrollFlags.ShowScrollTips)));
            }
            else if (_delayedScroll)
            {
                this.c1FlexGrid1.ScrollOptions = C1.Win.FlexGrid.ScrollFlags.DelayedScroll;
            }
            else if (_showScrollTips)
            {
                this.c1FlexGrid1.ScrollOptions = C1.Win.FlexGrid.ScrollFlags.ShowScrollTips;
            }
            else
            {
                this.c1FlexGrid1.ScrollOptions = ScrollFlags.None;
            }
        }
    }
}
