using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Configuration;
using System.ComponentModel;
using C1.Util;
using C1.Win.C1Editor.UICustomization;
using Resources = global::CustomDialogs.Properties.Resources;

namespace CustomDialogs
{
    /// <summary>
    /// Represents a form for editing image properties.
    /// </summary>
    internal partial class ImageEditorForm : BaseEditorForm, IImageItemDialog
    {

        #region declarations

        private Image _image = null;

        #endregion

        #region ctors

        public ImageEditorForm()
        {
            InitializeComponent();

            _tooltip = new ToolTip();
            _tooltip.SetToolTip(_btnSelectImageSource, Resources.sBrowseTooltip);
            _btnSelectImageSource.Click += new EventHandler(_btnSelectImageSource_Click);
            _chkWidth.CheckedChanged += new EventHandler(_chkWidth_CheckedChanged);
            _chkHeight.CheckedChanged += new EventHandler(_chkHeight_CheckedChanged);
            _cbxWidthType.SelectedIndexChanged += new EventHandler(_cbxWidthType_SelectedIndexChanged);
            _cbxHeightType.SelectedIndexChanged += new EventHandler(_cbxHeightType_SelectedIndexChanged);
            _tbWidthValue.ValueChanged += new EventHandler(_tbWidthValue_ValueChanged);
            _tbHeightValue.ValueChanged += new EventHandler(_tbHeightValue_ValueChanged);
            _pbSourceImage.SizeChanged += new EventHandler(PreviewImage);
            _tbWidthValue.Validated += new EventHandler(ValidateNumber);
            _tbHeightValue.Validated += new EventHandler(ValidateNumber);
            LoadSizeFormat(_cbxWidthType);
            LoadSizeFormat(_cbxHeightType);
            _tbSource.TextChanged += new EventHandler(SourceChanged);
            _tbSource.TextChanged += new EventHandler(SetButtonState);
        }

        #endregion

        #region implementation

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            AdjustBrowseButtons(
                new Button[] { _btnSelectImageSource },
                new Control[] { _tbSource });
        }

