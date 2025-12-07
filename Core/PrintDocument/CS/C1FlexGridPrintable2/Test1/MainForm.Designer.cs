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
            comboBox1 = new System.Windows.Forms.ComboBox();
            btnShowSample = new System.Windows.Forms.Button();
            btnPreviewSample = new System.Windows.Forms.Button();
            pgPrintInfo = new System.Windows.Forms.PropertyGrid();
            label1 = new System.Windows.Forms.Label();
            chkOverrideBorders = new System.Windows.Forms.CheckBox();
            progressBar1 = new System.Windows.Forms.ProgressBar();
            label2 = new System.Windows.Forms.Label();
            chkLandscape = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(14, 14);
            comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(294, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnShowSample
            // 
            btnShowSample.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnShowSample.Location = new System.Drawing.Point(14, 45);
            btnShowSample.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnShowSample.Name = "btnShowSample";
            btnShowSample.Size = new System.Drawing.Size(295, 27);
            btnShowSample.TabIndex = 1;
            btnShowSample.Text = "Show Selected Sample";
            btnShowSample.UseVisualStyleBackColor = true;
            btnShowSample.Click += btnShowSample_Click;
            // 
            // btnPreviewSample
            // 
            btnPreviewSample.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnPreviewSample.Location = new System.Drawing.Point(14, 78);
            btnPreviewSample.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnPreviewSample.Name = "btnPreviewSample";
            btnPreviewSample.Size = new System.Drawing.Size(295, 27);
            btnPreviewSample.TabIndex = 2;
            btnPreviewSample.Text = "PrintPreview Selected Sample";
            btnPreviewSample.UseVisualStyleBackColor = true;
            btnPreviewSample.Click += btnPreviewSample_Click;
            // 
            // pgPrintInfo
            // 
            pgPrintInfo.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pgPrintInfo.BackColor = System.Drawing.SystemColors.Control;
            pgPrintInfo.Location = new System.Drawing.Point(14, 153);
            pgPrintInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            pgPrintInfo.Name = "pgPrintInfo";
            pgPrintInfo.Size = new System.Drawing.Size(295, 375);
            pgPrintInfo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 204);
            label1.Location = new System.Drawing.Point(14, 130);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(164, 17);
            label1.TabIndex = 3;
            label1.Text = "Grid PrintInfo Properties:";
            // 
            // chkOverrideBorders
            // 
            chkOverrideBorders.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkOverrideBorders.AutoSize = true;
            chkOverrideBorders.Location = new System.Drawing.Point(14, 538);
            chkOverrideBorders.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkOverrideBorders.Name = "chkOverrideBorders";
            chkOverrideBorders.Size = new System.Drawing.Size(253, 19);
            chkOverrideBorders.TabIndex = 5;
            chkOverrideBorders.Text = "Override FlexGrid borders with 1pt gray line";
            chkOverrideBorders.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            progressBar1.Location = new System.Drawing.Point(14, 618);
            progressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            progressBar1.MarqueeAnimationSpeed = 0;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(295, 28);
            progressBar1.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 600);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(153, 15);
            label2.TabIndex = 7;
            label2.Tag = "Preview rendering: {0:0%} complete";
            label2.Text = "Preview rendering progress:";
            // 
            // chkLandscape
            // 
            chkLandscape.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chkLandscape.AutoSize = true;
            chkLandscape.Checked = true;
            chkLandscape.CheckState = System.Windows.Forms.CheckState.Checked;
            chkLandscape.Location = new System.Drawing.Point(14, 564);
            chkLandscape.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            chkLandscape.Name = "chkLandscape";
            chkLandscape.Size = new System.Drawing.Size(191, 19);
            chkLandscape.TabIndex = 6;
            chkLandscape.Text = "Use landscape page orientation";
            chkLandscape.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(328, 660);
            Controls.Add(chkLandscape);
            Controls.Add(label2);
            Controls.Add(progressBar1);
            Controls.Add(chkOverrideBorders);
            Controls.Add(label1);
            Controls.Add(pgPrintInfo);
            Controls.Add(btnPreviewSample);
            Controls.Add(btnShowSample);
            Controls.Add(comboBox1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();

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

