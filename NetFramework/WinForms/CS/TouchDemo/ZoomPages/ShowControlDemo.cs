using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TouchDemo.C1ZoomPages.Help_Forms;

namespace TouchDemo.C1ZoomPages
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
            this.Description = "When the AutoShowControl property is True,  C1Zoom scrolls up to the focused control in the form. The TextBox control may be hidden by the on-screen keyboard. If AutoShowControl is True, C1Zoom brings focus to the TextBox control and scrolls up to it when the on-screen keyboard is open.";
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
