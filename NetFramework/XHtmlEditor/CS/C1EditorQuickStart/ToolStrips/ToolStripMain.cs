using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1SpellChecker;

namespace C1EditorQuickStart.ToolStrips
{
    class ToolStripMain : ToolStripBase
    {
        //----------------------------------------------------------------------------
        #region ** fields

        string _fileName;
        bool _dirty;
        C1SpellChecker _spellChecker;
        ToolStripButton _btnNew, _btnOpen, _btnSave, _btnPrint;
        ToolStripButton _btnCut, _btnCopy , _btnPaste;
        ToolStripButton _btnUndo, _btnRedo;
        ToolStripButton _btnFind, _btnReplace;
        ToolStripButton _btnShowErrors, _btnSpell;
        ToolStripButton _btnWordCount;
        ToolStripButton _btnHelp;

        #endregion

        //----------------------------------------------------------------------------
        #region ** object model

        public C1SpellChecker SpellChecker
        {
            get { return _spellChecker; }
            set { _spellChecker = value; }
        }

        #endregion

        //----------------------------------------------------------------------------
        #region ** event handlers

        // initialize the toolstrip
        protected override void OnInitialize()
        {
            // populate toolstrip
            _btnNew = AddButton("New", Properties.Resources.New_small, New_Click);
            _btnOpen = AddButton("Open", Properties.Resources.Open_small, Open_Click);
            _btnSave = AddButton("Save", Properties.Resources.Save_small, Save_Click);
            _btnPrint = AddButton("Print", Properties.Resources.Print_small, Print_Click);
            Items.Add(new ToolStripSeparator());
            _btnCut = AddButton("Cut", Properties.Resources.Cut_small, Cut_Click);
            _btnCopy = AddButton("Copy", Properties.Resources.Copy_small, Copy_Click);
            _btnPaste = AddButton("Paste", Properties.Resources.Paste_small, Paste_Click);
            Items.Add(new ToolStripSeparator());
            _btnUndo = AddButton("Undo", Properties.Resources.Undo_small, Undo_Click);
            _btnRedo = AddButton("Redo", Properties.Resources.Redo_small, Redo_Click);
            Items.Add(new ToolStripSeparator());
            _btnShowErrors = AddButton("Show Spelling Errors", Properties.Resources.ShowErrors_small, ShowSpellingErrors_Click);
            _btnSpell = AddButton("Spell", Properties.Resources.Spelling_small, Spell_Click);
            Items.Add(new ToolStripSeparator());
            _btnFind = AddButton("Find", Properties.Resources.Find_small, Find_Click);
            _btnReplace = AddButton("Replace", Properties.Resources.Replace_small, Replace_Click);
            Items.Add(new ToolStripSeparator());
            _btnWordCount = AddButton("Word Count", Properties.Resources.WordCount_small, WordCount_Click);
            Items.Add(new ToolStripSeparator());
            _btnHelp = AddButton("Help", Properties.Resources.Help_small, Help_Click);
        }

        // enable/disable buttons
        public override void UpdateState()
        {
            Enabled = Editor != null;
            _btnCopy.Enabled = _btnCut.Enabled = Editor.CanCopy;
            _btnPaste.Enabled = Editor.CanPasteAsText; // CanPaste
            _btnUndo.Enabled = Editor.CanUndo();
            _btnRedo.Enabled = Editor.CanRedo();
            bool isDesign = Editor.Mode == C1.Win.C1Editor.EditorMode.Design;
            bool isPreview = Editor.Mode == C1.Win.C1Editor.EditorMode.Preview;
            _btnShowErrors.Enabled = isDesign && SpellChecker != null;
            _btnSpell.Enabled = isDesign && SpellChecker != null;
            _btnFind.Enabled = !isPreview;
            _btnReplace.Enabled = !isPreview;
        }

        // keep track of changes in the document
        protected override void OnDocumentChanged(EventArgs e)
        {
            SetDirty(true);
        }
        
        // keep track of changes in the document
        protected override void OnModeChanged(EventArgs e)
        {
            UpdateState();
        }

        protected override void OnEditorKeyDownHandler(KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                e.Handled = true;
                Save_Click(null, EventArgs.Empty);
            }
            else if (e.Control && e.KeyCode == Keys.O)
            {
                e.Handled = true;
                Open_Click(null, EventArgs.Empty);
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                e.Handled = true;
                Print_Click(null, EventArgs.Empty);
            }
            else if (e.Control && e.KeyCode == Keys.N)
            {
                e.Handled = true;
                New_Click(null, EventArgs.Empty);
            }
        }

        // file commands
        void New_Click(object sender, EventArgs e)
        {
            NewDocument();
        }
        void Open_Click(object sender, EventArgs e)
        {
            LoadDocument();
        }
        void Save_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        // preview/print
        void Print_Click(object sender, EventArgs e)
        {
            Editor.PrintPreview();
        }

        // clipboard
        void Cut_Click(object sender, EventArgs e)
        {
            Editor.Cut();
        }
        void Copy_Click(object sender, EventArgs e)
        {
            Editor.Copy();
        }
        void Paste_Click(object sender, EventArgs e)
        {
            Editor.PasteAsText();//.Paste();
        }

        // undo/redo
        void Undo_Click(object sender, EventArgs e)
        {
            Editor.Undo();
        }
        void Redo_Click(object sender, EventArgs e)
        {
            Editor.Redo();
        }

