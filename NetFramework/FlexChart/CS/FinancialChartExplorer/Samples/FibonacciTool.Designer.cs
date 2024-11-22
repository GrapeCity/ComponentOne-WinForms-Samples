using FinancialChartExplorer.CustomControls;

namespace FinancialChartExplorer.Samples
{
    partial class FibonacciTool
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
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.financialChart1 = new C1.Win.Chart.Finance.FinancialChart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.c1CmdToolType = new C1.Win.C1Input.C1ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.c1CmbLabelPosition = new C1.Win.C1Input.C1ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudStartX = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.label3 = new System.Windows.Forms.Label();
            this.nudEndX = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.label4 = new System.Windows.Forms.Label();
            this.nudStartY = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.label5 = new System.Windows.Forms.Label();
            this.nudEndY = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.c1CbUptrend = new C1.Win.C1Input.C1CheckBox();
            this.c1CbRangeSelector = new C1.Win.C1Input.C1CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmdToolType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbLabelPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CbUptrend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CbRangeSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.financialChart1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 272);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // financialChart1
            // 
            this.financialChart1.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            this.financialChart1.AnimationLoad.Duration = 400;
            this.financialChart1.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            this.financialChart1.AnimationLoad.Type = C1.Chart.AnimationType.All;
            this.financialChart1.AnimationSettings = C1.Chart.AnimationSettings.None;
            this.financialChart1.AnimationUpdate.Duration = 400;
            this.financialChart1.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            this.financialChart1.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            this.financialChart1.AxisX.AxisLine = true;
            this.financialChart1.AxisX.Chart = this.financialChart1;
            this.financialChart1.AxisX.DataSource = null;
            this.financialChart1.AxisX.Formatter = null;
            this.financialChart1.AxisX.GroupProvider = null;
            this.financialChart1.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.financialChart1.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.financialChart1.AxisX.GroupVisibilityLevel = 0;
            this.financialChart1.AxisX.PlotAreaName = null;
            this.financialChart1.AxisX.Position = C1.Chart.Position.Bottom;
            this.financialChart1.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            this.financialChart1.AxisY.AxisLine = false;
            this.financialChart1.AxisY.Chart = this.financialChart1;
            this.financialChart1.AxisY.DataSource = null;
            this.financialChart1.AxisY.Formatter = null;
            this.financialChart1.AxisY.GroupProvider = null;
            this.financialChart1.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            this.financialChart1.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            this.financialChart1.AxisY.GroupVisibilityLevel = 0;
            this.financialChart1.AxisY.MajorGrid = true;
            this.financialChart1.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.financialChart1.AxisY.PlotAreaName = null;
            this.financialChart1.AxisY.Position = C1.Chart.Position.Left;
            this.financialChart1.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            this.financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Column;
            this.financialChart1.DataLabel.Angle = 0;
            this.financialChart1.DataLabel.Border = false;
            this.financialChart1.DataLabel.ConnectingLine = false;
            this.financialChart1.DataLabel.Content = null;
            this.financialChart1.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            this.financialChart1.DataLabel.MaxAutoLabels = 100;
            this.financialChart1.DataLabel.MaxLines = 0;
            this.financialChart1.DataLabel.MaxWidth = 0;
            this.financialChart1.DataLabel.Offset = 0;
            this.financialChart1.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            this.financialChart1.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            this.financialChart1.DataLabel.Position = C1.Chart.LabelPosition.None;
            this.financialChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financialChart1.Legend.ItemMaxWidth = 0;
            this.financialChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.financialChart1.Legend.Position = C1.Chart.Position.Right;
            this.financialChart1.Legend.Reversed = false;
            this.financialChart1.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.financialChart1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.financialChart1.Legend.Title = null;
            this.financialChart1.Location = new System.Drawing.Point(13, 12);
            this.financialChart1.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.financialChart1.Name = "financialChart1";
            this.financialChart1.Options.BoxSize = 2D;
            this.financialChart1.Options.Chart = this.financialChart1;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.financialChart1.Options.ClusterSize = elementSize1;
            this.financialChart1.Options.ReversalAmount = 1D;
            this.financialChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            this.financialChart1.SelectedSeries = null;
            this.financialChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.financialChart1.Size = new System.Drawing.Size(774, 147);
            this.financialChart1.TabIndex = 0;
            this.financialChart1.Text = "financialChart1";
            // 
            // 
            // 
            this.financialChart1.ToolTip.Content = "{value}";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.c1CmdToolType);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.c1CmbLabelPosition);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.nudStartX);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.nudEndX);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.nudStartY);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.nudEndY);
            this.flowLayoutPanel1.Controls.Add(this.c1CbUptrend);
            this.flowLayoutPanel1.Controls.Add(this.c1CbRangeSelector);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 171);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 101);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type:";
            // 
            // c1CmdToolType
            // 
            this.c1CmdToolType.AllowSpinLoop = false;
            this.c1CmdToolType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.c1CmdToolType.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1CmdToolType.GapHeight = 5;
            this.c1CmdToolType.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1CmdToolType.Location = new System.Drawing.Point(72, 18);
            this.c1CmdToolType.Name = "c1CmdToolType";
            this.c1CmdToolType.Size = new System.Drawing.Size(160, 37);
            this.c1CmdToolType.TabIndex = 14;
            this.c1CmdToolType.Tag = null;
            this.c1CmdToolType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c1CmdToolType.SelectedIndexChanged += new System.EventHandler(this.c1CmdToolType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(13, 3, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Label Position:";
            // 
            // c1CmbLabelPosition
            // 
            this.c1CmbLabelPosition.AllowSpinLoop = false;
            this.c1CmbLabelPosition.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.c1CmbLabelPosition.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1CmbLabelPosition.GapHeight = 5;
            this.c1CmbLabelPosition.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1CmbLabelPosition.Location = new System.Drawing.Point(404, 18);
            this.c1CmbLabelPosition.Name = "c1CmbLabelPosition";
            this.c1CmbLabelPosition.Size = new System.Drawing.Size(107, 37);
            this.c1CmbLabelPosition.TabIndex = 15;
            this.c1CmbLabelPosition.Tag = null;
            this.c1CmbLabelPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c1CmbLabelPosition.SelectedItemChanged += new System.EventHandler(this.c1CmbLabelPosition_SelectedItemChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(527, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(13, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "StartX:";
            // 
            // nudStartX
            // 
            this.nudStartX.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudStartX.GapHeight = 0;
            this.nudStartX.ImagePadding = new System.Windows.Forms.Padding(0);
            this.nudStartX.Location = new System.Drawing.Point(610, 23);
            this.nudStartX.Minimum = -100;
            this.nudStartX.Name = "nudStartX";
            this.nudStartX.Size = new System.Drawing.Size(62, 26);
            this.nudStartX.TabIndex = 18;
            this.nudStartX.Tag = null;
            this.nudStartX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudStartX.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudStartX.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.nudStartX.ValueChanged += new System.EventHandler(this.nudStartX_ValueChanged_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(691, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "EndX:";
            // 
            // nudEndX
            // 
            this.nudEndX.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudEndX.GapHeight = 0;
            this.nudEndX.ImagePadding = new System.Windows.Forms.Padding(0);
            this.nudEndX.Location = new System.Drawing.Point(3, 66);
            this.nudEndX.Minimum = -100;
            this.nudEndX.Name = "nudEndX";
            this.nudEndX.Size = new System.Drawing.Size(62, 26);
            this.nudEndX.TabIndex = 19;
            this.nudEndX.Tag = null;
            this.nudEndX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudEndX.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudEndX.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.nudEndX.ValueChanged += new System.EventHandler(this.nudEndX_ValueChanged_1);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "StartY:";
            // 
            // nudStartY
            // 
            this.nudStartY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudStartY.GapHeight = 0;
            this.nudStartY.ImagePadding = new System.Windows.Forms.Padding(0);
            this.nudStartY.Location = new System.Drawing.Point(166, 66);
            this.nudStartY.Minimum = -100;
            this.nudStartY.Name = "nudStartY";
            this.nudStartY.Size = new System.Drawing.Size(62, 26);
            this.nudStartY.TabIndex = 21;
            this.nudStartY.Tag = null;
            this.nudStartY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudStartY.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudStartY.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.nudStartY.ValueChanged += new System.EventHandler(this.nudStartY_ValueChanged_1);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(247, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "EndY:";
            // 
            // nudEndY
            // 
            this.nudEndY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudEndY.GapHeight = 0;
            this.nudEndY.ImagePadding = new System.Windows.Forms.Padding(0);
            this.nudEndY.Location = new System.Drawing.Point(319, 66);
            this.nudEndY.Minimum = -100;
            this.nudEndY.Name = "nudEndY";
            this.nudEndY.Size = new System.Drawing.Size(62, 26);
            this.nudEndY.TabIndex = 20;
            this.nudEndY.Tag = null;
            this.nudEndY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudEndY.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudEndY.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.nudEndY.ValueChanged += new System.EventHandler(this.nudEndY_ValueChanged_1);
            // 
            // c1CbUptrend
            // 
            this.c1CbUptrend.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.c1CbUptrend.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1CbUptrend.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1CbUptrend.Location = new System.Drawing.Point(387, 62);
            this.c1CbUptrend.Name = "c1CbUptrend";
            this.c1CbUptrend.Size = new System.Drawing.Size(104, 35);
            this.c1CbUptrend.TabIndex = 16;
            this.c1CbUptrend.Text = "Uptrend";
            this.c1CbUptrend.UseVisualStyleBackColor = true;
            this.c1CbUptrend.Value = null;
            this.c1CbUptrend.CheckedChanged += new System.EventHandler(this.c1CbUptrend_CheckedChanged);
            // 
            // c1CbRangeSelector
            // 
            this.c1CbRangeSelector.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.c1CbRangeSelector.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1CbRangeSelector.Font = new System.Drawing.Font("Segoe UI Variable Display", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1CbRangeSelector.Location = new System.Drawing.Point(497, 61);
            this.c1CbRangeSelector.Name = "c1CbRangeSelector";
            this.c1CbRangeSelector.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.c1CbRangeSelector.Size = new System.Drawing.Size(104, 37);
            this.c1CbRangeSelector.TabIndex = 17;
            this.c1CbRangeSelector.Text = "Range Selector";
            this.c1CbRangeSelector.UseVisualStyleBackColor = true;
            this.c1CbRangeSelector.Value = null;
            this.c1CbRangeSelector.CheckedChanged += new System.EventHandler(this.c1CbRangeSelector_CheckedChanged);
            // 
            // FibonacciTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FibonacciTool";
            this.Size = new System.Drawing.Size(800, 272);
            this.Load += new System.EventHandler(this.OnLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmdToolType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmbLabelPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CbUptrend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CbRangeSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Chart.Finance.FinancialChart financialChart1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private C1.Win.C1Input.C1ComboBox c1CmdToolType;
        private C1.Win.C1Input.C1ComboBox c1CmbLabelPosition;
        private C1.Win.C1Input.C1CheckBox c1CbUptrend;
        private C1.Win.C1Input.C1CheckBox c1CbRangeSelector;
        private C1NumericEditEx nudStartX;
        private C1NumericEditEx nudEndX;
        private C1NumericEditEx nudStartY;
        private C1NumericEditEx nudEndY;
    }
}
