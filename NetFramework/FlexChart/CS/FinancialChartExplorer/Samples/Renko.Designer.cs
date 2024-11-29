using FinancialChartExplorer.CustomControls;

namespace FinancialChartExplorer.Samples
{
    partial class Renko
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
            this.label2 = new System.Windows.Forms.Label();
            this.boxSize = new FinancialChartExplorer.CustomControls.C1NumericEditEx();
            this.label3 = new System.Windows.Forms.Label();
            this.c1RangeMode = new C1.Win.C1Input.C1ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.c1DataFields = new C1.Win.C1Input.C1ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1RangeMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DataFields)).BeginInit();
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 214);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.c1ComboBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(443, 57);
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
            this.c1ComboBox1.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.c1ComboBox1.GapHeight = 5;
            this.c1ComboBox1.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1ComboBox1.ItemsDisplayMember = "Name";
            this.c1ComboBox1.ItemsValueMember = "Symbol";
            this.c1ComboBox1.Location = new System.Drawing.Point(96, 3);
            this.c1ComboBox1.Name = "c1ComboBox1";
            this.c1ComboBox1.Size = new System.Drawing.Size(135, 36);
            this.c1ComboBox1.TabIndex = 2;
            this.c1ComboBox1.Tag = null;
            this.c1ComboBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c1ComboBox1.TextDetached = true;
            this.c1ComboBox1.TranslateValue = true;
            this.c1ComboBox1.Value = "";
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
            this.financialChart1.Size = new System.Drawing.Size(443, 58);
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
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.boxSize);
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.c1RangeMode);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.c1DataFields);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 115);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(443, 99);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.label2.Location = new System.Drawing.Point(0, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Box Size:";
            // 
            // boxSize
            // 
            this.boxSize.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.boxSize.GapHeight = 0;
            this.boxSize.ImagePadding = new System.Windows.Forms.Padding(0);
            this.boxSize.Location = new System.Drawing.Point(101, 18);
            this.boxSize.Name = "boxSize";
            this.boxSize.Size = new System.Drawing.Size(60, 26);
            this.boxSize.TabIndex = 9;
            this.boxSize.Tag = null;
            this.boxSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.boxSize.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.boxSize.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.UpDown;
            this.boxSize.ValueChanged += new System.EventHandler(this.boxSize_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.label3.Location = new System.Drawing.Point(177, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(13, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Range Mode:";
            // 
            // c1RangeMode
            // 
            this.c1RangeMode.AllowSpinLoop = false;
            this.c1RangeMode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.c1RangeMode.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.c1RangeMode.GapHeight = 5;
            this.c1RangeMode.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1RangeMode.Location = new System.Drawing.Point(323, 18);
            this.c1RangeMode.Name = "c1RangeMode";
            this.c1RangeMode.Size = new System.Drawing.Size(109, 36);
            this.c1RangeMode.TabIndex = 7;
            this.c1RangeMode.Tag = null;
            this.c1RangeMode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c1RangeMode.Value = "";
            this.c1RangeMode.SelectedIndexChanged += new System.EventHandler(this.c1RangeMode_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.label4.Location = new System.Drawing.Point(13, 64);
            this.label4.Margin = new System.Windows.Forms.Padding(13, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 30);
            this.label4.TabIndex = 4;
            this.label4.Text = "Data Fields:";
            // 
            // c1DataFields
            // 
            this.c1DataFields.AllowSpinLoop = false;
            this.c1DataFields.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.c1DataFields.Font = new System.Drawing.Font("Segoe UI Variable Display", 13F);
            this.c1DataFields.GapHeight = 5;
            this.c1DataFields.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1DataFields.Location = new System.Drawing.Point(142, 60);
            this.c1DataFields.Name = "c1DataFields";
            this.c1DataFields.Size = new System.Drawing.Size(99, 36);
            this.c1DataFields.TabIndex = 8;
            this.c1DataFields.Tag = null;
            this.c1DataFields.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.c1DataFields.Value = "";
            this.c1DataFields.SelectedIndexChanged += new System.EventHandler(this.c1DataFields_SelectedIndexChanged);
            // 
            // Renko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Renko";
            this.Size = new System.Drawing.Size(443, 214);
            this.Load += new System.EventHandler(this.OnLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1ComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1RangeMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DataFields)).EndInit();
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
        private C1.Win.C1Input.C1ComboBox c1ComboBox1;
        private C1.Win.C1Input.C1ComboBox c1RangeMode;
        private C1.Win.C1Input.C1ComboBox c1DataFields;
        private C1NumericEditEx boxSize;
    }
}
