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
            flexGrid = new C1.Win.FlexGrid.C1FlexGrid();
            summaryPanel = new Controls.FilterEditorSummaryPanel();
            ShowFilterSummaryPanel = new C1.Win.Command.C1Command();
            CloseFilterSummaryPanel = new C1.Win.Command.C1Command();
            c1CommandHolder1 = new C1.Win.Command.C1CommandHolder();
            FlexGridContextMenu = new C1.Win.Command.C1ContextMenu();
            c1CommandLinkShow = new C1.Win.Command.C1CommandLink();
            c1CommandLinkClose = new C1.Win.Command.C1CommandLink();
            ((System.ComponentModel.ISupportInitialize)flexGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1CommandHolder1).BeginInit();
            SuspendLayout();
            // 
            // flexGrid
            // 
            flexGrid.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            flexGrid.BackColor = System.Drawing.Color.White;
            c1CommandHolder1.SetC1ContextMenu(flexGrid, FlexGridContextMenu);
            flexGrid.ColumnInfo = "10,1,0,0,0,-1,Columns:";
            flexGrid.ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            flexGrid.Location = new System.Drawing.Point(0, 0);
            flexGrid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            flexGrid.Name = "flexGrid";
            flexGrid.ShowThemedHeaders = C1.Win.FlexGrid.ShowThemedHeadersEnum.None;
            flexGrid.Size = new System.Drawing.Size(1230, 914);
            flexGrid.StyleInfo = resources.GetString("flexGrid.StyleInfo");
            flexGrid.TabIndex = 0;
            flexGrid.Tree.LineColor = System.Drawing.Color.FromArgb(171, 171, 171);
            // 
            // summaryPanel
            // 
            summaryPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            summaryPanel.Location = new System.Drawing.Point(0, 911);
            summaryPanel.Margin = new System.Windows.Forms.Padding(4);
            summaryPanel.Name = "summaryPanel";
            summaryPanel.Size = new System.Drawing.Size(1230, 40);
            summaryPanel.TabIndex = 1;
            // 
            // ShowFilterSummaryPanel
            // 
            ShowFilterSummaryPanel.Image = Properties.Resources.Filter;
            ShowFilterSummaryPanel.Name = "ShowFilterSummaryPanel";
            ShowFilterSummaryPanel.ShortcutText = "";
            ShowFilterSummaryPanel.ShowShortcut = false;
            ShowFilterSummaryPanel.Text = "Show filter summary panel";
            ShowFilterSummaryPanel.Virgin = false;
            // 
            // CloseFilterSummaryPanel
            // 
            CloseFilterSummaryPanel.Image = Properties.Resources.FilterClose;
            CloseFilterSummaryPanel.Name = "CloseFilterSummaryPanel";
            CloseFilterSummaryPanel.ShortcutText = "";
            CloseFilterSummaryPanel.ShowShortcut = false;
            CloseFilterSummaryPanel.Text = "Close filter summary panel";
            CloseFilterSummaryPanel.Virgin = false;
            // 
            // c1CommandHolder1
            // 
            c1CommandHolder1.Commands.Add(ShowFilterSummaryPanel);
            c1CommandHolder1.Commands.Add(CloseFilterSummaryPanel);
            c1CommandHolder1.Commands.Add(FlexGridContextMenu);
            c1CommandHolder1.Owner = this;
            c1CommandHolder1.CommandClick += c1CommandHolder1_CommandClick;
            // 
            // FlexGridContextMenu
            // 
            FlexGridContextMenu.CommandLinks.AddRange(new C1.Win.Command.C1CommandLink[] { c1CommandLinkShow, c1CommandLinkClose });
            FlexGridContextMenu.Name = "FlexGridContextMenu";
            FlexGridContextMenu.ShortcutText = "";
            FlexGridContextMenu.Virgin = false;
            FlexGridContextMenu.Click += FlexGridContextMenu_Click;
            // 
            // c1CommandLinkShow
            // 
            c1CommandLinkShow.ButtonLook = C1.Win.Command.ButtonLookFlags.Text;
            c1CommandLinkShow.Command = ShowFilterSummaryPanel;
            // 
            // c1CommandLinkClose
            // 
            c1CommandLinkClose.ButtonLook = C1.Win.Command.ButtonLookFlags.Text;
            c1CommandLinkClose.Command = CloseFilterSummaryPanel;
            c1CommandLinkClose.SortOrder = 1;
            // 
            // FilterEditorSummaryPanel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            Controls.Add(summaryPanel);
            Controls.Add(flexGrid);
            Font = new System.Drawing.Font("Segoe UI", 9.75F);
            ForeColor = System.Drawing.Color.FromArgb(68, 68, 68);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "FilterEditorSummaryPanel";
            Size = new System.Drawing.Size(1230, 951);
            Load += FilterEditorSummary_Load;
            ((System.ComponentModel.ISupportInitialize)flexGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1CommandHolder1).EndInit();
            ResumeLayout(false);
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
