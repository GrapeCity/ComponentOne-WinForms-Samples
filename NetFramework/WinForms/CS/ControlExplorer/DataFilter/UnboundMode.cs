using C1.DataCollection;
using C1.DataCollection.BindingList;
using C1.DataFilter;
using C1.Win.DataFilter;
using ControlExplorer.DataFilter.UI;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ControlExplorer.DataFilter
{
    public partial class UnboundMode : C1DemoForm
    {
        private readonly DropDownFilter _dropDownFilter;
        private C1BindingListDataCollection _dataSource;
        private DataTable _carsTable;
        private BindingSource _carsBindingSource;

        public UnboundMode()
        {
            InitializeComponent();

            _dropDownFilter = new DropDownFilter();
            _dropDownFilter.Closed += DropDownFilter_Closed;
        }

        private void DropDownFilter_Closed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            _dropDownFilter.ApplyFilter(_dataSource);
        }

        private void c1FlexGrid1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var columnIndex = c1FlexGrid1.MouseCol;
                if (columnIndex >= 0 && columnIndex < c1FlexGrid1.Cols.Count)
                {
                    _dropDownFilter.ShowFilter(c1FlexGrid1.Cols[columnIndex].Name, c1FlexGrid1, e.Location);
                }
            }
        }

        private void UnboundMode_Load(object sender, EventArgs e)
        {
            _carsTable = DemoDataSource("SELECT * FROM Cars", true);
            _carsBindingSource = new BindingSource()
            {
                DataSource = _carsTable
            };
            _dataSource = new C1BindingListDataCollection(_carsBindingSource);

            c1FlexGrid1.DataSource = _carsBindingSource;

            InitFilters();
        }

        private void InitFilters()
        {
            // model
            var modelFilter = new ChecklistFilter
            {
                Expanded = false,
                ItemsSource = _carsTable.AsEnumerable().Select(x => x.Field<string>("Model")),
                ShowHeader = false,
                ShowSearchBox = true,
                ShowSelectAll = true,
                PropertyName = "Model"
            };
            _dropDownFilter.AddFilter(modelFilter);

            // brand
            var brandFilter = new ChecklistFilter
            {
                Expanded = false,
                ItemsSource = _carsTable.AsEnumerable().Select(x => x.Field<string>("Brand")),
                ShowHeader = false,
                ShowSearchBox = true,
                ShowSelectAll = true,
                PropertyName = "Brand"
            };
            _dropDownFilter.AddFilter(brandFilter);

            // liter
            var literFilter = new RangeFilter
            {
                Expanded = false,
                Digits = 3,
                ShowHeader = false,
                Maximum = _carsTable.AsEnumerable().Max(x => x.Field<double>("Liter")),
                Minimum = _carsTable.AsEnumerable().Min(x => x.Field<double>("Liter")),
                PropertyName = "Liter"
            };
            _dropDownFilter.AddFilter(literFilter);

            // category
            var categoryFilter = new ChecklistFilter
            {
                Expanded = false,
                ItemsSource = _carsTable.AsEnumerable().Select(x => x.Field<string>("Category")),
                ShowHeader = false,
                ShowSearchBox = true,
                ShowSelectAll = true,
                PropertyName = "Category"
            };
            _dropDownFilter.AddFilter(categoryFilter);

            // price
            var priceFilter = new RangeFilter
            {
                Expanded = false,
                Digits = 0,
                ShowHeader = false,
                Maximum = _carsTable.AsEnumerable().Max(x => x.Field<double>("Price")),
                Minimum = _carsTable.AsEnumerable().Min(x => x.Field<double>("Price")),
                PropertyName = "Price"
            };
            _dropDownFilter.AddFilter(priceFilter);
        }
        protected override void OnThemeApplied() => _dropDownFilter.ApplyTheme(Explorer.Theme);
    }

    public class DropDownFilter : ToolStripDropDown
    {
        public DropDownFilter()
        {
            AutoClose = true;
            AutoSize = true;
            Margin = Padding.Empty;
            Padding = Padding.Empty;

            DataFilter = new C1DataFilter
            {
                AutoWidthMode = AutoWidthMode.Grow,
                ShowClearFilterButtons = true,
                ShowHeader = false
            };

            var host = new ToolStripControlHost(DataFilter)
            {
                Margin = Padding.Empty,
                Padding = Padding.Empty,
                AutoSize = true,
                AutoToolTip = false
            };

            Items.Clear();
            Items.Add(host);
        }

        public void ShowFilter(string propertyName, Control control, Point location)
        {
            var isFound = false;
            foreach (var filter in DataFilter.Filters)
            {
                if (filter.PropertyName == propertyName)
                {
                    filter.Expanded = true;
                    isFound = true;
                }
                else
                    filter.Expanded = false;
            }
            if (isFound)
            {
                DataFilter.Height = GetPreferredSize(Size.Empty).Height;
                Show(control, location);
            }
        }

        public void AddFilter(Filter filter) => DataFilter.Filters.Add(filter);

        public void ApplyFilter(ISupportFiltering dataSource) => dataSource.FilterAsync(DataFilter.GetFilterExpression());

        public C1DataFilter DataFilter { get; }

        internal void ApplyTheme(C1.Win.Themes.C1Theme theme) => Explorer.ApplyTheme(DataFilter);
    }
}
