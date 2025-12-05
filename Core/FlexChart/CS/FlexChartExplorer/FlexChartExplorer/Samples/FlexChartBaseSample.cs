using C1.Chart;
using C1.Win.Chart;
using C1.Win.Themes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FlexChartExplorer.Samples
{
    /// <summary>
    /// Base sample for all samples in FlexChartExplorer
    /// </summary>
    public partial class FlexChartBaseSample : BaseExplorer.Components.BaseSample
    {
        [DefaultValue(null)]
        public FlexChartBase Chart
        {
            get;
            protected set;
        }

        protected FlexChartBaseSample(FlexChartBase chart) : this()
        {
            Chart = chart;
        }

        public FlexChartBaseSample()
        {
            InitializeComponent();
            InitializeControls();
            this.DoubleBuffered = true;
            if (Chart != null)
            {
                Chart.Legend.Position = Position.Bottom;
                Chart.Dock = DockStyle.Fill;
                //Chart.BackColor = Color.Transparent;
            }
            SetupChart();
            pnlMain.Padding = new Padding(40, 20, 40, 20);

            if(Chart!=null)
                pnlMain.Controls.Add(Chart);
            C1ThemeController.ApplyThemeToControlTree(this, C1ThemeController.GetThemeByName(Theme, false), null, true);

            Disposed += OnDisposed;
        }

        private void OnDisposed(object sender, EventArgs e)
        {
            if (Chart != null)
            {
                if (Chart.ToolTip != null)
                    Chart.ToolTip.Dispose();
            }
        }

        protected virtual void InitializeControls() { }

        protected virtual void SetupChart() { }

        /// <summary>
        /// Gets the image of the Chart object
        /// </summary>
        /// <param name="width">desired width for the image</param>
        /// <param name="height">desired height for the image</param>
        /// <returns>Chart Image</returns>
        public override Image GetImage(int width = 200, int height = 200)
        {
            Bitmap bmp;
            using (var ms = new MemoryStream())
            {
                if (Chart == null)
                    return base.GetImage(width, height);

                var w = Chart.Width;
                var h = Chart.Height;

                Chart.Header.Content = string.Empty;
                Chart.Legend.Position = C1.Chart.Position.None;

                if (Chart is FlexPie || Chart is FlexRadar)
                {
                    var l = Math.Min(w, h);
                    Chart.Dock = DockStyle.None;
                    Chart.Size = new Size(l, l);
                    var pie = Chart as FlexPie;
                    if (pie != null)
                        pie.SaveImage(ms, ImageFormat.Png, pie.Width, pie.Height);
                    else
                    {
                        var radar = Chart as FlexRadar;
                        radar.SaveImage(ms, ImageFormat.Png, radar.Width, radar.Height);
                    }
                }
                else if (Chart is C1.Win.Chart.TreeMap)
                    ((C1.Win.Chart.TreeMap)Chart).SaveImage(ms, ImageFormat.Png, w, h);
                else
                    ((FlexChart)Chart).SaveImage(ms, ImageFormat.Png, w, h);
                bmp = new Bitmap(ms);
            }
            return bmp;
        }
    }
}
