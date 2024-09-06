using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.Chart;
using FlexChartExplorer.Data;
using BaseExplorer;
using C1.Chart;

namespace FlexChartExplorer.Samples
{
    public partial class Introduction : FlexChartBaseSample
    {
        private FlexChart flexChart1;

        public Introduction()
        {
            InitializeComponent();
        }

        protected override void SetupChart()
        {
            flexChart1.BeginUpdate();
            flexChart1.Header.Content = "Revenue and Expense Comparison";
            flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;
            flexChart1.Series.Clear();

            // Add data series
            var revenue = new Series();
            revenue.Binding = "Sales";
            revenue.Name = "Revenue";
            flexChart1.Series.Add(revenue);

            var expenses = new Series();
            expenses.Binding = expenses.Name = "Expenses";
            flexChart1.Series.Add(expenses);

            var downloads = new Series();
            downloads.Binding = downloads.Name = "Downloads";
            flexChart1.Series.Add(downloads);

            // Set x-binding and add data to the chart
            flexChart1.BindingX = "Name";
            flexChart1.DataSource = SalesDataSource.GetCountrySales();
            flexChart1.AxisX.AxisLine = false;

            flexChart1.EndUpdate();
        }

        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            cbChartType = ChartControlFactory.BasicChartTypesCombo();
            cbChartType.SelectedIndexChanged += (s, e) =>
            {
                flexChart1.ChartType = (ChartType)Enum.Parse(typeof(ChartType), cbChartType.SelectedItem.ToString());
                UpdateStackGroupVisibility();
            };

            cbPalette = ControlFactory.EnumBasedCombo(typeof(Palette), "Palette");
            cbPalette.SelectedIndexChanged += (s, e) => flexChart1.Palette = (C1.Chart.Palette)Enum.Parse(typeof(C1.Chart.Palette), cbPalette.SelectedItem.ToString());


            cbStacked = ControlFactory.EnumBasedCombo(typeof(Stacking), "Stacking");
            cbStacked.SelectedIndexChanged += (s, e) =>
            {
                flexChart1.Stacking = (C1.Chart.Stacking)Enum.Parse(typeof(C1.Chart.Stacking), cbStacked.SelectedItem.ToString());
                UpdateStackGroupVisibility();
            };

            chbRotate = new CheckBoxEx("Rotate");
            chbRotate.CheckedChanged += (s, e) => flexChart1.Rotated = chbRotate.Checked;

            chbGroup = new CheckBoxEx("Stacked Group") { Visible = false };
            chbGroup.CheckedChanged += ChbGroup_CheckedChanged;

            pnlControls.Controls.Add(cbChartType);
            pnlControls.Controls.Add(cbPalette);
            pnlControls.Controls.Add(cbStacked);
            pnlControls.Controls.Add(chbRotate);
            pnlControls.Controls.Add(chbGroup);
        }

        #region Event Handlers

        private void ChbGroup_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chbGroup.Checked)
            {
                flexChart1.Series[0].StackingGroup = 0;
                flexChart1.Series[1].StackingGroup = 0;
                flexChart1.Series[2].StackingGroup = 1;
            }
            else
            {
                foreach (var series in flexChart1.Series)
                {
                    series.StackingGroup = -1;
                }
            }
        }

        private void UpdateStackGroupVisibility()
        {
            if ((flexChart1.ChartType == ChartType.Column || flexChart1.ChartType == ChartType.Bar)
                && flexChart1.Stacking != Stacking.None)
            {
                chbGroup.Visible = true;
            }
            else
            {
                chbGroup.Visible = false;
            }
        }
        #endregion
    }
}
