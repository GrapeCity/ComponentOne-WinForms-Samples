using C1.Win.Ribbon;
using C1.Win.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarsListWithFilter
{
    public partial class MainForm : C1RibbonForm
    {
        private readonly string _fileName = "Expressions.xml";

        #region ctor

        public MainForm()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            foreach (var theme in C1ThemeController.GetThemes())
                ribbonCmbThemes.Items.Add(theme);

            ThemeName = "Office365White";
            ribbonCmbThemes.SelectedIndex = ribbonCmbThemes.Items.IndexOf(ThemeName);
            ApplyTheme(this);
        }
        
        #endregion

        #region themes

        private void ribbonCmbThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThemeName = ribbonCmbThemes.SelectedItem.Text;
            ApplyTheme(this);
        }

        private string ThemeName
        {
            get;
            set;
        }

        private void ApplyTheme(Control control)
        {
            if (!string.IsNullOrEmpty(ThemeName))
            {
                var theme = C1ThemeController.GetThemeByName(ThemeName, false);
                if (theme != null)
                    C1ThemeController.ApplyThemeToControlTree(control, theme);
            }
        }

        #endregion

        #region data source

        private DataTable _carsTable;

        private static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }

        private static DataTable GetDataSource()
        {
            string rs = "select * from Cars;";
            string cn = GetConnectionString();
            OleDbDataAdapter da = new OleDbDataAdapter(rs, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {
            _carsTable = GetDataSource();
            c1FlexGrid1.DataSource = _carsTable;
            c1DataFilter1.DataSource = _carsTable;
            c1DataFilter1.SaveFilterExpression(_fileName);
            c1DataFilter1.ApplyFilter();
        }

        private void c1DataFilter1_FilterAutoGenerating(object sender, C1.DataFilter.FilterAutoGeneratingEventArgs e)
        {
            switch(e.Property.Name)
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

                    // Ensure the filter is populated with data from the DataTable
                    var distinctValues = _carsTable.AsEnumerable()
                                                   .Select(row => row.Field<Int16>("TransmissSpeedCount"))
                                                   .Distinct()
                                                   .OrderBy(value => value)
                                                   .ToList();

                    foreach (var value in distinctValues)
                    {
                        tskFilter.Items.Add(new C1.DataFilter.ChecklistItem(value.ToString(), value.ToString()));
                    }

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
                    priceFilter.Maximum = _carsTable.AsEnumerable().Max(x => x.Field<double>("Price"));
                    priceFilter.Minimum = _carsTable.AsEnumerable().Min(x => x.Field<double>("Price"));
                    priceFilter.Increment = 1000;
                    priceFilter.Digits = 0;
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }

        private class TransmissAutomatic
        {
            public string DisplayValue { get; set; }
            public object Value { get; set; }
        }

        private void cbAutoApply_CheckedChanged(object sender, EventArgs e)
        {
            c1DataFilter1.AutoApply = cbAutoApply.Checked;
        }

        private void rbtnApplyFilter_Click(object sender, EventArgs e)
        {
            c1DataFilter1.ApplyFilter();
        }

        private void rbtnResetFilter_Click(object sender, System.EventArgs e)
        {
            c1DataFilter1.LoadFilterExpression(_fileName);
        }

        private void rbtnSaveFilter_Click(object sender, System.EventArgs e)
        {
            c1DataFilter1.SaveFilterExpression(_fileName);
        }
    }
}
