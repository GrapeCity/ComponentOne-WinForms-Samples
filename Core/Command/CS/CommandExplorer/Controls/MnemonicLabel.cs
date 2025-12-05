using System;
using System.Drawing;
using System.Windows.Forms;

namespace CommandExplorer.Controls
{
    /// <summary>
    /// Represents a label control that supports mnemonic (keyboard shortcut) appearance.
    /// </summary>
    /// <remarks>
    /// Unlike the standard <see cref="System.Windows.Forms.Label"/>, which binds the
    /// <see cref="System.Windows.Forms.Label.UseMnemonic"/> property to both behavior
    /// and UI appearance, <see cref="MnemonicLabel"/> draws the label without the behaviour of a mnemonic.
    /// </remarks>
    public partial class MnemonicLabel : Label
    {
        public MnemonicLabel()
        {
            UseMnemonic = false;
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            if (string.IsNullOrEmpty(Text)) return;

            TextFormatFlags flags = TextFormatFlags.EndEllipsis | TextAlign switch
            {
                ContentAlignment.TopLeft => TextFormatFlags.Left | TextFormatFlags.Top,
                ContentAlignment.TopCenter => TextFormatFlags.HorizontalCenter | TextFormatFlags.Top,
                ContentAlignment.TopRight => TextFormatFlags.Right | TextFormatFlags.Top,
                ContentAlignment.MiddleLeft => TextFormatFlags.Left | TextFormatFlags.VerticalCenter,
                ContentAlignment.MiddleCenter => TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter,
                ContentAlignment.MiddleRight => TextFormatFlags.Right | TextFormatFlags.VerticalCenter,
                ContentAlignment.BottomLeft => TextFormatFlags.Left | TextFormatFlags.Bottom,
                ContentAlignment.BottomCenter => TextFormatFlags.HorizontalCenter | TextFormatFlags.Bottom,
                ContentAlignment.BottomRight => TextFormatFlags.Right | TextFormatFlags.Bottom,
                _ => throw new NotImplementedException()
            };

            // Draw the text, forcing the mnemonic to always be visible
            TextRenderer.DrawText(
                e.Graphics,
                Text,
                Font,
                ClientRectangle,
                ForeColor, 
                BackColor,
                flags
            );
                
        }
    }
}
