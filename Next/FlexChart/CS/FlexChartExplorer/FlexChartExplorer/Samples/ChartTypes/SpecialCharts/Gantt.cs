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
    public partial class Gantt : FlexChartBaseSample
    {
        static Color[] colors = new Color[]
        {
            Color.FromArgb(171, 208, 237),
            Color.FromArgb(252, 201, 137),
            Color.FromArgb(177, 220, 182),
            Color.FromArgb(248, 195, 217),
            Color.FromArgb(210, 192, 135),
            Color.FromArgb(200, 190, 235),
            Color.FromArgb(245, 245, 100),
            Color.FromArgb(255, 155, 155),
            Color.FromArgb(187, 187, 187),
            Color.FromArgb(175, 255, 255),
        };
        static List<Task> taskData;
        private FlexChart flexChart1;

        public Gantt()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.Bar;
            this.flexChart1.BindingX = "Name";

            Series series = new GanttSeriesWithPointLegendItems() { Binding = "End"};
            series.SymbolRendering += Series_SymbolRendering;
            this.flexChart1.Series.Add(series);

            this.flexChart1.DataLabel.Content = "{DurationInWeeks} - Weeks";
            this.flexChart1.DataLabel.Position = LabelPosition.Left;
            this.flexChart1.DataSource = taskData = DataService.GetTasksData();
            this.flexChart1.AxisX.Min = taskData[taskData.Count-1].Start.ToOADate();
            this.flexChart1.AxisX.MajorGrid = true;
            this.flexChart1.AxisX.MajorUnit = 14D;
            this.flexChart1.AxisX.Format = "MMM-dd";
            this.flexChart1.Header.Content = "Project Schedule";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
        }
        public class GanttSeriesWithPointLegendItems : Series, ISeries
        {
            string ISeries.GetLegendItemName(int index) { return taskData.ElementAt(taskData.Count - 1 - index).Name; }
            _Style ISeries.GetLegendItemStyle(int index)
            {
                return new _Style { Fill = new SolidBrush(colors[(index)%colors.Length]) };
            }
            int ISeries.GetLegendItemLength() { return taskData.Count; }
        }

        private void Series_SymbolRendering(object sender, RenderSymbolEventArgs e)
        {
            e.Cancel = true;
            Task task = (Task)e.Item;
            var height = this.flexChart1.PlotRect.Height / ((List<Task>)this.flexChart1.DataSource).Count / 2;
            var start = this.flexChart1.AxisX.Convert(task.Start.ToOADate());
            e.Engine.SetFill(new SolidBrush(colors[(taskData.Count-1-e.Index) % colors.Length]));
            e.Engine.SetStroke(new SolidBrush(colors[(taskData.Count-1-e.Index) % colors.Length]));
            e.Engine.DrawRect(start, e.Point.Y-height/2, e.Point.X-start, height);
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
