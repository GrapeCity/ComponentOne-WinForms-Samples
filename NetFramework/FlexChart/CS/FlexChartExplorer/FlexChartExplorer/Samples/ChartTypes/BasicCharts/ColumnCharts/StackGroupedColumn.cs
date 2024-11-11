using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlexChartExplorer.Data;
using C1.Win.Chart;
using C1.Chart;
using BaseExplorer;
namespace FlexChartExplorer.Samples
{
    public partial class StackGroupedColumn : FlexChartBaseSample
    {
        private ComboBoxEx _cbStacking;
        private FlexChart flexChart1;

        public StackGroupedColumn()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Education Distribution";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = Demographics.GetPopulationEducation();
            this.flexChart1.BindingX = "Name";
            this.flexChart1.Stacking = Stacking.Stacked100pc;
            this.flexChart1.AxisX.AxisLine = false;

            var iMalePop = new Series
            {
                Name = "Male",
                Binding = "IlliterateMale",
                StackingGroup = 0,
                LegendGroup = "Illiterate"
            };

            var iFemalePop = new Series
            {
                Name = "Female",
                Binding = "IlliterateFemale",
                StackingGroup = 0,
                LegendGroup = "Illiterate"
            };

            var malePop = new Series
            {
                Name = "Male",
                Binding = "EducatedMale",
                LegendGroup = "Literate",
                StackingGroup = 1,
            };

            var femalePop = new Series
            {
                Name = "Female",
                Binding = "EducatedFemale",
                LegendGroup = "Literate",
                StackingGroup = 1,
            };
            this.flexChart1.Series.Add(iMalePop);
            this.flexChart1.Series.Add(iFemalePop);
            this.flexChart1.Series.Add(malePop);
            this.flexChart1.Series.Add(femalePop);

            this.flexChart1.AxisY.Format = "P0";
            this.flexChart1.Legend.Position = Position.Right;

            this.flexChart1.Legend.GroupHeaderStyle.Font = StyleInfo.LegendGroupHeaderFont;
            this.flexChart1.ToolTip.Content = "{y:0}";
            this.flexChart1.Rendered += (s, e) => { _cbStacking.SelectedItem = flexChart1.Stacking; };
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            _cbStacking = ControlFactory.EnumBasedCombo(typeof(Stacking), "Stacking");
            _cbStacking.SelectedIndexChanged += (s, e) =>
            {
                flexChart1.Stacking = (Stacking)Enum.Parse(typeof(Stacking), _cbStacking.SelectedValue.ToString());
                flexChart1.AxisY.Format = flexChart1.Stacking == Stacking.Stacked100pc ? "p0" : "#,##0,,M";
            };
            this.pnlControls.Controls.Add(_cbStacking);
        }
    }
}
