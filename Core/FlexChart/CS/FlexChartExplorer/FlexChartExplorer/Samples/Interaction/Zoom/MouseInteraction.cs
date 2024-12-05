using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlexChartExplorer.Data;
using C1.Win.Chart;
using C1.Chart;
using BaseExplorer;
using C1.Win.Chart.Interaction;

namespace FlexChartExplorer.Samples
{
    public partial class MouseInteraction : FlexChartBaseSample
    {
        FlexChart flexChart1;
        ButtonEx btnNewData;
        ComboBoxEx cbMode;
        TranslateBehavior translateBehavior;
        ZoomBehavior zoomBehavior;

        int nser = 8;
        int npts = 8000;

        public MouseInteraction()
        {
            InitializeComponent();
        }

        protected override void SetupChart()
        {
            // setup chart
            flexChart1.ToolTip.Content = null;
            flexChart1.AxisX.AxisLine = false;
            flexChart1.AxisX.MajorGrid = true;
            flexChart1.AxisX.Min = -2;
            flexChart1.AxisX.Max = 2;
            flexChart1.AxisY.Min = -2;
            flexChart1.AxisY.Max = 2;
            flexChart1.PlotStyle.StrokeColor = Color.LightGray;
            flexChart1.Legend.Position = Position.Right;
            flexChart1.RenderMode = RenderMode.DirectX;
            flexChart1.Binding = "Y";
            flexChart1.BindingX = "X";
            flexChart1.ChartType = ChartType.Scatter;
            flexChart1.Footer.Content = "Mouse Wheel: - zoom-in / zoom-out | Mouse Drag: Panning";

            // add mouse interaction
            flexChart1.Behaviors.Add(translateBehavior = new TranslateBehavior());
            flexChart1.Behaviors.Add(zoomBehavior = new ZoomBehavior());

            NewData();
        }

        static Random rnd = new Random();
        void NewData()
        {
            flexChart1.BeginUpdate();
            flexChart1.Series.Clear();

            for (double i = 0; i < nser; i++)
            {
                var series = new Series();
                series.Name = $"ser {i + 1}";
                series.SymbolSize = 6;
                series.DataSource = GetData(rnd.NextDouble() - 0.5, rnd.NextDouble() - 0.5, npts / nser, 0.5 * (1 - i / nser));
                flexChart1.Series.Add(series);
            }
            flexChart1.EndUpdate();
        }

        PointD[] GetData(double cx, double cy, int n, double maxr)
        {
            var data = new PointD[n];
            var r0 = 0.1 + maxr;
            for (int i = 0; i < data.Length; i++)
            {
                var a = 2 * Math.PI * rnd.NextDouble();
                var r = r0 * Math.Sqrt(-2 * Math.Log(rnd.NextDouble()));
                data[i] = new PointD() { X = cx + r * Math.Cos(a), Y = cy + r * Math.Sin(a) };
            }
            return data;
        }

        protected override void InitializeControls()
        {
            // initial chart setup
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;

            btnNewData = new ButtonEx("New Data");
            btnNewData.Click += (s, e) => NewData();
            pnlControls.Controls.Add(btnNewData);

            cbMode = new ComboBoxEx("Mode");

            cbMode.Items.AddRange(new object[] { GestureMode.X, GestureMode.Y, GestureMode.XY });
            cbMode.SelectedIndex = 2;
            cbMode.SelectedIndexChanged += (s, e) =>
              translateBehavior.Mode = zoomBehavior.Mode = (GestureMode)cbMode.SelectedItem;

            pnlControls.Controls.Add(cbMode);
        }
    }
}
