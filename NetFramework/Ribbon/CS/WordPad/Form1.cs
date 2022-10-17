using C1.Win.C1Themes;
using C1.Win.Ribbon;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WordPad.BackstageTabs;
using WordPad.Properties;

namespace WordPad
{
    public partial class Form1 : C1RibbonForm
    {
        public Form1()
        {
            InitializeComponent();

            InitializeClipboardGroup();
            InitializeFontGroup();
            InitializeParagraphGroup();
            InitializeViewZoomGroup();

            InitializeRibbonStyleMenu();
            InitializeFocusManagement();
            InitializeUndoRedo();
            InitializeModifiedIcon();
            InitializeQatPosition();

            _rdlOpened = new RecentDocumentList(Settings.Default.OpenedFiles);
            _rdlSaved = new RecentDocumentList(Settings.Default.SavedFiles);

            // Load a sample text file into the editor.
            this.LoadDocument(@"Readme.rtf");

            // Save application settings on exit.
            this.FormClosed += delegate { Properties.Settings.Default.Save(); };

            var openTab = new OpenTab
            {
                Owner = this,
                View = c1BackstageView1
            };
            OpenDocumentTab.Control = openTab;

            var saveAsTab = new SaveAsTab
            {
                Owner = this,
                View = c1BackstageView1
            };
            SaveDocumentAsTab.Control = saveAsTab;

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
            this.c1Ribbon1.RibbonEvent += c1Ribbon1_RibbonEvent;
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

        #region Icon

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

        #endregion

        #region Backstage Menu, Document-level functions (Open, Save, etc)

        RecentDocumentList _rdlOpened;
        RecentDocumentList _rdlSaved;

        /// <summary>
        /// The file name of the document, such as "Document.rtf"
        /// </summary>
        string _documentName = @"Readme.rtf";
        
        private void NewDocumentButton_Click(object sender, EventArgs e)
        {
            if (!PromtToSaveDocument())
                return;

            CreateNewDocument();
        }

        private void SaveDocumentButton_Click(object sender, EventArgs e)
        {
            SaveDocument();
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
            if (!richTextBox1.Modified)
                return true;

            DialogResult dr = MessageBox.Show("Do you want to save '" + _documentName + "'?", "WordPad Sample", MessageBoxButtons.YesNoCancel);

            switch (dr)
            {
                case DialogResult.Cancel:
                    return false;

                case DialogResult.No:
                    return true;

                case DialogResult.Yes:
                    return SaveDocument();
            }

            throw new ApplicationException();
        }

        /// <summary>
        /// Replaces the current document with a new empty document.
        /// </summary>
        private void CreateNewDocument()
        {
            richTextBox1.Clear();
            _documentName = "Document";

            RaiseRichTextBoxSelectionChanged();
        }

        private void LoadDocument(string filePathName)
        {
            RichTextBoxStreamType streamType = filePathName.EndsWith(".rtf")
                    ? RichTextBoxStreamType.RichText
                    : RichTextBoxStreamType.PlainText;
            try
            {
                this.richTextBox1.LoadFile(filePathName, streamType);
                //this.SetDocumentProperties(filePathName, streamType);
                //this.recentDocuments.Update(filePathName);
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

        public bool SaveDocument() => SaveDocument(_documentName);

        public bool SaveDocument(string fileName)
        {
            // no file name? defer to SaveAs to prompt
            if (string.IsNullOrEmpty(fileName))
            {
                return SaveDocumentAs();
            }

            richTextBox1.SaveFile(fileName);
            richTextBox1.Modified = false;
                        
            return true;
        }
        
        public bool SaveDocumentAs()
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.FileName = _documentName;
                //if (documentPath != null) dlg.InitialDirectory = this.documentPath;
                dlg.Filter = "Rich text file (*.rtf)|*.rtf|"
                    + "Rich text file, no OLE objects (*.rtf)|*.rtf|"
                    + "Plain text file, no OLE objects (*.txt)|*.txt|"
                    + "Plain text file, OLE objects replaced with text (*.txt)|*.txt|"
                    + "Unicode text file, no OLE objects (*.txt)|*.txt";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _documentName = dlg.FileName;
                    _rdlSaved.AddDocument(_documentName);
                    return SaveDocument();
                }
            }
            return false;
        }

        public void OpenDocument()
        {
            if (!PromtToSaveDocument())
                return;

            using (var dlg = new OpenFileDialog())
            {
                dlg.Filter = "Supported files (*.rtf, *.txt)|*.rtf;*.txt|" + "All files (*.*)|*.*";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    OpenDocument(dlg.FileName);
                }
            }
        }        

        public void OpenDocument(string fileName)
        {
            if (!PromtToSaveDocument())
                return;

            richTextBox1.LoadFile(fileName);
            _documentName = fileName;
            _rdlOpened.AddDocument(fileName);
        }

