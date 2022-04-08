using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DashboardModel;
using C1.Win.Gauge;
using System.Windows.Data;
using System.Globalization;

namespace DashboardWinForms
{
    public partial class Gauges : UserControl
    {
        List<SaleGoalItem> _source;

        public Gauges(List<SaleGoalItem> source = null)
        {
            _source = source;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CreateGauges();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            CreateGauges();
        }

        private void CreateGauges()
        {
            c1Gauge1.Gauges.ClearAndDispose();
            if (_source == null || _source.Count == 0)
                return;
            var unitConv = new UnitConverter();
            var colorConv = new BarColorConverter();
            var badConv = new BadValueConverter();
            var goodConv = new GoodValueConverter();
            int mul = c1Gauge1.Height / 5;
            for (int i = 0; i < _source.Count; i++)
            {
                SaleGoalItem item = _source[i];
                var goal = (double)unitConv.Convert(item.Goal, null, null, null);
                var sale = (double)unitConv.Convert(item.Sales, null, null, null);
                var color = (Color)colorConv.Convert(item.CompletePrecent, null, null, null);
                var badGoal = (double)badConv.Convert(item.Goal, null, null, null);
                var goodGoal = (double)goodConv.Convert(item.Goal, null, null, null);
                C1LinearGauge g = new C1LinearGauge();
                g.Maximum = 100;
                g.Viewport.Y = i * mul;
                g.Viewport.X = 80;
                g.Viewport.Height = mul;
                g.Pointer.Visible = false;
                var d = new C1GaugeRange() { To = sale, Width = mul, Filling = new C1GaugeFilling() { Color = color } };
                d.Border.LineStyle = C1GaugeBorderStyle.None;
                g.Decorators.Add(d);
                var width = mul*2;
                d = new C1GaugeRange() { To = badGoal, Filling = new C1GaugeFilling() { Color = Color.FromArgb(0x4C000000) }, Width = width };
                d.Border.LineStyle = C1GaugeBorderStyle.None;
                g.Decorators.Add(d);
                d = new C1GaugeRange() { To = goodGoal, Filling = new C1GaugeFilling() { Color = Color.FromArgb(0x26000000) }, Width = width };
                d.Border.LineStyle = C1GaugeBorderStyle.None;
                g.Decorators.Add(d);
                g.Decorators.Add(new C1GaugeRange() { From = goal - 0.2, To = goal, Filling = new C1GaugeFilling() { Color = Color.Black }, Width = width });

                g.FaceShapes.Add(new C1GaugeCaption() { Text = item.Name, CenterPointX = -68.0 / Width });
                c1Gauge1.Gauges.Add(g);
            }
            var gauge = c1Gauge1.Gauges[_source.Count - 1];
            var marks = new C1GaugeMarks() { From = 0, To = 100, Interval = 20, Location = mul * 2 + 40, Shape = C1GaugeMarkShape.Round };
            gauge.Decorators.Add(marks);
            var labels = new C1GaugeLabels() { From = 0, To = 100, Interval = 20, Location = mul * 2 + 90 };
            gauge.Decorators.Add(labels);
        }

    }
}
