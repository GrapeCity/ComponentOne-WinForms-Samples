using DataFilterExplorer.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DataFilterExplorer.Samples
{
    public partial class Overview : UserControl
    {
        private DataTable _carsTable;

        public Overview()
        {
            InitializeComponent();
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            _carsTable = DataSource.GetRows("Select * from cars", "cars");
            c1FlexGrid1.DataSource = _carsTable;
            c1DataFilter1.DataSource = _carsTable;
            c1DataFilter1.ApplyFilter();
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
                case "TransmissAutomatic":
                    var taFilter = (C1.Win.DataFilter.ChecklistFilter)e.Filter;
                    taFilter.ItemsSource = new List<TransmissAutomatic>()
                    {
                        new TransmissAutomatic() { DisplayValue = "Yes", Value = "Yes" },
                        new TransmissAutomatic() { DisplayValue = "No", Value = "No" },
                        new TransmissAutomatic() { DisplayValue = "No information", Value = DBNull.Value }
                    };
                    taFilter.DisplayMemberPath = "DisplayValue";
                    taFilter.ValueMemberPath = "Value";
                    taFilter.ShowSelectAll = false;
                    taFilter.LayoutType = C1.DataFilter.LayoutType.List;
                    taFilter.SelectAll();
                    break;
                case "Price":
                    var priceFilter = (C1.Win.DataFilter.RangeFilter)e.Filter;
                    priceFilter.Maximum = _carsTable.AsEnumerable().Max(x => x.Field<long>("Price"));
                    priceFilter.Minimum = _carsTable.AsEnumerable().Min(x => x.Field<long>("Price"));
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
