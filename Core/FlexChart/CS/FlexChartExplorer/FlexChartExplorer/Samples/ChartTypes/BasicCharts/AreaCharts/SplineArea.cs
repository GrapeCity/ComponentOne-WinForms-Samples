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
    public partial class SplineArea : FlexChartBaseSample
    {
        private ComboBoxEx _cbStacking;
        private FlexChart flexChart1;
        private LabelEx _lblStacking;

        public SplineArea()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.SplineArea;
            this.flexChart1.DataSource = SalesDataSource.GetUnitSalesInfo();
            this.flexChart1.BindingX = "Date";
            var Food = new Series()
            {
                Name = "Food",
                Binding = "Food",
            };
            var Drink = new Series()
            {
                Name = "Drink",
                Binding = "Drink",
            };
            var NonConsumable = new Series()
            {
                Name = "Non-Consumable",
                Binding = "NonConsumable",
            };

            this.flexChart1.Series.Add(Food);
            this.flexChart1.Series.Add(Drink);
            this.flexChart1.Series.Add(NonConsumable);

            this.flexChart1.ToolTip.Content = "{y:0}";
            this.flexChart1.Header.Content = "Daily Sales";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            this.flexChart1.AxisY.Title = "Number of Units";
            this.flexChart1.AxisY.TitleStyle.Font = StyleInfo.AxisTitleFont;
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;

            _lblStacking = new LabelEx("Stacking");

            //Init Stacking ComboBox
            _cbStacking = ControlFactory.EnumBasedCombo(typeof(Stacking), "Stacking");
            _cbStacking.SelectedIndexChanged += (s, e) =>
            {
                flexChart1.Stacking = (Stacking)Enum.Parse(typeof(Stacking), _cbStacking.SelectedItem.DisplayText);
                flexChart1.AxisY.Format = flexChart1.Stacking == Stacking.Stacked100pc ? "p0" : "0";
            };

            this.pnlControls.Controls.Add(_lblStacking);
            this.pnlControls.Controls.Add(_cbStacking);
        }
    }
}
