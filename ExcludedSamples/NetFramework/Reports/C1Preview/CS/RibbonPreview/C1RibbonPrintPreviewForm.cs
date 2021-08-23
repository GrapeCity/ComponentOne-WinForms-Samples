using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

using C1.Win.C1Preview;
using C1.Win.C1Ribbon;

namespace RibbonPreview
{
    public partial class C1RibbonPrintPreviewForm : C1RibbonForm
    {
        private int _updateCounter;

        public C1RibbonPrintPreviewForm()
        {
            InitializeComponent();
        }

        #region Private
        /// <summary>
        /// TBD:
        /// Should be called before updating form to block all events from child controls.
        /// </summary>
        private void BeginUpdate()
        {
            _updateCounter++;
        }

        /// <summary>
        /// TBD:
        /// Should be called after updating form to enable events from child controls.
        /// </summary>
        private void EndUpdate()
        {
            _updateCounter--;
        }

        private void UpdateUI()
        {
            int zf = (int)(ppMain.ZoomFactor * 100);

            rbtnOpen.Enabled = rbtnOpen2.Enabled = !ppMain.Busy;
            rbtnSave.Enabled = rbtnSave2.Enabled = !ppMain.Busy && ppMain.Document != null;
            rbtnReflow.Enabled = rbtnReflow2.Enabled = !ppMain.Busy && ppMain.Document != null && ppMain.Reflowable;
            rbtnPrint.Enabled = rbtnPrint2.Enabled = !ppMain.Busy && ppMain.Document != null;

            rbtnPageSetup.Enabled =
                rbtnPageSetup2.Enabled = 
                rbtnPageLandscape.Enabled =
                rbtnPagePortrait.Enabled = !ppMain.Busy && ppMain.PageSettings != null && ppMain.Reflowable;
            rbtnPageLandscape.Pressed = ppMain.PageSettings != null && ppMain.PageSettings.Landscape;
            rbtnPagePortrait.Pressed = ppMain.PageSettings != null && !ppMain.PageSettings.Landscape;

            rbtnZoom.Enabled =
                rbtnZoomOnePage.Enabled =
                rbtnZoomTwoPages.Enabled =
                rbtnZoomMorePages.Enabled = !ppMain.Busy;
            rbtnZoomFitToWindow.Pressed = ppMain.ZoomMode == ZoomModeEnum.WholePage;
            rbtnZoom10.Pressed = zf == 10;
            rbtnZoom25.Pressed = zf == 25;
            rbtnZoom50.Pressed = zf == 50;
            rbtnZoom75.Pressed = zf == 75;
            rbtnZoom100.Pressed = zf == 100;
            rbtnZoom150.Pressed = zf == 150;
            rbtnZoom200.Pressed = zf == 200;
            rbtnZoom500.Pressed = zf == 500;
            rbtnZoom1000.Pressed = zf == 1000;
            rbtnZoomOnePage.Pressed = ppMain.Cols == 1 && ppMain.Rows == 1;
            rbtnZoomTwoPages.Pressed = ppMain.Cols == 2 && ppMain.Rows == 1;
            rbtnZoomFourPages.Pressed = ppMain.Cols == 2 && ppMain.Rows == 2;
            rbtnZoomEightPages.Pressed = ppMain.Cols == 4 && ppMain.Rows == 2;
            rbtnZoomTwelvePages.Pressed = ppMain.Cols == 4 && ppMain.Rows == 3;

            rbtnFirstPage.Enabled = rbtnPreviousPage.Enabled = ppMain.StartPageIdx > 0;
            rbtnLastPage.Enabled = rbtnNextPage.Enabled = ppMain.StartPageIdx < ppMain.Pages.Count - 1;
            rebPageNo.Text = (ppMain.StartPageIdx + 1).ToString();
            rebPageNo.Enabled = ppMain.Pages.Count > 0;
            rlblPageCount.Text = ppMain.Pages.Count.ToString();

            rbtnHistoryBack.Enabled = !ppMain.Busy && ppMain.CurrentHistoryEntryIndex > 0;
            rbtnHistoryNext.Enabled = !ppMain.Busy && ppMain.CurrentHistoryEntryIndex < ppMain.ViewHistory.Count - 1;

            rbtnHandTool.Pressed = ppMain.MouseMode == MouseModeEnum.Hand;
            rbtnTextSelectTool.Pressed = ppMain.MouseMode == MouseModeEnum.Select;

            rbtnViewSinglePage.Enabled =
                rbtnViewContinuous.Enabled =
                rbtnViewPagesFacing.Enabled =
                rbtnViewPagesFacingContinuous.Enabled = !ppMain.Busy;
            rbtnViewSinglePage.Pressed = !ppMain.Continuous && ppMain.PageLayout == PageLayoutEnum.Normal;
            rbtnViewContinuous.Pressed = ppMain.Continuous && ppMain.PageLayout == PageLayoutEnum.Normal;
            rbtnViewPagesFacing.Pressed = !ppMain.Continuous && ppMain.PageLayout == PageLayoutEnum.Facing;
            rbtnViewPagesFacingContinuous.Pressed = ppMain.Continuous && ppMain.PageLayout == PageLayoutEnum.Facing;
            rlblZoom.Text = string.Format("{0}%", zf);
            rtbZoom.Value = zf;
            rtbZoom.Minimum = (int)(ppMain.MinZoomFactor * 100);
            rtbZoom.Maximum = (int)(ppMain.MaxZoomFactor * 100);
        }

