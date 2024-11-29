namespace PdfAnnotations
{
    partial class Form1
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
            this._btCreate = new System.Windows.Forms.Button();
            this._status = new System.Windows.Forms.StatusStrip();
            this._statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this._c1pdf = new C1.Win.Pdf.C1PdfDocument();
            this.label1 = new System.Windows.Forms.Label();
            this._status.SuspendLayout();
            this.SuspendLayout();
            // 
            // _btCreate
            // 
            this._btCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btCreate.Location = new System.Drawing.Point(277, 43);
            this._btCreate.Name = "_btCreate";
            this._btCreate.Size = new System.Drawing.Size(75, 23);
            this._btCreate.TabIndex = 0;
            this._btCreate.Text = "&Create";
            this._btCreate.UseVisualStyleBackColor = true;
            this._btCreate.Click += new System.EventHandler(this._btCreate_Click);
            // 
            // _status
            // 
            this._status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._statusBar});
            this._status.Location = new System.Drawing.Point(0, 69);
            this._status.Name = "_status";
            this._status.Size = new System.Drawing.Size(364, 22);
            this._status.TabIndex = 1;
            // 
            // _statusBar
            // 
            this._statusBar.Name = "_statusBar";
            this._statusBar.Size = new System.Drawing.Size(39, 17);
            this._statusBar.Text = "Ready";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please press <Create> button for preview PDF result with annotations.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 91);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._status);
            this.Controls.Add(this._btCreate);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "PDF Annotations sample";
            this._status.ResumeLayout(false);
            this._status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.Pdf.C1PdfDocument _c1pdf;
        private System.Windows.Forms.Button _btCreate;
        private System.Windows.Forms.StatusStrip _status;
        private System.Windows.Forms.ToolStripStatusLabel _statusBar;
        private System.Windows.Forms.Label label1;
    }
}

