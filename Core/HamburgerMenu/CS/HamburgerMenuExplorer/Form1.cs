using SampleExplorer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.Themes;

namespace HamburgerMenuExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
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
                cmbThemes.Items.Add(theme); ;
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
            UpdateDescriptionSize();
            ApplyTheme();
        }

        private void UpdateDescriptionSize()
        {
            Size s = TextRenderer.MeasureText(lblDescription.Text, lblDescription.Font);
            int height = Math.Max(s.Height + 6, (s.Height + 6) * (int)Math.Ceiling((decimal)(s.Width + 20) / lblDescription.Width));
            lblDescription.Size = new Size(lblDescription.Width, height);
        }
        
        private void chkInfo_CheckedChanged(object sender, EventArgs e)
        {
            pnlDescription.Visible = chkInfo.Checked;
            UpdateDescriptionSize();
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
                if (sample.Name == nameof(Samples.Overview) && pnlSample.Controls[0] is Samples.Overview sampleOv)
                    sampleOv.ApplyTheme(selectedTheme);
                else if (sample.Name == nameof(Samples.Layout) && pnlSample.Controls[0] is Samples.Layout sampleLa)
                    sampleLa.ApplyTheme(selectedTheme);
                else if (sample.Name == nameof(Samples.SearchPanel) && pnlSample.Controls[0] is Samples.SearchPanel sampleSe)
                    sampleSe.ApplyTheme(selectedTheme);
            }
        }

        private void cmbThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyTheme();
        }
    }
}
