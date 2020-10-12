namespace ControlExplorer.ExpressionEditor
{
    partial class ChartIntegration
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
                _dialog?.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartIntegration));
            this.productChart = new C1.Win.C1Chart.C1Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productChart)).BeginInit();
            this.SuspendLayout();
            // 
            // productChart
            // 
            this.productChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productChart.Location = new System.Drawing.Point(0, 0);
            this.productChart.Name = "productChart";
            this.productChart.PropBag = resources.GetString("productChart.PropBag");
            this.productChart.Size = new System.Drawing.Size(936, 484);
            this.productChart.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Image = global::ControlExplorer.Properties.Resources.icon_Filter;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 29);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChartIntegration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 484);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productChart);
            this.Name = "ChartIntegration";
            this.Text = "ChartIntegration";
            this.Load += new System.EventHandler(this.ChartIntegration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.C1Chart.C1Chart productChart;
        private System.Windows.Forms.Button button1;
    }
}