// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

namespace ContourChart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series1 = new C1.Win.Chart.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            flexChart1 = new C1.Win.Chart.FlexChart();
            c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            ribbonToolBar1 = new C1.Win.Ribbon.RibbonToolBar();
            ribCmbDataSet = new C1.Win.Ribbon.RibbonComboBox();
            ribCmbAppearance = new C1.Win.Ribbon.RibbonComboBox();
            ribbonGroup3 = new C1.Win.Ribbon.RibbonGroup();
            ribbonToolBar2 = new C1.Win.Ribbon.RibbonToolBar();
            ribNumEditContourLevels = new C1.Win.Ribbon.RibbonNumericBox();
            ribTxtBoxCustomLevels = new C1.Win.Ribbon.RibbonTextBox();
            ribCBEnableCustomLevels = new C1.Win.Ribbon.RibbonCheckBox();
            ribbonTab2 = new C1.Win.Ribbon.RibbonTab();
            ribbonGroup2 = new C1.Win.Ribbon.RibbonGroup();
            ribbonToolBar3 = new C1.Win.Ribbon.RibbonToolBar();
            ribBtnExportToPNG = new C1.Win.Ribbon.RibbonButton();
            ribbonSeparator3 = new C1.Win.Ribbon.RibbonSeparator();
            ribBtnExportToJPG = new C1.Win.Ribbon.RibbonButton();
            ribbonSeparator4 = new C1.Win.Ribbon.RibbonSeparator();
            ribBtnExportToSVG = new C1.Win.Ribbon.RibbonButton();
            ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            listViewColorPalette = new ListView();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)flexChart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1Ribbon1).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flexChart1
            // 
            flexChart1.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            flexChart1.AnimationLoad.Duration = 400;
            flexChart1.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            flexChart1.AnimationLoad.Type = C1.Chart.AnimationType.All;
            flexChart1.AnimationSettings = C1.Chart.AnimationSettings.None;
            flexChart1.AnimationUpdate.Duration = 400;
            flexChart1.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            flexChart1.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            flexChart1.AxisX.AxisLine = true;
            flexChart1.AxisX.Chart = flexChart1;
            flexChart1.AxisX.DataSource = null;
            flexChart1.AxisX.Formatter = null;
            flexChart1.AxisX.GroupProvider = null;
            flexChart1.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            flexChart1.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            flexChart1.AxisX.GroupVisibilityLevel = 0;
            flexChart1.AxisX.PlotAreaName = null;
            flexChart1.AxisX.Position = C1.Chart.Position.Bottom;
            flexChart1.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            flexChart1.AxisY.AxisLine = false;
            flexChart1.AxisY.Chart = flexChart1;
            flexChart1.AxisY.DataSource = null;
            flexChart1.AxisY.Formatter = null;
            flexChart1.AxisY.GroupProvider = null;
            flexChart1.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            flexChart1.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            flexChart1.AxisY.GroupVisibilityLevel = 0;
            flexChart1.AxisY.MajorGrid = true;
            flexChart1.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            flexChart1.AxisY.PlotAreaName = null;
            flexChart1.AxisY.Position = C1.Chart.Position.Left;
            flexChart1.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            flexChart1.DataLabel.Angle = 0;
            flexChart1.DataLabel.Border = false;
            flexChart1.DataLabel.ConnectingLine = false;
            flexChart1.DataLabel.Content = null;
            flexChart1.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            flexChart1.DataLabel.MaxAutoLabels = 100;
            flexChart1.DataLabel.MaxLines = 0;
            flexChart1.DataLabel.MaxWidth = 0;
            flexChart1.DataLabel.Offset = 0;
            flexChart1.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            flexChart1.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            flexChart1.DataLabel.Position = C1.Chart.LabelPosition.None;
            flexChart1.Dock = DockStyle.Fill;
            flexChart1.Legend.ItemMaxWidth = 0;
            flexChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            flexChart1.Legend.Position = C1.Chart.Position.None;
            flexChart1.Legend.Reversed = false;
            flexChart1.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            flexChart1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            flexChart1.Legend.Title = null;
            flexChart1.Location = new Point(40, 40);
            flexChart1.Margin = new Padding(0);
            flexChart1.Name = "flexChart1";
            flexChart1.Options.Chart = flexChart1;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            flexChart1.Options.ClusterSize = elementSize1;
            flexChart1.PlotMargin = new Padding(0);
            flexChart1.SelectedSeries = null;
            flexChart1.SelectionStyle.StrokeColor = Color.Red;
            series1.DataLabel = null;
            series1.Name = "Series 1";
            series1.StackingGroup = -1;
            series1.Style.StrokeWidth = 2F;
            series1.Tooltip = null;
            flexChart1.Series.Add(series1);
            flexChart1.Size = new Size(1632, 796);
            flexChart1.TabIndex = 0;
            flexChart1.Text = "flexChart1";
            // 
            // 
            // 
            flexChart1.ToolTip.Content = "";
            // 
            // c1Ribbon1
            // 
            c1Ribbon1.ApplicationMenuHolder = ribbonApplicationMenu1;
            c1Ribbon1.BottomToolBarHolder = ribbonBottomToolBar1;
            c1Ribbon1.ConfigToolBarHolder = ribbonConfigToolBar1;
            c1Ribbon1.Location = new Point(0, 0);
            c1Ribbon1.Name = "c1Ribbon1";
            c1Ribbon1.QatHolder = ribbonQat1;
            c1Ribbon1.Size = new Size(2090, 106);
            c1Ribbon1.Tabs.Add(ribbonTab1);
            c1Ribbon1.Tabs.Add(ribbonTab2);
            c1Ribbon1.TopToolBarHolder = ribbonTopToolBar1;
            c1Ribbon1.ViewMode = C1.Win.Ribbon.ViewMode.Simplified;
            // 
            // ribbonApplicationMenu1
            // 
            ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            ribbonApplicationMenu1.TabIndex = 0;
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
            ribbonQat1.Visible = false;
            // 
            // ribbonTab1
            // 
            ribbonTab1.Groups.Add(ribbonGroup1);
            ribbonTab1.Groups.Add(ribbonGroup3);
            ribbonTab1.Name = "ribbonTab1";
            ribbonTab1.TabIndex = 1;
            ribbonTab1.Text = "ribbonTab1";
            // 
            // ribbonGroup1
            // 
            ribbonGroup1.Items.Add(ribbonToolBar1);
            ribbonGroup1.LauncherTabIndex = 5;
            ribbonGroup1.Name = "ribbonGroup1";
            ribbonGroup1.Text = "ribbonGroup1";
            // 
            // ribbonToolBar1
            // 
            ribbonToolBar1.Items.Add(ribCmbDataSet);
            ribbonToolBar1.Items.Add(ribCmbAppearance);
            ribbonToolBar1.Name = "ribbonToolBar1";
            // 
            // ribCmbDataSet
            // 
            ribCmbDataSet.Label = "ribbonComboBox1";
            ribCmbDataSet.Name = "ribCmbDataSet";
            ribCmbDataSet.TabIndex = 14;
            ribCmbDataSet.TextAlign = HorizontalAlignment.Center;
            ribCmbDataSet.TextAreaWidth = 100;
            ribCmbDataSet.SelectedIndexChanged += ribCmbDataSet_SelectedIndexChanged;
            // 
            // ribCmbAppearance
            // 
            ribCmbAppearance.Label = "ribbonComboBox1";
            ribCmbAppearance.Name = "ribCmbAppearance";
            ribCmbAppearance.TabIndex = 13;
            ribCmbAppearance.TextAlign = HorizontalAlignment.Center;
            ribCmbAppearance.SelectedIndexChanged += ribCmbAppearance_SelectedIndexChanged;
            // 
            // ribbonGroup3
            // 
            ribbonGroup3.Items.Add(ribbonToolBar2);
            ribbonGroup3.LauncherTabIndex = 9;
            ribbonGroup3.Name = "ribbonGroup3";
            ribbonGroup3.Text = "ribbonGroup3";
            // 
            // ribbonToolBar2
            // 
            ribbonToolBar2.Items.Add(ribNumEditContourLevels);
            ribbonToolBar2.Items.Add(ribTxtBoxCustomLevels);
            ribbonToolBar2.Items.Add(ribCBEnableCustomLevels);
            ribbonToolBar2.Name = "ribbonToolBar2";
            // 
            // ribNumEditContourLevels
            // 
            ribNumEditContourLevels.Label = "ribbonNumericBox1";
            ribNumEditContourLevels.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ribNumEditContourLevels.Name = "ribNumEditContourLevels";
            ribNumEditContourLevels.TabIndex = 12;
            ribNumEditContourLevels.TextAlign = HorizontalAlignment.Center;
            ribNumEditContourLevels.TextAreaWidth = 30;
            ribNumEditContourLevels.ValueChanged += ribNumEditContourLevels_ValueChanged;
            // 
            // ribTxtBoxCustomLevels
            // 
            ribTxtBoxCustomLevels.Enabled = false;
            ribTxtBoxCustomLevels.Name = "ribTxtBoxCustomLevels";
            ribTxtBoxCustomLevels.TabIndex = 16;
            ribTxtBoxCustomLevels.TextAreaWidth = 300;
            ribTxtBoxCustomLevels.KeyPress += ribTxtBoxCustomLevels_KeyPress;
            ribTxtBoxCustomLevels.TextChanged += ribTxtBoxCustomLevels_TextChanged;
            // 
            // ribCBEnableCustomLevels
            // 
            ribCBEnableCustomLevels.Name = "ribCBEnableCustomLevels";
            ribCBEnableCustomLevels.TabIndex = 15;
            ribCBEnableCustomLevels.Text = "ribbonCheckBox1";
            ribCBEnableCustomLevels.CheckedChanged += ribCBEnableCustomLevels_CheckedChanged;
            // 
            // ribbonTab2
            // 
            ribbonTab2.Groups.Add(ribbonGroup2);
            ribbonTab2.Name = "ribbonTab2";
            ribbonTab2.TabIndex = 3;
            ribbonTab2.Text = "ribbonTab2";
            // 
            // ribbonGroup2
            // 
            ribbonGroup2.Items.Add(ribbonToolBar3);
            ribbonGroup2.LauncherTabIndex = 4;
            ribbonGroup2.Name = "ribbonGroup2";
            ribbonGroup2.Text = "ribbonGroup2";
            // 
            // ribbonToolBar3
            // 
            ribbonToolBar3.Items.Add(ribBtnExportToPNG);
            ribbonToolBar3.Items.Add(ribbonSeparator3);
            ribbonToolBar3.Items.Add(ribBtnExportToJPG);
            ribbonToolBar3.Items.Add(ribbonSeparator4);
            ribbonToolBar3.Items.Add(ribBtnExportToSVG);
            ribbonToolBar3.Name = "ribbonToolBar3";
            // 
            // ribBtnExportToPNG
            // 
            ribBtnExportToPNG.IconSet.Add(new C1.Framework.C1BitmapIcon("", new Size(16, 16), Color.Transparent, Properties.Resources.png));
            ribBtnExportToPNG.Name = "ribBtnExportToPNG";
            ribBtnExportToPNG.TabIndex = 17;
            ribBtnExportToPNG.Text = "ribbonButton1";
            ribBtnExportToPNG.Click += ribBtnExportToPNG_Click;
            // 
            // ribbonSeparator3
            // 
            ribbonSeparator3.Name = "ribbonSeparator3";
            // 
            // ribBtnExportToJPG
            // 
            ribBtnExportToJPG.IconSet.Add(new C1.Framework.C1BitmapIcon("", new Size(16, 16), Color.Transparent, Properties.Resources.jpg));
            ribBtnExportToJPG.Name = "ribBtnExportToJPG";
            ribBtnExportToJPG.TabIndex = 18;
            ribBtnExportToJPG.Text = "ribbonButton2";
            ribBtnExportToJPG.Click += ribBtnExportToJPG_Click;
            // 
            // ribbonSeparator4
            // 
            ribbonSeparator4.Name = "ribbonSeparator4";
            // 
            // ribBtnExportToSVG
            // 
            ribBtnExportToSVG.IconSet.Add(new C1.Framework.C1BitmapIcon("", new Size(16, 16), Color.Transparent, Properties.Resources.svg));
            ribBtnExportToSVG.Name = "ribBtnExportToSVG";
            ribBtnExportToSVG.TabIndex = 19;
            ribBtnExportToSVG.Text = "ribbonButton3";
            ribBtnExportToSVG.Click += ribBtnExportToSVG_Click;
            // 
            // ribbonTopToolBar1
            // 
            ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            ribbonTopToolBar1.Visible = false;
            // 
            // listViewColorPalette
            // 
            listViewColorPalette.Dock = DockStyle.Fill;
            listViewColorPalette.Location = new Point(3, 3);
            listViewColorPalette.Name = "listViewColorPalette";
            listViewColorPalette.Size = new Size(344, 878);
            listViewColorPalette.TabIndex = 2;
            listViewColorPalette.UseCompatibleStateImageBehavior = false;
            listViewColorPalette.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 106);
            panel1.Margin = new Padding(10, 3, 3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(2090, 904);
            panel1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 350F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(listViewColorPalette, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(10, 10);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(2070, 884);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Window;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(flexChart1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(353, 3);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(40);
            panel2.Size = new Size(1714, 878);
            panel2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2090, 1010);
            Controls.Add(panel1);
            Controls.Add(c1Ribbon1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)flexChart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1Ribbon1).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private C1.Win.Chart.FlexChart flexChart1;
        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTab ribbonTab1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.RibbonTab ribbonTab2;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup2;
        private ListView listViewColorPalette;
        private Panel panel1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup3;
        private C1.Win.Ribbon.RibbonToolBar ribbonToolBar1;
        private C1.Win.Ribbon.RibbonNumericBox ribNumEditContourLevels;
        private C1.Win.Ribbon.RibbonComboBox ribCmbAppearance;
        private C1.Win.Ribbon.RibbonComboBox ribCmbDataSet;
        private C1.Win.Ribbon.RibbonToolBar ribbonToolBar2;
        private C1.Win.Ribbon.RibbonCheckBox ribCBEnableCustomLevels;
        private C1.Win.Ribbon.RibbonTextBox ribTxtBoxCustomLevels;
        private C1.Win.Ribbon.RibbonToolBar ribbonToolBar3;
        private C1.Win.Ribbon.RibbonButton ribBtnExportToPNG;
        private C1.Win.Ribbon.RibbonButton ribBtnExportToJPG;
        private C1.Win.Ribbon.RibbonButton ribBtnExportToSVG;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator3;
        private C1.Win.Ribbon.RibbonSeparator ribbonSeparator4;
    }
}
