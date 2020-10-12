using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Forms.VisualStyles;
using C1.Win.C1Editor;
using C1.Win.C1Editor.UICustomization;
using Resources = global::CustomDialogs.Properties.Resources;

namespace CustomDialogs
{

    /// <summary>
    /// This type is for internal use only.
    /// </summary>
    internal partial class BaseEditorForm : Form
    {
        #region declarations

        private C1Editor _editor = null;

        /// <summary>
        /// This member is for internal use only.
        /// </summary>
        protected ToolTip _tooltip = null;
        /// <summary>
        /// This member is for internal use only.
        /// </summary>
        protected XHTMLItemBase _item;

        #endregion

        #region ctors

        /// <summary>
        /// This member is for internal use only.
        /// </summary>
        protected BaseEditorForm()
        {
            InitializeComponent();
            Font = SystemInformation.MenuFont;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        #endregion

        #region implementation

        /// <summary>
        /// Gets or sets the editor.
        /// </summary>
        public C1Editor Editor
        {
            get { return _editor; }
            set { _editor = value; }
        }

        private void AdjustFormWidth()
        {
            AdjustMinimumSize();
        }

        private void AdjustMinimumSize()
        {
            // calculate minimum width for the controls on the form
            int minWidth = _containerMain.MinimumSize.Width;
            int btnWidth = ClientSize.Width - _btnOK.Left + (_btnAplly.Visible ? _btnAplly.Width : 0);
            // check whether more space for the bottom buttons is required
            if (btnWidth > minWidth)
                minWidth = btnWidth;
            int border = this.Width - this.ClientSize.Width;
            int right = this.Width - _containerMain.Left - _containerMain.Width;
            int left = _containerMain.Left;
            if (this.Text != "BaseEditorForm")
                this.MinimumSize = new Size(minWidth + left + right + border, this.MinimumSize.Height);
        }

        protected virtual void ApllyClick(object sender, EventArgs e)
        {
            BindingContext[_item].EndCurrentEdit();
            if (_item.IsEditMode)
            {
                _item.ApplyChanges();
                OnItemPropertiesChanged();
                Focus();
            }
        }

        protected virtual void OnItemPropertiesChanged()
        {
            // used in derived classes
        }

        /// <summary>
        /// If the sender is <see cref="NumericUpDown"/>, its <see cref="p:NumericUpDown.Value"/> property will be set to the <see cref="p:NumericUpDown.Text"/> property.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains no event data.</param>
        protected virtual void ValidateNumber(object sender, EventArgs e)
        {
            NumericUpDown control = sender as NumericUpDown;
            if (control != null)
                control.Text = control.Value.ToString(); 
        }

        protected new bool Show(IWin32Window owner)
        {
            _btnAplly.Visible = _item.ApplyButtonVisible;
            int margin = _btnCancel.Left - _btnOK.Right;
            _btnCancel.Left = _item.ApplyButtonVisible ? _btnAplly.Left - margin - _btnCancel.Width : _btnAplly.Left;
            _btnOK.Left = _btnCancel.Left - margin - _btnOK.Width;
            return ShowDialog(owner) == DialogResult.OK;
        }

        protected void PaintBorder(object sender, PaintEventArgs e)
        {
            Rectangle rectangle = ((Control)sender).ClientRectangle;
            if (Application.RenderWithVisualStyles
                && VisualStyleRenderer.IsElementDefined(VisualStyleElement.TextBox.TextEdit.Normal))
            {
                VisualStyleRenderer render = new VisualStyleRenderer(VisualStyleElement.TextBox.TextEdit.Normal);
                render.DrawBackground(e.Graphics, rectangle);
            }
            else
            {
                rectangle.Width--;
                rectangle.Height--;
                ToolStripProfessionalRenderer render = new ToolStripProfessionalRenderer();
                e.Graphics.DrawRectangle(new Pen(Color.FromArgb(21, 66, 139)), rectangle);
            }
        }

        /// <summary>
        /// This member is for internal use only.
        /// </summary>
        protected void LoadSizeFormat(ComboBox control)
        {
            control.Items.Clear();
            control.Items.Add(Resources.sPixels);
            control.Items.Add(Resources.sPercent);
        }

        /// <summary>
        /// This member is for internal use only.
        /// </summary>
        protected void LoadAlignmentHorizontalFormat(ComboBox control)
        {
            control.Items.Clear();
            control.Items.Add(Resources.sAlignmentDefault);
            control.Items.Add(Resources.sAlignmentLeft);
            control.Items.Add(Resources.sAlignmentCenter);
            control.Items.Add(Resources.sAlignmentRight);
        }

        /// <summary>
        /// This member is for internal use only.
        /// </summary>
        protected void LoadAlignmentVerticalFormat(ComboBox control)
        {
            control.Items.Clear();
            control.Items.Add(Resources.sAlignmentDefault);
            control.Items.Add(Resources.sAlignmentTop);
            control.Items.Add(Resources.sAlignmentMiddle);
            control.Items.Add(Resources.sAlignmentBottom);
        }

        /// <summary>
        /// Adjusts the buttons height and top position according to the size and position of controls.
        /// </summary>
        /// <param name="buttons">An array of <see cref="Button"/>s to be adjusted.</param>
        /// <param name="controls">An array of <see cref="Control"/>s used for button adjusting.</param>
        protected void AdjustBrowseButtons(Button[] buttons, Control[] controls)
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                Button button = buttons[i];
                Control control = controls[i];
                button.Top = control.Top - 1;
                button.Height = control.Height + 2;
            }
        }

