using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Win.Chart.Finance;

using FinancialChartExplorer.Services;
using C1.Win.Chart.Annotation;
using C1.Chart.Annotation;
using C1.Chart;

namespace FinancialChartExplorer.Samples
{
    public partial class EventAnnotations : UserControl
    {
        C1.Win.Chart.Interaction.RangeSelector rs;
        AnnotationLayer annotationLayer;
        List<Quote> data;

        public EventAnnotations()
        {
            InitializeComponent();
        }

        private void RangeSelector_Load(object sender, EventArgs e)
        {
            var dataService = DataService.GetService();
            data = dataService.GetSymbolData("box");

            financialChart1.BeginUpdate();
            financialChart1.BindingX = "date";
            financialChart1.Binding = "high,low,open,close,volume";
            financialChart1.ToolTip.Content = "Date: {date}\nOpen: {open}\nHigh: {high}\nLow: {low}\nClose: {close}";
            financialChart1.Series.Add(new FinancialSeries());
            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Candlestick;
            financialChart1.DataSource = data;
            financialChart1.EndUpdate();

            financialChart2.BeginUpdate();
            financialChart2.BindingX = "date";
            financialChart2.Binding = "high,low,open,close";
            financialChart2.Series.Add(new FinancialSeries());
            financialChart2.ChartType = C1.Chart.Finance.FinancialChartType.Candlestick;
            financialChart2.DataSource = data;
            financialChart2.ToolTip.Content = null;
            financialChart2.EndUpdate();

            financialChart2.Rendered += financialChart2_Rendered;
            SetupAnnotations();
        }

        private void SetupAnnotations()
        {
            annotationLayer = new AnnotationLayer(financialChart1);
            var dataService = DataService.GetService();
            var annotations = dataService.GetAnnotations("box-annotations");
            foreach (var anno in annotations)
            {
                var rectangle = new C1.Win.Chart.Annotation.Rectangle()
                {
                    Content = "E",
                    Width = 20,
                    Height = 20,
                    Attachment = AnnotationAttachment.DataIndex,
                    PointIndex = anno.DataIndex,
                    TooltipText = anno.Description == null ?anno.Title : (anno.Title + "\n" + anno.Description)
                };
                rectangle.ContentStyle.StrokeColor = Color.White;
                rectangle.ContentStyle.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);
                rectangle.Style.FillColor = Color.FromArgb(180, Color.Blue);
                rectangle.Style.StrokeColor = Color.Black;
                rectangle.Style.StrokeWidth = 1;
                annotationLayer.Annotations.Add(rectangle);
            }
        }

        void financialChart2_Rendered(object sender, C1.Win.Chart.RenderEventArgs e)
        {
            if (rs == null && financialChart2.AxisX.ActualMin != financialChart2.AxisX.ActualMax)
            {
                rs = new C1.Win.Chart.Interaction.RangeSelector(financialChart2);
                rs.ValueChanged += rs_ValueChanged;
                var axis = financialChart2.AxisX as IAxis;
                var min = axis.GetMin();
                var max = axis.GetMax();
                var range = DataService.GetService().FindApproxRange(min, max, 0.45);
                rs.LowerValue = range.Min;
                rs.UpperValue = range.Max;
            }
        }

        void rs_ValueChanged(object sender, EventArgs e)
        {
            var yRange = DataService.GetService().FindRenderedYRange(data, rs.LowerValue, rs.UpperValue);
            financialChart1.BeginUpdate();
            financialChart1.AxisX.Min = rs.LowerValue;
            financialChart1.AxisX.Max = rs.UpperValue;
            financialChart1.AxisY.Min = yRange.Min;
            financialChart1.AxisY.Max = yRange.Max;
            financialChart1.EndUpdate();
        
        }
    }
}