        /// <summary> 
        /// Disposes of the resources (other than memory) used by the System.Windows.Forms.Form.
        /// </summary>
        /// <param name="disposing">true to release both managed and unmanaged resources; false to release only unmanaged resources.</param>
        protected override void Dispose(bool disposing)
        {
            if (Image != null)
                Image.Dispose();

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void SourceChanged(object sender, EventArgs e)
        {
            string currentDirectory = null;
            if (_item.DocumentName != null)
            {
                currentDirectory = Directory.GetCurrentDirectory();
                Directory.SetCurrentDirectory(Path.GetDirectoryName(_item.DocumentName));
            }
            try
            {
                string fileName = GetLocalPath(_tbSource.Text);
                if (File.Exists(fileName))
                {
                    try
                    {
                        Image = Image.FromFile(fileName);
                        if (_tbSource.Text != Item.Source)
                        {
                            _chkWidth.Checked = true;
                            _chkHeight.Checked = true;
                            _cbxHeightType.SelectedIndex = (int)C1.Win.C1Editor.UICustomization.SizeType.Pixel;
                            _cbxWidthType.SelectedIndex = (int)C1.Win.C1Editor.UICustomization.SizeType.Pixel;
                            _tbWidthValue.Value = _image.Width;
                            _tbHeightValue.Value = _image.Height;
                        }
                        PreviewImage(sender, e);
                    }
                    catch
                    {
                        Image = null;
                    }
                }
                else
                    Image = null;
            }
            finally
            {
                if (_item.DocumentName != null)
                    Directory.SetCurrentDirectory(currentDirectory);
            }
        }

        private void SetButtonState(object sender, EventArgs e)
        {
            _btnOK.Enabled = _btnAplly.Enabled = !string.IsNullOrEmpty(_tbSource.Text.Trim());
        }

        private XHTMLImageItem Item
        {
            get { return _item as XHTMLImageItem; }
        }

        // gets or sets the current image
        private Image Image
        {
            get { return _image; }
            set
            {
                _image = value;
                _pbSourceImage.Image = _image;
            }
        }

        // gets the width of the current image for preview
        private int ImageWidth
        {
            get
            {
                if (_image == null)
                    return 1;
                if (!_chkWidth.Checked)
                    return _image.Width;
                if (_cbxWidthType.SelectedIndex == (int)C1.Win.C1Editor.UICustomization.SizeType.Pixel)
                    return (int)_tbWidthValue.Value;
                return Math.Max((int)(_pbSourceImage.Width * _tbWidthValue.Value / 100), 1);
            }
        }

        // gets the height of the current image for preview
        private int ImageHeight
        {
            get
            {
                if (_image == null)
                    return 1;
                if (!_chkHeight.Checked)
                    return _image.Height;
                if ((int)_cbxHeightType.SelectedIndex == (int)C1.Win.C1Editor.UICustomization.SizeType.Pixel)
                    return (int)_tbHeightValue.Value;
                return Math.Max((int)(_pbSourceImage.Height * _tbHeightValue.Value / 100), 1);
            }
        }

        // updates the current image size for preview
        private void PreviewImage(object sender, EventArgs e)
        {
            if (_image == null)
                return;
            Image current = _pbSourceImage.Image;
            int width = ImageWidth;
            int height = ImageHeight;
            ScaleSize(ref width, ref height, _pbSourceImage.ClientSize.Width, _pbSourceImage.ClientSize.Height);
            if (current.Width != width || current.Height != height)
            {
                Image image = new Bitmap(_image, width, height);
                image = AddBorder(image, 0, Color.Black);
                _pbSourceImage.Image = image;
            }
        }

        #endregion

        #region implementation

        private void _btnSelectImageSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = Resources.sSelectImageFile;
            dlg.Filter = Resources.sFilterImage;
            dlg.Multiselect = false;
            dlg.FilterIndex = 1;
            dlg.InitialDirectory = Path.GetDirectoryName(_item.DocumentName);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                _tbSource.Text = GetUriFromPath(_item.DocumentName, dlg.FileName);
                BindingContext[_item].EndCurrentEdit();
            }
        }

        // enables controls for setting image width
        private void _chkWidth_CheckedChanged(object sender, EventArgs e)
        {
            bool enbabled = _chkWidth.Checked;
            _tbWidthValue.Enabled = enbabled;
            _cbxWidthType.Enabled = enbabled;
            PreviewImage(sender, e);
        }

        // enables controls for setting image height
        private void _chkHeight_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = _chkHeight.Checked;
            _tbHeightValue.Enabled = enabled;
            _cbxHeightType.Enabled = enabled;
            PreviewImage(sender, e);
        }

        // changes the image width type
        private void _cbxWidthType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item.WidthType = (C1.Win.C1Editor.UICustomization.SizeType)_cbxWidthType.SelectedIndex;
            bool inPixel = Item.WidthType == C1.Win.C1Editor.UICustomization.SizeType.Pixel;
            _tbWidthValue.Maximum = inPixel ? 5000 : 200;

            if (_image != null)
            {
                _tbWidthValue.Value = inPixel ? Math.Max(Math.Min(_image.Width, 5000), 1) : 100;
                PreviewImage(sender, e);
            }
        }

        // changes the image height type
        private void _cbxHeightType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Item.HeightType = (C1.Win.C1Editor.UICustomization.SizeType)_cbxHeightType.SelectedIndex;
            bool inPixel = Item.HeightType == C1.Win.C1Editor.UICustomization.SizeType.Pixel;
            _tbHeightValue.Maximum = inPixel ? 5000 : 200;

            if (_image != null)
            {
                _tbHeightValue.Value = inPixel ? Math.Max(Math.Min(_image.Height, 5000), 1) : 100;
                PreviewImage(sender, e);
            }
        }

        // changes the image width
        private void _tbWidthValue_ValueChanged(object sender, EventArgs e)
        {
            Item.WidthValue = (int)_tbWidthValue.Value;
            PreviewImage(sender, e);
        }

        // changes the image height
        private void _tbHeightValue_ValueChanged(object sender, EventArgs e)
        {
            Item.HeightValue = (int)_tbHeightValue.Value;
            PreviewImage(sender, e);
        }

        #endregion

        #region IImageItemDialog Members

        /// <summary>
        /// Binds data from the item to GUI controls on the form.
        /// Data can be bound either using the <see cref="Control.DataBindings"/> collection or any other way allowing 
        /// to read data from the item and write it back.
        /// </summary>
        /// <param name="item">The item to be bound to the GUI controls.</param>
        void IImageItemDialog.BindData(XHTMLImageItem item)
        {
            _item = item;
            _cbxWidthType.SelectedIndex = (int)Item.WidthType;
            _cbxHeightType.SelectedIndex = (int)Item.HeightType;
            _tbWidthValue.Value = Math.Max(Item.WidthValue, 1);
            _tbHeightValue.Value = Math.Max(Item.HeightValue, 1);
            _tbSource.DataBindings.Add("Text", Item, "Source");
            _chkWidth.DataBindings.Add("Checked", Item, "UseWidth");
            _chkHeight.DataBindings.Add("Checked", Item, "UseHeight");
            _tbAlternate.DataBindings.Add("Text", Item, "Alternate");

            SetButtonState(this, EventArgs.Empty);
        }

        /// <summary>
        /// Shows the form with the specified owner to the user.
        /// </summary>
        /// <param name="owner">Any object that implements <see cref="System.Windows.Forms.IWin32Window"/> and represents 
        /// the top-level window that will own this form.</param>
        /// <returns>True if the form was displayed successfully and the item was changed.</returns>
        bool IImageItemDialog.Show(IWin32Window owner)
        {
            return Show(owner);
        }

        #endregion
    }
}

