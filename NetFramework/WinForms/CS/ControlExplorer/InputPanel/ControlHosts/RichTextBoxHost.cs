using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlExplorer.InputPanel.ControlHosts
{
    public class RichTextBoxHost : C1.Win.C1InputPanel.InputControlHost
    {
        public RichTextBoxHost() : base(new System.Windows.Forms.RichTextBox())
        {
        }
    }
}
