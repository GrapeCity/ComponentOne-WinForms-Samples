//----------------------------------------------------------------------------
// MainForm_Preview.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.Win32;
using System.Collections.Specialized;
using System.Text.RegularExpressions;
using System.Drawing.Text;
using System.Globalization;
using System.Drawing.Printing;
using System.Diagnostics;
using System.Linq;

using C1.Win.Ribbon;
using FlexReportDesignerApp.Util;
using C1.Win.Localization;
using C1.Win.Command;

using C1.Win.FlexReport;
using C1.Win.FlexViewer;
using C1.Win.Document;
using Flex = C1.Win.FlexReport;
using DocExp = C1.Win.Document.Export;
using Viewer = C1.Win.FlexViewer;

namespace FlexReportDesignerApp
{
    public partial class MainForm
    {
        #region Private data members used exclusively by preview
        // UI update timer (currently used in preview mode only, for preview prop changes):
        private Timer _timer;
        private bool _timerUpdateNeeded = false;
        private bool _searchBarVisible;
        private string _searchText = string.Empty;
        private bool _matchWholeWord;
        private bool _matchCase;
        // rotation:
        private static readonly System.Collections.Generic.Dictionary<FlexViewerRotateView, FlexViewerRotateView> s_rotateCW =
            new Dictionary<FlexViewerRotateView, FlexViewerRotateView>()
            {
                {  Viewer.FlexViewerRotateView.NoRotation, Viewer.FlexViewerRotateView.Rotation90Clockwise },
                {  Viewer.FlexViewerRotateView.Rotation90Clockwise, Viewer.FlexViewerRotateView.Rotation180 },
                {  Viewer.FlexViewerRotateView.Rotation180, Viewer.FlexViewerRotateView.Rotation90CounterClockwise },
                {  Viewer.FlexViewerRotateView.Rotation90CounterClockwise, Viewer.FlexViewerRotateView.NoRotation }
            };
        private static readonly System.Collections.Generic.Dictionary<FlexViewerRotateView, FlexViewerRotateView> s_rotateCCW =
            new Dictionary<FlexViewerRotateView, FlexViewerRotateView>()
            {
                {  Viewer.FlexViewerRotateView.NoRotation, Viewer.FlexViewerRotateView.Rotation90CounterClockwise },
                {  Viewer.FlexViewerRotateView.Rotation90CounterClockwise, Viewer.FlexViewerRotateView.Rotation180 },
                {  Viewer.FlexViewerRotateView.Rotation180, Viewer.FlexViewerRotateView.Rotation90Clockwise },
                {  Viewer.FlexViewerRotateView.Rotation90Clockwise, Viewer.FlexViewerRotateView.NoRotation }
            };
        #endregion

        private void InitializeReportRender()
        {
            cPreviewCopy.Click += cPreviewCopy_Click;
            // set up timer for UI updates and other tasks:
            _timer = new Timer();
            _timer.Interval = 500;
            _timer.Tick += new EventHandler(_timer_Tick);
            _timer.Start();

            _flexViewer.PropertyChanged += _flexViewer_PropertyChanged;
            _flexViewer.ContextMenuPopup += _flexViewer_ContextMenuPopup;
            _flexViewer.KeyDown += _flexViewer_KeyDown;

            _reportRender.Paginated = true; // default
            _reportRender.StartReport += new System.EventHandler(this._reportRender_StartReport);
            _reportRender.EndReport += new System.EventHandler(this._reportRender_EndReport);
            _reportRender.BusyStateChanged += _reportRender_BusyStateChanged;
            _reportRender.StartPage += new Flex.ReportEventHandler(this._reportRender_StartPage);
            _reportRender.ReportError += new Flex.ReportErrorEventHandler(this._reportRender_ReportError);
            /// _reportRender.RenderCompleted += _reportRender_RenderCompleted;
        }

        void _flexViewer_ContextMenuPopup(object sender, ContextMenuPopupEventArgs e)
        {
            // Doing it here instead of assigning cmPreview as _flexViewer's context menu
            // does not show context menu in outlines and thumbnail view.
            cmPreview.ShowContextMenu(_flexViewer, _flexViewer.PointToClient(new Point(e.X, e.Y)));
        }

        void cPreviewCopy_Click(object sender, ClickEventArgs e)
        {
            if (_flexViewer.HasSelection)
                _flexViewer.CopySelectionToClipboard();
        }

        private bool IsPreviewRendering
        {
            // get { return _flexViewer.Busy || _reportRender.IsBusy; }
            get { return _reportRender.IsBusy; }
        }

