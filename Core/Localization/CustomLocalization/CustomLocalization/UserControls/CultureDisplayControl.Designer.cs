namespace Custom_Localization.CustomControls
{
    partial class CultureDisplayControl
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
            cultureDisplayPanel = new Panel();
            panel2 = new Panel();
            overrideCulturePanel = new FlowLayoutPanel();
            overrideCultureLabel = new C1.Win.Input.C1Label();
            customAddedCulturePanel = new FlowLayoutPanel();
            customAddedCultureLabel = new C1.Win.Input.C1Label();
            preSupportedCulturePanel = new FlowLayoutPanel();
            preDefinedCultureLabel = new C1.Win.Input.C1Label();
            cultureDisplayPanel.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)overrideCultureLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customAddedCultureLabel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)preDefinedCultureLabel).BeginInit();
            SuspendLayout();
            // 
            // cultureDisplayPanel
            // 
            cultureDisplayPanel.Controls.Add(panel2);
            cultureDisplayPanel.Controls.Add(customAddedCulturePanel);
            cultureDisplayPanel.Controls.Add(customAddedCultureLabel);
            cultureDisplayPanel.Controls.Add(preSupportedCulturePanel);
            cultureDisplayPanel.Controls.Add(preDefinedCultureLabel);
            cultureDisplayPanel.Dock = DockStyle.Fill;
            cultureDisplayPanel.Location = new Point(0, 0);
            cultureDisplayPanel.Margin = new Padding(2);
            cultureDisplayPanel.Name = "cultureDisplayPanel";
            cultureDisplayPanel.Size = new Size(288, 379);
            cultureDisplayPanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.AutoSize = true;
            panel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel2.Controls.Add(overrideCulturePanel);
            panel2.Controls.Add(overrideCultureLabel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 66);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 33);
            panel2.TabIndex = 4;
            // 
            // overrideCulturePanel
            // 
            overrideCulturePanel.AutoSize = true;
            overrideCulturePanel.Dock = DockStyle.Top;
            overrideCulturePanel.Location = new Point(0, 33);
            overrideCulturePanel.Margin = new Padding(2);
            overrideCulturePanel.Name = "overrideCulturePanel";
            overrideCulturePanel.Size = new Size(288, 0);
            overrideCulturePanel.TabIndex = 6;
            // 
            // overrideCultureLabel
            // 
            overrideCultureLabel.AutoSize = true;
            overrideCultureLabel.Dock = DockStyle.Top;
            overrideCultureLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            overrideCultureLabel.Location = new Point(0, 0);
            overrideCultureLabel.Name = "overrideCultureLabel";
            overrideCultureLabel.Size = new Size(288, 33);
            overrideCultureLabel.TabIndex = 5;
            overrideCultureLabel.Text = "Override Cultures";
            // 
            // customAddedCulturePanel
            // 
            customAddedCulturePanel.AutoSize = true;
            customAddedCulturePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customAddedCulturePanel.Dock = DockStyle.Top;
            customAddedCulturePanel.Location = new Point(0, 66);
            customAddedCulturePanel.Margin = new Padding(2);
            customAddedCulturePanel.Name = "customAddedCulturePanel";
            customAddedCulturePanel.Size = new Size(288, 0);
            customAddedCulturePanel.TabIndex = 3;
            // 
            // customAddedCultureLabel
            // 
            customAddedCultureLabel.AutoSize = true;
            customAddedCultureLabel.Dock = DockStyle.Top;
            customAddedCultureLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customAddedCultureLabel.Location = new Point(0, 33);
            customAddedCultureLabel.Name = "customAddedCultureLabel";
            customAddedCultureLabel.Size = new Size(288, 33);
            customAddedCultureLabel.TabIndex = 2;
            customAddedCultureLabel.Text = "Custom Cultures";
            // 
            // preSupportedCulturePanel
            // 
            preSupportedCulturePanel.AutoSize = true;
            preSupportedCulturePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            preSupportedCulturePanel.Dock = DockStyle.Top;
            preSupportedCulturePanel.Location = new Point(0, 33);
            preSupportedCulturePanel.Margin = new Padding(2);
            preSupportedCulturePanel.Name = "preSupportedCulturePanel";
            preSupportedCulturePanel.Size = new Size(288, 0);
            preSupportedCulturePanel.TabIndex = 1;
            // 
            // preDefinedCultureLabel
            // 
            preDefinedCultureLabel.AutoSize = true;
            preDefinedCultureLabel.Dock = DockStyle.Top;
            preDefinedCultureLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            preDefinedCultureLabel.Location = new Point(0, 0);
            preDefinedCultureLabel.Name = "preDefinedCultureLabel";
            preDefinedCultureLabel.Size = new Size(288, 33);
            preDefinedCultureLabel.TabIndex = 0;
            preDefinedCultureLabel.Text = "Pre Supported Cultures";
            // 
            // CultureDisplayControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cultureDisplayPanel);
            Margin = new Padding(2);
            Name = "CultureDisplayControl";
            Size = new Size(288, 379);
            cultureDisplayPanel.ResumeLayout(false);
            cultureDisplayPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)overrideCultureLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)customAddedCultureLabel).EndInit();
            ((System.ComponentModel.ISupportInitialize)preDefinedCultureLabel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel cultureDisplayPanel;
        private FlowLayoutPanel customAddedCulturePanel;
        private C1.Win.Input.C1Label customAddedCultureLabel;
        private FlowLayoutPanel preSupportedCulturePanel;
        private C1.Win.Input.C1Label preDefinedCultureLabel;
        private Panel panel2;
        private FlowLayoutPanel overrideCulturePanel;
        private C1.Win.Input.C1Label overrideCultureLabel;
    }
}
