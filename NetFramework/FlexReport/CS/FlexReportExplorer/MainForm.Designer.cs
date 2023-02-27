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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            C1.Win.C1Tile.PanelElement panelElement9 = new C1.Win.C1Tile.PanelElement();
            C1.Win.C1Tile.ImageElement imageElement8 = new C1.Win.C1Tile.ImageElement();
            C1.Win.C1Tile.TextElement textElement5 = new C1.Win.C1Tile.TextElement();
            C1.Win.C1Tile.ImageElement imageElement9 = new C1.Win.C1Tile.ImageElement();
            C1.Win.C1Tile.PanelElement panelElement10 = new C1.Win.C1Tile.PanelElement();
            C1.Win.C1Tile.PanelElement panelElement11 = new C1.Win.C1Tile.PanelElement();
            C1.Win.C1Tile.PanelElement panelElement12 = new C1.Win.C1Tile.PanelElement();
            C1.Win.C1Tile.ImageElement imageElement10 = new C1.Win.C1Tile.ImageElement();
            C1.Win.C1Tile.TextElement textElement6 = new C1.Win.C1Tile.TextElement();
            C1.Win.C1Tile.PanelElement panelElement13 = new C1.Win.C1Tile.PanelElement();
            C1.Win.C1Tile.PanelElement panelElement14 = new C1.Win.C1Tile.PanelElement();
            C1.Win.C1Tile.PanelElement panelElement15 = new C1.Win.C1Tile.PanelElement();
            C1.Win.C1Tile.ImageElement imageElement11 = new C1.Win.C1Tile.ImageElement();
            C1.Win.C1Tile.TextElement textElement7 = new C1.Win.C1Tile.TextElement();
            C1.Win.C1Tile.PanelElement panelElement16 = new C1.Win.C1Tile.PanelElement();
            C1.Win.C1Tile.ImageElement imageElement12 = new C1.Win.C1Tile.ImageElement();
            C1.Win.C1Tile.TextElement textElement8 = new C1.Win.C1Tile.TextElement();
            C1.Win.C1Tile.ImageElement imageElement13 = new C1.Win.C1Tile.ImageElement();
            C1.Win.C1Tile.ImageElement imageElement14 = new C1.Win.C1Tile.ImageElement();
            this.c1CmdDock = new C1.Win.C1Command.C1CommandDock();
            this.dockTabPagePreview = new C1.Win.C1Command.C1DockingTab();
            this.dockTabPageRptList = new C1.Win.C1Command.C1DockingTabPage();
            this.pnlRpts = new System.Windows.Forms.Panel();
            this.c1tileCntrl = new C1.Win.C1Tile.C1TileControl();
            this.tileGrp = new C1.Win.C1Tile.Group();
            this._reportDefaultTemplate = new C1.Win.C1Tile.Template();
            this._reportSelectedTemplate = new C1.Win.C1Tile.Template();
            this._tileSelectedTemplate = new C1.Win.C1Tile.Template();
            this._tileLineTemplate = new C1.Win.C1Tile.Template();
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
            this.dockTabPagePreview.CloseBox = C1.Win.C1Command.CloseBoxPositionEnum.ActivePage;
            this.dockTabPagePreview.Controls.Add(this.dockTabPageRptList);
            resources.ApplyResources(this.dockTabPagePreview, "dockTabPagePreview");
            this.dockTabPagePreview.Name = "dockTabPagePreview";
            this.dockTabPagePreview.ShowSingleTab = false;
            this.dockTabPagePreview.TabLook = C1.Win.C1Command.ButtonLookFlags.Text;
            this.dockTabPagePreview.TabsCanFocus = false;
            this.dockTabPagePreview.TabSizeMode = C1.Win.C1Command.TabSizeModeEnum.Fit;
            this.dockTabPagePreview.TabsShowFocusCues = false;
            this.dockTabPagePreview.TabsSpacing = 5;
            this.dockTabPagePreview.TabStyle = C1.Win.C1Command.TabStyleEnum.Office2007;
            this.dockTabPagePreview.VisualStyle = C1.Win.C1Command.VisualStyle.Office2007Blue;
            this.dockTabPagePreview.VisualStyleBase = C1.Win.C1Command.VisualStyle.Office2007Blue;
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
            // pnlRpts
            // 
            resources.ApplyResources(this.pnlRpts, "pnlRpts");
            this.pnlRpts.BackColor = System.Drawing.Color.Transparent;
            this.pnlRpts.Controls.Add(this.c1tileCntrl);
            this.pnlRpts.Name = "pnlRpts";
            // 
            // c1tileCntrl
            // 
            this.c1tileCntrl.BackColor = System.Drawing.Color.White;
            this.c1tileCntrl.CausesValidation = false;
            resources.ApplyResources(this.c1tileCntrl, "c1tileCntrl");
            this.c1tileCntrl.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            panelElement9.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            imageElement8.Alignment = System.Drawing.ContentAlignment.TopLeft;
            imageElement8.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft;
            imageElement8.FixedHeight = 50;
            imageElement8.FixedWidth = 30;
            resources.ApplyResources(imageElement8, "imageElement8");
            resources.ApplyResources(textElement5, "textElement5");
            panelElement9.Children.Add(imageElement8);
            panelElement9.Children.Add(textElement5);
            panelElement9.Dock = System.Windows.Forms.DockStyle.Fill;
            resources.ApplyResources(panelElement9, "panelElement9");
            imageElement9.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            imageElement9.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleCenter;
            imageElement9.FixedHeight = 20;
            imageElement9.FixedWidth = 20;
            imageElement9.ImageSelector = C1.Win.C1Tile.ImageSelector.Image1;
            resources.ApplyResources(imageElement9, "imageElement9");
            this.c1tileCntrl.DefaultTemplate.Elements.Add(panelElement9);
            this.c1tileCntrl.DefaultTemplate.Elements.Add(imageElement9);
            this.c1tileCntrl.ForeColor = System.Drawing.Color.Gray;
            this.c1tileCntrl.Groups.Add(this.tileGrp);
            this.c1tileCntrl.Name = "c1tileCntrl";
            this.c1tileCntrl.Orientation = C1.Win.C1Tile.LayoutOrientation.Vertical;
            this.c1tileCntrl.Templates.Add(this._reportDefaultTemplate);
            this.c1tileCntrl.Templates.Add(this._reportSelectedTemplate);
            this.c1tileCntrl.Templates.Add(this._tileSelectedTemplate);
            this.c1tileCntrl.Templates.Add(this._tileLineTemplate);
            this.c1tileCntrl.UncheckTilesOnClick = false;
            this.c1tileCntrl.MouseLeave += new System.EventHandler(this.TileControl_MouseLeave);
            this.c1tileCntrl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TileControl_MouseMove);
            // 
            // tileGrp
            // 
            this.tileGrp.Name = "tileGrp";
            // 
            // _reportDefaultTemplate
            // 
            resources.ApplyResources(this._reportDefaultTemplate, "_reportDefaultTemplate");
            this._reportDefaultTemplate.BackColorSelector = C1.Win.C1Tile.BackColorSelector.Unbound;
            this._reportDefaultTemplate.DefaultVerticalSize = 5;
            this._reportDefaultTemplate.Description = "Report tiles";
            resources.ApplyResources(panelElement10, "panelElement10");
            panelElement11.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft;
            resources.ApplyResources(panelElement11, "panelElement11");
            resources.ApplyResources(panelElement12, "panelElement12");
            imageElement10.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft;
            imageElement10.ImageLayout = C1.Win.C1Tile.ForeImageLayout.ScaleInner;
            panelElement12.Children.Add(imageElement10);
            panelElement12.Description = "Page image fill.";
            panelElement12.FixedHeight = 100;
            panelElement12.FixedWidth = 100;
            textElement6.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            resources.ApplyResources(textElement6, "textElement6");
            textElement6.BackColorSelector = C1.Win.C1Tile.BackColorSelector.Unbound;
            panelElement11.Children.Add(panelElement12);
            panelElement11.Children.Add(textElement6);
            panelElement11.Dock = System.Windows.Forms.DockStyle.Fill;
            panelElement10.Children.Add(panelElement11);
            panelElement10.Description = "Border around tile";
            panelElement10.Dock = System.Windows.Forms.DockStyle.Fill;
            this._reportDefaultTemplate.Elements.Add(panelElement10);
            this._reportDefaultTemplate.Name = "_reportDefaultTemplate";
            // 
            // _reportSelectedTemplate
            // 
            resources.ApplyResources(this._reportSelectedTemplate, "_reportSelectedTemplate");
            this._reportSelectedTemplate.BackColorSelector = C1.Win.C1Tile.BackColorSelector.Unbound;
            this._reportSelectedTemplate.DefaultVerticalSize = 5;
            this._reportSelectedTemplate.Description = "New Template";
            resources.ApplyResources(panelElement13, "panelElement13");
            panelElement14.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft;
            resources.ApplyResources(panelElement14, "panelElement14");
            resources.ApplyResources(panelElement15, "panelElement15");
            imageElement11.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft;
            imageElement11.ImageLayout = C1.Win.C1Tile.ForeImageLayout.ScaleInner;
            panelElement15.Children.Add(imageElement11);
            panelElement15.Description = "Page image fill.";
            panelElement15.FixedHeight = 100;
            panelElement15.FixedWidth = 100;
            textElement7.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            resources.ApplyResources(textElement7, "textElement7");
            textElement7.BackColorSelector = C1.Win.C1Tile.BackColorSelector.Unbound;
            panelElement14.Children.Add(panelElement15);
            panelElement14.Children.Add(textElement7);
            panelElement14.Dock = System.Windows.Forms.DockStyle.Fill;
            panelElement13.Children.Add(panelElement14);
            panelElement13.Dock = System.Windows.Forms.DockStyle.Fill;
            this._reportSelectedTemplate.Elements.Add(panelElement13);
            this._reportSelectedTemplate.Name = "_reportSelectedTemplate";
            // 
            // _tileSelectedTemplate
            // 
            this._tileSelectedTemplate.Description = "Selected category";
            resources.ApplyResources(panelElement16, "panelElement16");
            imageElement12.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft;
            imageElement12.FixedHeight = 50;
            imageElement12.FixedWidth = 30;
            resources.ApplyResources(imageElement12, "imageElement12");
            textElement8.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            textElement8.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleLeft;
            textElement8.BackColorSelector = C1.Win.C1Tile.BackColorSelector.Unbound;
            resources.ApplyResources(textElement8, "textElement8");
            panelElement16.Children.Add(imageElement12);
            panelElement16.Children.Add(textElement8);
            panelElement16.Dock = System.Windows.Forms.DockStyle.Fill;
            imageElement13.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            imageElement13.AlignmentOfContents = System.Drawing.ContentAlignment.MiddleCenter;
            imageElement13.FixedHeight = 20;
            imageElement13.FixedWidth = 20;
            imageElement13.ImageSelector = C1.Win.C1Tile.ImageSelector.Image1;
            resources.ApplyResources(imageElement13, "imageElement13");
            this._tileSelectedTemplate.Elements.Add(panelElement16);
            this._tileSelectedTemplate.Elements.Add(imageElement13);
            this._tileSelectedTemplate.Name = "_tileSelectedTemplate";
            // 
            // _tileLineTemplate
            // 
            resources.ApplyResources(this._tileLineTemplate, "_tileLineTemplate");
            this._tileLineTemplate.Description = "Separator";
            imageElement14.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            imageElement14.FixedHeight = 5;
            imageElement14.FixedWidth = 202;
            imageElement14.Image = ((System.Drawing.Image)(resources.GetObject("imageElement14.Image")));
            imageElement14.ImageLayout = C1.Win.C1Tile.ForeImageLayout.Stretch;
            imageElement14.ImageSelector = C1.Win.C1Tile.ImageSelector.Unbound;
            this._tileLineTemplate.Elements.Add(imageElement14);
            this._tileLineTemplate.Enabled = false;
            this._tileLineTemplate.Name = "_tileLineTemplate";
            // 
            // pnlTabShowHide
            // 
            this.pnlTabShowHide.Controls.Add(this.pbTabShowHide);
            resources.ApplyResources(this.pnlTabShowHide, "pnlTabShowHide");
            this.pnlTabShowHide.Name = "pnlTabShowHide";
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
            // 
            // flxViewer
            // 
            resources.ApplyResources(this.flxViewer, "flxViewer");
            this.flxViewer.Name = "flxViewer";
            this.flxViewer.ZoomMode = C1.Win.FlexViewer.FlexViewerZoomMode.PageWidth;
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
            ((System.ComponentModel.ISupportInitialize)(this.pbTabShowHide)).EndInit();
            this.pnlPreviewCtl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flxViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Command.C1CommandDock c1CmdDock;
        private C1.Win.C1Command.C1DockingTab dockTabPagePreview;
        private C1.Win.C1Command.C1DockingTabPage dockTabPageRptList;
        private System.Windows.Forms.Panel pnlRpts;
        private C1.Win.C1Tile.C1TileControl c1tileCntrl;
        private C1.Win.C1Tile.Group tileGrp;     
        private C1.Win.C1Tile.Template _reportDefaultTemplate;
        private System.Windows.Forms.Panel pnlTabShowHide;
        private System.Windows.Forms.PictureBox pbTabShowHide;
        private C1.Win.C1Tile.Template _tileSelectedTemplate;
        private Panel pnlPreviewCtl;
        private C1.Win.FlexViewer.C1FlexViewer flxViewer;
        private C1.Win.FlexReport.C1FlexReport flxRpt;
        private C1.Win.C1Tile.Template _tileLineTemplate;
        private C1.Win.C1Tile.Template _reportSelectedTemplate;
    }
}