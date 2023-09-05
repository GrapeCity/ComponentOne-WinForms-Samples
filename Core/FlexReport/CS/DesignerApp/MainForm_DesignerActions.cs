//----------------------------------------------------------------------------
// MainForm_DesignerActions.cs
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

using C1.Win.Ribbon;
using FlexReportDesignerApp.Util;
using C1.Win.Localization;

using C1.Win.FlexReport;
using C1.Win.Document;

namespace FlexReportDesignerApp
{
    public partial class MainForm
    {
        // Methods working on the designer control (e.g. copy report in reports list is NOT here).
        // On shortcut these methods are called when the designer control has focus.
        // These methods save the undo stack (explicitly, or the designer does that),
        // so saving the undo stack prior to calling them is not needed.
        private void Designer_DoCut()
        {
            try
            {
                _flexDesigner.DoCut();
            }
            catch (Exception ex)
            {
                MessageForm.Error(string.Format(Strings.MainForm.ClipboardErrorFmt, ex.Message));
            }
            _reportList.UpdateIcons(); // due to possible removal of subreports
        }
        private void Designer_DoDelete()
        {
            _flexDesigner.DoDeleteSelection();
            _reportList.UpdateIcons(); // due to possible removal of subreports
        }
        private void Designer_DoCopy()
        {
            try
            {
                _flexDesigner.DoCopy();
            }
            catch (Exception ex)
            {
                MessageForm.Error(string.Format(Strings.MainForm.ClipboardErrorFmt, ex.Message));
            }
        }
        private void Designer_DoPaste()
        {
            try
            {
                _flexDesigner.DoPaste();
            }
            catch (Exception ex)
            {
                MessageForm.Error(string.Format(Strings.MainForm.ClipboardErrorFmt, ex.Message));
            }
            _reportList.UpdateIcons(); // due to possible removal of subreports
        }
        private void Designer_DoAddSubSection()
        {
            _flexDesigner.DoAddSubSection();
        }
        private void Designer_DoDeleteSubSection()
        {
            _flexDesigner.DoDeleteSubSection();
        }
        private void Designer_DoSubSectionMove(bool down)
        {
            _flexDesigner.DoMoveSubSection(down);
        }
        /// <summary>
        /// Applies the style properties of the primary selection to other selected fields.
        /// </summary>
        private void Designer_DoApplyStyleToSelection()
        {
            _flexDesigner.DoApplyStyleToSelectedFields();
        }
        private void Designer_DoSetFontName(string fontName)
        {
            _flexDesigner.DoSetFontName(fontName);
        }
        private void Designer_DoSetFontSize(float size, bool absolute)
        {
            _flexDesigner.DoSetFontSize(size, absolute);
        }
        private void Designer_DoSetFontStyle(bool? bold, bool? italic, bool? underline)
        {
            _flexDesigner.DoSetFontStyle(bold, italic, underline);
        }
        private void Designer_DoSetForeColor(Color color)
        {
            _flexDesigner.DoSetForeColor(color);
        }
        private void Designer_DoSetTextAlign(FieldAlignEnum align, bool horizontal, bool vertical)
        {
            _flexDesigner.DoSetTextAlign(align, horizontal, vertical);
        }
        private void Designer_DoSetBackground(Color color)
        {
            C1SolidBrush bg = new C1SolidBrush(color);
            _flexDesigner.DoSetBackground(bg, true);
        }
    }
}
