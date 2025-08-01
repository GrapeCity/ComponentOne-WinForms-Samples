namespace FinancialChartExplorer.Samples
{
    partial class LineMarker
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
            C1.Chart.ElementSize elementSize2 = new C1.Chart.ElementSize();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            c1CbLines = new C1.Win.Input.C1ComboBox();
            label2 = new Label();
            c1CbAlignment = new C1.Win.Input.C1ComboBox();
            label3 = new Label();
            c1CbInteraction = new C1.Win.Input.C1ComboBox();
            financialChart1 = new C1.Win.Chart.Finance.FinancialChart();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1CbLines).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1CbAlignment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1CbInteraction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)financialChart1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(financialChart1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(5, 6, 5, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1136, 658);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(c1CbLines);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(c1CbAlignment);
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(c1CbInteraction);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 586);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 23, 0, 0);
            flowLayoutPanel1.Size = new Size(1136, 72);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 13F);
            label1.Location = new Point(0, 30);
            label1.Margin = new Padding(0, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 35);
            label1.TabIndex = 3;
            label1.Text = "Lines:";
            // 
            // c1CbLines
            // 
            c1CbLines.DropDownAlign = C1.Framework.DropDownAlignment.Center;
            c1CbLines.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            c1CbLines.Font = new Font("Segoe UI Variable Display", 13F);
            c1CbLines.GapHeight = 5;
            c1CbLines.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            c1CbLines.Location = new Point(86, 26);
            c1CbLines.Name = "c1CbLines";
            c1CbLines.ReadOnly = true;
            c1CbLines.Size = new Size(211, 43);
            c1CbLines.TabIndex = 6;
            c1CbLines.TextAlign = HorizontalAlignment.Center;
            c1CbLines.SelectedIndexChanged += c1CbLines_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 13F);
            label2.Location = new Point(305, 30);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 35);
            label2.TabIndex = 4;
            label2.Text = "Alignment:";
            // 
            // c1CbAlignment
            // 
            c1CbAlignment.DropDownAlign = C1.Framework.DropDownAlignment.Center;
            c1CbAlignment.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            c1CbAlignment.Font = new Font("Segoe UI Variable Display", 13F);
            c1CbAlignment.GapHeight = 5;
            c1CbAlignment.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            c1CbAlignment.Location = new Point(450, 26);
            c1CbAlignment.Name = "c1CbAlignment";
            c1CbAlignment.ReadOnly = true;
            c1CbAlignment.Size = new Size(165, 43);
            c1CbAlignment.TabIndex = 8;
            c1CbAlignment.TextAlign = HorizontalAlignment.Center;
            c1CbAlignment.SelectedIndexChanged += c1CbAlignment_SelectedIndexChanged1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 13F);
            label3.Location = new Point(623, 30);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(130, 35);
            label3.TabIndex = 5;
            label3.Text = "Interation:";
            // 
            // c1CbInteraction
            // 
            c1CbInteraction.DropDownAlign = C1.Framework.DropDownAlignment.Center;
            c1CbInteraction.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            c1CbInteraction.Font = new Font("Segoe UI Variable Display", 13F);
            c1CbInteraction.GapHeight = 5;
            c1CbInteraction.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            c1CbInteraction.Location = new Point(761, 26);
            c1CbInteraction.Name = "c1CbInteraction";
            c1CbInteraction.ReadOnly = true;
            c1CbInteraction.Size = new Size(165, 43);
            c1CbInteraction.TabIndex = 7;
            c1CbInteraction.TextAlign = HorizontalAlignment.Center;
            c1CbInteraction.SelectedIndexChanged += c1CbInteraction_SelectedIndexChanged;
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
            financialChart1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            financialChart1.Options.ClusterSize = elementSize2;
            financialChart1.Options.ReversalAmount = 1D;
            financialChart1.PlotMargin = new Padding(0);
            financialChart1.SelectedSeries = null;
            financialChart1.SelectionStyle.StrokeColor = Color.Red;
            financialChart1.Size = new Size(1136, 586);
            financialChart1.TabIndex = 1;
            financialChart1.Text = "financialChart1";
            // 
            // 
            // 
            financialChart1.ToolTip.Content = "{value}";
            // 
            // LineMarker
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "LineMarker";
            Size = new Size(1136, 658);
            Load += OnLoad;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)c1CbLines).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1CbAlignment).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1CbInteraction).EndInit();
            ((System.ComponentModel.ISupportInitialize)financialChart1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private C1.Win.Chart.Finance.FinancialChart financialChart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private C1.Win.Input.C1ComboBox c1CbLines;
        private C1.Win.Input.C1ComboBox c1CbInteraction;
        private C1.Win.Input.C1ComboBox c1CbAlignment;
    }
}
