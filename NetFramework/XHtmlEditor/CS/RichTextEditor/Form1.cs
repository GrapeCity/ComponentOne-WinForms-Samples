using C1.Win.Ribbon;
using System.Drawing;
using System.Windows.Forms;

namespace RichTextEditor
{
    public partial class Form1 : C1RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            InitExtendedRibbon();
        }
        private void InitExtendedRibbon()
        {
            var extendedRibbon = new ExtendedC1Ribbon
            {
                C1Editor = this.editor,
                Location = new Point(0, 0),
                Margin = new Padding(2),
                Name = "ribbon",
                Size = new Size(800, 167),
            };
            this.c1ThemeController1.SetTheme(extendedRibbon, "(default)");
            this.Controls.Add(extendedRibbon);
        }

        //editor rounded corner
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int cornerRadius = 3; // Adjust the corner radius in pixels

            // Dispose the previous Region if one exists to avoid memory leaks
            this.editor.Region?.Dispose();

            // Use 'using' to ensure proper disposal of the GraphicsPath object
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                // Use ClientRectangle to ensure proper dimensions
                Rectangle rect = this.editor.ClientRectangle;

                path.AddArc(rect.Left, rect.Top, cornerRadius * 2, cornerRadius * 2, 180, 90); // Upper-left corner
                path.AddArc(rect.Right - cornerRadius * 2, rect.Top, cornerRadius * 2, cornerRadius * 2, 270, 90); // Upper-right corner
                path.AddArc(rect.Right - cornerRadius * 2, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90); // Bottom-right corner
                path.AddArc(rect.Left, rect.Bottom - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 90, 90); // Bottom-left corner
                path.CloseFigure();

                // Assign the new region to the editor
                this.editor.Region = new Region(path);
            }
        }
    }
}
