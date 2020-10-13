namespace ControlExplorer.FlexChart
{
    partial class FinancialChartIntro
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            C1.Chart.ElementSize elementSize1 = new C1.Chart.ElementSize();
            this.flexChart1 = new C1.Win.Chart.Finance.FinancialChart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.chartType = new System.Windows.Forms.ComboBox();
            this.movAvg = new System.Windows.Forms.CheckBox();
            this.movAvg2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flexChart1
            // 
            this.flexChart1.AxisX.Chart = this.flexChart1;
            this.flexChart1.AxisX.Position = C1.Chart.Position.Bottom;
            this.flexChart1.AxisY.AxisLine = false;
            this.flexChart1.AxisY.Chart = this.flexChart1;
            this.flexChart1.AxisY.MajorGrid = true;
            this.flexChart1.AxisY.Position = C1.Chart.Position.Left;
            this.flexChart1.ChartType = C1.Chart.Finance.FinancialChartType.Column;
            this.flexChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flexChart1.Legend.Orientation = C1.Chart.Orientation.Auto;
            this.flexChart1.Legend.Position = C1.Chart.Position.Right;
            this.flexChart1.Legend.Title = null;
            this.flexChart1.Location = new System.Drawing.Point(3, 54);
            this.flexChart1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flexChart1.Name = "flexChart1";
            elementSize1.SizeType = C1.Chart.ElementSizeType.Percentage;
            elementSize1.Value = 70D;
            this.flexChart1.Options.ClusterSize = elementSize1;
            this.flexChart1.PlotMargin = new System.Windows.Forms.Padding(0);
            this.flexChart1.SelectedSeries = null;
            this.flexChart1.SelectionMode = C1.Chart.ChartSelectionMode.Series;
            this.flexChart1.SelectionStyle.StrokeColor = System.Drawing.Color.DodgerBlue;
            this.flexChart1.Size = new System.Drawing.Size(748, 390);
            this.flexChart1.TabIndex = 2;
            this.flexChart1.Text = "flexChart1";
            // 
            // 
            // 
            this.flexChart1.ToolTip.Content = "{value}";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flexChart1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(754, 448);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.chartType);
            this.flowLayoutPanel1.Controls.Add(this.movAvg);
            this.flowLayoutPanel1.Controls.Add(this.movAvg2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(748, 44);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chart type";
            // 
            // chartType
            // 
            this.chartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chartType.FormattingEnabled = true;
            this.chartType.Location = new System.Drawing.Point(77, 3);
            this.chartType.Name = "chartType";
            this.chartType.Size = new System.Drawing.Size(161, 25);
            this.chartType.TabIndex = 0;
            // 
            // movAvg
            // 
            this.movAvg.AutoSize = true;
            this.movAvg.Location = new System.Drawing.Point(244, 3);
            this.movAvg.Name = "movAvg";
            this.movAvg.Size = new System.Drawing.Size(98, 21);
            this.movAvg.TabIndex = 1;
            this.movAvg.Text = "Mov Avg 7d";
            this.movAvg.UseVisualStyleBackColor = true;
            // 
            // movAvg2
            // 
            this.movAvg2.AutoSize = true;
            this.movAvg2.Location = new System.Drawing.Point(348, 3);
            this.movAvg2.Name = "movAvg2";
            this.movAvg2.Size = new System.Drawing.Size(105, 21);
            this.movAvg2.TabIndex = 3;
            this.movAvg2.Text = "Mov Avg 14d";
            this.movAvg2.UseVisualStyleBackColor = true;
            // 
            // FinancialChartIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 448);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FinancialChartIntro";
            this.Text = "Intro";
            this.Load += new System.EventHandler(this.FinancialChartIntro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flexChart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.Chart.Finance.FinancialChart flexChart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox chartType;
        private System.Windows.Forms.CheckBox movAvg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox movAvg2;
    }
}