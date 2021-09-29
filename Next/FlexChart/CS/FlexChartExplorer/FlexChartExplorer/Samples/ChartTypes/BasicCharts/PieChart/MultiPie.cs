using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.Chart;
using C1.Chart;
using BaseExplorer;
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class MultiPie : FlexChartBaseSample
    {
        private ComboBoxEx _cbShow;
        public MultiPie()
        {
            InitializeComponent();
        }

        protected override void SetupChart()
        {
            var _flexPie = this.Chart as FlexPie;
            _flexPie.BindingName = "Name";
            _flexPie.Binding = "WinterOnline,WinterOffline,SummerOnline,SummerOffline";
            _flexPie.Header.Content = "Product Sales By Season";
            _flexPie.Header.Style.Font = StyleInfo.ChartHeaderFont;
            _flexPie.ToolTip.Content = "{Name} : {value}";
            _flexPie.DataSource = SalesDataSource.GetSeasonSales(5);
            _flexPie.Titles = AdjustTitles(_flexPie.Binding.Split(','));
        }
        protected override void InitializeControls()
        {
            this.Chart = new FlexPie { Dock = DockStyle.Fill };

            var bindings = new string[] {
                "WinterOnline,WinterOffline,SummerOnline,SummerOffline",
                "OfflineTotal,OnlineTotal",
                "WinterTotal,SummerTotal",
                "TotalSales"
            };
            _cbShow = new ComboBoxEx("Show", 150);
            _cbShow.DataSource = new string[] { "Season & Channel", "Offline vs Online", "Winter vs Summer", "Total" };
            _cbShow.SelectedIndexChanged += (sender, eventArgs) =>
            {
                var pie = (this.Chart as FlexPie);
                pie.Binding = bindings[_cbShow.SelectedIndex];
                // adjust titles
                pie.Titles = AdjustTitles(pie.Binding.Split(','));
            };

            this.pnlControls.Controls.Add(_cbShow);
        }

        string[] AdjustTitles(string[] titles)
        {
            if (titles.Length > 1)
            {
                for (var i = 0; i < titles.Length; i++)
                {
                    titles[i] = titles[i].Replace("Total", "");
                    // add space
                    titles[i] = string.Concat(titles[i].Select(x => Char.IsUpper(x) ? " " + x : x.ToString())).TrimStart(' ');
                }
            }
            else
                titles = null;

            return titles;
        }
    }
}
