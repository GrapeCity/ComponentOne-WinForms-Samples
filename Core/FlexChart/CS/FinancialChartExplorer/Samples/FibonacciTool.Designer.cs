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
            C1.Chart.ElementSize elementSize2 = new C1.Chart.ElementSize();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.financialChart1 = new C1.Win.Chart.Finance.FinancialChart();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdToolType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbLabelPosition = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudStartX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudEndX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudStartY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nudEndY = new System.Windows.Forms.NumericUpDown();
            this.cbUptrend = new System.Windows.Forms.CheckBox();
            this.cbRangeSelector = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndY)).BeginInit();
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
            this.financialChart1.AxisX.Chart = this.financialChart1;
            this.financialChart1.AxisX.Position = C1.Chart.Position.Bottom;
            this.financialChart1.AxisY.AxisLine = false;
            this.financialChart1.AxisY.Chart = this.financialChart1;
            this.financialChart1.AxisY.MajorGrid = true;
            this.financialChart1.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.financialChart1.AxisY.Position = C1.Chart.Position.Left;
            this.financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Column;
            this.financialChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financialChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.financialChart1.Legend.Position = C1.Chart.Position.Right;
            this.financialChart1.Legend.Reversed = false;
            this.financialChart1.Legend.Title = null;
            this.financialChart1.Location = new System.Drawing.Point(10, 10);
            this.financialChart1.Margin = new System.Windows.Forms.Padding(10);
            this.financialChart1.Name = "financialChart1";
            elementSize2.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize2.Value = 70D;
            this.financialChart1.Options.ClusterSize = elementSize2;
            this.financialChart1.Options.ReversalAmount = 1D;
            this.financialChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            this.financialChart1.SelectedSeries = null;
            this.financialChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.financialChart1.Size = new System.Drawing.Size(780, 195);
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
            this.flowLayoutPanel1.Controls.Add(this.cmdToolType);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.cmbLabelPosition);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.nudStartX);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.nudEndX);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.nudStartY);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.nudEndY);
            this.flowLayoutPanel1.Controls.Add(this.cbUptrend);
            this.flowLayoutPanel1.Controls.Add(this.cbRangeSelector);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 218);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 51);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type";
            // 
            // cmdToolType
            // 
            this.cmdToolType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdToolType.FormattingEnabled = true;
            this.cmdToolType.Location = new System.Drawing.Point(38, 3);
            this.cmdToolType.Name = "cmdToolType";
            this.cmdToolType.Size = new System.Drawing.Size(100, 21);
            this.cmdToolType.TabIndex = 1;
            this.cmdToolType.SelectedIndexChanged += new System.EventHandler(this.cmbToolType_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(13, 3, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Label Position";
            // 
            // cmbLabelPosition
            // 
            this.cmbLabelPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLabelPosition.FormattingEnabled = true;
            this.cmbLabelPosition.Location = new System.Drawing.Point(239, 3);
            this.cmbLabelPosition.Name = "cmbLabelPosition";
            this.cmbLabelPosition.Size = new System.Drawing.Size(80, 21);
            this.cmbLabelPosition.TabIndex = 9;
            this.cmbLabelPosition.SelectedIndexChanged += new System.EventHandler(this.cmbLabelPosition_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(13, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "StartX";
            // 
            // nudStartX
            // 
            this.nudStartX.DecimalPlaces = 2;
            this.nudStartX.Location = new System.Drawing.Point(378, 3);
            this.nudStartX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudStartX.Name = "nudStartX";
            this.nudStartX.Size = new System.Drawing.Size(52, 22);
            this.nudStartX.TabIndex = 3;
            this.nudStartX.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudStartX.ValueChanged += new System.EventHandler(this.nudStartX_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(449, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "EndX";
            // 
            // nudEndX
            // 
            this.nudEndX.DecimalPlaces = 2;
            this.nudEndX.Location = new System.Drawing.Point(488, 3);
            this.nudEndX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudEndX.Name = "nudEndX";
            this.nudEndX.Size = new System.Drawing.Size(52, 22);
            this.nudEndX.TabIndex = 5;
            this.nudEndX.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudEndX.ValueChanged += new System.EventHandler(this.nudEndX_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "StartY";
            // 
            // nudStartY
            // 
            this.nudStartY.DecimalPlaces = 2;
            this.nudStartY.Location = new System.Drawing.Point(601, 3);
            this.nudStartY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudStartY.Name = "nudStartY";
            this.nudStartY.Size = new System.Drawing.Size(52, 22);
            this.nudStartY.TabIndex = 7;
            this.nudStartY.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.nudStartY.ValueChanged += new System.EventHandler(this.nudStartY_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(672, 3);
            this.label5.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "EndY";
            // 
            // nudEndY
            // 
            this.nudEndY.DecimalPlaces = 2;
            this.nudEndY.Location = new System.Drawing.Point(710, 3);
            this.nudEndY.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudEndY.Name = "nudEndY";
            this.nudEndY.Size = new System.Drawing.Size(52, 22);
            this.nudEndY.TabIndex = 10;
            this.nudEndY.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.nudEndY.ValueChanged += new System.EventHandler(this.nudEndY_ValueChanged);
            // 
            // cbUptrend
            // 
            this.cbUptrend.AutoSize = true;
            this.cbUptrend.Location = new System.Drawing.Point(3, 31);
            this.cbUptrend.Name = "cbUptrend";
            this.cbUptrend.Size = new System.Drawing.Size(69, 17);
            this.cbUptrend.TabIndex = 12;
            this.cbUptrend.Text = "Uptrend";
            this.cbUptrend.UseVisualStyleBackColor = true;
            this.cbUptrend.CheckedChanged += new System.EventHandler(this.cbUptrend_CheckedChanged);
            // 
            // cbRangeSelector
            // 
            this.cbRangeSelector.AutoSize = true;
            this.cbRangeSelector.Location = new System.Drawing.Point(78, 31);
            this.cbRangeSelector.Name = "cbRangeSelector";
            this.cbRangeSelector.Size = new System.Drawing.Size(103, 17);
            this.cbRangeSelector.TabIndex = 13;
            this.cbRangeSelector.Text = "Range Selector";
            this.cbRangeSelector.UseVisualStyleBackColor = true;
            this.cbRangeSelector.CheckedChanged += new System.EventHandler(this.cbRangeSelector_CheckedChanged);
            // 
            // FibonacciTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudStartX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStartY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEndY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private C1.Win.Chart.Finance.FinancialChart financialChart1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmdToolType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudStartX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudEndX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudStartY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLabelPosition;
        private System.Windows.Forms.NumericUpDown nudEndY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbUptrend;
        private System.Windows.Forms.CheckBox cbRangeSelector;
    }
}
