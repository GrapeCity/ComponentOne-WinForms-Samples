using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FlexChartExplorer.Data;
using C1.Chart;
using C1.Win.Chart;
using BaseExplorer;
namespace FlexChartExplorer.Samples
{
    public partial class StackedColumn : FlexChartBaseSample
    {
        private ComboBoxEx _cbStacking;
        private LabelEx _lblStacking;
        private FlexChart flexChart1;

        public StackedColumn()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Population Share";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = Demographics.GetPopulationEducation();
            this.flexChart1.BindingX = "Name";
            this.flexChart1.Series.Add(new Series { Name = "Male", Binding = "MalePopulation" });
            this.flexChart1.Series.Add(new Series { Name = "Female", Binding = "FemalePopulation" });

            this.flexChart1.AxisY.Format = "#,##0,,M";
            this.flexChart1.Stacking = Stacking.Stacked;
            this.flexChart1.ToolTip.Content = "{y:0}";
            this.flexChart1.Rendered += (s, e) => 
            {
                _cbStacking.SelectedIndex = (int)this.flexChart1.Stacking;
            };
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;

            _lblStacking = new LabelEx("Stacking:");
            
            _cbStacking = ControlFactory.EnumBasedCombo(typeof(Stacking), "Stacking");
            _cbStacking.SelectedIndexChanged += (s, e) => 
            {
                this.flexChart1.Stacking = (Stacking)Enum.Parse(typeof(Stacking), _cbStacking.SelectedItem.DisplayText);
                this.flexChart1.AxisY.Format = flexChart1.Stacking == Stacking.Stacked100pc ? "p0" : "0";
            };

            this.pnlControls.Controls.Add(_lblStacking);
            this.pnlControls.Controls.Add(_cbStacking);
        }
    }
}
