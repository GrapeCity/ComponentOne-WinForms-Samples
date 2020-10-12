using C1.DataCollection.BindingList;
using C1.Win.C1Themes;
using C1.Win.DataFilter;
using C1.Win.Ribbon;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace UnboundMode
{
    public partial class MainForm : C1RibbonForm
    {
        private readonly DropDownFilter _dropDownFilter;
        private C1BindingListDataCollection _dataSource;

        public MainForm()
        {
            InitializeComponent();

            _dropDownFilter = new DropDownFilter();
            _dropDownFilter.Closed += DropDownFilter_Closed;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Cars' table. You can move, or remove it, as needed.
            carsTableAdapter.Fill(dataSet1.Cars);
            _dataSource = new C1BindingListDataCollection(carsBindingSource);

            InitThemes();
            cmbTheme.SelectedIndex = 1;

            InitFilters();

        }

        private void InitFilters()
        {
            // model
            var modelFilter = new ChecklistFilter
            {
                Expanded = false,
                ItemsSource = dataSet1.Cars.Select(x => x.Model),
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
                ItemsSource = dataSet1.Cars.Select(x => x.Brand),
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
                Maximum = dataSet1.Cars.Max(x => x.Liter),
                Minimum = dataSet1.Cars.Min(x => x.Liter),
                PropertyName = "Liter"
            };
            _dropDownFilter.AddFilter(literFilter);

            // category
            var categoryFilter = new ChecklistFilter
            {
                Expanded = false,
                ItemsSource = dataSet1.Cars.Select(x => x.Category),
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
                Maximum = dataSet1.Cars.Max(x => x.Price),
                Minimum = dataSet1.Cars.Min(x => x.Price),
                PropertyName = "Price"
            };
            _dropDownFilter.AddFilter(priceFilter);
        }

        #region Themes

        private void InitThemes()
        {
            var themes = C1ThemeController.GetThemes().Where(x => x.Contains("Office2016"));
            foreach (var theme in themes)
                cmbTheme.Items.Add(theme);
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = cmbTheme.SelectedItem.Text;
        }

        private void c1ThemeController1_ThemeChanged(C1ThemeController sender, ThemeEventArgs e)
        {
            c1ThemeController1.SetTheme(_dropDownFilter.DataFilter, e.ThemeName);
        }

        #endregion

        #region data

        public static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }



        #endregion

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

    }
}
