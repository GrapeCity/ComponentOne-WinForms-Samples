using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Configuration;
using C1.Win.C1Editor.UICustomization;

namespace CustomDialogs
{
    /// <summary>
    /// Represents a form for editing table cell properties.
    /// </summary>
    internal partial class CellEditorForm : BaseEditorForm, ICellItemDialog
    {
        #region ctors

        public CellEditorForm()
        {
            InitializeComponent();

            LoadAlignmentHorizontalFormat(_cbxHorizontalAlignment);
            LoadAlignmentVerticalFormat(_cbxVerticalAlignment);
            
            _cbxHorizontalAlignment.SelectedIndexChanged += new EventHandler(_cbxHorizontalAlignment_SelectedIndexChanged);
            _cbxVerticalAlignment.SelectedIndexChanged += new EventHandler(_cbxVerticalAlignment_SelectedIndexChanged);
            _nudColSpan.Validated += new EventHandler(ValidateNumber);
            _nudRowSpan.Validated += new EventHandler(ValidateNumber);

            _nudRowSpan.Minimum = 1;
            _nudColSpan.Minimum = 1;
        }

        #endregion

        #region implementation

        private XHTMLCellItem Item
        {
            get { return _item as XHTMLCellItem; }
        }

        #endregion

        #region #event handlers

        // changes the cell vertical alignment type
        private void _cbxVerticalAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Item != null)
                Item.VerticalAlignment = (C1.Win.C1Editor.UICustomization.VerticalAlignment)_cbxVerticalAlignment.SelectedIndex;
        }

        // changes the cell horizontal alignment type
        private void _cbxHorizontalAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Item != null)
                Item.HorizontalAlignment = (C1.Win.C1Editor.UICustomization.HorizontalAlignment)_cbxHorizontalAlignment.SelectedIndex;
        }

        #endregion

        #region ICellItemDialog Members

        /// <summary>
        /// Binds data from the item to GUI controls on the form.
        /// Data can be bound either using the <see cref="Control.DataBindings"/> collection or any other way allowing 
        /// to read data from the item and write it back.
        /// </summary>
        /// <param name="item">The item to be bound to the GUI controls.</param>
        void ICellItemDialog.BindData(XHTMLCellItem item)
        {
            _item = item;
            _cbxVerticalAlignment.SelectedIndex = (int)Item.VerticalAlignment;
            _cbxHorizontalAlignment.SelectedIndex = (int)Item.HorizontalAlignment;
            _nudColSpan.DataBindings.Add("Value", Item, "ColSpan");
            _nudRowSpan.DataBindings.Add("Value", Item, "RowSpan");
            _chbHeader.DataBindings.Add("Checked", Item, "IsHeader");
        }

        /// <summary>
        /// Shows the form with the specified owner to the user.
        /// </summary>
        /// <param name="owner">Any object that implements <see cref="System.Windows.Forms.IWin32Window"/> and represents 
        /// the top-level window that will own this form.</param>
        /// <returns>True if the form was displayed successfully and the item was changed.</returns>
        bool ICellItemDialog.Show(IWin32Window owner)
        {
            return Show(owner);
        }

        #endregion
    }
}

