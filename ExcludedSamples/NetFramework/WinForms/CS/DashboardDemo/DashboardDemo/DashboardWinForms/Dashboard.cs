using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.Chart;
using DashboardModel;
using C1.Win.C1Gauge;
using C1.Win.Layout;

namespace DashboardWinForms
{
    public partial class Dashboard : UserControl
    {
        const string Fmt = "#,##0,,.##M";

        public Dashboard()
        {
            InitializeComponent();
            Text = Strings.Resource.DashboardPage_Title;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Visible = false;
            var dashboardLayout = new C1DashboardLayout();
            var selector = new ValRangeSelector() { Dock = DockStyle.Bottom };
            Series series;
            var g1 = new BulletGraphs() { Dock = DockStyle.Fill, Parent = panGauges1 };
            var g2 = new BulletGraphs() { Dock = DockStyle.Fill, Parent = panGauges2 };
            selector.DateRangeChanged += (s, ev) =>
            {
                DataService.GetService().DateRange = ev.NewValue;

                g1.Source = DataService.GetService().CategorySalesVsGoal;
                labUnits1.Text = Strings.Resource.Unit_Text;

                chartSaleTopProd.DataSource = DataService.GetService().GetTopSaleProductList(3);
                chartSaleTopProd.AxisY.Format = Fmt;
                chartSaleTopProd.AxisX.LabelAngle = -45;
                chartSaleTopProd.Series.Clear();
                series = new Series();
                series.Binding = "Sales";
                SetColor1(series);
                chartSaleTopProd.BindingX = "Name";
                chartSaleTopProd.Series.Add(series);
                chartSaleTopProd.ChartType = C1.Chart.ChartType.Column;
                chartSaleTopProd.AnimationSettings = C1.Chart.AnimationSettings.All;

                chartCurrProfitVSPriorProfit.AnimationSettings = C1.Chart.AnimationSettings.All;
                chartSalesVsProfit.AnimationSettings = C1.Chart.AnimationSettings.All;

                gridTopSaleCustomer.DataSource = DataService.GetService().GetTopSaleCustomerList(7);
                gridTopSaleCustomer.Cols.Count = 4;
                gridTopSaleCustomer.Cols["Name"].StarWidth = "*";
                gridTopSaleCustomer.Cols["Sales"].Format = "C0";
                gridTopSaleCustomer.Cols["Sales"].StarWidth = "*";
                gridTopSaleCustomer.Cols["Profit"].Format = "C0";
                gridTopSaleCustomer.Cols["Profit"].StarWidth = "*";
                gridTopSaleCustomer.Cols[0].WidthDisplay = 0;

                g2.Source = DataService.GetService().RegionSalesVsGoal;
                labUnits2.Text = Strings.Resource.Unit_Text;

                dashboardLayout.SetCaption(c1SplitterPanel4, Strings.Resource.CategorySales_Header);
                dashboardLayout.SetCaption(c1SplitterPanel8, Strings.Resource.TopSaleProducts_Header);
                dashboardLayout.SetCaption(c1SplitterPanel9, Strings.Resource.TopSaleCustomer_Header);
                dashboardLayout.SetCaption(c1SplitContainer1, Strings.Resource.RegionSales_Header);
                dashboardLayout.SetCaption(c1SplitterPanel6, Strings.Resource.BudgetVSProfit_Header);
                dashboardLayout.SetCaption(splPan1, Strings.Resource.SalesVsProfit_Header);
                dashboardLayout.SetCaption(splPan2, Strings.Resource.BudgetVSProfit_Header);                
            };
            Controls.Add(selector);
            c1SplitContainer1.Dock = DockStyle.Fill;

            chartCurrProfitVSPriorProfit.DataSource = DataService.GetService().BudgetItemList;
            chartCurrProfitVSPriorProfit.AxisY.Format = Fmt;
            series = new Series();
            series.Binding = "Profit";
            series.Name = Strings.Resource.CurrentYear_Series;
            SetColor1(series);
            chartCurrProfitVSPriorProfit.Series.Add(series);
            series = new Series();
            series.Binding = "ProirProfit";
            series.Name = Strings.Resource.PriorYear_Series;
            SetColor2(series);
            chartCurrProfitVSPriorProfit.Series.Add(series);
            chartCurrProfitVSPriorProfit.BindingX = "Date";
            
            chartCurrProfitVSPriorProfit.ChartType = C1.Chart.ChartType.LineSymbols;
            chartCurrProfitVSPriorProfit.Legend.Position = C1.Chart.Position.Top;

            chartSalesVsProfit.DataSource = DataService.GetService().BudgetItemList;
            series = new Series();
            series.Binding = "Sales";
            series.Name = Strings.Resource.Sale_Series;
            series.AxisY = new Axis() { Position = C1.Chart.Position.Right, Title = Strings.Resource.Sale_Series, Format = Fmt };
            SetColor1(series);
            chartSalesVsProfit.Series.Add(series);
            series = new Series();
            series.Binding = "Profit";
            series.Name = Strings.Resource.Profit_Series;
            series.ChartType = C1.Chart.ChartType.Line;
            series.AxisY = new Axis() { Position = C1.Chart.Position.Left, Title = Strings.Resource.Profit_Series, Format = Fmt };
            SetColor2(series);
            chartSalesVsProfit.Series.Add(series);
            chartSalesVsProfit.BindingX = "Date";
            gridTopSaleCustomer.Visible = true;
            dashboardLayout.Options.ToolIconAppearance = ToolIconAppearance.UpperRight;
            dashboardLayout.AttachToLayout(new SplitLayout(c1SplitContainer1));
            selector.SendToBack();
            Visible = true;
        }

        private void SetColor1(Series series) => SetColor(series, Color.FromArgb(0, 0x96, 0x88)); //Color.Teal;

        private void SetColor2(Series series) => SetColor(series, Color.FromArgb(0xF4, 0x43, 0x36));// Color.Red;

        private void SetColor(Series series, Color color)
        {
            series.Style.StrokeColor = color;
            series.Style.FillColor = color;
        }
    }
}
