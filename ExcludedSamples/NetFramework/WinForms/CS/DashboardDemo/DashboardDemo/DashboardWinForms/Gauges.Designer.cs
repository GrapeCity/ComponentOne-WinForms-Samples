namespace DashboardWinForms
{
    partial class Gauges
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
            this.c1Gauge1 = new C1.Win.C1Gauge.C1Gauge();
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Gauge1
            // 
            this.c1Gauge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Gauge1.Location = new System.Drawing.Point(0, 0);
            this.c1Gauge1.Name = "c1Gauge1";
            this.c1Gauge1.Size = new System.Drawing.Size(566, 404);
            this.c1Gauge1.TabIndex = 0;
            this.c1Gauge1.ViewTag = ((long)(638402544216566180));
            // 
            // Gauges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.c1Gauge1);
            this.Name = "Gauges";
            this.Size = new System.Drawing.Size(566, 404);
            ((System.ComponentModel.ISupportInitialize)(this.c1Gauge1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Gauge.C1Gauge c1Gauge1;
    }
}
