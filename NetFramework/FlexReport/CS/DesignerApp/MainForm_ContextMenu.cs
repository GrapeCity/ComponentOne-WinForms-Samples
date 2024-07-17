//----------------------------------------------------------------------------
// MainForm_ContextMenu.cs
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
using C1.Win.C1Command;

using C1.Win.FlexReport;
using Flex = C1.Win.FlexReport;
using Doc = C1.Win.C1Document;
using C1.Win.FlexReport.FlexDesigner;

namespace FlexReportDesignerApp
{
    public partial class MainForm
    {
        // Context menu popup - see _flexDesigner_MouseDown
        private void _cmDesigner_Popup(object sender, EventArgs e)
        {
            // hide/don't show tooltips while context menu is up:
            ((ITooltipService)this).ClearToolTip(_flexDesigner);
            _suspendTooltipService = true;
            //
            // make sure we have the focus -- todo: I don't remember why it forces focus here...
            if (_flexDesigner.IsInplaceParagraphEditing)
                _flexDesigner.ActiveInplaceEditor.Focus();
            else
                _flexDesigner.Focus();
            //
            // TODO: if mouse is outside of primary selection (or if we manage to find out that we were called by keyboard),
            // move context menu close to the primary selection... this depends on missing feature in C1Command.
            //
            UpdateContextCommands();
            //
            UpdateCommands(true);
        }

        private void _cmDesigner_Closed(object sender, EventArgs e)
        {
            // restore tooltip service:
            _suspendTooltipService = false;
        }

        private void UpdateContextCommands()
        {
            int placeholderIdxTop = -1, placeholderIdxBot = -1;

            for (int i = 0; i < _cmDesigner.CommandLinks.Count; ++i)
            {
                var cmd = _cmDesigner.CommandLinks[i].Command;
                if (cmd == _cContextPlaceholderTop)
                    placeholderIdxTop = i;
                else if (cmd == _cContextPlaceholderBot)
                {
                    placeholderIdxBot = i;
                    break;
                }
            }
            if (placeholderIdxTop == -1 || placeholderIdxBot == -1)
                return;

            _cmDesigner.CommandLinks.RemoveRange(placeholderIdxTop + 1, placeholderIdxBot - placeholderIdxTop - 1);
            _cContextPlaceholderTop.Visible = false;
            _cContextPlaceholderBot.Visible = false;

            var selection = _flexDesigner.SelectedObjects;
            if (selection.Count != 1)
                return;

            var context = selection[0];
            if (context == null)
                return;

            ContextActionCollection actions = _flexDesigner.GetContextActions();
            if (actions == null || actions.Count() == 0)
                return;

            int idx = placeholderIdxTop + 1;
            foreach (C1Command cmd in actions)
            {
                var cl = new C1CommandLink(cmd);
                if (idx == placeholderIdxTop + 1)
                    cl.Delimiter = true;
                _cmDesigner.CommandLinks.Insert(idx++, cl);
            }
        }
    }
}
