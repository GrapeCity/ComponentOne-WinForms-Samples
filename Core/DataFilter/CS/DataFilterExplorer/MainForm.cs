using C1.Win.Themes;
using DataFilterExplorer.Data;
using DataFilterExplorer.Samples;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DataFilterExplorer
{
    public partial class MainForm : Form
    {
        public string SelectedTheme { get; set; }


        public MainForm()
        {
            InitializeComponent();
            foreach (SampleItem sample in SampleDataSource.AllItems)
            {
                lblSamples.Items.Add(sample);
            }
            lblSamples.SelectedIndex = 0;

            var themes = C1ThemeController.GetThemes();
            cmbThemes.Items.Add("(none)");
            foreach(var theme in themes)
            {
                cmbThemes.Items.Add(theme);
            }
            cmbThemes.SelectedIndex = cmbThemes.Items.Select(x => 
                x.DisplayText).ToList().IndexOf("Office365White");
        }

        private void lbSamples_SelectedValueChanged(object sender, EventArgs e)
        {
            this.pnlSample.Controls.Cast<Control>().ToList().ForEach(c => c.Dispose());
            this.pnlSample.Controls.Clear();
            var sample = lblSamples.SelectedItem as SampleItem;
            lblTitle.Text = sample.Title;
            lblDescription.Text = sample.Description;
            // Pass MainForm reference when creating the sample control
            Control control = sample.Name switch
            {
                "FilterEditorAndDataEngine" => new FilterEditorAndDataEngine(),
                "DataFilterAndDataEngine" => new DataFilterAndDataEngine(),
                _ => sample.Sample
            };

            if (control is FilterEditorAndDataEngine filterEditorControl)
            {
                filterEditorControl.SelectedTheme = this.SelectedTheme;  // Replace desiredTheme with the theme you want to set
            }
            else if (control is DataFilterAndDataEngine dataFilterControl)
            {
                dataFilterControl.SelectedTheme = this.SelectedTheme;
            }

            control.Dock = DockStyle.Fill;
            this.pnlSample.Controls.Add(control);
            if (control is Form form)
            {
                form.Show();
            }

            ApplyThemeToCurrentSample(); // Apply theme when a new sample is selected

        }

        private void chkInfo_CheckedChanged(object sender, EventArgs e)
        {
            pnlDescription.Visible = chkInfo.Checked;
        }

        private void cmbThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbThemes.SelectedIndex == -1)
                return;
            SelectedTheme = cmbThemes.SelectedItem.DisplayText;
            ApplyThemeToCurrentSample(); // Apply the selected theme to the current sample
        }

        private void ApplyThemeToCurrentSample()
        {
            if (string.IsNullOrEmpty(SelectedTheme) || SelectedTheme == "(none)")
                return;

            var theme = C1ThemeController.GetThemeByName(SelectedTheme, false);
            C1ThemeController.ApplyThemeToControlTree(pnlSample, theme, null, true);

            var sample = lblSamples.SelectedItem as SampleItem;
            if (sample != null)
            {
                switch (sample.Name)
                {
                    case "FilterEditorAndDataEngine":
                        if (pnlSample.Controls[0] is Samples.FilterEditorAndDataEngine sampleFD)
                            sampleFD.ApplyTheme(theme);
                        break;

                    case "FilterEditorSummaryPanel":
                        if (pnlSample.Controls[0] is Samples.FilterEditorSummaryPanel sampleES)
                            sampleES.ApplyTheme(theme);
                        break;

                    case "UnboundMode":
                        if (pnlSample.Controls[0] is Samples.UnboundMode sampleUM)
                            sampleUM.ApplyTheme(theme);
                        break;
                }
            }
        }
    }
}
