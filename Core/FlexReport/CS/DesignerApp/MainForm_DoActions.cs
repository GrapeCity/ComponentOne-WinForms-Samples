//----------------------------------------------------------------------------
// MainForm_DoActions.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Collections.ObjectModel;
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
using C1.Win.Command;
using C1.Win.Localization;
using C1.Win.Themes;
using C1.Util.Licensing;

using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;
using Doc = C1.Win.Document;
using Flex = C1.Win.FlexReport;

namespace FlexReportDesignerApp
{
    public partial class MainForm
    {
        private void DoNew()
        {
            NewFile();
        }

        private void DoClose()
        {
            NewFile();
        }

        private void DoOpen()
        {
            OpenFile();
        }

        private void DoSave()
        {
            SaveFile(false);
        }

        private void DoSaveAs()
        {
            SaveFile(true);
        }

        private void DoImport()
        {
            ImportFile();
        }

        private void DoExport()
        {
            ExportReport();
        }

        private void DoCopyReport()
        {
            // copy report to clipboard
            if (_reportList.SelectedItem == null)
                return;

            try
            {
                Clipboard.SetDataObject(BuildDataObject());
            }
            catch (Exception ex)
            {
                MessageForm.Error(string.Format(Strings.MainForm.ClipboardErrorFmt, ex.Message));
            }
            UpdateUI(false);
        }


        private void DoCutReport()
        {
            if (_reportList.SelectedItem != null)
            {
                try
                {
                    Clipboard.SetDataObject(BuildDataObject());
                    DeleteReport(true);
                }
                catch (Exception ex)
                {
                    MessageForm.Error(string.Format(Strings.MainForm.ClipboardErrorFmt, ex.Message));
                }
            }
        }

        private void DoPasteReport()
        {
            try
            {
                PasteDataObject(Clipboard.GetDataObject());
            }
            catch (Exception ex)
            {
                MessageForm.Error(string.Format(Strings.MainForm.ClipboardErrorFmt, ex.Message));
            }
        }

        private void DoDeleteReport()
        {
            DeleteReport();
        }

        private void DoMoveReportUp()
        {
            int selectedIndex = _reportList.SelectedIndex;
            if (selectedIndex <= 0)
                return;

            //
            ReportItem ri1 = (ReportItem)_reportList.Items[selectedIndex - 1];
            ReportItem ri2 = (ReportItem)_reportList.Items[selectedIndex];

            _reportList.BeginUpdate();
            ri1.Remove();
            ri2.Remove();
            _reportList.Items.Insert(selectedIndex - 1, ri2);
            _reportList.Items.Insert(selectedIndex, ri1);
            _reportList.FocusedItem = ri2;
            _reportList.EndUpdate();

            //
            MetadataChanged();
        }

        private void DoMoveReportDown()
        {
            int selectedIndex = _reportList.SelectedIndex;
            if (selectedIndex >= _reportList.Items.Count - 1)
                return;

            //
            ReportItem ri1 = (ReportItem)_reportList.Items[selectedIndex + 1];
            ReportItem ri2 = (ReportItem)_reportList.Items[selectedIndex];

            _reportList.BeginUpdate();
            ri1.Remove();
            ri2.Remove();
            _reportList.Items.Insert(selectedIndex, ri1);
            _reportList.Items.Insert(selectedIndex + 1, ri2);
            _reportList.FocusedItem = ri2;
            _reportList.EndUpdate();

            //
            MetadataChanged();
        }

        private void DoUndo()
        {
#if skip_dima
            TextBox tb = _flexDesigner.FieldEditor as TextBox;
            if (tb != null && tb.Focused)
                tb.Undo();
            else
#endif
            _flexDesigner.UndoUndo();
        }

        private void DoRedo()
        {
            _flexDesigner.UndoRedo();
        }

        private void DoExit()
        {
            // DiscardChangesOK is called in form closing, so no need/duplicate here.
            // if (DiscardChangesOK())
            Close();
        }

        private void DoSaveAndExit()
        {
            SaveFile(false);
            Close();
        }

        /// <summary>
        /// This method DELETES the file.
        /// Used (enabled) only when started from VS designer
        /// (i.e. we would be deleting a temp file).
        /// </summary>
        private void DoCancelAndExit()
        {
            AppUtils.DeleteFile(_fileName);
            // prevent saving file in MainForm_FormClosing()
            _dirty = false;
            Close();
        }

