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
using FlexGridExplorer.Samples.AdvancedFilters;

namespace FlexGridExplorer.Samples
{
    public partial class AdvancedFiltering : UserControl
    {
        public AdvancedFiltering()
        {
            InitializeComponent();

            InitData();

            c1FlexGrid1.AllowFiltering = true;
            foreach (Column col in c1FlexGrid1.Cols)
            {
                switch (col.Name)
                {
                    case "InheritedFilter":
                        col.Filter = new InheritedFilter();
                        break;
                    case "InheritedNoValue":
                        col.Filter = new InheritedFilter() { ValueFilterEnabled = false };
                        break;
                    case "InheritedNoCondition":
                        col.Filter = new InheritedFilter() { ConditionFilterEnabled = false };
                        break;
                    case "InheritedClassicMenu":
                        col.Filter = new InheritedFilter();
                        break;
                    case "ComposedClassicMenu":
                        col.Filter = new ComposedFilter();
                        break;
                    case "ComposedFilter":
                        col.Filter = new ComposedFilter();
                        break;
                    case "ValueFilter":
                        col.Filter = new CustomValueFilter();
                        break;
                    case "ConditionFilter":
                        col.Filter = new CustomConditionFilter();
                        break;
                    default:
                        col.Filter = new CustomColumnFilter();
                        break;
                }
            }
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
                row["ConditionFilter"] = row["OrderDate"];
                row["ValueFilter"] = row["OrderDate"];
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
