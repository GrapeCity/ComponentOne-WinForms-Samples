using C1.FlexPivot;

namespace DashboardWinForms
{
    partial class Analysis
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
            C1.Win.Themes.C1MaterialThemeSettings c1MaterialThemeSettings7 = new C1.Win.Themes.C1MaterialThemeSettings();
            C1.DataEngine.Workspace workspace2 = C1.Win.FlexPivot.C1FlexPivotPanel.CreateWorkspace();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analysis));
            C1.Win.Themes.C1MaterialThemeSettings c1MaterialThemeSettings8 = new C1.Win.Themes.C1MaterialThemeSettings();
            C1.Win.Themes.C1MaterialThemeSettings c1MaterialThemeSettings9 = new C1.Win.Themes.C1MaterialThemeSettings();
            C1.Chart.ElementSize elementSize2 = new C1.Chart.ElementSize();
            C1.Win.Themes.C1MaterialThemeSettings c1MaterialThemeSettings10 = new C1.Win.Themes.C1MaterialThemeSettings();
            C1.Win.Themes.C1MaterialThemeSettings c1MaterialThemeSettings11 = new C1.Win.Themes.C1MaterialThemeSettings();
            C1.Win.Themes.C1MaterialThemeSettings c1MaterialThemeSettings12 = new C1.Win.Themes.C1MaterialThemeSettings();
            this.OlapPanel = new C1.Win.FlexPivot.C1FlexPivotPanel();
            this.OlapGrid = new C1.Win.FlexPivot.C1FlexPivotGrid();
            this.Map = new C1.Win.Map.C1Map();
            this.c1SplitContainerMain = new C1.Win.SplitContainer.C1SplitContainer();
            this.c1SplitterPanelGrid = new C1.Win.SplitContainer.C1SplitterPanel();
            this.c1SplitterPanel3 = new C1.Win.SplitContainer.C1SplitterPanel();
            this.c1SplitterPanel4 = new C1.Win.SplitContainer.C1SplitterPanel();
            this.chartOpportunities = new C1.Win.Chart.FlexChart();
            this.labProdWise = new System.Windows.Forms.Label();
            this.c1ThemeController1 = new C1.Win.Themes.C1ThemeController();
            this.dfOlap = new C1.Win.DataFilter.C1DataFilter();
            ((System.ComponentModel.ISupportInitialize)(this.OlapPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OlapGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainerMain)).BeginInit();
            this.c1SplitContainerMain.SuspendLayout();
            this.c1SplitterPanelGrid.SuspendLayout();
            this.c1SplitterPanel3.SuspendLayout();
            this.c1SplitterPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOpportunities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dfOlap)).BeginInit();
            this.SuspendLayout();
            // 
            // OlapPanel
            // 
            this.OlapPanel.BackColor = System.Drawing.Color.White;
            this.OlapPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OlapPanel.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.OlapPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.OlapPanel.Location = new System.Drawing.Point(0, 0);
            this.OlapPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OlapPanel.Name = "OlapPanel";
            this.OlapPanel.Size = new System.Drawing.Size(250, 480);
            this.OlapPanel.TabIndex = 0;
            this.c1ThemeController1.SetTheme(this.OlapPanel, "Material");
            c1MaterialThemeSettings7.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            c1MaterialThemeSettings7.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.c1ThemeController1.SetThemeSettings(this.OlapPanel, c1MaterialThemeSettings7);
            workspace2.AutoSave = true;
            workspace2.KeepFiles = C1.DataEngine.KeepFileType.Results;
            this.OlapPanel.Workspace = workspace2;
            // 
            // OlapGrid
            // 
            this.OlapGrid.AllowMerging = C1.Win.FlexGrid.AllowMergingEnum.FixedOnly;
            this.OlapGrid.AllowMergingFixed = C1.Win.FlexGrid.AllowMergingEnum.Default;
            this.OlapGrid.BackColor = System.Drawing.Color.White;
            this.OlapGrid.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.OlapGrid.ColumnInfo = resources.GetString("OlapGrid.ColumnInfo");
            this.OlapGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OlapGrid.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            this.OlapGrid.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.OlapGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.OlapGrid.Location = new System.Drawing.Point(0, 0);
            this.OlapGrid.Name = "OlapGrid";
            this.OlapGrid.Rows.DefaultSize = 37;
            this.OlapGrid.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None;
            this.OlapGrid.Size = new System.Drawing.Size(434, 542);
            this.OlapGrid.StyleInfo = resources.GetString("OlapGrid.StyleInfo");
            this.OlapGrid.SubtotalBackground = System.Drawing.Color.Empty;
            this.OlapGrid.SubtotalForeground = System.Drawing.Color.Empty;
            this.OlapGrid.TabIndex = 1;
            this.c1ThemeController1.SetTheme(this.OlapGrid, "Material");
            c1MaterialThemeSettings8.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            c1MaterialThemeSettings8.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.c1ThemeController1.SetThemeSettings(this.OlapGrid, c1MaterialThemeSettings8);
            this.OlapGrid.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            // 
            // Map
            // 
            this.Map.BackColor = System.Drawing.Color.White;
            this.Map.DistanceScale.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            this.Map.DistanceScale.BarStyle.BackColor = System.Drawing.Color.Black;
            this.Map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Map.Location = new System.Drawing.Point(0, 0);
            this.Map.Name = "Map";
            this.Map.PanTool.MarkerStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(176)))), ((int)(((byte)(202)))));
            this.Map.PanTool.MarkerStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(224)))), ((int)(((byte)(245)))));
            this.Map.PanTool.MarkerStyle.GradientStyle = C1.Win.Map.GradientStyle.Vertical;
            this.Map.PanTool.PanStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Map.PanTool.PanStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Map.PanTool.PanStyle.GradientStyle = C1.Win.Map.GradientStyle.Vertical;
            this.Map.PanTool.PanStyle.Stroke.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.Map.PanTool.PanStyle.Stroke.Width = 1F;
            this.Map.Proxy = null;
            this.Map.Size = new System.Drawing.Size(434, 269);
            this.Map.TabIndex = 2;
            this.Map.Text = "c1Map1";
            this.Map.Viewport.Padding = new System.Windows.Forms.Padding(3);
            this.Map.Viewport.Zoom = 2D;
            this.Map.Viewport.Center = new C1.Win.Interop.Point(-100D, 40D);
            this.Map.ZoomTool.ButtonStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Map.ZoomTool.ButtonStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Map.ZoomTool.ButtonStyle.Border.Bottom.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.Map.ZoomTool.ButtonStyle.Border.Bottom.Width = 1F;
            this.Map.ZoomTool.ButtonStyle.Border.Left.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.Map.ZoomTool.ButtonStyle.Border.Left.Width = 1F;
            this.Map.ZoomTool.ButtonStyle.Border.Right.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.Map.ZoomTool.ButtonStyle.Border.Right.Width = 1F;
            this.Map.ZoomTool.ButtonStyle.Border.RoundRadius.BottomLeft = 3;
            this.Map.ZoomTool.ButtonStyle.Border.RoundRadius.BottomRight = 3;
            this.Map.ZoomTool.ButtonStyle.Border.RoundRadius.TopLeft = 3;
            this.Map.ZoomTool.ButtonStyle.Border.RoundRadius.TopRight = 3;
            this.Map.ZoomTool.ButtonStyle.Border.Top.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.Map.ZoomTool.ButtonStyle.Border.Top.Width = 1F;
            this.Map.ZoomTool.ButtonStyle.GradientStyle = C1.Win.Map.GradientStyle.Vertical;
            this.Map.ZoomTool.Margin = new System.Windows.Forms.Padding(20, 70, 0, 0);
            this.Map.ZoomTool.ThumbStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.Map.ZoomTool.ThumbStyle.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(176)))), ((int)(((byte)(202)))));
            this.Map.ZoomTool.ThumbStyle.Border.Bottom.Color = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(198)))));
            this.Map.ZoomTool.ThumbStyle.Border.Bottom.Width = 1F;
            this.Map.ZoomTool.ThumbStyle.Border.Left.Color = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(198)))));
            this.Map.ZoomTool.ThumbStyle.Border.Left.Width = 1F;
            this.Map.ZoomTool.ThumbStyle.Border.Right.Color = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(198)))));
            this.Map.ZoomTool.ThumbStyle.Border.Right.Width = 1F;
            this.Map.ZoomTool.ThumbStyle.Border.RoundRadius.BottomLeft = 3;
            this.Map.ZoomTool.ThumbStyle.Border.RoundRadius.BottomRight = 3;
            this.Map.ZoomTool.ThumbStyle.Border.RoundRadius.TopLeft = 3;
            this.Map.ZoomTool.ThumbStyle.Border.RoundRadius.TopRight = 3;
            this.Map.ZoomTool.ThumbStyle.Border.Top.Color = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(176)))), ((int)(((byte)(198)))));
            this.Map.ZoomTool.ThumbStyle.Border.Top.Width = 1F;
            this.Map.ZoomTool.ThumbStyle.GradientStyle = C1.Win.Map.GradientStyle.Vertical;
            this.Map.ZoomTool.TrackStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.Map.ZoomTool.TrackStyle.Border.Bottom.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.Map.ZoomTool.TrackStyle.Border.Bottom.Width = 1F;
            this.Map.ZoomTool.TrackStyle.Border.Left.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.Map.ZoomTool.TrackStyle.Border.Left.Width = 1F;
            this.Map.ZoomTool.TrackStyle.Border.Right.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.Map.ZoomTool.TrackStyle.Border.Right.Width = 1F;
            this.Map.ZoomTool.TrackStyle.Border.RoundRadius.BottomLeft = 3;
            this.Map.ZoomTool.TrackStyle.Border.RoundRadius.BottomRight = 3;
            this.Map.ZoomTool.TrackStyle.Border.RoundRadius.TopLeft = 3;
            this.Map.ZoomTool.TrackStyle.Border.RoundRadius.TopRight = 3;
            this.Map.ZoomTool.TrackStyle.Border.Top.Color = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.Map.ZoomTool.TrackStyle.Border.Top.Width = 1F;
            // 
            // c1SplitContainer1
            // 
            this.c1SplitContainerMain.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1SplitContainerMain.BackColor = System.Drawing.Color.White;
            this.c1SplitContainerMain.CollapsingAreaColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.c1SplitContainerMain.CollapsingCueColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.c1SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1SplitContainerMain.FixedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.c1SplitContainerMain.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.c1SplitContainerMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.c1SplitContainerMain.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.c1SplitContainerMain.HeaderLineWidth = 1;
            this.c1SplitContainerMain.Location = new System.Drawing.Point(10, 10);
            this.c1SplitContainerMain.Name = "c1SplitContainer1";
            this.c1SplitContainerMain.Panels.Add(this.c1SplitterPanelGrid);
            this.c1SplitContainerMain.Panels.Add(this.c1SplitterPanel3);
            this.c1SplitContainerMain.Panels.Add(this.c1SplitterPanel4);
            this.c1SplitContainerMain.Size = new System.Drawing.Size(872, 542);
            this.c1SplitContainerMain.SplitterColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.c1SplitContainerMain.SplitterMovingColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.c1SplitContainerMain.TabIndex = 3;
            this.c1ThemeController1.SetTheme(this.c1SplitContainerMain, "Material");
            c1MaterialThemeSettings9.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            c1MaterialThemeSettings9.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.c1ThemeController1.SetThemeSettings(this.c1SplitContainerMain, c1MaterialThemeSettings9);            
            // 
            // c1SplitterPanel2
            // 
            this.c1SplitterPanelGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.c1SplitterPanelGrid.Controls.Add(this.OlapGrid);
            this.c1SplitterPanelGrid.Dock = C1.Win.SplitContainer.PanelDockStyle.Left;
            this.c1SplitterPanelGrid.Location = new System.Drawing.Point(0, 0);
            this.c1SplitterPanelGrid.Name = "c1SplitterPanel2";
            this.c1SplitterPanelGrid.Size = new System.Drawing.Size(434, 542);
            this.c1SplitterPanelGrid.TabIndex = 1;
            this.c1SplitterPanelGrid.Width = 434;
            // 
            // c1SplitterPanel3
            // 
            this.c1SplitterPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.c1SplitterPanel3.Controls.Add(this.Map);
            this.c1SplitterPanel3.Height = 269;
            this.c1SplitterPanel3.Location = new System.Drawing.Point(438, 0);
            this.c1SplitterPanel3.Name = "c1SplitterPanel3";
            this.c1SplitterPanel3.Size = new System.Drawing.Size(434, 269);
            this.c1SplitterPanel3.TabIndex = 2;
            // 
            // c1SplitterPanel4
            // 
            this.c1SplitterPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(242)))));
            this.c1SplitterPanel4.Controls.Add(this.chartOpportunities);
            this.c1SplitterPanel4.Height = 269;
            this.c1SplitterPanel4.Location = new System.Drawing.Point(438, 273);
            this.c1SplitterPanel4.Name = "c1SplitterPanel4";
            this.c1SplitterPanel4.Size = new System.Drawing.Size(434, 269);
            this.c1SplitterPanel4.TabIndex = 3;
            // 
            // chartOpportunities
            // 
            this.chartOpportunities.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            this.chartOpportunities.AnimationLoad.Duration = 400;
            this.chartOpportunities.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            this.chartOpportunities.AnimationLoad.Type = C1.Chart.AnimationType.All;
            this.chartOpportunities.AnimationSettings = C1.Chart.AnimationSettings.None;
            this.chartOpportunities.AnimationUpdate.Duration = 400;
            this.chartOpportunities.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            this.chartOpportunities.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            this.chartOpportunities.AxisX.Chart = this.chartOpportunities;
            this.chartOpportunities.AxisX.DataSource = null;
            this.chartOpportunities.AxisX.GroupProvider = null;
            this.chartOpportunities.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.chartOpportunities.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.chartOpportunities.AxisX.GroupVisibilityLevel = 0;
            this.chartOpportunities.AxisX.LabelMax = false;
            this.chartOpportunities.AxisX.LabelMin = false;
            this.chartOpportunities.AxisX.PlotAreaName = null;
            this.chartOpportunities.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            this.chartOpportunities.AxisY.Chart = this.chartOpportunities;
            this.chartOpportunities.AxisY.DataSource = null;
            this.chartOpportunities.AxisY.GroupProvider = null;
            this.chartOpportunities.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.chartOpportunities.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.chartOpportunities.AxisY.GroupVisibilityLevel = 0;
            this.chartOpportunities.AxisY.LabelMax = false;
            this.chartOpportunities.AxisY.LabelMin = false;
            this.chartOpportunities.AxisY.PlotAreaName = null;
            this.chartOpportunities.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            this.chartOpportunities.BackColor = System.Drawing.Color.White;
            this.chartOpportunities.DataLabel.Angle = 0;
            this.chartOpportunities.DataLabel.Border = false;
            this.chartOpportunities.DataLabel.ConnectingLine = false;
            this.chartOpportunities.DataLabel.Content = null;
            this.chartOpportunities.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            this.chartOpportunities.DataLabel.MaxAutoLabels = 100;
            this.chartOpportunities.DataLabel.MaxLines = 0;
            this.chartOpportunities.DataLabel.MaxWidth = 0;
            this.chartOpportunities.DataLabel.Offset = 0;
            this.chartOpportunities.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            this.chartOpportunities.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            this.chartOpportunities.DataLabel.Position = C1.Chart.LabelPosition.None;
            this.chartOpportunities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartOpportunities.ForeColor = System.Drawing.Color.Black;
            this.chartOpportunities.Legend.ItemMaxWidth = 0;
            this.chartOpportunities.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.chartOpportunities.Legend.Position = C1.Chart.Position.Bottom;
            this.chartOpportunities.Legend.Reversed = false;
            this.chartOpportunities.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.chartOpportunities.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.chartOpportunities.Legend.Title = null;
            this.chartOpportunities.Location = new System.Drawing.Point(0, 0);
            this.chartOpportunities.Margin = new System.Windows.Forms.Padding(10);
            this.chartOpportunities.Name = "chartOpportunities";
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            this.chartOpportunities.Options.ClusterSize = elementSize2;
            this.chartOpportunities.PlotMargin = new System.Windows.Forms.Padding(0);
            this.chartOpportunities.SelectedSeries = null;
            this.chartOpportunities.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.chartOpportunities.Size = new System.Drawing.Size(434, 269);
            this.chartOpportunities.TabIndex = 1;
            // 
            // 
            // 
            this.chartOpportunities.ToolTip.Content = "{value}";
            // 
            // labProdWise
            // 
            this.labProdWise.AutoSize = true;
            this.labProdWise.Dock = System.Windows.Forms.DockStyle.Top;
            this.labProdWise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labProdWise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.labProdWise.Location = new System.Drawing.Point(10, 5);
            this.labProdWise.Margin = new System.Windows.Forms.Padding(3);
            this.labProdWise.Name = "labProdWise";
            this.labProdWise.Size = new System.Drawing.Size(60, 24);
            this.labProdWise.TabIndex = 2;
            this.labProdWise.Text = "label1";
            this.c1ThemeController1.SetTheme(this.labProdWise, "Material");
            c1MaterialThemeSettings10.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            c1MaterialThemeSettings10.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.c1ThemeController1.SetThemeSettings(this.labProdWise, c1MaterialThemeSettings10);
            // 
            // c1ThemeController1
            // 
            this.c1ThemeController1.Theme = "Material";
            // 
            // dfOlap
            // 
            this.dfOlap.Location = new System.Drawing.Point(0, 0);
            this.dfOlap.Name = "dfOlap";
            this.dfOlap.ShowHeader = false;
            this.dfOlap.Size = new System.Drawing.Size(500, 500);
            this.dfOlap.Styles.Button.Font = null;
            this.dfOlap.Styles.CheckBox.Font = null;
            this.dfOlap.Styles.Editor.Font = null;
            this.dfOlap.Styles.Filter.Font = null;
            this.dfOlap.Styles.FilterCaption.Font = null;
            this.dfOlap.Styles.Header.Font = null;
            this.dfOlap.TabIndex = 0;
            this.dfOlap.Text = "c1DataFilter1";
            this.c1ThemeController1.SetTheme(this.dfOlap, "Material");
            c1MaterialThemeSettings11.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            c1MaterialThemeSettings11.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.c1ThemeController1.SetThemeSettings(this.dfOlap, c1MaterialThemeSettings11);
            // 
            // Analysis
            // 
            this.Controls.Add(this.c1SplitContainerMain);
            this.Font = new System.Drawing.Font("Segoe UI", 11.5F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Name = "Analysis";
            this.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.Size = new System.Drawing.Size(892, 552);
            this.c1ThemeController1.SetTheme(this, "Material");
            c1MaterialThemeSettings12.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(0)))), ((int)(((byte)(238)))));
            c1MaterialThemeSettings12.SecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.c1ThemeController1.SetThemeSettings(this, c1MaterialThemeSettings12);
            this.Load += new System.EventHandler(this.Analysis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OlapPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OlapGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Map)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SplitContainerMain)).EndInit();
            this.c1SplitContainerMain.ResumeLayout(false);
            this.c1SplitterPanelGrid.ResumeLayout(false);
            this.c1SplitterPanel3.ResumeLayout(false);
            this.c1SplitterPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartOpportunities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dfOlap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.FlexPivot.C1FlexPivotPanel OlapPanel;
        private C1.Win.FlexPivot.C1FlexPivotGrid OlapGrid;
        private C1.Win.Map.C1Map Map;
        private C1.Win.SplitContainer.C1SplitContainer c1SplitContainerMain;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanelGrid;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel3;
        private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel4;
        private C1.Win.Chart.FlexChart chartOpportunities;
        private C1.Win.Themes.C1ThemeController c1ThemeController1;
        private System.Windows.Forms.Label labProdWise;
        private C1.Win.DataFilter.C1DataFilter dfOlap;
    }
}
