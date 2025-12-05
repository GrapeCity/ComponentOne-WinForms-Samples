using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using C1.Win.SpellChecker;

namespace CustomSpellDialog
{
    /// <summary>
    /// Dialog that displays spelling mistakes and allows the user to correct them.
    /// </summary>
    /// <remarks>
    /// This dialog is created and shown by the <see cref="C1SpellChecker"/> component
    /// when you call the <see cref="C1SpellChecker.CheckControl(ISpellCheckableEditor)"/> method.
    /// </remarks>
    public partial class SpellDialogWord : Form, ISpellDialog
    {
        //------------------------------------------------------------------------
        #region ** fields

        C1SpellChecker          _spell;                 // spell-checker to use
        ISpellCheckableEditor   _editor;                // generic wrapper for editor
        CharRangeList           _errors;                // current error list
        int                     _errorIndex = -1;       // current error index
        int                     _errorCount;            // error count
        CharRange               _sentence;              // sentence that contains the error
        bool                    _textChanged;           // user typed into replacement textbox
        string                  _textChangeTo;           // replacement text
        Color                   _errorBackColor;
        Color                   _errorForeColor;

        // change all dictionary
        Dictionary<string, string> _changeAll = new Dictionary<string, string>();

        #endregion

        //------------------------------------------------------------------------
        #region ** ctor

        /// <summary>
        /// Initializes a new instance of a <see cref="C1SpellDialog"/>.
        /// </summary>
        public SpellDialogWord()
        {
            InitializeComponent();

            // change font *after* initializing the form
            Font = SystemInformation.MenuFont;

            // initialize position of repeated word label
            _lblRepeatedWord.Location = _lblNotInDictionary.Location;

            // forecolor used to highlight errors
            _errorForeColor = Color.Red;

            // backcolor used to keep track of the error within the 
            // sentence shown in the _txtError control
            // (just a little different from the regular backcolor)
            int r = _txtError.BackColor.R;
            r = (r == 255) ? 254 : r + 1;
            _errorBackColor = Color.FromArgb(r, _txtError.BackColor.G, _txtError.BackColor.B);
        }

        #endregion

        //------------------------------------------------------------------------
        #region ** object model

        /// <summary>
        /// Initializes the dialog to use the given parameters.
        /// </summary>
        /// <param name="spell"><see cref="C1SpellChecker"/> to use for spelling.</param>
        /// <param name="editor"><see cref="ISpellCheckableEditor"/> that contains the text to spell-check.</param>
        /// <param name="errors"><see cref="CharRangeList"/> that contains the initial error list.</param>
        public void Initialize(C1SpellChecker spell, ISpellCheckableEditor editor, CharRangeList errors)
        {
            // initialize members
            _spell = spell;
            _editor = editor;
            _errors = errors;

            // initialize 'change all' list
            _changeAll.Clear();
            foreach (string key in _spell.AutoReplaceList.Keys)
            {
                _changeAll[key] = _spell.AutoReplaceList[key];
            }

            // initialize error list
            if (_errors == null)
            {
                _errors = _spell.CheckText(_editor.Text);
            }
            _errorCount += _errors.Count;
        }
        /// <summary>
        /// Gets the total number of errors detected in the control.
        /// </summary>
        public int ErrorCount
        {
            get { return _errorCount; }
        }
        /// <summary>
        /// Gets a <see cref="CharRangeList"/> object with all the errors detected by the 
        /// <see cref="C1SpellChecker"/> component that owns the dialog.
        /// </summary>
        public CharRangeList Errors
        {
            get { return _errors; }
        }
        /// <summary>
        /// Gets or sets the index of the current error into the <see cref="Errors"/> list.
        /// </summary>
        public int ErrorIndex
        {
            get { return _errorIndex; }
            set
            {
                _errorIndex = value;
                UpdateCurrentError();
            }
        }
        /// <summary>
        /// Gets the <see cref="CharRange"/> object that represents the error currently 
        /// displayed in the dialog.
        /// </summary>
        public CharRange CurrentError
        {
            get { return _errors[_errorIndex]; }
        }

        #endregion

        //------------------------------------------------------------------------
        #region ** private stuff

