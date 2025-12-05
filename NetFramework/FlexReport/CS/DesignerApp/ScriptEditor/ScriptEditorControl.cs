//----------------------------------------------------------------------------
// ScriptEditorControl.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Reflection;
#if CLR40 || CLR45
using System.Linq;
#endif
using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;
using C1.Win.InputPanel;
using C1.Util.Win;
using C1.Win.SuperTooltip;
using FlexReportDesignerApp.Util;
using C1.Report;


namespace FlexReportDesignerApp.Forms
{
    public partial class ScriptEditorControl : UserControl, ICodeCompleteWindowOwner
    {
        #region Fields
        private C1FlexReport _report; // report that owns the script
        private MainForm _mainForm = null;
        private SyntaxHighlightingType _syntaxHighlighting = SyntaxHighlightingType.None;
        private string _currentScriptItemKey = null;
        private bool _currentScriptIsDirty = false;
        private EditorScriptItemCollection _scriptItems = null;
        private bool _checkSyntaxPending = false;
        // fonts used to hi-light items/labels:
        private Font _strongFont = null;
        private Font _regularFont = null;
        private Color _hiliteBackColor = Color.Empty;
        private Color _hiliteForeColor = Color.Empty;
        // history:
        private List<string> _history = new List<string>();
        private int _historyIdx = -1; // current index in history
        private bool _isMovingInHistory = false;
        // tooltip for use by code complete window:
        private C1SuperTooltip _tooltip = new C1SuperTooltip();
        // TODO: make this a user option, for now ScriptSyntaxItemFlags.DotNetMethods is excluded:
        private ScriptSyntaxItemFlags _scriptSyntaxItemFlags = ScriptSyntaxItemFlags.Default;
        // After adding the db context changes (i.e. InitSyntaxDbFields is called when switching between split windows),
        // RichTextBox started sending changed notifications when mouse clicked in a non-empty window
        // (WM_LBUTTONDOWN => WM_REFLECT+WM_COMMAND/EN_CHANGE), hz why.
        // Specifically, it was caused by setting SelectionColor/SelectionFont in RegexTextBox.ApplyStyles(),
        // but delayed (i.e. could not be fixed with a flag).
        // Hence this is to keep last text before change and fire text changed only on real text changes.
        // I have no idea how to fix it otherwise, and this is probably better anyway.
        // If this is null, it means it has not been set yet, so a change is also internal:
        // NOTE: RichTextBoxEx also caches Text, maybe we can just use it...
        private string _textBeforeChange = null;
        #endregion

        #region Types
        private static class SyntaxHiliteGroups
        {
            // Strings sort in order in which regex will be applied:
            public const string VbsComments = "1.1: Comments";
            public const string VbsStrings = "1.2: Strings";
            public const string VbsBrackets = "1.3: Name brackets";
            public const string VbsKeywords = "1.4: VBScript keywords";
            public const string VbsFunctions = "1.5: VBScript functions";
            public const string VbsConstants = "1.6: VBScript constants";

            public const string FilterStrings = "2.1: Strings";
            public const string FilterBrackets = "2.2: Name brackets";
            public const string FilterKeywords = "2.3: Keywords";
            public const string FilterFunctions = "2.4: Functions";

            public const string C1rAggregates = "5.1: C1Report aggregates";
            public const string C1rFunctions = "5.2: C1Report functions"; // Like(), In()
            public const string C1rVariables = "5.3: C1Report variables";

            public const string DbFields = "6.1: Database fields";
            public const string CalcFields = "6.2: Calculated fields";
        }

        /// <summary>
        /// Specifies the type of syntax highlighting.
        /// </summary>
        public enum SyntaxHighlightingType
        {
            /// <summary>
            /// Syntax highlighting is off.
            /// </summary>
            None,
            /// <summary>
            /// VBScript syntax.
            /// </summary>
            VBScript,
            /// <summary>
            /// MS DataColumn.Expression syntax (https://msdn.microsoft.com/en-us/library/system.data.datacolumn.expression%28v=vs.110%29.aspx).
            /// </summary>
            DataFilter,
        }
        #endregion

        #region Construction/initialization
        public ScriptEditorControl()
        {
            InitializeComponent();

            _regularFont = inpPanel.Font;
            _strongFont = new System.Drawing.Font(_regularFont, FontStyle.Bold);

            // size/position glyph:
            pbGlyph.Width = 16;
            pbGlyph.Height = this.inpPanel.Height - this.inpPanel.Padding.Top * 2;
            // this.SizeChanged += (ss, ee) => pbGlyph.Location = new Point(this.Width - pbGlyph.Width - this.inpPanel.Padding.Top, this.inpPanel.Padding.Top);
            this.SizeChanged += (ss, ee) => pbGlyph.Location = new Point(this.Width - pbGlyph.Width, this.inpPanel.Padding.Top);

        }

        public void Init(MainForm mainForm, C1FlexReport report, EditorScriptItemCollection scriptItems)
        {
            _mainForm = mainForm;

            // color for highlighting the active editor:
            InitHiliteColors(_mainForm);

            // save parameters
            _report = report;
            _scriptItems = scriptItems;

            AutoScaleMode = AutoScaleMode.None;

            UpdateLists();

            // force refresh of syntax hilight:
            var shl = SyntaxHighlighting;
            SyntaxHighlighting = SyntaxHighlightingType.None;
            SyntaxHighlighting = shl;

            ilDirty.Font = _strongFont;
            ilDirty.Visibility = Visibility.Hidden;

            _txtScript.TextChanged += _txtScript_TextChanged;
            _txtScript.SelectionChanged += _txtScript_SelectionChanged;
            _txtScript.PreviewKeyDown += _txtScript_PreviewKeyDown;
            _txtScript.KeyDown += _txtScript_KeyDown;
            _txtScript.KeyPress += _txtScript_KeyPress;

            imScriptSubs.ChangeCommitted += imScriptSubs_ChangeCommitted;
            imScriptExprs.ChangeCommitted += imScriptExprs_ChangeCommitted;
            chkIsTextMode.CheckedChanged += chkIsTextMode_CheckedChanged;

#if skip_dima // this for some reason makes the tooltip's background a non-removable gradient, investigate/report bug:
            if (!string.IsNullOrEmpty(mainForm.Theme))
            {
                var tl = new C1.Win.Themes.C1ThemeLocator(mainForm.Theme);
                var theme = tl.GetTheme();
                if (theme != null)
                    C1.Win.Themes.C1ThemeController.ApplyThemeToObject(_tooltip, theme);
            }
#else
            _tooltip.MaximumWidth = 500; // Note: this seems a nice value, not sure what would be better.
            _tooltip.BackgroundGradient = BackgroundGradient.None;
            _tooltip.BackColor = mainForm.Ribbon.ToolTipSettings.BackColor;
            _tooltip.Border = mainForm.Ribbon.ToolTipSettings.Border;
            _tooltip.BorderColor = mainForm.Ribbon.ToolTipSettings.BorderColor;
            _tooltip.Font = mainForm.Ribbon.ToolTipSettings.Font;
            _tooltip.ForeColor = mainForm.Ribbon.ToolTipSettings.ForeColor;
            _tooltip.IsBalloon = mainForm.Ribbon.ToolTipSettings.IsBalloon;
            _tooltip.RoundedCorners = mainForm.Ribbon.ToolTipSettings.RoundedCorners;
            _tooltip.Shadow = mainForm.Ribbon.ToolTipSettings.Shadow;
            _tooltip.UseFading = mainForm.Ribbon.ToolTipSettings.UseFading;
#endif
        }