        /// <summary>
        /// TBD:
        /// Called from rbnMain_RibbonEvent(...) and handling RibbonEventType.Click events from rbnMain.
        /// </summary>
        /// <param name="item">RibbonItem that was clicked.</param>
        private void RibbonClick(RibbonItem item)
        {
            if (item == rbtnSave || item == rbtnSave2)
                ppMain.FileSave();
            if (item == rbtnOpen || item == rbtnOpen2)
                ppMain.FileOpen();
            else if (item == rbtnPrint || item == rbtnPrint2)
                ppMain.Print();
            else if (item == rbtnReflow)
                ppMain.Reflow();
            else if (item == rbtnPagePortrait)
            {
                if (ppMain.PageSettings != null)
                {
                    PageSettings ps = (PageSettings)ppMain.PageSettings.Clone();
                    ps.Landscape = false;
                    ppMain.PageSettings = ps;
                }
            }
            else if (item == rbtnPageLandscape)
            {
                if (ppMain.PageSettings != null)
                {
                    PageSettings ps = (PageSettings)ppMain.PageSettings.Clone();
                    ps.Landscape = true;
                    ppMain.PageSettings = ps;
                }
            }
            else if (item == rbtnPageSetup || item == rbtnPageSetup2)
                ppMain.PageSetup();
            else if (item == rbtnZoomFitToWindow)
                ppMain.ZoomMode = ZoomModeEnum.WholePage;
            else if (item.Parent as RibbonMenu == rbtnZoom)
            {
                string s = item.Tag as string;
                if (s != null)
                {
                    int v;
                    if (int.TryParse(s, out v))
                        ppMain.ZoomFactor = v / 100.0;
                }
            }
            else if (item == rbtnZoomOnePage)
                using (new C1PreviewPane.LayoutSection(ppMain, HistorySavedActionsEnum.All))
                {
                    ppMain.Continuous = true;
                    ppMain.PageLayout = C1.Win.C1Preview.PageLayoutEnum.Normal;
                    ppMain.Cols = 1;
                    ppMain.Rows = 1;
                    ppMain.ZoomMode = ZoomModeEnum.WholePage;
                }
            else if (item == rbtnZoomTwoPages ||
                    item == rbtnZoomFourPages ||
                    item == rbtnZoomEightPages ||
                    item == rbtnZoomTwelvePages)
            {
                string s = item.Tag as string;
                if (s != null)
                {
                    string[] cr = s.Split(',');
                    if (cr.Length == 2)
                    {
                        int c, r;
                        if (int.TryParse(cr[0], out r) && int.TryParse(cr[1], out c))
                        {
                            using (new C1PreviewPane.LayoutSection(ppMain, HistorySavedActionsEnum.All))
                            {
                                ppMain.Continuous = true;
                                ppMain.PageLayout = C1.Win.C1Preview.PageLayoutEnum.Custom;
                                ppMain.Cols = c;
                                ppMain.Rows = r;
                            }
                        }
                    }
                }
            }
            if (item == rbtnHistoryBack)
                ppMain.HistoryBack();
            else if (item == rbtnHistoryNext)
                ppMain.HistoryForward();
            else if (item == rbtnFirstPage)
                ppMain.StartPageIdx = 0;
            else if (item == rbtnPreviousPage)
                ppMain.StartPageIdx--;
            else if (item == rbtnNextPage)
                ppMain.StartPageIdx++;
            else if (item == rbtnLastPage)
                ppMain.StartPageIdx = ppMain.Pages.Count - 1;
            if (item == rbtnHandTool)
                ppMain.MouseMode = MouseModeEnum.Hand;
            else if (item == rbtnTextSelectTool)
                ppMain.MouseMode = MouseModeEnum.Select;
            else if (item == rbtnOutline)
            {
                dtpOutline.Show();
                ActiveControl = povMain;
            }
            else if (item == rbtnPages)
            {
                dtpPages.Show();
                ActiveControl = ptvMain;
            }
            else if (item == rbtnSearch)
            {
                dtpSearch.Show();
                ActiveControl = ptspMain.Controls[0].Controls[2];
            }
            else if (item.Parent as RibbonItem == rbtnHistoryBack || item.Parent as RibbonItem == rbtnHistoryNext)
            {
                ViewHistoryItem vhi = item.Tag as ViewHistoryItem;
                if (vhi != null)
                    ppMain.CurrentHistoryEntry = vhi;
            }
        }

