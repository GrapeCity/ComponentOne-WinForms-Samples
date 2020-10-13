using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.InputPanel
{
    public partial class Validation : C1DemoForm
    {
        public Validation()
        {
            InitializeComponent();
        }

        private void inputTextBox1_Validating(object sender, CancelEventArgs e)
        {
            if (inputTextBox1.Text.Length > 0 && !inputTextBox1.Text.StartsWith("a"))
            {
                inputTextBox1.ErrorText = BuildErrorTip(inputTextBox1, "Please enter a value that starts with <b>'a'</b> (lowercase).<br><i>Other values are not accepted because they will compromise our sorting algorithm.<br>We will get this fixed eventually, but for now please oblige... <b>Thank you!</b></i>.");
                e.Cancel = true;
            }
            else
            {
                inputTextBox1.ErrorText = string.Empty;
            }
        }

        private void inputNumericBox1_Validating(object sender, EventArgs e)
        {
            if (!inputNumericBox1.ValueIsNull && inputNumericBox1.Value % 2 != 0)
            {
                inputNumericBox1.ErrorText = BuildErrorTip(inputNumericBox1, "Please enter an <b>even</b> number.<br><i>In case you have forgotten (nothing to be ashamed of ;-), even numbers are<br><b>integers</b> divisible by 2 with no remainder (e.g. 0, 2, 4, 6, etc.)</i>");

            }
            else
            {
                inputNumericBox1.ErrorText = string.Empty;
            }

            inputNumericBox2.ErrorText = inputNumericBox1.Value + inputNumericBox2.Value < 100
                ? BuildErrorTip(inputNumericBox2, "Please enter values that add up to at least <b>100</b>.")
                : string.Empty;
        }

        private void inputNumericBox1_ValueChanged(object sender, EventArgs e)
        {
            inputNumericBox2.ErrorText = inputNumericBox1.Value + inputNumericBox2.Value < 100
                ? BuildErrorTip(inputNumericBox2, "Please enter values that add up to at least <b>100</b>.")
                : string.Empty;
        }

        private void inputTimePicker1_TextChanged(object sender, EventArgs e)
        {
            inputTimePicker1.ErrorText = (inputTimePicker1.Value < new TimeSpan(13, 0, 0) || inputTimePicker1.Value > new TimeSpan(14, 0, 0))
                ? BuildErrorTip(inputTimePicker1, "Please enter a time <b>between</b> 1 PM and 2 PM. <br>Otherwise, you're not on time.")
                : string.Empty;
        }

        private void inputCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            inputCheckBox1.ErrorText = !inputCheckBox1.Checked && !inputCheckBox2.Checked
                ? BuildErrorTip(inputCheckBox1, "Please check at least one of the checkboxes,<br> otherwise I won't know what to do...")
                : string.Empty;
            inputCheckBox2.ErrorText = inputCheckBox1.ErrorText;
        }

        private void inputTextBox2_TextChanged(object sender, EventArgs e)
        {
            inputTextBox2.ToolTipText = "Characters entered: " + inputTextBox2.Text.Length.ToString();
            inputTextBox2.ErrorText = inputTextBox2.Text.Length < 50
                ? BuildErrorTip(inputTextBox2, "Please enter at least 50 characters.  We want to know <b>more!</b>")
                : string.Empty;
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

        private void Validation_Load(object sender, EventArgs e)
        {

        }
    }
}
