namespace ControlExplorer.Controls
{
    partial class HomePageControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlWrapper = new System.Windows.Forms.Panel();
            pnlBody = new System.Windows.Forms.Panel();
            pnlFeatureBody = new System.Windows.Forms.FlowLayoutPanel();
            pnlFeatureHeader = new System.Windows.Forms.Panel();
            lblFeature = new System.Windows.Forms.Label();
            pnlHeader = new System.Windows.Forms.Panel();
            pnlDesc = new System.Windows.Forms.Panel();
            lblDesc = new System.Windows.Forms.Label();
            pnlTitle = new System.Windows.Forms.Panel();
            lblTitle = new System.Windows.Forms.Label();
            pnlWrapper.SuspendLayout();
            pnlBody.SuspendLayout();
            pnlFeatureHeader.SuspendLayout();
            pnlHeader.SuspendLayout();
            pnlDesc.SuspendLayout();
            pnlTitle.SuspendLayout();
            SuspendLayout();
            // 
            // pnlWrapper
            // 
            pnlWrapper.Controls.Add(pnlBody);
            pnlWrapper.Controls.Add(pnlHeader);
            pnlWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlWrapper.Location = new System.Drawing.Point(26, 22);
            pnlWrapper.Name = "pnlWrapper";
            pnlWrapper.Size = new System.Drawing.Size(1161, 778);
            pnlWrapper.TabIndex = 0;
            // 
            // pnlBody
            // 
            pnlBody.Controls.Add(pnlFeatureBody);
            pnlBody.Controls.Add(pnlFeatureHeader);
            pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlBody.Location = new System.Drawing.Point(0, 161);
            pnlBody.Name = "pnlBody";
            pnlBody.Size = new System.Drawing.Size(1161, 617);
            pnlBody.TabIndex = 1;
            // 
            // pnlFeatureBody
            // 
            pnlFeatureBody.AutoScroll = true;
            pnlFeatureBody.AutoSize = true;
            pnlFeatureBody.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlFeatureBody.Location = new System.Drawing.Point(0, 38);
            pnlFeatureBody.Name = "pnlFeatureBody";
            pnlFeatureBody.Size = new System.Drawing.Size(1161, 579);
            pnlFeatureBody.TabIndex = 1;
            // 
            // pnlFeatureHeader
            // 
            pnlFeatureHeader.Controls.Add(lblFeature);
            pnlFeatureHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlFeatureHeader.Location = new System.Drawing.Point(0, 0);
            pnlFeatureHeader.Name = "pnlFeatureHeader";
            pnlFeatureHeader.Size = new System.Drawing.Size(1161, 38);
            pnlFeatureHeader.TabIndex = 0;
            // 
            // lblFeature
            // 
            lblFeature.Dock = System.Windows.Forms.DockStyle.Left;
            lblFeature.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            lblFeature.ForeColor = System.Drawing.Color.FromArgb(214, 86, 76);
            lblFeature.Location = new System.Drawing.Point(0, 0);
            lblFeature.Name = "lblFeature";
            lblFeature.Size = new System.Drawing.Size(525, 38);
            lblFeature.TabIndex = 0;
            lblFeature.Text = "label1";
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(pnlDesc);
            pnlHeader.Controls.Add(pnlTitle);
            pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            pnlHeader.Location = new System.Drawing.Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new System.Drawing.Size(1161, 161);
            pnlHeader.TabIndex = 0;
            // 
            // pnlDesc
            // 
            pnlDesc.Controls.Add(lblDesc);
            pnlDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            pnlDesc.Location = new System.Drawing.Point(0, 59);
            pnlDesc.Name = "pnlDesc";
            pnlDesc.Size = new System.Drawing.Size(1161, 102);
            pnlDesc.TabIndex = 1;
            // 
            // lblDesc
            // 
            lblDesc.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            lblDesc.Font = new System.Drawing.Font("Segoe UI", 13F);
            lblDesc.Location = new System.Drawing.Point(0, -1);
            lblDesc.Name = "lblDesc";
            lblDesc.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            lblDesc.Size = new System.Drawing.Size(1156, 102);
            lblDesc.TabIndex = 0;
            lblDesc.Text = "label1";
            // 
            // pnlTitle
            // 
            pnlTitle.Controls.Add(lblTitle);
            pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            pnlTitle.Location = new System.Drawing.Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new System.Drawing.Size(1161, 59);
            pnlTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(214, 86, 76);
            lblTitle.Location = new System.Drawing.Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(482, 59);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // HomePageControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pnlWrapper);
            Name = "HomePageControl";
            Padding = new System.Windows.Forms.Padding(26, 22, 26, 22);
            Size = new System.Drawing.Size(1213, 822);
            pnlWrapper.ResumeLayout(false);
            pnlBody.ResumeLayout(false);
            pnlBody.PerformLayout();
            pnlFeatureHeader.ResumeLayout(false);
            pnlHeader.ResumeLayout(false);
            pnlDesc.ResumeLayout(false);
            pnlTitle.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlWrapper;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlDesc;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlFeatureHeader;
        private System.Windows.Forms.Label lblFeature;
        private System.Windows.Forms.FlowLayoutPanel pnlFeatureBody;
    }
}
