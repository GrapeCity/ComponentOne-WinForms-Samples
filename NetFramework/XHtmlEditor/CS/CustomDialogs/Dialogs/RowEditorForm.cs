using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using System.Configuration;
using C1.Win.C1Editor.UICustomization;

namespace CustomDialogs
{
    /// <summary>
    /// Represents a form for editing table row properties.
    /// </summary>
    internal partial class RowEditorForm : BaseEditorForm, IRowItemDialog
    {
        #region ctors

        public RowEditorForm()
        {
            InitializeComponent();

            LoadAlignmentHorizontalFormat(_cbxHorizontalAlignment);
            LoadAlignmentVerticalFormat(_cbxVerticalAlignment);

            _cbxHorizontalAlignment.SelectedIndexChanged += new EventHandler(_cbxHorizontalAlignment_SelectedIndexChanged);
            _cbxVerticalAlignment.SelectedIndexChanged += new EventHandler(_cbxVerticalAlignment_SelectedIndexChanged);
        }

        #endregion

        #region implementation

        private XHTMLRowItem Item
        {
            get { return _item as XHTMLRowItem; }
        }

        #endregion

        #region event handlers

        // changes the row vertical alignment type
        private void _cbxVerticalAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Item != null)
                Item.VerticalAlignment = (C1.Win.C1Editor.UICustomization.VerticalAlignment)_cbxVerticalAlignment.SelectedIndex;
        }

        // changes the row horizontal alignment type
        private void _cbxHorizontalAlignment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Item != null)
                Item.HorizontalAlignment = (C1.Win.C1Editor.UICustomization.HorizontalAlignment)_cbxHorizontalAlignment.SelectedIndex;
        }

        #endregion

        #region IRowItemDialog Members

        /// <summary>
        /// Binds data from the item to GUI controls on the form.
        /// Data can be bound either using the <see cref="Control.DataBindings"/> collection or any other way allowing 
        /// to read data from the item and write it back.
        /// </summary>
        /// <param name="item">The item to be bound to the GUI controls.</param>
        void IRowItemDialog.BindData(XHTMLRowItem item)
        {
            _item = item;
            _cbxVerticalAlignment.DataBindings.Add("SelectedIndex", Item, "VerticalAlignment");
            _cbxHorizontalAlignment.DataBindings.Add("SelectedIndex", Item, "HorizontalAlignment");
        }

        /// <summary>
        /// Shows the form with the specified owner to the user.
        /// </summary>
        /// <param name="owner">Any object that implements <see cref="System.Windows.Forms.IWin32Window"/> and represents 
        /// the top-level window that will own this form.</param>
        /// <returns>True if the form was displayed successfully and the item was changed.</returns>
        bool IRowItemDialog.Show(IWin32Window owner)
        {
            return Show(owner);
        }

        #endregion
    }
}

