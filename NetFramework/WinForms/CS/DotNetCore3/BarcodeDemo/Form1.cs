using C1.BarCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBarCode {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        Array types = Enum.GetValues(typeof(CodeType));
        private void Form1_Load(object sender, EventArgs e) {
            tbText.Text = "CODE39";
            propertyGrid1.SelectedObject = c1BarCode1;
            cbCodeType.DataSource = types;
            cbCodeType.SelectedIndex = Array.IndexOf(types, CodeType.Code39);
            cbCodeType.Select();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            c1BarCode1.Text = tbText.Text;
        }

        private void TemplateButton_Click(object sender, EventArgs e) {
            Button btn = (Button)sender;
            switch (btn.Name) { 
                case "btnCode39":
                    cbCodeType.SelectedIndex = Array.IndexOf(types, CodeType.Code39);
                    tbText.Text = "CODE39";
                    return;
                case "btnQRcode":
                    cbCodeType.SelectedIndex = Array.IndexOf(types, CodeType.QRCode);
                    tbText.Text = "QRCode";
                    return;
                case "btnPdf417":
                    cbCodeType.SelectedIndex = Array.IndexOf(types, CodeType.Pdf417);
                    tbText.Text = "Pdf417";
                    return;
                case "btnDataMatrix":
                    cbCodeType.SelectedIndex = Array.IndexOf(types, CodeType.DataMatrix);
                    tbText.Text = "DataMatrix";
                    return;
                case "btnComposite":
                    c1BarCode1.GS1CompositeOptions.Type = GS1CompositeType.CCA;
                    c1BarCode1.GS1CompositeOptions.Value = "777";
                    cbCodeType.SelectedIndex = Array.IndexOf(types, CodeType.RSSLimited);
                    tbText.Text = "1234567890";
                    return;
            }
            
        }

        private void cbCodeType_SelectedIndexChanged(object sender, EventArgs e) {
            c1BarCode1.CodeType = (CodeType)cbCodeType.SelectedValue;
        }

        private void btnRotateLeft_Click(object sender, EventArgs e) {
            var next = (int)c1BarCode1.BarDirection - 2;
            if (next == -1) next = 2;
            if (next == -2) next = 3;
            c1BarCode1.BarDirection = (BarCodeDirection)next;
        }

        private void btnRotateRight_Click(object sender, EventArgs e) {
            var next = (int)c1BarCode1.BarDirection + 2;
            if (next == 4) next = 1;
            if (next == 5) next = 0;
            c1BarCode1.BarDirection = (BarCodeDirection)next;
        }

    }
}
