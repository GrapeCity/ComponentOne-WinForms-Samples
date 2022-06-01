using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C1.Chart;
using C1.DataFilter;

namespace DataFilterExplorer.Samples
{
    public class FlexChartDateTimeFilter : FlexChartFilter
    {
        #region fields
        private FlexChartDateTimeFilterView dtFilterView
        {
            get { return filterView as FlexChartDateTimeFilterView; }
            set { filterView = value; }
        }
        //Original Data provided by User
        private IEnumerable<object> source;
        #endregion
        #region Properties
        public bool ShowGroupBy
        {
            get { return dtFilterView.ShowGroupBy; }
            set { dtFilterView.ShowGroupBy = value; }
        }
        public bool ShowAggregate
        {
            get { return dtFilterView.ShowAggregate; }
            set { dtFilterView.ShowAggregate = value; }
        }
        public DateTimeGroupOption GroupBy
        {
            get { return dtFilterView.GroupBy; }
            set
            {
                dtFilterView.GroupBy = value;
            }
        }
        public AggregateFunction Aggregate
        {
            get { return (filterView as FlexChartDateTimeFilterView).Aggregate; }
            set
            {
                (filterView as FlexChartDateTimeFilterView).Aggregate = value;
            }
        }
        public bool UseCustomGroups { get; set; } = false;

        public Dictionary<DateTimeGroupOption, string> GroupFormats = new Dictionary<DateTimeGroupOption, string>()
        {
            { DateTimeGroupOption.Yearly, "yyyy" },
            { DateTimeGroupOption.Quarterly, "yyyy|Q{0}" },
            { DateTimeGroupOption.Monthly, "MMM-yyyy" },
            { DateTimeGroupOption.Weekly, "MMM-yyyy|W{0}" },
        };
        #endregion
        #region Events
        public event EventHandler<GroupByEventArgs> GroupByChanged;
        #endregion
        #region c'tor
        public FlexChartDateTimeFilter(IEnumerable<object> items, string xProperty, string yProperty, ChartType chartType = ChartType.Column)
        {
            dtFilterView = new FlexChartDateTimeFilterView(items, xProperty, yProperty, chartType) { Height = 250 };
            PropertyName = propertyX = xProperty;
            propertyY = yProperty;
            source = this.items = items.OrderBy(x => GetPropertyValue(xProperty, x));
            dtFilterView.SelectionChanged += (s, e) => OnValueChanged(new ValueChangedEventArgs() { ApplyFilter = dtFilterView.IsLoaded });
            dtFilterView.GroupByChanged += FlexChartDateTimeFilter_GroupByChanged;
            dtFilterView.AggregateChanged += FlexChartDateTimeFilter_AggregateChanged;

            Control = filterView;
        }
        #endregion
        #region Event Handlers
        private void FlexChartDateTimeFilter_AggregateChanged(object sender, EventArgs e)
        {
            if (GroupBy != DateTimeGroupOption.ShowAll)
            {
                UpdateView();
            }
        }

