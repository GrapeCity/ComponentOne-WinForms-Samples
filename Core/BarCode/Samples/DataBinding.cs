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
    using BarCodeExplorer.Data;
    public partial class DataBinding : UserControl
    {
        private BindingSource _data;

        public DataBinding()
        {
            InitializeComponent();
        }

        private void DataBound_Load(object sender, EventArgs e)
        {
            _data = new BindingSource();
            _data.DataSource = DataSources.GetProducts();

            c1Label1.DataBindings.Add("Text", _data, "ProductName");
            c1Label2.DataBindings.Add("Text", _data, "QuantityPerUnit");
            c1BarCode1.DataBindings.Add("Text", _data, "ProductID");
            
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            button1.Enabled = _data.Position != 0;
            button2.Enabled = _data.Position < _data.Count - 1;

            label3.Text = $"{_data.Position + 1} of {_data.Count}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_data.Position > 0)
                _data.Position--;
            UpdateButtons();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_data.Position < _data.Count - 1)
                _data.Position++;
            UpdateButtons();
        }

    }
}
