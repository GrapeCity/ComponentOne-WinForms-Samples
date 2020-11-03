using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StockChart
{
    public partial class ucSymbolSearchBox : UserControl
    {
        public EventHandler<StringEventArgs> OnSymbolChanged;

        public ucSymbolSearchBox()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                InitializeControls();
            }

            this.pnlText.Click += (o, e) =>
            {
                this.txtSymbol.Focus();
            };
        }
        void InitializeControls()
        {
            this.Load += (o, e) =>
            {
                RefrushPlaceholder();
            };
            

            this.txtSymbol.TextChanged += (o, e) =>
            {
                var text = this.txtSymbol.Text;
                if (!string.IsNullOrEmpty(text))
                {
                    var symbol = (text.Split(new char[] { ' ' })).FirstOrDefault();

                    if (this.DataSource != null && this.DataSource.Keys.Contains(symbol))
                    {
                        this.btnAdd.Enabled = true;
                    }
                    else
                    {
                        this.btnAdd.Enabled = false;
                    }
                }
                else
                {
                    this.btnAdd.Enabled = false;
                }
            };

            this.btnAdd.Click += (o, e) =>
            {
                var symbol = (this.txtSymbol.Text.Split(new char[] { ' ' })).FirstOrDefault();
                if (this.DataSource != null && this.DataSource.Keys.Contains(symbol))
                {
                    if (this.OnSymbolChanged != null)
                        this.OnSymbolChanged(this, new StringEventArgs() { Value = symbol });
                    this.txtSymbol.Text = string.Empty;
                    this.btnAdd.Enabled = false;
                    RefrushPlaceholder();
                }
            };

        }

        private string _placeholder;
        public string Placeholder
        {
            get
            {
                return _placeholder;
            }
            set
            {
                _placeholder = value;
                if (this.IsHandleCreated)
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        TextBoxUtility.SetCueText(this.txtSymbol, _placeholder);
                    }));
                }
            }
        }

        public Image ButtonImage
        {
            get
            {
                return this.btnAdd.Image;
            }
            set
            {
                this.btnAdd.Image = value;
            }
        }


        public void RefrushPlaceholder()
        {
            if (this.IsHandleCreated)
            {
                this.BeginInvoke(new Action(() =>
                {
                    TextBoxUtility.SetCueText(this.txtSymbol, _placeholder);
                }));
            }
        }


        private Dictionary<string, string> _dataSource;
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Dictionary<string, string> DataSource
        {
            get
            {
                return _dataSource;
            }
            set
            {
                _dataSource = value;

                if (_dataSource != null && _dataSource.Any())
                {
                    List<string> src = new List<string>();
                    if (!(this.GetService(typeof(System.ComponentModel.Design.IDesignerHost)) != null || System.ComponentModel.LicenseManager.UsageMode == System.ComponentModel.LicenseUsageMode.Designtime))
                        src.AddRange((from p in _dataSource select p.Key + " " + p.Value).ToArray());

                    this.txtSymbol.AutoCompleteList = src;
                }
            }
        }
    }

}
