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
    public partial class Area : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public Area()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.Area;
            this.flexChart1.Header.Content = "Newspapers Losing Relevance as News Source";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = DataService.GetNewsSourcesInfo();
            this.flexChart1.BindingX = "Year";

            this.flexChart1.Series.Add(new Series { Name = "Newspaper", Binding = "Newspaper" });
            this.flexChart1.Series.Add(new Series { Name = "Internet", Binding = "Internet" });

            this.flexChart1.AxisY.Format = "p0";
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
