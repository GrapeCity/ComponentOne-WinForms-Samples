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
    using C1.FlexMap;
    using C1.Win.Map;
    using VectorLayer = C1.FlexMap.VectorLayer;
    using VectorPlacemark = C1.FlexMap.VectorPlacemark;
    public partial class MarkControl : UserControl
    {
        #region fields

        private MapUserControl _mapControl;
        private C1.Win.Map.VectorLayer _layer;
        private readonly Random _rnd = new Random();
        private DataTable _table = new DataTable();
        private KeyValuePair<int, Color> _lastMark = new KeyValuePair<int, Color>();

        #endregion

        #region ctor & dctor

        public MarkControl()
        {
            InitializeComponent();

            // Init images
            var images = new Dictionary<object, Bitmap>()
            {
                {btnAddMark, Properties.Resources.AddPoint},
                {btnDeleteMark, Properties.Resources.DeletePoint},
                {mnuContextDelete, Properties.Resources.DeletePoint},
                {mnuContextAdd, Properties.Resources.AddPoint},
                {mnuContextZoomInItems, Properties.Resources.Center}
            };

            images.Keys.ToList().ForEach(x =>
            {
                if (x is ToolStripButton button)
                    button.Image = images[x];

                if (x is ToolStripMenuItem menu)
                    menu.Image = images[x];
            });
        }

        #endregion
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
            else
                return index;
        }

        private void AddMark(double lon, double lat)
        {
            var mark = new C1.Win.Map.VectorPlacemark();
            _layer.Items.Add(mark);
            // Create the random number for mark
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

        #region events
        private void btnAddMark_Click(object sender, EventArgs e)
        {
            AddMark(-60 + _rnd.Next(160), -60 + _rnd.Next(160));
        }

        private void btnCreateMarks_Click(object sender, EventArgs e)
        {
            CreateMarks();
        }

        private void MarkControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                // Init map
                _mapControl = new MapUserControl(new VirtualEarthAerialSource());
                _mapControl.Map.Viewport.Zoom = 1;
                _mapControl.Dock = DockStyle.Fill;

                // Create layer
                _layer = new C1.Win.Map.VectorLayer();
                _mapControl.Map.Layers.Add(_layer);

                _panel.Controls.Add(_mapControl);

                // Init table
                _table.Clear();
                var columns = new List<KeyValuePair<string, string>>()
                {
                        new KeyValuePair<string,string>("Number", "№" ),
                        new KeyValuePair<string,string>("longitude","Longitude" ),
                        new KeyValuePair<string,string>("latitude","Latitude" )
                };

                _table.Columns.AddRange(
                        columns.Select(x =>
                        new DataColumn() { ColumnName = x.Key }).ToArray()
                    );

                _grid.Columns.AddRange(
                    columns.Select(x =>
                        new DataGridViewTextBoxColumn()
                        { HeaderText = x.Value, Width = x.Key == "Number" ? 30 : 70, DataPropertyName = x.Key }).ToArray()
                    );

                _grid.DataSource = _table;

                // Create marks
                CreateMarks();
            }
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

                // Find current mark
                var currentMark = _layer.Items.Cast<C1.Win.Map.VectorPlacemark>()
                    .ToList()
                    .Where(x => Convert.ToInt32(x.Tag) == index).FirstOrDefault();

                // Find last mark
                if (_lastMark.Key > 0)
                {
                    var lastMark = _layer.Items.Cast<C1.Win.Map.VectorPlacemark>()
                        .ToList()
                        .Where(x => Convert.ToInt32(x.Tag) == _lastMark.Key).FirstOrDefault();

                    // Restore last color
                    if (lastMark is not null)
                        lastMark.Style.BackColor = _lastMark.Value;
                }

                if (currentMark is null) return;

                // Save last mark
                _lastMark = new KeyValuePair<int, Color>(index, currentMark.Style.BackColor);

                // Set the red color for current mark
                currentMark.Style.BackColor = Color.Red;
            }
        }

        private void btnDeleteMark_Click(object sender, EventArgs e)
        {
            if (_grid.SelectedRows.Count <= 0) return;
            if (_grid.SelectedRows.Count == 1 && _grid.Rows.Count > 1)
            {
                // Change color for one mark
                var row = _grid.SelectedRows.Cast<DataGridViewRow>().First();
                if (row is null) return;
                var data = (DataRowView)row.DataBoundItem;
                int.TryParse(data["Number"].ToString(), out var index);

                // Find current mark
                var currentMark = _layer.Items.Cast<C1.Win.Map.VectorPlacemark>()
                    .ToList()
                    .Where(x => Convert.ToInt32(x.Tag) == index).FirstOrDefault();

                if (currentMark is null) return;

                _layer.Items.Remove(currentMark);
                _table.Rows.Remove(data.Row);
            }
        }

        private void mnuContextDelete_Click(object sender, EventArgs e)
        {
            btnDeleteMark_Click(sender, e);
        }

        private void mnuContextAdd_Click(object sender, EventArgs e)
        {
            btnAddMark_Click(sender, e);
        }

        private void btnZoomArea_Click(object sender, EventArgs e)
        {
            if (_grid.SelectedRows.Count <= 0) return;
            if (_grid.SelectedRows.Count > 1 && _grid.Rows.Count > 1)
            {
                var list = _grid.SelectedRows.Cast<DataGridViewRow>()
                    .ToList()
                    .Select(x => x.DataBoundItem as DataRowView)
                    .Select(x => Convert.ToInt32(x["Number"]))
                    .ToList();

                var marks = _layer.Items.Where(x => list.Contains(Convert.ToInt32(x.Tag)));
                _mapControl.Map.ZoomToItems(marks);
            }
        }

        private void mnuContextZoomInItems_Click(object sender, EventArgs e)
        {
            btnZoomArea_Click(sender, e);
        }

        #endregion
    }
}
