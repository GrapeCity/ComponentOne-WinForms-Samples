using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Chart;
using C1.Win.Chart;

using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class Bubble : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public Bubble()
        {
            InitializeComponent();
        }

        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Futures & Commodities Investment Analysis";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.BindingX = "Age";
            this.flexChart1.Options.BubbleMaxSize = 60;
            this.flexChart1.Options.BubbleMinSize = 10;
            this.flexChart1.ToolTip.Content = "AOI : {x}\n{seriesName} : {Amount:c}\nReturn : {Return:p}";

            Series series = new Series { Binding = "Amount,Return", Name="Investment" };
            this.flexChart1.Series.Add(series);

            this.flexChart1.AxisY.Format = "c0";
            this.flexChart1.AxisY.Title = "Investment Amount";
            this.flexChart1.AxisY.TitleStyle.Font = StyleInfo.AxisTitleFont;

            this.flexChart1.AxisX.Title = "Investment Duration (Years)";
            this.flexChart1.AxisX.TitleStyle.Font = StyleInfo.AxisTitleFont;

            this.flexChart1.ChartType = ChartType.Bubble;
            this.flexChart1.DataSource = FinancialDataSource.GetInvestmentData();
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
