using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.Chart;
using C1.Chart;

namespace FlexChartCustomization.Samples
{
    public partial class LegendRanges : UserControl
    {
        static List<TemperatureRecord> records = USStatesTemperatureRecords();
        public LegendRanges()
        {
            InitializeComponent();
            InitializeControls();
            SetupChart();       
        }

        void SetupChart()
        {
            flexChart1.BeginUpdate();
            flexChart1.Series.Clear();
            flexChart1.DataSource = records;
            flexChart1.BindingX = "Place";
            flexChart1.Binding = "High";
            flexChart1.ChartType = ChartType.Scatter;
            flexChart1.Header.Style.Font = new Font(FontFamily.GenericSansSerif, 15);
            flexChart1.Header.Content = "U.S. State Record High Temperature";
            flexChart1.AxisY.Min = 95;
            flexChart1.AxisY.Format = "#°F";
            var recordsSeries = new SeriesWithPointLegendItems();
            recordsSeries.SymbolRendering += RecordsSeries_SymbolRendering;
            flexChart1.Series.Add(recordsSeries);
            
            flexChart1.ToolTip.Content = "{x}\r\n{value}";
            flexChart1.EndUpdate();
        }
        
        private void RecordsSeries_SymbolRendering(object sender, RenderSymbolEventArgs e)
        {
            int idx = (((TemperatureRecord)e.Item).High - 95) / 5;
            e.Engine.SetFill(new SolidBrush(GetTempartureRangeColor(idx)));
            e.Engine.SetStroke(new SolidBrush(GetTempartureRangeColor(idx)));
        }

        private void InitializeControls()
        {
            //Set localized content
            baseSample1.lblTitle.Text = Localizer.GetItem("legendranges", "title");
            baseSample1.tbDescription.Rtf = Localizer.GetItem("legendranges", "description").MakeRtf();
            baseSample1.pScroll.Controls.Remove(baseSample1.pControls);
            flexChart1 = baseSample1.flexChart1;
        }

        public class SeriesWithPointLegendItems : Series, ISeries
        {
            /// <summary>
            /// Gets the name of legend.
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            string ISeries.GetLegendItemName(int index)
            {
                int low = 95 + 5 * index;
                return low + " to " + (low + 5);
            }

            /// <summary>
            /// Gets the style of legend.
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            _Style ISeries.GetLegendItemStyle(int index)
            {
                return new _Style { Fill = new SolidBrush(GetTempartureRangeColor(index)) };
            }

            /// <summary>
            /// Get the number of series items in the legend.
            /// </summary>
            int ISeries.GetLegendItemLength() { return 8; }
        }

