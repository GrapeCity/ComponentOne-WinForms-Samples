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
    public partial class SunburstSelection : FlexChartBaseSample
    {
        private LabelEx _lOffset;
        private NumericUpDownEx _udOffset;
        private ComboBoxEx _cbSelItemPos;
        public SunburstSelection()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var sunburst = this.Chart as C1.Win.Chart.Sunburst;
            sunburst.Binding = "Value";
            sunburst.BindingName = "Year,Quarter,Month";
            sunburst.ChildItemsPath = "Items";
            sunburst.DataLabel.Position = PieLabelPosition.Center;
            sunburst.DataLabel.Content = "{name}";
            sunburst.ToolTip.Content = "{name} Sales : {value}\nShare : {P:0}%";
            sunburst.DataSource = HierarchicalDataSource.GetSunburstData();
            sunburst.SelectionMode = ChartSelectionMode.Point;
            sunburst.SelectedItemPosition = Position.Left;
            sunburst.SelectedItemOffset = 0.2;
            sunburst.SelectedIndex = 0;
            sunburst.Header.Content = "Sales over the years";
            sunburst.Header.Style.Font = StyleInfo.ChartHeaderFont;
            sunburst.Rendered += (s, e) => { _udOffset.Value = (decimal)sunburst.SelectedItemOffset; };
        }
        protected override void InitializeControls()
        {            
            this.Chart = new C1.Win.Chart.Sunburst { Dock = DockStyle.Fill };

            //Selected Item Offset
            _lOffset = new LabelEx("Selected Item Offset");
            
            _udOffset = new NumericUpDownEx { Minimum = 0, Maximum = 1, Increment = (decimal)0.1, Value = 0, DecimalPlaces = 1 };
            _udOffset.ValueChanged += (s, e) => (this.Chart as C1.Win.Chart.Sunburst).SelectedItemOffset = (double)_udOffset.Value;

            //Selected Item Position
            _cbSelItemPos = ControlFactory.EnumBasedCombo(typeof(Position), "Selected Item Position");
            _cbSelItemPos.Width = 160;
            _cbSelItemPos.SelectedIndexChanged += (s, e) => (this.Chart as C1.Win.Chart.Sunburst).SelectedItemPosition = (Position)Enum.Parse(typeof(Position), _cbSelItemPos.SelectedItem.ToString());

            this.pnlControls.Controls.Add(_lOffset);
            this.pnlControls.Controls.Add(_udOffset);
            this.pnlControls.Controls.Add(_cbSelItemPos);
        }
    }
}
