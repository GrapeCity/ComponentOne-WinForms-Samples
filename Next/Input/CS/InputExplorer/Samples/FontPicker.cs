using C1.Win.Input.Pickers;
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
    public partial class FontPicker : UserControl
    {
        public FontPicker()
        {
            InitializeComponent();

            foreach (Control control in Controls)
                if (control is C1FontPicker)
                    control.Enter += Control_GotFocus;

            richTextBox1.SelectAll();

        }

        private void Control_GotFocus(object sender, EventArgs e)
        {
            this.propertyGrid1.SelectedObject = sender;
        }

        private void c1FontPicker1_SelectedFontFamilyChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
                richTextBox1.SelectionFont = new Font(((C1.Win.Input.Pickers.C1FontPicker)sender).SelectedFontFamily, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
        }
    }
}
