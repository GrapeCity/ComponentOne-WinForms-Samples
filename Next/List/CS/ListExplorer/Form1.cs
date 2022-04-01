using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ListExplorer
{
    using ListExplorer.Samples;

    public partial class Form1 : Form
    {
        private readonly IList<SampleItem> _items = SampleDataSource.AllItems;

        public Form1()
        {
            InitializeComponent();
            if (_items != null)
            {
                lblSamples.Items.AddRange(_items.Select(x => x.Name).ToArray());
                if(_items.Any())
                    lblSamples.SelectedIndex = 0;
            }
        }

        private void lbSamples_SelectedValueChanged(object sender, EventArgs e)
        {
            pnlSample.Controls.Clear();
            if (lblSamples.SelectedItem is not string sampleName) return;

            var sample = _items.Where(x => x.Name == sampleName).FirstOrDefault();
            if (sample == null) return;

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
    }
}
