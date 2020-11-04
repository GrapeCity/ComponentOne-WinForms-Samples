using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.Chart;
using System.Drawing.Drawing2D;
using C1.Win.Chart.Interaction;

namespace LineMarkerExplorer.Samples
{
    public partial class CustomPaint : UserControl
    {
        protected LineMarker lineMarker;
        SolidBrush axisRectSB = new SolidBrush(Color.DarkBlue);
        SolidBrush axisFontSB = new SolidBrush(Color.White);
        Font axisFont = new System.Drawing.Font(FontFamily.GenericSansSerif, 9, FontStyle.Bold);

        Font lineMarkerFont = new Font(FontFamily.GenericSerif, 10);

        TextFormatFlags flags = TextFormatFlags.NoPadding;

        Image[] images = new Image[] 
        { 
            LineMarkerExplorer.Properties.Resources.EN_Flag,
            LineMarkerExplorer.Properties.Resources.ES_Flag,
            LineMarkerExplorer.Properties.Resources.FR_Flag
        };

        public CustomPaint()
        {
            InitializeComponent();
            InitializeControls();

            SetupChart();

            Disposed += Introduction_Disposed;
        }

        void Introduction_Disposed(object sender, EventArgs e)
        {
            lineMarker.Remove();
        }

        void SetupChart()
        {
            flexChart1 = baseSample1.flexChart1;

            var rnd = new Random();
            var pointsCount = rnd.Next(1, 30);

            var pointsList = new List<DataItem>();

            DateTime startDate = new DateTime(DateTime.Now.Year - 1, 1, 1);
            for (DateTime date = startDate; date.Month < startDate.AddMonths(2).Month; date += TimeSpan.FromDays(1.0))
            {
                pointsList.Add(new DataItem()
                {
                    Date = date,
                    England = rnd.Next(1, 99),
                    Spain = rnd.Next(1, 99),
                    France = rnd.Next(1, 99),
                });
            }

            flexChart1.BeginUpdate();
            flexChart1.Series.Clear();
            flexChart1.ChartType = C1.Chart.ChartType.Line;

            flexChart1.BindingX = "Date";

            var extraSerie = new Series() { Name = "England", Binding = "England" };
            extraSerie.Style.StrokeColor = Color.FromArgb(255, 178, 251, 88);
            flexChart1.Series.Add(extraSerie);

            var outputSerie = new Series() { Name = "Spain", Binding = "Spain" };
            outputSerie.Style.StrokeColor = Color.FromArgb(255, 251, 178, 88);
            flexChart1.Series.Add(outputSerie);

            var inputSerie = new Series() { Name = "France", Binding = "France" };
            inputSerie.Style.StrokeColor = Color.FromArgb(255, 136, 189, 230);
            flexChart1.Series.Add(inputSerie);

            flexChart1.DataSource = pointsList.ToArray();

            flexChart1.EndUpdate();

            flexChart1.Rendered += flexChart1_Rendered;
        }

        void flexChart1_Rendered(object sender, RenderEventArgs e)
        {
            if (lineMarker == null)
            {
                lineMarker = new LineMarker(flexChart1);
                lineMarker.LineWidth = 2;
                lineMarker.DragThreshold = 10;
                lineMarker.Paint += lineMarker_Paint;
            }
        }

        void lineMarker_Paint(object sender, PaintEventArgs e)
        {
            var chartPoint = new Point(lineMarker.X, lineMarker.Y);
            var _hitTestInfo = flexChart1.HitTest(chartPoint, C1.Chart.MeasureOption.X);
 
            Rectangle infoRect = new Rectangle(lineMarker.X + 10, lineMarker.Y + 10, 150, 75);
            e.Graphics.FillRectangle(new SolidBrush(Color.Gray), infoRect);
            Point startPoint = new Point(lineMarker.X + 20, lineMarker.Y + 20);

            var i = 0;
            foreach (Series serie in flexChart1.Series)
            {
                var values = serie.GetValues(0);
                if (_hitTestInfo.PointIndex < 0 || values.Length <= _hitTestInfo.PointIndex) continue;
                var serieData = String.Format("{0} - {1}", serie.Name, values[(int)_hitTestInfo.PointIndex]);
                var serieColor = serie.Style.StrokeColor;

                if (images.Length > i)
                {
                    e.Graphics.DrawImage(images[i], startPoint);

                    var textPoint = new Point(startPoint.X + images[i].Width + 10, startPoint.Y);
                    TextRenderer.DrawText(e.Graphics, serieData, lineMarkerFont, textPoint, serieColor, flags);
                    startPoint.Y += 20;
                }
                i++;
            }

            var _hitTestInfo2 = flexChart1.HitTest(chartPoint);

            //draw X rectangle
            var xRect = new Rectangle(lineMarker.X - 60, (int)(flexChart1.PlotRect.Top + flexChart1.PlotRect.Height + 1), 120, 25);
            e.Graphics.FillRectangle(axisRectSB, xRect);
            e.Graphics.DrawString(_hitTestInfo2.Format("{x:dd-MM-yyyy}"), axisFont, axisFontSB, xRect.X + 5, xRect.Y + 2);

            //draw Y rectangle
            var yRect = new Rectangle((int)(flexChart1.PlotRect.Left - 40), lineMarker.Y - 15, 40, 25);
            e.Graphics.FillRectangle(axisRectSB, yRect);
            e.Graphics.DrawString(_hitTestInfo2.Format("{y}"), axisFont, axisFontSB, yRect.X + 5, yRect.Y + 2);
        }

        class DataItem
        {
            public int England { get; set; }
            public int France { get; set; }
            public int Spain { get; set; }
            public DateTime Date { get; set; }
        }

        private void InitializeControls()
        {

            #region Init controls

            //Set localized text
            baseSample1.lblTitle.Text = Localizer.GetItem("custompaint", "title");
            baseSample1.tbDescription.Rtf = Localizer.GetItem("custompaint", "description").MakeRtf();

            baseSample1.pControls.Visible = false;
            #endregion
        }
    }
}
