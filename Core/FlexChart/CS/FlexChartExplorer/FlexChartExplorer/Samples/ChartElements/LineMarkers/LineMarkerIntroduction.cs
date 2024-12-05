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
using C1.Win.Chart.Interaction;
using FlexChartExplorer.Data;
using BaseExplorer;

namespace FlexChartExplorer.Samples
{
    public partial class LineMarkerIntroduction : FlexChartBaseSample
    {
        private LineMarker _lineMarker;
        private ComboBoxEx _cbLine, _cbInteraction, _cbAlignment;
        private FlexChart flexChart1;

        public LineMarkerIntroduction()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Daily Price Movement";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.BindingX = "Date";
            this.flexChart1.ChartType = ChartType.Line;

            var high = new Series { Binding = "High", Name="High"};
            var low = new Series { Binding = "Low", Name = "Low" };
            
            this.flexChart1.Series.Add(high);
            this.flexChart1.Series.Add(low);

            this.flexChart1.AxisY.Format = "c0";
            this.flexChart1.Rendering += FlexChart1_Rendering;
            this.flexChart1.DataSource = FinancialDataSource.GetQuotes();
        }
        
        private void FlexChart1_Rendering(object sender, RenderEventArgs e)
        {
            if (_lineMarker == null)
            {
                _lineMarker = new LineMarker(this.flexChart1)
                {
                    LineWidth = 2,
                    DragThreshold = 10,
                    Content = "High : {High:c}\nLow : {Low:c}",
                    HorizontalPosition = 0.5, VerticalPosition = 0.5,
                };
                _cbInteraction.SelectedItem = _lineMarker.Interaction;
                _cbLine.SelectedItem = _lineMarker.Lines;
            }
        }

        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _cbLine = ControlFactory.EnumBasedCombo(typeof(LineMarkerLines), "Lines");
            _cbLine.SelectedIndexChanged += (s, e) => { _lineMarker.Lines = (LineMarkerLines)Enum.Parse(typeof(LineMarkerLines), _cbLine.SelectedItem.ToString()); };
            this.pnlControls.Controls.Add(_cbLine);

            _cbInteraction = ControlFactory.EnumBasedCombo(typeof(LineMarkerInteraction), "Interaction");
            _cbInteraction.SelectedIndexChanged += (s, e) => 
            {
                _lineMarker.Interaction = (LineMarkerInteraction)Enum.Parse(typeof(LineMarkerInteraction), _cbInteraction.SelectedItem.ToString());
                if(_lineMarker.Interaction == LineMarkerInteraction.Drag)
                    _lineMarker.HorizontalPosition = _lineMarker.VerticalPosition = double.NaN;
            };
            this.pnlControls.Controls.Add(_cbInteraction);

            _cbAlignment = ControlFactory.EnumBasedCombo(typeof(LineMarkerAlignment), "Alignment");
            _cbAlignment.SelectedIndexChanged += (s, e) => { _lineMarker.Alignment = (LineMarkerAlignment)Enum.Parse(typeof(LineMarkerAlignment), _cbAlignment.SelectedItem.ToString()); };
            this.pnlControls.Controls.Add(_cbAlignment);
        }
    }
}
