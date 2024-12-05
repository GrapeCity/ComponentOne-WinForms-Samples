using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Chart;
using C1.Win.Chart;
using BaseExplorer;
using FlexChartExplorer.Data;
using System.Collections.ObjectModel;

namespace FlexChartExplorer.Samples
{
    public partial class DateTimeAxisGrouping : FlexChartBaseSample
    {
        private ComboBoxEx _cbXGroupSeparator;
        private ComboBoxEx _cbXMajorUnit;
        private CheckBoxEx _chbMinLabel, _chbMaxLabel;
        private FlexChart flexChart1;

        public DateTimeAxisGrouping()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.Line;
            this.flexChart1.Header.Content = "Stock Price Forecast";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = FinancialDataSource.GetQuotes(DateTime.Today,1000);
            this.flexChart1.BindingX = "Date";
            this.flexChart1.Series.Add(new Series { Binding = "High" });

            // Instantiate and assign the AxisGroupProvider,
            // and set the TimeUnits for each desired level.
            // To use the built-in provider:
            //DateTimeGroupProvider mtgp = new DateTimeGroupProvider(flexChart1.AxisX);

            // For the purposes of the sample, use the included provider.

            this.flexChart1.AxisX.GroupProvider = new MyDateTimeGroupProvider(flexChart1.AxisX);
            this.flexChart1.AxisX.GroupSeparator = AxisGroupSeparator.Horizontal;
            this.flexChart1.AxisX.Format = "dd-MMM";
            this.flexChart1.AxisX.LabelAngle = 90;

            this.flexChart1.Rendered += (s, e) => { _cbXGroupSeparator.SelectedItem = flexChart1.AxisX.GroupSeparator; };
        }
        /// <summary>
        /// Provides basic groups for DateTime values that extend beyond one month.  Although
        /// default groups are provided, explicit selection of the groups and format are possible.
        /// </summary>
        class MyDateTimeGroupProvider : IAxisGroupProvider
        {
            ObservableCollection<TimeUnits> _groupTypes = new ObservableCollection<TimeUnits>();
            Dictionary<TimeUnits, string> _groupFormats = new Dictionary<TimeUnits, string>();
            Axis _groupAxis = null;

            /// <summary>
            /// Gets the collection of group specifiers using the TimeUnits enumeration.  The index of each
            /// specifier indicates (level-1).  Specifiers modified using the collection Add, Insert and Remove
            /// methods of the collection.  If no values are specified, values are automatically selected
            /// based on the range.
            /// </summary>
            public ObservableCollection<TimeUnits> GroupTypes
            {
                get { return _groupTypes; }
            }

            /// <summary>
            /// Get a dictionary of formats keyed by the TimeUnits enum of each group.  Each value specifies
            /// the string.Format() of the numeric value followed by the year, with the exception of TimeUnits.Month
            /// for which the format specifies either all "M" characters (for the month name) or the numeric
            /// value of the month and year. Note if {1} is not included in the format, the year is not included.
            /// 
            /// Default formats are Day="{0}", Week="Week {0}, Month="MMM", Quarter="Q{0}", "Year="{0}".
            /// </summary>
            public Dictionary<TimeUnits, string> GroupFormats
            {
                get { return _groupFormats; }
            }

            /// <summary>
            /// This contstructor allows automatic generation of groups based upon the axis range.
            /// </summary>
            public MyDateTimeGroupProvider() { }

            /// <summary>
            /// This constructor allows automatic generation of groups based upon the axis range
            /// and the axis MajorUnit value.
            /// </summary>
            /// <param name="axis"></param>
            public MyDateTimeGroupProvider(Axis axis)
            {
                _groupAxis = axis;
            }

