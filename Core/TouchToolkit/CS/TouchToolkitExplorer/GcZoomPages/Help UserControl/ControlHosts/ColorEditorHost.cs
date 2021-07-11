using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Reflection;
using C1.Win.C1Ribbon;

namespace ClickOnceDemo.GcZoomPages.ControlHosts
{
    /// <summary>
    /// The host component for the ColorEditorControl on a Ribbon.
    /// </summary>
    [DefaultEvent("SelectedColorChanged")]
    public class ColorEditorHost : RibbonControlHost
    {
        //===========================================================================
        #region ** ctor

        public ColorEditorHost()
            : base(new ColorEditorControl())
        {
        }

        #endregion

        //===========================================================================
        #region ** properties

        /// <summary>
        /// Gets the hosted color editor control.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ColorEditorControl ColorEditor
        {
            get { return (ColorEditorControl)Control; }
        }

        /// <summary>
        /// Gets or sets the selected color.
        /// </summary>
        [Category("Data")]
        [Description("Gets or sets the selected color.")]
        public Color SelectedColor
        {
            get { return ColorEditor.SelectedColor; }
            set { ColorEditor.SelectedColor = value; }
        }
        private bool ShouldSerializeSelectedColor()
        {
            return SelectedColor != Color.Empty;
        }
        private void ResetSelectedColor()
        {
            SelectedColor = Color.Empty;
        }

        #endregion

        //===========================================================================
        #region ** events

        /// <summary>
        /// Fires when the <see cref="SelectedColor"/> property is changed.
        /// </summary>
        [Category("Property Changed")]
        [Description("Fires when the value of the SelectedColor property changes.")]
        public event EventHandler SelectedColorChanged;
        /// <summary>
        /// Raises the <see cref="SelectedColorChanged"/> event.
        /// </summary>
        protected virtual void OnSelectedColorChanged(EventArgs e)
        {
            if (SelectedColorChanged != null)
                SelectedColorChanged(this, e);
        }

        #endregion

        //===========================================================================
        #region ** methods

        protected override void OnSubscribeControlEvents(Control control)
        {
            base.OnSubscribeControlEvents(control);
            ((ColorEditorControl)control).SelectedColorChanged += new EventHandler(HandleSelectedColorChanged);
        }
        protected override void OnUnsubscribeControlEvents(Control control)
        {
            base.OnUnsubscribeControlEvents(control);
            ((ColorEditorControl)control).SelectedColorChanged -= new EventHandler(HandleSelectedColorChanged);
        }
        private void HandleSelectedColorChanged(object sender, EventArgs e)
        {
            this.OnSelectedColorChanged(e);
        }

        #endregion
    }

    /// <summary>
    /// Uses the Color UITypeEditor to show a form where users can pick colors.
    /// </summary>
    public class ColorEditorControl : ComboBox, IServiceProvider, IWindowsFormsEditorService
    {
        //===========================================================================
        #region ** fields

        // UITypeEditor responsible for editing the values
        private ColorEditor _editor;

        // form used to show the drop down
        private Form _form;

        // current editor value 
        private Color _selectedColor = Color.Empty;

        #endregion

        //===========================================================================
        #region ** static members

        private static TypeConverter _colorConverter;

        // cache the color converter in a static field
        static ColorEditorControl()
        {
            _colorConverter = TypeDescriptor.GetConverter(typeof(Color));
        }

        #endregion

        //===========================================================================
        #region ** ctor

        public ColorEditorControl()
        {
            _editor = new ColorEditor();

            // initialize combo
            DrawMode = DrawMode.OwnerDrawFixed;

            // initialize drop down editor
            _form = new Form();
            _form.StartPosition = FormStartPosition.Manual;
            _form.FormBorderStyle = FormBorderStyle.None;
            _form.ShowInTaskbar = false;
            _form.TopLevel = true;
            _form.KeyPreview = true;
            _form.Deactivate += new EventHandler(_form_Deactivate);
            _form.KeyDown += new KeyEventHandler(_form_KeyDown);
        }

        #endregion

        //===========================================================================
        #region ** property

        /// <summary>
        /// Gets or sets the color value.
        /// </summary>
        public Color SelectedColor
        {
            get
            {
                Color result = Color.Empty;
                try
                {
                    result = (Color)_colorConverter.ConvertFromString(Text);
                }
                catch
                {
                }
                return result;
            }
            set
            {
                Text = _colorConverter.ConvertToString(value);
                UpdateSelectedColor(value);
            }
        }

