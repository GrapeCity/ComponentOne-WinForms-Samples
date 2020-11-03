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

namespace FlexChartExplorer.Samples
{
    public partial class Palettes : FlexChartBaseSample
    {
        ComboBoxEx _cbPalletes, _cbChartType;
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
            this.flexChart1.Rendered += (s, e) => { _cbChartType.SelectedItem = flexChart1.ChartType.ToString(); };
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _cbChartType = ChartControlFactory.BasicChartTypesCombo();
            _cbChartType.SelectedIndexChanged += (s, e) => 
            {
                flexChart1.ChartType = (ChartType)Enum.Parse(typeof(ChartType), _cbChartType.SelectedItem.ToString());
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

            _cbPalletes = ControlFactory.EnumBasedCombo(typeof(Palette), "Palette");
            _cbPalletes.SelectedIndexChanged += (s, e) => { flexChart1.Palette = (Palette)Enum.Parse(typeof(Palette), _cbPalletes.SelectedItem.ToString()); };

            this.pnlControls.Controls.Add(_cbPalletes);
            this.pnlControls.Controls.Add(_cbChartType);
        }
    }
}
