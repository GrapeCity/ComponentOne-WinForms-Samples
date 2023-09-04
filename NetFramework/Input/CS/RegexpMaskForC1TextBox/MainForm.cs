using C1.Win.C1Themes;
using C1.Win.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegexpMaskForC1TextBox
{
    public partial class MainForm : C1RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitThemes();

            c1TextBox2.MaskInfo.RegexpMaskType = C1.Win.C1Input.RegexpMaskType.C1RegexpEditMask;
            c1TextBox2.MaskInfo.ShowLiterals = C1.Win.C1Input.ShowLiteralsEnum.ShowAlways;
            c1TextBox2.MaskInfo.RegexpEditMask = "[0-9]{3}-[0-9]{3}";
            c1TextBox2.MaskInfo.RegexpEditMask = "[0-9]{3}-[0-9]{3}";

            c1TextBox1.CausesValidation = true;
            c1TextBox2.CausesValidation = true;
        }

        #region Themes

        private void InitThemes()
        {
            var themes = C1ThemeController.GetThemes().Where(x => x.Contains("Office2016"));
            foreach (var theme in themes)
                cmbTheme.Items.Add(theme);
        }

        private void cmbTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            c1ThemeController1.Theme = cmbTheme.SelectedItem.Text;
        }

        #endregion


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

        private void c1Button3_Click(object sender, EventArgs e)
        {
            c1TextBox1.MaskInfo.RegexpEditMask = c1TextBox2.MaskInfo.RegexpEditMask;
            c1Label2.Value = c1TextBox1.MaskInfo.RegexpEditMask;
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

        private void c1Button4_Click(object sender, EventArgs e)
        {
            c1TextBox2.MaskInfo.RegexpEditMask = c1TextBox1.MaskInfo.RegexpEditMask;
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

        private void c1ComboBox1_SelectedItemChanged(object sender, EventArgs e)
        {
            c1TextBox1.MaskInfo.RegexpEditMask = c1ComboBox1.SelectedItem.ToString();
            c1Label2.Value = c1TextBox1.MaskInfo.RegexpEditMask;
        }

        private void c1ComboBox2_SelectedItemChanged(object sender, EventArgs e)
        {
            c1TextBox2.MaskInfo.RegexpEditMask = c1ComboBox2.SelectedItem.ToString();
            c1Label7.Value = c1TextBox2.MaskInfo.RegexpEditMask;
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://developer.mescius.com/componentone/docs/win/online-input/MaskedInputUsingRegularExpressions.html");
            }
            catch
            {
                MessageBox.Show("Unable to open link https://developer.mescius.com/componentone/docs/win/online-input/MaskedInputUsingRegularExpressions.html.");
            }
        }
    }
}
