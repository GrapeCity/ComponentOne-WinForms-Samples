//----------------------------------------------------------------------------
// MainForm_Actions.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
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
using System.Threading;

using C1.Win.C1Ribbon;
using FlexReportDesignerApp.Util;
using C1.Win.Localization;
using C1.Win.C1Command;

using C1.Win.FlexReport;
using Flex = C1.Win.FlexReport;
using Doc = C1.Win.C1Document;
using C1.Win.FlexReport.FlexDesigner;

namespace FlexReportDesignerApp
{
    public partial class MainForm
    {
        // NOTE: actions are associated with ribbon items via item.Tag.
        private enum ActionTypeEnum
        {
            New,
            Open,
            Close,
            Save,
            SaveAs,
            Import,
            Export,

            AlignCenter,
            AlignMiddle,
            AlignLeft,
            AlignRight,
            AlignTop,
            AlignBottom,

            GroupSort,
            Database,
            ReportInfo,
            ScriptEditor,

            Cut,
            Copy,
            Paste,
            Delete,
            Undo,
            Redo,
            SelectAll,

            ExportHtml,
            ExportPdf,
            ExportRtf,
            ExportText,
            ExportXls,
            ExportMore,

            FontName,
            FontSize,
            FontSizeDown,
            FontSizeUp,
            FontBold,
            FontItalic,
            FontUnderline,
            TextAlignGeneral,
            TextAlignLeft,
            TextAlignCenter,
            TextAlignRight,
            TextAlignJustify,
            TextColor,
            FillColor,

            Styles,
            ApplyStyleToSelection,
            FormatAsTableRow,
            SnapToGrid,
            ShowGrid,
            GridProperties,
            LockFields,

            PreviousView,
            NextView,
            FirstPage,
            PreviousPage,
            NextPage,
            LastPage,
            EditPageNo,
            LblPageCount,

            PageSize,
            PageSetup,
            PagePortrait,
            PageLandscape,

            BringToFront,
            SendToBack,
            EqualHorizontalSpacing,
            EqualVerticalSpacing,
            IncreaseHorizontalSpacing,
            IncreaseVerticalSpacing,
            DecreaseHorizontalSpacing,
            DecreaseVerticalSpacing,

            PreviewPrint,

            ViewSinglePage,
            ViewContinuous,
            ViewPagesFacing,
            ViewPagesFacingContinuous,
            RotateViewCW,
            RotateViewCCW,

            LblZoom,
            ZoomValue,

            HandTool,
            TextSelectTool,
            PreviewFind,

            CloseSearch,
            SearchTextBox,
            SearchNext,
            SearchPrev,
            MatchCase,
            MatchWholeWord,

            PropertiesAlphabetical,
            PropertiesCategorized,

            NewReportEmpty,
            NewReportWizard,
            PasteReport,
            CutReport,
            CopyReport,
            DeleteReport,
            MoveReportDown,
            MoveReportUp,

            AlignToGrid,
            SizeToGrid,
            HeightToShortest,
            HeightToTallest,
            WidthToNarrowest,
            WidthToWidest,

            ShowPropertyGrid,
            ShowDataTree,

            Zoom,
            ZoomOnePage,
            ZoomTwoPages,
            ZoomMorePages,
            ZoomFourPages,
            ZoomEightPages,
            ZoomTwelvePages,
            ZoomFitToWindow,
            Zoom10,
            Zoom25,
            Zoom50,
            Zoom75,
            Zoom100,
            Zoom125,
            Zoom150,
            Zoom200,
            Zoom500,
            //
            PreviewThumbnails,
            PreviewOutlines,
            PreviewParams,
            PreviewPaginated,

            ModeDesign,
            ModePreview,

            SelectedReport,

            BorderColor,
            BorderWidth,
            BorderStyle,
            BorderStyleNone,
            BorderStyleSolid,
            BorderStyleDash,
            BorderStyleDot,
            BorderStyleDashDot,
            BorderStyleDashDotDot,
            BorderProperties,

            PreviewStop,
            PreviewRefresh,

            SubSectionAdd,
            SubSectionRemove,
            SubSectionMoveUp,
            SubSectionMoveDown,

            CaptionsVisibility,
            CaptionsVisibilitySection,
            CaptionsVisibilityAll,
            CaptionsVisibilityHairline,
            CaptionsVisibilityHidden,
            CaptionsExpandAll,
            CaptionsCollapseAll,

            DataSources,
            ShowErrorList,
            ErrorListCopy,
        }

        private class UIAction
        {
            public bool Enabled;
            public bool Pressed;
            public string Text;
            public Color Color;
            public int Value;
        }

        private class Actions
        {
            private UIAction[] _items;

            #region Constructors
            public Actions()
            {
                _items = new UIAction[Enum.GetValues(typeof(ActionTypeEnum)).Length];
                for (int i = 0; i < _items.Length; i++)
                    _items[i] = new UIAction();
            }
            #endregion

            #region Public properties
            public UIAction this[ActionTypeEnum index]
            {
                get { return _items[(int)index]; }
            }
            #endregion
        }

        private bool TryGetAction(string s, out UIAction a)
        {
            ActionTypeEnum actionType;
            if (Enum.TryParse<ActionTypeEnum>(s, out actionType))
            {
                a = _actions[actionType];
                return true;
            }
            else
            {
                System.Diagnostics.Debug.Assert(false, "Unknown actions are a waste of electrons.");
                a = null;
                return false;
            }
        }

        /// <summary>
        /// Suspends ribbon updates (this avoids ribbon flicker/speeds up things A LOT),
        /// also makes sure updating ribbon items does not cause ribbon event handling
        /// (i.e. changes to the report due to ribbon items "pressing" etc.).
        /// </summary>
        private void BeginRibbonUpdates()
        {
            System.Diagnostics.Debug.Assert(_suppressRibbonEventActions >= 0);
            ++_suppressRibbonEventActions;
            rbnMain.BeginUpdate();
        }
        /// <summary>
        /// Resumes ribbon updates and normal ribbon item events handling.
        /// (A counter is used to support nested calls.)
        /// </summary>
        private void EndRibbonUpdates()
        {
            rbnMain.EndUpdate();
            --_suppressRibbonEventActions;
        }

        /// <summary>
        /// Initializes static actions' stuff (not dependent on the current state).
        /// </summary>
        private void InitActions()
        {
            _actions[ActionTypeEnum.BorderStyleNone].Value = (int)Doc.DashStyle.None;
            _actions[ActionTypeEnum.BorderStyleSolid].Value = (int)Doc.DashStyle.Solid;
            _actions[ActionTypeEnum.BorderStyleDash].Value = (int)Doc.DashStyle.Dash;
            _actions[ActionTypeEnum.BorderStyleDot].Value = (int)Doc.DashStyle.Dot;
            _actions[ActionTypeEnum.BorderStyleDashDot].Value = (int)Doc.DashStyle.DashDot;
            _actions[ActionTypeEnum.BorderStyleDashDotDot].Value = (int)Doc.DashStyle.DashDotDot;
            //
            _actions[ActionTypeEnum.CaptionsVisibilityAll].Value = (int)CaptionsVisibility.All;
            _actions[ActionTypeEnum.CaptionsVisibilitySection].Value = (int)CaptionsVisibility.Section;
            _actions[ActionTypeEnum.CaptionsVisibilityHairline].Value = (int)CaptionsVisibility.Hairline;
            _actions[ActionTypeEnum.CaptionsVisibilityHidden].Value = (int)CaptionsVisibility.Hidden;
            //
            _actions[ActionTypeEnum.ShowErrorList].Enabled = true;
        }

