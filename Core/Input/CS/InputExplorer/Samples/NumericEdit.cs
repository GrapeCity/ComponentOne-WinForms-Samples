using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C1.Win.Input;

namespace InputExplorer.Samples
{
    public partial class NumericEdit : UserControl
    {
        public NumericEdit()
        {
            InitializeComponent();

            foreach (Control control in Controls)
                if (control is C1NumericEdit)
                    control.Enter += Control_GotFocus;
        }

        private void Control_GotFocus(object sender, EventArgs e)
        {
            this.propertyGrid1.SelectedObject = sender;
        }
    }
}