        private void DoDesign()
        {
            ReportDesignMode = true;
        }

        private void DoPreview()
        {
            ReportDesignMode = false;
        }

        private void DoEditGroups()
        {
            C1FlexReport report = _flexDesigner.Report;
            if (report == null)
                return;

            using (GroupEditorForm dlg = new GroupEditorForm())
            {
                var undo = _flexDesigner.Undo_CreateSavedState();
                if (dlg.ShowDialog(report) == DialogResult.OK)
                {
                    _flexDesigner.Undo_PushSavedState(undo);
                    _flexDesigner.UpdateFromReport();
                    UpdateUI(true, true);
                    _dataTree.UpdateFromReport();
                }
                else
                    _flexDesigner.Undo_DiscardSavedState(undo);
            }
        }

        private void DoReportInfo()
        {
            // get current report
            ReportItem ri = _reportList.SelectedItem;
            if (ri == null || ri.Report == null)
                return;

            // show form
            using (ReportInfoForm f = new ReportInfoForm())
            {
                if (f.ShowDialog(ri.Report) == DialogResult.OK)
                {
                    // apply new information to current report
                    ri.Report.ReportInfo = f.ReportInfo.Clone();

                    // apply to all reports
                    if (f.ApplyToAll && _reportList.Items.Count > 1)
                    {
                        // confirm first
                        if (MessageForm.Ask(Strings.MainForm.ApplyToAllQ) == DialogResult.Yes)
                        {
                            foreach (ReportItem reportItem in _reportList.Items)
                            {
                                reportItem.Report.ReportInfo = f.ReportInfo.Clone();
                            }
                        }
                    }
                    _flexDesigner.CreateFieldInfo = null;
                }
            }
        }

        private void DoScriptEditor()
        {
            C1FlexReport report = _flexDesigner.Report;
            if (report == null)
                return;

            var state = _flexDesigner.Undo_CreateSavedState();
            object result;
            var contextName = EditorScriptContextBase.MakeContextName(report.DataSourceName, ScriptEditorContextKind.ReportScript);
            if (EditScriptInternal(report, contextName, null, report, "GlobalScripts", null, false, out result))
                _flexDesigner.Undo_PushSavedState(state);
            else
                _flexDesigner.Undo_DiscardSavedState(state);
        }

        private void DoSetFontName()
        {
            // check font name
            string fontName = rcbFontName.Text;
            using (InstalledFontCollection ifc = new InstalledFontCollection())
            {
                foreach (FontFamily ff in ifc.Families)
                    if (ff.Name == fontName)
                    {
                        Designer_DoSetFontName(fontName);
                        break;
                    }
            }
        }

        private void DoSetFontSize()
        {
            float fontSize;
            if (float.TryParse(rcbFontSize.Text, out fontSize) || float.TryParse(rcbFontSize.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out fontSize))
                Designer_DoSetFontSize(fontSize, true);
        }

        private void DoFontStyle(RibbonItem item, bool on)
        {
            if (item == rbtnFontSizeDown)
                Designer_DoSetFontSize(-1, false);
            else if (item == rbtnFontSizeUp)
                Designer_DoSetFontSize(1, false);
            else if (item == rbtnFontBold)
                Designer_DoSetFontStyle(on, null, null); //rbtnFontBold.Pressed
            else if (item == rbtnFontItalic)
                Designer_DoSetFontStyle(null, on, null); //rbtnFontBold.Pressed
            else if (item == rbtnFontUnderline)
                Designer_DoSetFontStyle(null, null, on); //rbtnFontUnderline.Pressed
            else
                System.Diagnostics.Debug.Assert(false);
        }

        private void DoTextAlign(RibbonItem item)
        {
            Flex.FieldAlignEnum align;
            if (item == rbtnTextAlignGeneral)
                align = FieldAlignEnum.General;
            else if (item == rbtnTextAlignLeft)
                align = FieldAlignEnum.LeftTop;
            else if (item == rbtnTextAlignCenter)
                align = FieldAlignEnum.CenterTop;
            else if (item == rbtnTextAlignRight)
                align = FieldAlignEnum.RightTop;
            else if (item == rbtnTextAlignJustify)
                align = FieldAlignEnum.JustTop;
            else
            {
                System.Diagnostics.Debug.Assert(false);
                align = FieldAlignEnum.LeftTop;
            }
            Designer_DoSetTextAlign(align, true, false);
        }

