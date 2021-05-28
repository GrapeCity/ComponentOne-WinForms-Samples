using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Command;

namespace ClickOnceDemo.GcZoomPages
{
    public partial class C1NavBarSample : UserControl
    {

        public C1NavBarSample()
        {
            InitializeComponent();
        }

        //BinaryDockStyle limits users to only left and right docking
        public enum BinaryDockStyle
        {
            Left,
            Right
        }
        private BinaryDockStyle _dock;
        public BinaryDockStyle Docking
        {
            get { return _dock; }
            set 
            { 
                _dock = value;
                if (_dock == BinaryDockStyle.Left)
                {
                    c1NavBar1.Dock = DockStyle.Left;
                    c1NavBar1.CollapseDirection = CollapseDirectionEnum.ToLeft;
                }
                else
                {
                    c1NavBar1.Dock = DockStyle.Right;
                    c1NavBar1.CollapseDirection = CollapseDirectionEnum.ToRight;
                }
            }
        }

        private void c1NavBar1_DockChanged(object sender, EventArgs e)
        {
            splitter1.Dock = c1NavBar1.Dock;
        }
    }
}
