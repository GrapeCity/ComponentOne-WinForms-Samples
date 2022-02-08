namespace GaugeDemo
{
    partial class PageLituus
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
            C1.Win.Gauge.C1GaugeSingleLabel c1GaugeSingleLabel1 = new C1.Win.Gauge.C1GaugeSingleLabel();
            C1.Win.Gauge.C1GaugeRectangle c1GaugeRectangle1 = new C1.Win.Gauge.C1GaugeRectangle();
            this.c1Gauge1 = new C1.Win.Gauge.C1Gauge();
            this.c1LinearGauge1 = new C1.Win.Gauge.C1LinearGauge();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.gaugePanel.SuspendLayout();
            this.gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugePanel
            // 
            this.gaugePanel.Controls.Add(this.trackBar1);
            this.gaugePanel.Controls.Add(this.c1Gauge1);
            // 
            // gaugeGrid
            // 
            this.gaugeGrid.SelectedObject = this.c1LinearGauge1;
            // 
            // c1Gauge1
            // 
            this.c1Gauge1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1Gauge1.Gauges.AddRange(new C1.Win.Gauge.C1GaugeBase[] {
            this.c1LinearGauge1});
            this.c1Gauge1.Location = new System.Drawing.Point(3, 3);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(387, 385);
            this.c1Gauge1.TabIndex = 0;
            this.c1Gauge1.ViewTag = ((long)(639096176253039103));
            // 
            // c1LinearGauge1
            // 
            this.c1LinearGauge1.BaseFactor = 0.9;
            this.c1LinearGauge1.BaseOrigin = 0.05;
            c1GaugeSingleLabel1.Color = System.Drawing.Color.Silver;
            c1GaugeSingleLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            c1GaugeSingleLabel1.FontSize = 8;
            c1GaugeSingleLabel1.Format = "p1";
            c1GaugeSingleLabel1.Location = 17;
            c1GaugeSingleLabel1.PointerIndex = 100;
            c1GaugeSingleLabel1.Position = 0.8;
            c1GaugeSingleLabel1.ViewTag = ((long)(646977542129652696));
            this.c1LinearGauge1.Decorators.AddRange(new C1.Win.Gauge.C1GaugeDecorator[] {
            c1GaugeSingleLabel1});
            c1GaugeRectangle1.Border.LineStyle = C1.Win.Gauge.C1GaugeBorderStyle.None;
            c1GaugeRectangle1.Filling.Color = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.c1LinearGauge1.FaceShapes.AddRange(new C1.Win.Gauge.C1GaugeBaseShape[] {
            c1GaugeRectangle1});
            this.c1LinearGauge1.Maximum = 1;
            this.c1LinearGauge1.Name = "c1LinearGauge1";
            this.c1LinearGauge1.Pointer.Value = 0.67;
            this.c1LinearGauge1.Pointer.Visible = false;
            this.c1LinearGauge1.Viewport.AspectRatio = 1.5;
            this.c1LinearGauge1.ViewTag = ((long)(639377651282252762));
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(15, 384);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(360, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 67;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // PageLituus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Name = "PageLituus";
            this.gaugePanel.ResumeLayout(false);
            this.gaugePanel.PerformLayout();
            this.gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Gauge.C1Gauge c1Gauge1;
        private C1.Win.Gauge.C1LinearGauge c1LinearGauge1;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}
