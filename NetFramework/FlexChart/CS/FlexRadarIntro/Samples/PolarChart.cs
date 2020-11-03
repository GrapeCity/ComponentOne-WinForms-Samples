using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Win.Chart;

namespace FlexRadarIntro.Samples
{
    public partial class PolarChart : UserControl
    {
        public PolarChart()
        {
            InitializeComponent();
        }

        private void BasicFeatures_Load(object sender, EventArgs e)
        {
            flexRadar.BeginUpdate();

            flexRadar.ChartType = C1.Chart.RadarChartType.LineSymbols;

            flexRadar.Binding = "Y";
            flexRadar.BindingX = "X";
            flexRadar.DataSource = CreateData(10, 2);
            flexRadar.Series.Add(new RadarSeries() { SymbolSize = 4 });

            flexRadar.AxisY.Min = 0;
            flexRadar.AxisX.MajorUnit = 45;

            flexRadar.EndUpdate();
        }

        List<PointF> CreateData(double k, double a)
        {
            var pts = new List<PointF>();
            int n = 360;
            for (var i = 0; i < n; i++)
            {
                var angle = Math.PI * i / 180;
                pts.Add(new PointF() { X = i, Y = (float)(Math.Cos(k * angle) + a) });
            }
            return pts;
        }

        private void numericUpDownStartAngle_ValueChanged(object sender, EventArgs e)
        {
            flexRadar.DataSource = CreateData((double)numericUpDownStartAngle.Value, (double)numericUpDown2.Value);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            flexRadar.DataSource = CreateData((double)numericUpDownStartAngle.Value, (double)numericUpDown2.Value);
        }
    }
}
