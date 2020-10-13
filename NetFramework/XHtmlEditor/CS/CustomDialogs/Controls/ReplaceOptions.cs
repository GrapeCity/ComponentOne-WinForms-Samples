using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CustomDialogs
{
    internal partial class ReplaceOptions : FindOptions
    {
        public ReplaceOptions() : base()
        {
            InitializeComponent();

            _btnReplace.Click += delegate(object sender, EventArgs e) { RaiseButtonReplaceClick(); };
            _btnReplaceAll.Click += delegate(object sender, EventArgs e) { RaiseButtonReplaceAllClick(); };

            _tbFindPattern_TextChanged(this, EventArgs.Empty);
        }

        private void _tbFindPattern_TextChanged(object sender, EventArgs e)
        {
            _btnReplace.Enabled = _btnFindNext.Enabled;
            _btnReplaceAll.Enabled = _btnFindNext.Enabled;
        }

        #region events

        public event EventHandler ButtonReplaceClick;

        protected void RaiseButtonReplaceClick()
        {
            if (ButtonReplaceClick != null)
                ButtonReplaceClick(this, EventArgs.Empty);
        }

        public event EventHandler ButtonReplaceAllClick;

        protected void RaiseButtonReplaceAllClick()
        {
            if (ButtonReplaceAllClick != null)
                ButtonReplaceAllClick(this, EventArgs.Empty);
        }

        #endregion

        #region properties

        public string ReplacePattern
        {
            get { return _tbReplacePattern.Text.Trim(); }
        }

        #endregion
    }
}

