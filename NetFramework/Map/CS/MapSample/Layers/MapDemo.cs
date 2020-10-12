using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.Map;

namespace MapSample.Layers
{
    public partial class MapDemo : MapUserControl
    {
        public MapDemo()
        {
            InitializeComponent();
        }

        protected override C1Map Map
        {
            get { return c1Map1; }
        }

        protected override void InitMap()
        {
            base.InitMap();
            c1Map1.Viewport.Zoom = 1;
            cmbSource.SelectedIndex = 0;
        }

        private void cmbSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbSource.SelectedIndex)
            {
                case 0:
                    c1Map1.TileLayer.TileSource = new VirtualEarthRoadSource();
                    break;
                case 1:
                    c1Map1.TileLayer.TileSource = new VirtualEarthAerialSource();
                    break;
                case 2:
                    c1Map1.TileLayer.TileSource = new VirtualEarthHybridSource();
                    break;
                case 3:
                    c1Map1.TileLayer.TileSource = new OpenStreetTileSource();
                    break;
                default:
                    c1Map1.TileLayer.TileSource = null;
                    break;
            }
        }

        private void chkShowTools_CheckedChanged(object sender, EventArgs e)
        {
            var visible = chkShowTools.Checked;
            c1Map1.DistanceScale.Visible = visible;
            c1Map1.PanTool.Visible = visible;
            c1Map1.ZoomTool.Visible = visible;
        }
    }
}
