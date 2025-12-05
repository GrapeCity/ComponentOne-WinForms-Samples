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
                lbSamples.Items.AddRange(_items.Select(x => x.Name).ToArray());
                if (_items.Any())
                    lbSamples.SelectedIndex = 0;
            }
        }

        private void lbSamples_SelectedValueChanged(object sender, EventArgs e)
        {
            for (int i = pnlSample.Controls.Count - 1; i >= 0; i--)
            {
                Control control = pnlSample.Controls[i];
                pnlSample.Controls.RemoveAt(i);
                control.Dispose();
            }
            if (lbSamples.SelectedItem is not string sampleName)
                return;

            SampleItem sampleItem = _items.Where(x => x.Name == sampleName).FirstOrDefault();
            if (sampleItem == null)
                return;

            lblTitle.Text = sampleItem.Title;
            lblDescription.Text = sampleItem.Description;

            var sampleItemControl = sampleItem.Sample;
            sampleItemControl.Dock = DockStyle.Fill;
            pnlSample.Controls.Add(sampleItemControl);
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
