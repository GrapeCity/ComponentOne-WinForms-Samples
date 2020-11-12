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

    public partial class Overview : UserControl
    {
        private List<CodeType> _barCodes;
        private PanelBarCode _selectPanel;

        private List<CodeType> _popularCodes = new List<CodeType>()
        { CodeType.Code_128auto, CodeType.Code_128_A, CodeType.Code_128_B, CodeType.Code_128_C, CodeType.Ansi39, CodeType.Codabar};

        private List<CodeType> _qrCodes = new List<CodeType>()
        { CodeType.QRCode, CodeType.MicroQRCode, CodeType.JapanesePostal, CodeType.Pdf417, CodeType.MicroPDF417, CodeType.DataMatrix };

        private List<CodeType> _exludedCodes = new List<CodeType>()
        { CodeType.HIBCCode128, CodeType.HIBCCode39, CodeType.IntelligentMailPackage, CodeType.SSCC18 };

        public Overview()
        {
            InitializeComponent();
        }

        public void InitializeBarCodes()
        {
            // Get all type bar codes
            _barCodes = Enum.GetValues(typeof(CodeType))
                .Cast<CodeType>()
                .Where(x => x != CodeType.None)
                .Where(x => !_exludedCodes.Contains(x))
                .ToList();

            List<CodeType> result = new List<CodeType>();
            switch (_mode.SelectedIndex)
            {
                case 0:
                    {
                        // Populare
                        result = _barCodes.Where(x => _popularCodes.Any(y => x == y)).ToList();
                        break;
                    }
                case 1:
                    {
                        // Qr
                        result = _barCodes.Where(x => _qrCodes.Any(y => x == y)).ToList();
                        break;
                    }
                default:
                    {
                        // All
                        result = _barCodes;
                        break;
                    }
            }

            var list = result
                .OrderBy(x => x)
                .Select(x => new PanelBarCode(x, _mode.SelectedIndex != 1,
                     _mode.SelectedIndex == 1 ? new Size(200, 200) :// QR                                                                   
                     _mode.SelectedIndex == 0 ? new Size(200, 80) :// Popular
                     new Size(200, 70)                     
                ))
               .ToList();

            _quantity.Text = list.Count().ToString();
            list.ForEach(x => { x.SelectBarCode += BarCode_Click; });

            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(list.ToArray());
        }

        private void BarCode_Click(object sender, EventArgs e)
        {
            var selectPanel = sender as PanelBarCode;
            if (selectPanel == null) return;
            if (_selectPanel != null)
                _selectPanel.IsSelect = false;

            _selectPanel = selectPanel;

            if (selectPanel.BarCode == null) return;

            var selectedObjects = new List<C1BarCode>() { selectPanel.BarCode }.ToArray();
            _settings.SelectedObjects = (object[])selectedObjects;
        }

        private void Overview_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
                _mode.SelectedIndex = 0;
        }

        private void _mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitializeBarCodes();
        }
    }
}
