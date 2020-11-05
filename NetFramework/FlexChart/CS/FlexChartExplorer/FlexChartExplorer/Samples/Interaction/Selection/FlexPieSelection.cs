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
using BaseExplorer;
using FlexChartExplorer.Data;
using System.IO;

namespace FlexChartExplorer.Samples
{
    public partial class FlexPieSelection : FlexChartBaseSample
    {
        private ComboBoxEx cbSelItemPos, cbSelItemOffset;
        public FlexPieSelection()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            var flexPie = this.Chart as FlexPie;
            flexPie.Header.Content = "Market share of automobile organizations";
            flexPie.Header.Style.Font = StyleInfo.ChartHeaderFont;
            flexPie.Binding = "Value";
            flexPie.BindingName = "Name";

            flexPie.DataLabel.Position = PieLabelPosition.Radial;
            flexPie.DataLabel.Content = "{name} : {p:0}%";
            flexPie.ToolTip.Content = "Units Sold : {value:n0}";

            //To enable slice's selection, set selection mode to point.
            flexPie.SelectionMode = ChartSelectionMode.Point;
            flexPie.SelectedIndex = 0;
            flexPie.SelectedItemOffset = 0.2;
            flexPie.SelectedItemPosition = Position.Left;
            flexPie.DataSource = SalesDataSource.GetCarSales();
            flexPie.Rendered += (s, e) => 
            {
                cbSelItemOffset.SelectedItem = flexPie.SelectedItemOffset;
            };
        }
        protected override void InitializeControls()
        {
            this.Chart = new FlexPie { Dock = DockStyle.Fill };
            
            cbSelItemPos = ControlFactory.EnumBasedCombo(typeof(Position), "Selected Item Position");
            cbSelItemPos.SelectedIndexChanged += (sender, eventArgs) => (this.Chart as FlexPie).SelectedItemPosition = (Position)Enum.Parse(typeof(Position),cbSelItemPos.SelectedItem.ToString());
            cbSelItemPos.Size = new Size(200, 21);
                        
            cbSelItemOffset = new ComboBoxEx("Selected Item Offset");
            cbSelItemOffset.DataSource = new double[] { 0, 0.2, 0.5, 0.8, 1 };
            cbSelItemOffset.SelectedIndexChanged += (sender, eventArgs) => (this.Chart as FlexPie).SelectedItemOffset = (double)cbSelItemOffset.SelectedItem;
            cbSelItemOffset.Size = new Size(200, 21);

            this.pnlControls.Controls.Add(cbSelItemPos);
            this.pnlControls.Controls.Add(cbSelItemOffset);
        }
    }
}
