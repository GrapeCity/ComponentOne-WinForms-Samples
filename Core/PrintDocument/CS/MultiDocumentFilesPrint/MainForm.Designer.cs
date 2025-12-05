namespace MultiDocumentFilesPrint
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            _pview = new C1.Win.C1Preview.C1PrintPreviewControl();
            btnMultiDoc = new System.Windows.Forms.Button();
            btnSingleDoc = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            tbDir = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            tbMask = new System.Windows.Forms.TextBox();
            btnChooseDir = new System.Windows.Forms.Button();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)_pview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_pview.PreviewPane).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // _pview
            // 
            _pview.Dock = System.Windows.Forms.DockStyle.Fill;
            _pview.Location = new System.Drawing.Point(0, 35);
            _pview.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _pview.Name = "_pview";
            // 
            // 
            // 
            _pview.PreviewPane.IntegrateExternalTools = true;
            _pview.PreviewPane.Location = new System.Drawing.Point(0, 0);
            _pview.PreviewPane.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            _pview.PreviewPane.Name = "previewPane";
            _pview.PreviewPane.Size = new System.Drawing.Size(233, 300);
            _pview.PreviewPane.TabIndex = 0;
            _pview.Size = new System.Drawing.Size(1133, 716);
            _pview.TabIndex = 1;
            _pview.Text = "c1PrintPreviewControl1";
            // 
            // btnMultiDoc
            // 
            btnMultiDoc.AutoSize = true;
            btnMultiDoc.Location = new System.Drawing.Point(706, 3);
            btnMultiDoc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnMultiDoc.Name = "btnMultiDoc";
            btnMultiDoc.Size = new System.Drawing.Size(134, 29);
            btnMultiDoc.TabIndex = 5;
            btnMultiDoc.Text = "C1MultiDocument";
            btnMultiDoc.UseVisualStyleBackColor = true;
            btnMultiDoc.Click += MultiDocument_Click;
            // 
            // btnSingleDoc
            // 
            btnSingleDoc.AutoSize = true;
            btnSingleDoc.Location = new System.Drawing.Point(848, 3);
            btnSingleDoc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSingleDoc.Name = "btnSingleDoc";
            btnSingleDoc.Size = new System.Drawing.Size(131, 29);
            btnSingleDoc.TabIndex = 6;
            btnSingleDoc.Text = "C1PrintDocument";
            btnSingleDoc.UseVisualStyleBackColor = true;
            btnSingleDoc.Click += SingleDocument_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(4, 0);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 3);
            label1.Size = new System.Drawing.Size(58, 24);
            label1.TabIndex = 0;
            label1.Text = "Directory:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbDir
            // 
            tbDir.Location = new System.Drawing.Point(70, 3);
            tbDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbDir.Name = "tbDir";
            tbDir.Size = new System.Drawing.Size(417, 23);
            tbDir.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(529, 0);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 3);
            label2.Size = new System.Drawing.Size(100, 24);
            label2.TabIndex = 3;
            label2.Text = "Mask (e.g. \"*.cs\"):";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbMask
            // 
            tbMask.Location = new System.Drawing.Point(637, 3);
            tbMask.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tbMask.Name = "tbMask";
            tbMask.Size = new System.Drawing.Size(61, 23);
            tbMask.TabIndex = 4;
            tbMask.Text = "*.cs";
            // 
            // btnChooseDir
            // 
            btnChooseDir.AutoSize = true;
            btnChooseDir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnChooseDir.Location = new System.Drawing.Point(495, 3);
            btnChooseDir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnChooseDir.Name = "btnChooseDir";
            btnChooseDir.Size = new System.Drawing.Size(26, 25);
            btnChooseDir.TabIndex = 2;
            btnChooseDir.Text = "...";
            btnChooseDir.UseVisualStyleBackColor = true;
            btnChooseDir.Click += btnChooseDir_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(label1);
            flowLayoutPanel1.Controls.Add(tbDir);
            flowLayoutPanel1.Controls.Add(btnChooseDir);
            flowLayoutPanel1.Controls.Add(label2);
            flowLayoutPanel1.Controls.Add(tbMask);
            flowLayoutPanel1.Controls.Add(btnMultiDoc);
            flowLayoutPanel1.Controls.Add(btnSingleDoc);
            flowLayoutPanel1.Controls.Add(btnHelp);
            flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(1133, 35);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnHelp
            // 
            btnHelp.AutoSize = true;
            btnHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            btnHelp.Location = new System.Drawing.Point(987, 3);
            btnHelp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnHelp.Name = "btnHelp";
            btnHelp.Size = new System.Drawing.Size(42, 25);
            btnHelp.TabIndex = 7;
            btnHelp.Text = "Help";
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1133, 751);
            Controls.Add(_pview);
            Controls.Add(flowLayoutPanel1);
            HelpButton = true;
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "MultiDocumentFilesPrint";
            ((System.ComponentModel.ISupportInitialize)_pview.PreviewPane).EndInit();
            ((System.ComponentModel.ISupportInitialize)_pview).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private C1.Win.C1Preview.C1PrintPreviewControl _pview;
        private System.Windows.Forms.Button btnMultiDoc;
        private System.Windows.Forms.Button btnSingleDoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMask;
        private System.Windows.Forms.Button btnChooseDir;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnHelp;
    }
}

