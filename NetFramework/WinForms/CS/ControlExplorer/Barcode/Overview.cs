using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.BarCode;
using C1.Win.C1InputPanel;

namespace ControlExplorer.Barcode
{
    public partial class Overview : C1DemoForm
    {
        public Overview()
        {
            InitializeComponent();
            txtBarCodeValue.Text = "1234567889012";
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            BarCodeValue = txtBarCodeValue.Text;   
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            //add demo properties
            AddProperty("BarHeight", this);
            AddProperty("CaptionPosition", this);
        }

        //gets and sets the Text property for all C1Barcodes inside the C1InputPanel
        public string BarCodeValue
        {
            get { return c1BarCode39.Text; }
            set {
                foreach (Control c in tableLayoutPanel1.Controls)
                {
                    var bar = c as C1BarCode;
                    if (bar != null)
                    {
                        bar.Text = value;
                    }
                }
            }
        }

        //gets and sets the ShowText property for all C1Barcodes inside the C1InputPanel
        public C1.BarCode.BarCodeCaptionPosition CaptionPosition
        {
            get { return c1BarCode39.CaptionPosition; }
            set
            {
                foreach (Control c in tableLayoutPanel1.Controls)
                {
                    var bar = c as C1BarCode;
                    if (bar != null)
                    {
                        bar.CaptionPosition = value;
                    }
                }
            }
        }

        //gets and sets the BarHeight property for all C1Barcodes inside the C1InputPanel
        public int BarHeight
        {
            get { return c1BarCode39.BarHeight; }
            set
            {
                foreach (Control c in tableLayoutPanel1.Controls)
                {
                    var bar = c as C1BarCode;
                    if (bar != null)
                    {
                        bar.BarHeight = value;
                    }
                }
            }
        }
    }
}
