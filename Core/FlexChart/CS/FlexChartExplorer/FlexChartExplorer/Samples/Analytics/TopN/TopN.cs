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
    public partial class TopN : FlexChartBaseSample
    {
        private TopNFilter _filter = new TopNFilter();
        private object _data;

        private ComboBoxEx _cbTopN;
        private CheckBoxEx _chbShowOthers;
        private FlexChart flexChart1;

        public TopN()
        {
            InitializeComponent();
            InitializeFilter();
        }
        private void InitializeFilter()
        {
            _filter.Source = _data;
            _filter.Bindings = new string[] { "Shipments" };
            _filter.BindingX = "Name";
            _filter.AggregateType = AggregateFunction.Sum;
            _filter.SortType = SortType.Descending;
            _filter.SortOrder = true;

            _filter.PropertyChanged += (s, e) => 
            {
                if(e.PropertyName == "DataSource")
                    this.flexChart1.DataSource = _filter.DataSource;
            };
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Top 10 Smartphone Vendors";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            this.flexChart1.DataSource= _data = DataService.SmartPhoneVendors();
            this.flexChart1.BindingX = "Name";
            this.flexChart1.Binding = "Shipments";
            var series = new Series() { Name = "Shipments" };
            this.flexChart1.Series.Add(series);            
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            //Init TopN ComboBox 
            var comboBoxItems = new Queue<ComboBoxItem>();
            comboBoxItems.Enqueue(new ComboBoxItem{ Name = "Show All"});
            for (int i = 1; i < 10; i++)
                comboBoxItems.Enqueue(new ComboBoxItem{ Name = "Top-" + i, Value = i });

            _cbTopN = new ComboBoxEx() { ItemsDataSource = comboBoxItems.ToArray(), ItemsDisplayMember = "Name", ItemsValueMember = "Value" };
            _cbTopN.SelectedIndex = 0;
            _cbTopN.SelectedIndexChanged += (s, e) =>
            {
                if (_cbTopN.SelectedIndex == 0)
                {
                    flexChart1.Header.Content = "2017 : Top 10 Smartphone Vendors";
                    _filter.TopNEnabled = false;
                    _chbShowOthers.Visible = false;
                }

                else
                {
                    _filter.TopNEnabled = true;
                    _chbShowOthers.Visible = true;
                    _filter.TopNCount = Convert.ToInt32(_cbTopN.SelectedValue);
                    flexChart1.Header.Content = string.Format("2017 : Top {0} Smartphone Vendor",_filter.TopNCount);
                    flexChart1.Header.Content += _filter.TopNCount > 1 ? "s" : "";
                }
            };

            //Init ShowOthers CheckBox
            _chbShowOthers = new CheckBoxEx("Show Others") { Visible = false };
            _chbShowOthers.CheckedChanged += (s, e) => 
            {
                _filter.ShowOther = _chbShowOthers.Checked;
            };

            this.pnlControls.Controls.Add(_cbTopN);
            this.pnlControls.Controls.Add(_chbShowOthers);
        }
    }
}
