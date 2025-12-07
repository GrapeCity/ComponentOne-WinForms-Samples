using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.FlexGrid;

namespace ColumnFilters
{
    public partial class Form1 : Form
    {
        public C1.C1Preview.C1PrintDocument MakeDoc(C1.Win.FlexGrid.C1FlexGridPrintInfo printInfo)
        {
            C1FlexGrid flex = _tab.SelectedTab.Controls[0] as C1FlexGrid;
            if (flex == null)
                return null;

            C1.Win.FlexGrid.C1FlexGridPrinter printer = new C1.Win.FlexGrid.C1FlexGridPrinter(flex);
            C1.C1Preview.C1PrintDocument doc = new C1.C1Preview.C1PrintDocument();
            printer.PrintInfo = printInfo;
            C1.C1Preview.RenderObject gridRO = printer.MakeGridTable(doc);
            // if flex grid borders are not printed, provide our own:
            if (!printInfo.PrintBorders)
                gridRO.Style.GridLines.All = new C1.C1Preview.LineDef("0.5pt", Color.LightGray);
            doc.Body.Children.Add(gridRO);
            doc.PageLayout.PageHeader = printer.MakePageHeader(doc);
            doc.PageLayout.PageFooter = printer.MakePageFooter(doc);
            return doc;
        }

        //----------------------------------------------------------------------
        #region ** ctor

        public Form1()
        {
            InitializeComponent();

            // get some data
            var da = new OleDbDataAdapter("select * from products", GetConnectionString());
            var dtProducts = new DataTable();
            da.Fill(dtProducts);
            dtProducts.Columns.Add("Date", typeof(DateTime)).DefaultValue = DateTime.Today;
            dtProducts.Columns.Add("Enum", typeof(ConditionOperator)).DefaultValue = ConditionOperator.BeginsWith;

            da = new OleDbDataAdapter("select * from [invoices]", GetConnectionString());
            var dtInvoices = new DataTable();
            da.Fill(dtInvoices);

            // configure default grid
            _flexDefault.DataSource = dtProducts;
            _flexDefault.Cols["UnitPrice"].Format = "#,###.00";
            _flexDefault.AllowFiltering = true;
            _flexDefault.AutoSizeCols(20);

            // configure custom filtering grid
            _flexCustom.DataSource = dtProducts;
            _flexCustom.Cols["UnitPrice"].Format = "#,###.00";
            _flexCustom.AllowFiltering = true;
            _flexCustom.Glyphs[GlyphEnum.FilteredColumn] = C1FlexGridPrinterTest.Properties.Resources.ColumnFilters_Search2_small;
            foreach (Column c in _flexCustom.Cols)
            {
                c.AllowFiltering = c.DataType == typeof(string)
                    ? AllowFiltering.Default
                    : AllowFiltering.None;
            }
            var filter = new ConditionFilter();
            filter.Condition1.Operator = ConditionOperator.BeginsWith;
            filter.Condition1.Parameter = "C";
            _flexCustom.Cols["ProductName"].Filter = filter;
            _flexCustom.AutoSizeCols(20);

            // configure grouping grid
            var dv = new DataView(dtProducts);
            dv.Sort = "CategoryID";
            _flexGroup.Tree.Column = 1;
            _flexGroup.Styles[CellStyleEnum.Subtotal0].BackColor = SystemColors.ControlDark;
            _flexGroup.AllowFiltering = true;
            _flexGroup.AllowSorting = AllowSortingEnum.None;
            _flexGroup.AllowMerging = AllowMergingEnum.Nodes;
            _flexGroup.DataSource = dv;
            _flexGroup.Cols["UnitPrice"].Format = "#,###.00";
            _flexGroup.Cols["CategoryID"].Move(1);
            _flexGroup.Cols["CategoryID"].TextAlign = TextAlignEnum.LeftCenter;
            _flexGroup.AfterDataRefresh += _flexGroup_AfterDataRefresh;
            _flexGroup.AfterFilter += _flexGroup_AfterFilter;
            UpdateTotals();
            _flexGroup.AutoSizeCols(20);

            // configure bigger grid
            _flexBigger.AllowFiltering = true;
            _flexBigger.AutoResize = false;
            _flexBigger.DataSource = dtInvoices;
            _flexBigger.Cols["UnitPrice"].Format = "#,###.00";
            _flexBigger.Cols["ExtendedPrice"].Format = "#,###.00";
            _flexBigger.Cols["Freight"].Format = "#,###.00";
            _flexBigger.Cols["Discount"].Format = "p0";
            _flexBigger.AutoSizeCols(20);

            // configure styles grid
            _flexStyles.AllowFiltering = true;
            _flexStyles.DataSource = dtInvoices;
            var cs = _flexStyles.Styles.Add("filteredOut");
            cs.BackColor = Color.LightSalmon;
            cs.ForeColor = Color.DarkOrange;
            _flexStyles.BeforeFilter += _flexStyles_BeforeFilter;
            _flexStyles.AfterFilter += _flexStyles_AfterFilter;
            _flexStyles.AutoSizeCols(20);

            // configure search grid
            _flexSearch.DataSource = dtInvoices;
            _flexSearch.AutoSizeCols(20);

            // configure help
            _rtfHelp.Rtf = C1FlexGridPrinterTest.Properties.Resources.ColumnFilters_FilterHelp;
            _status.Text = _tab.SelectedTab.Tag as string;
        }

