using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.BarCode;

namespace ControlExplorer.Barcode
{
    public partial class BarCodeTypesSample : C1DemoForm
    {
        public BarCodeTypesSample()
        {
            InitializeComponent();
            c1BarCode1.CaptionPosition = C1.BarCode.BarCodeCaptionPosition.Below;
            c1BarCode1.EncodingError += c1BarCode1_EncodingError;
            c1BarCode1.AutoSize = true;
        }

        void c1BarCode1_EncodingError(object sender, EncodingErrorEventArgs e)
        {
            e.Text = "Supplied data are not valid for selected code type. Error: " + e.ErrorCode;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            c1BarCode1.Text = textBox1.Text;
        }

        private void BarCodeTypesSample_Load(object sender, EventArgs e)
        {
            //add demo properties
            AddProperty("CodeType", c1BarCode1);
            AddProperty("CaptionPosition", c1BarCode1);
            AddProperty("ModuleSize", c1BarCode1);
        }
    }
}