        #endregion

        //===========================================================================
        #region ** event

        /// <summary>
        /// Fires when the <see cref="SelectedColor"/> property is changed.
        /// </summary>
        public event EventHandler SelectedColorChanged;
        /// <summary>
        /// Raises the <see cref="SelectedColorChanged"/> event.
        /// </summary>
        protected virtual void OnSelectedColorChanged(EventArgs e)
        {
            if (SelectedColorChanged != null)
                SelectedColorChanged(this, e);
        }

        #endregion

        //===========================================================================
        #region ** private

        // close drop down when form deactivated
        private void _form_Deactivate(object sender, EventArgs e)
        {
            ((IWindowsFormsEditorService)this).CloseDropDown();
        }

        // close drop down when the user presses the Esc button
        private void _form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                ((IWindowsFormsEditorService)this).CloseDropDown();
                e.Handled = true;
            }
        }

        // raises the ColorChanged event if necessary
        private void UpdateSelectedColor(Color newSelectedColor)
        {
            if (_selectedColor != newSelectedColor)
            {
                _selectedColor = newSelectedColor;
                OnSelectedColorChanged(EventArgs.Empty);
            }
        }

        #endregion

        //===========================================================================
        #region ** overrides

        protected override void OnValidating(CancelEventArgs e)
        {
            if (Text.Length > 0 && SelectedColor == Color.Empty)
            {
                e.Cancel = true;
            }
            base.OnValidating(e);
        }
        protected override void OnValidated(EventArgs e)
        {
            base.OnValidated(e);
            UpdateSelectedColor(SelectedColor);
        }
        protected override bool IsInputKey(Keys keyData)
        {
            if (keyData == Keys.Return || keyData == Keys.Escape)
            {
                if (SelectedColor != _selectedColor)
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
                Color newSelectedColor = SelectedColor;
                if (newSelectedColor != _selectedColor)
                {
                    if (e.KeyData == Keys.Escape)
                    {
                        SelectedColor = _selectedColor;
                    }
                    else if (newSelectedColor != Color.Empty || Text.Length == 0)
                    {
                        UpdateSelectedColor(newSelectedColor);
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
            base.OnDropDown(EventArgs.Empty);

            // show editor and get the new value
            object value = _editor.EditValue((IServiceProvider)this, SelectedColor);
            if (value is Color)
            {
                SelectedColor = (Color)value;
                SelectAll();
            }

            // hide the standard drop-down
            Win32.PostMessage(Handle, Win32.CB_SHOWDROPDOWN, IntPtr.Zero, IntPtr.Zero);
        }

        #endregion

        //===========================================================================
        #region ** interfaces

        object IServiceProvider.GetService(Type serviceType)
        {
            if (serviceType == typeof(IWindowsFormsEditorService))
                return (IWindowsFormsEditorService)this;
            return null;
        }
        void IWindowsFormsEditorService.DropDownControl(Control control)
        {
            // size form
            _form.ClientSize = control.Size;
            Rectangle bounds = Parent.RectangleToScreen(Bounds);

            // calculate form location to avoid being off the screen
            Point pt = new Point();
            pt.Y = bounds.Bottom;
            if (bounds.Width > _form.Width)
                pt.X = bounds.Right - _form.Width;
            else
                pt.X = bounds.Left;
            Rectangle rc = Screen.GetWorkingArea(this);
            if (bounds.Bottom + _form.Height > rc.Bottom)
                pt.Y = bounds.Top - _form.Height;
            if (pt.Y < 0) pt.Y = 0;
            if (bounds.X + _form.Width > rc.Right)
                pt.X = rc.Right - _form.Width;
            if (pt.X < 0) pt.X = 0;

            // position form
            _form.Location = pt;

            // add control to form and show it
            _form.Controls.Add(control);
            _form.Show();

            // wait until user makes a selection
            while (control.Visible)
            {
                Application.DoEvents();
                Win32.MsgWaitForMultipleObjects(1, IntPtr.Zero, 0, 5, 255);
            }

            // done
            _form.Controls.Clear();
        }
        void IWindowsFormsEditorService.CloseDropDown()
        {
            _form.Hide();
        }
        DialogResult IWindowsFormsEditorService.ShowDialog(Form dialog)
        {
            return DialogResult.OK;
        }

        #endregion
    }
}
