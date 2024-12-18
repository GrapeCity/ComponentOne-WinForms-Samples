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
    public partial class Palettes : FlexChartBaseSample
    {
        ComboBoxEx _cbChartType, _cbPaletes;
        LabelEx _lblChartType, _lblPaletes;
        Brush[] _customPalette = new Brush[] { Brushes.Blue, Brushes.Green, Brushes.Maroon, Brushes.Yellow, Brushes.Pink, Brushes.Violet, Brushes.Orange, Brushes.SandyBrown, Brushes.Silver};
        private FlexChart flexChart1;

        public Palettes()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            flexChart1.Header.Content = "Internet Gaining Relevance as News Source";
            flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            flexChart1.ChartType = ChartType.Line;
            this.flexChart1.DataSource = DataService.GetNewsSourcesInfo();
            this.flexChart1.BindingX = "Year";

            this.flexChart1.Series.Add(new Series { Name="TV", Binding="TV"});
            this.flexChart1.Series.Add(new Series { Name = "Newspaper", Binding = "Newspaper" });
            this.flexChart1.Series.Add(new Series { Name = "Internet", Binding = "Internet" });

            this.flexChart1.AxisY.Format = "p0";
            this.flexChart1.CustomPalette = _customPalette;
            string chartType = flexChart1.ChartType.ToString();
            C1.Win.Input.ComboBoxItem selectedItem = _cbChartType.Items[0];
            foreach (var item in _cbChartType.Items)
            {
                if (item.DisplayText == chartType)
                {
                    selectedItem = item;
                    break;
                }
            }
            this.flexChart1.Rendered += (s, e) => { _cbChartType.SelectedItem = selectedItem; };
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _cbChartType = ChartControlFactory.BasicChartTypesCombo();
            _cbChartType.SelectedIndexChanged += (s, e) => 
            {
                flexChart1.ChartType = (ChartType)Enum.Parse(typeof(ChartType), _cbChartType.SelectedItem.DisplayText);
                if(flexChart1.ChartType == ChartType.Bar)
                {
                    flexChart1.AxisX.Format = "p0";
                    flexChart1.AxisY.Format = "0";
                }
                else
                {
                    flexChart1.AxisY.Format = "p0";
                    flexChart1.AxisX.Format = "0";
                }
            };

            _cbPaletes = ControlFactory.EnumBasedCombo(typeof(Palette), "Palette");
            _cbPaletes.SelectedIndexChanged += (s, e) => { flexChart1.Palette = (Palette)Enum.Parse(typeof(Palette), _cbPaletes.SelectedItem.DisplayText); };

            _lblChartType = new LabelEx("ChartType:");
            _lblPaletes = new LabelEx("Palette:");

            this.pnlControls.Controls.Add(_lblPaletes);
            this.pnlControls.Controls.Add(_cbPaletes);
            this.pnlControls.Controls.Add(_lblChartType);
            this.pnlControls.Controls.Add(_cbChartType);
        }
    }
}
