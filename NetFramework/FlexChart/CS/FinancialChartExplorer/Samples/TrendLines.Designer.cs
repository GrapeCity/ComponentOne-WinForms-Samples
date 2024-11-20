using FinancialChartExplorer.CustomControls;

namespace FinancialChartExplorer.Samples
{
    partial class TrendLines
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.c1FitType = new C1.Win.C1Input.C1ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.order = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.c1ChkForecast = new C1.Win.C1Input.C1CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numForwardPeriods = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.label4 = new System.Windows.Forms.Label();
            this.numBackwardPeriods = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.financialChart1 = new C1.Win.Chart.Finance.FinancialChart();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FitType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ChkForecast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numForwardPeriods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBackwardPeriods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.financialChart1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 263);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.c1FitType);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.order);
            this.flowLayoutPanel1.Controls.Add(this.c1ChkForecast);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.numForwardPeriods);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.numBackwardPeriods);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 208);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1000, 55);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fit Type:";
            // 
            // c1FitType
            // 
            this.c1FitType.AllowSpinLoop = false;
            this.c1FitType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.c1FitType.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.c1FitType.GapHeight = 5;
            this.c1FitType.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1FitType.Location = new System.Drawing.Point(103, 17);
            this.c1FitType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.c1FitType.Name = "c1FitType";
            this.c1FitType.Size = new System.Drawing.Size(89, 36);
            this.c1FitType.TabIndex = 10;
            this.c1FitType.Tag = null;
            this.c1FitType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c1FitType.SelectedIndexChanged += new System.EventHandler(this.c1FitType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.label2.Location = new System.Drawing.Point(199, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order:";
            // 
            // order
            // 
            this.order.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.order.GapHeight = 0;
            this.order.ImagePadding = new System.Windows.Forms.Padding(0);
            this.order.Location = new System.Drawing.Point(280, 24);
            this.order.Maximum = 10;
            this.order.Minimum = 2;
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(63, 22);
            this.order.TabIndex = 12;
            this.order.Tag = null;
            this.order.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.order.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.order.ValueChanged += new System.EventHandler(this.order_ValueChanged_1);
            // 
            // c1ChkForecast
            // 
            this.c1ChkForecast.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.c1ChkForecast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1ChkForecast.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.c1ChkForecast.Location = new System.Drawing.Point(349, 19);
            this.c1ChkForecast.Margin = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.c1ChkForecast.Name = "c1ChkForecast";
            this.c1ChkForecast.Size = new System.Drawing.Size(120, 31);
            this.c1ChkForecast.TabIndex = 11;
            this.c1ChkForecast.Text = "Forecast Enable";
            this.c1ChkForecast.UseVisualStyleBackColor = true;
            this.c1ChkForecast.Value = null;
            this.c1ChkForecast.CheckedChanged += new System.EventHandler(this.c1ChkForecast_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.label3.Location = new System.Drawing.Point(469, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 4, 4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Forward:";
            // 
            // numForwardPeriods
            // 
            this.numForwardPeriods.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numForwardPeriods.GapHeight = 0;
            this.numForwardPeriods.ImagePadding = new System.Windows.Forms.Padding(0);
            this.numForwardPeriods.Location = new System.Drawing.Point(574, 24);
            this.numForwardPeriods.Name = "numForwardPeriods";
            this.numForwardPeriods.Size = new System.Drawing.Size(73, 22);
            this.numForwardPeriods.TabIndex = 13;
            this.numForwardPeriods.Tag = null;
            this.numForwardPeriods.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numForwardPeriods.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.numForwardPeriods.ValueChanged += new System.EventHandler(this.numForwardPeriods_ValueChanged_1);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.label4.Location = new System.Drawing.Point(654, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Backward:";
            // 
            // numBackwardPeriods
            // 
            this.numBackwardPeriods.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.numBackwardPeriods.GapHeight = 0;
            this.numBackwardPeriods.ImagePadding = new System.Windows.Forms.Padding(0);
            this.numBackwardPeriods.Location = new System.Drawing.Point(772, 24);
            this.numBackwardPeriods.Name = "numBackwardPeriods";
            this.numBackwardPeriods.Size = new System.Drawing.Size(73, 22);
            this.numBackwardPeriods.TabIndex = 14;
            this.numBackwardPeriods.Tag = null;
            this.numBackwardPeriods.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numBackwardPeriods.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.numBackwardPeriods.ValueChanged += new System.EventHandler(this.numBackwardPeriods_ValueChanged_1);
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
            this.financialChart1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialChart1.Legend.ItemMaxWidth = 0;
            this.financialChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.financialChart1.Legend.Position = C1.Chart.Position.Right;
            this.financialChart1.Legend.Reversed = false;
            this.financialChart1.Legend.ScrollBars = C1.Chart.LegendScrollBars.None;
            this.financialChart1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.financialChart1.Legend.Title = null;
            this.financialChart1.Location = new System.Drawing.Point(0, 0);
            this.financialChart1.Margin = new System.Windows.Forms.Padding(0);
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
            this.financialChart1.Size = new System.Drawing.Size(1000, 208);
            this.financialChart1.TabIndex = 1;
            this.financialChart1.Text = "financialChart1";
            // 
            // 
            // 
            this.financialChart1.ToolTip.Content = "{value}";
            // 
            // TrendLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TrendLines";
            this.Size = new System.Drawing.Size(1000, 263);
            this.Load += new System.EventHandler(this.OnLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1FitType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ChkForecast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numForwardPeriods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBackwardPeriods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private C1.Win.Chart.Finance.FinancialChart financialChart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private C1.Win.C1Input.C1ComboBox c1FitType;
        private C1.Win.C1Input.C1CheckBox c1ChkForecast;
        private C1NumericEditEx order;
        private C1NumericEditEx numForwardPeriods;
        private C1NumericEditEx numBackwardPeriods;
    }
}
