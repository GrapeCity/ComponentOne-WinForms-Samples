using System;
using System.Windows.Forms;

namespace TouchToolkitDemo
{
    public partial class DemoBase_settings : UserControl
    {
        public DemoBase_settings()
        {
            InitializeComponent();
        }

        public string Title
        {
            get
            {
                return this.lblTitle.Text;
            }
            set
            {
                this.lblTitle.Text = value;
            }
        }

        public string Description
        {
            get
            {
                return this.lblDescription.Text;
            }
            set
            {
                this.lblDescription.Text = value;
            }
        }
    }
}
