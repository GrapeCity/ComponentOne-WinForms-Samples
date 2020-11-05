using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Chart;
using C1.Win.Chart;
using FlexChartExplorer.Data;
using BaseExplorer;

namespace FlexChartExplorer.Samples
{
    public partial class StepArea : FlexChartBaseSample
    {
        private ComboBox _cbStacking;
        private FlexChart flexChart1;

        public StepArea()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.StepArea;
            this.flexChart1.DataSource = DataService.GetGamesInfo();
            this.flexChart1.BindingX = "Year";
            var won = new Series()
            {
                Name = "Won",
                Binding = "Won",
            };
            var lost = new Series()
            {
                Name = "Lost",
                Binding = "Lost",
            };
            
            this.flexChart1.Series.Add(won);
            this.flexChart1.Series.Add(lost);
            this.flexChart1.ToolTip.Content = "W = {Won}, L = {Lost}";
            this.flexChart1.Header.Content = "Brazil at the FIFA World Cup";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.Stacking = Stacking.Stacked;
            this.flexChart1.AxisY.Title = "No. of Matches";
            this.flexChart1.AxisY.TitleStyle.Font = StyleInfo.AxisTitleFont;
            this.flexChart1.Rendered += (s, e) => { _cbStacking.SelectedItem = flexChart1.Stacking; };
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;

            //Init Stacking ComboBox
            _cbStacking = ControlFactory.EnumBasedCombo(typeof(Stacking), "Stacking");
            _cbStacking.SelectedIndexChanged += (s, e) =>
            {
                flexChart1.Stacking = (Stacking)Enum.Parse(typeof(Stacking), _cbStacking.SelectedItem.ToString());
                flexChart1.AxisY.Format = flexChart1.Stacking == Stacking.Stacked100pc ? "p0" : "0";
            };

            this.pnlControls.Controls.Add(_cbStacking);
        }
    }
}
