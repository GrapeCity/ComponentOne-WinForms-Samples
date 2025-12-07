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
using C1.Win.SuperTooltip;

namespace FlexChartExplorer.Samples
{
    public partial class FormattedTooltip : FlexChartBaseSample
    {
        private C1SuperTooltip _stSuperTooltip;
        private FlexChart flexChart1;
        const int MAX_DIST = 5;
        public FormattedTooltip()
        {
            InitializeComponent();
        }
        protected override void SetupChart()
        {
            this.flexChart1.Header.Content = "Sales vs Expenses";
            this.flexChart1.Header.Style.Font = StyleInfo.ChartHeaderFont;

            this.flexChart1.DataSource = SalesDataSource.GetCountrySales();
            this.flexChart1.BindingX = "Name";
            this.flexChart1.Series.Add(new Series { Name = "Sales", Binding = "Sales" });
            this.flexChart1.Series.Add(new Series { Name = "Expenses", Binding = "Expenses", ChartType = ChartType.LineSymbols });
            this.flexChart1.ToolTip.Active = false;
            this.flexChart1.MouseMove += FlexChart1_MouseMove;
            this.flexChart1.AxisX.AxisLine = false;
        }

        private void FlexChart1_MouseMove(object sender, MouseEventArgs e)
        {
            var hitTestInfo = flexChart1.HitTest(e.Location);
            if (hitTestInfo == null)
                return;
            if (hitTestInfo.Item != null && hitTestInfo.Distance <= MAX_DIST)
            {
                var item = hitTestInfo.Item as Country;
                var htmlTemplate = @"<p><b>Country: </b>{0}
                                   <br/>
                                   <b>Sales: </b>{1}
                                   <br/>
                                   <b>Expenses: </b>{2}
                                   </p>";
                var htmlContent = String.Format(htmlTemplate, item.Name, item.Sales, item.Expenses);
                _stSuperTooltip.SetToolTip(flexChart1, htmlContent);
            }
            else
                _stSuperTooltip.Hide();
        }

        protected override void InitializeControls()
        {
            flexChart1 = new FlexChart();
            this.Chart = flexChart1;
            
            _stSuperTooltip = new C1SuperTooltip() { AutomaticDelay = 0 , AutoPopDelay = int.MaxValue};
            this.pnlControls.Hide();
        }
    }
}
