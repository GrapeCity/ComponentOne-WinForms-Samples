using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DataManipulation
{
    public partial class Sorting : UserControl
    {
        SortingFilter _filter = new SortingFilter();
        public Sorting()
        {
            InitializeComponent();
            InitializeControls();

            InitializeFilter();
            InitializeChart();
        }
        void InitializeFilter()
        {
            var dataSource = SortDataCreator.CreateScore();

            _filter.Bindings = new string[] { "PredictiveValue" };
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
            flexChart1.Header.Content = "2016 Category sales contrast";
            flexChart1.Header.Style.Font = new Font(FontFamily.GenericSansSerif, 15);
            this.flexChart1.Stacking = C1.Chart.Stacking.None;
            flexChart1.BindingX = "Name";
            flexChart1.Binding = "Value";
            flexChart1.LegendToggle = true;
            this.flexChart1.Series.Clear();
            this.flexChart1.Series.Add(new C1.Win.Chart.Series() { Name = "PredictiveValue", Binding = "PredictiveValue" });
            this.flexChart1.Series.Add(new C1.Win.Chart.Series() { Name = "ActualValue", Binding = "ActualValue" });
            flexChart1.DataSource = _filter.DataSource;
            flexChart1.EndUpdate();
        }

        private ComboBox cmbSortBy;
        private void InitializeControls()
        {
            //Set localized content
            baseSample1.lblTitle.Text = Localizer.GetItem("sorting", "title");
            baseSample1.tbDescription.Rtf = Localizer.GetItem("sorting", "description").MakeRtf();
            flexChart1 = baseSample1.flexChart1;

            cmbSortBy = new ComboBox();
            // 
            // cmbSortType
            // 
            this.cmbSortBy.FormattingEnabled = true;
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Size = new System.Drawing.Size(200, 21);
            baseSample1.pControls.Controls.Add(cmbSortBy);
            
            cmbSortBy.DisplayMember = "Name";
            cmbSortBy.Items.Add(new ComboBoxItem("None", "none"));
            cmbSortBy.Items.Add(new ComboBoxItem("Descending by PredictiveValue", "dbp"));
            cmbSortBy.Items.Add(new ComboBoxItem("Ascending by PredictiveValue", "abp"));
            cmbSortBy.Items.Add(new ComboBoxItem("Descending by ActualValue", "dba"));
            cmbSortBy.Items.Add(new ComboBoxItem("Ascending by ActualValue", "aba"));
            cmbSortBy.Items.Add(new ComboBoxItem("Descending by Difference", "dbd"));
            cmbSortBy.Items.Add(new ComboBoxItem("Ascending by Difference", "abd"));

            cmbSortBy.SelectedIndex = 0;
            this.cmbSortBy.SelectedIndexChanged += (o, e) =>
            {
                string key = (cmbSortBy.SelectedItem as ComboBoxItem).Value.ToString();
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
                    case "dbp":
                        _filter.Bindings = new string[] { "PredictiveValue" };
                        _filter.AggregateType = AggregateFunction.Sum;
                        _filter.CustomSortFun = null;
                        _filter.SortType = SortType.Descending;
                        break;
                    case "abp":
                        _filter.Bindings = new string[] { "PredictiveValue" };
                        _filter.AggregateType = AggregateFunction.Sum;
                        _filter.CustomSortFun = null;
                        _filter.SortType = SortType.Ascending;
                        break;
                    case "dbd":
                        _filter.Bindings = new string[] { "PredictiveValue", "ActualValue" };
                        _filter.CustomSortFun = k => k.First() - k.Last();
                        _filter.SortType = SortType.Descending;
                        break;
                    case "abd":
                        _filter.Bindings = new string[] { "PredictiveValue", "ActualValue" };
                        _filter.CustomSortFun = k => k.First() - k.Last();
                        _filter.SortType = SortType.Ascending;
                        break;
                    case "none":
                    default:
                        _filter.Bindings = new string[] { "PredictiveValue" };
                        _filter.CustomSortFun = null;
                        _filter.SortType = SortType.None;
                        break;
                }
            };
        }
    }

}
