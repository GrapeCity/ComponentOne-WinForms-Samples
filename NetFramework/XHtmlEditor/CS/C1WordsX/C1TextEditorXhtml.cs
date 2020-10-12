using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Text;
using System.Xml;
using C1.Win.C1Editor;

namespace C1WordsX
{
    #region enums

    /// <summary>
    /// Specifies how text in a text range is horizontally aligned.
    /// </summary>
    internal enum TextAlignment
    {
        Default = 0,
        Left = 1,
        Right = 2,
        Center = 3,
        Justify = 4
    }

    /// <summary>
    /// Specifies type of list numbering
    /// </summary>
    internal enum ListNumbering
    {
        Arabic,
        Bullets,
        Lowercase,
        RomanLowercase,
        RomanUppercase,
        Uppercase,
        None
    }

    /// <summary>
    /// Represents change case options
    /// </summary>
    internal enum CharCasing
    {
        SentenceCase,
        LowerCase,
        UpperCase,
        CapitalizeWords,
        ToggleCase
    }

    #endregion

    public class C1RibbonEditorXhtml
    {
        //----------------------------------------------------------------------
        #region ** fields

        private C1Editor _editor;
        private int _newDocumentCounter = 0;
        private XhtmlPrintDocument _doc;

        #endregion

        //----------------------------------------------------------------------
        #region ** ctor

        public C1RibbonEditorXhtml(C1Editor editor)
        {
            _editor = editor;
            _editor.AcceptsTab = true;
        }

        #endregion

        #region common tasks

        internal C1Editor Editor
        {
            get { return _editor; }
        }

        // GetWebBrowser2
        internal object GetWebBrowser2()
        {
            return _editor.GetActiveXInstance();
        }

        /// <summary>
        /// Sets or gets editor mode
        /// </summary>
        internal EditorMode Mode
        {
            get { return _editor.Mode; }
            set { _editor.Mode = value; }
        }

        #endregion common tasks

        #region file operations

        /// <summary>
        /// Clears editor content
        /// </summary>
        internal void Clear()
        {
            string html = string.Format("<html><head><title>New Document {0}</title></head><body><p></p></body></html>", ++_newDocumentCounter);
            _editor.LoadXml(html, null);
        }

        /// <summary>
        /// Loads document from file
        /// </summary>
        /// <param name="fileName">File name</param>
        /// <returns>True if file is loaded</returns>
        internal bool Load(string fileName)
        {
            try
            {
                _editor.Mode = EditorMode.Design;
                if (System.IO.Path.GetExtension(fileName.ToLower()) == ".rtf")
                    _editor.LoadRtf(fileName);
                else
                    _editor.LoadXml(fileName);
                return true;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, Application.ProductName);
                return false;
            }
        }

