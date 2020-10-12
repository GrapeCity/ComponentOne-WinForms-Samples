using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using C1.Win.C1Editor;
using System.IO;

namespace HtmlGrid
{
	/// <summary>
	/// Class used to edit and render Html in C1FlexGrid cells.
	/// </summary>
	public class HtmlEditor : C1Editor
	{
        //--------------------------------------------------------------------------------
        #region ** ctor

        public HtmlEditor()
        {
        }

        #endregion

        //--------------------------------------------------------------------------------
        #region ** Editing

        public void C1EditorInitialize(object value, IDictionary editorAttributes)
        {
            // assign HTML content when editing starts
            this.LoadXml((string)value, null);
        }

        public object C1EditorGetValue()
        {
            // save HTML content when done editing
            MemoryStream ms = new MemoryStream();
            this.SaveXml(ms);
            List<byte> byteArray = new List<byte>(ms.ToArray());
            byteArray.RemoveRange(0, 3); //remove BOM characters
            return Encoding.UTF8.GetString(byteArray.ToArray());
        }

        public bool C1EditorValueIsValid()
        {
            return Enabled;
        }

        // support ctrl-B, I, U to implement bold/italic/underline
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (this.SelectedText != null)
            {
                if (e.Modifiers == Keys.Control)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.B:
                            ToggleStyle(FontStyle.Bold);
                            e.Handled = true;
                            e.SuppressKeyPress = true;
                            return;
                        case Keys.I:
                            ToggleStyle(FontStyle.Italic);
                            e.Handled = true;
                            e.SuppressKeyPress = true;
                            return;
                        case Keys.U:
                            ToggleStyle(FontStyle.Underline);
                            e.Handled = true;
                            e.SuppressKeyPress = true;
                            return;
                    }
                }
            }
           base.OnKeyDown(e);
        }
        void ToggleStyle(FontStyle fs)
        {
            switch (fs)
            {
                case FontStyle.Bold:
                    if (Selection.IsTagApplied("b"))
                    {
                        Selection.RemoveTag("b");
                    }
                    else
                    {
                        Selection.ApplyTag("b");
                    }
                    break;
                case FontStyle.Italic:
                    if (Selection.IsTagApplied("i"))
                    {
                        Selection.RemoveTag("i");
                    }
                    else
                    {
                        Selection.ApplyTag("i");
                    }
                    break;
                case FontStyle.Underline:
                    if (Selection.IsStyleApplied("text-decoration") &&
                        string.Compare(Selection.GetStyleValue("text-decoration", C1StyleType.Character), "underline", true) == 0)
                    {
                        Selection.RemoveStyle("text-decoration", null);
                    }
                    else
                    {
                        Selection.ApplyStyle("text-decoration", "underline", C1StyleType.Character);
                    }
                    break;
            }
        }

        #endregion
    }
}