        private void UpdateState()
        {
            if (ReportDesignMode)
                UpdateStateDesignMode();
            else
                UpdateStatePreviewMode();
        }

        private void UpdateStateDesignMode()
        {
            System.Diagnostics.Debug.Assert(ReportDesignMode);
            System.Diagnostics.Debug.Assert(!IsPreviewRendering);

            bool hasReports = _reportList.Items.Count > 0;
            bool hasCurrentReport = _flexDesigner.Report != null;
            bool hasVisualObjects = _flexDesigner.HasSelectedVisualObjects;
            int selectedFieldsCount = _flexDesigner.SelectedFields.Count;
            bool inplaceEditing = _flexDesigner.IsInplaceEditing;

            int zf = (int)Math.Round(_flexDesigner.ZoomFactor * 100);
            // update actions
            _actions[ActionTypeEnum.New].Enabled = true;
            _actions[ActionTypeEnum.Open].Enabled = true;
            _actions[ActionTypeEnum.Close].Enabled = hasCurrentReport;
            _actions[ActionTypeEnum.Save].Enabled = hasCurrentReport;
            _actions[ActionTypeEnum.SaveAs].Enabled = hasCurrentReport;
            _actions[ActionTypeEnum.Import].Enabled = true;
            _actions[ActionTypeEnum.Export].Enabled = hasCurrentReport;

            // stop/refresh preview:
            _actions[ActionTypeEnum.PreviewStop].Enabled = false;
            _actions[ActionTypeEnum.PreviewRefresh].Enabled = false;

            //
            _actions[ActionTypeEnum.AlignCenter].Enabled =
                _actions[ActionTypeEnum.AlignMiddle].Enabled =
                _actions[ActionTypeEnum.AlignLeft].Enabled =
                _actions[ActionTypeEnum.AlignRight].Enabled =
                _actions[ActionTypeEnum.AlignTop].Enabled =
                _actions[ActionTypeEnum.AlignBottom].Enabled = !_flexDesigner.Locked && selectedFieldsCount > 1;

            //
            _actions[ActionTypeEnum.DataSources].Enabled =
                _actions[ActionTypeEnum.GroupSort].Enabled =
                _actions[ActionTypeEnum.Database].Enabled =
                _actions[ActionTypeEnum.ReportInfo].Enabled =
                _actions[ActionTypeEnum.ScriptEditor].Enabled = !inplaceEditing && hasCurrentReport;

            //
            _actions[ActionTypeEnum.ModeDesign].Enabled = true;
            _actions[ActionTypeEnum.ModeDesign].Pressed = true;
            _actions[ActionTypeEnum.ModePreview].Enabled = !inplaceEditing && hasCurrentReport;
            _actions[ActionTypeEnum.ModePreview].Pressed = false;
            //
            _actions[ActionTypeEnum.Cut].Enabled = _flexDesigner.CanCut;
            _actions[ActionTypeEnum.Copy].Enabled = _flexDesigner.CanCopy;
            _actions[ActionTypeEnum.Paste].Enabled = _flexDesigner.CanPaste;
            _actions[ActionTypeEnum.Delete].Enabled = _flexDesigner.CanDelete;
            _actions[ActionTypeEnum.Undo].Enabled = _flexDesigner.CanUndo;
            _actions[ActionTypeEnum.Redo].Enabled = _flexDesigner.CanRedo;

            //
            _actions[ActionTypeEnum.ExportHtml].Enabled =
                _actions[ActionTypeEnum.ExportPdf].Enabled =
                _actions[ActionTypeEnum.ExportRtf].Enabled =
                _actions[ActionTypeEnum.ExportText].Enabled =
                _actions[ActionTypeEnum.ExportXls].Enabled =
                _actions[ActionTypeEnum.ExportMore].Enabled = false;

            //
            if (selectedFieldsCount > 0) // design mode, have selected fields
            {
                bool canSetTextStyles = _flexDesigner.CanSetTextStyles();
                string fontName = _flexDesigner.GetFontName();
                float? fontSize = _flexDesigner.GetFontSize();
                bool? fontBold, fontItalic, fontUnderline;
                _flexDesigner.GetFontStyle(out fontBold, out fontItalic, out fontUnderline);
                var textAlignHorz = _flexDesigner.GetTextAlignHorz();
                Color? foreColor = _flexDesigner.GetForeColor();
                //
                _actions[ActionTypeEnum.FontName].Enabled = canSetTextStyles;
                _actions[ActionTypeEnum.FontName].Text = fontName;
                _actions[ActionTypeEnum.FontSize].Enabled = canSetTextStyles;
                _actions[ActionTypeEnum.FontSize].Text = fontSize == null ? string.Empty : fontSize.ToString();
                _actions[ActionTypeEnum.FontSizeDown].Enabled = canSetTextStyles;
                _actions[ActionTypeEnum.FontSizeUp].Enabled = canSetTextStyles;
                //
                _actions[ActionTypeEnum.FontBold].Enabled = canSetTextStyles;
                _actions[ActionTypeEnum.FontBold].Pressed = fontBold == true;
                _actions[ActionTypeEnum.FontItalic].Enabled = canSetTextStyles;
                _actions[ActionTypeEnum.FontItalic].Pressed = fontItalic == true;
                _actions[ActionTypeEnum.FontUnderline].Enabled = canSetTextStyles;
                _actions[ActionTypeEnum.FontUnderline].Pressed = fontUnderline == true;
                //
                _actions[ActionTypeEnum.TextAlignGeneral].Enabled = !inplaceEditing && canSetTextStyles;
                _actions[ActionTypeEnum.TextAlignGeneral].Pressed = textAlignHorz.HasValue && textAlignHorz.Value == DesignerUtil.TextAlignHorz.General;
                _actions[ActionTypeEnum.TextAlignLeft].Enabled = !inplaceEditing && canSetTextStyles;
                _actions[ActionTypeEnum.TextAlignLeft].Pressed = textAlignHorz.HasValue && textAlignHorz.Value == DesignerUtil.TextAlignHorz.Left;
                _actions[ActionTypeEnum.TextAlignCenter].Enabled = !inplaceEditing && canSetTextStyles;
                _actions[ActionTypeEnum.TextAlignCenter].Pressed = textAlignHorz.HasValue && textAlignHorz.Value == DesignerUtil.TextAlignHorz.Center;
                _actions[ActionTypeEnum.TextAlignRight].Enabled = !inplaceEditing && canSetTextStyles;
                _actions[ActionTypeEnum.TextAlignRight].Pressed = textAlignHorz.HasValue && textAlignHorz.Value == DesignerUtil.TextAlignHorz.Right;
                _actions[ActionTypeEnum.TextAlignJustify].Enabled = !inplaceEditing && canSetTextStyles;
                _actions[ActionTypeEnum.TextAlignJustify].Pressed = textAlignHorz.HasValue && textAlignHorz.Value == DesignerUtil.TextAlignHorz.Justify;
                //
                _actions[ActionTypeEnum.TextColor].Enabled = canSetTextStyles; // was foreColor != null; -- not sure why, i want to be able to change multiple colors even if they were different initially
                _actions[ActionTypeEnum.TextColor].Color = foreColor == null ? Color.Empty : (Color)foreColor;

                //
                _actions[ActionTypeEnum.ApplyStyleToSelection].Enabled = !inplaceEditing && selectedFieldsCount > 1;
                _actions[ActionTypeEnum.FormatAsTableRow].Enabled = !inplaceEditing && selectedFieldsCount > 1;
            }
            else // design mode but no selected fields
            {
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
                //
                _actions[ActionTypeEnum.ApplyStyleToSelection].Enabled = false;
                _actions[ActionTypeEnum.FormatAsTableRow].Enabled = false;
            }
            // Background:
            var background = _flexDesigner.GetBackground();
            Color? backColor = background is Doc.C1SolidBrush ? ((Doc.C1SolidBrush)background).Color : (Color?)null;
            //
            if (_flexDesigner.IsInplaceParagraphEditing)
            {
                _actions[ActionTypeEnum.FillColor].Enabled = true;
                _actions[ActionTypeEnum.FillColor].Color = backColor == null ? Color.Empty : (Color)backColor;
            }
            else
            {
                _actions[ActionTypeEnum.FillColor].Enabled = !inplaceEditing && hasVisualObjects;
                _actions[ActionTypeEnum.FillColor].Color = backColor == null ? Color.Empty : (Color)backColor;
            }
            // borders:
            Doc.DashStyle? borderStyle = _flexDesigner.GetBorderStyle();
            double? borderWidth = _flexDesigner.GetBorderWidth();
            Color? borderColor = _flexDesigner.GetBorderColor();
            //
            _actions[ActionTypeEnum.BorderProperties].Enabled = !inplaceEditing && hasVisualObjects;
            _actions[ActionTypeEnum.BorderColor].Enabled = !inplaceEditing && hasVisualObjects;
            _actions[ActionTypeEnum.BorderColor].Color = borderColor == null ? Color.Empty : (Color)borderColor;
            _actions[ActionTypeEnum.BorderStyle].Enabled = !inplaceEditing && hasVisualObjects;
            _actions[ActionTypeEnum.BorderStyle].Text = borderStyle.ToString();
            _actions[ActionTypeEnum.BorderStyle].Value = borderStyle.HasValue ? (int)borderStyle.Value : -1;
            _actions[ActionTypeEnum.BorderWidth].Enabled = !inplaceEditing && hasVisualObjects;
            _actions[ActionTypeEnum.BorderWidth].Text = borderWidth.HasValue ? borderWidth.ToString() : string.Empty;
            // BorderStyle:
            _actions[ActionTypeEnum.BorderStyleNone].Enabled = !inplaceEditing && hasVisualObjects;
            _actions[ActionTypeEnum.BorderStyleSolid].Enabled = !inplaceEditing && hasVisualObjects;
            _actions[ActionTypeEnum.BorderStyleDash].Enabled = !inplaceEditing && hasVisualObjects;
            _actions[ActionTypeEnum.BorderStyleDot].Enabled = !inplaceEditing && hasVisualObjects;
            _actions[ActionTypeEnum.BorderStyleDashDot].Enabled = !inplaceEditing && hasVisualObjects;
            _actions[ActionTypeEnum.BorderStyleDashDotDot].Enabled = !inplaceEditing && hasVisualObjects;
            //
            _actions[ActionTypeEnum.SubSectionAdd].Enabled = _flexDesigner.CanAddSubSection;
            _actions[ActionTypeEnum.SubSectionRemove].Enabled = _flexDesigner.CanDeleteSubSection;
            _actions[ActionTypeEnum.SubSectionMoveUp].Enabled = _flexDesigner.CanMoveSubSection(false);
            _actions[ActionTypeEnum.SubSectionMoveDown].Enabled = _flexDesigner.CanMoveSubSection(true);
            //
            _actions[ActionTypeEnum.Styles].Enabled = !inplaceEditing && hasCurrentReport;
            //
            var prefs = _flexDesigner.Preferences;
            _actions[ActionTypeEnum.SnapToGrid].Enabled = !inplaceEditing;
            _actions[ActionTypeEnum.SnapToGrid].Pressed = prefs.GridSnap;
            _actions[ActionTypeEnum.ShowGrid].Enabled = !inplaceEditing;
            _actions[ActionTypeEnum.ShowGrid].Pressed = prefs.GridVisible;
            _actions[ActionTypeEnum.GridProperties].Enabled = !inplaceEditing;
            _actions[ActionTypeEnum.LockFields].Enabled = !inplaceEditing;
            _actions[ActionTypeEnum.LockFields].Pressed = _flexDesigner.Locked;

            //
            _actions[ActionTypeEnum.PreviousView].Enabled =
                _actions[ActionTypeEnum.NextView].Enabled =
                _actions[ActionTypeEnum.EditPageNo].Enabled =
                _actions[ActionTypeEnum.LblPageCount].Enabled =
                _actions[ActionTypeEnum.PreviousPage].Enabled =
                _actions[ActionTypeEnum.FirstPage].Enabled =
                _actions[ActionTypeEnum.NextPage].Enabled =
                _actions[ActionTypeEnum.LastPage].Enabled = false;

            //
            _actions[ActionTypeEnum.PageSize].Enabled = !inplaceEditing && hasCurrentReport;
            _actions[ActionTypeEnum.PageSetup].Enabled = !inplaceEditing && hasCurrentReport;
            _actions[ActionTypeEnum.PagePortrait].Enabled = !inplaceEditing && hasCurrentReport;
            _actions[ActionTypeEnum.PagePortrait].Pressed = hasCurrentReport && _flexDesigner.Report.Layout.Orientation == Flex.OrientationEnum.Portrait;
            _actions[ActionTypeEnum.PageLandscape].Enabled = !inplaceEditing && hasCurrentReport;
            _actions[ActionTypeEnum.PageLandscape].Pressed = hasCurrentReport && _flexDesigner.Report.Layout.Orientation == Flex.OrientationEnum.Landscape;

            //
            if (hasCurrentReport && !_flexDesigner.Locked && !inplaceEditing)
            {
                _actions[ActionTypeEnum.BringToFront].Enabled = selectedFieldsCount > 0;
                _actions[ActionTypeEnum.SendToBack].Enabled = selectedFieldsCount > 0;
                _actions[ActionTypeEnum.EqualHorizontalSpacing].Enabled = selectedFieldsCount > 2;
                _actions[ActionTypeEnum.EqualVerticalSpacing].Enabled = selectedFieldsCount > 2;
                _actions[ActionTypeEnum.IncreaseHorizontalSpacing].Enabled = selectedFieldsCount > 1;
                _actions[ActionTypeEnum.IncreaseVerticalSpacing].Enabled = selectedFieldsCount > 1;
                _actions[ActionTypeEnum.DecreaseHorizontalSpacing].Enabled = selectedFieldsCount > 1;
                _actions[ActionTypeEnum.DecreaseVerticalSpacing].Enabled = selectedFieldsCount > 1;
            }
            else
            {
                _actions[ActionTypeEnum.BringToFront].Enabled =
                    _actions[ActionTypeEnum.SendToBack].Enabled =
                    _actions[ActionTypeEnum.EqualHorizontalSpacing].Enabled =
                    _actions[ActionTypeEnum.EqualVerticalSpacing].Enabled =
                    _actions[ActionTypeEnum.IncreaseHorizontalSpacing].Enabled =
                    _actions[ActionTypeEnum.IncreaseVerticalSpacing].Enabled =
                    _actions[ActionTypeEnum.DecreaseHorizontalSpacing].Enabled =
                    _actions[ActionTypeEnum.DecreaseVerticalSpacing].Enabled = false;
            }

            //
            _actions[ActionTypeEnum.PreviewPrint].Enabled =
                _actions[ActionTypeEnum.ViewSinglePage].Enabled =
                _actions[ActionTypeEnum.ViewContinuous].Enabled =
                _actions[ActionTypeEnum.ViewPagesFacing].Enabled =
                _actions[ActionTypeEnum.ViewPagesFacingContinuous].Enabled =
                _actions[ActionTypeEnum.RotateViewCW].Enabled =
                _actions[ActionTypeEnum.RotateViewCCW].Enabled = false;
            //
            _actions[ActionTypeEnum.LblZoom].Enabled = !inplaceEditing;
            _actions[ActionTypeEnum.LblZoom].Text = string.Format(Strings.MainForm.PercentFmt, zf);
            _actions[ActionTypeEnum.ZoomValue].Enabled = !inplaceEditing;
            _actions[ActionTypeEnum.ZoomValue].Value = ZoomFactorToZoomSlider(zf);
            //
            _actions[ActionTypeEnum.HandTool].Enabled =
                _actions[ActionTypeEnum.TextSelectTool].Enabled =
                _actions[ActionTypeEnum.PreviewFind].Enabled = false;
            //
            _actions[ActionTypeEnum.PropertiesAlphabetical].Enabled = true;
            _actions[ActionTypeEnum.PropertiesAlphabetical].Pressed = _propGrid.PropertySort == PropertySort.Alphabetical;
            _actions[ActionTypeEnum.PropertiesCategorized].Enabled = true;
            _actions[ActionTypeEnum.PropertiesCategorized].Pressed = _propGrid.PropertySort == PropertySort.Categorized || _propGrid.PropertySort == PropertySort.CategorizedAlphabetical;

            //
            _actions[ActionTypeEnum.NewReportEmpty].Enabled = !inplaceEditing;
            _actions[ActionTypeEnum.NewReportWizard].Enabled = !inplaceEditing;
            try
            {
                _actions[ActionTypeEnum.PasteReport].Enabled = !inplaceEditing && GetReportDataPresent(Clipboard.GetDataObject());
            }
            catch (Exception ex)
            {
                MessageForm.Error(string.Format(Strings.MainForm.ClipboardErrorFmt, ex.Message));
                _actions[ActionTypeEnum.PasteReport].Enabled = false;
            }
            _actions[ActionTypeEnum.CutReport].Enabled = !inplaceEditing && hasCurrentReport;
            _actions[ActionTypeEnum.CopyReport].Enabled = !inplaceEditing && hasCurrentReport;
            _actions[ActionTypeEnum.DeleteReport].Enabled = !inplaceEditing && hasCurrentReport;
            _actions[ActionTypeEnum.MoveReportDown].Enabled = !inplaceEditing && !SortReportList && _reportList.SelectedIndex >= 0 && _reportList.SelectedIndex < _reportList.Items.Count - 1;
            _actions[ActionTypeEnum.MoveReportUp].Enabled = !inplaceEditing && !SortReportList && _reportList.SelectedIndex > 0;

            _actions[ActionTypeEnum.SelectedReport].Enabled = !inplaceEditing;
            _actions[ActionTypeEnum.SelectedReport].Text = hasCurrentReport ?
                string.Format(Strings.MainForm.ReportFmt, _flexDesigner.Report.ReportName) :
                Strings.MainForm.ReportNotSelected;

            //
            if (hasCurrentReport && !inplaceEditing && !_flexDesigner.Locked)
            {
                _actions[ActionTypeEnum.AlignToGrid].Enabled = selectedFieldsCount > 0;
                _actions[ActionTypeEnum.SizeToGrid].Enabled = selectedFieldsCount > 0;
                _actions[ActionTypeEnum.HeightToShortest].Enabled = selectedFieldsCount > 1;
                _actions[ActionTypeEnum.HeightToTallest].Enabled = selectedFieldsCount > 1;
                _actions[ActionTypeEnum.WidthToNarrowest].Enabled = selectedFieldsCount > 1;
                _actions[ActionTypeEnum.WidthToWidest].Enabled = selectedFieldsCount > 1;
            }
            else
            {
                _actions[ActionTypeEnum.AlignToGrid].Enabled =
                    _actions[ActionTypeEnum.SizeToGrid].Enabled =
                    _actions[ActionTypeEnum.HeightToShortest].Enabled =
                    _actions[ActionTypeEnum.HeightToTallest].Enabled =
                    _actions[ActionTypeEnum.WidthToNarrowest].Enabled =
                    _actions[ActionTypeEnum.WidthToWidest].Enabled = false;
            }

            //
            _actions[ActionTypeEnum.ShowPropertyGrid].Enabled = hasCurrentReport;
            _actions[ActionTypeEnum.ShowDataTree].Enabled = !inplaceEditing && hasCurrentReport;

            //
            _actions[ActionTypeEnum.ZoomOnePage].Enabled =
                _actions[ActionTypeEnum.ZoomTwoPages].Enabled =
                _actions[ActionTypeEnum.ZoomMorePages].Enabled =
                _actions[ActionTypeEnum.ZoomFourPages].Enabled =
                _actions[ActionTypeEnum.ZoomEightPages].Enabled =
                _actions[ActionTypeEnum.ZoomTwelvePages].Enabled =
                _actions[ActionTypeEnum.ZoomFitToWindow].Enabled =
                _actions[ActionTypeEnum.PreviewThumbnails].Enabled =
                _actions[ActionTypeEnum.PreviewOutlines].Enabled =
                _actions[ActionTypeEnum.PreviewParams].Enabled =
                _actions[ActionTypeEnum.PreviewPaginated].Enabled =
                false;
            _actions[ActionTypeEnum.Zoom].Enabled =
                _actions[ActionTypeEnum.Zoom10].Enabled =
                _actions[ActionTypeEnum.Zoom25].Enabled =
                _actions[ActionTypeEnum.Zoom50].Enabled =
                _actions[ActionTypeEnum.Zoom75].Enabled =
                _actions[ActionTypeEnum.Zoom100].Enabled =
                _actions[ActionTypeEnum.Zoom125].Enabled =
                _actions[ActionTypeEnum.Zoom150].Enabled =
                _actions[ActionTypeEnum.Zoom200].Enabled =
                _actions[ActionTypeEnum.Zoom500].Enabled = !inplaceEditing && hasCurrentReport;
            //
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
            _actions[ActionTypeEnum.SelectAll].Enabled = _reportList.Items.Count > 0;
            //
            _actions[ActionTypeEnum.CaptionsVisibility].Enabled =
                _actions[ActionTypeEnum.CaptionsVisibilityAll].Enabled =
                _actions[ActionTypeEnum.CaptionsVisibilitySection].Enabled =
                _actions[ActionTypeEnum.CaptionsVisibilityHairline].Enabled =
                _actions[ActionTypeEnum.CaptionsVisibilityHidden].Enabled =
                _actions[ActionTypeEnum.CaptionsExpandAll].Enabled =
                _actions[ActionTypeEnum.CaptionsCollapseAll].Enabled = !inplaceEditing && hasCurrentReport;
            _actions[ActionTypeEnum.CaptionsVisibilityAll].Pressed = _flexDesigner.CaptionsVisibility == CaptionsVisibility.All;
            _actions[ActionTypeEnum.CaptionsVisibilitySection].Pressed = _flexDesigner.CaptionsVisibility == CaptionsVisibility.Section;
            _actions[ActionTypeEnum.CaptionsVisibilityHairline].Pressed = _flexDesigner.CaptionsVisibility == CaptionsVisibility.Hairline;
            _actions[ActionTypeEnum.CaptionsVisibilityHidden].Pressed = _flexDesigner.CaptionsVisibility == CaptionsVisibility.Hidden;
            //
            _actions[ActionTypeEnum.ErrorListCopy].Enabled = _errorList.CanCopy;
        }

