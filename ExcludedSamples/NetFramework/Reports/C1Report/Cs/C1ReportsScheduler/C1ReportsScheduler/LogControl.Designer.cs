using System.Diagnostics;

namespace C1ReportsScheduler
{
    partial class LogControl
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
            if (_eventLog != null)
            {
                _eventLog.EntryWritten -= new EntryWrittenEventHandler(_eventLog_EntryWritten);
                _eventLog = null;
            }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogControl));
            this._textBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbClear = new System.Windows.Forms.ToolStripButton();
            this.tsbStop = new System.Windows.Forms.ToolStripButton();
            this.tsbResume = new System.Windows.Forms.ToolStripButton();
            this.tsbEventViewer = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _textBox
            // 
            this._textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._textBox.Location = new System.Drawing.Point(0, 25);
            this._textBox.Multiline = true;
            this._textBox.Name = "_textBox";
            this._textBox.ReadOnly = true;
            this._textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this._textBox.Size = new System.Drawing.Size(486, 288);
            this._textBox.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClear,
            this.tsbStop,
            this.tsbResume,
            this.tsbEventViewer});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(486, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbClear
            // 
            this.tsbClear.Image = global::C1ReportsScheduler.Properties.Resources.Delete;
            this.tsbClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClear.Name = "tsbClear";
            this.tsbClear.Size = new System.Drawing.Size(54, 22);
            this.tsbClear.Text = "&Clear";
            this.tsbClear.Click += new System.EventHandler(this.tsbClear_Click);
            // 
            // tsbStop
            // 
            this.tsbStop.Image = global::C1ReportsScheduler.Properties.Resources.Pause;
            this.tsbStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbStop.Name = "tsbStop";
            this.tsbStop.Size = new System.Drawing.Size(114, 22);
            this.tsbStop.Text = "&Stop Monitoring";
            this.tsbStop.Click += new System.EventHandler(this.tsbStop_Click);
            // 
            // tsbResume
            // 
            this.tsbResume.Image = global::C1ReportsScheduler.Properties.Resources.Resume;
            this.tsbResume.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbResume.Name = "tsbResume";
            this.tsbResume.Size = new System.Drawing.Size(132, 22);
            this.tsbResume.Text = "&Resume Monitoring";
            this.tsbResume.Click += new System.EventHandler(this.tsbResume_Click);
            // 
            // tsbEventViewer
            // 
            this.tsbEventViewer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbEventViewer.Image = ((System.Drawing.Image)(resources.GetObject("tsbEventViewer.Image")));
            this.tsbEventViewer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEventViewer.Name = "tsbEventViewer";
            this.tsbEventViewer.Size = new System.Drawing.Size(120, 22);
            this.tsbEventViewer.Text = "&Launch Event Viewer";
            this.tsbEventViewer.Click += new System.EventHandler(this.tsbEventViewer_Click);
            // 
            // LogControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._textBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "LogControl";
            this.Size = new System.Drawing.Size(486, 313);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbClear;
        private System.Windows.Forms.ToolStripButton tsbStop;
        private System.Windows.Forms.ToolStripButton tsbResume;
        private System.Windows.Forms.ToolStripButton tsbEventViewer;
    }
}
