using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

using C1.Win.C1Ribbon;
using System.Linq;
using C1.Win.C1Themes;

namespace WordPad
{
    public partial class Form1 : C1RibbonForm
    {
        public Form1()
        {
            InitializeComponent();

            this.InitializeClipboardGroup();
            this.InitializeFontGroup();
            this.InitializeParagraphGroup();
            this.InitializeViewZoomGroup();

            this.InitializeRibbonStyleMenu();
            this.InitializeFocusManagement();
            this.InitializeUndoRedo();
            this.InitializeModifiedIcon();
            this.InitializeQatPosition();

            this.InitializeRecentDocumentList();

            // Load a sample text file into the editor.
            this.LoadDocument(@"Readme.rtf");

            // Save application settings on exit.
            this.FormClosed += delegate { Properties.Settings.Default.Save(); };
        }

        #region Clipboard Group

        private void InitializeClipboardGroup()
        {
            this.UpdateClipboardGroupBasedOnCurrentTextSelection();

            this.richTextBox1.SelectionChanged += delegate
            {
                this.UpdateClipboardGroupBasedOnCurrentTextSelection();
            };

            this.PasteButton.Click += new EventHandler(PasteButton_Click);
            this.PasteAsTextButton.Click += new EventHandler(PasteAsTextButton_Click);
        }

        private void CutButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Cut();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Copy();
        }