        private bool IsItemsEqual(RibbonItemCollection items1, List<string> items2)
        {
            if (items1.Count != items2.Count)
                return false;

            for (int i = 0; i < items2.Count; i++)
            {
                var item1 = items1[i];
                if (item1 is RibbonSeparator)
                {
                    if (items2[i] != "-")
                        return false;
                }
                else if (item1 is RibbonButton)
                {
                    if (items2[i] != ((RibbonButton)item1).Text)
                        return false;
                }
                else
                    return false;
            }

            return true;
        }

        private void UpdateRibbonItems(IEnumerable items)
        {
            BeginRibbonUpdates();
            foreach (object o in items)
            {
                RibbonItem item = o as RibbonItem;
                if (item == null)
                    continue;

                string s = item.Tag as string;
                if (s == null)
                    continue;

                UIAction a;
                if (!TryGetAction(s, out a))
                    continue;

                item.Enabled = a.Enabled;
                if (item is RibbonToggleButton)
                    ((RibbonToggleButton)item).Pressed = a.Pressed;
                else if (item is RibbonComboBox)
                    ((RibbonComboBox)item).Text = a.Text;
                else if (item is RibbonTextBox)
                    ((RibbonTextBox)item).Text = a.Text;
                else if (item is RibbonTrackBar)
                {
                    RibbonTrackBar rtbar = item as RibbonTrackBar;
                    if (rtbar.Value != a.Value)
                        rtbar.Value = Math.Min(Math.Max(a.Value, rtbar.Minimum), rtbar.Maximum);
                }
                else if (item is RibbonNumericBox)
                {
                    RibbonNumericBox rnbox = item as RibbonNumericBox;
                    rnbox.Value = Math.Min(Math.Max(a.Value, rnbox.Minimum), rnbox.Maximum);
                }
                else if (item is RibbonLabel)
                    ((RibbonLabel)item).Text = a.Text;
                else if (item is RibbonColorPicker)
                    ((RibbonColorPicker)item).Color = a.Color;
            }
            EndRibbonUpdates();
        }

