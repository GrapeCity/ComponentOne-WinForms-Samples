using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using C1.Chart;
using C1.Win.Chart;
using C1.Win.Chart.Interaction;
using C1.Chart.Printing;

namespace FlexChartPrint.Samples
{
    public partial class BaseSample : UserControl
    {
        public const int maximumXValue = 56;
        public PrinterSettings prnSets = null;
        public PageSettings pageSets = null;
        AxisScrollbar horzBar = null;

        public BaseSample()
        {
            InitializeComponent();

            double[] xval = new double[maximumXValue + 1];
            double[] yval = new double[xval.Length];
            for (int i = 0; i < yval.Length; i++)
            {
                xval[i] = i;
                yval[i] = 2.0 + Math.Sin(i);
            }

            flexChart1.Series.Clear();
            flexChart1.Options.ClusterSize = new ElementSize()
            {
                SizeType = ElementSizeType.Absolute,
                Value = 4
            };

            Series ser = new Series();
            flexChart1.Series.Add(ser);
            ser.SetData(xval, yval);

            flexChart1.BackColor = Color.FromKnownColor(KnownColor.Info);
        }

        public FlexChart FlexChart
        {
            get { return flexChart1; }
        }

        public string Title
        {
            get { return labTitle.Text; }
            set { labTitle.Text = value; }
        }

        private void btnPageSetup_Click(object sender, EventArgs e)
        {
            ChartPrinter chartPrinter = new ChartPrinter(flexChart1, false);
            if (pageSets != null)
                chartPrinter.PageSettingsProp = pageSets;

            chartPrinter.PageSetup();

            pageSets = chartPrinter.PageSettingsProp;
        }

        private void btnPrinterSetup_Click(object sender, EventArgs e)
        {
            ChartPrinter chartPrinter = new ChartPrinter(flexChart1, false);
            if (prnSets != null)
                chartPrinter.PrintSettingsProp = prnSets;

            chartPrinter.PrintSetup();

            prnSets = chartPrinter.PrintSettingsProp;
        }

        private void chkScrollbar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkScrollbar.Checked)
            {
                if (horzBar == null)
                    horzBar = new AxisScrollbar(flexChart1.AxisX);
                horzBar.ScrollButtonsVisible = true;
                horzBar.BorderStyle = BorderStyle.FixedSingle;
                horzBar.UpperValue = 5;
            }
            else
            {
                if (horzBar != null)
                {
                    horzBar.Remove();
                    horzBar = null;
                }
            }
        }

        public BaseChartPrint PanelControl
        {
            get
            {
                BaseChartPrint panelControl = (splitBase.Panel2.Controls.Count > 0) ?
                    splitBase.Panel2.Controls[0] as BaseChartPrint : null;
                return panelControl;
            }

            set
            {
                if (value is BaseChartPrint)
                {
                    splitBase.Panel2.Controls.Clear();
                    splitBase.Panel2.Controls.Add(value);
                    value.Dock = DockStyle.Fill;
                    value.BaseSample = this;
                }
            }
        }
    }

    public class BaseChartPrint : UserControl
    {
        BaseSample baseSample = null;

        public BaseSample BaseSample
        {
            get { return baseSample; }
            set { baseSample = value; OnBaseSampleUpdated(); }
        }

        protected void InitializePageSettings()
        {
            if (baseSample != null && baseSample.pageSets == null)
                baseSample.pageSets = new PageSettings() { Landscape = true };
        }

        protected virtual string Title { get { return ""; } }

        protected virtual void OnBaseSampleUpdated()
        {
            BaseSample.Title = Title;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseChartPrint
            // 
            this.Name = "BaseChartPrint";
            this.Size = new System.Drawing.Size(618, 502);
            this.ResumeLayout(false);
        }
    }
}
