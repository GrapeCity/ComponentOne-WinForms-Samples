using System.Drawing;
using System.Windows.Forms;

namespace FlexGridExplorer.Samples
{
    partial class Transpose
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
            components = new System.ComponentModel.Container();
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            C1.Win.Chart.Series series1 = new C1.Win.Chart.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transpose));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            transposeToggleButton = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            userStoryLinkLabel = new LinkLabel();
            tableLayoutPanel2 = new TableLayoutPanel();
            linkLabel1 = new LinkLabel();
            HotelFlexGrid = new C1.Win.FlexGrid.C1FlexGrid();
            flexChart1 = new C1.Win.Chart.FlexChart();
            imageList1 = new ImageList(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)transposeToggleButton).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)HotelFlexGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flexChart1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.WhiteSmoke;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(transposeToggleButton, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(userStoryLinkLabel, 0, 6);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.83521F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.16479F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(553, 1120);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            label1.Location = new Point(55, 847);
            label1.Margin = new Padding(55, 0, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(218, 41);
            label1.TabIndex = 0;
            label1.Text = "Transpose will:";
            // 
            // transposeToggleButton
            // 
            transposeToggleButton.Anchor = AnchorStyles.None;
            transposeToggleButton.Cursor = Cursors.Hand;
            transposeToggleButton.Image = Properties.Resources.transpose_off;
            transposeToggleButton.Location = new Point(80, 229);
            transposeToggleButton.Name = "transposeToggleButton";
            transposeToggleButton.Size = new Size(392, 377);
            transposeToggleButton.TabIndex = 1;
            transposeToggleButton.TabStop = false;
            transposeToggleButton.Click += transposeToggleButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.Location = new Point(98, 909);
            label2.Margin = new Padding(98, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(351, 30);
            label2.TabIndex = 1;
            label2.Text = "✔ Improve Readability and Clarity";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 8F);
            label3.Location = new Point(98, 951);
            label3.Margin = new Padding(98, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(261, 30);
            label3.TabIndex = 2;
            label3.Text = "✔ Enhance Data Analysis";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8F);
            label4.Location = new Point(98, 987);
            label4.Margin = new Padding(98, 0, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(382, 30);
            label4.TabIndex = 3;
            label4.Text = "✔ Streamline the Reporting Structure";
            // 
            // userStoryLinkLabel
            // 
            userStoryLinkLabel.Anchor = AnchorStyles.Right;
            userStoryLinkLabel.AutoSize = true;
            userStoryLinkLabel.LinkColor = Color.SkyBlue;
            userStoryLinkLabel.Location = new Point(222, 1056);
            userStoryLinkLabel.Margin = new Padding(3, 0, 40, 30);
            userStoryLinkLabel.Name = "userStoryLinkLabel";
            userStoryLinkLabel.Size = new Size(291, 32);
            userStoryLinkLabel.TabIndex = 4;
            userStoryLinkLabel.TabStop = true;
            userStoryLinkLabel.Text = "Read about the user-story";
            userStoryLinkLabel.LinkClicked += userStoryLinkLabel_LinkClicked;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoScroll = true;
            tableLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.BackColor = Color.White;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(linkLabel1, 0, 2);
            tableLayoutPanel2.Controls.Add(HotelFlexGrid, 0, 0);
            tableLayoutPanel2.Controls.Add(flexChart1, 0, 1);
            tableLayoutPanel2.Location = new Point(550, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 56.79475F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 43.20525F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel2.Size = new Size(1147, 1120);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.SkyBlue;
            linkLabel1.Location = new Point(810, 1056);
            linkLabel1.Margin = new Padding(3, 0, 40, 30);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(297, 32);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Learn more about FlexGrid";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // HotelFlexGrid
            // 
            HotelFlexGrid.AllowDragging = C1.Win.FlexGrid.AllowDraggingEnum.None;
            HotelFlexGrid.AllowResizing = C1.Win.FlexGrid.AllowResizingEnum.None;
            HotelFlexGrid.Anchor = AnchorStyles.None;
            HotelFlexGrid.BorderStyle = C1.Win.FlexGrid.Util.BaseControls.BorderStyleEnum.XpThemes;
            HotelFlexGrid.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            HotelFlexGrid.Location = new Point(107, 159);
            HotelFlexGrid.Name = "HotelFlexGrid";
            HotelFlexGrid.Size = new Size(933, 280);
            HotelFlexGrid.TabIndex = 0;
            HotelFlexGrid.MouseClick += HotelFlexGrid_MouseClick;
            // 
            // flexChart1
            // 
            flexChart1.Anchor = AnchorStyles.None;
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
            flexChart1.Legend.ItemMaxWidth = 0;
            flexChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            flexChart1.Legend.Position = C1.Chart.Position.Right;
            flexChart1.Legend.Reversed = false;
            flexChart1.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            flexChart1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            flexChart1.Legend.Title = null;
            flexChart1.Location = new Point(128, 624);
            flexChart1.Margin = new Padding(10);
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
            flexChart1.Size = new Size(891, 405);
            flexChart1.TabIndex = 1;
            flexChart1.Text = "flexChart1";
            // 
            // 
            // 
            flexChart1.ToolTip.Content = "";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(256, 256);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // Form1
            // 
            ClientSize = new Size(1689, 1120);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            
            Name = "TransposedGridForm";
            Text = "FlexGrid Transpose Sample";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)transposeToggleButton).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)HotelFlexGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)flexChart1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label3;
        private Label label4;
        private C1.Win.FlexGrid.C1FlexGrid HotelFlexGrid;
        private PictureBox transposeToggleButton;
        private C1.Win.Chart.FlexChart flexChart1;
        private LinkLabel userStoryLinkLabel;
        private LinkLabel linkLabel1;
    }
}