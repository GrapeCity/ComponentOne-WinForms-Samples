using C1.Win.C1Input;
using C1.Win.TreeView;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace CustomEditors
{
    public class CustomColorPicker: C1ColorPicker, IC1TreeEditor
    {
        public override object C1EditorGetValue()
        {
            return Color;
        }

        public override void C1EditorInitialize(object value, IDictionary attrs)
        {            
            AutoSize = false;
            TabStop = false;
            
            if (attrs.Contains("BackColor"))
                BackColor = (Color)attrs["BackColor"];
            if (attrs.Contains("Font"))
                Font = (Font)attrs["Font"];
            if (attrs.Contains("ForeColor"))
                ForeColor = (Color)attrs["ForeColor"];
            if (attrs.Contains("DisabledForeColor"))
                ForeColor = (Color)attrs["DisabledForeColor"];
            if (attrs.Contains("MaxLength"))
                MaxLength = (int)attrs["MaxLength"];
        
            Color = (Color)value;
        }

        public override bool C1EditorKeyDownFinishEdit(KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                return true;
            return false;
        }

        public void C1EditorSetFormat(string format)
        {

        }

        public override void C1EditorUpdateBounds(Rectangle rc)
        {
            Bounds = rc;
        }

        public override bool C1EditorValueIsValid()
        {
            return true;
        }
    }
}
