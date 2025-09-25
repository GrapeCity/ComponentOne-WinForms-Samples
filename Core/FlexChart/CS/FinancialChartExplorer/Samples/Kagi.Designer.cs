using FinancialChartExplorer.CustomControls;

namespace FinancialChartExplorer.Samples
{
    partial class Kagi
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            label1 = new Label();
            c1ComboBox1 = new C1.Win.Input.C1ComboBox();
            financialChart1 = new C1.Win.Chart.Finance.FinancialChart();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label2 = new Label();
            reversalAmount1 = new C1NumericEditEx();
            label3 = new Label();
            c1RangeMode = new C1.Win.Input.C1ComboBox();
            label4 = new Label();
            c1DataFields = new C1.Win.Input.C1ComboBox();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1ComboBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)financialChart1).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reversalAmount1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1RangeMode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1DataFields).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(financialChart1, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(1114, 616);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(c1ComboBox1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 0, 0, 15);
            flowLayoutPanel1.Size = new Size(1114, 64);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 13F);
            label1.Location = new Point(0, 7);
            label1.Margin = new Padding(0, 3, 3, 3);
            label1.Name = "label1";
            label1.Size = new Size(105, 35);
            label1.TabIndex = 0;
            label1.Text = "Symbol:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // c1ComboBox1
            // 
            c1ComboBox1.DropDownAlign = C1.Framework.DropDownAlignment.Center;
            c1ComboBox1.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            c1ComboBox1.Font = new Font("Segoe UI Variable Display", 13F);
            c1ComboBox1.GapHeight = 5;
            c1ComboBox1.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            c1ComboBox1.ItemsDisplayMember = "Name";
            c1ComboBox1.ItemsValueMember = "Symbol";
            c1ComboBox1.Location = new Point(111, 3);
            c1ComboBox1.Name = "c1ComboBox1";
            c1ComboBox1.ReadOnly = true;
            c1ComboBox1.Size = new Size(200, 43);
            c1ComboBox1.TabIndex = 2;
            c1ComboBox1.TextAlign = HorizontalAlignment.Center;
            c1ComboBox1.Value = "";
            c1ComboBox1.SelectedIndexChanged += c1ComboBox1_SelectedIndexChanged;
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
            financialChart1.Location = new Point(0, 64);
            financialChart1.Margin = new Padding(0);
            financialChart1.Name = "financialChart1";
            financialChart1.Options.BoxSize = 2D;
            financialChart1.Options.Chart = financialChart1;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            financialChart1.Options.ClusterSize = elementSize1;
            financialChart1.Options.ReversalAmount = 2D;
            financialChart1.PlotMargin = new Padding(0);
            financialChart1.SelectedSeries = null;
            financialChart1.SelectionStyle.StrokeColor = Color.Red;
            financialChart1.Size = new Size(1114, 488);
            financialChart1.TabIndex = 1;
            financialChart1.Text = "financialChart1";
            // 
            // 
            // 
            financialChart1.ToolTip.Content = "{value}";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSize = true;
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(reversalAmount1);
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Controls.Add(c1RangeMode);
            flowLayoutPanel2.Controls.Add(label4);
            flowLayoutPanel2.Controls.Add(c1DataFields);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 552);
            flowLayoutPanel2.Margin = new Padding(0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(0, 15, 0, 0);
            flowLayoutPanel2.Size = new Size(1114, 64);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Variable Display", 13F);
            label2.Location = new Point(0, 23);
            label2.Margin = new Padding(0, 3, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(212, 35);
            label2.TabIndex = 0;
            label2.Text = "Reversal Amount:";
            // 
            // reversalAmount1
            // 
            reversalAmount1.Location = new Point(218, 18);
            reversalAmount1.Name = "reversalAmount1";
            reversalAmount1.Size = new Size(65, 31);
            reversalAmount1.TabIndex = 8;
            reversalAmount1.TextAlign = HorizontalAlignment.Center;
            reversalAmount1.Value = new decimal(new int[] { 2, 0, 0, 0 });
            reversalAmount1.ValueChanged += reversalAmount1_ValueChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Variable Display", 13F);
            label3.Location = new Point(299, 23);
            label3.Margin = new Padding(13, 3, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(164, 35);
            label3.TabIndex = 2;
            label3.Text = "Range Mode:";
            // 
            // c1RangeMode
            // 
            c1RangeMode.DropDownAlign = C1.Framework.DropDownAlignment.Center;
            c1RangeMode.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            c1RangeMode.Font = new Font("Segoe UI Variable Display", 13F);
            c1RangeMode.GapHeight = 5;
            c1RangeMode.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            c1RangeMode.Location = new Point(469, 18);
            c1RangeMode.Name = "c1RangeMode";
            c1RangeMode.ReadOnly = true;
            c1RangeMode.Size = new Size(180, 43);
            c1RangeMode.TabIndex = 6;
            c1RangeMode.TextAlign = HorizontalAlignment.Center;
            c1RangeMode.Value = "";
            c1RangeMode.SelectedIndexChanged += c1RangeMode_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Display", 13F);
            label4.Location = new Point(665, 23);
            label4.Margin = new Padding(13, 3, 3, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 35);
            label4.TabIndex = 4;
            label4.Text = "Data Fields:";
            // 
            // c1DataFields
            // 
            c1DataFields.DropDownAlign = C1.Framework.DropDownAlignment.Center;
            c1DataFields.DropDownStyle = C1.Win.Input.DropDownStyle.DropDownList;
            c1DataFields.Font = new Font("Segoe UI Variable Display", 13F);
            c1DataFields.GapHeight = 5;
            c1DataFields.InitialSelection = C1.Win.Input.InitialSelection.CaretAtStart;
            c1DataFields.Location = new Point(815, 18);
            c1DataFields.Name = "c1DataFields";
            c1DataFields.ReadOnly = true;
            c1DataFields.Size = new Size(184, 43);
            c1DataFields.TabIndex = 7;
            c1DataFields.TextAlign = HorizontalAlignment.Center;
            c1DataFields.Value = "";
            c1DataFields.SelectedIndexChanged += c1DataFields_SelectedIndexChanged;
            // 
            // Kagi
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Kagi";
            Size = new Size(1114, 616);
            Load += OnLoad;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)c1ComboBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)financialChart1).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reversalAmount1).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1RangeMode).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1DataFields).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private C1.Win.Chart.Finance.FinancialChart financialChart1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private C1.Win.Input.C1ComboBox c1ComboBox1;
        private C1.Win.Input.C1ComboBox c1RangeMode;
        private C1.Win.Input.C1ComboBox c1DataFields;
        private C1NumericEditEx reversalAmount1;
    }
}
