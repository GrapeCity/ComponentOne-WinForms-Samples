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

namespace ControlExplorer.FlexChart
{
    public partial class CustomAnimation : C1DemoForm
    {
        int npts = 100;
        C1.Win.Chart.FlexChart chart;

        public CustomAnimation()
        {
            InitializeComponent();
        }

        private void CustomAnimation_Load(object sender, EventArgs e)
        {
            chart = new C1.Win.Chart.FlexChart() { Dock = DockStyle.Fill, ChartType = ChartType.Scatter };

            chart.AxisX.Origin = chart.AxisY.Origin = 0;
            chart.AxisX.Min = chart.AxisY.Min = -1;
            chart.AxisX.Max = chart.AxisY.Max = 1;
            chart.AxisY.AxisLine = true;
            chart.AxisY.MajorGrid = false;

            chart.AnimationTransform += AnimationTransform;
            chart.AnimationLoad.Direction = AnimationDirection.XY;
            chart.AnimationLoad.Easing = Easing.Linear;
            chart.AnimationSettings = AnimationSettings.All;

            tableLayoutPanel1.Controls.Add(chart);

            AddsSeries();
        }

        private void AddSer_Click(object sender, EventArgs e)
        {
            AddsSeries();
        }

        private void DelSer_Click(object sender, EventArgs e)
        {
            if (chart.Series.Count > 0)
                chart.Series.RemoveAt(chart.Series.Count - 1);
        }

        private void chart_Loaded(object sender, EventArgs e)
        {
            AddsSeries();
        }

        void AddsSeries()
        {
            var pts = new PointF[npts];
            var rnd = new Random();
            for (var i = 0; i < npts; i++)
                pts[i] = new PointF( 2 * ((float)rnd.NextDouble() - 0.5f), 2 * ((float)rnd.NextDouble() - 0.5f));
            var ser = new Series() { BindingX = "X", Binding = "Y", DataSource = pts, SymbolSize = 4 };
            chart.Series.Add(ser);
        }

        private void AnimationTransform(object sender, AnimationTransformEventArgs e)
        {
            var center = ((PointF[])e.Series.DataSource)[0];
            e.Start = e.AxisType == AxisType.X ? center.X : center.Y;
        }
    }
}
