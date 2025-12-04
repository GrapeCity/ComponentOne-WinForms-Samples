namespace C1FlexGridPrinterTest
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

            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnShowSample = new System.Windows.Forms.Button();
            this.btnPreviewSample = new System.Windows.Forms.Button();
            this.pgPrintInfo = new System.Windows.Forms.PropertyGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.chkOverrideBorders = new System.Windows.Forms.CheckBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.chkLandscape = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnShowSample
            // 
            this.btnShowSample.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowSample.Location = new System.Drawing.Point(12, 39);
            this.btnShowSample.Name = "btnShowSample";
            this.btnShowSample.Size = new System.Drawing.Size(253, 23);
            this.btnShowSample.TabIndex = 1;
            this.btnShowSample.Text = "Show Selected Sample";
            this.btnShowSample.UseVisualStyleBackColor = true;
            this.btnShowSample.Click += new System.EventHandler(this.btnShowSample_Click);
            // 
            // btnPreviewSample
            // 
            this.btnPreviewSample.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreviewSample.Location = new System.Drawing.Point(12, 68);
            this.btnPreviewSample.Name = "btnPreviewSample";
            this.btnPreviewSample.Size = new System.Drawing.Size(253, 23);
            this.btnPreviewSample.TabIndex = 2;
            this.btnPreviewSample.Text = "PrintPreview Selected Sample";
            this.btnPreviewSample.UseVisualStyleBackColor = true;
            this.btnPreviewSample.Click += new System.EventHandler(this.btnPreviewSample_Click);
            // 
            // pgPrintInfo
            // 
            this.pgPrintInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pgPrintInfo.Location = new System.Drawing.Point(12, 133);
            this.pgPrintInfo.Name = "pgPrintInfo";
            this.pgPrintInfo.Size = new System.Drawing.Size(253, 325);
            this.pgPrintInfo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Grid PrintInfo Properties:";
            // 
            // chkOverrideBorders
            // 
            this.chkOverrideBorders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkOverrideBorders.AutoSize = true;
            this.chkOverrideBorders.Location = new System.Drawing.Point(12, 465);
            this.chkOverrideBorders.Name = "chkOverrideBorders";
            this.chkOverrideBorders.Size = new System.Drawing.Size(227, 17);
            this.chkOverrideBorders.TabIndex = 5;
            this.chkOverrideBorders.Text = "Override FlexGrid borders with 1pt gray line";
            this.chkOverrideBorders.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(12, 536);
            this.progressBar1.MarqueeAnimationSpeed = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(253, 24);
            this.progressBar1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 7;
            this.label2.Tag = "Preview rendering: {0:0%} complete";
            this.label2.Text = "Preview rendering progress:";
            // 
            // chkLandscape
            // 
            this.chkLandscape.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkLandscape.AutoSize = true;
            this.chkLandscape.Checked = true;
            this.chkLandscape.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLandscape.Location = new System.Drawing.Point(12, 488);
            this.chkLandscape.Name = "chkLandscape";
            this.chkLandscape.Size = new System.Drawing.Size(176, 17);
            this.chkLandscape.TabIndex = 6;
            this.chkLandscape.Text = "Use landscape page orientation";
            this.chkLandscape.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 572);
            this.Controls.Add(this.chkLandscape);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chkOverrideBorders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pgPrintInfo);
            this.Controls.Add(this.btnPreviewSample);
            this.Controls.Add(this.btnShowSample);
            this.Controls.Add(this.comboBox1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnShowSample;
        private System.Windows.Forms.Button btnPreviewSample;
        private System.Windows.Forms.PropertyGrid pgPrintInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkOverrideBorders;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkLandscape;
    }
}

