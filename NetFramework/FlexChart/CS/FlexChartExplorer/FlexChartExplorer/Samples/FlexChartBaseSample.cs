//using System;
//using System.Drawing;
//using System.IO;
//using System.Windows.Forms;
//using C1.Win.Chart;
//using C1.Chart;

//namespace FlexChartExplorer.Samples
//{
//    /// <summary>
//    /// Base sample for all samples in FlexChartExplorer
//    /// </summary>
//    public partial class FlexChartBaseSample
//        : BaseExplorer.Components.BaseSample
//    {
//        public FlexChartBase Chart
//        {
//            get;
//            protected set;
//        }

//        protected FlexChartBaseSample(FlexChartBase chart)
//            : this()
//        {
//            Chart = chart;

//            if (Chart != null)
//            {
//                Chart.Legend.Position = Position.Bottom;
//                Chart.Dock = DockStyle.Fill;
//                Chart.BackColor = Color.White;

//                if (!pnlMain.Controls.Contains(Chart))
//                    pnlMain.Controls.Add(Chart);
//            }
//        }

//        public FlexChartBaseSample()
//        {
//            InitializeComponent();

//            // Creates controls used by individual samples.
//            InitializeControls();

//            if (Chart != null)
//            {
//                Chart.Legend.Position = Position.Bottom;
//                Chart.Dock = DockStyle.Fill;
//                Chart.BackColor = Color.White;
//            }

//            // Sets up the chart after controls are created.
//            SetupChart();

//            pnlMain.BackColor =
//                Color.FromArgb(234, 242, 246);

//            pnlMain.Padding =
//                new Padding(40, 20, 40, 20);

//            if (Chart != null &&
//                !pnlMain.Controls.Contains(Chart))
//            {
//                pnlMain.Controls.Add(Chart);
//            }

//            Disposed += OnDisposed;
//        }

//        private void OnDisposed(object sender, EventArgs e)
//        {
//            if (Chart != null &&
//                Chart.ToolTip != null)
//            {
//                Chart.ToolTip.Dispose();
//            }
//        }

//        protected virtual void InitializeControls()
//        {
//        }

//        protected virtual void SetupChart()
//        {
//        }

//        /// <summary>
//        /// Gets the image of the Chart object
//        /// </summary>
//        /// <param name="width">
//        /// Desired width for the image
//        /// </param>
//        /// <param name="height">
//        /// Desired height for the image
//        /// </param>
//        /// <returns>Chart image</returns>
//        public override Image GetImage(
//            int width = 200,
//            int height = 200)
//        {
//            if (Chart == null ||
//                Chart.IsDisposed ||
//                Chart.Disposing)
//            {
//                return base.GetImage(width, height);
//            }

//            int imageWidth =
//                Chart.Width > 0
//                    ? Chart.Width
//                    : Math.Max(width, 1);

//            int imageHeight =
//                Chart.Height > 0
//                    ? Chart.Height
//                    : Math.Max(height, 1);

//            DockStyle oldDock =
//                Chart.Dock;

//            Size oldSize =
//                Chart.Size;

//            Position oldLegendPosition =
//                Chart.Legend.Position;

//            string oldHeaderContent =
//                Chart.Header.Content;

//            try
//            {
//                Chart.Header.Content =
//                    string.Empty;

//                Chart.Legend.Position =
//                    Position.None;

//                using (var ms = new MemoryStream())
//                {
//                    if (Chart is FlexPie ||
//                        Chart is FlexRadar)
//                    {
//                        int size = Math.Max(
//                            1,
//                            Math.Min(
//                                imageWidth,
//                                imageHeight));

//                        Chart.Dock =
//                            DockStyle.None;

//                        Chart.Size =
//                            new Size(size, size);

//                        Chart.SaveImage(
//                            ms,
//                            C1.Win.Chart.ImageFormat.Png,
//                            size,
//                            size);
//                    }
//                    else
//                    {
//                        Chart.SaveImage(
//                            ms,
//                            C1.Win.Chart.ImageFormat.Png,
//                            imageWidth,
//                            imageHeight);
//                    }

//                    ms.Position = 0;

//                    using (var temporaryBitmap =
//                        new Bitmap(ms))
//                    {
//                        // Return a copy before the stream closes.
//                        return new Bitmap(
//                            temporaryBitmap);
//                    }
//                }
//            }
//            catch (NullReferenceException ex)
//            {
//                System.Diagnostics.Debug.WriteLine(
//                    "Chart preview failed: " +
//                    ex);

