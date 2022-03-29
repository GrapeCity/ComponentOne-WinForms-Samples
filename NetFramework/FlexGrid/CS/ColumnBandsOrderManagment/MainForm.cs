using System;
using System.Data;
using System.Linq;
using C1.Win.C1Themes;
using C1.Win.Ribbon;

namespace ColumnBands
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
            columnBandsUserControl1.Init();
        }

        #region Themes

        private void InitThemes()
        {
            var themes = C1ThemeController.GetThemes().Where(x => x.Contains("Office2016"));
            foreach (var theme in themes)
                cmbTheme.Items.Add(theme);
            cmbTheme.SelectedIndex = 3;
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = cmbTheme.SelectedItem.Text;
            columnBandsUserControl1.ApplyTheme(cmbTheme.SelectedItem.Text);
        }

        #endregion
    }
}
