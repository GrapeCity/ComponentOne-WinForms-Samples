using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapExplorer.Samples
{
    using MapExplorer.Samples.Layers;
    using SourceMaps = C1.FlexMap;
    using C1.Win.Map;
    public partial class Overview : UserControl
    {
        public Overview()
        {
            InitializeComponent();
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            if(!DesignMode)
            {
                var sources = new List<SourceMaps.ITileSource>()
                { 
                    new VirtualEarthAerialSource(), 
                    new VirtualEarthRoadSource(), 
                    new VirtualEarthHybridSource(),
                    // Custom map
                    new OpenStreetTileSource()
            };

                // Create maps
                var maps = sources.Select(x => new MapUserControl(x));

                // For each map create the layer
                maps
                    .ToList()
                    .ForEach(x =>
                    {
                        //x.Map.Viewport.Zoom = 5;
                        var _layer = new C1.Win.Map.VectorLayer();
                        x.Map.Layers.Add(_layer);
                    });

                _panel.Controls.AddRange(maps.ToArray());
                SetSizeMaps();
            }
        }

        private void SetSizeMaps()
        {
            var width = (int)(_panel.Size.Width / 2);
            var height = (int)(_panel.Size.Height / 2);

            _panel.Controls.Cast<MapUserControl>().ToList()
                .ForEach(x =>
                {
                    x.Size = new Size(width, height);
                });
        }

        private void _panel_SizeChanged(object sender, EventArgs e)
        {
            SetSizeMaps();
        }
    }
}