        #endregion

        //----------------------------------------------------------------------
        #region ** Grouping

        // update groups when the data changes (sort/filter)
        void _flexGroup_AfterDataRefresh(object sender, ListChangedEventArgs e)
        {
            UpdateTotals();
        }
        void _flexGroup_AfterFilter(object sender, EventArgs e)
        {
            UpdateTotals();
        }
        void UpdateTotals()
        {
            var colCat = _flexGroup.Cols.IndexOf("CategoryID");
            var colPrice = _flexGroup.Cols.IndexOf("UnitPrice");
            var colName = _flexGroup.Cols.IndexOf("ProductName");
            _flexGroup.Subtotal(AggregateEnum.Clear);
            _flexGroup.Subtotal(AggregateEnum.Average, 0, colCat, colPrice, "Category ID {0}");
            _flexGroup.Subtotal(AggregateEnum.Count, 0, colCat, colName);
        }

        #endregion

        //----------------------------------------------------------------------
        #region ** Style filtering

        void _flexStyles_BeforeFilter(object sender, CancelEventArgs e)
        {
            _flexStyles.BeginUpdate();
        }
        void _flexStyles_AfterFilter(object sender, EventArgs e)
        {
            // get style used to show filtered out rows
            var cs = _flexStyles.Styles["filteredOut"];

            // apply style to all rows
            for (int r = _flexStyles.Rows.Fixed; r < _flexStyles.Rows.Count; r++)
            {
                var row = _flexStyles.Rows[r];
                if (row.Visible)
                {
                    row.Style = null; // normal row, reset style
                }
                else
                {
                    row.Style = cs; // fitlered row, make visible and apply style
                    row.Visible = true;
                }
            }
            _flexStyles.EndUpdate();
        }

        #endregion

        //----------------------------------------------------------------------
        #region ** iTunes-style search

        ConditionFilter _searchFilter = new ConditionFilter();

        private void _searchBox_Search(object sender, EventArgs e)
        {
            // configure filter
            _searchFilter.Condition1.Operator = ConditionOperator.Contains;
            _searchFilter.Condition1.Parameter = _searchBox.Text;

            // apply filter
            var count = 0;
            _flexSearch.BeginUpdate();
            for (int r = _flexSearch.Rows.Fixed; r < _flexSearch.Rows.Count; r++)
            {
                bool visible = false;
                for (int c = _flexSearch.Cols.Fixed; c < _flexSearch.Cols.Count; c++)
                {
                    if (_searchFilter.Apply(_flexSearch[r, c]))
                    {
                        visible = true;
                        count++;
                        break;
                    }
                }
                _flexSearch.Rows[r].Visible = visible;
            }
            _flexSearch.EndUpdate();

            _lblSearchCount.Text = string.Format("{0:n0} items", count);
        }

        #endregion

        //----------------------------------------------------------------------
        #region ** show help, active filters

        void _tab_SelectedIndexChanged(object sender, EventArgs e)
        {
            _status.Text = _tab.SelectedTab.Tag as string;
        }
        void _showFilter_Click(object sender, EventArgs e)
        {
            var flex = _tab.SelectedTab.Controls[0] as C1FlexGrid;
            if (flex != null)
            {
                var sb = new StringBuilder();
                foreach (Column col in flex.Cols)
                {
                    var cf = col.ActiveFilter;
                    if (cf != null)
                    {
                        var conditionFilter = cf as ConditionFilter;
                        if (conditionFilter != null)
                        {
                            AppendFilterInfo(sb, col, conditionFilter);
                        }
                        var valueFilter = cf as ValueFilter;
                        if (valueFilter != null)
                        {
                            AppendFilterInfo(sb, col, valueFilter);
                        }
                        var colFilter = cf as ColumnFilter;
                        if (colFilter != null)
                        {
                            if (colFilter.ValueFilter.IsActive)
                            {
                                AppendFilterInfo(sb, col, colFilter.ValueFilter);
                            }
                            if (colFilter.ConditionFilter.IsActive)
                            {
                                AppendFilterInfo(sb, col, colFilter.ConditionFilter);
                            }
                        }
                    }
                }
                if (sb.Length == 0)
                {
                    sb.Append("No filters are currently applied.");
                }
                MessageBox.Show(this, sb.ToString(), "Active Filters");
            }
        }
        void AppendFilterInfo(StringBuilder sb, Column col, ConditionFilter cf)
        {
            sb.AppendFormat("Column [{0}]: ({1} '{2}') {3} ({4} '{5}')\r\n",
                col.Name,
                cf.Condition1.Operator,
                cf.Condition1.Parameter,
                cf.AndConditions ? "and" : "or",
                cf.Condition2.Operator,
                cf.Condition2.Parameter);
        }
        void AppendFilterInfo(StringBuilder sb, Column col, ValueFilter vf)
        {
            sb.AppendFormat("Column [{0}]: ({1} values selected)\r\n",
                col.Name,
                vf.ShowValues.Length);
        }

        #endregion

        //----------------------------------------------------------------------
        #region ** utility

        public static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }

        #endregion
    }
}
