//----------------------------------------------------------------------------
// ScriptEditorFormEx.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;

using C1.Win.FlexReport;
using C1.Win.FlexReport.FlexDesigner;
using C1.Win.Command;
using C1.Win.Localization;
using C1.Win.Ribbon;
using C1.Win.Themes;
using FlexReportDesignerApp.Util;

namespace FlexReportDesignerApp.Forms
{
    public partial class ScriptEditorFormEx : C1.Win.Ribbon.C1RibbonForm
    {
        private bool _scriptWritten = false; // if true, we must return OK.
        private MainForm _mainForm = null;
        private C1FlexReport _report; // report that owns the script
        private EditorScriptContextCollection _contexts = null;
        private EditorScriptItemCollection _scriptItems = null;
        // the key for the string that we were called for:
        private string _scriptItemKey = null;
        private const int c_minFontSize = 6;
        private const int c_maxFontSize = 24;
        // Currently active editor:
        private ScriptEditorControl _activeScriptEditor = null;
        // Splitter-related vars:
        const int c_SnapSplitterDistance = 30;
        const int c_StartSplitterDistance = 5;
        bool _splitterMoving = false;
        int _splitterStartY = 0;

        #region Constructors
        public ScriptEditorFormEx()
        {
            // initialize components
            InitializeComponent();

        }

        public ScriptEditorFormEx(
            MainForm mainForm,
            C1FlexReport report,
            string scriptContextName,
            // either this:
            ITypeDescriptorContext typeDescriptorContext,
            // or these two:
            object propertyOwner,
            string propertyName,
            // if non-null, used instead of derived name for display ONLY (does not affect script item key)
            string displayName,
            //
            bool isScript)
            : this()
        {
            System.Diagnostics.Debug.Assert(typeDescriptorContext != null || (propertyOwner != null && !string.IsNullOrEmpty(propertyName)));

            AutoScaleMode = AutoScaleMode.None;
            Font = MainForm.DefaultAppFont;
            _mainForm = mainForm;
            _report = report;
            _contexts = new EditorScriptContextCollection(this, report, _mainForm.FlexDesigner);
            _activeScriptEditor = _scriptEditor0;
            //
            rbnMain.BeginUpdate();
            //
            _scriptEditor1.TextBox.Font = _scriptEditor0.TextBox.Font = _mainForm._scriptEditorFont;
            _scriptEditor1.EditorBackgroundColor = _scriptEditor0.EditorBackgroundColor = _mainForm._scriptEditorBackColor;
            _scriptEditor1.EditorTextColor = _scriptEditor0.EditorTextColor = _mainForm._scriptEditorForeColor;
            _scriptEditor1.SyntaxAutoCheck = _scriptEditor0.SyntaxAutoCheck = _mainForm._syntaxCheck;
            _scriptEditor1.AutoSaveCurrentScript = _scriptEditor0.AutoSaveCurrentScript = _mainForm._scriptEditorAutoSave;
            // init options in ribbon UI:
            rbEditorFontName.Text = _mainForm._scriptEditorFont.Name;
            rbBackgroundColor.Color = _mainForm._scriptEditorBackColor;
            rbTextColor.Color = _mainForm._scriptEditorForeColor;
            rbSyntaxHighlight.Checked = _mainForm._syntaxColoring;
            rbSyntaxAutoCheck.Checked = _mainForm._syntaxCheck;
            rbAutoSave.Checked = _mainForm._scriptEditorAutoSave;
            rbDataSourceFilterWarning.Checked = _mainForm._scriptEditorDataSourceFilterWarning;
            // font size:
            for (int i = c_minFontSize; i <= c_maxFontSize; ++i)
                rbFontSize.Items.Add(i.ToString());
            rbFontSize.Text = ((int)Math.Round(_scriptEditor0.EditorFont.Size)).ToString();

            _scriptEditor0.TextBox.GotFocus += ScriptEditorGotFocus;
            _scriptEditor0.CurrentScriptItemChanged += CurrentScriptItemChanged;
            _scriptEditor0.CurrentScriptTextChanged += CurrentScriptTextChanged;
            _scriptEditor0.ScriptWritten += ScriptWritten;
            _scriptEditor0.TextSelectionChanged += TextSelectionChanged;
            _scriptEditor0.SyntaxCheckNeeded += SyntaxCheckNeeded;

            _scriptEditor1.TextBox.GotFocus += ScriptEditorGotFocus;
            _scriptEditor1.CurrentScriptItemChanged += CurrentScriptItemChanged;
            _scriptEditor1.CurrentScriptTextChanged += CurrentScriptTextChanged;
            _scriptEditor1.ScriptWritten += ScriptWritten;
            _scriptEditor1.TextSelectionChanged += TextSelectionChanged;
            _scriptEditor1.SyntaxCheckNeeded += SyntaxCheckNeeded;

            _scriptItems = new EditorScriptItemCollection(_report, _contexts, _mainForm.FlexDesigner);

            // initial mode we start with:
            bool splitWindowMode = _mainForm._scriptEditorSplitWindowDistance > 0;

            // script data context:
            EditorScriptContextBase context = _contexts.GetContext(scriptContextName);
            System.Diagnostics.Debug.Assert(context != null);

            // this is patchy but will do for now:
            // - if we are being called from prop grid, then we have EditContext and edit that;
            // - else, if we are called to edit an expression - this is creating a new field;
            // - else, the big "Edit Scripts" button was pressed, and we default to GlobalScripts.

            EditorScriptItem scriptItem;
            if (typeDescriptorContext != null)
                scriptItem = EditorScriptItem.FromTypeDescriptorContext(typeDescriptorContext, context, isScript, displayName);
            else
                scriptItem = EditorScriptItem.FromObjectProperty(propertyOwner, propertyName, context, isScript, displayName);

            // A script item may not be "collected" if it is a new calc field being added, or e.g. in Maps there are many expressions:
            if (!_scriptItems.ContainsKey(scriptItem.Key))
            {
                scriptItem.EnsureTopKey();
                _scriptItems.Add(scriptItem.Key, scriptItem);
            }

            _scriptEditor0.Init(mainForm, _report, _scriptItems);
            _scriptEditor1.Init(mainForm, _report, _scriptItems);

            // _scriptItemKey is used ONLY for returning the script with which we were called:
            _scriptItemKey = scriptItem.Key;
            if (splitWindowMode)
            {
                _scriptEditor1.SetCurrentScriptItem(_scriptItemKey, Forms.ScriptEditorControl.SetCurrentScriptItemContext.Initial);
                if (_scriptItems.ContainsKey(_mainForm._scriptEditorLastItemKey0))
                    _scriptEditor0.SetCurrentScriptItem(_mainForm._scriptEditorLastItemKey0, Forms.ScriptEditorControl.SetCurrentScriptItemContext.Initial);
                else
                    _scriptEditor0.SetCurrentScriptItem(_scriptItemKey, Forms.ScriptEditorControl.SetCurrentScriptItemContext.Initial);
            }
            else
            {
                _scriptEditor0.SetCurrentScriptItem(_scriptItemKey, Forms.ScriptEditorControl.SetCurrentScriptItemContext.Initial);
                _scriptEditor1.SetCurrentScriptItem(_scriptItemKey, Forms.ScriptEditorControl.SetCurrentScriptItemContext.Initial);
            }

            // Apply main window's theme:
            var tl = new C1ThemeLocator(_mainForm.Theme);
            var theme = tl.GetTheme();
            if (theme != null)
            {
                C1ThemeController.ApplyThemeToControlTree(this, theme);
                C1ThemeController.ApplyThemeToObject(contextMenu, theme);
            }

            // Set up script editors' glyphs - splitter and close window:
            _scriptEditor0.GlyphBox.Cursor = Cursors.HSplit;
            _scriptEditor1.GlyphBox.Image = Properties.Resources.SplitWindowClose_16x16;

            _splitter.SplitterMoved += Splitter_SplitterMoved;
            _scriptEditor0.GlyphBox.MouseEnter += GlyphBox0_MouseEnter;
            _scriptEditor0.GlyphBox.MouseLeave += GlyphBox0_MouseLeave;
            _scriptEditor0.GlyphBox.MouseDown += GlyphBox0_MouseDown;
            _scriptEditor0.GlyphBox.MouseMove += GlyphBox0_MouseMove;
            _scriptEditor0.GlyphBox.MouseUp += GlyphBox0_MouseUp;
            _scriptEditor0.GlyphBox.MouseCaptureChanged += GlyphBox0_MouseCaptureChanged;
            _scriptEditor1.GlyphBox.MouseDown += GlyphBox1_MouseDown;

            // Ready to start:
            UpdateStatusBar();
            //
            rbnMain.EndUpdate();
            //
        }
        #endregion

