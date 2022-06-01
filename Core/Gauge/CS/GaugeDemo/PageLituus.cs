using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using C1.Win.Gauge;

namespace GaugeDemo
{
    public partial class PageLituus : BaseGaugePage
    {
        public PageLituus()
        {
            InitializeComponent();
            FillDecorators();
        }

        private void FillDecorators()
        {
            c1Gauge1.BeginUpdate();

            CommonColorMap colorMap = new CommonColorMap();
            colorMap.Name = "green";
            colorMap.ValueColorFalloff = C1GaugeValueColorFalloff.None;
            colorMap.ValueColors.Add(new C1GaugeValueColor(0.0, Color.LimeGreen, 1.0));
            colorMap.ValueColors.Add(new C1GaugeValueColor(double.NaN, 100, Color.DimGray, 1.0));
            c1LinearGauge1.ColorMaps.Add(colorMap);

            colorMap = new CommonColorMap();
            colorMap.Name = "yellow";
            colorMap.ValueColorFalloff = C1GaugeValueColorFalloff.None;
            colorMap.ValueColors.Add(new C1GaugeValueColor(0.0, Color.Yellow, 1.0));
            colorMap.ValueColors.Add(new C1GaugeValueColor(double.NaN, 100, Color.DimGray, 1.0));
            c1LinearGauge1.ColorMaps.Add(colorMap);

            colorMap = new CommonColorMap();
            colorMap.Name = "red";
            colorMap.ValueColorFalloff = C1GaugeValueColorFalloff.None;
            colorMap.ValueColors.Add(new C1GaugeValueColor(0.0, Color.FromArgb(255, 64, 64), 1.0));
            colorMap.ValueColors.Add(new C1GaugeValueColor(double.NaN, 100, Color.DimGray, 1.0));
            c1LinearGauge1.ColorMaps.Add(colorMap);

            for (int i = 0; i < 100; i++)
            {
                C1GaugeSingleMark mark = new C1GaugeSingleMark();
                mark.Border.LineStyle = C1GaugeBorderStyle.None;
                mark.Shape = C1GaugeMarkShape.Round;
                mark.Width = 2;
                double dl = i * 0.035;
                mark.Length = 6 + dl * dl * dl;
                if (i < 60)
                    mark.ColorMapName = "green";
                else if (i < 85)
                    mark.ColorMapName = "yellow";
                else
                    mark.ColorMapName = "red";
                mark.Value = i / 100.0;

                double x, y;
                GetXY(i, out x, out y);
                mark.Position = x * 0.01 + 0.27;
                mark.Location = y + 35;

                double x1, y1;
                GetXY(i + 0.01, out x1, out y1);
                double dy = (y1 - y) * 0.75;
                double l = Math.Sqrt((x1 - x) * (x1 - x) + dy * dy);
                double alpha = Math.Asin(dy / l);
                if (x1 < x)
                {
                    alpha = Math.PI - alpha;
                }
                mark.ShapeAngle = alpha * 180.0 / Math.PI;

                c1LinearGauge1.Decorators.Add(mark);
            }
            c1Gauge1.EndUpdate();
        }

        private static void GetXY(double a, out double x, out double y)
        {
            a = 120.0 - a;
            double phi = a * a * Math.PI / 5000.0;
            double ro = 36.0 / Math.Sqrt(phi);
            x = Math.Cos(phi) * ro;
            y = Math.Sin(phi) * ro * 1.5;
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            c1LinearGauge1.Value = trackBar1.Value / 100.0;
        }
    }
}
