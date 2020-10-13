namespace ControlExplorer.Chart
{
    partial class Financial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Financial));
            this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
            this.stockData1 = new ControlExplorer.Chart.StockData();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radChartGroups = new System.Windows.Forms.RadioButton();
            this.radCandle = new System.Windows.Forms.RadioButton();
            this.radHiLoOpenClose = new System.Windows.Forms.RadioButton();
            this.radHiLo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockData1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // c1Chart1
            // 
            this.c1Chart1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.c1Chart1.DataSource = this.stockData1;
            this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Chart1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.c1Chart1.ImageNames = new string[] {
        "Header"};
            this.c1Chart1.Images = new System.Drawing.Image[] {
        ((System.Drawing.Image)(((System.Drawing.Image)(resources.GetObject("c1Chart1.Images")))))};
            this.c1Chart1.Location = new System.Drawing.Point(0, 30);
            this.c1Chart1.Name = "c1Chart1";
            this.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag");
            this.c1Chart1.Size = new System.Drawing.Size(592, 416);
            this.c1Chart1.TabIndex = 1;
            // 
            // stockData1
            // 
            this.stockData1.Position = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(212)))), ((int)(((byte)(221)))));
            this.panel1.Controls.Add(this.radChartGroups);
            this.panel1.Controls.Add(this.radCandle);
            this.panel1.Controls.Add(this.radHiLoOpenClose);
            this.panel1.Controls.Add(this.radHiLo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 30);
            this.panel1.TabIndex = 2;
            // 
            // radChartGroups
            // 
            this.radChartGroups.AutoSize = true;
            this.radChartGroups.Location = new System.Drawing.Point(240, 7);
            this.radChartGroups.Name = "radChartGroups";
            this.radChartGroups.Size = new System.Drawing.Size(83, 17);
            this.radChartGroups.TabIndex = 3;
            this.radChartGroups.Text = "Combination";
            this.radChartGroups.UseVisualStyleBackColor = true;
            this.radChartGroups.CheckedChanged += new System.EventHandler(this.radHiLo_CheckedChanged);
            // 
            // radCandle
            // 
            this.radCandle.AutoSize = true;
            this.radCandle.Location = new System.Drawing.Point(176, 7);
            this.radCandle.Name = "radCandle";
            this.radCandle.Size = new System.Drawing.Size(58, 17);
            this.radCandle.TabIndex = 2;
            this.radCandle.Text = "Candle";
            this.radCandle.UseVisualStyleBackColor = true;
            this.radCandle.CheckedChanged += new System.EventHandler(this.radHiLo_CheckedChanged);
            // 
            // radHiLoOpenClose
            // 
            this.radHiLoOpenClose.AutoSize = true;
            this.radHiLoOpenClose.Location = new System.Drawing.Point(65, 7);
            this.radHiLoOpenClose.Name = "radHiLoOpenClose";
            this.radHiLoOpenClose.Size = new System.Drawing.Size(105, 17);
            this.radHiLoOpenClose.TabIndex = 1;
            this.radHiLoOpenClose.Text = "HiLo-Open-Close";
            this.radHiLoOpenClose.UseVisualStyleBackColor = true;
            this.radHiLoOpenClose.CheckedChanged += new System.EventHandler(this.radHiLo_CheckedChanged);
            // 
            // radHiLo
            // 
            this.radHiLo.AutoSize = true;
            this.radHiLo.Checked = true;
            this.radHiLo.Location = new System.Drawing.Point(12, 7);
            this.radHiLo.Name = "radHiLo";
            this.radHiLo.Size = new System.Drawing.Size(47, 17);
            this.radHiLo.TabIndex = 0;
            this.radHiLo.TabStop = true;
            this.radHiLo.Text = "HiLo";
            this.radHiLo.UseVisualStyleBackColor = true;
            this.radHiLo.CheckedChanged += new System.EventHandler(this.radHiLo_CheckedChanged);
            // 
            // Financial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.c1Chart1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Financial";
            this.Text = "Financial";
            this.Load += new System.EventHandler(this.Financial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockData1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Chart.C1Chart c1Chart1;
        private StockData stockData1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radChartGroups;
        private System.Windows.Forms.RadioButton radCandle;
        private System.Windows.Forms.RadioButton radHiLoOpenClose;
        private System.Windows.Forms.RadioButton radHiLo;

    }
}