        private void PasteSplitButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        void PasteButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Paste();
        }

        void PasteAsTextButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectedText = Clipboard.GetText();
        }

        private void UpdateClipboardGroupBasedOnCurrentTextSelection()
        {
            this.CutButton.Enabled = this.CopyButton.Enabled =
                !string.IsNullOrEmpty(this.richTextBox1.SelectedText);
        }

        #endregion
        #region Font Group

        private void InitializeFontGroup()
        {
            // Populate the Font Face combobox with font names.
            foreach (FontFamily fontFamily in FontFamily.Families)
            {
                this.FontFaceComboBox.Items.Add(new RibbonButton(fontFamily.Name));
            }

            // Populate the Font Size combobox with some typical font sizes.
            foreach (int size in new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 })
            {
                this.FontSizeComboBox.Items.Add(new RibbonButton(size.ToString()));
            }

            // Keep ribbon controls state updated based on current text selection.
            this.UpdateFontGroupBasedOnCurrentTextSelection();
            this.richTextBox1.SelectionChanged += delegate
            {
                this.UpdateFontGroupBasedOnCurrentTextSelection();
            };
        }

        private void UpdateFontGroupBasedOnCurrentTextSelection()
        {
            Font font = this.richTextBox1.SelectionFont;
            bool none = font == null;
            FontBoldButton.Pressed = none ? false : font.Bold;
            FontItalicButton.Pressed = none ? false : font.Italic;
            FontUnderlineButton.Pressed = none ? false : font.Underline;
            FontStrikeoutButton.Pressed = none ? false : font.Strikeout;
            FontFaceComboBox.Text = none ? "" : font.FontFamily.Name;
            FontSizeComboBox.Text = none ? "" : font.Size.ToString();
        }

        private void FontFaceComboBox_ChangeCommitted(object sender, EventArgs e)
        {
            Font font = this.richTextBox1.SelectionFont;

            if (font == null)
            {
                MessageBox.Show("Cannot change font family while selected text has more than one font.");
                return;
            }

            string fontFamilyName = this.FontFaceComboBox.Text;

            this.richTextBox1.SelectionFont = new Font(
                fontFamilyName,
                font.Size,
                font.Style,
                font.Unit);
        }

        private void FontSizeComboBox_ChangeCommitted(object sender, EventArgs e)
        {
            Font font = this.richTextBox1.SelectionFont;

            if (font == null)
            {
                MessageBox.Show("Cannot change font size while selected text has more than one font.");
                return;
            }

            this.richTextBox1.SelectionFont = new Font(
                font.FontFamily,
                float.Parse(this.FontSizeComboBox.Text),
                font.Style,
                GraphicsUnit.Point);
        }

        #region Bold, Italic, Underline, and Strikeout Buttons

        private void FontBoldButton_Click(object sender, EventArgs e)
        {
            ToggleSelectionFontStyle(FontStyle.Bold);
        }

        private void FontItalicButton_Click(object sender, EventArgs e)
        {
            ToggleSelectionFontStyle(FontStyle.Italic);
        }

        private void FontUnderlineButton_Click(object sender, EventArgs e)
        {
            ToggleSelectionFontStyle(FontStyle.Underline);
        }

        private void FontStrikeoutButton_Click(object sender, EventArgs e)
        {
            ToggleSelectionFontStyle(FontStyle.Strikeout);
        }

        void ToggleSelectionFontStyle(FontStyle fontStyle)
        {
            if (this.richTextBox1.SelectionFont == null)
            {
                MessageBox.Show("Cannot change font style while selected text has more than one font.");
            }
            else
            {
                this.richTextBox1.SelectionFont = new Font(this.richTextBox1.SelectionFont,
                    this.richTextBox1.SelectionFont.Style ^ fontStyle);
            }
        }

        #endregion

        #region FontColorPicker

        private void FontColorPicker_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionColor = this.FontColorPicker.Color;
        }

        private void FontColorPicker_SelectedColorChanged(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionColor = this.FontColorPicker.Color;
        }

        #endregion
        #region BackColorPicker

        private void BackColorPicker_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionBackColor = this.BackColorPicker.Color;
        }

        private void BackColorPicker_SelectedColorChanged(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionBackColor = this.BackColorPicker.Color;
        }

        #endregion

        private void FontGroup_ClickDialogLauncher(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            Font font = this.richTextBox1.SelectionFont;
            if (font != null) dlg.Font = font;
            if (dlg.ShowDialog() != DialogResult.OK) return;
            this.richTextBox1.SelectionFont = dlg.Font;
        }

        #endregion
        #region Paragraph Group

        private void InitializeParagraphGroup()
        {
            // Keep Ribbon controls state updated based on current text selection.
            this.UpdateParagraphGroupBasedOnCurrentTextSelection();
            this.richTextBox1.SelectionChanged += delegate
            {
                this.UpdateParagraphGroupBasedOnCurrentTextSelection();
            };
        }

        private void UpdateParagraphGroupBasedOnCurrentTextSelection()
        {
            this.UpdateParagraphAlignmentButtons();
        }

        #region Indent Buttons

        private void IncreaseIndentButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionIndent += 30;
        }

        private void DecreaseIndentButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.SelectionIndent -= 30;
        }

        #endregion
        #region Alignment Buttons

        private void ParagraphAlignLeftButton_Click(object sender, EventArgs e)
        {
            this.SetParagraphAlignment(HorizontalAlignment.Left);
        }

        private void ParagraphAlignCenterButton_Click(object sender, EventArgs e)
        {
            this.SetParagraphAlignment(HorizontalAlignment.Center);
        }

        private void ParagraphAlignRightButton_Click(object sender, EventArgs e)
        {
            this.SetParagraphAlignment(HorizontalAlignment.Right);
        }

        void SetParagraphAlignment(HorizontalAlignment alignment)
        {
            this.richTextBox1.SelectionAlignment = alignment;

            // If the user clicks the same button twice, it will get unpressed.
            // We want 1 button to be pressed at all times, so we just set 
            // the buttons' states based on current text alignment.
            this.UpdateParagraphAlignmentButtons();
        }

        private void UpdateParagraphAlignmentButtons()
        {
            HorizontalAlignment a = this.richTextBox1.SelectionAlignment;
            this.ParagraphAlignLeftButton.Pressed = a == HorizontalAlignment.Left;
            this.ParagraphAlignCenterButton.Pressed = a == HorizontalAlignment.Center;
            this.ParagraphAlignRightButton.Pressed = a == HorizontalAlignment.Right;
        }

        #endregion

        #endregion
        #region View Zoom Group

        private void InitializeViewZoomGroup()
        {
            foreach (int percent in new int[] { 10, 30, 50, 80, 100, 120, 150, 200, 250, 300, 400, 700, 1000 })
            {
                this.ViewZoomCombobox.Items.Add(new RibbonButton(percent + "%"));
            }

            this.UpdateViewZoomComboBox();

            // Update the combo box when user zooms with the mouse wheel.
            this.richTextBox1.MouseWheel += delegate
            {
                this.UpdateViewZoomComboBox();
            };
        }

        private void ViewZoomCombobox_ChangeCommitted(object sender, EventArgs e)
        {
            string s = this.ViewZoomCombobox.Text;
            if (string.IsNullOrEmpty(s)) return;
            if (s.EndsWith("%")) s = s.Substring(0, s.Length - 1);
            float percent;
            if (!float.TryParse(s, out percent)) return;
            this.SetZoomFactor(percent / 100);
        }

        private void UpdateViewZoomComboBox()
        {
            this.ViewZoomCombobox.Text = (this.richTextBox1.ZoomFactor * 100).ToString() + "%";
        }

        private void NormalSizeButton_Click(object sender, EventArgs e)
        {
            this.SetZoomFactor(1);
        }

        private void SetZoomFactor(float zoomFactor)
        {
            this.richTextBox1.ZoomFactor = zoomFactor;
            this.UpdateViewZoomComboBox();
        }

        #endregion

        #region Input Focus Management

        private void InitializeFocusManagement()
        {
            // Set initial focus on the text area.
            this.Shown += delegate { this.richTextBox1.Focus(); };

            // When a Ribbon button is clicked, move the focus back to the rich text box.
            this.c1Ribbon1.RibbonEvent += new RibbonEventHandler(c1Ribbon1_RibbonEvent);
        }

        void c1Ribbon1_RibbonEvent(object sender, RibbonEventArgs e)
        {
            switch (e.EventType)
            {
                case RibbonEventType.ChangeCommitted:
                case RibbonEventType.ChangeCanceled:
                case RibbonEventType.Click:
                case RibbonEventType.DialogLauncherClick:
                case RibbonEventType.DropDownClosed:
                    if (this.c1Ribbon1.Focused)
                    {
                        this.richTextBox1.Focus();
                    }
                    break;
            }
        }

        #endregion
        #region Undo/Redo

        private void InitializeUndoRedo()
        {
            this.UpdateUndoRedoButtons();
            this.richTextBox1.TextChanged += delegate { this.UpdateUndoRedoButtons(); };
        }

        void UpdateUndoRedoButtons()
        {
            this.UndoButton.Enabled = this.richTextBox1.CanUndo;
            this.RedoButton.Enabled = this.richTextBox1.CanRedo;
        }

        private void UndoButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Undo();
            this.UpdateUndoRedoButtons();
        }

        private void RedoButton_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Redo();
            this.UpdateUndoRedoButtons();
        }

        #endregion

        private void InitializeModifiedIcon()
        {
            this.UpdateModifiedIcon();
            this.richTextBox1.ModifiedChanged += delegate { this.UpdateModifiedIcon(); };
        }

        private void UpdateModifiedIcon()
        {
            this.DocumentModifiedLabel.Enabled = this.richTextBox1.Modified;
            this.DocumentModifiedLabel.ToolTip = this.richTextBox1.Modified
                ? "Document modified"
                : "Document not modified";
        }

        #region Application Menu, Document-level functions (Open, Save, etc)

        /// <summary>
        /// Path to the currently open document, no trailing backslash, e.g. "C:\Documents"; 
        /// null if the document has never been saved.
        /// </summary>
        string documentPath;

        /// <summary>
        /// The file name of the document, such as "Document.rtf"
        /// </summary>
        string documentName;

        RichTextBoxStreamType documentFileType;

        private void NewDocumentButton_Click(object sender, EventArgs e)
        {
            if (!this.PromtToSaveDocument()) return;

            this.CreateNewDocument();
        }

        private void OpenDocumentButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Supported files (*.rtf, *.txt)|*.rtf;*.txt|" + "All files (*.*)|*.*";

            DialogResult dr = dlg.ShowDialog();
            if (dr == DialogResult.Cancel) return;
            if (dr != DialogResult.OK) throw new ApplicationException();

            if (!this.PromtToSaveDocument()) return;

            this.LoadDocument(dlg.FileName);
        }

        private void SaveDocumentButton_Click(object sender, EventArgs e)
        {
            this.SaveDocument();
        }

        private void SaveDocumentAsButton_Click(object sender, EventArgs e)
        {
            this.ShowSaveFileDialog();
        }

        private void ShowSaveFileDialog()
        {
            this.SaveDocument(true); // passing 'true' to show the Save File dialog.
        }

        private void SaveDocumentAsRtfButton_Click(object sender, EventArgs e)
        {
            string s = this.documentName;
            if (s.EndsWith(".txt"))
                this.documentName = s.Substring(0, s.Length - 3) + "rtf";
            this.SaveDocumentAs(RichTextBoxStreamType.RichText);
        }

        private void SaveDocumentAsTextButton_Click(object sender, EventArgs e)
        {
            string s = this.documentName;
            if (s.EndsWith(".rtf"))
                this.documentName = s.Substring(0, s.Length - 3) + "txt";
            this.SaveDocumentAs(RichTextBoxStreamType.PlainText);
        }

        private void SaveDocumentAsOtherButton_Click(object sender, EventArgs e)
        {
            this.ShowSaveFileDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!this.PromtToSaveDocument())
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// If necessary, promts the user if they want to save the current document;
        /// if the user says yes, saves the document.
        /// </summary>
        /// <returns> False if the user cancelled saving either at the promt or the save file dialog. </returns>
        private bool PromtToSaveDocument()
        {
            if (!this.richTextBox1.Modified) return true;

            DialogResult dr = MessageBox.Show(
                "Do you want to save '" + this.documentName + "'?",
                "WordPad Sample", MessageBoxButtons.YesNoCancel);

            switch (dr)
            {
                case DialogResult.Cancel:
                    return false;

                case DialogResult.No:
                    return true;

                case DialogResult.Yes:
                    return this.SaveDocument();
            }

            throw new ApplicationException();
        }

        /// <summary>
        /// Replaces the current document with a new empty document.
        /// </summary>
        private void CreateNewDocument()
        {
            this.richTextBox1.Clear();
            this.documentName = "Document";
            this.documentPath = null;
            this.documentFileType = RichTextBoxStreamType.RichText;

            this.RaiseRichTextBoxSelectionChanged();
        }

        private void LoadDocument(string filePathName)
        {
            RichTextBoxStreamType streamType = filePathName.EndsWith(".rtf")
                    ? RichTextBoxStreamType.RichText
                    : RichTextBoxStreamType.PlainText;
            try
            {
                this.richTextBox1.LoadFile(filePathName, streamType);
                this.SetDocumentProperties(filePathName, streamType);
                this.recentDocuments.Update(filePathName);
                this.RaiseRichTextBoxSelectionChanged();
            }
            catch (IOException e)
            {
                // there is no such file
                MessageBox.Show(e.Message);
            }
        }

        private void RaiseRichTextBoxSelectionChanged()
        {
            // Force a SelectionChanged event to update the state of Ribbon items 
            // that depend on current text selection.
            this.richTextBox1.SelectAll();
            this.richTextBox1.Select(0, 0);

            this.richTextBox1.Modified = false;
        }

        private void SetDocumentProperties(string filePathName, RichTextBoxStreamType fileType)
        {
            FileInfo fileInfo = new FileInfo(filePathName);
            this.documentName = fileInfo.Name;
            this.documentPath = fileInfo.DirectoryName;
            this.documentFileType = fileType;
        }

        private bool SaveDocument()
        {
            return this.SaveDocument(this.documentPath == null);
        }

        private bool SaveDocument(bool showDialog)
        {
            if (showDialog)
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.FileName = this.documentName;
                if (this.documentPath != null) dlg.InitialDirectory = this.documentPath;
                dlg.Filter = "Rich text file (*.rtf)|*.rtf|"
                    + "Rich text file, no OLE objects (*.rtf)|*.rtf|"
                    + "Plain text file, no OLE objects (*.txt)|*.txt|"
                    + "Plain text file, OLE objects replaced with text (*.txt)|*.txt|"
                    + "Unicode text file, no OLE objects (*.txt)|*.txt";

                DialogResult dr = dlg.ShowDialog();
                if (dr == DialogResult.Cancel) return false;
                if (dr != DialogResult.OK) throw new ApplicationException();

                RichTextBoxStreamType fileType;

                switch (dlg.FilterIndex)
                {
                    case 1: fileType = RichTextBoxStreamType.RichText; break;
                    case 2: fileType = RichTextBoxStreamType.RichNoOleObjs; break;
                    case 3: fileType = RichTextBoxStreamType.PlainText; break;
                    case 4: fileType = RichTextBoxStreamType.TextTextOleObjs; break;
                    case 5: fileType = RichTextBoxStreamType.UnicodePlainText; break;
                    default: throw new ApplicationException();
                }

                this.SetDocumentProperties(dlg.FileName, fileType);
            }

            this.SaveDocumentAs(this.documentFileType);

            return true;
        }

        private void SaveDocumentAs(RichTextBoxStreamType fileType)
        {
            string filePathName = this.documentPath + '\\' + this.documentName;

            this.richTextBox1.SaveFile(filePathName, fileType);

            this.recentDocuments.Update(filePathName);

            this.richTextBox1.Modified = false;
        }

        #endregion

        #region Ribbon Style Menu

        private void InitializeRibbonStyleMenu()
        {
            ribbonStyleCombo.Items.Clear();
            string[] themes = C1ThemeController.GetThemes();
            ribbonStyleCombo.Items.Add("(No Theme)");
            foreach (string theme in themes)
                ribbonStyleCombo.Items.Add(theme);
            ribbonStyleCombo.SelectedIndex = 0;
        }

        private void ribbonStyleCombo_ChangeCommitted(object sender, EventArgs e)
        {
            this.SuspendPainting();
            C1Theme theme = null;
            try
            {
                theme = C1ThemeController.GetThemeByName(ribbonStyleCombo.Text, false);
            }
            catch
            {

            }
            this.ribbonApplicationMenu1.Appearance = AppMenuAppearance.DropDown;
            if (theme != null)
            {
                C1ThemeController.ApplyThemeToControlTree(this, theme);
                if ( theme.Name.Contains("2016"))
                {
                    this.ribbonApplicationMenu1.Appearance = AppMenuAppearance.WholeForm;
                }
            }
            else
                this.ResetVisualStyle();
            this.ResumePainting();
            this.Activate();
        }

        #endregion
        #region InitializeQatPosition

        private void InitializeQatPosition()
        {
            Properties.Settings settings = Properties.Settings.Default;

            // Initialize QAT position from application settings.
            this.c1Ribbon1.Qat.BelowRibbon = settings.QatBelowRibbon;

            // Update application setting when QAT position changes.
            this.c1Ribbon1.Qat.PositionChanged += delegate
            {
                settings.QatBelowRibbon = this.c1Ribbon1.Qat.BelowRibbon;
            };
        }

        #endregion
        #region Recent Document List

        private RecentDocumentList recentDocuments;

        private void InitializeRecentDocumentList()
        {
            // Create a new collection if it was not serialized before.
            if (Properties.Settings.Default.RecentDocuments == null)
            {
                Properties.Settings.Default.RecentDocuments = new StringCollection();
            }

            this.recentDocuments = new RecentDocumentList(
                this.c1Ribbon1.ApplicationMenu.RightPaneItems,
                Properties.Settings.Default.RecentDocuments,
                this.LoadRecentDocument);
        }

        private void LoadRecentDocument(string filename)
        {
            if (!File.Exists(filename))
            {
                MessageBox.Show("File does not exist: " + filename);
                return;
            }

            if (!this.PromtToSaveDocument()) return;

            this.LoadDocument(filename);
        }

        private class RecentDocumentList
        {
            public delegate void LoadDocumentDelegate(string filename);

            public RecentDocumentList(
                RibbonItemCollection rightPaneItems,
                StringCollection files,
                LoadDocumentDelegate loadDocument)
            {
                this.rightPaneItems = rightPaneItems;
                this.files = files;
                this.loadDocument = loadDocument;

                // first create a header and make sure it's not selectable
                RibbonListItem listItem = new RibbonListItem(new RibbonLabel("Recent Documents"));
                listItem.AllowSelection = false;
                rightPaneItems.Add(listItem);
                rightPaneItems.Add(new RibbonListItem(new RibbonSeparator()));

                this.listTopIndex = rightPaneItems.Count;

                // create the recently used document list
                foreach (string document in this.files)
                {
                    RecentDocumentItem item = new RecentDocumentItem(document, false, loadDocument);
                    rightPaneItems.Add(item);

                    string d = document;
                }
            }

            readonly RibbonItemCollection rightPaneItems;
            readonly StringCollection files;
            readonly LoadDocumentDelegate loadDocument;
            readonly int listTopIndex;

            class RecentDocumentItem : RibbonListItem
            {
                public RecentDocumentItem(string fullFileName, bool pinned, LoadDocumentDelegate loadDocument)
                {
                    this.fullFileName = fullFileName;

                    string documentName = new FileInfo(fullFileName).Name;

                    // each item consists of the name of the document and a push pin
                    this.label = new RibbonLabel(documentName);
                    this.pin = new RibbonToggleButton();

                    // allow the button to be selectable so we can toggle it
                    this.pin.AllowSelection = true;

                    this.pin.Pressed = pinned;
                    this.pin.PressedChanged += delegate { this.SetPinImage(); };
                    this.SetPinImage();

                    this.Items.Add(this.label);
                    this.Items.Add(this.pin);

                    this.ToolTip = fullFileName;

                    this.Click += delegate { loadDocument(this.FullFileName); };
                }

                readonly RibbonLabel label;
                readonly RibbonToggleButton pin;
                readonly string fullFileName;

                void SetPinImage()
                {
                    this.pin.SmallImage = this.pin.Pressed
                        ? Properties.Resources.Pinned
                        : Properties.Resources.Unpinned;
                }

                public string FullFileName
                {
                    get { return this.fullFileName; }
                }

                public bool Pinned
                {
                    get { return this.pin.Pressed; }
                }
            }

            /// <summary>
            /// Adds or moves the file to the top of the list.
            /// </summary>
            /// <param name="filename"> Absolule or relative file path and name. </param>
            public void Update(string filename)
            {
                string fullFileName = new FileInfo(filename).FullName;

                int i = this.IndexOf(fullFileName);
                if (i >= 0)
                {
                    if (this[i].Pinned) return; // do not move pinned items

                    this.RemoveAt(i);
                }

                this.Insert(0, new RecentDocumentItem(fullFileName, false, this.loadDocument));
            }

            private int Count
            {
                get { return this.rightPaneItems.Count - this.listTopIndex; }
            }

            private RecentDocumentItem this[int i]
            {
                get { return (RecentDocumentItem)this.rightPaneItems[this.listTopIndex + i]; }
            }

            private int IndexOf(string fullFileName)
            {
                for (int i = 0; i < this.Count; ++i)
                {
                    if (this[i].FullFileName == fullFileName) return i;
                }
                return -1;
            }

            private void RemoveAt(int i)
            {
                this.rightPaneItems.RemoveAt(this.listTopIndex + i);
                this.files.RemoveAt(i);
            }

            private void Insert(int i, RecentDocumentItem item)
            {
                this.rightPaneItems.Insert(this.listTopIndex + i, item);
                this.files.Insert(i, item.FullFileName);
            }
        }

        #endregion
    }
}