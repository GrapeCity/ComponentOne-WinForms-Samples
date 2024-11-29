using C1.Win.Themes;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CommandExplorer
{
    public partial class Form1 : Form
    {
        private Control _selectedControl;
        private readonly string _defaultTheme = "Office365White";

        public Form1()
        {
            InitializeComponent();

            foreach (SampleItem sample in SampleDataSource.AllItems)
            {
                lblSamples.Items.Add(sample);
            }

            lblSamples.SelectedIndex = 0;

            InitializeTheme();

            ApplyTheme(_defaultTheme, 0);
        }

        private void InitializeTheme()
        {
            String[] themeNames = C1ThemeController.GetThemes();
            cmbThemes.Items.Add("(none)");

            foreach (string theme in themeNames)
            {
                var Themeitem = new C1.Win.Input.ComboBoxItem { DisplayText = theme };
                cmbThemes.Items.Add(Themeitem.DisplayText);
            }
        }

        private void lbSamples_SelectedValueChanged(object sender, EventArgs e)
        {
            pnlSample.Controls.Clear();
            var sample = lblSamples.SelectedItem as SampleItem;
            lblTitle.Text = sample.Title;
            lblDescription.Text = sample.Description;
            _selectedControl = sample.Sample;

            _selectedControl.Dock = DockStyle.Fill;
            pnlSample.Controls.Add(_selectedControl);

            if (_selectedControl is Form)
            {
                ((Form)_selectedControl).Show();
            }

            ApplyTheme();
        }

        private void chkInfo_CheckedChanged(object sender, EventArgs e)
        {
            pnlDescription.Visible = chkInfo.Checked;
        }

        private void cmbThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbThemes.SelectedIndex == -1)
            {
                return;
            }

            ApplyTheme();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            lblDescription.MaximumSize = new Size(pnlDescription.Width, 0); // adjust description label width
        }

        private void ApplyTheme()
        {
            if (cmbThemes.SelectedItem != null && _selectedControl != null)
            {
                var displayText = cmbThemes.SelectedItem.DisplayText;
                cmbThemes.Text = displayText;
                C1ThemeController.ApplyThemeToControlTree(_selectedControl, C1ThemeController.GetThemeByName(displayText, false), null, true);
            }
        }

        private void ApplyTheme(string themeName, int defaultIndex)
        {
            var themeItem = cmbThemes.Items.FirstOrDefault(x => x.DisplayText == themeName);
            if (themeItem is null)
            {
                cmbThemes.SelectedIndex = defaultIndex;
                return;
            }

            cmbThemes.SelectedItem = themeItem;
            C1ThemeController.ApplyThemeToControlTree(_selectedControl, C1ThemeController.GetThemeByName(themeName, false), null, true);
        }
    }
}