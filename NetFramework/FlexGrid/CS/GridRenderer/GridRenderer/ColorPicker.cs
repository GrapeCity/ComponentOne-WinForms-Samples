using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace GridRenderer
{
    /// <summary>
    /// Uses the Color UITypeEditor to show a form where users can pick colors.
    /// </summary>
    [DefaultEvent("ColorChanged")]
    public class ColorPicker :
        ComboBox,
        IServiceProvider,
        IWindowsFormsEditorService
    {
        //------------------------------------------------------------------------
        #region ** fields

        ColorEditor _editor;            // UITypeEditor responsible for editing the values
        Form _form;                     // form used to show the drop down
        Color _color = Color.Empty;     // current editor value 

        #endregion

        //------------------------------------------------------------------------
        #region ** ctor

        public ColorPicker()
        {
            // we don't want to show the dropdown, but it flickers in and out,
            // so make it as small as possible.
            if (!this.DesignMode)
            {
                DropDownWidth = 1;
                DropDownHeight = 1;
            }

            // create color editor pane
            _editor = new ColorEditor();

            // initialize drop down editor
            _form = new Form();
            _form.StartPosition = FormStartPosition.Manual;
            _form.FormBorderStyle = FormBorderStyle.None;
            _form.ShowInTaskbar = false;
            _form.TopLevel = true;
            _form.KeyPreview = true;
            _form.Deactivate += _form_Deactivate;
            _form.KeyDown += _form_KeyDown;
        }

        #endregion

        //------------------------------------------------------------------------
        #region ** object model

        /// <summary>
        /// Gets or sets the color value.
        /// </summary>
        [DefaultValue(typeof(Color), "Empty")]
        public Color Color
        {
            get
            {
                Color result = Color.Empty;
                try
                {
                    var cc = TypeDescriptor.GetConverter(typeof(Color));
                    result = (Color)cc.ConvertFromString(Text);
                }
                catch { }
                return result;
            }
            set
            {
                var cc = TypeDescriptor.GetConverter(typeof(Color));
                Text = cc.ConvertToString(value);
                UpdateColor(value);
            }
        }
        /// <summary>
        /// Overridden to modify attributes.
        /// </summary>
        [
        Browsable(false),
        EditorBrowsable(EditorBrowsableState.Never),
        DefaultValue(DrawMode.OwnerDrawFixed)
        ]
        new DrawMode DrawMode
        {
            get { return base.DrawMode; }
            set { base.DrawMode = value; }
        }

        #endregion

        //------------------------------------------------------------------------
        #region ** event

        /// <summary>
        /// Fires when the <see cref="SelectedColor"/> property is changed.
        /// </summary>
        public event EventHandler ColorChanged;
        /// <summary>
        /// Raises the <see cref="SelectedColorChanged"/> event.
        /// </summary>
        protected virtual void OnColorChanged(EventArgs e)
        {
            if (ColorChanged != null)
            {
                ColorChanged(this, e);
            }
        }

        #endregion

        //------------------------------------------------------------------------
        #region ** private

        // close drop down when form deactivated
        void _form_Deactivate(object sender, EventArgs e)
        {
            ((IWindowsFormsEditorService)this).CloseDropDown();
        }

        // close drop down when the user presses the Esc button
        void _form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                ((IWindowsFormsEditorService)this).CloseDropDown();
                e.Handled = true;
            }
        }

        // raises the ColorChanged event if necessary
        void UpdateColor(Color newSelectedColor)
        {
            if (_color != newSelectedColor)
            {
                _color = newSelectedColor;
                OnColorChanged(EventArgs.Empty);
            }
        }

        #endregion

        //------------------------------------------------------------------------
        #region ** overrides

        protected override void OnValidating(CancelEventArgs e)
        {
            if (Text.Length > 0 && Color == Color.Empty)
            {
                e.Cancel = true;
            }
            base.OnValidating(e);
        }
        protected override void OnValidated(EventArgs e)
        {
            base.OnValidated(e);
            UpdateColor(Color);
        }
        protected override bool IsInputKey(Keys keyData)
        {
            if (keyData == Keys.Return || keyData == Keys.Escape)
            {
                if (Color != _color)
                {
                    return true;
                }
            }
            return base.IsInputKey(keyData);
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (!IsDisposed && (e.KeyData == Keys.Return || e.KeyData == Keys.Escape))
            {
                Color newColor = Color;
                if (newColor != _color)
                {
                    if (e.KeyData == Keys.Escape)
                    {
                        Color = _color;
                    }
                    else if (newColor != Color.Empty || Text.Length == 0)
                    {
                        UpdateColor(newColor);
                    }
                    SelectAll();
                    e.Handled = true;
                }
            }
            base.OnKeyDown(e);
        }

        // if the user can type, show drop down when requested
        protected override void OnDropDown(EventArgs e)
        {
            // fire event as usual
            base.OnDropDown(e);

            // show editor and get the new value
            object value = _editor.EditValue((IServiceProvider)this, Color);

            // save new color
            if (value is Color)
            {
                Color = (Color)value;
                SelectAll();
            }

            // hide the standard drop-down (REVIEW: this doesn't work in this app)
            PostMessage(Handle, CB_SHOWDROPDOWN, IntPtr.Zero, IntPtr.Zero);
        }

        #endregion

        //------------------------------------------------------------------------
        #region ** interfaces

        object IServiceProvider.GetService(Type serviceType)
        {
            return serviceType == typeof(IWindowsFormsEditorService)
                ? this
                : null;
        }
        void IWindowsFormsEditorService.DropDownControl(Control control)
        {
            // size form
            _form.ClientSize = control.Size;
            var bounds = Parent.RectangleToScreen(Bounds);

            // calculate form location to avoid being off the screen
            Point pt = new Point(bounds.X, bounds.Bottom);
            if (bounds.Width > _form.Width)
            {
                pt.X = bounds.Right - _form.Width;
            }
            var rc = Screen.GetWorkingArea(this);
            if (bounds.Bottom + _form.Height > rc.Bottom)
            {
                pt.Y = bounds.Top - _form.Height;
            }
            if (pt.Y < 0) pt.Y = 0;
            if (bounds.X + _form.Width > rc.Right)
            {
                pt.X = rc.Right - _form.Width;
            }
            if (pt.X < 0) pt.X = 0;

            // position form
            _form.Location = pt;

            // add control to form and show it
            _form.Controls.Add(control);
            _form.Show(this.TopLevelControl);

            // wait until user makes a selection
            while (control.Visible)
            {
                Application.DoEvents();
                MsgWaitForMultipleObjects(1, IntPtr.Zero, 0, 5, 255);
            }

            // done
            _form.Controls.Clear();
            _form.Hide();
        }
        void IWindowsFormsEditorService.CloseDropDown()
        {
            DroppedDown = false;
            _form.Hide();
        }
        DialogResult IWindowsFormsEditorService.ShowDialog(Form dialog)
        {
            return DialogResult.OK;
        }

        const int CB_SHOWDROPDOWN = 0x14F;

        [System.Runtime.InteropServices.DllImport("USER32.DLL")]
        static extern int MsgWaitForMultipleObjects(
            int nCount, IntPtr pHandles, short bWaitAll, int dwMilliseconds, int dwWakeMask);

        [System.Runtime.InteropServices.DllImport("USER32.DLL", EntryPoint = "PostMessageW")]
        static extern IntPtr PostMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        [System.Runtime.InteropServices.DllImport("USER32.DLL", EntryPoint = "SendMessageW")]
        static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, IntPtr lParam);

        #endregion
    }
}