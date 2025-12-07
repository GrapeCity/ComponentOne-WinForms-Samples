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
            tableLayoutPanel1 = new TableLayoutPanel();
            financialChart1 = new C1.Win.Chart.Finance.FinancialChart();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            c1CmdToolType = new C1.Win.Input.C1ComboBox();
            label6 = new Label();
            c1CmbLabelPosition = new C1.Win.Input.C1ComboBox();
            label2 = new Label();
            nudStartX = new C1NumericEditEx();
            label3 = new Label();
            nudEndX = new C1NumericEditEx();
            label4 = new Label();
            nudStartY = new C1NumericEditEx();
            label5 = new Label();
            nudEndY = new C1NumericEditEx();
            c1CbUptrend = new C1.Win.Input.C1CheckBox();
            c1CbRangeSelector = new C1.Win.Input.C1CheckBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)financialChart1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1CmdToolType).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1CmbLabelPosition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStartX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEndX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStartY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEndY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1CbUptrend).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1CbRangeSelector).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(financialChart1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1168, 560);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // financialChart1
            // 
            financialChart1.AnimationLoad.Direction = C1.Chart.AnimationDirection.Y;
            financialChart1.AnimationLoad.Duration = 400;
            financialChart1.AnimationLoad.Easing = C1.Chart.Easing.Linear;
            financialChart1.AnimationLoad.Type = C1.Chart.AnimationType.All;
            financialChart1.AnimationSettings = C1.Chart.AnimationSettings.None;
            financialChart1.AnimationUpdate.Duration = 400;
            financialChart1.AnimationUpdate.Easing = C1.Chart.Easing.Linear;
            financialChart1.AnimationUpdate.Type = C1.Chart.AnimationType.All;
            financialChart1.AxisX.AxisLine = true;
            financialChart1.AxisX.Chart = financialChart1;
            financialChart1.AxisX.DataSource = null;
            financialChart1.AxisX.Formatter = null;
            financialChart1.AxisX.GroupProvider = null;
            financialChart1.AxisX.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            financialChart1.AxisX.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            financialChart1.AxisX.GroupVisibilityLevel = 0;
            financialChart1.AxisX.PlotAreaName = null;
            financialChart1.AxisX.Position = C1.Chart.Position.Bottom;
            financialChart1.AxisX.TimeUnit = C1.Chart.TimeUnits.Day;
            financialChart1.AxisY.AxisLine = false;
            financialChart1.AxisY.Chart = financialChart1;
            financialChart1.AxisY.DataSource = null;
            financialChart1.AxisY.Formatter = null;
            financialChart1.AxisY.GroupProvider = null;
            financialChart1.AxisY.GroupSeparator = C1.Chart.AxisGroupSeparator.None;
            financialChart1.AxisY.GroupTitleAlignment = C1.Chart.AxisLabelAlignment.Center;
            financialChart1.AxisY.GroupVisibilityLevel = 0;
            financialChart1.AxisY.MajorGrid = true;
            financialChart1.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            financialChart1.AxisY.PlotAreaName = null;
            financialChart1.AxisY.Position = C1.Chart.Position.Left;
            financialChart1.AxisY.TimeUnit = C1.Chart.TimeUnits.Day;
            financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Column;
            financialChart1.DataLabel.Angle = 0;
            financialChart1.DataLabel.Border = false;
            financialChart1.DataLabel.ConnectingLine = false;
            financialChart1.DataLabel.Content = null;
            financialChart1.DataLabel.ContentOptions = C1.Chart.ContentOptions.WordWrap;
            financialChart1.DataLabel.MaxAutoLabels = 100;
            financialChart1.DataLabel.MaxLines = 0;
            financialChart1.DataLabel.MaxWidth = 0;
            financialChart1.DataLabel.Offset = 0;
            financialChart1.DataLabel.Overlapping = C1.Chart.LabelOverlapping.Hide;
            financialChart1.DataLabel.OverlappingOptions = C1.Chart.LabelOverlappingOptions.OutsidePlotArea;
            financialChart1.DataLabel.Position = C1.Chart.LabelPosition.None;
            financialChart1.Dock = DockStyle.Fill;
            financialChart1.Legend.ItemMaxWidth = 0;
            financialChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            financialChart1.Legend.Position = C1.Chart.Position.Right;
            financialChart1.Legend.Reversed = false;
            financialChart1.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            financialChart1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            financialChart1.Legend.Title = null;
            financialChart1.Location = new Point(0, 0);
            financialChart1.Margin = new Padding(0);
            financialChart1.Name = "financialChart1";
            financialChart1.Options.BoxSize = 2D;
            financialChart1.Options.Chart = financialChart1;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            financialChart1.Options.ClusterSize = elementSize1;
            financialChart1.Options.ReversalAmount = 1D;
            financialChart1.PlotMargin = new Padding(0);
            financialChart1.SelectedSeries = null;
            financialChart1.SelectionStyle.StrokeColor = Color.Red;
            financialChart1.Size = new Size(1168, 452);
            financialChart1.TabIndex = 0;
            financialChart1.Text = "financialChart1";
            // 
            // 
            // 
            financialChart1.ToolTip.Content = "{value}";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(c1CmdToolType);
            flowLayoutPanel1.Controls.Add(label6);
            flowLayoutPanel1.Controls.Add(c1CmbLabelPosition);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(nudStartX);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(nudEndX);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(nudStartY);
            flowLayoutPanel1.Controls.Add(label5);
            flowLayoutPanel1.Controls.Add(nudEndY);
            flowLayoutPanel1.Controls.Add(c1CbUptrend);
            flowLayoutPanel1.Controls.Add(c1CbRangeSelector);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 452);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 15, 0, 0);
            flowLayoutPanel1.Size = new Size(1168, 108);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 23);
            label1.Margin = new Padding(3, 3, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 36);
            label1.TabIndex = 0;
            label1.Text = "Type:";
            // 
            // c1CmdToolType
            // 
            c1CmdToolType.Anchor = AnchorStyles.Left;
            c1CmdToolType.DropDownAlign = C1.Framework.DropDownAlignment.Center;
            c1CmdToolType.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            c1CmdToolType.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c1CmdToolType.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            c1CmdToolType.Location = new Point(87, 18);
            c1CmdToolType.Name = "c1CmdToolType";
            c1CmdToolType.ReadOnly = true;
            c1CmdToolType.Size = new Size(215, 44);
            c1CmdToolType.TabIndex = 14;
            c1CmdToolType.TextAlign = HorizontalAlignment.Center;
            c1CmdToolType.SelectedIndexChanged += c1CmdToolType_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(318, 23);
            label6.Margin = new Padding(13, 3, 3, 0);
            label6.Name = "label6";
            label6.Size = new Size(183, 36);
            label6.TabIndex = 11;
            label6.Text = "Label Position:";
            // 
            // c1CmbLabelPosition
            // 
            c1CmbLabelPosition.Anchor = AnchorStyles.Left;
            c1CmbLabelPosition.DropDownAlign = C1.Framework.DropDownAlignment.Center;
            c1CmbLabelPosition.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            c1CmbLabelPosition.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c1CmbLabelPosition.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            c1CmbLabelPosition.Location = new Point(507, 18);
            c1CmbLabelPosition.Name = "c1CmbLabelPosition";
            c1CmbLabelPosition.ReadOnly = true;
            c1CmbLabelPosition.Size = new Size(174, 44);
            c1CmbLabelPosition.TabIndex = 15;
            c1CmbLabelPosition.TextAlign = HorizontalAlignment.Center;
            c1CmbLabelPosition.SelectedItemChanged += c1CmbLabelPosition_SelectedItemChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(697, 23);
            label2.Margin = new Padding(13, 3, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(94, 36);
            label2.TabIndex = 2;
            label2.Text = "StartX:";
            // 
            // nudStartX
            // 
            nudStartX.Anchor = AnchorStyles.Left;
            nudStartX.Location = new Point(797, 24);
            nudStartX.Minimum = -100;
            nudStartX.Name = "nudStartX";
            nudStartX.Size = new Size(77, 31);
            nudStartX.TabIndex = 18;
            nudStartX.TextAlign = HorizontalAlignment.Center;
            nudStartX.Value = new decimal(new int[] { 20, 0, 0, 0 });
            nudStartX.ValueChanged += nudStartX_ValueChanged_1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(893, 23);
            label3.Margin = new Padding(16, 3, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 36);
            label3.TabIndex = 4;
            label3.Text = "EndX:";
            // 
            // nudEndX
            // 
            nudEndX.Anchor = AnchorStyles.Left;
            nudEndX.Location = new Point(980, 24);
            nudEndX.Minimum = -100;
            nudEndX.Name = "nudEndX";
            nudEndX.Size = new Size(80, 31);
            nudEndX.TabIndex = 19;
            nudEndX.TextAlign = HorizontalAlignment.Center;
            nudEndX.Value = new decimal(new int[] { 2, 0, 0, 0 });
            nudEndX.ValueChanged += nudEndX_ValueChanged_1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 70);
            label4.Margin = new Padding(16, 3, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(93, 36);
            label4.TabIndex = 6;
            label4.Text = "StartY:";
            // 
            // nudStartY
            // 
            nudStartY.Anchor = AnchorStyles.Left;
            nudStartY.Location = new Point(115, 71);
            nudStartY.Minimum = -100;
            nudStartY.Name = "nudStartY";
            nudStartY.Size = new Size(79, 31);
            nudStartY.TabIndex = 21;
            nudStartY.TextAlign = HorizontalAlignment.Center;
            nudStartY.Value = new decimal(new int[] { 2, 0, 0, 0 });
            nudStartY.ValueChanged += nudStartY_ValueChanged_1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(213, 70);
            label5.Margin = new Padding(16, 3, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 36);
            label5.TabIndex = 8;
            label5.Text = "EndY:";
            // 
            // nudEndY
            // 
            nudEndY.Anchor = AnchorStyles.Left;
            nudEndY.Location = new Point(299, 71);
            nudEndY.Minimum = -100;
            nudEndY.Name = "nudEndY";
            nudEndY.Size = new Size(82, 31);
            nudEndY.TabIndex = 20;
            nudEndY.TextAlign = HorizontalAlignment.Center;
            nudEndY.Value = new decimal(new int[] { 2, 0, 0, 0 });
            nudEndY.ValueChanged += nudEndY_ValueChanged_1;
            // 
            // c1CbUptrend
            // 
            c1CbUptrend.Anchor = AnchorStyles.Left;
            c1CbUptrend.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c1CbUptrend.Location = new Point(387, 69);
            c1CbUptrend.Name = "c1CbUptrend";
            c1CbUptrend.Size = new Size(104, 35);
            c1CbUptrend.TabIndex = 16;
            c1CbUptrend.Text = "Uptrend";
            c1CbUptrend.Value = null;
            c1CbUptrend.CheckedChanged += c1CbUptrend_CheckedChanged;
            // 
            // c1CbRangeSelector
            // 
            c1CbRangeSelector.Anchor = AnchorStyles.None;
            c1CbRangeSelector.Font = new Font("Segoe UI Variable Display", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            c1CbRangeSelector.Location = new Point(497, 68);
            c1CbRangeSelector.Name = "c1CbRangeSelector";
            c1CbRangeSelector.Size = new Size(104, 37);
            c1CbRangeSelector.TabIndex = 17;
            c1CbRangeSelector.Text = "Range Selector";
            c1CbRangeSelector.Value = null;
            c1CbRangeSelector.CheckedChanged += c1CbRangeSelector_CheckedChanged;
            // 
            // FibonacciTool
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FibonacciTool";
            Size = new Size(1168, 560);
            Load += OnLoad;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)financialChart1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)c1CmdToolType).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1CmbLabelPosition).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStartX).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEndX).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStartY).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEndY).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1CbUptrend).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1CbRangeSelector).EndInit();
            ResumeLayout(false);

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
        private C1.Win.Input.C1ComboBox c1CmdToolType;
        private C1.Win.Input.C1ComboBox c1CmbLabelPosition;
        private C1.Win.Input.C1CheckBox c1CbUptrend;
        private C1.Win.Input.C1CheckBox c1CbRangeSelector;
        private C1NumericEditEx nudStartX;
        private C1NumericEditEx nudEndX;
        private C1NumericEditEx nudStartY;
        private C1NumericEditEx nudEndY;
    }
}
