using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TouchDemo.C1ApplicationZoomPages
{
    public partial class AppZoom_Child2 : Form
    {
        public AppZoom_Child2()
        {
            InitializeComponent();
        }
        private int _selectIndex;

        public int _checkParam
        {
            get
            {
                return _selectIndex;
            }
            set
            {
                _selectIndex = value;
            }
        }

     



     
    }
}
