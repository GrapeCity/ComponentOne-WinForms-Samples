using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.Sizer
{
    public partial class SizerLightForm : Form
    {
        public SizerLightForm()
        {
            InitializeComponent();
        }

        private void SizerLightForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
        }
    }
}
