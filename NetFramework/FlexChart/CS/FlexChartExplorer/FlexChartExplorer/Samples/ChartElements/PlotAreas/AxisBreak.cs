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
using AxisBreak;
using BaseExplorer;

namespace FlexChartExplorer.Samples
{
    public partial class AxisBreak : FlexChartBaseSample
    {
        private FlexChart flexChart1;
        ComboBoxEx comboBoxChartType;
        CheckBoxEx checkBoxAxisBreak;
        CheckBoxEx checkBoxRotated;

        public AxisBreak()
        {
            InitializeComponent();
        }

        protected override void SetupChart()
        {
            comboBoxChartType.DataSource = new ChartType[] { ChartType.Column, ChartType.Line, ChartType.LineSymbols };
            comboBoxChartType.SelectedIndex = 0;
            comboBoxChartType.SelectedIndexChanged += (s, e) => flexChart1.ChartType = (ChartType)comboBoxChartType.SelectedValue;

            checkBoxAxisBreak.CheckedChanged += checkBoxAxisBreak_CheckedChanged;

            checkBoxRotated.CheckedChanged += checkBoxRotated_CheckedChanged;

            flexChart1.DataSource = CreateData();
            flexChart1.Binding = "Y";
            flexChart1.BindingX = "X";

            var ser = new Series();
            ser.Style.FillColor = ser.Style.StrokeColor = Color.FromArgb((int)((IPalette)flexChart1).GetColor(0));
            flexChart1.Series.Add(ser);

            checkBoxAxisBreak.Checked = true;
        }

        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            Chart = flexChart1;

            checkBoxAxisBreak = new CheckBoxEx() { Text = "Axis Break", AutoSize = true };
            pnlControls.Controls.Add(checkBoxAxisBreak);

            checkBoxRotated = new CheckBoxEx() { Text = "Rotated", AutoSize = true };
            pnlControls.Controls.Add(checkBoxRotated);

            pnlControls.Controls.Add(new BaseExplorer.LabelEx("Chart Type"));

            comboBoxChartType = new ComboBoxEx();
            pnlControls.Controls.Add(comboBoxChartType);
        }


        PointF[] CreateData()
        {
            var rnd = new Random();
            var pts = new PointF[20];

            for (var i = 0; i < pts.Length; i++)
            {
                if (rnd.NextDouble() < 0.85)
                    pts[i] = new PointF(i, rnd.Next(0, 10));
                else
                    pts[i] = new PointF(i, 50 + rnd.Next(0, 50));
            }

            return pts;
        }

        private void checkBoxAxisBreak_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAxisBreak.Checked)
            {
                if (flexChart1.Rotated)
                    AxisBreakHelper.CreateAxisBreak(flexChart1.AxisX, 0, 10, 50, 100);
                else
                    AxisBreakHelper.CreateAxisBreak(flexChart1.AxisY, 0, 10, 50, 100);
            }
            else
                AxisBreakHelper.Remove(flexChart1);
        }

        private void checkBoxRotated_CheckedChanged(object sender, EventArgs e)
        {
            flexChart1.Rotated = checkBoxRotated.Checked;
            flexChart1.AxisX.MajorGrid = flexChart1.Rotated;
            flexChart1.AxisY.MajorGrid = !flexChart1.Rotated;

            if (checkBoxAxisBreak.Checked)
            {
                if (flexChart1.Rotated)
                    AxisBreakHelper.CreateAxisBreak(flexChart1.AxisX, 0, 10, 50, 100);
                else
                    AxisBreakHelper.CreateAxisBreak(flexChart1.AxisY, 0, 10, 50, 100);
            }
        }

    }
}