        private void InitHiliteColors(MainForm mainForm)
        {
            // color for highlighting the active editor:
            // Color c = inpPanel.InputStyle.ColorSet[C1.Win.InputPanel.StyleColor.ButtonText];
            bool darkTheme = mainForm != null && mainForm.Theme != null && mainForm.Theme.ToLowerInvariant().Contains("dark");
            if (!darkTheme)
            {
                _hiliteBackColor = Color.FromArgb(0xFF, Color.FromArgb(0xE0F7DA));
                _hiliteForeColor = Color.Black;
            }
            else
            {
                _hiliteBackColor = Color.FromArgb(0xFF, Color.FromArgb(0x0a212a));
                _hiliteForeColor = Color.White;
            }
        }
        #endregion

        void imScriptExprs_ChangeCommitted(object sender, EventArgs e)
        {
            if (imScriptExprs.SelectedOption != null)
            {
                SetCurrentScriptItem(imScriptExprs.SelectedOption.Name, SetCurrentScriptItemContext.ItemSelect);
                _txtScript.Focus();
            }
        }

        void imScriptSubs_ChangeCommitted(object sender, EventArgs e)
        {
            if (imScriptSubs.SelectedOption != null)
            {
                SetCurrentScriptItem(imScriptSubs.SelectedOption.Name, SetCurrentScriptItemContext.ItemSelect);
                _txtScript.Focus();
            }
        }

