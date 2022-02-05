using C1.Win.Gauge;

namespace DashboardWinForms
{
    partial class Dashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            C1.Chart.ElementSize elementSize4 = new C1.Chart.ElementSize();
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            C1.Chart.ElementSize elementSize2 = new C1.Chart.ElementSize();
            C1.Win.FlexGrid.FooterDescription footerDescription2 = new C1.Win.FlexGrid.FooterDescription();
            C1.Win.FlexGrid.AggregateDefinition aggregateDefinition4 = new C1.Win.FlexGrid.AggregateDefinition();
            C1.Win.FlexGrid.AggregateDefinition aggregateDefinition5 = new C1.Win.FlexGrid.AggregateDefinition();
            C1.Win.FlexGrid.AggregateDefinition aggregateDefinition6 = new C1.Win.FlexGrid.AggregateDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            C1.Win.Themes.C1MaterialThemeSettings c1MaterialThemeSettings2 = new C1.Win.Themes.C1MaterialThemeSettings();
            this.chartCurrProfitVSPriorProfit = new C1.Win.Chart.FlexChart();
            this.chartSalesVsProfit = new C1.Win.Chart.FlexChart();
            this.chartSaleTopProd = new C1.Win.Chart.FlexChart();
            this.gridTopSaleCustomer = new C1.Win.FlexGrid.C1FlexGrid();
            this.c1SplitContainer1 = new C1.Win.SplitContainer.C1SplitContainer();
            this.c1SplitterPanel1 = new C1.Win.SplitContainer.C1SplitterPanel();
            this.c1SplitContainer3 = new C1.Win.SplitContainer.C1SplitContainer();
            this.c1SplitterPanel6 = new C1.Win.SplitContainer.C1SplitterPanel();
            this.c1SplitterPanel7 = new C1.Win.SplitContainer.C1SplitterPanel();
            this.c1SplitContainer4 = new C1.Win.SplitContainer.C1SplitContainer();
            this.c1SplitterPanel8 = new C1.Win.SplitContainer.C1SplitterPanel();
            this.c1SplitterPanel9 = new C1.Win.SplitContainer.C1SplitterPanel();
            this.c1SplitterPanel2 = new C1.Win.SplitContainer.C1SplitterPanel();
            this.c1SplitContainer2 = new C1.Win.SplitContainer.C1SplitContainer();
            this.splPan1 = new C1.Win.SplitContainer.C1SplitterPanel();
            this.c1SplitterPanel4 = new C1.Win.SplitContainer.C1SplitterPanel();
            this.panGauges1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labUnits1 = new System.Windows.Forms.Label();
            this.splPan2 = new C1.Win.SplitContainer.C1SplitterPanel();
            this.panGauges2 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labUnits2 = new System.Windows.Forms.Label();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.chartCurrProfitVSPriorProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesVsProfit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSaleTopProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTopSaleCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).BeginInit();
            this.c1SplitContainer1.SuspendLayout();
            this.c1SplitterPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer3)).BeginInit();
            this.c1SplitContainer3.SuspendLayout();
            this.c1SplitterPanel6.SuspendLayout();
            this.c1SplitterPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer4)).BeginInit();
            this.c1SplitContainer4.SuspendLayout();
            this.c1SplitterPanel8.SuspendLayout();
            this.c1SplitterPanel9.SuspendLayout();
            this.c1SplitterPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer2)).BeginInit();
            this.c1SplitContainer2.SuspendLayout();
            this.splPan1.SuspendLayout();
            this.c1SplitterPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.splPan2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartCurrProfitVSPriorProfit
            // 
            this.chartCurrProfitVSPriorProfit.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            this.chartCurrProfitVSPriorProfit.AnimationLoad.Duration = 400;
            this.chartCurrProfitVSPriorProfit.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            this.chartCurrProfitVSPriorProfit.AnimationLoad.Type = C1.Chart.AnimationType.All;
            this.chartCurrProfitVSPriorProfit.AnimationSettings = C1.Chart.AnimationSettings.None;
            this.chartCurrProfitVSPriorProfit.AnimationUpdate.Duration = 400;
            this.chartCurrProfitVSPriorProfit.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            this.chartCurrProfitVSPriorProfit.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            this.chartCurrProfitVSPriorProfit.AxisX.Chart = this.chartCurrProfitVSPriorProfit;
            this.chartCurrProfitVSPriorProfit.AxisX.DataSource = null;
            this.chartCurrProfitVSPriorProfit.AxisX.GroupProvider = null;
            this.chartCurrProfitVSPriorProfit.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.chartCurrProfitVSPriorProfit.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.chartCurrProfitVSPriorProfit.AxisX.GroupVisibilityLevel = 0;
            this.chartCurrProfitVSPriorProfit.AxisX.LabelMax = false;
            this.chartCurrProfitVSPriorProfit.AxisX.LabelMin = false;
            this.chartCurrProfitVSPriorProfit.AxisX.PlotAreaName = null;
            this.chartCurrProfitVSPriorProfit.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            this.chartCurrProfitVSPriorProfit.AxisY.Chart = this.chartCurrProfitVSPriorProfit;
            this.chartCurrProfitVSPriorProfit.AxisY.DataSource = null;
            this.chartCurrProfitVSPriorProfit.AxisY.GroupProvider = null;
            this.chartCurrProfitVSPriorProfit.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.chartCurrProfitVSPriorProfit.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.chartCurrProfitVSPriorProfit.AxisY.GroupVisibilityLevel = 0;
            this.chartCurrProfitVSPriorProfit.AxisY.LabelMax = false;
            this.chartCurrProfitVSPriorProfit.AxisY.LabelMin = false;
            this.chartCurrProfitVSPriorProfit.AxisY.PlotAreaName = null;
            this.chartCurrProfitVSPriorProfit.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            this.chartCurrProfitVSPriorProfit.BackColor = System.Drawing.Color.White;
            this.chartCurrProfitVSPriorProfit.DataLabel.Angle = 0;
            this.chartCurrProfitVSPriorProfit.DataLabel.Border = false;
            this.chartCurrProfitVSPriorProfit.DataLabel.ConnectingLine = false;
            this.chartCurrProfitVSPriorProfit.DataLabel.Content = null;
            this.chartCurrProfitVSPriorProfit.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            this.chartCurrProfitVSPriorProfit.DataLabel.MaxAutoLabels = 100;
            this.chartCurrProfitVSPriorProfit.DataLabel.MaxLines = 0;
            this.chartCurrProfitVSPriorProfit.DataLabel.MaxWidth = 0;
            this.chartCurrProfitVSPriorProfit.DataLabel.Offset = 0;
            this.chartCurrProfitVSPriorProfit.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            this.chartCurrProfitVSPriorProfit.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            this.chartCurrProfitVSPriorProfit.DataLabel.Position = C1.Chart.LabelPosition.None;
            this.chartCurrProfitVSPriorProfit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCurrProfitVSPriorProfit.ForeColor = System.Drawing.Color.Black;
            this.chartCurrProfitVSPriorProfit.Legend.ItemMaxWidth = 0;
            this.chartCurrProfitVSPriorProfit.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.chartCurrProfitVSPriorProfit.Legend.Position = C1.Chart.Position.Right;
            this.chartCurrProfitVSPriorProfit.Legend.Reversed = false;
            this.chartCurrProfitVSPriorProfit.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.chartCurrProfitVSPriorProfit.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.chartCurrProfitVSPriorProfit.Legend.Title = null;
            this.chartCurrProfitVSPriorProfit.Location = new System.Drawing.Point(0, 0);
            this.chartCurrProfitVSPriorProfit.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.chartCurrProfitVSPriorProfit.Name = "chartCurrProfitVSPriorProfit";
            elementSize4.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize4.Value = 70D;
            this.chartCurrProfitVSPriorProfit.Options.ClusterSize = elementSize4;
            this.chartCurrProfitVSPriorProfit.PlotMargin = new System.Windows.Forms.Padding(0);
            this.chartCurrProfitVSPriorProfit.SelectedSeries = null;
            this.chartCurrProfitVSPriorProfit.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.chartCurrProfitVSPriorProfit.Size = new System.Drawing.Size(1260, 446);
            this.chartCurrProfitVSPriorProfit.TabIndex = 0;
            // 
            // 
            // 
            this.chartCurrProfitVSPriorProfit.ToolTip.Content = "{value}";
            // 
            // chartSalesVsProfit
            // 
            this.chartSalesVsProfit.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            this.chartSalesVsProfit.AnimationLoad.Duration = 400;
            this.chartSalesVsProfit.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            this.chartSalesVsProfit.AnimationLoad.Type = C1.Chart.AnimationType.All;
            this.chartSalesVsProfit.AnimationSettings = C1.Chart.AnimationSettings.None;
            this.chartSalesVsProfit.AnimationUpdate.Duration = 400;
            this.chartSalesVsProfit.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            this.chartSalesVsProfit.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            this.chartSalesVsProfit.AxisX.Chart = this.chartSalesVsProfit;
            this.chartSalesVsProfit.AxisX.DataSource = null;
            this.chartSalesVsProfit.AxisX.GroupProvider = null;
            this.chartSalesVsProfit.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.chartSalesVsProfit.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.chartSalesVsProfit.AxisX.GroupVisibilityLevel = 0;
            this.chartSalesVsProfit.AxisX.LabelMax = false;
            this.chartSalesVsProfit.AxisX.LabelMin = false;
            this.chartSalesVsProfit.AxisX.PlotAreaName = null;
            this.chartSalesVsProfit.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            this.chartSalesVsProfit.AxisY.Chart = this.chartSalesVsProfit;
            this.chartSalesVsProfit.AxisY.DataSource = null;
            this.chartSalesVsProfit.AxisY.GroupProvider = null;
            this.chartSalesVsProfit.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.chartSalesVsProfit.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.chartSalesVsProfit.AxisY.GroupVisibilityLevel = 0;
            this.chartSalesVsProfit.AxisY.LabelMax = false;
            this.chartSalesVsProfit.AxisY.LabelMin = false;
            this.chartSalesVsProfit.AxisY.PlotAreaName = null;
            this.chartSalesVsProfit.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            this.chartSalesVsProfit.BackColor = System.Drawing.Color.White;
            this.chartSalesVsProfit.DataLabel.Angle = 0;
            this.chartSalesVsProfit.DataLabel.Border = false;
            this.chartSalesVsProfit.DataLabel.ConnectingLine = false;
            this.chartSalesVsProfit.DataLabel.Content = null;
            this.chartSalesVsProfit.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            this.chartSalesVsProfit.DataLabel.MaxAutoLabels = 100;
            this.chartSalesVsProfit.DataLabel.MaxLines = 0;
            this.chartSalesVsProfit.DataLabel.MaxWidth = 0;
            this.chartSalesVsProfit.DataLabel.Offset = 0;
            this.chartSalesVsProfit.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            this.chartSalesVsProfit.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            this.chartSalesVsProfit.DataLabel.Position = C1.Chart.LabelPosition.None;
            this.chartSalesVsProfit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartSalesVsProfit.ForeColor = System.Drawing.Color.Black;
            this.chartSalesVsProfit.Legend.ItemMaxWidth = 0;
            this.chartSalesVsProfit.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.chartSalesVsProfit.Legend.Position = C1.Chart.Position.Bottom;
            this.chartSalesVsProfit.Legend.Reversed = false;
            this.chartSalesVsProfit.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.chartSalesVsProfit.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.chartSalesVsProfit.Legend.Title = null;
            this.chartSalesVsProfit.Location = new System.Drawing.Point(0, 0);
            this.chartSalesVsProfit.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.chartSalesVsProfit.Name = "chartSalesVsProfit";
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.chartSalesVsProfit.Options.ClusterSize = elementSize1;
            this.chartSalesVsProfit.PlotMargin = new System.Windows.Forms.Padding(0);
            this.chartSalesVsProfit.SelectedSeries = null;
            this.chartSalesVsProfit.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.chartSalesVsProfit.Size = new System.Drawing.Size(123, 311);
            this.chartSalesVsProfit.TabIndex = 2;
            // 
            // 
            // 
            this.chartSalesVsProfit.ToolTip.Content = "{value}";
            // 
            // chartSaleTopProd
            // 
            this.chartSaleTopProd.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            this.chartSaleTopProd.AnimationLoad.Duration = 400;
            this.chartSaleTopProd.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            this.chartSaleTopProd.AnimationLoad.Type = C1.Chart.AnimationType.All;
            this.chartSaleTopProd.AnimationSettings = C1.Chart.AnimationSettings.None;
            this.chartSaleTopProd.AnimationUpdate.Duration = 400;
            this.chartSaleTopProd.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            this.chartSaleTopProd.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            this.chartSaleTopProd.AxisX.Chart = this.chartSaleTopProd;
            this.chartSaleTopProd.AxisX.DataSource = null;
            this.chartSaleTopProd.AxisX.GroupProvider = null;
            this.chartSaleTopProd.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.chartSaleTopProd.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.chartSaleTopProd.AxisX.GroupVisibilityLevel = 0;
            this.chartSaleTopProd.AxisX.LabelMax = false;
            this.chartSaleTopProd.AxisX.LabelMin = false;
            this.chartSaleTopProd.AxisX.PlotAreaName = null;
            this.chartSaleTopProd.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            this.chartSaleTopProd.AxisY.Chart = this.chartSaleTopProd;
            this.chartSaleTopProd.AxisY.DataSource = null;
            this.chartSaleTopProd.AxisY.GroupProvider = null;
            this.chartSaleTopProd.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.chartSaleTopProd.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.chartSaleTopProd.AxisY.GroupVisibilityLevel = 0;
            this.chartSaleTopProd.AxisY.LabelMax = false;
            this.chartSaleTopProd.AxisY.LabelMin = false;
            this.chartSaleTopProd.AxisY.PlotAreaName = null;
            this.chartSaleTopProd.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            this.chartSaleTopProd.BackColor = System.Drawing.Color.White;
            this.chartSaleTopProd.DataLabel.Angle = 0;
            this.chartSaleTopProd.DataLabel.Border = false;
            this.chartSaleTopProd.DataLabel.ConnectingLine = false;
            this.chartSaleTopProd.DataLabel.Content = null;
            this.chartSaleTopProd.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            this.chartSaleTopProd.DataLabel.MaxAutoLabels = 100;
            this.chartSaleTopProd.DataLabel.MaxLines = 0;
            this.chartSaleTopProd.DataLabel.MaxWidth = 0;
            this.chartSaleTopProd.DataLabel.Offset = 0;
            this.chartSaleTopProd.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            this.chartSaleTopProd.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            this.chartSaleTopProd.DataLabel.Position = C1.Chart.LabelPosition.None;
            this.chartSaleTopProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartSaleTopProd.ForeColor = System.Drawing.Color.Black;
            this.chartSaleTopProd.Legend.ItemMaxWidth = 0;
            this.chartSaleTopProd.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.chartSaleTopProd.Legend.Position = C1.Chart.Position.Right;
            this.chartSaleTopProd.Legend.Reversed = false;
            this.chartSaleTopProd.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.chartSaleTopProd.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.chartSaleTopProd.Legend.Title = null;
            this.chartSaleTopProd.Location = new System.Drawing.Point(0, 0);
            this.chartSaleTopProd.Margin = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.chartSaleTopProd.Name = "chartSaleTopProd";
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            this.chartSaleTopProd.Options.ClusterSize = elementSize2;
            this.chartSaleTopProd.PlotMargin = new System.Windows.Forms.Padding(0);
            this.chartSaleTopProd.SelectedSeries = null;
            this.chartSaleTopProd.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.chartSaleTopProd.Size = new System.Drawing.Size(955, 237);
            this.chartSaleTopProd.TabIndex = 3;
            // 
            // 
            // 
            this.chartSaleTopProd.ToolTip.Content = "{value}";
            // 
            // gridTopSaleCustomer
            // 
            this.gridTopSaleCustomer.BackColor = System.Drawing.Color.White;
            this.gridTopSaleCustomer.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.gridTopSaleCustomer.ColumnInfo = "10,1,0,0,0,120,Columns:";
            this.gridTopSaleCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            aggregateDefinition4.Caption = "Total:";
            aggregateDefinition4.PropertyName = "Name";
            aggregateDefinition5.Aggregate = C1.Win.FlexGrid.AggregateEnum.Sum;
            aggregateDefinition5.Caption = "{0:C0}";
            aggregateDefinition5.PropertyName = "Sales";
            aggregateDefinition6.Aggregate = C1.Win.FlexGrid.AggregateEnum.Sum;
            aggregateDefinition6.Caption = "{0:C0}";
            aggregateDefinition6.PropertyName = "Profit";
            footerDescription2.Aggregates.Add(aggregateDefinition4);
            footerDescription2.Aggregates.Add(aggregateDefinition5);
            footerDescription2.Aggregates.Add(aggregateDefinition6);
            this.gridTopSaleCustomer.Footers.Descriptions.Add(footerDescription2);
            this.gridTopSaleCustomer.Footers.Fixed = true;
            this.gridTopSaleCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.gridTopSaleCustomer.Location = new System.Drawing.Point(0, 0);
            this.gridTopSaleCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gridTopSaleCustomer.Name = "gridTopSaleCustomer";
            this.gridTopSaleCustomer.Rows.Count = 51;
            this.gridTopSaleCustomer.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None;
            this.gridTopSaleCustomer.Size = new System.Drawing.Size(302, 237);
            this.gridTopSaleCustomer.StyleInfo = resources.GetString("gridTopSaleCustomer.StyleInfo");
            this.gridTopSaleCustomer.TabIndex = 4;
            this.c1ThemeController1.SetTheme(this.gridTopSaleCustomer, "Material");
            c1MaterialThemeSettings2.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            c1MaterialThemeSettings2.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.c1ThemeController1.SetThemeSettings(this.gridTopSaleCustomer, c1MaterialThemeSettings2);
            this.gridTopSaleCustomer.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.gridTopSaleCustomer.Visible = false;
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1SplitContainer1.BackColor = System.Drawing.Color.White;
            this.c1SplitContainer1.CollapsingAreaColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.c1SplitContainer1.CollapsingCueColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer1.FixedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.c1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer1.HeaderHeight = 31;
            this.c1SplitContainer1.HeaderLineWidth = 1;
            this.c1SplitContainer1.Location = new System.Drawing.Point(4, 0);
            this.c1SplitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c1SplitContainer1.Name = "c1SplitContainer1";
            this.c1SplitContainer1.Panels.Add(this.c1SplitterPanel1);
            this.c1SplitContainer1.Panels.Add(this.c1SplitterPanel2);
            this.c1SplitContainer1.Size = new System.Drawing.Size(1386, 686);
            this.c1SplitContainer1.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer1.SplitterMovingColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer1.SplitterWidth = 3;
            this.c1SplitContainer1.TabIndex = 5;
            this.c1SplitContainer1.UseParentVisualStyle = false;
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Controls.Add(this.c1SplitContainer3);
            this.c1SplitterPanel1.Dock = C1.Win.SplitContainer.PanelDockStyle.Left;
            this.c1SplitterPanel1.Height = 686;
            this.c1SplitterPanel1.Location = new System.Drawing.Point(0, 0);
            this.c1SplitterPanel1.MinHeight = 61;
            this.c1SplitterPanel1.MinWidth = 61;
            this.c1SplitterPanel1.Name = "c1SplitterPanel1";
            this.c1SplitterPanel1.Size = new System.Drawing.Size(1260, 686);
            this.c1SplitterPanel1.SizeRatio = 91.113D;
            this.c1SplitterPanel1.TabIndex = 0;
            this.c1SplitterPanel1.Width = 1260;
            // 
            // c1SplitContainer3
            // 
            this.c1SplitContainer3.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1SplitContainer3.BackColor = System.Drawing.Color.White;
            this.c1SplitContainer3.CollapsingAreaColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.c1SplitContainer3.CollapsingCueColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1SplitContainer3.FixedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.c1SplitContainer3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer3.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer3.HeaderHeight = 31;
            this.c1SplitContainer3.HeaderLineWidth = 1;
            this.c1SplitContainer3.Location = new System.Drawing.Point(0, 0);
            this.c1SplitContainer3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c1SplitContainer3.Name = "c1SplitContainer3";
            this.c1SplitContainer3.Panels.Add(this.c1SplitterPanel6);
            this.c1SplitContainer3.Panels.Add(this.c1SplitterPanel7);
            this.c1SplitContainer3.Size = new System.Drawing.Size(1260, 686);
            this.c1SplitContainer3.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer3.SplitterMovingColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer3.SplitterWidth = 3;
            this.c1SplitContainer3.TabIndex = 0;
            this.c1SplitContainer3.UseParentVisualStyle = false;
            // 
            // c1SplitterPanel6
            // 
            this.c1SplitterPanel6.Controls.Add(this.chartCurrProfitVSPriorProfit);
            this.c1SplitterPanel6.Height = 446;
            this.c1SplitterPanel6.Location = new System.Drawing.Point(0, 0);
            this.c1SplitterPanel6.MinHeight = 61;
            this.c1SplitterPanel6.MinWidth = 61;
            this.c1SplitterPanel6.Name = "c1SplitterPanel6";
            this.c1SplitterPanel6.Size = new System.Drawing.Size(1260, 446);
            this.c1SplitterPanel6.SizeRatio = 65.351D;
            this.c1SplitterPanel6.TabIndex = 0;
            this.c1SplitterPanel6.Width = 1260;
            // 
            // c1SplitterPanel7
            // 
            this.c1SplitterPanel7.Controls.Add(this.c1SplitContainer4);
            this.c1SplitterPanel7.Height = 237;
            this.c1SplitterPanel7.Location = new System.Drawing.Point(0, 449);
            this.c1SplitterPanel7.MinHeight = 61;
            this.c1SplitterPanel7.MinWidth = 61;
            this.c1SplitterPanel7.Name = "c1SplitterPanel7";
            this.c1SplitterPanel7.Size = new System.Drawing.Size(1260, 237);
            this.c1SplitterPanel7.TabIndex = 1;
            this.c1SplitterPanel7.Width = 1260;
            // 
            // c1SplitContainer4
            // 
            this.c1SplitContainer4.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1SplitContainer4.BackColor = System.Drawing.Color.White;
            this.c1SplitContainer4.CollapsingAreaColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.c1SplitContainer4.CollapsingCueColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1SplitContainer4.FixedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.c1SplitContainer4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer4.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer4.HeaderHeight = 31;
            this.c1SplitContainer4.HeaderLineWidth = 1;
            this.c1SplitContainer4.Location = new System.Drawing.Point(0, 0);
            this.c1SplitContainer4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c1SplitContainer4.Name = "c1SplitContainer4";
            this.c1SplitContainer4.Panels.Add(this.c1SplitterPanel8);
            this.c1SplitContainer4.Panels.Add(this.c1SplitterPanel9);
            this.c1SplitContainer4.Size = new System.Drawing.Size(1260, 237);
            this.c1SplitContainer4.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer4.SplitterMovingColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer4.SplitterWidth = 3;
            this.c1SplitContainer4.TabIndex = 0;
            this.c1SplitContainer4.UseParentVisualStyle = false;
            // 
            // c1SplitterPanel8
            // 
            this.c1SplitterPanel8.Controls.Add(this.chartSaleTopProd);
            this.c1SplitterPanel8.Dock = C1.Win.SplitContainer.PanelDockStyle.Left;
            this.c1SplitterPanel8.Height = 237;
            this.c1SplitterPanel8.Location = new System.Drawing.Point(0, 0);
            this.c1SplitterPanel8.MinHeight = 61;
            this.c1SplitterPanel8.MinWidth = 61;
            this.c1SplitterPanel8.Name = "c1SplitterPanel8";
            this.c1SplitterPanel8.Size = new System.Drawing.Size(955, 237);
            this.c1SplitterPanel8.SizeRatio = 75.966D;
            this.c1SplitterPanel8.TabIndex = 0;
            this.c1SplitterPanel8.Width = 955;
            // 
            // c1SplitterPanel9
            // 
            this.c1SplitterPanel9.Controls.Add(this.gridTopSaleCustomer);
            this.c1SplitterPanel9.Height = 237;
            this.c1SplitterPanel9.Location = new System.Drawing.Point(958, 0);
            this.c1SplitterPanel9.MinHeight = 61;
            this.c1SplitterPanel9.MinWidth = 61;
            this.c1SplitterPanel9.Name = "c1SplitterPanel9";
            this.c1SplitterPanel9.Size = new System.Drawing.Size(302, 237);
            this.c1SplitterPanel9.TabIndex = 1;
            this.c1SplitterPanel9.Width = 302;
            // 
            // c1SplitterPanel2
            // 
            this.c1SplitterPanel2.Controls.Add(this.c1SplitContainer2);
            this.c1SplitterPanel2.Height = 686;
            this.c1SplitterPanel2.Location = new System.Drawing.Point(1263, 0);
            this.c1SplitterPanel2.MinHeight = 61;
            this.c1SplitterPanel2.MinWidth = 61;
            this.c1SplitterPanel2.Name = "c1SplitterPanel2";
            this.c1SplitterPanel2.Size = new System.Drawing.Size(123, 686);
            this.c1SplitterPanel2.TabIndex = 1;
            this.c1SplitterPanel2.Width = 123;
            // 
            // c1SplitContainer2
            // 
            this.c1SplitContainer2.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1SplitContainer2.BackColor = System.Drawing.Color.White;
            this.c1SplitContainer2.CollapsingAreaColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.c1SplitContainer2.CollapsingCueColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1SplitContainer2.FixedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.c1SplitContainer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer2.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer2.HeaderHeight = 31;
            this.c1SplitContainer2.HeaderLineWidth = 1;
            this.c1SplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.c1SplitContainer2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.c1SplitContainer2.Name = "c1SplitContainer2";
            this.c1SplitContainer2.Panels.Add(this.splPan1);
            this.c1SplitContainer2.Panels.Add(this.c1SplitterPanel4);
            this.c1SplitContainer2.Panels.Add(this.splPan2);
            this.c1SplitContainer2.Size = new System.Drawing.Size(123, 686);
            this.c1SplitContainer2.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer2.SplitterMovingColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer2.SplitterWidth = 3;
            this.c1SplitContainer2.TabIndex = 0;
            this.c1SplitContainer2.UseParentVisualStyle = false;
            // 
            // splPan1
            // 
            this.splPan1.Controls.Add(this.chartSalesVsProfit);
            this.splPan1.Height = 311;
            this.splPan1.Location = new System.Drawing.Point(0, 0);
            this.splPan1.MinHeight = 61;
            this.splPan1.MinWidth = 61;
            this.splPan1.Name = "splPan1";
            this.splPan1.Size = new System.Drawing.Size(123, 311);
            this.splPan1.SizeRatio = 45.468D;
            this.splPan1.TabIndex = 0;
            this.splPan1.Width = 123;
            // 
            // c1SplitterPanel4
            // 
            this.c1SplitterPanel4.Controls.Add(this.panGauges1);
            this.c1SplitterPanel4.Controls.Add(this.panel1);
            this.c1SplitterPanel4.Height = 236;
            this.c1SplitterPanel4.Location = new System.Drawing.Point(0, 314);
            this.c1SplitterPanel4.MinHeight = 61;
            this.c1SplitterPanel4.MinWidth = 61;
            this.c1SplitterPanel4.Name = "c1SplitterPanel4";
            this.c1SplitterPanel4.Size = new System.Drawing.Size(123, 236);
            this.c1SplitterPanel4.SizeRatio = 63.881D;
            this.c1SplitterPanel4.TabIndex = 1;
            this.c1SplitterPanel4.Width = 123;
            // 
            // panGauges1
            // 
            this.panGauges1.BackColor = System.Drawing.Color.White;
            this.panGauges1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panGauges1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panGauges1.Location = new System.Drawing.Point(0, 55);
            this.panGauges1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panGauges1.Name = "panGauges1";
            this.panGauges1.Size = new System.Drawing.Size(123, 181);
            this.panGauges1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labUnits1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.panel1.Size = new System.Drawing.Size(123, 55);
            this.panel1.TabIndex = 5;
            // 
            // labUnits1
            // 
            this.labUnits1.AutoSize = true;
            this.labUnits1.BackColor = System.Drawing.Color.White;
            this.labUnits1.Dock = System.Windows.Forms.DockStyle.Right;
            this.labUnits1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labUnits1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.labUnits1.Location = new System.Drawing.Point(42, 5);
            this.labUnits1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUnits1.Name = "labUnits1";
            this.labUnits1.Size = new System.Drawing.Size(81, 29);
            this.labUnits1.TabIndex = 3;
            this.labUnits1.Text = "label1";
            this.labUnits1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // splPan2
            // 
            this.splPan2.Controls.Add(this.panGauges2);
            this.splPan2.Controls.Add(this.panel2);
            this.splPan2.Height = 133;
            this.splPan2.Location = new System.Drawing.Point(0, 553);
            this.splPan2.MinHeight = 61;
            this.splPan2.MinWidth = 61;
            this.splPan2.Name = "splPan2";
            this.splPan2.Size = new System.Drawing.Size(123, 133);
            this.splPan2.TabIndex = 2;
            this.splPan2.Width = 123;
            // 
            // panGauges2
            // 
            this.panGauges2.BackColor = System.Drawing.Color.White;
            this.panGauges2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panGauges2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panGauges2.Location = new System.Drawing.Point(0, 55);
            this.panGauges2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panGauges2.Name = "panGauges2";
            this.panGauges2.Size = new System.Drawing.Size(123, 78);
            this.panGauges2.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labUnits2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(123, 55);
            this.panel2.TabIndex = 4;
            // 
            // labUnits2
            // 
            this.labUnits2.AutoSize = true;
            this.labUnits2.BackColor = System.Drawing.Color.White;
            this.labUnits2.Dock = System.Windows.Forms.DockStyle.Right;
            this.labUnits2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labUnits2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.labUnits2.Location = new System.Drawing.Point(42, 5);
            this.labUnits2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labUnits2.Name = "labUnits2";
            this.labUnits2.Size = new System.Drawing.Size(81, 29);
            this.labUnits2.TabIndex = 4;
            this.labUnits2.Text = "label1";
            this.labUnits2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.Theme = "Office2016Colorful";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.c1SplitContainer1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(15, 15, 15, 0);
            this.Size = new System.Drawing.Size(1390, 880);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartCurrProfitVSPriorProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSalesVsProfit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSaleTopProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTopSaleCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer1)).EndInit();
            this.c1SplitContainer1.ResumeLayout(false);
            this.c1SplitterPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer3)).EndInit();
            this.c1SplitContainer3.ResumeLayout(false);
            this.c1SplitterPanel6.ResumeLayout(false);
            this.c1SplitterPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer4)).EndInit();
            this.c1SplitContainer4.ResumeLayout(false);
            this.c1SplitterPanel8.ResumeLayout(false);
            this.c1SplitterPanel9.ResumeLayout(false);
            this.c1SplitterPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainer2)).EndInit();
            this.c1SplitContainer2.ResumeLayout(false);
            this.splPan1.ResumeLayout(false);
            this.c1SplitterPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splPan2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Chart.FlexChart chartCurrProfitVSPriorProfit;
        private C1.Win.Chart.FlexChart chartSalesVsProfit;
        private C1.Win.Chart.FlexChart chartSaleTopProd;
        private C1.Win.FlexGrid.C1FlexGrid gridTopSaleCustomer;
        private C1.Win.SplitContainer.C1SplitContainer c1SplitContainer1;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel1;
        private C1.Win.SplitContainer.C1SplitContainer c1SplitContainer3;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel6;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel7;
        private C1.Win.SplitContainer.C1SplitContainer c1SplitContainer4;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel8;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel9;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel2;
        private C1.Win.SplitContainer.C1SplitContainer c1SplitContainer2;
        private C1.Win.SplitContainer.C1SplitterPanel splPan1;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel4;
        private C1.Win.SplitContainer.C1SplitterPanel splPan2;
        private System.Windows.Forms.Panel panGauges2;
        private System.Windows.Forms.Panel panGauges1;
        private System.Windows.Forms.Label labUnits1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labUnits2;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
    }
}
