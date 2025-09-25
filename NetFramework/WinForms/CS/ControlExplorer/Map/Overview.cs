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
            C1Zoom.Target = null; // C1Map can handle pinch zoom by its own, so don't use C1Zoom.
            Load += Overview_Load;
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            cmbSource.SelectedIndex = 0;
        }

        private void cmbSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1Map1.TileLayer.TileSource = new OpenStreetTileSource();
            c1Map1.Viewport.Zoom = 2.5;

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
