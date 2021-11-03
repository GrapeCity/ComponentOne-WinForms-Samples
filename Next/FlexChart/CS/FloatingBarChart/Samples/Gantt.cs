using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using C1.Win.Chart;
using C1.Chart;

namespace FloatingBarChart.Samples
{
    public partial class Gantt : UserControl
    {
        static List<Phase> releasePhases = ReleasePhases();
        Series customSeries;
        public Gantt()
        {
            InitializeComponent();
            InitializeControls();
            SetupChart();
        }

        void SetupChart()
        {
            flexChart1.BeginUpdate();

            flexChart1.Series.Clear();
            flexChart1.DataSource = releasePhases;
            flexChart1.ChartType = ChartType.Bar;
            flexChart1.BindingX = "Name";
            flexChart1.Header.Style.Font = new Font(FontFamily.GenericSansSerif, 15);
            flexChart1.Header.Content = "Release Schedule";
            customSeries = new GanntSeriesWithPointLegendItems();
            customSeries.Name = "Phases";
            customSeries.Binding = "Start,End";
            customSeries.SymbolRendering += SymbolRendering;
            flexChart1.LabelRendering += LabelRendering;
            flexChart1.AxisX.MajorUnit = 1;
            flexChart1.AxisX.MajorGrid = true;
            flexChart1.AxisX.Format = "Week 0";
            flexChart1.Series.Add(customSeries);
            flexChart1.ToolTip.Content = "{x}";
            flexChart1.DataLabel.Position = LabelPosition.Left;
            flexChart1.DataLabel.Content = "Value";
            flexChart1.DataLabel.Style.Font = new Font(FontFamily.GenericSansSerif, 9);
            flexChart1.EndUpdate();
        }

        private void LabelRendering(object sender, RenderDataLabelEventArgs e)
        {
            var range = (Phase)e.Item;
            int duration = range.End - range.Start;
            e.Text = duration > 1 ? duration + " weeks" : "1 week";
        }

        private void SymbolRendering(object sender, RenderSymbolEventArgs e)
        {
            e.Engine.SetFill(new SolidBrush(releasePhases.ElementAt(e.Index).Color));
            e.Engine.SetStroke(new SolidBrush(Color.FromArgb(200, releasePhases.ElementAt(e.Index).Color)));
        }

        private void InitializeControls()
        {
            //Set localized content
            baseSample1.lblTitle.Text = Localizer.GetItem("gantt", "title");
            baseSample1.tbDescription.Rtf = Localizer.GetItem("gantt", "description").MakeRtf();
            flexChart1 = baseSample1.flexChart1;
        }

        public class GanntSeriesWithPointLegendItems : Series, ISeries
        {
            /// <summary>
            /// Gets the name of legend.
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            string ISeries.GetLegendItemName(int index) { return releasePhases.ElementAt(releasePhases.Count - 1 - index).Name; }

            /// <summary>
            /// Gets the style of legend.
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            _Style ISeries.GetLegendItemStyle(int index)
            {
                return new _Style { Fill = new SolidBrush(releasePhases.ElementAt(releasePhases.Count - 1 - index).Color) };
            }

            /// <summary>
            /// Get the number of series items in the legend.
            /// </summary>
            int ISeries.GetLegendItemLength() { return releasePhases.Count; }
        }

        private static List<Phase> ReleasePhases()
        {
            var phases = new List<Phase>();
            phases.Add(new Phase() { Name = "Distribute", End = 11, Start = 10, Color = Color.FromArgb(210, 192, 135) });
            phases.Add(new Phase() { Name = "Test, Accept", End = 10, Start = 8, Color = Color.FromArgb(248, 195, 217) });
            phases.Add(new Phase() { Name = "Development", End = 8, Start = 2, Color = Color.FromArgb(252, 201, 137) });
            phases.Add(new Phase() { Name = "Design", End = 2, Start = 1, Color = Color.FromArgb(177, 220, 182) });
            phases.Add(new Phase() { Name = "Plan", End = 1, Start = 0, Color = Color.FromArgb(171, 208, 237) });
            return phases;
        }

        public class Phase
        {
            public string Name { get; set; }
            public int End { get; set; }
            public int Start { get; set; }
            public Color Color { get; set; }
        }
    }
}