            /// <summary>
            /// As the first method called by FlexChart, this method provides the number of group
            /// levels provided by the class.
            /// </summary>
            /// <param name="range">
            /// Specifies the full range of the axis data.
            /// </param>
            /// <returns>Specifies number of group levels.</returns>
            public int GetLevels(IRange range)
            {
                // Base default groups on the specified range.
                // Require group is larger than the MajorUnit, has more than one member
                // and does not have too many members that they do not fit along the axis.
                if (_groupTypes.Count == 0)
                {
                    double majorUnitDays = (range.Max - range.Min) / 12; //approximate if MajorUnit = NaN

                    // if there are MajorUnit values, then request groupings with larger intervals
                    if (_groupAxis != null && !double.IsNaN(_groupAxis.MajorUnit))
                        majorUnitDays = new double[] { 1, 7, 30, 90, 365 }[(int)_groupAxis.TimeUnit] * _groupAxis.MajorUnit;

                    // only default to most commonly desired groups.
                    TimeUnits[] tu = { TimeUnits.Month, TimeUnits.Quarter, TimeUnits.Year };
                    double[] daysPerGroupUnit = { 30, 90, 365 };

                    DateTime start = DateTime.FromOADate(range.Min);
                    DateTime end = DateTime.FromOADate(range.Max);

                    List<DateTime> dates = new List<DateTime>();
                    List<string> labels = new List<string>();
                    for(int i=0;i<tu.Length; i++)
                    {
                        if (majorUnitDays < daysPerGroupUnit[i])
                        {
                            CreateTimeValues(tu[i], start, end, 1, dates, labels);
                            if (dates.Count>1 && dates.Count < 15)
                                _groupTypes.Add(tu[i]);
                            dates.Clear();labels.Clear();
                        }
                    }
                }
                return _groupTypes.Count;
            }

            /// <summary>
            /// Returns a list of IRange values for the level specified the by the appropriate
            /// entry in the GroupTypes collection.
            /// </summary>
            /// <param name="range">
            /// Specifies the full range of the axis.
            /// </param>
            /// <param name="level">
            /// Specifies the level of IRange values for the level specified by the appropriate
            /// entry in the GroupTypes collection.
            /// </param>
            /// <returns></returns>
            public IList<IRange> GetRanges(IRange range, int level)
            {
                if (level - 1 < 0 || level - 1 > _groupTypes.Count)
                    return null;        // invalid group request

                var timeRange = range as TimeRange;
                if (timeRange == null)
                    return null;

                var min = timeRange.TimeMin;
                var max = timeRange.TimeMax;
                var span = max - min;

                if (span.TotalDays < 1)
                    return null;

                List<DateTime> dates = new List<DateTime>();
                List<string> labels = new List<string>();
                TimeUnits mtu = _groupTypes[level - 1];
                CreateTimeValues(mtu, min, max, 1, dates, labels);

                List<IRange> ranges = new List<IRange>();
                for(int d = 1; d < dates.Count; d++)
                {
                    TimeRange tr = new TimeRange(labels[d-1], dates[d - 1], dates[d]);
                    ranges.Add(tr);
                }
                return ranges;
            }
            private void CreateTimeValues(TimeUnits mtu, DateTime startDate, DateTime endDate, int delta, List<DateTime> dates, List<string> labels)
            {
                startDate = new DateTime(startDate.Year, startDate.Month, startDate.Day);
                endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 23, 59, 59);
                string fmt = _groupFormats.ContainsKey(mtu) ? _groupFormats[mtu] : null;
                string label = null;

                DateTime currentDate = GetTimeUnit(mtu, startDate, 0, fmt, out label);
                while (currentDate <= endDate)
                {
                    dates.Add(currentDate);
                    labels.Add(label);
                    currentDate = GetTimeUnit(mtu, currentDate, delta, fmt, out label);
                }

