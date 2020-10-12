using C1.Win.C1FlexGrid;
using C1.Win.C1Themes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.FlexGrid
{
    public partial class Sparkline : C1DemoForm
    {
        public Sparkline()
        {
            InitializeComponent();
        }

        private void Sparkline_Load(object sender, EventArgs e)
        {
            SetupGrid();
        }

        private void SetupGrid()
        {
            c1FlexGrid1.AllowEditing = false;
            c1FlexGrid1.AllowSorting = AllowSortingEnum.None;
            c1FlexGrid1.AllowMerging = AllowMergingEnum.None;
            c1FlexGrid1.SelectionMode = SelectionModeEnum.Row;

            c1FlexGrid1.DataSource = GetRegionSales();

            c1FlexGrid1.Rows.DefaultSize = 30;
            c1FlexGrid1.Cols.Fixed = 0;

            var totalSalesColumn = c1FlexGrid1.Cols["TotalSales"];
            totalSalesColumn.Format = "c2";
            totalSalesColumn.Width = 90;

            var netSalesColumn = c1FlexGrid1.Cols["NetSales"];
            totalSalesColumn.Width = 90;

            var salesTrendColumn = c1FlexGrid1.Cols["SalesTrend"];

            salesTrendColumn.ShowSparkline = true;
            salesTrendColumn.Sparkline.ShowHigh = true;
            salesTrendColumn.Sparkline.ShowLow = true;

            var winLossColumn = c1FlexGrid1.Cols["WinLoss"];

            winLossColumn.ShowSparkline = true;
            winLossColumn.Sparkline.SparklineType = SparklineType.WinLoss;
            winLossColumn.Sparkline.Styles.BarDistance = 4;
            winLossColumn.Sparkline.ShowNegative = true;

            var profitTrendColumn = c1FlexGrid1.Cols["ProfitTrend"];

            profitTrendColumn.ShowSparkline = true;
            profitTrendColumn.Sparkline.SparklineType = SparklineType.Column;
            profitTrendColumn.Sparkline.Styles.BarDistance = 4;
            profitTrendColumn.Sparkline.Styles.LowMarkerColor = Color.Red;
            profitTrendColumn.Sparkline.Styles.HighMarkerColor = Color.Green;
            profitTrendColumn.Sparkline.ShowHigh = true;
            profitTrendColumn.Sparkline.ShowLow = true;
        }

        private List<RegionSalesData> GetRegionSales()
        {
            var sales = new List<RegionSalesData>();

            Random rnd = new Random();
            string[] states = new string[] { "Alabama", "Alaska", "Arizona", "Idaho", "Illinois", "Indiana", "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Vermont", "Virginia", "Washington" };

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
                    rsd.NetSales += d;
                    rsd.TotalSales += Math.Abs(d);
                    rsd.SalesTrend.Add(d);
                    rsd.WinLoss.Add(d);
                    rsd.ProfitTrend.Add(d);
                }

                sales.Add(rsd);
            }

            return sales;
        }

        protected override void OnThemeApplied()
        {
            if (c1FlexGrid1 != null)
            {
                var profitTrendColumn = c1FlexGrid1.Cols["ProfitTrend"];
                if (profitTrendColumn != null)
                {
                    profitTrendColumn.Sparkline.Styles.LowMarkerColor = Color.Red;
                    profitTrendColumn.Sparkline.Styles.HighMarkerColor = Color.Green;
                }
            }
        }
    }

    public class RegionSalesData
    {
        public string State { get; set; }
        public double TotalSales { get; set; }
        public double NetSales { get; set; }
        public ObservableCollection<double> SalesTrend { get; set; }
        public ObservableCollection<double> WinLoss { get; set; }
        public ObservableCollection<double> ProfitTrend { get; set; }
    }
}
