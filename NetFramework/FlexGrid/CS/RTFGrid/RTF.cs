using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RTFGrid
{
	/// <summary>
	/// Class used to edit and render RTF in C1FlexGrid cells.
	/// </summary>
	public class RTF : RichTextBox 
	{
        //--------------------------------------------------------------------------------
        #region ** ctor

        public RTF()
        {
            BorderStyle = BorderStyle.None;
            ScrollBars = RichTextBoxScrollBars.None;
        }

        #endregion

        //--------------------------------------------------------------------------------
        #region ** Editing

        public void C1EditorInitialize(object value, IDictionary editorAttributes)
        {
            // initialize control content
            this.Rtf = (string)value;

            // initialize background
            this.BackColor = (Color)editorAttributes["BackColor"];
        }
        public object C1EditorGetValue()
        {
            // save RTF content when done editing
            return this.Rtf;
        }

        // support ctrl-B, I, U to implement bold/italic/underline
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.B:
                        ToggleStyle(FontStyle.Bold);
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.I:
                        ToggleStyle(FontStyle.Italic);
                        e.SuppressKeyPress = true;
                        break;
                    case Keys.U:
                        ToggleStyle(FontStyle.Underline);
                        e.SuppressKeyPress = true;
                        break;
                }
            }
            base.OnKeyDown(e);
        }
        void ToggleStyle(FontStyle fs)
        {
            Font f = SelectionFont;
            if (f != null)
            {
                fs = (f.Style & fs) == 0
                    ? f.Style | fs
                    : f.Style & ~fs;
                SelectionFont = new Font(f, fs);
            }
        }

        #endregion

        //--------------------------------------------------------------------------------
        #region ** Rendering

        // render the control directly into a given Graphics object 
        // (this does not honor clipping set in the target Graphics object; it that is
        // a problem, use the RenderClipped method instead).
        public void Render(Graphics g, Rectangle rc)
        {
            // convert rect from pixels to twips
            rc.X = (int)(rc.X * 1440 / g.DpiX);
            rc.Y = (int)(rc.Y * 1440 / g.DpiY);
            rc.Width = rc.X + (int)((rc.Width) * 1440 / g.DpiX);
            rc.Height = rc.Y + (int)((rc.Height) * 1440 / g.DpiY);

            // get dc
            IntPtr hdc = g.GetHdc();

            // set up FORMATRANGE struct
            FORMATRANGE fmt = new FORMATRANGE();
            fmt.hdc = fmt.hdcTarget = hdc;
            fmt.rc = fmt.rcPage = rc;
            fmt.cpMin = 0;
            fmt.cpMax = -1;

            // render RTF
            int render = 1;
            SendMessageFormatRange(Handle, EM_FORMATRANGE, render, ref fmt);

            // clean up
            SendMessage(Handle, EM_FORMATRANGE, render, 0);

            // done with dc
            g.ReleaseHdc(hdc);
        }

        // render RTF into a Graphics object using a temporary bitmap to ensure
        // clipping works correctly.
        public void RenderClipped(Graphics g, Rectangle rc)
        {
            // create temp bitmap
            Rectangle rcSrc = new Rectangle(0, 0, rc.Width, rc.Height);
            using (Bitmap bmp = new Bitmap(rc.Width, rc.Height))
            {
                // render RTF into bitmap
                using (Graphics gBmp = Graphics.FromImage(bmp))
                {
                    Render(gBmp, rcSrc);

                    // transfer bitmap to original Graphics object
                    // (this honors clipping set in the target Graphics object)
                    g.DrawImage(bmp, rc, rcSrc, GraphicsUnit.Pixel);
                }
            }
        }

        #endregion

        //--------------------------------------------------------------------------------
        #region ** Win32

		// messages used by RichEd20.dll
		internal const int
			WM_USER				= 0x0400,
			EM_FORMATRANGE		= WM_USER + 57;

		// FORMATRANGE is used by RichEd20.dll to render RTF
		internal struct FORMATRANGE
		{ 
			internal IntPtr hdc, hdcTarget; 
			internal Rectangle rc, rcPage; 
			internal int cpMin, cpMax;
		}

		// SendMessage
		[DllImport("USER32.DLL", CharSet=CharSet.Auto)]
		static private extern int SendMessage(
			IntPtr hWnd, 
			uint   wMsg, 
			int    wParam, 
			int    lParam);
		[DllImport("USER32.DLL", CharSet=CharSet.Auto, EntryPoint="SendMessage")]
		static private extern int SendMessageFormatRange(
			IntPtr hWnd, 
			uint   wMsg, 
			int    wParam, 
			ref FORMATRANGE lParam);
        #endregion
    }
}
