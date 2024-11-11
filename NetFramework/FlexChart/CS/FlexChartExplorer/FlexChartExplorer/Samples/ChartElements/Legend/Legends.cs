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
using System.IO;

namespace FlexChartExplorer.Samples
{
    public partial class Legends : FlexChartBaseSample
    {
        private ComboBoxEx _cbPosition, _cbOrientation, _cbTextWrapping, _cbMaxWidth;
        private FlexChart flexChart1;

        public Legends()
        {
            InitializeComponent();
        }

        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Education Distribution";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = Demographics.GetPopulationEducation();
            this.flexChart1.BindingX = "Name";

            this.flexChart1.Series.Add(new Series { Name = "Total Population", Binding = "TotalPopulation" });
            this.flexChart1.Series.Add(new Series { Name = "Educated Population", Binding = "EducatedPopulation" });

            this.flexChart1.AxisY.Format = "#,##0,,M";
            this.flexChart1.ToolTip.Content = "{y:0}";
            this.flexChart1.Legend.ItemMaxWidth = 50;
            this.flexChart1.Rendered += (s, e) => { _cbPosition.SelectedItem = flexChart1.Legend.Position; };
            this.flexChart1.AxisX.AxisLine = false;
        }

        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _cbPosition = ControlFactory.EnumBasedCombo(typeof(Position), "Position");
            _cbPosition.SelectedIndexChanged += (s, e) => { flexChart1.Legend.Position = (Position)Enum.Parse(typeof(Position), _cbPosition.SelectedValue.ToString()); };

            _cbOrientation = ControlFactory.EnumBasedCombo(typeof(C1.Chart.Orientation), "Orientation");
            _cbOrientation.SelectedIndexChanged += (s, e) => { flexChart1.Legend.Orientation = (C1.Chart.Orientation)Enum.Parse(typeof(C1.Chart.Orientation), _cbOrientation.SelectedValue.ToString()); };

            _cbTextWrapping = ControlFactory.EnumBasedCombo(typeof(TextWrapping), "Text Wrapping");
            _cbTextWrapping.SelectedIndexChanged += (s, e) => { flexChart1.Legend.TextWrapping = (TextWrapping)Enum.Parse(typeof(TextWrapping), _cbTextWrapping.SelectedValue.ToString()); };

            _cbMaxWidth = new ComboBoxEx("Max Width") { DisplayMember="Name", ValueMember="Value"};
            _cbMaxWidth.DataSource = new ComboBoxItem[]
            {
                new ComboBoxItem{Name="Narrow", Value=50},
                new ComboBoxItem{Name="Middle", Value=100},
                new ComboBoxItem{Name="Wide", Value=150},
            };
            _cbMaxWidth.SelectedIndexChanged += (s, e) => { flexChart1.Legend.ItemMaxWidth = (int)(_cbMaxWidth.SelectedValue); };
            
            this.pnlControls.Controls.Add(_cbPosition);
            this.pnlControls.Controls.Add(_cbOrientation);
            this.pnlControls.Controls.Add(_cbTextWrapping);
            this.pnlControls.Controls.Add(_cbMaxWidth);
        }
    }
    public class ComboBoxItem
    {
        public string Name { get; set; }
        public object Value { get; set; }
    }
}
