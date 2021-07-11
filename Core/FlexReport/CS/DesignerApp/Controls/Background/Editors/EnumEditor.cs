//----------------------------------------------------------------------------
// EnumEditor.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) GrapeCity Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Windows.Forms;
using C1.Win.Input;

namespace FlexReportDesignerApp.Controls.Background.Editors
{
    internal class EnumEditor : DropDownEditorBase
    {
        private Type _enumType;
        private Array _enumValues;
        private string _customString = "Custom";

        #region Constructors
        public EnumEditor()
        {
            DropDownForm.ListBox = CreateListBox();
            //VisibleButtons = DropDownControlButtonFlags.DropDown;
        }
        #endregion

        #region Private
        private int IndexOfValue(
            object obj)
        {
            for (int i = 0; i < _enumValues.Length; i++)
                if (_enumValues.GetValue(i).Equals(obj))
                    return i;
            return -1;
        }

        private void UpdateDropDown()
        {
            DropDownForm.Items.Clear();
            foreach (object v in _enumValues)
                DropDownForm.Items.Add(new DropDownListBox.Item(v.ToString(), v));

            DropDownForm.UpdatePerferedSize(Size);
        }
        #endregion

        #region Protected
        protected override bool TextToValue(TextToValueArgs e)
        {
            if (string.IsNullOrEmpty(e.Text))  return false;

            try
            {
                object v = Enum.Parse(_enumType, e.Text);
                if (IndexOfValue(v) == -1)
                    return false;
                e.Value = v;
                return true;
            }
            catch
            {
                return false;
            }
        }

        protected override void ValueToText(ValueToTextArgs e)
        {
            e.Text = Enum.IsDefined(EnumType, e.Value) ? e.Value.ToString() : CustomString;
        }

        protected virtual DropDownListBox CreateListBox()
        {
            return new DropDownListBox();
        }

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            if (DoMouseDoubleClick())
                return;
            base.OnMouseDoubleClick(e);
        }

        #endregion

        #region Protected properties
        //protected override string DefaultDropDownFormClassName
        //{
        //    get { return "FlexReportDesignerApp.Controls.Background.Editors.ListDropDownForm"; }
        //}
        #endregion

        #region Public
        public T? GetEnumValue<T>() where T : struct
        {
            return (T)Value;
        }

        public override bool DoMouseDoubleClick()
        {
            object value = Value;
            if (Utils.IsNull(value))
                Value = _enumValues.GetValue(0);
            else
            {
                int i = IndexOfValue(value);
                if (i >= _enumValues.Length - 1)
                    i = 0;
                else
                    i = i + 1;
                Value = _enumValues.GetValue(i);
            }
            return true;
        }
        #endregion

        #region Public properties
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Type EnumType
        {
            get { return _enumType; }
            set
            {
                if (_enumType == value)
                    return;

                _enumType = value;

                // build list of supported characters
                m_AllowedChars = string.Empty;
                if (_enumType != null && _enumType.IsEnum)
                {
                    string[] names = Enum.GetNames(_enumType);
                    foreach (string s in names)
                        AddAllowedChars(s);

                    // initialize drop down form values
                    _enumValues = Enum.GetValues(_enumType);
                    UpdateDropDown();
                }
                else
                {
                    _enumValues = new object[0];
                    DropDownForm.Items.Clear();
                }
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Array EnumValues
        {
            get { return _enumValues; }
            set
            {
                _enumValues = value;
                UpdateDropDown();
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string CustomString
        {
            get { return _customString; }
            set { _customString = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ListDropDownForm DropDownForm
        {
            get { return (ListDropDownForm)base.DropDownForm; }
        }

        #endregion
    }
}