        private static List<TemperatureRecord> USStatesTemperatureRecords()
        {
            List<TemperatureRecord> records = new List<TemperatureRecord>();
            records.Add(new TemperatureRecord() { Place = "Alabama", High = 112 });
            records.Add(new TemperatureRecord() { Place = "Alaska", High = 100 });
            records.Add(new TemperatureRecord() { Place = "Arizona", High = 128 });
            records.Add(new TemperatureRecord() { Place = "Arkansas", High = 120 });
            records.Add(new TemperatureRecord() { Place = "California", High = 134 });
            records.Add(new TemperatureRecord() { Place = "Colorado", High = 114 });
            records.Add(new TemperatureRecord() { Place = "Connecticut", High = 106 });
            records.Add(new TemperatureRecord() { Place = "Delaware", High = 110 });
            records.Add(new TemperatureRecord() { Place = "District of Columbia", High = 106 });
            records.Add(new TemperatureRecord() { Place = "Florida", High = 109 });
            records.Add(new TemperatureRecord() { Place = "Georgia", High = 112 });
            records.Add(new TemperatureRecord() { Place = "Hawaii", High = 98 });
            records.Add(new TemperatureRecord() { Place = "Idaho", High = 118 });
            records.Add(new TemperatureRecord() { Place = "Illinois", High = 117 });
            records.Add(new TemperatureRecord() { Place = "Indiana", High = 116 });
            records.Add(new TemperatureRecord() { Place = "Iowa", High = 118 });
            records.Add(new TemperatureRecord() { Place = "Kansas", High = 121 });
            records.Add(new TemperatureRecord() { Place = "Kentucky", High = 114 });
            records.Add(new TemperatureRecord() { Place = "Louisiana", High = 114 });
            records.Add(new TemperatureRecord() { Place = "Maine", High = 105 });
            records.Add(new TemperatureRecord() { Place = "Maryland", High = 109 });
            records.Add(new TemperatureRecord() { Place = "Massachusetts", High = 107 });
            records.Add(new TemperatureRecord() { Place = "Michigan", High = 112 });
            records.Add(new TemperatureRecord() { Place = "Minnesota", High = 115 });
            records.Add(new TemperatureRecord() { Place = "Mississippi", High = 115 });
            records.Add(new TemperatureRecord() { Place = "Missouri", High = 118 });
            records.Add(new TemperatureRecord() { Place = "Montana", High = 117 });
            records.Add(new TemperatureRecord() { Place = "Nebraska", High = 118 });
            records.Add(new TemperatureRecord() { Place = "Nevada", High = 125 });
            records.Add(new TemperatureRecord() { Place = "New Hampshire", High = 106 });
            records.Add(new TemperatureRecord() { Place = "New Jersey", High = 110 });
            records.Add(new TemperatureRecord() { Place = "New Mexico", High = 122 });
            records.Add(new TemperatureRecord() { Place = "New York", High = 109 });
            records.Add(new TemperatureRecord() { Place = "North Carolina", High = 110 });
            records.Add(new TemperatureRecord() { Place = "North Dakota", High = 121 });
            records.Add(new TemperatureRecord() { Place = "Ohio", High = 113 });
            records.Add(new TemperatureRecord() { Place = "Oklahoma", High = 120 });
            records.Add(new TemperatureRecord() { Place = "Oregon", High = 117 });
            records.Add(new TemperatureRecord() { Place = "Pennsylvania", High = 111 });
            records.Add(new TemperatureRecord() { Place = "Rhode Island", High = 104 });
            records.Add(new TemperatureRecord() { Place = "South Carolina", High = 113 });
            records.Add(new TemperatureRecord() { Place = "South Dakota", High = 120 });
            records.Add(new TemperatureRecord() { Place = "Tennessee", High = 113 });
            records.Add(new TemperatureRecord() { Place = "Texas", High = 120 });
            records.Add(new TemperatureRecord() { Place = "Utah", High = 117 });
            records.Add(new TemperatureRecord() { Place = "Vermont", High = 105 });
            records.Add(new TemperatureRecord() { Place = "Virginia", High = 110 });
            records.Add(new TemperatureRecord() { Place = "Washington", High = 118 });
            records.Add(new TemperatureRecord() { Place = "West Virginia", High = 112 });
            records.Add(new TemperatureRecord() { Place = "Wisconsin", High = 114 });
            records.Add(new TemperatureRecord() { Place = "Wyoming", High = 115 });
            return records;
        }

        private static readonly Color[] GradientRedColors = 
        {
                Color.FromArgb(254, 224, 232),
                Color.FromArgb(252, 173, 193),
                Color.FromArgb(251, 121, 154),
                Color.FromArgb(249, 70, 115),
                Color.FromArgb(247, 19, 77),
                Color.FromArgb(205, 7, 57),
                Color.FromArgb(154, 5, 43),
                Color.FromArgb(103, 3, 29)
        };
        private static Color GetTempartureRangeColor(int index)
        {
            //return Color.FromArgb(80 + index * 20, Color.Red);
            return GradientRedColors[index];
        }
        public class TemperatureRecord
        {
            public string Place { get; set; }
            public int High { get; set; }
        }
    }
}
