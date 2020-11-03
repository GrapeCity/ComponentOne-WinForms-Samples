using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaseExplorer.Core;

namespace BaseExplorer.Components
{
    public partial class DescriptionPanel : UserControl
    {
        public string Content
        {
            get { return rtbContents.Rtf; }
            set
            {
                rtbContents.Clear();
                rtbContents.Rtf = value;
            }
        }

        public DescriptionPanel()
        {
            InitializeComponent();
            rtbContents.ContentsResized += OnContentsResized;
            foreach (Control control in Controls)
                SubscribeMouseEvents(control);
        }

        private void OnContentsResized(object sender, ContentsResizedEventArgs e)
        {
            this.Height = Math.Min(rtbHeader.Height + e.NewRectangle.Height + 20,280);
        }

        public void SubscribeMouseEvents(Control c)
        {
            c.MouseLeave += (s, e) =>
            {
                if (!this.ClientRectangle.Contains(this.PointToClient(MousePosition)))
                    this.OnMouseLeave(e);
            };
            foreach (Control child in c.Controls)
                SubscribeMouseEvents(child);
        }
    }
}
