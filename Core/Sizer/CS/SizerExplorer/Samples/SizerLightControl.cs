using System;
using System.Windows.Forms;

namespace SizerExplorer.Samples
{
    public partial class SizerLightControl : UserControl
    {
        public SizerLightControl()
        {
            InitializeComponent();
        }

        private void SizerLight_Load(object sender, EventArgs e)
        {
            SizerLightForm lightForm = new SizerLightForm()
            {
                TopLevel = false,
                SizeGripStyle = SizeGripStyle.Show
            };
            panel1.Controls.Add(lightForm);
            lightForm.Show();
        }
    }
}
