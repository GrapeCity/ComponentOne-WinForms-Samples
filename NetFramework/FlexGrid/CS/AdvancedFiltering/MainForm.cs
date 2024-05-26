using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using C1.Win.C1Themes;
using C1.Win.Ribbon;

namespace AdvancedFiltering
{
    public partial class MainForm : C1RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitThemes();

            InitData();

            c1FlexGrid1.AllowFiltering = true;
            c1FlexGrid1.Cols["InheritedFilter"].Filter = new InheritedFilterNewMenu();
            c1FlexGrid1.Cols["InheritedNoValue"].Filter = new InheritedFilterNewMenu() { ValueFilterEnabled = false };
            c1FlexGrid1.Cols["InheritedNoCondition"].Filter = new InheritedFilterNewMenu() { ConditionFilterEnabled = false };
            c1FlexGrid1.Cols["InheritedClassicMenu"].Filter = new InheritedFilter();
            c1FlexGrid1.Cols["ComposedClassicMenu"].Filter = new ComposedFilter();
            c1FlexGrid1.Cols["ComposedFilter"].Filter = new ComposedFilterNewMenu();
            c1FlexGrid1.Cols["ValueFilter"].Filter = new ValueFilter();
            c1FlexGrid1.Cols["ConditionFilter"].Filter = new ConditionFilter();
        }

        private void InitData()
        {
            var dataAdapter = new OleDbDataAdapter("select * from orders", GetConnectionString());
            var dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            var newColumn = dataTable.Columns.Add("ConditionFilter", typeof(DateTime));
            newColumn.SetOrdinal(1);
            newColumn = dataTable.Columns.Add("ValueFilter", typeof(DateTime));
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

        private string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }

        #region Themes

        private void InitThemes()
        {
            var themes = C1ThemeController.GetThemes().Where(x => x.Contains("Office365"));
            foreach (var theme in themes)
                cmbTheme.Items.Add(theme);
            cmbTheme.SelectedIndex = cmbTheme.Items.IndexOf("Office365Green");
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = cmbTheme.SelectedItem.Text;
        }

        #endregion

        private void rbSaveFiltersToXml_Click(object sender, EventArgs e)
        {
            c1TextBox1.Text = c1FlexGrid1.FilterDefinition.Replace(">", ">\r\n");
        }

        private void rbCreateFilters_Click(object sender, EventArgs e)
        {
            c1FlexGrid1.ClearFilter();
            ((InheritedFilterNewMenu)c1FlexGrid1.Cols["InheritedFilter"].Filter).WeekdayFilter.Monday = false;
            var filter = (ColumnFilter)c1FlexGrid1.Cols["InheritedNoValue"].Filter;
            filter.ConditionFilter.Condition1.Operator = ConditionOperator.LessThan;
            filter.ConditionFilter.Condition1.Parameter = c1FlexGrid1[9, "InheritedNoValue"];
            c1FlexGrid1.ApplyFilters();
        }

        private void rbClearFilters_Click(object sender, EventArgs e)
        {
            c1FlexGrid1.ClearFilter();
        }

        private void rbLoadFiltersFromXml_Click(object sender, EventArgs e)
        {
            c1FlexGrid1.FilterDefinition = c1TextBox1.Text;
        }
    }
}