//                return base.GetImage(
//                    width,
//                    height);
//            }
//            catch (Exception ex)
//            {
//                System.Diagnostics.Debug.WriteLine(
//                    "Unable to create chart preview: " +
//                    ex);

//                return base.GetImage(
//                    width,
//                    height);
//            }
//            finally
//            {
//                if (Chart != null && !Chart.IsDisposed)
//                {
//                    Chart.Dock =
//                        oldDock;

//                    Chart.Size =
//                        oldSize;

//                    Chart.Header.Content =
//                        oldHeaderContent;

//                    Chart.Legend.Position =
//                        oldLegendPosition;
//                }
//            }
//        }
//    }
//}


using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using C1.Chart;
using C1.Win.Chart;

namespace FlexChartExplorer.Samples
{
    /// <summary>
    /// Base sample for all samples in FlexChartExplorer
    /// </summary>
    public partial class FlexChartBaseSample : BaseExplorer.Components.BaseSample
    {
        public FlexChartBase Chart
        {
            get;
            protected set;
        }

        protected FlexChartBaseSample(FlexChartBase chart) : this()
        {
            Chart = chart;

            if (Chart != null)
            {
                Chart.Legend.Position = Position.Bottom;
                Chart.Dock = DockStyle.Fill;
                Chart.BackColor = Color.White;

                if (!pnlMain.Controls.Contains(Chart))
                    pnlMain.Controls.Add(Chart);
            }
        }

        public FlexChartBaseSample()
        {
            InitializeComponent();

            // Creates controls used by individual samples.
            InitializeControls();

            if (Chart != null)
            {
                Chart.Legend.Position = Position.Bottom;
                Chart.Dock = DockStyle.Fill;
                Chart.BackColor = Color.White;
            }

            // Sets up the chart after controls are created.
            SetupChart();

            pnlMain.BackColor = Color.FromArgb(234, 242, 246);
            pnlMain.Padding = new Padding(40, 20, 40, 20);

            if (Chart != null && !pnlMain.Controls.Contains(Chart))
                pnlMain.Controls.Add(Chart);

            Disposed += OnDisposed;
        }

        private void OnDisposed(object sender, EventArgs e)
        {
            if (Chart != null && Chart.ToolTip != null)
                Chart.ToolTip.Dispose();
        }

        protected virtual void InitializeControls()
        {
        }

        protected virtual void SetupChart()
        {
        }

        /// <summary>
        /// Gets the image of the Chart object
        /// </summary>
        /// <param name="width">Desired width for the image</param>
        /// <param name="height">Desired height for the image</param>
        /// <returns>Chart image</returns>
        public override Image GetImage(int width = 200, int height = 200)
        {
            if (Chart == null || Chart.IsDisposed || Chart.Disposing)
                return base.GetImage(width, height);

            int imageWidth = Chart.Width > 0 ? Chart.Width : Math.Max(width, 1);
            int imageHeight = Chart.Height > 0 ? Chart.Height : Math.Max(height, 1);
            DockStyle oldDock = Chart.Dock;
            Size oldSize = Chart.Size;
            Position oldLegendPosition = Chart.Legend.Position;
            string oldHeaderContent = Chart.Header.Content;

            try
            {
                Chart.Header.Content = string.Empty;
                Chart.Legend.Position = Position.None;

                using (var ms = new MemoryStream())
                {
                    if (Chart is FlexPie || Chart is FlexRadar)
                    {
                        int size = Math.Max(1, Math.Min(imageWidth, imageHeight));

                        Chart.Dock = DockStyle.None;
                        Chart.Size = new Size(size, size);
                        Chart.SaveImage(ms, C1.Win.Chart.ImageFormat.Png, size, size);
                    }
                    else
                    {
                        Chart.SaveImage(ms, C1.Win.Chart.ImageFormat.Png, imageWidth, imageHeight);
                    }

                    ms.Position = 0;

                    using (var temporaryBitmap = new Bitmap(ms))
                    {
                        // Return a copy before the stream closes.
                        return new Bitmap(temporaryBitmap);
                    }
                }
            }
            catch (NullReferenceException ex)
            {
                System.Diagnostics.Debug.WriteLine("Chart preview failed: " + ex);
                return base.GetImage(width, height);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Unable to create chart preview: " + ex);
                return base.GetImage(width, height);
            }
            finally
            {
                if (Chart != null && !Chart.IsDisposed)
                {
                    Chart.Dock = oldDock;
                    Chart.Size = oldSize;
                    Chart.Header.Content = oldHeaderContent;
                    Chart.Legend.Position = oldLegendPosition;
                }
            }
        }
    }
}