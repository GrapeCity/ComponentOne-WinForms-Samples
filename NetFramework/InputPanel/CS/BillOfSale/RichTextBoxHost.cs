using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillOfSale
{
    public class RichTextBoxHost : C1.Win.InputPanel.InputControlHost
    {
        public RichTextBoxHost()
            : base(new System.Windows.Forms.RichTextBox())
        {
        }
    }
}