        void chkIsTextMode_CheckedChanged(object sender, EventArgs e)
        {
            bool newTextMode = chkIsTextMode.Checked;
            var si = CurrentScriptItem;
            if (newTextMode)
            {
                this.SyntaxAutoCheck = false;
                this.SyntaxHighlighting = SyntaxHighlightingType.None;
            }
            else
            {
                this.SyntaxAutoCheck = _mainForm._syntaxCheck;
                if (_mainForm._syntaxColoring)
                {
                    bool isFilter = si != null && si.Context.ContextKind == ScriptEditorContextKind.DataView;
                    SyntaxHighlighting = isFilter ? ScriptEditorControl.SyntaxHighlightingType.DataFilter : ScriptEditorControl.SyntaxHighlightingType.VBScript;
                }
            }
            if (si != null && si.IsTextMode != newTextMode)
                si.IsTextMode = newTextMode;
            // This will update available options like syntax highlight etc
            if (CurrentScriptItemChanged != null)
                CurrentScriptItemChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Fires when a script is written back to the owner object.
        /// </summary>
        public EventHandler ScriptWritten;

        /// <summary>
        /// Fires when a new script is selected by the user, or when a script is loaded initially.
        /// This is NOT the event fired when the text of the script item changes.
        /// </summary>
        public EventHandler CurrentScriptItemChanged;

        /// <summary>
        /// Fires when the user changes (edits) the current script.
        /// </summary>
        public EventHandler CurrentScriptTextChanged;

        /// <summary>
        /// Fires when the text selection changes.
        /// </summary>
        public EventHandler TextSelectionChanged;

        /// <summary>
        /// Fires when syntax check should be performed
        /// (on text changed unless code complete window is open, in which case fires when that window closes).
        /// </summary>
        public EventHandler SyntaxCheckNeeded;

        /// <summary>
        /// Gets the script editor.
        /// </summary>
        public RegexTextBox TextBox
        {
            get { return _txtScript; }
        }

        public void GetCurrentLineCol(out int line, out int column)
        {
            // Get the line.
            int index = _txtScript.SelectionStart;
            line = _txtScript.GetLineFromCharIndex(index);

            // Get the column.
            int firstChar = _txtScript.GetFirstCharIndexFromLine(line);
            column = index - firstChar;
        }

        public PictureBox GlyphBox
        {
            get { return pbGlyph; }
        }

        public bool IsSelectedEditor
        {
            get { return false; }
            set
            {
                if (value)
                {
                    this.inpPanel.BackColor = _hiliteBackColor;
                    this.inpPanel.ForeColor = _hiliteForeColor;
                    foreach (InputComponent ic in this.inpPanel.Items)
                        ic.ForeColor = _hiliteForeColor;
                }
                else
                {
                    this.inpPanel.ResetBackColor();
                    this.inpPanel.ResetForeColor();
                    foreach (InputComponent ic in this.inpPanel.Items)
                        ic.ForeColor = inpPanel.ForeColor;
                }
            }
        }

        public Font EditorFont
        {
            get { return _txtScript.Font; }
            set { _txtScript.Font = value; }
        }

        public Color EditorBackgroundColor
        {
            get { return _txtScript.BackColor; }
            set { _txtScript.BackColor = value; }
        }
        public Color EditorTextColor
        {
            get { return _txtScript.ForeColor; }
            set { _txtScript.ForeColor = value; }
        }

        public EditorScriptItem CurrentScriptItem
        {
            get
            {
                EditorScriptItem currScriptItem = null;
                if (!string.IsNullOrEmpty(_currentScriptItemKey))
                    _scriptItems.TryGetValue(_currentScriptItemKey, out currScriptItem);
                return currScriptItem;
            }
        }

        public bool IsCurrentScriptDirty
        {
            get { return _currentScriptIsDirty; }
            internal set { _currentScriptIsDirty = value; }
        }

        public bool SyntaxAutoCheck { get; set; }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public SyntaxHighlightingType SyntaxHighlighting
        {
            get { return _syntaxHighlighting; }
            set
            {
                if (value == _syntaxHighlighting)
                    return;

                var si = CurrentScriptItem;
                _syntaxHighlighting = value;
                switch (_syntaxHighlighting)
                {
                    case SyntaxHighlightingType.None:
                        _txtScript.ClearSyntaxDescriptors();
                        break;
                    case SyntaxHighlightingType.VBScript:
                        _txtScript.ClearSyntaxDescriptors();
                        UpdateSyntaxVBScript(true);
                        UpdateSyntaxC1Report(true);
                        // UpdateSyntaxDataFilter(false);
                        UpdateSyntaxDbFields(true, si != null ? si.Context : null);
                        break;
                    case SyntaxHighlightingType.DataFilter:
                        _txtScript.ClearSyntaxDescriptors();
                        // UpdateSyntaxVBScript(false);
                        // UpdateSyntaxC1Report(false);
                        UpdateSyntaxDataFilter(true);
                        UpdateSyntaxDbFields(true, si != null ? si.Context : null);
                        break;
                    default:
                        System.Diagnostics.Debug.Assert(false);
                        break;
                }
                _txtScript.Refresh();
            }
        }

        public bool AutoSaveCurrentScript { get; set; }

        public enum SetCurrentScriptItemContext
        {
            Initial,
            ItemSelect,
            CloseWindow,
            CancelWindow,
        }

        /// <summary>
        /// Sets the current script item on the control.
        /// If the current item has changed, optionally asks the user to confirm saving the changes.
        /// </summary>
        /// <param name="si"></param>
        /// <param name="confirmUnsavedChanges">If true, and current item has changed, a confirmation message will be shown.
        /// If false, a changed script will be saved automatically.</param>
        /// <returns>True if the change has been successfull, false if the user asked to cancel the change.</returns>
        public bool SetCurrentScriptItem(string scriptItemKey, SetCurrentScriptItemContext context)
        {
            if (_currentScriptItemKey == scriptItemKey)
                return true;

            EditorScriptItem oldScriptItem = null;
            if (!string.IsNullOrEmpty(_currentScriptItemKey))
                _scriptItems.TryGetValue(_currentScriptItemKey, out oldScriptItem);
            EditorScriptItem newScriptItem = null;
            if (!string.IsNullOrEmpty(scriptItemKey))
                _scriptItems.TryGetValue(scriptItemKey, out newScriptItem);

            if (oldScriptItem != null && _currentScriptIsDirty)
            {
                bool showMessage = false;
                string msg = string.Empty;
                switch (context)
                {
                    case SetCurrentScriptItemContext.Initial:
                        showMessage = false;
                        break;
                    case SetCurrentScriptItemContext.ItemSelect:
                        showMessage = !AutoSaveCurrentScript;
                        if (showMessage)
                            msg = string.Format(Strings.ScriptEditorControl.ConfirmSaveFmt, oldScriptItem) + "\r\n\r\n" + Strings.ScriptEditorControl.ConfirmSaveMore;
                        break;
                    case SetCurrentScriptItemContext.CloseWindow:
                        showMessage = false;
                        break;
                    case SetCurrentScriptItemContext.CancelWindow:
                        showMessage = true;
                        msg = string.Format(Strings.ScriptEditorControl.ConfirmSaveFmt, oldScriptItem);
                        break;
                    default:
                        System.Diagnostics.Debug.Assert(false);
                        break;
                }
                var confirm = showMessage ?
                    MessageForm.Show(null, MessageForm.Caption.Confirm, msg, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) : DialogResult.Yes;
                if (confirm == DialogResult.Cancel)
                    return false;
                else if (confirm == DialogResult.Yes)
                {
                    // This is THE (only) place where we actually save the script:
                    oldScriptItem.WriteValue(_txtScript.Text);
                    if (ScriptWritten != null)
                        ScriptWritten(this, EventArgs.Empty);

                    InputOption iopt = null;
                    if (imScriptSubs.Items.Contains(oldScriptItem.Key))
                        iopt = (InputOption)imScriptSubs.Items[oldScriptItem.Key];
                    else if (imScriptExprs.Items.Contains(oldScriptItem.Key))
                        iopt = (InputOption)imScriptExprs.Items[oldScriptItem.Key];
                    UpdateInputOption(iopt, oldScriptItem);
                }
            }

            _currentScriptIsDirty = false;
            ilDirty.Visibility = Visibility.Hidden;
            _textBeforeChange = null;
            bool isTextMode = false;
            if (newScriptItem != null)
            {
                if (!newScriptItem.IsScript)
                {
                    lblField.Font = _strongFont;
                    lblScript.Font = _regularFont;
                    imScriptExprs.Text = newScriptItem.ToString();
                    imScriptSubs.Text = null;
                }
                else
                {
                    lblScript.Font = _strongFont;
                    lblField.Font = _regularFont;
                    imScriptSubs.Text = newScriptItem.ToString();
                    imScriptExprs.Text = null;
                }
                _txtScript.Text = newScriptItem.Text;
                chkIsTextMode.Enabled = !newScriptItem.IsScript;
                isTextMode = newScriptItem.IsTextMode;
            }
            else
            {
                lblScript.Font = _regularFont;
                lblField.Font = _regularFont;
                imScriptSubs.Text = null;
                imScriptExprs.Text = null;
                _txtScript.Text = string.Empty;
                chkIsTextMode.Enabled = false;
            }
            // Save set text - from that point on, any changes will be handled:
            _textBeforeChange = _txtScript.Text;

            _txtScript.ClearUndo(_textBeforeChange);
            _currentScriptItemKey = scriptItemKey;

            if (chkIsTextMode.Checked != isTextMode)
                chkIsTextMode.Checked = isTextMode;

            if (!_isMovingInHistory && newScriptItem != null)
            {
                if (_historyIdx < _history.Count - 1)
                    _history.RemoveRange(_historyIdx + 1, _history.Count - _historyIdx - 1);
                _history.Add(_currentScriptItemKey);
                _historyIdx = _history.Count - 1;
            }

            if (CurrentScriptItemChanged != null)
                CurrentScriptItemChanged(this, EventArgs.Empty);

            return true;
        }

        public bool IsTextMode
        {
            get
            {
                var si = CurrentScriptItem;
                if (si != null)
                    return si.IsTextMode;
                return false;
            }
        }

        public bool HistoryCanGoBack
        {
            get { return _historyIdx > 0; }
        }

        public bool HistoryCanGoForward
        {
            get { return _historyIdx >= 0 && _historyIdx < _history.Count - 1; }
        }

        public void HistoryGoBack()
        {
            if (_historyIdx > 0)
            {
                _isMovingInHistory = true;
                if (this.SetCurrentScriptItem(_history[_historyIdx - 1], Forms.ScriptEditorControl.SetCurrentScriptItemContext.ItemSelect))
                    --_historyIdx;
                _isMovingInHistory = false;
            }
        }

        public void HistoryGoForward()
        {
            if (_historyIdx < _history.Count - 1)
            {
                _isMovingInHistory = true;
                if (this.SetCurrentScriptItem(_history[_historyIdx + 1], Forms.ScriptEditorControl.SetCurrentScriptItemContext.ItemSelect))
                    ++_historyIdx;
                _isMovingInHistory = false;
            }
        }


        private InputOption MakeInputOption(EditorScriptItem si)
        {
            InputOption iopt = new InputOption();
            iopt.Name = si.Key;
            iopt.Text = si.ToString();
            iopt.Width = imScriptSubs.Width;
            UpdateInputOption(iopt, si);
            return iopt;
        }

        private void UpdateInputOption(InputOption iopt, EditorScriptItem si)
        {
            if (!string.IsNullOrEmpty(si.Text))
            {
                iopt.ToolTipText = string.Format("<pre>{0}</pre>", si.Text);
                if (!si.IsTextMode) // - this was 'if calculated'
                    iopt.Font = _strongFont;
                else
                    iopt.Font = _regularFont;
            }
            else
            {
                iopt.ToolTipText = null;
                iopt.Font = _regularFont;
            }
        }


        private void UpdateLists()
        {
            this.inpPanel.BeginUpdate();
            try
            {
                imScriptSubs.Items.Clear();
                imScriptExprs.Items.Clear();

                if (_scriptItems == null)
                    return;

                foreach (string key in _scriptItems.Keys)
                {
                    EditorScriptItem si = _scriptItems[key];
                    if (!si.IsScript)
                        imScriptExprs.Items.Add(MakeInputOption(si));
                    else
                        imScriptSubs.Items.Add(MakeInputOption(si));
                }
            }
            finally
            {
                this.inpPanel.EndUpdate();
            }
        }

        public bool CheckSyntax(out string error)
        {
            if (IsTextMode)
            {
                error = string.Empty;
                return true;
            }

            if (_report != null && SyntaxAutoCheck)
            {
                var si = CurrentScriptItem;
                if (si != null)
                {
                    bool asExpression;
                    if (si.CanSyntaxCheck(out asExpression))
                    {
                        Exception x = asExpression ? _report.ParseExpression(_txtScript.Text) : _report.ParseStatement(_txtScript.Text, si.Key, si.IsGlobal);
                        if (x != null)
                        {
                            error = x.Message;
                            return false;
                        }

                    }
                }
            }
            error = string.Empty;
            return true;
        }

        public void InitSyntaxDbFields(EditorScriptContextBase context)
        {
            UpdateSyntaxDbFields(SyntaxHighlighting != SyntaxHighlightingType.None, context);
            _txtScript.Refresh();
        }

        private void UpdateSyntaxC1Report(bool on)
        {
            System.Diagnostics.Debug.Assert(!on || SyntaxHighlighting == SyntaxHighlightingType.VBScript);

            _txtScript.RemoveSyntaxDescriptor(SyntaxHiliteGroups.C1rAggregates);
            _txtScript.RemoveSyntaxDescriptor(SyntaxHiliteGroups.C1rFunctions);
            _txtScript.RemoveSyntaxDescriptor(SyntaxHiliteGroups.C1rVariables);
            if (on && _report != null)
            {
                // Aggregates functions:
                string rx = @"(?i)(^|\W)(?<match>" + ScriptSyntaxC1Report.Aggregates.RegexWords + @")+(?=$|\W)";
                _txtScript.AddSyntaxDescriptor(SyntaxHiliteGroups.C1rAggregates, new SyntaxDescriptor(rx, Color.Blue));

                // Built-in functions (Like(), In(), Iif, Format):
                rx = @"(?i)(^|\W)(?<match>" + ScriptSyntaxC1Report.Functions.RegexWords + @")+(?=$|\W)";
                _txtScript.AddSyntaxDescriptor(SyntaxHiliteGroups.C1rFunctions, new SyntaxDescriptor(rx, Color.Blue));

                // report keywords (Report/Page/Pages/Cancel), fields and sections:
                StringBuilder sb = new StringBuilder(ScriptSyntaxC1Report.Keywords.RegexWords);
                foreach (var p in _report.Parameters)
                    sb.AppendFormat("|{0}", p.Name);
                foreach (var f in _report.Fields)
                    sb.AppendFormat("|{0}", f.Name);
                foreach (var g in _report.Groups)
                    sb.AppendFormat("|{0}", g.Name);
                foreach (Section s in _report.Sections)
                    sb.AppendFormat("|{0}", s.Name);
                rx = @"(?i)(^|\W)(?<match>" + sb.ToString() + @")+(?=$|\W)";
                _txtScript.AddSyntaxDescriptor(SyntaxHiliteGroups.C1rVariables, new SyntaxDescriptor(rx, Color.Gray));
            }
        }

        /// <summary>
        /// Adds or removes VBScript-specific syntax.
        /// Does NOT update C1Report aggregates/fields/sections.
        /// </summary>
        private void UpdateSyntaxVBScript(bool on)
        {
            System.Diagnostics.Debug.Assert(!on || SyntaxHighlighting == SyntaxHighlightingType.VBScript);

            _txtScript.RemoveSyntaxDescriptor(SyntaxHiliteGroups.VbsComments);
            _txtScript.RemoveSyntaxDescriptor(SyntaxHiliteGroups.VbsStrings);
            _txtScript.RemoveSyntaxDescriptor(SyntaxHiliteGroups.VbsBrackets);
            _txtScript.RemoveSyntaxDescriptor(SyntaxHiliteGroups.VbsKeywords);
            _txtScript.RemoveSyntaxDescriptor(SyntaxHiliteGroups.VbsConstants);
            _txtScript.RemoveSyntaxDescriptor(SyntaxHiliteGroups.VbsFunctions);
            if (on)
            {
                // comments
                _txtScript.AddSyntaxDescriptor(SyntaxHiliteGroups.VbsComments, new SyntaxDescriptor("(?m)'.*$", Color.Green));

                // strings
                _txtScript.AddSyntaxDescriptor(SyntaxHiliteGroups.VbsStrings, new SyntaxDescriptor(@"""[^""\n]*""", Color.DarkRed));

                // variable names in brackets 
                // (to avoid highlighing vb keywords in the names, e.g. [Start Date])
                // note: use Color.FromArgb(1) instead of black because black is the
                //       default color and may be overwritten by other descriptors.
                _txtScript.AddSyntaxDescriptor(SyntaxHiliteGroups.VbsBrackets, new SyntaxDescriptor(@"\[[^\]\n]+\]", Color.FromArgb(1)));

                // VScript keywords
                // make sure longer words come first, e.g. EndIf|End, ElseIf|Else
                string rx = @"(?i)(^|\W)(?<match>" + ScriptSyntaxVBScript.Keywords.RegexWords + @")+(?=$|\W)";
                _txtScript.AddSyntaxDescriptor(SyntaxHiliteGroups.VbsKeywords, new SyntaxDescriptor(rx, Color.Blue));

                // VBScript functions
                rx = @"(?i)(^|\W)(?<match>" + ScriptSyntaxVBScript.Constants.RegexWords + @")+(?=$|\W)";
                _txtScript.AddSyntaxDescriptor(SyntaxHiliteGroups.VbsConstants, new SyntaxDescriptor(rx, Color.DarkMagenta));

                // VBScript functions
                rx = @"(?i)(^|\W)(?<match>" + ScriptSyntaxVBScript.RegexAllFunctions + @")+(?=$|\W)";
                _txtScript.AddSyntaxDescriptor(SyntaxHiliteGroups.VbsFunctions, new SyntaxDescriptor(rx, Color.Blue));
            }
        }

        private void UpdateSyntaxDbFields(bool on, EditorScriptContextBase context)
        {
            _txtScript.RemoveSyntaxDescriptor(SyntaxHiliteGroups.DbFields);
            if (on && context != null && context.HasDataSourceInfo)
            {
                // add db fields to syntax
                StringBuilder sb = new StringBuilder();

                var fieldNames = context.DataSourceInfo.Fields.Select((f_) => f_.Name).Concat(context.CalculatedFields.Select((c_) => c_.Name));
                foreach (string s in fieldNames)
                    sb.AppendFormat(sb.Length == 0 ? "{0}" : "|{0}", s);

                string rx = @"(?i)(^|\W)(?<match>" + sb.ToString() + @")+(?=$|\W)";
                _txtScript.AddSyntaxDescriptor(SyntaxHiliteGroups.DbFields, new SyntaxDescriptor(rx, Color.DarkSlateBlue));
            }
        }

        private void UpdateSyntaxDataFilter(bool on)
        {
            System.Diagnostics.Debug.Assert(!on || SyntaxHighlighting == SyntaxHighlightingType.DataFilter);

            _txtScript.RemoveSyntaxDescriptor(SyntaxHiliteGroups.FilterStrings);
            _txtScript.RemoveSyntaxDescriptor(SyntaxHiliteGroups.FilterBrackets);
            _txtScript.RemoveSyntaxDescriptor(SyntaxHiliteGroups.FilterKeywords);
            _txtScript.RemoveSyntaxDescriptor(SyntaxHiliteGroups.FilterFunctions);
            if (on)
            {
                // comments - not supported

                // strings
                _txtScript.AddSyntaxDescriptor(SyntaxHiliteGroups.FilterStrings, new SyntaxDescriptor(@"'[^'\n]*'", Color.DarkRed));

                // variable names in brackets 
                // (to avoid highlighing vb keywords in the names, e.g. [Start Date])
                // note: use Color.FromArgb(1) instead of black because black is the
                //       default color and may be overwritten by other descriptors.
                // (in filter expressions, back quotes may be used instead of square brackets)
                _txtScript.AddSyntaxDescriptor(SyntaxHiliteGroups.FilterBrackets, new SyntaxDescriptor(@"\[[^\]\n]+\]|`[^`\n]+`", Color.FromArgb(1)));

                // keywords
                // make sure longer words come first, e.g. EndIf|End, ElseIf|Else
                string rx = ScriptSyntaxDataFilter.Keywords.RegexWords;
                rx = @"(?i)(^|\W)(?<match>" + rx + @")+(?=$|\W)";
                _txtScript.AddSyntaxDescriptor(SyntaxHiliteGroups.FilterKeywords, new SyntaxDescriptor(rx, Color.Blue));

                // functions
                rx = ScriptSyntaxDataFilter.Functions.RegexWords;
                rx = @"(?i)(^|\W)(?<match>" + rx + @")+(?=$|\W)";
                _txtScript.AddSyntaxDescriptor(SyntaxHiliteGroups.FilterFunctions, new SyntaxDescriptor(rx, Color.Blue));
            }
        }

        #region IIntellisenseOwner
        public Form MasterForm
        {
            get { return this.FindForm(); }
        }

        public Control EditorControl
        {
            get { return this._txtScript; }
        }

        public void OnClosed()
        {
            _ccw = null;
            if (_checkSyntaxPending)
            {
                _checkSyntaxPending = false;
                if (SyntaxCheckNeeded != null)
                    SyntaxCheckNeeded(this, EventArgs.Empty);
            }
        }

        public void InsertText(string text, CodeCompleteContext context)
        {
            if (!string.IsNullOrEmpty(text))
            {
                _txtScript.SelectionStart = context.WordPosition;
                _txtScript.SelectionLength = context.WordLength;
                switch (context.Kind)
                {
                    case CodeCompleteKind.None:
                        InsertTemplate(text);
                        break;
                    case CodeCompleteKind.DbFields:
                        _txtScript.SelectedText = text;
                        break;
                    default:
                        System.Diagnostics.Debug.Assert(false);
                        break;
                }
            }
            _txtScript.Focus();
        }

        public string GetContextWord(CodeCompleteContext context)
        {
            return context.GetWord(_txtScript);
        }

        /// <summary>
        /// Inserts the template text into the editor.
        /// The following special chars/strings are supported, in order of precedence:
        /// - ".." - replaced with two newlines (\n), used in constructs such as "If * Then .. End If".
        /// - "~" - locates the insertion point, but is removed from the template itself.
        /// - "*" - locates the insertion point, and gets selected (so that typing replaces it).
        /// - "(" - locates the insertion point after itself.
        /// </summary>
        /// <param name="template"></param>
        public void InsertTemplate(string template)
        {
            template = template.Replace(" .. ", "\n\n"); ;
            // tilda points to where to put the cursor, but is itself not inserted:
            int tilda = template.IndexOf('~');
            template = template.Replace("~", "");

            // insert menu text
            _txtScript.SelectedText = template;

            // position cursor
            if (tilda > -1)
                _txtScript.SelectionStart -= (template.Length - tilda);
            else
            {
                int asterisk = template.IndexOf("*");
                int openPar = template.IndexOf("(");
                if (asterisk > -1)
                {
                    _txtScript.SelectionStart -= (template.Length - asterisk);
                    _txtScript.SelectionLength = 1;
                }
                else if (openPar > -1)
                    _txtScript.SelectionStart -= (template.Length - openPar - 1);
            }
        }

        #endregion

        private CodeCompleteWindow _ccw = null;
        private bool _ccExpectedChange = false;
        // if this is non-null, _txtScript_KeyPress should eat the corresponding char
        private char? _ccKeyPressPending = null;

        void _txtScript_TextChanged(object sender, EventArgs e)
        {
            // Handle only REAL text changes (null means we're still initializing):
            if (_textBeforeChange == _txtScript.Text || _textBeforeChange == null)
                return;

            _textBeforeChange = _txtScript.Text;

            _currentScriptIsDirty = true;
            ilDirty.Visibility = Visibility.Visible;
            if (CurrentScriptTextChanged != null)
                CurrentScriptTextChanged(this, EventArgs.Empty);

            // there is not much point in syntax checking while the code complete window is open:
            if (_ccw != null)
            {
                if (_ccExpectedChange)
                {
                    _checkSyntaxPending = true;
                    _ccw.UpdateFilter();
                }
                else
                {
                    _ccw.Close();
                    if (SyntaxCheckNeeded != null)
                        SyntaxCheckNeeded(this, EventArgs.Empty);
                }
            }
            else if (!IsTextMode && SyntaxCheckNeeded != null)
                SyntaxCheckNeeded(this, EventArgs.Empty);
            _ccExpectedChange = false;
        }

        void _txtScript_SelectionChanged(object sender, EventArgs e)
        {
            if (_ccw != null)
            {
                if (_txtScript.SelectionStart < _ccw.Context.WordPosition ||
                    (_txtScript.SelectionStart + _txtScript.SelectionLength) > (_ccw.Context.WordPosition + _ccw.Context.WordLength))
                    _ccw.Close();
            }

            if (TextSelectionChanged != null)
                TextSelectionChanged(this, EventArgs.Empty);
        }

        void _txtScript_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
        }

