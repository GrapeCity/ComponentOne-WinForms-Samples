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
    public partial class StackedArea : FlexChartBaseSample
    {
        private ComboBoxEx _cbStacking;
        private FlexChart flexChart1;

        public StackedArea()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.Area;
            this.flexChart1.DataSource = DataService.GetEnergyConsumptionData();
            this.flexChart1.BindingX = "Year";

            var petroleum = new Series(){ Name = "Petroleum",Binding = "Petroleum"};
            var naturalgas = new Series{Name = "NaturalGas", Binding = "NaturalGas"};
            var coal = new Series { Name = "Coal", Binding = "Coal" };
            var renewable = new Series { Name = "Renewable", Binding = "Renewable" };
            var nuclear = new Series { Name = "Nuclear", Binding = "Nuclear" };

            this.flexChart1.Series.Add(petroleum);
            this.flexChart1.Series.Add(naturalgas);
            this.flexChart1.Series.Add(coal);
            this.flexChart1.Series.Add(renewable);
            this.flexChart1.Series.Add(nuclear);

            this.flexChart1.Stacking = Stacking.Stacked;
            this.flexChart1.AxisY.Format = "P0";
            this.flexChart1.Header.Content = "USA : Major Energy Consumption over the Years";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            this.flexChart1.Rendered += (e, s) => { _cbStacking.SelectedItem = flexChart1.Stacking; };
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
            };

            this.pnlControls.Controls.Add(_cbStacking);
        }
    }
}