        private void UpdateCommands(bool update)
        {
            if (update)
                UpdateState();
            foreach (C1Command c in chMain.Commands)
            {
                string s = c.UserData as string;
                if (s != null)
                {
                    UIAction a;
                    if (TryGetAction(s, out a))
                    {
                        c.Enabled = a.Enabled;
                        c.Pressed = a.Pressed;
                    }
                }
            }
        }

        /// <summary>
        /// Updates a dropdown list with items from the passed list.
        /// </summary>
        /// <param name="menu">The menu to update.</param>
        /// <param name="items">The new items list.</param>
        /// <param name="enabled">Enable or disable the menu (if items is null or empty, this parameter is ignored unless the menu is a RibbonSplitButton).</param>
        // private void UpdateDropDownField(RibbonDropDownBase menu, List<string> items, bool enabled)
        private void UpdateDropDownField(RibbonDropDownBase menu, List<string> items, bool enabled)
        {
            BeginRibbonUpdates();
            // if (items == null || items.Count == 0)
            if (items == null || items.Count() == 0)
            {
                menu.Enabled = menu is RibbonSplitButton ? enabled : false;
                menu.Items.Clear();
            }
            else
            {
                menu.Enabled = enabled;
                // to imporve perfomance we compare current list of items with items parameter
                if (!IsItemsEqual(menu.Items, items))
                {
                    menu.Items.Clear();
                    foreach (string s in items)
                        if (s == "-")
                            menu.Items.Add(new RibbonSeparator());
                        else
                            menu.Items.Add(new RibbonButton(s));
                }
            }
            EndRibbonUpdates();
        }
        
