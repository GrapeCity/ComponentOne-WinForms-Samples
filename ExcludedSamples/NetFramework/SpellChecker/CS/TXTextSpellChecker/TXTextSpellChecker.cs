using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;

using TXTextControl;
using C1.Win.C1SpellChecker;


namespace TXTextSpellCheckerDemo
{
    public class TXTextSpellChecker : TextControl, ISpellCheckableRichEditor
    {
        //-------------------------------------------------------------------------------------
        #region ** override OnChanged to fire TextChanged as most controls do

        bool _ignoreChanges;
        public bool IgnoreChanges
        {
            get { return _ignoreChanges; }
            set { _ignoreChanges = value; }
        }
        protected override void OnChanged(EventArgs e)
        {
            base.OnChanged(e);
            if (!_ignoreChanges)
            {
                base.OnTextChanged(e);
            }
        }

        #endregion

        //-------------------------------------------------------------------------------------
        #region ** ISpellCheckableEditor

        Control ISpellCheckableEditor.Control
        {
            get { return this; }
        }
        bool ISpellCheckableEditor.HasMoreText()
        {
            return false;
        }
        bool ISpellCheckableEditor.HideSelection
        {
            get { return this.HideSelection; }
            set { this.HideSelection = value; }
        }
        void ISpellCheckableEditor.Select(int start, int length)
        {
            this.Select(start, length);
        }
        string ISpellCheckableEditor.SelectedText
        {
            get { return this.Selection.Text; }
            set { this.Selection.Text = value; }
        }
        int ISpellCheckableEditor.SelectionLength
        {
            get { return this.Selection.Length; }
            set { this.Selection.Length = value; }
        }
        int ISpellCheckableEditor.SelectionStart
        {
            get { return this.Selection.Start; }
            set { this.Selection.Start = value; }
        }
        string ISpellCheckableEditor.Text
        {
            get { return this.Text.Replace("\r\n", "\n"); }
            set { this.Text = value; }
        }
        void ISpellCheckableEditor.BeginSpell()
        {
        }
        void ISpellCheckableEditor.EndSpell()
        {
        }

        #endregion

        //-------------------------------------------------------------------------------------
        #region ** ISpellCheckableRichEditor

        private PointF _dpi = new PointF(-1, -1);
        private PointF Dpi
        {
            get
            {
                if (_dpi.X < 0)
                {
                    using (Graphics g = this.CreateGraphics())
                    {
                        _dpi = new PointF(g.DpiX, g.DpiY);
                    }
                }
                return _dpi;
            }
        }
        int ISpellCheckableRichEditor.GetBaselineOffset(CharRange error)
        {
            LINERECT lr = new LINERECT();
            lr.lineIndex = SendMessage(TX_LINEFROMCHAR, 0, error.Start) - 1;
            if (lr.lineIndex > -1)
            {
                SendMessage(this.Handle, TX_GETLINERECT, 0, ref lr);
                return (int)(lr.lineRect.height / 1440f * Dpi.Y * (this.ZoomFactor / 100f) - 2);
            }
            else
            {
                return this.Font.Height - 2;
            }
        }
        int ISpellCheckableRichEditor.GetCharIndexFromPosition(Point pt)
        {
            // can't do this while the user is selecting text with the mouse!
            if ((Control.MouseButtons & MouseButtons.Left) != 0)
            {
                return 0;
            }

            // convert client to document coords
            pt.X = (int)(pt.X * 1440f / Dpi.X * (100f / (float)this.ZoomFactor));
            pt.Y = (int)(pt.Y * 1440f / Dpi.Y * (100f / (float)this.ZoomFactor));
            pt.Offset(this.ScrollLocation);

            // temporarily move input position and get character position
            using (new SelectionContext(this))
            {
                this.InputPosition = new InputPosition(pt);
                int textPosition = this.InputPosition.TextPosition;
                return textPosition;
            }
        }
        Point ISpellCheckableRichEditor.GetPositionFromCharIndex(int index)
        {
            // can't do this while the user is selecting text with the mouse!
            if ((Control.MouseButtons & MouseButtons.Left) != 0)
            {
                return Point.Empty;
            }
            // temporarily move input position and get character position
            using (new SelectionContext(this))
            {
                this.InputPosition = new InputPosition(index);
                Point pt = this.InputPosition.Location;

                // convert document to client coords
                pt.Offset(-this.ScrollLocation.X, -this.ScrollLocation.Y);
                pt.X = (int)(pt.X * Dpi.X / 1440f * this.ZoomFactor / 100f);
                pt.Y = (int)(pt.Y * Dpi.Y / 1440f * this.ZoomFactor / 100f);
                return pt;
            }
        }
        /// <summary>
        /// Helper class used to save and restore the selection.
        /// </summary>
        private class SelectionContext : IDisposable
        {
            TXTextSpellChecker _editor;
            Selection _sel;
            bool _hadFocus;

