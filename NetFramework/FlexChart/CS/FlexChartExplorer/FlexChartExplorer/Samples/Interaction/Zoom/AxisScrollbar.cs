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
using C1.Win.Chart.Interaction;
using FlexChartExplorer.Data;

namespace FlexChartExplorer.Samples
{
    public partial class AxisScrollbar : FlexChartBaseSample
    {
        C1.Win.Chart.Interaction.AxisScrollbar _horizontalScrollbar, _verticalScrollbar;
        private FlexChart flexChart1;

        public AxisScrollbar()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.Line;
            this.flexChart1.Header.Content = "Daily Price Movement";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            this.flexChart1.AxisX.AxisLine = false;

            this.flexChart1.DataSource = FinancialDataSource.GetQuotes(1000);
            this.flexChart1.BindingX = "Date";
            this.flexChart1.Series.Add(new Series { Binding = "High" });
            this.flexChart1.Rendering += (s, e) =>
            {
                if (_horizontalScrollbar != null && _verticalScrollbar != null)
                    return;
                _horizontalScrollbar = new C1.Win.Chart.Interaction.AxisScrollbar(flexChart1.AxisX);
                _horizontalScrollbar.UpperValue = _horizontalScrollbar.LowerValue + 150;

                _verticalScrollbar = new C1.Win.Chart.Interaction.AxisScrollbar(flexChart1.AxisY);
                _verticalScrollbar.ScrollButtonsVisible = false;
            };
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
        }
    }
}
