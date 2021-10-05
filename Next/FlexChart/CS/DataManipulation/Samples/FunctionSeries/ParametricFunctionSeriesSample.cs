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
    public partial class ParametricFunctionSeriesSample : UserControl
    {
        AggregateFilter _filter = new AggregateFilter();
        ParametricFunctionSeries series;
        public ParametricFunctionSeriesSample()
        {
            InitializeComponent();
            InitializeControls();

            InitializeChart();
        }

        void InitializeChart()
        {
            flexChart1.BeginUpdate();
            this.flexChart1.Stacking = C1.Chart.Stacking.None;
            series = new ParametricFunctionSeries();
            series.SampleCount = 1000;
            series.Max = 2 * Math.PI;
            series.Name = "Parametric Function Series";
            series.XFunction = CalculateX;
            series.YFunction = CalculateY;

            flexChart1.AxisX.Min = -1.5;
            flexChart1.AxisX.Max = 1.5;
            flexChart1.AxisX.MajorUnit = 0.2;

            this.flexChart1.Series.Clear();
            this.flexChart1.Series.Add(series);
            flexChart1.EndUpdate();

        }
        private void InitializeControls()
        {
            //Set localized content
            baseSample1.lblTitle.Text = Localizer.GetItem("parametricseries", "title");
            baseSample1.tbDescription.Rtf = Localizer.GetItem("parametricseries", "description").MakeRtf();
            flexChart1 = baseSample1.flexChart1;
        }

        private double CalculateX(double v)
        {
            return Math.Cos(5 * v);
        }

        private double CalculateY(double v)
        {
            return Math.Sin(7 * v);
        }
    }

}
