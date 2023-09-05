//----------------------------------------------------------------------------
// CodeCompleteWindow.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) Mescius, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
#if CLR40 || CLR45
using System.Linq;
#endif

using C1.Win.C1Command;
using C1.Win.Localization;
using C1.Win.C1InputPanel;
using C1.Util.Win;
using C1.Win.C1SuperTooltip;
using FlexReportDesignerApp.Util;


namespace FlexReportDesignerApp.Forms
{
    public class CodeCompleteContext
    {
        public CodeCompleteKind Kind { get; set; }
        public int WordPosition { get; set; }
        public int WordLength { get; set; }
        public string GetWord(RegexTextBox textbox)
        {
            try
            {
                return textbox.Text.Substring(WordPosition, WordLength);
            }
            catch
            {
                return string.Empty;
            }
        }
        public IList<ScriptSyntaxItem> SyntaxItems { get; set; }
    }

    public enum CodeCompleteKind
    {
        None, // invoked ty Ctrl-J
        DbFields, // invoked by '['
    }

    public interface ICodeCompleteWindowOwner
    {
        Form MasterForm { get; }
        Control EditorControl { get; }
        void OnClosed();
        void InsertText(string text, CodeCompleteContext context);
        string GetContextWord(CodeCompleteContext context);
    }

    public class NonFocusingListBox : ListBox
    {
        int _oldIndex = -1;
        CodeCompleteWindow _parent = null;

