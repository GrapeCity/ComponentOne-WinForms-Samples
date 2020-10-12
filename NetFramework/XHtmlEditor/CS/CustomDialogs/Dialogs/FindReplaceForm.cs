using System;
using System.ComponentModel;
using System.Windows.Forms;
using C1.Win.C1Editor.UICustomization;

namespace CustomDialogs
{
    /// <summary>
    /// Represents a Find/Replace dialog.
    /// </summary>
    internal partial class FindReplaceForm : Form, IFindReplaceDialog
    {
        #region declarations

        private FindOptions _currentControl;
        private FindReplaceSupport _support;

        #endregion

        #region ctors

        public FindReplaceForm()
        {
            InitializeComponent();
            ShowInTaskbar = false;
            Font = SystemInformation.MenuFont;

            _findOption.ButtonCloseClick += delegate { Close(); };
            _replaceOption.ButtonCloseClick += delegate { Close(); };
            _findOption.ButtonFindNextClick += delegate { FindNext(); };
            _replaceOption.ButtonFindNextClick += delegate { FindNext(); };
            _replaceOption.ButtonReplaceClick += delegate { Replace(); };
            _replaceOption.ButtonReplaceAllClick += delegate { ReplaceAll(); };
        }

        #endregion

        #region implementation

        private void SetFindReplaceOptions()
        {
            _support.SearchUp = _currentControl.SearchUp;
            _support.MatchWholeWord = _currentControl.MatchWholeWord;
            _support.MatchCase = _currentControl.MatchCase;
            _support.SearchPattern = _currentControl.SearchPattern;
            _support.ReplacePattern = _replaceOption.ReplacePattern;
        }

        private void FindNext()
        {
            SetFindReplaceOptions();
            _support.FindNext();
        }

        private void Replace()
        {
            SetFindReplaceOptions();
            _support.Replace();
        }

        private void ReplaceAll()
        {
            SetFindReplaceOptions();
            _support.ReplaceAll();
        }

        private void ChangeMode(object sender, EventArgs e)
        {
            if (_tbcFindReplace.SelectedIndex == 0)
            {
                _currentControl = _findOption;
                _currentControl.MatchCase = _replaceOption.MatchCase;
                _currentControl.MatchWholeWord = _replaceOption.MatchWholeWord;
                _currentControl.SearchUp = _replaceOption.SearchUp;
                _currentControl.SearchPattern = _replaceOption.SearchPattern;
            }
            else
            {
                _currentControl = _replaceOption;
                _currentControl.MatchCase = _findOption.MatchCase;
                _currentControl.MatchWholeWord = _findOption.MatchWholeWord;
                _currentControl.SearchUp = _findOption.SearchUp;
                _currentControl.SearchPattern = _findOption.SearchPattern;
            }

            _currentControl.SetActiveControl();
            AcceptButton = _currentControl.AcceptButton;
            CancelButton = _currentControl.CancelButton;
        }

        private void SetMode(bool startWithFindDialog, bool init)
        {
            bool needToChange = _tbcFindReplace.SelectedIndex == 0 != startWithFindDialog;
            if (needToChange)
                _tbcFindReplace.SelectedIndex = startWithFindDialog ? 0 : 1;
            if (needToChange || init)
                ChangeMode(this, EventArgs.Empty);
        }

        protected override void OnShown(EventArgs e)
        {
            _currentControl.SetActiveControl();
            Focus();
            base.OnShown(e);
        }

        #endregion

        #region IFindReplaceDialog Members

        /// <summary>
        /// Binds data from the item to GUI controls on the form.
        /// Data can be bound either using the <see cref="Control.DataBindings"/> collection or any other way allowing 
        /// to read data from the item and write it back.
        /// </summary>
        /// <param name="item">The item to be bound to the GUI controls.</param>
        void IFindReplaceDialog.BindData(FindReplaceSupport support)
        {
            _support = support;
            _findOption.SearchPattern = support.SearchPattern;
            _replaceOption.SearchPattern = support.SearchPattern;
        }

        /// <summary>
        /// Shows the form with the specified owner to the user.
        /// </summary>
        /// <param name="owner">Any object that implements <see cref="System.Windows.Forms.IWin32Window"/> and represents 
        /// the top-level window that will own this form.</param>
        /// <returns>True if the form was displayed successfully and the item was changed.</returns>
        void IFindReplaceDialog.Show(IWin32Window owner, bool startWithFindDialog)
        {
            if (!Visible)
            {
                SetMode(startWithFindDialog, true);
                Show(owner);
            }
            else
            {
                SetMode(startWithFindDialog, false);
                Activate();
            }
                
        }

        #endregion
    }
}