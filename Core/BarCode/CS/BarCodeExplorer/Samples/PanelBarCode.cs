using C1.BarCode;
using C1.Win.BarCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BarCodeExplorer.Samples
{
    public delegate void SelectBarCodeEventHandler(object sender, EventArgs e);
    public class PanelBarCode : Panel
    {
        #region ** fields

        private bool _isActive = false;
        private bool _isSelect = false;
        private Color _frameColor = Color.FromArgb(51, 102, 204);
        private Color _selectColor = Color.FromArgb(102, 102, 153);
        static Random _random = new Random();

        private const int c_delta = 6;
        private const int c_defaultLabelWidth = 70;
        private const int c_defaultLabelHeight = 23;

        private readonly C1BarCode _barCode;
        private readonly Label _label;
        private readonly Panel _innerPanel;

        private static Dictionary<string, CodeType> binaryCodes = new Dictionary<string, CodeType>()
        {
            {"11001", CodeType.PostNet },
            {"10101", CodeType.RSSExpanded },
            {"10011", CodeType.Pharmacode },
            {"10110", CodeType.RSSExpandedStacked}
        };

        private static Dictionary<int, CodeType> strongCodes = new Dictionary<int, CodeType>()
        {
            {13, CodeType.EAN_13},
            {14, CodeType.UPC_A },
            {8, CodeType.EAN_8 }
        };

        private static Dictionary<string, CodeType> specialCodes = new Dictionary<string, CodeType>()
        {
            {"00270123456200800001",CodeType.IntelligentMail},
            {"10705632085940", CodeType.ITF14},
            {"1234567", CodeType.PZN},
            {"9780976773665", CodeType.ISBN }
        };


        #endregion

        #region ** ctor

        public PanelBarCode(Size size, bool scaleBarCode)
        {
            var delta = GetSize(c_delta, c_delta).Width;
            if(scaleBarCode)
                Size = GetSize(size.Width, size.Height);
            else
            {
                var sz = GetSize(size.Width, c_defaultLabelHeight);
                sz.Height += size.Height - c_defaultLabelHeight;
                Size = sz;
            }
            
            Cursor = Cursors.Hand;

            _label = new Label() { Size = GetSize(c_defaultLabelWidth, c_defaultLabelHeight) };
            _innerPanel = new Panel();

            _innerPanel.Location = new Point(delta, delta);
            _innerPanel.Size = new Size(Width - 2 * delta, Height - 2 * delta);
            _innerPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;
            _innerPanel.MouseEnter += CustomMouseEnter;
            _innerPanel.MouseLeave += CustomMouseLeave;
            _innerPanel.Click += CustomClick;

            Controls.Add(_innerPanel);

            _label.MouseLeave += CustomMouseLeave;
            _label.MouseEnter += CustomMouseEnter;
            _label.Click += CustomClick;
        }

        public PanelBarCode(CodeType codeType, bool scaleBarCode, Size size) : this(size, scaleBarCode)
        {
            _innerPanel.Controls.Clear();

            _label.Dock = DockStyle.Top;
            _innerPanel.Controls.Add(_label);
            var value = GetValue(codeType);

            if (codeType == CodeType.None)
                _label.Text = $"Type: None";
            else
            {
                _barCode = new C1BarCode()
                {
                    CodeType = codeType,
                    Text = value,
                    BackColor = Color.White,
                    Dock = DockStyle.Bottom,
                    BarHeight = _innerPanel.Height - _label.Height,
                    QuietZone = new QuietZone(4, 4, 4, 4)                    
                };

                _barCode.MouseLeave += CustomMouseLeave;
                _barCode.MouseEnter += CustomMouseEnter;
                _barCode.Click += CustomClick;

                _label.Text = $"Type: {_barCode.CodeType.ToString()}";
                _innerPanel.Controls.Add(_barCode);
            }
        }

        #endregion

        private static string GetValue(CodeType codeType)
        {
            // Max value
            var value = _random.Next(1000, 9999).ToString() + _random.Next(1000, 9999).ToString() + _random.Next(1000, 9999).ToString() + _random.Next(1000, 9999).ToString();

            if (strongCodes.Values.Any(x => x == codeType))
            {
                value = value.Substring(0, strongCodes.FirstOrDefault(x => x.Value == codeType).Key - 1);
                return value;
            }

            if (binaryCodes.Values.Any(x => x == codeType))
                return binaryCodes.FirstOrDefault(x => x.Value == codeType).Key;

            if (specialCodes.Values.Any(x => x == codeType))
                return specialCodes.FirstOrDefault(x => x.Value == codeType).Key;

            // Default value
            value = _random.Next(1000, 99999999).ToString();
            return value;
        }

        [Browsable(false)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public C1BarCode BarCode
        {
            get => _barCode;
        }

        [Description("The frame color"), Category("ComponentOne")]
        [DefaultValue(typeof(Color), "51, 102, 204")]
        public Color FrameColor { get => _frameColor; set => _frameColor = value; }

        [Description("The activity status"), Category("ComponentOne")]
        [DefaultValue(false)]
        public bool IsActive { get => _isActive; set => _isActive = value; }

        [Description("The status is select"), Category("ComponentOne")]
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
    }
}