        #region Publics
        /// <summary>
        /// Gets the saved value for the script item for which the editor was initially shown.
        /// Note that the editor itself saves items. This value is only useful as a return value
        /// for the UITypeEditor's EditValue so that it knows that the value has changed.
        /// </summary>
        /// <returns></returns>
        public object GetValue()
        {
            return _scriptItems[_scriptItemKey].Value;
        }
        #endregion

        #region Split window mode support
        /*
         * Split window mode notes:
         * - we provide two editors - #0 & #1, 0 is the "main" one, #1 is initially hidden "behind" #0.
         * - to enter split mode, user pulls the splitter in #0's top left corner, down (like in VS2013).
         * - current state is saved on exit, to be restored on load.
         * - in split mode, if there's a script we are called with is loaded into #1, otherwise last script loaded into #1 is loaded.
         * - in split mode, the other window is loaded with last loaded script.
         */
        private bool IsSplitWindowMode
        {
            get { return !_splitter.Panel1Collapsed; }
        }

        private void SetSplitWindowMode(bool show, int splitterDistance, bool force)
        {
            if (force || show != IsSplitWindowMode)
            {
                _splitter.Panel1Collapsed = !show;
                _splitter.SplitterDistance = show ? splitterDistance : 0;
                if (!show)
                    SetActiveScriptEditor(true);
            }
        }

        private void SetSplitterMoving(bool start)
        {
            _splitterMoving = start;
            if (_scriptEditor0.GlyphBox.Capture != start)
                _scriptEditor0.GlyphBox.Capture = start;
        }

        private void SplitOffIfNeeded()
        {
            if (_splitter.SplitterDistance < c_SnapSplitterDistance)
            {
                SetSplitterMoving(false);
                SetSplitWindowMode(false, 0, false);
            }
        }

        private void Splitter_SplitterMoved(object sender, SplitterEventArgs e)
        {
            if (Control.MouseButtons == System.Windows.Forms.MouseButtons.None)
                SplitOffIfNeeded();
        }

        private void GlyphBox0_MouseEnter(object sender, EventArgs e)
        {
        }

        private void GlyphBox0_MouseLeave(object sender, EventArgs e)
        {
        }

