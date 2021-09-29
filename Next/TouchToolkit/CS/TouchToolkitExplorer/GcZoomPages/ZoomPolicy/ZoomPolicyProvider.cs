using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TouchToolkitExplorer.C1ZoomPages
{
    public class ZoomPolicyProvider : ZoomPolicyProviderBase
    {
        public override string[] PolicyGroups
        {
            get { return new string[]{"Standard"}; }
        }

    }
}
