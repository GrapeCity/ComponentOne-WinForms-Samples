using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockChart
{
    class ToggleButtonEx : System.Windows.Forms.Button
    {
        public EventHandler<BooleanEventArgs> OnCheckedChanged;
        public ToggleButtonEx()
        {
            this.MouseEnter += (o, e) =>
            {
                this.BackColor = this.ForeColor = Checked ? System.Drawing.Color.FromArgb(28, 28, 28) : System.Drawing.Color.FromArgb(230, 230, 230);
            };
            this.MouseLeave += (o, e) =>
            {
                this.BackColor = this.ForeColor = Checked ? System.Drawing.Color.FromArgb(28, 28, 28) : System.Drawing.Color.FromArgb(66, 66, 66);
            };
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            this.Checked = !this.Checked;
            if (this.OnCheckedChanged != null)
            {
                this.OnCheckedChanged(this, new BooleanEventArgs() { Value = this.Checked });
            }
        }

        private bool _checked = false;
        public bool Checked
        {
            get { return _checked; }
            set
            {
                _checked = value;
                Stylization();
            }
        }

        private void Stylization()
        {
            this.BackColor = this.ForeColor = Checked ? System.Drawing.Color.FromArgb(28, 28, 28) : System.Drawing.Color.FromArgb(66, 66, 66);
        }
    }
}
