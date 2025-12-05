using C1.Win.Themes;
using DataFilterExplorer.Data;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DataFilterExplorer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            foreach (SampleItem sample in SampleDataSource.AllItems)
            {
                lbSamples.Items.Add(sample);
            }
            lbSamples.SelectedIndex = 0;

            var themes = C1ThemeController.GetThemes();
            cmbThemes.Items.Add("(none)");
            foreach (var theme in themes)
            {
                cmbThemes.Items.Add(theme);
            }
            cmbThemes.SelectedIndex = cmbThemes.Items.Select(x =>
                x.DisplayText).ToList().IndexOf("Office365White");
        }

        private void lbSamples_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = pnlSample.Controls.Count - 1; i >= 0; i--)
            {
                Control control = pnlSample.Controls[i];
                pnlSample.Controls.RemoveAt(i);
                control.Dispose();
            }
            if (lbSamples.SelectedItem is not SampleItem sampleItem)
            {
                return;
            }
            lblTitle.Text = sampleItem.Title;
            lblDescription.Text = sampleItem.Description;
            var sampleItemControl = sampleItem.Sample;
            sampleItemControl.Dock = DockStyle.Fill;
            pnlSample.Controls.Add(sampleItemControl);

            ApplyTheme();

            if (sampleItemControl is Form sampleItemForm)
            {
                sampleItemForm.Show();
            }
        }

        private void ApplyTheme()
        {
            if (cmbThemes.SelectedIndex == -1)
                return;

            var selectedTheme = C1ThemeController.GetThemeByName((string)cmbThemes.SelectedItem.Value, false);
            C1ThemeController.ApplyThemeToControlTree(pnlSample, selectedTheme, null, true);

            var sample = lbSamples.SelectedItem as SampleItem;
            if (sample != null)
            {
                if (sample.Name == "FilterEditorAndDataEngine" && pnlSample.Controls[0] is Samples.FilterEditorAndDataEngine sampleFD)
                    sampleFD.ApplyTheme(selectedTheme);
                else if (sample.Name == "FilterEditorSummaryPanel" && pnlSample.Controls[0] is Samples.FilterEditorSummaryPanel sampleES)
                    sampleES.ApplyTheme(selectedTheme);
                else if (sample.Name == "UnboundMode" && pnlSample.Controls[0] is Samples.UnboundMode sampleUM)
                    sampleUM.ApplyTheme(selectedTheme);
            }
        }

        private void chkInfo_CheckedChanged(object sender, EventArgs e)
        {
            pnlDescription.Visible = chkInfo.Checked;
        }

        private void cmbThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyTheme();
        }
    }
}
