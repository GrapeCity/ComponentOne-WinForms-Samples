using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1SpellChecker;
using C1.Win.C1FlexGrid;

namespace ControlExplorer.SpellChecker
{
    public partial class SpellGrid : C1DemoForm
    {
        public SpellGrid()
        {
            InitializeComponent();
        }

        private void SpellGrid_Load(object sender, EventArgs e)
        {
            c1FlexGrid1.DataSource = DemoDataSource("Employees");
            c1FlexGrid1.Cols["TitleOfCourtesy"].Visible = false;
            c1FlexGrid1.Cols["Extension"].Visible = false;
            c1FlexGrid1.Cols["ReportsTo"].Visible = false;
            c1FlexGrid1.Cols["BirthDate"].Visible = false;
            c1FlexGrid1.Cols["Address"].Visible = false;
            c1FlexGrid1.Cols["City"].Visible = false;
            c1FlexGrid1.Cols["Region"].Visible = false;
            c1FlexGrid1.Cols["HomePhone"].Visible = false;
            c1FlexGrid1.Cols["PostalCode"].Visible = false;
            c1FlexGrid1.Cols["Country"].Visible = false;
            c1FlexGrid1.Cols["HireDate"].Visible = false;
            // initialize grid
            c1FlexGrid1.Styles.Normal.WordWrap = true;
            Column c = c1FlexGrid1.Cols["Notes"];
            c.Width = 350;
            c1FlexGrid1.AutoSizeRows();

            // hook up spell-checker when editing starts
            c1FlexGrid1.StartEdit += new RowColEventHandler(_flex_StartEdit);

            // use green underline here, just for fun...
            c1SpellChecker1.Options.UnderlineColor = Color.DarkGreen;
        }

        // provide as-you-type spelling in the grid editor
        void _flex_StartEdit(object sender, RowColEventArgs e)
        {
            TextBoxBase tb = c1FlexGrid1.Editor as TextBoxBase;
            if (tb != null)
            {
                c1SpellChecker1.SetSpellChecking(tb, true);
            }
        }

        // spell-check the grid
        private void _spellCheck_Click(object sender, EventArgs e)
        {
            // create spell-checkable wrapper for C1FlexGrid
            FlexGridSpeller editor = new FlexGridSpeller(c1FlexGrid1, "Title", "Notes");

            // spell-check
            int errorCount = c1SpellChecker1.CheckControl(editor);
            if (errorCount > -1)
            {
                string msg = string.Format("Spell-checking complete. {0} error(s) found.", errorCount);
                MessageBox.Show(msg);
            }
            else
            {
                MessageBox.Show("Spell-checking cancelled.");
            }
        }
    }

    /// <summary>
    /// Wrapper class that implements the ISpellCheckableEditor on behalf of a
    /// C1FlexGrid and allows spell-checking the grid with a C1SpellChecker 
    /// control.
    /// </summary>
    public class FlexGridSpeller : ISpellCheckableEditor
    {
        //-----------------------------------------------------------------------------
        #region ** fields

        C1FlexGrid _flex;   // grid being spell-checked
        int[] _cols;        // columns to be spell-checked
        int _row, _col;     // cell being spell-checked (_row, _cols[_col])
        int _selStart;      // selection being checked within the cell
        int _selLength;

        #endregion

        //-----------------------------------------------------------------------------
        #region ** ctors

        // check some columns
        public FlexGridSpeller(C1FlexGrid flex, params string[] cols)
        {
            // save parameters
            _flex = flex;

            // create column list if needed
            if (cols == null)
            {
                List<string> list = new List<string>();
                foreach (Column col in flex.Cols)
                {
                    if (col.DataType == typeof(string))
                        list.Add(col.Name);
                }
                cols = list.ToArray();
            }

            // convert column names to column indices
            _cols = new int[cols.Length];
            for (int i = 0; i < _cols.Length; i++)
            {
                string name = cols[i];
                if (!_flex.Cols.Contains(name))
                {
                    throw new Exception("column not found: " + name);
                }
                _cols[i] = _flex.Cols[name].Index;
            }

            // scan cells until an error is found
            _row = -1;
            _col = 0;
            MoveNext();
        }

        // check all columns
        public FlexGridSpeller(C1FlexGrid flex)
            : this(flex, null)
        {
        }

        #endregion

        //-----------------------------------------------------------------------------
        #region ** object model

        // move on to the next cell
        public bool MoveNext()
        {
            // initialize or increment row/col position
            if (_row < 0)
            {
                // initialize
                _row = _flex.Rows.Fixed;
                _col = 0;
            }
            else if (_col < _cols.Length - 1)
            {
                // next column
                _col++;
            }
            else
            {
                // next row
                _row++;
                _col = 0;
            }

            // return true if we still have valid cells
            return _row < _flex.Rows.Count && _col < _cols.Length;
        }

        #endregion

        //-----------------------------------------------------------------------------
        #region ** ISpellCheckableEditor

        public Control Control
        {
            get { return _flex; }
        }
        public bool HideSelection
        {
            get { return false; }
            set { }
        }
        public string Text
        {
            get { return _flex.GetDataDisplay(_row, _cols[_col]); }
            set { _flex[_row, _cols[_col]] = value; }
        }
        public string SelectedText
        {
            get { return Text.Substring(_selStart, _selLength); }
            set
            {
                string text = Text;
                text = string.Format("{0}{1}{2}",
                    text.Substring(0, _selStart),
                    value,
                    text.Substring(_selStart + _selLength));
                Text = text;
            }
        }
        public int SelectionLength
        {
            get { return _selLength; }
            set { _selLength = value; }
        }
        public int SelectionStart
        {
            get { return _selStart; }
            set { _selStart = value; }
        }
        public void Select(int start, int length)
        {
            // keep track of selection within the cell
            _selStart = start;
            _selLength = length;

            // check that the cell being checked is selected
            _flex.Select(_row, _cols[_col]);
        }
        public void SelectAll()
        {
            _selStart = 0;
            _selLength = Text.Length;
        }
        public bool HasMoreText()
        {
            return MoveNext();
        }
        public void BeginSpell()
        {
        }
        public void EndSpell()
        {
        }
        #endregion
    }
}
