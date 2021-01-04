using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarCodeExplorer.Samples
{
    using C1.BarCode;
    using C1.Win.BarCode;
    public partial class DividingQrCode : UserControl
    {
        public DividingQrCode()
        {
            InitializeComponent();
            _symbols.Text = _sourceText.Text.Length.ToString();
        }

        private void lbGenerate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GenerateQrCodes();
        }

        private void GenerateQrCodes()
        {
            _panel.Controls.Clear();

            if (string.IsNullOrEmpty(_sourceText.Text)) return;

            var Code = new C1BarCode();
            Code.CodeType = CodeType.QRCode;
            Code.Text = _sourceText.Text;
            Code.QRCodeOptions.Connection = true;

            var range = Convert.ToInt32(_range.SelectedItem);
            Code.QRCodeOptions.Version = range;
            Code.QRCodeOptions.ErrorLevel = QRCodeErrorLevel.Medium;

            Enumerable.Range(0, range)
                .ToList()
                .ForEach(x =>
                {
                    Code.QRCodeOptions.ConnectionNumber = x;
                    var imageCode = Code.Image;
                    var pictureBox = new PictureBox() { Image = imageCode, Size = new Size(200, 200) };

                    _panel.Controls.Add(pictureBox);
                });

            // For preview properties
            var selectedObjects = new List<C1BarCode>() { Code }.ToArray();
            _settings.SelectedObjects = (object[])selectedObjects;

            // Capacity of text 
            _symbols.Text = _sourceText.Text.Length.ToString();
        }

        private void _sourceText_TextChanged(object sender, EventArgs e)
        {
            _symbols.Text = _sourceText.Text.Length.ToString();
        }

        private void _range_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateQrCodes();
        }
    }
}