                if (currentDate > endDate)
                {
                    dates.Add(endDate);
                    labels.Add(label);
                }

            }
            private DateTime GetTimeUnit(TimeUnits mtu, DateTime dt, int delta, string fmt, out string label)
            {
                dt = new DateTime(dt.Year, dt.Month, dt.Day);
                label = null;
                int unit = 0;

                switch (mtu)
                {
                    case TimeUnits.Day:
                        dt = dt.AddDays(delta);
                        label = fmt == null ? dt.Day.ToString() : string.Format(fmt, dt.Day, dt.Year);
                        break;

                    case TimeUnits.Month:
                        // first day of the month
                        dt = dt.AddDays(1 - dt.Day).AddMonths(delta);
                        if (fmt == null)
                            label = dt.ToString("MMM");
                        else if (string.IsNullOrEmpty(fmt.Replace("M", "")))
                            label = dt.ToString(fmt);
                        else
                            label = string.Format(fmt, dt.Month, dt.Year);
                        break;

                    case TimeUnits.Quarter:
                        // first day of the quarter
                        unit = (dt.Month + 2) / 3;
                        dt = dt.AddDays(1 - dt.DayOfYear).AddMonths(((unit - 1 + delta) * 3));
                        unit = (dt.Month + 2) / 3;
                        label = (fmt == null) ? "Q" + unit.ToString() : string.Format(fmt, unit, dt.Year);
                        break;

                    case TimeUnits.Week:
                        // first day of the week
                        unit = (dt.DayOfYear + 6) / 7;
                        dt = dt.AddDays(1 - dt.DayOfYear).AddDays((unit - 1 + delta) * 7);
                        unit = (dt.DayOfYear + 6) / 7;
                        label = (fmt == null) ? "Week" + unit.ToString() : string.Format(fmt, unit, dt.Year);
                        break;

                    case TimeUnits.Year:
                        // first day of the year
                        dt = dt.AddDays(1 - dt.DayOfYear).AddYears(delta);
                        label = (fmt == null) ? dt.Year.ToString() : string.Format(fmt, dt.Year);
                        break;
                }
                return dt;
            }
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _cbXGroupSeparator = ControlFactory.EnumBasedCombo(typeof(AxisGroupSeparator), "AxisX Group Separator");
            _cbXGroupSeparator.Width = 160;
            _cbXGroupSeparator.SelectedIndexChanged += (s, e) => { flexChart1.AxisX.GroupSeparator = (AxisGroupSeparator)Enum.Parse(typeof(AxisGroupSeparator), _cbXGroupSeparator.SelectedItem.ToString()); };

            _cbXMajorUnit = new ComboBoxEx("Major Unit");
            _cbXMajorUnit.DataSource = new string[] { "Default", "1 Week", "2 Week", "1 Month", "2 Month", "3 Month" };
            _cbXMajorUnit.SelectedIndexChanged += _cbXMajorUnit_SelectedIndexChanged;

            _chbMinLabel = new CheckBoxEx("Min Label");
            _chbMinLabel.CheckedChanged += (s, e) => { flexChart1.AxisX.LabelMin = _chbMinLabel.Checked; };

            _chbMaxLabel = new CheckBoxEx("Max Label");
            _chbMaxLabel.CheckedChanged += (s, e) => { flexChart1.AxisX.LabelMax = _chbMaxLabel.Checked; };

            this.pnlControls.Controls.Add(_cbXGroupSeparator);
            this.pnlControls.Controls.Add(_cbXMajorUnit);
            this.pnlControls.Controls.Add(_chbMinLabel);
            this.pnlControls.Controls.Add(_chbMaxLabel);
        }

        private void _cbXMajorUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            var values = _cbXMajorUnit.SelectedItem.ToString().Split(' ');
            if (values.Length == 1)
                flexChart1.AxisX.MajorUnit = double.NaN;
            else
            {
                flexChart1.AxisX.MajorUnit = Convert.ToInt16(values[0]);
                flexChart1.AxisX.TimeUnit = (TimeUnits)Enum.Parse(typeof(TimeUnits), values[1]);
            }
            (flexChart1.AxisX.GroupProvider as MyDateTimeGroupProvider).GroupTypes.Clear();
        }
    }
}
