using FinancialChartExplorer.CustomControls;

namespace FinancialChartExplorer.Samples
{
    partial class PointAndFigure
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
            this.c1ComboBox1 = new C1.Win.C1Input.C1ComboBox();
            this.financialChart1 = new C1.Win.Chart.Finance.FinancialChart();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.c1DataFields = new C1.Win.C1Input.C1ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reversal = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.label3 = new System.Windows.Forms.Label();
            this.c1Scaling = new C1.Win.C1Input.C1ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.boxSize = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.label6 = new System.Windows.Forms.Label();
            this.period = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.c1SquareGrid = new C1.Win.C1Input.C1CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DataFields)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reversal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Scaling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.period)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SquareGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.financialChart1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(535, 325);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.c1ComboBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(535, 57);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.label1.Location = new System.Drawing.Point(0, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Symbol:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // c1ComboBox1
            // 
            this.c1ComboBox1.AllowSpinLoop = false;
            this.c1ComboBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.c1ComboBox1.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.c1ComboBox1.GapHeight = 5;
            this.c1ComboBox1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ComboBox1.ItemsDisplayMember = "Name";
            this.c1ComboBox1.ItemsValueMember = "Symbol";
            this.c1ComboBox1.Location = new System.Drawing.Point(96, 3);
            this.c1ComboBox1.MaximumSize = new System.Drawing.Size(140, 36);
            this.c1ComboBox1.Name = "c1ComboBox1";
            this.c1ComboBox1.Size = new System.Drawing.Size(140, 36);
            this.c1ComboBox1.TabIndex = 2;
            this.c1ComboBox1.Tag = null;
            this.c1ComboBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c1ComboBox1.TextDetached = true;
            this.c1ComboBox1.TranslateValue = true;
            this.c1ComboBox1.SelectedIndexChanged += new System.EventHandler(this.c1ComboBox1_SelectedIndexChanged);
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
            this.financialChart1.Location = new System.Drawing.Point(0, 57);
            this.financialChart1.Margin = new System.Windows.Forms.Padding(0);
            this.financialChart1.Name = "financialChart1";
            this.financialChart1.Options.BoxSize = 2D;
            this.financialChart1.Options.Chart = this.financialChart1;
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.financialChart1.Options.ClusterSize = elementSize1;
            this.financialChart1.Options.ReversalAmount = 2D;
            this.financialChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            this.financialChart1.SelectedSeries = null;
            this.financialChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.financialChart1.Size = new System.Drawing.Size(535, 130);
            this.financialChart1.TabIndex = 1;
            this.financialChart1.Text = "financialChart1";
            // 
            // 
            // 
            this.financialChart1.ToolTip.Content = "{value}";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.c1DataFields);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.reversal);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.c1Scaling);
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.boxSize);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.period);
            this.flowLayoutPanel2.Controls.Add(this.c1SquareGrid);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 187);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(535, 138);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.label4.Location = new System.Drawing.Point(3, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data Fields:";
            // 
            // c1DataFields
            // 
            this.c1DataFields.AllowSpinLoop = false;
            this.c1DataFields.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.c1DataFields.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.c1DataFields.GapHeight = 5;
            this.c1DataFields.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1DataFields.Location = new System.Drawing.Point(132, 18);
            this.c1DataFields.Name = "c1DataFields";
            this.c1DataFields.Size = new System.Drawing.Size(109, 36);
            this.c1DataFields.TabIndex = 0;
            this.c1DataFields.Tag = null;
            this.c1DataFields.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c1DataFields.SelectedIndexChanged += new System.EventHandler(this.c1DataFields_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.label5.Location = new System.Drawing.Point(247, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Reversal:";
            // 
            // reversal
            // 
            this.reversal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.reversal.GapHeight = 0;
            this.reversal.ImagePadding = new System.Windows.Forms.Padding(0);
            this.reversal.Location = new System.Drawing.Point(350, 23);
            this.reversal.Maximum = 5;
            this.reversal.Minimum = 2;
            this.reversal.Name = "reversal";
            this.reversal.Size = new System.Drawing.Size(62, 26);
            this.reversal.TabIndex = 15;
            this.reversal.Tag = null;
            this.reversal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reversal.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.reversal.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.reversal.ValueChanged += new System.EventHandler(this.reversal_ValueChanged_1);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.label3.Location = new System.Drawing.Point(428, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(13, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Scaling:";
            // 
            // c1Scaling
            // 
            this.c1Scaling.AllowSpinLoop = false;
            this.c1Scaling.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.c1Scaling.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.c1Scaling.GapHeight = 5;
            this.c1Scaling.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1Scaling.Location = new System.Drawing.Point(3, 60);
            this.c1Scaling.Name = "c1Scaling";
            this.c1Scaling.Size = new System.Drawing.Size(109, 36);
            this.c1Scaling.TabIndex = 11;
            this.c1Scaling.Tag = null;
            this.c1Scaling.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c1Scaling.SelectedIndexChanged += new System.EventHandler(this.c1Scaling_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.label2.Location = new System.Drawing.Point(118, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Box Size:";
            // 
            // boxSize
            // 
            this.boxSize.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxSize.GapHeight = 0;
            this.boxSize.ImagePadding = new System.Windows.Forms.Padding(0);
            this.boxSize.Location = new System.Drawing.Point(219, 65);
            this.boxSize.Name = "boxSize";
            this.boxSize.Size = new System.Drawing.Size(62, 26);
            this.boxSize.TabIndex = 16;
            this.boxSize.Tag = null;
            this.boxSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.boxSize.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.boxSize.ValueChanged += new System.EventHandler(this.boxSize_ValueChanged_1);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.label6.Location = new System.Drawing.Point(287, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 30);
            this.label6.TabIndex = 8;
            this.label6.Text = "ATR Period:";
            // 
            // period
            // 
            this.period.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.period.GapHeight = 0;
            this.period.ImagePadding = new System.Windows.Forms.Padding(0);
            this.period.Location = new System.Drawing.Point(412, 65);
            this.period.Maximum = 30;
            this.period.Minimum = 7;
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(62, 26);
            this.period.TabIndex = 17;
            this.period.Tag = null;
            this.period.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.period.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.period.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.period.ValueChanged += new System.EventHandler(this.period_ValueChanged_1);
            // 
            // c1SquareGrid
            // 
            this.c1SquareGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.c1SquareGrid.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.c1SquareGrid.Location = new System.Drawing.Point(3, 107);
            this.c1SquareGrid.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.c1SquareGrid.Name = "c1SquareGrid";
            this.c1SquareGrid.Size = new System.Drawing.Size(104, 28);
            this.c1SquareGrid.TabIndex = 14;
            this.c1SquareGrid.Text = "Square Grid";
            this.c1SquareGrid.UseVisualStyleBackColor = false;
            this.c1SquareGrid.Value = null;
            this.c1SquareGrid.CheckedChanged += new System.EventHandler(this.c1SquareGrid_CheckedChanged);
            // 
            // PointAndFigure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PointAndFigure";
            this.Size = new System.Drawing.Size(535, 325);
            this.Load += new System.EventHandler(this.OnLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1DataFields)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reversal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1Scaling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.period)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1SquareGrid)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private C1.Win.C1Input.C1ComboBox c1ComboBox1;
        private C1.Win.C1Input.C1ComboBox c1DataFields;
        private C1.Win.C1Input.C1ComboBox c1Scaling;
        private C1.Win.C1Input.C1CheckBox c1SquareGrid;
        private C1NumericEditEx reversal;
        private C1NumericEditEx boxSize;
        private C1NumericEditEx period;
    }
}
