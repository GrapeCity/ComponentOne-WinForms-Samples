using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Ribbon;
using C1.Win.C1SpellChecker;
using C1.Win.C1Editor;

using Resources = global::RichTextEditor.Properties.Resources;
using Settings = global::RichTextEditor.Properties.Settings;

namespace RichTextEditor
{
    /// <summary>
    /// Extends C1Ribbon to provide a Word-style ribbon for a text editor.
    /// </summary>
    [LicenseProvider(typeof(LicenseProvider))]
    public class C1TextEditorRibbon : C1.Win.C1Ribbon.C1Ribbon
    {
        //------------------------------------------------------------
        #region ** events

        public event EventHandler EditorTextChanged;

        #endregion

        //------------------------------------------------------------
        #region ** fields

        bool                _hasChanges;        // document has changes (needs to be saved)
        string              _fileName;          // current file name
        RecentDocumentList _mruOpened;            // recent document list
        RecentDocumentList _mruSaved;          // recent document list

        C1RibbonEditorXhtml _editor;            // editor
        Form                _parent;            // parent form (to update caption)
        bool                _dirtyUI;           // UI needs updating
        bool                _updatingUI;        // UI is being updated
        C1SpellChecker      _spellChecker;      // spell-checker
        private AppMenuTabs.PrintTab _printTab;

        #endregion

        //------------------------------------------------------------
        #region ** create/dispose

        // populate the ribbon
        public C1TextEditorRibbon()
        {
            // create spell checker
            _spellChecker = new C1SpellChecker();

            // configure tooltips
            this.ToolTipSettings.MaximumWidth = 240;
            //this.ToolTipSettings.Font = new Font("Calibri", 9);

            // initialize ribbon
            InitTabs();
            InitQat();
            InitApplicationMenu();

            // apply settings
            Settings settings = Settings.Default;
            Qat.BelowRibbon = settings.QatBelowRibbon;
            ShowErrors = settings.ShowErrors;
            Dictionary = settings.Dictionary;

            // update UI when app is idle
            Application.Idle += Application_Idle;
        }

        // update UI when selected tab changes
        protected override void OnTabIndexChanged(EventArgs e)
        {
            _dirtyUI = true;
        }

        // hook up parent form events
        protected override void OnParentChanged(EventArgs e)
        {
            // unhook previous if any
            if (_parent != null)
            {
                _parent.FormClosing -= _parent_FormClosing;
            }

            // hook new if any
            _parent = TopLevelControl as Form;
            if (_parent != null)
            {
                _parent.FormClosing += _parent_FormClosing;
            }

            // fire event as usual
            base.OnParentChanged(e);
        }

        // update UI when app is idle
        void Application_Idle(object sender, EventArgs e)
        {
            if (_dirtyUI)
            {
                UpdateUI();
            }
        }

        // handle form closing
        void _parent_FormClosing(object sender, FormClosingEventArgs e)
        {
            // check that we're not discarding any changes
            if (!OKToDiscardChanges())
            {
                e.Cancel = true;
            }

            // save settings (even when canceled closing, just to be safe...)
            Settings settings = Settings.Default;
            settings.QatBelowRibbon = Qat.BelowRibbon;
            settings.OpenedFiles = _mruOpened.RecentDocuments;
            settings.SavedFiles = _mruSaved.RecentDocuments;
            settings.ShowErrors = ShowErrors;
            settings.Dictionary = Dictionary;
            settings.Save();
        }

        #endregion

