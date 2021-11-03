using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using C1.Win.Chart;
using C1.Chart;
using System;

namespace FloatingBarChart.Samples
{
    public partial class CustomizedGannt : UserControl
    {
        public CustomizedGannt()
        {
            InitializeComponent();
            InitializeControls();
            SetupChart();
        }

        List<Task> _tasks;

        List<Task> GetChartData()
        {
            var year = DateTime.Now.Year;
            return new List<Task>() {
                new Task("Task1", new DateTime(year, 1, 1), new DateTime(year, 3, 31), null, 100),
                new Task("Task2", new DateTime(year, 4, 1), new DateTime(year, 4, 30), "Task1", percent: 100),
                new Task("Task3", new DateTime(year, 5, 1), new DateTime(year, 7, 31), "Task2", percent: 75),
                new Task("Task4", new DateTime(year, 4, 1), new DateTime(year, 7, 31), "Task1", percent: 33),
                new Task("Task5", new DateTime(year, 8, 1), new DateTime(year, 9, 30), "Task3,Task4", percent: 0),
                new Task("Task6", new DateTime(year, 10, 1), new DateTime(year, 12, 31), "Task1,Task5", percent: 0),
                new Task("Task7", new DateTime(year, 1, 1), new DateTime(year, 12, 31), null, percent: 50)
            };
        }

        class Task
        {
            public string Name { get; set; }
            public DateTime Start { get; set; }
            public DateTime End { get; set; }

            public string Parent { get; set; }
            public double Percent { get; set; }

            public Task(string name, DateTime start, DateTime end, string parent, double percent)
            {
                Name = name;
                Start = start;
                End = end;
                Parent = parent;
                Percent = percent;
            }
        }

        void SetupChart()
        {
            flexChart1.BeginUpdate();

            _tasks = GetChartData();
            flexChart1.DataSource = _tasks;
            flexChart1.ToolTip.Content = "{Name}:\r{Start:d} - {End:d}\rpercent complete: {Percent}%";
            flexChart1.ChartType = ChartType.Bar;
            flexChart1.BindingX = "Name";
            flexChart1.AxisY.Reversed = true;
            flexChart1.AxisY.MajorGrid = false;
            flexChart1.AxisY.MinorGrid = true;
            flexChart1.AxisY.MinorGridStyle.StrokeColor = Color.LightGray;
            flexChart1.AxisX.Min = _tasks.Min(t => t.Start).ToOADate();
            flexChart1.AxisX.Format = "MMM yyyy";

            flexChart1.Series.Clear();
            var series = new Series();
            flexChart1.Series.Add(series);
            series.Binding = "Start,End";
            series.SymbolRendered += Series_SymbolRendered;

            flexChart1.Rendered += FlexChart1_Rendered;
            flexChart1.EndUpdate();
        }

        private void FlexChart1_Rendered(object sender, RenderEventArgs e)
        {
            _tasks.ForEach(task => {
                var parents = GetTaskParents(task);
                parents.ForEach(parent => {
                    DrawConnectingLine(e.Engine, task, parent);
                });
            });
        }

        private List<Task> GetTaskParents(Task task)
        {
            var parents = new List<Task>();
            if (task.Parent != null)
            {
                string[] names = task.Parent.Split(',');
                foreach (string name in names)
                {
                    var parent = _tasks.Find(t => t.Name == name);
                    if (parent != null)
                    {
                        parents.Add(parent);
                    }
                }
            }
            return parents;
        }

        private void Series_SymbolRendered(object sender, RenderSymbolEventArgs e)
        {
            var task = (Task)e.Item;
            var rect = GetTaskRect(task);
            rect.Inflate(-8, -8);
            var pct = task.Percent;
            var clap = (pct < 0 ? 0 : (pct > 100 ? 100 : pct)) / 100;
            e.Engine.SetFill(new SolidBrush(clap == 1 ? Color.Green : Color.Gold));
            e.Engine.DrawRect(rect.Left, rect.Top, rect.Width * pct / 100, rect.Height);
        }

        RectangleF GetTaskRect(Task task)
        {
            float left = (float)flexChart1.AxisX.Convert(task.Start.ToOADate());
            float right = (float)flexChart1.AxisX.Convert(task.End.ToOADate());
            var index = _tasks.IndexOf(task);
            float top = (float)flexChart1.AxisY.Convert(index - 0.35);
            float bottom = (float)flexChart1.AxisY.Convert(index + 0.35);
            return new RectangleF(left, top, right - left, bottom - top);
        }

        void DrawConnectingLine(IRenderEngine engine, Task task, Task parent)
        {
            var rc1 = GetTaskRect(parent);      // parent rect
            var rc2 = GetTaskRect(task);        // task rect
            var x1 = rc1.Left + rc1.Width / 2;  // parent x center
            var x2 = rc2.Left;                  // task left
            var y1 = rc1.Bottom;                // parent bottom
            var y2 = rc2.Top + rc2.Height / 2;  // task y center

            // draw connecting line
            var xs = new double[] { x1, x1, x2 };
            var ys = new double[] { y1, y2, y2 };
            engine.SetStroke(new SolidBrush(Color.Black));
            engine.DrawLines(xs, ys);

            // draw arrow at the end
            var sz = 5;
            xs = new double[] { x2 - 2 * sz, x2, x2 - 2 * sz };
            ys = new double[] { y2 - sz, y2, y2 + sz };
            engine.SetFill(new SolidBrush(Color.Black));
            engine.DrawPolygon(xs, ys);
        }

        private void InitializeControls()
        {
            //Set localized content
            baseSample1.lblTitle.Text = Localizer.GetItem("customized", "title");
            baseSample1.tbDescription.Rtf = Localizer.GetItem("customized", "description").MakeRtf();
            flexChart1 = baseSample1.flexChart1;
        }
    }
}
