using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClickOnceDemo.C1ZoomPages.Help_Forms;

namespace ClickOnceDemo.C1ZoomPages
{
    public partial class ShowControlDemo : DemoBase
    {
        public ShowControlDemo()
        {
            InitializeComponent();
            InitializeDemo();
        }

        private void InitializeDemo()
        {
            this.Title = "Show Control";
            this.Description = "When AutoShowControl property is true, C1Zoom will try to scroll the from to show the focused control.";
        }

        private void formButton_Click(object sender, EventArgs e)
        {
            using (Form form = new ShowControlForm())
            {
                form.ShowDialog(this);
                // The _C1Zoom will auto detach when the Form dispose.
                //_C1Zoom.SetEnabled(form, false);
            }
        }
    }
}
