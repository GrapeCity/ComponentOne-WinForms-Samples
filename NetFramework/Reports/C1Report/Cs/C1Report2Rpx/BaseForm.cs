using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace C1Report2Rpx
{
    public partial class BaseForm : C1.AppUtils.BaseForm
    {
        private int _updateCounter;

        public BaseForm()
        {
            InitializeComponent();
        }

        #region Protected
        protected void BeginUpdate()
        {
            _updateCounter++;
        }

        protected void EndUpdate()
        {
            _updateCounter--;
        }
        #endregion

        #region Protected properties
        protected bool Updating
        {
            get { return _updateCounter != 0; }
        }

        protected override C1.AppUtils.Options.WindowsApplicationOptions Options
        {
            get { return ProgramOptions.Instance; }
        }
        #endregion
    }
}
