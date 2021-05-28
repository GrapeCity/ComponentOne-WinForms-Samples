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
    /// The host component for the FontEditorControl on a Ribbon.
    /// </summary>
    [DefaultEvent("SelectedFontChanged")]
    public class FontEditorHost : RibbonControlHost
    {
        //===========================================================================
        #region ** ctor

        public FontEditorHost()
            : base(new FontEditorControl())
        {
        }

        #endregion

        //===========================================================================
        #region ** properties

        /// <summary>
        /// Gets the hosted font editor control.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public FontEditorControl FontEditor
        {
            get { return (FontEditorControl)Control; }
        }

        /// <summary>
        /// Gets or sets the selected font.
        /// </summary>
        [Category("Data")]
        [Description("Gets or sets the selected font.")]
        [DefaultValue((string)null)]
        public Font SelectedFont
        {
            get { return FontEditor.SelectedFont; }
            set { FontEditor.SelectedFont = value; }
        }

        #endregion

        //===========================================================================
        #region ** events

        /// <summary>
        /// Fires when the <see cref="SelectedFont"/> property is changed.
        /// </summary>
        [Category("Property Changed")]
        [Description("Fires when the value of the SelectedFont property changes.")]
        public event EventHandler SelectedFontChanged;
        /// <summary>
        /// Raises the <see cref="SelectedFontChanged"/> event.
        /// </summary>
        protected virtual void OnSelectedFontChanged(EventArgs e)
        {
            if (SelectedFontChanged != null)
                SelectedFontChanged(this, e);
        }

        #endregion

        //===========================================================================
        #region ** methods

        protected override void OnSubscribeControlEvents(Control control)
        {
            base.OnSubscribeControlEvents(control);
            ((FontEditorControl)control).SelectedFontChanged += new EventHandler(HandleSelectedFontChanged);
        }
        protected override void OnUnsubscribeControlEvents(Control control)
        {
            base.OnUnsubscribeControlEvents(control);
            ((FontEditorControl)control).SelectedFontChanged -= new EventHandler(HandleSelectedFontChanged);
        }
        private void HandleSelectedFontChanged(object sender, EventArgs e)
        {
            this.OnSelectedFontChanged(e);
        }

        #endregion
    }

    /// <summary>
    /// Uses the font UITypeEditor to show a form where users can choose fonts.
    /// </summary>
    public class FontEditorControl : ComboBox, IServiceProvider, IWindowsFormsEditorService
    {
        //===========================================================================
        #region ** fields

        // UITypeEditor responsible for editing the values
        private FontEditor _editor;

        // current editor value 
        private Font _selectedFont;

        #endregion

        //===========================================================================
        #region ** static members

        private static TypeConverter _fontConverter;

        // cache the font converter in a static field
        static FontEditorControl()
        {
            _fontConverter = TypeDescriptor.GetConverter(typeof(Font));
        }

        #endregion

        //===========================================================================
        #region ** ctor

        public FontEditorControl()
        {
            _editor = new FontEditor();

            // initialize combo
            DrawMode = DrawMode.OwnerDrawFixed;
        }

        #endregion

        //===========================================================================
        #region ** property

        /// <summary>
        /// Gets or sets the selected font.
        /// </summary>
        public Font SelectedFont
        {
            get
            {
                Font result = null;
                try
                {
                    result = (Font)_fontConverter.ConvertFromString(Text);
                }
                catch
                {
                }
                return result;
            }
            set
            {
                Text = value != null ? _fontConverter.ConvertToString(value) : String.Empty;
                if (!FontsAreEqual(_selectedFont, value))
                {
                    _selectedFont = value;
                    OnSelectedFontChanged(EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Returns true if two fonts are equivalent.
        /// </summary>
        public static bool FontsAreEqual(Font font1, Font font2)
        {
            return font1 == null ? font2 == null : font1.Equals(font2);
        }

        #endregion

        //===========================================================================
        #region ** event

        /// <summary>
        /// Fires when the <see cref="SelectedFont"/> property is changed.
        /// </summary>
        public event EventHandler SelectedFontChanged;
        /// <summary>
        /// Raises the <see cref="SelectedFontChanged"/> event.
        /// </summary>
        protected virtual void OnSelectedFontChanged(EventArgs e)
        {
            if (SelectedFontChanged != null)
                SelectedFontChanged(this, e);
        }

        #endregion

        //===========================================================================
        #region ** overrides

        protected override void OnValidating(CancelEventArgs e)
        {
            if (Text.Length > 0 && SelectedFont == null)
            {
                e.Cancel = true;
            }
            base.OnValidating(e);
        }
        protected override void OnValidated(EventArgs e)
        {
            base.OnValidated(e);
            SelectedFont = SelectedFont;
        }
        protected override bool IsInputKey(Keys keyData)
        {
            if (keyData == Keys.Return || keyData == Keys.Escape)
            {
                if (!FontsAreEqual(_selectedFont, SelectedFont))
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
                Font newSelectedFont = SelectedFont;
                if (!FontsAreEqual(newSelectedFont, _selectedFont))
                {
                    SelectedFont = e.KeyData == Keys.Escape ? _selectedFont : newSelectedFont;
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
            object value = _editor.EditValue((IServiceProvider)this, SelectedFont);
            if (value is Font)
            {
                SelectedFont = (Font)_fontConverter.ConvertFromString(_fontConverter.ConvertToString(value));
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
        }
        void IWindowsFormsEditorService.CloseDropDown()
        {
        }
        DialogResult IWindowsFormsEditorService.ShowDialog(Form dialog)
        {
            return dialog.ShowDialog();
        }

        #endregion
    }
}
