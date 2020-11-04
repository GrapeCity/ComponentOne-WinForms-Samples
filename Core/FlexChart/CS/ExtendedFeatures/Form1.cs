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

namespace ExtendedFeatures
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
            var g1 = new SampleGroup() { Name = "Heatmap" };

            var s11 = new Sample() {
                Name = "Color Scale",
                Description = "Shows Heatmap plot with gradient color scale. The data from two-dimensional array is shown as a table. The color of table's cell depends on the corresponding data value.",
                ControlName = "Temperature"
            };
            g1.Samples.Add(s11);

            var s12 = new Sample() {
                Name = "Color Axis",
                Description = "Shows Heatmap plot with gradient color axis. The data from function f(x,y) is displayed a heatmap with gradient colouring. The correspondence with color and function value is shown on the auxliary color axis.",
                ControlName = "ColorAxis" };
            g1.Samples.Add(s12);

            var s13 = new Sample() {
                Name = "Discrete Color Scale",
                Description = "Shows Heatmap plot with disrete color scale. In case of disrete color scale, the color depends on which interval the corresponding data value belongs to. All data points from the same interval have the same color. The list of user-defined intervals is shown on the chart legend.",
                ControlName = "Loading" };
            g1.Samples.Add(s13);

            samples.Groups.Add(g1);

            if (samples != null)
                _helper.InitSamples(samples);
        }
    }
}
