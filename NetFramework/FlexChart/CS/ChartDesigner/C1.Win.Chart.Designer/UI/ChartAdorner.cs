using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using C1.Chart;

namespace C1.Win.Chart.Designer.UI
{
    class ChartAdorner
    {
        class Styles
        {
            public static Brush DropAreaFill = new SolidBrush(Color.FromArgb(128, Color.White));
            public static Brush DropAreaText = Brushes.DarkGray;
            public static Pen DropAreaPen = Pens.DarkGray;

            public static Font TextFont = new Font("Segoe UI", 12, FontStyle.Regular);
            public static Font HeaderFont = new Font("Segoe UI", 10, FontStyle.Regular);

            public static Brush HoverFill = new SolidBrush(Color.FromArgb(32, Color.White));
            public static Brush HoverText = Brushes.DarkGray;
            public static Pen HoverPen = Pens.DarkGray;

            public static Pen SelectionPen = new Pen(Color.DarkGray);// { DashPattern = new float[] { 3, 3} };
        }

        ChartElement activeElement = ChartElement.None;
        ChartElement hoverElement = ChartElement.None;
        ChartElement selectedElement = ChartElement.None;

        SolidBrush dragFill = new SolidBrush(Color.FromArgb(64, 255, 0, 0));
        Pen dragPen = Pens.Red;

        Series hoverSeries, selectedSeries;
        Axis hoverAxis, selectedAxis;

        FlexChartBase chart;
        _Point center;
        double radius;

        public ChartAdorner(FlexChartBase chart)
        {
            this.chart = chart;
            Attach();
        }

        FlexChart FlexChart
        {
            get { return chart as FlexChart; }
        }

        FlexPie FlexPie
        {
            get { return chart as FlexPie; }
        }

        DataLabelBaseProperties DataLabelProperties
        {
            get
            {
                if (FlexChart != null)
                    return new DataLabelProperties(FlexChart.DataLabel, chart);
                if (FlexPie != null)
                    return new PieDataLabelProperties(FlexPie.DataLabel, chart);
                return null;
            }
        }

        internal void Attach()
        {
            if (FlexChart != null)
                Attach(FlexChart);
            else if (FlexPie != null)
                Attach(FlexPie);
        }

        internal void Detach()
        {
            if (FlexChart != null)
                Detach(FlexChart);
            else if (FlexPie != null)
                Detach(FlexPie);
        }

        #region FlexChart

        void Attach(FlexChart fc)
        {
            fc.Rendered += OnRendered;
            fc.MouseMove += OnMouseMove;
            fc.Click += OnClick;
        }

        void Detach(FlexChart fc)
        {
            if (SelectedSeries != null)
                SelectedSeries = null;

            fc.Rendered -= OnRendered;
            fc.MouseMove -= OnMouseMove;
            fc.Click -= OnClick;
        }

        private void SymbolRendered(object sender, RenderSymbolEventArgs e)
        {
            var g = e.Graphics;
            var pen = Styles.SelectionPen;
            var rf = new RectangleF(e.Point.X - 5, e.Point.Y - 5, 10, 10);
            g.DrawEllipse(pen, rf.Left - 3, rf.Top - 3, 6, 6);
            g.DrawEllipse(pen, rf.Right - 3, rf.Top - 3, 6, 6);
            g.DrawEllipse(pen, rf.Left - 3, rf.Bottom - 3, 6, 6);
            g.DrawEllipse(pen, rf.Right - 3, rf.Bottom - 3, 6, 6);
        }

        #endregion

        #region FlexPie

        void Attach(FlexPie fp)
        {
            fp.SliceRendered += (s, a) =>
            {
                center = new _Point(a.CenterX, a.CenterY);
                radius = a.Radius;
            };
            fp.Rendered += PieOnRendered;
            fp.MouseMove += PieOnMouseMove;
            fp.Click += OnClick;
        }

        void Detach(FlexPie fp)
        {
            fp.Rendered -= PieOnRendered;
            fp.MouseMove -= PieOnMouseMove;
            fp.Click -= OnClick;
        }

