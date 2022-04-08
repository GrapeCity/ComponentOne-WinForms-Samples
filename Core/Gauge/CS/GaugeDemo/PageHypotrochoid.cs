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
    public partial class PageHypotrochoid : BaseGaugePage
    {
        private const double _chainLength = 25.0;
        private double _value = _chainLength;

        public PageHypotrochoid()
        {
            InitializeComponent();
            c1LinearGauge1.MorePointers[0].Value = _value;
            FillDecorators();
        }

        protected override void OnTimer()
        {
            _value += 2.0;
            if (_value > 100.0)
            {
                _value = 0.0;
            }
            if (_value <= _chainLength)
            {
                c1LinearGauge1.MorePointers[2].Value = _value;
                c1LinearGauge1.MorePointers[1].Value = 100.0 + _value - _chainLength;
                c1LinearGauge1.MorePointers[0].Value = double.NaN;
            }
            else
            {
                c1LinearGauge1.MorePointers[2].Value = 0.0;
                c1LinearGauge1.MorePointers[1].Value = _value - _chainLength;
                c1LinearGauge1.MorePointers[0].Value = _value;
            }
        }

        private void FillDecorators()
        {
            c1Gauge1.BeginUpdate();

            CommonShape commonShape = new CommonShape();
            commonShape.Name = "my arrow";
            commonShape.StartWidth = 2.5;
            commonShape.EndAngle = 60.0;
            commonShape.EndWidth = 2.5;
            commonShape.EndSwellWidth = 1;
            c1Gauge1.CommonShapes.Add(commonShape);

            CommonColorMap colorMap = new CommonColorMap();
            colorMap.Name = "my colors";
            colorMap.ValueColorFalloff = C1GaugeValueColorFalloff.None;
            colorMap.ValueColors.Add(new C1GaugeValueColor(0.0, Color.SteelBlue, 1.0));
            colorMap.ValueColors.Add(new C1GaugeValueColor(double.NaN, 2, Color.Transparent, 1.0));
            colorMap.ValueColors.Add(new C1GaugeValueColor(double.NaN, 1, Color.SteelBlue, 1.0));
            colorMap.ValueColors.Add(new C1GaugeValueColor(double.NaN, 0, Color.Transparent, 1.0));
            c1LinearGauge1.ColorMaps.Add(colorMap);

            for (int i = 0; i <= 100; i += 2)
            {
                C1GaugeSingleMark mark = new C1GaugeSingleMark();
                mark.Border.Color = Color.LightSteelBlue;
                mark.Filling.BrushType = C1GaugeBrushType.Gradient;
                mark.Filling.Color2 = Color.LightSteelBlue;
                mark.Gradient.Direction = C1GaugeGradientDirection.RadialOuter;
                mark.CustomShape.CommonShapeName = "my arrow";
                mark.Length = 6;
                mark.Width = 2.5;
                mark.ColorMapName = "my colors";
                mark.Value = i;

                double x, y;
                GetXY(i, out x, out y);
                mark.Position = x * 0.01 + 0.5;
                mark.Location = y + 50;

                double x1, y1;
                GetXY(i + 0.01, out x1, out y1);
                double l = Math.Sqrt((x1 - x) * (x1 - x) + (y1 - y) * (y1 - y));
                double alpha = Math.Asin((y1 - y) / l);
                if (x1 < x)
                {
                    alpha = Math.PI - alpha;
                }
                mark.ShapeAngle = -alpha * 180.0 / Math.PI + 90.0;

                c1LinearGauge1.Decorators.Add(mark);
            }
            c1Gauge1.EndUpdate();
        }

        private static void GetXY(double a, out double x, out double y)
        {
            const double R = 36.0;
            const double r = 12.0;
            const double h = 30.0;
            double phi = a * Math.PI / 50.0;
            double d = R - r;
            double t = d * phi / r;
            x = Math.Cos(phi) * d + Math.Cos(t) * h;
            y = Math.Sin(phi) * d - Math.Sin(t) * h;
        }
    }
}