        // find/replace
        void Find_Click(object sender, EventArgs e)
        {
            Editor.ShowDialog(C1.Win.C1Editor.DialogType.Find);
        }
        void Replace_Click(object sender, EventArgs e)
        {
            Editor.ShowDialog(C1.Win.C1Editor.DialogType.Replace);
        }

        // spelling
        void ShowSpellingErrors_Click(object sender, EventArgs e)
        {
            if (SpellChecker != null)
            {
                bool show = !_btnShowErrors.Checked;
                _btnShowErrors.Checked = show;
                SpellChecker.SetActiveSpellChecking(Editor, Editor.GetActiveXInstance(), show);
            }
        }
        void Spell_Click(object sender, EventArgs e)
        {
            if (SpellChecker != null)
            {
                SpellChecker.CheckControl(Editor, Editor.GetActiveXInstance());
            }
        }

        // word count
        void WordCount_Click(object sender, EventArgs e)
        {
            string text = Editor.Text;
            int chars = 0;
            int nonSpaceChars = 0;
            int words = 0;
            int paragraphs = 0;
            int sentences = 0;

            int length = text.Length;

            // calculate statistics
            for (int i = 0; i < length; i++)
            {
                char c = text[i];

                // count chars
                chars++;

                // count non-space chars
                if (!char.IsWhiteSpace(c))
                {
                    nonSpaceChars++;
                }

                // count paragraphs
                if (c == '\n' || i == length - 1)
                {
                    if (i == length - 1 || text[i + 1] != '\n')
                    {
                        paragraphs++;
                    }
                }

                // count sentences
                if (c == '.' || c == '!' || c == '?' || i == length - 1)
                {
                    if (i == length - 1 || char.IsWhiteSpace(text, i + 1))
                    {
                        sentences++;
                    }
                }

                // count words
                if (char.IsLetterOrDigit(c))
                {
                    if (i == length - 1 || !char.IsLetterOrDigit(text, i + 1))
                    {
                        words++;
                    }
                }
            }

            // show statistics
            string msg = string.Format(
                "Words: {0:n0}\r\n" +
                "Characters: {1:n0}\r\n" +
                "Non-Space Characters: {2:n0}\r\n" +
                "Sentences: {3:n0}\r\n" +
                "Paragraphs: {4:n0}\r\n" +
                "Average Word Length: {5:n1}\r\n" +
                "Average Sentence Length: {6:n1}\r\n" +
                "Average Paragraph Length: {7:n1}\r\n",
                words, chars, nonSpaceChars, sentences, paragraphs,
                words > 0 ? nonSpaceChars / (float)words : 0f,
                sentences > 0 ? nonSpaceChars / (float)sentences : 0f,
                paragraphs > 0 ? nonSpaceChars / (float)paragraphs : 0f);
            MessageBox.Show(msg, "Word Count");
        }

        // help
        void Help_Click(object sender, EventArgs e)
        {
            string msg = string.Format(
                Properties.Resources.About,
                Editor.GetType().Assembly.GetName().Version);
            MessageBox.Show(msg, ProductName);
        }

        #endregion

        //----------------------------------------------------------------------------
        #region ** implementation

        // keep track of changes
        void SetDirty(bool dirty)
        {
            _dirty = dirty;
            UpdateCaption();
        }

        // check with user before discarding changes
        bool OKToDiscardChanges()
        {
            if (_dirty)
            {
                DialogResult dr = MessageBox.Show(
                    Properties.Resources.PromptSaveChanges,
                    ProductName,
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                switch (dr)
                {
                    // save document, then proceed
                    case DialogResult.Yes:
                        return SaveDocument();

                    // proceed without saving
                    case DialogResult.No:
                        return true;

                    // do not proceed
                    case DialogResult.Cancel:
                        return false;
                }
            }

            // no changes, ok to proceed
            return true;
        }

        // show current document and modified state
        void UpdateCaption()
        {
            Form form = TopLevelControl as Form;
            if (form != null)
            {
                StringBuilder sb = new StringBuilder(ProductName);
                if (!string.IsNullOrEmpty(_fileName))
                {
                    sb.AppendFormat(" - {0}", Path.GetFileName(_fileName));
                    if (_dirty)
                    {
                        sb.Append(" *");
                    }
                }
                form.Text = sb.ToString();
            }
        }

        // create a new document
        bool NewDocument()
        {
            if (OKToDiscardChanges())
            {
                Editor.Document = new System.Xml.XmlDocument();
                _fileName = null;
                SetDirty(false);
                return true;
            }
            return false;
        }

        // load a document into the editor
        bool LoadDocument()
        {
            if (OKToDiscardChanges())
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    // get file name
                    dlg.Filter = Properties.Resources.FileFilter;
                    dlg.DefaultExt = Properties.Resources.DefaultExt;
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            // load document
                            Editor.LoadXml(dlg.FileName);
                            _fileName = dlg.FileName;
                            SetDirty(false);
                            return true;
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }

            // canceled...
            return false;
        }

        // save current document using current file name
        bool SaveDocument()
        {
            // no name? go get one...
            if (string.IsNullOrEmpty(_fileName))
            {
                return SaveDocumentAs();
            }

            // got the name, save the file
            try
            {
                Editor.SaveXml(_fileName);
                SetDirty(false);
                return true;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // save current document using a new name
        bool SaveDocumentAs()
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Filter = Properties.Resources.FileFilter;
                dlg.DefaultExt = Properties.Resources.DefaultExt;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _fileName = dlg.FileName;
                    return SaveDocument();
                }
            }
            return false;
        }

        #endregion

    }
}
