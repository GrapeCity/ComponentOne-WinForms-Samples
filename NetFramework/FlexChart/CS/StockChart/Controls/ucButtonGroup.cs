using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockChart
{
    public partial class ucButtonGroup : UserControl
    {
        public EventHandler<IntgerEventArgs> OnSelectedIndexChanged;

        public ucButtonGroup()
        {
            InitializeComponent();

            foreach (var item in this.Controls)
            {
                if (item is CheckButtonEx)
                {
                    CheckButtonEx cbtn = item as CheckButtonEx;
                    cbtn.OnCheckedChanged += (o, e) =>
                    {
                        foreach (var control in this.Controls)
                        {
                            if (control != o)
                            {
                                (control as CheckButtonEx).Checked = false;
                            }
                        }

                        if (this.OnSelectedIndexChanged != null)
                        {
                            this.OnSelectedIndexChanged(this, new IntgerEventArgs() { Value = this.Controls.Count - 1 - this.Controls.IndexOf(o as Control) });
                        }

                    };
                }
            }
        }
        
        private int _selectedIndex = 0;
        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set { _selectedIndex = value; UpdateItems(); }
        }

        private void UpdateItems()
        {
            for (int i = this.Controls.Count - 1; i >= 0; i--)
            {
                var item = this.Controls[i]; if (item is CheckButtonEx)
                {
                    CheckButtonEx cbtn = item as CheckButtonEx;
                    if ((this.Controls.Count - 1) - i == this.SelectedIndex)
                    {
                        cbtn.Checked = true;
                    }
                    else
                    {
                        cbtn.Checked = false;
                    }
                }
            }
        }


    }
}