        /// <summary>
        /// Returns a relative or absolute path in Windows local file format.
        /// </summary>
        /// <param name="path">A path in any format.</param>
        /// <returns>A path in Windows local file format.</returns>
        protected string GetLocalPath(string path)
        {
            Uri uri;
            if (!Uri.TryCreate(path, UriKind.RelativeOrAbsolute, out uri))
                return null;
            if (uri.IsAbsoluteUri)
                path = uri.LocalPath;
            else
                path = uri.OriginalString.Replace('/', System.IO.Path.DirectorySeparatorChar);
            return Uri.UnescapeDataString(path);
        }

        /// <summary>
        /// Returns a relative URI for the fileName according to the given base path
        /// </summary>
        /// <param name="path">Base path used to calculate the relative URI.</param>
        /// <param name="fileName">File name to be converted to URI format.</param>
        /// <returns>Relative URI</returns>
        protected string GetUriFromPath(string path, string fileName)
        {
            Uri fileNameUri = new Uri(fileName);
            Uri uri = path != null ? new Uri(path).MakeRelativeUri(fileNameUri) : fileNameUri;
            return Uri.UnescapeDataString(new Uri(uri.ToString(), UriKind.RelativeOrAbsolute).ToString());
        }


        /// <summary>
        /// Corrects width and height: if width/height exceeds maxWidth/maxHeight, 
        /// they are decreased to maxWidth/maxHeight with saving ratio.
        /// </summary>
        /// <param name="width">The width of the object.</param>
        /// <param name="height">The height of the object.</param>
        /// <param name="maxWidth">The maximum width of the object.</param>
        /// <param name="maxHeight">The maximum height of the object.</param>
        protected void ScaleSize(ref int width, ref int height, int maxWidth, int maxHeight)
        {
            double scaleX = (maxWidth > 0) ? ((double)width / (double)maxWidth) : 0;
            double scaleY = (maxHeight > 0) ? ((double)height / (double)maxHeight) : 0;
            if (scaleX > 1 || scaleY > 1)
            {
                double proportion = (height > 0) ? ((double)width / (double)height) : 0;
                if (scaleX > scaleY)
                {
                    width = maxWidth;
                    height = (proportion > 0) ? (int)(maxWidth / proportion) : 0;
                }
                else
                {
                    width = (proportion > 0) ? (int)(maxHeight * proportion) : 0;
                    height = maxHeight;
                }
            }
            if (width < 1)
                width = 1;
            if (height < 1)
                height = 1;
        }

