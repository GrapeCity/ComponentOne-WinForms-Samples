using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using C1.Win.C1Editor.UICustomization;

namespace CustomDialogs
{
    /// <summary>
    /// Represents a form for editing table column properties.
    /// </summary>
    internal partial class ColumnEditorForm : BaseEditorForm, IColumnItemDialog
    {
        #region ctors

        public ColumnEditorForm()
        {
            InitializeComponent();

            LoadSizeFormat(_cbxWidthType);
            LoadAlignmentHorizontalFormat(_cbxHorizontalAlignment);
            LoadAlignmentVerticalFormat(_cbxVerticalAlignment);

            _cbxHorizontalAlignment.SelectedIndexChanged += new EventHandler(_cbxHorizontalAlignment_SelectedIndexChanged);
            _cbxVerticalAlignment.SelectedIndexChanged += new EventHandler(_cbxVerticalAlignment_SelectedIndexChanged);
            _chkWidth.CheckedChanged += new EventHandler(_chkWidth_CheckedChanged);
            _cbxWidthType.SelectedIndexChanged += new EventHandler(_cbxWidthType_SelectedIndexChanged);
            _nudSpan.Validated += new EventHandler(ValidateNumber);
            _tbWidthValue.Validated += new EventHandler(ValidateNumber);

            _nudSpan.Minimum = 1;
        }

        #endregion

        #region implementation

        private XHTMLColumnItem Item
        {
            get { return _item as XHTMLColumnItem; }
        }

        #endregion

        #region #event handlers

        // enables/disables controls for setting column width
        private void _chkWidth_CheckedChanged(object sender, EventArgs e)
        {
            _tbWidthValue.Enabled = _chkWidth.Checked;
            _cbxWidthType.Enabled = _chkWidth.Checked;
        }

        // changes the column size type
        private void _cbxWidthType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item.WidthType = (C1.Win.C1Editor.UICustomization.SizeType)_cbxWidthType.SelectedIndex;
        }

        // changes the column vertical alignment type
        private void _cbxVerticalAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Item != null)
                Item.VerticalAlignment = (C1.Win.C1Editor.UICustomization.VerticalAlignment)_cbxVerticalAlignment.SelectedIndex;
        }

        // changes the column horizontal alignment type
        private void _cbxHorizontalAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Item != null)
                Item.HorizontalAlignment = (C1.Win.C1Editor.UICustomization.HorizontalAlignment)_cbxHorizontalAlignment.SelectedIndex;
        }

        #endregion

        #region IColumnItemDialog Members

        /// <summary>
        /// Binds data from the item to GUI controls on the form.
        /// Data can be bound either using the <see cref="Control.DataBindings"/> collection or any other way allowing 
        /// to read data from the item and write it back.
        /// </summary>
        /// <param name="item">The item to be bound to the GUI controls.</param>
        void IColumnItemDialog.BindData(XHTMLColumnItem item)
        {
            _item = item;
            _cbxWidthType.SelectedIndex = (int)Item.WidthType;
            _cbxVerticalAlignment.SelectedIndex = (int)Item.VerticalAlignment;
            _cbxHorizontalAlignment.SelectedIndex = (int)Item.HorizontalAlignment;
            _nudSpan.DataBindings.Add("Value", Item, "Span");
            _tbWidthValue.DataBindings.Add("Value", Item, "WidthValue");
            _chkWidth.DataBindings.Add("Checked", Item, "UseWidth");
        }

        /// <summary>
        /// Shows the form with the specified owner to the user.
        /// </summary>
        /// <param name="owner">Any object that implements <see cref="System.Windows.Forms.IWin32Window"/> and represents 
        /// the top-level window that will own this form.</param>
        /// <returns>True if the form was displayed successfully and the item was changed.</returns>
        bool IColumnItemDialog.Show(IWin32Window owner)
        {
            return Show(owner);
        }

        #endregion
    }
}

