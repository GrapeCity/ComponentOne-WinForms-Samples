//----------------------------------------------------------------------------
// ColorEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using C1.Win.C1Input;

namespace FlexReportDesignerApp.Controls.Background.Editors
{
    internal class ColorEditor : DropDownEditorBase
    {
        private const bool c_DefAllowTransparent = true;
        private const bool c_DefAllowEmpty = false;

        private bool _allowTransparent = c_DefAllowTransparent;
        private bool _allowEmpty = c_DefAllowEmpty;
        private string _emptyColorCaption;

        #region Constructors
        public ColorEditor()
        {
            VisibleButtons = DropDownControlButtonFlags.DropDown | DropDownControlButtonFlags.Modal;
        }
        #endregion

        #region Protected
        protected override void ValueToText(
            ValueToTextArgs e)
        {
            e.Text = Utils.GetColorDisplayText((Color)e.Value, _emptyColorCaption);
        }

        protected override bool TextToValue(
            TextToValueArgs e)
        {
            if (string.IsNullOrEmpty(e.Text))
            {
                e.Value = Color.Transparent;
                return true;
            }

            Color color;
            if (!Utils.TryParseColorFromDisplayText(e.Text, _emptyColorCaption, out color))
                return false;

            if (color == Color.Transparent && !AllowTransparent)
                return false;
            if (color.IsEmpty && !AllowEmpty)
                return false;

            e.Value = color;
            return true;
        }

        protected override void OnModalButtonClick(
            EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                Color c = ColorValue;

                    // standard ColorDialog does not support Transparent color
                    // so replace Transparent with White
                    if (c == Color.Transparent)
                        cd.Color = Color.White;
                    else
                        cd.Color = c;
                
                if (cd.ShowDialog(this) == DialogResult.OK)
                {
                    SetEditorValue(cd.Color);
                }
            }
        }

        protected override int GetIconWidth()
        {
            return c_IconWidth;
        }

        protected override void DrawIcon(
            Graphics g,
            Rectangle bounds)
        {
            Utils.DrawColorMark(g, ColorValue, true, bounds);
        }
        
        internal override object GetEditorValue()
        {
            return Value;
        }

        internal override void SetEditorValue(object value)
        {
            if (value == null)
                value = Color.Transparent;
            base.SetEditorValue(value);
        }

        #endregion

        #region Protected properties
        protected override CreationTime DropDownFormCreationTime
        {
            get { return CreationTime.OnFirstCall; }
        }

        protected override string DefaultDropDownFormClassName
        {
            get { return "FlexReportDesignerApp.Controls.Background.Editors.ColorDropDownForm"; }
        }
        #endregion

        #region Public properties
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool AllowTransparent
        {
            get { return _allowTransparent; }
            set { _allowTransparent = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool AllowEmpty
        {
            get { return _allowEmpty; }
            set { _allowEmpty = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string EmptyColorCaption
        {
            get { return _emptyColorCaption; }
            set
            {
                if (_emptyColorCaption == value)
                    return;
                _emptyColorCaption = value;
                Invalidate();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ColorDropDownForm DropDownForm
        {
            get { return (ColorDropDownForm)base.DropDownForm; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color ColorValue
        {
            get
            {
                var value = EditorValue;
                if (value == null || value == DBNull.Value) return Color.Transparent;
                return (Color) value;
            }
            set { EditorValue = value; }
        }
        #endregion
    }
}
