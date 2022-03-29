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
            
            c1MaskedTextBox9.CausesValidation = true;
            c1MaskedTextBox10.CausesValidation = true;
        }

        private void Control_GotFocus(object sender, EventArgs e)
        {
            this.propertyGrid1.SelectedObject = sender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1MaskedTextBox9.MaskInfo.RegexpEditMask = textBox1.Text;
            if (c1MaskedTextBox9.MaskInfo.IsRegexpPatternRecognized)
            {
                label7.Text = textBox1.Text;
                label7.ForeColor = SystemColors.ControlText;
            }
            else
            {
                label7.Text = "Pattern is not recognized.";
                label7.ForeColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c1MaskedTextBox10.MaskInfo.RegexpEditMask = textBox2.Text;
            if (c1MaskedTextBox10.MaskInfo.IsRegexpPatternRecognized)
            {
                label10.Text = textBox2.Text;
                label10.ForeColor = SystemColors.ControlText;
            }
            else
            {
                label10.Text = "Pattern is not recognized.";
                label10.ForeColor = Color.Red;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1MaskedTextBox9.MaskInfo.RegexpEditMask = comboBox1.SelectedItem.ToString();
            label7.Text = c1MaskedTextBox9.MaskInfo.RegexpEditMask;
            label7.ForeColor = SystemColors.ControlText;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1MaskedTextBox10.MaskInfo.RegexpEditMask = comboBox2.SelectedItem.ToString();
            label10.Text = c1MaskedTextBox10.MaskInfo.RegexpEditMask;
            label10.ForeColor = SystemColors.ControlText;
        }
    }
}
