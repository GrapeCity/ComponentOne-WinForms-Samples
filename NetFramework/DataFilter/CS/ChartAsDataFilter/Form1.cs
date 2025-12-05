using C1.Win.FlexGrid;
using C1.Win.Chart.Interaction;
using ChartAsDataFilter.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartAsDataFilter
{
    public partial class Form1 : Form
    {
        private ObservableCollection<Quote> finanicalData;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            finanicalData = new ObservableCollection<Quote>(DataService.GetFinancialData(500));
            //FlexGrid
            c1FlexGrid1.DataSourceChanged += C1FlexGrid1_DataSourceChanged;
            c1FlexGrid1.DataSource = finanicalData;
            //DataFilter
            c1DataFilter1.AutoGenerateFilters = false;
            c1DataFilter1.DataSource = finanicalData;
            c1DataFilter1.FilterChanged += (s, args) =>
            {
                c1FlexGrid1.DataSource = c1DataFilter1.View.ToList();
            };
            InitFilters();            
        }

        private void C1FlexGrid1_DataSourceChanged(object sender, EventArgs e)
        {
            for (int i = 1; i < c1FlexGrid1.Cols.Count; i++)
                c1FlexGrid1.Cols[i].StarWidth = "*";
        }
        private void InitFilters()
        {
            var priceFilter = new FlexChartFilter(finanicalData, "Date", "High", C1.Chart.ChartType.Scatter);
            priceFilter.HeaderText = "Daily High Prices";
            priceFilter.SelectionMode = SelectionMode.RangeSelect;
            priceFilter.ShowRangeSlider = true;
            priceFilter.SliderLowerValue = new DateTime(finanicalData.Last().Date.Year, 7, 15).ToOADate();
            priceFilter.SliderUpperValue = finanicalData.Last().Date.ToOADate();
            priceFilter.FlexChart.SelectionStyle.FillColor = Color.NavajoWhite;
            priceFilter.FlexChart.SelectionStyle.StrokeColor = Color.Red;
            c1DataFilter1.Filters.Add(priceFilter);

            var grpVolumeFilter = new FlexChartDateTimeFilter(finanicalData, "Date", "Volume", C1.Chart.ChartType.Column);
            grpVolumeFilter.ShowSelectionMode = false;
            grpVolumeFilter.HeaderText = "Volume";
            grpVolumeFilter.FlexChart.AxisY.Format = "#,##0,,M";
            grpVolumeFilter.GroupByChanged += (s, e) =>
            {
                var dtFilter = (s as FlexChartDateTimeFilter);
                dtFilter.ShowRangeSlider = dtFilter.GroupBy != DateTimeGroupOption.Quarterly && dtFilter.GroupBy != DateTimeGroupOption.Yearly;
            };
            grpVolumeFilter.GroupBy = DateTimeGroupOption.Yearly;
            c1DataFilter1.Filters.Add(grpVolumeFilter);

            var customDtFilter = new FlexChartDateTimeFilter(finanicalData, "Date", "High,Low,Open,Close", C1.Chart.ChartType.Candlestick);
            customDtFilter.HeaderText = "High-Low-Open-Close";
            customDtFilter.FlexChart.ToolTip.Content = "X:{x}\nH:{High}\nL:{Low}\nO:{Open}\nC:{Close}";
            customDtFilter.UseCustomGroups = true;
            customDtFilter.GroupByChanged += CustomDtFilter_GroupByChangedChanged;
            customDtFilter.GroupBy = DateTimeGroupOption.Monthly;
            customDtFilter.SliderLowerValue = 17;
            customDtFilter.SliderUpperValue = 24;
            customDtFilter.ShowAggregate = customDtFilter.ShowSelectionMode = false;
            c1DataFilter1.Filters.Add(customDtFilter);
        }

        private void CustomDtFilter_GroupByChangedChanged(object sender, GroupByEventArgs e)
        {
            var dtFilter = sender as FlexChartDateTimeFilter;
            switch (dtFilter.GroupBy)
            {
                case DateTimeGroupOption.ShowAll:
                    e.BindingX = "Date";
                    dtFilter.ShowRangeSlider = true;
                    break;
                case DateTimeGroupOption.Yearly:
                    e.BindingX = "XValue";
                    e.ItemsSource = GetGroupByYear(dtFilter);
                    dtFilter.ShowRangeSlider = false;
                    break;
                case DateTimeGroupOption.Quarterly:
                    e.BindingX = "XValue";
                    e.ItemsSource = GetGroupByQuarter(dtFilter);
                    dtFilter.ShowRangeSlider = false;
                    break;
                case DateTimeGroupOption.Monthly:
                    e.BindingX = "XValue";
                    e.ItemsSource = GetGroupByMonth(dtFilter);
                    dtFilter.ShowRangeSlider = true;
                    break;
                case DateTimeGroupOption.Weekly:
                    e.BindingX = "XValue";
                    e.ItemsSource = GetGroupByWeek(dtFilter);
                    dtFilter.ShowRangeSlider = true;
                    break;
            }
        }
        private IEnumerable<CustomGroupItem> GetGroupByYear(FlexChartDateTimeFilter dtFilter)
        {
            var yearsData = finanicalData.Select(x =>
            {
                DateTime dt = x.Date;
                var data = new
                {
                    GroupKey = new DateTime(dt.Year, 1, 1),
                    High = x.High, Low = x.Low, Open = x.Open, Close =x.Close,
                };
                return data;
            });
            return yearsData.GroupBy(x => x.GroupKey).Select(x => new CustomGroupItem
            {
                XValue = x.Key.ToString(dtFilter.GroupFormats[DateTimeGroupOption.Yearly]),
                High = x.Max(y=>y.High), Low = x.Min(y=>y.Low), Open = x.First().Open, Close = x.Last().Close,
                Min = x.Key,
                Max = new DateTime(x.Key.Year, 12, 31),
            });
        }
        private IEnumerable<CustomGroupItem> GetGroupByQuarter(FlexChartDateTimeFilter dtFilter)
        {
            var quartersData = finanicalData.Select(x =>
            {
                DateTime dt = x.Date;
                var data = new
                {
                    GroupKey = dt.GetFirstDateOfQuarter(),
                    High = x.High,
                    Low = x.Low,
                    Open = x.Open,
                    Close = x.Close,
                };
                return data;
            });
            return quartersData.GroupBy(x => x.GroupKey).Select(x =>
            {
                return new CustomGroupItem
                {
                    XValue = dtFilter.GetFormattedString(x.Key, dtFilter.GroupFormats[DateTimeGroupOption.Quarterly], x.Key.GetQuarterNumber()),
                    High = x.Max(y => y.High),
                    Low = x.Min(y => y.Low),
                    Open = x.First().Open,
                    Close = x.Last().Close,
                    Min = x.Key,
                    Max = x.Key.GetLastDateOfQuarter(),
                };
            });
        }
        private IEnumerable<CustomGroupItem> GetGroupByMonth(FlexChartDateTimeFilter dtFilter)
        {
            var monthsData = finanicalData.Select(x =>
            {
                DateTime dt = x.Date;
                var data = new
                {
                    GroupKey = new DateTime(dt.Year, dt.Month, 1),
                    High = x.High,
                    Low = x.Low,
                    Open = x.Open,
                    Close = x.Close,
                };
                return data;
            });
            return monthsData.GroupBy(x => x.GroupKey).Select(x => new CustomGroupItem
            {
                XValue = x.Key.ToString(dtFilter.GroupFormats[DateTimeGroupOption.Monthly]),
                High = x.Max(y => y.High),
                Low = x.Min(y => y.Low),
                Open = x.First().Open,
                Close = x.Last().Close,
                Min = x.Key,
                Max = new DateTime(x.Key.Year, x.Key.Month, DateTime.DaysInMonth(x.Key.Year, x.Key.Month)),
            });
        }
        private IEnumerable<CustomGroupItem> GetGroupByWeek(FlexChartDateTimeFilter dtFilter)
        {
            var weeksData = finanicalData.Select(x =>
            {
                DateTime dt = x.Date;
                var data = new
                {
                    GroupKey = dt.GetFirstDateOfWeek(),
                    High = x.High,
                    Low = x.Low,
                    Open = x.Open,
                    Close = x.Close,
                };
                return data;
            });
            return weeksData.GroupBy(x => x.GroupKey).Select(x => new CustomGroupItem
            {
                XValue = dtFilter.GetFormattedString(x.Key, dtFilter.GroupFormats[DateTimeGroupOption.Weekly], x.Key.GetWeekOfMonth()),
                High = x.Max(y => y.High),
                Low = x.Min(y => y.Low),
                Open = x.First().Open,
                Close = x.Last().Close,
                Min = x.Key,
                Max = x.Key.GetLastDateOfWeek(),
            });
        }
    }
    public class CustomGroupItem : GroupItem
    {
        public double High { get; set; }
        public double Low { get; set; }
        public double Open { get; set; }
        public double Close { get; set; }
    }
}