        #region Borders
        private void rgBorder_DialogLauncherClick(object sender, EventArgs e)
        {
            var selection = _flexDesigner.SelectedVisualObjects;
            if (selection.Count == 0)
                return;

            using (BordersForm dlg = new BordersForm(_flexDesigner.GetBorder()))
            {
                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    _flexDesigner.DoSetBorder(dlg.Border);
            }
        }

        private void DoBorderColor()
        {
            _flexDesigner.DoSetBorderColor(rclrBorderColor.Color);
        }

        private void DoBorderWidth()
        {
            double value;
            if (!double.TryParse(rcmbBorderWidth.Text, out value) || value < 0)
                value = 0;

            _flexDesigner.DoSetBorderWidth(value);
        }

        private void DoBorderStyle(RibbonGalleryItem rgi)
        {
            UIAction a;
            if (!TryGetAction(rgi.Tag as string, out a))
                return;

            Doc.DashStyle borderStyle;
            try
            {
                borderStyle = (Doc.DashStyle)a.Value;
            }
            catch
            {
                return;
            }
            _flexDesigner.DoSetBorderStyle(borderStyle);
        }

        private void BorderWidthSetup()
        {
            const string Sample = "Hairline"; // should be not smaller than the biggest text
            const int PadX = 4;
            const int PadY = 3;
            const int Gap = 8; // gap between text and line
            const int LineLength = 64;

            RibbonItemCollection items = rcmbBorderWidth.Items;
            items.BeginUpdate();
            foreach (BordersForm.BorderWidthItem bwi in BordersForm.s_borderWidths)
            {
                RibbonButton item = new RibbonButton(bwi.Width.ToString());
                item.OwnerDraw = true;
                item.MeasureItem += (ss, ee) =>
                {
                    SizeF s = ee.Graphics.MeasureString(Sample, this.Font, PointF.Empty, StringFormat.GenericDefault);
                    ee.ItemHeight = (int)Math.Round(s.Height + PadY * 2);
                    ee.ItemWidth = (int)Math.Round(s.Width + LineLength + PadX * 2 + Gap);
                };
                item.DrawItem += (ss, ee) =>
                {
                    ee.DrawBackground();
                    using (Pen p = new Pen(ee.ForeColor, ((float)bwi.Width / 1440f) * ee.Graphics.DpiY))
                    using (SolidBrush b = new SolidBrush(ee.ForeColor))
                    using (var sf = new StringFormat(StringFormat.GenericDefault))
                    {
                        var offset = ee.Graphics.MeasureString(Sample, this.Font, PointF.Empty, StringFormat.GenericDefault).Width + PadX + Gap / 2;

                        sf.Alignment = StringAlignment.Far;
                        sf.LineAlignment = StringAlignment.Center;
                        ee.Graphics.DrawString(bwi.Text, this.Font, b, ee.Bounds.Left + offset - Gap / 2, ee.Bounds.Top + ee.Bounds.Height / 2, sf);
                        if (bwi.Width > 0)
                            ee.Graphics.DrawLine(p, ee.Bounds.Left + offset + Gap / 2, ee.Bounds.Top + ee.Bounds.Height / 2, ee.Bounds.Right - PadX, ee.Bounds.Top + ee.Bounds.Height / 2);
                    }
                };
                items.Add(item);
            }
            items.EndUpdate();
        }
        #endregion

        private void DoPropertiesAlphabetical()
        {
            CategorizeProperties = false;
            UpdateCommands(true);
        }

        private void DoPropertiesCategorized()
        {
            CategorizeProperties = true;
            UpdateCommands(true);
        }

        private void ShowTabPage(C1DockingTabPage page)
        {
            var tab = page.Parent as C1DockingTab;
            if (tab != null)
                tab.SelectedTab = page;
        }

        private void DoShowPropertyGrid()
        {
            ShowTabPage(dtpProperties);
            ActiveControl = _propGrid;
            UpdateUITools(true);
        }

        private void DoShowDataTree()
        {
            ShowTabPage(dtpData);
            ActiveControl = _dataTree;
            _dataTree.Focus();
            UpdateUITools(true);
        }

