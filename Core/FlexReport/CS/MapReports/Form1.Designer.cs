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
            c1FlexViewer1 = new C1.Win.FlexViewer.C1FlexViewer();
            _btnGo = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            _reportList = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)c1FlexViewer1).BeginInit();
            SuspendLayout();
            // 
            // c1FlexViewer1
            // 
            c1FlexViewer1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            c1FlexViewer1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            c1FlexViewer1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            c1FlexViewer1.Location = new System.Drawing.Point(265, 11);
            c1FlexViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            c1FlexViewer1.Name = "c1FlexViewer1";
            c1FlexViewer1.Size = new System.Drawing.Size(575, 662);
            c1FlexViewer1.TabIndex = 3;
            c1FlexViewer1.UseAsyncRendering = false;
            // 
            // _btnGo
            // 
            _btnGo.Location = new System.Drawing.Point(170, 210);
            _btnGo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            _btnGo.Name = "_btnGo";
            _btnGo.Size = new System.Drawing.Size(88, 26);
            _btnGo.TabIndex = 2;
            _btnGo.Text = "Go";
            _btnGo.UseVisualStyleBackColor = true;
            _btnGo.Click += _btnGo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 11);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(171, 30);
            label1.TabIndex = 0;
            label1.Text = "Select a report in the list below,\r\nclick \"Go\" to render:";
            // 
            // _reportList
            // 
            _reportList.FormattingEnabled = true;
            _reportList.Location = new System.Drawing.Point(16, 48);
            _reportList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            _reportList.Name = "_reportList";
            _reportList.Size = new System.Drawing.Size(241, 154);
            _reportList.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(854, 689);
            Controls.Add(_btnGo);
            Controls.Add(label1);
            Controls.Add(_reportList);
            Controls.Add(c1FlexViewer1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Map Reports";
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)c1FlexViewer1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private C1.Win.FlexViewer.C1FlexViewer c1FlexViewer1;
        private System.Windows.Forms.Button _btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox _reportList;
    }
}

