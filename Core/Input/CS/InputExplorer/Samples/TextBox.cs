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

            c1TextBox1.PreValidation.ErrorMessage = "String rejected by validation before parsing.\nUse uppercase and lowercase latin letters.";
            c1TextBox1.PostValidation.ErrorMessage = "The value is out of range or does not belong to the list of possible values. Valid values are \"circle\", \"square\" and \"triangle\".";
        }

        private void Control_GotFocus(object sender, EventArgs e)
        {
            this.propertyGrid1.SelectedObject = sender;
        }
    }
}
