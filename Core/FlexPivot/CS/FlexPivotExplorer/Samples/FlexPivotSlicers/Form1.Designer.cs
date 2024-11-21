namespace FlexPivotExplorer.Samples.FlexPivotSlicers
{
	partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            ribbonButton1 = new C1.Win.Ribbon.RibbonButton();
            ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            ribbonGallery1 = new C1.Win.Ribbon.RibbonGallery();
            ribbonTab2 = new C1.Win.Ribbon.RibbonTab();
            ribbonGroup2 = new C1.Win.Ribbon.RibbonGroup();
            rbGrid = new C1.Win.Ribbon.RibbonToggleButton();
            rbChart = new C1.Win.Ribbon.RibbonToggleButton();
            ribbonTab3 = new C1.Win.Ribbon.RibbonTab();
            ribbonGroup3 = new C1.Win.Ribbon.RibbonGroup();
            ribbonCheckBox1 = new C1.Win.Ribbon.RibbonCheckBox();
            ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            c1SplitContainer1 = new C1.Win.SplitContainer.C1SplitContainer();
            c1SplitterPanel1 = new C1.Win.SplitContainer.C1SplitterPanel();
            c1DashboardLayout1 = new C1.Win.Layout.C1DashboardLayout();
            c1SplitterPanel2 = new C1.Win.SplitContainer.C1SplitterPanel();
            c1FlexPivotChart1 = new C1.Win.FlexPivot.FlexPivotChart();
            c1FlexPivotPanel1 = new C1.Win.FlexPivot.C1FlexPivotPanel();
            c1FlexPivotGrid1 = new C1.Win.FlexPivot.C1FlexPivotGrid();
            chlFields = new System.Windows.Forms.CheckedListBox();
            fieldSplitContainer = new C1.Win.SplitContainer.C1SplitContainer();
            fieldSplitPnl = new C1.Win.SplitContainer.C1SplitterPanel();
            ((System.ComponentModel.ISupportInitialize)c1Ribbon1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1SplitContainer1).BeginInit();
            c1SplitContainer1.SuspendLayout();
            c1SplitterPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1DashboardLayout1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1DashboardLayout1.SplitLayoutControl).BeginInit();
            c1DashboardLayout1.SuspendLayout();
            c1SplitterPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1FlexPivotChart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1FlexPivotPanel1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1FlexPivotGrid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fieldSplitContainer).BeginInit();
            fieldSplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // c1Ribbon1
            // 
            c1Ribbon1.ApplicationMenuHolder = ribbonApplicationMenu1;
            c1Ribbon1.BottomToolBarHolder = ribbonBottomToolBar1;
            c1Ribbon1.ConfigToolBarHolder = ribbonConfigToolBar1;
            c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            c1Ribbon1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            c1Ribbon1.Name = "c1Ribbon1";
            c1Ribbon1.QatHolder = ribbonQat1;
            c1Ribbon1.Size = new System.Drawing.Size(1384, 201);
            c1Ribbon1.Tabs.Add(ribbonTab1);
            c1Ribbon1.Tabs.Add(ribbonTab2);
            c1Ribbon1.Tabs.Add(ribbonTab3);
            c1Ribbon1.TopToolBarHolder = ribbonTopToolBar1;
            // 
            // ribbonApplicationMenu1
            // 
            ribbonApplicationMenu1.LeftPaneItems.Add(ribbonButton1);
            ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            ribbonApplicationMenu1.Text = "File";
            // 
            // ribbonButton1
            // 
            ribbonButton1.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, (System.Drawing.Image)resources.GetObject("ribbonButton1.IconSet")));
            ribbonButton1.Name = "ribbonButton1";
            ribbonButton1.Text = "Refresh ";
            // 
            // ribbonBottomToolBar1
            // 
            ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonConfigToolBar1
            // 
            ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            ribbonQat1.Name = "ribbonQat1";
            // 
            // ribbonTab1
            // 
            ribbonTab1.Groups.Add(ribbonGroup1);
            ribbonTab1.Name = "ribbonTab1";
            ribbonTab1.Text = "Data";
            // 
            // ribbonGroup1
            // 
            ribbonGroup1.Items.Add(ribbonGallery1);
            ribbonGroup1.Name = "ribbonGroup1";
            ribbonGroup1.Text = "Data for Analysis";
            // 
            // ribbonGallery1
            // 
            ribbonGallery1.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, (System.Drawing.Image)resources.GetObject("ribbonGallery1.IconSet")));
            ribbonGallery1.ItemSize = new System.Drawing.Size(150, 60);
            ribbonGallery1.Name = "ribbonGallery1";
            ribbonGallery1.Text = "Gallery";
            ribbonGallery1.SelectedIndexChanged += ribbonGallery1_SelectedIndexChanged;
            // 
            // ribbonTab2
            // 
            ribbonTab2.Groups.Add(ribbonGroup2);
            ribbonTab2.Name = "ribbonTab2";
            ribbonTab2.Text = "View";
            // 
            // ribbonGroup2
            // 
            ribbonGroup2.Items.Add(rbGrid);
            ribbonGroup2.Items.Add(rbChart);
            ribbonGroup2.Name = "ribbonGroup2";
            ribbonGroup2.Text = "Data View";
            // 
            // rbGrid
            // 
            rbGrid.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, (System.Drawing.Image)resources.GetObject("rbGrid.IconSet")));
            rbGrid.Name = "rbGrid";
            rbGrid.Pressed = true;
            rbGrid.Text = "Grid";
            rbGrid.ToggleGroupName = "DataView";
            rbGrid.PressedButtonChanged += rbGrid_PressedButtonChanged;
            // 
            // rbChart
            // 
            rbChart.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, (System.Drawing.Image)resources.GetObject("rbChart.IconSet")));
            rbChart.Name = "rbChart";
            rbChart.Text = "Chart";
            rbChart.ToggleGroupName = "DataView";
            // 
            // ribbonTab3
            // 
            ribbonTab3.Groups.Add(ribbonGroup3);
            ribbonTab3.Name = "ribbonTab3";
            ribbonTab3.Text = "Options";
            // 
            // ribbonGroup3
            // 
            ribbonGroup3.Items.Add(ribbonCheckBox1);
            ribbonGroup3.Name = "ribbonGroup3";
            ribbonGroup3.Text = "Filter options";
            // 
            // ribbonCheckBox1
            // 
            ribbonCheckBox1.Name = "ribbonCheckBox1";
            ribbonCheckBox1.Text = "Headers";
            // 
            // ribbonTopToolBar1
            // 
            ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // c1SplitContainer1
            // 
            c1SplitContainer1.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            c1SplitContainer1.BackColor = System.Drawing.Color.White;
            c1SplitContainer1.CollapsingAreaColor = System.Drawing.Color.FromArgb(244, 244, 244);
            c1SplitContainer1.CollapsingCueColor = System.Drawing.Color.FromArgb(212, 212, 212);
            c1SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1SplitContainer1.FixedLineColor = System.Drawing.Color.FromArgb(212, 212, 212);
            c1SplitContainer1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            c1SplitContainer1.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            c1SplitContainer1.HeaderButtonBackColor = System.Drawing.Color.Transparent;
            c1SplitContainer1.HeaderForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            c1SplitContainer1.HeaderHeight = 30;
            c1SplitContainer1.HeaderLineWidth = 1;
            c1SplitContainer1.Location = new System.Drawing.Point(0, 201);
            c1SplitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            c1SplitContainer1.Name = "c1SplitContainer1";
            c1SplitContainer1.Panels.Add(c1SplitterPanel1);
            c1SplitContainer1.Panels.Add(c1SplitterPanel2);
            c1SplitContainer1.Size = new System.Drawing.Size(1384, 854);
            c1SplitContainer1.SplitterColor = System.Drawing.Color.FromArgb(212, 212, 212);
            c1SplitContainer1.SplitterMovingColor = System.Drawing.Color.FromArgb(68, 68, 68);
            c1SplitContainer1.SplitterWidth = 3;
            c1SplitContainer1.TabIndex = 1;
            // 
            // c1SplitterPanel1
            // 
            c1SplitterPanel1.Collapsible = true;
            c1SplitterPanel1.Controls.Add(c1DashboardLayout1);
            c1SplitterPanel1.Dock = C1.Win.SplitContainer.PanelDockStyle.Left;
            c1SplitterPanel1.Height = 854;
            c1SplitterPanel1.Location = new System.Drawing.Point(0, 30);
            c1SplitterPanel1.MinHeight = 57;
            c1SplitterPanel1.MinWidth = 57;
            c1SplitterPanel1.Name = "c1SplitterPanel1";
            c1SplitterPanel1.Size = new System.Drawing.Size(800, 824);
            c1SplitterPanel1.SizeRatio = 58.611D;
            c1SplitterPanel1.TabIndex = 0;
            c1SplitterPanel1.Text = "Filters";
            c1SplitterPanel1.Width = 809;
            // 
            // c1DashboardLayout1
            // 
            c1DashboardLayout1.Dock = System.Windows.Forms.DockStyle.Fill;
            // 
            // 
            // 
            c1DashboardLayout1.FlowLayoutControl.AutoScroll = true;
            c1DashboardLayout1.FlowLayoutControl.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.FlowLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            c1DashboardLayout1.FlowLayoutControl.Controls.Add(fieldSplitContainer);
            c1DashboardLayout1.FlowLayoutControl.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            c1DashboardLayout1.FlowLayoutControl.Location = new System.Drawing.Point(10, 10);
            c1DashboardLayout1.FlowLayoutControl.Margin = new System.Windows.Forms.Padding(0);
            c1DashboardLayout1.FlowLayoutControl.Name = "FlowContentPanel";
            c1DashboardLayout1.FlowLayoutControl.Size = new System.Drawing.Size(780, 804);
            c1DashboardLayout1.FlowLayoutControl.TabIndex = 0;
            // 
            // 
            // 
            c1DashboardLayout1.GridLayoutControl.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.GridLayoutControl.Location = new System.Drawing.Point(0, 0);
            c1DashboardLayout1.GridLayoutControl.Margin = new System.Windows.Forms.Padding(0);
            c1DashboardLayout1.GridLayoutControl.Name = "";
            c1DashboardLayout1.GridLayoutControl.TabIndex = 0;
            c1DashboardLayout1.LayoutType = C1.Win.Layout.LayoutType.Flow;
            c1DashboardLayout1.Location = new System.Drawing.Point(0, 0);
            c1DashboardLayout1.Margin = new System.Windows.Forms.Padding(0);
            c1DashboardLayout1.Name = "c1DashboardLayout1";
            c1DashboardLayout1.Size = new System.Drawing.Size(800, 824);
            // 
            // 
            // 
            c1DashboardLayout1.SplitLayoutControl.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            c1DashboardLayout1.SplitLayoutControl.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            c1DashboardLayout1.SplitLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            c1DashboardLayout1.SplitLayoutControl.HeaderButtonBackColor = System.Drawing.Color.Transparent;
            c1DashboardLayout1.SplitLayoutControl.Location = new System.Drawing.Point(10, 10);
            c1DashboardLayout1.SplitLayoutControl.Margin = new System.Windows.Forms.Padding(0);
            c1DashboardLayout1.SplitLayoutControl.Name = "";
            c1DashboardLayout1.SplitLayoutControl.Size = new System.Drawing.Size(480, 280);
            c1DashboardLayout1.SplitLayoutControl.TabIndex = 0;
            c1DashboardLayout1.TabIndex = 0;
            c1DashboardLayout1.TabStop = false;
            c1DashboardLayout1.Text = "c1DashboardLayout1";
            // 
            // c1SplitterPanel2
            // 
            c1SplitterPanel2.Controls.Add(c1FlexPivotChart1);
            c1SplitterPanel2.Controls.Add(c1FlexPivotGrid1);
            c1SplitterPanel2.Controls.Add(c1FlexPivotPanel1);
            c1SplitterPanel2.Dock = C1.Win.SplitContainer.PanelDockStyle.Right;
            c1SplitterPanel2.Height = 854;
            c1SplitterPanel2.Location = new System.Drawing.Point(812, 30);
            c1SplitterPanel2.MinHeight = 57;
            c1SplitterPanel2.MinWidth = 57;
            c1SplitterPanel2.Name = "c1SplitterPanel2";
            c1SplitterPanel2.Size = new System.Drawing.Size(572, 824);
            c1SplitterPanel2.TabIndex = 1;
            c1SplitterPanel2.Text = "Data";
            c1SplitterPanel2.Width = 572;
            // 
            // c1FlexPivotChart1
            // 
            c1FlexPivotChart1.CustomPalette = null;
            c1FlexPivotChart1.DataSource = c1FlexPivotPanel1;
            c1FlexPivotChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1FlexPivotChart1.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            c1FlexPivotChart1.Location = new System.Drawing.Point(0, 0);
            c1FlexPivotChart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            c1FlexPivotChart1.Name = "c1FlexPivotChart1";
            c1FlexPivotChart1.Palette = C1.Chart.Palette.Standard;
            c1FlexPivotChart1.Size = new System.Drawing.Size(572, 824);
            c1FlexPivotChart1.TabIndex = 2;
            c1FlexPivotChart1.Visible = false;
            // 
            // c1FlexPivotPanel1
            // 
            c1FlexPivotPanel1.BackColor = System.Drawing.Color.White;
            c1FlexPivotPanel1.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            c1FlexPivotPanel1.Location = new System.Drawing.Point(175, 68);
            c1FlexPivotPanel1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            c1FlexPivotPanel1.Name = "c1FlexPivotPanel1";
            c1FlexPivotPanel1.Size = new System.Drawing.Size(376, 648);
            c1FlexPivotPanel1.TabIndex = 1;
            // 
            // c1FlexPivotGrid1
            // 
            c1FlexPivotGrid1.AllowMerging = C1.Win.FlexGrid.AllowMergingEnum.FixedOnly;
            c1FlexPivotGrid1.AllowMergingFixed = C1.Win.FlexGrid.AllowMergingEnum.Default;
            c1FlexPivotGrid1.BackColor = System.Drawing.Color.White;
            c1FlexPivotGrid1.ColumnInfo = "1,1,0,0,0,135,Columns:0{Width:95;Caption:\" \";}\t";
            c1FlexPivotGrid1.DataSource = c1FlexPivotPanel1;
            c1FlexPivotGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            c1FlexPivotGrid1.DrawMode = C1.Win.FlexGrid.DrawModeEnum.OwnerDraw;
            c1FlexPivotGrid1.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            c1FlexPivotGrid1.Location = new System.Drawing.Point(0, 0);
            c1FlexPivotGrid1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            c1FlexPivotGrid1.Name = "c1FlexPivotGrid1";
            c1FlexPivotGrid1.Rows.Count = 1;
            c1FlexPivotGrid1.Rows.DefaultSize = 27;
            c1FlexPivotGrid1.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None;
            c1FlexPivotGrid1.Size = new System.Drawing.Size(572, 824);
            c1FlexPivotGrid1.StyleInfo = resources.GetString("c1FlexPivotGrid1.StyleInfo");
            c1FlexPivotGrid1.SubtotalBackground = System.Drawing.Color.Empty;
            c1FlexPivotGrid1.SubtotalForeground = System.Drawing.Color.Empty;
            c1FlexPivotGrid1.TabIndex = 0;
            c1FlexPivotGrid1.Tree.LineColor = System.Drawing.Color.FromArgb(171, 171, 171);
            // 
            // chlFields
            // 
            chlFields.Dock = System.Windows.Forms.DockStyle.Fill;
            chlFields.Location = new System.Drawing.Point(10, 39);
            chlFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            chlFields.Name = "chlFields";
            chlFields.Size = new System.Drawing.Size(380, 336);
            chlFields.TabIndex = 0;
            chlFields.ItemCheck += chlFields_SelectionChanged;
            // 
            // fieldSplitContainer
            // 
            fieldSplitContainer.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            fieldSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            fieldSplitContainer.HeaderButtonBackColor = System.Drawing.Color.Transparent;
            fieldSplitContainer.Location = new System.Drawing.Point(10, 10);
            fieldSplitContainer.Margin = new System.Windows.Forms.Padding(0);
            fieldSplitContainer.Name = "fieldSplitContainer";
            fieldSplitContainer.Panels.Add(fieldSplitPnl);
            fieldSplitContainer.Size = new System.Drawing.Size(780, 804);
            fieldSplitContainer.TabIndex = 1;
            // 
            // fieldSplitPnl
            // 
            fieldSplitPnl.Height = 804;
            fieldSplitPnl.Controls.Add(chlFields);
            fieldSplitPnl.Location = new System.Drawing.Point(0, 21);
            fieldSplitPnl.Name = "fieldSplitPnl";
            fieldSplitPnl.Size = new System.Drawing.Size(780, 783);
            fieldSplitPnl.TabIndex = 0;
            fieldSplitPnl.Text = "Fields";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(c1SplitContainer1);
            Controls.Add(c1Ribbon1);
            ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Form1";
            Size = new System.Drawing.Size(1384, 1055);
            ((System.ComponentModel.ISupportInitialize)c1Ribbon1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1SplitContainer1).EndInit();
            c1SplitContainer1.ResumeLayout(false);
            c1SplitterPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)c1DashboardLayout1.SplitLayoutControl).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1DashboardLayout1).EndInit();
            c1DashboardLayout1.ResumeLayout(false);
            c1SplitterPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)c1FlexPivotChart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1FlexPivotPanel1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1FlexPivotGrid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fieldSplitContainer).EndInit();
            fieldSplitContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
		private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
		private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
		private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
		private C1.Win.Ribbon.RibbonQat ribbonQat1;
		private C1.Win.Ribbon.RibbonTab ribbonTab1;
		private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
		private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
		private C1.Win.SplitContainer.C1SplitContainer c1SplitContainer1;
		private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel1;
		private C1.Win.SplitContainer.C1SplitterPanel c1SplitterPanel2;
		private C1.Win.FlexPivot.C1FlexPivotGrid c1FlexPivotGrid1;
		private C1.Win.Layout.C1DashboardLayout c1DashboardLayout1;
		private C1.Win.FlexPivot.C1FlexPivotPanel c1FlexPivotPanel1;
		private System.Windows.Forms.CheckedListBox chlFields;
		private C1.Win.Ribbon.RibbonGallery ribbonGallery1;
		private C1.Win.Ribbon.RibbonButton ribbonButton1;
		private C1.Win.Ribbon.RibbonTab ribbonTab2;
		private C1.Win.Ribbon.RibbonGroup ribbonGroup2;
		private C1.Win.Ribbon.RibbonToggleButton rbGrid;
		private C1.Win.Ribbon.RibbonToggleButton rbChart;
		private C1.Win.Ribbon.RibbonTab ribbonTab3;
		private C1.Win.Ribbon.RibbonGroup ribbonGroup3;
		private C1.Win.Ribbon.RibbonCheckBox ribbonCheckBox1;
		private C1.Win.FlexPivot.FlexPivotChart c1FlexPivotChart1;
        private C1.Win.SplitContainer.C1SplitContainer fieldSplitContainer;
        private C1.Win.SplitContainer.C1SplitterPanel fieldSplitPnl;
    }
}

