using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace CustomDialogs
{
    internal partial class FindOptions : UserControl
    {
        public FindOptions()
        {
            InitializeComponent();

            _btnClose.Click += delegate(object sender, EventArgs e) { RaiseCloseButtonClick(); };
            _btnFindNext.Click += delegate(object sender, EventArgs e) { RaiseFindNextButonClick(); };

            _tbFindPattern_TextChanged(this, EventArgs.Empty);
        }

        private void _tbFindPattern_TextChanged(object sender, EventArgs e)
        {
            _btnFindNext.Enabled = SearchPattern.Length > 0;
        }

        #region events

        public event EventHandler ButtonFindNextClick;

        protected void RaiseFindNextButonClick()
        {
            if (ButtonFindNextClick != null)
                ButtonFindNextClick(this, EventArgs.Empty);
        }

        public event EventHandler ButtonCloseClick;

        protected void RaiseCloseButtonClick()
        {
            if (ButtonCloseClick != null)
                ButtonCloseClick(this, EventArgs.Empty);
        }

        #endregion

        #region properties

        public bool MatchCase
        {
            get { return _chbMatchCase.Checked; }
            set { _chbMatchCase.Checked = value; }
        }

        public bool MatchWholeWord
        {
            get { return _chbMatchWholeWord.Checked; }
            set { _chbMatchWholeWord.Checked = value; }
        }

        public bool SearchUp
        {
            get { return _chbSearchUp.Checked; }
            set { _chbSearchUp.Checked = value; }
        }

        public string SearchPattern
        {
            get { return _tbFindPattern.Text.Trim(); }
            set { _tbFindPattern.Text = value; }
        }

        public Button AcceptButton
        {
            get { return _btnFindNext; }
        }

        public Button CancelButton
        {
            get { return _btnClose; }
        }

        #endregion

        #region public

        public void SetActiveControl()
        {
            _tbFindPattern.Select();
        }

        #endregion
    }
}
