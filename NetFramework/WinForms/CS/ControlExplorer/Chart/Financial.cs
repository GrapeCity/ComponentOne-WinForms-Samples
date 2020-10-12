using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Chart;

namespace ControlExplorer.Chart
{
    public partial class Financial : C1DemoForm
    {
        public Financial()
        {
            InitializeComponent();
        }

        private void radHiLo_CheckedChanged(object sender, EventArgs e)
        {
            ResetChart();
            if (radChartGroups.Checked)
            {
                ChartGroup g = c1Chart1.ChartGroups.Group0;
                g.ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Candle;
                g.ChartData.SeriesList[0].LineStyle.Thickness = 2;
                c1Chart1.ChartGroups.Group1.Visible = true;
                c1Chart1.ChartArea.AxisY2.Visible = true;
            }
            else if (radHiLoOpenClose.Checked)
            {
                c1Chart1.ChartGroups.Group0.ChartType = C1.Win.C1Chart.Chart2DTypeEnum.HiLoOpenClose;
            }
            else if (radCandle.Checked)
            {
                ChartGroup g = c1Chart1.ChartGroups.Group0;
                g.ChartType = C1.Win.C1Chart.Chart2DTypeEnum.Candle;
                g.ChartData.SeriesList[0].LineStyle.Thickness = 2;
            }
            else
            {
                c1Chart1.ChartGroups.Group0.ChartType = C1.Win.C1Chart.Chart2DTypeEnum.HiLo;
            }
        }

        private void ResetChart()
        {
            c1Chart1.ChartGroups.Group0.ChartData.SeriesList[0].LineStyle.Thickness = 4;
            c1Chart1.ChartGroups.Group1.Visible = false;
            c1Chart1.ChartArea.AxisY2.Visible = false;
        }

        private void Financial_Load(object sender, EventArgs e)
        {
            stockData1.ResetBindings(false);

            //add demo properties
            HiLoData hilo = c1Chart1.ChartGroups.Group0.HiLoData;
            AddProperty("FillFalling", hilo);
            AddProperty("FillTransparent", hilo);
            AddProperty("FullWidth", hilo);
            AddProperty("ShowClose", hilo);
            AddProperty("ShowOpen", hilo);
        }
    }
}
