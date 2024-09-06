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
using FlexChartExplorer.Data;
using C1.Win.Chart;
using BaseExplorer;

namespace FlexChartExplorer.Samples
{
    public partial class HitTest : FlexChartBaseSample
    {
        private LabelEx _lInfo1, _lInfo2;
        private Panel _pInformation;
        private FlexChart flexChart1;

        public HitTest()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.SplineSymbols;
            this.flexChart1.Header.Content = "Newspapers Losing Relevance as News Source";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = DataService.GetNewsSourcesInfo();
            this.flexChart1.BindingX = "Year";
            var newspaper = new Series { Name = "Newspaper", Binding = "Newspaper" };
            var internet = new Series { Name = "Internet", Binding = "Internet" };
            this.flexChart1.Series.Add(newspaper);
            this.flexChart1.Series.Add(internet);

            this.flexChart1.AxisY.Format = "p0";
            this.flexChart1.AxisX.AxisLine = false;
            this.flexChart1.Footer.Style.Font = StyleInfo.ChartHeaderFont;
            this.flexChart1.MouseMove += FlexChart1_MouseMove;
        }

        private void FlexChart1_MouseMove(object sender, MouseEventArgs e)
        {
            // Show information about chart element under mouse cursor
            var hitInfo = flexChart1.HitTest(e.Location);
            var result1 = new StringBuilder();
            if (hitInfo != null)
            {
                result1.AppendLine(string.Format("Chart element:{0}", hitInfo.ChartElement));
                if (hitInfo.Series != null)
                    result1.AppendLine(string.Format("Series name:{0}", hitInfo.Series.Name));
                if (hitInfo.PointIndex >= 0)
                    result1.AppendLine(string.Format("Point index={0:0}", hitInfo.PointIndex));
                _lInfo1.Text = result1.ToString();

                var result2 = new StringBuilder();
                if (hitInfo.Distance > 0)
                    result2.AppendLine(string.Format("Distance={0:0}", hitInfo.Distance));
                if (hitInfo.X != null)
                    result2.AppendLine(string.Format("X={0:0}", hitInfo.X));
                if (hitInfo.Y != null)
                    result2.AppendLine(string.Format("Y={0:p}", hitInfo.Y));
                _lInfo2.Text = result2.ToString();
            }
        }

        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            //Init lable Info1 & Info2
            _lInfo1 = new LabelEx(string.Empty) { Location = new Point(40,10), ForeColor= Color.Gray};
            _lInfo2 = new LabelEx(string.Empty) { Location = new Point(200,10), ForeColor = Color.Gray};

            //Init Information Panel
            _pInformation = new Panel { Dock = DockStyle.Bottom, BackColor = Color.White};
            _pInformation.Paint += (s, e) =>
            {
                e.Graphics.DrawLine(new Pen(Color.Gray), 0, 0, _pInformation.Width, 0);
            };

            _pInformation.Controls.Add(_lInfo1);
            _pInformation.Controls.Add(_lInfo2);
            this.Controls.Add(_pInformation);
        }
        public override Image GetImage(int width = 200, int height = 200)
        {
            var combinedImg = new Bitmap(flexChart1.Width, (flexChart1.Height + _pInformation.Height));

            var bmpMainChart = base.GetImage();

            FlexChart1_MouseMove(flexChart1, new MouseEventArgs(MouseButtons.Left, 1, flexChart1.Width / 2, flexChart1.Height / 2, 0));
            var bmpInfoPnlImage = new Bitmap(_pInformation.Width, _pInformation.Height);
            _pInformation.DrawToBitmap(bmpInfoPnlImage, _pInformation.DisplayRectangle);

            Graphics g = Graphics.FromImage(combinedImg);
            g.DrawImage(bmpMainChart, 0, 0);
            g.DrawImage(bmpInfoPnlImage, 0, flexChart1.Height);
            return combinedImg;
        }
    }
}
