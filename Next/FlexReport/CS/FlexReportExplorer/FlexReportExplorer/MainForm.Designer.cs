using C1.C1FlexReportExplorer.Properties;
using System.Windows.Forms;
namespace C1.C1FlexReportExplorer
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
            Application.Exit();
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.c1CmdDock = new C1.Win.Command.C1CommandDock();
            this.dockTabPagePreview = new C1.Win.Command.C1DockingTab();
            this.dockTabPageRptList = new C1.Win.Command.C1DockingTabPage();
            this.pnlRpts = new System.Windows.Forms.Panel();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn1 = new C1.Win.TreeView.C1TreeColumn();
            this.c1TreeView = new C1.Win.TreeView.C1TreeView();
            this.c1ThemeController = new C1.Win.Themes.C1ThemeController();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController)).BeginInit();
            this.pnlTabShowHide = new System.Windows.Forms.Panel();
            this.pbTabShowHide = new System.Windows.Forms.PictureBox();
            this.pnlPreviewCtl = new System.Windows.Forms.Panel();
            this.flxViewer = new C1.Win.FlexViewer.C1FlexViewer();
            ((System.ComponentModel.ISupportInitialize)(this.c1CmdDock)).BeginInit();
            this.c1CmdDock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dockTabPagePreview)).BeginInit();
            this.dockTabPagePreview.SuspendLayout();
            this.dockTabPageRptList.SuspendLayout();
            this.pnlRpts.SuspendLayout();
            this.pnlTabShowHide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTabShowHide)).BeginInit();
            this.pnlPreviewCtl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flxViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // c1ThemeController
            // 
            this.c1ThemeController.Theme = "GreenHouse";
            // 
            // c1CmdDock
            // 
            this.c1CmdDock.Controls.Add(this.dockTabPagePreview);
            resources.ApplyResources(this.c1CmdDock, "c1CmdDock");
            this.c1CmdDock.Id = 0;
            this.c1CmdDock.Name = "c1CmdDock";
            // 
            // dockTabPagePreview
            // 
            this.dockTabPagePreview.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.dockTabPagePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dockTabPagePreview.CanAutoHide = true;
            this.dockTabPagePreview.CloseBox = C1.Win.Command.CloseBoxPositionEnum.ActivePage;
            this.dockTabPagePreview.Controls.Add(this.dockTabPageRptList);
            resources.ApplyResources(this.dockTabPagePreview, "dockTabPagePreview");
            this.dockTabPagePreview.Name = "dockTabPagePreview";
            this.dockTabPagePreview.ShowSingleTab = false;
            this.dockTabPagePreview.TabLook = C1.Win.Command.ButtonLookFlags.Text;
            this.dockTabPagePreview.TabsCanFocus = false;
            this.dockTabPagePreview.TabSizeMode = C1.Win.Command.TabSizeModeEnum.Fit;
            this.dockTabPagePreview.TabsShowFocusCues = false;
            this.dockTabPagePreview.TabsSpacing = 5;
            this.c1ThemeController.SetTheme(this.dockTabPagePreview, "(default)");
            // 
            // dockTabPageRptList
            // 
            this.dockTabPageRptList.BackColor = System.Drawing.Color.White;
            this.dockTabPageRptList.Controls.Add(this.pnlRpts);
            this.dockTabPageRptList.Controls.Add(this.pnlTabShowHide);
            resources.ApplyResources(this.dockTabPageRptList, "dockTabPageRptList");
            this.dockTabPageRptList.Name = "dockTabPageRptList";
            this.dockTabPageRptList.TabBackColor = System.Drawing.Color.Transparent;
            //
            // c1TreeView
            //
            this.c1TreeView.AllowDrop = false;
            this.c1TreeView.AutoSizeElement = C1.Framework.AutoSizeElement.Both;
            this.c1TreeView.BackColor = System.Drawing.Color.White;
            this.c1TreeView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            c1TreeColumn1.DisplayFieldName = null;
            c1TreeColumn1.Name = "Column1";
            c1TreeColumn1.Width = 185;
            this.c1TreeView.Columns.Add(c1TreeColumn1);
            this.c1TreeView.BindingInfo.DataMember = null;
            this.c1TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1TreeView.BindingInfo.KeyField = null;
            this.c1TreeView.Location = new System.Drawing.Point(0, 0);
            this.c1TreeView.Name = "c1TreeView";
            this.c1TreeView.BindingInfo.ParentKeyField = null;
            this.c1TreeView.Styles.BorderStyle = C1.Win.TreeView.C1TreeViewBorderStyle.None;
            this.c1TreeView.Styles.ExpandButtonStyle = C1.Win.TreeView.ExpandButtonStyle.Windows10;
            this.c1TreeView.Styles.ShowLines = false;
            this.c1TreeView.ShowColumnHeaders = false;
            this.c1TreeView.TabIndex = 0;
            this.c1TreeView.MouseMove += C1TreeView_MouseMove;
            this.c1TreeView.SelectionChanged += new C1.Win.TreeView.C1TreeViewEventHandler(this.c1TreeView_SelectionChanged);
            this.c1ThemeController.SetTheme(this.c1TreeView, "(default)");
            // 
            // pnlRpts
            // 
            resources.ApplyResources(this.pnlRpts, "pnlRpts");
            this.pnlRpts.BackColor = System.Drawing.Color.Transparent;
            this.pnlRpts.Controls.Add(this.c1TreeView);
            this.pnlRpts.Name = "pnlRpts";
            this.c1ThemeController.SetTheme(this.pnlRpts, "(default)");
            // 
            // pnlTabShowHide
            // 
            this.pnlTabShowHide.Controls.Add(this.pbTabShowHide);
            resources.ApplyResources(this.pnlTabShowHide, "pnlTabShowHide");
            this.pnlTabShowHide.Name = "pnlTabShowHide";
            this.c1ThemeController.SetTheme(this.pnlTabShowHide, "(default)");
            // 
            // pbTabShowHide
            // 
            this.pbTabShowHide.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pbTabShowHide, "pbTabShowHide");
            this.pbTabShowHide.Name = "pbTabShowHide";
            this.pbTabShowHide.TabStop = false;
            this.pbTabShowHide.Click += new System.EventHandler(this.PbTabShowHide_Click);
            // 
            // pnlPreviewCtl
            // 
            this.pnlPreviewCtl.Controls.Add(this.flxViewer);
            resources.ApplyResources(this.pnlPreviewCtl, "pnlPreviewCtl");
            this.pnlPreviewCtl.Name = "pnlPreviewCtl";
            this.c1ThemeController.SetTheme(this.pnlPreviewCtl, "(default)");
            // 
            // flxViewer
            // 
            resources.ApplyResources(this.flxViewer, "flxViewer");
            this.flxViewer.Name = "flxViewer";
            this.flxViewer.ZoomMode = C1.Win.FlexViewer.FlexViewerZoomMode.PageWidth;
            this.c1ThemeController.SetTheme(this.flxViewer, "(default)");
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPreviewCtl);
            this.Controls.Add(this.c1CmdDock);
            this.KeyPreview = true;
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.c1CmdDock)).EndInit();
            this.c1CmdDock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dockTabPagePreview)).EndInit();
            this.dockTabPagePreview.ResumeLayout(false);
            this.dockTabPageRptList.ResumeLayout(false);
            this.pnlRpts.ResumeLayout(false);
            this.pnlTabShowHide.ResumeLayout(false);
            this.c1ThemeController.SetTheme(this, "(default)");
            ((System.ComponentModel.ISupportInitialize)(this.pbTabShowHide)).EndInit();
            this.pnlPreviewCtl.ResumeLayout(false);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.flxViewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1ThemeController)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private C1.Win.Command.C1CommandDock c1CmdDock;
        private C1.Win.Command.C1DockingTab dockTabPagePreview;
        private C1.Win.Command.C1DockingTabPage dockTabPageRptList;
        private System.Windows.Forms.Panel pnlRpts;
        private C1.Win.TreeView.C1TreeView c1TreeView;
        private C1.Win.Themes.C1ThemeController c1ThemeController;
        private System.Windows.Forms.Panel pnlTabShowHide;
        private System.Windows.Forms.PictureBox pbTabShowHide;
        private Panel pnlPreviewCtl;
        private Win.FlexViewer.C1FlexViewer flxViewer;
        private Win.FlexReport.C1FlexReport flxRpt;
    }
}