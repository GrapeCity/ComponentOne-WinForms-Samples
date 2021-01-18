using C1.Win.Themes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CommandExplorer
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
            var control = sample.Sample;
            control.Dock = DockStyle.Fill;
            pnlSample.Controls.Add(control);

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
            {
                return;
            }

            var value = cmbThemes.SelectedItem.DisplayText;
            cmbThemes.Text = value;
            C1ThemeController.ApplyThemeToControlTree(pnlSample, C1ThemeController.GetThemeByName(value, false), null, true);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            lblDescription.MaximumSize = new Size(pnlDescription.Width, 0);
        }
    }
}