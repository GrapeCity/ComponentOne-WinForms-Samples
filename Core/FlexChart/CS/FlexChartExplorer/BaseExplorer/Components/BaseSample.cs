using BaseExplorer.Core;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace BaseExplorer.Components
{
    public partial class BaseSample : UserControl
    {
        private bool _showDescPanel = true;
        private string _theme = "Office365White";

        public string Id { get; private set; }

        [DefaultValue(null)]
        public string Title { get; set; }

        [DefaultValue("Office365White")]
        public string Theme 
        { 
            get
            {
                return _theme;
            }
            set
            {
                if (_theme != value) 
                {
                    _theme = value;
                    rootPanel.Invalidate();
                    ApplyTheme();
                }
                else
                {
                    _theme = value;
                } 
            }
        }

        [DefaultValue(true)]
        public bool ShowDescriptionPanel
        {
            get { return _showDescPanel; }
            set
            {
                if (_showDescPanel != value)
                {
                    _showDescPanel = value;
                    pnlControls.Visible = value;
                }
            }
        }

        public BaseSample()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            ColorPanels(Theme == "Office365Black" ? SkinManager.Office365LightBlack : SkinManager.LightBackColor);
        }

        private void ColorPanels(Color color)
        {
            this.BackColor = color;
            rootPanel.BackColor = color;
            pnlControls.BackColor = color;
            pnlMain.BackColor = color;
        }

        /// <summary>
        /// Gets the thumbnail image of the sample
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public virtual Image GetImage(int width = 200, int height = 200)
        {
            var bmp = new Bitmap(this.Width, this.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            this.DrawToBitmap(bmp, this.DisplayRectangle);
            var thumb = bmp.GetThumbnailImage(width, height, null, IntPtr.Zero);
            return thumb;
        }

        private void BaseSample_SizeChanged(object sender, EventArgs e)
        {
        }

        private void pnlControls_Paint(object sender, PaintEventArgs e)
        {
            pnlControls.Visible = pnlControls.Controls.Count > 0;
        }

        public virtual void RootPanelPaint(object sender, PaintEventArgs e)
        {
            if(this.GetType().Name != "Home")
            {
                Graphics g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                int diameter = 8;
                Rectangle rect = rootPanel.ClientRectangle;

                GraphicsPath path = new GraphicsPath();
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // Top-left corner
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); // Top-right corner
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // Bottom-right corner
                path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); // Bottom-left corner
                path.CloseFigure();

                Color demoBackColor = (Theme == "Office365White" ? SkinManager.Office365Grey : SkinManager.Office365Black);

                using (Brush whiteBrush = new SolidBrush(demoBackColor))
                {
                    g.FillPath(whiteBrush, path);
                }
            } 
        }

        // Was needed for Home only during creation, override this if needed in other samples inhereting base sample
        public virtual void ReapplyProperties(){ }
    }
}
