using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Font = SystemInformation.MenuFont;
        }
        private void inputTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (inputTextBox1.Text.Length > 0 && !inputTextBox1.Text.StartsWith("a"))
            {
                inputTextBox1.ErrorText = BuildErrorTip(inputTextBox1, Properties.Resources.ErrStartWithA);
                e.Cancel = true;
            }
            else
            {
                inputTextBox1.ErrorText = string.Empty;
            }
        }
        private void inputNumericBox1_Validating(object sender, CancelEventArgs e)
        {
            if (!inputNumericBox1.ValueIsNull && inputNumericBox1.Value % 2 != 0)
            {
                inputNumericBox1.ErrorText = BuildErrorTip(inputNumericBox1, Properties.Resources.ErrEven);
                e.Cancel = true;
            }
            else
            {
                inputNumericBox1.ErrorText = string.Empty;
            }
        }
        private void inputNumericBox1_ValueChanged(object sender, EventArgs e)
        {
            inputNumericBox2.ErrorText = inputNumericBox1.Value + inputNumericBox2.Value < 100
                ? BuildErrorTip(inputNumericBox2, Properties.Resources.Err100)
                : string.Empty;
        }
        private void inputTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if (!inputTimePicker1.ValueIsNull && inputTimePicker1.Value < new TimeSpan(12, 0, 0))
            {
                inputTimePicker1.ErrorText = BuildErrorTip(inputTimePicker1, Properties.Resources.ErrAfter12);
                e.Cancel = true;
            }
            else
            {
                inputTimePicker1.ErrorText = string.Empty;
            }
        }
        private void inputCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            inputCheckBox1.ErrorText = !inputCheckBox1.Checked && !inputCheckBox2.Checked
                ? BuildErrorTip(inputCheckBox1, Properties.Resources.ErrOneBox)
                : string.Empty;
            inputCheckBox2.ErrorText = inputCheckBox1.ErrorText;
        }
        private string BuildErrorTip(C1.Win.C1InputPanel.InputComponent c, string error)
        {
            return string.Format(
                "{0}<table style='background-color:#FFDDDD'>" +
                "<tr style='vertical-align:top;'>" +
                "<td><img src='res://errorinfo'/>" +
                "<td>{1}</table>",
                c.ToolTipText,
                error);
        }
    }
}