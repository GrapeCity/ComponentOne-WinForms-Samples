using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiSelectExplorer
{
    using MultiSelectExplorer.Samples;
    public partial class Form1 : Form
    {
        private IList<SampleItem> _items = SampleDataSource.AllItems;
        public Form1()
        {
            InitializeComponent();
            if (_items != null)
            {
                lbSamples.Items.AddRange(_items.Select(x => x.Name).ToArray());
                if(_items.Any())
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
            var sampleName = lbSamples.SelectedItem as string;
            if (sampleName == null) return;

            SampleItem sampleItem = _items.Where(x => x.Name == sampleName).FirstOrDefault();
            if (sampleItem == null) return;

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
    }
}
