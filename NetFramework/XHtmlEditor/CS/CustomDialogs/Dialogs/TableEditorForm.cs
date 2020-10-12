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
    /// Represents a form for editing table properties.
    /// </summary>
    internal partial class TableEditorForm : BaseEditorForm, ITableItemDialog
    {
        #region ctors

        public TableEditorForm()
        {
            InitializeComponent();

            _chkWidth.CheckedChanged += new EventHandler(_chkWidth_CheckedChanged);
            _cbxWidthType.SelectedIndexChanged += new EventHandler(_cbxWidthType_SelectedIndexChanged);
            _nudColumnCount.Validated += new EventHandler(ValidateNumber);
            _nudRowCount.Validated += new EventHandler(ValidateNumber);
            _nudCellPadding.Validated += new EventHandler(ValidateNumber);
            _nudCellSpacing.Validated += new EventHandler(ValidateNumber);
            _tbWidthValue.Validated += new EventHandler(ValidateNumber);
            _nudBorder.Validated += new EventHandler(ValidateNumber);
            LoadSizeFormat(_cbxWidthType);
        }

        #endregion

        #region implementation

        private XHTMLTableItem Item
        {
            get { return _item as XHTMLTableItem; }
        }
        
        #endregion

        #region event handlers

        protected override void OnItemPropertiesChanged()
        {
            //don't allow decrease table size in the edit mode
            _nudRowCount.Minimum = (_item != null && _item.IsEditMode) ? Item.RowCount : 1;
            _nudColumnCount.Minimum = (_item != null && _item.IsEditMode) ? Item.ColumnCount : 1;
        }

        // enables/disables controls for setting table width
        private void _chkWidth_CheckedChanged(object sender, EventArgs e)
        {
            _tbWidthValue.Enabled = _chkWidth.Checked;
            _cbxWidthType.Enabled = _chkWidth.Checked;
        }

        // changes the table width type
        private void _cbxWidthType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item.WidthType = (C1.Win.C1Editor.UICustomization.SizeType)_cbxWidthType.SelectedIndex;
        }

        #endregion

        #region ITableItemDialog Members

        /// <summary>
        /// Binds data from the item to GUI controls on the form.
        /// Data can be bound either using the <see cref="Control.DataBindings"/> collection or any other way allowing 
        /// to read data from the item and write it back.
        /// </summary>
        /// <param name="item">The item to be bound to the GUI controls.</param>
        void ITableItemDialog.BindData(XHTMLTableItem item)
        {
            _item = item;
            _cbxWidthType.SelectedIndex = (int)Item.WidthType;
            _nudRowCount.DataBindings.Add("Value", Item, "RowCount");
            _nudColumnCount.DataBindings.Add("Value", Item, "ColumnCount");
            _tbWidthValue.DataBindings.Add("Value", Item, "WidthValue");
            _nudCellPadding.DataBindings.Add("Value", Item, "CellPadding");
            _nudCellSpacing.DataBindings.Add("Value", Item, "CellSpacing");
            _nudBorder.DataBindings.Add("Value", Item, "Border");
            _chkWidth.DataBindings.Add("Checked", Item, "UseWidth");
            _tbCaption.DataBindings.Add("Text", Item, "Caption");
            _tbSummary.DataBindings.Add("Text", Item, "Summary");

            OnItemPropertiesChanged();
        }

        /// <summary>
        /// Shows the form with the specified owner to the user.
        /// </summary>
        /// <param name="owner">Any object that implements <see cref="System.Windows.Forms.IWin32Window"/> and represents 
        /// the top-level window that will own this form.</param>
        /// <returns>True if the form was displayed successfully and the item was changed.</returns>
        bool ITableItemDialog.Show(IWin32Window owner)
        {
            return Show(owner);
        }

        #endregion
    }
}

