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
        private MapUserControl _mapControl;
        private C1.Win.Map.VectorLayer _layer;

        public Overview()
        {
            InitializeComponent();
        }

        private void Overview_Load(object sender, EventArgs e)
        {
           
            if(!DesignMode)
            {
                // Init map
                _mapControl = new MapUserControl(new OpenStreetTileSource());
                _mapControl.Map.Viewport.Zoom = 2.5;
                _mapControl.Dock = DockStyle.Fill;

                // Create layer
                _layer = new C1.Win.Map.VectorLayer();
                _mapControl.Map.Layers.Add(_layer);

                _panel.Controls.Add(_mapControl);
            }
        }
    }
}
