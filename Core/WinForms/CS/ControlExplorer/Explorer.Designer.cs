namespace ControlExplorer
{
    partial class Explorer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Explorer));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.btnPricing = new C1.Win.Input.C1Button();
            this.btnDownload = new C1.Win.Input.C1Button();
            this.slblHeader = new C1.Win.SuperTooltip.C1SuperLabel();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.allControls1 = new ControlExplorer.Controls.AllControls();
            this.demoViewer1 = new ControlExplorer.Controls.DemoViewer();
            this.homeNavigation1 = new ControlExplorer.Controls.HomeNavigation();
            this.btnAbout = new C1.Win.Input.C1Button();
            this.btnSupport = new C1.Win.Input.C1Button();
            this.headerPanel.SuspendLayout();
            this.navigationPanel.SuspendLayout();
            this.pnlTools.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.headerPanel.Controls.Add(this.pnlTools);
            this.headerPanel.Controls.Add(this.slblHeader);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1192, 48);
            this.headerPanel.TabIndex = 0;
            // 
            // pnlTools
            // 
            this.pnlTools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTools.Controls.Add(this.btnSupport);
            this.pnlTools.Controls.Add(this.btnAbout);
            this.pnlTools.Controls.Add(this.btnPricing);
            this.pnlTools.Controls.Add(this.btnDownload);
            this.pnlTools.Location = new System.Drawing.Point(518, 0);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(674, 48);
            this.pnlTools.TabIndex = 1;
            // 
            // btnPricing
            // 
            this.btnPricing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.btnPricing.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            this.btnPricing.Location = new System.Drawing.Point(471, 0);
            this.btnPricing.Name = "btnPricing";
            this.btnPricing.Size = new System.Drawing.Size(48, 48);
            this.btnPricing.Styles.Default.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnPricing.Styles.Border = new C1.Framework.Thickness(0);
            this.btnPricing.Styles.Default.ForeColor = System.Drawing.Color.White;
            this.btnPricing.Styles.Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnPricing.Styles.Hot.ForeColor = System.Drawing.Color.White;
            this.btnPricing.Styles.HotPressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnPricing.Styles.HotPressed.ForeColor = System.Drawing.Color.White;
            this.btnPricing.Styles.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnPricing.Styles.Pressed.ForeColor = System.Drawing.Color.White;
            this.btnPricing.TabIndex = 1;
            this.btnPricing.UseMnemonic = true;
            this.btnPricing.Click += new System.EventHandler(this.btnPricing_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            this.btnDownload.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Location = new System.Drawing.Point(535, 8);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(115, 32);
            this.btnDownload.Styles.Border = new C1.Framework.Thickness(0, 0, 0, 0);
            this.btnDownload.Styles.Default.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnDownload.Styles.Default.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Styles.Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(54)))), ((int)(((byte)(53)))));
            this.btnDownload.Styles.Hot.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Styles.HotPressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(54)))), ((int)(((byte)(53)))));
            this.btnDownload.Styles.HotPressed.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Styles.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnDownload.Styles.Pressed.ForeColor = System.Drawing.Color.White;
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "FREE TRIAL";
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // slblHeader
            // 
            this.slblHeader.Font = new System.Drawing.Font("Trebuchet MS", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.slblHeader.ForeColor = System.Drawing.Color.White;
            this.slblHeader.Location = new System.Drawing.Point(26, 10);
            this.slblHeader.Margin = new System.Windows.Forms.Padding(0);
            this.slblHeader.Name = "slblHeader";
            this.slblHeader.Size = new System.Drawing.Size(489, 35);
            this.slblHeader.TabIndex = 0;
            this.slblHeader.Text = "<span style=\"font-weight:bold\">Component</span><span style=\"font-weight:light\">On" +
    "e|</span><span style=\"font-weight:bold\">WinForms </span><span style=\"font-weight" +
    ":light\">CONTROL EXPLORER</span>";
            this.slblHeader.UseMnemonic = true;
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(243)))));
            this.navigationPanel.Controls.Add(this.homeNavigation1);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(0, 48);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(215, 710);
            this.navigationPanel.TabIndex = 1;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Controls.Add(this.allControls1);
            this.contentPanel.Controls.Add(this.demoViewer1);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(215, 48);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(977, 710);
            this.contentPanel.TabIndex = 3;
            // 
            // allControls1
            // 
            this.allControls1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allControls1.Location = new System.Drawing.Point(0, 0);
            this.allControls1.Name = "allControls1";
            this.allControls1.Size = new System.Drawing.Size(677, 710);
            this.allControls1.TabIndex = 1;
            // 
            // demoViewer1
            // 
            this.demoViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.demoViewer1.Location = new System.Drawing.Point(0, 0);
            this.demoViewer1.Name = "demoViewer1";
            this.demoViewer1.Size = new System.Drawing.Size(977, 710);
            this.demoViewer1.TabIndex = 0;
            // 
            // homeNavigation1
            // 
            this.homeNavigation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(243)))));
            this.homeNavigation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeNavigation1.Location = new System.Drawing.Point(0, 0);
            this.homeNavigation1.Name = "homeNavigation1";
            this.homeNavigation1.Size = new System.Drawing.Size(215, 710);
            this.homeNavigation1.TabIndex = 0;
            // 
            // btnAbout
            // 
            this.btnAbout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            this.btnAbout.Location = new System.Drawing.Point(375, 0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(48, 48);
            this.btnAbout.Styles.Default.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnAbout.Styles.Border = new C1.Framework.Thickness(0);
            this.btnAbout.Styles.Default.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Styles.Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnAbout.Styles.Hot.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Styles.HotPressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAbout.Styles.HotPressed.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Styles.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAbout.Styles.Pressed.ForeColor = System.Drawing.Color.White;
            this.btnAbout.TabIndex = 2;
            this.btnAbout.UseMnemonic = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSupport
            // 
            this.btnSupport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            this.btnSupport.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right));
            this.btnSupport.Location = new System.Drawing.Point(423, 0);
            this.btnSupport.Name = "btnSupport";
            this.btnSupport.Size = new System.Drawing.Size(48, 48);
            this.btnSupport.Styles.Default.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.btnSupport.Styles.Border = new C1.Framework.Thickness(0);
            this.btnSupport.Styles.Default.ForeColor = System.Drawing.Color.White;
            this.btnSupport.Styles.Hot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.btnSupport.Styles.Hot.ForeColor = System.Drawing.Color.White;
            this.btnSupport.Styles.HotPressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSupport.Styles.HotPressed.ForeColor = System.Drawing.Color.White;
            this.btnSupport.Styles.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSupport.Styles.Pressed.ForeColor = System.Drawing.Color.White;
            this.btnSupport.TabIndex = 3;
            this.btnSupport.UseMnemonic = true;
            this.btnSupport.Click += new System.EventHandler(this.btnSupport_Click);
            // 
            // Explorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.ClientSize = new System.Drawing.Size(1192, 758);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.headerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Explorer";
            this.Text = "ComponentOne WinForms Control Explorer";
            this.Load += new System.EventHandler(this.Explorer_Load);
            this.headerPanel.ResumeLayout(false);
            this.navigationPanel.ResumeLayout(false);
            this.pnlTools.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Panel contentPanel;
        private C1.Win.SuperTooltip.C1SuperLabel slblHeader;
        private Controls.DemoViewer demoViewer1;
        private Controls.AllControls allControls1;
        private Controls.HomeNavigation homeNavigation1;
        private System.Windows.Forms.Panel pnlTools;
        private C1.Win.Input.C1Button btnDownload;
        private C1.Win.Input.C1Button btnPricing;
        private C1.Win.Input.C1Button btnSupport;
        private C1.Win.Input.C1Button btnAbout;
    }
}

