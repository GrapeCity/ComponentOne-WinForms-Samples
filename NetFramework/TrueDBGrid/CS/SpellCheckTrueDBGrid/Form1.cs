using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1SpellChecker;
using C1.Win.C1TrueDBGrid;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button1.Text = "Spell Check";

            // mock data with some spelling errors
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("Name", typeof(string));

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    dt.Rows.Add(i, string.Format("Name {0}", i));
                else
                    dt.Rows.Add(i, "Nmea");
            }
            
            c1TrueDBGrid1.SetDataBinding(dt, "");

            // set editor so we can do spell checking
            // ...you *may* be able to do this without setting editor, but this works fine
            c1TrueDBGrid1.Columns[0].Editor = new TextBox();
            c1TrueDBGrid1.Columns[1].Editor = new TextBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrueGridSpeller editor = new TrueGridSpeller(c1TrueDBGrid1, "Name");
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

        // Boolean flag to check if edit can be committed
        bool allowCommit = true;
        private void c1TrueDBGrid1_ColEdit(object sender, ColEventArgs e)
        {
            TextBoxBase tb = c1TrueDBGrid1.Editor as TextBoxBase;
            if (tb != null)
            {
                c1SpellChecker1.SetSpellChecking(tb, true);

                if (c1SpellChecker1.CheckText(tb.Text).Count > 0)
                {
                    allowCommit = false;
                    errorProvider1.SetError(c1TrueDBGrid1, "There is a spelling error.  Please correct the spelling error before moving on.");
                }
                else
                {
                    allowCommit = true;
                    errorProvider1.Clear();
                }
            }
        }

        private void c1TrueDBGrid1_BeforeRowColChange(object sender, C1.Win.C1TrueDBGrid.CancelEventArgs e)
        {
            // if there is an error, cancel changes until spelling is correct
            if (!allowCommit)
            {
                e.Cancel = true;
            }
        }

        private void c1TrueDBGrid1_AfterColEdit(object sender, ColEventArgs e)
        {
            TextBoxBase tb = c1TrueDBGrid1.Editor as TextBoxBase;
            if (tb != null)
            {
                c1SpellChecker1.SetSpellChecking(tb, true);

                if (c1SpellChecker1.CheckText(tb.Text).Count > 0)
                {
                    allowCommit = false;
                    errorProvider1.SetError(c1TrueDBGrid1, "There is a spelling error.  Please correct the spelling error before moving on.");
                }
                else
                {
                    allowCommit = true;
                    errorProvider1.Clear();
                }
            }
        }
    }

    public class TrueGridSpeller : ISpellCheckableEditor
    {
        //-------------------------------
        #region ** fields

        // grid being spell-checked
        C1TrueDBGrid _trueGrid;
        // columns to be spell-checked
        int[] _cols;
        // cell being spell-checked (_row, _cols[_col])
        int _row, _col;
        // selection being checked within the cell
        int _selStart;
        int _selLength;

        #endregion

        //-------------------------------
        #region ** ctors

        // check some columns
        public TrueGridSpeller(C1TrueDBGrid trueGrid, params string[] cols)
        {
            // save parameters
            _trueGrid = trueGrid;

            // create column list if needed
            if (cols == null)
            {
                List<string> list = new List<string>();
                foreach (C1DataColumn col in trueGrid.Columns)
                {
                    if (col.DataType == typeof(string))
                        list.Add(col.DataField);
                }
                cols = list.ToArray();
            }

            // convert column names to column indices
            _cols = new int[cols.Length];
            for (int i = 0; i < _cols.Length; i++)
            {
                string name = cols[i];
                if (!(_trueGrid.DataSource as DataTable).Columns.Contains(name))
                {
                    throw new Exception("column not found: " + name);
                }
                _cols[i] = _trueGrid.Columns.IndexOf(name);
            }

            // scan cells until an error is found
            _row = -1;
            _col = 0;
            MoveNext();
        }

        // check all columns
        public TrueGridSpeller(C1TrueDBGrid trueGrid) : this(trueGrid, null)
        {
        }

        #endregion

        //-------------------------------
        #region ** object model

        // move on to the next cell
        public bool MoveNext()
        {
            // initialize or increment row/col position
            if (_row < 0)
            {
                // initialize
                _row = 0;
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
            return _row < _trueGrid.RowCount && _col < _cols.Length;
        }

        #endregion

        //-------------------------------
        #region ** ISpellCheckableEditor

        public Control Control
        {
            get { return _trueGrid; }
        }
        public bool HideSelection
        {
            get { return false; }
            set { }
        }
        public string Text
        {
            get { return _trueGrid[_row, _cols[_col]].ToString(); }
            set { _trueGrid[_row, _cols[_col]] = value; }
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
            _trueGrid.SetActiveCell(_row, _cols[_col]);
            //_trueGrid.Select(_row, _cols[_col]);
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
