using C1.Win.Themes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintDocExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
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
            this.pnlSample.Controls.Clear();
            var sample = lblSamples.SelectedItem as SampleItem;
            lblTitle.Text = sample.Title;
            lblDescription.Text = sample.Description;
            var control = sample.Sample;
            control.Dock = DockStyle.Fill;
            this.pnlSample.Controls.Add(control);
            if (control is Form)
            {
                ((Form)control).Show();
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
        }
    }
}
