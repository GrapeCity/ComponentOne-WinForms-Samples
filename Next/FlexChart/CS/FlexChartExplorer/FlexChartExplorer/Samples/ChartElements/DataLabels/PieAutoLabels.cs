using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Chart;
using C1.Win.Chart;
using FlexChartExplorer.Data;
using BaseExplorer;

namespace FlexChartExplorer.Samples
{
    public partial class PieAutoLabels : FlexChartBaseSample
    {
        const int NUM_POINTS = 100;
        private FlexPie flexPie;

        public PieAutoLabels()
        {
            InitializeComponent();
        }

        protected override void SetupChart()
        {
            flexPie.Binding = "Value";
            flexPie.BindingName = "Name";
            flexPie.DataSource = CreateData(NUM_POINTS);
            flexPie.Legend.Position = Position.None;
            flexPie.DataLabel.Position = C1.Chart.PieLabelPosition.Auto;
            flexPie.DataLabel.Content = "{Name}";
            flexPie.DataLabel.ConnectingLine = true;
            flexPie.ToolTip.Content = "{Name}:{Value}";
        }

        protected override void InitializeControls()
        {
            flexPie = new FlexPie();
            Chart = flexPie;

            var cbSorted = new CheckBoxEx() { Text = "Sorted", Checked = true };
            cbSorted.CheckedChanged += (s, e) => flexPie.DataSource = CreateData(NUM_POINTS, cbSorted.Checked);

            var bntNew = new ButtonEx() { Text = "New Data" };
            bntNew.Click += (s, e) => flexPie.DataSource = CreateData(NUM_POINTS, cbSorted.Checked);

            pnlControls.Controls.Add(bntNew);
            pnlControls.Controls.Add(cbSorted);
        }

        public List<FlexPieSlice> CreateData(int npts, bool sorted = true)
        {
            var countries = Countries.GetCountries();

            var rnd = new Random();
            var list = new List<FlexPieSlice>();

            for (var i = 0; i < npts; i++)
                list.Add(new FlexPieSlice(rnd.Next(1, 100), countries[i]));//.Substring(0, Math.Min(countries[i].Length, 15))));

            if (sorted)
                list = list.OrderBy((i) => i.Value).ToList();

            return list;
        }
    }
}