            public SelectionContext(TXTextSpellChecker editor)
            {
                _editor = editor;
                _sel = _editor.Selection;
                _editor.IgnoreChanges = true;
                if (_editor.Focused)
                {
                    _hadFocus = true;
                    SetFocus(IntPtr.Zero);
                }
            }
            public void Dispose()
            {
                _editor.Select(_sel.Start, _sel.Length);
                if (_hadFocus)
                {
                    _editor.Focus();
                }
                _editor.IgnoreChanges = false;
            }
        }

        #endregion

        //---------------------------------------------------------------
        #region ** Win32

        private struct RECT
        {
            public int left, top, right, bottom;
            public int width { get { return right - left; } }
            public int height { get { return bottom - top; } }
        }
        private struct LINERECT
        {
            public int lineIndex;
            public RECT lineRect;
        }

        private int SendMessage(int msg, int wParam)
        {
            return SendMessage(this.Handle, msg, (IntPtr)wParam, IntPtr.Zero);
        }
        private int SendMessage(int msg, int wParam, int lParam)
        {
            return SendMessage(this.Handle, msg, (IntPtr)wParam, (IntPtr)lParam);
        }

        [DllImport("user32")]
        static private extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, ref LINERECT lr);

        [DllImport("user32")]
        internal static extern int SetFocus(IntPtr hWnd);

        [DllImport("user32")]
        static private extern int LockWindowUpdate(IntPtr hWnd);

        private const int
            EM_SETSEL = 0x00b1;

        // TxText messages:
        private const int
            WM_USER = 0x400,
            TX_FIRST = (WM_USER + 100),
            TX_GETCARETEXT = (WM_USER + 100),
            TX_GETCARETPOS = (WM_USER + 101),
            TX_GETFONTATTR = (WM_USER + 102),
            TX_GETFORMAT = (WM_USER + 103),
            TX_GETHANDLE = (WM_USER + 104),
            TX_GETLINEANDCOL = (WM_USER + 105),
            TX_GETMODE = (WM_USER + 106),
            TX_GETRECT = (WM_USER + 107),
            TX_GETSEL = (WM_USER + 108),
            TX_GETTABS = (WM_USER + 109),
            TX_GETTEXTEXTENT = (WM_USER + 110),
            TX_GETTEXTLIMITS = (WM_USER + 111),
            TX_GETTEXTSIZE = (WM_USER + 112),
            TX_GETBASELINE = (WM_USER + 113),
            TX_GETLINESPACING = (WM_USER + 114),
            TX_GETLINECOUNT = (WM_USER + 115),
            TX_LINEINDEX = (WM_USER + 116),
            TX_LINEFROMCHAR = (WM_USER + 117),
            TX_LINEFROMPOINT = (WM_USER + 118),
            TX_GETIMAGEA = (WM_USER + 119),
            TX_GETINDENTS = (WM_USER + 120),
            TX_GETFONTA = (WM_USER + 121),
            TX_GETESCAPEMENT = (WM_USER + 122),
            TX_GETLINKWND = (WM_USER + 123),
            TX_GETZOOM = (WM_USER + 124),
            TX_GETLINERECT = (WM_USER + 125),
            TX_GETTEXTCOLOR = (WM_USER + 126),
            TX_GETMODEEX = (WM_USER + 127),
            TX_GETBKGNDCOLOR = (WM_USER + 128),
            TX_GETPGFRAME = (WM_USER + 129),

