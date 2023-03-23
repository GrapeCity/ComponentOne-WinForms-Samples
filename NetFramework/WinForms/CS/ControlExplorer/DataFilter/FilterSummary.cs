using System;
using System.Data;
using System.Windows.Forms;
using System.Linq;

namespace ControlExplorer.DataFilter
{
    public partial class FilterSummary : C1DemoForm
    {
        private DataTable _carsTable;
        public FilterSummary()
        {
            InitializeComponent();
            c1DataFilter1.AutoApply = true;
        }

        private void FilterSummary_Load(object sender, EventArgs e)
        {
            _carsTable = DemoDataSource("SELECT * FROM Cars", true);
            _carsTable.TableName = "Cars";

            var ds = new DataSet();
            ds.Tables.Add(_carsTable);

            var bs = new BindingSource(ds, "Cars");
            c1FlexGrid1.DataSource = bs;
            c1DataFilter1.DataSource = bs;

            bs = new BindingSource(ds, "Cars");
            var cf = c1DataFilter1.Filters[0] as C1.Win.DataFilter.ChecklistFilter;
            cf.ItemsSource = bs;
            cf.SelectAll();

            bs = new BindingSource(ds, "Cars");
            cf = c1DataFilter1.Filters[1] as C1.Win.DataFilter.ChecklistFilter;
            cf.ItemsSource = bs;
            cf.SelectAll();
        }
    }
}
