using C1.Win.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputExplorer.Samples
{
    public partial class MaskedTextBox : UserControl
    {
        public MaskedTextBox()
        {
            InitializeComponent();

            foreach (Control control in Controls)
                if (control is C1MaskedTextBox)
                    control.Enter += Control_GotFocus;
            
        }

        private void Control_GotFocus(object sender, EventArgs e)
        {
            this.propertyGrid1.SelectedObject = sender;
        }
    }
}
