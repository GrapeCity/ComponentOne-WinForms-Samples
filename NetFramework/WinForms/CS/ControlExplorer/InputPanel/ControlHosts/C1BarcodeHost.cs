using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.C1InputPanel;
using C1.Win.BarCode;

namespace ControlExplorer.InputPanel.ControlHosts
{
    class C1BarcodeHost : InputControlHost
    {
        /// <summary>
        /// Creates the C1Barcode control and its host element.
        /// </summary>
        public C1BarcodeHost()
            : base(new C1BarCode())
        {
            // initialize width and height
            Width = 250;
            Height = BarCode.Height = 55;
            BarCode.SizeChanged += BarCode_SizeChanged;
            BarCode.AutoSize = false;
        }

        void BarCode_SizeChanged(object sender, EventArgs e)
        {
            // adjust size, so that all barcode fits into space at zooming
            Height = BarCode.Height + Padding.Size.Height;
            Width = BarCode.Width + Padding.Size.Width;
        }

        /// <summary>
        /// Gets the hosted C1BarCode control.
        /// </summary>
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public C1BarCode BarCode
        {
            get { return (C1BarCode)Control; }
        }

        /// <summary>
        /// Gets or sets the Code Type that the C1BarCode displays.
        /// </summary>
        [Category("Appearance")]
        [Description("Gets or sets the Code Type that the C1BarCode displays.")]
        public C1.BarCode.CodeType CodeType
        {
            get { return BarCode.CodeType; }
            set { BarCode.CodeType = value; }
        }

        [Category("Appearance")]
        [Description("Gets or sets Text position.")]
        public C1.BarCode.BarCodeCaptionPosition CaptionPosition
        {
            get { return BarCode.CaptionPosition; }
            set { BarCode.CaptionPosition = value; }
        }

        [Category("Appearance")]
        [Description("Gets or sets the height of the bars.")]
        public int BarHeight
        {
            get { return BarCode.BarHeight; }
            set { BarCode.BarHeight = value; }
        }
    }
}
