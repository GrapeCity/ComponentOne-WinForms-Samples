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
    public partial class MapUserControl : UserControl
    {
        private VectorItem _currentItem;
        private Point _mouseLocation;

        protected MapUserControl()
        {
            InitializeComponent();
        }

        internal ToolTip ToolTip { get; set; }

        protected virtual C1Map Map { get { return null; } }

        protected override void OnLoad(EventArgs e)
        {
            if (!DesignMode) InitMap();
        }

        protected virtual void InitMap()
        {
            if (Map == null) return;
            
            Map.MouseMove += OnMapMouseMove;
            Map.ContextMenuStrip = contextMenuStrip1;
        }

        private void OnMapMouseMove(object sender, MouseEventArgs e)
        {
            if (ToolTip == null) return;

            var map = sender as C1Map;
            if (map == null) return;

            var info = map.HitTest(e.Location);
            SetToolTip(map, info == null ? null : info.Vector);
        }

        private void SetToolTip(C1Map map, VectorItem item)
        {
            if (_currentItem == item) return;

            _currentItem = item;
            if (_currentItem == null)
            {
                ToolTip.SetToolTip(map, null);
            }
            else
            {
                ToolTip.SetToolTip(map, item.Tag as string);
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (Map == null) return;

            _mouseLocation = Map.PointToClient(MousePosition);
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Map == null) return;

            Map.ZoomAt(1d, _mouseLocation);
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Map == null) return;

            Map.ZoomAt(-1d, _mouseLocation);
        }

        private void centerHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Map == null) return;

            Map.CenterTo(_mouseLocation);
        }
    }
}
