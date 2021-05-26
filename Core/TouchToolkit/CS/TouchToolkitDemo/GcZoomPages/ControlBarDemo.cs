using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TouchToolkitDemo.C1ZoomPages.Help_Forms;
using C1.Win.TouchToolKit;

namespace TouchToolkitDemo.C1ZoomPages
{
    public partial class ControlBarDemo : DemoBase
    {
        public ControlBarDemo()
        {
            InitializeComponent();

            this.Title = "ControlBar";
            this.Description = @"ControlBar can provide a floating, translucent window for form.
- ControlBar provides built-in actions, the map demo shows how to use the built-in actions.
- Of course, customize the action is simple, keyboard demo shows how to costomize the actions.";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new MapViewFormForControlBar();
            form.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new InputFormforControlBar();
            form.Show();
        }
    }
}