        void _txtScript_KeyDown(object sender, KeyEventArgs e)
        {
            if (IsTextMode)
                return;

            System.Diagnostics.Debug.Assert(!_ccKeyPressPending.HasValue);

            if (_ccw == null)
            {
                if (e.KeyData == (Keys.J | Keys.Control) || e.KeyData == (Keys.Space | Keys.Control))
                {
                    CodeCompleteContext ccw;
                    int line, col;
                    GetCurrentLineCol(out line, out col);
                    if (col > 0 && _txtScript.Lines[line][col - 1] == '.')
                    {
                        ccw = PrepareCcContextDotNet(TokenizeLineLeftOfCaret());
                    }
                    else
                    {
                        ccw = PrepareCcContextGeneral(CodeCompleteKind.None);
                        if (ccw != null)
                        {
                            for (int i = _txtScript.SelectionStart - 1; i >= 0 && --col >= 0 && char.IsLetterOrDigit(_txtScript.Text[i]); --i)
                            {
                                ccw.WordLength += 1;
                                ccw.WordPosition -= 1;
                            }
                        }
                    }
                    ShowIntellisense(ccw);
                    e.Handled = true;
                    if (e.KeyData == (Keys.Space | Keys.Control))
                        _ccKeyPressPending = ' '; // eat the space char
                }
            }
            else // _ccw != null
            {
                if (e.KeyData == Keys.Tab)
                    _ccKeyPressPending = '\t';
                else if (e.KeyData == Keys.Back)
                {
                    if (_txtScript.SelectionStart > 0)
                    {
                        _ccw.Context.WordLength -= _txtScript.SelectionLength > 0 ? _txtScript.SelectionLength : 1;
                        _ccExpectedChange = _ccw.Context.WordLength > 0; // we will hide intellisence on missing word
                    }
                }
                else if (e.KeyData == Keys.Delete) // note: this never happens if something is selected, investigate...
                {
                    if (_txtScript.SelectionStart < _txtScript.TextLength)
                    {
                        _ccw.Context.WordLength -= _txtScript.SelectionLength > 0 ? _txtScript.SelectionLength : 1;
                        _ccExpectedChange = _ccw.Context.WordLength > 0; // we will hide intellisence on missing word
                    }
                }
                // ccw.HandleKeyDown can cause the code completion window to close,
                // which sets _ccw to null, hence this:
                var ccw = _ccw;
                e.Handled = ccw.HandleKeyDown(e);
            }
        }

