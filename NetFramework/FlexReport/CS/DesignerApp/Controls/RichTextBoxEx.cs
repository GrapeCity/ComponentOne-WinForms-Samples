//----------------------------------------------------------------------------
// RichTextBoxEx.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Text;
using System.Windows.Forms;

namespace FlexReportDesignerApp.Util
{
    /// <summary>
    /// This class inherits RichTextBox with IME bug fixes: getting of Text and SelectionLength properties causes IME composition break.
    /// </summary>
    public class RichTextBoxEx : RichTextBox
    {
        public enum WM_IME
        {
            WM_IME_ENDCOMPOSITION = 0x10E,
            WM_IME_STARTCOMPOSITION = 0x10D
        }

        private bool _imeComposing = false;
        private string _text = "";
        private int _selectionLength = 0;

        protected override void WndProc(ref Message m)
        {
            // sets/resets _imeComposing flag on the IME composition start/end
            if (m.Msg == (int)WM_IME.WM_IME_STARTCOMPOSITION)
                _imeComposing = true;
            else if (m.Msg == (int)WM_IME.WM_IME_ENDCOMPOSITION)
                _imeComposing = false;
            base.WndProc(ref m);
        }

        public override string Text
        {
            get
            {
                // returns old Text if input is in composition mode
                if (!_imeComposing)
                {
                    _text = base.Text;
                    return _text;
                }
                else
                    return _text;
            }
            set
            {
                base.Text = value;
                _text = value;
            }
        }

        public override int SelectionLength
        {
            get
            {
                // returns old SelectionLength if input is in composition mode
                if (!_imeComposing)
                {
                    _selectionLength = base.SelectionLength;
                    return base.SelectionLength;
                }
                else
                    return _selectionLength;
            }
            set
            {
                base.SelectionLength = value;
                _selectionLength = value;
            }
        }
    }
}
