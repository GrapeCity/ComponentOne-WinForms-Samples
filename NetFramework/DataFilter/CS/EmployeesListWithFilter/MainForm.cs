using C1.Win.C1Ribbon;
using C1.Win.C1Themes;
using C1.Win.DataFilter;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EmployeesListWithFilter
{
    public partial class MainForm : C1RibbonForm
    {
        private DataProvider _dataProvider = new DataProvider();

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
            ribbonCmbThemes.SelectedIndex = ribbonCmbThemes.Items.IndexOf("Office365White");
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            var data = _dataProvider.GetEmployees().ToList();
            c1DataFilter1.DataSource = data;
            c1FlexGrid1.DataSource = data;
            foreach (ChecklistFilter filter in c1DataFilter1.Filters.Where(f => f is ChecklistFilter))
                filter.SelectAll();            
        }

        private void c1DataFilter1_FilterChanged(object sender, EventArgs e)
        {
            c1FlexGrid1.DataSource = c1DataFilter1.View.Cast<Employee>().ToList();
        }
    }
}
