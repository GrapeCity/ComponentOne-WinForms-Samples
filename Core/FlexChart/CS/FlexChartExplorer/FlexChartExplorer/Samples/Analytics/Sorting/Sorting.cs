using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.Chart;
using FlexChartExplorer.Data;
using BaseExplorer;

namespace FlexChartExplorer.Samples
{
    public partial class Sorting : FlexChartBaseSample
    {
        private SortingFilter _filter = new SortingFilter();
        private object _data;
        private ComboBoxEx _cbSortBy;
        private FlexChart flexChart1;

        public Sorting()
        {
            InitializeComponent();
            InitializeFilter();
        }
        private void InitializeFilter()
        {
            _filter.Bindings = new string[] { "EstimatedValue" };
            _filter.AggregateType = AggregateFunction.Sum;
            _filter.Source = _data;
            _filter.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == "DataSource")
                    this.flexChart1.DataSource = _filter.DataSource;
            };
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Actual vs Estimated Sales By Product";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            this.flexChart1.DataSource = _data = SalesDataSource.GetSalesForecastData();
            this.flexChart1.BindingX = "Name";
            this.flexChart1.Series.Add(new Series { Name = "Estimate", Binding = "EstimatedValue" });
            this.flexChart1.Series.Add(new Series { Name = "Actual", Binding = "ActualValue" });
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;

            var cbItems = new List<ComboBoxItem>();
            cbItems.Add(new ComboBoxItem { Name = "None", Value = "none" });
            cbItems.Add(new ComboBoxItem { Name = "Ascending By Estimated Value", Value = "abe" });
            cbItems.Add(new ComboBoxItem { Name = "Descending By Estimated Value", Value = "dbe" });
            cbItems.Add(new ComboBoxItem { Name = "Ascending By Actual Value", Value = "aba" });
            cbItems.Add(new ComboBoxItem { Name = "Descending By Actual Value", Value = "dba" });
            cbItems.Add(new ComboBoxItem { Name = "Ascending By Difference", Value = "abd" });
            cbItems.Add(new ComboBoxItem { Name = "Descending By Difference", Value = "dbd" });

            _cbSortBy = new ComboBoxEx() { ItemsDisplayMember = "Name", ItemsValueMember= "Value", Width = 200, ItemsDataSource= cbItems };

            _cbSortBy.SelectedIndex = 0;
            _cbSortBy.SelectedIndexChanged += _cbSortBy_SelectedIndexChanged;

            this.pnlControls.Controls.Add(_cbSortBy);
        }

        private void _cbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = _cbSortBy.SelectedValue.ToString();
            switch (key)
            {
                case "dba":
                    _filter.Bindings = new string[] { "ActualValue" };
                    _filter.AggregateType = AggregateFunction.Sum;
                    _filter.CustomSortFun = null;
                    _filter.SortType = SortType.Descending;
                    break;
                case "aba":
                    _filter.Bindings = new string[] { "ActualValue" };
                    _filter.AggregateType = AggregateFunction.Sum;
                    _filter.CustomSortFun = null;
                    _filter.SortType = SortType.Ascending;
                    break;
                case "dbe":
                    _filter.Bindings = new string[] { "EstimatedValue" };
                    _filter.AggregateType = AggregateFunction.Sum;
                    _filter.CustomSortFun = null;
                    _filter.SortType = SortType.Descending;
                    break;
                case "abe":
                    _filter.Bindings = new string[] { "EstimatedValue" };
                    _filter.AggregateType = AggregateFunction.Sum;
                    _filter.CustomSortFun = null;
                    _filter.SortType = SortType.Ascending;
                    break;
                case "dbd":
                    _filter.Bindings = new string[] { "EstimatedValue", "ActualValue" };
                    _filter.CustomSortFun = k => k.First() - k.Last();
                    _filter.SortType = SortType.Descending;
                    break;
                case "abd":
                    _filter.Bindings = new string[] { "EstimatedValue", "ActualValue" };
                    _filter.CustomSortFun = k => k.First() - k.Last();
                    _filter.SortType = SortType.Ascending;
                    break;
                case "none":
                default:
                    _filter.Bindings = new string[] { "EstimatedValue" };
                    _filter.CustomSortFun = null;
                    _filter.SortType = SortType.None;
                    break;
            }
        }
    }
}
