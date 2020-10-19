using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RulesManagerExplorer
{
    using RulesManagerExplorer.Samples;
    public partial class Form1 : Form
    {
        IList<SampleItem> _samples = SampleDataSource.AllItems;

        public Form1()
        {
            InitializeComponent();

            lblSamples.Items.AddRange(_samples.Select(x => x.Name).ToArray());
            if(_samples.Any())
                lblSamples.SelectedIndex = 0;
        }

        private void lbSamples_SelectedValueChanged(object sender, EventArgs e)
        {
            this.pnlSample.Controls.Clear();
            var sampleName = lblSamples.SelectedItem as String;
            if (sampleName == null) return;

            var sample = _samples.Where(x => x.Name == sampleName).FirstOrDefault();
            lblTitle.Text = sample.Title;
            lblDescription.Text = sample.Description;

            var control = sample.Sample;
            control.Dock = DockStyle.Fill;
            this.pnlSample.Controls.Add(control);
            UpdateDescriptionSize();
        }

        private void UpdateDescriptionSize()
        {
            Size s = TextRenderer.MeasureText(lblDescription.Text, lblDescription.Font);
            int height = Math.Max(s.Height + 6, (s.Height + 6) * (int)Math.Ceiling((decimal)(s.Width + 20) / lblDescription.Width));
            this.lblDescription.Size = new Size(lblDescription.Width, height);
        }
        private void chkInfo_CheckedChanged(object sender, EventArgs e)
        {
            pnlDescription.Visible = chkInfo.Checked;
            UpdateDescriptionSize();
        }
    }
}
