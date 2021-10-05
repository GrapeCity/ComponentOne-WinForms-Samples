using C1.Win.Input;
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
    public partial class RangeSliderView : UserControl
    {
        private C1RangeSlider rangeSlider;
        private DateTimePicker fromDatePicker, toDatePicker;
        private NumericUpDown fromNumeric, toNumeric;

        private Timer _delay;
        private double _lowerValue = double.NaN, _upperValue = double.NaN;
        private double _minValue = double.NaN, _maxValue = double.NaN;
        public double LowerValue
        {
            get { return _lowerValue; }
            set
            {
                if (value != double.NaN && _lowerValue != value)
                {
                    _lowerValue = value;
                    if (_lowerValue > UpperValue)
                        UpperValue = value;
                    if (this.IsHandleCreated)
                    {
                        rangeSlider.LowerValue = _lowerValue;
                        if (fromNumeric != null && toNumeric != null)
                            fromNumeric.Value = toNumeric.Minimum = (decimal)_lowerValue;
                        if (fromDatePicker != null && toDatePicker != null)
                            fromDatePicker.Value = toDatePicker.MinDate = DateTime.FromOADate(_lowerValue);
                        OnRangeChanged();
                    }
                }
            }
        }
        public double UpperValue
        {
            get { return _upperValue; }
            set
            {
                if (value != double.NaN && _upperValue != value)
                {
                    _upperValue = value;
                    if (_upperValue < LowerValue)
                        LowerValue = value;
                    if (this.IsHandleCreated)
                    {
                        rangeSlider.UpperValue = _upperValue;
                        if (fromNumeric != null && toNumeric != null)
                            toNumeric.Value = fromNumeric.Maximum = (decimal)_upperValue;
                        if (fromDatePicker != null && toDatePicker != null)
                            toDatePicker.Value = fromDatePicker.MaxDate = DateTime.FromOADate(_upperValue);
                        OnRangeChanged();
                    }
                }
            }
        }
        public double Minimum
        {
            get { return _minValue; }
            set
            {
                if (value != double.NaN && _minValue != value)
                {
                    _minValue = value;
                    if (_minValue > Maximum)
                        Maximum = value;

                    if (this.IsHandleCreated)
                    {
                        rangeSlider.Minimum = _minValue;
                        if (fromNumeric != null)
                            fromNumeric.Minimum = (decimal)_minValue;
                        if (fromDatePicker != null)
                            fromDatePicker.MinDate = DateTime.FromOADate(_minValue);
                    }
                }
            }
        }
        public double Maximum
        {
            get { return _maxValue; }
            set
            {
                if (value != double.NaN && _maxValue != value)
                {
                    _maxValue = value;
                    if (_maxValue < Minimum)
                        Minimum = value;
                    if (this.IsHandleCreated)
                    {
                        rangeSlider.Maximum = _maxValue;
                        if (toNumeric != null)
                            toNumeric.Maximum = (decimal)_maxValue;
                        if (toDatePicker != null)
                            toDatePicker.MaxDate = DateTime.FromOADate(_maxValue);
                    }
                }
            }
        }
        public bool IsFullRange
        {
            get
            {
                return Minimum == LowerValue && Maximum == UpperValue;
            }
        }
        public bool IsDateTimeRange
        {
            get
            {
                return fromDatePicker != null && toDatePicker != null;
            }
        }

        public bool IsLoaded { get; private set; }

        public RangeSliderView(bool isDateRange = false)
        {
            InitializeComponent();
            var container = new TableLayoutPanel() { RowCount = 2, Dock = DockStyle.Fill };

            rangeSlider = new C1RangeSlider()
            {
                Orientation = System.Windows.Forms.Orientation.Horizontal,
                Height = 20,
                Dock = DockStyle.Fill
            };

            var editors = new FlowLayoutPanel() { FlowDirection = FlowDirection.LeftToRight, Height = 30, Dock = DockStyle.Fill };

            var fromLabel = new Label() { Text = "From :", AutoSize = true, Margin = new Padding(5) };
            var toLabel = new Label() { Text = "To :", AutoSize = true, Margin = new Padding(5) };

            if (isDateRange)
            {
                //Add DateTime Pickers
                fromDatePicker = new DateTimePicker()
                {
                    Width = 60,
                    Format = DateTimePickerFormat.Short,
                };

                toDatePicker = new DateTimePicker()
                {
                    Width = 60,
                    Format = DateTimePickerFormat.Short,
                };

                editors.Controls.Add(fromLabel);
                editors.Controls.Add(fromDatePicker);
                editors.Controls.Add(toLabel);
                editors.Controls.Add(toDatePicker);
            }
            else
            {
                //Add NumericUpDown boxes
                fromNumeric = new NumericUpDown()
                {
                    Width = 50,
                    Increment = 1,
                };
                toNumeric = new NumericUpDown()
                {
                    Width = 50,
                    Increment = 1,
                };

                editors.Controls.Add(fromLabel);
                editors.Controls.Add(fromNumeric);
                editors.Controls.Add(toLabel);
                editors.Controls.Add(toNumeric);
            }

            container.Controls.Add(rangeSlider, 0, 0);
            container.Controls.Add(editors, 0, 1);
            Controls.Add(container);

            _delay = new Timer() { Interval = 500 };
            _delay.Tick += _delay_Tick;

            this.Load += RangeSliderView_Load;
        }
        private void RangeSliderView_Load(object sender, EventArgs eArgs)
        {
            #region RangeSlider Settings
            rangeSlider.Maximum = Maximum;
            rangeSlider.Minimum = Minimum;
            rangeSlider.UpperValueChanged += (s, e) =>
            {
                UpperValue = rangeSlider.UpperValue;
            };
            rangeSlider.LowerValueChanged += (s, e) =>
            {
                LowerValue = rangeSlider.LowerValue;
            };
            rangeSlider.UpperValue = UpperValue;
            rangeSlider.LowerValue = LowerValue;
            #endregion
            #region DatePicker Settings
            if (fromDatePicker != null && toDatePicker != null)
            {
                fromDatePicker.ValueChanged += (s, e) =>
                {
                    LowerValue = fromDatePicker.Value.ToOADate();
                };
                toDatePicker.ValueChanged += (s, e) =>
                {
                    UpperValue = toDatePicker.Value.ToOADate();
                };
                toDatePicker.Value = DateTime.FromOADate(UpperValue);
                fromDatePicker.Value = DateTime.FromOADate(LowerValue);
            }
            #endregion
            #region NumericBox Settings
            if (fromNumeric != null && toNumeric != null)
            {
                fromNumeric.ValueChanged += (s, e) =>
                {
                    LowerValue = (double)fromNumeric.Value;
                };
                toNumeric.ValueChanged += (s, e) =>
                {
                    UpperValue = (double)toNumeric.Value;
                };
                toNumeric.Value = (decimal)UpperValue;
                fromNumeric.Value = (decimal)LowerValue;
            }
            #endregion
            RangeChanged.Invoke(this, eArgs);
            IsLoaded = true;
        }

        private void _delay_Tick(object sender, EventArgs e)
        {
            _delay.Stop();
            RangeChanged?.Invoke(this, e);
        }
        public void SetFullRange()
        {
            this.UpperValue = this.Maximum;
            this.LowerValue = this.Minimum;
        }
        public event EventHandler RangeChanged;

        protected virtual void OnRangeChanged()
        {
            _delay.Start();
        }
    }
}
