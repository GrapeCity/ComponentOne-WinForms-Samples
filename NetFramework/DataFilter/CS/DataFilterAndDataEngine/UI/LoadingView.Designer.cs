
namespace DataFilterAndDataEngine.UI
{
    partial class LoadingView
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
            this.components = new System.ComponentModel.Container();
            C1.Win.Gauge.C1GaugeRange c1GaugeRange1 = new C1.Win.Gauge.C1GaugeRange();
            C1.Win.Gauge.C1GaugeRange c1GaugeRange2 = new C1.Win.Gauge.C1GaugeRange();
            C1.Win.Gauge.C1GaugeSingleLabel c1GaugeSingleLabel1 = new C1.Win.Gauge.C1GaugeSingleLabel();
            this.c1Gauge1 = new C1.Win.Gauge.C1Gauge();
            this.c1RadialGauge1 = new C1.Win.Gauge.C1RadialGauge();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Gauge1
            // 
            this.c1Gauge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Gauge1.Gauges.AddRange(new C1.Win.Gauge.C1GaugeBase[] {
            this.c1RadialGauge1});
            this.c1Gauge1.Location = new System.Drawing.Point(0, 0);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(832, 661);
            this.c1Gauge1.TabIndex = 0;
            this.c1Gauge1.ViewTag = ((long)(637017851395108607));
            // 
            // c1RadialGauge1
            // 
            this.c1RadialGauge1.Cap.Border.Color = System.Drawing.Color.Black;
            this.c1RadialGauge1.Cap.Filling.Color = System.Drawing.Color.Black;
            this.c1RadialGauge1.Cap.Radius = 2.5D;
            this.c1RadialGauge1.Cap.Visible = false;
            c1GaugeRange1.Border.Color = System.Drawing.Color.Transparent;
            c1GaugeRange1.Filling.Color = System.Drawing.Color.Silver;
            c1GaugeRange1.FromPointerIndex = 100;
            c1GaugeRange1.Location = 60D;
            c1GaugeRange1.ViewTag = ((long)(640162063073460990));
            c1GaugeRange1.Width = 22D;
            c1GaugeRange2.Border.Color = System.Drawing.Color.Transparent;
            c1GaugeRange2.Filling.Color = System.Drawing.Color.SteelBlue;
            c1GaugeRange2.Location = 60D;
            c1GaugeRange2.Name = "Before";
            c1GaugeRange2.ToPointerIndex = 100;
            c1GaugeRange2.ViewTag = ((long)(640443538688254004));
            c1GaugeRange2.Width = 22D;
            c1GaugeSingleLabel1.Angle = 0D;
            c1GaugeSingleLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            c1GaugeSingleLabel1.Location = 0D;
            c1GaugeSingleLabel1.PointerIndex = 100;
            c1GaugeSingleLabel1.Text = "Loading..";
            c1GaugeSingleLabel1.ViewTag = ((long)(642976825261498990));
            this.c1RadialGauge1.Decorators.AddRange(new C1.Win.Gauge.C1GaugeDecorator[] {
            c1GaugeRange1,
            c1GaugeRange2,
            c1GaugeSingleLabel1});
            this.c1RadialGauge1.Name = "c1RadialGauge1";
            this.c1RadialGauge1.Pointer.Border.Color = System.Drawing.Color.Black;
            this.c1RadialGauge1.Pointer.CustomShape.EndAngle = 60D;
            this.c1RadialGauge1.Pointer.CustomShape.EndWidth = 0.15D;
            this.c1RadialGauge1.Pointer.CustomShape.StartRadius = 1.999999999998D;
            this.c1RadialGauge1.Pointer.CustomShape.StartWidth = 1D;
            this.c1RadialGauge1.Pointer.Filling.Color = System.Drawing.Color.Black;
            this.c1RadialGauge1.Pointer.Length = 64D;
            this.c1RadialGauge1.Pointer.Offset = 0D;
            this.c1RadialGauge1.Pointer.Shape = C1.Win.Gauge.C1GaugePointerShape.Custom;
            this.c1RadialGauge1.Pointer.Visible = false;
            this.c1RadialGauge1.Radius = 0.6D;
            this.c1RadialGauge1.StartAngle = -90D;
            this.c1RadialGauge1.SweepAngle = 360D;
            this.c1RadialGauge1.Viewport.AspectRatio = 0.5D;
            this.c1RadialGauge1.ViewTag = ((long)(639317637171740509));
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LoadingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1Gauge1);
            this.Name = "LoadingView";
            this.Size = new System.Drawing.Size(832, 661);
            this.Load += new System.EventHandler(this.LoadingView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.Gauge.C1Gauge c1Gauge1;
        private C1.Win.Gauge.C1RadialGauge c1RadialGauge1;
        private System.Windows.Forms.Timer timer1;
    }
}