            TX_SETFONTATTR = (WM_USER + 130),
            TX_SETFORMAT = (WM_USER + 131),
            TX_SETHANDLE = (WM_USER + 132),
            TX_SETMODE = (WM_USER + 133),
            TX_SETSEL = (WM_USER + 134),
            TX_SETTABS = (WM_USER + 135),
            TX_SETBASELINE = (WM_USER + 136),
            TX_SETLINESPACING = (WM_USER + 137),
            TX_SETIMAGEA = (WM_USER + 138),
            TX_SETINDENTS = (WM_USER + 139),
            TX_SETFONTA = (WM_USER + 140),
            TX_SETESCAPEMENT = (WM_USER + 141),
            TX_SETLINKWND = (WM_USER + 142),
            TX_SETWORDDIVISION = (WM_USER + 143),
            TX_SETTEXTCOLOR = (WM_USER + 144),
            TX_SETMODEEX = (WM_USER + 145),
            TX_SETBKGNDCOLOR = (WM_USER + 146),
            TX_SETPGFRAME = (WM_USER + 147),
            TX_SETTEXTAREA = (WM_USER + 148),
            TX_SETSCROLLPOS = (WM_USER + 149),
            TX_ADJUSTCLIPBOARD = (WM_USER + 150),
            TX_CREATEIMAGEA = (WM_USER + 151),
            TX_DEVMODECHANGE = (WM_USER + 152),
            TX_ENLARGEFONT = (WM_USER + 153),
            TX_FONTDIALOG = (WM_USER + 154),

            TX_LIMITTEXT = (WM_USER + 156),
            TX_LIMITLINE = (WM_USER + 157),
            TX_PARAGRAPHDIALOG = (WM_USER + 158),
            TX_GETTEXTAREA = (WM_USER + 159),
            TX_SELTEST = (WM_USER + 160),
            TX_IMPORTTEXTBUFFERA = (WM_USER + 161),
            TX_IMPORTTEXTFILEA = (WM_USER + 162),
            TX_EXPORTTEXTA = (WM_USER + 163),
            TX_GETBASELINEPOS = (WM_USER + 164),
            TX_GETSUPPORTEDFONTSA = (WM_USER + 165),
            TX_GETSUPPORTEDSIZESA = (WM_USER + 166),
            TX_GETIMAGEFILTERSA = (WM_USER + 167),
            TX_GETSCROLLPOS = (WM_USER + 168),
            TX_REPLACESELA = (WM_USER + 169),
            TX_GETCHARRECT = (WM_USER + 170),
            TX_PRINTPAGE = (WM_USER + 171),
            TX_GETPAGECOUNT = (WM_USER + 172),
            TX_GETTEXTWIDTH = (WM_USER + 173),
            TX_GETTEXTHEIGHT = (WM_USER + 174),
            TX_GETIMAGEFORMAT = (WM_USER + 175),
            TX_SETIMAGEFORMAT = (WM_USER + 176),
            TX_GETPAGEMARGINS = (WM_USER + 177),
            TX_SETPAGEMARGINS = (WM_USER + 178),
            TX_GETTEXTA = (WM_USER + 179),
            TX_SETTEXTA = (WM_USER + 180),
            TX_GETASCIITEXT = (WM_USER + 181),
            TX_GETASCIITEXTSIZE = (WM_USER + 182),
            TX_GETPARAFORMATFLAGS = (WM_USER + 183),
            TX_SETPARAFORMATFLAGS = (WM_USER + 184),
            TX_GETPRINTERDC = (WM_USER + 185),
            TX_RELEASEPRINTERDC = (WM_USER + 186),
            TX_GETMESSAGESTRINGA = (WM_USER + 187),
            TX_SETCARETEXT = (WM_USER + 188),
            TX_SETLINEANDCOL = (WM_USER + 189),
            TX_RESETCONTENTS = (WM_USER + 190),
            TX_INPUTPOSFROMPOINT = (WM_USER + 191),

            TX_FIELD_FROMCARETPOS = (WM_USER + 194),
            TX_FIELD_GOTOA = (WM_USER + 195),
            TX_FIELD_GETTYPEA = (WM_USER + 196),
            TX_FIELD_SETTYPEA = (WM_USER + 197),
            TX_FIELD_ISFIELD = (WM_USER + 198),
            TX_FIELD_GETDATA = (WM_USER + 199),
            TX_FIELD_CHANGETEXTA = (WM_USER + 200),
            TX_FIELD_GETATTR = (WM_USER + 201),
            TX_FIELD_GETCURRENT = (WM_USER + 202),
            TX_FIELD_GETTEXTA = (WM_USER + 203),
            TX_FIELD_GETPOSITION = (WM_USER + 204),
            TX_FIELD_INSERTA = (WM_USER + 205),
            TX_FIELD_SETATTR = (WM_USER + 206),
            TX_FIELD_DELETE = (WM_USER + 207),
            TX_FIELD_GETNEXT = (WM_USER + 208),
            TX_FIELD_SETDATA = (WM_USER + 209),

