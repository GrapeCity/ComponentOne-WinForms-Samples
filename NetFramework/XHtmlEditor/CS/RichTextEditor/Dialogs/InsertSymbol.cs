using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Resources = global::RichTextEditor.Properties.Resources;

namespace RichTextEditor
{
    public partial class InsertSymbol : Form
    {
        // ** fields
        C1EditorFunctionaliy _editor;
        SymbolLabel _selectedSymbol;

        // ** ctor
        public InsertSymbol()
        {
            InitializeComponent();

            _panel.SuspendLayout();
            foreach (string line in Resources.Symbols_tbl.Split('\r'))
            {
                SymbolLabel lbl = new SymbolLabel(toolTip1, line.Trim());
                lbl.Click += lbl_Click;
                lbl.DoubleClick += _btnInsert_Click;
                _panel.Controls.Add(lbl);
            }
            _panel.ResumeLayout();
        }

        // ** object model
        public DialogResult ShowDialog(C1EditorFunctionaliy editor)
        {
            _editor = editor;
            return ShowDialog();
        }

        C1EditorFunctionaliy Editor
        {
            get { return _editor; }
        }

        int SelectedIndex
        {
            get { return _panel.Controls.IndexOf(SelectedSymbol); }
            set 
            {
                value = Math.Min(Math.Max(value, 0), _panel.Controls.Count - 1);
                SelectedSymbol = (SymbolLabel)_panel.Controls[value]; 
            }
        }
        SymbolLabel SelectedSymbol
        {
            get { return _selectedSymbol; }
            set
            {
                if (_selectedSymbol != value)
                {
                    if (_selectedSymbol != null)
                    {
                        _selectedSymbol.BackColor = SystemColors.Window;
                        _selectedSymbol.ForeColor = SystemColors.WindowText;
                        _lblDescription.Text = string.Empty;
                    }

                    _selectedSymbol = value;
                    _btnInsert.Enabled = _selectedSymbol != null;

                    if (_selectedSymbol != null)
                    {
                        _selectedSymbol.BackColor = SystemColors.Highlight;
                        _selectedSymbol.ForeColor = SystemColors.HighlightText;
                        _lblDescription.Text = _selectedSymbol.Description;
                        _panel.ScrollControlIntoView(_selectedSymbol);
                    }
                }
            }
        }

        // ** implementation
        void lbl_Click(object sender, EventArgs e)
        {
            SelectedSymbol = sender as SymbolLabel;
            _focusBox.Focus();
        }
        void _btnInsert_Click(object sender, EventArgs e)
        {
            Editor.SelectedText = SelectedSymbol.Text;
        }
        void _focusBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    SelectVertical(-1);
                    break;
                case Keys.Down:
                    SelectVertical(+1);
                    break;
                case Keys.PageUp:
                    for (int i = 0; i < 4; i++)
                    {
                        SelectVertical(-1);
                    }
                    break;
                case Keys.PageDown:
                    for (int i = 0; i < 4; i++)
                    {
                        SelectVertical(+1);
                    }
                    break;
                case Keys.Left:
                    SelectedIndex--;
                    break;
                case Keys.Right:
                    SelectedIndex++;
                    break;
                case Keys.Home:
                    SelectedIndex = 0;
                    break;
                case Keys.End:
                    SelectedIndex = _panel.Controls.Count - 1;
                    break;
            }
            e.Handled = true;
        }
        void SelectVertical(int offset)
        {
            for (int i = SelectedIndex + offset; i >= 0 && i < _panel.Controls.Count; i += offset)
            {
                if (_panel.Controls[i].Left == SelectedSymbol.Left)
                {
                    SelectedIndex = i;
                    break;
                }
            }
        }

        // ** helper class
        class SymbolLabel : Label
        {
            static Size _sz = new Size(40, 40);
            string _description;

            public SymbolLabel(ToolTip tip, string symbol)
            {
                SetStyle(ControlStyles.Selectable, true);
                ((Control)this).TabStop = true;

                AutoSize = false;
                Size = _sz;
                Margin = new Padding(3);

                TextAlign = ContentAlignment.MiddleCenter;
                BackColor = SystemColors.Window;
                ForeColor = SystemColors.WindowText;

                Text = symbol[0].ToString();
                Description = symbol.Substring(2).Trim();
                tip.SetToolTip(this, Description);
            }
            public string Description
            {
                get { return _description; }
                set { _description = value; }
            }
        }
    }
}
