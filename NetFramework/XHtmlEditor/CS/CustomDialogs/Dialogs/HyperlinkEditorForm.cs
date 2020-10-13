using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using C1.Util;
using C1.Win.C1Editor.UICustomization;
using Resources = global::CustomDialogs.Properties.Resources;

namespace CustomDialogs
{
    /// <summary>
    /// Represents a form for editing hyperlink properties.
    /// </summary>
    internal partial class HyperlinkEditorForm : BaseEditorForm, IHyperlinkItemDialog
    {
        #region ctors

        public HyperlinkEditorForm()
        {
            InitializeComponent();
            InitializeTargets();
            _tbTabIndex.Validated += new EventHandler(ValidateNumber);
            _btnSelectImageSource.Click += new EventHandler(_btnSelectLink_Click);
            _tbText.TextChanged += new EventHandler(_tbText_TextChanged);
            _tbAccessKey.MaxLength = 1;
        }

        #endregion

        #region implementation

        private XHTMLHyperlinkItem Item
        {
            get { return _item as XHTMLHyperlinkItem; }
        }

        private void InitializeTargets()
        {
            _cmbTarget.Items.Add(Resources.sHyperlinkTargetDefault);
            _cmbTarget.Items.Add(Resources.sHyperlinkTargetSameFrame);
            _cmbTarget.Items.Add(Resources.sHyperlinkTargetWholePage);
            _cmbTarget.Items.Add(Resources.sHyperlinkTargetNewWindow);
            _cmbTarget.Items.Add(Resources.sHyperlinkTargetParentFrame);
        }

        #endregion

        #region event handlers

        private void _btnSelectLink_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = Resources.sSelectFile;
            dlg.Filter = Resources.sFilterAllFiles;
            dlg.Multiselect = false;
            dlg.FilterIndex = 1;
            dlg.InitialDirectory = Path.GetDirectoryName(_item.DocumentName);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _tbLink.Text = GetUriFromPath(_item.DocumentName, dlg.FileName);
                BindingContext[_item].EndCurrentEdit();
            }
        }

        private void _tbText_TextChanged(object sender, EventArgs e)
        {
            _btnOK.Enabled = !string.IsNullOrEmpty(_tbText.Text.Trim());
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AdjustBrowseButtons(
                new Button[] { _btnSelectImageSource },
                new Control[] { _tbLink });
        }

        #endregion

        #region IHyperlinkItemDialog Members

        /// <summary>
        /// Binds data from the item to GUI controls on the form.
        /// Data can be bound either using the <see cref="Control.DataBindings"/> collection or any other way allowing 
        /// to read data from the item and write it back.
        /// </summary>
        /// <param name="item">The item to be bound to the GUI controls.</param>
        void IHyperlinkItemDialog.BindData(XHTMLHyperlinkItem item)
        {
            _item = item;

            if (!string.IsNullOrEmpty(item.AccessKey) && item.AccessKey.Length > 1)
                item.AccessKey = item.AccessKey.Substring(0, 1);

            _tbText.DataBindings.Add("Text", item, "Text");
            _tbLink.DataBindings.Add("Text", item, "Href");
            _tbTitle.DataBindings.Add("Text", item, "Title");
            _tbAccessKey.DataBindings.Add("Text", item, "AccessKey");
            _tbTabIndex.DataBindings.Add("Value", item, "TabIndex");
            _cmbTarget.DataBindings.Add("Text", item, "Target");

            _tbText.Enabled = item.IsEmpty;
            _tbText_TextChanged(this, EventArgs.Empty);
        }

        /// <summary>
        /// Shows the form with the specified owner to the user.
        /// </summary>
        /// <param name="owner">Any object that implements <see cref="System.Windows.Forms.IWin32Window"/> and represents 
        /// the top-level window that will own this form.</param>
        /// <returns>True if the form was displayed successfully and the item was changed.</returns>
        bool IHyperlinkItemDialog.Show(IWin32Window owner)
        {
            return Show(owner);
        }

        #endregion
    }
}

