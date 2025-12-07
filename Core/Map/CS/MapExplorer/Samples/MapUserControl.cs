using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MapExplorer.Samples.Layers
{
    using SourceMaps = C1.FlexMap;
    using C1.Win.Map;
    public partial class MapUserControl : UserControl
    {
        #region fields

        private VectorItem _currentItem;
        private Point _mouseLocation;
        private C1Map _map;

        // Colors
        private readonly Color _toolbarLigthColor = Color.FromArgb(230, 230, 230);
        private readonly Color _toolbarDarkColor = Color.FromArgb(204, 204, 204);
        private readonly Color _titleColor = Color.FromArgb(102, 102, 51);
        private readonly int _padding = 5;

        #endregion

        #region ctor & dctor
        public MapUserControl()
        {
            InitializeComponent();
        }

        public MapUserControl(SourceMaps.ITileSource source)
        {
            InitializeComponent();
            InitMap(source);

            // Init images
            zoomInToolStripMenuItem.Image = MapExplorer.Properties.Resources.Zoom_In;
            zoomOutToolStripMenuItem.Image = MapExplorer.Properties.Resources.Zoom_Out;
            centerHereToolStripMenuItem.Image = MapExplorer.Properties.Resources.Center;
        }

        protected virtual void InitMap(SourceMaps.ITileSource source = null)
        {
            if (Map is null)
            {
                // Start init
                _map = new C1Map();
                ((System.ComponentModel.ISupportInitialize)_map).BeginInit();
                SuspendLayout();

                // Basic properties
                _map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                    | System.Windows.Forms.AnchorStyles.Left)
                    | System.Windows.Forms.AnchorStyles.Right)));
                _map.DistanceScale.Alignment = System.Drawing.ContentAlignment.BottomLeft;
                _map.DistanceScale.BarStyle.BackColor = _titleColor;
                _map.DistanceScale.BarStyle.ForeColor = _titleColor;

                _map.Location = new System.Drawing.Point(_padding, _padding);
                _map.Size = new Size(Size.Width - _padding * 2, Size.Height - _padding * 2);

                // Muve options
                _map.PanTool.MarkerStyle.BackColor = _toolbarLigthColor;
                _map.PanTool.MarkerStyle.BackColor2 = _toolbarDarkColor;
                _map.PanTool.MarkerStyle.GradientStyle = C1.Win.Map.GradientStyle.Vertical;

                _map.PanTool.PanStyle.BackColor = _toolbarLigthColor;
                _map.PanTool.PanStyle.BackColor2 = _toolbarDarkColor;
                _map.PanTool.PanStyle.GradientStyle = C1.Win.Map.GradientStyle.Vertical;

                _map.PanTool.PanStyle.Stroke.Color = _toolbarDarkColor;

                // Zoom options
                _map.ZoomTool.Margin = new System.Windows.Forms.Padding(20, 70, 0, 0);
                _map.ZoomTool.ButtonStyle.BackColor = _toolbarLigthColor;
                _map.ZoomTool.ButtonStyle.BackColor2 = _toolbarDarkColor;

                _map.ZoomTool.ButtonStyle.Border.Bottom.Color = Color.DarkGray;
                _map.ZoomTool.ButtonStyle.Border.Left.Color = Color.DarkGray;
                _map.ZoomTool.ButtonStyle.Border.Right.Color = Color.DarkGray;
                _map.ZoomTool.ButtonStyle.Border.RoundRadius.BottomLeft = 3;
                _map.ZoomTool.ButtonStyle.Border.RoundRadius.BottomRight = 3;
                _map.ZoomTool.ButtonStyle.Border.RoundRadius.TopLeft = 3;
                _map.ZoomTool.ButtonStyle.Border.RoundRadius.TopRight = 3;
                _map.ZoomTool.ButtonStyle.Border.Top.Color = Color.DarkGray;
                _map.ZoomTool.ButtonStyle.GradientStyle = C1.Win.Map.GradientStyle.Vertical;

                _map.ZoomTool.ThumbStyle.BackColor = _toolbarLigthColor;
                _map.ZoomTool.ThumbStyle.BackColor2 = _toolbarDarkColor;
                _map.ZoomTool.ThumbStyle.Border.Bottom.Color = Color.DarkGray;
                _map.ZoomTool.ThumbStyle.Border.Left.Color = Color.DarkGray;
                _map.ZoomTool.ThumbStyle.Border.Right.Color = Color.DarkGray;
                
                _map.ZoomTool.ThumbStyle.Border.RoundRadius.BottomLeft = 3;
                _map.ZoomTool.ThumbStyle.Border.RoundRadius.BottomRight = 3;
                _map.ZoomTool.ThumbStyle.Border.RoundRadius.TopLeft = 3;
                _map.ZoomTool.ThumbStyle.Border.RoundRadius.TopRight = 3;
                _map.ZoomTool.ThumbStyle.Border.Top.Color = Color.DarkGray;
                _map.ZoomTool.ThumbStyle.GradientStyle = C1.Win.Map.GradientStyle.Vertical;

                _map.ZoomTool.TrackStyle.BackColor = _toolbarLigthColor;
                _map.ZoomTool.TrackStyle.Border.Bottom.Color = Color.DarkGray;
                _map.ZoomTool.TrackStyle.Border.Left.Color = Color.DarkGray;
                _map.ZoomTool.TrackStyle.Border.Left.Width = 1F;
                _map.ZoomTool.TrackStyle.Border.Right.Color = Color.DarkGray;
                _map.ZoomTool.TrackStyle.Border.RoundRadius.BottomLeft = 3;
                _map.ZoomTool.TrackStyle.Border.RoundRadius.BottomRight = 3;
                _map.ZoomTool.TrackStyle.Border.RoundRadius.TopLeft = 3;
                _map.ZoomTool.TrackStyle.Border.RoundRadius.TopRight = 3;
                _map.ZoomTool.TrackStyle.Border.Top.Color = Color.DarkGray;

                // Set source map
                if (source is not null)
                    _map.TileLayer.TileSource = source;

                // End init 
                ((System.ComponentModel.ISupportInitialize)_map).EndInit();
                ResumeLayout(false);

                // Add events
                _map.MouseMove += OnMapMouseMove;
                _map.ContextMenuStrip = contextMenuStrip1;
            }

            if(_map is not null)
                Controls.Add(_map);
        }

        #endregion

        [DefaultValue(null)]
        public ToolTip ToolTip { get; set; }

        public C1Map Map { get { return _map; } }

        public void SetToolTip(C1Map map, VectorItem item)
        {
            if (_currentItem == item) return;

            _currentItem = item;
            if (_currentItem is null)
            {
                ToolTip.SetToolTip(map, null);
            }
            else
            {
                ToolTip.SetToolTip(map, item.Tag as string);
            }
        }


        #region events

        protected override void OnLoad(EventArgs e)
        {
            if (!DesignMode) InitMap();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (Map is null) return;

            _mouseLocation = Map.PointToClient(MousePosition);
        }
        private void OnMapMouseMove(object sender, MouseEventArgs e)
        {
            if (ToolTip is null) return;

            var map = sender as C1Map;
            if (map is null) return;

            var info = map.HitTest(e.Location);
            SetToolTip(map, info?.Vector);
        }
        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Map is null) return;

            Map.ZoomAt(1d, _mouseLocation);
        }
        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Map is null) return;

            Map.ZoomAt(-1d, _mouseLocation);
        }
        private void centerHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Map is null) return;

            Map.CenterTo(_mouseLocation);
        }

        #endregion

        private void MapUserControl_Resize(object sender, EventArgs e)
        {
            Invalidate(true);
        }

        private void mnuContextShowTools_CheckedChanged(object sender, EventArgs e)
        {
            var visible = mnuContextShowTools.Checked;
            Map.DistanceScale.Visible = visible;
            Map.PanTool.Visible = visible;
            Map.ZoomTool.Visible = visible;
        }
    }
}
