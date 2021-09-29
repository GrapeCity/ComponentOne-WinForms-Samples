using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace Samples
{
    class SampleHelper
    {
        TableLayoutPanel pnlSamples;
        Panel panelSample;
        Label sampleHeader;
        RichTextBox sampleDescription;
        LinkLabel _current = null;

        public SampleHelper(TableLayoutPanel pnlSamples, Panel panelSample, Label sampleHeader, RichTextBox sampleDescription)
        {
            this.pnlSamples = pnlSamples;
            this.panelSample = panelSample;
            this.sampleHeader = sampleHeader;
            this.sampleDescription = sampleDescription;
        }

        public void InitSamples(AllSamples samples)
        {
            pnlSamples.Controls.Clear();
            pnlSamples.RowCount = 0;
            pnlSamples.RowStyles.Clear();

            Sample first = null;

            foreach (var g in samples.Groups)
            {
                var lbl = new Label() { Text = g.Name };
                SetGroupStyle(lbl);
                var isEmptyGroup = string.IsNullOrEmpty(g.Name);

                pnlSamples.RowCount++;
                pnlSamples.RowStyles.Add(new RowStyle() { SizeType = SizeType.Absolute, Height = isEmptyGroup ? 12 : 36 });
                pnlSamples.SetRow(lbl, pnlSamples.RowCount - 1);
                pnlSamples.Controls.Add(lbl);

                foreach (var s in g.Samples)
                {
                    var ll = new LinkLabel() { Text = s.Name, Tag = s };
                    ll.LinkClicked += SampleLinkClicked;
                    SetSampleStyle(ll, isEmptyGroup);

                    if (first == null)
                    {
                        first = s;
                        _current = ll;
                        ll.LinkBehavior = LinkBehavior.AlwaysUnderline;
                    }

                    pnlSamples.RowCount++;
                    pnlSamples.RowStyles.Add(new RowStyle() { SizeType = SizeType.Absolute, Height = 24 });
                    pnlSamples.SetRow(ll, pnlSamples.RowCount - 1);
                    pnlSamples.Controls.Add(ll);
                }
            }

            pnlSamples.RowCount++;
            pnlSamples.RowStyles.Add(new RowStyle() { SizeType = SizeType.Absolute, Height = 24 });

            if (first != null)
                ShowSample(first);
        }

        void SetGroupStyle(Label lbl)
        {
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Padding = new Padding(12, 0, 0, 0);
            lbl.Dock = DockStyle.Fill;
        }

        void SetSampleStyle(LinkLabel ll, bool isEmptyGroup = false)
        {
            ll.LinkBehavior = LinkBehavior.HoverUnderline;
            ll.TextAlign = ContentAlignment.MiddleLeft;
            ll.Padding = new Padding( isEmptyGroup ? 12 : 24, 0, 0, 0);
            ll.Margin = new System.Windows.Forms.Padding(0);
            ll.ActiveLinkColor = Color.Black;
            ll.LinkColor = Color.DarkSlateGray;
            ll.Dock = DockStyle.Fill;
        }

        void SampleLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ll = (LinkLabel)sender;
            var sample = ll.Tag as Sample;

            Debug.Assert(sample != null);

            if (_current != null)
                _current.LinkBehavior = LinkBehavior.HoverUnderline;
            ll.LinkBehavior = LinkBehavior.AlwaysUnderline;
            _current = ll;

            ShowSample(sample);
        }

        void ShowSample(Sample sample)
        {
            panelSample.Controls.Clear();
            sampleHeader.Text = sample.Name;
            sampleDescription.Text = sample.Description;

            var ctrl = GetSampleControl(sample.ControlName);
            if (ctrl != null)
            {
                ctrl.Dock = DockStyle.Fill;
                ctrl.Tag = sample;
                panelSample.Controls.Add(ctrl);
            }
        }

        UserControl GetSampleControl(string name)
        {
            var ctrl = Assembly.GetExecutingAssembly().CreateInstance("Samples." + name) as UserControl;
            Debug.Assert(ctrl != null);
            return ctrl;
        }
    }
}