        /// <summary>
        /// Compares the button items' text in the passed ribbon items collection with the texts
        /// in the passed collection of strings.
        /// This method is used to prevent unneeded re-creation of the same ribbon buttons
        /// for field insert dropdowns only.
        /// </summary>
        /// <param name="items1"></param>
        /// <param name="items2"></param>
        /// <returns></returns>
        private bool IsSameFieldList(RibbonItemCollection items1, IEnumerable<string> items2)
        {
            int i1 = 0;
            foreach (var item2 in items2)
            {
                // skip non-buttons
                RibbonButton item1 = null;
                while (i1 < items1.Count)
                {
                    if (items1[i1] is RibbonButton)
                    {
                        item1 = (RibbonButton)items1[i1];
                        break;
                    }
                    ++i1;
                }
                if (item1 == null)
                    return false;
                if (item1.Text != item2)
                    return false;
                ++i1;
            }
            return i1 == items1.Count;
        }

        /// <summary>
        /// Updates field insert dropdowns.
        /// </summary>
        /// <param name="report">The report.</param>
        /// <param name="ds">The data source.</param>
        /// <param name="text">Whether to list text or byte[] (supposedly image) fields.</param>
        /// <param name="buttons">The list of buttons to update.</param>
        private void UpdateInsertFieldDropdown(C1FlexReport report, bool text, params RibbonDropDownBase[] buttons)
        {
            if (report == null)
            {
                BeginRibbonUpdates();
                foreach (var btn in buttons)
                {
                    btn.Items.Clear();
                    btn.Enabled = false;
                }
                EndRibbonUpdates();
                return;
            }

            DataSource ds = report.DataSource;
            IEnumerable<string> all; // this is used only to compare existing buttons with proposed new ones
            IEnumerable<string> dbFields;
            IEnumerable<string> calcFields;
            var @params = report.Parameters.Select(p_ => p_.Name);
            if (ds != null)
            {
                if (ds.IsDataSourceInfoFetched)
                {
                    if (text)
                        dbFields = ds.DataSourceInfo.TextFields.Select(fi_ => fi_.Name);
                    else
                        dbFields = ds.DataSourceInfo.ImageFields.Select(fi_ => fi_.Name);
                }
                else
                    dbFields = new List<string>(1) { Strings.MainForm.Working };
                calcFields = ds.CalculatedFields.Where(cf_ => (cf_.Type == typeof(byte[])) != text).Select(cf__ => cf__.Name);
                all = dbFields.Concat(calcFields).Concat(@params);
            }
            else
            {
                dbFields = null;
                calcFields = null;
                all = @params;
            }

            BeginRibbonUpdates();
            foreach (var btn in buttons)
            {
                // Trying not to clear/add same items -- I am really not sure how useful this is, check...
                if (IsSameFieldList(btn.Items, all))
                    continue;

                btn.Items.Clear();
                if (dbFields != null && dbFields.Count() > 0)
                {
                    btn.Items.Add(new RibbonLabel(Strings.Common.DbFields));
                    if (!ds.IsDataSourceInfoFetched)
                    {
                        var working = new RibbonButton(Strings.MainForm.Working);
                        working.Enabled = false;
                        btn.Items.Add(working);
                    }
                    else
                        foreach (var f in dbFields)
                            btn.Items.Add(new RibbonButton(f));
                }
                if (calcFields != null && calcFields.Count() > 0)
                {
                    btn.Items.Add(new RibbonLabel(Strings.Common.CalcFields));
                    foreach (var f in calcFields)
                        btn.Items.Add(new RibbonButton(f));
                }
                if (text && @params.Count() > 0)
                {
                    btn.Items.Add(new RibbonLabel(Strings.Common.ReportParams));
                    foreach (var par in @params)
                        btn.Items.Add(new RibbonButton(par));
                }
                btn.Enabled = true;// btn.Items.Count > 0;
            }
            EndRibbonUpdates();
        }

