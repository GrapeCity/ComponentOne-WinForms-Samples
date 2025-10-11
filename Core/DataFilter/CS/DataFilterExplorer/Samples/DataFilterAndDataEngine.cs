using DataFilterExplorer.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataFilterExplorer.Samples
{
    public partial class DataFilterAndDataEngine : UserControl
    {
        private DataFilterView _view;

        [DefaultValue(null)]
        public string SelectedTheme { get; set; }

        public DataFilterAndDataEngine()
        {
            InitializeComponent();
        }

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

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
            SamplePanel.Controls.Remove(loader);
            loader.Dispose();

            // Apply the theme after loading the data
            if (SelectedTheme != null)
            {
                var theme = C1.Win.Themes.C1ThemeController.GetThemeByName(SelectedTheme, false);
                C1.Win.Themes.C1ThemeController.ApplyThemeToControlTree(_view, theme, null, true);
            }

        }

        private void View_DataUpdated(object sender, EventArgs e)
        {
            lblTotalCount.Text = _view.TotalCount.ToString();
            lblFilteredCount.Text = _view.FilteredCount.ToString();
            lblTotalLoadTime.Text = $"{TimeSpan.FromMilliseconds(_view.TotalLoadTime):ss\\:fff} ms";
            lblFilteredTime.Text = $"{TimeSpan.FromMilliseconds(_view.FilteredTime):ss\\:fff} ms";
        }
    }
}