        void rb_Click(object sender, EventArgs e)
        {
            ppMain.FileSave(null, ((RibbonButton)sender).Tag as C1.C1Preview.Export.ExportProvider);
        }

        /// <summary>
        /// TBD:
        /// Called from rbnMain_RibbonEvent(...) and handling RibbonEventType.DropDown events from rbnMain.
        /// </summary>
        /// <param name="item">RibbonItem that was droppeddown.</param>
        private void RibbonDropDown(RibbonItem item)
        {
            if (item == rbtnHistoryBack)
            {
                rbtnHistoryBack.Items.Clear();
                for (int i = ppMain.CurrentHistoryEntryIndex - 1, j = 0;
                            i >= 0 && j < 10;
                            i--, j++)
                {
                    ViewHistoryItem vhi = ppMain.ViewHistory[i];
                    RibbonButton btn = new RibbonButton(vhi.Caption);
                    btn.Tag = vhi;
                    rbtnHistoryBack.Items.Add(btn);
                }
            }
            else if (item == rbtnHistoryNext)
            {
                rbtnHistoryNext.Items.Clear();
                for (int i = ppMain.CurrentHistoryEntryIndex + 1, j = 0;
                            i < ppMain.ViewHistory.Count && j < 10;
                            i++, j++)
                {
                    ViewHistoryItem vhi = ppMain.ViewHistory[i];
                    RibbonButton btn = new RibbonButton(vhi.Caption);
                    btn.Tag = vhi;
                    rbtnHistoryNext.Items.Add(btn);
                }
            }
            else if (item == rbtnSave)
            {
                rbtnSave.Items.Clear();
                foreach (C1.C1Preview.Export.ExportProvider ep in C1.C1Preview.Export.ExportProviders.RegisteredProviders)
                {
                    if (ep.CanExportObject(Document))
                    {
                        RibbonButton rb = new RibbonButton();
                        rb.Text = ep.FormatName;
                        rb.Tag = ep;
                        rb.Click += new EventHandler(rb_Click);
                        rbtnSave.Items.Add(rb);
                    }
                }
            }
        }

        /// <summary>
        /// TBD:
        /// Called from rbnMain_RibbonEvent(...) and handling RibbonEventType.ChangeCommitted events from rbnMain.
        /// </summary>
        /// <param name="item">RibbonItem value of that was committed.</param>
        private void RibbonChangeCommitted(RibbonItem item)
        {
            if (item == rebPageNo)
            {
                int v;
                if (int.TryParse(rebPageNo.Text, out v))
                    ppMain.StartPageIdx = v - 1;
            }
        }
        #endregion

        #region Private properties
        /// <summary>
        /// TBD:
        /// Gets a value indicating whether the state of the form is updating and
        /// all events from child controls should be ignored.
        /// </summary>
        private bool Updating
        {
            get { return _updateCounter != 0; }
        }
        #endregion

