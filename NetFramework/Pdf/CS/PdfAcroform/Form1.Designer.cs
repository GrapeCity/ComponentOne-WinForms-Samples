namespace PdfAcroforms
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
            this._btCreate.Location = new System.Drawing.Point(347, 55);
            this._btCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this._btCreate.Name = "_btCreate";
            this._btCreate.Size = new System.Drawing.Size(100, 28);
            this._btCreate.TabIndex = 0;
            this._btCreate.Text = "&Create";
            this._btCreate.UseVisualStyleBackColor = true;
            this._btCreate.Click += new System.EventHandler(this._btCreate_Click);
            // 
            // _status
            // 
            this._status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._statusBar});
            this._status.Location = new System.Drawing.Point(0, 91);
            this._status.Name = "_status";
            this._status.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this._status.Size = new System.Drawing.Size(463, 23);
            this._status.TabIndex = 1;
            // 
            // _statusBar
            // 
            this._statusBar.Name = "_statusBar";
            this._statusBar.Size = new System.Drawing.Size(49, 18);
            this._statusBar.Text = "Ready";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Press the button to crate a Pdf document with an AcroForm.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 114);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._status);
            this.Controls.Add(this._btCreate);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF Acroform sample";
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

