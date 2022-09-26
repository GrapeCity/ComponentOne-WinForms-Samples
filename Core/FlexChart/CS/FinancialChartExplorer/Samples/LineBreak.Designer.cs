namespace FinancialChartExplorer.Samples
{
    partial class LineBreak
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
            this.comboBoxSymbol = new System.Windows.Forms.ComboBox();
            this.financialChart1 = new C1.Win.Chart.Finance.FinancialChart();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.newLineBreaks = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newLineBreaks)).BeginInit();
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
            this.flowLayoutPanel1.Controls.Add(this.comboBoxSymbol);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(437, 27);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Symbol";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxSymbol
            // 
            this.comboBoxSymbol.DisplayMember = "Symbol";
            this.comboBoxSymbol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSymbol.FormattingEnabled = true;
            this.comboBoxSymbol.Location = new System.Drawing.Point(50, 3);
            this.comboBoxSymbol.Name = "comboBoxSymbol";
            this.comboBoxSymbol.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSymbol.TabIndex = 1;
            this.comboBoxSymbol.ValueMember = "Symbol";
            this.comboBoxSymbol.SelectedIndexChanged += new System.EventHandler(this.comboBoxSymbol_SelectedIndexChanged);
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
            this.financialChart1.Legend.Position = C1.Chart.Position.Right;
            this.financialChart1.Location = new System.Drawing.Point(3, 36);
            this.financialChart1.Name = "financialChart1";
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.financialChart1.Options.ClusterSize = elementSize1;
            this.financialChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            this.financialChart1.SelectedSeries = null;
            this.financialChart1.SelectionStyle.StrokeColor = System.Drawing.Color.Red;
            this.financialChart1.Size = new System.Drawing.Size(437, 143);
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
            this.flowLayoutPanel2.Controls.Add(this.newLineBreaks);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 185);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(437, 26);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number of Lines in Break";
            // 
            // newLineBreaks
            // 
            this.newLineBreaks.Location = new System.Drawing.Point(135, 3);
            this.newLineBreaks.Name = "newLineBreaks";
            this.newLineBreaks.Size = new System.Drawing.Size(52, 20);
            this.newLineBreaks.TabIndex = 1;
            this.newLineBreaks.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.newLineBreaks.ValueChanged += new System.EventHandler(this.newLineBreaks_ValueChanged);
            // 
            // LineBreak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "LineBreak";
            this.Size = new System.Drawing.Size(443, 214);
            this.Load += new System.EventHandler(this.HeikinAshi_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.financialChart1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newLineBreaks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSymbol;
        private C1.Win.Chart.Finance.FinancialChart financialChart1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown newLineBreaks;
    }
}
