using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DashboardModel;
using C1.Win.Chart;
using C1.Win.Chart.Interaction;

namespace DashboardWinForms
{
    public partial class ValRangeSelector : UserControl
    {
        List<SaleItem> _items;
        RangeSelector _rangeSelector;

        public ValRangeSelector()
        {
            InitializeComponent();
        }

        public event DateRangeChangedEvent DateRangeChanged;

        void RasisedDateRangeChangedEvent(DateRange dateRange)
        {
            DateRangeChanged?.Invoke(this, new DateRangeChangedEventArgs(dateRange));
        }

        private void RangeSelector_Load(object sender, EventArgs e)
        {
            _items = DataService.GetService().DateSaleList;
            flexChart1.DataSource = _items;
            flexChart1.Series.Clear();
            var series = new Series();
            series.Binding = "Sales";
            flexChart1.BindingX = "Month";
            flexChart1.Series.Add(series);
            flexChart1.AxisY.Labels = false;
            flexChart1.AxisY.MajorGrid = false;
            flexChart1.ChartType = C1.Chart.ChartType.Line;
            _rangeSelector = new RangeSelector(flexChart1);
            _rangeSelector.Maximum = _items.Count - 1;
            _rangeSelector.UpperValue = _rangeSelector.Maximum;
            _rangeSelector.ValueChanged += _rangeSelector_ValueChanged;

            _rangeSelector_ValueChanged(null, EventArgs.Empty);
        }

        private void _rangeSelector_ValueChanged(object sender, EventArgs e)
        {
            DateRange dateRange = new DateRange();
            dateRange.Start = _items[(int)_rangeSelector.LowerValue].Date;
            dateRange.End = _items[(int)_rangeSelector.UpperValue].Date;
            RasisedDateRangeChangedEvent(dateRange);
        }
    }
}
