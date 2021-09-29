using C1.Win.Themes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CommandExplorer
{
    public partial class Form1 : Form
    {
        private Control _selectedControl;

        public Form1()
        {
            InitializeComponent();
            
            foreach (SampleItem sample in SampleDataSource.AllItems)
            {
                lblSamples.Items.Add(sample);
            }

            lblSamples.SelectedIndex = 0;

            var item = new C1.Win.Input.ComboBoxItem();
            item.DisplayText = "(none)";
            cmbThemes.Items.Add(item);
            
            var themes = C1ThemeController.GetThemes();
            
            foreach(var theme in themes)
            {
                var themeItem = new C1.Win.Input.ComboBoxItem();
                themeItem.DisplayText = theme;
                cmbThemes.Items.Add(themeItem);
            }
            
            cmbThemes.SelectedIndex = 0;
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
    }
}