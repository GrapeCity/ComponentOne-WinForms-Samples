using C1.Win.Themes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MultiColumnComboExplorer
{
    using Samples;

    public partial class MainForm : Form
    {
        private readonly IList<SampleItem> _items = SampleDataSource.AllItems;

        public MainForm()
        {
            InitializeComponent();

            var themes = C1ThemeController.GetThemes();
            cmbThemes.Items.Add("(none)");
            foreach (var theme in themes)
            {
                cmbThemes.Items.Add(theme);
            }
            cmbThemes.SelectedIndex = cmbThemes.Items.Select(x => 
                x.DisplayText).ToList().IndexOf("Office365White");
            C1ThemeController.ApplyThemeToControlTree(pnlSample, C1ThemeController.GetThemeByName((string)cmbThemes.SelectedItem.Value, false), null, true);

            if (_items is not null)
            {
                lblSamples.Items.AddRange(_items.Select(x => x.Name).ToArray());
                if (_items.Any())
                    lblSamples.SelectedIndex = 0;
            }
        }

        private void lbSamples_SelectedValueChanged(object sender, EventArgs e)
        {
            pnlSample.Controls.Clear();
            if (lblSamples.SelectedItem is not string sampleName)
                return;

            var sample = _items.Where(x => x.Name == sampleName).FirstOrDefault();
            if (sample == null)
                return;

            lblTitle.Text = sample.Title;
            lblDescription.Text = sample.Description;

            var control = sample.Sample;
            control.Dock = DockStyle.Fill;
            pnlSample.Controls.Add(control);
            UpdateDescriptionSize();
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

        private void cmbThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbThemes.SelectedIndex == -1)
                return;
            cmbThemes.Text = cmbThemes.SelectedItem.DisplayText;
            C1ThemeController.ApplyThemeToControlTree(pnlSample, C1ThemeController.GetThemeByName((string)cmbThemes.SelectedItem.Value, false), null, true);
        }
    }
}