        /// <summary>
        /// Updates all designer db fields' lists.
        /// The actual updating is done in a separate thread so as to improve ui.
        /// </summary>
        /// <param name="report">The report (must not be null).</param>
        /// <param name="async">If true, a separate thread is spawning to retrieve the fields' info.</param>
        private void UpdateDataUI(Flex.C1FlexReport report, bool async)
        {
            Debug.Assert(report != null);

            // Updates the UI. This must be done in the main (UI) thread:
            Action updateUI = () =>
            {
                _dataTree.UpdateFromReport();
                UpdateInsertFieldDropdown(report, true, rbtnFieldDataField, rbtnFieldBarCode, rbtnFieldCheckBox, rbtnFieldRtf);
                UpdateInsertFieldDropdown(report, false, rbtnFieldPicture);
            };
            // Fetches the data source info. That may take a long time, and can be done in a separate thread:
            Action fetchInfo = () =>
            {
                foreach (DataSource dataSource in report.DataSources)
                {
                    // Alexander Manuzin 2016/06/08
                    // looks like here is the best place to
                    // assign dataobjects in _dataSchema to the data sources
                    if (_dataSchema != null && _dataSchema.ContainsKey(dataSource.ConnectionString) && !string.IsNullOrEmpty(dataSource.RecordSource))
                    {
                        DataSet dataSet = (DataSet)_dataSchema[dataSource.ConnectionString];
                        dataSource.SetRecordset(dataSet.Tables[dataSource.RecordSource]);
                    }

                    dataSource.FetchDataSourceInfo(false);
                }
            };

            if (!async)
            {
                fetchInfo();
                updateUI();
                return;
            }
            // Note: we do all-or-nothing, as we must update all data sources for the data tree.
            // So for now, do it all together - but, it might be better to do it individually...tbd.
            if (report.DataSources.All(ds_ => ds_.IsDataSourceInfoFetched))
            {
                updateUI();
                return;
            }
            // Here we go:
            // When doing it async-style, we want to (treating all data sources together for now):
            // - avoid calling updateUI() while we have not fetched data source info yet, if the data sources are local/fast;
            // - avoid calling updateUI() twice for the same state of the data sources;
            // - if a data source is slow, we do want to updateUI() while it is being fetched, and go on while waiting...
            // So, we do create a BackgroundWorker, but wait for its worker just a little bit right away - 
            // if it completes within 100ms, we cancel it, and updateUI right here and are done with it.
            const int timeout = 100;
            var gen = System.Threading.Interlocked.Increment(ref _fieldsUpdaterGeneration);
            var fieldsUpdater = new BackgroundWorker();
            fieldsUpdater.WorkerSupportsCancellation = true; // this is false by default
            var waiter = new AutoResetEvent(false);
            //
            fieldsUpdater.DoWork += (ss, ee) =>
            {
                try
                {
                    fetchInfo();
                    waiter.Set();
                    // we want to give the waiting thread a bit of time to set CancellationPending, if it was still wating.
                    // this should not affect UI for fast data sources because we already signalled...
                    Thread.Sleep(50);
                    ee.Result = (int)ee.Argument;
                    if (((BackgroundWorker)ss).CancellationPending)
                        ee.Cancel = true;
                }
                catch
                {
                    ee.Result = null;
                }
            };
            fieldsUpdater.RunWorkerCompleted += (ss, ee) =>
            {
                try
                {
                    // if error occurred or we became obsolete while getting the fields, don't do anything:
                    if (!ee.Cancelled && ee.Result != null && (int)ee.Result == _fieldsUpdaterGeneration)
                        updateUI();
                    // release background worker:
                    fieldsUpdater = null;
                    ((BackgroundWorker)ss).Dispose();
                }
                catch
                {
                }
            };
            fieldsUpdater.RunWorkerAsync(gen);
            //
            if (waiter.WaitOne(timeout))
            {
                if (fieldsUpdater != null)
                    fieldsUpdater.CancelAsync();
            }
            updateUI();
        }