        private void PieOnMouseMove(object sender, MouseEventArgs e)
        {
            var ht = FlexPie.HitTest(e.Location);
            var par = new _Rect(center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
            var el = ht.ChartElement;
            if (par.Contains(e.X, e.Y))
                el = ChartElement.PlotArea;
            HoverElement = el;
        }

        private void PieOnRendered(object sender, RenderEventArgs e)
        {
            Draw(e.Graphics);
        }

        #endregion

        private void OnClick(object sender, EventArgs e)
        {
            selectedAxis = hoverAxis;
            SelectedElement = HoverElement;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            var ht = FlexChart.HitTest(e.Location);
            if (ht != null)
            {
                HoverElement = ht.ChartElement;
                HoverSeries = ht.Distance <= 8 ? ht.Series as Series : null;
                hoverAxis = (Axis)ht.Axis;
            }
        }

        private void OnRendered(object sender, RenderEventArgs e)
        {
            Draw(e.Graphics);
        }

        void Draw(Graphics g)
        {
            var fc = FlexChart;

            var axr = new _Rect();
            var ayr = new _Rect();
            var par = new _Rect();

            if (fc != null)
            {
                axr = ((IChart)fc).AxisX.Rect;
                ayr = ((IChart)fc).AxisY.Rect;
                par = ((IChart)fc).GetPlotRect();
            }
            else
            {
                if (FlexPie != null)
                    par = new _Rect(center.X - radius, center.Y - radius, 2 * radius, 2 * radius);
            }

            if (HoverElement == ChartElement.AxisX)
                DrawArea(g, Styles.HoverFill, Styles.HoverText, Styles.HoverPen, axr, null, "X-Axis");
            else if (HoverElement == ChartElement.AxisY)
            {
                if (hoverAxis == fc.AxisY)
                    DrawArea(g, Styles.HoverFill, Styles.HoverText, Styles.HoverPen, ayr, null, "Y-Axis");
                else
                    DrawArea(g, Styles.HoverFill, Styles.HoverText, Styles.HoverPen, ((IAxis)hoverAxis).Rect, null, "Y-Axis");
            }
            else if (HoverElement == ChartElement.PlotArea)
                DrawArea(g, Styles.HoverFill, Styles.HoverText, Styles.HoverPen, par, null, "Plot Area");
            else if (HoverElement == ChartElement.Legend)
                DrawArea(g, Styles.HoverFill, Styles.HoverText, Styles.HoverPen, GetLegendRect(), null, "Legend");

            if (SelectedElement == ChartElement.AxisX)
                DrawArea(g, null, null, Styles.SelectionPen, axr, null, null, true);
            else if (SelectedElement == ChartElement.AxisY)
                DrawArea(g, null, null, Styles.SelectionPen, selectedAxis == fc.AxisY ? ayr : ((IAxis)selectedAxis).Rect, null, null, true);
            else if (SelectedElement == ChartElement.PlotArea)
                DrawArea(g, null, null, Styles.SelectionPen, par, null, null, true);
            else if (SelectedElement == ChartElement.Legend)
                DrawArea(g, null, null, Styles.SelectionPen, GetLegendRect(), null, null, true);
            else if (SelectedElement == ChartElement.Header)
                DrawArea(g, null, null, Styles.SelectionPen, chart.Header.GetRect(), null, null, true);
            else if (SelectedElement == ChartElement.Footer)
                DrawArea(g, null, null, Styles.SelectionPen, chart.Footer.GetRect(), null, null, true);
        }

        void DrawArea(Graphics g, Brush brush, Brush textBrush, Pen pen, _Rect r, string text, string header = null, bool selected = false)
        {
            var rf = ToRectangle(r);
            if (brush != null)
                g.FillRectangle(brush, rf);

            if (header != null)
            {
                var sz = g.MeasureString(header, Styles.HeaderFont);
                g.FillRectangle(Brushes.White, new Rectangle((int)r.Left, (int)(r.Top - sz.Height), (int)sz.Width, (int)sz.Height));
                g.DrawString(header, Styles.HeaderFont, textBrush, new Point((int)r.Left, (int)(r.Top - sz.Height)));
            }

            if (text != null)
            {
                var sz = g.MeasureString(text, Styles.TextFont);
                g.DrawString(text, Styles.TextFont, textBrush, new Point((int)(r.Left + 0.5 * (r.Width - sz.Width)), (int)(r.Top + 0.5 * (r.Height - sz.Height))));
            }

            if (pen != null)
            {
                g.DrawRectangle(pen, rf);

                if (selected)
                {
                    g.DrawRectangle(pen, rf.Left - 3, rf.Top - 3, 6, 6);
                    g.DrawRectangle(pen, rf.Right - 3, rf.Top - 3, 6, 6);
                    g.DrawRectangle(pen, rf.Left - 3, rf.Bottom - 3, 6, 6);
                    g.DrawRectangle(pen, rf.Right - 3, rf.Bottom - 3, 6, 6);
                }
            }
        }

        _Rect GetLegendRect()
        {
            var r = (_Rect)chart.Legend.GetType().GetProperty("Rect", BindingFlags.Instance | BindingFlags.NonPublic).GetValue(chart.Legend);
            r.Inflate(-3, -3);
            return r;
        }

        public Rectangle ToRectangle(_Rect r)
        {
            return new Rectangle((int)r.Left, (int)r.Top, (int)r.Width, (int)r.Height);
        }

        public ChartElement ActiveElement
        {
            get { return activeElement; }
            set
            {
                if (activeElement != value)
                {
                    activeElement = value;
                }
            }
        }

        public ChartElement HoverElement
        {
            get { return hoverElement; }
            set
            {
                if (hoverElement != value)
                {
                    hoverElement = value;
                    chart.Invalidate();
                }
            }
        }

        public Series HoverSeries
        {
            get { return hoverSeries; }
            private set { hoverSeries = value; }
        }

        public Series SelectedSeries
        {
            get { return selectedSeries; }
            private set
            {
                if (selectedSeries != value)
                {
                    if (selectedSeries != null)
                        selectedSeries.SymbolRendered -= SymbolRendered;
                    selectedSeries = value;
                    if (selectedSeries != null)
                        selectedSeries.SymbolRendered += SymbolRendered;
                }
            }
        }

        public ChartElement SelectedElement
        {
            get { return selectedElement; }
            set
            {
                //if (selectedElement != value)
                {
                    selectedElement = value;

                    if (selectedElement != ChartElement.PlotArea)
                        SelectedSeries = null;

                    if (selectedElement == ChartElement.AxisX)
                        selectedAxis = FlexChart.AxisX;
                    else if (selectedElement == ChartElement.AxisY)
                        selectedAxis = FlexChart.AxisY;

                    chart.Invalidate();
                    if (SelectedElementChanged != null)
                        SelectedElementChanged.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler SelectedElementChanged;


        public object GetSelectedObject()
        {
            object obj = null;

            if (SelectedElement == C1.Chart.ChartElement.AxisX)
                obj = new AxisProperties(FlexChart.AxisX);
            else if (SelectedElement == C1.Chart.ChartElement.AxisY)
                obj = new AxisProperties(selectedAxis);
            else if (SelectedElement == C1.Chart.ChartElement.Legend)
                obj = new LegendProperties(chart.Legend,chart);
            else if (SelectedElement == C1.Chart.ChartElement.Header)
                obj = new TitleProperties(chart.Header, chart, true);
            else if (SelectedElement == C1.Chart.ChartElement.Footer)
                obj = new TitleProperties(chart.Footer, chart, false);
            else if (SelectedElement == C1.Chart.ChartElement.DataLabel)
                obj = DataLabelProperties;
            else if (SelectedElement == C1.Chart.ChartElement.PlotArea)
            {
                if (HoverSeries != null)
                    obj = new SeriesProperties(HoverSeries);
                else if (FlexPie != null)
                    obj = new FlexPieProperties(FlexPie);
            }
            SelectedSeries = HoverSeries;

            if (obj == null)
            {
                if (FlexChart != null)
                    obj = new FlexChartProperties(FlexChart);
                else if (FlexPie != null)
                    obj = new FlexPieProperties(FlexPie);

            }

            return obj;
        }
    }
}
