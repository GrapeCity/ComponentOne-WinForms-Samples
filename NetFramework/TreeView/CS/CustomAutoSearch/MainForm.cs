using C1.Win.C1Ribbon;
using C1.Win.C1Themes;
using System;
using System.Windows.Forms;

namespace CustomAutoSearch
{
    public partial class MainForm : C1RibbonForm
    {
        private AutoSearchService _searchService;

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
            this.regionTableAdapter.Fill(this.dataSet1.Region);
            this.territoriesTableAdapter.Fill(this.dataSet1.Territories);

            c1TreeView1.BindingInfo.DataMember = "Region\\Territories";
            c1TreeView1.BindingInfo.KeyField = "RegionID\\RegionID";
            c1TreeView1.BindingInfo.DataSource = dataSet1;

            _searchService = new AutoSearchService(c1TreeView1);
        }

        private void ribbonTextBox1_TextChanged(object sender, EventArgs e)
        {
            _searchService.Search(ribbonTextBox1.Text);
        }
    }
}