        private void UpdateUIMode()
        {
            BeginRibbonUpdates();
            UpdateRibbonItems(rgMode.Items);
            EndRibbonUpdates();
        }

        private void UpdateUIFields(bool update, bool async)
        {
            if (update)
                UpdateState();
            BeginRibbonUpdates();
            try
            {
                if (ReportDesignMode)
                {
                    if (_flexDesigner.Report != null && !_flexDesigner.IsInplaceEditing)
                    {
                        rgFields.Enabled = rgCustomFields.Enabled = rgSubSection.Enabled = true;
                        // "field insert" buttons stay pressed for the duration of the field insert operation:
                        if (_flexDesigner.CreateFieldInfo == null)
                        {
                            Action<RibbonItem> setPressed = (ri_) =>
                                {
                                    if (ri_ is RibbonSplitButton)
                                        ((RibbonSplitButton)ri_).Pressed = false;
                                    else if (ri_ is RibbonToggleButton)
                                        ((RibbonToggleButton)ri_).Pressed = (RibbonToggleButton)ri_ == rbtnFieldArrow;
                                };
                            foreach (RibbonItem ri in rgFields.Items)
                                setPressed(ri);
                            foreach (RibbonItem ri in rgCustomFields.Items)
                                setPressed(ri);
                        }
                        //
                        UpdateDataUI(_flexDesigner.Report, async);
                        UpdateDropDownField(rbtnFieldCalculated, CommonFields.GetFieldNames(), true);
                        //
                        List<string> subReports = new List<string>();
                        for (int i = 0; i < _reportList.Items.Count; i++)
                            if (i != _reportList.SelectedIndex)
                                subReports.Add(_reportList.Items[i].ToString());
                        UpdateDropDownField(rbtnFieldSubReport, subReports, true);
                    }
                    else
                    {
                        _dataTree.UpdateFromReport();
                        rgFields.Enabled = rgCustomFields.Enabled = rgSubSection.Enabled = false;
                    }
                }
                else
                    rgFields.Enabled = rgCustomFields.Enabled = rgSubSection.Enabled = false;
            }
            finally
            {
                EndRibbonUpdates();
            }
        }

        private void UpdateUITools(bool update)
        {
            if (update)
                UpdateState();
            BeginRibbonUpdates();
            try
            {
                UpdateRibbonItems(rgTools.Items);
                UpdateRibbonItems(rgPreviewTools.Items);
            }
            finally
            {
                EndRibbonUpdates();
            }
        }

        private void UpdateUIEdit(bool update)
        {
            if (update)
                UpdateState();
            BeginRibbonUpdates();
            try
            {
                UpdateRibbonItems(rgEdit.Items);
            }
            finally
            {
                EndRibbonUpdates();
            }
        }

        private void UpdateUIFont(bool update)
        {
            if (update)
                UpdateState();
            BeginRibbonUpdates();
            try
            {
                UpdateRibbonItems(ribbonToolBar1.Items);
                UpdateRibbonItems(ribbonToolBar2.Items);
            }
            finally
            {
                EndRibbonUpdates();

            }
        }

        private void UpdateUIBorders(bool update)
        {
            if (update)
                UpdateState();
            BeginRibbonUpdates();
            try
            {
                rgBorder.LauncherEnabled = _actions[ActionTypeEnum.BorderProperties].Enabled;
                UpdateRibbonItems(rgBorder.Items);
                UpdateRibbonItems(rgalBorderStyle.Items);
                UpdateRibbonItems(ribbonToolBar5.Items);
                UpdateRibbonItems(ribbonToolBar6.Items);
                rgalBorderStyle.SelectedIndex = -1;
                foreach (RibbonGalleryItem item in rgalBorderStyle.Items)
                {
                    string s = item.Tag as string;
                    if (s == null)
                        continue;

                    UIAction a;
                    if (!TryGetAction(s, out a))
                        continue;

                    if (a.Value == _actions[ActionTypeEnum.BorderStyle].Value)
                    {
                        item.Selected = true;
                        break;
                    }
                }
            }
            finally
            {
                EndRibbonUpdates();
            }
        }

        //
        private void UpdateUIData(bool update)
        {
            if (update)
                UpdateState();
            BeginRibbonUpdates();
            try
            {
                UpdateRibbonItems(rgData.Items);

                // Update data sources menu:
                while (rbtnDataSources.Items.Count > 2)
                    rbtnDataSources.Items.RemoveAt(0);

                var report = _flexDesigner.Report;
                if (report == null)
                    return;

                foreach (DataSource ds in report.DataSources.Reverse())
                {
                    RibbonSplitButton btnDs = new RibbonSplitButton(ds.Name);
                    if (report.DataSourceName == ds.Name)
                        btnDs.Pressed = true;
                    btnDs.Click += (s_, e_) => DoDataSourceSetAsMain(ds);
                    // Make main:
                    RibbonButton btnMain = new RibbonButton(Strings.MainForm.RibbonButtonSetDataSource);
                    if (btnDs.Pressed)
                        btnMain.Enabled = false;
                    else
                        btnMain.Click += (s_, e_) => DoDataSourceSetAsMain(ds);
                    btnDs.Items.Add(btnMain);
                    // Edit:
                    RibbonButton btnEdit = new RibbonButton(Strings.MainForm.RibbonButtonEdit);
                    btnEdit.Click += (s_, e_) => DoDataSourcesAction((Func<DataSource, bool>)DataSources_EditDataSource, ds);
                    btnDs.Items.Add(btnEdit);
                    // Remove:
                    RibbonButton btnRemove = new RibbonButton(Strings.MainForm.RibbonButtonRemove);
                    btnRemove.Click += (s_, e_) => DoDataSourcesAction((Func<DataSource, bool>)DataSources_RemoveDataSource, ds);
                    btnDs.Items.Add(btnRemove);
                    //
                    rbtnDataSources.Items.Insert(0, btnDs);
                }
            }
            finally
            {
                EndRibbonUpdates();
            }
        }

        // update all actions in application menu
        private void UpdateUIApplicationMenu(bool update)
        {
            if (update)
                UpdateState();
            BeginRibbonUpdates();
            try
            {
                UpdateRibbonItems(ramMain.LeftPaneItems);
            }
            finally
            {
                EndRibbonUpdates();
            }
        }

        private void UpdateUIFormat(bool update)
        {
            if (update)
                UpdateState();
            BeginRibbonUpdates();
            try
            {
                UpdateRibbonItems(rgAutoFormat.Items);
            }
            finally
            {
                EndRibbonUpdates();
            }
        }

