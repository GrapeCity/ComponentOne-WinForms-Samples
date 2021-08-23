using C1.Win.C1Gauge;

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
            C1.Win.C1FlexGrid.FooterDescription footerDescription1 = new C1.Win.C1FlexGrid.FooterDescription();
            C1.Win.C1FlexGrid.AggregateDefinition aggregateDefinition1 = new C1.Win.C1FlexGrid.AggregateDefinition();
            C1.Win.C1FlexGrid.AggregateDefinition aggregateDefinition2 = new C1.Win.C1FlexGrid.AggregateDefinition();
            C1.Win.C1FlexGrid.AggregateDefinition aggregateDefinition3 = new C1.Win.C1FlexGrid.AggregateDefinition();
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            C1.Chart.ElementSize elementSize2 = new C1.Chart.ElementSize();
            C1.Chart.ElementSize elementSize3 = new C1.Chart.ElementSize();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.chartCurrProfitVSPriorProfit = new C1.Win.Chart.FlexChart();
            this.chartSalesVsProfit = new C1.Win.Chart.FlexChart();
            this.chartSaleTopProd = new C1.Win.Chart.FlexChart();
            this.gridTopSaleCustomer = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.c1SplitContainer1 = new C1.Win.C1SplitContainer.C1SplitContainer();
            this.c1SplitterPanel1 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1SplitContainer3 = new C1.Win.C1SplitContainer.C1SplitContainer();
            this.c1SplitterPanel6 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1SplitterPanel7 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1SplitContainer4 = new C1.Win.C1SplitContainer.C1SplitContainer();
            this.c1SplitterPanel8 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1SplitterPanel9 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1SplitterPanel2 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1SplitContainer2 = new C1.Win.C1SplitContainer.C1SplitContainer();
            this.splPan1 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.c1SplitterPanel4 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.panGauges1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labUnits1 = new System.Windows.Forms.Label();
            this.splPan2 = new C1.Win.C1SplitContainer.C1SplitterPanel();
            this.panGauges2 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labUnits2 = new System.Windows.Forms.Label();
            this.c1ThemeController1 = new C1.Win.C1Themes.C1ThemeController();
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
            this.chartCurrProfitVSPriorProfit.AxisX.Chart = this.chartCurrProfitVSPriorProfit;
            this.chartCurrProfitVSPriorProfit.AxisX.DataSource = null;
            this.chartCurrProfitVSPriorProfit.AxisX.PlotAreaName = null;
            this.chartCurrProfitVSPriorProfit.AxisY.Chart = this.chartCurrProfitVSPriorProfit;
            this.chartCurrProfitVSPriorProfit.AxisY.DataSource = null;
            this.chartCurrProfitVSPriorProfit.AxisY.PlotAreaName = null;
            this.chartCurrProfitVSPriorProfit.BackColor = System.Drawing.Color.White;
            this.chartCurrProfitVSPriorProfit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartCurrProfitVSPriorProfit.ForeColor = System.Drawing.Color.Black;
            this.chartCurrProfitVSPriorProfit.Legend.ItemMaxWidth = 0;
            this.chartCurrProfitVSPriorProfit.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.chartCurrProfitVSPriorProfit.Legend.Position = C1.Chart.Position.Right;
            this.chartCurrProfitVSPriorProfit.Legend.Reversed = false;
            this.chartCurrProfitVSPriorProfit.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.chartCurrProfitVSPriorProfit.Legend.Title = null;
            this.chartCurrProfitVSPriorProfit.Location = new System.Drawing.Point(0, 0);
            this.chartCurrProfitVSPriorProfit.Margin = new System.Windows.Forms.Padding(10);
            this.chartCurrProfitVSPriorProfit.Name = "chartCurrProfitVSPriorProfit";
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.chartCurrProfitVSPriorProfit.Options.ClusterSize = elementSize1;
            this.chartCurrProfitVSPriorProfit.PlotMargin = new System.Windows.Forms.Padding(0);
            this.chartCurrProfitVSPriorProfit.SelectedSeries = null;
            this.chartCurrProfitVSPriorProfit.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.chartCurrProfitVSPriorProfit.Size = new System.Drawing.Size(553, 235);
            this.chartCurrProfitVSPriorProfit.TabIndex = 0;
            // 
            // 
            // 
            this.chartCurrProfitVSPriorProfit.ToolTip.Content = "{value}";
            // 
            // chartSalesVsProfit
            // 
            this.chartSalesVsProfit.AxisX.Chart = this.chartSalesVsProfit;
            this.chartSalesVsProfit.AxisX.DataSource = null;
            this.chartSalesVsProfit.AxisX.PlotAreaName = null;
            this.chartSalesVsProfit.AxisY.Chart = this.chartSalesVsProfit;
            this.chartSalesVsProfit.AxisY.DataSource = null;
            this.chartSalesVsProfit.AxisY.PlotAreaName = null;
            this.chartSalesVsProfit.BackColor = System.Drawing.Color.White;
            this.chartSalesVsProfit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartSalesVsProfit.ForeColor = System.Drawing.Color.Black;
            this.chartSalesVsProfit.Legend.ItemMaxWidth = 0;
            this.chartSalesVsProfit.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.chartSalesVsProfit.Legend.Position = C1.Chart.Position.Bottom;
            this.chartSalesVsProfit.Legend.Reversed = false;
            this.chartSalesVsProfit.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.chartSalesVsProfit.Legend.Title = null;
            this.chartSalesVsProfit.Location = new System.Drawing.Point(0, 0);
            this.chartSalesVsProfit.Margin = new System.Windows.Forms.Padding(10);
            this.chartSalesVsProfit.Name = "chartSalesVsProfit";
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            this.chartSalesVsProfit.Options.ClusterSize = elementSize2;
            this.chartSalesVsProfit.PlotMargin = new System.Windows.Forms.Padding(0);
            this.chartSalesVsProfit.SelectedSeries = null;
            this.chartSalesVsProfit.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.chartSalesVsProfit.Size = new System.Drawing.Size(369, 133);
            this.chartSalesVsProfit.TabIndex = 2;
            // 
            // 
            // 
            this.chartSalesVsProfit.ToolTip.Content = "{value}";
            // 
            // chartSaleTopProd
            // 
            this.chartSaleTopProd.AxisX.Chart = this.chartSaleTopProd;
            this.chartSaleTopProd.AxisX.DataSource = null;
            this.chartSaleTopProd.AxisX.PlotAreaName = null;
            this.chartSaleTopProd.AxisY.Chart = this.chartSaleTopProd;
            this.chartSaleTopProd.AxisY.DataSource = null;
            this.chartSaleTopProd.AxisY.PlotAreaName = null;
            this.chartSaleTopProd.BackColor = System.Drawing.Color.White;
            this.chartSaleTopProd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartSaleTopProd.ForeColor = System.Drawing.Color.Black;
            this.chartSaleTopProd.Legend.ItemMaxWidth = 0;
            this.chartSaleTopProd.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.chartSaleTopProd.Legend.Position = C1.Chart.Position.Right;
            this.chartSaleTopProd.Legend.Reversed = false;
            this.chartSaleTopProd.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.chartSaleTopProd.Legend.Title = null;
            this.chartSaleTopProd.Location = new System.Drawing.Point(0, 0);
            this.chartSaleTopProd.Margin = new System.Windows.Forms.Padding(10);
            this.chartSaleTopProd.Name = "chartSaleTopProd";
            elementSize3.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize3.Value = 70D;
            this.chartSaleTopProd.Options.ClusterSize = elementSize3;
            this.chartSaleTopProd.PlotMargin = new System.Windows.Forms.Padding(0);
            this.chartSaleTopProd.SelectedSeries = null;
            this.chartSaleTopProd.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.chartSaleTopProd.Size = new System.Drawing.Size(276, 209);
            this.chartSaleTopProd.TabIndex = 3;
            // 
            // 
            // 
            this.chartSaleTopProd.ToolTip.Content = "{value}";
            // 
            // gridTopSaleCustomer
            // 
            this.gridTopSaleCustomer.BackColor = System.Drawing.Color.White;
            this.gridTopSaleCustomer.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.gridTopSaleCustomer.ColumnInfo = "10,1,0,0,0,120,Columns:";
            aggregateDefinition1.PropertyName = "Name";
            aggregateDefinition1.Caption = "Total:";
            aggregateDefinition2.PropertyName = "Sales";
            aggregateDefinition2.Caption = "{0:C0}";
            aggregateDefinition2.Aggregate = C1.Win.C1FlexGrid.AggregateEnum.Sum;
            aggregateDefinition3.PropertyName = "Profit";
            aggregateDefinition3.Caption = "{0:C0}";
            aggregateDefinition3.Aggregate = C1.Win.C1FlexGrid.AggregateEnum.Sum;
            footerDescription1.Aggregates.Add(aggregateDefinition1);
            footerDescription1.Aggregates.Add(aggregateDefinition2);
            footerDescription1.Aggregates.Add(aggregateDefinition3);
            this.gridTopSaleCustomer.Footers.Descriptions.Add(footerDescription1);
            this.gridTopSaleCustomer.Footers.Fixed = true;
            this.gridTopSaleCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTopSaleCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.gridTopSaleCustomer.Location = new System.Drawing.Point(0, 40);
            this.gridTopSaleCustomer.Name = "gridTopSaleCustomer";
            this.gridTopSaleCustomer.ShowThemedHeaders = C1.Win.C1FlexGrid.ShowThemedHeadersEnum.None;
            this.gridTopSaleCustomer.Size = new System.Drawing.Size(275, 169);
            this.gridTopSaleCustomer.StyleInfo = resources.GetString("gridTopSaleCustomer.StyleInfo");
            this.gridTopSaleCustomer.TabIndex = 4;
            this.c1ThemeController1.SetTheme(this.gridTopSaleCustomer, "Material");
            this.gridTopSaleCustomer.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.gridTopSaleCustomer.Visible = false;
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainer1.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1SplitContainer1.BackColor = System.Drawing.Color.White;
            this.c1SplitContainer1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer1.CollapsingAreaColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.c1SplitContainer1.CollapsingCueColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer1.FixedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.c1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer1.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer1.HeaderLineWidth = 1;
            this.c1SplitContainer1.Location = new System.Drawing.Point(3, 0);
            this.c1SplitContainer1.Name = "c1SplitContainer1";
            this.c1SplitContainer1.Panels.Add(this.c1SplitterPanel1);
            this.c1SplitContainer1.Panels.Add(this.c1SplitterPanel2);
            this.c1SplitContainer1.Size = new System.Drawing.Size(924, 446);
            this.c1SplitContainer1.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer1.SplitterMovingColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer1.SplitterWidth = 2;
            this.c1SplitContainer1.TabIndex = 5;
            this.c1SplitContainer1.UseParentVisualStyle = false;
            // 
            // c1SplitterPanel1
            // 
            this.c1SplitterPanel1.Controls.Add(this.c1SplitContainer3);
            this.c1SplitterPanel1.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left;
            this.c1SplitterPanel1.Location = new System.Drawing.Point(0, 0);
            this.c1SplitterPanel1.Name = "c1SplitterPanel1";
            this.c1SplitterPanel1.Size = new System.Drawing.Size(553, 446);
            this.c1SplitterPanel1.SizeRatio = 60D;
            this.c1SplitterPanel1.TabIndex = 0;
            this.c1SplitterPanel1.Width = 553;
            // 
            // c1SplitContainer3
            // 
            this.c1SplitContainer3.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1SplitContainer3.BackColor = System.Drawing.Color.White;
            this.c1SplitContainer3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer3.CollapsingAreaColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.c1SplitContainer3.CollapsingCueColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1SplitContainer3.FixedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.c1SplitContainer3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer3.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer3.HeaderLineWidth = 1;
            this.c1SplitContainer3.Location = new System.Drawing.Point(0, 0);
            this.c1SplitContainer3.Name = "c1SplitContainer3";
            this.c1SplitContainer3.Panels.Add(this.c1SplitterPanel6);
            this.c1SplitContainer3.Panels.Add(this.c1SplitterPanel7);
            this.c1SplitContainer3.Size = new System.Drawing.Size(553, 446);
            this.c1SplitContainer3.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer3.SplitterMovingColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer3.SplitterWidth = 2;
            this.c1SplitContainer3.TabIndex = 0;
            this.c1SplitContainer3.UseParentVisualStyle = false;
            // 
            // c1SplitterPanel6
            // 
            this.c1SplitterPanel6.Controls.Add(this.chartCurrProfitVSPriorProfit);
            this.c1SplitterPanel6.Height = 235;
            this.c1SplitterPanel6.Location = new System.Drawing.Point(0, 0);
            this.c1SplitterPanel6.Name = "c1SplitterPanel6";
            this.c1SplitterPanel6.Size = new System.Drawing.Size(553, 235);
            this.c1SplitterPanel6.SizeRatio = 43D;
            this.c1SplitterPanel6.TabIndex = 0;
            // 
            // c1SplitterPanel7
            // 
            this.c1SplitterPanel7.Controls.Add(this.c1SplitContainer4);
            this.c1SplitterPanel7.Height = 209;
            this.c1SplitterPanel7.Location = new System.Drawing.Point(0, 237);
            this.c1SplitterPanel7.Name = "c1SplitterPanel7";
            this.c1SplitterPanel7.Size = new System.Drawing.Size(553, 209);
            this.c1SplitterPanel7.TabIndex = 1;
            // 
            // c1SplitContainer4
            // 
            this.c1SplitContainer4.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1SplitContainer4.BackColor = System.Drawing.Color.White;
            this.c1SplitContainer4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer4.CollapsingAreaColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.c1SplitContainer4.CollapsingCueColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1SplitContainer4.FixedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer4.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.c1SplitContainer4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer4.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer4.HeaderLineWidth = 1;
            this.c1SplitContainer4.Location = new System.Drawing.Point(0, 0);
            this.c1SplitContainer4.Name = "c1SplitContainer4";
            this.c1SplitContainer4.Panels.Add(this.c1SplitterPanel8);
            this.c1SplitContainer4.Panels.Add(this.c1SplitterPanel9);
            this.c1SplitContainer4.Size = new System.Drawing.Size(553, 209);
            this.c1SplitContainer4.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer4.SplitterMovingColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer4.SplitterWidth = 2;
            this.c1SplitContainer4.TabIndex = 0;
            this.c1SplitContainer4.UseParentVisualStyle = false;
            // 
            // c1SplitterPanel8
            // 
            this.c1SplitterPanel8.Controls.Add(this.chartSaleTopProd);
            this.c1SplitterPanel8.Dock = C1.Win.C1SplitContainer.PanelDockStyle.Left;
            this.c1SplitterPanel8.Location = new System.Drawing.Point(0, 0);
            this.c1SplitterPanel8.Name = "c1SplitterPanel8";
            this.c1SplitterPanel8.Size = new System.Drawing.Size(276, 209);
            this.c1SplitterPanel8.TabIndex = 0;
            this.c1SplitterPanel8.Width = 276;
            // 
            // c1SplitterPanel9
            // 
            this.c1SplitterPanel9.Controls.Add(this.gridTopSaleCustomer);
            this.c1SplitterPanel9.Height = 209;
            this.c1SplitterPanel9.Location = new System.Drawing.Point(278, 0);
            this.c1SplitterPanel9.Name = "c1SplitterPanel9";
            this.c1SplitterPanel9.Size = new System.Drawing.Size(275, 209);
            this.c1SplitterPanel9.TabIndex = 1;
            // 
            // c1SplitterPanel2
            // 
            this.c1SplitterPanel2.Controls.Add(this.c1SplitContainer2);
            this.c1SplitterPanel2.Height = 446;
            this.c1SplitterPanel2.Location = new System.Drawing.Point(555, 0);
            this.c1SplitterPanel2.Name = "c1SplitterPanel2";
            this.c1SplitterPanel2.Size = new System.Drawing.Size(369, 446);
            this.c1SplitterPanel2.TabIndex = 1;
            // 
            // c1SplitContainer2
            // 
            this.c1SplitContainer2.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1SplitContainer2.BackColor = System.Drawing.Color.White;
            this.c1SplitContainer2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer2.CollapsingAreaColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.c1SplitContainer2.CollapsingCueColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1SplitContainer2.FixedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.c1SplitContainer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer2.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer2.HeaderLineWidth = 1;
            this.c1SplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.c1SplitContainer2.Name = "c1SplitContainer2";
            this.c1SplitContainer2.Panels.Add(this.splPan1);
            this.c1SplitContainer2.Panels.Add(this.c1SplitterPanel4);
            this.c1SplitContainer2.Panels.Add(this.splPan2);
            this.c1SplitContainer2.Size = new System.Drawing.Size(369, 446);
            this.c1SplitContainer2.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.c1SplitContainer2.SplitterMovingColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.c1SplitContainer2.SplitterWidth = 2;
            this.c1SplitContainer2.TabIndex = 0;
            this.c1SplitContainer2.UseParentVisualStyle = false;
            // 
            // splPan1
            // 
            this.splPan1.Controls.Add(this.chartSalesVsProfit);
            this.splPan1.Height = 133;
            this.splPan1.Location = new System.Drawing.Point(0, 0);
            this.splPan1.Name = "splPan1";
            this.splPan1.Size = new System.Drawing.Size(369, 133);
            this.splPan1.SizeRatio = 30D;
            this.splPan1.TabIndex = 0;
            // 
            // c1SplitterPanel4
            // 
            this.c1SplitterPanel4.Controls.Add(this.panGauges1);
            this.c1SplitterPanel4.Controls.Add(this.panel1);
            this.c1SplitterPanel4.Height = 154;
            this.c1SplitterPanel4.Location = new System.Drawing.Point(0, 135);
            this.c1SplitterPanel4.Name = "c1SplitterPanel4";
            this.c1SplitterPanel4.Size = new System.Drawing.Size(369, 154);
            this.c1SplitterPanel4.SizeRatio = 42D;
            this.c1SplitterPanel4.TabIndex = 1;
            // 
            // panGauges1
            // 
            this.panGauges1.BackColor = System.Drawing.Color.White;
            this.panGauges1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panGauges1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panGauges1.Location = new System.Drawing.Point(0, 36);
            this.panGauges1.Name = "panGauges1";
            this.panGauges1.Size = new System.Drawing.Size(369, 118);
            this.panGauges1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labUnits1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 3, 0, 0);
            this.panel1.Size = new System.Drawing.Size(369, 36);
            this.panel1.TabIndex = 5;
            // 
            // labUnits1
            // 
            this.labUnits1.AutoSize = true;
            this.labUnits1.BackColor = System.Drawing.Color.White;
            this.labUnits1.Dock = System.Windows.Forms.DockStyle.Right;
            this.labUnits1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labUnits1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.labUnits1.Location = new System.Drawing.Point(309, 3);
            this.labUnits1.Name = "labUnits1";
            this.labUnits1.Size = new System.Drawing.Size(60, 24);
            this.labUnits1.TabIndex = 3;
            this.labUnits1.Text = "label1";
            this.labUnits1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // splPan2
            // 
            this.splPan2.Controls.Add(this.panGauges2);
            this.splPan2.Controls.Add(this.panel2);
            this.splPan2.Height = 155;
            this.splPan2.Location = new System.Drawing.Point(0, 291);
            this.splPan2.Name = "splPan2";
            this.splPan2.Size = new System.Drawing.Size(369, 155);
            this.splPan2.TabIndex = 2;
            // 
            // panGauges2
            // 
            this.panGauges2.BackColor = System.Drawing.Color.White;
            this.panGauges2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panGauges2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panGauges2.Location = new System.Drawing.Point(0, 36);
            this.panGauges2.Name = "panGauges2";
            this.panGauges2.Size = new System.Drawing.Size(369, 119);
            this.panGauges2.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.labUnits2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 3, 0, 0);
            this.panel2.Size = new System.Drawing.Size(369, 36);
            this.panel2.TabIndex = 4;
            // 
            // labUnits2
            // 
            this.labUnits2.AutoSize = true;
            this.labUnits2.BackColor = System.Drawing.Color.White;
            this.labUnits2.Dock = System.Windows.Forms.DockStyle.Right;
            this.labUnits2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labUnits2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.labUnits2.Location = new System.Drawing.Point(309, 3);
            this.labUnits2.Name = "labUnits2";
            this.labUnits2.Size = new System.Drawing.Size(60, 24);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1SplitContainer1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.Size = new System.Drawing.Size(927, 572);
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
        private C1.Win.C1FlexGrid.C1FlexGrid gridTopSaleCustomer;
        private C1.Win.C1SplitContainer.C1SplitContainer c1SplitContainer1;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel1;
        private C1.Win.C1SplitContainer.C1SplitContainer c1SplitContainer3;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel6;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel7;
        private C1.Win.C1SplitContainer.C1SplitContainer c1SplitContainer4;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel8;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel9;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel2;
        private C1.Win.C1SplitContainer.C1SplitContainer c1SplitContainer2;
        private C1.Win.C1SplitContainer.C1SplitterPanel splPan1;
        private C1.Win.C1SplitContainer.C1SplitterPanel c1SplitterPanel4;
        private C1.Win.C1SplitContainer.C1SplitterPanel splPan2;
        private System.Windows.Forms.Panel panGauges2;
        private System.Windows.Forms.Panel panGauges1;
        private System.Windows.Forms.Label labUnits1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labUnits2;
        private C1.Win.C1Themes.C1ThemeController c1ThemeController1;
    }
}
