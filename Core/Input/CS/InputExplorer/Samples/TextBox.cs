using C1.Win.Input;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace InputExplorer.Samples
{
    public partial class TextBox : UserControl
    {
        private List<string> _fruits = new List<string>()
        {
            "orange",
            "apple",
            "pear",
            "pineapple",
            "coconut",
            "banana",
            "plum"
        };

        public TextBox()
        {
            InitializeComponent();

            c1TextBox4.AutoCompleteCustomSource.AddRange(_fruits.ToArray());

            foreach (Control control in Controls)
                if (control is C1TextBox)
                    control.Enter += Control_GotFocus;
        }

        private void Control_GotFocus(object sender, EventArgs e)
        {
            this.propertyGrid1.SelectedObject = sender;
        }
    }
}
