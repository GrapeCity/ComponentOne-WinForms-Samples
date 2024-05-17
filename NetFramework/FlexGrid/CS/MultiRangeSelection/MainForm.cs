using C1.Win.C1Themes;
using C1.Win.Ribbon;
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

namespace MultiRangeSelection
{
    public partial class MainForm : C1RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'c1NWindDataSet.Orders' table. You can move, or remove it, as needed.
            var dbConnection = $@"provider=microsoft.jet.oledb.4.0;data source={Environment.GetFolderPath(Environment.SpecialFolder.Personal)}\ComponentOne Samples\Common\c1nwind.mdb;";
            ordersTableAdapter.Connection.ConnectionString = dbConnection;
            this.ordersTableAdapter.Fill(this.c1NWindDataSet.Orders);
            InitThemes();

            c1FlexGrid1.AllowMerging = AllowMergingEnum.Custom;
            var cellRange = c1FlexGrid1.GetCellRange(2, 2, 3, 3);
            c1FlexGrid1.MergedRanges.Add(cellRange);

            c1FlexGrid1.AfterSelChange += C1FlexGrid1_AfterSelChange;
        }

        private void C1FlexGrid1_AfterSelChange(object sender, RangeEventArgs e)
        {
            toolStripLabel1.Text = $"Selection statistic: Count={c1FlexGrid1.Aggregate(AggregateEnum.Count)}; Sum={c1FlexGrid1.Aggregate(AggregateEnum.Sum)}";
        }

        #region Themes

        private void InitThemes()
        {
            var themes = C1ThemeController.GetThemes().Where(x => x.Contains("Office365"));
            foreach (var theme in themes)
                cmbTheme.Items.Add(theme);
            cmbTheme.SelectedIndex = cmbTheme.Items.IndexOf("Office365Green");
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = cmbTheme.SelectedItem.Text;
        }

        #endregion

        private void rbCopyToClipboard_Click(object sender, EventArgs e)
        {
            c1FlexGrid1.Copy();
        }

        private void rbPasteFromClipboard_Click(object sender, EventArgs e)
        {
            c1FlexGrid1.Paste();
        }

        private void rbExportToExcel_Click(object sender, EventArgs e)
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

        private void rbSelectRanges_Click(object sender, EventArgs e)
        {
            var ranges = new List<CellRange>
            {
                c1FlexGrid1.GetCellRange(1, 1, 4, 2),
                c1FlexGrid1.GetCellRange(1, 5, 4, 6)
            };
            c1FlexGrid1.Select(ranges);
        }
    }
}