        internal NonFocusingListBox(CodeCompleteWindow parent)
        {
            _parent = parent;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= Win32.WS_EX.WS_EX_NOACTIVATE;
                return cp;
            }
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Win32.WM.WM_MOUSEACTIVATE)
            {
                var ht = Win32.LOWORDU(m.LParam);
                if (ht == Win32.HT.HTCLIENT)
                {
                    m.Result = (IntPtr)Win32.MA.MA_NOACTIVATEANDEAT;
                    var mp = this.PointToClient(Control.MousePosition);
                    var idx = this.IndexFromPoint(mp);
                    if (idx >= 0 && idx < this.Items.Count)
                    {
                        if (_oldIndex == idx) // we are on the same element, we can accept and close
                            _parent.AcceptAndClose();
                        else
                        {
                        this.SelectedIndex = idx;
                            _oldIndex = idx;
                        }
                    }
                }
                else
                    m.Result = (IntPtr)Win32.MA.MA_NOACTIVATE;
            }
            else
                base.WndProc(ref m);
        }
        public bool SelectIndex(int index, bool center)
        {
            if (index < 0 || index >= this.Items.Count)
            {
                this.SelectedIndex = -1;
                return false;
            }
            else
            {
                if (center)
                {
                    int th = (this.Height / this.ItemHeight) / 2;
                    this.TopIndex = (int)Math.Max(0, index - th);
                }
                this.SelectedIndex = index;
                _oldIndex = index;
                return true;
            }
        }
    }

    /// <summary>
    /// This is used to catch mouse clicks on e.g. editor window's title etc.
    /// </summary>
    internal class MouseDownFilter : IMessageFilter
    {
        public event EventHandler MouseClicked;

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == Win32.WM.WM_LBUTTONDOWN || m.Msg == Win32.WM.WM_MBUTTONDOWN || m.Msg == Win32.WM.WM_RBUTTONDOWN)
                OnFormClicked();
            return false;
        }

        protected void OnFormClicked()
        {
            if (MouseClicked != null)
                MouseClicked(this, EventArgs.Empty);
        }
    }

    /// <summary>
    /// Code completion window - the small popup window with the list of possible completions.
    /// </summary>
    internal class CodeCompleteWindow : Form
    {
        private ICodeCompleteWindowOwner _owner = null;
        private NonFocusingListBox _list = null;
        private int _lastSelectedIndex = -1;
        private CodeCompleteContext _context;
        private MouseDownFilter _mouseFilter = null;
        private static StringFormat s_StringFormat;
        //
        // 0 - func/prop name
        // 1 - description
        // 2 - class/category/etc
        private const string c_TooltipFmt =
            // Prototype itself:
            @"<div ><b>{0}</b></div>" +
            // Description:
            @"<div style='margin: 1px 10px; '>{1}</div>" +
            // Class description (.net prop or method, vbs, c1report etc):
            @"<div style='margin: 6px 1px 1px 1px; '><i>{2}</i></div>";

        static CodeCompleteWindow()
        {
            s_StringFormat = new StringFormat(StringFormat.GenericDefault);
            s_StringFormat.LineAlignment = StringAlignment.Center;
        }

        public CodeCompleteWindow(ICodeCompleteWindowOwner owner, CodeCompleteContext context)
        {
            System.Diagnostics.Debug.Assert(owner != null && owner.MasterForm != null);

            _owner = owner;
            _context = context;
            this.Owner = _owner.MasterForm;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.Manual;

            _list = new NonFocusingListBox(this);
            // set up owner draw:
            _list.DrawMode = DrawMode.OwnerDrawVariable;
            _list.DrawItem += _list_DrawItem;
            _list.FontChanged += _list_FontChanged;
            //
            foreach (var item in _context.SyntaxItems)
                _list.Items.Add(item);

            _list.Dock = DockStyle.Fill;
            _list.SelectionMode = SelectionMode.One;
            _list.SelectedIndexChanged += _list_SelectedIndexChanged;
            //
            this.Controls.Add(_list);

            this.Owner.Deactivate += (ss, ee) => this.Close();
            this.Owner.Move += (ss, ee) => this.Close();
            owner.EditorControl.LostFocus += (ss, ee) => this.Close();
            owner.EditorControl.MouseDown += (ss, ee) => this.Close();
            // close on mouse down in e.g. ribbon etc:
            _mouseFilter = new MouseDownFilter();
            _mouseFilter.MouseClicked += mouseFilter_MouseClicked;
            Application.AddMessageFilter(_mouseFilter);
        }

        protected override void OnClosed(EventArgs e)
        {
            if (_mouseFilter != null)
            {
                Application.RemoveMessageFilter(_mouseFilter);
                _mouseFilter = null;
            }
            base.OnClosed(e);
            _owner.OnClosed();
        }

        void mouseFilter_MouseClicked(object sender, EventArgs e)
        {
            if (!this.DesktopBounds.Contains(Control.MousePosition))
                this.Close();
        }

        void _list_FontChanged(object sender, EventArgs e)
        {
            using (var g = this.CreateGraphics())
                _list.ItemHeight = (int)g.MeasureString("I", _list.Font).Height;
        }

        void _list_DrawItem(object sender, DrawItemEventArgs e)
        {
            const int C16 = 16;
            e.DrawBackground();
            e.DrawFocusRectangle();
            var r = e.Bounds;
            r.Offset(C16, 0);
            r.Width -= C16;

            var item = (ScriptSyntaxItem)_list.Items[e.Index];
            using (var b = new SolidBrush(e.ForeColor))
                e.Graphics.DrawString(item.ToString(), e.Font, b, r, s_StringFormat);

            var image = ScriptSyntaxItem.ItemTypeImages[item.ItemType];
            if (image != null)
            {
                var p = e.Bounds.Location;
                p.Offset(1, (_list.ItemHeight - image.Height) / 2);
                e.Graphics.DrawImage(image, p);
            }
        }
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= Win32.WS_EX.WS_EX_NOACTIVATE | Win32.WS_EX.WS_EX_TOPMOST | Win32.WS_EX.WS_EX_TOOLWINDOW;
                cp.Style |= Win32.WS.WS_POPUP;
                return cp;
            }
        }

        void _list_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_list.SelectedIndex < 0 || _list.SelectedIndex >= _list.Items.Count)
                return;

            _lastSelectedIndex = _list.SelectedIndex;
            var rc = _list.GetItemRectangle(_list.SelectedIndex);

            // tooltip
            var item = _list.SelectedItem as ScriptSyntaxItem;
            if (item != null && ToolTip != null)
            {
                string tt = string.Format(c_TooltipFmt, item.TooltipProto, item.Description ?? string.Empty, ScriptSyntaxItem.ItemTypeDescriptions[item.ItemType]);
                ToolTip.Show(tt, _list, new Point(this.Width, rc.Top), 0);
            }
        }

        public CodeCompleteContext Context { get { return _context; } }

        public C1SuperTooltip ToolTip { get; set; }

        public new void Show()
        {
            Win32.SetWindowPos(this.Handle, (IntPtr)Win32.HWND_TOPMOST, this.Left, this.Top, this.Width, this.Height, Win32.SWP.SWP_NOACTIVATE);
            Win32.ShowWindow(this.Handle, (int)Win32.SW.SW_SHOWNOACTIVATE);
            _list.SelectIndex(0, false);
        }

        public bool HandleKeyDown(KeyEventArgs e)
        {
            System.Diagnostics.Debug.Assert(_list.Items.Count > 0);

            switch (e.KeyData)
            {
                case Keys.Up:
                    _list.SelectIndex((_list.SelectedIndex > 0) ? _list.SelectedIndex - 1 : (_lastSelectedIndex != -1 ? _lastSelectedIndex : 0), false);
                    return true;
                case Keys.Down:
                    _list.SelectIndex((_list.SelectedIndex < _list.Items.Count - 1) ? _list.SelectedIndex + 1 : (_lastSelectedIndex != -1 ? _lastSelectedIndex : 0), false);
                    return true;
                case Keys.PageUp:
                    _list.SelectIndex(Math.Max(0, (_list.SelectedIndex != -1 ? _list.SelectedIndex : _lastSelectedIndex) - (int)(_list.Height / _list.ItemHeight)), true);
                    return true;
                case Keys.PageDown:
                    _list.SelectIndex(Math.Min(_list.Items.Count - 1, (_list.SelectedIndex != -1 ? _list.SelectedIndex : _lastSelectedIndex) + (int)(_list.Height / _list.ItemHeight)), true);
                    return true;
                case Keys.Escape:
                    this.Close();
                    return true;
                case Keys.Enter:
                case Keys.Tab:
                    return AcceptAndClose();
                default:
                    return false;
            }
        }

        public bool AcceptAndClose()
        {
            var item = _list.SelectedItem as ScriptSyntaxItem;
            if (item != null)
            {
                _owner.InsertText(item.Prototype, _context);
                this.Close();
                return true;
            }
            else
            {
                this.Close();
                return false;
            }
        }

        private void Filter(string word)
        {
            ScriptSyntaxItem lastItem;
            if (_list.SelectedItem != null)
                lastItem = (ScriptSyntaxItem)_list.SelectedItem;
            else if (_lastSelectedIndex >= 0 && _lastSelectedIndex < _list.Items.Count)
                lastItem = (ScriptSyntaxItem)_list.Items[_lastSelectedIndex];
            else
                lastItem = new ScriptSyntaxItem() { ItemType = ScriptSyntaxItemType.None, Prototype = "" };

            if (ToolTip != null)
                ToolTip.Hide();

            _list.SuspendLayout();
            _list.Items.Clear();
            if (string.IsNullOrEmpty(word))
            {
                foreach (var item in _context.SyntaxItems)
                    _list.Items.Add(item);
            }
            else
            {
                // make sure 'word' is a good regex:
                word = Regex.Replace(word, @"[^\w\[]", "");
                word = word.Replace("[", "\\[");
                //
                List<ScriptSyntaxItem> filtered = new List<ScriptSyntaxItem>();
                foreach (var item in _context.SyntaxItems)
                    if (Regex.IsMatch(item.ToString(), word, RegexOptions.IgnoreCase))
                        _list.Items.Add(item);
                if (_list.Items.Count == 0)
                    _list.Items.Add(lastItem);
            }
            _list.ResumeLayout();
        }

        public void UpdateFilter()
        {
            string word = _owner.GetContextWord(Context);
            Filter(word);
            UpdateCurrentPosition(word);
        }

        public void UpdateCurrentPosition(string word = null)
        {
            if (word == null)
                word = _owner.GetContextWord(Context);
            _list.SelectIndex(_list.FindString(word), true); // note: this just deselects all, ideally we need to keep some indication if (idx != ListBox.NoMatches)
            if (_list.SelectedItem == null)
                _lastSelectedIndex = 0;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case (int)Win32.WM.WM_ACTIVATE:
                    if (this.Owner != null)
                    {
                        if ((((uint)m.WParam) & 0x1111) != 0) // != WA_INACTIVE
                        {
                            // our window is being activated - make sure our master does not
                            // lose "active" border
                            if (this.Owner.IsMdiChild && this.Owner.MdiParent != null)
                                Win32.SendMessage(this.Owner.MdiParent.Handle, (int)Win32.WM.WM_NCACTIVATE, 1, 0);
                            else
                                Win32.SendMessage(this.Owner.Handle, (int)Win32.WM.WM_NCACTIVATE, 1, 0);
                        }
                        else
                        {
                            // our form is being deactivated
                            // note: "eating" this message results in menu left when its app is inactive
                            // e.g. when a control was focused in the menu when the switch took place.
                            if (this.Owner.IsMdiChild && this.Owner.MdiParent != null)
                            {
                                // dima/todo/patch: what is this doing??? do we really need the break afterwards?
                                Win32.SendMessage(this.Owner.MdiParent.Handle, (int)Win32.WM.WM_NCLBUTTONDOWN, 1, 0);
                                break;
                            }
                        }
                    }
                    base.WndProc(ref m);
                    break;
                case (int)Win32.WM.WM_ERASEBKGND:
                    break;
                case (int)Win32.WM.WM_MOUSEACTIVATE:
                    m.Result = (IntPtr)Win32.MA.MA_NOACTIVATE;//ANDEAT;
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
    }
}
