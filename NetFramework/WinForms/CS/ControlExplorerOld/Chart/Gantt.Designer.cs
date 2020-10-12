namespace ControlExplorer.Chart
{
    partial class Gantt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gantt));
            this.c1Chart1 = new C1.Win.C1Chart.C1Chart();
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Chart1
            // 
            this.c1Chart1.BackColor = System.Drawing.Color.FloralWhite;
            this.c1Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1Chart1.Location = new System.Drawing.Point(0, 0);
            this.c1Chart1.Name = "c1Chart1";
            this.c1Chart1.PropBag = resources.GetString("c1Chart1.PropBag");
            this.c1Chart1.Size = new System.Drawing.Size(592, 446);
            this.c1Chart1.TabIndex = 0;
            // 
            // Gantt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 446);
            this.Controls.Add(this.c1Chart1);
            this.Name = "Gantt";
            this.Text = "Gantt";
            this.Load += new System.EventHandler(this.Gantt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Chart.C1Chart c1Chart1;
    }
}