        // update dialog to show current error
        private void UpdateCurrentError()
        {
            // design time
            if (DesignMode || _errors == null)
            {
                return;
            }

            // finished with this batch of errors
            if (ErrorIndex < 0 || ErrorIndex >= _errors.Count)
            {
                // check whether the editor has more text to check
                while (_editor.HasMoreText())
                {
                    _errors = _spell.CheckText(_editor.Text);
                    if (_errors.Count > 0)
                    {
                        _errorCount += _errors.Count;
                        ErrorIndex = 0;
                        return;
                    }
                }

                // editor has no more text...
                DialogResult = DialogResult.OK;
                return;
            }

            // update current error
            CharRange err = CurrentError;

            // select word in editor
            _editor.Select(err.Start, err.Text.Length);

            // honor 'change all' list
            if (_changeAll.ContainsKey(err.Text))
            {
                _textChangeTo = _changeAll[err.Text];
                _btnChange_Click(this, EventArgs.Empty);
                return;
            }

            // show whole sentence, highlight bad word
            _sentence = GetSentence(_editor.Text, err);
            _txtError.Font = _editor.Control.Font;
            _txtError.Text = _sentence.Text;
            _txtError.Select(err.Start - _sentence.Start, err.Length);
            _txtError.SelectionFont = new Font(_txtError.Font, FontStyle.Bold);
            _txtError.SelectionColor = _errorForeColor;
            _txtError.SelectionBackColor = _errorBackColor;
            _txtError.Select(_txtError.SelectionStart + _txtError.SelectionLength, 0);

            // repeated word?
            if (err.Duplicate)
            {
                // adjust dialog
                _lblNotInDictionary.Visible = false;
                _lblRepeatedWord.Visible = true;
                _btnChange.Text = _lblRemove.Text;
                _btnIgnoreAll.Enabled = false;
                _btnChangeAll.Enabled = false;
                _btnAdd.Enabled = false;

                // no suggestions
                _listSuggestions.Items.Clear();
            }
            else
            {
                // adjust dialog
                _lblRepeatedWord.Visible = false;
                _lblNotInDictionary.Visible = true;
                _btnChange.Text = _lblChange.Text;
                _btnIgnoreAll.Enabled = true;
                _btnChange.Enabled = false;
                _btnChangeAll.Enabled = false;
                _btnAdd.Enabled = true;

                // show suggestions
                ShowSuggestions(err.Text);
            }

            // focus to new word
            _txtError.Focus();
            _btnSuggest.Enabled = false;
            AcceptButton = _btnIgnore;

            // show 'Add' button only if user dictionary is enabled
            _btnAdd.Visible = _spell.UserDictionary.Enabled;

            // ready, fire BadWordDetected event
            BadWordEventArgs e = new BadWordEventArgs(this, _editor.Control, err, _errors);
            _spell.OnBadWordFound(e);

            // ignore error on event-handler request
            if (e.Cancel)
            {
                ErrorIndex++;
            }
        }
        private CharRange GetSentence(string text, CharRange err)
        {
            // find sentence start
            int start = -1;
            for (int i = err.Start; i > 0 && start < 0; i--)
            {
                switch (text[i])
                {
                    case '.':
                    case '!':
                    case '?':
                    case '\n':
                    case '\r':
                        for (int j = i; j < err.Start; j++)
                        {
                            if (char.IsLetterOrDigit(text[j]))
                            {
                                start = j;
                                break;
                            }
                        }
                        break;
                }
            }
            if (start < 0)
                start = 0;

            // find sentence end
            int end = -1;
            for (int i = err.Start; i < text.Length && end < 0; i++)
            {
                switch (text[i])
                {
                    case '.':
                    case '!':
                    case '?':
                        end = i;
                        break;
                    case '\n':
                    case '\r':
                        end = i - 1;
                        break;
                }
            }
            if (end < 0)
                end = text.Length - 1;

            // done, return result
            string sentence = text.Substring(start, end - start + 1);
            return new CharRange(sentence, start, false);
        }
        private CharRange GetReplacement()
        {
            int start = -1;
            int end = -1;
            using (_txtError.CreateSelectionContext())
            {
                for (int i = 0; i < _txtError.Text.Length; i++)
                {
                    _txtError.Select(i, 1);
                    if (_txtError.SelectionBackColor == _errorBackColor)
                    {
                        if (start < 0) start = i;
                        end = i;
                    }
                }
            }
            return start > -1
                ? new CharRange(_txtError.Text.Substring(start, end - start + 1), start, false)
                : null;
        }
        private bool ReplacementTextChanged
        {
            get { return _textChanged; }
            set
            {
                _textChanged = value;
                _textChangeTo = string.Empty;

                if (_textChanged)
                {
                    // update controls
                    _btnIgnore.Text = "&Undo Edit";
                    _btnIgnoreAll.Enabled = false;
                    _btnAdd.Enabled = false;
                    _btnChange.Enabled = true;
                    _btnChangeAll.Enabled = true;

                    _btnSuggest.Enabled = true;
                    _listSuggestions.Enabled = false;

                    // remove error highlight
                    using (_txtError.CreateSelectionContext())
                    {
                        _txtError.SelectAll();
                        _txtError.SelectionFont = _editor.Control.Font;
                        _txtError.SelectionColor = _txtError.ForeColor;
                    }
                }
                else
                {
                    // update controls
                    _btnIgnore.Text = "&Ignore Once";
                    _btnIgnoreAll.Enabled = true;
                    _btnAdd.Enabled = true;

                    _btnSuggest.Enabled = false;
                    _listSuggestions.Enabled = _listSuggestions.Items.Count > 0;
                }
            }
        }
        private void ShowSuggestions(string word)
        {
            string[] suggestions = _spell.GetSuggestions(word);
            _listSuggestions.Items.Clear();
            if (suggestions.Length > 0)
            {
                _listSuggestions.Items.AddRange(suggestions);
                _listSuggestions.SelectedIndex = 0;
                _listSuggestions.Enabled = true;
            }
            else
            {
                _listSuggestions.Items.Add(_lblNoSuggestions.Text);
                _listSuggestions.SelectedIndex = -1;
                _listSuggestions.Enabled = false;
            }
        }

