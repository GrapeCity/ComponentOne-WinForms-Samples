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

namespace ControlExplorer.FlexGrid
{
    public partial class MultiRangeSelection : C1DemoForm
    {
        public MultiRangeSelection()
        {
            InitializeComponent();

            //Setup FlexGrid
            c1FlexGrid1.DataSource = DemoDataSource("EmployeeOrders");
            c1FlexGrid1.AutoClipboard = true;
            c1FlexGrid1.ClipboardCopyMode = ClipboardCopyModeEnum.DataOnly;
            c1FlexGrid1.SelectionMode = SelectionModeEnum.MultiRange;
            c1FlexGrid1.AllowMerging = AllowMergingEnum.Custom;
            var cellRange = c1FlexGrid1.GetCellRange(2, 2, 3, 3);
            c1FlexGrid1.MergedRanges.Add(cellRange);
            c1FlexGrid1.AfterSelChange += C1FlexGrid1_AfterSelChange;
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
            using (var dialog = new SaveFileDialog())
            {
                dialog.FileName = "MultiRangeSelection.xlsx";
                dialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    c1FlexGrid1.SaveExcel(dialog.FileName, FileFlags.SelectedRangesOnly | FileFlags.SaveMergedRanges);
                    MessageBox.Show("Data exported to Excel.", "FlexGrid MultiRange Selection Sample", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
