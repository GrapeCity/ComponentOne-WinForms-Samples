using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.Chart;
using System.Drawing.Drawing2D;
using C1.Chart;
using C1.Chart.Annotation;
using C1.Win.Chart.Annotation;
using C1.Win.Chart.Interaction;
using DataManipulation.Samples.FunctionSeries;

namespace DataManipulation
{
    public partial class YFunctionSeriesSample : UserControl
    {
        AggregateFilter _filter = new AggregateFilter();
        YFunctionSeries series;
        public YFunctionSeriesSample()
        {
            InitializeComponent();
            InitializeControls();

            InitializeChart();
        }

        void InitializeChart()
        {
            flexChart1.BeginUpdate();
            this.flexChart1.Stacking = C1.Chart.Stacking.None;
            series = new YFunctionSeries();
            series.SampleCount = 300;
            series.Min = -10;
            series.Max = 10;
            series.Name = "Y-Function Series";
            series.Function = Calculate;
            this.flexChart1.Series.Clear();
            this.flexChart1.Series.Add(series);
            flexChart1.EndUpdate();

        }
        private void InitializeControls()
        {
            //Set localized content
            baseSample1.lblTitle.Text = Localizer.GetItem("yfunction", "title");
            baseSample1.tbDescription.Rtf = Localizer.GetItem("yfunction", "description").MakeRtf();
            flexChart1 = baseSample1.flexChart1;
        }

        private double Calculate(double v)
        {
            return Math.Sin(4 * v) * Math.Cos(3 * v);
        }
    }

}
