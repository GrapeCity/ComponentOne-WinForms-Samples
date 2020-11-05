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
using BaseExplorer.CustomControls;

namespace FlexChartExplorer.Samples
{
    public partial class AxisTitle : FlexChartBaseSample
    {
        private LabelEx _lXTitle, _lYTitle;
        private TextBoxEx _tbXTitle, _tbYTitle;
        private FlexChart flexChart1;

        public AxisTitle()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Relationship between Production and Cost";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = DataService.GetUnitCostData();
            this.flexChart1.ChartType = ChartType.LineSymbols;
            this.flexChart1.Binding = "Cost";
            this.flexChart1.BindingX = "Units";
            this.flexChart1.Series.Add(new Series());

            this.flexChart1.AxisY.Title = "Per Unit Cost";
            this.flexChart1.AxisY.TitleStyle.Font = StyleInfo.AxisTitleFont;

            this.flexChart1.AxisX.Title = "Quantity";
            this.flexChart1.AxisX.TitleStyle.Font = StyleInfo.AxisTitleFont;

            this.flexChart1.Rendered += (s, e) =>
            {
                _tbXTitle.Text = flexChart1.AxisX.Title;
                _tbYTitle.Text = flexChart1.AxisY.Title;
            };
        }
        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
           
            _lXTitle = new LabelEx("X-Axis Title:");
            _tbXTitle = new TextBoxEx { ForeColor = Color.DimGray, AutoSize = false };
            _tbXTitle.TextChanged += (s, e) => { flexChart1.AxisX.Title = _tbXTitle.Text; };

            _lYTitle = new LabelEx("Y-Axis Title:");
            _tbYTitle = new TextBoxEx { ForeColor = Color.DimGray, AutoSize = false };
            _tbYTitle.TextChanged += (s, e) => { flexChart1.AxisY.Title = _tbYTitle.Text; };

            this.pnlControls.Controls.Add(_lXTitle);
            this.pnlControls.Controls.Add(_tbXTitle);
            this.pnlControls.Controls.Add(_lYTitle);
            this.pnlControls.Controls.Add(_tbYTitle);
        }
    }
}
