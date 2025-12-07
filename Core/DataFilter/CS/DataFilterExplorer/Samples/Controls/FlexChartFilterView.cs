using C1.Chart;
using C1.Win.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataFilterExplorer.Samples
{
    public partial class FlexChartFilterView : UserControl
    {
        #region fields
        private bool _isLoaded = false;
        private List<int> _selectedIndices;
        private bool _showSelectionMode = true, _showRangeSlider = false, _selecting;
        private Point _ptStart = Point.Empty, _ptEnd = Point.Empty;
        private IEnumerable<object> _items;
        private SelectionMode _selectionMode = SelectionMode.NormalSelect;
        private CheckBox _chbClear;
        private ComboBox _cbSelectionMode;
        protected FlowLayoutPanel _pnlControlOptions;

        TableLayoutPanel _tablePanel;

        #endregion

        #region Object Model

        public bool IsLoaded => _isLoaded && Slider.IsLoaded;

        public FlexChart Chart { get; }
        public RangeSliderView Slider { get; }

        [DefaultValue(SelectionMode.NormalSelect)]
        public SelectionMode SelectionMode
        {
            get
            {
                return _selectionMode;
            }
            set
            {
                if (_selectionMode != value)
                {
                    _selectionMode = value;
                    _cbSelectionMode.SelectedIndex = _cbSelectionMode.SelectedIndex == -1 ? -1 : (int)value;
                }
            }
        }

        [DefaultValue(true)]
        public bool ShowSelectionMode
        {
            get { return _showSelectionMode; }
            set
            {
                if (value != _showSelectionMode && _cbSelectionMode != null)
                {
                    _showSelectionMode = _cbSelectionMode.Visible = value;
                }
            }
        }

        [DefaultValue(false)]
        public bool ShowRangeSlider
        {
            get
            {
                return _showRangeSlider;
            }
            set
            {
                _showRangeSlider = value;
                if (this.IsHandleCreated)
                    Slider.Visible = value;
            }
        }
        public bool IsGroupedData
        {
            get { return _items.First().GetType() == typeof(GroupItem) || _items.First().GetType().IsSubclassOf(typeof(GroupItem)); }
        }

        public bool IsFilterApplied
        {
            get { return !_chbClear.Checked; }
        }

        public event EventHandler SelectionChanged;
        #endregion

        #region C'tor
        public FlexChartFilterView(IEnumerable<object> items,
            string bindingX,
            string binding,
            ChartType chartType = ChartType.Column)
        {
            InitializeComponent();

            Margin = new Padding(0);
            Padding = new Padding(0);

            _tablePanel = new TableLayoutPanel
            {
                Margin = new Padding(0),
                Padding = new Padding(0),
                RowCount = 3,
                Dock = DockStyle.Fill,
            };

            _selectedIndices = new List<int>();
            this._items = items;

            //Initialize Chart
            this.Chart = new FlexChart()
            {
                Margin = new Padding(0),
                Padding = new Padding(0),
                ChartType = chartType,
                DataSource = items,
                BindingX = bindingX,
                Binding = binding,
                Dock = DockStyle.Fill,
                //Margin = new Padding(0, 30, 0, 0)                
            };

            var ser = new Series();
            ser.SymbolRendering += OnSeriesSymbolRendering;
            this.Chart.Series.Add(ser);

            this.Chart.SelectionStyle.Stroke = Brushes.DarkBlue;
            this.Chart.SelectionStyle.StrokeWidth = 2;
            this.Chart.SelectionStyle.Fill = new SolidBrush(Color.FromArgb(200, Color.CornflowerBlue));
            this.Chart.ToolTip.Content = "X: {x} \nY: {y}";
            this.Chart.AxisX.LabelMax = this.Chart.AxisX.LabelMin = true;
            this.Chart.MouseClick += OnChartMouseClick;
            this.Chart.Rendered += OnChartRendered;

            _pnlControlOptions = new FlowLayoutPanel()
            {
                Margin = new Padding(0),
                Padding = new Padding(0),
                FlowDirection = FlowDirection.LeftToRight,
                //Dock = DockStyle.Top,
                Dock = DockStyle.Fill,
                //Height = 30,
                //AutoScroll = true,
            };

            _chbClear = new CheckBox()
            {
                Text = "Clear",
                Checked = true,
                Enabled = false,
                AutoSize = true,
            };
            _chbClear.CheckedChanged += (s, e) => OnClearChanged();

            _cbSelectionMode = new ComboBox()
            {
                Width = 80,
                Visible = ShowSelectionMode,
                FlatStyle = FlatStyle.Flat,
                DataSource = Enum.GetValues(typeof(SelectionMode)),
            };
            _cbSelectionMode.SelectedIndexChanged += (s, e) =>
            {
                this.SelectionMode = (SelectionMode)_cbSelectionMode.SelectedValue;
                OnSelectionModeChanged();
            };

            _pnlControlOptions.Controls.Add(_chbClear);
            _pnlControlOptions.Controls.Add(_cbSelectionMode);

            var isDateTime = items.First().GetType().GetProperty(Chart.BindingX).PropertyType == typeof(DateTime);

            Slider = new RangeSliderView(isDateTime)
            {
                Margin = new Padding(0),
                Padding = new Padding(0),
                //Dock = DockStyle.Bottom,                
                Dock = DockStyle.Fill
            };
            SetupRangeSlider();
            Slider.RangeChanged += RangeSliderView_RangeChanged;

            _pnlControlOptions.BorderStyle = BorderStyle.FixedSingle;
            Slider.BorderStyle = BorderStyle.FixedSingle;

            _tablePanel.ColumnCount = 1;
            _tablePanel.ColumnStyles.Add(new ColumnStyle() { SizeType = SizeType.Percent, Width = 100 });
            _tablePanel.RowStyles.Add(new RowStyle() { Height = 30, SizeType = SizeType.Absolute });
            _tablePanel.RowStyles.Add(new RowStyle() { SizeType = SizeType.Percent, Height = 100 });


            _tablePanel.Controls.Add(_pnlControlOptions, 0, 0);
            _tablePanel.Controls.Add(Chart, 0, 1);
            _tablePanel.Controls.Add(Slider, 0, 2);

            Controls.Add(_tablePanel);

            float scale = (float)DeviceDpi / (float)C1.Win.Util.DpiHelper.DEFAULT_DPI;
            _tablePanel.Scale(new System.Drawing.SizeF(scale, scale));

            //Controls.Add(_pnlControlOptions);
            //Controls.Add(Chart);
            //Controls.Add(Slider);
        }
        #endregion

        #region Private Methods

        #region Control Event Handlers
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _cbSelectionMode.SelectedIndex = (int)SelectionMode;
            Slider.Visible = ShowRangeSlider;
            Slider.Height = Slider.Height >= 80 ? 80 : 40;
            _tablePanel.RowStyles.Add(new RowStyle() { SizeType = SizeType.Absolute, Height = Slider.Visible ? Slider.Height : 0 });
            _isLoaded = true;
        }
        private void OnClearChanged()
        {
            if (_chbClear.Checked)
            {
                _selectedIndices.Clear();
                Slider.SetFullRange();
                OnSelectedPointsChanged();
            }
            _chbClear.Enabled = !_chbClear.Checked;
        }
        private void OnChartRendered(object sender, RenderEventArgs e)
        {
            if (_selecting)
            {
                e.Engine.SetStroke(Brushes.Red);
                var minX = Math.Min(_ptStart.X, _ptEnd.X);
                var minY = Math.Min(_ptStart.Y, _ptEnd.Y);
                var maxX = Math.Max(_ptStart.X, _ptEnd.X);
                var maxY = Math.Max(_ptStart.Y, _ptEnd.Y);
                e.Engine.DrawRect(minX, minY, maxX - minX, maxY - minY);
            }
        }

        private void OnChartMouseClick(object sender, MouseEventArgs e)
        {
            var hitTest = Chart.HitTest(e.Location);
            if (hitTest.Item != null && hitTest.Distance == 0)
            {
                var currentSelected = hitTest.PointIndex;
                if (!_selectedIndices.Contains(currentSelected))
                    _selectedIndices.Add(currentSelected);
                else
                    _selectedIndices.Remove(currentSelected);
                OnSelectedPointsChanged();
            }
        }

        private void OnChartMouseUp(object sender, MouseEventArgs e)
        {
            if (_selecting)
            {
                _ptEnd = e.Location;
                FindItemsInRectRange();
                _ptStart = Point.Empty;
                _ptEnd = Point.Empty;
                _selecting = false;

                Chart.Capture = false;
                Chart.Refresh();
            }
            else
            {
                _ptStart = Point.Empty;
                _ptEnd = Point.Empty;
            }
        }

        private void OnChartMouseMove(object sender, MouseEventArgs e)
        {
            if (_ptStart != Point.Empty)
            {
                _ptEnd = e.Location;
                Chart.Refresh();
                _selecting = true;
            }
        }

        private void OnChartMouseDown(object sender, MouseEventArgs e)
        {
            _ptStart = e.Location;
            Chart.Capture = true;
        }
        private void OnSeriesSymbolRendering(object sender, RenderSymbolEventArgs e)
        {
            if (_selectedIndices.Contains(e.Index))
            {
                if (Chart.SelectionStyle.Stroke != null)
                    e.Engine.SetStroke(Chart.SelectionStyle.Stroke);
                if (Chart.SelectionStyle.StrokeWidth > 0)
                    e.Engine.SetStrokeThickness(Chart.SelectionStyle.StrokeWidth);
                if (Chart.SelectionStyle.Fill != null)
                    e.Engine.SetFill(Chart.SelectionStyle.Fill);
            }
        }
        private void RangeSliderView_RangeChanged(object sender, EventArgs e)
        {
            if (!Slider.IsFullRange)
            {
                Chart.AxisX.Min = Slider.LowerValue;
                Chart.AxisX.Max = Slider.UpperValue;
            }
            else
            {
                Chart.AxisX.Min = Chart.AxisX.Max = double.NaN;
            }
            OnSelectedPointsChanged();
        }
        #endregion

        private void OnSelectionModeChanged()
        {
            Chart.MouseClick -= OnChartMouseClick;
            Chart.MouseDown -= OnChartMouseDown;
            Chart.MouseMove -= OnChartMouseMove;
            Chart.MouseUp -= OnChartMouseUp;

            switch (SelectionMode)
            {
                case SelectionMode.NormalSelect:
                    Chart.MouseClick += OnChartMouseClick;
                    break;
                case SelectionMode.RangeSelect:
                    Chart.MouseDown += OnChartMouseDown;
                    Chart.MouseMove += OnChartMouseMove;
                    Chart.MouseUp += OnChartMouseUp;
                    break;
            }
        }

        private void OnSelectedPointsChanged()
        {
            _chbClear.Checked = _selectedIndices.Count == 0 ? Slider.IsFullRange : false;
            Chart.Refresh();
            SelectionChanged?.Invoke(this, null);
        }

        private void SetupRangeSlider()
        {
            var values = GetChartXValues().ToList();
            Slider.Maximum = values.Max();
            Slider.Minimum = values.Min();
            Slider.SetFullRange();
        }
        private void FindItemsInRectRange()
        {
            var startX = Chart.AxisX.ConvertBack(Math.Min(_ptStart.X, _ptEnd.X));
            var endX = Chart.AxisX.ConvertBack(Math.Max(_ptStart.X, _ptEnd.X));
            var startY = Chart.AxisY.ConvertBack(Math.Max(_ptStart.Y, _ptEnd.Y));
            var endY = Chart.AxisY.ConvertBack(Math.Min(_ptStart.Y, _ptEnd.Y));

            var xValues = GetChartXValues();
            var yValues = Chart.Series[0].GetValues(0);

            for (int idx = 0; idx < xValues.Count(); idx++)
            {
                if ((startX <= xValues[idx]) && (xValues[idx] <= endX) && (startY <= yValues[idx]) && (yValues[idx] <= endY))
                    _selectedIndices.Add(idx);
            }
            OnSelectedPointsChanged();
        }
        private double[] GetChartXValues()
        {
            var values = Chart.Series[0].GetValues(1);
            if (values == null)
            {
                values = new double[_items.Count()];
                int idx = 0;
                _items.ToList().ForEach(x => values[idx] = idx++);
            }
            return values;
        }
        #endregion

        #region Public Methods
        public IEnumerable<object> GetSelectedValues()
        {
            var items = this._items.ToList();
            return items.Where(x => _selectedIndices.Contains(items.IndexOf(x)));
        }
        public Tuple<object, object> GetSliderRange()
        {
            Tuple<object, object> values = null;

            if (Slider.IsFullRange)
                return values;
            if (Slider.IsDateTimeRange && !IsGroupedData)
                values = new Tuple<object, object>(DateTime.FromOADate(Slider.LowerValue), DateTime.FromOADate(Slider.UpperValue));
            else
                values = new Tuple<object, object>(Slider.LowerValue, Slider.UpperValue);
            return values;
        }
        public void ChangeDataSource(IEnumerable<object> items, string bindingX = "", string binding = "")
        {
            Chart.DataSource = this._items = items;
            Chart.BindingX = bindingX != string.Empty ? bindingX : Chart.BindingX;
            Chart.Series[0].Binding = binding != string.Empty ? binding : Chart.Series[0].Binding;
            Slider.Controls[0].Controls[1].Visible = !IsGroupedData;
            Slider.Height = !IsGroupedData ? 80 : 40;
            SetupRangeSlider();
            _selectedIndices.Clear();
            OnSelectedPointsChanged();
        }
        #endregion
    }
}
