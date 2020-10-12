//----------------------------------------------------------------------------
// RegexTextBox.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace FlexReportDesignerApp.Util
{
	/// <summary>
	/// Textbox with regular-expression styling.
	/// 
	/// The styling includes forecolor and font, and is applied to matches
	/// found for regular expressions.
	/// 
	/// The main property in the control is the SyntaxDescriptors list, which 
	/// contains a list of SyntaxDescriptor objects, each with a regular expression
	/// and the color/font that goes with this item.
	/// 
	/// If the regular expression contains a group called 'match', the style
	/// is applied only to that group. Otherwise, it is applied to the entire
	/// expression.
	/// 
	/// For example:
	/// 
	/// 1) Regex for strings enclosed in double quotes ("hello"):
	///		@"""[^""\n]*"""
	///	2) Regex for c-style comments (/* hello */):
	///		@"/\*\[&\*]\*/"
	///	3)Regex for c++-style comments (// hello):
	///	    @"(?m)//.*$"
	///	4) Regex for expressions in parenthesis (excluding the parenthesis (hello)):
	///	    @"\((?<match>[^)(]+)\)"
	///	5) Regex for case-insensitive keywords (new, public, etc):
	///	    @"(?i)(^|\W)(?<match>true|false|new|private|public)(?=$|\W)"
	/// </summary>
    public class RegexTextBox : RichTextBoxEx 
	{
		//------------------------------------------------------------------------
		#region ** fields

		// regex styling members
        private SortedList<string, SyntaxDescriptor> _syntaxDescriptors = new SortedList<string, SyntaxDescriptor>();
		private bool			_parsing = false;
        private Timer           _timer;

		// undo/redo members
		private ArrayList		_undoList = new ArrayList();
		private Stack			_redoStack = new Stack();
		private bool			_isUndo = false;
		private UndoRedoInfo	_lastUndoInfo = new UndoRedoInfo(string.Empty, new POINT(), 0);
		private int				_maxUndoSteps = 50;

		#endregion

		//------------------------------------------------------------------------
		#region Add/remove syntax descriptors
        public void AddSyntaxDescriptor(string name, SyntaxDescriptor sd)
        {
            _syntaxDescriptors.Add(name, sd);
        }

        public void RemoveSyntaxDescriptor(string name)
        {
            _syntaxDescriptors.Remove(name);
        }

        public void ClearSyntaxDescriptors()
        {
            _syntaxDescriptors.Clear();
        }
		#endregion

		//------------------------------------------------------------------------
		#region ** undo/redo

		public int MaxUndoRedoSteps 
		{
			get { return _maxUndoSteps; }
			set { _maxUndoSteps = value; }
		}
		public new bool CanUndo 
		{
			get { return _undoList.Count > 0;}
		}
		public new bool CanRedo
		{
			get { return _redoStack.Count > 0; }
		}
		private void LimitUndo()
		{
			while (_undoList.Count > _maxUndoSteps)
			{
				_undoList.RemoveAt(_maxUndoSteps);
			}
		}
		public new void Undo()
		{
			if (CanUndo)
			{
				_isUndo = true;
				_redoStack.Push(new UndoRedoInfo(Text, GetScrollPos(), SelectionStart));
				UndoRedoInfo info = (UndoRedoInfo)_undoList[0];
				_undoList.RemoveAt(0);
				Text = info.Text;
				SelectionStart = info.SelectionStart;
				SetScrollPos(info.ScrollPos);
				_lastUndoInfo = info;
				_isUndo = false;
			}
		}
		public new void Redo()
		{
			if (CanRedo)
			{
				_isUndo = true;
				_undoList.Insert(0,new UndoRedoInfo(Text, GetScrollPos(), SelectionStart));
				LimitUndo();
				UndoRedoInfo info = (UndoRedoInfo)_redoStack.Pop();
				Text = info.Text;
				SelectionStart = info.SelectionStart;
				SetScrollPos(info.ScrollPos);
				_isUndo = false;
			}
		}
		private class UndoRedoInfo
		{
			public readonly POINT ScrollPos;
			public readonly int SelectionStart;
			public readonly string Text;
			public UndoRedoInfo(string text, POINT scrollPos, int selStart)
			{
				Text = text;
				ScrollPos = scrollPos;
				SelectionStart = selStart;
			}
		}
        public new void ClearUndo()
        {
            ClearUndo(string.Empty);
        }
        public void ClearUndo(string initialText)
        {
            _undoList.Clear();

            if (base.IsHandleCreated) // base.ClearUndo() does nothing unless handle has been created
                base.ClearUndo();
            else
                base.HandleCreated += RegexTextBox_HandleCreated;

            _lastUndoInfo = new UndoRedoInfo(initialText, new POINT(), 0);
        }
        private void RegexTextBox_HandleCreated(object sender, EventArgs e)
        {
            base.ClearUndo();
            base.HandleCreated -= RegexTextBox_HandleCreated;
        }
		#endregion

		//------------------------------------------------------------------------
		#region ** overrides
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            if (_timer != null)
            {
                _timer.Enabled = false;
                _timer.Tick -= _timer_Tick;
                _timer.Dispose();
                _timer = null;
            }
        }

		public override void Refresh()
		{
			RefreshStyles();
			base.Refresh();
		}
        bool _keyPress;
		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			_keyPress = true;
			base.OnKeyPress(e);
		}
		protected override void OnKeyDown(KeyEventArgs e)
		{
            if (e.KeyData == (Keys.Control | Keys.Z))
            {
                Undo();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            else if (e.KeyData == (Keys.Control | Keys.Y))
            {
                Redo();
                e.Handled = true;
                e.SuppressKeyPress = true; // suppress the beep
            }
            else if (e.KeyCode == Keys.Delete)
			{
				_keyPress = true;
			}
			base.OnKeyDown(e);
		}
		protected override void OnSelectionChanged(EventArgs e)
		{
			// suppress notifications while parsing
			if (!_parsing)
			{
				base.OnSelectionChanged(e);
			}
		}
		protected override void OnTextChanged(EventArgs e)
		{
			// suppress notifications while parsing
            if (!_parsing)
            {
                // save undo info
                if (!_isUndo)
                {
                    _redoStack.Clear();
                    _undoList.Insert(0, _lastUndoInfo);
                    LimitUndo();
                    _lastUndoInfo = new UndoRedoInfo(Text, GetScrollPos(), SelectionStart);
                }

                // update styles
                if (_timer == null)
                {
                    _timer = new Timer();
                    _timer.Interval = 250;
                    _timer.Enabled = false;
                    _timer.Tick += new EventHandler(_timer_Tick);
                }
                _timer.Enabled = false;
                _timer.Enabled = true;

                // fire event
                base.OnTextChanged(e);
            }
		}
        void _timer_Tick(object sender, EventArgs e)
        {
            _timer.Enabled = false;
            RefreshStyles();
            _timer.Enabled = false;
        }
		#endregion

		//------------------------------------------------------------------------
		#region ** private stuff

        private void RefreshStyles()
        {
            // Note: this code was only called if (_syntaxDescriptors.Count > 0) - but that didn't work if
            // we switched syntax highlight off. Hence do it anyway.
            SendMessage(Handle, WM_SETREDRAW, 0, IntPtr.Zero);

            // save state
            POINT scrollPos = GetScrollPos();
            int selStart = SelectionStart;
            int selLength = SelectionLength;

            // apply syntax styles
            _parsing = true;
            ApplyStyles();
            _parsing = false;

            // restore cursor and scrollbars location.
            Select(selStart, selLength);
            SetScrollPos(scrollPos);
            SendMessage(Handle, WM_SETREDRAW, 1, IntPtr.Zero);

            // update scrollbars
            SetWindowPos(Handle, IntPtr.Zero, 0, 0, 0, 0, SWP_FLAGS);
            Invalidate();
        }
        private void ApplyStyles()
        {
            // get text
            string text = Text;

            // get range to format
            // (could be the whole thing or just the neighborhood of the last keypress)
            int rangeStart = 0;
            int rangeEnd   = text.Length - 1;
			if (_keyPress)
			{
				_keyPress = false;
				int pos = SelectionStart;
				rangeStart = Math.Max(0, pos - 100);
				rangeEnd = Math.Min(text.Length - 1, pos + 100);
			}

            // reset all color/font
            Select(rangeStart, rangeEnd - rangeStart + 1);
            SelectionColor = ForeColor;
            SelectionFont = Font;

            // apply all descriptors
            foreach (SyntaxDescriptor sd in _syntaxDescriptors.Values)
            {
                // if there's a group called 'match', use it;
                // otherwise, use the first one
                int gIndex = sd.Regex.GroupNumberFromName("match");
                if (gIndex < 0) gIndex = 0;

                // find all matches for this descriptor
                for (Match match = sd.Regex.Match(text); match.Success; match = match.NextMatch())
                {
                    // apply descriptor style for this match
                    Group g = match.Groups[gIndex];
                    foreach (Capture c in g.Captures)
                    {
                        if (c.Index + c.Length >= rangeStart && c.Index <= rangeEnd)
                        {
                            ApplyStyle(sd, c);
                        }
                    }
                }
            }
        }
        private void ApplyStyle(SyntaxDescriptor sd, Capture c)
        {
            Select(c.Index, c.Length);
            if (SelectionColor.ToArgb() == ForeColor.ToArgb() && 
                SameFont(SelectionFont, Font))
            {
                if (sd.Color != ForeColor)
                    SelectionColor = sd.Color;
                if (sd.Font != null)
                    SelectionFont = sd.Font;
            }
        }
        private static bool SameFont(Font f1, Font f2)
		{
            // handle case where fonts are null
            if (f1 == null && f2 == null) return true;
            if (f1 != null && f2 != null)
            {
                return
                    f1.Style == f2.Style &&
                    f1.Size == f2.Size &&
                    f1.Name == f2.Name;
            }
            return false;
		}

		#endregion

		//------------------------------------------------------------------------
		#region ** low-level stuff

        private POINT GetScrollPos()
		{
			POINT pt = new POINT();
			SendMessage(Handle, EM_GETSCROLLPOS, 0, ref pt);
			return pt;
		}
		private void SetScrollPos(POINT pt)
		{
			SendMessage(Handle, EM_SETSCROLLPOS, 0, ref pt);
		}
		private const int 
			WM_PAINT		= 0x000f,
			WM_NCPAINT		= 0x0085,
			WM_VSCROLL		= 0x0115,
			WM_SETREDRAW    = 0x000b,
			WM_USER			= 0x0400,
			EM_GETSCROLLPOS	= WM_USER + 221,
			EM_SETSCROLLPOS = WM_USER + 222;

		private const int
			SWP_NOSIZE          = 0x0001,
			SWP_NOMOVE          = 0x0002,
			SWP_NOZORDER        = 0x0004,
			SWP_NOREDRAW        = 0x0008,
			SWP_NOACTIVATE      = 0x0010,
			SWP_FRAMECHANGED    = 0x0020,
			SWP_SHOWWINDOW      = 0x0040,
			SWP_HIDEWINDOW      = 0x0080,
			SWP_NOCOPYBITS      = 0x0100,
			SWP_NOOWNERZORDER   = 0x0200,
			SWP_NOSENDCHANGING  = 0x0400,
			SWP_FLAGS = SWP_FRAMECHANGED | SWP_NOACTIVATE | 
				SWP_NOMOVE | SWP_NOSIZE | SWP_NOOWNERZORDER | SWP_NOZORDER;
		public struct POINT
		{
			public int x;
			public int y;
		}
        [DllImport("user32")] private static extern int LockWindowUpdate(IntPtr hwnd);
        [DllImport("user32")] private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, ref POINT pt);
        [DllImport("user32")] private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, IntPtr lParam);
		[DllImport("user32")] private static extern int SetWindowPos(IntPtr hwnd, IntPtr hwndInsertAfter, int X, int Y, int cx, int cy, int uFlags);
 
		#endregion
	}

	/// <summary>
	/// Class used to associate syntax elements to display attributes (font/color).
	/// </summary>
	public class SyntaxDescriptor
	{
		#region Public properties
        public Regex Regex { get; private set; }
        public Color Color { get; private set; }
        public Font Font { get; private set; }
		#endregion

		#region ctors
		public SyntaxDescriptor(Regex regex, Color color, Font font)
		{
			Regex = regex;
			Color = color;
			Font = font;
		}
		public SyntaxDescriptor(Regex regex, Color color) :
			this(regex, color, null) {}
		public SyntaxDescriptor(string regex, Color color, Font font) :
			this(new Regex(regex), color, font) {}
		public SyntaxDescriptor(string regex, Color color) :
			this(regex, color, null) {}
		#endregion
	}
}