        /// <summary>
        /// Adds a border to the <see cref="Image"/>.
        /// </summary>
        /// <param name="image">An <see cref="Image"/> to add border.</param>
        /// <param name="width">Border width.</param>
        /// <param name="color"><see cref="Color"/> of the border.</param>
        /// <returns>The <see cref="Image"/> with the specified border.</returns>
        protected Image AddBorder(Image image, int width, Color color)
        {
            if (image == null || width <= 0)
                return image;

            int imageWidth = image.Width + width * 2;
            int imageHeight = image.Height + width * 2;
            Rectangle[] rects = new Rectangle[width];
            for (int i = 1; i <= width; i++)
                rects[i - 1] = new Rectangle(i - 1, i - 1, imageWidth - i * 2 + 1, imageHeight - i * 2 + 1);

            Bitmap bitmap = new Bitmap(imageWidth, imageHeight);
            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                using (Pen pen = new Pen(color))
                {
                    graphics.DrawRectangles(pen, rects);
                }
            }
            return CombineImages(bitmap, image, AnchorStyles.None);
        }

        /// <summary>
        /// Merges two images into the single image.
        /// </summary>
        /// <param name="img1">The first image to be drawn at background.</param>
        /// <param name="img2">The second image to be drawn at foreground.</param>
        /// <param name="anchor">The anchor specifying how to align the second image.</param>
        /// <returns>The merged image.</returns>
        protected Image CombineImages(Image img1, Image img2, AnchorStyles anchor)
        {
            Bitmap img = new Bitmap(img1);
            using (Graphics g = Graphics.FromImage(img))
            {
                Rectangle rc1 = new Rectangle(Point.Empty, img1.Size);
                Rectangle rc2 = new Rectangle(Point.Empty, img2.Size);
                if ((anchor & AnchorStyles.Bottom) == AnchorStyles.Bottom)
                    rc2.Offset(0, img1.Height - img2.Height);
                if ((anchor & AnchorStyles.Right) == AnchorStyles.Right)
                    rc2.Offset(img1.Width - img2.Width, 0);
                if (anchor == AnchorStyles.None)
                    rc2.Offset((img1.Width - img2.Width) / 2, (img1.Height - img2.Height) / 2);
                g.DrawImage(img2, rc2);
            }
            return img;
        }

        #endregion

        #region internal classes

        /// <summary>
        /// Represents a List of strings.
        /// </summary>
        internal class StringList : List<string>
        {
            private StringComparer _comparer = StringComparer.InvariantCultureIgnoreCase;
            /// <summary>
            /// Determines whether a string is in the <see cref="StringList"/>. 
            /// </summary>
            /// <param name="item">The string to locate in the <see cref="StringList"/>. The value can be null for reference types.</param>            
            /// <returns>true if <paramref name="item"/> is found in the <see cref="StringList"/>; otherwise, false.</returns>
            public new bool Contains(string item)
            {
                if (item == null)
                {
                    for (int i = 0; i < this.Count; i++)
                        if (this[i] == null)
                            return true;
                    return false;
                }
                for (int j = 0; j < this.Count; j++)
                    if (_comparer.Equals(this[j], item))
                        return true;
                return false;
            }
        }

        /// <summary>
        /// Calculates the size of a Flash movie.
        /// </summary>
        internal class FlashMovieSize
        {
            private int[] _sizes = new int[4];

            #region ctors

            public FlashMovieSize(string fileName)
            {
                byte[] buffer = new byte[17];
                try
                {
                    using (FileStream fs = File.Open(fileName, FileMode.Open))
                    {
                        fs.Seek(8, SeekOrigin.Begin);
                        fs.Read(buffer, 0, 17);
                    }
                    Parse(buffer);
                }
                catch
                {
                    for (int i = 0; i < _sizes.Length; _sizes[i++] = 0) ;
                }
            }

            #endregion

            #region implementation

            private string BinaryFormat(byte value)
            {
                string res = Convert.ToString(value, 2);
                return new string('0', 8 - res.Length) + res;
            }

            private void Parse(byte[] buffer)
            {
                string s = string.Empty;
                for (int i = 0; i < buffer.Length; i++)
                    s += BinaryFormat(buffer[i]);

                int dimensionLength = Convert.ToInt32(s.Substring(0, 5), 2);
                for (int i = 0; i < _sizes.Length; i++)
                {
                    string temp = s.Substring(5 + dimensionLength * i, dimensionLength);
                    if (temp[0] == '1')
                        temp = new string('1', 32 - temp.Length) + temp;
                    _sizes[i] = Convert.ToInt32(temp, 2) / 20;
                }

                return;
            }

            #endregion

            #region properties

            public int Width
            {
                get { return _sizes[1] > _sizes[0] ? _sizes[1] - _sizes[0] : 0; }
            }

            public int Height
            {
                get { return _sizes[3] > _sizes[2] ? _sizes[3] - _sizes[2] : 0; }
            }

            #endregion
        }

        #endregion
    }
}