        /// <summary>
        /// Saves document to file
        /// </summary>
        /// <param name="fileName">File name to save</param>
        /// <returns>True if file is saved</returns>
        internal bool Save(string fileName)
        {
            try
            {
                //replace default document title with fileName
                XmlNamespaceManager nsManager = new XmlNamespaceManager(_editor.Document.NameTable);
                nsManager.AddNamespace("xhtml", _editor.Document.DocumentElement.NamespaceURI);
                XmlNode title = _editor.Document.DocumentElement.SelectSingleNode("//xhtml:head/xhtml:title", nsManager);
                if (title != null && !string.IsNullOrEmpty(title.InnerText) && title.InnerText.StartsWith("New Document"))
                    title.InnerText = System.IO.Path.GetFileNameWithoutExtension(fileName);

                if (System.IO.Path.GetExtension(fileName.ToLower()) == ".rtf")
                    _editor.SaveRtf(fileName);
                else
                    _editor.SaveXml(fileName);
                return true;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message, Application.ProductName);
                return false;
            }
        }

        #endregion file operations

        #region Validate & Fix

        /// <summary>
        /// Validates document in source mode and shows validation errors if found.
        /// </summary>
        /// <returns><b>True</b> if document validated; otherwise, False. </returns>
        internal bool ValidateSource()
        {
            return _editor.ValidateSource();
        }

        /// <summary>
        /// Fixes document in source mode.
        /// </summary>
        internal void FixSource()
        {
            _editor.FixSource();
        }

        /// <summary>
        /// Customizes open/save file dialog
        /// </summary>
        /// <param name="dlg"></param>
        internal void CustomizeFileDialog(FileDialog dlg)
        {
            dlg.DefaultExt = ".htm";
            dlg.AddExtension = true;
            dlg.Filter =
                "XHTML File Format (*.html *.htm)|*.htm;*.html|" +
                "Rich Text Format (*.rtf)|*.rtf|" +
                "All Files (*.*)|*.*";
        }

        #endregion

        #region printing support

        /// <summary>
        /// Returns printing object
        /// </summary>
        internal PrintDocument PrintDocument
        {
            get 
            {
                if (_doc == null)
                {
                    _doc = new XhtmlPrintDocument(_editor);
                }
                return _doc;
            }
        }

        /// <summary>
        /// Prints current document.
        /// </summary>
        /// <param name="selectPrinter">If true, display select printer dialog.</param>
        internal void Print(bool selectPrinter)
        {
            _editor.Print(selectPrinter);
        }

        /// <summary>
        /// Shows print preview dialog.
        /// </summary>
        internal void PrintPreview()
        {
            _editor.PrintPreview();
        }

        /// <summary>
        /// Shows page setup page
        /// </summary>
        internal void PageSetup()
        {
            _editor.ShowDialog(DialogType.PageSetup);
        }

        #endregion printing support

        #region text

        //Sets or gets text of editor document
        internal string Text
        {
            get { return _editor.Text; }
            set { _editor.Text = value; }
        }

        /// <summary>
        /// Inserts page break to current selection
        /// </summary>
        internal void InsertPageBreak()
        {
            C1TextRange range = _editor.Selection;
            range.Start.MoveTo(range.End);
            range.XmlText = "<br style=\"page-break-before: always\"/>";
        }

        #endregion

        #region undo/redo

        /// <summary>
        /// Returns a value that indicates whether the most recent action can be undone.
        /// </summary>
        internal bool CanUndo
        {
            get { return _editor.CanUndo(); }
        }

        /// <summary>
        /// Returns a value that indicates whether the most recent undo action can be redone.
        /// </summary>
        internal bool CanRedo
        {
            get { return _editor.CanRedo(); }
        }

        /// <summary>
        /// Performs Undo action in the current (design or source) editor mode.
        /// </summary>
        internal void Undo()
        {
            _editor.Undo();
        }

        /// <summary>
        /// Performs Redo action in the current (design or source) editor mode.
        /// </summary>
        internal void Redo()
        {
            _editor.Redo();
        }

        #endregion

        #region find/replace

        /// <summary>
        /// Shows find/replace dialog in "find" mode
        /// </summary>
        internal void Find()
        {
            _editor.ShowDialog(DialogType.Find);
        }

        /// <summary>
        /// Shows find/replace dialog in "replace" mode
        /// </summary>
        internal void FindAndReplace()
        {
            _editor.ShowDialog(DialogType.Replace);
        }

        #endregion

        #region clipboard

        /// <summary>
        /// Moves the current selection in the editor to the Clipboard.
        /// </summary>
        internal void Cut()
        {
            _editor.Cut();
        }

        /// <summary>
        /// Copies the current selection in the editor to the Clipboard.
        /// </summary>
        internal void Copy()
        {
            _editor.Copy();
        }

        /// <summary>
        /// Pastes the contents of the Clipboard into the editor
        /// </summary>
        /// <param name="plainText">If true, pastes text only</param>
        internal void Paste(bool plainText)
        {
            if (plainText)
            {
                // paste as plain text
                _editor.PasteAsText();
            }
            else
            {
                // automatically select format
                _editor.Paste();
            }
        }

        /// <summary>
        /// Gets a value indicating whether the cut command is supported on the current selection.
        /// </summary>
        internal bool CanCut
        {
            get { return _editor.CanCut; }
        }

        /// <summary>
        /// Gets a value indicating whether the copy command is supported on the current selection.
        /// </summary>
        internal bool CanCopy
        {
            get { return _editor.CanCopy; }
        }

        /// <summary>
        /// Gets a value indicating whether the paste command is supported on the current selection.
        /// </summary>
        internal bool CanPaste
        {
            get { return _editor.CanPaste; }
        }

        /// <summary>
        /// Determines whether you can paste information from the Clipboard in the text format.
        /// </summary>
        internal bool CanPasteAsText
        {
            get { return _editor.CanPasteAsText; }
        }

        #endregion

        #region selection/formatting

        /// <summary>
        /// Gets or sets index of the first selected character.
        /// </summary>
        internal int SelectionStart
        {
            get { return _editor.SelectionStart; }
            set { _editor.SelectionStart = value; }
        }

        /// <summary>
        /// Gets or sets number of selected characters.
        /// </summary>
        internal int SelectionLength
        {
            get { return _editor.SelectionLength; }
            set { _editor.SelectionLength = value; }
        }

        /// <summary>
        /// Selects text from start text position to specified length
        /// </summary>
        /// <param name="start">Initial text position</param>
        /// <param name="length">Length of selection</param>
        internal void Select(int start, int length)
        {
            _editor.SelectionStart = start;
            _editor.SelectionLength = length;
        }

        /// <summary>
        /// Gets or sets font name of selection
        /// </summary>
        internal string SelectionFontName 
        {
            get { return _editor.Mode == EditorMode.Design ? _editor.Selection.GetStyleValue("font-family") : string.Empty; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    _editor.Selection.RemoveStyle("font-family", null);
                else
                    _editor.Selection.ApplyStyle("font-family", value, C1StyleType.Character);
            }
        }

        /// <summary>
        /// Gets or sets font size of selection
        /// </summary>
        internal string SelectionFontSize
        {
            get
            {
                if (_editor.Mode == EditorMode.Design)
                {
                    string size = _editor.Selection.GetStyleValue("font-size") ?? string.Empty;
                    return size.EndsWith("pt") ? size.Substring(0, size.Length - 2) : size;
                }
                else
                    return string.Empty;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                    _editor.Selection.RemoveStyle("font-size", null);
                else
                    _editor.Selection.ApplyStyle("font-size", value + (value.EndsWith("pt") ? "" : "pt"), C1StyleType.Character);
            }
        }

        /// <summary>
        /// Gets true if tags "strong" or "b" applied to selection
        /// Sets "strong" tag to selection
        /// </summary>
        internal bool SelectionFontBold
        {
            get
            {
                return Mode == EditorMode.Design ?
                    (_editor.Selection.IsTagApplied("strong") || _editor.Selection.IsTagApplied("b")) : 
                    false;
            }
            set
            {
                if (value)
                {
                    _editor.Selection.ApplyTag("strong");
                }
                else
                {
                    _editor.BeginTransaction("Remove style");
                    try
                    {
                        _editor.Selection.RemoveTag("strong");
                        _editor.Selection.RemoveTag("b");
                        _editor.CommitTransaction();
                    }
                    catch
                    {
                        _editor.RollbackTransaction();
                    }
                }
            }
        }

        /// <summary>
        /// Gets true if tags "em" or "i" applied to selection
        /// Sets "em" tag to selection
        /// </summary>
        internal bool SelectionFontItalic
        {
            get
            {
                return Mode == EditorMode.Design ?
                    (_editor.Selection.IsTagApplied("em") || _editor.Selection.IsTagApplied("i")) : 
                    false;
            }
            set
            {
                if (value)
                {
                    _editor.Selection.ApplyTag("em");
                }
                else
                {
                    _editor.BeginTransaction("Remove style");
                    try
                    {
                        _editor.Selection.RemoveTag("em");
                        _editor.Selection.RemoveTag("i");
                        _editor.CommitTransaction();
                    }
                    catch
                    {
                        _editor.RollbackTransaction();
                    }
                }
            }
        }

        /// <summary>
        /// Gets true if style attribute "text-decoration:line-through" or tag "strike" applied to selection
        /// Sets style attribute "text-decoration:line-through" to selection
        /// </summary>
        internal bool SelectionFontStrikethrough
        {
            get
            {
                if (_editor.Mode == EditorMode.Design)
                {
                    bool res = _editor.Selection.IsTagApplied("strike");
                    if (!res && _editor.Selection.IsStyleApplied("text-decoration"))
                        res = string.Compare(_editor.Selection.GetStyleValue("text-decoration", C1StyleType.Character), "line-through", true) == 0;
                    return res;
                }
                else
                    return false;
            }
            set
            {
                if (value)
                {
                    _editor.Selection.ApplyStyle("text-decoration", "line-through", C1StyleType.Character);
                }
                else
                {
                    _editor.BeginTransaction("Remove style");
                    try
                    {
                        _editor.Selection.RemoveStyle("text-decoration", null);
                        _editor.Selection.RemoveTag("strike");
                        _editor.CommitTransaction();
                    }
                    catch
                    {
                        _editor.RollbackTransaction();
                    }
                }
            }
        }

        /// <summary>
        /// Gets true if style attribute "text-decoration:underline" or tag "u" applied to selection
        /// Sets style attribute "text-decoration:underline" to selection
        /// </summary>
        internal bool SelectionFontUnderline
        {
            get
            {
                if (_editor.Mode == EditorMode.Design)
                {
                    bool res = _editor.Selection.IsTagApplied("u");
                    if (!res && _editor.Selection.IsStyleApplied("text-decoration"))
                        res = string.Compare(_editor.Selection.GetStyleValue("text-decoration", C1StyleType.Character), "underline", true) == 0;
                    return res;
                }
                else
                    return false;
            }
            set
            {
                if (value)
                {
                    _editor.Selection.ApplyStyle("text-decoration", "underline", C1StyleType.Character);
                }
                else
                {
                    _editor.BeginTransaction("Remove style");
                    try
                    {
                        _editor.Selection.RemoveStyle("text-decoration", null);
                        _editor.Selection.RemoveTag("u");
                        _editor.CommitTransaction();
                    }
                    catch
                    {
                        _editor.RollbackTransaction();
                    }
                }
            }
        }

        /// <summary>
        /// Gets true if tag "big" applied to selection
        /// Sets "big" tag to selection
        /// </summary>
        internal bool SelectionFontBig
        {
            get { return Mode == EditorMode.Design ? _editor.Selection.IsTagApplied("big") : false; }
            set
            {
                if (value)
                {
                    _editor.BeginTransaction("Apply style");
                    try
                    {
                        _editor.Selection.RemoveTag("small");
                        _editor.Selection.ApplyTag("big");
                        _editor.CommitTransaction();
                    }
                    catch
                    {
                        _editor.RollbackTransaction();
                    }
                }
                else
                    _editor.Selection.RemoveTag("big");
            }
        }

        /// <summary>
        /// Gets true if tag "small" applied to selection
        /// Sets "small" tag to selection
        /// </summary>
        internal bool SelectionFontSmall
        {
            get { return Mode == EditorMode.Design ? _editor.Selection.IsTagApplied("small") : false; }
            set
            {
                if (value)
                {
                    _editor.BeginTransaction("Apply style");
                    try
                    {
                        _editor.Selection.RemoveTag("big");
                        _editor.Selection.ApplyTag("small");
                        _editor.CommitTransaction();
                    }
                    catch
                    {
                        _editor.RollbackTransaction();
                    }

                }
                else
                    _editor.Selection.RemoveTag("small");
            }
        }

        /// <summary>
        /// Gets color from current selection's style attribute "color"
        /// Sets color to current selection's style attribute "color"
        /// </summary>
        internal Color SelectionColor
        {
            get
            {
                if (_editor.Mode == EditorMode.Design)
                {
                    string foreColor = _editor.Selection.GetStyleValue("color", C1StyleType.Character);
                    return System.Drawing.ColorTranslator.FromHtml(foreColor);
                }
                else
                    return Color.Empty;
            }
            set
            {
                if (value.IsEmpty)
                    _editor.Selection.RemoveStyle("color", null);
                else
                {
                    string foreColor = System.Drawing.ColorTranslator.ToHtml(value);
                    _editor.Selection.ApplyStyle("color", foreColor, C1StyleType.Character);
                }
            }
        }

        /// <summary>
        /// Gets color from current selection's style attribute "background-color"
        /// Sets color to current selection's style attribute "background-color"
        /// </summary>
        internal Color SelectionBackColor
        {
            get
            {
                if (_editor.Mode == EditorMode.Design)
                {
                    string backColor = _editor.Selection.GetStyleValue("background-color", C1StyleType.Character);
                    return System.Drawing.ColorTranslator.FromHtml(backColor);
                }
                else
                    return Color.Empty;
            }
            set
            {
                if (value.IsEmpty)
                    _editor.Selection.RemoveStyle("background-color", null);
                else
                {
                    string backColor = System.Drawing.ColorTranslator.ToHtml(value);
                    _editor.Selection.ApplyStyle("background-color", backColor, C1StyleType.Character);
                }
            }
        }

        /// <summary>
        /// Gets color from current selection's paragraph style attribute "background-color"
        /// Sets color to current selection's paragragh style attribute "background-color"
        /// </summary>
        internal Color SelectionParagraphColor
        {
            get 
            {
                if (_editor.Mode == EditorMode.Design)
                {
                    string htmlColor = _editor.Selection.GetStyleValue("background-color", C1StyleType.Paragraph);
                    return ColorTranslator.FromHtml(htmlColor);
                }
                else
                    return Color.Empty;
            }
            set 
            {
                string htmlColor = ColorTranslator.ToHtml(value);
                _editor.Selection.ApplyStyle("background-color", htmlColor, C1StyleType.Paragraph);
            }
        }

        /// <summary>
        /// Gets line spacing from current selection's paragraph style attribute "line-height"
        /// Sets line spacing to current selection's paragragh style attribute "line-height"
        /// </summary>
        internal float SelectionLineSpacing
        {
            get
            {
                if (_editor.Mode == EditorMode.Design)
                {
                    float lsp = 1f;
                    string lineSpacing = _editor.Selection.GetStyleValue("line-height");
                    if (string.IsNullOrEmpty(lineSpacing))
                        return 1f;

                    if (float.TryParse(lineSpacing, out lsp))
                        return lsp / 100;
                    return 1f;
                }
                else
                    return 1f;
            }
            set
            {
                _editor.Selection.ApplyStyle("line-height", (value * 100).ToString() + "%", C1StyleType.Paragraph); 
            }
        }

        /// <summary>
        /// Gets or sets selected text
        /// </summary>
        internal string SelectedText
        {
            get { return Mode == EditorMode.Design ? _editor.Selection.Text : string.Empty; }
            set 
            {
                C1TextRange range = _editor.Selection.Clone();
                range.Text = value;
                //after inserting text we must collapse selection to the end
                range.Normalize();
                range.Start.MoveTo(range.End);
                range.Select();
            }
        }

        /// <summary>
        /// Gets text alignment from current selection's paragraph style attribute "text-align"
        /// Sets text alignment to current selection's paragragh style attribute "text-align"
        /// </summary>
        internal TextAlignment SelectionAlignment
        {
            get
            {
                if (_editor.Mode == EditorMode.Design)
                {
                    string textAlign = _editor.Selection.GetStyleValue("text-align");
                    if (String.Compare(textAlign, "center") == 0)
                        return TextAlignment.Center;
                    else if (String.Compare(textAlign, "right") == 0)
                        return TextAlignment.Right;
                    else if (String.Compare(textAlign, "left") == 0)
                        return TextAlignment.Left;
                    else if (String.Compare(textAlign, "justify") == 0)
                        return TextAlignment.Justify;
                    else
                        return TextAlignment.Default;
                }
                else
                    return TextAlignment.Default;
            }
            set
            {
                switch (value)
                {
                    case TextAlignment.Left:
                        _editor.Selection.ApplyStyle("text-align", "left", C1StyleType.Paragraph);
                        break;
                    case TextAlignment.Center:
                        _editor.Selection.ApplyStyle("text-align", "center", C1StyleType.Paragraph);
                        break;
                    case TextAlignment.Right:
                        _editor.Selection.ApplyStyle("text-align", "right", C1StyleType.Paragraph);
                        break;
                    case TextAlignment.Justify:
                        _editor.Selection.ApplyStyle("text-align", "justify", C1StyleType.Paragraph);
                        break;
                    default:
                        _editor.Selection.RemoveStyle("text-align", null);
                        break;
                }
            }
		}

        /// <summary>
        /// Gets numbering type of current selection's paragraphs
        /// Sets numbering type to current selection's paragraghs
        /// </summary>
        internal ListNumbering SelectionNumbering
        {
            get
            {
                if (_editor.Mode == EditorMode.Design)
                {
                    bool orderedList = _editor.Selection.IsTagApplied("ol");
                    bool unorderedList = _editor.Selection.IsTagApplied("ul");
                    if (orderedList && !unorderedList)
                        return ListNumbering.Arabic;
                    else if (unorderedList && !orderedList)
                        return ListNumbering.Bullets;
                    else
                        return ListNumbering.None;
                }
                else
                    return ListNumbering.None;
            }
            set
            {
                _editor.BeginTransaction("Apply style");
                try
                {
                    _editor.Selection.RemoveTag("ol");
                    _editor.Selection.RemoveTag("ul");
                    switch (value)
                    {
                        case ListNumbering.Arabic:
                        case ListNumbering.Lowercase:
                        case ListNumbering.RomanLowercase:
                        case ListNumbering.RomanUppercase:
                        case ListNumbering.Uppercase:
                            _editor.Selection.ApplyTag("ol");
                            break;
                        case ListNumbering.Bullets:
                            _editor.Selection.ApplyTag("ul");
                            break;
                    }
                    _editor.CommitTransaction();
                }
                catch
                {
                    _editor.RollbackTransaction();
                }
            }
        }

        /// <summary>
        /// Gets true if tag "sup" applied to selection
        /// Sets "sup" tag to selection
        /// </summary>
        internal bool SelectionSuperscript
        {
            get { return Mode == EditorMode.Design ? _editor.Selection.IsTagApplied("sup") : false; }
            set
            {
                if (value)
                {
                    _editor.Selection.RemoveTag("sub");
                    _editor.Selection.ApplyTag("sup");
                }
                else
                    _editor.Selection.RemoveTag("sup");
            }
        }

        /// <summary>
        /// Gets true if tag "sub" applied to selection
        /// Sets "sub" tag to selection
        /// </summary>
        internal bool SelectionSubscript 
        {
            get { return Mode == EditorMode.Design ? _editor.Selection.IsTagApplied("sub") : false; }
            set
            {
                if (value)
                {
                    _editor.Selection.RemoveTag("sup");
                    _editor.Selection.ApplyTag("sub");
                }
                else
                    _editor.Selection.RemoveTag("sub");
            }
        }

        /// <summary>
        /// Clears selection formatting
        /// </summary>
        internal void ClearFontFormatting()
        {
            _editor.Selection.ClearFormatting();
        }

        /// <summary>
        /// Sets character case to selection by setting "text-transform" attribute
        /// </summary>
        /// <param name="casing"></param>
        internal void SelectionChangeCase(CharCasing casing)
        {
            if (casing == CharCasing.CapitalizeWords)
                _editor.Selection.ApplyStyle("text-transform", "capitalize", C1StyleType.Character);
            else if (casing == CharCasing.LowerCase)
                _editor.Selection.ApplyStyle("text-transform", "lowercase", C1StyleType.Character);
            else if (casing == CharCasing.UpperCase)
                _editor.Selection.ApplyStyle("text-transform", "uppercase", C1StyleType.Character);
        }

        /// <summary>
        /// Returns true, if the selection
        /// </summary>
        internal bool IsSelectionInsideList()
        {
            bool res = false;
            XmlNode start = Editor.Selection.Start.Node;
            XmlNode end = Editor.Selection.End.Node;

            while (start != null && !string.Equals(start.Name, "li"))
                start = start.ParentNode;
            while (end != null && !string.Equals(end.Name, "li"))
                end = end.ParentNode;

            if (start != null && end != null)
            {
                if (start == end)
                    res = true;
                else
                {
                    XmlNode parent = GetCommonParent(start, end);
                    if (start == parent || end == parent)
                        parent = parent.ParentNode;
                    res = parent != null && (string.Equals(parent.Name, "ol") || string.Equals(parent.Name, "ul"));
                }
            }

            return res;
        }

        /// <summary>
        /// Increase the indent level of the selected paragraphs.
        /// </summary>
        internal void IncreaseIndent()
        {
            _editor.BeginTransaction("Apply style");
            try
            {
                List<XmlNode> paragraphs = _editor.Selection.GetTags(C1StyleType.Paragraph, true);
                XmlDocument doc = _editor.Document;
                foreach (XmlNode node in paragraphs)
                {
                    XmlNode newNode = doc.CreateElement("blockquote", doc.DocumentElement.NamespaceURI);
                    node.ParentNode.InsertAfter(newNode, node);
                    newNode.AppendChild(node);
                }
                _editor.CommitTransaction();
            }
            catch
            {
                _editor.RollbackTransaction();
            }
        }

        /// <summary>
        /// Decrease the indent level of the selected paragraphs.
        /// </summary>
        internal void DecreaseIndent()
        {
            _editor.BeginTransaction("Remove style");
            try
            {
                List<XmlNode> nodes = _editor.Selection.GetTags(C1StyleType.Paragraph, true);
                
                XmlDocument doc = _editor.Document;
                for (int i = 0; i < nodes.Count; i++)
                {
                    XmlNode node = nodes[i];
                    while (node != null && !string.Equals(node.Name, "blockquote"))
                        node = node.ParentNode;

                    if (node != null && string.Equals(node.Name, "blockquote"))
                    {
                        while (node.HasChildNodes)
                            node.ParentNode.InsertBefore(node.FirstChild, node);
                        node.ParentNode.RemoveChild(node);
                    }
                }
                _editor.CommitTransaction();
            }
            catch
            {
                _editor.RollbackTransaction();
            }
        }

        #endregion

        #region table, image, flash, links

        /// <summary>
        /// Shows picture dialog and inserts/edits picture
        /// </summary>
        internal void InsertPicture()
        {
            _editor.ShowDialog(DialogType.Image);
        }

        /// <summary>
        /// Shows flash movie dialog and inserts/edits flash movie
        /// </summary>
        internal void InsertFlashMovie()
        {
            _editor.ShowDialog(DialogType.FlashMovie);
        }

        /// <summary>
        /// Shows hyperlink dialog and inserts/edits hyperlink
        /// </summary>
        internal void InsertHyperlink()
        {
            _editor.ShowDialog(DialogType.Hyperlink);
        }

        /// <summary>
        /// Shows bookmark dialog and inserts/edits bookmark
        /// </summary>
        internal void InsertBookmark()
        {
            _editor.ShowDialog(DialogType.Bookmark);
        }

        /// <summary>
        /// Shows table dialog and inserts/edits table
        /// </summary>
        internal void InsertTable()
        {
            _editor.ShowDialog(DialogType.NewTable);
        }

        /// <summary>
        /// Inserts table row above current selected cell
        /// </summary>
        internal void InsertTableRowAbove()
        {
            _editor.Selection.Table.Execute(Table.Action.InsertRowAbove);
        }

        /// <summary>
        /// Inserts table row below current selected cell
        /// </summary>
        internal void InsertTableRowBelow()
        {
            _editor.Selection.Table.Execute(Table.Action.InsertRowBelow);
        }

        /// <summary>
        /// Inserts table column before current selected cell
        /// </summary>
        internal void InsertTableColumnBefore()
        {
            _editor.Selection.Table.Execute(Table.Action.InsertColumnBefore);
        }

        /// <summary>
        /// Inserts table column after current selected cell
        /// </summary>
        internal void InsertTableColumnAfter()
        {
            _editor.Selection.Table.Execute(Table.Action.InsertColumnAfter);
        }

        /// <summary>
        /// Deletes selected table
        /// </summary>
        internal void DeleteTable()
        {
            _editor.Selection.Table.Execute(Table.Action.DeleteTable);
        }

        /// <summary>
        /// Deletes selected table rows
        /// </summary>
        internal void DeleteTableRows()
        {
            _editor.Selection.Table.Execute(Table.Action.DeleteRows);
        }

        /// <summary>
        /// Deletes selected table columns
        /// </summary>
        internal void DeleteTableColumns()
        {
            _editor.Selection.Table.Execute(Table.Action.DeleteColumns);
        }

        /// <summary>
        /// Shows table properties dialog, edits table properties
        /// </summary>
        internal void TableProperties()
        {
            _editor.Selection.Table.ShowDialog(Table.DialogType.Table);
        }

        /// <summary>
        /// Shows table row properties dialog, edits table row properties
        /// </summary>
        internal void TableRowProperties()
        {
            _editor.Selection.Table.ShowDialog(Table.DialogType.Row);
        }

        /// <summary>
        /// Shows table column properties dialog, edits table column properties
        /// </summary>
        internal void TableColumnProperties()
        {
            _editor.Selection.Table.ShowDialog(Table.DialogType.Column);
        }

        /// <summary>
        /// Shows table cell properties dialog, edits table cell properties
        /// </summary>
        internal void TableCellProperties()
        {
            _editor.Selection.Table.ShowDialog(Table.DialogType.Cell);
        }

        /// <summary>
        /// Returns true if picture can be inserted to current selection
        /// </summary>
        internal bool InsertPictureEnabled
        {
           get { return _editor.CanShowDialog(DialogType.Image); }
        }

        /// <summary>
        /// Returns true if flash movie can be inserted to current selection
        /// </summary>
        internal bool InsertFlashMovieEnabled
        {
            get { return _editor.CanShowDialog(DialogType.FlashMovie); }
        }

        /// <summary>
        /// Returns true if hyperlink can be inserted to current selection
        /// </summary>
        internal bool InsertHyperlinkEnabled
        {
            get { return _editor.CanShowDialog(DialogType.Hyperlink); }
        }

        /// <summary>
        /// Returns true if bookmark can be inserted to current selection
        /// </summary>
        internal bool InsertBookmarkEnabled
        {
            get { return _editor.CanShowDialog(DialogType.Bookmark); }
        }

        /// <summary>
        /// Returns true if table can be inserted to current selection
        /// </summary>
        internal bool InsertTableEnabled
        {
            get { return _editor.CanShowDialog(DialogType.NewTable); }
        }

        /// <summary>
        /// Returns true if table row can be inserted to current selection
        /// </summary>
        internal bool InsertTableRowEnabled
        {
            get
            {
                if (_editor.Mode == EditorMode.Design && _editor.Selection.Table != null)
                    return _editor.Selection.Table.CanExecute(Table.Action.InsertRowAbove);
                else
                    return false;
            }
        }

        /// <summary>
        /// Returns true if table column can be inserted to current selection
        /// </summary>
        internal bool InsertTableColumnEnabled
        {
            get
            {
                if (_editor.Mode == EditorMode.Design && _editor.Selection.Table != null)
                    return _editor.Selection.Table.CanExecute(Table.Action.InsertColumnAfter);
                else
                    return false;
            }
        }

        /// <summary>
        /// Returns true if table can be deleted
        /// </summary>
        internal bool DeleteTableEnabled
        {
            get
            {
                if (_editor.Mode == EditorMode.Design && _editor.Selection.Table != null)
                    return _editor.Selection.Table.CanExecute(Table.Action.DeleteTable);
                else
                    return false;
            }
        }

        /// <summary>
        /// Returns true if table rows can be deleted
        /// </summary>
        internal bool DeleteTableRowsEnabled
        {
            get
            {
                if (_editor.Mode == EditorMode.Design && _editor.Selection.Table != null)
                    return _editor.Selection.Table.CanExecute(Table.Action.DeleteRows);
                else
                    return false;
            }
        }

        /// <summary>
        /// Returns true if table columns can be deleted
        /// </summary>
        internal bool DeleteTableColumnsEnabled
        {
            get
            {
                if (_editor.Mode == EditorMode.Design && _editor.Selection.Table != null)
                    return _editor.Selection.Table.CanExecute(Table.Action.DeleteColumns);
                else
                    return false;
            }
        }

        /// <summary>
        /// Returns true if table properties dialog can be shown
        /// </summary>
        internal bool TablePropertiesEnabled
        {
            get
            {
                if (_editor.Mode == EditorMode.Design && _editor.Selection.Table != null)
                    return _editor.Selection.Table.CanShowDialog(Table.DialogType.Table);
                else
                    return false;
            }
        }

        /// <summary>
        /// Returns true if table row properties dialog can be shown
        /// </summary>
        internal bool TableRowPropertiesEnabled
        {
            get
            {
                if (_editor.Mode == EditorMode.Design && _editor.Selection.Table != null)
                    return _editor.Selection.Table.CanShowDialog(Table.DialogType.Row);
                else
                    return false;
            }
        }

        /// <summary>
        /// Returns true if table column properties dialog can be shown
        /// </summary>
        internal bool TableColumnPropertiesEnabled
        {
            get
            {
                if (_editor.Mode == EditorMode.Design && _editor.Selection.Table != null)
                    return _editor.Selection.Table.CanShowDialog(Table.DialogType.Column);
                else
                    return false;
            }
        }

        /// <summary>
        /// Returns true if table cell properties dialog can be shown
        /// </summary>
        internal bool TableCellPropertiesEnabled
        {
            get
            {
                if (_editor.Mode == EditorMode.Design && _editor.Selection.Table != null)
                    return _editor.Selection.Table.CanShowDialog(Table.DialogType.Cell);
                else
                    return false;
            }
        }

        #endregion

        #region implementation

        private XmlNode GetCommonParent(XmlNode node1, XmlNode node2)
        {
            if (node1 == null)
                return node2;
            if (node2 == null)
                return node1;
            XmlNode commonNode = null;
            if (node1 != node2)
            {
                XmlNode documentElement = node1.OwnerDocument.DocumentElement;
                XmlNode node = null;
                List<XmlNode> node1Parents = new List<XmlNode>();
                node = node1;
                while (node != null && node != documentElement)
                {
                    node1Parents.Insert(0, node);
                    node = node.ParentNode;
                }

                List<XmlNode> node2Parents = new List<XmlNode>();
                node = node2;
                while (node != null && node != documentElement)
                {
                    node2Parents.Insert(0, node);
                    node = node.ParentNode;
                }

                int length = Math.Min(node1Parents.Count, node2Parents.Count);
                for (int i = 0; i < length; i++)
                {
                    if (node1Parents[i] != node2Parents[i])
                        break;
                    else
                        commonNode = node1Parents[i];
                }
            }
            else
            {
                commonNode = node1;
            }

            return commonNode;
        }

        #endregion

    }
}
