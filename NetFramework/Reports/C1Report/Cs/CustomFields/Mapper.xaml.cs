using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Windows.Threading;

namespace C1.C1Report.MapCustomField
{
    /// <summary>
    /// Interaction logic for Mapper.xaml
    /// </summary>
    public partial class Mapper : UserControl
    {
        private ESRI.ArcGIS.Client.GraphicsLayer _l1;
        private int _progress = -1;

        public Mapper()
        {
            InitializeComponent();
            _map.IsLogoVisible = false;
            this.scaleLine1.Visibility = System.Windows.Visibility.Visible;



            // extent (qq - think!)
            //var pt1 = MapUtil.ProjectPoint(new Point(0, -90));
            //var pt2 = MapUtil.ProjectPoint(new Point(360, 90));
            var pt1 = MapUtil.ProjectPoint(new Point(0, -40));
            var pt2 = MapUtil.ProjectPoint(new Point(360, 40));

            var extent = new ESRI.ArcGIS.Client.Geometry.Envelope(
                new ESRI.ArcGIS.Client.Geometry.MapPoint(pt1.X, pt1.Y),
                new ESRI.ArcGIS.Client.Geometry.MapPoint(pt2.X, pt2.Y));

            _map.Extent = extent;
            _map.ZoomDuration = TimeSpan.Zero;//qqq

            _l1 = new ESRI.ArcGIS.Client.GraphicsLayer();
            this._map.Layers.Add(_l1);
            _l1.Initialize();//qq
            _l1.Visible = true;

            //this.legend1.LayerItems.Add(new ESRI.ArcGIS.Client.Toolkit.Primitives.LayerItemViewModel(_l1)); //qq

            this._map.Progress += new EventHandler<ESRI.ArcGIS.Client.ProgressEventArgs>(_map_Progress);

            //
            IsDirty = true;
        }

        #region Properties
        public bool IsDirty
        {
            get;
            private set;
        }
        #endregion

        void _map_Progress(object sender, ESRI.ArcGIS.Client.ProgressEventArgs e)
        {
            _progress = e.Progress;
            System.Diagnostics.Debug.WriteLine("----------------progress: " + e.Progress.ToString());
        }

        public System.Drawing.Image GetImage(double dpiX, double dpiY)
        {
            this.Measure(new System.Windows.Size(this.Width, this.Height));
            this.Arrange(new System.Windows.Rect(new System.Windows.Size(this.Width, this.Height)));
            // this.InvalidateVisual();
            // this._map.UpdateLayout();
            this.UpdateLayout();
            System.Diagnostics.Debug.Assert(_map.IsInitialized);

            Dispatcher.CurrentDispatcher.Invoke(new Action(delegate { }), DispatcherPriority.Background);
            int noProgress = 0;
            const int MaxNoProgress = 100;
            while (_progress < 100 && noProgress < MaxNoProgress)
            {
                System.Diagnostics.Debug.WriteLine("******************************************* " + _l1.IsInitialized.ToString());
                Dispatcher.CurrentDispatcher.Invoke(new Action(delegate { }), DispatcherPriority.Background);
                if (_progress == -1)
                {
                    ++noProgress;
                    System.Threading.Thread.Sleep(100);//qq
                }
            }
            IsDirty = false;
            return MakeImage(dpiX, dpiY);
        }

        private System.Drawing.Image MakeImage(double dpiX, double dpiY)
        {
            RenderTargetBitmap targetBitmap = new RenderTargetBitmap(
                (int)this.ActualWidth,
                (int)this.ActualHeight,
                dpiX, dpiY,
                PixelFormats.Default);
            targetBitmap.Render(this);

            // add the RenderTargetBitmap to a Bitmapencoder
            BmpBitmapEncoder encoder = new BmpBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(targetBitmap));

            // produce a WinForms Image:
            MemoryStream ms = new MemoryStream();
            encoder.Save(ms);
            return System.Drawing.Image.FromStream(ms);
        }

        public void ClearQQ()
        {
            IsDirty = true;
            _l1.ClearGraphics();
        }

        public void AutoZoom()
        {
            //qq _map.Extent
        }

        public void SetExtent(double lonMin, double lonMax, double latMin, double latMax)
        {
            var pt1 = MapUtil.ProjectPoint(new Point(lonMin, latMin));
            var pt2 = MapUtil.ProjectPoint(new Point(lonMax, latMax));

            var extent = new ESRI.ArcGIS.Client.Geometry.Envelope(
                new ESRI.ArcGIS.Client.Geometry.MapPoint(pt1.X, pt1.Y),
                new ESRI.ArcGIS.Client.Geometry.MapPoint(pt2.X, pt2.Y));

            if (_map.Extent != extent) // qq??
            {
                _progress = -1; //qqq
                _map.Extent = extent;
                IsDirty = true;
            }
        }

        public void DrawPoint(double latitude, double longitude)
        {
            IsDirty = true;
            ESRI.ArcGIS.Client.Symbols.SimpleMarkerSymbol marker = new ESRI.ArcGIS.Client.Symbols.SimpleMarkerSymbol();
            marker.Style = ESRI.ArcGIS.Client.Symbols.SimpleMarkerSymbol.SimpleMarkerStyle.Circle;
            marker.Color = System.Windows.Media.Brushes.OrangeRed;
            // marker.Size = 

            ESRI.ArcGIS.Client.Graphic g = new ESRI.ArcGIS.Client.Graphic();
            g.Symbol = marker;

            var pt = MapUtil.ProjectPoint(new System.Windows.Point(longitude, latitude));
            ESRI.ArcGIS.Client.Geometry.MapPoint geometry = new ESRI.ArcGIS.Client.Geometry.MapPoint(pt.X, pt.Y);
            g.Geometry = geometry;

            _l1.Graphics.Add(g);
        }
    }
}
