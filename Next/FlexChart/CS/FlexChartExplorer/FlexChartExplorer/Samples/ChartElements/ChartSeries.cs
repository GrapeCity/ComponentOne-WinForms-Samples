using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Chart;
using C1.Win.Chart;
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class ChartSeries : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public ChartSeries()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.SplineSymbols;
            this.flexChart1.Header.Content = "Revenue vs Expenses";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = SalesDataSource.GetCountrySales();
            this.flexChart1.BindingX = "Name";

            var ser1 = new Series
            {
                Binding = "Sales",
                Name = "Revenue",
            };
            ser1.Style.StrokeWidth = 3;
            var ser2 = new Series
            {
                Binding = "Expenses",
                Name = "Expenses",
                SymbolMarker = SymbolMarker.Box,
                SymbolSize = 10,
            };
            ser2.Style.StrokeDashPattern = new float[] { 2, 1 };

            this.flexChart1.Series.Add(ser1);
            this.flexChart1.Series.Add(ser2);
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            this.pnlControls.Hide();
        }
    }
}
