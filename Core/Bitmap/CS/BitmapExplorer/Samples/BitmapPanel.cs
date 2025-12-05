using C1.Win.Bitmap;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BitmapExplorer.Samples
{
    public delegate void SelectBimapPanelHandler(object sender, EventArgs e);

    public class BitmapPanel : Panel
    {
        #region ** fields

        private bool _isSelect = false;
        private Color _selectColor = Color.FromArgb(102, 102, 153);        

        // For size
        private const int _delta = 6;
        private const int _defaultLabelHeight = 23;

        private readonly C1Bitmap _bitmap;
        private readonly string _caption;
        private readonly string _description;

        private readonly RichTextBox _label;
        private readonly Panel _innerPanel;
        private PictureBox _picture;

        private readonly Color _defaultColor;
        private readonly Color _defaultBackColor;

        #endregion

        #region ** ctor

        public BitmapPanel(Size size, bool scalePicture)
        {
            this.Click += CustomClick;
            Cursor = Cursors.Hand;

            // Set size 
            SetSizeControl(size, scalePicture);
            _innerPanel = new Panel()
            {
                Location = new Point(_delta, _delta),
                Size = new Size(Width - 2 * _delta, Height - 2 * _delta)
            };
            _innerPanel.Click += CustomClick;

            Controls.Add(_innerPanel);
            _bitmap = new C1Bitmap();
        }

        public BitmapPanel(DataRow rowData, bool scalePicture, Size size) : this(size, scalePicture)
        {
            _innerPanel.Controls.Clear();

            var checkColumns = new List<string>() { "Caption", "Picture", "Description" };
            var sourceColumns = (from s in rowData.Table.Columns.Cast<DataColumn>() select s)
                .Select(x => x.ColumnName);

            if (!checkColumns.Where(x => sourceColumns.Contains(x)).Any())
                MessageBox.Show("The data source did not corrent!\nExpect columns: " + string.Join(",", checkColumns.ToArray()));

            // Add label
            _caption = rowData["Caption"].ToString();
            _description = rowData["Description"].ToString();

            _label = new RichTextBox()
            {
                Text = _caption,
                Dock = DockStyle.Bottom,
                BackColor = System.Drawing.SystemColors.Window,
                BorderStyle = System.Windows.Forms.BorderStyle.None,
                ReadOnly = true,
                Cursor = Cursors.Hand
            };
            _label.Height = _label.Font.Height + 2;
            _label.SelectAll();
            _label.SelectionAlignment = HorizontalAlignment.Center;

            _label.Click += CustomClick;
            _innerPanel.Controls.Add(_label);

            // Add bitmap
            _bitmap = (C1Bitmap)rowData["Picture"];
            SetImagePanel();

            _defaultColor = _label.SelectionColor;
            _defaultBackColor = _label.SelectionBackColor;
        }

        #endregion

        #region ** events

        public event SelectBimapPanelHandler SelectImage;

        private void CustomClick(object sender, EventArgs e)
        {
            SelectImage?.Invoke(this, e);
            IsSelect = true;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            CustomClick(this, e);
        }

        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw frame
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            var penColor = BackColor;
            if (_isSelect)
                penColor = _selectColor;

            Pen objPen = new Pen(penColor, 1);
            e.Graphics.DrawRectangle(objPen, rect);
        }

        #region ** size
        private void SetSizeControl(Size size, bool scalePicture)
        {
            if (scalePicture)
                Size = GetSize(size.Width, size.Height);
            else
            {
                var sz = GetSize(size.Width, _defaultLabelHeight);
                sz.Height += size.Height - _defaultLabelHeight;
                Size = sz;
            }
        }

        private Size GetSize(int width, int height)
        {
            int dpi = base.DeviceDpi;
            if (dpi != 96)
            {
                double scale = (double)dpi / 96;
                width = (int)(width * scale);
                height = (int)(height * scale);
            }
            return new Size(width, height);
        }

        #endregion

        #region ** properties

        public string Caption => _caption;

        [DefaultValue(false)]
        public bool IsSelect
        {
            get => _isSelect;
            set
            {
                _isSelect = value;
                Invalidate();
            }
        }

        public C1Bitmap Bitmap
        {
            get => _bitmap; 
        }

        public string Description => _description;

        #endregion

        public void Select(string selectText)
        {
            _label.SelectAll();
            _label.SelectionColor = _defaultColor;
            _label.SelectionBackColor = _defaultBackColor;

            // Set selection in red color
            if (_caption.IndexOf(selectText) >= 0)
            {
                var startPosition = _caption.IndexOf(selectText);
                var stopPosition = startPosition + selectText.Length;
                _label.Select(startPosition, stopPosition);
                _label.SelectionColor = Color.Red;
                _label.SelectionBackColor = Color.Yellow;
            }
        }

        private void SetImagePanel()
        {
            if (_bitmap == null) return;

            _picture = new PictureBox()
            {
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = _bitmap.ToGdiBitmap(),
                Location = new Point(0, 0),
                Width = _innerPanel.Width,
                Height = _innerPanel.Height - _label?.Height?? 0
            };
            _picture.Click += CustomClick;
            _innerPanel.Controls.Add(_picture);
        }
    }
}
