﻿using C1.Win.Themes;
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
                lblSamples.Items.Add(sample);
            }
            lblSamples.SelectedIndex = 0;

            var themes = C1ThemeController.GetThemes();
            cmbThemes.Items.Add("(none)");
            foreach(var theme in themes)
            {
                cmbThemes.Items.Add(theme);
            }
            cmbThemes.SelectedIndex = 0;
        }

        private void lbSamples_SelectedValueChanged(object sender, EventArgs e)
        {
            this.pnlSample.Controls.Cast<Control>().ToList().ForEach(c => c.Dispose());
            this.pnlSample.Controls.Clear();
            var sample = lblSamples.SelectedItem as SampleItem;
            lblTitle.Text = sample.Title;
            lblDescription.Text = sample.Description;
            var control = sample.Sample;
            control.Dock = DockStyle.Fill;
            this.pnlSample.Controls.Add(control);
            if (control is Form form)
            {
                form.Show();
            }
        }

        private void chkInfo_CheckedChanged(object sender, EventArgs e)
        {
            pnlDescription.Visible = chkInfo.Checked;
        }

        private void cmbThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbThemes.SelectedIndex == -1)
                return;
            cmbThemes.Text = cmbThemes.SelectedItem.DisplayText;
            C1ThemeController.ApplyThemeToControlTree(pnlSample, C1ThemeController.GetThemeByName((string)cmbThemes.SelectedItem.Value, false), null, true);
            var sample = lblSamples.SelectedItem as SampleItem;
            if (sample.Name == "FilterEditorAndDataEngine" || sample.Name == "FilterEditorSummaryPanel")
            {
                if(pnlSample.Controls[0] is Samples.FilterEditorAndDataEngine sampleFD)
                    sampleFD.ApplyTheme(C1ThemeController.GetThemeByName((string)cmbThemes.SelectedItem.Value, false));
                else
                if (pnlSample.Controls[0] is Samples.FilterEditorSummaryPanel sampleES)
                    sampleES.ApplyTheme(C1ThemeController.GetThemeByName((string)cmbThemes.SelectedItem.Value, false));
            }
            if (sample.Name == "UnboundMode")
            {
                if (pnlSample.Controls[0] is Samples.UnboundMode sampleUM)
                    sampleUM.ApplyTheme(C1ThemeController.GetThemeByName((string)cmbThemes.SelectedItem.Value, false));
            }
        }
    }
}