            TX_OBJ_EMBEDA = (WM_USER + 210),
            TX_OBJ_GETATTRA = (WM_USER + 211),
            TX_OBJ_SETATTRA = (WM_USER + 212),
            TX_OBJ_DELETE = (WM_USER + 213),
            TX_OBJ_EXIST = (WM_USER + 214),
            TX_OBJ_GETNEXT = (WM_USER + 215),
            TX_OBJ_OLE_CANCEL = (WM_USER + 216),
            TX_OBJ_ERRORNOTIFY = (WM_USER + 217),
            TX_OBJ_GETDISPINTERFACE = (WM_USER + 218),

            TX_TABLE_INSERT = (WM_USER + 230),
            TX_TABLE_GETCOLPOSITIONS = (WM_USER + 231),
            TX_TABLE_SETCOLPOSITIONS = (WM_USER + 232),
            TX_TABLE_INSERTLINES = (WM_USER + 233),
            TX_TABLE_DELETELINES = (WM_USER + 234),
            TX_TABLE_ISPOSSIBLE = (WM_USER + 235),
            TX_TABLE_GETCELLATTR = (WM_USER + 236),
            TX_TABLE_SETCELLATTR = (WM_USER + 237),
            TX_TABLE_ATTRDIALOG = (WM_USER + 238),
            TX_TABLE_CHANGEID = (WM_USER + 239),
            TX_TABLE_GETTEXTOFCELLA = (WM_USER + 240),
            TX_TABLE_SETTEXTOFCELLA = (WM_USER + 241),
            TX_TABLE_GETROWSANDCOLS = (WM_USER + 242),
            TX_TABLE_FROMCARETPOS = (WM_USER + 243),
            TX_TABLE_GETATTROFCELL = (WM_USER + 244),
            TX_TABLE_SETATTROFCELL = (WM_USER + 245),
            TX_TABLE_GETNEXT = (WM_USER + 246),
            TX_TABLE_GETCELLPOSITION = (WM_USER + 247),
            TX_TABLE_GETLINELOCATION = (WM_USER + 248),

            TX_HF_ACTIVATE = (WM_USER + 260),
            TX_HF_ENABLE = (WM_USER + 261),
            TX_HF_SELECT = (WM_USER + 262),
            TX_HF_GETPOSITION = (WM_USER + 263),
            TX_HF_SETPOSITION = (WM_USER + 264),
            TX_HF_DISABLE = (WM_USER + 265),
            TX_HF_ISHEADERORFOOTER = (WM_USER + 266),
            TX_HF_GETENABLED = (WM_USER + 267),
            TX_HF_GETACTIVATEDPAGE = (WM_USER + 268);

        // font attribute flags:

        // TX_GET/SETFONTATTR:
        private const int
            FA_NOCOMMONS = 0x00000001,
            FA_STANDARD = 0x00000002,
            FA_BOLD = 0x00000004,
            FA_ITALIC = 0x00000008,
            FA_UNDERLINE = 0x00000010,
            FA_STRIKEOUT = 0x00000020,
            FA_UL_DOUBLE = 0x00000040,
            FA_UL_WORDSONLY = 0x00000080,
            FA_UL_REDZIGZAG = 0x00010000,

            // TX_SETFONTATTR only:
            FA_UL_NOWORDSONLY = 0x00000200,
            FA_NOBOLD = 0x00000400,
            FA_NOITALIC = 0x00000800,
            FA_NOUNDERLINE = 0x00001000,
            FA_NOSTRIKEOUT = 0x00002000,
            FA_UL_NODOUBLE = 0x00004000,
            FA_UL_NOREDZIGZAG = 0x00020000,

            // TX_GETFONTATTR only:
            FA_PARTIALNORMAL = 0x00000200,
            FA_PARTIALBOLD = 0x00000400,
            FA_PARTIALITALIC = 0x00000800,
            FA_PARTIALUNDERLINE = 0x00001000,
            FA_PARTIALSTRIKEOUT = 0x00002000,
            FA_UL_PARTIALDOUBLE = 0x00004000,
            FA_UL_PARTIALWORDSONLY = 0x00008000,
            FA_UL_PARTIALREDZIGZAG = 0x00020000;

        #endregion
    }
}
