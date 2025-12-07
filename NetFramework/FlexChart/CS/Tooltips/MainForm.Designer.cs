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
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularTooltipMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTMLTooltipMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartTooltipMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.regularTooltipMenuItem,
            this.hTMLTooltipMenuItem,
            this.chartTooltipMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            resources.ApplyResources(this.viewToolStripMenuItem, "viewToolStripMenuItem");
            // 
            // regularTooltipMenuItem
            // 
            this.regularTooltipMenuItem.Name = "regularTooltipMenuItem";
            resources.ApplyResources(this.regularTooltipMenuItem, "regularTooltipMenuItem");
            // 
            // hTMLTooltipMenuItem
            // 
            this.hTMLTooltipMenuItem.Name = "hTMLTooltipMenuItem";
            resources.ApplyResources(this.hTMLTooltipMenuItem, "hTMLTooltipMenuItem");
            // 
            // chartTooltipMenuItem
            // 
            this.chartTooltipMenuItem.Name = "chartTooltipMenuItem";
            resources.ApplyResources(this.chartTooltipMenuItem, "chartTooltipMenuItem");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regularTooltipMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hTMLTooltipMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartTooltipMenuItem;
    }
}