        private void c1BackstageView1_DropDown(object sender, EventArgs e)
        {
            ((BackstageTabs.Items.BackstageTab)OpenDocumentTab.Control).LoadItems(_rdlOpened.RecentDocuments);
            // load saved docs
            ((BackstageTabs.Items.BackstageTab)SaveDocumentAsTab.Control).LoadItems(_rdlSaved.RecentDocuments);
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
            if (theme != null)
            {
                C1ThemeController.ApplyThemeToControlTree(this, theme);
            }
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

        #region ** Text Style Gallery
        private void StyleGallery_HighlightedItemChanged(object sender, GalleryEventArgs e)
        {
            if (e.GalleryItem == null)
            {
                if (!styleGallery.DroppedDown)
                {
                    UpdateStyle(styleGallery.SelectedIndex);
                }
            }
            else
            {
                UpdateStyle(styleGallery.Items.IndexOf(e.GalleryItem));
            }
        }

        private void StyleGallery_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStyle(styleGallery.SelectedIndex);
        }

        private void UpdateStyle(int index)
        {
            ClearFormatting();
            this.richTextBox1.SelectionBackColor = SystemColors.Window;

            // select current paragraph
            int c = richTextBox1.SelectionStart;
            int parStart = richTextBox1.Text.LastIndexOf("\n", c);
            parStart = parStart < 0 ? 0 : parStart + 1;
            int parEnd = richTextBox1.SelectedText.EndsWith("\n") ?
                c + richTextBox1.SelectionLength
                : richTextBox1.Text.IndexOf("\n", c + richTextBox1.SelectionLength);
            parEnd = parEnd < 0 ? richTextBox1.Text.Length - 1 : parEnd;
            richTextBox1.Select(parStart, parEnd - parStart);

            switch (index)
            {
                // Common
                case 0: // Normal
                    this.richTextBox1.SelectionFont = new Font("Calibri", 11, FontStyle.Regular);
                    this.richTextBox1.SelectionColor = SystemColors.WindowText;
                    break;
                case 1: // Heading 1
                    this.richTextBox1.SelectionFont = new Font("Calibri Light", 16, FontStyle.Bold);
                    this.richTextBox1.SelectionColor = Color.FromArgb(0, 68, 114, 196);
                    break;
                case 2: // Heading 2
                    this.richTextBox1.SelectionFont = new Font("Calibri Light", 14, FontStyle.Bold);
                    this.richTextBox1.SelectionColor = Color.FromArgb(0, 68, 114, 196);
                    break;
                case 3: // Title
                    this.richTextBox1.SelectionFont = new Font("Calibri Light", 16, FontStyle.Bold);
                    this.richTextBox1.SelectionColor = SystemColors.WindowText;
                    this.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                    break;
                case 4: // Subtitle
                    this.richTextBox1.SelectionFont = new Font("Calibri Light", 12, FontStyle.Regular);
                    this.richTextBox1.SelectionColor = Color.FromArgb(0, 90, 90, 90);
                    this.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                    break;
                // Extended
                case 5: // Emphasis
                    this.richTextBox1.SelectionFont = new Font("Calibri", 11, FontStyle.Italic);
                    this.richTextBox1.SelectionColor = Color.FromArgb(0, 90, 90, 90);
                    break;
                case 6: // Intense Emphasis
                    this.richTextBox1.SelectionFont = new Font("Calibri", 11, FontStyle.Italic);
                    this.richTextBox1.SelectionColor = Color.FromArgb(0, 68, 114, 196);
                    break;
                case 7: // Strong
                    this.richTextBox1.SelectionFont = new Font("Calibri", 11, FontStyle.Bold);
                    this.richTextBox1.SelectionColor = SystemColors.WindowText;
                    break;
                case 8: // Quote
                    this.richTextBox1.SelectionFont = new Font("Calibri", 11, FontStyle.Italic);
                    this.richTextBox1.SelectionColor = SystemColors.WindowText;
                    this.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                    break;
                case 9: // Intense Quote
                    this.richTextBox1.SelectionFont = new Font("Calibri", 11, FontStyle.Italic);
                    this.richTextBox1.SelectionColor = Color.FromArgb(0, 68, 114, 196);
                    this.richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
                    break;
                case 10: // Bullet List
                    this.richTextBox1.SelectionBullet = true;
                    this.richTextBox1.SelectionColor = SystemColors.WindowText;
                    break;
            }

            UpdateParagraphGroupBasedOnCurrentTextSelection();
            UpdateFontGroupBasedOnCurrentTextSelection();
        }

        private void ClearFormatting()
        {
            this.richTextBox1.SelectionIndent = 0;
            this.richTextBox1.SelectionHangingIndent = 0;
            this.richTextBox1.SelectionColor = this.richTextBox1.ForeColor;
            this.richTextBox1.SelectionBackColor = Color.Transparent;
            this.richTextBox1.SelectionFont = this.richTextBox1.Font;
            this.richTextBox1.SelectionBullet = false;
            this.richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
            UpdateParagraphGroupBasedOnCurrentTextSelection();
            UpdateFontGroupBasedOnCurrentTextSelection();

        }
        private void ClearFormatButton_Click(object sender, EventArgs e)
        {
            ClearFormatting();
        }

        // show gallery as collapsed in Simplified view
        private void c1Ribbon1_ViewChanged(object sender, EventArgs e)
        {
            this.styleGallery.Expanded = c1Ribbon1.ViewMode == ViewMode.Full;
        }
        #endregion

    }
}