        void _txtScript_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (IsTextMode)
                return;

            if (_ccKeyPressPending.HasValue && _ccKeyPressPending.Value == e.KeyChar)
            {
                _ccKeyPressPending = null;
                e.Handled = true;
                return;
            }

            if (_ccw == null)
            {
                if (char.IsLetter(e.KeyChar))
                {
                    var prevIdx = _txtScript.SelectionStart - 1;
                    if (prevIdx < 0 || !char.IsLetterOrDigit(_txtScript.Text[prevIdx]))
                    {
                        ShowIntellisense(PrepareCcContextGeneral(CodeCompleteKind.None));
                        if (_ccw == null)
                            return;
                        _ccExpectedChange = true;
                        _ccw.Context.WordLength = 1;
                    }
                }
                else if (e.KeyChar == '[')
                {
                    ShowIntellisense(PrepareCcContextGeneral(CodeCompleteKind.DbFields));
                    if (_ccw == null)
                        return;
                    _ccExpectedChange = true;
                    _ccw.Context.WordLength = 1;
                }
                else if (e.KeyChar == '.')
                {
                    _txtScript.SelectedText = ".";
                    ShowIntellisense(PrepareCcContextDotNet(TokenizeLineLeftOfCaret()));
                    e.Handled = true;
                }
                else if (e.KeyChar == '\t')
                {
                    _txtScript.SelectedText = "  ";
                    e.Handled = true;
                }
            }
            else // _ccw != null
            {
                if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '[')
                {
                    _ccExpectedChange = true;
                    _ccw.Context.WordLength += 1 - _txtScript.SelectionLength;
                }
                else if (e.KeyChar == '.')
                {
                    _ccw.AcceptAndClose();
                    _txtScript.SelectedText = ".";
                    ShowIntellisense(PrepareCcContextDotNet(TokenizeLineLeftOfCaret()));
                    e.Handled = true;
                }
            }
        }

        /// <summary>
        /// This method is used to "tokenize" the VBScript line to the left of caret,
        /// getting to the start of a dot-separated member invocation chain which may also contain function calls
        /// (e.g. report.Fileds(0).Name). Last dot is ignored. Balanced parentheses are skipped.
        /// Strings in double quotes are excluded. VBS continuation lines are accounted for.
        /// </summary>
        /// <returns>
        /// Returns the list of tokens, starting with the last one.
        /// Tokens that are function calls have a "(" appended to the name.
        /// E.g. for Report.Fields(0).Name, the returned list is "Name", "Fields(", "Report".
        /// </returns>
        private List<string> TokenizeLineLeftOfCaret()
        {
            int line, column;
            GetCurrentLineCol(out line, out column);
            // Get current line:
            string sline = line < _txtScript.Lines.Length ? _txtScript.Lines[line] : string.Empty;
            if (string.IsNullOrEmpty(sline))
                return null;
            // Trim to the right of caret:
            sline = sline.Substring(0, column);
            // Ignore last dot:
            if (sline.EndsWith("."))
                sline = sline.Substring(0, sline.Length - 1);
            // Prepend continued lines:
            for (int i = line - 1; i >= 0 && _txtScript.Lines[i].EndsWith("_"); --i)
                sline = _txtScript.Lines[i].Substring(0, _txtScript.Lines[i].Length - 1) + sline;

            // debug: System.Diagnostics.Debug.WriteLine("*** LINE: '" + sline + "'");

            // 1. Remove strings from sline:
            sline = Regex.Replace(sline, @"""[^""]*""", "");

            // debug: System.Diagnostics.Debug.WriteLine("*** LINE w/out strings: '" + sline + "'");

            // 2. Go backwards over line, skipping whatever is inside balanced pairs of parentheses:
            var tks = new List<string>();
            bool isFuncCall = false;
            Action<int, int> addToken = (idx, len) =>
                {
                    string tstr = sline.Substring(idx, len);
                    if (isFuncCall)
                    {
                        tstr += "(";
                        isFuncCall = false;
                    }
                    tks.Add(tstr);
                };

            int paren = 0;
            int end = sline.Length;
            bool done = false;
            for (int chi = sline.Length - 1; chi >= 0; --chi)
            {
                if (sline[chi] == ')')
                {
                    ++paren;
                }
                else if (sline[chi] == '(')
                {
                    if (paren == 0)
                    {
                        addToken(chi + 1, end - chi - 1);
                        done = true;
                        break;
                    }
                    else if (--paren == 0)
                        isFuncCall = true;
                    end = chi;
                }
                else if (paren == 0)
                {
                    if (sline[chi] == '.')
                    {
                        addToken(chi + 1, end - chi - 1);
                        end = chi;
                    }
                    else if (!char.IsLetterOrDigit(sline[chi]))
                    {
                        addToken(chi + 1, end - chi - 1);
                        done = true;
                        break;
                    }
                }
                // skip all within paremtheses
            }
            // we got to the beginning of line, add it too:
            if (paren == 0 && !done)
                addToken(0, end);

            // debug: foreach (string ss in tks) System.Diagnostics.Debug.WriteLine(">>>>TK: |" + ss + "|");

            return tks;
        }

        // Helper methods preparing code complete entries' lists:
        private void Make_ReportParameters(List<ScriptSyntaxItem> list, EditorScriptContextBase context)
        {
            if ((_scriptSyntaxItemFlags & ScriptSyntaxItemFlags.C1ReportParams) != ScriptSyntaxItemFlags.None)
                foreach (var par in context.Parameters)
                    list.Add(ScriptSyntaxItem.MakeC1RepParamItem(par.Name));
        }
        private void Make_DbFields(List<ScriptSyntaxItem> list, EditorScriptContextBase context)
        {
            if ((_scriptSyntaxItemFlags & ScriptSyntaxItemFlags.C1ReportDbFields) != ScriptSyntaxItemFlags.None)
            {
                if (context.HasDataSourceInfo)
                {
                    foreach (var fi in context.DataSourceInfo.Fields)
                        list.Add(ScriptSyntaxItem.MakeDbFieldItem(fi.Name));
                }
                if (context.CalculatedFields != null)
                {
                    foreach (var cf in context.CalculatedFields)
                        list.Add(ScriptSyntaxItem.MakeC1dbCalcFieldItem(cf.Name));
                }
            }
        }
        private void Make_ReportGroups(List<ScriptSyntaxItem> list)
        {
            if ((_scriptSyntaxItemFlags & ScriptSyntaxItemFlags.C1ReportGroups) != ScriptSyntaxItemFlags.None)
                foreach (var group in _report.Groups.Where((g_) => !string.IsNullOrEmpty(g_.Name)))
                    list.Add(ScriptSyntaxItem.MakeC1RepGroupItem(group.Name));
        }
        private void Make_ReportFields(List<ScriptSyntaxItem> list, EditorScriptContextBase context)
        {
            if ((_scriptSyntaxItemFlags & ScriptSyntaxItemFlags.C1ReportFields) != ScriptSyntaxItemFlags.None)
                foreach (var f in _report.Fields)
                    list.Add(ScriptSyntaxItem.MakeC1FieldItem(f, context.Designer));
        }
        private void Make_ReportSections(List<ScriptSyntaxItem> list)
        {
            if ((_scriptSyntaxItemFlags & ScriptSyntaxItemFlags.C1ReportSections) != ScriptSyntaxItemFlags.None)
                foreach (var s in _report.Sections)
                    list.Add(ScriptSyntaxItem.MakeC1SectionItem(s));
        }
        private void Make_ReportGlobalFuncs(List<ScriptSyntaxItem> list)
        {
            if ((_scriptSyntaxItemFlags & ScriptSyntaxItemFlags.C1ReportGlobals) != ScriptSyntaxItemFlags.None)
                foreach (string fn in _report.GetGlobalFunctions())
                    list.Add(ScriptSyntaxItem.MakeC1GlobalFuncItem(fn));
        }
        private void Make_ReportGlobalSubs(List<ScriptSyntaxItem> list)
        {
            if ((_scriptSyntaxItemFlags & ScriptSyntaxItemFlags.C1ReportGlobals) != ScriptSyntaxItemFlags.None)
                foreach (string sn in _report.GetGlobalSubs())
                    list.Add(ScriptSyntaxItem.MakeC1GlobalSubItem(sn));
        }
        /// <summary>
        /// Checks whether the current caret is to the right of a comment char (')
        /// or inside a double quoted string. Used to avoid code complete window popping up in those cases.
        /// This method is simple/stupid, will do for now (we must review the whole syntax check/highlight/etc stuff).
        /// </summary>
        /// <returns></returns>
        private bool IsCurrLineCommentOrString()
        {
            int line, column;
            GetCurrentLineCol(out line, out column);
            // Get current line:
            if (line >= _txtScript.Lines.Length)
                return false;
            string sline = _txtScript.Lines[line];
            // Trim to the right of caret:
            sline = sline.Substring(0, column);
            if (string.IsNullOrEmpty(sline))
                return false;

            if (sline.Contains("'"))
                return true;
            int qCount = 0;
            foreach (char c in sline)
                if (c == '"')
                    ++qCount;
            if ((qCount % 2) == 1)
                return true;

            return false;
        }
        /// <summary>
        /// Prepares a code complete context for the general case (i.e. not after a dot).
        /// </summary>
        /// <returns></returns>
        private CodeCompleteContext PrepareCcContextGeneral(CodeCompleteKind cck)
        {
            System.Diagnostics.Debug.Assert(_ccw == null);

            int selStart = _txtScript.SelectionStart;
            if (selStart < 0 || selStart > _txtScript.Text.Length)
                return null;

            var si = this.CurrentScriptItem;
            if (si == null)
                return null;

            bool isDataFilter = si.Context.ContextKind == ScriptEditorContextKind.DataView;
            bool isDataContext = si.Context.ContextKind == ScriptEditorContextKind.DataHandler;
            if (isDataFilter && cck == CodeCompleteKind.DbFields)
                return null;

            if (IsCurrLineCommentOrString())
                return null;

            CodeCompleteContext context = new CodeCompleteContext()
            {
                Kind = cck,
                WordPosition = selStart,
                WordLength = 0
            };

            switch (context.Kind)
            {
                case CodeCompleteKind.None:
                    var items = new List<ScriptSyntaxItem>();
                    if (!isDataFilter)
                    {
                        // data
                        Make_ReportParameters(items, si.Context);
                        Make_DbFields(items, si.Context);
                        if (!isDataContext)
                        {
                            // report
                            Make_ReportGroups(items);
                            Make_ReportFields(items, si.Context);
                            Make_ReportSections(items);
                            if (!si.IsScript)
                                Make_ReportGlobalFuncs(items);
                            else // not expression
                            {
                                Make_ReportGlobalSubs(items);
                                Make_ReportGlobalFuncs(items);
                            }
                        }
                        if ((_scriptSyntaxItemFlags & ScriptSyntaxItemFlags.VBScript) != ScriptSyntaxItemFlags.None)
                            items.AddRange(ScriptSyntaxC1Report.AllC1ReportSyntaxItems);
                        // Generic VBScript:
                        if ((_scriptSyntaxItemFlags & ScriptSyntaxItemFlags.VBScript) != ScriptSyntaxItemFlags.None)
                            items.AddRange(ScriptSyntaxVBScript.AllVBScriptSyntaxItems);
                    }
                    else
                    {
                        if ((_scriptSyntaxItemFlags & ScriptSyntaxItemFlags.DataFilter) != ScriptSyntaxItemFlags.None)
                            items.AddRange(ScriptSyntaxDataFilter.AllDataFilterSyntaxItems);
                    }
                    items.Sort();
                    context.SyntaxItems = items;
                    break;
                case CodeCompleteKind.DbFields:
                    if ((_scriptSyntaxItemFlags & ScriptSyntaxItemFlags.C1ReportDbFields) != ScriptSyntaxItemFlags.None)
                    {
                        var dbfields = new List<ScriptSyntaxItem>();
                        Make_DbFields(dbfields, si.Context);
                        dbfields.Sort();
                        context.SyntaxItems = dbfields;
                    }
                    break;
                default:
                    System.Diagnostics.Debug.Assert(false);
                    break;
            }

            if (context.SyntaxItems == null || context.SyntaxItems.Count == 0)
                return null;

            return context;
        }

        /// <summary>
        /// Prepares a code complete context for after a dot, based on .net types, triggered by hitting '.'.
        /// 
        /// Tokens are in inverse order, e.g. report.Fields(0).Name is:
        /// "Name", "Fields", "report"
        /// 
        /// This method handles following root report objects:
        /// - Report
        /// - Parameters
        /// - 'parameter name'
        /// For report (not data handler) context, also:
        /// - report Fields
        /// - report Sections
        /// - report Groups
        /// </summary>
        /// <param name="tokens"></param>
        /// <returns></returns>
        private CodeCompleteContext PrepareCcContextDotNet(List<string> tokens)
        {
            if (tokens == null || tokens.Count == 0)
                return null;
            if ((_scriptSyntaxItemFlags & (ScriptSyntaxItemFlags.DotNetFields | ScriptSyntaxItemFlags.DotNetMethods | ScriptSyntaxItemFlags.DotNetProperties)) == ScriptSyntaxItemFlags.None)
                return null;
            var si = this.CurrentScriptItem;
            if (si == null)
                return null;

            if (IsCurrLineCommentOrString())
                return null;

            try
            {
                bool isReportScript = si.Context.ContextKind == ScriptEditorContextKind.ReportScript;
                bool isFuncCall = false;
                Func<int, string> getToken = (idx) =>
                    {
                        string tstr = tokens[idx];
                        isFuncCall = tstr.EndsWith("(");
                        if (isFuncCall)
                            tstr = tstr.Substring(0, tstr.Length - 1);
                        return tstr;
                    };

                string rootToken = getToken(tokens.Count - 1);
                // Root tokens available in both data handler and report script contexts:
                Type type = GetRootObjectType(rootToken, isFuncCall, !isReportScript);

                // todo: not sure what to do with Page/Pages/Cancel...

                if (type == null || isFuncCall) // we cannot handle function calls on report/field/section
                    return null;

                // go down the tokens chain:
                for (int i = tokens.Count - 2; i >= 0; --i)
                {
                    string token = getToken(i);
                    MemberInfo[] tmis = type.GetMember(token);
                    if (tmis.Length == 0)
                        return null;
                    switch (tmis[0].MemberType)
                    {
                        case MemberTypes.Property:
                            type = GetProperty(type, token);
                            if (isFuncCall)
                            {
                                // assuming integer indexing, e.g. report.Fields(0) -> report.Fields.Item(0)
                                // type = type.GetProperty(token).PropertyType;
                                // var att = type.GetCustomAttribute(typeof(DefaultMemberAttribute), true) as DefaultMemberAttribute;
                                var att = AppUtils.GetAttribute<DefaultMemberAttribute>(type);
                                if (att != null)
                                    type = type.GetProperty(att.MemberName, new Type[] { typeof(int) }).PropertyType;
                            }
                            break;
                        case MemberTypes.Field:
                            if (!isFuncCall)
                                type = type.GetField(token).FieldType;
                            else
                                type = null;
                            break;
                        case MemberTypes.Method:
                            if (isFuncCall)
                                type = type.GetMethod(token).ReturnType;
                            else
                                type = null;
                            break;
                        default:
                            return null;
                    }
                }
                if (type == null || type == typeof(void))
                    return null;

                List<ScriptSyntaxItem> items = new List<ScriptSyntaxItem>();
                // Properties:
                if ((_scriptSyntaxItemFlags & ScriptSyntaxItemFlags.DotNetProperties) != ScriptSyntaxItemFlags.None)
                {
                    var props = GetProperties(type);
                    props.ForEach(pi_ => items.Add(ScriptSyntaxItem.MakeDotNetPropertyItem(pi_)));
                }
                // Methods:
                if ((_scriptSyntaxItemFlags & ScriptSyntaxItemFlags.DotNetMethods) != ScriptSyntaxItemFlags.None)
                {
                    var methods = GetMethods(type);
                    methods.ForEach(mi_ => items.Add(ScriptSyntaxItem.MakeDotNetMethodItem(mi_)));
                }
                // todo: fields?
                // todo: statics?

                if (items.Count == 0)
                    return null;

                items.Sort();

                CodeCompleteContext context = new CodeCompleteContext()
                {
                    Kind = CodeCompleteKind.None,
                    WordPosition = _txtScript.SelectionStart,
                    WordLength = 0,
                    SyntaxItems = items
                };
                return context;
            }
            catch
            {
                // if something went wrong (probably in reflection), we just bail out quietly:
                return null;
            }
        }

        private List<PropertyInfo> GetProperties(Type type)
        {
            var props = type.GetProperties(BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Instance);
            List<PropertyInfo> ret = new List<PropertyInfo>(props.Length);
            // Note on this and skip below: if a property with the same name is declared on a parent type,
            // we skip it as in VBScript we cannot tell the two apart. A case in point Parameter.Owner. (TFS:150802 case 2)
            List<int> skips = new List<int>();
            for (int i = 0; i < props.Length; ++i)
            {
                if (skips.Contains(i))
                    continue;
                var pi = props[i];
                var browsable = AppUtils.GetAttribute<EditorBrowsableAttribute>(pi);
                if (browsable != null && browsable.State != EditorBrowsableState.Always)
                    continue;
                bool skip = false;
                for (int j = i + 1; j < props.Length; ++j)
                {
                    var tpi = props[j];
                    if (pi.Name == tpi.Name &&
                        pi.GetIndexParameters().Length == tpi.GetIndexParameters().Length)
                    {
                        if (pi.DeclaringType.IsAssignableFrom(tpi.DeclaringType))
                            skip = true; // skip type i
                        else
                            skips.Add(j); // skip type j
                        break;
                    }
                }
                if (skip)
                    continue;
                ret.Add(pi);
            }
            return ret;
        }

        private List<MethodInfo> GetMethods(Type type)
        {
            var methods = type.GetMethods(BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.Instance);
            List<MethodInfo> ret = new List<MethodInfo>(methods.Length);
            foreach (MethodInfo mi in methods)
            {
                if (mi.IsSpecialName || mi.IsGenericMethod || mi.IsGenericMethodDefinition)
                    continue;
                var browsable = AppUtils.GetAttribute<EditorBrowsableAttribute>(mi);
                if (browsable != null && browsable.State != EditorBrowsableState.Always)
                    continue;
                ret.Add(mi);
            }
            return ret;
        }

        /// <summary>
        /// Gets the type of the root object for .net code completion.
        /// The order of objects is copied from 
        /// protected override object ReportScriptContext.InternalGetObjectByName(string name)
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        private Type GetRootObjectType(string token, bool isFuncCall, bool isDataOnly)
        {
            const string c_objReport = "report";
            const string c_objDataSources = "datasources";
#if skip_dima
            const string c_objPage = "page";
            const string c_objPages = "pages";
            const string c_objGroupPage = "grouppage";
            const string c_objGroupPages = "grouppages";
#endif

            var context = this.CurrentScriptItem.Context;

            if (string.Compare(token, c_objReport, true) == 0)
                return typeof(C1FlexReport);

            if (string.Compare(token, c_objDataSources, true) == 0)
                return isFuncCall ? typeof(DataSource) : typeof(DataSourceCollection);
#if skip_dima
            else if (rootTokenLc == "parameters")
            {
                if (isFuncCall)
                {
                    type = typeof(ReportParameter);
                    isFuncCall = false;
                }
                else
                    type = typeof(ReportParameterCollection);
            }
            if (string.Compare(token, c_objPage, true) == 0)
                return new PageWrapper(Report.MasterReport);

            if (string.Compare(token, c_objPages, true) == 0)
                return new PagesWrapper(Report.MasterReport);

            if (string.Compare(token, c_objGroupPage, true) == 0)
                return new GroupPageWrapper(Report);

            if (string.Compare(token, c_objGroupPages, true) == 0)
                return new GroupPagesWrapper(Report);
#endif

            // look up database fields in the MainDataSource
            if (context.HasDataSourceInfo && context.DataSourceInfo.Fields.Any((fi_) => string.Compare(token, fi_.Name, true) == 0))
                return typeof(DataField);

            if (context.CalculatedFields != null && context.CalculatedFields.Any((fi_) => string.Compare(token, fi_.Name, true) == 0))
                return typeof(CalculatedField);

            if (!isDataOnly)
            {
                // look up report fields
                var fld = _report.Fields.FindByName(token);
                if (fld != null)
                    return fld.GetType();

                // look up report sections
                var sec = _report.Sections.FindByName(token);
                if (sec != null)
                    return sec.GetType();

                // look up report groups
                var grp = _report.Groups.FindByName(token);
                if (grp != null)
                    return grp.GetType();
            }

            // parameters
            var par = _report.Parameters.FindByName(token);
            if (par != null)
                return par.GetType();

            //
            return null;
        }


        private Type GetProperty(Type currentType, string propertyName)
        {
            try
            {
                return currentType.GetProperty(propertyName).PropertyType;
            }
            catch (AmbiguousMatchException)
            {
            }
            try
            {
                return currentType.GetProperty(propertyName, new Type[] { typeof(int) }).PropertyType;
            }
            catch
            {
                // this rather special case is for report.Parameters, which is defined both in report and doc source.
                // this whole mess needs rethinking...
                return currentType.GetProperty(propertyName, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public).PropertyType;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void ShowIntellisense(CodeCompleteContext context)
        {
            System.Diagnostics.Debug.Assert(_ccw == null);

            if (context == null || context.SyntaxItems == null || context.SyntaxItems.Count == 0)
                return;

            // Position the completions popup below or above the insertion point:
            const int PopupWidth = 300;
            Point p = this._txtScript.GetPositionFromCharIndex(context.WordPosition);
            p = _txtScript.PointToScreen(p);
            var s = Screen.FromPoint(p);
            int lineHeight;
            using (var g = this.CreateGraphics())
                lineHeight = (int)g.MeasureString("I", _txtScript.SelectionFont).Height;
            int PopupHeight = lineHeight * 9 + 2;
            // Create, position and show the popup:
            _ccw = new CodeCompleteWindow(this, context);
            _ccw.Font = _txtScript.Font;
            // Tooltip to be used by the codecomplete window:
            _ccw.ToolTip = _tooltip;
            if (s.Bounds.Contains(p.X, p.Y + lineHeight + PopupHeight))
                _ccw.Bounds = new Rectangle(p.X, p.Y + lineHeight, PopupWidth, PopupHeight);
            else
                _ccw.Bounds = new Rectangle(p.X, p.Y - PopupHeight, PopupWidth, PopupHeight);
            _ccw.Show();
            _ccw.UpdateCurrentPosition();
        }
    }
}
