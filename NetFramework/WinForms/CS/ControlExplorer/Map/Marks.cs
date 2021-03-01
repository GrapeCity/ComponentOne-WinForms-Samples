using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ControlExplorer.Map
{
    using C1.FlexMap;
    using C1.Win.Map;

    public partial class Marks : C1DemoForm
    {
        private C1Map _map;
        private MapUserControl _mapControl;
        private C1.Win.Map.VectorLayer _layer;
        private readonly Random _rnd = new Random();
        private DataTable _table = new DataTable();
        private KeyValuePair<int, Color> _lastMark = new KeyValuePair<int, Color>();

        public Marks()
        {
            InitializeComponent();
        }

        private void CreateMarks()
        {
            _layer.Items.Clear();
            _table.Rows.Clear();

            Enumerable.Range(0, 15)
                .ToList()
                .ForEach(x =>
                {
                    AddMark(-60 + _rnd.Next(160), -60 + _rnd.Next(160));
                });
        }

        private int GetRandomNumber()
        {
            var index = _rnd.Next(99);
            if (_layer.Items.Any(x => Convert.ToInt32(x.Tag) == index))
                return GetRandomNumber();
            return index;
        }

        private void AddMark(double lon, double lat)
        {
            var mark = new C1.Win.Map.VectorPlacemark();
            _layer.Items.Add(mark);
            // Create the random number for mark.
            var index = GetRandomNumber();

            mark.Geometry = new GeoPoint(lon, lat);
            mark.Marker.Size = new SizeF(20, 27.32f);
            mark.Marker.Shape = MarkerShape.Custom;
            mark.Tag = index;
            mark.Marker.CustomShape = new MarkShape(index);
            mark.Style.Stroke.Color = Color.DarkGray;
            mark.Style.Stroke.Width = 1;
            mark.Style.BackColor = GetRandomColor(128, 192);

            var row = _table.NewRow();
            row["Number"] = index;
            row["longitude"] = lon;
            row["latitude"] = lat;
            _table.Rows.Add(row);
        }

        private Color GetRandomColor(byte min, byte a)
        {
            return Color.FromArgb(a, (byte)(min + _rnd.Next(255 - min)),
              (byte)(min + _rnd.Next(255 - min)), (byte)(min + _rnd.Next(255 - min)));
        }

        private void btnAddMark_Click(object sender, EventArgs e)
            => AddMark(-60 + _rnd.Next(160), -60 + _rnd.Next(160));

        private void btnCreateMarks_Click(object sender, EventArgs e)
            => CreateMarks();

        private void MarkControl_Load(object sender, EventArgs e)
        {
            // Init map.
            _mapControl = new MapUserControl(new VirtualEarthAerialSource())
            {
                Dock = DockStyle.Fill
            };
            _panel.Controls.Add(_mapControl);

            _map = _mapControl.Map;
            _map.Viewport.Zoom = 1;

            // Create layer.
            _layer = new C1.Win.Map.VectorLayer();
            _map.Layers.Add(_layer);

            // Init table.
            _table.Clear();
            var columns = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string,string>("Number", "№" ),
                new KeyValuePair<string,string>("longitude","Longitude" ),
                new KeyValuePair<string,string>("latitude","Latitude" )
            };

            _table.Columns.AddRange(columns.Select(x => new DataColumn() { ColumnName = x.Key }).ToArray());

            _grid.Columns.AddRange(columns.Select(x => new DataGridViewTextBoxColumn() {
                HeaderText = x.Value,
                Width = x.Key == "Number" ? 30 : 70,
                DataPropertyName = x.Key
            }).ToArray());

            _grid.DataSource = _table;

            // Create marks.
            CreateMarks();
        }

        private void _grid_SelectionChanged(object sender, EventArgs e)
        {
            if (_grid.SelectedRows.Count <= 0) return;
            if(_grid.SelectedRows.Count == 1 && _grid.Rows.Count > 1)
            {
                var row = _grid.SelectedRows.Cast<DataGridViewRow>().First();
                if (row is null) return;
                var data = (DataRowView)row.DataBoundItem;
                int.TryParse(data["Number"].ToString(), out var index);

                // Find current mark.
                var currentMark = _layer.Items.Cast<C1.Win.Map.VectorPlacemark>()
                    .ToList()
                    .Where(x => Convert.ToInt32(x.Tag) == index).FirstOrDefault();

                // Find last mark.
                if (_lastMark.Key > 0)
                {
                    var lastMark = _layer.Items.Cast<C1.Win.Map.VectorPlacemark>()
                        .ToList()
                        .Where(x => Convert.ToInt32(x.Tag) == _lastMark.Key).FirstOrDefault();

                    // Restore last color.
                    if (lastMark != null)
                        lastMark.Style.BackColor = _lastMark.Value;
                }

                if (currentMark is null) return;

                // Save last mark.
                _lastMark = new KeyValuePair<int, Color>(index, currentMark.Style.BackColor);

                // Set the red color for current mark.
                currentMark.Style.BackColor = Color.Red;
            }
        }

        private void btnDeleteMark_Click(object sender, EventArgs e)
        {
            if (_grid.SelectedRows.Count <= 0) return;
            if (_grid.SelectedRows.Count == 1 && _grid.Rows.Count > 1)
            {
                // Change color for one mark.
                var row = _grid.SelectedRows.Cast<DataGridViewRow>().First();
                if (row is null) return;
                var data = (DataRowView)row.DataBoundItem;
                int.TryParse(data["Number"].ToString(), out var index);

                // Find current mark.
                var currentMark = _layer.Items.Cast<C1.Win.Map.VectorPlacemark>()
                    .ToList()
                    .Where(x => Convert.ToInt32(x.Tag) == index).FirstOrDefault();

                if (currentMark is null) return;

                _layer.Items.Remove(currentMark);
                _table.Rows.Remove(data.Row);
            }
        }

        private void mnuContextDelete_Click(object sender, EventArgs e)
            => btnDeleteMark_Click(sender, e);

        private void mnuContextAdd_Click(object sender, EventArgs e)
            => btnAddMark_Click(sender, e);

        private void btnZoomArea_Click(object sender, EventArgs e)
        {
            if (_grid.SelectedRows.Count <= 0)
                return;
            if (_grid.SelectedRows.Count > 1 && _grid.Rows.Count > 1)
            {
                var list = _grid.SelectedRows.Cast<DataGridViewRow>()
                    .ToList()
                    .Select(x => x.DataBoundItem as DataRowView)
                    .Select(x => Convert.ToInt32(x["Number"]))
                    .ToList();

                var marks = _layer.Items.Where(x => list.Contains(Convert.ToInt32(x.Tag)));
                _map.ZoomToItems(marks);
            }
        }

        private void mnuContextZoomInItems_Click(object sender, EventArgs e)
            => btnZoomArea_Click(sender, e);
    }

    public class MarkShape : CustomShape
    {
        private readonly int _index;

        public MarkShape(int index)
        {
            _index = index;
        }

        public override RectangleF GetDrawingBounds(Graphics g, RectangleF bounds, Style style)
        {
            bounds.Y -= bounds.Height / 2;
            return bounds;
        }

        public override bool IsVisible(Graphics g, RectangleF bounds, PointF point, Style style)
        {
            using (var path = CreateBaloon(bounds))
                return path.IsVisible(point);
        }

        public override void Draw(Graphics g, RectangleF bounds, Style style)
        {
            using (var path = CreateBaloon(bounds))
            {
                using (var brush = new SolidBrush(style.BackColor))
                    g.FillPath(brush, path);

                using (var pen = new Pen(style.Stroke.Color, style.Stroke.Width))
                    g.DrawPath(pen, path);

                var rect = new RectangleF(bounds.Location, new SizeF(20, 20));
                using (var brush = new SolidBrush(style.ForeColor))
                using (var sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Center;
                    g.DrawString(_index.ToString(CultureInfo.InstalledUICulture),
                        style.Font, brush, rect, sf);
                }
            }
        }

        private GraphicsPath CreateBaloon(RectangleF bounds)
        {
            var path = new GraphicsPath();
            var rect = new RectangleF(bounds.Location, new SizeF(20, 20));
            path.AddArc(rect, 120, 300);
            rect = new RectangleF(bounds.Right - 10, bounds.Bottom - 10, 20, 20);
            path.AddArc(rect, -120, -60);
            rect = new RectangleF(bounds.Left - 10, bounds.Bottom - 10, 20, 20);
            path.AddArc(rect, 0, -60);

            return path;
        }
    }
}
