using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.FlexGrid;
using FlexGridExplorer.Data;

namespace FlexGridExplorer.Samples
{
    public partial class MultiRangeSelection : UserControl
    {
        public MultiRangeSelection()
        {
            InitializeComponent();

            //Setup FlexGrid
            c1FlexGrid1.BeginUpdate();
            c1FlexGrid1.DataSource = DataSource.GetRows("Select * from Orders");
            c1FlexGrid1.AutoSizeCols();
            c1FlexGrid1.AutoSizeRows();
            c1FlexGrid1.AutoClipboard = true;
            c1FlexGrid1.ClipboardCopyMode = ClipboardCopyModeEnum.DataOnly;
            c1FlexGrid1.SelectionMode = SelectionModeEnum.MultiRange;
            c1FlexGrid1.AllowMerging = AllowMergingEnum.Custom;
            var cellRange = c1FlexGrid1.GetCellRange(2, 2, 3, 3);
            c1FlexGrid1.MergedRanges.Add(cellRange);
            c1FlexGrid1.AfterSelChange += C1FlexGrid1_AfterSelChange;
            c1FlexGrid1.EndUpdate();
        }

        private void C1FlexGrid1_AfterSelChange(object sender, RangeEventArgs e)
        {
            toolStripLabel1.Text = $"Selection statistic: Count={c1FlexGrid1.Aggregate(AggregateEnum.Count)}; Sum={c1FlexGrid1.Aggregate(AggregateEnum.Sum)}";
        }

        private void btnSelectRanges_Click(object sender, EventArgs e)
        {
            var ranges = new List<CellRange>
            {
                c1FlexGrid1.GetCellRange(1, 1, 4, 2),
                c1FlexGrid1.GetCellRange(1, 5, 4, 6)
            };
            c1FlexGrid1.Select(ranges);
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            c1FlexGrid1.Copy();
        }

        private void btnPasteFromClipboard_Click(object sender, EventArgs e)
        {
            c1FlexGrid1.Paste();
        }

        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            c1FlexGrid1.SaveExcel("MultiRangeSelection.xlsx", FileFlags.SelectedRangesOnly | FileFlags.SaveMergedRanges);
            MessageBox.Show("Data exported to Excel", "FlexGrid MultiRange Selection Sample", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
