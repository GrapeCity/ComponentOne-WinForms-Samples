using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.TouchToolKit;

namespace TouchToolkitExplorer.C1ZoomPages
{
    public partial class BoundaryFeedbackUI : UserControl
    {
        public BoundaryFeedbackUI()
        {
            InitializeComponent();
        }

        public BoundaryFeedbackMode BoundaryFeedbackMode
        {
            get
            {
                return radioButton1.Checked ? BoundaryFeedbackMode.Split : BoundaryFeedbackMode.Standard;
            }
            set
            {
                radioButton1.Checked = (value == BoundaryFeedbackMode.Split);
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            this.OnBoundaryFeedbackModeChanged(e);
        }

        public event EventHandler<EventArgs> BoundaryFeedbackModeChanged;

        protected virtual void OnBoundaryFeedbackModeChanged(EventArgs e)
        {
            if (this.BoundaryFeedbackModeChanged != null)
            {
                this.BoundaryFeedbackModeChanged(this, e);
            }
        }   
    }
}
