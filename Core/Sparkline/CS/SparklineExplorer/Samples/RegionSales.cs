using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

namespace SparklineExplorer.Samples
{
    public partial class RegionSales : UserControl
    {
        public RegionSales()
        {
            InitializeComponent();

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

            fxgRegionSales.AutoSizeCols(0,2,2);

        }
    }
}
