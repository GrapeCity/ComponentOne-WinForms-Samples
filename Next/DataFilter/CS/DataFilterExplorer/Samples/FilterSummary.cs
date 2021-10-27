using DataFilterExplorer.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace DataFilterExplorer.Samples
{
    public partial class FilterSummary : UserControl
    {
        public FilterSummary()
        {
            InitializeComponent();
        }

        private void FilterSummary_Load(object sender, EventArgs e)
        {
            var ds = new DataSet();
            ds.Tables.Add(DataSource.GetRows("Select * from cars", "cars"));
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