        private void GlyphBox0_MouseDown(object sender, MouseEventArgs e)
        {
            SetSplitterMoving(true);
            SetSplitWindowMode(true, c_StartSplitterDistance, false);
            _splitterStartY = e.Y;
        }

        private void GlyphBox0_MouseMove(object sender, MouseEventArgs e)
        {
            if (_splitterMoving)
            {
                int newDistance = _splitter.SplitterDistance + e.Y - _splitterStartY;
                try
                {
                    _splitter.SplitterDistance = newDistance;
                }
                catch
                { }
            }
        }

        private void GlyphBox0_MouseUp(object sender, MouseEventArgs e)
        {
            SplitOffIfNeeded();
        }

        private void GlyphBox0_MouseCaptureChanged(object sender, EventArgs e)
        {
            SetSplitterMoving(false);
        }

        private void GlyphBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // close top window:
            var key = _scriptEditor0.CurrentScriptItem == null ? null : _scriptEditor0.CurrentScriptItem.Key;
            if (_scriptEditor1.SetCurrentScriptItem(key, Forms.ScriptEditorControl.SetCurrentScriptItemContext.CancelWindow))
                SetSplitWindowMode(false, 0, false);
        }
        #endregion

        #region Overrides
        protected override void OnClosing(CancelEventArgs e)
        {
            string key0 = _scriptEditor0.CurrentScriptItem == null ? string.Empty : _scriptEditor0.CurrentScriptItem.Key;
            string key1 = _scriptEditor1.CurrentScriptItem == null ? string.Empty : _scriptEditor1.CurrentScriptItem.Key;

            // TBD: add the script's name to the message about script not being saved:
            if (!_scriptEditor0.SetCurrentScriptItem(null, Forms.ScriptEditorControl.SetCurrentScriptItemContext.CancelWindow))
                e.Cancel = true;
            else if (key0 != key1 && !_scriptEditor1.SetCurrentScriptItem(null, Forms.ScriptEditorControl.SetCurrentScriptItemContext.CancelWindow))
                e.Cancel = true;
            else
            {
#if skip_dima
                if (_scriptWritten)
                    DialogResult = System.Windows.Forms.DialogResult.OK;
#else
                this.DialogResult = _scriptWritten ? DialogResult.OK : DialogResult.Cancel;
#endif
                //
                AppSettings.SaveObject("ScriptEditorForm", new FormState(this));
                _mainForm._scriptEditorSplitWindowDistance = IsSplitWindowMode ? _splitter.SplitterDistance : 0;
                _mainForm._scriptEditorLastItemKey0 = key0;
                _mainForm._scriptEditorLastItemKey1 = key1;
                _mainForm._appConfig.SaveAppState();
            }
            //
            base.OnClosing(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //
            rbnMain.BeginUpdate();
            //
            InitCommands();
            //
            // We need to do it here because it uses Invoke which needs the window handle to work:
            _contexts.Init();
            //
            AppSettings.LoadObject("ScriptEditorForm", new FormState(this));
            if (_mainForm._scriptEditorSplitWindowDistance > c_StartSplitterDistance)
                SetSplitWindowMode(true, _mainForm._scriptEditorSplitWindowDistance, true);
            else
                SetSplitWindowMode(false, 0, true);
            //
            rbnMain.EndUpdate();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (!IsSplitWindowMode)
                _scriptEditor0.TextBox.Focus();
            else
                _scriptEditor1.TextBox.Focus();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            AutoSizeMessage();
        }
        #endregion

        #region Private
        private void ScriptEditorGotFocus(object source, EventArgs e)
        {
            SetActiveScriptEditor(!_scriptEditor1.TextBox.Focused);
        }

        /// <summary>
        /// Sets the active script editor (#0 or #1).
        /// (In split window mode, #0 is the bottom one, #1 is the top one; in single window mode, #0 only is shown.)
        /// </summary>
        /// <param name="main">If true, sets editor #0 as the active one, otherwise sets #1.</param>
        private void SetActiveScriptEditor(bool main)
        {
            if (main || !_scriptEditor1.Visible)
            {
                if (_activeScriptEditor == _scriptEditor0)
                    return;
                _activeScriptEditor = _scriptEditor0;
                _scriptEditor1.IsSelectedEditor = false;
            }
            else
            {
                if (_activeScriptEditor == _scriptEditor1)
                    return;
                _activeScriptEditor = _scriptEditor1;
                _scriptEditor0.IsSelectedEditor = false;
            }
            rbnMain.BeginUpdate();
            //
            _activeScriptEditor.IsSelectedEditor = true;
            _activeScriptEditor.TextBox.Focus();
            CurrentScriptItemChanged(_activeScriptEditor, EventArgs.Empty);
            //
            rbnMain.EndUpdate();
        }

        private void CurrentScriptItemChanged(object source, EventArgs e)
        {
            rbnMain.BeginUpdate();
            //
            var si = _activeScriptEditor.CurrentScriptItem;
            //
            SetFormCaption(si);
            //
            UpdateInsertUI();
            // Special help note for DataSource.Filter:
            if (si != null && si.Context.ContextKind == ScriptEditorContextKind.DataView)
            {
                _slNote.Visible = _mainForm._scriptEditorDataSourceFilterWarning;
                AutoSizeMessage();
            }
            else
                _slNote.Visible = false;
            //
            bool dummy = false;
            bool canSyntaxCheck = si != null && si.CanSyntaxCheck(out dummy);
            rbSyntaxAutoCheck.Enabled = canSyntaxCheck;

            rbSyntaxHighlight.Enabled = si != null && !si.IsTextMode;
            SetEditorSyntaxHighlighting(si != null && !si.IsTextMode && _mainForm._syntaxColoring);

            // re-check syntax if needed:
            CheckSyntax();
            //
            UpdateStatusBar();
            //
            rbnMain.EndUpdate();
        }

        private bool _inCurrentScriptTextChanged = false;
        private void CurrentScriptTextChanged(object source, EventArgs e)
        {
            if (_inCurrentScriptTextChanged)
                return;
            _inCurrentScriptTextChanged = true;

            SetFormCaption(_activeScriptEditor.CurrentScriptItem);
            // Moved to SyntaxCheckNeeded - check syntax only when there is no intellisense popup:
            // CheckSyntax();

            if (_activeScriptEditor == source)
            {
                var inactiveEditor = _activeScriptEditor == _scriptEditor0 ? _scriptEditor1 : _scriptEditor0;
                if (_activeScriptEditor.CurrentScriptItem.Key == inactiveEditor.CurrentScriptItem.Key)
                    inactiveEditor.TextBox.Text = _activeScriptEditor.TextBox.Text;
            }
            _inCurrentScriptTextChanged = false;
        }

        private void ScriptWritten(object source, EventArgs e)
        {
            _scriptWritten = true;
            string key0 = _scriptEditor0.CurrentScriptItem == null ? string.Empty : _scriptEditor0.CurrentScriptItem.Key;
            string key1 = _scriptEditor1.CurrentScriptItem == null ? string.Empty : _scriptEditor1.CurrentScriptItem.Key;
            if (key0 == key1)
            {
                // reset 'dirty' flag in another editor if it is editing the same item:
                if (source == _scriptEditor0)
                    _scriptEditor1.IsCurrentScriptDirty = false;
                else
                    _scriptEditor0.IsCurrentScriptDirty = false;
            }
        }
        private void TextSelectionChanged(object source, EventArgs e)
        {
            UpdateStatusBar();
        }

        private void SyntaxCheckNeeded(object source, EventArgs e)
        {
            CheckSyntax();
        }

        private void SetFormCaption(EditorScriptItem si)
        {
            if (si == null || _activeScriptEditor == null)
                this.Text = Strings.ScriptEditorForm.CaptionEmpty;
            else
            {
                var star = _activeScriptEditor.IsCurrentScriptDirty ? '*' : ' ';
                this.Text = string.Format(Strings.ScriptEditorForm.CaptionVBScriptFmt, si.ToString(), star);
            }
        }

        private void SetEditorSyntaxHighlighting(bool value)
        {
            Action<ScriptEditorControl> setHiliting = (sec) =>
                {
                    if (value)
                    {
                        var si = sec.CurrentScriptItem;
                        if (si == null || si.IsTextMode)
                            sec.SyntaxHighlighting = ScriptEditorControl.SyntaxHighlightingType.None;
                        else if (si.Context.ContextKind == ScriptEditorContextKind.DataView)
                            sec.SyntaxHighlighting = ScriptEditorControl.SyntaxHighlightingType.DataFilter;
                        else
                            sec.SyntaxHighlighting = ScriptEditorControl.SyntaxHighlightingType.VBScript;
                    }
                    else
                        sec.SyntaxHighlighting = ScriptEditorControl.SyntaxHighlightingType.None;
                };
            setHiliting(_scriptEditor0);
            setHiliting(_scriptEditor1);
        }

        private void CheckSyntax()
        {
            if (_activeScriptEditor == null)
                return;

            string error;
            // Note: editor.CheckSyntax only does anything if SyntaxAutoCheck and it can:
            if (!_activeScriptEditor.CheckSyntax(out error))
            {
                rblText.Text = error;
                rbtnError.ToolTip = error;
                rbtnError.Visible = true;
                ribbonSeparator1.Visible = true;
            }
            else
            {
                rbtnError.Visible = false;
                rblText.Text = string.Empty;
                ribbonSeparator1.Visible = false;
            }
        }

        private void UpdateInsertUI()
        {
            // C1Report:
            UpdateInsertUIReportParams();
            UpdateInsertUIDbFields();
            UpdateInsertUIReportFields();
            UpdateInsertUIReportGlobals();
            UpdateInsertUIReportMore();
            // VBScript:
            // todo: this code runs on each script item change, but the actual content of vbs stuff does not change with context,
            // it can only be disabled at the menu level.
            UpdateInsertUIVBScriptFunctions();
            UpdateInsertUIVBScriptProgram();
        }

        private void _clearMenus(RibbonMenu rMenu, C1CommandMenu cMenu)
        {
            rMenu.Items.Clear();
            cMenu.CommandLinks.Clear();
            rMenu.Enabled = cMenu.Enabled = false;
        }

        private void _addMenus(RibbonMenu rMenu, C1CommandMenu cMenu, string[] texts)
        {
            if (texts == null || texts.Length == 0)
            {
                rMenu.Enabled = rMenu.Items.Count > 0;
                cMenu.Enabled = cMenu.CommandLinks.Count > 0;
            }
            else
            {
                rMenu.Enabled = cMenu.Enabled = true;
                foreach (string text in texts)
                {
                    AddRibbonInsertTextButton(rMenu, text);
                    AddCommandMenuItem(cMenu, text);
                }
            }
        }

        private void _addMenus(RibbonMenu rMenu, C1CommandMenu cMenu, string texts)
        {
            _addMenus(rMenu, cMenu, texts != null ? texts.Split('|') : null);
        }

        private void _clearSubMenus(RibbonMenu rParent, C1CommandMenu cParent)
        {
            foreach (RibbonMenu rmnu in rParent.Items)
                rmnu.Items.Clear();
            foreach (C1CommandLink cl in cParent.CommandLinks)
                ((C1CommandMenu)cl.Command).CommandLinks.ClearAll();
            _clearMenus(rParent, cParent);
        }

        private void _addSubMenus(RibbonMenu rParent, C1CommandMenu cParent, string menuName, string[] texts)
        {
            rParent.Enabled = cParent.Enabled = true;
            RibbonMenu rMenu = new RibbonMenu();
            rMenu.Text = menuName;
            C1CommandMenu cMenu = new C1CommandMenu();
            cMenu.Text = menuName;
            chMain.Commands.Add(cMenu);
            _addMenus(rMenu, cMenu, texts);
            rParent.Items.Add(rMenu);
            cParent.CommandLinks.Add(new C1CommandLink(cMenu));
        }

        private void _addSubMenus(RibbonMenu rParent, C1CommandMenu cParent, string menuName, string texts)
        {
            _addSubMenus(rParent, cParent, menuName, texts != null ? texts.Split('|') : null);
        }

        /// <summary>
        /// Tag indicating that the menu item click should insert its text.
        /// </summary>
        private static object s_rbnInsertTextTag = new object();
        private void AddRibbonInsertTextButton(RibbonMenu menu, string text)
        {
            var btn = new RibbonButton(text);
            btn.Tag = s_rbnInsertTextTag;
            menu.Items.Add(btn);
        }

        private void AddCommandMenuItem(C1CommandMenu menu, string text)
        {
            C1Command c = new C1Command();
            c.Text = text;
            c.UserData = s_rbnInsertTextTag;
            chMain.Commands.Add(c);
            menu.CommandLinks.Add(new C1CommandLink(c));
        }

        private void _insertTemplate(ScriptEditorControl sec, string text)
        {
            if (sec != null)
            {
                sec.InsertTemplate(text);
                sec.TextBox.Focus();
            }
        }

        private void UpdateInsertUIReportFields()
        {
            _clearMenus(rmnuReportFields, cmnuReportFields);

            if (_activeScriptEditor == null)
                return;
            var item = _activeScriptEditor.CurrentScriptItem;
            if (item == null || item.IsTextMode)
                return;
            if (item.Context.ContextKind != ScriptEditorContextKind.ReportScript)
                return;

            string[] names = new string[_report.Fields.Count];
            for (int i = 0; i < _report.Fields.Count; ++i)
                names[i] = _report.Fields[i].Name;
            _addMenus(rmnuReportFields, cmnuReportFields, names);
        }

        public void DataSourceInfoFetched(string dataSourceName)
        {
            UpdateInsertUIDbFields();
        }

        private void UpdateInsertUIDbFields()
        {
            // Clear and disable everything:
            _clearMenus(rmnuDataFields, cmnuDataFields);
            _clearMenus(rmnuCalculatedFields, cmnuCalculatedFields);

            if (_activeScriptEditor == null)
                return;
            var item = _activeScriptEditor.CurrentScriptItem;
            if (item == null || item.IsTextMode)
                return;

            var context = item.Context;
            lock (_report)
            {
                if (context.HasDataSourceInfo)
                {
                    _addMenus(rmnuDataFields, cmnuDataFields, context.DataSourceInfo.Fields.Select((f_) => f_.Name).ToArray());
                    _addMenus(rmnuCalculatedFields, cmnuCalculatedFields, context.CalculatedFields.Select((f_) => f_.Name).ToArray());
                }
            }

            // refresh syntax coloring
            _activeScriptEditor.InitSyntaxDbFields(context);
        }

        private void UpdateInsertUIReportParams()
        {
            // Clear and disable everything:
            _clearMenus(rmnuReportParams, cmnuReportParams);

            if (_activeScriptEditor == null)
                return;
            var item = _activeScriptEditor.CurrentScriptItem;
            if (item == null || item.IsTextMode)
                return;
            if (item.Context.ContextKind == ScriptEditorContextKind.DataView)
                return;

            _addMenus(rmnuReportParams, cmnuReportParams, _report.Parameters.Select((p_) => p_.Name).ToArray());
        }

        private void UpdateInsertUIReportGlobals()
        {
            _clearMenus(rmnuReportGlobals, cmnuReportGlobals);
            if (_activeScriptEditor == null)
                return;
            var item = _activeScriptEditor.CurrentScriptItem;
            if (item == null || item.IsTextMode)
                return;
            var contextKind = item.Context.ContextKind;
            if (contextKind == ScriptEditorContextKind.DataView || contextKind == ScriptEditorContextKind.MetaView)
                return;

            _report.ParseGlobalScript();
            _addMenus(rmnuReportGlobals, cmnuReportGlobals, _report.GetGlobalFunctions());
            _addMenus(rmnuReportGlobals, cmnuReportGlobals, _report.GetGlobalSubs());
        }

        private void UpdateInsertUIReportMore()
        {
            _clearSubMenus(rmnuReportMore, cmnuReportMore);

            if (_activeScriptEditor == null)
                return;
            var item = _activeScriptEditor.CurrentScriptItem;
            if (item == null || item.IsTextMode)
                return;
#if skip_dima
            if (item.Context.ContextKind != ScriptEditorContextKind.ReportScript)
                return;
#else
            bool isReportScript;
            switch (item.Context.ContextKind)
            {
                case ScriptEditorContextKind.ReportScript:
                    isReportScript = true;
                    break;
                case ScriptEditorContextKind.DataHandler:
                    isReportScript = false;
                    break;
                default:
                    return;
            }
#endif
            if (isReportScript)
            {
                // Groups:
                _addSubMenus(rmnuReportMore, cmnuReportMore, Strings.ScriptEditorForm.MnuReportGroups, _report.Groups.Where((g__) => !string.IsNullOrEmpty(g__.Name)).Select((g_) => g_.Name).ToArray());
                // Sections:
                _addSubMenus(rmnuReportMore, cmnuReportMore, Strings.ScriptEditorForm.MnuReportSections, _report.Sections.Select((s_) => s_.Name).ToArray());
                // Report variables:
                _addSubMenus(rmnuReportMore, cmnuReportMore, Strings.ScriptEditorForm.MnuReportVariables, ScriptSyntaxC1Report.Keywords.Prototypes);
                // Aggregates:
                _addSubMenus(rmnuReportMore, cmnuReportMore, Strings.ScriptEditorForm.MnuAggregateFunctions, ScriptSyntaxC1Report.Aggregates.Prototypes);
                // Built-in functions:
                _addSubMenus(rmnuReportMore, cmnuReportMore, Strings.ScriptEditorForm.MnuBuiltinFunctions, ScriptSyntaxC1Report.Functions.Prototypes);
            }
            else
            {
                // Data handler contexts still allow aggregates, but nothing else (some built-in functions can be used, but for now they are bundled with those that cannot):
                // Groups:
                _addSubMenus(rmnuReportMore, cmnuReportMore, Strings.ScriptEditorForm.MnuReportGroups, (string[])null);
                // Sections:
                _addSubMenus(rmnuReportMore, cmnuReportMore, Strings.ScriptEditorForm.MnuReportSections, (string[])null);
                // Report variables:
                _addSubMenus(rmnuReportMore, cmnuReportMore, Strings.ScriptEditorForm.MnuReportVariables, (string[])null);
                // Aggregates:
                _addSubMenus(rmnuReportMore, cmnuReportMore, Strings.ScriptEditorForm.MnuAggregateFunctions, ScriptSyntaxC1Report.Aggregates.Prototypes);
                // Built-in functions:
                _addSubMenus(rmnuReportMore, cmnuReportMore, Strings.ScriptEditorForm.MnuBuiltinFunctions, (string[])null);
            }
        }

        private void UpdateInsertUIVBScriptFunctions()
        {
            _clearSubMenus(rmnuVBScriptFunctions, cmnuVBScriptFunc);

            if (_activeScriptEditor == null)
                return;
            var item = _activeScriptEditor.CurrentScriptItem;
            if (item == null || item.IsTextMode)
                return;
            if (item.Context.ContextKind == ScriptEditorContextKind.DataView)
                return;

            // String:
            _addSubMenus(rmnuVBScriptFunctions, cmnuVBScriptFunc, Strings.ScriptEditorForm.MnuStringFunctions, ScriptSyntaxVBScript.StringFunctions.Prototypes);
            // Data conversion:
            _addSubMenus(rmnuVBScriptFunctions, cmnuVBScriptFunc, Strings.ScriptEditorForm.MnuDataConversion, ScriptSyntaxVBScript.ConversionFunctions.Prototypes);
            // Math:
            _addSubMenus(rmnuVBScriptFunctions, cmnuVBScriptFunc, Strings.ScriptEditorForm.MnuMathFunctions, ScriptSyntaxVBScript.MathFunctions.Prototypes);
            // Date/time:
            _addSubMenus(rmnuVBScriptFunctions, cmnuVBScriptFunc, Strings.ScriptEditorForm.MnuDateTimeFunctions, ScriptSyntaxVBScript.DateTimeFunctions.Prototypes);
        }

        private void UpdateInsertUIVBScriptProgram()
        {
            _clearSubMenus(rmnuVBScriptProgram, cmnuVBScriptProg);

            if (_activeScriptEditor == null)
                return;
            var item = _activeScriptEditor.CurrentScriptItem;
            if (item == null || item.IsTextMode)
                return;
            if (item.Context.ContextKind == ScriptEditorContextKind.DataView)
                return;

            // Program Logic:
            _addSubMenus(rmnuVBScriptProgram, cmnuVBScriptProg, Strings.ScriptEditorForm.MnuProgramLogic, ScriptSyntaxVBScript.Logic.Prototypes);
            /* todo: maybe add those as well?
				// statement keywords
				AddKeyword(new Token("If",				TKID.IF,				TKTYPE.STATEMENT));
				AddKeyword(new Token("Then",			TKID.THEN,				TKTYPE.STATEMENT));
				AddKeyword(new Token("Else",			TKID.ELSE,				TKTYPE.STATEMENT));
				AddKeyword(new Token("ElseIf",			TKID.ELSEIF,			TKTYPE.STATEMENT));
				AddKeyword(new Token("Endif",			TKID.ENDIF,				TKTYPE.STATEMENT));
				AddKeyword(new Token("For",				TKID.FOR,				TKTYPE.STATEMENT));
				AddKeyword(new Token("To",				TKID.TO,				TKTYPE.STATEMENT));
				AddKeyword(new Token("Next",			TKID.NEXT,				TKTYPE.STATEMENT));
				AddKeyword(new Token("Step",			TKID.STEP,				TKTYPE.STATEMENT));
				AddKeyword(new Token("While",			TKID.WHILE,				TKTYPE.STATEMENT));
				AddKeyword(new Token("Wend",			TKID.WEND,				TKTYPE.STATEMENT));
				AddKeyword(new Token("Const",			TKID.CONST,				TKTYPE.STATEMENT));
				AddKeyword(new Token("Dim",				TKID.DIM,				TKTYPE.STATEMENT));
				AddKeyword(new Token("Redim",			TKID.REDIM,				TKTYPE.STATEMENT));
             */
            // Constants:
            _addSubMenus(rmnuVBScriptProgram, cmnuVBScriptProg, Strings.ScriptEditorForm.MnuConstants, ScriptSyntaxVBScript.Constants.Prototypes);
            // Misc:
            List<string> miscProtos = new List<string>();
            miscProtos.AddRange(ScriptSyntaxVBScript.MiscFunctions.Prototypes);
            miscProtos.AddRange(new string[] { "Mod", "Nothing", "Null" });
            _addSubMenus(rmnuVBScriptProgram, cmnuVBScriptProg, Strings.ScriptEditorForm.MnuMiscellaneous, miscProtos.ToArray());
            // Global Script:
            _addSubMenus(rmnuVBScriptProgram, cmnuVBScriptProg, Strings.ScriptEditorForm.MnuFunctionsAndSubs, ScriptSyntaxVBScript.Program.Prototypes);
        }

        private void UpdateStatusBar()
        {
            if (_activeScriptEditor == null)
            {
                rlblCol.Text = string.Empty;
                rlblRow.Text = string.Empty;
            }
            else
            {
                int line;
                int column;
                _activeScriptEditor.GetCurrentLineCol(out line, out column);
                rlblCol.Text = string.Format(Strings.ScriptEditorForm.ColumnFmt, column + 1);
                rlblRow.Text = string.Format(Strings.ScriptEditorForm.LineFmt, line + 1);
            }
        }
        #endregion

        #region Privates
        private void InitCommands()
        {
            cPaste.CommandStateQuery += (ss, ee) =>
                {
                    try { ee.Enabled = !string.IsNullOrEmpty(Clipboard.GetText()); }
                    catch { }
                };
            cCut.CommandStateQuery += (ss, ee) => ee.Enabled = _activeScriptEditor.TextBox.SelectionLength > 0;
            cCopy.CommandStateQuery += (ss, ee) => ee.Enabled = _activeScriptEditor.TextBox.SelectionLength > 0;
            cDelete.CommandStateQuery += (ss, ee) => ee.Enabled = _activeScriptEditor.TextBox.SelectionLength > 0;
            cUndo.CommandStateQuery += (ss, ee) => ee.Enabled = _activeScriptEditor.TextBox.CanUndo;
            cRedo.CommandStateQuery += (ss, ee) => ee.Enabled = _activeScriptEditor.TextBox.CanRedo;
            cSelectAll.CommandStateQuery += (ss, ee) => ee.Enabled = _activeScriptEditor.TextBox.Text.Length > 0;
            cHistBack.CommandStateQuery += (ss, ee) => ee.Enabled = _activeScriptEditor.HistoryCanGoBack;
            cHistForward.CommandStateQuery += (ss, ee) => ee.Enabled = _activeScriptEditor.HistoryCanGoForward;
            cSwitchWindow.CommandStateQuery += (ss, ee) => ee.Enabled = _scriptEditor1.Visible;
        }

        private void rbnMain_RibbonEvent(object sender, RibbonEventArgs e)
        {
            bool saveAppState = false;
            if (e.EventType == RibbonEventType.Click)
            {
                var button = e.Item as RibbonButton;
                if (button != null && button.Tag == s_rbnInsertTextTag)
                    _insertTemplate(_activeScriptEditor, button.Text);
                // the rest is "options":
                else if (button == rbtnFontSizeUp)
                    UpdateEditorFont(new Font(_scriptEditor0.EditorFont.FontFamily, _scriptEditor0.EditorFont.Size + 1));
                else if (button == rbtnFontSizeDown)
                    UpdateEditorFont(new Font(_scriptEditor0.EditorFont.FontFamily, _scriptEditor0.EditorFont.Size - 1));
            }
            else if (e.EventType == RibbonEventType.CheckedChanged)
            {
                if (e.Item == (object)rbSyntaxHighlight)
                {
                    _mainForm._syntaxColoring = ((RibbonCheckBox)e.Item).Checked;
                    SetEditorSyntaxHighlighting(_mainForm._syntaxColoring);
                    saveAppState = true;
                }
                else if (e.Item == (object)rbSyntaxAutoCheck)
                {
                    _mainForm._syntaxCheck = _scriptEditor0.SyntaxAutoCheck = _scriptEditor1.SyntaxAutoCheck = ((RibbonCheckBox)e.Item).Checked;
                    saveAppState = true;
                }
                else if (e.Item == (object)rbAutoSave)
                {
                    _mainForm._scriptEditorAutoSave = _scriptEditor0.AutoSaveCurrentScript = _scriptEditor1.AutoSaveCurrentScript = ((RibbonCheckBox)e.Item).Checked;
                    saveAppState = true;
                }
                else if (e.Item == (object)rbDataSourceFilterWarning)
                {
                    _mainForm._scriptEditorDataSourceFilterWarning = ((RibbonCheckBox)e.Item).Checked;
                    saveAppState = true;
                    var si = _activeScriptEditor != null ? _activeScriptEditor.CurrentScriptItem : null;
                    if (si != null && si.Context.ContextKind == ScriptEditorContextKind.DataView)
                        _slNote.Visible = _mainForm._scriptEditorDataSourceFilterWarning;
                }
            }
            else if (e.EventType == RibbonEventType.ChangeCommitted)
            {
                if (e.Item == (object)rbEditorFontName)
                    UpdateEditorFont(new Font(((RibbonFontComboBox)e.Item).Text, _scriptEditor0.Font.Size));
                else if (e.Item == (object)rbFontSize)
                    UpdateEditorFont(new Font(_scriptEditor0.EditorFont.FontFamily, int.Parse(rbFontSize.Text)));
            }
            else if (e.EventType == RibbonEventType.SelectedColorChanged)
            {
                if (e.Item == (object)rbBackgroundColor)
                {
                    _mainForm._scriptEditorBackColor = _scriptEditor0.EditorBackgroundColor = _scriptEditor1.EditorBackgroundColor = ((RibbonColorPicker)e.Item).Color;
                    saveAppState = true;
                }
                else if (e.Item == (object)rbTextColor)
                {
                    _mainForm._scriptEditorForeColor = _scriptEditor0.EditorTextColor = _scriptEditor1.EditorTextColor = ((RibbonColorPicker)e.Item).Color;
                    saveAppState = true;
                }
            }
            //
            if (saveAppState)
                _mainForm._appConfig.SaveAppState();
        }

        private void UpdateEditorFont(Font font)
        {
            _scriptEditor0.EditorFont = _scriptEditor1.EditorFont = font;
            rbtnFontSizeDown.Enabled = font.Size > c_minFontSize;
            rbtnFontSizeUp.Enabled = font.Size < c_maxFontSize;
            rbEditorFontName.Text = font.Name;
            rbFontSize.Text = font.Size.ToString();

            _mainForm._scriptEditorFont = _scriptEditor0.EditorFont;
            _mainForm._appConfig.SaveAppState();
        }

        private void chMain_CommandClick(object sender, CommandClickEventArgs e)
        {
            if (e.Command == cOK)
            {
                _scriptEditor0.SetCurrentScriptItem(null, Forms.ScriptEditorControl.SetCurrentScriptItemContext.CloseWindow);
                _scriptEditor1.SetCurrentScriptItem(null, Forms.ScriptEditorControl.SetCurrentScriptItemContext.CloseWindow);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else if (e.Command == cCancel)
            {
                // todo - maybe show it anyway? _scriptEditor1.SetCurrentScriptItem(null, true);
                this.DialogResult = _scriptWritten ? DialogResult.OK : DialogResult.Cancel;
                this.Close();
            }
            else if (e.Command == cSwitchWindow)
            {
                SetActiveScriptEditor(_activeScriptEditor == _scriptEditor1);
                _activeScriptEditor.TextBox.Focus();
            }
            else if (e.Command == cHistBack)
                _activeScriptEditor.HistoryGoBack();
            else if (e.Command == cHistForward)
                _activeScriptEditor.HistoryGoForward();
            else if (e.Command == cUndo)
                _activeScriptEditor.TextBox.Undo();
            else if (e.Command == cRedo)
                _activeScriptEditor.TextBox.Redo();
            else if (e.Command == cCut)
                _activeScriptEditor.TextBox.Cut();
            else if (e.Command == cCopy)
                _activeScriptEditor.TextBox.Copy();
            else if (e.Command == cPaste || e.Command == cPasteAlt) // cPasteAlt is only to catch Shift+Ins in addition to Ctrl+V
            {
                // We do not want any formatting as it screws up syntax highlighting and generally can result in unreadable text:
                DataFormats.Format textFormat = DataFormats.GetFormat(DataFormats.Text);
                if (_activeScriptEditor.TextBox.CanPaste(textFormat))
                    _activeScriptEditor.TextBox.Paste(textFormat);
            }
            else if (e.Command == cDelete)
                _activeScriptEditor.TextBox.SelectedText = string.Empty;
            else if (e.Command == cSelectAll)
                _activeScriptEditor.TextBox.SelectAll();
            else
            {
                if (e.Command.UserData == s_rbnInsertTextTag)
                    _insertTemplate(_activeScriptEditor, e.Command.Text);
            }
        }

        private void rbEditorFontName_ShouldDrawFont(object sender, ShouldDrawFontEventArgs e)
        {
            using (Bitmap b = new Bitmap(1, 1))
            using (Graphics g = Graphics.FromImage(b))
            using (Font f = new Font(e.FontFamily, 10))
                e.ShouldDraw = IsFixedWidth(g, f);
        }

        private bool IsFixedWidth(Graphics g, Font ft)
        {
            char[] charSizes = new char[] { 'i', 'a', 'Z', '%', '#', 'a', 'B', 'l', 'm', ',', '.' };
            float charWidth = g.MeasureString("I", ft).Width;

            foreach (char c in charSizes)
                if (g.MeasureString(c.ToString(), ft).Width != charWidth)
                    return false;

            return true;
        }

        private void _slNote_LinkClicked(object sender, C1.Win.SuperTooltip.C1SuperLabelLinkClickedEventArgs e)
        {
            if (e.HRef == "hide_note")
            {
                _slNote.Visible = false;
                _mainForm._scriptEditorDataSourceFilterWarning = rbDataSourceFilterWarning.Checked = false;
                _mainForm._appConfig.SaveAppState();
            }
            else
                MainForm.OpenURL(e.HRef);
        }

        private void AutoSizeMessage()
        {
            // super label's own AutoSize does not seem to work when it is docked, hence this:
            Size s = _slNote.Measure(_slNote.Width);
            _slNote.Height = s.Height;
        }
        #endregion
    }
}
