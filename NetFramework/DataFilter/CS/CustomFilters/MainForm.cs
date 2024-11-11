using C1.DataFilter;
using C1.Win.Ribbon;
using C1.Win.DataFilter;
using CustomFilters.Model;
using CustomFilters.ViewModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace CustomFilters
{
    public partial class MainForm : C1RibbonForm
    {
        private DataProvider _dataProvider = new DataProvider();        

        public MainForm()
        {
            InitializeComponent();
            c1TreeView1.ShowToolTips = true;
            c1TreeView1.Columns[0].CustomContentPresenter = new CarPresenter();
            c1TreeView1.BindingInfo.DataMember = "\\Stores";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var data = _dataProvider.GetCarsInStores().ToList();

            UpdateTreeViewData(data);

            c1DataFilter1.DataSource = data;
            c1DataFilter1.Styles.FilterCaption.Font = new Font("Calibri", 14, FontStyle.Bold);
            c1DataFilter1.Styles.CheckBox.Font = new Font("Calibri", 12);

            InitFilters();
        }

        private void InitFilters()
        {
            // Map filter
            var mf = new MapFilter()
            {
                HeaderText = "Store",
                PropertyName = "Store.ID"
            };
            mf.SetStores(_dataProvider.GetStores());
            c1DataFilter1.Filters.Add(mf);

            // Model filter
            var mdf = new ModelFilter()
            {
                HeaderText = "Model",
                PropertyName = "Car.Model"
            };
            mdf.SetTagList(_dataProvider.GetCars().ToList());
            c1ThemeController1.SetTheme(mdf.MultiSelect, "(default)");
            c1DataFilter1.Filters.Add(mdf);

            // Price filter
            var pf = new PriceFilter()
            {
                HeaderText = "Price",
                PropertyName = "Car.Price",
                LayoutType = LayoutType.List,
                ShowSelectAll = false,
                ShowSearchBox = false
            };
            var intervals = new List<PriceInterval>
            {
                new PriceInterval { MaxPrice = 20000 },
                new PriceInterval { MinPrice = 20000, MaxPrice = 40000 },
                new PriceInterval { MinPrice = 40000, MaxPrice = 70000 },
                new PriceInterval { MinPrice = 70000, MaxPrice = 100000 },
                new PriceInterval { MinPrice = 100000 }
            };
            pf.SetPriceIntervals(intervals);
            c1DataFilter1.Filters.Add(pf);

            // Transmiss filter
            var tf = new ChecklistFilter
            {
                PropertyName = "Car.TransmissAutomatic",
                HeaderText = "Automatic transmission",
                ShowSelectAll = true,
                ShowSearchBox = false,
                SelectionMode = SelectionMode.Single,
                LayoutType = LayoutType.List
            };
            tf.Items.Add(new ChecklistItem() { DisplayValue = "Yes", Value = "Yes" });
            tf.Items.Add(new ChecklistItem() { DisplayValue = "No", Value = "no" });
            c1DataFilter1.Filters.Add(tf);

            // Color filter
            var cf = new ColorFilter
            {
                HeaderText = "Color",
                PropertyName = "Color"
            };
            cf.SetColors(_dataProvider.Colors.Select(x => Color.FromName(x)));
            c1DataFilter1.Filters.Add(cf);

        }

        private void UpdateTreeViewData(IEnumerable<CountInStore> data)
        {
            c1TreeView1.BindingInfo.DataSource = data.GroupBy(x => x.Car).Select(x => new CarView(x.Key, x.ToList())).ToList();
        }

        private void c1DataFilter1_FilterChanged(object sender, EventArgs e)
        {
            UpdateTreeViewData(c1DataFilter1.View.Cast<CountInStore>());
        }
    }
}
