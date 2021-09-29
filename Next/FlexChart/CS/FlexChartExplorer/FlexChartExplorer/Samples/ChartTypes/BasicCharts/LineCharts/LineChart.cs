using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Chart;
using FlexChartExplorer.Data;
using C1.Win.Chart;

namespace FlexChartExplorer.Samples
{
    public partial class LineChart : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public LineChart()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.Line;
            this.flexChart1.DataSource = FinancialDataSource.GetQuotes(100);

            this.flexChart1.BindingX = "Date";
            this.flexChart1.Series.Add(new Series { Binding = "High", Name = "Highs" });
            this.flexChart1.Series.Add(new Series { Binding = "Low", Name = "Lows" });

            this.flexChart1.Header.Content = "Daily Price Movement";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
