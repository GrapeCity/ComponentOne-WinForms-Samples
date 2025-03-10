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
    public partial class AxisLabels : FlexChartBaseSample
    {
        private LabelEx _lStaggeredLines;
        private ComboBoxEx _cbOverlapping;
        private LabelEx _lblOverlapping;
        private NumericUpDownEx _udStaggeredLines;
        private FlexChart flexChart1;

        public AxisLabels()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "World GDP";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = DataService.GetCountriesGDP();
            this.flexChart1.BindingX = "Name";
            this.flexChart1.Binding = "Value";
            this.flexChart1.Series.Add(new Series());

            this.flexChart1.AxisY.Format = "#,,";
            this.flexChart1.AxisY.Title = "GDP, trillion($)";
            this.flexChart1.AxisY.TitleStyle.Font = StyleInfo.AxisTitleFont;
            this.flexChart1.AxisX.StaggeredLines = 2;
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _lStaggeredLines = new LabelEx("Staggered Lines :");
            _udStaggeredLines = new NumericUpDownEx { Minimum = 1, Maximum = 4, Value = 2 };
            _udStaggeredLines.ValueChanged += (s, e) => { flexChart1.AxisX.StaggeredLines = Convert.ToInt32(_udStaggeredLines.Value); };

            _cbOverlapping = ControlFactory.EnumBasedCombo(typeof(OverlappingLabels), "Overlapping");
            _cbOverlapping.SelectedIndexChanged += (s, e) => { flexChart1.AxisX.OverlappingLabels = (OverlappingLabels)Enum.Parse(typeof(OverlappingLabels), _cbOverlapping.SelectedItem.DisplayText); };

            _lblOverlapping = new LabelEx("Overlapping:");

            this.pnlControls.Controls.Add(_lStaggeredLines);
            this.pnlControls.Controls.Add(_udStaggeredLines);
            this.pnlControls.Controls.Add(_lblOverlapping);
            this.pnlControls.Controls.Add(_cbOverlapping);
        }
    }
}
