namespace AddScriptObject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._btnRunReport = new System.Windows.Forms.Button();
            this.c1FlexReport1 = new C1.Win.FlexReport.C1FlexReport();
            this.c1FlexViewerDialog1 = new C1.Win.FlexViewer.C1FlexViewerDialog();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexViewerDialog1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(497, 223);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // _btnRunReport
            // 
            this._btnRunReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnRunReport.Location = new System.Drawing.Point(240, 241);
            this._btnRunReport.Name = "_btnRunReport";
            this._btnRunReport.Size = new System.Drawing.Size(269, 39);
            this._btnRunReport.TabIndex = 1;
            this._btnRunReport.Text = "Generate and Preview FlexReport";
            this._btnRunReport.UseVisualStyleBackColor = true;
            this._btnRunReport.Click += new System.EventHandler(this.button1_Click);
            // 
            // c1FlexReport1
            // 
            this.c1FlexReport1.ReportDefinition = resources.GetString("c1FlexReport1.ReportDefinition");
            this.c1FlexReport1.ReportName = "AddScriptObject";
            // 
            // c1FlexViewerDialog1
            // 
            this.c1FlexViewerDialog1.ClientSize = new System.Drawing.Size(919, 589);
            this.c1FlexViewerDialog1.Name = "C1FlexViewerDialog";
            this.c1FlexViewerDialog1.Text = "c1FlexViewerDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 292);
            this.Controls.Add(this._btnRunReport);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "AddScriptObject";
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexViewerDialog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button _btnRunReport;
        private C1.Win.FlexReport.C1FlexReport c1FlexReport1;
        private C1.Win.FlexViewer.C1FlexViewerDialog c1FlexViewerDialog1;
    }
}

