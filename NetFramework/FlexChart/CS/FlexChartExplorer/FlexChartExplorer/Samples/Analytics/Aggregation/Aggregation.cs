using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlexChartExplorer.Data;
using C1.Win.Chart;
using BaseExplorer;

namespace FlexChartExplorer.Samples
{
    public partial class Aggregation : FlexChartBaseSample
    {
        private AggregateFilter _filter = new AggregateFilter();
        private object _data;

        private ComboBoxEx _cbAggregateType, _cbAggregateFun;
        private FlexChart flexChart1;

        public Aggregation()
        {
            InitializeComponent();
            InitializeFilter();
        }
        private void InitializeFilter()
        {
            _filter.AggregateType = AggregateFunction.Sum;
            _filter.Source = _data;
            _filter.PropertyChanged += (s, e) =>
            {
                if (e.PropertyName == "DataSource")
                    this.flexChart1.DataSource = _filter.DataSource;
            };
            _filter.Analyse();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Sales Data";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            this.flexChart1.DataSource = _data = HierarchicalDataSource.GetHierarchicalDataItems();
            this.flexChart1.BindingX = "Key";
            this.flexChart1.Binding = "Value";
            this.flexChart1.Series.Add(new Series { Name="Sales"});
            this.flexChart1.AxisX.AxisLine = false;
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            //Init AggregateType comboBox
            List<ComboBoxItem> cbItems = new List<ComboBoxItem>
            {
                new ComboBoxItem{Name="Non-Aggregated", Value="None"},
                new ComboBoxItem{Name="Aggregated By Quarter", Value="Quarter"},
                new ComboBoxItem{Name="Aggregated By Year", Value="Year"}
            };
            _cbAggregateType = new ComboBoxEx { DataSource = cbItems, DisplayMember="Name", ValueMember="Value", Width=160};
            _cbAggregateType.SelectedIndexChanged += _cbAggregateType_SelectedIndexChanged;
            
            //Init AggregateFunction ComboBox
            _cbAggregateFun = ControlFactory.EnumBasedCombo(typeof(AggregateFunction), "Aggregate Function");
            _cbAggregateFun.Width = 160;
            _cbAggregateFun.SelectedIndexChanged += (s, e) =>
            {
                _filter.AggregateType = (AggregateFunction)Enum.Parse(typeof(AggregateFunction), _cbAggregateFun.SelectedValue.ToString());
            };

            this.pnlControls.Controls.Add(_cbAggregateType);
            this.pnlControls.Controls.Add(_cbAggregateFun);
        }

        private void _cbAggregateType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var key = _cbAggregateType.SelectedValue.ToString();
            switch (key)
            {
                case "Year":
                    _filter.Bindings = new string[] { "Year" };
                    break;
                case "Quarter":
                    _filter.Bindings = new string[] { "Year", "Quarter" };
                    break;
                default:
                    _filter.Bindings = null;
                    break;
            }
        }
    }
}
