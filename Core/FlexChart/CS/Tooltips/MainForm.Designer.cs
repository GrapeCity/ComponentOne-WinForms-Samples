namespace Tooltips
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            regularTooltipMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            hTMLTooltipMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            chartTooltipMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { viewToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { regularTooltipMenuItem, hTMLTooltipMenuItem, chartTooltipMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // regularTooltipMenuItem
            // 
            regularTooltipMenuItem.Name = "regularTooltipMenuItem";
            resources.ApplyResources(regularTooltipMenuItem, "regularTooltipMenuItem");
            // 
            // hTMLTooltipMenuItem
            // 
            hTMLTooltipMenuItem.Name = "hTMLTooltipMenuItem";
            resources.ApplyResources(hTMLTooltipMenuItem, "hTMLTooltipMenuItem");
            // 
            // chartTooltipMenuItem
            // 
            chartTooltipMenuItem.Name = "chartTooltipMenuItem";
            resources.ApplyResources(chartTooltipMenuItem, "chartTooltipMenuItem");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularTooltipMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTMLTooltipMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartTooltipMenuItem;
    }
}