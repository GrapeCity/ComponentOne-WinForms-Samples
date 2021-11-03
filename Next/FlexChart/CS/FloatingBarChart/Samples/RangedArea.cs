using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.Chart;
using C1.Chart;
using System;

namespace FloatingBarChart.Samples
{
    public partial class RangedArea : UserControl
    {
        static List<SubjectScoreRange> scoreRanges = SubjectScoreRanges();
        Series seriesA, seriesB;
        float columnWidthPercentage = 0.6f;

        public RangedArea()
        {
            InitializeComponent();
            InitializeControls();
            SetupChart();
        }

        void SetupChart()
        {
            flexChart1.BeginUpdate();

            flexChart1.Series.Clear();
            flexChart1.DataSource = scoreRanges;
            flexChart1.BindingX = "Name";

            flexChart1.Header.Style.Font = new Font(FontFamily.GenericSansSerif, 15);
            flexChart1.Header.Content = "Subject Score Range";
            seriesA = new Series();
            seriesA.Binding = "ClassALow,ClassAHigh";
            seriesA.Name = "Class A";
            seriesB = new Series();
            seriesB.Binding = "ClassBLow,ClassBHigh";
            seriesB.Name = "Class B";
            flexChart1.ChartType = ChartType.Area;
            flexChart1.Series.Add(seriesA);
            flexChart1.Series.Add(seriesB);
            flexChart1.LabelRendering += LabelRendering;
            flexChart1.AxisY.MajorUnit = 10;
            flexChart1.ToolTip.Active = false;

            flexChart1.Options.ClusterSize = new ElementSize() { SizeType = ElementSizeType.Percentage, Value = columnWidthPercentage * 100 };
            flexChart1.EndUpdate();
        }

        private void LabelRendering(object sender, RenderDataLabelEventArgs e)
        {
            SubjectScoreRange range = (SubjectScoreRange)e.Item;
            e.Text = e.Text.Equals("Class A") ? range.ClassALow + " - " + range.ClassAHigh : range.ClassBLow + " - " + range.ClassBHigh;
        }

        private void InitializeControls()
        {
            //Set localized content
            baseSample1.lblTitle.Text = Localizer.GetItem("rangedarea", "title");
            baseSample1.tbDescription.Rtf = Localizer.GetItem("rangedarea", "description").MakeRtf();
            flexChart1 = baseSample1.flexChart1;
        }

        private static List<SubjectScoreRange> SubjectScoreRanges()
        {
            var ranges = new List<SubjectScoreRange>();
            ranges.Add(new SubjectScoreRange() { Name = "English", ClassAHigh = 99, ClassALow = 56, ClassBHigh = 96, ClassBLow = 67 });
            ranges.Add(new SubjectScoreRange() { Name = "Mathematics", ClassAHigh = 100, ClassALow = 75, ClassBHigh = 98, ClassBLow = 65 });
            ranges.Add(new SubjectScoreRange() { Name = "Reading", ClassAHigh = 91, ClassALow = 32, ClassBHigh = 96, ClassBLow = 67 });
            ranges.Add(new SubjectScoreRange() { Name = "Science", ClassAHigh = 85, ClassALow = 21, ClassBHigh = 92, ClassBLow = 51 });
            ranges.Add(new SubjectScoreRange() { Name = "Writing", ClassAHigh = 92, ClassALow = 47, ClassBHigh = 95, ClassBLow = 61 });
            return ranges;
        }

        public class SubjectScoreRange
        {
            public string Name { get; set; }
            public int ClassAHigh { get; set; }
            public int ClassALow { get; set; }
            public int ClassBHigh { get; set; }
            public int ClassBLow { get; set; }
            public string ClassName { get; set; }
        }
    }

    

}
