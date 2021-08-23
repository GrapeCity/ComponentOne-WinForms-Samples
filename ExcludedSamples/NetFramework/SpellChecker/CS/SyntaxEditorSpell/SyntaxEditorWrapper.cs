using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using C1.Win.C1SpellChecker;
using ActiproSoftware.SyntaxEditor;

namespace SpellEditor
{
    /// <summary>
    /// Class that wraps a SyntaxEditor and implements the ISpellCheckableRichEditor 
    /// interface.
    /// </summary>
    public class SyntaxEditorWrapper: ISpellCheckableRichEditor
    {
        #region ** fields
        readonly SyntaxEditor _editor;
        #endregion

        #region ** ctor
        public SyntaxEditorWrapper(SyntaxEditor editor)
        {
            _editor = editor;
        }
        #endregion

        #region ** ISpellCheckableEditor
        Control ISpellCheckableEditor.Control
        {
            get
            {
                return this._editor;
            }
        }

        //     control remains highlighted when the control loses focus.
        bool ISpellCheckableEditor.HideSelection
        {
            get
            {
                return false;
            }
            set
            {
            }
        }

        //     Gets or sets the text that is selected in the editor.
        string ISpellCheckableEditor.SelectedText
        {
            get
            {
                return _editor.SelectedView.SelectedText;
            }
            set
            {
                _editor.SelectedView.ReplaceSelectedText(DocumentModificationType.Replace, value);
            }
        }

        //     Gets or sets the length of text selected in the editor.
        int ISpellCheckableEditor.SelectionLength
        {
            get
            {
                return _editor.SelectedView.Selection.Length;
            }
            set
            {
                _editor.SelectedView.Selection.Collapse();
                _editor.SelectedView.Selection.SelectWord();
            }
        }

        //     Gets or sets the starting index of text selected in the editor.
        int ISpellCheckableEditor.SelectionStart
        {
            get
            {
                return _editor.SelectedView.Selection.StartOffset;
            }
            set
            {
                _editor.SelectedView.Selection.StartOffset = value;
            }
        }

        //     Gets or sets the text in the editor.
        string ISpellCheckableEditor.Text
        {
            get
            {
                // !not just _editor.Text
                // to be consistent with GetCharacterBounds function
                return _editor.Document.GetText(LineTerminator.CarriageReturn);
            }
            set
            {
                _editor.Text = value;
            }
        }

        void ISpellCheckableEditor.BeginSpell()
        {
        }
        void ISpellCheckableEditor.EndSpell()
        {
        }

        //     Only one text block.
        bool ISpellCheckableEditor.HasMoreText()
        {
            return false;
        }

        //     Selects a range of text in the editor.
        void ISpellCheckableEditor.Select(int start, int length)
        {
            _editor.SelectedView.Selection.StartOffset = start;
            _editor.SelectedView.Selection.EndOffset = start + length;
        }
        #endregion

        #region ** ISpellCheckableRichEditor
        // Gets the index of the character closest to the specified location. 
        int ISpellCheckableRichEditor.GetCharIndexFromPosition(Point pt)
        {
            return _editor.SelectedView.LocationToOffset(pt, LocationToPositionAlgorithm.Block);
        }
        
        // Gets the location within the control at the specified character index.
        Point ISpellCheckableRichEditor.GetPositionFromCharIndex(int index)
        {
            Rectangle b = _editor.SelectedView.GetCharacterBounds(index);
            if (b.Left < (_editor.SelectedView.TextAreaBounds.Left))
                b.X = (_editor.SelectedView.TextAreaBounds.Left);
            return new Point(b.Left, b.Bottom);
        }

        // Gets the distance in pixels between the Y position returned by <see cref="GetPositionFromCharIndex"/>
        int ISpellCheckableRichEditor.GetBaselineOffset(CharRange range)
        {
            return 0;
        }
        #endregion
    }
}
