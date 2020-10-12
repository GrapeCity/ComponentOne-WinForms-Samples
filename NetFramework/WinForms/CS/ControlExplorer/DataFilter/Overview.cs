using System;
using System.Data;
using System.Linq;

namespace ControlExplorer.DataFilter
{
    public partial class Overview : C1DemoForm
    {
        private DataTable _carsTable;

        public Overview()
        {
            InitializeComponent();
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            _carsTable = DemoDataSource("SELECT * FROM Cars;", true);
            c1FlexGrid1.DataSource = _carsTable;
            c1DataFilter1.DataSource = _carsTable;
        }

        private void c1DataFilter1_FilterAutoGenerating(object sender, C1.DataFilter.FilterAutoGeneratingEventArgs e)
        {
            switch (e.Property.Name)
            {
                case "Model":
                    var modelFilter = (C1.Win.DataFilter.ChecklistFilter)e.Filter;
                    modelFilter.ShowSearchBox = true;
                    modelFilter.SelectAll();
                    break;
                case "Brand":
                    var brandFilter = (C1.Win.DataFilter.ChecklistFilter)e.Filter;
                    brandFilter.SelectAll();
                    break;
                case "Liter":
                    var literFilter = (C1.Win.DataFilter.RangeFilter)e.Filter;
                    literFilter.Maximum = _carsTable.AsEnumerable().Max(x => x.Field<double>("Liter"));
                    literFilter.Minimum = _carsTable.AsEnumerable().Min(x => x.Field<double>("Liter"));
                    literFilter.Increment = 0.01;
                    break;
                case "TransmissSpeedCount":
                    var tskFilter = new C1.Win.DataFilter.ChecklistFilter("TransmissSpeedCount");
                    tskFilter.HeaderText = "Transmiss speed count";
                    tskFilter.ShowSelectAll = false;
                    tskFilter.SelectAll();
                    e.Filter = tskFilter;
                    break;
                case "Category":
                    var categoryFilter = (C1.Win.DataFilter.ChecklistFilter)e.Filter;
                    categoryFilter.ShowSelectAll = false;
                    categoryFilter.SelectAll();
                    break;
                case "Price":
                    var priceFilter = (C1.Win.DataFilter.RangeFilter)e.Filter;
                    priceFilter.Maximum = _carsTable.AsEnumerable().Max(x => x.Field<double>("Price"));
                    priceFilter.Minimum = _carsTable.AsEnumerable().Min(x => x.Field<double>("Price"));
                    priceFilter.Increment = 1000;
                    priceFilter.Digits = 0;
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }
    }
}