        private bool NeedSyncRender()
        {
            foreach (var field in _reportRender.Fields)
                if (field is C1.Win.FlexReport.CustomFields.Map)
                    return true;
            return false;
        }
        /// <summary>
        /// Renders preview.
        /// </summary>
        /// <param name="updateDefinition">If true, the report definition will be refreshed.</param>
        /// <param name="keepParams">If true, the current values for the report parameters will be preserved.</param>
        /// <returns></returns>
        private bool RenderPreview(bool updateDefinition, bool keepParams)
        {
            if (_dirty && _autoSave)
                SaveFile(false);

            UpdateUI(false);
            if (_lastRenderCancelled)
            {
                // if last generation was cancelled by user, we probably want to regenerate the report:
                _lastRenderCancelled = false;
            }
            try
            {
                // clear error info if any
                ClearRenderError();
                try
                {
                    // cancel if the report is busy
                    if (_reportRender.IsBusy || _flexViewer.Busy)
                    {
                        DoPreviewStop();
                        return true;
                    }
                    if (updateDefinition)
                    {
                        ParameterCollection pars = null;
                        if (keepParams)
                        {
                            pars = new ParameterCollection();
                            pars.AssignFrom(_reportRender.Parameters);
                        }

                        // ReportDefinition is used because it creates a "deep" copy of report
                        // including subreports
                        _reportRender.BasePath = _flexDesigner.Report.BasePath;
                        _reportRender.ReportDefinition = _flexDesigner.Report.ReportDefinition;
                        // initializes datasources if report called from VS design-time
                        if (_dataSchema != null)
                        {
                            foreach (DataSource ds in _reportRender.DataSources)
                            {
                                if (_dataSchema.Contains(ds.ConnectionString))
                                {
                                    DataSet dataSet = (DataSet)_dataSchema[ds.ConnectionString];
                                    if (!string.IsNullOrEmpty(ds.RecordSource) && dataSet.Tables.Contains(ds.RecordSource))
                                    {
                                        ds.Recordset = dataSet.Tables[ds.RecordSource];
                                    }
                                }
                            }
                        }
                        //
                        if (keepParams)
                        {
                            _reportRender.Parameters.AssignFrom(pars);
                        }
                    }
                    // make report dirty if it has parameters
                    bool render = true;
                    if (_reportRender.Parameters.Count > 0)
                    {
                        var errList = _reportRender.ValidateParameters();
                        render = errList == null || errList.Count == 0;
                    }
                    // render the report
                    _reportRender.DoEvents = true;
                    // Assign report to preview, this also renders the report:
                    if (render)
                    {
                        Cursor = Cursors.WaitCursor;
                        if (NeedSyncRender())
                            _reportRender.Render();
                        else
                            _reportRender.RenderAsync();
                    }
                    _flexViewer.DocumentSource = _reportRender;
                    ShowStatus(Strings.MainForm.Ready);
                    _flexViewer.Focus();
                    return true;
                }
                catch (Exception x) // show message for all other problems
                {
                    MessageForm.Warn(string.Format(Strings.MainForm.ErrRenderingReportFmt, x.Message));
                    return false;
                }
            }
            finally
            {
                UpdateUI(false);
            }
        }
#if skip_dima
        // NOTE: this is fired ONLY in async mode.
        void _reportRender_RenderCompleted(object sender, AsyncCompletedEventArgs e)
        {
            // Make sure event is processed in UI thread:
            Invoke((Action<Exception>)((e_) => ReportRender_RenderCompleted(e_)), e.Error);
        }
#endif
        private void _reportRender_StartReport(object sender, System.EventArgs e)
        {
            // Make sure event is processed in UI thread:
            Invoke((Action)(() => ReportRender_StartReport()));
        }
        private void _reportRender_EndReport(object sender, EventArgs e)
        {
            // Make sure event is processed in UI thread:
            Invoke((Action)(() => ReportRender_EndReport()));
        }
        private void _reportRender_BusyStateChanged(object sender, EventArgs e)
        {
            // Make sure event is processed in UI thread:
            Invoke((Action)(() => ReportRender_BusyStateChanged()));
        }
        private void _reportRender_StartPage(object sender, ReportEventArgs e)
        {
            // Make sure event is processed in UI thread:
            Invoke((Action<ReportEventArgs>)((e_) => ReportRender_StartPage(e_)), e);
        }
        private void _reportRender_ReportError(object sender, ReportErrorEventArgs e)
        {
            // Make sure event is processed in UI thread:
            Invoke((Action<ReportErrorEventArgs>)((e_) => ReportRender_ReportError(e_)), e);
        }
        private void ReportRender_StartReport()
        {
            ClearRenderError();
            UpdateUI(false);
            ShowStatus(string.Format(Strings.MainForm.Rendering, _flexDesigner.Report.ReportName));
            Cursor = Cursors.WaitCursor;
        }
        private void ReportRender_EndReport()
        {
        }
        private void ReportRender_BusyStateChanged()
        {
            // Currently, we use this event in place of EndReport because it is fired when busy state is ready already:
            Cursor = Cursors.Default;
            _lastRenderCancelled = _reportRender.Cancel;
            _reportRender.Cancel = false;
            //
            if (_reportRender.Log.Count > 0)
            {
                dtpErrors.TabVisible = true;
                var lastLogEntry = _reportRender.Log[_reportRender.Log.Count - 1];
                if (lastLogEntry.Severity == LogEntrySeverity.Critical)
                {
                    MessageForm.Warn(string.Format(Strings.MainForm.ErrRenderingReportFmt, lastLogEntry.Message));
                    ShowReportRenderError(lastLogEntry.Exception); // we still show the error in the status bar
                }
                for (int i = 0; i < _reportRender.Log.Count; ++i)
                    _errorList.AddLogEntry(_reportRender.Log[i]);
            }
            UpdateUI(false);
            ShowStatus(Strings.MainForm.Ready);
        }
        private void ReportRender_StartPage(ReportEventArgs e)
        {
            UpdateUI(false);
            ShowStatus(string.Format(Strings.MainForm.RenderingPressEsc, _reportRender.ReportName));
        }
        private void ReportRender_ReportError(ReportErrorEventArgs e)
        {
            ShowReportRenderError(e.Exception);
        }
#if skip_dima
        private void ReportRender_RenderCompleted(Exception error)
        {
            System.Diagnostics.Debug.Assert(!IsPreviewRendering);
            Cursor = Cursors.Default;
            _lastRenderCancelled = _reportRender.Cancel;
            _reportRender.Cancel = false;
            UpdateUI(false);
            ShowStatus(Strings.MainForm.Ready);
            if (error != null)
            {
                MessageForm.Warn(string.Format(Strings.MainForm.ErrRenderingReportFmt, error.Message));
                ShowReportRenderError(error); // we still show the error in the status bar
            }
        }
#endif
        private void ShowReportRenderError(Exception ex)
        {
            // build error message (no duplicates)
            string err = rbtnRenderError.ToolTip;
            if (err.IndexOf(ex.Message) > -1)
                return;
            if (err.Length == 0)
                err = string.Format(
                    Strings.MainForm.ErrorsInReportFmt,
                    _reportRender.ReportName,
                    Strings.MainForm.ClickToCopyErrors);
            err += string.Format("\r\n- {0}", ex.Message);

            // show error message and icon
            SetRenderError(err);
        }
        private void _timer_Tick(object sender, EventArgs e)
        {
            // Update UI:
            if (_timerUpdateNeeded)
            {
                _timerUpdateNeeded = false;
                try
                {
                    UpdateUIPreviewStatusBar(true);
                    UpdateUINavigation(false);
                    UpdateUIPreviewTools(false);
                    UpdateUIZoom(false);
                    UpdateUIPreviewStopRefresh(false);
                }
                catch
                {
                    // sometimes timer gets called when we're exiting, so just ignore this.
                }
            }
            // Handle delayed form close:
            if (_closeRequestedWhileRendering && !IsPreviewRendering)
            {
                _closeRequestedWhileRendering = false;
                this.BeginInvoke(new MethodInvoker(delegate () { this.Close(); }));
            }
        }

