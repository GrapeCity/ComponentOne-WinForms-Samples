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
using BaseExplorer;
using FlexChartExplorer.Data;
using C1.Win.Input;

namespace FlexChartExplorer.Samples
{
    public partial class CartesianChartSelection : FlexChartBaseSample
    {
        private ComboBoxEx _cbSelectionMode, _cbChartType;
        private LabelEx _lblSelectionMode, _lblChartType;
        private FlexChart flexChart1;

        public CartesianChartSelection()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Sales vs Expenses";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = SalesDataSource.GetCountrySales();
            this.flexChart1.BindingX = "Name";

            this.flexChart1.Series.Add(new Series { Name = "Sales", Binding = "Sales" });
            this.flexChart1.Series.Add(new Series { Name = "Expenses", Binding = "Expenses" });

            this.flexChart1.SelectedSeries = flexChart1.Series[1];
            this.flexChart1.SelectedIndex = 2;
            this.flexChart1.SelectionMode = ChartSelectionMode.Point;
            this.flexChart1.SelectionStyle.StrokeWidth = 2;
            this.flexChart1.Rendered += (s, e) => { _cbSelectionMode.SelectedIndex = (int)flexChart1.SelectionMode; };
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _cbChartType = ChartControlFactory.BasicChartTypesCombo();
            _cbChartType.SelectedIndexChanged += (s, e) => { flexChart1.ChartType = (ChartType)Enum.Parse(typeof(ChartType), _cbChartType.SelectedItem.DisplayText); };

            _cbSelectionMode = ControlFactory.EnumBasedCombo(typeof(ChartSelectionMode), "Selection Mode");
            _cbSelectionMode.SelectedIndexChanged += (s, e) => { flexChart1.SelectionMode = (ChartSelectionMode)Enum.Parse(typeof(ChartSelectionMode), _cbSelectionMode.SelectedItem.DisplayText); };

            _lblSelectionMode = new LabelEx("Selection Mode:");
            _lblChartType = new LabelEx("Chart Type:");

            this.pnlControls.Controls.Add(_lblChartType);
            this.pnlControls.Controls.Add(_cbChartType);
            this.pnlControls.Controls.Add(_lblSelectionMode);
            this.pnlControls.Controls.Add(_cbSelectionMode);
        }
    }
}
