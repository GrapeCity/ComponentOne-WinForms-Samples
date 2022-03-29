using C1.Win.C1Themes;
using C1.Win.Ribbon;
using FilterEditorAndDataEngine.UI;
using System;
using System.Data;
using System.Linq;

namespace FilterEditorAndDataEngine
{
    public partial class MainForm : C1RibbonForm
    {
        private readonly DataFilterView _view;
        private readonly LoadingView _loader;

        public MainForm()
        {
            _loader = new LoadingView();
            _view = new DataFilterView();
            _view.DataUpdated += View_DataUpdated;
            _view.DataLoaded += View_DataLoaded;

            SuspendLayout();
            InitializeComponent();

            InitThemes();
            cmbTheme.SelectedIndex = 3;            
            SamplePanel.Controls.Add(_loader);
            ResumeLayout();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            // load data if needed            
            if (!DataService.TablesExists())
            {
                await DataService.GenerateData();
            }
            // load sample view
            await _view.LoadData();
        }

        private void View_DataUpdated(object sender, EventArgs e)
        {
            lblTotalCount.Text = _view.TotalCount.ToString();
            lblFilteredCount.Text = _view.FilteredCount.ToString();
            lblTotalLoadTime.Text = $"{TimeSpan.FromMilliseconds(_view.TotalLoadTime):ss\\:fff} ms";
            lblFilteredTime.Text = $"{TimeSpan.FromMilliseconds(_view.FilteredTime):ss\\:fff} ms";
        }

        private void View_DataLoaded(object sender, EventArgs e)
        {
            // hide loader
            SamplePanel.Controls.Add(_view);
            ApplyTheme();
            SamplePanel.Controls.Remove(_loader);
            _loader.Dispose();
        }

        #region Themes

        private void InitThemes()
        {
            var themes = C1ThemeController.GetThemes().Where(x => x.Contains("Office2016"));
            foreach (var theme in themes)
                cmbTheme.Items.Add(theme);
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e) => ApplyTheme();

        private void ApplyTheme()
        {
            var theme = C1ThemeController.GetThemeByName(cmbTheme.SelectedItem.Text, false);
            C1ThemeController.ApplyThemeToControlTree(this, theme);
            _view?.ApplyTheme(theme);
        }

        #endregion

    }
}
