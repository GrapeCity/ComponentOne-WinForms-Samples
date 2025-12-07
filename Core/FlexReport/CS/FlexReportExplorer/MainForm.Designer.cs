using FlexReportExplorer.Properties;
using System.Windows.Forms;
namespace FlexReportExplorer
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
            C1.Win.Command.CentralTabMinimumSize centralTabMinimumSize1 = new C1.Win.Command.CentralTabMinimumSize();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            C1.Win.TreeView.C1TreeColumn c1TreeColumn1 = new C1.Win.TreeView.C1TreeColumn();
            C1.Win.TreeView.C1TreeColumn c1TreeColumn2 = new C1.Win.TreeView.C1TreeColumn();
            c1CmdDock = new C1.Win.Command.C1CommandDock();
            dockTabPagePreview = new C1.Win.Command.C1DockingTab();
            dockTabPageRptList = new C1.Win.Command.C1DockingTabPage();
            pnlRpts = new Panel();
            c1TreeView = new C1.Win.TreeView.C1TreeView();
            pnlTabShowHide = new Panel();
            pbTabShowHide = new PictureBox();
            c1ThemeController = new C1.Win.Themes.C1ThemeController();
            pnlPreviewCtl = new Panel();
            flxViewer = new C1.Win.FlexViewer.C1FlexViewer();
            ((System.ComponentModel.ISupportInitialize)c1CmdDock).BeginInit();
            c1CmdDock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dockTabPagePreview).BeginInit();
            dockTabPagePreview.SuspendLayout();
            dockTabPageRptList.SuspendLayout();
            pnlRpts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)c1TreeView).BeginInit();
            pnlTabShowHide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTabShowHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)c1ThemeController).BeginInit();
            pnlPreviewCtl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flxViewer).BeginInit();
            SuspendLayout();
            // 
            // c1CmdDock
            // 
            centralTabMinimumSize1.Width = 20;
            centralTabMinimumSize1.WidthType = SizeType.AutoSize;
            c1CmdDock.CentralTabMinimumSize = centralTabMinimumSize1;
            c1CmdDock.Controls.Add(dockTabPagePreview);
            resources.ApplyResources(c1CmdDock, "c1CmdDock");
            c1CmdDock.Id = 0;
            c1CmdDock.Name = "c1CmdDock";
            // 
            // dockTabPagePreview
            // 
            dockTabPagePreview.Alignment = TabAlignment.Bottom;
            dockTabPagePreview.BackColor = System.Drawing.Color.White;
            dockTabPagePreview.CanAutoHide = true;
            dockTabPagePreview.CloseBox = C1.Win.Command.CloseBoxPositionEnum.ActivePage;
            dockTabPagePreview.Controls.Add(dockTabPageRptList);
            resources.ApplyResources(dockTabPagePreview, "dockTabPagePreview");
            dockTabPagePreview.HotTrack = true;
            dockTabPagePreview.Name = "dockTabPagePreview";
            dockTabPagePreview.ShowSingleTab = false;
            dockTabPagePreview.TabLook = C1.Win.Command.ButtonLookFlags.Text;
            dockTabPagePreview.TabsCanFocus = false;
            dockTabPagePreview.TabShape = C1.Win.Command.TabShape.Rounded;
            dockTabPagePreview.TabSizeMode = C1.Win.Command.TabSizeModeEnum.Fit;
            dockTabPagePreview.TabsSpacing = 5;
            c1ThemeController.SetTheme(dockTabPagePreview, "(default)");
            // 
            // dockTabPageRptList
            // 
            dockTabPageRptList.BackColor = System.Drawing.Color.White;
            dockTabPageRptList.Controls.Add(pnlRpts);
            dockTabPageRptList.Controls.Add(pnlTabShowHide);
            resources.ApplyResources(dockTabPageRptList, "dockTabPageRptList");
            dockTabPageRptList.Name = "dockTabPageRptList";
            dockTabPageRptList.TabBackColor = System.Drawing.Color.Transparent;
            // 
            // pnlRpts
            // 
            resources.ApplyResources(pnlRpts, "pnlRpts");
            pnlRpts.BackColor = System.Drawing.SystemColors.ButtonFace;
            pnlRpts.Controls.Add(c1TreeView);
            pnlRpts.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            pnlRpts.Name = "pnlRpts";
            c1ThemeController.SetTheme(pnlRpts, "(default)");
            // 
            // c1TreeView
            // 
            c1TreeView.BackColor = System.Drawing.Color.White;
            c1TreeView.BorderStyle = BorderStyle.None;
            // 
            // 
            // 
            c1TreeView.ButtonImageList.ColorDepth = ColorDepth.Depth32Bit;
            c1TreeView.ButtonImageList.ImageSize = (System.Drawing.Size)resources.GetObject("c1TreeView.ButtonImageList.ImageSize");
            // 
            // 
            // 
            c1TreeView.CheckImageList.ColorDepth = ColorDepth.Depth32Bit;
            c1TreeView.CheckImageList.ImageSize = (System.Drawing.Size)resources.GetObject("c1TreeView.CheckImageList.ImageSize");
            c1TreeColumn1.HeaderText = "Column1";
            c1TreeColumn1.Name = "Column1";
            c1TreeColumn2.HeaderText = null;
            c1TreeColumn2.Name = "Column1";
            c1TreeColumn2.Width = 185;
            c1TreeView.Columns.Add(c1TreeColumn1);
            c1TreeView.Columns.Add(c1TreeColumn2);
            resources.ApplyResources(c1TreeView, "c1TreeView");
            c1TreeView.Name = "c1TreeView";
            c1TreeView.ShowColumnHeaders = false;
            c1TreeView.Styles.ExpandButtonStyle = C1.Win.TreeView.ExpandButtonStyle.Windows10;
            c1ThemeController.SetTheme(c1TreeView, "(default)");
            c1TreeView.SelectionChanged += c1TreeView_SelectionChanged;
            c1TreeView.MouseMove += C1TreeView_MouseMove;
            // 
            // pnlTabShowHide
            // 
            pnlTabShowHide.BackColor = System.Drawing.SystemColors.ButtonFace;
            pnlTabShowHide.Controls.Add(pbTabShowHide);
            resources.ApplyResources(pnlTabShowHide, "pnlTabShowHide");
            pnlTabShowHide.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            pnlTabShowHide.Name = "pnlTabShowHide";
            c1ThemeController.SetTheme(pnlTabShowHide, "(default)");
            // 
            // pbTabShowHide
            // 
            pbTabShowHide.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(pbTabShowHide, "pbTabShowHide");
            pbTabShowHide.Name = "pbTabShowHide";
            pbTabShowHide.TabStop = false;
            pbTabShowHide.Click += PbTabShowHide_Click;
            // 
            // c1ThemeController
            // 
            c1ThemeController.Theme = "Office365White";
            // 
            // pnlPreviewCtl
            // 
            pnlPreviewCtl.BackColor = System.Drawing.SystemColors.ButtonFace;
            pnlPreviewCtl.Controls.Add(flxViewer);
            resources.ApplyResources(pnlPreviewCtl, "pnlPreviewCtl");
            pnlPreviewCtl.ForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            pnlPreviewCtl.Name = "pnlPreviewCtl";
            c1ThemeController.SetTheme(pnlPreviewCtl, "(default)");
            // 
            // flxViewer
            // 
            resources.ApplyResources(flxViewer, "flxViewer");
            flxViewer.Name = "flxViewer";
            flxViewer.OutlineBackColorHot = System.Drawing.Color.WhiteSmoke;
            flxViewer.OutlineBackColorHotSelected = System.Drawing.Color.FromArgb(249, 249, 249);
            flxViewer.OutlineBackColorSelected = System.Drawing.Color.FromArgb(249, 249, 249);
            flxViewer.OutlineButtonBackColorHot = System.Drawing.Color.FromArgb(235, 235, 235);
            flxViewer.OutlineButtonBackColorPressed = System.Drawing.SystemColors.ButtonFace;
            flxViewer.OutlineButtonBorderColorHot = System.Drawing.Color.FromArgb(235, 235, 235);
            flxViewer.OutlineButtonBorderColorPressed = System.Drawing.SystemColors.ButtonFace;
            flxViewer.OutlineButtonForeColorHot = System.Drawing.Color.FromArgb(32, 32, 32);
            flxViewer.OutlineButtonForeColorNormal = System.Drawing.Color.FromArgb(32, 32, 32);
            flxViewer.OutlineButtonForeColorPressed = System.Drawing.SystemColors.WindowFrame;
            flxViewer.OutlineForeColorHot = System.Drawing.Color.FromArgb(32, 32, 32);
            flxViewer.OutlineForeColorHotSelected = System.Drawing.SystemColors.WindowFrame;
            flxViewer.OutlineForeColorNormal = System.Drawing.Color.FromArgb(32, 32, 32);
            flxViewer.OutlineForeColorSelected = System.Drawing.SystemColors.WindowFrame;
            flxViewer.OutlineLineColor = System.Drawing.Color.FromArgb(215, 215, 215);
            flxViewer.PageAreaBackColor = System.Drawing.Color.FromArgb(231, 231, 231);
            flxViewer.ParamHeaderBackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            flxViewer.ParamHeaderForeColor = System.Drawing.Color.FromArgb(32, 32, 32);
            flxViewer.SplitterColor = System.Drawing.Color.FromArgb(215, 215, 215);
            c1ThemeController.SetTheme(flxViewer, "(default)");
            flxViewer.ThumbAreaBackColor = System.Drawing.Color.FromArgb(231, 231, 231);
            flxViewer.ThumbBackColorHot = System.Drawing.Color.FromArgb(224, 224, 224);
            flxViewer.ThumbBackColorPressed = System.Drawing.SystemColors.ScrollBar;
            flxViewer.ThumbBackColorSelected = System.Drawing.SystemColors.ScrollBar;
            flxViewer.ThumbPageNumBackColor = System.Drawing.Color.White;
            flxViewer.ThumbPageNumForeColor = System.Drawing.Color.Black;
            flxViewer.ZoomMode = C1.Win.FlexViewer.FlexViewerZoomMode.PageWidth;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlPreviewCtl);
            Controls.Add(c1CmdDock);
            KeyPreview = true;
            Name = "MainForm";
            c1ThemeController.SetTheme(this, "(default)");
            FormClosing += Form1_FormClosing;
            ((System.ComponentModel.ISupportInitialize)c1CmdDock).EndInit();
            c1CmdDock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dockTabPagePreview).EndInit();
            dockTabPagePreview.ResumeLayout(false);
            dockTabPageRptList.ResumeLayout(false);
            pnlRpts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)c1TreeView).EndInit();
            pnlTabShowHide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbTabShowHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)c1ThemeController).EndInit();
            pnlPreviewCtl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)flxViewer).EndInit();
            ResumeLayout(false);
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
        private C1.Win.FlexViewer.C1FlexViewer flxViewer;
        private C1.Win.FlexReport.C1FlexReport flxRpt;
    }
}