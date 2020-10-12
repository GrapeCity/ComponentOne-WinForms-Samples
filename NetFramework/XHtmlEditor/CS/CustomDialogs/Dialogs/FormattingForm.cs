using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Editor;
using C1.Win.C1Editor.UICustomization;

namespace CustomDialogs
{
    /// <summary>
    /// Represents a form for basic text formatting.
    /// </summary>
    internal partial class FormattingForm : Form, IFormattingDialog
    {
        #region ctors

        public FormattingForm()
        {
            InitializeComponent();
            //_cbFontFamily combobox must be initialized by fonts from the current system
            foreach (FontFamily fontFamily in FontFamily.Families)
                _cbFontFamily.Items.Add(fontFamily.Name);
            _rbNone.CheckedChanged += new EventHandler(_rbNone_CheckedChanged);
        }

        #endregion ctors

        #region declarations

        FormattingSupport _support;

        #endregion

        #region private methods

        /// <summary>
        /// Translates a CSS color representation to a GDI+ <see cref="T:System.Drawing.Color"></see> structure.
        /// </summary>
        /// <param name="cssColor">The string with the CSS color representation.</param>
        /// <returns>The <see cref="T:System.Drawing.Color"></see> structure that represents the translated HTML color.</returns>
        private Color ToColor(string cssColor)
        {
            Color color = Color.Empty;

            if (!string.IsNullOrEmpty(cssColor))
            {
                color = ColorTranslator.FromHtml(cssColor);
            }

            return color;
        }

        /// <summary>
        /// Converts a GDI+ <see cref="Color"/> structure to a CSS hex-formatted string.
        /// </summary>
        /// <param name="color">The Color structure to be converted.</param>
        /// <returns>The CSS hex-formatted color.</returns>
        private string ToCSSString(Color? color)
        {
            return color.HasValue ? ToCSSString(color.Value) : string.Empty;
        }

        /// <summary>
        /// Converts a GDI+ <see cref="Color"/> structure to a CSS hex-formatted string.
        /// </summary>
        /// <param name="color">The Color structure to be converted.</param>
        /// <returns>The CSS hex-formatted color.</returns>
        private string ToCSSString(Color color)
        {
            if (color.IsEmpty)
                return "";
            string cssString;
            string R = GetByteInToHexNumber(color.R);
            string G = GetByteInToHexNumber(color.G);
            string B = GetByteInToHexNumber(color.B);
            cssString = string.Format("#{0}{1}{2}", R, G, B);
            return cssString;
        }

        private string GetByteInToHexNumber(byte b)
        {
            string R = Convert.ToString(b, 16);
            if (R.Length == 1)
                R = "0" + R;
            return R;
        }

        #endregion

        #region #event handlers

        private void _tbTextColor_Validated(object sender, EventArgs e)
        {
            _support.ForeColor = ToColor((sender as TextBox).Text);
        }

        private void _rbNone_CheckedChanged(object sender, EventArgs e)
        {
            if (_support == null)
                return;
            if (_rbNone.Checked)
            {
                _support.Underline = false;
                _support.Overline = false;
                _support.Strikeout = false;
            }
        }

        #endregion

        #region IFormattingDialog Members

        /// <summary>
        /// Binds data from the item to GUI controls on the form.
        /// Data can be bound either using the <see cref="Control.DataBindings"/> collection or any other way allowing 
        /// to read data from the item and write it back.
        /// </summary>
        /// <param name="item">The item to be bound to the GUI controls.</param>
        void IFormattingDialog.BindData(FormattingSupport support)
        {
            _support = null;
            _rbNone.Checked = true;
            _support = support;
            //data biniding is used to link each control with corresponding data member
            _cbBold.DataBindings.Add("Checked", _support, "Bold");
            _cbItalic.DataBindings.Add("Checked", _support, "Italic");
            _cbInvisible.DataBindings.Add("Checked", _support, "Hidden");
            _rbUnderline.DataBindings.Add("Checked", _support, "Underline");
            _rbOverline.DataBindings.Add("Checked", _support, "Overline");
            _rbStrikeout.DataBindings.Add("Checked", _support, "Strikeout");
            _cbFontFamily.DataBindings.Add("Text", _support, "FontName");
            _tbSize.DataBindings.Add("Text", _support, "FontSize");
            _tbTextColor.Text = ToCSSString(_support.ForeColor);
        }

        /// <summary>
        /// Shows the form with the specified owner to the user.
        /// </summary>
        /// <param name="owner">Any object that implements <see cref="System.Windows.Forms.IWin32Window"/> and represents 
        /// the top-level window that will own this form.</param>
        /// <returns>True if the form was displayed successfully and the item was changed.</returns>
        bool IFormattingDialog.Show(IWin32Window owner)
        {
            //returns true if the dialog was executed and OK button was pressed
            return ShowDialog(owner) == DialogResult.OK;
        }

        #endregion

    }
}
