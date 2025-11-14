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

namespace ControlExplorer.FlexChart
{
    public partial class MultiPie : C1DemoForm
    {
        public MultiPie()
        {
            var _flexPie = new FlexPie { Dock = DockStyle.Fill };
            _flexPie.BindingName = "Name";
            _flexPie.Binding = "WinterOnline,WinterOffline,SummerOnline,SummerOffline";
            _flexPie.Header.Content = "Product Sales By Season";
            _flexPie.ToolTip.Content = "{Name} : {value}";
            _flexPie.DataSource = SeasonSale.GetSeasonSales(5);
            _flexPie.Titles = AdjustTitles(_flexPie.Binding.Split(','));
            _flexPie.Legend.Position = Position.Bottom;
            _flexPie.Dock = DockStyle.Fill;
            this.Chart = _flexPie;

            this.Controls.Add(_flexPie);

            InitializeComponent();

            // initialize combo for switching FlexPie bindings
            var bindings = new string[] {
                "WinterOnline,WinterOffline,SummerOnline,SummerOffline",
                "OfflineTotal,OnlineTotal",
                "WinterTotal,SummerTotal",
                "TotalSales"
            };
            var chartTypes = new string[] { "Season & Channel", "Offline vs Online", "Winter vs Summer", "Total" };
            cmbChartTypes.ItemsDataSource = chartTypes;
            cmbChartTypes.SelectedIndexChanged += (sender, eventArgs) =>
            {
                var pie = (this.Chart as FlexPie);
                if (pie is null) return;

                // change binding based on selected chart type
                try
                {
                    pie.Binding = bindings[cmbChartTypes.SelectedIndex];   
                }
                catch (IndexOutOfRangeException e)
                {
                    pie.Binding = bindings[0];
                }
                pie.Titles = AdjustTitles(pie.Binding.Split(','));
            };
            this.Disposed += OnDisposed;
        }

        private void OnDisposed(object sender, EventArgs e)
        {
            if (Chart != null)
            {
                if (Chart.ToolTip != null)
                    Chart.ToolTip.Dispose();
            }
        }

        public FlexChartBase Chart
        {
            get;
            protected set;
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

        public class SeasonSale
        {
            public string Name { get; set; }
            public double WinterOnline { get; set; }
            public double WinterOffline { get; set; }
            public double SummerOnline { get; set; }
            public double SummerOffline { get; set; }
            public double TotalSales
            {
                get
                {
                    return WinterOnline + WinterOffline + SummerOffline + SummerOnline;
                }
            }
            public double WinterTotal { get { return WinterOnline + WinterOffline; } }
            public double SummerTotal { get { return SummerOnline + SummerOffline; } }
            public double OnlineTotal { get { return WinterOnline + SummerOnline; } }
            public double OfflineTotal { get { return WinterOffline + SummerOffline; } }


            static string[] salesItems = "Computers|Software|Cell Phones|Video Games|Musical Instruments|Household Electronic Items|Sports & Fitness|Jewellery & Accessories|Furniture|Clothing".Split('|');

            public static List<SeasonSale> GetSeasonSales(int numOfCategories)
            {
                var rnd = new Random();
                var data = new List<SeasonSale>();
                for (int i = 0; i < numOfCategories; i++)
                {
                    var item = salesItems[i];
                    data.Add(new SeasonSale
                    {
                        Name = item,
                        WinterOnline = rnd.Next(10, 100),
                        SummerOnline = rnd.Next(10, 100),
                        WinterOffline = rnd.Next(10, 100),
                        SummerOffline = rnd.Next(10, 100),
                    });
                }
                return data;
            }
        }
    }
}
