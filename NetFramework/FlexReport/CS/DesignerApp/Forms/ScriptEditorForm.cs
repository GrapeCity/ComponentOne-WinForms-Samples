//----------------------------------------------------------------------------
// ScriptEditorForm.cs
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
using System.Text.RegularExpressions;
using System.Threading;

using C1.Win.C1Command;
using C1.C1Preview;
using C1.C1Report;
using C1.Win.Localization;
using ReportDesignerApp.Util;

namespace ReportDesignerApp
{
    public partial class ScriptEditorForm : Form
    {
        private C1Report _report; // report that owns the script
        private bool _expression; // editing expression or statement 
        private bool _syntaxCheck = true; // check syntax while editing
        private bool _syntaxColoring = true; // color text
        private bool _contextMenuClosed;

        #region Constructors
        public ScriptEditorForm()
        {
            // initialize components
            InitializeComponent();

            // localize:
            StringsManager.LocalizeControl(typeof(Strings), this, typeof(ScriptEditorForm));
        }

        public ScriptEditorForm(
            C1Report report,
            bool expression)
            : this()
        {
            // save parameters
            _report = report;
            _expression = expression;

            AutoScaleMode = AutoScaleMode.None;
            Font = MainForm.DefaultAppFont;

            // populate fields lists first time the menu is displayed
            InitMenus();

            // initialize syntax highlighter
            InitSyntax();

            // ready to start
            UpdateStatusBar();
        }
        #endregion

        #region Private
        private void CheckSyntax()
        {
            rbtnError.Visible = false;
            rblText.Text = string.Empty;
            ribbonSeparator1.Visible = false;

            if (_report != null && _syntaxCheck)
            {
                Exception x = (_expression)
                    ? _report.ParseExpression(txtScript.Text)
                    : _report.ParseStatement(txtScript.Text);
                if (x != null)
                {
                    rblText.Text = x.Message;
                    rbtnError.ToolTip = x.Message;
                    rbtnError.Visible = true;
                    ribbonSeparator1.Visible = true;
                }
            }
        }

        private void InitSyntax()
        {
            if (_syntaxColoring)
            {
                // comments
                txtScript.AddSyntaxDescriptor("Comments", new SyntaxDescriptor("(?m)'.*$", Color.Green));

                // strings
                txtScript.AddSyntaxDescriptor("Strings", new SyntaxDescriptor(@"""[^""\n]*""", Color.DarkRed));

                // variable names in brackets 
                // (to avoid highlighing vb keywords in the names, e.g. [Start Date])
                // note: use Color.FromArgb(1) instead of black because black is the
                //       default color and may be overwritten by other descriptors.
                txtScript.AddSyntaxDescriptor("Bracketed names", new SyntaxDescriptor(@"\[[^\]\n]+\]", Color.FromArgb(1)));

                // VScript keywords
                // make sure longer words come first, e.g. EndIf|End, ElseIf|Else
                string rx = "True|False|Nothing|Null|And|Or|Not|Mod|Const|Dim|Redim|" +
                    "If|Then|ElseIf|Else|EndIf|End|Iif|For|To|Next|Step|While|Wend|Sub|Function|Call|ByRef|ByVal";
#if skip_dima // old list, w/no GLOBALSCRIPT
                string rx = "True|False|Nothing|Null|And|Or|Not|Mod|Const|Dim|Redim|" +
                    "If|Then|ElseIf|Else|EndIf|End|Iif|For|To|Next|Step|While|Wend";
#endif
                rx = @"(?i)(^|\W)(?<match>" + rx + @")+(?=$|\W)";
                txtScript.AddSyntaxDescriptor("VBScript keywords", new SyntaxDescriptor(rx, Color.Blue));

                // VBScript functions
                rx = "Argb|Abs|Acos|Asc|Asin|Atn|CBool|CByte|CCur|CDate|CDbl|Chr|CInt|CLng|Cos|CSng|CStr|" +
                    "Date|DateAdd|DateDiff|DatePart|DateSerial|DateValue|Day|Exp|Fix|Format|" +
                    "FormatCurrency|FormatDateTime|FormatNumber|FormatPercent|Hex|Hour|" +
                    "InputBox|InStr|InStrRev|Int|IsDate|IsEmpty|IsNull|IsNumeric|IsObject|LCase|" +
                    "Left|Len|Log|LTrim|Mid|Minute|Month|MonthName|MsgBox|Now|Oct|Pi|Replace|" +
                    "RGB|Right|Rnd|Round|RTrim|Second|Sgn|Sin|Sign|Space|Sqr|StrComp|String|" +
                    "Tan|Time|Timer|TimeSerial|TimeValue|Trim|TypeName|UCase|VarType|WeekDay|WeekDayName|Year|" +
                    "CBoolInvariant|CByteInvariant|CCurInvariant|CDateInvariant|CDblInvariant|" +
                    "CIntInvariant|CLngInvariant|CSngInvariant|CStrInvariant|Like|In";
                rx = @"(?i)(^|\W)(?<match>" + rx + @")+(?=$|\W)";
                txtScript.AddSyntaxDescriptor("VBScript functions", new SyntaxDescriptor(rx, Color.Blue));

                // Custom functions (aggregates)
                rx = "Avg|Count|CountDistinct|Min|Max|Range|StDev|StDevP|Sum|Var|VarP";
                rx = @"(?i)(^|\W)(?<match>" + rx + @")+(?=$|\W)";
                txtScript.AddSyntaxDescriptor("C1Report aggregates", new SyntaxDescriptor(rx, Color.Blue));

                // report variables
                StringBuilder sb = new StringBuilder("Page|Pages|Report");
                foreach (Field f in _report.Fields)
                {
                    sb.AppendFormat("|{0}", f.Name);
                }
                foreach (Section s in _report.Sections)
                {
                    sb.AppendFormat("|{0}", s.Name);
                }
                rx = @"(?i)(^|\W)(?<match>" + sb.ToString() + @")+(?=$|\W)";
                txtScript.AddSyntaxDescriptor("C1Report variables", new SyntaxDescriptor(rx, Color.Gray));

                // syntax loaded, refresh the control
                txtScript.Refresh();
            }
        }

