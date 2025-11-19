// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using System.Drawing;
using System.Windows.Forms;

namespace MultiSelectExplorer.Samples.Utilities
{
    /// <summary>
    /// Provides helper methods for creating visual overlays.
    /// </summary>
    public static class OverlayHelper
    {
        /// <summary>
        /// Creates a semi-transparent black overlay form that covers the specified parent control.
        /// </summary>
        public static Form CreateOverlay(Control parent)
        {
            var overlay = new Form
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                ShowInTaskbar = false,
                BackColor = Color.Black,
                Opacity = 0.3,
                Size = parent.ClientSize,
                Location = parent.PointToScreen(parent.ClientRectangle.Location)
            };

            return overlay;
        }
    }
}
