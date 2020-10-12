using C1.Win.TreeView;
using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace CustomEditors
{
    public class CustomDatePicker : DateTimePicker, IC1TreeEditor
    {
        public object C1EditorGetValue()
        {
            return Value;
        }

        public void C1EditorInitialize(object value, IDictionary attrs)
        {
            AutoSize = false;
            TabStop = false;

            Format = DateTimePickerFormat.Short;
                        
            if (attrs.Contains("BackColor"))
                BackColor = (Color)attrs["BackColor"];
            if (attrs.Contains("Font"))
                Font = (Font)attrs["Font"];
            if (attrs.Contains("ForeColor"))
                ForeColor = (Color)attrs["ForeColor"];
            if (attrs.Contains("DisabledForeColor"))
                ForeColor = (Color)attrs["DisabledForeColor"];
            
            Value = (DateTime)value;
        }

        public bool C1EditorKeyDownFinishEdit(KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                return true;
            return false;
        }

        public void C1EditorSetFormat(string format)
        {
        }

        public void C1EditorUpdateBounds(Rectangle rc)
        {
            Bounds = rc;
        }

        public bool C1EditorValueIsValid()
        {
            return true;
        }
    }
}
