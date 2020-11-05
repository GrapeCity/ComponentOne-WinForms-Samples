using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Samples;

namespace AnimationDemo
{
    public partial class Form1 : Form
    {
        SampleHelper _helper;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _helper = new SampleHelper(panelSamples, panelSample, sampleHeader, sampleDescription);

            var samples = new AllSamples();
            var g1 = new SampleGroup() { Name = "" };

            var s11 = new Sample()
            {
                Name = "FlexChart Animation",
                Description = "Shows advanced animation options for FlexChart control.",
                ControlName = "FlexChartAnimation"
            };
            g1.Samples.Add(s11);
            var s12 = new Sample()
            {
                Name = "FlexPie Animation",
                Description = "Shows advanced animation options for FlexPie control.",
                ControlName = "FlexPieAnimation"
            };
            g1.Samples.Add(s12);
            var s13 = new Sample()
            {
                Name = "Custom Animation",
                Description = "Show how to customize animation with AnimationTransform event.",
                ControlName = "CustomAnimation"
            };
            g1.Samples.Add(s13);

            samples.Groups.Add(g1);

            if (samples != null)
                _helper.InitSamples(samples);
        }
    }
}
