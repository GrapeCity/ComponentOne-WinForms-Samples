namespace MapReports
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
            this.c1FlexViewer1 = new C1.Win.FlexViewer.C1FlexViewer();
            this._btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this._reportList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexViewer1)).BeginInit();
            this.SuspendLayout();
            // 
            // c1FlexViewer1
            // 
            this.c1FlexViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.c1FlexViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.c1FlexViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.c1FlexViewer1.Location = new System.Drawing.Point(227, 9);
            this.c1FlexViewer1.Name = "c1FlexViewer1";
            this.c1FlexViewer1.Size = new System.Drawing.Size(493, 530);
            this.c1FlexViewer1.TabIndex = 3;
            this.c1FlexViewer1.UseAsyncRendering = false;
            // 
            // _btnGo
            // 
            this._btnGo.Location = new System.Drawing.Point(146, 168);
            this._btnGo.Name = "_btnGo";
            this._btnGo.Size = new System.Drawing.Size(75, 21);
            this._btnGo.TabIndex = 2;
            this._btnGo.Text = "Go";
            this._btnGo.UseVisualStyleBackColor = true;
            this._btnGo.Click += new System.EventHandler(this._btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a report in the list below,\r\nclick \"Go\" to render:";
            // 
            // _reportList
            // 
            this._reportList.FormattingEnabled = true;
            this._reportList.ItemHeight = 12;
            this._reportList.Location = new System.Drawing.Point(14, 38);
            this._reportList.Name = "_reportList";
            this._reportList.Size = new System.Drawing.Size(207, 124);
            this._reportList.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 551);
            this.Controls.Add(this._btnGo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._reportList);
            this.Controls.Add(this.c1FlexViewer1);
            this.Name = "Form1";
            this.Text = "Map Reports";
            ((System.ComponentModel.ISupportInitialize)(this.c1FlexViewer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.FlexViewer.C1FlexViewer c1FlexViewer1;
        private System.Windows.Forms.Button _btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox _reportList;
    }
}

