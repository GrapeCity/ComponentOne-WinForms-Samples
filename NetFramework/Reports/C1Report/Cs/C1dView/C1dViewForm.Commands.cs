/*
 * This file is part of C1Report's C1dView sample.
 * 
 * This file contains most of UI handling code for C1dViewForm.
 * 
 * Copyright GrapeCity, Inc.
 */
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

using C1.C1Preview;
using C1.C1Report;
using C1.Win.C1Preview;
using C1.Win.C1Ribbon;
using C1.Win.C1Command;

namespace C1dView
{
    public partial class C1dViewForm
    {
        #region Helper objects
        /// <summary>
        /// Provides zoom scale with 100% in the middle:
        /// </summary>
        protected ZoomSliderScale ZoomSliderScale { get; set; }
        #endregion

        /// <summary>
        /// Wires up user commands controlling the preview (file operations, zoom and so on),
        /// and performs a few other initialization actions.
        /// </summary>
        /// <remarks>
        /// Most user actions are wired up via C1Command "commands" (components of type C1.Win.C1Command.C1Command),
        /// in the following manner:
        /// <para>
        /// The C1CommandHolder contains the list of all supported commands, such as 'open',
        /// 'save', 'zoom in' and so on, with self-explanatory names (e.g. cmdFileOpen).
        /// Most commands perform a single action without any parameters.
        /// The few that do perform parameterized actions use C1Command.UserData property
        /// to accept the parameters. For instance cmdFileOpen command optionally accepts
        /// a fileName/reportName pair.
        /// </para>
        /// <para>
        /// For each ribbon button, its Click event is bound to the appropriate command's PerformClick method.
        /// The actual action is then bound to the command's Click event.
        /// On most commands, two other events are also bound:
        /// - CommandStateQuery updates the command's enabled state;
        /// - EnabledChanged (invoked only when the enabled state of the command actually changes)
        /// updates the button's enabled state. This event is not bound for commands that do not
        /// have associated buttons (e.g. cmdZoomIn/cmdZoomOut are only bound to keys).
        /// </para>
        /// <para>
        /// Some buttons (such as 'portrait orientation') have a pressed state, which reflects the current
        /// state of the preview. The pressed state of buttons is updated by the PreviewPane.PropertyChanged
        /// event handler, which minimizes overhead.
        /// </para>
        /// </remarks>
        protected void InitPreviewCommands()
        {
            // Hide the search tab in the left tab control (it is not used, and is here only for
            // backwards compatibility - FindHelper and status bar search controls are used instead):
            this.dtpSearch.TabVisible = false;
            this.ptspMain.Visible = false;

            // Ensure command holder uses ribbon's visual style:
            C1.Win.C1Command.VisualStyle vs;
            if (Enum.TryParse<C1.Win.C1Command.VisualStyle>(this.rbnMain.VisualStyle.ToString(), true, out vs))
                this._cmdHolder.VisualStyle = vs;


            this.ZoomSliderScale = new ZoomSliderScale(
                PreviewPane.MinZoomFactor,
                PreviewPane.MaxZoomFactor,
                (int)(PreviewPane.MinZoomFactor * 100),
                (int)(PreviewPane.MaxZoomFactor * 100));
            this.rtbZoom.TickFrequency = ZoomSliderScale.SliderValue(1);

            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(C1RibbonPrintPreviewForm_KeyDown);

            this.rbnProgress.Visible = false;
            this.PreviewPane.LongOperation += new C1.C1Preview.LongOperationEventHandler(PreviewPane_LongOperation);
            this.PreviewPane.PropertyChanged += new PropertyChangedEventHandler(PreviewPane_PropertyChanged);

            // connect toolbar buttons to commands:
            this.rbtnAbout.Click += (s, e) => this.cmdAbout.PerformClick();
            this.rbtnOpen.Click += (s, e) => this.cmdFileOpen.PerformClick();
            this.rbtnOpen2.Click += (s, e) => this.cmdFileOpen.PerformClick();
            this.rbtnSave.Click += (s, e) => this.cmdFileSave.PerformClick();
            this.rbtnSave2.Click += (s, e) => this.cmdFileSave.PerformClick();
            this.rbtnClose2.Click += (s, e) => this.cmdFileClose.PerformClick();
            this.rbtnNew2.Click += (s, e) => this.cmdFileNew.PerformClick();
            this.rbtnExit.Click += (s, e) => this.cmdExit.PerformClick();
            this.rbtnPrint.Click += (s, e) => this.cmdPrint.PerformClick();
            this.rbtnPrint2.Click += (s, e) => this.cmdPrint.PerformClick();
            this.rbtnRefresh.Click += (s, e) => this.cmdRefresh.PerformClick();
            this.rbtnPageSetup.Click += (s, e) => this.cmdPageSetup.PerformClick();
            this.rbtnPageSetup2.Click += (s, e) => this.cmdPageSetup.PerformClick();
            this.rbtnPageLandscape.Click += (s, e) => this.cmdPageLandscape.PerformClick();
            this.rbtnPagePortrait.Click += (s, e) => this.cmdPagePortrait.PerformClick();
            this.rbtnZoom100.Click += (s, e) => this.cmdZoom100.PerformClick();
            this.rbtnZoomFitPage.Click += (s, e) => cmdZoomFitPage.PerformClick();
            this.rbtnZoomFitWidth.Click += (s, e) => cmdZoomFitWidth.PerformClick();

            this.rbtnFirstPage.Click += (s, e) => this.cmdGoFirst.PerformClick();
            this.rbtnLastPage.Click += (s, e) => this.cmdGoLast.PerformClick();
            this.rbtnPreviousPage.Click += (s, e) => this.cmdGoPrev.PerformClick();
            this.rbtnNextPage.Click += (s, e) => this.cmdGoNext.PerformClick();

            this.rbtnHistoryBack.Click += (s, e) => this.cmdHistoryPrev.PerformClick();
            this.rbtnHistoryNext.Click += (s, e) => this.cmdHistoryNext.PerformClick();

            this.rbtnHandTool.Click += (s, e) => this.cmdMouseModeHand.PerformClick();
            this.rbtnTextSelectTool.Click += (s, e) => this.cmdMouseModeSelect.PerformClick();
            this.rbtnZoomInTool.Click += (s, e) => this.cmdMouseModeZoomIn.PerformClick();
            this.rbtnZoomOutTool.Click += (s, e) => this.cmdMouseModeZoomOut.PerformClick();

            this.rbtnViewSinglePage.Click += (s, e) => this.cmdPageViewSingle.PerformClick();
            this.rbtnViewContinuous.Click += (s, e) => this.cmdPageViewContinuous.PerformClick();
            this.rbtnViewPagesFacing.Click += (s, e) => this.cmdPageViewTwoUp.PerformClick();
            this.rbtnViewPagesFacingContinuous.Click += (s, e) => this.cmdPageViewTwoUpContinuous.PerformClick();

            this.rbtnFind.Click += (s, e) => this.cmdFind.PerformClick();
            this.rbtnFindAgain.Click += (s, e) => this.cmdFindNext.PerformClick();

            this.rgZoom.DialogLauncherClick += (s, e) => this.cmdZoomDialog.PerformClick();
            this.rbtnZoom.Click += (s, e) => this.cmdZoomDialog.PerformClick();

            // commands:
#if C1DVIEW_APP
            this.cmdAbout.Click += (s, e) => (new AboutForm()).ShowDialog(this);
            // this.cmdHelp.Click += (s, e) => (new AboutForm()).ShowDialog(this);
#endif

            this.cmdFileOpen.CommandStateQuery += (s, e) => e.Enabled = !PreviewPane.Busy;
            this.cmdFileOpen.EnabledChanged += (s, e) => this.rbtnOpen.Enabled = this.rbtnOpen2.Enabled = ((C1Command)s).Enabled;
            this.cmdFileOpen.Click += (s, e) => { FileOpen((C1Command)s); PreviewPane.Focus(); };

            this.cmdFileSave.CommandStateQuery += (s, e) => e.Enabled = !PreviewPane.Busy && PreviewPane.Document != null;
            this.cmdFileSave.EnabledChanged += (s, e) => this.rbtnSave.Enabled = this.rbtnSave2.Enabled = ((C1Command)s).Enabled;
            this.cmdFileSave.Click += (s, e) => PreviewPane.FileSave();

            this.cmdFileClose.CommandStateQuery += (s, e) => e.Enabled = !PreviewPane.Busy && (s_openWindows.Count > 1 || PreviewPane.Document != null);
            this.cmdFileClose.EnabledChanged += (s, e) => rbtnClose2.Enabled = ((C1Command)s).Enabled;
            this.cmdFileClose.Click += (s, e) => FileClose();

            this.cmdFileNew.CommandStateQuery += (s, e) => e.Enabled = true;
            this.cmdFileNew.EnabledChanged += (s, e) => rbtnNew2.Enabled = ((C1Command)s).Enabled;
            this.cmdFileNew.Click += (s, e) => FileNew(null);

            this.cmdExit.Click += (s, e) => FileExit();

            this.cmdPrint.CommandStateQuery += (s, e) => e.Enabled = !PreviewPane.Busy && (s_openWindows.Count > 1 || PreviewPane.Document != null);
            this.cmdPrint.EnabledChanged += (s, e) => this.rbtnPrint.Enabled = this.rbtnPrint2.Enabled = ((C1Command)s).Enabled;
            this.cmdPrint.Click += (s, e) => PreviewPane.Print();

            this.cmdRefresh.CommandStateQuery += (s, e) => e.Enabled = !PreviewPane.Busy && PreviewPane.Document != null && PreviewPane.Reflowable;
            this.cmdRefresh.EnabledChanged += (s, e) => this.rbtnRefresh.Enabled = ((C1Command)s).Enabled;
            this.cmdRefresh.Click += (s, e) => PreviewPane.Reflow();

            this.cmdPageSetup.CommandStateQuery += (s, e) => e.Enabled =
                !PreviewPane.Busy && PreviewPane.Document != null && PreviewPane.Reflowable && PreviewPane.CanSetPageSettings;
            this.cmdPageSetup.EnabledChanged += (s, e) => this.rbtnPageSetup.Enabled = this.rbtnPageSetup2.Enabled = ((C1Command)s).Enabled;
            this.cmdPageSetup.Click += (s, e) => PreviewPane.PageSetup();

            this.cmdPageLandscape.CommandStateQuery += (s, e) => e.Enabled =
                !PreviewPane.Busy && PreviewPane.Document != null && PreviewPane.Reflowable && PreviewPane.CanSetPageSettings;
            this.cmdPageLandscape.EnabledChanged += (s, e) => this.rbtnPageLandscape.Enabled = ((C1Command)s).Enabled;
            this.cmdPageLandscape.PressedChanged += (s, e) => this.rbtnPageLandscape.Pressed = ((C1Command)s).Pressed;
            this.cmdPageLandscape.Click += (s, e) => SetPageOrientation(true);

            this.cmdPagePortrait.CommandStateQuery += (s, e) => e.Enabled =
                !PreviewPane.Busy && PreviewPane.Document != null && PreviewPane.Reflowable && PreviewPane.CanSetPageSettings;
            this.cmdPagePortrait.EnabledChanged += (s, e) => this.rbtnPagePortrait.Enabled = ((C1Command)s).Enabled;
            this.cmdPagePortrait.PressedChanged += (s, e) => this.rbtnPagePortrait.Pressed = ((C1Command)s).Pressed;
            this.cmdPagePortrait.Click += (s, e) => SetPageOrientation(false);

            this.cmdZoom100.CommandStateQuery += (s, e) => e.Enabled = Document != null && !PreviewPane.Busy;
            this.cmdZoom100.EnabledChanged += (s, e) => this.rbtnZoom100.Enabled = ((C1Command)s).Enabled;
            this.cmdZoom100.Click += (s, e) =>
                { PreviewPane.PageLayout = C1.Win.C1Preview.PageLayoutEnum.Normal; PreviewPane.ZoomMode = ZoomModeEnum.ActualSize; };

            this.cmdZoomFitPage.CommandStateQuery += (s, e) => e.Enabled = Document != null && !PreviewPane.Busy;
            this.cmdZoomFitPage.EnabledChanged += (s, e) => this.rbtnZoomFitPage.Enabled = ((C1Command)s).Enabled;
            this.cmdZoomFitPage.Click += (s, e) => PreviewPane.ZoomMode = ZoomModeEnum.WholePage;

            this.cmdZoomFitWidth.CommandStateQuery += (s, e) => e.Enabled = Document != null && !PreviewPane.Busy;
            this.cmdZoomFitWidth.EnabledChanged += (s, e) => this.rbtnZoomFitWidth.Enabled = ((C1Command)s).Enabled;
            this.cmdZoomFitWidth.Click += (s, e) => PreviewPane.ZoomMode = ZoomModeEnum.PageWidth;

            this.cmdZoomIn.Click += (s, e) => PreviewPane.DoZoomIn();
            this.cmdZoomIn.CommandStateQuery += (s, e) => e.Enabled = Math.Round(PreviewPane.ZoomFactor, 2) < PreviewPane.MaxZoomFactor;
            // this.cmdZoomIn.EnabledChanged += (s, e) => rbtnZoomIn.Enabled = cmdZoomIn.Enabled;

            this.cmdZoomOut.Click += (s, e) => PreviewPane.DoZoomOut();
            this.cmdZoomOut.CommandStateQuery += (s, e) => e.Enabled = Math.Round(PreviewPane.ZoomFactor, 2) > PreviewPane.MinZoomFactor;
            // this.cmdZoomOut.EnabledChanged += (s, e) => rbtnZoomOut.Enabled = cmdZoomOut.Enabled;

            this.cmdGoFirst.CommandStateQuery += (s, e) => e.Enabled = PreviewPane.StartPageIdx > 0;
            this.cmdGoFirst.EnabledChanged += (s, e) => this.rbtnFirstPage.Enabled = ((C1Command)s).Enabled;
            this.cmdGoFirst.Click += (s, e) => PreviewPane.StartPageIdx = 0;

            this.cmdGoLast.CommandStateQuery += (s, e) => e.Enabled = PreviewPane.StartPageIdx < PreviewPane.Pages.Count - 1;
            this.cmdGoLast.EnabledChanged += (s, e) => this.rbtnLastPage.Enabled = ((C1Command)s).Enabled;
            this.cmdGoLast.Click += (s, e) => PreviewPane.StartPageIdx = int.MaxValue;

            this.cmdGoPrev.CommandStateQuery += (s, e) => e.Enabled = PreviewPane.StartPageIdx > 0;
            this.cmdGoPrev.EnabledChanged += (s, e) => this.rbtnPreviousPage.Enabled = ((C1Command)s).Enabled;
            this.cmdGoPrev.Click += (s, e) => --PreviewPane.StartPageIdx;

            this.cmdGoNext.CommandStateQuery += (s, e) => e.Enabled = PreviewPane.StartPageIdx < PreviewPane.Pages.Count - 1;
            this.cmdGoNext.EnabledChanged += (s, e) => this.rbtnNextPage.Enabled = ((C1Command)s).Enabled;
            this.cmdGoNext.Click += (s, e) => ++PreviewPane.StartPageIdx;

            this.cmdGoPageNo.CommandStateQuery += (s, e) => e.Enabled = PreviewPane.Pages.Count > 0;
            this.cmdGoPageNo.EnabledChanged += (s, e) => rebPageNo.Enabled = ((C1Command)s).Enabled;
            this.cmdGoPageNo.Click += (s, e) => GoToPage();

            this.cmdHistoryPrev.CommandStateQuery += (s, e) => e.Enabled = !PreviewPane.Busy && PreviewPane.CurrentHistoryEntryIndex > 0;
            this.cmdHistoryPrev.EnabledChanged += (s, e) => this.rbtnHistoryBack.Enabled = ((C1Command)s).Enabled;
            this.cmdHistoryPrev.Click += (s, e) => PreviewPane.HistoryBack();

            this.cmdHistoryNext.CommandStateQuery += (s, e) => e.Enabled = !PreviewPane.Busy && PreviewPane.CurrentHistoryEntryIndex < PreviewPane.ViewHistory.Count - 1;
            this.cmdHistoryNext.EnabledChanged += (s, e) => this.rbtnHistoryNext.Enabled = ((C1Command)s).Enabled;
            this.cmdHistoryNext.Click += (s, e) => PreviewPane.HistoryForward();

            this.cmdMouseModeHand.Click += (s, e) => PreviewPane.MouseMode = MouseModeEnum.Hand;
            this.cmdMouseModeSelect.Click += (s, e) => PreviewPane.MouseMode = MouseModeEnum.Select;
            this.cmdMouseModeZoomIn.Click += (s, e) => PreviewPane.MouseMode = MouseModeEnum.Zoom;
            this.cmdMouseModeZoomOut.Click += (s, e) => PreviewPane.MouseMode = MouseModeEnum.ZoomOut;

            this.cmdPageViewSingle.EnabledChanged += (s, e) => this.rbtnViewSinglePage.Enabled = ((C1Command)s).Enabled;
            this.cmdPageViewSingle.CommandStateQuery += (s, e) => e.Enabled = !PreviewPane.Busy;
            this.cmdPageViewSingle.Click += (s, e) => pageView_Click(s, e);

            this.cmdPageViewContinuous.EnabledChanged += (s, e) => this.rbtnViewContinuous.Enabled = ((C1Command)s).Enabled;
            this.cmdPageViewContinuous.CommandStateQuery += (s, e) => e.Enabled = !PreviewPane.Busy;
            this.cmdPageViewContinuous.Click += (s, e) => pageView_Click(s, e);

            this.cmdPageViewTwoUp.EnabledChanged += (s, e) => this.rbtnViewPagesFacing.Enabled = ((C1Command)s).Enabled;
            this.cmdPageViewTwoUp.CommandStateQuery += (s, e) => e.Enabled = !PreviewPane.Busy;
            this.cmdPageViewTwoUp.Click += (s, e) => pageView_Click(s, e);

            this.cmdPageViewTwoUpContinuous.EnabledChanged += (s, e) => this.rbtnViewPagesFacingContinuous.Enabled = ((C1Command)s).Enabled;
            this.cmdPageViewTwoUpContinuous.CommandStateQuery += (s, e) => e.Enabled = !PreviewPane.Busy;
            this.cmdPageViewTwoUpContinuous.Click += (s, e) => pageView_Click(s, e);

            this.cmdZoomDialog.EnabledChanged += (s, e) => this.rbtnZoom.Enabled = ((C1Command)s).Enabled;
            this.cmdZoomDialog.CommandStateQuery += (s, e) => e.Enabled = !PreviewPane.Busy;
            this.cmdZoomDialog.Click += (s, e) => ShowZoomDialog();
        }

