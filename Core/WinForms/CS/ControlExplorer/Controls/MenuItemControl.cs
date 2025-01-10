using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ControlExplorer.Controls
{
    public partial class MenuItemControl : UserControl
    {
        #region Private Variables
        private bool _isSelected = false;
        private Color _selectedBgColor = Color.Transparent;
        private Color _hoverBgColor = Color.FromArgb(233, 232, 232);
        private Color _indicatorColor = Color.FromArgb(214, 86, 76);
        #endregion

        #region Public Methods 
        public string MenuName { get; set; }
        public bool Selected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                ResetSelection();
            }
        }
       
        public void SetWidth(string text, int padding = 0)
        {
            using (Graphics g = this.CreateGraphics())
            {
                int textWidth = TextRenderer.MeasureText(g, text, lblMenuItem.Font).Width;
                float dpiScaleFactor = this.DeviceDpi / 96f;
                int marginPadding = lblMenuItem.Margin.Left + lblMenuItem.Margin.Right;
                this.Width = (int)((textWidth + padding + marginPadding) * dpiScaleFactor);
                lblMenuItem.Width = textWidth;
            }
        }
        public MenuItemControl(string menuName)
        {
            InitializeComponent();
            MenuName = menuName;
            lblMenuItem.Text = MenuName;

            pnlIndicatorWrapper.Height = 6;
            pnlIndicator.Height = pnlIndicatorWrapper.Height;
            pnlIndicator.Width = 35;
            pnlIndicator.BackColor = Color.Transparent;
            pnlIndicator.Visible = false;
            pnlIndicator.Location = new Point((pnlIndicatorWrapper.Width - pnlIndicator.Width) / 2, 0);

            pnlIndicatorWrapper.Resize += (s, e) =>
            {
                pnlIndicator.Location = new Point((pnlIndicatorWrapper.Width - pnlIndicator.Width) / 2, 0);
            };

            pnlIndicator.Paint += IndicatorPanel_Paint;

            lblMenuItem.Click += (s, e) => this.OnClick(e);
            lblMenuItem.MouseEnter += (s, e) => MenuItemControl_MouseEnter(s, e);
            lblMenuItem.MouseLeave += (s, e) => MenuItemControl_MouseLeave(s, e);
        }

        #endregion

        #region Private Methods
        private void ResetSelection()
        {
            pnlMenuWrapper.BackColor = _isSelected ? _selectedBgColor : Color.Transparent;
            pnlIndicator.Visible = _isSelected;
            pnlIndicator.Invalidate();

        }

        private void IndicatorPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle bounds = new Rectangle(0, 0, pnlIndicator.Width - 1, pnlIndicator.Height - 1);
            int cornerRadius = Math.Min(bounds.Height / 2, bounds.Width / 2);
            using (GraphicsPath path = new GraphicsPath())
            {
                path.StartFigure();
                path.AddArc(bounds.X, bounds.Y, cornerRadius * 2, cornerRadius * 2, 180, 90);
                path.AddArc(bounds.Right - cornerRadius * 2, bounds.Y, cornerRadius * 2, cornerRadius * 2, 270, 90);
                path.AddArc(bounds.Right - cornerRadius * 2, bounds.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90);
                path.CloseFigure();
                using (Brush brush = new SolidBrush(_indicatorColor))
                {
                    g.FillPath(brush, path);
                }
            }
        }

        private void MenuItemControl_MouseEnter(object sender, EventArgs e)
        {
            if (!Selected)
            {
                pnlMenuWrapper.BackColor = _hoverBgColor;
            }
        }

        private void MenuItemControl_MouseLeave(object sender, EventArgs e)
        {
            if (!Selected)
            {
                pnlMenuWrapper.BackColor = Color.Transparent;
            }
        }

        #endregion
       
        #region Protected Methods
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
        #endregion
    }
}
