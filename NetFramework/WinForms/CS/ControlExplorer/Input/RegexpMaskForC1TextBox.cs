using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlExplorer.Input
{
    public partial class RegexpMaskForC1TextBox : C1DemoForm
    {
        public RegexpMaskForC1TextBox()
        {
            InitializeComponent();
        }

        private void RegexpMaskForC1TextBox_Load(object sender, EventArgs e)
        {
            c1TextBox1.MaskInfo.RegexpEditMask = "[0-9]{3}-[0-9]{3}";
            c1TextBox2.MaskInfo.RegexpMaskType = C1.Win.C1Input.RegexpMaskType.C1RegexpEditMask;
            c1TextBox2.MaskInfo.RegexpEditMask = "[0-9]{3}-[0-9]{3}";
            c1TextBox2.MaskInfo.ShowLiterals = C1.Win.C1Input.ShowLiteralsEnum.ShowAlways;

            c1TextBox1.CausesValidation = true;
            c1TextBox2.CausesValidation = true;
        }

        private void c1Button1_Click(object sender, EventArgs e)
        {
            c1TextBox1.MaskInfo.RegexpEditMask = c1TextBox3.Text;
            if (c1TextBox1.MaskInfo.IsRegexpPatternRecognized)
            {
                c1Label2.Value = c1TextBox1.MaskInfo.RegexpEditMask;
                c1Label2.ForeColor = Color.Black;
            }
            else
            {
                c1Label2.Value = "Pattern was not recognized.";
                c1Label2.ForeColor = Color.Red;
            }
        }

        private void c1Button2_Click(object sender, EventArgs e)
        {
            c1TextBox2.MaskInfo.RegexpEditMask = c1TextBox4.Text;
            if (c1TextBox2.MaskInfo.IsRegexpPatternRecognized)
            {
                c1Label7.Value = c1TextBox2.MaskInfo.RegexpEditMask;
                c1Label7.ForeColor = Color.Black;
            }
            else
            {
                c1Label7.Value = "Pattern was not recognized.";
                c1Label7.ForeColor = Color.Red;
            }
        }

    }
}