        //------------------------------------------------------------
        #region ** disable ribbon element serialization

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public RibbonApplicationMenu ApplicationMenuHolder
        {
            get { return base.ApplicationMenuHolder; }
            set { base.ApplicationMenuHolder = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public RibbonApplicationMenu ApplicationMenu
        {
            get { return base.ApplicationMenu; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public RibbonConfigToolBar ConfigToolBarHolder
        {
            get { return base.ConfigToolBarHolder; }
            set { base.ConfigToolBarHolder = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public RibbonConfigToolBar ConfigToolBar
        {
            get { return base.ConfigToolBar; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public RibbonQat QatHolder
        {
            get { return base.QatHolder; }
            set { base.QatHolder = value; }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        new public RibbonQat Qat
        {
            get { return base.Qat; }
        }

        #endregion

        //------------------------------------------------------------
        #region ** object model

        public C1Editor C1Editor
        {
            get { return Editor == null ? null : Editor.Editor; }
            set { Editor = new C1RibbonEditorXhtml(value); }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public C1RibbonEditorXhtml Editor
        {
            get { return _editor; }
            set
            {
                AttachEventHandlers(false);
                _editor = value;
                AttachEventHandlers(true);
                this.Enabled = Editor != null;
                if (Editor != null)
                {
                    Editor.Clear();
                    UpdateUndoRedoState();
                }
                _dirtyUI = true;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public C1SpellChecker SpellChecker
        {
            get { return _spellChecker; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool HasChanges
        {
            get { return _hasChanges; }
            set
            {
                if (_hasChanges != value)
                {
                    _hasChanges = value;
                    UpdateAppCaption();
                }
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FileName
        {
            get { return _fileName; }
            set
            {
                if (_fileName != value)
                {
                    _fileName = value;                    
                    UpdateAppCaption();
                }
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowErrors
        {
            get { return ((RibbonToggleButton)GetItemByID("ShowErrors")).Pressed; }
            set { ((RibbonToggleButton)GetItemByID("ShowErrors")).Pressed = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Dictionary
        {
            get { return Path.GetFileName(_spellChecker.MainDictionary.FileName); }
            set { _spellChecker.MainDictionary.FileName = value; }
        }

        #endregion

        //------------------------------------------------------------
        #region ** handle check spelling

        internal void SpellCheck()
        {
            if (_editor == null)
                return;

            object webBrowser = null;
            int errors;
            if ((webBrowser = _editor.GetWebBrowser2()) != null)
                errors = _spellChecker.CheckControl((Control)_editor.Editor, webBrowser, false, null);
            else
                return;

            string msg = errors < 0
                ? Resources.SpellingCanceled_msg
                : string.Format(Resources.SpellingComplete_msg, errors);
            MessageBox.Show(msg, Resources.SpellingComplete_caption);
        }

        internal void SetActiveSpellChecking(bool spellChecking)
        {
            if (_editor == null)
                return;

            object webBrowser = null;
            if ((webBrowser = _editor.GetWebBrowser2()) != null)
                _spellChecker.SetActiveSpellChecking((Control)_editor.Editor, webBrowser, spellChecking);
        }

        internal void SetSpellingLanguage()
        {
            using (SetLanguage dlg = new SetLanguage(_spellChecker))
            {
                dlg.ShowDialog();
            }
        }

        #endregion

        //------------------------------------------------------------
        #region ** editor event handlers

        // add/remove editor event handlers 
        void AttachEventHandlers(bool attach)
        {
            if (Editor != null)
            {
                if (attach)
                {
                    Editor.Editor.DocumentChanged += Editor_TextChanged;
                    Editor.Editor.SelectionChanged += Editor_SelectionChanged;

                    // support file drag/drop
                    Control ctl = Editor.Editor as Control;
                    if (ctl != null)
                    {
                        ctl.DragEnter += ctl_DragEnter;
                        ctl.DragDrop += ctl_DragDrop;
                    }

                    // connect spell-checker
                    if (ShowErrors)
                        SetActiveSpellChecking(true);
                }
                else
                {
                    Editor.Editor.DocumentChanged -= Editor_TextChanged;
                    Editor.Editor.SelectionChanged -= Editor_SelectionChanged;

                    // disconnect spell checker
                    SetActiveSpellChecking(false);
                }
            }
        }

        // update UI when the editor content changes
        void Editor_TextChanged(object sender, EventArgs e)
        {
            _dirtyUI = true;
            HasChanges = true;
            UpdateUndoRedoState();
            if (EditorTextChanged != null)
                EditorTextChanged(this, EventArgs.Empty);
        }

        // update UI when the current selection changes
        void Editor_SelectionChanged(object sender, EventArgs e)
        {
            _dirtyUI = true;
        }

        // file drop
        // REVIEW: editor thinks there are changes after drops
        void ctl_DragEnter(object sender, DragEventArgs e)
        {
            if (!string.IsNullOrEmpty(GetDroppedFileName(e.Data)))
            {
                e.Effect = DragDropEffects.Copy;
                return;
            }
        }
        void ctl_DragDrop(object sender, DragEventArgs e)
        {
            string fileName = GetDroppedFileName(e.Data);
            if (!string.IsNullOrEmpty(fileName))
            {
                OpenDocument(fileName);
                e.Effect = DragDropEffects.None;
            }
        }
        #endregion

        //------------------------------------------------------------
        #region ** command dispatcher

        // forward ribbon events to the appropriate C1XHtmlRibbonTab.
        protected override void OnRibbonEvent(RibbonEventArgs e)
        {
            RibbonItem item = e.Item as RibbonItem;
            if (item != null)
            {
                // handle clicks on non-tab items
                if (e.EventType == RibbonEventType.Click)
                {
                    // handle application menu and Qat items
                    if (item.Tab == null)
                    {
                        switch (item.ID)
                        {
                            case "New":
                                NewDocument();
                                return;
                            case "Open":
                            case "OpenQat":
                                OpenDocument();
                                return;
                            case "Save":
                            case "SaveQat":
                                SaveDocument();
                                return;
                            case "SaveAs":
                                SaveDocumentAs();
                                break;
                            case "Print":
                                PrintDocument(true, false);
                                break;
                            case "PrintPreview":
                                PrintDocument(false, true);
                                break;
                            case "QuickPrint":
                                PrintDocument(false, false);
                                break;
                            case "ExportPdf":
                                ExportDocument();
                                break;
                            case "Exit":
                                Exit();
                                break;
                            case "Undo":
                                Undo();
                                break;
                            case "Redo":
                                Redo();
                                break;
                            default:
                                break;
                        }
                    }
                }
                else if (e.EventType == RibbonEventType.DropDown)
                {
                    switch (item.ID)
                    {
                        case "Undo":
                        case "Redo":
                            bool isUndo = string.Compare(item.ID, "Undo", true) == 0;
                            string[] actionList = isUndo ? _editor.Editor.History.UndoList : _editor.Editor.History.RedoList;
                            RibbonSplitButton sb = item as RibbonSplitButton;
                            sb.Items.Clear();
                            int actionIndex = 0;
                            foreach (string action in actionList)
                            {
                                RibbonButton rb = new RibbonButton(action);
                                rb.Tag = actionIndex;
                                rb.Click += (isUndo ? new EventHandler(UndoClick) : new EventHandler(RedoClick));
                                sb.Items.Add(rb);
                                actionIndex += 1;
                            }
                            break;
                        default:
                            break;
                    }
                }

                // delegate to tab elements
                if (!_updatingUI)
                {
                    C1TextEditorRibbonTab tab = item.Tab as C1TextEditorRibbonTab;
                    if (tab != null)
                    {
                        tab.HandleItemEvent(e);
                    }
                }

                // exit when double-clicking the app menu
                if (item.Equals(this.ApplicationMenu) &&
                    e.EventType == RibbonEventType.DoubleClick)
                {
                    Exit();
                }
            }

            // fire event as usual
            base.OnRibbonEvent(e);
        }

        private void UndoClick(object sender, EventArgs e)
        {
            RibbonButton button = sender as RibbonButton;
            if (button != null)
            {
                int index = (int)button.Tag;
                _editor.Editor.History.Undo(index + 1);
            }
        }

        private void RedoClick(object sender, EventArgs e)
        {
            RibbonButton button = sender as RibbonButton;
            if (button != null)
            {
                int index = (int)button.Tag;
                _editor.Editor.History.Redo(index + 1);
            }
        }

        #endregion

        //------------------------------------------------------------
        #region ** non-tab event handlers (main menu/Qat)

        bool NewDocument()
        {
            if (!OKToDiscardChanges())
            {
                return false;
            }

            // start new document
            Editor.Clear();
            FileName = string.Empty;
            HasChanges = false;
            UpdateUndoRedoState();
            return true;
        }
        internal bool OpenDocument()
        {
            if (!OKToDiscardChanges())
            {
                return false;
            }

            // get file name
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                Editor.CustomizeFileDialog(dlg);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    return OpenDocument(dlg.FileName);
                }
            }

            // canceled
            return false;
        }
        internal bool OpenDocument(string fileName)
        {
            if (!OKToDiscardChanges())
            {
                return false;
            }

            try
            {
                if (Editor.Load(fileName))
                {
                    FileName = fileName;
                    _mruOpened.AddDocument(fileName);
                    HasChanges = false;
                    return true;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, Application.ProductName);
            }

            // failed to load, remove from mru
            _mruOpened.RemoveDocument(fileName);
            return false;
        }
        internal bool SaveDocument()
        {
            return SaveDocument(FileName);
        }
        internal bool SaveDocument(string fileName)
        {
            // no file name? defer to SaveAs to prompt
            if (string.IsNullOrEmpty(fileName))
            {
                return SaveDocumentAs();
            }

            // save current file
            try
            {
                if (Editor.Save(fileName))
                {
                    HasChanges = false;
                    return true;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, Application.ProductName);
            }

            // failed to save...
            return false;
        }
        internal bool PrintDocument(bool selectPrinter, bool showPreview)
        {
            if (!showPreview)
            {
                Editor.Print(selectPrinter);
            }
            else
            {
                Editor.PrintPreview();
            }
            return true;
        }
        bool ExportDocument()
        {
            // get pdf file name
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = "Portable Document File (*.pdf)|*.pdf";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    // create preview document
                    PrintDocument doc = Editor.PrintDocument;
                    PrintController pc = doc.PrintController;
                    PreviewPrintController pcpv = new PreviewPrintController();
                    doc.PrintController = pcpv;
                    doc.Print();
                    doc.PrintController = pc;

                    // create pdf document
                    using (C1.C1Pdf.C1PdfDocument pdf = new C1.C1Pdf.C1PdfDocument())
                    {
                        // add pages to pdf document
                        bool firstPage = true;
                        foreach (PreviewPageInfo page in pcpv.GetPreviewPageInfo())
                        {
                            pdf.PageSize = new SizeF(
                                page.PhysicalSize.Width * 0.72f,
                                page.PhysicalSize.Height * 0.72f);
                            if (!firstPage)
                            {
                                pdf.NewPage();
                            }
                            pdf.DrawImage(page.Image, pdf.PageRectangle);
                            firstPage = false;
                        }

                        // save pdf file
                        try
                        {
                            pdf.Save(dlg.FileName);
                            string msg = string.Format(Resources.ExportPdf_msg, Path.GetFileName(dlg.FileName));
                            DialogResult dr = MessageBox.Show(this, msg, Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.Yes)
                            {
                                Process.Start(dlg.FileName);
                            }
                            return true;
                        }
                        catch (Exception x)
                        {
                            string msg = x.Message;
                            MessageBox.Show(this, msg, Application.ProductName);
                            return false;
                        }
                    }
                }
            }

            // failed
            return false;
        }
        internal bool SaveDocumentAs()
        {
            // get file name
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                Editor.CustomizeFileDialog(dlg);
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    FileName = dlg.FileName;
                    _mruSaved.AddDocument(FileName);
                    return SaveDocument();
                }
            }

            // failed...
            return false;
        }
        void Exit()
        {
            if (!OKToDiscardChanges())
            {
                return;
            }

            // done with application
            Application.Exit();
        }
        void Undo()
        {
            Editor.Undo();
        }
        void Redo()
        {
            Editor.Redo();
        }

        #endregion

        //------------------------------------------------------------
        #region ** implementation

        // initialize tabs
        void InitTabs()
        {
            Tabs.Clear();
            Tabs.Add(new HomeTab());
            Tabs.Add(new InsertTab());
            Tabs.Add(new ReviewTab());
            Tabs.Add(new ViewTab());

            foreach (C1TextEditorRibbonTab tab in Tabs)
                tab.InitTab();
        }

        // initialize main menu
        void InitApplicationMenu()
        {
            // initialize menu
            RibbonApplicationMenu menu = this.ApplicationMenu;
            menu.DropDownWidth = 370;
            menu.AllowImageScaling = false;
            menu.SmallImage = Resources.AppMenuArrow;
            menu.Appearance = AppMenuAppearance.WholeForm;
            menu.DropDown += Menu_DropDown;

            // left menu items
            RibbonItemCollection items = menu.LeftPaneItems;
            items.ClearAndDisposeItems();
            items.Add(CreateButton("New"));
            items.Add(CreateTab("OpenTab"));
            ((AppMenuTabs.OpenTab)((RibbonAppMenuTab)items["OpenTab"]).Control).RibbonApplicationMenu = menu;
            items.Add(CreateButton("Save"));
            items["Save"].SmallImage = null;
            items.Add(CreateTab("SaveAsTab"));
            ((AppMenuTabs.SaveAsTab)((RibbonAppMenuTab)items["SaveAsTab"]).Control).RibbonApplicationMenu = menu;
            items.Add(new RibbonSeparator());
            items.Add(CreateTab("PrintTab"));

            _printTab = (AppMenuTabs.PrintTab)((RibbonAppMenuTab)items["PrintTab"]).Control;
            _printTab.Ribbon = this;
            _printTab.VisibleChanged += _printTab_VisibleChanged;

            //items.Add(CreateSplitButton("Print",
            //    CreateHeaderLabel("PreviewAndPrint"),
            //    CreateButton("Print"),
            //    CreateButton("QuickPrint"),
            //    CreateButton("PrintPreview")));
            items.Add(CreateButton("ExportPdf"));
            items.Add(new RibbonSeparator());
            items.Add(CreateButton("Exit"));

            _mruOpened = new RecentDocumentList(Settings.Default.OpenedFiles);
            _mruSaved = new RecentDocumentList(Settings.Default.SavedFiles);
        }

        private void _printTab_VisibleChanged(object sender, EventArgs e)
        {
            if (_printTab.Visible)
            {
                _printTab.SetDocument();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_printTab != null)
                {
                    _printTab.VisibleChanged -= _printTab_VisibleChanged;
                }
            }
            base.Dispose(disposing);
        }

        // initialize quick access toolbar
        void InitQat()
        {
            // populate QAT (use ItemLinks instead of Items)
            RibbonQatLinkCollection items = Qat.ItemLinks;
            items.Clear();
            items.Add(CreateSplitButton("Undo", new object[] {}));
            items.Add(CreateSplitButton("Redo", new object[] {}));
            items.Add(CreateButton("SaveQat", "Save"));

            // copy QAT items to the hot item list (to allow customization)
            RibbonQatLinkCollection hot = Qat.HotItemLinks;
            hot.Clear();
            foreach (Component item in Qat.ItemLinks)
            {
                hot.Add(item);
            }

            // add more items to hot item list
            hot.Add(CreateButton("OpenQat", "Open"));
        }

        // delegate element creation to C1XHtmlRibbonTab
        static RibbonLabel CreateHeaderLabel(string id)
        {
            return C1TextEditorRibbonTab.CreateHeaderLabel(id);
        }
        static RibbonListItem CreateHeader(string id)
        {
            return C1TextEditorRibbonTab.CreateHeader(id);
        }
        static RibbonAppMenuTab CreateTab(string id)
        {
            return C1TextEditorRibbonTab.CreateTab(id);
        }
        static RibbonButton CreateButton(string id)
        {
            return C1TextEditorRibbonTab.CreateButton(id);
        }
        static RibbonButton CreateButton(string id, string imageId)
        {
            return C1TextEditorRibbonTab.CreateButton(id, imageId);
        }
        static RibbonSplitButton CreateSplitButton(string id, params object[] items)
        {
            return C1TextEditorRibbonTab.CreateSplitButton(id, items);
        }

        // check whether it's OK to discard any current changes
        bool OKToDiscardChanges()
        {
            // no changes? ok to discard (nothing)
            if (!HasChanges)
            {
                return true;
            }

            // prompt user
            string docName = string.IsNullOrEmpty(FileName) ? "Document" : Path.GetFileName(FileName);
            string msg = string.Format(Resources.SaveChanges_msg, docName);
            DialogResult dr = MessageBox.Show(msg, Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            switch (dr)
            {
                case DialogResult.Yes:
                    return SaveDocument();
                case DialogResult.No:
                    HasChanges = false; // don't ask again...
                    return true;
            }

            // not OK to discard...
            return false;
        }

        // show current document name and modified state in form caption.
        void UpdateAppCaption()
        {
            Control ctl = TopLevelControl;
            if (ctl is Form)
            {
                StringBuilder sb = new StringBuilder();
                if (!string.IsNullOrEmpty(FileName))
                {
                    sb.AppendFormat("{0}{1} - ", 
                        HasChanges ? "* " : string.Empty,
                        Path.GetFileName(FileName));
                }
                sb.Append(Application.ProductName);
                ctl.Text = sb.ToString();
            }
            UpdateUI();
        }

        // update UI when the selection changes
        void UpdateUI()
        {
            // start updating
            _updatingUI = true;

            // update selected tab
            C1TextEditorRibbonTab tab = this.SelectedTab as C1TextEditorRibbonTab;
            if (tab != null)
                tab.UpdateUI();

            // done updating
            _updatingUI = false;
            _dirtyUI = false;
        }

        // update Undo and Redo buttons state
        void UpdateUndoRedoState()
        {
            EnableItem("Undo", Editor.CanUndo);
            EnableItem("Redo", Editor.CanRedo);
        }

        // enable/disable items based on their ID
        void EnableItem(string id, bool enable)
        {
            RibbonItem item = (RibbonItem)GetItemByID(id);
            item.Enabled = enable;
        }

        // get name of rtf file being dropped
        string GetDroppedFileName(IDataObject data)
        {
            if (data.GetDataPresent(DataFormats.FileDrop, false))
            {
                string[] files = (string[])data.GetData(DataFormats.FileDrop);
                if (files != null && files.Length == 1)
                {
                    return files[0];
                }
            }
            return null;
        }

        private void Menu_DropDown(object sender, EventArgs e)
        {
            var openTab = (AppMenuTabs.OpenTab)((RibbonAppMenuTab)ApplicationMenu.LeftPaneItems["OpenTab"]).Control;
            openTab.LoadItems(_mruOpened.RecentDocuments);
            // load saved docs
            var saveAsTab = (AppMenuTabs.SaveAsTab)((RibbonAppMenuTab)ApplicationMenu.LeftPaneItems["SaveAsTab"]).Control;
            saveAsTab.LoadItems(_mruSaved.RecentDocuments);
        }
        #endregion
    }
}
