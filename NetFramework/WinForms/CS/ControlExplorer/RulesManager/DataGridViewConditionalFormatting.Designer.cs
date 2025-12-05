namespace ControlExplorer.RulesManager
{
    partial class DataGridViewConditionalFormatting
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
            this.commandDock = new C1.Win.Command.C1CommandDock();
            this.dockingTab = new C1.Win.Command.C1DockingTab();
            this.dockingTabPageConditionalFormatting = new C1.Win.Command.C1DockingTabPage();
            this.rulesManager = new C1.Win.RulesManager.C1RulesManager();
            this.formattableDataGridView = new ControlExplorer.RulesManager.FormattableDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.commandDock)).BeginInit();
            this.commandDock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockingTab)).BeginInit();
            this.dockingTab.SuspendLayout();
            this.dockingTabPageConditionalFormatting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rulesManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formattableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // commandDock
            // 
            this.commandDock.Controls.Add(this.dockingTab);
            this.commandDock.Dock = System.Windows.Forms.DockStyle.Right;
            this.commandDock.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.commandDock.Id = 1;
            this.commandDock.Location = new System.Drawing.Point(892, 0);
            this.commandDock.Name = "commandDock";
            this.commandDock.Size = new System.Drawing.Size(200, 752);
            // 
            // dockingTab
            // 
            this.dockingTab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dockingTab.Controls.Add(this.dockingTabPageConditionalFormatting);
            this.dockingTab.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dockingTab.HotTrack = true;
            this.dockingTab.Location = new System.Drawing.Point(0, 0);
            this.dockingTab.Name = "dockingTab";
            this.dockingTab.ShowSingleTab = false;
            this.dockingTab.Size = new System.Drawing.Size(200, 752);
            this.dockingTab.TabIndex = 0;
            this.dockingTab.TabSizeMode = C1.Win.Command.TabSizeModeEnum.Fit;
            this.dockingTab.TabsSpacing = 2;
            this.dockingTab.VisualStyle = C1.Win.Command.VisualStyle.Office2010Blue;
            this.dockingTab.VisualStyleBase = C1.Win.Command.VisualStyle.Office2010Blue;
            // 
            // dockingTabPageConditionalFormatting
            // 
            this.dockingTabPageConditionalFormatting.Controls.Add(this.rulesManager);
            this.dockingTabPageConditionalFormatting.Location = new System.Drawing.Point(4, 1);
            this.dockingTabPageConditionalFormatting.Name = "dockingTabPageConditionalFormatting";
            this.dockingTabPageConditionalFormatting.Size = new System.Drawing.Size(195, 750);
            this.dockingTabPageConditionalFormatting.TabIndex = 0;
            this.dockingTabPageConditionalFormatting.Text = "Conditional Formatting";
            // 
            // rulesManager
            // 
            this.rulesManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rulesManager.Location = new System.Drawing.Point(0, 0);
            this.rulesManager.Name = "rulesManager";
            this.rulesManager.Size = new System.Drawing.Size(195, 750);
            this.rulesManager.TabIndex = 0;
            this.rulesManager.Text = "rulesManager";
            // 
            // formattableDataGridView
            // 
            this.rulesManager.SetC1RulesManager(this.formattableDataGridView, this.rulesManager);
            this.formattableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formattableDataGridView.Location = new System.Drawing.Point(0, 0);
            this.formattableDataGridView.Name = "formattableDataGridView";
            this.formattableDataGridView.Size = new System.Drawing.Size(892, 752);
            this.formattableDataGridView.TabIndex = 1;
            // 
            // DataGridViewConditionalFormatting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 752);
            this.Controls.Add(this.formattableDataGridView);
            this.Controls.Add(this.commandDock);
            this.Name = "DataGridViewConditionalFormatting";
            this.Text = "DataGridViewConditionalFormatting";
            this.Load += new System.EventHandler(this.DataGridViewConditionalFormatting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.commandDock)).EndInit();
            this.commandDock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockingTab)).EndInit();
            this.dockingTab.ResumeLayout(false);
            this.dockingTabPageConditionalFormatting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rulesManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formattableDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.Command.C1CommandDock commandDock;
        private C1.Win.Command.C1DockingTab dockingTab;
        private C1.Win.Command.C1DockingTabPage dockingTabPageConditionalFormatting;
        private C1.Win.RulesManager.C1RulesManager rulesManager;
        private ControlExplorer.RulesManager.FormattableDataGridView formattableDataGridView;
    }
}

