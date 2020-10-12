using System;
using System.Windows.Forms;
using System.Configuration;
using System.ComponentModel;
using C1.Util;
using C1.Win.C1Editor.UICustomization;
using Resources = global::CustomDialogs.Properties.Resources;

namespace CustomDialogs
{
    /// <summary>
    /// Represents a form for editing Flash movie properties.
    /// </summary>
    internal partial class ObjectEditorForm : BaseEditorForm, IFlashMovieItemDialog
    {
        #region ctors

        public ObjectEditorForm()
        {
            InitializeComponent();

            _tooltip = new ToolTip();
            _tooltip.SetToolTip(_btnSelectFile, Resources.sBrowseTooltip);
            _btnSelectFile.Click += new EventHandler(_btnSelectFile_Click);
            _chkWidth.CheckedChanged += new EventHandler(_chkWidth_CheckedChanged);
            _chkHeight.CheckedChanged += new EventHandler(_chkHeight_CheckedChanged);
            _cbxWidthType.SelectedIndexChanged += new EventHandler(_cbxWidthType_SelectedIndexChanged);
            _cbxHeightType.SelectedIndexChanged += new EventHandler(_cbxHeightType_SelectedIndexChanged);
            _nudWidthValue.Validated += new EventHandler(ValidateNumber);
            _nudHeightValue.Validated += new EventHandler(ValidateNumber);
            LoadSizeFormat(_cbxWidthType);
            LoadSizeFormat(_cbxHeightType);
            _tbData.TextChanged += new EventHandler(SetButtonState);
        }
        
        #endregion

        #region implementation

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AdjustBrowseButtons(
                new Button[] { _btnSelectFile },
                new Control[] { _tbData });
        }

        private void SetButtonState(object sender, EventArgs e)
        {
            _btnOK.Enabled = _btnAplly.Enabled = !string.IsNullOrEmpty(_tbData.Text.Trim());
        }

        private XHTMLFlashMovieItem Item
        {
            get { return _item as XHTMLFlashMovieItem; }
        }

        #endregion

        #region event handlers

        private void _btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = Resources.sFilterFlashMovie;
            dlg.Multiselect = false;
            dlg.FilterIndex = 1;
            dlg.InitialDirectory = System.IO.Path.GetDirectoryName(_item.DocumentName);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _tbData.Text = GetUriFromPath(_item.DocumentName, dlg.FileName);

                FlashMovieSize size = new FlashMovieSize(dlg.FileName);
                _cbxHeightType.SelectedIndex = (int)C1.Win.C1Editor.UICustomization.SizeType.Pixel;
                _cbxWidthType.SelectedIndex = (int)C1.Win.C1Editor.UICustomization.SizeType.Pixel;
                if (size.Width > 0 && size.Height > 0)
                {
                    _chkWidth.Checked = true;
                    _chkHeight.Checked = true;
                    _nudHeightValue.Value = size.Height;
                    _nudWidthValue.Value = size.Width;
                }
                else
                {
                    _chkWidth.Checked = false;
                    _chkHeight.Checked = false;
                    _nudHeightValue.Value = 0;
                    _nudWidthValue.Value = 0;
                }

                BindingContext[_item].EndCurrentEdit();
            }
        }

        // enables/disables controls for setting object width
        private void _chkWidth_CheckedChanged(object sender, EventArgs e)
        {
            _nudWidthValue.Enabled = _chkWidth.Checked;
            _cbxWidthType.Enabled = _chkWidth.Checked;
        }

        // enables/disables controls for setting object height
        private void _chkHeight_CheckedChanged(object sender, EventArgs e)
        {
            _nudHeightValue.Enabled = _chkHeight.Checked;
            _cbxHeightType.Enabled = _chkHeight.Checked;
        }
    
        // changes the object width type
        private void _cbxWidthType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item.WidthType = (C1.Win.C1Editor.UICustomization.SizeType)_cbxWidthType.SelectedIndex;
            if (Item.WidthType == C1.Win.C1Editor.UICustomization.SizeType.Pixel)
                _nudWidthValue.Maximum = 5000;
            else
            {
                _nudWidthValue.Maximum = 200;
                _nudWidthValue.Value = 100;
                Item.WidthValue = 100;
            }
        }

        // changes the object height type
        private void _cbxHeightType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item.HeightType = (C1.Win.C1Editor.UICustomization.SizeType)_cbxHeightType.SelectedIndex;
            if (Item.HeightType == C1.Win.C1Editor.UICustomization.SizeType.Pixel)
                _nudHeightValue.Maximum = 5000;
            else
            {
                _nudHeightValue.Maximum = 200;
                _nudHeightValue.Value = 100;
                Item.HeightValue = 100;
            }

        }

        #endregion

        #region IFlashMovieItemDialog Members

        /// <summary>
        /// Binds data from the item to GUI controls on the form.
        /// Data can be bound either using the <see cref="Control.DataBindings"/> collection or any other way allowing 
        /// to read data from the item and write it back.
        /// </summary>
        /// <param name="item">The item to be bound to the GUI controls.</param>
        void IFlashMovieItemDialog.BindData(XHTMLFlashMovieItem item)
        {
            _item = item;
            _cbxWidthType.SelectedIndex = (int)Item.WidthType;
            _cbxHeightType.SelectedIndex = (int)Item.HeightType;
            _nudWidthValue.DataBindings.Add("Value", Item, "WidthValue");
            _nudHeightValue.DataBindings.Add("Value", Item, "HeightValue");
            _tbData.DataBindings.Add("Text", Item, "Data");
            _chbAutoplay.DataBindings.Add("Checked", Item, "Autoplay");
            _chbLoop.DataBindings.Add("Checked", Item, "Loop");
            _chkWidth.DataBindings.Add("Checked", Item, "UseWidth");
            _chkHeight.DataBindings.Add("Checked", Item, "UseHeight");
            _tbTitle.DataBindings.Add("Text", Item, "Title");

            SetButtonState(this, EventArgs.Empty);
        }

        /// <summary>
        /// Shows the form with the specified owner to the user.
        /// </summary>
        /// <param name="owner">Any object that implements <see cref="System.Windows.Forms.IWin32Window"/> and represents 
        /// the top-level window that will own this form.</param>
        /// <returns>True if the form was displayed successfully and the item was changed.</returns>
        bool IFlashMovieItemDialog.Show(IWin32Window owner)
        {
            return Show(owner);
        }

        #endregion
    }
}

