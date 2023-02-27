using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TouchDemo.C1ZoomPages
{
    public partial class InputFormforControlBar : Form
    {
        public InputFormforControlBar()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.C1Zoom1.ControlBars[0].Position = new Point(this.Width ,0);
        }
    }
}