        private void InitSyntaxDbFields(string[] fields)
        {
            if (_syntaxColoring)
            {
                // add db fields to syntax
                StringBuilder sb = new StringBuilder();
                foreach (string s in fields)
                    sb.AppendFormat(sb.Length == 0 ? "{0}" : "|{0}", s);

                string rx = @"(?i)(^|\W)(?<match>" + sb.ToString() + @")+(?=$|\W)";
                txtScript.AddSyntaxDescriptor("C1Report data fields", new SyntaxDescriptor(rx, Color.DarkSlateBlue));

                // syntax loaded, refresh the control
                txtScript.Refresh();
            }
        }

        private void AddMenuItem(C1CommandMenu cm, string caption)
        {
            C1Command c = new C1Command();
            c.Text = caption;
            chMain.Commands.Add(c);

            cm.CommandLinks.Add(new C1CommandLink(c));
        }

        private void InitMenus()
        {
            // aggregate functions
            string items = "Avg()|Count()|CountDistinct()|Min()|Max()|Range()|StDev()|StDevP()|Sum()|Var()|VarP()";
            foreach (string caption in items.Split('|'))
                AddMenuItem(cAggregates, caption);

            // math functions
            items = "Abs()|Acos()|Asin()|Atn()|Cos()|Exp()|Fix()|In()|Int()|IsNull()|IsNumeric()|IsObject()|Pi()|Oct()|Rnd()|Round()|Sgn()|Sin()|Sign()|Sqr()|Tan()";
            foreach (string caption in items.Split('|'))
                AddMenuItem(cMath, caption);

            // data conversion
            items = "CBool()|CByte()|CCur()|CDate()|CDbl()|CInt()|CLng()|CSng()|CStr()|IsEmpty()|TypeName()|VarType()|CBoolInvariant()|CByteInvariant()|CCurInvariant()|CDateInvariant()|CDblInvariant()|CIntInvariant()|CLngInvariant()|CSngInvariant()|CStrInvariant()";
            foreach (string caption in items.Split('|'))
                AddMenuItem(cDataConversion, caption);

            // string functions
            items = "Asc()|Chr()|CStr()|Format(,)|FormatCurrency(,)|FormatDateTime(,)|FormatNumber(,)|FormatPercent(,)|Instr(,)|LCase()|Left()|Len()|Like()|LTrim()|Mid()|Replace(,)|Right(,)|Space()|Trim()|UCase()|Hex()";
            foreach (string caption in items.Split('|'))
                AddMenuItem(cString, caption);

            // date/time functions
            items = "CDate()|DateAdd()|DateDiff(,)|DatePart(,)|DateSerial()|Day()|Hour()|IsDate()|Minute()|Month()|MonthName()|Now|Second()|Weekday()|WeekdayName()|Year()|Date()|Timer()|TimeSerial()|TimeValue()";
            foreach (string caption in items.Split('|'))
                AddMenuItem(cDateTime, caption);

            // logical functions
            items = "Iif(,,)|If * Then *|If * Then * Else *";
            foreach (string caption in items.Split('|'))
                AddMenuItem(cLogical, caption);

            // misc functions
            items = "InputBox()|MsgBox()|Rgb()|Argb()";
            foreach (string caption in items.Split('|'))
                AddMenuItem(cMiscellaneous, caption);

            // report variables
            items = "Page|Pages|Report";
            foreach (string caption in items.Split('|'))
                AddMenuItem(cReportVariables, caption);

            // report fields
            if (_report.Fields.Count == 0)
                cReportFields.Enabled = false;
            else
            {
                foreach (Field f in _report.Fields)
                    AddMenuItem(cReportFields, f.Name);
            }
        }

        private void LoadDBFields()
        {
            lock (_report)
            {
                // get the list of db fields (may be slow the first time)
                _report.DataSource.GetDBFieldList(true);
            }

            // done, do the work on the main thread
            Invoke(new EventHandler(LoadDBFields));
        }

