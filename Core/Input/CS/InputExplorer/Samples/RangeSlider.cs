using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using C1.Win.Input;

namespace InputExplorer.Samples
{
    public partial class RangeSlider : UserControl
    {
        public RangeSlider()
        {
            InitializeComponent();

            GraphicsPath lowerArrow = new GraphicsPath();
            lowerArrow.AddPolygon(new Point[] {
                               new Point(0, 0),
                               new Point(10, 0),
                               new Point(15, 15),
                               new Point(10, 30),
                               new Point(0, 30),
                               new Point(5, 15)
                           });

            GraphicsPath upperArrow = new GraphicsPath();
            upperArrow.AddPolygon(new Point[] {
                               new Point(15, 0),
                               new Point(5, 0),
                               new Point(0, 15),
                               new Point(5, 30),
                               new Point(15, 30),
                               new Point(10, 15)
                           });

            c1RangeSlider2.LowerThumbPath = lowerArrow;
            c1RangeSlider2.UpperThumbPath = upperArrow;

            foreach (Control control in Controls)
                if (control is C1RangeSlider)
                    control.GotFocus += Control_GotFocus;
        }

        private void Control_GotFocus(object sender, EventArgs e)
        {
            this.propertyGrid1.SelectedObject = sender;
        }
    }
}
