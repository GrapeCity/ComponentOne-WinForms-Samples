using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FinancialChartExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        LinkLabel _current = null;

        private void Form1_Load(object sender, EventArgs e)
        {
#if false
            var samples = new AllSamples();
            var g1 = new SampleGroup() { Name = "Chart Types" };

            var s11 = new Sample() { Name = "Heikin-Ashi", Description = "Heikin-Ashi", ControlName = "HeikinAshi" };
            g1.Samples.Add(s11);
            var s12 = new Sample() { Name = "Line Break", Description = "Line Break", ControlName = "LineBreak" };
            g1.Samples.Add(s12);

            samples.Groups.Add(g1);

            var g2 = new SampleGroup() { Name = "Interaction" };

            var s21 = new Sample() { Name = "Markers" };
            g2.Samples.Add(s21);
            var s22 = new Sample() { Name = "Range Selector" };
            g2.Samples.Add(s22);

            samples.Groups.Add(g2);

            var ser = new XmlSerializer(typeof(AllSamples));
            var sw = new StringWriter();
            ser.Serialize(sw, samples);

            var s = sw.ToString();
#endif
            AllSamples samples = null;

            string path = "FinancialChartExplorer.Resources.config.xml";
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path))
            {
                var ser = new XmlSerializer(typeof(AllSamples));
                samples = ser.Deserialize(stream) as AllSamples;
            }

            Debug.Assert( samples!= null);

            if(samples!=null)
                InitSamples(samples);
        }

        void InitSamples(AllSamples samples)
        {
            pnlSamples.Controls.Clear();
            pnlSamples.RowCount = 0;
            pnlSamples.RowStyles.Clear();
            //pnlSamples.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

            Sample first = null;

            foreach (var g in samples.Groups)
            {
                var lbl = new Label() { Text = g.Name };
                SetGroupStyle(lbl);

                pnlSamples.RowCount++;
                pnlSamples.RowStyles.Add(new RowStyle() { SizeType = SizeType.Absolute, Height = 36 });
                pnlSamples.SetRow(lbl, pnlSamples.RowCount-1);
                pnlSamples.Controls.Add(lbl);

                foreach (var s in g.Samples)
                {
                    var ll = new LinkLabel() { Text = s.Name, Tag = s};
                    ll.LinkClicked += SampleLinkClicked;
                    SetSampleStyle(ll);
                    
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

            if(first!=null)
                ShowSample(first);
        }

        void SetGroupStyle(Label lbl)
        {
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            lbl.Padding = new Padding(12, 0, 0, 0);
            lbl.Dock = DockStyle.Fill;
        }

        void SetSampleStyle(LinkLabel ll)
        {
            ll.LinkBehavior = LinkBehavior.HoverUnderline;
            ll.TextAlign = ContentAlignment.MiddleLeft;
            ll.Padding = new Padding(24, 0, 0, 0);
            ll.Margin = new System.Windows.Forms.Padding(0);
            ll.ActiveLinkColor = Color.Black;
            ll.LinkColor = Color.DarkSlateGray;
            ll.Dock = DockStyle.Fill;
        }

        void SampleLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var ll = (LinkLabel)sender;
            var sample = ll.Tag as Sample;
            
            Debug.Assert( sample!=null);

            if (_current != null)
                _current.LinkBehavior = LinkBehavior.HoverUnderline;
            ll.LinkBehavior = LinkBehavior.AlwaysUnderline;
            _current = ll;
            
            ShowSample(sample);
        }

        void ShowSample(Sample sample)
        {
            panelSample.Controls.Clear();
            labelSampleHeader.Text = sample.Name;
            richTextBoxSampleDescription.Text = sample.Description;

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
            var ctrl = Assembly.GetExecutingAssembly().CreateInstance("FinancialChartExplorer.Samples." + name) as UserControl;
            Debug.Assert(ctrl != null);
            return ctrl;
        }
    }
}