        #endregion

        //------------------------------------------------------------------------
        #region ** event handlers

        /// <summary>
        /// Raises the <see cref="Form.Load"/> event.
        /// </summary>
        /// <param name="e"><see cref="EventArgs"/> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            // fire load event
            base.OnLoad(e);

            // show first error (after firing load event)
            ErrorIndex = 0;
        }

        // update ChangeTo text when a suggestion is selected
        private void _listSuggestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_listSuggestions.SelectedIndex > -1)
            {
                _btnChange.Enabled = true;
                _btnChangeAll.Enabled = true;
                _textChangeTo = _listSuggestions.Text;
            }
        }

        // move to the next error (ignore the current one)
        private void _btnIgnore_Click(object sender, EventArgs e)
        {
            if (ReplacementTextChanged)
            {
                UpdateCurrentError();
            }
            else
            {
                ErrorIndex++;
            }
        }

        // add current word to the ignore list in the spell-checker
        private void _btnIgnoreAll_Click(object sender, EventArgs e)
        {
            _spell.IgnoreList.Add(CurrentError.Text);
            _errors = _spell.CheckText(_editor.Text);
            UpdateCurrentError();
        }

        // change current word into 'ChangeTo' value
        private void _btnChange_Click(object sender, EventArgs e)
        {
            // save starting point to continue checking from here
            int start = CurrentError.Start;

            // if the user typed into the text error box, handle that
            CharRange replacement = null;
            if (ReplacementTextChanged && _listSuggestions.Enabled == false)
            {
                // get part of the text that replaced the actual error within the sentence
                replacement = GetReplacement();
                if (replacement != null && replacement.Text.Length > 0)
                {
                    // warn if replacement is bad
                    if (_spell.CheckText(replacement.Text).Count > 0)
                    {
                        string msg = "You have chosen a word that is not in the dictionary.\r\n" +
                                     "Do you want to use this word and continue checking?";
                        DialogResult dr = MessageBox.Show(this, msg, "Spelling", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dr == DialogResult.No)
                        {
                            return;
                        }
                    }

                    // honor ChangeAll button
                    if (sender.Equals(_btnChangeAll))
                    {
                        _changeAll[CurrentError.Text] = replacement.Text;
                    }
                }

                // replace whole sentence in text
                _editor.Select(_sentence.Start, _sentence.Length);
                _editor.SelectedText = _txtError.Text;

                // resume checking from sentence start
                start = _sentence.Start;
            }
            else
            {
                // no changes in text, use Suggestion/ChangeAll value stored in _txtChangeTo
                string changeTo = _textChangeTo;
                if (changeTo.Length == 0)
                {
                    // if replacement is empty, expand over spaces and commas
                    CharRange delete = CharRange.ExpandOverWhitespace(_editor.Text, CurrentError);
                    _editor.Select(delete.Start, delete.Text.Length);
                }

                // honor ChangeAll button
                if (sender.Equals(_btnChangeAll))
                {
                    _changeAll[CurrentError.Text] = changeTo;
                }

                // replace word in text
                _editor.SelectedText = changeTo;
                _errors = _spell.CheckText(_editor.Text);
            }

            // re-check
            _errors = _spell.CheckText(_editor.Text);
            _errorIndex = -1;
            for (int index = 0; index < _errors.Count; index++)
            {
                if (_errors[index].Start >= start)
                {
                    if (replacement == null || replacement.Text != _errors[index].Text)
                    {
                        _errorIndex = index;
                        break;
                    }
                }
            }

            // show the current error
            UpdateCurrentError();
        }

        // change all instances of the current word into 'ChangeTo' value
        private void _btnChangeAll_Click(object sender, EventArgs e)
        {
            _btnChange_Click(this, e);
        }

        // add current word to the user dictionary
        private void _btnAdd_Click(object sender, EventArgs e)
        {
            _spell.UserDictionary.AddWord(CurrentError.Text);
            _errors = _spell.CheckText(_editor.Text);
            UpdateCurrentError();
        }

        // update suggestion list with current content
        private void _btnSuggest_Click(object sender, EventArgs e)
        {
            _listSuggestions.Items.Clear();
            CharRange replacement = GetReplacement();
            if (replacement != null && replacement.Text.Length > 0)
            {
                ShowSuggestions(replacement.Text);
            }
            _btnSuggest.Enabled = false;
        }

        // cancel dialog
        private void _btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        // double-click selects word and changes it
        private void _listSuggestions_DoubleClick(object sender, EventArgs e)
        {
            _btnChange_Click(this, e);
        }

        // changing the replacement text enables change buttons
        private void _txtError_KeyDown(object sender, KeyEventArgs e)
        {
            ReplacementTextChanged = true;
        }

        #endregion
    }

    /// <summary>
    /// Class that derives from <see cref="RichTextBox"/> to provide a flat border.
    /// </summary>
    public class RicherTextBox : RichTextBox
    {
        // ** ctor
        public RicherTextBox() { }

        // ** preserve selection
        public IDisposable CreateSelectionContext()
        {
            return new SelectionContext(this);
        }
        private class SelectionContext : IDisposable
        {
            RicherTextBox _tb;
            int _start, _len;
            bool _focus;

            public SelectionContext(RicherTextBox tb)
            {
                _tb = tb;
                _start = tb.SelectionStart;
                _len = tb.SelectionLength;
                _focus = tb.Focused;
                SetFocus(IntPtr.Zero);
            }
            void IDisposable.Dispose()
            {
                _tb.Select(_start, _len);
                if (_focus)
                    _tb.Focus();
            }
        }

        // ** win32 stuff
        protected override void WndProc(ref Message m)
        {
            const int WM_NCPAINT = 0x0085;

            switch (m.Msg)
            {
                case WM_NCPAINT:
                    if (BorderStyle == BorderStyle.FixedSingle)
                    {
                        // paint scrollbars
                        base.WndProc(ref m);

                        // paint border
                        DrawFlatNCBorder(ref m);

                        // don't call base.WndProc, we're done.
                        return;
                    }
                    break;
            }

            // allow default processing
            base.WndProc(ref m);
        }
        private void DrawFlatNCBorder(ref Message msg)
        {
            IntPtr hRgn = msg.WParam;
            IntPtr hdc = GetDCEx(msg.HWnd, hRgn, DCX_WINDOW | DCX_PARENTCLIP | DCX_INTERSECTRGN);
            if (hdc != IntPtr.Zero)
            {
                using (Graphics g = Graphics.FromHdc(hdc))
                {
                    base.UpdateBounds();
                    Rectangle r = new Rectangle(0, 0, Width, Height);
                    ControlPaint.DrawBorder(g, r, VisualStyleInformation.TextControlBorder, ButtonBorderStyle.Solid);
                    r.Inflate(-1, -1);
                    ControlPaint.DrawBorder(g, r, BackColor, ButtonBorderStyle.Solid);
                }
                msg.Result = (IntPtr)1;
                ReleaseDC(msg.HWnd, hdc);
            }
        }
        [System.Runtime.InteropServices.DllImport("USER32.DLL")]
        static private extern IntPtr GetDCEx(IntPtr hWnd, IntPtr hRgnClip, uint flags);
        [System.Runtime.InteropServices.DllImport("USER32.DLL")]
        static private extern int ReleaseDC(IntPtr hWnd, IntPtr hdc);
        [System.Runtime.InteropServices.DllImport("USER32.DLL")]
        static private extern int SetFocus(IntPtr hWnd);

        private const int
            DCX_WINDOW = 0x00000001,
            DCX_CACHE = 0x00000002,
            DCX_NORESETATTRS = 0x00000004,
            DCX_CLIPCHILDREN = 0x00000008,
            DCX_CLIPSIBLINGS = 0x00000010,
            DCX_PARENTCLIP = 0x00000020,
            DCX_EXCLUDERGN = 0x00000040,
            DCX_INTERSECTRGN = 0x00000080,
            DCX_EXCLUDEUPDATE = 0x00000100,
            DCX_INTERSECTUPDATE = 0x00000200,
            DCX_LOCKWINDOWUPDATE = 0x00000400,
            DCX_VALIDATE = 0x00200000;
    }
}