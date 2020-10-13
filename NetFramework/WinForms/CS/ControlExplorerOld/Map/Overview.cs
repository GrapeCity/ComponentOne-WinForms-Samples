using C1.Win.Map;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.Map
{
    public partial class Overview : C1DemoForm
    {
        public Overview()
        {
            InitializeComponent();
            c1Zoom1.Target = null; // C1Map can handle pinch zoom by its own, so don't use C1Zoom.
            Load += Overview_Load;
        }

        private void Overview_Load(object sender, EventArgs e)
        {
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

    class OpenStreetTileSource : C1.FlexMap.ITileSource
    {
        private const string UrlTemplate = "http://tile.openstreetmap.org/{0}/{1}/{2}.png";

        public void GetTile(int level, int x, int y, out string url, out object image)
        {
            image = null;
            url = string.Format(UrlTemplate, level, x, y);
        }

        public int TileWidth { get { return 256; } }
        public int TileHeight { get { return 256; } }
    }
}