        private void LoadDBFields(object sender, System.EventArgs e)
        {
            // get a list of db fields
            lock (_report)
            {
                string[] dbFields = _report.DataSource.GetDBFieldList(true);
                if (dbFields == null || dbFields.Length == 0)
                {
                    cDatabaseFields.Enabled = false;
                }
                else
                {
                    // initialize menu
                    foreach (string item in dbFields)
                        AddMenuItem(cDatabaseFields, item);

                    // initialize syntax coloring
                    InitSyntaxDbFields(dbFields);
                }
            }
        }

        private void UpdateStatusBar()
        {
            int chr = txtScript.SelectionStart;
            int line = txtScript.GetLineFromCharIndex(chr);

            int column = 0;
            string text = txtScript.Text;
            for (int i = Math.Min(chr - 1, text.Length - 1); i > 0; i--)
            {
                if (text[i] == '\n') break;
                column++;
            }

            rlblCol.Text = string.Format(Strings.ScriptEditorForm.ColumnFmt, column + 1);
            rlblRow.Text = string.Format(Strings.ScriptEditorForm.LineFmt, line + 1);
        }
        #endregion

        #region Protected
        // save dialog bounds to reuse next time <<B137>>
        protected override void OnClosing(CancelEventArgs e)
        {
            AppSettings.SaveObject("ScriptEditorForm", new FormState(this));
            base.OnClosing(e);
        }

        // apply dialog bounds (after calling OnLoad) <<B157>>
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AppSettings.LoadObject("ScriptEditorForm", new FormState(this));
        }
        #endregion

        #region Public properties
        public string Expression
        {
            get { return txtScript.Text; }
            set
            {
                // replace Lf with CrLf
                txtScript.Text = (value != null)
                    ? Regex.Replace(value, "([^\r])\n", "$1\r\n")
                    : string.Empty;
            }
        }

        public Font EditorFont
        {
            get { return txtScript.Font; }
            set { txtScript.Font = value; }
        }

        public bool SyntaxCheck
        {
            get { return _syntaxCheck; }
            set { _syntaxCheck = value; }
        }

        public bool SyntaxColoring
        {
            get { return _syntaxColoring; }
            set
            {
                _syntaxColoring = value;
                if (!value)
                    txtScript.ClearSyntaxDescriptors();
            }
        }
        #endregion

        private void ScriptEditorForm_Load(object sender, EventArgs e)
        {
            // go load db fields (use a separate thread since this may take some time)
            Thread t = new Thread(new ThreadStart(LoadDBFields));
            t.Start();
        }

        private void contextMenu_Popup(object sender, EventArgs e)
        {
            cUndo.Enabled = txtScript.CanUndo;
            cRedo.Enabled = txtScript.CanRedo;
            cSelectAll.Enabled = txtScript.Text.Length > 0;
            cPaste.Enabled = Clipboard.GetDataObject() != null;
            cCut.Enabled =
            cCopy.Enabled =
            cDelete.Enabled = txtScript.SelectionLength > 0;
        }

        private void chMain_CommandClick(object sender, CommandClickEventArgs e)
        {
            if (e.Command == cUndo)
                txtScript.Undo();
            else if (e.Command == cRedo)
                txtScript.Redo();
            else if (e.Command == cCut)
                txtScript.Cut();
            else if (e.Command == cCopy)
                txtScript.Copy();
            else if (e.Command == cPaste)
                txtScript.Paste();
            else if (e.Command == cDelete)
                txtScript.SelectedText = string.Empty;
            else if (e.Command == cSelectAll)
                txtScript.SelectAll();
            else
            {
                // insert menu text
                C1Command item = e.Command;
                txtScript.SelectedText = item.Text;

                // position cursor
                int openPar = item.Text.IndexOf("(");
                int asterisk = item.Text.IndexOf("*");
                if (openPar > -1)
                    txtScript.SelectionStart -= (item.Text.Length - openPar - 1);
                else if (asterisk > -1)
                {
                    txtScript.SelectionStart -= (item.Text.Length - asterisk);
                    txtScript.SelectionLength = 1;
                }
            }
        }

        private void _btnFields_Click(object sender, EventArgs e)
        {
            // initialize menus
            cUndo.Visible = false;
            cRedo.Visible = false;
            cCut.Visible = false;
            cCopy.Visible = false;
            cPaste.Visible = false;
            cDelete.Visible = false;
            cSelectAll.Visible = false;

            _contextMenuClosed = false;
            contextMenu.ShowContextMenu(_btnFields, new Point(_btnFields.Width / 2, _btnFields.Height / 2));
            while (!_contextMenuClosed)
                Application.DoEvents();

            cUndo.Visible = true;
            cRedo.Visible = true;
            cCut.Visible = true;
            cCopy.Visible = true;
            cPaste.Visible = true;
            cDelete.Visible = true;
            cSelectAll.Visible = true;

            txtScript.Focus();
        }

        private void txtScript_TextChanged(object sender, EventArgs e)
        {
            CheckSyntax();
        }

        private void txtScript_SelectionChanged(object sender, EventArgs e)
        {
            UpdateStatusBar();
        }

        private void contextMenu_Closed(object sender, EventArgs e)
        {
            _contextMenuClosed = true;
        }
    }
}
