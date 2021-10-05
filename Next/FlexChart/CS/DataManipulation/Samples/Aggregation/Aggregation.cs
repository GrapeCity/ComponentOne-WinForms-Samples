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
using System.Drawing.Drawing2D;
using C1.Chart;
using C1.Chart.Annotation;
using C1.Win.Chart.Annotation;
using C1.Win.Chart.Interaction;

namespace DataManipulation
{
    public partial class Aggregation : UserControl
    {
        AggregateFilter _filter = new AggregateFilter();
        public Aggregation()
        {
            InitializeComponent();
            InitializeControls();

            InitializeFilter();
            InitializeChart();
        }
        void InitializeFilter()
        {
            var dataSource = AggregationDataCreator.CreateScore();
            
            _filter.AggregateType = AggregateFunction.Sum;
            _filter.Source = dataSource;

            _filter.PropertyChanged += (o, e) =>
            {
                if (e.PropertyName == "DataSource")
                {
                    flexChart1.DataSource = _filter.DataSource;
                }
            };
        }

        void InitializeChart()
        {
            flexChart1.BeginUpdate();
            flexChart1.Header.Content = "Sales data";
            flexChart1.Header.Style.Font = new Font(FontFamily.GenericSansSerif, 15);
            this.flexChart1.Stacking = C1.Chart.Stacking.None;
            flexChart1.BindingX = "Key";
            flexChart1.Binding = "Value";
            flexChart1.LegendToggle = true;
            this.flexChart1.Series.Clear();
            this.flexChart1.Series.Add(new C1.Win.Chart.Series() { Name = "Sales", Binding = "Value" });
            flexChart1.DataSource = _filter.DataSource;
            flexChart1.EndUpdate();

        }

        private ComboBox cmbAggregateProperty;
        private ComboBox cmbAggregateType;
        private void InitializeControls()
        {
            //Set localized content
            baseSample1.lblTitle.Text = Localizer.GetItem("aggregation", "title");
            baseSample1.tbDescription.Rtf = Localizer.GetItem("aggregation", "description").MakeRtf();
            flexChart1 = baseSample1.flexChart1;


            cmbAggregateProperty = new ComboBox();
            // 
            // cmbAggregateType
            // 
            this.cmbAggregateProperty.FormattingEnabled = true;
            this.cmbAggregateProperty.Name = "cmbAggregateProperty";
            this.cmbAggregateProperty.Size = new System.Drawing.Size(160, 21);
            baseSample1.pControls.Controls.Add(cmbAggregateProperty);


            cmbAggregateType = new ComboBox();
            // 
            // cmbAggregateType
            // 
            this.cmbAggregateType.FormattingEnabled = true;
            this.cmbAggregateType.Name = "cmbAggregateType";
            this.cmbAggregateType.Size = new System.Drawing.Size(160, 21);
            baseSample1.pControls.Controls.Add(cmbAggregateType);


            cmbAggregateProperty.DisplayMember = "Name";
            cmbAggregateProperty.Items.Add(new ComboBoxItem("Non-Aggregated", null));
            cmbAggregateProperty.Items.Add(new ComboBoxItem("Aggregated By Quarter", "Quarter"));
            cmbAggregateProperty.Items.Add(new ComboBoxItem("Aggregated By Year", "Year"));

            cmbAggregateProperty.SelectedIndex = 0;
            this.cmbAggregateProperty.SelectedIndexChanged += (o, e) =>
            {
                string key = null;
                var cbItem = cmbAggregateProperty.SelectedItem as ComboBoxItem;
                if (cbItem != null)
                {
                    if (cbItem.Value != null)
                    {
                        key = cbItem.Value.ToString();
                    }
                }
                if (string.IsNullOrEmpty(key))
                {
                    _filter.Bindings = null;
                }

                switch (key)
                {
                    case "Year":
                        _filter.Bindings = new string[] { "Year" };
                        break;
                    case "Quarter":
                        _filter.Bindings = new string[] { "Year", "Q" };
                        break;
                    default:
                        _filter.Bindings = null;
                        break;
                }

                _filter.AggregateType = (AggregateFunction)(cmbAggregateType.SelectedItem as ComboBoxItem).Value;
            };


            cmbAggregateType.DisplayMember = "Name";
            foreach (var item in Enum.GetValues(typeof(AggregateFunction)))
            {
                cmbAggregateType.Items.Add(new ComboBoxItem("Aggregate Function : " + ((AggregateFunction)item).ToString(), item));
            }
            cmbAggregateType.SelectedIndex = 0;
            this.cmbAggregateType.SelectedIndexChanged += (o, e) =>
            {
                _filter.AggregateType = (AggregateFunction)(cmbAggregateType.SelectedItem as ComboBoxItem).Value;
            };
            

        }
    }

}