        protected void RefreshUI()
        {
            PreviewPane_PropertyChanged(PreviewPane, new PropertyChangedEventArgs("_all_"));
        }

        private void C1RibbonPrintPreviewForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (!PreviewPane.Focused)
            {
                if (e.KeyCode == Keys.Escape && e.Modifiers == Keys.None)
                    PreviewPane.Focus();
                else if (e.KeyCode == Keys.Add && e.Modifiers == Keys.Control)
                    cmdZoomIn.PerformClick();
                else if (e.KeyCode == Keys.Subtract && e.Modifiers == Keys.Control)
                    cmdZoomOut.PerformClick();
            }
        }

        void PreviewPane_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.PropertyName);

            Action updPageSettings = () =>
                {
                    var ps = PreviewPane.PageSettings;
                    cmdPageLandscape.Pressed = ps != null && PreviewPane.PageSettings.Landscape;
                    cmdPagePortrait.Pressed = ps != null && !PreviewPane.PageSettings.Landscape;
                };
            Action updZoomFactor = () =>
                {
                    var zf = (int)(PreviewPane.ZoomFactor * 100);
                    rbtnZoom100.Pressed = zf == 100;
                    rbtnZoomFitWidth.Pressed = PreviewPane.ZoomMode == ZoomModeEnum.PageWidth;
                    rbtnZoomFitPage.Pressed = PreviewPane.ZoomMode == ZoomModeEnum.WholePage;
                    //
                    rtbZoom.Minimum = (int)(PreviewPane.MinZoomFactor * 100);
                    rtbZoom.Maximum = (int)(PreviewPane.MaxZoomFactor * 100);
                    rtbZoom.Value = ZoomSliderScale.SliderValue(PreviewPane.ZoomFactor);
                    rbtnZoom.Text = string.Format("{0}%", zf);
                };
            Action updView = () =>
                {
                    // bottom rigth buttons:
                    rbtnViewSinglePage.Pressed = !PreviewPane.Continuous && PreviewPane.Cols == 1 && PreviewPane.Rows == 1;
                    rbtnViewContinuous.Pressed = PreviewPane.Continuous && PreviewPane.Cols == 1 && PreviewPane.Rows == 1;
                    rbtnViewPagesFacing.Pressed = !PreviewPane.Continuous && PreviewPane.Cols == 2 && PreviewPane.Rows == 1;
                    rbtnViewPagesFacingContinuous.Pressed = PreviewPane.Continuous && PreviewPane.Cols == 2 && PreviewPane.Rows == 1;
                };
            Action updPageNo = () =>
                {
                    rebPageNo.Text = (PreviewPane.StartPageIdx + 1).ToString();
                    rlblPageCount.Text = string.Format("of {0}", PreviewPane.Pages.Count);
                };
            Action updMouseTools = () =>
                {
                    rbtnHandTool.Pressed = PreviewPane.MouseMode == MouseModeEnum.Hand;
                    rbtnTextSelectTool.Pressed = PreviewPane.MouseMode == MouseModeEnum.Select;
                    rbtnZoomInTool.Pressed = PreviewPane.MouseMode == MouseModeEnum.Zoom;
                    rbtnZoomOutTool.Pressed = PreviewPane.MouseMode == MouseModeEnum.ZoomOut;
                };

            switch (e.PropertyName)
            {
                case "_all_":
                    updPageSettings();
                    updZoomFactor();
                    updPageNo();
                    updMouseTools();
                    updView();
                    break;
                case "Busy":
                    this.rbnProgress.Visible = PreviewPane.Busy;
                    break;
                case "StatusText":
                    this.rlblStatusText.Text = PreviewPane.StatusText;
                    break;
                case "Document":
                    updPageSettings();
                    updZoomFactor();
                    updPageNo();
                    break;
                case "PageSettings":
                    // Getting PreviewPane.PageSettings is a very heavy operation, so we only do it if necessary:
                    updPageSettings();
                    updPageNo();
                    break;
                case "ZoomFactor":
                case "MinZoomFactor":
                case "MaxZoomFactor":
                    updZoomFactor();
                    break;
                case "Rows":
                case "Cols":
                case "PageLayout":
                case "Continuous":
                    updView();
                    break;
                case "StartPageIdx":
                    updPageNo();
                    break;
                case "MouseMode":
                    updMouseTools();
                    break;
                default:
                    break;
            }
        }

        void PreviewPane_LongOperation(object sender, C1.C1Preview.LongOperationEventArgs e)
        {
            this.rbnProgress.Value = (int)(e.Complete * 100d);
            foreach (C1Command cmd in _cmdHolder.Commands)
                cmd.StateQuery();
            Application.DoEvents();
        }

        private void SetPageOrientation(bool landscape)
        {
            var ps = PreviewPane.PageSettings;
            if (ps != null)
            {
                ps.Landscape = landscape;
                PreviewPane.PageSettings = ps;
            }
        }

        private void ShowZoomDialog()
        {
            using (var zd = new ZoomDialog())
            {
                zd.PreviewPane = this.PreviewPane;
                zd.ShowDialog();
            }
        }

        private void GoToPage()
        {
            int v;
            if (int.TryParse(rebPageNo.Text, out v))
                PreviewPane.StartPageIdx = v - 1;
            else
                rebPageNo.Text = (PreviewPane.StartPageIdx + 1).ToString();
        }

        // page view buttons on bottom left:
        private void pageView_Click(object sender, EventArgs e)
        {
            using (new C1PreviewPane.LayoutSection(_pview, HistorySavedActionsEnum.PageLayout))
            {
                if (sender == cmdPageViewSingle)
                {
                    PreviewPane.Continuous = false;
                    PreviewPane.PageLayout = C1.Win.C1Preview.PageLayoutEnum.Normal;
                }
                else if (sender == cmdPageViewContinuous)
                {
                    PreviewPane.Continuous = true;
                    PreviewPane.PageLayout = C1.Win.C1Preview.PageLayoutEnum.Normal;
                }
                else if (sender == cmdPageViewTwoUp)
                {
                    PreviewPane.Continuous = false;
                    PreviewPane.PageLayout = C1.Win.C1Preview.PageLayoutEnum.Custom;
                    PreviewPane.Rows = 1;
                    PreviewPane.Cols = 2;
                }
                else if (sender == cmdPageViewTwoUpContinuous)
                {
                    PreviewPane.Continuous = true;
                    PreviewPane.PageLayout = C1.Win.C1Preview.PageLayoutEnum.Custom;
                    PreviewPane.Rows = 1;
                    PreviewPane.Cols = 2;
                }
            }
        }

        private void RibbonClick(RibbonItem item)
        {
            if (item.Parent as RibbonItem == rbtnHistoryBack || item.Parent as RibbonItem == rbtnHistoryNext)
            {
                ViewHistoryItem vhi = item.Tag as ViewHistoryItem;
                if (vhi != null)
                    _pview.CurrentHistoryEntry = vhi;
            }
        }

        private void RibbonChangeCommitted(RibbonItem item)
        {
            if (item == rebPageNo)
                cmdGoPageNo.PerformClick();
        }

        private void rbnMain_RibbonEvent(object sender, RibbonEventArgs e)
        {
            switch (e.EventType)
            {
                case RibbonEventType.Click:
                    RibbonClick(e.Item as RibbonItem);
                    break;
                case RibbonEventType.ChangeCommitted:
                    RibbonChangeCommitted(e.Item as RibbonItem);
                    break;
            }
        }

        private void rtbZoom_Scroll(object sender, EventArgs e)
        {
            var zf = ZoomSliderScale.ZoomFactor(rtbZoom.Value);
            // we want to be able to easily "zero in" on 100% zoom, hence this:
            if (zf > 0.97 && zf < 1.04)
                zf = 1;
            else if ((zf < 1 && PreviewPane.ZoomFactor > 1) || (zf > 1 && PreviewPane.ZoomFactor < 1))
                zf = 1;
            PreviewPane.ZoomFactor = zf;
        }

        private void rbtnHistoryBack_DropDown(object sender, EventArgs e)
        {
            rbtnHistoryBack.Items.Clear();
            for (int i = _pview.CurrentHistoryEntryIndex - 1, j = 0; i >= 0 && j < 10; --i, ++j)
            {
                ViewHistoryItem vhi = _pview.ViewHistory[i];
                RibbonButton btn = new RibbonButton(vhi.Caption);
                btn.Tag = vhi;
                rbtnHistoryBack.Items.Add(btn);
            }
        }

        private void rbtnHistoryNext_DropDown(object sender, EventArgs e)
        {
            rbtnHistoryNext.Items.Clear();
            for (int i = _pview.CurrentHistoryEntryIndex + 1, j = 0; i < _pview.ViewHistory.Count && j < 10; ++i, ++j)
            {
                ViewHistoryItem vhi = _pview.ViewHistory[i];
                RibbonButton btn = new RibbonButton(vhi.Caption);
                btn.Tag = vhi;
                rbtnHistoryNext.Items.Add(btn);
            }
        }
    }
}
