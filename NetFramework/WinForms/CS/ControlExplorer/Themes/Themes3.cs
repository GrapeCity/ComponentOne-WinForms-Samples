using C1.Win.FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.Themes
{
    public partial class Themes3 : C1DemoForm
    {
        public Themes3()
        {
            IsThemeable = false;
            InitializeComponent();
            this.ribbonComboBox1.DropDownStyle = C1.Win.Ribbon.RibbonComboBoxStyle.DropDownList;
            // populate combobox with all available themes
            var themes = C1.Win.Themes.C1ThemeController.GetThemes();
            foreach (string theme in themes)
                this.ribbonComboBox1.Items.Add(theme);
            this.ribbonComboBox1.SelectedIndex = this.ribbonComboBox1.Items.IndexOf("Material");
        }

        private void ribbonComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var theme = ribbonComboBox1.SelectedItem.Text;

            Action<Control> setTheme = null;
            setTheme = (c) =>
            {
                if (C1.Win.Themes.C1ThemeController.IsObjectThemeable(c))
                    this.c1ThemeController1.SetTheme(c, theme);
                foreach (Control cc in c.Controls)
                    setTheme(cc);
            };
            setTheme(this);
            var color = ribbonColorPicker1.Color;
            if (color != Color.Transparent && !color.IsEmpty)
            {
                c1FlexGrid1.ForeColor = ribbonColorPicker1.Color;
            }
        }

        private void Themes3_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'c1DemoDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.c1DemoDataSet.Employees);

            c1FlexGrid1.AllowFiltering = true;
            // load data to combobox
            foreach(C1DemoDataSet.EmployeesRow eRow in c1DemoDataSet.Employees.Rows)
                ribbonComboBox2.Items.Add(eRow.LastName);
        }

        private void ribbonComboBox2_TextChanged(object sender, EventArgs e)
        {
            // has filter text
            if (!string.IsNullOrEmpty(ribbonComboBox2.Text))
            {
                // create a new ConditionFilter
                var filter = new ConditionFilter();

                // configure filter
                filter.Condition1.Operator = ConditionOperator.BeginsWith;
                filter.Condition1.Parameter = ribbonComboBox2.Text;

                // assign new filter to column
                c1FlexGrid1.Cols["LastName"].Filter = filter;
                rbtnClearFilter1.Enabled = true;
            }
            else
            {
                c1FlexGrid1.Cols["LastName"].Filter = null;
                rbtnClearFilter1.Enabled = false;
            }
        }

        private void ribbonDatePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (!(ribbonDatePicker1.Value.Year == 2000 && ribbonDatePicker1.Value.Month == 1 && ribbonDatePicker1.Value.Day == 1))
            {
                // create a new ConditionFilter
                var filter = new ConditionFilter();

                // configure filter
                filter.Condition1.Operator = ConditionOperator.LessThanOrEqualTo;
                filter.Condition1.Parameter = ribbonDatePicker1.Value;

                // assign new filter to column
                c1FlexGrid1.Cols["BirthDate"].Filter = filter;
                rbtnClearFilter2.Enabled = true;
            }
            else
            {
                c1FlexGrid1.Cols["BirthDate"].Filter = null;
                rbtnClearFilter2.Enabled = false;
            }
        }

        private void ribbonNumericBox1_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ribbonNumericBox1.Text))
            {
                // create a new ConditionFilter
                var filter = new ConditionFilter();

                // configure filter
                filter.Condition1.Operator = ConditionOperator.Equals;
                filter.Condition1.Parameter = ribbonNumericBox1.Value;

                // assign new filter to column
                c1FlexGrid1.Cols["EmployeeID"].Filter = filter;
                rbtnClearFilter3.Enabled = true;
            }
            else
            {
                c1FlexGrid1.Cols["EmployeeID"].Filter = null;
                rbtnClearFilter3.Enabled = false;
            }
        }

        private void rbtnClearFilter3_Click(object sender, EventArgs e)
        {
            ribbonNumericBox1.ValueIsNull = true;
        }

        private void rbtnClearFilter2_Click(object sender, EventArgs e)
        {
            ribbonDatePicker1.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
        }

        private void rbtnClearFilter1_Click(object sender, EventArgs e)
        {
            ribbonComboBox2.Text = string.Empty;
        }

        private void ribbonFontComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var fontFace = ribbonFontComboBox1.SelectedItem.Text;
            c1FlexGrid1.Font = new Font(fontFace, 10);
        }

        private void ribbonButton2_Click(object sender, EventArgs e)
        {
            C1Zoom.ZoomFactor = Math.Max(1f, C1Zoom.ZoomFactor - 0.2f);
        }

        private void ribbonButton1_Click(object sender, EventArgs e)
        {
            C1Zoom.ZoomFactor = Math.Min(2f, C1Zoom.ZoomFactor + 0.2f);
        }

        private void ribbonColorPicker1_SelectedColorChanged(object sender, EventArgs e)
        {
            c1FlexGrid1.ForeColor = ribbonColorPicker1.Color;
        }
    }
}
