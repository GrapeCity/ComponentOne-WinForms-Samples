namespace C1ReportsScheduler
{
    partial class LogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            this.logControl1 = new C1ReportsScheduler.LogControl();
            this.SuspendLayout();
            // 
            // logControl1
            // 
            this.logControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logControl1.Location = new System.Drawing.Point(0, 0);
            this.logControl1.Name = "logControl1";
            this.logControl1.Size = new System.Drawing.Size(611, 270);
            this.logControl1.TabIndex = 0;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 270);
            this.Controls.Add(this.logControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Service Log";
            this.ResumeLayout(false);

        }

        #endregion

        private LogControl logControl1;
    }
}