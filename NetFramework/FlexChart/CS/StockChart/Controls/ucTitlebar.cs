using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockChart.Controls
{
    public partial class ucTitlebar : UserControl
    {
        public EventHandler<StringEventArgs> OnSymbolChanged;
        public ucTitlebar()
        {
            InitializeComponent();
            InitializeControls();
        }



        public string StockName
        {
            get
            {
                return this.stockLabel.StockName;
            }
            set
            {
                this.stockLabel.StockName = value;
            }
        }

        public double Price
        {
            get
            {
                return this.stockLabel.Price;
            }
            set
            {
                this.stockLabel.Price = value;
            }
        }

        public double Difference
        {
            get
            {
                return this.stockLabel.Difference;
            }
            set
            {
                this.stockLabel.Difference = value;
            }
        }


        private void InitializeControls()
        {
            if (!DesignMode)
            {
                txtSearchBox.DataSource = Data.DataService.Instance.SymbolNames;
                Data.DataService.Instance.SymbolsLoaded += (s, e) => txtSearchBox.DataSource = Data.DataService.Instance.SymbolNames;
            }

            txtSearchBox.OnSymbolChanged += (o, e) =>
            {
                if(OnSymbolChanged != null)
                    OnSymbolChanged(this, new StringEventArgs() { Value = e.Value });
            };
        }
    }
}
