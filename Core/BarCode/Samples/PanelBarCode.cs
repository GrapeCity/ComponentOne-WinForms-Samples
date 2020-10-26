using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace BarCodeExplorer.Samples
{
    using C1.BarCode;
    using C1.Win.BarCode;

    public delegate void SelectBarCodeEventHandler(object sender, EventArgs e);
    public class PanelBarCode : Panel
    {
        #region ** fields

        private bool _isActive = false;
        private bool _isSelect = false;
        private Color _frameColor = Color.FromArgb(51, 102, 204);
        private Color _selectColor = Color.FromArgb(102, 102, 153);
        static Random _random = new Random();

        private readonly C1BarCode _barCode;
        private readonly Label _label;
        private readonly Panel _innerPanel;

        #endregion

        #region ** ctor

        public PanelBarCode()
        {
            var delta = 6;
            Size = new System.Drawing.Size(200, 70);
            Cursor = Cursors.Hand;

            _label = new Label();
            _innerPanel = new Panel();

            _innerPanel.Location = new Point(delta, delta);
            _innerPanel.Size = new Size(200 - 2 * delta, 70 - 2 * delta);
            _innerPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            _innerPanel.MouseEnter += CustomMouseEnter;
            _innerPanel.MouseLeave += CustomMouseLeave;
            _innerPanel.Click += CustomClick;

            Controls.Add(_innerPanel);

            _label.MouseLeave += CustomMouseLeave;
            _label.MouseEnter += CustomMouseEnter;
            _label.Click += CustomClick;
        }

        public PanelBarCode(CodeType codeType) : this()
        {
            _innerPanel.Controls.Clear();

            _label.Dock = DockStyle.Top;
            _innerPanel.Controls.Add(_label);
            var value = _random.Next(1000, 99999999).ToString();

            // For EAN codes (hard length)
            if (codeType == CodeType.EAN_8)
                value = _random.Next(1000000, 9999999).ToString();

            if (codeType == CodeType.EAN_13 || codeType == CodeType.UPC_A || codeType == CodeType.ISBN)
                value = _random.Next(1000, 9999).ToString() + _random.Next(1000, 9999).ToString() + _random.Next(1000, 9999).ToString();

            if (codeType == CodeType.None)
                _label.Text = $"Type: None";
            else
            {
                _barCode = new C1BarCode()
                {
                    CodeType = codeType,
                    Text = value,
                    BackColor = Color.White,
                    Dock = DockStyle.Bottom
                };

                _barCode.MouseLeave += CustomMouseLeave;
                _barCode.MouseEnter += CustomMouseEnter;
                _barCode.Click += CustomClick;

                _label.Text = $"Type: {_barCode.CodeType.ToString()}";
                _innerPanel.Controls.Add(_barCode);
            }
        }

        #endregion

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public C1BarCode BarCode
        {
            get => _barCode;
        }

        [Description("The frame color"), Category("ComponentOne")]
        public Color FrameColor { get => _frameColor; set => _frameColor = value; }

        [Description("The activity status"), Category("ComponentOne")]
        public bool IsActive { get => _isActive; set => _isActive = value; }

        [Description("The status is select"), Category("ComponentOne")]
        public bool IsSelect
        {
            get => _isSelect;
            set
            {
                _isSelect = value;
                Invalidate();
            }
        }

        #region ** events

        [Description("Fires after a click")]
        public event SelectBarCodeEventHandler SelectBarCode;

        private void CustomClick(object sender, EventArgs e)
        {
            _isSelect = true;
            SelectBarCode?.Invoke(this, e);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            _isSelect = true;
            CustomClick(this, e);
        }

        private void CustomMouseLeave(object sender, EventArgs e)
        {
            _isActive = false;
            Invalidate();
        }

        private void CustomMouseEnter(object sender, EventArgs e)
        {
            _isActive = true;
            Invalidate();
        }

        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw frame
            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            var penColor = BackColor;
            if (_isActive)
                penColor = _frameColor;
            else
            if (_isSelect && !_isActive)
                penColor = _selectColor;

            Pen objPen = new Pen(penColor, 1);
            e.Graphics.DrawRectangle(objPen, rect);
        }
    }
}
