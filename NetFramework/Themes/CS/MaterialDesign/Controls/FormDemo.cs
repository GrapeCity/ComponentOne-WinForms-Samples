using System;
using System.Drawing;
using System.Windows.Forms;
using C1.Win.Themes;

namespace MaterialDesign.Controls
{
    public partial class FormDemo : UserControl, IThemeable
    {
        private Color _labelColor;
        private Color _selectedLabelColor;

        public FormDemo()
        {
            InitializeComponent();

            c1RangeSlider1.LowerValue = 2000;
            c1RangeSlider1.UpperValue = 3000;
        }

        void IThemeable.ThemeChanged()
        {
            label1.Font = label2.Font = label3.Font = label4.Font = label5.Font = label6.Font = new Font(Font.FontFamily, Font.Size - 2);
            c1Label8.Font = c1Label9.Font = new Font(Font.FontFamily, Font.Size - 4);
            _labelColor = label1.ForeColor;
            C1MaterialThemeSettings settings = SampleHelper.Instance.C1Theme.GetSettings() as C1MaterialThemeSettings;
            if (settings != null)
                _selectedLabelColor = settings.PrimaryColor;
        }

        private void c1NumericEdit1_ValueChanged(object sender, EventArgs e)
        {
            var value1 = c1NumericEdit1.Value;
            var value2 = c1NumericEdit2.Value;
            if (value1 is DBNull)
                c1NumericEdit1.Value = 500;
            else if ((decimal)value1 < 500)
                c1NumericEdit1.Value = 500;
            else if (!(value2 is DBNull) && (decimal)value1 > (decimal)value2)
                c1NumericEdit1.Value = c1NumericEdit2.Value;
            c1RangeSlider1.LowerValue = decimal.ToDouble((decimal)c1NumericEdit1.Value);
        }

        private void c1NumericEdit2_ValueChanged(object sender, EventArgs e)
        {
            var value1 = c1NumericEdit1.Value;
            var value2 = c1NumericEdit2.Value;
            if(value2 is DBNull)
                c1NumericEdit2.Value = 5000;
            else if ((decimal)value2 > 5000)
                c1NumericEdit2.Value = 5000;
            else if (!(value1 is DBNull) && (decimal)value1 > (decimal)value2)
                c1NumericEdit2.Value = c1NumericEdit1.Value;
            c1RangeSlider1.UpperValue = decimal.ToDouble((decimal)c1NumericEdit2.Value);
        }

        private void c1CheckBox2_CheckedChanged(object sender, EventArgs e) => c1CheckBox1.Checked = !c1CheckBox2.Checked;
        private void c1CheckBox1_CheckedChanged(object sender, EventArgs e) => c1CheckBox2.Checked = !c1CheckBox1.Checked;

        private void c1RangeSlider1_UpperValueChanged(object sender, EventArgs e) => c1NumericEdit2.Value = (int)c1RangeSlider1.UpperValue;
        private void c1RangeSlider1_LowerValueChanged(object sender, EventArgs e) => c1NumericEdit1.Value = (int)c1RangeSlider1.LowerValue;

        private void c1TextBox1_Enter(object sender, EventArgs e) => label1.ForeColor = _selectedLabelColor;
        private void c1TextBox1_Leave(object sender, EventArgs e) => label1.ForeColor = _labelColor;
     
        private void c1TextBox2_Enter(object sender, EventArgs e) => label2.ForeColor = _selectedLabelColor;
        private void c1TextBox2_Leave(object sender, EventArgs e) => label2.ForeColor = _labelColor;

        private void c1DateEdit1_Enter(object sender, EventArgs e) => label3.ForeColor = _selectedLabelColor;
        private void c1DateEdit1_Leave(object sender, EventArgs e) => label3.ForeColor = _labelColor;

        private void c1ComboBox1_Enter(object sender, EventArgs e) => label4.ForeColor = _selectedLabelColor;
        private void c1ComboBox1_Leave(object sender, EventArgs e) => label4.ForeColor = _labelColor;

        private void c1NumericEdit1_Enter(object sender, EventArgs e) => label5.ForeColor = _selectedLabelColor;
        private void c1NumericEdit1_Leave(object sender, EventArgs e) => label5.ForeColor = _labelColor;

        private void c1NumericEdit2_Enter(object sender, EventArgs e) => label6.ForeColor = _selectedLabelColor;
        private void c1NumericEdit2_Leave(object sender, EventArgs e) => label6.ForeColor = _labelColor;
    }
}