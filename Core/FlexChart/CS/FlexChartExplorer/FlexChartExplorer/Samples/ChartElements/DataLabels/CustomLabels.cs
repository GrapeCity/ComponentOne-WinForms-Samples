using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlexChartExplorer.Data;
using C1.Win.Chart;
using BaseExplorer;
using FlexChartExplorer.Properties;

namespace FlexChartExplorer.Samples
{
    public partial class CustomLabels : FlexChartBaseSample
    {
        private CheckBoxEx _chblabelBorder;
        private LabelEx _lLabelsGap;
        private NumericUpDownEx _udLabelsGap;
        private FlexChart flexChart1;
        public CustomLabels()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Daily High Prices";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            this.flexChart1.ChartType = C1.Chart.ChartType.LineSymbols;

            this.flexChart1.DataSource = FinancialDataSource.GetQuotes(100).OrderBy(x=>x.Date);
            this.flexChart1.BindingX = "Date";
            var high = new Series { Name = "High Price", Binding = "High" };
            this.flexChart1.Series.Add(high);
            
            this.flexChart1.DataLabel.Content ="{y}";
            this.flexChart1.DataLabel.Position = C1.Chart.LabelPosition.Center;
            this.flexChart1.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Show;
            this.flexChart1.LabelRendering += FlexChart1_LabelRendering;
        }

        private void FlexChart1_LabelRendering(object sender, RenderDataLabelEventArgs e)
        {
            if (e.Index % (_udLabelsGap.Value+1) != 0)
                e.Cancel = true;
        }

        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;

            _lLabelsGap = new LabelEx("DataLabels Gap :");
            _udLabelsGap = new NumericUpDownEx { Minimum = 0, Maximum=15, Increment =1, Value = 10};
            _udLabelsGap.ValueChanged += (s, e) => { flexChart1.Invalidate(); };

            _chblabelBorder = new CheckBoxEx("Label Border");
            _chblabelBorder.CheckedChanged += (s, e) => { this.flexChart1.DataLabel.Border = _chblabelBorder.Checked; };

            this.pnlControls.Controls.Add(_lLabelsGap);
            this.pnlControls.Controls.Add(_udLabelsGap);
            this.pnlControls.Controls.Add(_chblabelBorder);
        }
    }
}