        private void DoStyles()
        {
            using (ReportStyleForm f = new ReportStyleForm(this))
            {
                f.Designer = _flexDesigner;
                f.ShowDialog();
            }
        }

        private void DoSnapToGrid()
        {
            _flexDesigner.Preferences.GridSnap = rbtnSnapToGrid.Pressed;
            UpdateUIGrid(true);
        }

        private void DoLockFields()
        {
            _flexDesigner.Locked = !_flexDesigner.Locked;
            UpdateUIGrid(true);
        }

#if skip_dima
        private void DoToggleLockOfSelectedFields()
        {
            _designer.ToggleLockOfSelectedFields();
        }
#endif

        private void DoShowHideGrid()
        {
            _flexDesigner.Preferences.GridVisible = rbtnShowGrid.Pressed;
            UpdateUIGrid(true);
        }

        private void DoGridProperties()
        {
            _appConfig.ShowDialog("DesignPane");
            UpdateUI(false);
        }

        private void DoAlign(RibbonItem item)
        {
            if (item == rbtnAlignToGrid)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.AlignToGrid);
            else if (item == rbtnFormatAsTableRow)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.FormatAsTableRow);
            else if (item == rbtnAlignLeft)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.AlignLeft);
            else if (item == rbtnAlignCenter)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.AlignCenter);
            else if (item == rbtnAlignMiddle)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.AlignMiddle);
            else if (item == rbtnAlignRight)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.AlignRight);
            else if (item == rbtnAlignTop)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.AlignTop);
            else if (item == rbtnAlignBottom)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.AlignBottom);
            else if (item == rbtnSendToBack)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.SendToBack);
            else if (item == rbtnBringToFront)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.BringToFront);
            else if (item == rbtnEqualHorizontalSpacing)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.EqualHorizontalSpacing);
            else if (item == rbtnIncreaseHorizontalSpacing)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.IncreaseHorizontalSpacing);
            else if (item == rbtnDecreaseHorizontalSpacing)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.DecreaseHorizontalSpacing);
            else if (item == rbtnEqualVerticalSpacing)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.EqualVerticalSpacing);
            else if (item == rbtnIncreaseVerticalSpacing)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.IncreaseVerticalSpacing);
            else if (item == rbtnDecreaseVerticalSpacing)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.DecreaseVerticalSpacing);
            else if (item == rbtnSizeToGrid)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.SizeToGrid);
            else if (item == rbtnWidthToNarrowest)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.WidthToNarrowest);
            else if (item == rbtnWidthToWidest)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.WidthToWidest);
            else if (item == rbtnHeightToShortest)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.HeightToShortest);
            else if (item == rbtnHeightToTallest)
                _flexDesigner.DoAlignSelectedFields(FieldAlignOperation.HeightToTallest);
        }

        private void DoSetLayoutOrientation(bool landscape)
        {
            _flexDesigner.UndoSaveState();
            _flexDesigner.Report.Layout.Orientation = landscape ? Flex.OrientationEnum.Landscape : Flex.OrientationEnum.Portrait;
            _flexDesigner.UpdateFromReport();

            // update preview
            if (!ReportDesignMode)
                RenderPreview(true, true);
        }

        // NOTE: this code is taken from C1Report printing.
        /// <summary>
        /// Creates a PrintDocument based on passed printer settings and current page settings.
        /// </summary>
        /// <param name="printerSettings">The printer settings to use. Must not be null.</param>
        /// <returns>An instance of PrintDocument that has the specified printer and page settings.</returns>
        /// <remarks>
        /// The code in this method tries to work around an issue with the standard page setup dialog:
        /// if the target printer supports papers that are absent from the System.Drawing.Printing.PaperKind
        /// enum, and such a paper is selected - in certain use scenarios the integrity of the printer and
        /// page settings is broken by the dialog, and on subsequent calls the dialog shows only the
        /// default paper. The key to avoiding this seems to be to use a PrintDocument, and to
        /// set the printer settings with Sethdevnames/Sethdevmode calls, and then to individually
        /// set the relevant page settings. TFS~~17823.
        /// </remarks>
        private PrintDocument _makePageSettingsPrintDocument(PageSettings pageSettings, PrinterSettings printerSettings)
        {
            var pdoc = new PrintDocument();

            // Set printer settings:
            pdoc.PrinterSettings.SetHdevnames(printerSettings.GetHdevnames());
            pdoc.PrinterSettings.SetHdevmode(printerSettings.GetHdevmode());

            // Set relevant page settings (code is copied from C1PageSettings.ToPageSettings):
            var page = pageSettings; // cache page settings as they are created on the fly

            // color:
            pdoc.DefaultPageSettings.Color = page.Color;

            // orientation:
            pdoc.DefaultPageSettings.Landscape = page.Landscape;

            // margins:
            pdoc.DefaultPageSettings.Margins.Left = page.Margins.Left;
            pdoc.DefaultPageSettings.Margins.Right = page.Margins.Right;
            pdoc.DefaultPageSettings.Margins.Top = page.Margins.Top;
            pdoc.DefaultPageSettings.Margins.Bottom = page.Margins.Bottom;

            // paper source:
            PaperSource ps = null;
            if (page.PaperSource.Kind == PaperSourceKind.Custom)
            {
                foreach (PaperSource paperSource in pdoc.PrinterSettings.PaperSources)
                    if (paperSource.Kind == PaperSourceKind.Custom && paperSource.RawKind == page.PaperSource.RawKind)
                    {
                        ps = paperSource;
                        break;
                    }
            }
            else
            {
                foreach (PaperSource paperSource in pdoc.PrinterSettings.PaperSources)
                    if (paperSource.Kind == page.PaperSource.Kind)
                    {
                        ps = paperSource;
                        break;
                    }
            }
            if (ps == null)
            {
                ps = new PaperSource();
                ps.SourceName = page.PaperSource.SourceName;
                ps.RawKind = page.PaperSource.RawKind;
            }
            pdoc.DefaultPageSettings.PaperSource = ps;

            // printer resolution:
            if (page.PrinterResolution != null && page.PrinterResolution.Kind == System.Drawing.Printing.PrinterResolutionKind.Custom)
            {
                PrinterResolution pr = new PrinterResolution();
                pr.Kind = page.PrinterResolution.Kind;
                pr.X = page.PrinterResolution.X;
                pr.Y = page.PrinterResolution.Y;
                pdoc.DefaultPageSettings.PrinterResolution = pr;
            }
            else
            {
                foreach (PrinterResolution printerResolution in pdoc.PrinterSettings.PrinterResolutions)
                    if (printerResolution.Kind == page.PrinterResolution.Kind)
                    {
                        pdoc.DefaultPageSettings.PrinterResolution = printerResolution;
                        break;
                    }
            }

            // paper size: assigning .NET PaperSize to a size where Kind is one missing from the PaperKind enum
            // (e.g. A0) causes the PageSetupDialog to break the associated devmode's integrity for subsequent calls,
            // so we don't mess with such papers at all:
            if (page.PaperSize.Kind != PaperKind.Custom)
            {
                foreach (PaperSize psize in pdoc.PrinterSettings.PaperSizes)
                {
                    if (psize.Kind == page.PaperSize.Kind && pdoc.DefaultPageSettings.PaperSize.Kind != page.PaperSize.Kind)
                    {
                        pdoc.DefaultPageSettings.PaperSize = page.PaperSize;
                        break;
                    }
                }
            }

            return pdoc;
        }

        // NOTE: this code is taken from C1Report printing.
        /// <summary>
        /// Displays the PageSetupDialog, for dialog must be specified:
        ///   PageSettings
        ///   PrinterSettings
        /// This method is a workaround for .NET bug with Margins in PageSetupDialog
        /// (the are displayed incorrectly if RegionInfo.CurrentRegion.IsMetric == true)
        /// and for PaperSize if it is created as PaperSize ps = new PaperSize(Name, Width, Height);
        /// </summary>
        /// <param name="dialog">The PageSetupDialog object</param>
        /// <param name="ownerForm">The owner form.</param>
        /// <returns>Returns the result of dialog.ShowDialog() function.</returns>
        private static DialogResult ShowPageSetupDialog(PageSetupDialog dialog, Form ownerForm)
        {
            if (dialog.PageSettings.PaperSize.Kind == PaperKind.Custom)
                foreach (PaperSize ps in dialog.PrinterSettings.PaperSizes)
                {
                    // Setting custom to custom breaks page settings if paper is e.g. A0 (TFS~~17823):
                    if (ps.Kind != PaperKind.Custom &&
                        dialog.PageSettings.PaperSize.Width == ps.Width &&
                        dialog.PageSettings.PaperSize.Height == ps.Height)
                    {
                        dialog.PageSettings.PaperSize = ps;
                        break;
                    }
                }

            bool isMetric = RegionInfo.CurrentRegion.IsMetric;
            if (isMetric)
            {
                // convert 1/100 inch to 1/10 of mm
                var m = dialog.PageSettings.Margins;
                m.Left = (int)Math.Round((float)m.Left / 100f * 25.4 * 10f);
                m.Top = (int)Math.Round((float)m.Top / 100f * 25.4 * 10f);
                m.Right = (int)Math.Round((float)m.Right / 100f * 25.4 * 10f);
                m.Bottom = (int)Math.Round((float)m.Bottom / 100f * 25.4 * 10f);
            }
            DialogResult result = dialog.ShowDialog(ownerForm);
            if (result != DialogResult.OK && isMetric)
            {
                // convert 1/10 mm to 1/100 of inch
                var m = dialog.PageSettings.Margins;
                m.Left = (int)Math.Round((float)m.Left * 100f / 25.4 / 10f);
                m.Top = (int)Math.Round((float)m.Top * 100f / 25.4 / 10f);
                m.Right = (int)Math.Round((float)m.Right * 100f / 25.4 / 10f);
                m.Bottom = (int)Math.Round((float)m.Bottom * 100f / 25.4 / 10f);
            }
            return result;
        }

        private void DoPageSetup()
        {
            var undo = _flexDesigner.Undo_CreateSavedState();

            var printerSettings = new PrinterSettings();
            var pageSettings = _flexDesigner.Report.PageSettings.ToPageSettings(printerSettings);
            using (var pdoc = _makePageSettingsPrintDocument(pageSettings, printerSettings))
            using (var psd = new PageSetupDialog())
            {
                psd.Document = pdoc;
                if (ShowPageSetupDialog(psd, this) == DialogResult.OK)
                {
                    _flexDesigner.Undo_PushSavedState(undo);

                    Func<int, double> toTwips = v => (v / 100.0) * 1440;
                    var report = _flexDesigner.Report;
                    var layout = report.Layout;
                    var ps = pdoc.DefaultPageSettings;
                    Margins m = ps.Margins;
                    layout.MarginLeft = toTwips(m.Left);
                    layout.MarginTop = toTwips(m.Top);
                    layout.MarginRight = toTwips(m.Right);
                    layout.MarginBottom = toTwips(m.Bottom);
                    layout.PaperSize = ps.PaperSize.Kind;
                    if (layout.PaperSize == PaperKind.Custom)
                    {
                        layout.CustomWidth = toTwips(ps.PaperSize.Width);
                        layout.CustomHeight = toTwips(ps.PaperSize.Width);
                    }
                    else
                    {
                        layout.CustomWidth = 0;
                        layout.CustomHeight = 0;
                    }
                    layout.Orientation = ps.Landscape ? OrientationEnum.Landscape : OrientationEnum.Portrait;
                    //
                    _flexDesigner.UpdateFromReport();
                    // update preview
                    if (!ReportDesignMode)
                        RenderPreview(true, true);
                }
                else
                    _flexDesigner.Undo_DiscardSavedState(undo);
            }
        }

        private void DoCaptionsVisibility(RibbonItem item)
        {
            if (item == rbtnCaptionsExpandAll)
                _flexDesigner.ExpandAllBands();
            else if (item == rbtnCaptionsCollapseAll)
                _flexDesigner.CollapseAllBands();
            else
            {
                UIAction a;
                if (!TryGetAction(item.Tag as string, out a))
                    return;
                try
                {
                    _flexDesigner.CaptionsVisibility = (CaptionsVisibility)a.Value;
                }
                catch
                {
                    _flexDesigner.CaptionsVisibility = CaptionsVisibility.Section;
                }
                UpdateUICaptionsVisibility(true);
            }
        }

        private void DoZoom(RibbonItem item)
        {
            if (ReportDesignMode)
                DoZoomDesigner(item);
            else
                DoPreviewView(item);
        }

        private void DoZoomDesigner(RibbonItem item)
        {
            if (item.Parent as RibbonMenu == rbtnZoom)
                _flexDesigner.ZoomFactor = int.Parse(((string)item.Tag).Substring(4)) / 100.0f;
        }

        private void DoOptions()
        {
            _appConfig.ShowDialog();
            UpdateUI(false);
        }

        private void DoSelectAll()
        {
            // This selects all fields within, or relative to the current selection.
            // See C1FlexReportDesigner.SelectAllFields() for more details.
            _flexDesigner.SelectAll();
        }

        private void DoAbout()
        {
            using (AppAboutForm dlg = NewAppAboutForm())
            {
                dlg.ShowDialog();
            }
        }

        private void RibbonChangeCommitted(RibbonItem item)
        {
            if (item == rcbFontName)
                DoSetFontName();
            else if (item == rcbFontSize)
                DoSetFontSize();
            else if (item == rebPageNo)
                DoSetPageNo();
        }

        private void RibbonChangeCanceled(RibbonItem item)
        {
            if (item == rcbFontName || item == rcbFontSize)
                UpdateUIFont(true);
        }

        private void RibbonColorChanged(RibbonColorPicker cb)
        {
            if (cb == rbtnTextColor)
                Designer_DoSetForeColor(rbtnTextColor.Color);
            else if (cb == rbtnFillColor)
                Designer_DoSetBackground(rbtnFillColor.Color);
        }

        private void RibbonClick(RibbonItem item)
        {
            DiscardPendingUndoState();

            if (item == rbtnNew)
                DoNew();
            else if (item == rbtnClose)
                DoClose();
            else if (item == rbtnOpen)
                DoOpen();
            else if (item == rbtnSave)
                DoSave();
            else if (item == rbtnSaveAs)
                DoSaveAs();
            else if (item == rbtnImport)
                DoImport();
            else if (item == rbtnExport)
                DoExport();
            else if (item == rbtnCut)
                Designer_DoCut();
            else if (item == rbtnCopy)
                Designer_DoCopy();
            else if (item == rbtnPaste)
                Designer_DoPaste();
            else if (item == rbtnDelete)
                Designer_DoDelete();
            else if (item == rbtnUndo)
                DoUndo();
            else if (item == rbtnRedo)
                DoRedo();
            else if (item == rbtnExit)
                DoExit();
            else if (item == rbtnSaveAndExit)
                DoSaveAndExit();
            else if (item == rbtnCancelAndExit)
                DoCancelAndExit();
            //
            else if (item == rbtnGroupSort)
                DoEditGroups();
            else if (item == rbtnDataSources)
                DoDataSourcesAction((Func<bool>)DataSources_EditMain, null);
            else if (item == rbtnReportInfo)
                DoReportInfo();
            else if (item == rbtnScriptEditor)
                DoScriptEditor();
            else if (item.Group == rgFields || item.Group == rgCustomFields)
                DoCreateField(item);
            else if (item == rbtnFontBold)
                DoFontStyle(item, rbtnFontBold.Pressed);
            else if (item == rbtnFontItalic)
                DoFontStyle(item, rbtnFontItalic.Pressed);
            else if (item == rbtnFontUnderline)
                DoFontStyle(item, rbtnFontUnderline.Pressed);
            else if (item == rbtnFontSizeDown || item == rbtnFontSizeUp)
                DoFontStyle(item, false);
            else if (item == rbtnTextAlignGeneral || item == rbtnTextAlignLeft || item == rbtnTextAlignCenter || item == rbtnTextAlignRight || item == rbtnTextAlignJustify)
                DoTextAlign(item);
            else if (item == rbtnShowPropertyGrid)
                DoShowPropertyGrid();
            else if (item == rbtnShowDataTree)
                DoShowDataTree();
            else if (item == rbtnShowErrorList)
                dtpErrors.TabVisible = true;
            else if (item == rbtnStyles)
                DoStyles();
            else if (item == rbtnApplyStyleToSelection)
                Designer_DoApplyStyleToSelection();
            else if (item == rbtnShowGrid)
                DoShowHideGrid();
            else if (item == rbtnSnapToGrid)
                DoSnapToGrid();
            else if (item == rbtnLockFields)
                DoLockFields();
            else if (item == rbtnGridProperties)
                DoGridProperties();
            else if (item == rbtnFormatAsTableRow ||
                item == rbtnAlignToGrid ||
                item == rbtnFormatAsTableRow ||
                item == rbtnAlignLeft ||
                item == rbtnAlignCenter ||
                item == rbtnAlignMiddle ||
                item == rbtnAlignRight ||
                item == rbtnAlignTop ||
                item == rbtnAlignBottom ||
                item == rbtnSendToBack ||
                item == rbtnBringToFront ||
                item == rbtnEqualHorizontalSpacing ||
                item == rbtnIncreaseHorizontalSpacing ||
                item == rbtnDecreaseHorizontalSpacing ||
                item == rbtnEqualVerticalSpacing ||
                item == rbtnIncreaseVerticalSpacing ||
                item == rbtnDecreaseVerticalSpacing ||
                item == rbtnSizeToGrid ||
                item == rbtnWidthToNarrowest ||
                item == rbtnWidthToWidest ||
                item == rbtnHeightToShortest ||
                item == rbtnHeightToTallest)
                DoAlign(item);
            else if (item.Parent as RibbonMenu == rbmCaptionsVisibility)
                DoCaptionsVisibility(item);
            else if (item == rbtnOptions)
                DoOptions();
            else if (item == rbtnAbout2)
                DoAbout();
            else if (item == rbtnAbout || item == rbtnHelpContents)
                DoHelpContents();
            else if (item == rclrBorderColor || (item.Parent as RibbonColorPicker) == rclrBorderColor)
                DoBorderColor();
            else if ((item.Parent as RibbonGallery) == rgalBorderStyle)
                DoBorderStyle(item as RibbonGalleryItem);
            else if (item == rcmbBorderWidth || (item.Parent as RibbonComboBox) == rcmbBorderWidth)
                DoBorderWidth();
            else if (item == rbtnSubSectionAdd)
                Designer_DoAddSubSection();
            else if (item == rbtnSubSectionRemove)
                Designer_DoDeleteSubSection();
            else if (item == rbtnSubSectionMoveUp)
                Designer_DoSubSectionMove(false);
            else if (item == rbtnSubSectionMoveDown)
                Designer_DoSubSectionMove(true);
            // Preview mode:
            else if (item == rbtnModePreview)
                DoPreview();
            else if (item == rbtnPreviewPrint)
                DoPreviewPrint();
            else if (item == rbtnModeDesign)
                DoClosePreview();
            else if (item == rbtnPreviewStop)
                DoPreviewStop();
            else if (item == rbtnPreviewRefresh)
                RenderPreview(false, true);
            else if (item == rbtnPreviewPrint)
                DoPreviewPrint();
            else if (item == rbtnPreviousView ||
                item == rbtnNextView ||
                item == rbtnFirstPage ||
                item == rbtnPreviousPage ||
                item == rbtnNextPage ||
                item == rbtnLastPage)
                DoNavigation(item);
            else if (item == rbtnHandTool ||
                item == rbtnTextSelectTool ||
                item == rbtnPreviewFind)
                DoPreviewTool(item);
            else if (item.Group == rgExport)
                DoPreviewExport(item);
            // Misc:
            else if (item == rbtnPageLandscape1 || item == rbtnPageLandscape2)
                DoSetLayoutOrientation(true);
            else if (item == rbtnPagePortrait1 || item == rbtnPagePortrait2)
                DoSetLayoutOrientation(false);
            else if (item == rbtnPageSetup1 || item == rbtnPageSetup2)
                DoPageSetup();
            else if (item.Parent as RibbonMenu == rbtnZoom ||
                item == rbtnZoomTwoPages ||
                item == rbtnZoomOnePage ||
                item == rbtnPreviewParams ||
                item == rbtnPreviewThumbnails ||
                item == rbtnPreviewOutlines ||
                item == rbtnPreviewPaginated)
                DoZoom(item);
            // else?
        }

        private void DoErrorToClipboard()
        {
            try
            {
                Clipboard.SetText(rbtnRenderError.ToolTip);
            }
            catch (Exception ex)
            {
                MessageForm.Error(string.Format(Strings.MainForm.ClipboardErrorFmt, ex.Message));
            }
        }

        private void DoHelpContents()
        {
            OpenURL(Strings.MainForm.HelpUrl);
        }


        private void RibbonDropDown(RibbonItem item)
        {
            // currently nothing...
        }
    }
}
