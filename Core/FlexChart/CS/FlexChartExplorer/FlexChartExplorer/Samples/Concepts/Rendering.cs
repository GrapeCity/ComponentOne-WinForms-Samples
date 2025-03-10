using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using C1.Chart;
using C1.Win.Chart;
using BaseExplorer;
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class Rendering : FlexChartBaseSample
    {
        private ComboBoxEx _cbPoints;
        private CheckBoxEx _chbSVGOrDirectX;
        private LabelEx _lTimeElapsed;
        private Stopwatch _stopwatch;
        private FlexChart flexChart1;
        private Func<double, double> _yFunc = x => Math.Sin(x) * Math.Tan(x);

        public Rendering()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.Line;
            
            this.flexChart1.DataSource = DataService.CreateDataPoints(x=>x, _yFunc, 100);
            this.flexChart1.BindingX = "X";
            this.flexChart1.Series.Add(new Series() { Binding = "Y" });

            this.flexChart1.Rendering += (s, e) => 
            {
                _stopwatch.Restart();
            };
            this.flexChart1.Rendered += (s, e) =>
            {
                _stopwatch.Stop();
                _lTimeElapsed.Text = "Elapsed Time : " + _stopwatch.ElapsedMilliseconds + " ms";
            };
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
           
            _cbPoints = new ComboBoxEx("Points") { ItemsDataSource = new int[] { 100, 1000, 10000, 50000 } };
            _cbPoints.SelectedIndex = 0;
            _cbPoints.SelectedIndexChanged += (s, e) => { flexChart1.DataSource = DataService.CreateDataPoints(x=>x, _yFunc, (int)(_cbPoints.SelectedValue)); };

            _chbSVGOrDirectX = new CheckBoxEx("DirectX Rendering");
            _chbSVGOrDirectX.CheckedChanged += (s, e) => { flexChart1.RenderMode = _chbSVGOrDirectX.Checked ? RenderMode.DirectX : RenderMode.Default; };

            _lTimeElapsed = new LabelEx("Elapsed Time:");
            _stopwatch = new Stopwatch();

            this.pnlControls.Controls.Add(_cbPoints);
            this.pnlControls.Controls.Add(_chbSVGOrDirectX);
            this.pnlControls.Controls.Add(_lTimeElapsed);
        }
    }
}
