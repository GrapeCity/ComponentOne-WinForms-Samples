using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DashboardModel;
using C1.Win.C1FlexGrid;
using System.Globalization;
using C1.Win.C1Command;

namespace DashboardWinForms
{
    public partial class Tasks : UserControl
    {

        public Tasks()
        {
            InitializeComponent();
            Text = Strings.Resource.TaskPage_Title;
            c1DockingTabPage1.Text = Strings.Resource.AllTasks_Header;
            c1DockingTabPage2.Text = Strings.Resource.InProgress_Header;
            c1DockingTabPage3.Text = Strings.Resource.Completed_Header;
            c1DockingTabPage4.Text = Strings.Resource.Deferred_Header;
            c1DockingTabPage5.Text = Strings.Resource.Urgent_Header;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var selector = new ValRangeSelector() { Dock = DockStyle.Bottom };
            selector.DateRangeChanged += Selector_DateRangeChanged;
            Controls.Add(selector);
            c1DockingTab1_TabClick(null, EventArgs.Empty);
            _flex.GroupDescriptions = new List<C1.Win.C1FlexGrid.GroupDescription>() { new C1.Win.C1FlexGrid.GroupDescription("AssignedTo") };
            _flex.Cols[0].Width = 0;
            _flex.Cols[1].StarWidth = "*";
            _flex.Cols[2].StarWidth = "*";
            _flex.Cols[3].StarWidth = "*";
            _flex.Cols[5].StarWidth = "*";
            _flex.DrawMode = DrawModeEnum.OwnerDraw;
            _flex.OwnerDrawCell += new OwnerDrawCellEventHandler(_flex_OwnerDrawCell);
        }

        private void Selector_DateRangeChanged(object sender, DateRangeChangedEventArgs e)
        {
            DataService.GetService().DateRange = e.NewValue;
            c1DockingTab1_TabClick(null, EventArgs.Empty);
        }

        void _flex_OwnerDrawCell(object sender, OwnerDrawCellEventArgs e)
        {
            if (_flex.Cols[e.Col].UserData != null && e.Row >= _flex.Rows.Fixed)
            {
                double value;
                if (double.TryParse(_flex.GetDataDisplay(e.Row, e.Col), NumberStyles.Any, CultureInfo.CurrentCulture, out value))
                {
                    // calculate bar extent
                    Rectangle rc = e.Bounds;
                    double max = (double)_flex.Cols[e.Col].UserData;
                    rc.Width = (int)(_flex.Cols[e.Col].WidthDisplay * value / max);

                    // draw background
                    e.DrawCell(DrawCellFlags.Background | DrawCellFlags.Border);

                    // draw bar
                    rc.Inflate(-2, -2);
                    e.Graphics.FillRectangle(Brushes.Turquoise, rc);
                    rc.Inflate(-1, -1);
                    e.Graphics.FillRectangle(Brushes.Teal, rc);
                    e.Text = (value * 100).ToString() + "%";

                    // draw cell content
                    e.DrawCell(DrawCellFlags.Content);
                }
            }
        }

        private void c1DockingTab1_TabClick(object sender, EventArgs e)
        {
            int selectedIndex = c1DockingTab1.SelectedIndex;
            DataService.GetService().CampainTaskType = (CampainTaskType)selectedIndex;
            _flex.Parent.Tag = _flex.GroupDescriptions;
            _flex.GroupDescriptions = null;
            _flex.DataSource = DataService.GetService().CampainTaskCollction.Cast<CampainTaskItem>().ToList();
            int r1 = _flex.Rows.Fixed;
            int r2 = _flex.Rows.Count - 1;
            if (r2 > 1)
            {
                Column col = _flex.Cols["Complete"];
                double max = _flex.Aggregate(AggregateEnum.Max, r1, col.Index, r2, col.Index);
                col.UserData = max;
                col.TextAlign = TextAlignEnum.CenterCenter;
            }
            _flex.Cols[1].StarWidth = "*";
            _flex.Cols[2].StarWidth = "*";
            _flex.Cols[3].StarWidth = "*";
            _flex.Cols[5].StarWidth = "*";
            _flex.Parent = c1DockingTab1.SelectedTab;
            _flexGroupPanel.Parent = c1DockingTab1.SelectedTab;
            _flex.GroupDescriptions = _flex.Parent.Tag as IList<C1.Win.C1FlexGrid.GroupDescription>;
        }

        private void c1DockingTab1_MeasureTab(object sender, C1.Win.C1Command.MeasureTabEventArgs e)
        {
            var tabs = (C1DockingTab)sender;
            tabs.ItemSize = new Size(150, 50);

        }
    }
}