        private void FlexChartDateTimeFilter_GroupByChanged(object sender, EventArgs e)
        {
            if (UseCustomGroups)
            {
                var customGroups = new GroupByEventArgs();
                GroupByChanged?.Invoke(this, customGroups);
                items = customGroups.ItemsSource == null ? source : customGroups.ItemsSource;
                dtFilterView.ChangeDataSource(items, customGroups.BindingX, customGroups.Binding);
            }
            else
            {
                GroupByChanged?.Invoke(this, null);
                UpdateView();
            }
        }
        #endregion
        #region Private Helpers
        private void UpdateView()
        {
            UpdateItems();
            if (GroupBy == DateTimeGroupOption.ShowAll)
                dtFilterView.ChangeDataSource(items, propertyX, propertyY);
            else
                dtFilterView.ChangeDataSource(items, "XValue", "YValue");
        }
        private void UpdateItems()
        {
            switch (GroupBy)
            {
                case DateTimeGroupOption.ShowAll:
                    items = source;
                    break;
                case DateTimeGroupOption.Yearly:
                    items = GetGroupByYear();
                    break;
                case DateTimeGroupOption.Quarterly:
                    items = GetGroupByQuarter();
                    break;
                case DateTimeGroupOption.Monthly:
                    items = GetGroupByMonth();
                    break;
                case DateTimeGroupOption.Weekly:
                    items = GetGroupByWeek();
                    break;
            }
        }
        private IEnumerable<object> GetGroupByYear()
        {
            var yearsData = source.Select(x =>
            {
                DateTime dt = (DateTime)GetPropertyValue(propertyX, x);
                var data = new
                {
                    GroupKey = new DateTime(dt.Year, 1, 1),
                    Value = (double)GetPropertyValue(propertyY, x),
                };
                return data;
            });
            return yearsData.GroupBy(x => x.GroupKey).Select(x => new GroupItem
            {
                XValue = x.Key.ToString(GroupFormats[DateTimeGroupOption.Yearly]),
                YValue = x.Select(y=>y.Value).Aggregate(Aggregate),
                Min = x.Key,
                Max = new DateTime(x.Key.Year, 12, 31),
            });
        }
        private IEnumerable<object> GetGroupByQuarter()
        {
            var quartersData = source.Select(x =>
            {
                DateTime dt = (DateTime)GetPropertyValue(propertyX, x);
                var data = new
                {
                    GroupKey = dt.GetFirstDateOfQuarter(),
                    Value = (double)GetPropertyValue(propertyY, x),
                };
                return data;
            });
            return quartersData.GroupBy(x => x.GroupKey).Select(x =>
            {
                return new GroupItem
                {
                    XValue = GetFormattedString(x.Key, GroupFormats[DateTimeGroupOption.Quarterly], x.Key.GetQuarterNumber()),
                    YValue = x.Select(y => y.Value).Aggregate(Aggregate),
                    Min = x.Key,
                    Max = x.Key.GetLastDateOfQuarter(),
                };
            });
        }
        private IEnumerable<object> GetGroupByMonth()
        {
            var monthsData = source.Select(x =>
            {
                DateTime dt = (DateTime)GetPropertyValue(propertyX, x);
                var data = new
                {
                    GroupKey = new DateTime(dt.Year, dt.Month, 1),
                    Value = (double)GetPropertyValue(propertyY, x),
                };
                return data;
            });
            return monthsData.GroupBy(x => x.GroupKey).Select(x => new GroupItem
            {
                XValue = x.Key.ToString(GroupFormats[DateTimeGroupOption.Monthly]),
                YValue = x.Select(y => y.Value).Aggregate(Aggregate),
                Min = x.Key,
                Max = new DateTime(x.Key.Year, x.Key.Month, DateTime.DaysInMonth(x.Key.Year, x.Key.Month)),
            });
        }
        private IEnumerable<object> GetGroupByWeek()
        {
            var weeksData = source.Select(x =>
            {
                DateTime dt = (DateTime)GetPropertyValue(propertyX, x);
                var data = new
                {
                    GroupKey = dt.GetFirstDateOfWeek(),
                    Value = (double)GetPropertyValue(propertyY, x),
                };
                return data;
            });
            return weeksData.GroupBy(x => x.GroupKey).Select(x => new GroupItem
            {
                XValue = GetFormattedString(x.Key, GroupFormats[DateTimeGroupOption.Weekly], x.Key.GetWeekOfMonth()),
                YValue = x.Select(y => y.Value).Aggregate(Aggregate),
                Min = x.Key,
                Max = x.Key.GetLastDateOfWeek(),
            });
        }
        #endregion
        public string GetFormattedString(DateTime date, string Format, int formatItemVal)
        {
            var parts = Format.Split('|');
            var result = string.Empty;
            foreach (var part in parts)
            {
                result += result == string.Empty ? string.Empty : " ";
                result += part.Contains("{0}") ? string.Format(part, formatItemVal) : date.ToString(part);
            }
            return result;
        }
    }
    public class GroupByEventArgs
    {
        public IEnumerable<GroupItem> ItemsSource { get; set; }
        public string BindingX { get; set; }
        public string Binding { get; set; }
    }
}
