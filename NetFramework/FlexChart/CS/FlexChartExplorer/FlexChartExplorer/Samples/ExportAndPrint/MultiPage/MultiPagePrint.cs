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
using C1.Chart.Printing;

namespace FlexChartExplorer.Samples
{
    public partial class MultiPagePrint : FlexChartBaseSample
    {
        private ButtonEx _bPageSetup, _bPrinterSetup;
        private CheckBoxEx _chbAxisScrollbar;
        private C1.Win.Chart.Interaction.AxisScrollbar _axisScrollbar;
        private MultiPagePrintControl _singlePagePrintControl;
        private FlexChart flexChart1;

        public MultiPagePrint()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.ChartType = ChartType.Area;
            this.flexChart1.DataSource = DataService.CreateDataPoints(i => i, i => (2.0 + Math.Sin(i)), 56);
            this.flexChart1.BindingX = "X";
            this.flexChart1.Series.Add(new Series { Binding = "Y" });
            this.flexChart1.Options.ClusterSize = new ElementSize() { SizeType = ElementSizeType.Absolute, Value = 4 };
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;            
            this.pnlControls.Height = 40;

            _bPageSetup = new ButtonEx("Page Setup");
            _bPageSetup.Click += _bPageSetup_Click;

            _bPrinterSetup = new ButtonEx("Printer Setup");
            _bPrinterSetup.Click += _bPrinterSetup_Click;

            _chbAxisScrollbar = new CheckBoxEx("Axis Scrollbar");
            _chbAxisScrollbar.CheckedChanged += (s, e) =>
            {
                if (_chbAxisScrollbar.Checked)
                {
                    _axisScrollbar = new C1.Win.Chart.Interaction.AxisScrollbar(flexChart1.AxisX);
                    _axisScrollbar.UpperValue = _axisScrollbar.LowerValue + 10;
                }
                else
                {
                    _axisScrollbar.Dispose();
                    flexChart1.AxisX.Min = flexChart1.AxisY.Min = double.NaN;
                    flexChart1.AxisX.Max = flexChart1.AxisY.Max = double.NaN;
                }
            };

            _singlePagePrintControl = new MultiPagePrintControl() { FlexChart= flexChart1, Dock = DockStyle.Bottom };

            this.pnlControls.Controls.Add(_bPageSetup);
            this.pnlControls.Controls.Add(_bPrinterSetup);
            this.pnlControls.Controls.Add(_chbAxisScrollbar);
            this.Controls.Add(_singlePagePrintControl);
        }
        private void _bPrinterSetup_Click(object sender, EventArgs e)
        {
            ChartPrinter chartPrinter = new ChartPrinter(flexChart1, false);
            chartPrinter.PrintSetup();
            _singlePagePrintControl.PrinterSets = chartPrinter.PrintSettingsProp;
        }

        private void _bPageSetup_Click(object sender, EventArgs e)
        {
            ChartPrinter chartPrinter = new ChartPrinter(flexChart1, false);
            chartPrinter.PageSetup();
            _singlePagePrintControl.PageSets = chartPrinter.PageSettingsProp;
        }
    }
}
