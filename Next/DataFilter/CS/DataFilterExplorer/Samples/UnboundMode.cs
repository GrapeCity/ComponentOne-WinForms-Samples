using C1.DataCollection.BindingList;
using C1.Win.DataFilter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataFilterExplorer.Samples
{
    public partial class UnboundMode : UserControl
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
            _carsTable = DataSource.GetRows("Select * from cars", "cars");
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
                Maximum = _carsTable.AsEnumerable().Max(x => x.Field<long>("Price")),
                Minimum = _carsTable.AsEnumerable().Min(x => x.Field<long>("Price")),
                PropertyName = "Price"
            };
            _dropDownFilter.AddFilter(priceFilter);
        }

    }
}
