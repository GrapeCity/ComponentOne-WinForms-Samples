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
    public partial class Tornado : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public Tornado()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var data = Demographics.GetPopulationEducation();
            data = data.OrderBy(x => x.MalePopulation + x.FemalePopulation).ToList();
            
            this.flexChart1.ChartType = ChartType.Bar;
            this.flexChart1.Header.Content = "Population Pyramid";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = data;
            this.flexChart1.BindingX = "Name";
            this.flexChart1.PlotAreas.Add(new PlotArea { Name = "plot1", Column = 0 });
            this.flexChart1.PlotAreas.Add(new PlotArea { Name = "plot2", Column = 1 });
            
            var males = new Series()
            {
                Name = "Male", Binding = "MalePopulation",
                DataLabel = new DataLabel { Content= "{y: #,##0,,M}", Position = LabelPosition.Right},
                AxisX = new Axis { Position = Position.Bottom, PlotAreaName = "plot1", Reversed = true, AxisLine = false, Labels = false, MinorTickMarks = TickMark.None, LogBase = 10, Min=1000000},
            };
            var females = new Series
            {
                Name = "Female", Binding = "FemalePopulation",
                DataLabel = new DataLabel { Content = "{y: #,##0,,M}", Position = LabelPosition.Left},
                AxisX = new Axis { Position = Position.Bottom, PlotAreaName = "plot2",  AxisLine = false, Labels = false, MinorTickMarks = TickMark.None, LogBase = 10, Min = 1000000 },                
            };

            this.flexChart1.Series.Add(males);
            this.flexChart1.Series.Add(females);

            this.flexChart1.DataLabel.Overlapping = LabelOverlapping.Show;
            this.flexChart1.AxisX.AxisLine = false;
            this.flexChart1.AxisY.MajorGrid = false;
            this.flexChart1.AxisY.MajorTickMarks = TickMark.Outside;
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
    
}
