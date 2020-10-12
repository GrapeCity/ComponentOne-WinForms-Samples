using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.Sizer
{
    public partial class SizerLight : C1DemoForm
    {
        public SizerLight()
        {
            InitializeComponent();
        }

        private void SizerLight_Load(object sender, EventArgs e)
        {
            SizerLightForm lightForm = new SizerLightForm();
            lightForm.TopLevel = false;
            lightForm.SizeGripStyle = SizeGripStyle.Show;
            panel1.Controls.Add(lightForm);
            Explorer.ApplyTheme(panel1);
            lightForm.Show();
        }

    }
}
