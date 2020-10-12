using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace AutoCompleteTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // add some data to start with
            _flex[0, 1] = "Countries";
            var countries = "Zaire|Austria|Belgium|Canada|Denmark|Ethiopia|Finland|Germany|Haiti".Split('|');
            for (int i = 0; i < countries.Length; i++)
            {
                _flex[i + 1, 1] = countries[i];
            }
            _flex[0, 2] = "Colors";
            var colors = "Red|Green|Blue|Yellow|White|Black|Gold|Silver|Goldenrod|Magenta|Purple".Split('|');
            for (int i = 0; i < colors.Length; i++)
            {
                _flex[i + 1, 2] = colors[i];
            }

            // activate/deactivate auto completion
            _flex.SetupEditor += _flex_SetupEditor;
        }

        void _flex_SetupEditor(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            var tb = _flex.Editor as TextBox;
            if (tb != null)
            {
                tb.Multiline = false; // auto-complete works on single-line text boxes
                tb.AutoCompleteMode = AutoCompleteMode.Suggest;//.Append;//.Suggest;
                tb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                tb.AutoCompleteCustomSource = GetSuggestions(e.Col);
            }
        }
        /// <summary>
        /// Build a list containing all string in a given column of the grid.
        /// </summary>
        AutoCompleteStringCollection GetSuggestions(int column)
        {
            var list = new AutoCompleteStringCollection();
            for (int i = _flex.Rows.Fixed; i < _flex.Rows.Count; i++)
            {
                var text = _flex[i, column] as string;
                if (text != null)
                {
                    list.Add(text);
                }
            }
            return list;
        }
    }
}
