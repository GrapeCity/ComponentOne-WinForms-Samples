using C1.Win.C1FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SelectionStatistics
{
    public partial class SelectionStatisticsControl : UserControl
    {
        public SelectionStatisticsControl()
        {
            InitializeComponent();

            InitializeData();

            UpdateStatistics();
        }

        private void UpdateStatistics()
        {
            var text = string.Empty;
            if (!c1FlexGrid1.Selection.IsSingleCell)
            {
                text = $"Average: {c1FlexGrid1.Aggregate(AggregateEnum.Average):F2}  " +
                   $"Count: {c1FlexGrid1.Aggregate(AggregateEnum.Count)}  " +
                   $"Summary: {c1FlexGrid1.Aggregate(AggregateEnum.Sum):F2}";
            }

            tslSelectionStatistics.Text = text;
        }

        private void InitializeData()
        {
            c1FlexGrid1.BeginUpdate();

            ordersTableAdapter1.Connection.ConnectionString = GetConnectionString();
            ordersTableAdapter1.Fill(c1NWindDataSet1.Orders);

            var groups = new List<GroupDescription>();
            var group1 = new GroupDescription("ShipRegion", ListSortDirection.Descending, true);
            var group2 = new GroupDescription("CustomerID", ListSortDirection.Ascending, true);
            groups.Add(group1);
            groups.Add(group2);
            c1FlexGrid1.GroupDescriptions = groups;

            c1FlexGrid1.Cols[1].Width = 222;

            c1FlexGrid1.EndUpdate();
        }

        private void c1FlexGrid1_SelChange(object sender, EventArgs e)
        {
            UpdateStatistics();
        }

        private static string GetConnectionString()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            var conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }
    }
}
