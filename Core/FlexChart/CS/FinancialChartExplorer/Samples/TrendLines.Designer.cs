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
            this.fitType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.NumericUpDown();
            this.chkForecast = new System.Windows.Forms.CheckBox();
            this.financialChart1 = new C1.Win.Chart.Finance.FinancialChart();
            this.label3 = new System.Windows.Forms.Label();
            this.numForwardPeriods = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numBackwardPeriods = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numForwardPeriods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBackwardPeriods)).BeginInit();
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(750, 214);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.fitType);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.order);
            this.flowLayoutPanel1.Controls.Add(this.chkForecast);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.numForwardPeriods);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.numBackwardPeriods);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 184);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(744, 27);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fit Type";
            // 
            // fitType
            // 
            this.fitType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fitType.FormattingEnabled = true;
            this.fitType.Location = new System.Drawing.Point(54, 3);
            this.fitType.Name = "fitType";
            this.fitType.Size = new System.Drawing.Size(121, 21);
            this.fitType.TabIndex = 1;
            this.fitType.SelectedIndexChanged += new System.EventHandler(this.fitType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order";
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(233, 3);
            this.order.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.order.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(56, 20);
            this.order.TabIndex = 3;
            this.order.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.order.ValueChanged += new System.EventHandler(this.order_ValueChanged);
            // 
            // chkForecast
            // 
            this.chkForecast.AutoSize = true;
            this.chkForecast.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkForecast.Location = new System.Drawing.Point(316, 3);
            this.chkForecast.Margin = new System.Windows.Forms.Padding(24, 3, 3, 3);
            this.chkForecast.Name = "chkForecast";
            this.chkForecast.Size = new System.Drawing.Size(103, 17);
            this.chkForecast.TabIndex = 4;
            this.chkForecast.Text = "Forecast Enable";
            this.chkForecast.UseVisualStyleBackColor = true;
            this.chkForecast.CheckedChanged += new System.EventHandler(this.chkForecast_CheckedChanged);
            // 
            // financialChart1
            // 
            this.financialChart1.AxisX.Chart = this.financialChart1;
            this.financialChart1.AxisX.DataSource = null;
            this.financialChart1.AxisX.PlotAreaName = null;
            this.financialChart1.AxisX.Position = C1.Chart.Position.Bottom;
            this.financialChart1.AxisY.AxisLine = false;
            this.financialChart1.AxisY.Chart = this.financialChart1;
            this.financialChart1.AxisY.DataSource = null;
            this.financialChart1.AxisY.MajorGrid = true;
            this.financialChart1.AxisY.MajorTickMarks = C1.Chart.TickMark.None;
            this.financialChart1.AxisY.PlotAreaName = null;
            this.financialChart1.AxisY.Position = C1.Chart.Position.Left;
            this.financialChart1.ChartType = C1.Chart.Finance.FinancialChartType.Column;
            this.financialChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.financialChart1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financialChart1.Legend.ItemMaxWidth = 0;
            this.financialChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.financialChart1.Legend.Position = C1.Chart.Position.Right;
            this.financialChart1.Legend.Reversed = false;
            this.financialChart1.Legend.TextWrapping = C1.Chart.TextWrapping.None;
            this.financialChart1.Legend.Title = null;
            this.financialChart1.Location = new System.Drawing.Point(10, 10);
            this.financialChart1.Margin = new System.Windows.Forms.Padding(10);
            this.financialChart1.Name = "financialChart1";
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.financialChart1.Options.ClusterSize = elementSize1;
            this.financialChart1.Options.ReversalAmount = 1D;
            this.financialChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            this.financialChart1.SelectedSeries = null;
            this.financialChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.financialChart1.Size = new System.Drawing.Size(730, 161);
            this.financialChart1.TabIndex = 1;
            this.financialChart1.Text = "financialChart1";
            // 
            // 
            // 
            this.financialChart1.ToolTip.Content = "{value}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 3);
            this.label3.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Forward";
            // 
            // numForwardPeriods
            // 
            this.numForwardPeriods.Location = new System.Drawing.Point(489, 3);
            this.numForwardPeriods.Name = "numForwardPeriods";
            this.numForwardPeriods.Size = new System.Drawing.Size(56, 20);
            this.numForwardPeriods.TabIndex = 7;
            this.numForwardPeriods.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numForwardPeriods.ValueChanged += new System.EventHandler(this.numForwardPeriods_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(564, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Backward";
            // 
            // numBackwardPeriods
            // 
            this.numBackwardPeriods.Location = new System.Drawing.Point(625, 3);
            this.numBackwardPeriods.Name = "numBackwardPeriods";
            this.numBackwardPeriods.Size = new System.Drawing.Size(56, 20);
            this.numBackwardPeriods.TabIndex = 9;
            this.numBackwardPeriods.ValueChanged += new System.EventHandler(this.numBackwardPeriods_ValueChanged);
            // 
            // TrendLines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TrendLines";
            this.Size = new System.Drawing.Size(750, 214);
            this.Load += new System.EventHandler(this.OnLoad);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numForwardPeriods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBackwardPeriods)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private C1.Win.Chart.Finance.FinancialChart financialChart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox fitType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown order;
        private System.Windows.Forms.CheckBox chkForecast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numForwardPeriods;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numBackwardPeriods;
    }
}
