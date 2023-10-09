//----------------------------------------------------------------------------
// DropDownListBox.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright ©️ MESCIUS inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System.Windows.Forms;
using System.ComponentModel;


namespace FlexReportDesignerApp.Controls.Background.Editors
{
    internal class DropDownListBox : ListBox
    {
        #region Constructors
        public DropDownListBox()
        {
            IntegralHeight = false;
            BorderStyle = BorderStyle.None;
        }
        #endregion

        #region Public properties
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object Value
        {
            get
            {
                var item = SelectedItem as Item;
                return item == null ? null : item.Value;
            }
            set
            {
                for (int i = 0; i < Items.Count; i++)
                    if (((Item)Items[i]).Value.Equals(value))
                    {
                        SelectedIndex = i;
                        return;
                    }
                SelectedIndex = -1;
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new ObjectCollection Items
        {
            get { return base.Items; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool IntegralHeight
        {
            get { return base.IntegralHeight; }
            set { base.IntegralHeight = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new BorderStyle BorderStyle
        {
            get { return base.BorderStyle; }
            set { base.BorderStyle = value; }
        }
        #endregion

        #region Nested types
        public class Item
        {
            private readonly string _text;
            private readonly object _value;

            #region Constructors
            public Item(
                string text,
                object value)
            {
                _text = text;
                _value = value;
            }
            #endregion

            #region Public
            public override string ToString()
            {
                return _text;
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
            }
            #endregion
        }
        #endregion
    }
}
