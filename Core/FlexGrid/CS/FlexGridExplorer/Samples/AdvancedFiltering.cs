using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.FlexGrid;
using FlexGridExplorer.Data;

namespace FlexGridExplorer.Samples
{
    public partial class AdvancedFiltering : UserControl
    {
        public AdvancedFiltering()
        {
            InitializeComponent();

            InitData();

            c1FlexGrid1.AllowFiltering = true;
            c1FlexGrid1.Cols["InheritedFilter"].Filter = new AdvancedFilters.InheritedFilterNewMenu();
            c1FlexGrid1.Cols["InheritedNoValue"].Filter = new AdvancedFilters.InheritedFilterNewMenu() { ValueFilterEnabled = false };
            c1FlexGrid1.Cols["InheritedNoCondition"].Filter = new AdvancedFilters.InheritedFilterNewMenu() { ConditionFilterEnabled = false };
            c1FlexGrid1.Cols["InheritedClassicMenu"].Filter = new AdvancedFilters.InheritedFilter();
            c1FlexGrid1.Cols["ComposedClassicMenu"].Filter = new AdvancedFilters.ComposedFilter();
            c1FlexGrid1.Cols["ComposedFilter"].Filter = new AdvancedFilters.ComposedFilterNewMenu();
            c1FlexGrid1.Cols["ValueFilter"].Filter = new ValueFilter();
            c1FlexGrid1.Cols["ConditionFilter"].Filter = new ConditionFilter();
        }

        private void InitData()
        {
            var dataTable = DataSource.GetRows("Select * from Orders");
            var newColumn = dataTable.Columns.Add("ValueFilter", typeof(DateTime));
            newColumn.SetOrdinal(1);
            newColumn = dataTable.Columns.Add("ConditionFilter", typeof(DateTime));
            newColumn.SetOrdinal(1);
            newColumn = dataTable.Columns.Add("ComposedClassicMenu", typeof(DateTime));
            newColumn.SetOrdinal(1);
            newColumn = dataTable.Columns.Add("InheritedClassicMenu", typeof(DateTime));
            newColumn.SetOrdinal(1);
            newColumn = dataTable.Columns.Add("InheritedNoValue", typeof(DateTime));
            newColumn.SetOrdinal(1);
            newColumn = dataTable.Columns.Add("InheritedNoCondition", typeof(DateTime));
            newColumn.SetOrdinal(1);
            newColumn = dataTable.Columns.Add("ComposedFilter", typeof(DateTime));
            newColumn.SetOrdinal(1);
            newColumn = dataTable.Columns.Add("InheritedFilter", typeof(DateTime));
            newColumn.SetOrdinal(1);
            foreach (DataRow row in dataTable.Rows)
            {
                row["InheritedFilter"] = row["OrderDate"];
                row["InheritedNoValue"] = row["OrderDate"];
                row["InheritedNoCondition"] = row["OrderDate"];
                row["InheritedClassicMenu"] = row["OrderDate"];
                row["ComposedClassicMenu"] = row["OrderDate"];
                row["ComposedFilter"] = row["OrderDate"];
                row["ConditionFilter"] = row["ConditionFilter"];
                row["ValueFilter"] = row["ValueFilter"];
            }
            c1FlexGrid1.DataSource = dataTable;
        }

        private void btnSaveFiltersToXml_Click(object sender, EventArgs e)
        {
            textBox1.Text = c1FlexGrid1.FilterDefinition.Replace(">", ">\r\n");
        }

        private void btnCreateFilters_Click(object sender, EventArgs e)
        {
            c1FlexGrid1.ClearFilter();
            ((AdvancedFilters.InheritedFilterNewMenu)c1FlexGrid1.Cols["InheritedFilter"].Filter).WeekdayFilter.Monday = false;
            var filter = (ColumnFilter)c1FlexGrid1.Cols["InheritedNoValue"].Filter;
            filter.ConditionFilter.Condition1.Operator = ConditionOperator.LessThan;
            filter.ConditionFilter.Condition1.Parameter = c1FlexGrid1[9, "InheritedNoValue"];
            c1FlexGrid1.ApplyFilters();
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            c1FlexGrid1.ClearFilter();
        }

        private void btnLoadFiltersFromXml_Click(object sender, EventArgs e)
        {
            c1FlexGrid1.FilterDefinition = textBox1.Text;
        }

    }
}