        private void UpdateUIGrid(bool update)
        {
            if (update)
                UpdateState();
            BeginRibbonUpdates();
            try
            {
                UpdateRibbonItems(rgGrid.Items);
            }
            finally
            {
                EndRibbonUpdates();
            }
        }

        private void UpdateUIControlAlignment(bool update)
        {
            if (update)
                UpdateState();
            BeginRibbonUpdates();
            try
            {
                UpdateRibbonItems(rgControlAlignment.Items);
            }
            finally
            {
                EndRibbonUpdates();
            }
        }

        private void UpdateUISize(bool update)
        {
            if (update)
                UpdateState();
            BeginRibbonUpdates();
            try
            {
                UpdateRibbonItems(rgSize.Items);
            }
            finally
            {
                EndRibbonUpdates();
            }
        }

        private void UpdateUIPageSetup(bool update)
        {
            if (update)
                UpdateState();
            BeginRibbonUpdates();
            try
            {
                UpdateRibbonItems(rgPageLayout1.Items);
                UpdateRibbonItems(rgPageLayout2.Items);
            }
            finally
            {
                EndRibbonUpdates();
            }
        }

        private void UpdateUIPosition(bool update)
        {
            if (update)
                UpdateState();
            BeginRibbonUpdates();
            try
            {
                UpdateRibbonItems(rgPosition.Items);
            }
            finally
            {
                EndRibbonUpdates();
            }
        }

        private void UpdateUIZoom(bool update)
        {
            if (update)
                UpdateState();
            BeginRibbonUpdates();
            try
            {
                UpdateRibbonItems(rgZoom.Items);
                UpdateRibbonItems(rbtnZoom.Items);
                UpdateRibbonItems(sbMain.RightPaneItems);
            }
            finally
            {
                EndRibbonUpdates();
            }
        }
        private void UpdateUICaptionsVisibility(bool update)
        {
            if (update)
                UpdateState();
            BeginRibbonUpdates();
            try
            {
                UpdateRibbonItems(rbmCaptionsVisibility.Items);
            }
            finally
            {
                EndRibbonUpdates();
            }
        }

        private void UpdateUINavigation(bool update)
        {
            if (update)
                UpdateState();
            BeginRibbonUpdates();
            try
            {
                UpdateRibbonItems(ribbonToolBar4.Items);
                UpdateRibbonItems(ribbonToolBar3.Items);
            }
            finally
            {
                EndRibbonUpdates();
            }
        }

        private void UpdateUIPreviewTools(bool update)
        {
            if (update)
                UpdateState();
            BeginRibbonUpdates();
            try
            {
                UpdateRibbonItems(rgPreviewTools.Items);
                // handling UI actions in designer is a mess.
                // for now, cannot think of a better place for this:
                cPreviewCopy.Enabled = _actions[ActionTypeEnum.Copy].Enabled;
            }
            finally
            {
                EndRibbonUpdates();
            }
        }

        private void UpdateUIPreviewStopRefresh(bool update)
        {
            if (update)
                UpdateState();
            BeginRibbonUpdates();
            try
            {
                UpdateRibbonItems(rgStopRefresh.Items);
                rbtnPreviewStop.Visible = rbtnPreviewStop.Enabled;
                rbtnPreviewRefresh.Visible = rbtnPreviewRefresh.Enabled;
            }
            finally
            {
                EndRibbonUpdates();
            }
        }

        private void UpdateUIExport(bool update)
        {
            if (update)
                UpdateState();
            BeginRibbonUpdates();
            try
            {
                rbtnExportHtml.Enabled = _actions[ActionTypeEnum.ExportHtml].Enabled;
                rbtnExportPdf.Enabled = _actions[ActionTypeEnum.ExportPdf].Enabled;
                rbtnExportRtf.Enabled = _actions[ActionTypeEnum.ExportRtf].Enabled;
                rbtnExportXls.Enabled = _actions[ActionTypeEnum.ExportXls].Enabled;
                rbtnExportDocx.Enabled = _actions[ActionTypeEnum.ExportText].Enabled;
                rmExportMore.Enabled = _actions[ActionTypeEnum.ExportMore].Enabled;
            }
            finally
            {
                EndRibbonUpdates();
            }
        }

        private void UpdateUIPreviewStatusBar(bool update)
        {
            if (update)
                UpdateState();
            BeginRibbonUpdates();
            sbMain.BeginUpdate();
            try
            {
                UpdateRibbonItems(sbMain.RightPaneItems);
                UpdateRibbonItems(ribbonToggleGroup1.Items);
            }
            finally
            {
                sbMain.EndUpdate();
                EndRibbonUpdates();
            }
        }

        private void UpdateUISubSection(bool update)
        {
            if (update)
                UpdateState();
            BeginRibbonUpdates();
            try
            {
                rbtnSubSectionAdd.Enabled = _actions[ActionTypeEnum.SubSectionAdd].Enabled;
                rbtnSubSectionRemove.Enabled = _actions[ActionTypeEnum.SubSectionRemove].Enabled;
                rbtnSubSectionMoveUp.Enabled = _actions[ActionTypeEnum.SubSectionMoveUp].Enabled;
                rbtnSubSectionMoveDown.Enabled = _actions[ActionTypeEnum.SubSectionMoveDown].Enabled;
            }
            finally
            {
                EndRibbonUpdates();
            }
        }

        // update UI (_mns, toolbars, etc) - review, maybe call it less
        /// <summary>
        /// Updates the ribbon and other UI elements.
        /// Does NOT update the property grid!
        /// </summary>
        private void UpdateUI(bool dataToo, bool dataAsync = true)
        {
            BeginRibbonUpdates();
            try
            {
                UpdateState();
                //
                UpdateUIApplicationMenu(false);
                //
                UpdateUIMode();
                //
                UpdateUIEdit(false);
                // 
                UpdateUIFont(false);
                //
                UpdateUIBorders(false);
                //
                UpdateUITools(false);
                //
                UpdateUIFormat(false);
                //
                UpdateUIGrid(false);
                //
                UpdateUIControlAlignment(false);
                //
                UpdateUISize(false);
                //
                UpdateUIPageSetup(false);
                //
                UpdateUIPosition(false);
                //
                UpdateUIZoom(false);
                //
                UpdateUICaptionsVisibility(false);
                //
                UpdateUINavigation(false);
                //
                UpdateUIPreviewTools(false);
                //
                UpdateUIPreviewStopRefresh(false);
                //
                UpdateUIExport(false);
                //
                UpdateUIPreviewStatusBar(false);
                //
                UpdateCommands(false);
                //
                UpdateUISubSection(false);
                //
                UpdateFormCaption();
                //
                // Don't know of a good place for this:
                rbtnFieldLegacy.Visible = _insertLegacyField;
                rbtnFieldChart.Visible = _insertLegacyChart;
                //
                if (dataToo)
                {
                    UpdateUIData(false);
                    UpdateUIFields(false, dataAsync);
                }
            }
            finally
            {
                EndRibbonUpdates();
            }
        }

    }
}
