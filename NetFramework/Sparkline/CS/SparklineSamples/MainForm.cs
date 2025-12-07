using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SparklineSamples
{
    public partial class MainForm : Form
    {
        private SampleData _sampleData = new SampleData();

        public MainForm()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            c1Sparkline1.Data = _sampleData.DefaultData;
            c1Sparkline2.Data = _sampleData.DefaultData;

            var sparklineTypes = _sampleData.SparklineTypes;

            var defaultColors = _sampleData.DefaultColors;

            // "See it in action" tab:
            cbxSparklineType.Items.AddRange(sparklineTypes);
            cbxSparklineType.SelectedIndex = 0;

            c1Sparkline1.DisplayXAxis = chbxDisplayXAxisAction.Checked;

            // "Appearance" tab:
            cbxAppearanceSparkLineType.Items.AddRange(sparklineTypes);
            cbxAppearanceSparkLineType.SelectedIndex = 0;

            cbxMarksColor.Items.AddRange(defaultColors);
            cbxMarksColor.SelectedIndex = 2;

            cbxHighMarksColor.Items.AddRange(defaultColors);
            cbxHighMarksColor.SelectedIndex = 1;

            cbxSeriesColor.Items.AddRange(defaultColors);
            cbxSeriesColor.SelectedIndex = 1;

            cbxFirstMarkColor.Items.AddRange(defaultColors);
            cbxFirstMarkColor.SelectedIndex = 7;

            cbxLowMarkColor.Items.AddRange(defaultColors);
            cbxLowMarkColor.SelectedIndex = 2;

            cbxAxisColor.Items.AddRange(defaultColors);
            cbxAxisColor.SelectedIndex = 3;

            cbxLastMarkColor.Items.AddRange(defaultColors);
            cbxLastMarkColor.SelectedIndex = 1;

            cbxNegativeColor.Items.AddRange(defaultColors);
            cbxNegativeColor.SelectedIndex = 1;

            c1Sparkline2.ShowMarkers = chbxShowMarks.Checked;
            c1Sparkline2.DisplayXAxis = chbxDisplayXAxisAppearance.Checked;
            c1Sparkline2.ShowFirst = chbxShowFirst.Checked;
            c1Sparkline2.ShowLast = chbxShowLast.Checked;
            c1Sparkline2.ShowHigh = chbxShowHigh.Checked;
            c1Sparkline2.ShowLow = chbxShowLow.Checked;
            c1Sparkline2.ShowNegative = chbxShowNegative.Checked;

            c1Sparkline2.SparklineType = (cbxAppearanceSparkLineType.SelectedItem as SparklineTypeItem).Type;
            c1Sparkline2.Styles.SeriesColor = (cbxSeriesColor.SelectedItem as ColorItem).Value;
            c1Sparkline2.Styles.AxisColor = (cbxAxisColor.SelectedItem as ColorItem).Value;
            c1Sparkline2.Styles.MarkersColor = (cbxMarksColor.SelectedItem as ColorItem).Value;
            c1Sparkline2.Styles.FirstMarkerColor = (cbxFirstMarkColor.SelectedItem as ColorItem).Value;
            c1Sparkline2.Styles.LastMarkerColor = (cbxLastMarkColor.SelectedItem as ColorItem).Value;
            c1Sparkline2.Styles.HighMarkerColor = (cbxHighMarksColor.SelectedItem as ColorItem).Value;
            c1Sparkline2.Styles.LowMarkerColor = (cbxLowMarkColor.SelectedItem as ColorItem).Value;
            c1Sparkline2.Styles.NegativeColor = (cbxNegativeColor.SelectedItem as ColorItem).Value;

            // "Region sales" tab:

            Random rnd = new Random();
            string[] states = new string[] { "Alabama", "Alaska", "Arizona", "Idaho", "Illinois", "Indiana", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Vermont", "Virginia", "Washington" };

            var salesList = new List<RegionSalesData>();

            for (int i = 0; i < states.Length; i++)
            {
                var rsd = new RegionSalesData();
                rsd.State = states[i];

                rsd.SalesTrend = new ObservableCollection<double>();
                rsd.WinLoss = new ObservableCollection<double>();
                rsd.ProfitTrend = new ObservableCollection<double>();

                for (int j = 0; j < 12; j++)
                {
                    double d = rnd.Next(-50, 50);
                    rsd.SalesTrend.Add(d);
                    rsd.WinLoss.Add(d);
                    rsd.ProfitTrend.Add(d);
                    rsd.NetSales += d;
                    rsd.TotalSales += Math.Abs(d);
                }

                salesList.Add(rsd);
            }

            fxgRegionSales.AllowEditing = false;
            fxgRegionSales.AllowSorting = C1.Win.FlexGrid.AllowSortingEnum.None;
            fxgRegionSales.AllowMerging = C1.Win.FlexGrid.AllowMergingEnum.None;
            fxgRegionSales.SelectionMode = C1.Win.FlexGrid.SelectionModeEnum.Row;

            fxgRegionSales.DataSource = salesList;

            fxgRegionSales.Cols.DefaultSize = 170;
            fxgRegionSales.Rows.DefaultSize = 50;

            fxgRegionSales.Cols["TotalSales"].Format = "c2";

            var salesTrendColumn = fxgRegionSales.Cols["SalesTrend"];

            salesTrendColumn.ShowSparkline = true;
            salesTrendColumn.Sparkline.ShowMarkers = true;

            var winLossColumn = fxgRegionSales.Cols["WinLoss"];

            winLossColumn.ShowSparkline = true;
            winLossColumn.Sparkline.SparklineType = C1.Win.FlexGrid.SparklineType.WinLoss;
            winLossColumn.Sparkline.ShowNegative = true;

            var profitTrendColumn = fxgRegionSales.Cols["ProfitTrend"];

            profitTrendColumn.ShowSparkline = true;
            profitTrendColumn.Sparkline.SparklineType = C1.Win.FlexGrid.SparklineType.Column;
            profitTrendColumn.Sparkline.ShowHigh = true;
            profitTrendColumn.Sparkline.ShowLow = true;

            fxgRegionSales.Cols.MoveRange(1, 3, 4);
            fxgRegionSales.Cols.Remove(0);
        }

        private void cbxSparklineType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = sender as ComboBox;

            if (cmb != null)
            {
                var selectedSparklineTypeItem = cmb.SelectedItem as SparklineTypeItem;
                if (selectedSparklineTypeItem != null)
                {
                    c1Sparkline1.SparklineType = selectedSparklineTypeItem.Type;
                }
            }
        }

        private void chbxDisplayXAxisAction_CheckedChanged(object sender, EventArgs e)
        {
            var chk = sender as CheckBox;
            if (chk != null)
            {
                c1Sparkline1.DisplayXAxis = chk.Checked;
            }
        }

        private void btnNewData_Click(object sender, EventArgs e)
        {
            int cnt = 12;
            double[] vals = new double[cnt];
            Random rnd = new Random();
            for (int i = 0; i < cnt; i++)
            {
                vals[i] = rnd.Next(-50, 50);
            }
            c1Sparkline1.Data = vals;
        }

        private void chbxShowMarks_CheckedChanged(object sender, EventArgs e)
        {
            var chk = sender as CheckBox;
            if (chk != null)
            {
                c1Sparkline2.ShowMarkers = chk.Checked;
            }
        }

        private void chbxDisplayXaxis_CheckedChanged(object sender, EventArgs e)
        {
            var chk = sender as CheckBox;
            if (chk != null)
            {
                c1Sparkline2.DisplayXAxis = chk.Checked;
            }
        }

        private void chbxShowFirst_CheckedChanged(object sender, EventArgs e)
        {
            var chk = sender as CheckBox;
            if (chk != null)
            {
                c1Sparkline2.ShowFirst = chk.Checked;
            }
        }

        private void chbxShowLast_CheckedChanged(object sender, EventArgs e)
        {
            var chk = sender as CheckBox;
            if (chk != null)
            {
                c1Sparkline2.ShowLast = chk.Checked;
            }
        }

        private void chbxShowHigh_CheckedChanged(object sender, EventArgs e)
        {
            var chk = sender as CheckBox;
            if (chk != null)
            {
                c1Sparkline2.ShowHigh = chk.Checked;
            }
        }

        private void chbxShowLow_CheckedChanged(object sender, EventArgs e)
        {
            var chk = sender as CheckBox;
            if (chk != null)
            {
                c1Sparkline2.ShowLow = chk.Checked;
            }
        }

        private void chbxShowNegative_CheckedChanged(object sender, EventArgs e)
        {
            var chk = sender as CheckBox;
            if (chk != null)
            {
                c1Sparkline2.ShowNegative = chk.Checked;
            }
        }

        private void cbxAppearanceSparkLineType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = sender as ComboBox;

            if (cmb != null)
            {
                var selectedSparklineTypeItem = cmb.SelectedItem as SparklineTypeItem;
                if (selectedSparklineTypeItem != null)
                {
                    c1Sparkline2.SparklineType = selectedSparklineTypeItem.Type;
                }
            }
        }

        private void cbxSeriesColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = sender as ComboBox;

            if (cmb != null)
            {
                var selectedColorItem = cmb.SelectedItem as ColorItem;
                if (selectedColorItem != null)
                {
                    c1Sparkline2.Styles.SeriesColor = selectedColorItem.Value;
                }
            }
        }

        private void cbxAxisColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = sender as ComboBox;

            if (cmb != null)
            {
                var selectedColorItem = cmb.SelectedItem as ColorItem;
                if (selectedColorItem != null)
                {
                    c1Sparkline2.Styles.AxisColor = selectedColorItem.Value;
                }
            }
        }

        private void cbxMarksColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = sender as ComboBox;

            if (cmb != null)
            {
                var selectedColorItem = cmb.SelectedItem as ColorItem;
                if (selectedColorItem != null)
                {
                    c1Sparkline2.Styles.MarkersColor = selectedColorItem.Value;
                }
            }
        }

        private void cbxFirstMarkColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = sender as ComboBox;

            if (cmb != null)
            {
                var selectedColorItem = cmb.SelectedItem as ColorItem;
                if (selectedColorItem != null)
                {
                    c1Sparkline2.Styles.FirstMarkerColor = selectedColorItem.Value;
                }
            }
        }

        private void cbxLastMarkColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = sender as ComboBox;

            if (cmb != null)
            {
                var selectedColorItem = cmb.SelectedItem as ColorItem;
                if (selectedColorItem != null)
                {
                    c1Sparkline2.Styles.LastMarkerColor = selectedColorItem.Value;
                }
            }
        }

        private void cbxHighMarksColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = sender as ComboBox;

            if (cmb != null)
            {
                var selectedColorItem = cmb.SelectedItem as ColorItem;
                if (selectedColorItem != null)
                {
                    c1Sparkline2.Styles.HighMarkerColor = selectedColorItem.Value;
                }
            }
        }

        private void cbxLowMarkColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = sender as ComboBox;

            if (cmb != null)
            {
                var selectedColorItem = cmb.SelectedItem as ColorItem;
                if (selectedColorItem != null)
                {
                    c1Sparkline2.Styles.LowMarkerColor = selectedColorItem.Value;
                }
            }
        }

        private void cbxNegativeColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cmb = sender as ComboBox;

            if (cmb != null)
            {
                var selectedColorItem = cmb.SelectedItem as ColorItem;
                if (selectedColorItem != null)
                {
                    c1Sparkline2.Styles.NegativeColor = selectedColorItem.Value;
                }
            }
        }
    }
}