        #region Public properties
        /// <summary>
        /// Gets or sets the document shown by the preview.
        /// </summary>
        [Browsable(false)]
        public object Document
        {
            get { return ppMain.Document; }
            set { ppMain.Document = value; }
        }
        #endregion

        private void rbnMain_RibbonEvent(object sender, RibbonEventArgs e)
        {
            if (Updating)
                return;

            switch (e.EventType)
            {
                case RibbonEventType.Click:
                    RibbonClick(e.Item as RibbonItem);
                    break;
                case RibbonEventType.ChangeCommitted:
                    RibbonChangeCommitted(e.Item as RibbonItem);
                    break;
                case RibbonEventType.DropDown:
                    RibbonDropDown(e.Item as RibbonItem);
                    break;
            }
        }

        private void ppMain_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            BeginUpdate();
            try
            {
                switch (e.PropertyName)
                {
                    case "Busy":
                    case "MinZoomFactor":
                    case "MaxZoomFactor":
                    case "ZoomFactor":
                    case "ZoomMode":
                    case "Cols":
                    case "Rows":
                    case "StartPageIdx":
                    case "PreviewScrollPosition":
                    case "PageLayout":
                    case "Continuous":
                    case "CurrentHistoryEntry":
                    case "MouseMode":
                    case "ShowRulers":
                    case "HideMargins":
                    case "HideMarginsState":
                        UpdateUI();
                        break;
                }
            }
            finally
            {
                EndUpdate();
            }
        }

        private void rbtnViewSinglePage_Click(object sender, EventArgs e)
        {
            using (new C1PreviewPane.LayoutSection(ppMain, HistorySavedActionsEnum.All))
            {
                if (sender as RibbonToggleButton == rbtnViewSinglePage)
                {
                    ppMain.Continuous = false;
                    ppMain.PageLayout = C1.Win.C1Preview.PageLayoutEnum.Normal;
                }
                else if (sender as RibbonToggleButton == rbtnViewContinuous)
                {
                    ppMain.Continuous = true;
                    ppMain.PageLayout = C1.Win.C1Preview.PageLayoutEnum.Normal;
                }
                else if (sender as RibbonToggleButton == rbtnViewPagesFacing)
                {
                    ppMain.Continuous = false;
                    ppMain.PageLayout = C1.Win.C1Preview.PageLayoutEnum.Facing;
                }
                else if (sender as RibbonToggleButton == rbtnViewPagesFacingContinuous)
                {
                    ppMain.Continuous = true;
                    ppMain.PageLayout = C1.Win.C1Preview.PageLayoutEnum.Facing;
                }
            }
        }

        private void rtbZoom_Scroll(object sender, EventArgs e)
        {
            if (Updating)
                return;
            ppMain.ZoomFactor = rtbZoom.Value / 100.0;
        }

        private void RecentFileClick(object sender, EventArgs e)
        {
            int i = (int)((RibbonListItem)sender).Tag;
            if (i >= 0 && i < ppMain.VisitedDocuments.Count)
                ppMain.CurrentVisitedDocument = ppMain.VisitedDocuments[i];
        }

        private void ramMain_DropDown(object sender, EventArgs e)
        {
            for (int i = ramMain.RightPaneItems.Count - 1; i > 1; i--)
            {
                RibbonItem ri = ramMain.RightPaneItems[i];
                ramMain.RightPaneItems.RemoveAt(i);
                ri.Dispose();
            }

            for (int i = 0; i < ppMain.VisitedDocuments.Count; i++)
            {
                RibbonListItem rli = new RibbonListItem();
                rli.Click += RecentFileClick;
                rli.Tag = i;
                RibbonButton rb = new RibbonButton();
                if (i < 9)
                    rb.Text = string.Format("&{0}  {1}", i + 1, ppMain.VisitedDocuments[i].DocumentCaption);
                else
                    rb.Text = string.Format("   {0}", ppMain.VisitedDocuments[i].DocumentCaption);
                rli.Items.Add(rb);
                ramMain.RightPaneItems.Add(rli);
            }
        }

        private void C1RibbonPrintPreviewForm_Load(object sender, EventArgs e)
        {
            dtpPages.Show();
            ppMain.Focus();
        }
    }
}