        void _flexViewer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Handled)
            {
                return;
            }
            if (e.KeyData == Keys.F3 && _searchBarVisible)
            {
                SearchNext(true);
                e.Handled = true;
            }
            else if (e.KeyData == (Keys.Control | Keys.F) || e.KeyData == Keys.F3)
            {
                if (_actions[ActionTypeEnum.PreviewFind].Enabled)
                {
                    UpdateSearchVisible(true);
                    e.Handled = true;
                }
            }
            else if (e.KeyData == (Keys.Shift | Keys.F3))
            {
                if (_searchBarVisible)
                {
                    SearchPrev(true);
                    e.Handled = true;
                }
            }
            else if (e.KeyData == Keys.Escape)
            {
                if (_searchBarVisible)
                {
                    UpdateSearchVisible(false);
                    e.Handled = true;
                }
            }
            else if (e.KeyData == (Keys.Control | Keys.C) || e.KeyData == (Keys.Control | Keys.Insert))
            {
                if (_flexViewer.HasSelection)
                {
                    _flexViewer.CopySelectionToClipboard();
                    e.Handled = true;
                }
            }
        }

        private void _flexViewer_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "HasHistory":
                case "HasSelection":
                case "HasOutlines":
                case "HasParameters":
                case "OutlinePanelVisible":
                case "ParamPanelVisible":
                case "ZoomMode":
                case "PageCount":
                case "Continuous":
                case "FacingPages":
                case "PageColumns":
                case "PageRows":
                case "HiddenMargins":
                case "MouseMode":
                case "ShowRulers":
                case "SelectMouseMode":
                case "Busy":
                    _timerUpdateNeeded = true;
                    break;

                case "StatusText":
                    if (!string.IsNullOrEmpty(_flexViewer.StatusText) || _searchBarVisible)
                    {
                        rlblStatusBarText.Text = _flexViewer.StatusText;
                    }
                    break;

                case "Paginated":
                case "ThumbViewActive":
                    UpdateSearchVisible(false);
                    _timerUpdateNeeded = true;
                    break;

                // special optimization for PageIndex and ZoomFactor to avoid delays while browsing the report
                case "PageIndex":
                    {
                        int index = _flexViewer.PageIndex;
                        string s = (index + 1).ToString();
                        _actions[ActionTypeEnum.EditPageNo].Text = s;
                        rebPageNo.Text = s;
                        bool canMovePrev = false;
                        bool canMoveNext = false;
                        if (_flexDesigner.Report != null && !IsPreviewRendering)
                        {
                            canMovePrev = index > 0;
                            canMoveNext = index < _flexViewer.PageCount - 1;
                        }
                        _actions[ActionTypeEnum.FirstPage].Enabled = canMovePrev;
                        _actions[ActionTypeEnum.PreviousPage].Enabled = canMovePrev;
                        _actions[ActionTypeEnum.NextPage].Enabled = canMoveNext;
                        _actions[ActionTypeEnum.LastPage].Enabled = canMoveNext;
                        rbtnFirstPage.Enabled = canMovePrev;
                        rbtnPreviousPage.Enabled = canMovePrev;
                        rbtnNextPage.Enabled = canMoveNext;
                        rbtnLastPage.Enabled = canMoveNext;
                    }
                    break;

                case "ZoomFactor":
                    {
                        int zf = (int)Math.Round(_flexViewer.ZoomFactor * 100);
                        string s = string.Format(Strings.MainForm.PercentFmt, zf);
                        _actions[ActionTypeEnum.LblZoom].Text = s;
                        sbMain.Invalidate();

                        zf = ZoomFactorToZoomSlider(zf);
                        _actions[ActionTypeEnum.ZoomValue].Value = zf;
                        if (rtbZoom.Value != zf)
                        {
                            rtbZoom.Value = Math.Min(Math.Max(zf, rtbZoom.Minimum), rtbZoom.Maximum);
                        }
                    }
                    break;

                default:
                    break;
            }
        }

        void ZoomLevelButton_DrawItem(object sender, C1.Win.Ribbon.DrawItemEventArgs e)
        {
            e.DrawBackground();
            TextRenderer.DrawText(e.Graphics, _actions[ActionTypeEnum.LblZoom].Text, e.Font, e.Bounds, e.ForeColor);
        }

        private void UpdateStatePreviewMode()
        {
            System.Diagnostics.Debug.Assert(!ReportDesignMode);

            bool hasReports = _reportList.Items.Count > 0;
            bool hasCurrReport = _flexDesigner.Report != null;
            bool isPreviewRendering = IsPreviewRendering;

            int zf = (int)Math.Round(_flexViewer.ZoomFactor * 100);
            // update actions
            _actions[ActionTypeEnum.New].Enabled = !isPreviewRendering;
            _actions[ActionTypeEnum.Open].Enabled = !isPreviewRendering;
            _actions[ActionTypeEnum.Close].Enabled = !isPreviewRendering && hasCurrReport;
            _actions[ActionTypeEnum.Save].Enabled = !isPreviewRendering && hasCurrReport;
            _actions[ActionTypeEnum.SaveAs].Enabled = !isPreviewRendering && hasCurrReport;
            _actions[ActionTypeEnum.Import].Enabled = !isPreviewRendering;
            _actions[ActionTypeEnum.Export].Enabled = !isPreviewRendering && hasCurrReport;

            // stop/refresh preview:
            _actions[ActionTypeEnum.PreviewStop].Enabled = isPreviewRendering;
            _actions[ActionTypeEnum.PreviewRefresh].Enabled = hasCurrReport && !isPreviewRendering;

            //
            _actions[ActionTypeEnum.AlignCenter].Enabled =
                _actions[ActionTypeEnum.AlignMiddle].Enabled =
                _actions[ActionTypeEnum.AlignLeft].Enabled =
                _actions[ActionTypeEnum.AlignRight].Enabled =
                _actions[ActionTypeEnum.AlignTop].Enabled =
                _actions[ActionTypeEnum.AlignBottom].Enabled = false;
            //
            _actions[ActionTypeEnum.GroupSort].Enabled =
                _actions[ActionTypeEnum.Database].Enabled =
                _actions[ActionTypeEnum.ReportInfo].Enabled =
                _actions[ActionTypeEnum.ScriptEditor].Enabled = false;

            //
            _actions[ActionTypeEnum.ModeDesign].Enabled = true;
            _actions[ActionTypeEnum.ModeDesign].Pressed = false;
            _actions[ActionTypeEnum.ModePreview].Enabled = true;
            _actions[ActionTypeEnum.ModePreview].Pressed = true;
            //
            _actions[ActionTypeEnum.Cut].Enabled =
                _actions[ActionTypeEnum.Paste].Enabled =
                _actions[ActionTypeEnum.Delete].Enabled =
                _actions[ActionTypeEnum.Undo].Enabled =
                _actions[ActionTypeEnum.Redo].Enabled = false;
            _actions[ActionTypeEnum.Copy].Enabled = _flexViewer.HasSelection;
            //
            _actions[ActionTypeEnum.ExportHtml].Enabled =
                _actions[ActionTypeEnum.ExportPdf].Enabled =
                _actions[ActionTypeEnum.ExportRtf].Enabled =
                _actions[ActionTypeEnum.ExportText].Enabled =
                _actions[ActionTypeEnum.ExportXls].Enabled =
                _actions[ActionTypeEnum.ExportMore].Enabled = hasCurrReport && !isPreviewRendering;

            //
            _actions[ActionTypeEnum.FontName].Enabled = false;
            _actions[ActionTypeEnum.FontName].Text = string.Empty;
            _actions[ActionTypeEnum.FontSize].Enabled = false;
            _actions[ActionTypeEnum.FontSize].Text = string.Empty;
            _actions[ActionTypeEnum.FontSizeDown].Enabled = false;
            _actions[ActionTypeEnum.FontSizeUp].Enabled = false;
            //
            _actions[ActionTypeEnum.FontBold].Enabled = false;
            _actions[ActionTypeEnum.FontBold].Pressed = false;
            _actions[ActionTypeEnum.FontItalic].Enabled = false;
            _actions[ActionTypeEnum.FontItalic].Pressed = false;
            _actions[ActionTypeEnum.FontUnderline].Enabled = false;
            _actions[ActionTypeEnum.FontUnderline].Pressed = false;
            //
            _actions[ActionTypeEnum.TextAlignGeneral].Enabled = false;
            _actions[ActionTypeEnum.TextAlignGeneral].Pressed = false;
            _actions[ActionTypeEnum.TextAlignLeft].Enabled = false;
            _actions[ActionTypeEnum.TextAlignLeft].Pressed = false;
            _actions[ActionTypeEnum.TextAlignCenter].Enabled = false;
            _actions[ActionTypeEnum.TextAlignCenter].Pressed = false;
            _actions[ActionTypeEnum.TextAlignRight].Enabled = false;
            _actions[ActionTypeEnum.TextAlignRight].Pressed = false;
            _actions[ActionTypeEnum.TextAlignJustify].Enabled = false;
            _actions[ActionTypeEnum.TextAlignJustify].Pressed = false;
            //
            _actions[ActionTypeEnum.TextColor].Enabled = false;
            _actions[ActionTypeEnum.TextColor].Color = Color.Empty;
            // borders:
            _actions[ActionTypeEnum.BorderColor].Enabled = false;
            _actions[ActionTypeEnum.BorderColor].Color = Color.Empty;
            _actions[ActionTypeEnum.BorderStyle].Enabled = false;
            _actions[ActionTypeEnum.BorderStyle].Text = DashStyle.None.ToString();
            _actions[ActionTypeEnum.BorderStyle].Value = (int)DashStyle.None;
            _actions[ActionTypeEnum.BorderWidth].Enabled = false;
            _actions[ActionTypeEnum.BorderWidth].Text = string.Empty;
            //
            _actions[ActionTypeEnum.ApplyStyleToSelection].Enabled = false;
            _actions[ActionTypeEnum.FormatAsTableRow].Enabled = false;
            // 
            _actions[ActionTypeEnum.FillColor].Enabled = false;
            //
            _actions[ActionTypeEnum.SubSectionAdd].Enabled =
                _actions[ActionTypeEnum.SubSectionRemove].Enabled =
                _actions[ActionTypeEnum.SubSectionMoveUp].Enabled =
                _actions[ActionTypeEnum.SubSectionMoveDown].Enabled = false;

            //
            _actions[ActionTypeEnum.Styles].Enabled = false;

            //
            _actions[ActionTypeEnum.SnapToGrid].Enabled =
                _actions[ActionTypeEnum.ShowGrid].Enabled =
                _actions[ActionTypeEnum.GridProperties].Enabled =
                _actions[ActionTypeEnum.LockFields].Enabled = false;

            //
            // _flexViewer.HasBackwardHistory
            _actions[ActionTypeEnum.PreviousView].Enabled = hasCurrReport && !_flexViewer.Busy && _flexViewer.HasBackwardHistory;
            _actions[ActionTypeEnum.NextView].Enabled = hasCurrReport && !_flexViewer.Busy && _flexViewer.HasForwardHistory;
            _actions[ActionTypeEnum.EditPageNo].Enabled = hasCurrReport && !_flexViewer.Busy && _flexViewer.PageCount > 0;
            _actions[ActionTypeEnum.EditPageNo].Text = (_flexViewer.PageIndex + 1).ToString();
            _actions[ActionTypeEnum.LblPageCount].Enabled = hasCurrReport && !_flexViewer.Busy && _flexViewer.PageCount > 0;
            _actions[ActionTypeEnum.LblPageCount].Text = _flexViewer.PageCount > 0 ? string.Format(Strings.MainForm.OfPagesFmt, _flexViewer.PageCount) : string.Empty;
            _actions[ActionTypeEnum.PreviousPage].Enabled = hasCurrReport && !isPreviewRendering && _flexViewer.PageIndex > 0;
            _actions[ActionTypeEnum.FirstPage].Enabled = hasCurrReport && !isPreviewRendering && _flexViewer.PageIndex > 0;
            _actions[ActionTypeEnum.NextPage].Enabled = hasCurrReport && !isPreviewRendering && _flexViewer.PageIndex < _flexViewer.PageCount - 1;
            _actions[ActionTypeEnum.LastPage].Enabled = hasCurrReport && !isPreviewRendering && _flexViewer.PageIndex < _flexViewer.PageCount - 1;
            //
            _actions[ActionTypeEnum.PageSize].Enabled = hasCurrReport && !isPreviewRendering;
            _actions[ActionTypeEnum.PageSetup].Enabled = hasCurrReport && !isPreviewRendering;
            _actions[ActionTypeEnum.PagePortrait].Enabled = hasCurrReport && !isPreviewRendering;
            _actions[ActionTypeEnum.PagePortrait].Pressed = hasCurrReport && _reportRender.Layout.Orientation == Flex.OrientationEnum.Portrait;
            _actions[ActionTypeEnum.PageLandscape].Enabled = hasCurrReport && !isPreviewRendering;
            _actions[ActionTypeEnum.PageLandscape].Pressed = hasCurrReport && _reportRender.Layout.Orientation == Flex.OrientationEnum.Landscape;

            //
            _actions[ActionTypeEnum.BringToFront].Enabled =
                _actions[ActionTypeEnum.SendToBack].Enabled =
                _actions[ActionTypeEnum.EqualHorizontalSpacing].Enabled =
                _actions[ActionTypeEnum.EqualVerticalSpacing].Enabled =
                _actions[ActionTypeEnum.IncreaseHorizontalSpacing].Enabled =
                _actions[ActionTypeEnum.IncreaseVerticalSpacing].Enabled =
                _actions[ActionTypeEnum.DecreaseHorizontalSpacing].Enabled =
                _actions[ActionTypeEnum.DecreaseVerticalSpacing].Enabled = false;

            //
            _actions[ActionTypeEnum.PreviewPrint].Enabled = !isPreviewRendering && _reportRender != null && _reportRender.Paginated;
            //
            _actions[ActionTypeEnum.RotateViewCW].Enabled = 
                _actions[ActionTypeEnum.RotateViewCCW].Enabled = !isPreviewRendering && _flexViewer.HasPages && _flexViewer.Paginated;
            _actions[ActionTypeEnum.ViewSinglePage].Enabled = !isPreviewRendering && !_flexViewer.ThumbViewActive;
            _actions[ActionTypeEnum.ViewSinglePage].Pressed = !_flexViewer.Continuous && !_flexViewer.FacingPages;
            _actions[ActionTypeEnum.ViewContinuous].Enabled = !isPreviewRendering && !_flexViewer.ThumbViewActive;
            _actions[ActionTypeEnum.ViewContinuous].Pressed = _flexViewer.Continuous && !_flexViewer.FacingPages;
            _actions[ActionTypeEnum.ViewPagesFacing].Enabled = !isPreviewRendering && !_flexViewer.ThumbViewActive;
            _actions[ActionTypeEnum.ViewPagesFacing].Pressed = !_flexViewer.Continuous && _flexViewer.FacingPages;
            _actions[ActionTypeEnum.ViewPagesFacingContinuous].Enabled = !isPreviewRendering && !_flexViewer.ThumbViewActive;
            _actions[ActionTypeEnum.ViewPagesFacingContinuous].Pressed = _flexViewer.Continuous && _flexViewer.FacingPages;
            _actions[ActionTypeEnum.LblZoom].Enabled = !_flexViewer.ThumbViewActive;
            _actions[ActionTypeEnum.LblZoom].Text = string.Format(Strings.MainForm.PercentFmt, zf);
            _actions[ActionTypeEnum.ZoomValue].Enabled = !isPreviewRendering && !_flexViewer.ThumbViewActive;
            _actions[ActionTypeEnum.ZoomValue].Value = ZoomFactorToZoomSlider(zf);

            //
            _actions[ActionTypeEnum.HandTool].Enabled = true;
            _actions[ActionTypeEnum.HandTool].Pressed = !_flexViewer.SelectMouseMode;
            _actions[ActionTypeEnum.TextSelectTool].Enabled = true;
            _actions[ActionTypeEnum.TextSelectTool].Pressed = _flexViewer.SelectMouseMode;
            _actions[ActionTypeEnum.PreviewFind].Enabled = !isPreviewRendering && _flexViewer.HasPages && !_flexViewer.ThumbViewActive;
            _actions[ActionTypeEnum.PreviewFind].Pressed = _searchBarVisible;

            //
            _actions[ActionTypeEnum.PropertiesAlphabetical].Enabled = true;
            _actions[ActionTypeEnum.PropertiesAlphabetical].Pressed = _propGrid.PropertySort == PropertySort.Alphabetical;
            _actions[ActionTypeEnum.PropertiesCategorized].Enabled = true;
            _actions[ActionTypeEnum.PropertiesCategorized].Pressed = _propGrid.PropertySort == PropertySort.Categorized || _propGrid.PropertySort == PropertySort.CategorizedAlphabetical;

            //
            _actions[ActionTypeEnum.NewReportWizard].Enabled =
                _actions[ActionTypeEnum.NewReportEmpty].Enabled =
                _actions[ActionTypeEnum.PasteReport].Enabled =
                _actions[ActionTypeEnum.CutReport].Enabled =
                _actions[ActionTypeEnum.CopyReport].Enabled =
                _actions[ActionTypeEnum.DeleteReport].Enabled =
                _actions[ActionTypeEnum.MoveReportDown].Enabled =
                _actions[ActionTypeEnum.MoveReportUp].Enabled = false;

            _actions[ActionTypeEnum.SelectedReport].Enabled = true;
            if (hasCurrReport)
                _actions[ActionTypeEnum.SelectedReport].Text = string.Format(Strings.MainForm.ReportFmt, _flexDesigner.Report.ReportName);
            else
                _actions[ActionTypeEnum.SelectedReport].Text = Strings.MainForm.ReportNotSelected;

            //
            _actions[ActionTypeEnum.AlignToGrid].Enabled =
                _actions[ActionTypeEnum.SizeToGrid].Enabled =
                _actions[ActionTypeEnum.HeightToShortest].Enabled =
                _actions[ActionTypeEnum.HeightToTallest].Enabled =
                _actions[ActionTypeEnum.WidthToNarrowest].Enabled =
                _actions[ActionTypeEnum.WidthToWidest].Enabled = false;

            //
            _actions[ActionTypeEnum.ShowPropertyGrid].Enabled = false;
            _actions[ActionTypeEnum.ShowDataTree].Enabled = false;

            //
            _actions[ActionTypeEnum.ZoomFitToWindow].Enabled =
                _actions[ActionTypeEnum.PreviewPaginated].Enabled =
                _actions[ActionTypeEnum.Zoom].Enabled =
                _actions[ActionTypeEnum.Zoom10].Enabled =
                _actions[ActionTypeEnum.Zoom25].Enabled =
                _actions[ActionTypeEnum.Zoom50].Enabled =
                _actions[ActionTypeEnum.Zoom75].Enabled =
                _actions[ActionTypeEnum.Zoom100].Enabled =
                _actions[ActionTypeEnum.Zoom125].Enabled =
                _actions[ActionTypeEnum.Zoom150].Enabled =
                _actions[ActionTypeEnum.Zoom200].Enabled =
                _actions[ActionTypeEnum.Zoom500].Enabled = hasCurrReport && !isPreviewRendering && !_flexViewer.ThumbViewActive;

            _actions[ActionTypeEnum.PreviewParams].Enabled = hasCurrReport && _flexViewer.HasParameters && _flexViewer.CanShowParameters;
            _actions[ActionTypeEnum.PreviewThumbnails].Enabled = hasCurrReport && _flexViewer.HasPages && _flexViewer.Paginated && _flexViewer.CanShowThumbnails;
            _actions[ActionTypeEnum.PreviewOutlines].Enabled = hasCurrReport && _flexViewer.HasOutlines && _flexViewer.CanShowOutlines;

            _actions[ActionTypeEnum.ZoomOnePage].Enabled =
                _actions[ActionTypeEnum.ZoomTwoPages].Enabled =
                _actions[ActionTypeEnum.ZoomMorePages].Enabled =
                _actions[ActionTypeEnum.ZoomFourPages].Enabled =
                _actions[ActionTypeEnum.ZoomEightPages].Enabled =
                _actions[ActionTypeEnum.ZoomTwelvePages].Enabled = _flexViewer.Paginated && !_flexViewer.ThumbViewActive;

            //
            _actions[ActionTypeEnum.ZoomOnePage].Pressed = hasCurrReport && _flexViewer.PageRows == 1 && _flexViewer.PageColumns == 1;
            _actions[ActionTypeEnum.ZoomTwoPages].Pressed = hasCurrReport && _flexViewer.PageRows == 1 && _flexViewer.PageColumns == 2;
            _actions[ActionTypeEnum.ZoomFourPages].Pressed = (_flexViewer.PageRows == 2) && (_flexViewer.PageColumns == 2);
            _actions[ActionTypeEnum.ZoomEightPages].Pressed = (_flexViewer.PageRows == 2) && (_flexViewer.PageColumns == 4);
            _actions[ActionTypeEnum.ZoomTwelvePages].Pressed = (_flexViewer.PageRows == 3) && (_flexViewer.PageColumns == 4);
            _actions[ActionTypeEnum.ZoomFitToWindow].Pressed = _flexViewer.ZoomMode == FlexViewerZoomMode.WholePage;
            _actions[ActionTypeEnum.PreviewThumbnails].Pressed = _flexViewer.ThumbViewActive;
            _actions[ActionTypeEnum.PreviewOutlines].Pressed = _flexViewer.OutlinePanelVisible;
            _actions[ActionTypeEnum.PreviewParams].Pressed = _flexViewer.ParamPanelVisible;
            _actions[ActionTypeEnum.PreviewPaginated].Pressed = _reportRender != null && _reportRender.Paginated;
            _actions[ActionTypeEnum.Zoom10].Pressed = zf == 10;
            _actions[ActionTypeEnum.Zoom25].Pressed = zf == 25;
            _actions[ActionTypeEnum.Zoom50].Pressed = zf == 50;
            _actions[ActionTypeEnum.Zoom75].Pressed = zf == 75;
            _actions[ActionTypeEnum.Zoom100].Pressed = zf == 100;
            _actions[ActionTypeEnum.Zoom125].Pressed = zf == 125;
            _actions[ActionTypeEnum.Zoom150].Pressed = zf == 150;
            _actions[ActionTypeEnum.Zoom200].Pressed = zf == 200;
            _actions[ActionTypeEnum.Zoom500].Pressed = zf == 500;
            //
            _actions[ActionTypeEnum.SelectAll].Enabled = false;
            //
            _actions[ActionTypeEnum.ErrorListCopy].Enabled = _errorList.CanCopy;
        }

        private void DoPreviewPrint()
        {
            _flexViewer.Print();
        }

        private void DoPreviewView(RibbonItem item)
        {
            if (_flexViewer.Busy)
                return;

            if (item == rbtnPreviewParams)
                _flexViewer.ShowParameters = ((RibbonToggleButton)rbtnPreviewParams).Pressed;
            else if (item == rbtnPreviewThumbnails)
                _flexViewer.ShowThumbnails = ((RibbonToggleButton)rbtnPreviewThumbnails).Pressed;
            else if (item == rbtnPreviewOutlines)
                _flexViewer.ShowOutlines = ((RibbonToggleButton)rbtnPreviewOutlines).Pressed;
            else if (item == rbtnPreviewPaginated)
            {
                if (_reportRender != null)
                {
                    var paginated = ((RibbonToggleButton)rbtnPreviewPaginated).Pressed;
                    _reportRender.Paginated = paginated;
                    _reportRender.RenderAsync();
                }
            }
            //
            else if (item == rbtnZoomFitToWindow)
                _flexViewer.ZoomMode = FlexViewerZoomMode.WholePage;
            else if (item.Parent as RibbonMenu == rbtnZoom)
                _flexViewer.ZoomFactor = int.Parse(((string)item.Tag).Substring(4)) / 100f;
            else if (item == rbtnZoomOnePage)
            {
                _flexViewer.FacingPages = false;
                _flexViewer.PageColumns = 1;
                _flexViewer.PageRows = 1;
            }
            else if (item == rbtnZoomTwoPages)
            {
                _flexViewer.FacingPages = false;
                _flexViewer.PageColumns = 2;
                _flexViewer.PageRows = 1;
            }
        }

        private void DoNavigation(RibbonItem item)
        {
            if (item == rbtnPreviousView)
                _flexViewer.NavigateBackward();
            else if (item == rbtnNextView)
                _flexViewer.NavigateForward();
            else if (item == rbtnFirstPage)
                _flexViewer.PageIndex = 0;
            else if (item == rbtnPreviousPage)
                --_flexViewer.PageIndex;
            else if (item == rbtnNextPage)
                ++_flexViewer.PageIndex;
            else if (item == rbtnLastPage)
                _flexViewer.PageIndex = _flexViewer.PageCount - 1;
        }

        private void DoSetPageNo()
        {
            int v;
            if (int.TryParse(rebPageNo.Text, out v))
                _flexViewer.SetPageIndex(v - 1, true);
        }

        private void DoPreviewTool(RibbonItem item)
        {
            if (item == rbtnHandTool)
            {
                _flexViewer.SelectMouseMode = !rbtnHandTool.Pressed;
            }
            else if (item == rbtnTextSelectTool)
            {
                _flexViewer.SelectMouseMode = rbtnTextSelectTool.Pressed;
            }
            else if (item == rbtnPreviewFind)
            {
                UpdateSearchVisible(!_searchBarVisible);
            }
            // done by timer: UpdateUIPreviewTools(true);
        }

        private void DoPageLayout(RibbonItem item)
        {
            if (_flexViewer.Busy)
                return;

            if (item == rbtnViewSinglePage)
            {
                _flexViewer.Continuous = false;
                _flexViewer.FacingPages = false;
                _flexViewer.ZoomMode = FlexViewerZoomMode.WholePage;
            }
            else if (item == rbtnViewContinuous)
            {
                _flexViewer.Continuous = true;
                _flexViewer.FacingPages = false;
                _flexViewer.ZoomMode = FlexViewerZoomMode.PageWidth;
            }
            else if (item == rbtnViewPagesFacing)
            {
                _flexViewer.Continuous = false;
                _flexViewer.FacingPages = true;
            }
            else if (item == rbtnViewPagesFacingContinuous)
            {
                _flexViewer.Continuous = true;
                _flexViewer.FacingPages = true;
            }
        }

        private void DoRotateView(bool clockwise)
        {
            if (_flexViewer.Busy)
                return;

            _flexViewer.RotateView = clockwise ? s_rotateCW[_flexViewer.RotateView] : s_rotateCCW[_flexViewer.RotateView];
        }

        /// <summary>
        /// Cancels current report generation, but does not exit preview.
        /// </summary>
        private void DoPreviewStop()
        {
            if (!_reportRender.IsDisposed)
                _reportRender.Cancel = true;
        }

        private void DoClosePreview()
        {
            ReportDesignMode = true;
        }

        #region Text Search

        private void DoCloseSearch()
        {
            UpdateSearchVisible(false);
        }

        private void DoSetSearchText()
        {
            _searchText = rebSearchText.Text;
            UpdateSearchTarget();
        }

        private void DoSearchNext()
        {
            SearchNext(true);
        }

        private void DoSearchPrev()
        {
            SearchPrev(true);
        }

        private void DoMatchCase()
        {
            _matchCase = !_matchCase;
            UpdateSearchOptions();
        }

        private void DoWholeWord()
        {
            _matchWholeWord = !_matchWholeWord;
            UpdateSearchOptions();
        }

        void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                _flexViewer.Focus();
                UpdateSearchVisible(false);
                e.Handled = true;
            }
            else if (e.KeyData == Keys.Enter)
            {
                SearchNext(false);
                rebSearchText.TextBox.SelectAll();
                e.Handled = true;
            }
            else if (e.KeyData == Keys.F3)
            {
                SearchNext(false);
                e.Handled = true;
            }
            else if (e.KeyData == (Keys.Shift | Keys.F3))
            {
                SearchPrev(false);
                e.Handled = true;
            }
        }

        void UpdateSearchTarget()
        {
            _flexViewer.ResetSearch();
            bool enabled = !string.IsNullOrEmpty(_searchText);
            rbtnSearchNext.Enabled = enabled;
            rbtnSearchPrev.Enabled = enabled;
        }

        void UpdateSearchOptions()
        {
            _flexViewer.ResetSearch();
            rbtnMatchCase.Pressed = _matchCase;
            rbtnMatchWholeWord.Pressed = _matchWholeWord;
        }

        void UpdateSearchVisible(bool visible)
        {
            var fvp = _flexViewer;
            if (_searchBarVisible != visible)
            {
                _searchBarVisible = visible;
                foreach (RibbonItem ri in sbMain.LeftPaneItems)
                {
                    if (ri.Name == "rlblStatusBarText")
                        continue;
                    ri.Visible = visible;
                }
                if (!visible)
                {
                    if (fvp.HasPages)
                    {
                        fvp.ResetSearch();
                    }
                    _searchText = string.Empty;
                    rebSearchText.Text = _searchText;
                    ShowStatus(Strings.MainForm.Ready);
                    fvp.Focus();
                }
                UpdateUIPreviewTools(true);
            }
            if (visible)
            {
                Application.DoEvents();
                rebSearchText.TextBox.Focus();
                rebSearchText.TextBox.SelectAll();
                rlblStatusBarText.Text = string.Empty;
            }
        }

        void SearchNext(bool focusPane)
        {
            var fvp = _flexViewer;
            if (!string.IsNullOrEmpty(_searchText))
            {
                if (!fvp.SearchStarted)
                {
                    fvp.SearchText(_searchText, _matchWholeWord, _matchCase, false);
                }
                else
                {
                    fvp.SearchNext();
                }
                if (focusPane)
                {
                    fvp.Focus();
                }
            }
        }

        void SearchPrev(bool focusPane)
        {
            var fvp = _flexViewer;
            if (!string.IsNullOrEmpty(_searchText))
            {
                if (!fvp.SearchStarted)
                {
                    fvp.SearchText(_searchText, _matchWholeWord, _matchCase, true);
                }
                else
                {
                    fvp.SearchPrevious();
                }
                if (focusPane)
                {
                    fvp.Focus();
                }
            }
        }

        #endregion

        private void DoPreviewExport(RibbonItem item)
        {
            string tag = item.Tag as string;
            if (tag == null)
                return;

            ExportReport(_reportRender, tag);
        }

        #region Exporting (works both in design and preview modes)
        /// <summary>
        /// Holds description of an export filter for the designer/viewer.
        /// Keys are ribbon buttons' tags.
        /// </summary>
        private class ExportProvider
        {
            public ExportProvider(string key)
            {
                Key = key;
                PreviewDefault = true;
            }
            public DocExp.ExportFilter NewFilter()
            {
                var filter = (DocExp.ExportFilter)Provider.NewExporter();
                if (SetupFilter != null)
                    SetupFilter(filter);
                return filter;
            }
            /// <summary>
            /// Keys should match ribbon buttons' tags.
            /// </summary>
            public string Key { get; private set; }
            public DocExp.ExportProvider Provider { get; set; }
            public string Name { get; set; }
            public string Extension { get { return Provider.DefaultExtension; } }
            public bool PreviewDefault { get; set; }
            public Action<DocExp.ExportFilter> SetupFilter { get; set; }
        }

        // Keys ("_PDF" etc) correspond to ribbon buttons' tags.
        private static readonly List<ExportProvider> s_exportProviders = new List<ExportProvider>()
        {
            new ExportProvider("_PDF_A")
            {
                Provider = DocExp.ExportProvider.PdfExportProvider,
                Name = Strings.MainForm.ExportToPdfAFormatName,
                SetupFilter = (f_ => ((DocExp.PdfFilter)f_).PdfACompatible = true)
            },
            new ExportProvider("_PDF")
            {
                Provider = DocExp.ExportProvider.PdfExportProvider,
                Name = Strings.MainForm.ExportToPdfFormatName,
                SetupFilter = (f_ => { ((DocExp.PdfFilter)f_).PdfACompatible = false; ((DocExp.PdfFilter)f_).EmbedFonts = false; })
            },
            new ExportProvider("_PagedHTML")
            {
                Provider = DocExp.ExportProvider.HtmlExportProvider, 
                Name = Strings.MainForm.ExportToPagedHtmlFormatName,
                SetupFilter = (f_ => ((DocExp.HtmlFilter)f_).Paged = true)
            },
            new ExportProvider("_HTML")
            {
                Provider = DocExp.ExportProvider.HtmlExportProvider, 
                Name = Strings.MainForm.ExportToPlainHtmlFormatName,
                SetupFilter = (f_ => ((DocExp.HtmlFilter)f_).Paged = false)
            },
            new ExportProvider("_RTF")
            {
                Provider = DocExp.ExportProvider.RtfExportProvider,
                Name = DocExp.ExportProvider.RtfExportProvider.FormatName,
            },
            new ExportProvider("_DOCX")
            {
                Provider = DocExp.ExportProvider.DocxExportProvider,
                Name = DocExp.ExportProvider.DocxExportProvider.FormatName,
            },
            //new ExportProvider("_XLS")
            //{
            //    Provider = DocExp.ExportProvider.XlsExportProvider,
            //    Name = DocExp.ExportProvider.XlsExportProvider.FormatName,
            //},
            new ExportProvider("_XLSX")
            {
                Provider = DocExp.ExportProvider.XlsxExportProvider,
                Name = DocExp.ExportProvider.XlsxExportProvider.FormatName,
            },
            // Image exports:
            new ExportProvider("_ZIP")
            {
                Provider = DocExp.ExportProvider.MetafileExportProvider,
                Name = DocExp.ExportProvider.MetafileExportProvider.FormatName,
                PreviewDefault = false, // normally there would be no reasonable way to "preview" a zipped metafiles archive
            },
            new ExportProvider("_TIFF")
            {
                Provider = DocExp.ExportProvider.TiffExportProvider,
                Name = DocExp.ExportProvider.TiffExportProvider.FormatName,
            },
            new ExportProvider("_BMP")
            {
                Provider = DocExp.ExportProvider.BmpExportProvider,
                Name = DocExp.ExportProvider.BmpExportProvider.FormatName,
            },
            new ExportProvider("_PNG")
            {
                Provider = DocExp.ExportProvider.PngExportProvider,
                Name = DocExp.ExportProvider.PngExportProvider.FormatName,
            },
            new ExportProvider("_JPEG")
            {
                Provider = DocExp.ExportProvider.JpegExportProvider,
                Name = DocExp.ExportProvider.JpegExportProvider.FormatName,
            },
            new ExportProvider("_GIF")
            {
                Provider = DocExp.ExportProvider.GifExportProvider,
                Name = DocExp.ExportProvider.GifExportProvider.FormatName,
            },
        };

        private static readonly string s_exportDialogFilter = BuildExportDialogFilter();

        private static string BuildExportDialogFilter()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var provider in s_exportProviders)
                sb.AppendFormat("{0} (*.{1})|*.{1}|", provider.Name, provider.Extension);
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
        private void ExportReport()
        {
            if (ReportDesignMode)
            {
                if (_flexDesigner.Report != null)
                {
                    var expRep = new C1FlexReport();
                    expRep.CopyDefinitionFrom(_flexDesigner.Report);
                    ExportReport(expRep, null);
                }
            }
            else
                ExportReport(_reportRender, null);
        }
        private void ExportReport(C1FlexReport report, string providerKey)
        {
            if (report == null)
                return;

            int filterIndex = s_exportProviders.FindIndex(ep_ => ep_.Key == providerKey) + 1;

            // get export file name
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.DereferenceLinks = true;
                dlg.Title = Strings.MainForm.ExportReportDlgTitle;
                dlg.FileName = Regex.Replace(report.ReportName, @"[/:\\\.""]", "_"); // was StringParser.CheckFileName
                dlg.Filter = s_exportDialogFilter;
                dlg.FilterIndex = filterIndex;
                DialogResult dr = dlg.ShowDialog();
                if (dr != DialogResult.OK)
                    return;

                // autosave
                if (_dirty && _autoSave)
                    SaveFile(false);

                int index = dlg.FilterIndex - 1;
                if (index < 0 || index >= s_exportProviders.Count)
                    index = 0;
                ExportReport(report, dlg.FileName, s_exportProviders[index]);
            }
        }
        private void ExportReport(C1FlexReport report, string fileName, ExportProvider provider)
        {
            if (report == null)
                return;

            try
            {
                Cursor = Cursors.WaitCursor;
                ShowStatus(string.Format(Strings.MainForm.ExportingFmt, report.ReportName, fileName));
                var exporter = provider.NewFilter();
                exporter.FileName = fileName;
                exporter.ShowOptions = true;
                exporter.Preview = _openExportedFile && provider.PreviewDefault;
                report.RenderToFilter(exporter);
            }
            catch (Exception e)
            {
                MessageForm.Warn(string.Format(Strings.MainForm.ErrCannotExportReportFmt, fileName, e.Message));
            }
            finally
            {
                ShowStatus(Strings.MainForm.Ready);
                Cursor = Cursors.Default;
            }
        }
        #endregion
    }
}
