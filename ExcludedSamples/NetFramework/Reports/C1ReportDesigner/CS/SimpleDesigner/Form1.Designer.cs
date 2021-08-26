using System;
using System.Xml;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using C1.C1Report;

namespace ReportDesignerDemo
{
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : System.Windows.Forms.Form
    {
        private System.ComponentModel.IContainer components;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this._ppg = new System.Windows.Forms.PropertyGrid();
            this._lblPropGrid = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this._list = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this._c1rd = new C1.Win.C1ReportDesigner.C1ReportDesigner();
            this._c1ppv = new C1.Win.C1Preview.C1PrintPreviewControl();
            this._tb = new System.Windows.Forms.ToolBar();
            this._btnDesign = new System.Windows.Forms.ToolBarButton();
            this._btnPreview = new System.Windows.Forms.ToolBarButton();
            this._btnSep = new System.Windows.Forms.ToolBarButton();
            this._btnNew = new System.Windows.Forms.ToolBarButton();
            this._btnOpen = new System.Windows.Forms.ToolBarButton();
            this._btnSave = new System.Windows.Forms.ToolBarButton();
            this._btnSep2 = new System.Windows.Forms.ToolBarButton();
            this._btnAddReport = new System.Windows.Forms.ToolBarButton();
            this._btnDelReport = new System.Windows.Forms.ToolBarButton();
            this._btnAddField = new System.Windows.Forms.ToolBarButton();
            this._btnAddLabel = new System.Windows.Forms.ToolBarButton();
            this._btnSep3 = new System.Windows.Forms.ToolBarButton();
            this._btnCut = new System.Windows.Forms.ToolBarButton();
            this._btnCopy = new System.Windows.Forms.ToolBarButton();
            this._btnPaste = new System.Windows.Forms.ToolBarButton();
            this._btnSep4 = new System.Windows.Forms.ToolBarButton();
            this._btnUndo = new System.Windows.Forms.ToolBarButton();
            this._btnRedo = new System.Windows.Forms.ToolBarButton();
            this._imgList = new System.Windows.Forms.ImageList(this.components);
            this._c1r = new C1.C1Report.C1Report();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._c1ppv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._c1ppv.PreviewPane)).BeginInit();
            this._c1ppv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._c1r)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._ppg);
            this.panel1.Controls.Add(this._lblPropGrid);
            this.panel1.Controls.Add(this.splitter2);
            this.panel1.Controls.Add(this._list);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 493);
            this.panel1.TabIndex = 0;
            // 
            // _ppg
            // 
            this._ppg.Dock = System.Windows.Forms.DockStyle.Fill;
            this._ppg.HelpVisible = false;
            this._ppg.LineColor = System.Drawing.SystemColors.ScrollBar;
            this._ppg.Location = new System.Drawing.Point(0, 165);
            this._ppg.Name = "_ppg";
            this._ppg.Size = new System.Drawing.Size(171, 328);
            this._ppg.TabIndex = 3;
            this._ppg.ToolbarVisible = false;
            this._ppg.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this._ppg_PropertyValueChanged);
            // 
            // _lblPropGrid
            // 
            this._lblPropGrid.BackColor = System.Drawing.SystemColors.Control;
            this._lblPropGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._lblPropGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this._lblPropGrid.ForeColor = System.Drawing.SystemColors.ControlText;
            this._lblPropGrid.Location = new System.Drawing.Point(0, 146);
            this._lblPropGrid.Name = "_lblPropGrid";
            this._lblPropGrid.Size = new System.Drawing.Size(171, 19);
            this._lblPropGrid.TabIndex = 2;
            this._lblPropGrid.Text = "Properties";
            this._lblPropGrid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 139);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(171, 7);
            this.splitter2.TabIndex = 4;
            this.splitter2.TabStop = false;
            // 
            // _list
            // 
            this._list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._list.Dock = System.Windows.Forms.DockStyle.Top;
            this._list.IntegralHeight = false;
            this._list.Location = new System.Drawing.Point(0, 19);
            this._list.Name = "_list";
            this._list.Size = new System.Drawing.Size(171, 120);
            this._list.TabIndex = 1;
            this._list.SelectedIndexChanged += new System.EventHandler(this._list_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reports";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(171, 27);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(6, 493);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._c1rd);
            this.panel2.Controls.Add(this._c1ppv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(177, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(607, 493);
            this.panel2.TabIndex = 2;
            // 
            // _c1rd
            // 
            this._c1rd.BorderStyleSection = System.Windows.Forms.Border3DStyle.RaisedOuter;
            this._c1rd.Dock = System.Windows.Forms.DockStyle.Fill;
            this._c1rd.ForeColorGroup = System.Drawing.SystemColors.Highlight;
            this._c1rd.Location = new System.Drawing.Point(0, 0);
            this._c1rd.Name = "_c1rd";
            this._c1rd.Size = new System.Drawing.Size(607, 493);
            this._c1rd.TabIndex = 1;
            this._c1rd.Text = "c1ReportDesigner1";
            this._c1rd.ZoomFactor = 1F;
            this._c1rd.SelectionChanged += new System.EventHandler(this._c1rd_SelectionChanged);
            this._c1rd.ValuesChanged += new System.EventHandler(this._c1rd_ValuesChanged);
            this._c1rd.CreateField += new C1.Win.C1ReportDesigner.CreateFieldEventHandler(this._c1rd_CreateField);
            // 
            // _c1ppv
            // 
            this._c1ppv.Dock = System.Windows.Forms.DockStyle.Fill;
            this._c1ppv.Location = new System.Drawing.Point(0, 0);
            this._c1ppv.Name = "_c1ppv";
            // 
            // _c1ppv.OutlineView
            // 
            this._c1ppv.PreviewOutlineView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._c1ppv.PreviewOutlineView.Location = new System.Drawing.Point(0, 0);
            this._c1ppv.PreviewOutlineView.Name = "OutlineView";
            this._c1ppv.PreviewOutlineView.Size = new System.Drawing.Size(136, 361);
            this._c1ppv.PreviewOutlineView.TabIndex = 0;
            // 
            // _c1ppv.PreviewPane
            // 
            this._c1ppv.PreviewPane.IntegrateExternalTools = true;
            this._c1ppv.PreviewPane.TabIndex = 0;
            // 
            // _c1ppv.PreviewTextSearchPanel
            // 
            this._c1ppv.PreviewTextSearchPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this._c1ppv.PreviewTextSearchPanel.Location = new System.Drawing.Point(442, 0);
            this._c1ppv.PreviewTextSearchPanel.MinimumSize = new System.Drawing.Size(200, 240);
            this._c1ppv.PreviewTextSearchPanel.Name = "PreviewTextSearchPanel";
            this._c1ppv.PreviewTextSearchPanel.Size = new System.Drawing.Size(200, 393);
            this._c1ppv.PreviewTextSearchPanel.TabIndex = 0;
            this._c1ppv.PreviewTextSearchPanel.Visible = false;
            // 
            // _c1ppv.ThumbnailView
            // 
            this._c1ppv.PreviewThumbnailView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._c1ppv.PreviewThumbnailView.Location = new System.Drawing.Point(0, 0);
            this._c1ppv.PreviewThumbnailView.Name = "ThumbnailView";
            this._c1ppv.PreviewThumbnailView.Size = new System.Drawing.Size(136, 420);
            this._c1ppv.PreviewThumbnailView.TabIndex = 0;
            this._c1ppv.PreviewThumbnailView.UseImageAsThumbnail = false;
            this._c1ppv.Size = new System.Drawing.Size(607, 493);
            this._c1ppv.TabIndex = 2;
            // 
            // 
            // 
            this._c1ppv.ToolBars.Navigation.HistoryNext.Image = ((System.Drawing.Image)(resources.GetObject("_c1ppv.ToolBars.Navigation.HistoryNext.Image")));
            this._c1ppv.ToolBars.Navigation.HistoryNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._c1ppv.ToolBars.Navigation.HistoryNext.Name = "btnHistoryNext";
            this._c1ppv.ToolBars.Navigation.HistoryNext.Size = new System.Drawing.Size(32, 20);
            this._c1ppv.ToolBars.Navigation.HistoryNext.Tag = "C1PreviewActionEnum.HistoryNext";
            this._c1ppv.ToolBars.Navigation.HistoryNext.ToolTipText = "Next View";
            // 
            // 
            // 
            this._c1ppv.ToolBars.Navigation.HistoryPrev.Image = ((System.Drawing.Image)(resources.GetObject("_c1ppv.ToolBars.Navigation.HistoryPrev.Image")));
            this._c1ppv.ToolBars.Navigation.HistoryPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._c1ppv.ToolBars.Navigation.HistoryPrev.Name = "btnHistoryPrev";
            this._c1ppv.ToolBars.Navigation.HistoryPrev.Size = new System.Drawing.Size(32, 20);
            this._c1ppv.ToolBars.Navigation.HistoryPrev.Tag = "C1PreviewActionEnum.HistoryPrev";
            this._c1ppv.ToolBars.Navigation.HistoryPrev.ToolTipText = "Previous View";
            this._c1ppv.ToolBars.Navigation.ToolTipPageNo = null;
            // 
            // 
            // 
            this._c1ppv.ToolBars.Page.Continuous.Checked = true;
            this._c1ppv.ToolBars.Page.Continuous.CheckState = System.Windows.Forms.CheckState.Checked;
            this._c1ppv.ToolBars.Page.Continuous.Image = ((System.Drawing.Image)(resources.GetObject("_c1ppv.ToolBars.Page.Continuous.Image")));
            this._c1ppv.ToolBars.Page.Continuous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._c1ppv.ToolBars.Page.Continuous.Name = "btnPageContinuous";
            this._c1ppv.ToolBars.Page.Continuous.Size = new System.Drawing.Size(23, 22);
            this._c1ppv.ToolBars.Page.Continuous.Tag = "C1PreviewActionEnum.PageContinuous";
            this._c1ppv.ToolBars.Page.Continuous.ToolTipText = "Continuous View";
            // 
            // 
            // 
            this._c1ppv.ToolBars.Page.Facing.Image = ((System.Drawing.Image)(resources.GetObject("_c1ppv.ToolBars.Page.Facing.Image")));
            this._c1ppv.ToolBars.Page.Facing.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._c1ppv.ToolBars.Page.Facing.Name = "btnPageFacing";
            this._c1ppv.ToolBars.Page.Facing.Size = new System.Drawing.Size(23, 22);
            this._c1ppv.ToolBars.Page.Facing.Tag = "C1PreviewActionEnum.PageFacing";
            this._c1ppv.ToolBars.Page.Facing.ToolTipText = "Pages Facing View";
            // 
            // 
            // 
            this._c1ppv.ToolBars.Page.FacingContinuous.Image = ((System.Drawing.Image)(resources.GetObject("_c1ppv.ToolBars.Page.FacingContinuous.Image")));
            this._c1ppv.ToolBars.Page.FacingContinuous.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._c1ppv.ToolBars.Page.FacingContinuous.Name = "btnPageFacingContinuous";
            this._c1ppv.ToolBars.Page.FacingContinuous.Size = new System.Drawing.Size(23, 22);
            this._c1ppv.ToolBars.Page.FacingContinuous.Tag = "C1PreviewActionEnum.PageFacingContinuous";
            this._c1ppv.ToolBars.Page.FacingContinuous.ToolTipText = "Pages Facing Continuous View";
            // 
            // 
            // 
            this._c1ppv.ToolBars.Text.Find.Image = ((System.Drawing.Image)(resources.GetObject("_c1ppv.ToolBars.Text.Find.Image")));
            this._c1ppv.ToolBars.Text.Find.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._c1ppv.ToolBars.Text.Find.Name = "btnFind";
            this._c1ppv.ToolBars.Text.Find.Size = new System.Drawing.Size(23, 20);
            this._c1ppv.ToolBars.Text.Find.Tag = "C1PreviewActionEnum.Find";
            this._c1ppv.ToolBars.Text.Find.ToolTipText = "Find Text";
            // 
            // 
            // 
            this._c1ppv.ToolBars.Text.SelectText.Image = ((System.Drawing.Image)(resources.GetObject("_c1ppv.ToolBars.Text.SelectText.Image")));
            this._c1ppv.ToolBars.Text.SelectText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._c1ppv.ToolBars.Text.SelectText.Name = "btnSelectTextTool";
            this._c1ppv.ToolBars.Text.SelectText.Size = new System.Drawing.Size(23, 20);
            this._c1ppv.ToolBars.Text.SelectText.Tag = "C1PreviewActionEnum.SelectTextTool";
            this._c1ppv.ToolBars.Text.SelectText.ToolTipText = "Text Select Tool";
            this._c1ppv.Visible = false;
            // 
            // _tb
            // 
            this._tb.Appearance = System.Windows.Forms.ToolBarAppearance.Flat;
            this._tb.Buttons.AddRange(new System.Windows.Forms.ToolBarButton[] {
            this._btnDesign,
            this._btnPreview,
            this._btnSep,
            this._btnNew,
            this._btnOpen,
            this._btnSave,
            this._btnSep2,
            this._btnAddReport,
            this._btnDelReport,
            this._btnAddField,
            this._btnAddLabel,
            this._btnSep3,
            this._btnCut,
            this._btnCopy,
            this._btnPaste,
            this._btnSep4,
            this._btnUndo,
            this._btnRedo});
            this._tb.DropDownArrows = true;
            this._tb.ImageList = this._imgList;
            this._tb.Location = new System.Drawing.Point(0, 0);
            this._tb.Name = "_tb";
            this._tb.ShowToolTips = true;
            this._tb.Size = new System.Drawing.Size(784, 27);
            this._tb.TabIndex = 3;
            this._tb.ButtonClick += new System.Windows.Forms.ToolBarButtonClickEventHandler(this._tb_ButtonClick);
            // 
            // _btnDesign
            // 
            this._btnDesign.ImageIndex = 5;
            this._btnDesign.Name = "_btnDesign";
            this._btnDesign.Pushed = true;
            this._btnDesign.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this._btnDesign.ToolTipText = "Design Mode";
            // 
            // _btnPreview
            // 
            this._btnPreview.ImageIndex = 6;
            this._btnPreview.Name = "_btnPreview";
            this._btnPreview.Style = System.Windows.Forms.ToolBarButtonStyle.ToggleButton;
            this._btnPreview.ToolTipText = "Preview Mode";
            // 
            // _btnSep
            // 
            this._btnSep.Name = "_btnSep";
            this._btnSep.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // _btnNew
            // 
            this._btnNew.ImageIndex = 0;
            this._btnNew.Name = "_btnNew";
            this._btnNew.ToolTipText = "New File";
            // 
            // _btnOpen
            // 
            this._btnOpen.ImageIndex = 1;
            this._btnOpen.Name = "_btnOpen";
            this._btnOpen.ToolTipText = "Open File";
            // 
            // _btnSave
            // 
            this._btnSave.ImageIndex = 2;
            this._btnSave.Name = "_btnSave";
            this._btnSave.ToolTipText = "Save File";
            // 
            // _btnSep2
            // 
            this._btnSep2.Name = "_btnSep2";
            this._btnSep2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // _btnAddReport
            // 
            this._btnAddReport.ImageIndex = 12;
            this._btnAddReport.Name = "_btnAddReport";
            this._btnAddReport.ToolTipText = "Add Report";
            // 
            // _btnDelReport
            // 
            this._btnDelReport.ImageIndex = 13;
            this._btnDelReport.Name = "_btnDelReport";
            this._btnDelReport.ToolTipText = "Delete Report";
            // 
            // _btnAddField
            // 
            this._btnAddField.ImageIndex = 14;
            this._btnAddField.Name = "_btnAddField";
            this._btnAddField.ToolTipText = "Add Calculated Field";
            // 
            // _btnAddLabel
            // 
            this._btnAddLabel.ImageIndex = 15;
            this._btnAddLabel.Name = "_btnAddLabel";
            this._btnAddLabel.ToolTipText = "Add Label Field";
            // 
            // _btnSep3
            // 
            this._btnSep3.Name = "_btnSep3";
            this._btnSep3.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // _btnCut
            // 
            this._btnCut.ImageIndex = 11;
            this._btnCut.Name = "_btnCut";
            this._btnCut.ToolTipText = "Cut";
            // 
            // _btnCopy
            // 
            this._btnCopy.ImageIndex = 10;
            this._btnCopy.Name = "_btnCopy";
            this._btnCopy.ToolTipText = "Copy";
            // 
            // _btnPaste
            // 
            this._btnPaste.ImageIndex = 9;
            this._btnPaste.Name = "_btnPaste";
            this._btnPaste.ToolTipText = "Paste";
            // 
            // _btnSep4
            // 
            this._btnSep4.Name = "_btnSep4";
            this._btnSep4.Style = System.Windows.Forms.ToolBarButtonStyle.Separator;
            // 
            // _btnUndo
            // 
            this._btnUndo.ImageIndex = 7;
            this._btnUndo.Name = "_btnUndo";
            this._btnUndo.ToolTipText = "Undo";
            // 
            // _btnRedo
            // 
            this._btnRedo.ImageIndex = 8;
            this._btnRedo.Name = "_btnRedo";
            this._btnRedo.ToolTipText = "Redo";
            // 
            // _imgList
            // 
            this._imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("_imgList.ImageStream")));
            this._imgList.TransparentColor = System.Drawing.Color.Red;
            this._imgList.Images.SetKeyName(0, "");
            this._imgList.Images.SetKeyName(1, "");
            this._imgList.Images.SetKeyName(2, "");
            this._imgList.Images.SetKeyName(3, "");
            this._imgList.Images.SetKeyName(4, "");
            this._imgList.Images.SetKeyName(5, "");
            this._imgList.Images.SetKeyName(6, "");
            this._imgList.Images.SetKeyName(7, "");
            this._imgList.Images.SetKeyName(8, "");
            this._imgList.Images.SetKeyName(9, "");
            this._imgList.Images.SetKeyName(10, "");
            this._imgList.Images.SetKeyName(11, "");
            this._imgList.Images.SetKeyName(12, "");
            this._imgList.Images.SetKeyName(13, "");
            this._imgList.Images.SetKeyName(14, "");
            this._imgList.Images.SetKeyName(15, "");
            // 
            // _c1r
            // 
            this._c1r.ReportDefinition = resources.GetString("_c1r.ReportDefinition");
            this._c1r.ReportName = "c1Report1";
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(784, 520);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._tb);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C1ReportDesigner Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._c1ppv.PreviewPane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._c1ppv)).EndInit();
            this._c1ppv.ResumeLayout(false);
            this._c1ppv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._c1r)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolBar _tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox _list;
        private System.Windows.Forms.PropertyGrid _ppg;
        private System.Windows.Forms.Splitter splitter2;
        private C1.Win.C1ReportDesigner.C1ReportDesigner _c1rd;
        private System.Windows.Forms.ImageList _imgList;
        private System.Windows.Forms.ToolBarButton _btnNew;
        private System.Windows.Forms.ToolBarButton _btnOpen;
        private System.Windows.Forms.ToolBarButton _btnSave;
        private System.Windows.Forms.ToolBarButton _btnSep;
        private System.Windows.Forms.ToolBarButton _btnUndo;
        private System.Windows.Forms.ToolBarButton _btnRedo;
        private System.Windows.Forms.ToolBarButton _btnSep2;
        private System.Windows.Forms.ToolBarButton _btnDesign;
        private System.Windows.Forms.ToolBarButton _btnPreview;
        private System.Windows.Forms.ToolBarButton _btnSep3;
        private System.Windows.Forms.ToolBarButton _btnCopy;
        private System.Windows.Forms.ToolBarButton _btnPaste;
        private System.Windows.Forms.ToolBarButton _btnCut;
        private C1.C1Report.C1Report _c1r;
        private System.Windows.Forms.Label _lblPropGrid;
        private System.Windows.Forms.ToolBarButton _btnAddReport;
        private System.Windows.Forms.ToolBarButton _btnDelReport;
        private System.Windows.Forms.ToolBarButton _btnAddField;
        private System.Windows.Forms.ToolBarButton _btnSep4;
        private System.Windows.Forms.ToolBarButton _btnAddLabel;
        private C1.Win.C1Preview.C1PrintPreviewControl _c1ppv;
    }
}

