using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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
    public partial class SpellDialog : Form, ISpellDialog
    {
        //------------------------------------------------------------------------
        #region ** fields

        C1SpellChecker          _spell;                 // spell-checker to use
        ISpellCheckableEditor   _editor;                // generic wrapper for editor
        CharRangeList           _errors;                // current error list
        int                     _errorIndex = -1;       // current error index
        int                     _errorCount;            // error count

        Dictionary<string, string> _changeAll = new Dictionary<string, string>();

        /// <summary>
        /// Event that fires when the <see cref="C1SpellDialog"/> displays an error
        /// to the user.
        /// </summary>
        /// <remarks>
        /// You can use the <see cref="ErrorIndex"/> and <see cref="Errors"/> properties
        /// to display information about the error in a status bar.
        /// </remarks>
        public event EventHandler ErrorDisplayed;

        #endregion

        //------------------------------------------------------------------------
        #region ** ctor

        /// <summary>
        /// Initializes a new instance of a <see cref="C1SpellDialog"/>.
        /// </summary>
        public SpellDialog()
        {
            InitializeComponent();
            Font = SystemInformation.MenuFont;
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
            _spell = spell;
            _editor = editor;
            _errors = errors;
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
        /// <summary>
        /// Raises the <see cref="ErrorDisplayed"/> event.
        /// </summary>
        /// <param name="e"><see cref="EventArgs"/> that contains the event data.</param>
        protected virtual void OnErrorDisplayed(EventArgs e)
        {
            if (ErrorDisplayed != null)
                ErrorDisplayed(this, e);
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
            if (ErrorIndex >= _errors.Count)
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
                _txtChangeTo.Text = _changeAll[err.Text];
                _btnChange_Click(this, EventArgs.Empty);
                return;
            }

            // show bad word, new text
            _txtError.Text = err.Text;
            _txtChangeTo.Text = string.Empty;

            // repeated word?
            if (err.Duplicate)
            {
                // adjust dialog
                _lblNotInDictionary.Visible = false;
                _lblRepeatedWord.Visible = true;
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
                _btnIgnoreAll.Enabled = true;
                _btnChangeAll.Enabled = true;
                _btnAdd.Enabled = true;

                // show suggestions
                string[] suggestions = _spell.GetSuggestions(err.Text);
                _listSuggestions.Items.Clear();
                if (suggestions.Length > 0)
                {
                    _listSuggestions.Items.AddRange(suggestions);
                    _listSuggestions.SelectedIndex = 0;
                }
                else
                {
                    _listSuggestions.Items.Add(_lblNoSuggestions.Text);
                    _listSuggestions.SelectedIndex = -1;
                }
            }

            // focus to new word
            _txtChangeTo.SelectAll();
            _txtChangeTo.Focus();
            _btnSuggest.Enabled = false;
            AcceptButton = _btnIgnore;

            // show 'Add' button only if user dictionary is enabled
            _btnAdd.Visible = _spell.UserDictionary.Enabled;

            // all ready, fire ErrorDisplayed event
            OnErrorDisplayed(EventArgs.Empty);
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

            // initialize position of 'repeated word' label
            _lblRepeatedWord.Location = _lblNotInDictionary.Location;

            // show first error (after firing load event)
            ErrorIndex = 0;
        }

        // update ChangeTo text when a suggestion is selected
        private void _listSuggestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            _txtChangeTo.Text = _listSuggestions.Text == _lblNoSuggestions.Text
                ? string.Empty
                : _listSuggestions.Text;
        }

        // move to the next error (ignore the current one)
        private void _btnIgnore_Click(object sender, EventArgs e)
        {
            ErrorIndex++;
        }

        // add current word to the ignore list in the spell-checker
        private void _btnIgnoreAll_Click(object sender, EventArgs e)
        {
            _spell.IgnoreList.Add(CurrentError.Text);
            _errors = _spell.CheckText(_editor.Text, CurrentError.Start);
            UpdateCurrentError();
        }

        // change current word into 'ChangeTo' value
        private void _btnChange_Click(object sender, EventArgs e)
        {
            // save starting point to continue checking from here
            int start = CurrentError.Start;

            // get replacement text
            string replacement = _txtChangeTo.Text;
            if (replacement.Length == 0)
            {
                // if replacement is empty, expand over spaces and commas
                CharRange delete = CharRange.ExpandOverWhitespace(_editor.Text, CurrentError);
                _editor.Select(delete.Start, delete.Text.Length);
            }

            // replace word in text and re-check
            _editor.SelectedText = replacement;
            _errors = _spell.CheckText(_editor.Text, start);

            // update index
            ErrorIndex = 0;
        }

        // change all instances of the current word into 'ChangeTo' value
        private void _btnChangeAll_Click(object sender, EventArgs e)
        {
            _changeAll[CurrentError.Text] = _txtChangeTo.Text;
            _btnChange_Click(this, e);
        }

        // add current word to the user dictionary
        private void _btnAdd_Click(object sender, EventArgs e)
        {
            _spell.UserDictionary.AddWord(CurrentError.Text);
            _errors = _spell.CheckText(_editor.Text, CurrentError.Start);
            ErrorIndex = 0;
        }

        // update suggestion list with current content
        private void _btnSuggest_Click(object sender, EventArgs e)
        {
            _listSuggestions.Items.Clear();
            _listSuggestions.Items.AddRange(_spell.GetSuggestions(_txtChangeTo.Text));
        }

        // disable ChangeAll button when deleting words
        private void _txtChangeTo_TextChanged(object sender, EventArgs e)
        {
            // update button status
            if (_txtChangeTo.Text.Length > 0)
            {
                // update change buttons
                _btnChange.Text = _lblChange.Text;
                _btnChangeAll.Enabled = !CurrentError.Duplicate;

                // update suggest button
                string text = _txtChangeTo.Text;
                if (text.IndexOf(' ') < 0 && !_listSuggestions.Items.Contains(text))
                {
                    bool enable = true;
                    for (int i = 0; i < text.Length && enable; i++)
                    {
                        if (!char.IsLetterOrDigit(text, i) && text[i] != '\'')
                            enable = false;
                    }
                    _btnSuggest.Enabled = enable;
                }

                // indicate whether current text is valid
                _txtChangeTo.ForeColor = _spell.CheckText(_txtChangeTo.Text).Count == 0
                    ? SystemColors.WindowText
                    : Color.DarkRed;
            }
            else
            {
                _btnChange.Text = _lblRemove.Text;
                _btnChangeAll.Enabled = false;
                _btnSuggest.Enabled = false;
                _txtChangeTo.ForeColor = SystemColors.WindowText;
            }

            // change default button
            AcceptButton = _btnChange;
        }

        // cancel dialog
        private void _btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        // double-click selects word and changes it
        private void _listSuggestions_DoubleClick(object sender, EventArgs e)
        {
            if (_txtChangeTo.Text == _listSuggestions.Text)
            {
                _btnChange_Click(this, e);
            }
        }

        #endregion
    }
}