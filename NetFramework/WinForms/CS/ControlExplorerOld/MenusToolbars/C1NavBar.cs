using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1Command;

namespace ControlExplorer.MenusToolbars
{
    public partial class C1NavBar : C1DemoForm
    {  
        public C1NavBar()
        {
            InitializeComponent();
        }

        private void c1NavBar1_DockChanged(object sender, EventArgs e)
        {
            //move splitter if C1NavBar moves
            splitter1.Dock = c1NavBar1.Dock;
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

        private void C1NavBar_Load(object sender, EventArgs e)
        {
            //add demo properties
            AddProperty("AllowCollapse", c1NavBar1);
            AddProperty("ButtonHeight", c1NavBar1);
            AddProperty("CloseButton", c1NavBar1);
            AddProperty("Docking", this);
            AddProperty("PanelHeaderHeight", c1NavBar1);
            AddProperty("ShowOptionsMenu", c1NavBar1);
            AddProperty("StackButtonCount", c1NavBar1);
            AddProperty("StripHeight", c1NavBar1);
        }
    }
}
