using System;
using System.Windows;
using System.Windows.Controls;

namespace BarcodeWPF
{
    /// <summary>
    /// Implements a linear bar code element based on the C1BarCode control.
    /// </summary>
    class C1BarCodeElement : BarcodeElement
    {
        // create C1QRCode WinForms control
        C1.Win.C1BarCode.C1BarCode _barCode = new C1.Win.C1BarCode.C1BarCode();

        /// <summary>
        /// Gets or sets the type of encoding to use.
        /// </summary>
        public C1.Win.C1BarCode.CodeTypeEnum CodeType
        {
            get { return _barCode.CodeType; }
            set { _barCode.CodeType = value; }
        }
        /// <summary>
        /// Gets a System.Drawing.Image containing the barcode image.
        /// </summary>
        /// <returns>A System.Drawing.Image containing the barcode image.</returns>
        protected override System.Drawing.Image GetImage()
        {
            _barCode.Text = Text;
            return _barCode.Image;
        }
    }
    /// <summary>
    /// Implements a 2-D bar code element based on the C1QRCode control.
    /// </summary>
    class C1QRCodeElement : BarcodeElement
    {
        // create C1QRCode WinForms control
        C1.Win.C1BarCode.C1QRCode _qrCode = new C1.Win.C1BarCode.C1QRCode();

        /// <summary>
        /// Gets a System.Drawing.Image containing the barcode image.
        /// </summary>
        /// <returns>A System.Drawing.Image containing the barcode image.</returns>
        protected override System.Drawing.Image GetImage()
        {
            _qrCode.Text = Text;
            return _qrCode.Image;
        }
    }
    /// <summary>
    /// Base class for C1BarCodeElement and C1QRCodeElement
    /// </summary>
    abstract class BarcodeElement : Image
    {
        /// <summary>
        /// Gets or sets the text to be displayed in the bar code element.
        /// </summary>
        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(string), typeof(BarcodeElement),
            new PropertyMetadata(BarcodeElement.OnPropChanged));
        static void OnPropChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var bc = (BarcodeElement)d;
            bc.UpdateImage();
        }
        /// <summary>
        /// Gets a System.Drawing.Image containing the barcode image.
        /// </summary>
        /// <returns>A System.Drawing.Image containing the barcode image.</returns>
        protected virtual System.Drawing.Image GetImage()
        {
            return null;
        }

        // load barcode image into this Image element
        void UpdateImage()
        {
            // get image
            System.Drawing.Image img = null;
            try
            {
                img = GetImage();
            }
            catch { /* invalid text for this encoding? */ }

            // apply image to this element
            if (img != null)
            {
                var bi = new System.Windows.Media.Imaging.BitmapImage();
                bi.BeginInit();
                bi.StreamSource = null;
                var stream = new System.IO.MemoryStream();
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                stream.Position = 0;
                bi.StreamSource = stream;
                bi.EndInit();
                Source = bi;
            }
            else
            {
                this.Source = null;
            }
        }
    }
}
