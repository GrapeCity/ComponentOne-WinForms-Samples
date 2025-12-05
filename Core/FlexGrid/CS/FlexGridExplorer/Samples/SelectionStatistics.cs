using C1.Win.FlexGrid;
using FlexGridExplorer.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples
{
    public partial class SelectionStatistics : UserControl
    {
        public SelectionStatistics()
        {
            InitializeComponent();

            InitializeData();

            UpdateStatistics();
        }

        private void UpdateStatistics()
        {
            var text = string.Empty;
            if (!flexGrid1.Selection.IsSingleCell)
            {
                text = $"Average: {flexGrid1.Aggregate(AggregateEnum.Average):F2}  " +
               $"Count: {flexGrid1.Aggregate(AggregateEnum.Count)}  " +
               $"Summary: {flexGrid1.Aggregate(AggregateEnum.Sum):F2}";
            }

            tslSelectionStatistics.Text = text;
        }

        private void InitializeData()
        {
            flexGrid1.BeginUpdate();

            flexGrid1.DataSource = DataSource.GetRows("Select * from Orders");

            flexGrid1.AutoSizeCols();
            flexGrid1.AutoSizeRows();

            foreach (RowCol col in flexGrid1.Cols)
            {
                col.TextAlign = TextAlignEnum.CenterCenter;
            }

            var groups = new List<C1.Win.FlexGrid.GroupDescription>();
            var group1 = new C1.Win.FlexGrid.GroupDescription("ShipRegion", ListSortDirection.Descending, true);
            var group2 = new C1.Win.FlexGrid.GroupDescription("CustomerID", ListSortDirection.Ascending, true);
            groups.Add(group1);
            groups.Add(group2);
            flexGrid1.GroupDescriptions = groups;

            flexGrid1.Cols[1].Width = 222;

            flexGrid1.EndUpdate();
        }

        private void c1FlexGrid1_SelChange(object sender, EventArgs e)
        {
            UpdateStatistics();
        }

    }
}
