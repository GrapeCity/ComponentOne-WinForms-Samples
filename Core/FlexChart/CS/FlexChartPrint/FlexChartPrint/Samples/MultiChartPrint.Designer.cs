namespace FlexChartPrint.Samples
{
    partial class MultiChartPrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultiChartPrint));
            this.btnMultiChart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMultiPage = new System.Windows.Forms.Button();
            this.btnSubCharts = new System.Windows.Forms.Button();
            this.btnStripChart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMultiChart
            // 
            this.btnMultiChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(152)))), ((int)(((byte)(232)))));
            this.btnMultiChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiChart.Location = new System.Drawing.Point(15, 102);
            this.btnMultiChart.Name = "btnMultiChart";
            this.btnMultiChart.Size = new System.Drawing.Size(236, 28);
            this.btnMultiChart.TabIndex = 0;
            this.btnMultiChart.Text = "Print Multiple Charts Per Page";
            this.btnMultiChart.UseVisualStyleBackColor = true;
            this.btnMultiChart.Click += new System.EventHandler(this.btnMultiChart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.label1.Location = new System.Drawing.Point(15, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnMultiPage
            // 
            this.btnMultiPage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(152)))), ((int)(((byte)(232)))));
            this.btnMultiPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMultiPage.Location = new System.Drawing.Point(275, 102);
            this.btnMultiPage.Name = "btnMultiPage";
            this.btnMultiPage.Size = new System.Drawing.Size(236, 28);
            this.btnMultiPage.TabIndex = 1;
            this.btnMultiPage.Text = "Print Multiple Charts on Multiple Pages";
            this.btnMultiPage.UseVisualStyleBackColor = true;
            this.btnMultiPage.Click += new System.EventHandler(this.btnMultiPage_Click);
            // 
            // btnSubCharts
            // 
            this.btnSubCharts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(152)))), ((int)(((byte)(232)))));
            this.btnSubCharts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubCharts.Location = new System.Drawing.Point(15, 136);
            this.btnSubCharts.Name = "btnSubCharts";
            this.btnSubCharts.Size = new System.Drawing.Size(236, 28);
            this.btnSubCharts.TabIndex = 2;
            this.btnSubCharts.Text = "Print Sub Charts With Axis";
            this.btnSubCharts.UseVisualStyleBackColor = true;
            this.btnSubCharts.Click += new System.EventHandler(this.btnSubCharts_Click);
            // 
            // btnStripChart
            // 
            this.btnStripChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(152)))), ((int)(((byte)(232)))));
            this.btnStripChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStripChart.Location = new System.Drawing.Point(275, 136);
            this.btnStripChart.Name = "btnStripChart";
            this.btnStripChart.Size = new System.Drawing.Size(236, 28);
            this.btnStripChart.TabIndex = 3;
            this.btnStripChart.Text = "Print as Stripchart";
            this.btnStripChart.UseVisualStyleBackColor = true;
            this.btnStripChart.Click += new System.EventHandler(this.btnStripChart_Click);
            // 
            // MultiChartPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStripChart);
            this.Controls.Add(this.btnSubCharts);
            this.Controls.Add(this.btnMultiPage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMultiChart);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MultiChartPrint";
            this.Size = new System.Drawing.Size(536, 184);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMultiChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMultiPage;
        private System.Windows.Forms.Button btnSubCharts;
        private System.Windows.Forms.Button btnStripChart;
    }
}
