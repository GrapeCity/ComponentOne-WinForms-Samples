using System;

namespace DataFilterExplorer.Samples
{
    partial class FilterEditorSummaryPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterEditorSummaryPanel));
            this.flexGrid = new C1.Win.FlexGrid.C1FlexGrid();
            this.summaryPanel = new DataFilterExplorer.Samples.Controls.FilterEditorSummaryPanel();
            this.ShowFilterSummaryPanel = new C1.Win.Command.C1Command();
            this.CloseFilterSummaryPanel = new C1.Win.Command.C1Command();
            this.c1CommandHolder1 = new C1.Win.Command.C1CommandHolder();
            this.FlexGridContextMenu = new C1.Win.Command.C1ContextMenu();
            this.c1CommandLinkShow = new C1.Win.Command.C1CommandLink();
            this.c1CommandLinkClose = new C1.Win.Command.C1CommandLink();
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            this.SuspendLayout();
            // 
            // flexGrid
            // 
            this.flexGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flexGrid.BackColor = System.Drawing.Color.White;
            this.c1CommandHolder1.SetC1ContextMenu(this.flexGrid, this.FlexGridContextMenu);
            this.flexGrid.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            this.flexGrid.ColumnPickerInfo.SearchMode = C1.Win.FlexGrid.ColumnPickerSearchMode.None;
            this.flexGrid.ColumnPickerInfo.ShowColumnMenuItem = false;
            this.flexGrid.ColumnPickerInfo.ShowToolButton = false;
            this.flexGrid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.flexGrid.Location = new System.Drawing.Point(0, 0);
            this.flexGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flexGrid.Name = "flexGrid";
            this.flexGrid.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None;
            this.flexGrid.Size = new System.Drawing.Size(1230, 914);
            this.flexGrid.StyleInfo = resources.GetString("flexGrid.StyleInfo");
            this.flexGrid.TabIndex = 0;
            this.flexGrid.Tree.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            // 
            // summaryPanel
            // 
            this.summaryPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.summaryPanel.Location = new System.Drawing.Point(0, 913);
            this.summaryPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.Size = new System.Drawing.Size(1230, 38);
            this.summaryPanel.TabIndex = 1;
            // 
            // ShowFilterSummaryPanel
            // 
            this.ShowFilterSummaryPanel.Image = global::DataFilterExplorer.Properties.Resources.Filter;
            this.ShowFilterSummaryPanel.Name = "ShowFilterSummaryPanel";
            this.ShowFilterSummaryPanel.ShortcutText = "";
            this.ShowFilterSummaryPanel.ShowShortcut = false;
            this.ShowFilterSummaryPanel.Text = "Show filter summary panel";
            // 
            // CloseFilterSummaryPanel
            // 
            this.CloseFilterSummaryPanel.Image = global::DataFilterExplorer.Properties.Resources.FilterClose;
            this.CloseFilterSummaryPanel.Name = "CloseFilterSummaryPanel";
            this.CloseFilterSummaryPanel.ShortcutText = "";
            this.CloseFilterSummaryPanel.ShowShortcut = false;
            this.CloseFilterSummaryPanel.Text = "Close filter summary panel";
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.ShowFilterSummaryPanel);
            this.c1CommandHolder1.Commands.Add(this.CloseFilterSummaryPanel);
            this.c1CommandHolder1.Commands.Add(this.FlexGridContextMenu);
            this.c1CommandHolder1.Owner = this;
            this.c1CommandHolder1.CommandClick += new C1.Win.Command.CommandClickEventHandler(this.c1CommandHolder1_CommandClick);
            // 
            // FlexGridContextMenu
            // 
            this.FlexGridContextMenu.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] {
            this.c1CommandLinkShow,
            this.c1CommandLinkClose});
            this.FlexGridContextMenu.Name = "FlexGridContextMenu";
            this.FlexGridContextMenu.ShortcutText = "";
            this.FlexGridContextMenu.Click += new C1.Win.Command.ClickEventHandler(this.FlexGridContextMenu_Click);
            // 
            // c1CommandLinkShow
            // 
            this.c1CommandLinkShow.ButtonLook = C1.Win.Command.ButtonLookFlags.Text;
            this.c1CommandLinkShow.Command = this.ShowFilterSummaryPanel;
            // 
            // c1CommandLinkClose
            // 
            this.c1CommandLinkClose.ButtonLook = C1.Win.Command.ButtonLookFlags.Text;
            this.c1CommandLinkClose.Command = this.CloseFilterSummaryPanel;
            this.c1CommandLinkClose.SortOrder = 1;
            // 
            // FilterEditorSummaryPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.summaryPanel);
            this.Controls.Add(this.flexGrid);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FilterEditorSummaryPanel";
            this.Size = new System.Drawing.Size(1230, 951);
            this.Load += new System.EventHandler(this.FilterEditorSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flexGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private C1.Win.FlexGrid.C1FlexGrid flexGrid;
        private Controls.FilterEditorSummaryPanel summaryPanel;
        private C1.Win.Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.Command.C1Command ShowFilterSummaryPanel;
        private C1.Win.Command.C1Command CloseFilterSummaryPanel;
        private C1.Win.Command.C1ContextMenu FlexGridContextMenu;
        private C1.Win.Command.C1CommandLink c1CommandLinkShow;
        private C1.Win.Command.C1CommandLink c1CommandLinkClose;
    }
}
