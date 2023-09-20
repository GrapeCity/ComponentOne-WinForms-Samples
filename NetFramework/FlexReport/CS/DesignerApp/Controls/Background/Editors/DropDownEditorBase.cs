//----------------------------------------------------------------------------
// DropDownEditorBase.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using C1.Win.C1Input;

namespace FlexReportDesignerApp.Controls.Background.Editors
{
    internal class DropDownEditorBase : C1DropDownControl
    {
        public const int c_IconContentOffset = 2;
        public const int c_IconWidth = 20;

        private bool _disableCheckValidation;
        private bool _disableLeave;
        protected string m_AllowedChars;

        #region Constructors
        public DropDownEditorBase()
        {
            VisibleButtons = DropDownControlButtonFlags.DropDown;
            DisplayFormat.FormatType = FormatTypeEnum.UseEvent;
            EditFormat.FormatType = FormatTypeEnum.UseEvent;
            ParseInfo.FormatType = FormatTypeEnum.UseEvent;
            DataType = typeof(object);
            InterceptArrowKeys = true;
            AcceptsTab = true;
        }
        #endregion

        #region Protected

        protected void AddAllowedChars(
            string s,
            bool lowerCase,
            bool upperCase)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (lowerCase)
                {
                    char c = char.ToLower(s[i]);
                    if (m_AllowedChars.IndexOf(c) == -1)
                        m_AllowedChars += c;
                }
                if (upperCase)
                {
                    char c = char.ToUpper(s[i]);
                    if (m_AllowedChars.IndexOf(c) == -1)
                        m_AllowedChars += c;
                }
            }
        }

        protected void AddAllowedChars(
            string s)
        {
            AddAllowedChars(s, true, true);
        }

        protected virtual void OnEditorValueChanged()
        {
            if (EditorValueChanged != null)
                EditorValueChanged(this, EventArgs.Empty);
        }

        protected override void ProcessKeyPress(
            KeyPressEventArgs e)
        {
            if (!string.IsNullOrEmpty(m_AllowedChars))
            {
                if (e.KeyChar != 13 && e.KeyChar != 8 && m_AllowedChars.IndexOf(e.KeyChar) == -1)
                {
                    // invalid character, simple exit
                    e.Handled = true;
                    return;
                }
            }

            base.ProcessKeyPress(e);
        }

        /// <summary>
        /// Should be overridden in deviced class and convert string to value.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        protected virtual bool TextToValue(
            TextToValueArgs e)
        {
            throw new Exception("TextToValue() should be overridden in derived class.");
        }

        protected override void OnParsing(
            ParseEventArgs e)
        {
            if (SuppressTextInput)
            {
                // this is readonly control like ImageEdit, BackgroundEdit, text
                // of such control can not be changed by the user
                // so parsing is not needed
                e.Value = null;
                e.Succeeded = false;
            }
            else
            {
                var ttva = new TextToValueArgs(e.Text);
                if (TextToValue(ttva))
                {
                    e.Value = ttva.Value;
                    e.Succeeded = true;
                }
                else
                {
                    e.Succeeded = false;
                    e.ParseInfo.ErrorMessage = ttva.ErrorMessage;
                }
            }
            base.OnParsing(e);
        }

        /// <summary>
        /// Should be overridden in derived class and convert value to string.
        /// Called only from OnFormatting(...) method.
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        protected virtual void ValueToText(
            ValueToTextArgs e)
        {
            throw new Exception("ValueToText() should be overridden in derived class.");
        }

        protected override void OnFormatting(
            FormatEventArgs e)
        {
            e.Succeeded = true;

            var value = e.Value;
            if (value == null)
                e.Text = string.Empty;
            else
            {
                    var vtta = new ValueToTextArgs(value, e.Target);
                    ValueToText(vtta);
                    e.Text = vtta.Text;
            }
            base.OnFormatting(e);
        }

        protected override void OnValueChanged(EventArgs e)
        {
            base.OnValueChanged(e);

            _disableLeave = true;
            OnEditorValueChanged();
            _disableLeave = false;
        }

        protected override void OnLeave(
            EventArgs e)
        {
            if (_disableLeave)
                return;

            _disableCheckValidation = true;
            try
            {
                base.OnLeave(e);
            }
            finally
            {
                _disableCheckValidation = false;
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                UpdateValueWithCurrentText();
            }

            return base.ProcessDialogKey(keyData);
        }

        protected override void OnKeyPress(
            KeyPressEventArgs e)
        {
            if (SuppressTextInput)
            {
                e.Handled = true;
                return;
            }
            base.OnKeyPress(e);
        }

        protected override void OnKeyDown(
            KeyEventArgs e)
        {
            if (SuppressTextInput)
            {
                if (e.KeyData == Keys.Delete)
                {
                    base.OnKeyDown(e);
                    e.Handled = true;
                    return;
                }
            }

            base.OnKeyDown(e);
        }

       
        protected virtual HitTestEx GetHitTest(
            MouseEventArgs e)
        {
            return HitTestEx.Inside;
        }

        protected override void OnMouseLeave(
            EventArgs e)
        {
            base.OnMouseLeave(e);
#if skip_dima // seems to be unused
            _hitTest = HitTestEx.None;
#endif
        }

        protected virtual int GetIconWidth()
        {
            return -1;
        }

        protected virtual void DrawIcon(
            Graphics g,
            Rectangle bounds)
        {
        }

        protected override Size GetImageSize()
        {
            Size sz = Size.Empty;
            sz.Width += GetIconWidth() + c_IconContentOffset;
            return sz;
        }

        protected override void DrawImage(
            Graphics g,
            IntPtr dc,
            Rectangle bounds)
        {
            Rectangle r = bounds;

            // icon
            int iconWidth = GetIconWidth();
            if (iconWidth > 0)
            {
                r.Y = bounds.Top;
                r.Height = bounds.Height - 2;

                r.Width = iconWidth;
                DrawIcon(g, r);
            }
        }

        protected object ParseContent()
        {
            object value;
            if (ParseContent(out value, ErrorInfo) != ErrorReasonEnum.NoErrors)
                return null;
            return value;
        }

        internal virtual object GetEditorValue()
        {
            return Value;
        }

        internal virtual void SetEditorValue(
            object value)
        {
            Value = value;
            Refresh();
        }

        #endregion

        #region Protected properties
        protected virtual bool EnterUpdatesValue
        {
            get { return true; }
        }

        protected virtual bool UpdateEditorValueOnValueChanged
        {
            get { return true; }
        }

        protected override bool ShowImage
        {
            get
            {
                return GetIconWidth() > 0;
            }
        }
        #endregion

        public event EventHandler EditorValueChanged;

        #region Public

        public virtual bool DoMouseDoubleClick()
        {
            return false;
        }

       #endregion

        #region Public properties
        
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public virtual bool SuppressTextInput
        {
            get { return false; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object EditorValue
        {
            get { return GetEditorValue(); }
            set { SetEditorValue(value); }
        }

        #region Hidden props
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new DropDownControlButtonFlags VisibleButtons
        {
            get { return base.VisibleButtons; }
            set { base.VisibleButtons = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool InterceptArrowKeys
        {
            get { return base.InterceptArrowKeys; }
            set { base.InterceptArrowKeys = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new FormatInfo EditFormat
        {
            get { return base.EditFormat; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new FormatInfo DisplayFormat
        {
            get { return base.DisplayFormat; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ParseInfo ParseInfo
        {
            get { return base.ParseInfo; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new Type DataType
        {
            get { return base.DataType; }
            set { base.DataType = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new PostValidation PostValidation
        {
            get { return base.PostValidation; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new NumericInputKeyFlags NumericInputKeys
        {
            get { return base.NumericInputKeys; }
            set { base.NumericInputKeys = value; }
        }
        #endregion
        #endregion

        #region Nested types
        protected class ValueToTextArgs
        {
            private readonly object _value;
            private string _text;
            private readonly FormatTargetEnum _target;

            #region Constructors
            public ValueToTextArgs(
                object value,
                FormatTargetEnum target)
            {
                _value = value;
                _text = null;
                _target = target;
            }
            #endregion

            #region Public properties
            public string Text
            {
                get { return _text; }
                set { _text = value; }
            }

            public object Value
            {
                get { return _value; }
            }

            public FormatTargetEnum Target
            {
                get { return _target; }
            }
            #endregion
        }

        protected class TextToValueArgs
        {
            private readonly string _text;
            private object _value;
            private bool _emptyValue;
            private string _errorMessage;

            #region Constructors
            public TextToValueArgs(
                string text)
            {
                _text = text;
                _value = null;
                _emptyValue = false;
                _errorMessage = null;
            }
            #endregion

            #region Public properties
            public string Text
            {
                get { return _text; }
            }

            public object Value
            {
                get { return _value; }
                set { _value = value; }
            }

            public bool EmptyValue
            {
                get { return _emptyValue; }
                set { _emptyValue = value; }
            }

            public string ErrorMessage
            {
                get { return _errorMessage; }
                set { _errorMessage = value; }
            }
            #endregion
        }

        protected enum HitTestEx
        {
            None,
            Inside,
        }
        #endregion

        #region IC1EmbeddedEditor overrides
        public override void C1EditorInitialize(
            object value,
            System.Collections.IDictionary attrs)
        {
            base.C1EditorInitialize(value, attrs);
            this.ValueChangedBehavior = ValueChangedBehaviorEnum.Default;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        }

        public override bool C1EditorKeyDownFinishEdit(
            KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.Down ||
                e.KeyData == Keys.PageUp || e.KeyData == Keys.PageDown ||
                e.KeyData == (Keys.Control | Keys.Home) || e.KeyData == (Keys.Control | Keys.End))
                return true;
            if (e.KeyData == Keys.Tab || e.KeyData == (Keys.Tab | Keys.Shift))
                return true;
            if ((e.KeyData & Keys.Return) != 0 || e.KeyData == Keys.Escape)
                // do not finish editing mode in flexgrid, just set or cancel a value
                return false;
            return base.C1EditorKeyDownFinishEdit(e);
        }

        public override bool C1EditorValueIsValid()
        {
            if (!Modified)
                return true;

            object value;
            ErrorReasonEnum ere = ParseContent(out value, ErrorInfo);
            if (ere == ErrorReasonEnum.NoErrors)
                return true;
            if (!_disableCheckValidation)
                CheckValidationResult(ere, ref value, ErrorInfo);
            return false;
        }
        #endregion
    }
}
