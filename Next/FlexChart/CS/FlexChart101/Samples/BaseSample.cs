using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.Chart;
using System.Drawing.Drawing2D;

namespace FlexChart101.Samples
{
    public partial class BaseSample : UserControl
    {
        public BaseSample()
        {
            InitializeComponent();
        }

        private void pControls_Paint(object sender, PaintEventArgs e)
        {
            pControls.CreateGraphics().DrawLine(new Pen(Color.LightGray), 0, pControls.Height - 1, pControls.Width, pControls.Height - 1);
        }

        private void pCollapse_Paint(object sender, PaintEventArgs e)
        {
            using (var gr = pCollapse.CreateGraphics())
            {
                gr.FillRectangle(new SolidBrush(Color.White), 0, 0, pCollapse.Width, pCollapse.Height / 2);
                gr.DrawLine(new Pen(Color.LightGray), 0, pCollapse.Height / 2, pCollapse.Width, pCollapse.Height / 2);
            }
        }

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            pDescription.Visible = pCode.Visible = !pDescription.Visible;
            btnCollapse.BackgroundImage = pDescription.Visible ? 
                FlexChart101.Properties.Resources.cb_up26 : 
                FlexChart101.Properties.Resources.cb_down26;
        }

        private void pDescription_Paint(object sender, PaintEventArgs e)
        {
            pDescription.CreateGraphics().DrawLine(new Pen(Color.LightGray), 20, 13, pDescription.Width - 20, 13);
        }

        private void tbCode_SizeChanged(object sender, EventArgs e)
        {
            btnCopy.Left = tbCode.Right - btnCopy.Width - 25;
            btnCopy.Top = tbCode.Top + 5;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();       
            Clipboard.SetText(tbCode.Text);
        }

        private void btnCopy_MouseEnter(object sender, EventArgs e)
        {
            btnCopy.BackgroundImage = FlexChart101.Properties.Resources.btnCopyMouseOn;
            ttCopy.Show("Copy to clipboard", btnCopy, -33, -35);
        }

        private void btnCopy_MouseLeave(object sender, EventArgs e)
        {
            btnCopy.BackgroundImage = FlexChart101.Properties.Resources.btnCopy;
            ttCopy.RemoveAll();
        }

        private void ttCopy_Draw(object sender, DrawToolTipEventArgs e)
        {
            // Draw the custom background.
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), e.Bounds);

            // Draw the custom text.
            // The using block will dispose the StringFormat automatically.
            using (StringFormat sf = new StringFormat())
            {
                sf.FormatFlags = StringFormatFlags.NoClip | StringFormatFlags.NoFontFallback;
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;
                sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.None;
                sf.FormatFlags = StringFormatFlags.NoWrap;
                using (Font f = new Font("Tahoma", 9, FontStyle.Bold))
                {
                    e.Graphics.DrawString(e.ToolTipText, f,
                        new SolidBrush(Color.White), e.Bounds, sf);
                }
            }
        }

        private void ttCopy_Popup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = new Size(130, 30);
        }
    }
}
