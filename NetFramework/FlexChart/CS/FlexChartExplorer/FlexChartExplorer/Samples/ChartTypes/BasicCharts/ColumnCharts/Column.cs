using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlexChartExplorer.Data;
using C1.Chart;
using C1.Win.Chart;

namespace FlexChartExplorer.Samples
{
    public partial class Column : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public Column()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Populous Countries";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = Demographics.GetPopulationEducation().OrderByDescending(x=>x.TotalPopulation);
            this.flexChart1.BindingX = "Name";
            this.flexChart1.Series.Add(new Series { Name = "Population", Binding = "TotalPopulation" });
            this.flexChart1.AxisX.AxisLine = false;

            this.flexChart1.AxisY.Format = "#,##0,,M";
            this.flexChart1.ToolTip.Content = "{y:0}";
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
