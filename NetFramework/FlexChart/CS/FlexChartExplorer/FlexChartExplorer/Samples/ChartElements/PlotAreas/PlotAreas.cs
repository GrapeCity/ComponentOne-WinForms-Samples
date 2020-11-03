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
    public partial class PlotAreas : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public PlotAreas()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            flexChart1.ChartType = ChartType.Area;
            this.flexChart1.Header.Content = "Distance, Velocity and Acceleration Graphs";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            flexChart1.PlotAreas.Add(new PlotArea { Name = "plot1", Row = 0 });
            flexChart1.PlotAreas.Add(new PlotArea { Name = "spacing1", Row = 1 });
            flexChart1.PlotAreas.Add(new PlotArea { Name = "plot2", Row = 2 });
            flexChart1.PlotAreas.Add(new PlotArea { Name = "spacing2", Row = 3 });
            flexChart1.PlotAreas.Add(new PlotArea { Name = "plot3", Row = 4 });

            flexChart1.BindingX = "X";
            flexChart1.Binding = "Y";
            var acceleration = new Series
            {
                Name = "Acceleration",
                DataSource = DataService.CreateDataPoints((x) => x, (y) => y, 20),
                AxisY = new Axis
                {
                    Position = Position.Left,
                    MajorGrid = true,
                    PlotAreaName = "plot1"
                }
            };
            var velocity = new Series
            {
                Name = "Velocity",
                DataSource = DataService.CreateDataPoints((x) => x, (y) => y * y, 20),
                AxisY = new Axis
                {
                    Position = Position.Left,
                    MajorGrid = true,
                    PlotAreaName = "plot2"
                }
            };
            var distance = new Series
            {
                Name = "Distance",
                DataSource = DataService.CreateDataPoints((x) => x, (y) => 0.5 * y * y * y, 20),
                AxisY = new Axis
                {
                    Position = Position.Left,
                    MajorGrid = true,
                    PlotAreaName = "plot3"
                }
            };
            this.flexChart1.Legend.Position = Position.Right;
            this.flexChart1.Series.Add(acceleration);
            this.flexChart1.Series.Add(velocity);
            this.flexChart1.Series.Add(distance);
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
        }
    }
}
