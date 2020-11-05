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
    public partial class Content : UserControl
    {
        protected LineMarker lineMarker;
        public Content()
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
                    Input = rnd.Next(1, 9),
                    Output = rnd.Next(10, 19)
                });
            }

            flexChart1.BeginUpdate();
            flexChart1.Series.Clear();
            flexChart1.ChartType = C1.Chart.ChartType.Line;

            flexChart1.BindingX = "Date";

            var serie1 = new Series() { Name = "Output", Binding = "Output" };
            serie1.Style.StrokeColor = Color.FromArgb(255, 251, 178, 88);
            flexChart1.Series.Add(serie1);

            var serie = new Series() { Name = "Input", Binding = "Input" };
            serie.Style.StrokeColor = Color.FromArgb(255, 136, 189, 230);
            flexChart1.Series.Add(serie);

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
                lineMarker.PositionChanged += lineMarker_PositionChanged;
            }
        }

        void lineMarker_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            //Check sender
            LineMarker senderLineMarker = (LineMarker)sender;
            if (senderLineMarker == null) return;

            var newContent = String.Empty;

            var _hitTestInfo = flexChart1.HitTest(new Point(e.X, e.Y), C1.Chart.MeasureOption.X, -1);
            //set first line as X value
            newContent += _hitTestInfo.Format("{x}\r\n");

            double total = 0;
            //add FlexChart series to Content
            foreach (Series serie in flexChart1.Series)
            {
                //get inputSerie values array
                var values = serie.GetValues(0);

                // check if array index exists
                if (_hitTestInfo.PointIndex > 0 &&_hitTestInfo.PointIndex < values.Length)
                {
                    newContent += String.Format("{0} - {1} \r\n", serie.Name, values[_hitTestInfo.PointIndex]);
                    total += values[_hitTestInfo.PointIndex];
                }
            }

            newContent += "Total: " + total;
            senderLineMarker.Content = newContent;
        }

        class DataItem
        {
            public int Input { get; set; }
            public int Output { get; set; }
            public DateTime Date { get; set; }
        }


        private void InitializeControls()
        {

            #region Init controls

            //Set localized text
            baseSample1.lblTitle.Text = Localizer.GetItem("content", "title");
            baseSample1.tbDescription.Rtf = Localizer.GetItem("content", "description").MakeRtf();

            baseSample1.pControls.Visible = false;
            #endregion
        }
    }
}
