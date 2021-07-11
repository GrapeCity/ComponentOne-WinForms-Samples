using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1Ribbon;

namespace ClickOnceDemo.GcZoomPages.ControlHosts
{
    /// <summary>
    /// The Ribbon element that contains a PictureBox.
    /// </summary>
    public class PictureBoxHost : RibbonControlHost
    {
        /// <summary>
        /// Creates the PictureBox control and its host element.
        /// </summary>
        public PictureBoxHost()
            : base(new PictureBox())
        {
        }

        /// <summary>
        /// Gets the hosted PictureBox control.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PictureBox PictureBox
        {
            get { return (PictureBox)Control; }
        }

        /// <summary>
        /// Gets or sets the image that the PictureBox displays.
        /// </summary>
        [Category("Appearance")]
        [Description("Gets or sets the image that the PictureBox displays.")]
        public Image Image
        {
            get { return PictureBox.Image; }
            set { PictureBox.Image = value; }
        }

        /// <summary>
        /// This property is not applicable to the PictureBox.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = value; }
        }
    }
}
