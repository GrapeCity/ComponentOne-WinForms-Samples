using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.MenusToolbars
{
    public partial class C1TopicBar : C1DemoForm
    {
        public C1TopicBar()
        {
            InitializeComponent();
        }

        private void C1TopicBar_Load(object sender, EventArgs e)
        {
            //add demo properties
            AddProperty("Animation", c1TopicBar1);
        }
    }
}
