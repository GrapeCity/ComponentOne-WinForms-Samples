using C1.DataEngine;
using C1.Win.C1Themes;
using C1.Win.Ribbon;
using DataFilterAndDataEngine.UI;
using System;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DataFilterAndDataEngine
{
    public partial class MainForm : C1RibbonForm
    {
        private DataFilterView _view;
        
        public MainForm()
        {
            InitializeComponent();     
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            InitThemes();
            cmbTheme.SelectedIndex = 3;
            await Task.Yield();
            // load data if needed
            var loader = new LoadingView();
            SamplePanel.Controls.Add(loader);
            if (!DataService.TablesExists())
            {                
                await DataService.GenerateData();                
            }
            // load sample view
            _view = new DataFilterView();
            _view.DataUpdated += View_DataUpdated;
            await _view.LoadData();
            // hide loader
            SamplePanel.Controls.Add(_view);
            ApplyTheme();
            SamplePanel.Controls.Remove(loader);            
            loader.Dispose();
        }

        private void View_DataUpdated(object sender, EventArgs e)
        {
            lblTotalCount.Text = _view.TotalCount.ToString();
            lblFilteredCount.Text = _view.FilteredCount.ToString();
            lblTotalLoadTime.Text = $"{TimeSpan.FromMilliseconds(_view.TotalLoadTime):ss\\:fff} ms";
            lblFilteredTime.Text = $"{TimeSpan.FromMilliseconds(_view.FilteredTime):ss\\:fff} ms";
        }

        #region Themes

        private void InitThemes()
        {
            var themes = C1ThemeController.GetThemes().Where(x => x.Contains("Office2016"));
            foreach (var theme in themes)
                cmbTheme.Items.Add(theme);
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e) => ApplyTheme();

        private void ApplyTheme() => C1ThemeController.ApplyThemeToControlTree(this, C1ThemeController.GetThemeByName(cmbTheme.SelectedItem.Text, false));

        #endregion
    }
}
