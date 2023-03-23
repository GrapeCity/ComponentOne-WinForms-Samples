using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TouchDemo.C1ZoomPages.Help_Forms;
using C1.Win.TouchToolKit;

namespace TouchDemo.C1ZoomPages
{
    public partial class ControlBarDemo : DemoBase
    {
        public ControlBarDemo()
        {
            InitializeComponent();

            this.Title = "ControlBar";
            this.Description = @"ControlBar is a customizable floating transparent window used simplify touch actions when scrolling large areas such as the map shown in the demo and for touch input such as the keyboard controlbar shown in the demo.
Use the ControlBar MapView demo to see the various built-in actions associated with each button.
Use the ControlBar Keyboard demo to see how to customize the built-in actions associated with each button on the ControlBar.";
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
