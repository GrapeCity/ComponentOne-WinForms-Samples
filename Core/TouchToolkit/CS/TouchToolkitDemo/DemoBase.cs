using System;
using System.Windows.Forms;

namespace TouchToolkitDemo
{
    public partial class DemoBase : UserControl
    {
        public DemoBase()
        {
            InitializeComponent();

            this.Title = this.GetType().Name;
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
