using C1.Win.FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExplorer.FlexGrid
{
    public partial class SelectionStatistics : BaseDataBoundForm
    {
        public SelectionStatistics()
        {
            InitializeComponent();

            c1FlexGrid1.BringToFront();

            //subscribe to the FlexGrid selection change event
            c1FlexGrid1.SelChange += C1FlexGrid1_SelChange;

            UpdateStatistics();
        }

        private void C1FlexGrid1_SelChange(object sender, EventArgs e)
        {
            UpdateStatistics();
        }

        /// <summary>
        /// Calculating selection statistics and updating the bottom toolbar text
        /// </summary>
        private void UpdateStatistics()
        {
            var text = string.Empty;
            if (!c1FlexGrid1.Selection.IsSingleCell)
            {
                text = $"Average: {c1FlexGrid1.Aggregate(AggregateEnum.Average):F2}  " +
               $"Count: {c1FlexGrid1.Aggregate(AggregateEnum.Count)}  " +
               $"Summary: {c1FlexGrid1.Aggregate(AggregateEnum.Sum):F2}";
            }

            tslSelStats.Text = text;
        }
    }
}
