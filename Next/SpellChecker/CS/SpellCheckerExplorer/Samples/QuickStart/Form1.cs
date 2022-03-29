using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.FlexGrid;
using C1.Win.SpellChecker;

namespace SpellCheckerExplorer.Samples.QuickStart
{
    public partial class Form1 : UserControl
    {
        public Form1()
        {
            InitializeComponent();
        }

        //------------------------------------------------------------------------------------------------
        #region ** Initalize form
        
        // load some text into controls, check that the spell dictionary is loaded
        private void Form1_Load(object sender, EventArgs e)
        {
            Font = SystemInformation.MenuFont;

            // load some text into the text boxes (rich and regular)
            this.richTextBox1.Rtf = Properties.Resources.Mark_Twain;
            this.textBox1.Text = this.richTextBox1.Text.Replace("\n", "\r\n");

            // initialize richtextbox zoom
            cmbZoom.Text = "100%";

            // initialize FlexGrid
            string sql = "select * from employees";
            string conn = GetConnectionString();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            // initialize grid
            _flex.Styles.Normal.WordWrap = true;
            _flex.DataSource = dt;
            Column c = _flex.Cols["Notes"];
            _flex.AutoSizeCols();
            c.Width = 350;
            _flex.AutoSizeRows();

            // hook up spell-checker when editing starts
            _flex.StartEdit += new RowColEventHandler(_flex_StartEdit);

            // check that the spell-checker is active
            // NOTE: the easiest way to ensure the dictionary is deployed properly is to add the dct
            //       file to the project, and set the following properties:
            //          BuildAction = None
            //          CopyToOutputDirectory = CopyIfNewer
            //
            if (!this._spell.Enabled)
            {
                // not enabled, check why
                switch (this._spell.MainDictionary.State)
                {
                    case DictionaryState.Empty:
                        MessageBox.Show("Dictionary file name not set.");
                        break;
                    case DictionaryState.FileNotFound:
                        MessageBox.Show(string.Format("Dictionary file '{0}' not found.", this._spell.MainDictionary.FileName));
                        break;
                    case DictionaryState.InvalidFileFormat:
                        MessageBox.Show(string.Format("Dictionary file '{0}' is invalid.", this._spell.MainDictionary.FileName));
                        break;
                    case DictionaryState.InvalidPassword:
                        MessageBox.Show(string.Format("Wrong password for dictionary file '{0}'.", this._spell.MainDictionary.FileName));
                        break;
                    case DictionaryState.Loaded:
                        MessageBox.Show("Dictionary loaded OK.");
                        break;
                }
            }
        }
        static string GetConnectionString()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + @"\ComponentOne Samples\Common";
            string conn = @"provider=microsoft.jet.oledb.4.0;data source={0}\c1nwind.mdb;";
            return string.Format(conn, path);
        }


        #endregion

        //------------------------------------------------------------------------------------------------
        #region ** Apply all spelling modes to a RichTextBox

        // mode 1: batch
        // check a string and get a list of all spelling mistakes
        private void btnShowErrorsRich_Click(object sender, EventArgs e)
        {
            // get a list with all spelling mistakes
            CharRangeList errors = this._spell.CheckText(this.richTextBox1.Text);

            // show the list
            ShowErrors(errors);
        }

        // mode 2: modal dialog
        // spell-check a text editor showing a dialog
        private void btnSpellDialogRich_Click(object sender, EventArgs e)
        {
            // show dialog
            int errorCount = this._spell.CheckControl(this.richTextBox1);

            if (errorCount < 0)
            {
                // dialog was canceled by user
            }
            else
            {
                string msg = string.Format("Spell-checking complete.\r\n{0} error(s) found.", errorCount);
                MessageBox.Show(msg);
            }
        }

        // mode 3: active (as-you-type) spell checking
        // draws a red wiggly underline under typos, provides a context-sensitive menu
        private void btnAsYouTypeRich_CheckedChanged(object sender, EventArgs e)
        {
            // toggle active spelling
            this._spell.SetActiveSpellChecking(
                this.richTextBox1, 
                this.btnAsYouTypeRich.Checked);
        }

        #endregion

        //------------------------------------------------------------------------------------------------
        #region ** Apply all spelling modes to a regular TextBox (exactly the same code as before)

        private void btnShowErrors_Click(object sender, EventArgs e)
        {
            CharRangeList errors = this._spell.CheckText(this.textBox1.Text);
            ShowErrors(errors);
        }
        private void btnSpellDialog_Click(object sender, EventArgs e)
        {
            int errorCount = this._spell.CheckControl(this.textBox1);
            if (errorCount > -1)
            {
                string msg = string.Format("Spell-checking complete.\r\n{0} error(s) found.", errorCount);
                MessageBox.Show(msg);
            }
        }
        private void btnAsYouType_CheckedChanged(object sender, EventArgs e)
        {
            this._spell.SetActiveSpellChecking(this.textBox1, this.btnAsYouType.Checked);
        }

        #endregion

        //------------------------------------------------------------------------------------------------
        #region ** Spell-check a C1FlexGrid

        // provide as-you-type spelling in the grid editor
        void _flex_StartEdit(object sender, RowColEventArgs e)
        {
            TextBoxBase tb = _flex.Editor as TextBoxBase;
            if (tb != null)
            {
                _spell.SetSpellChecking(tb, true);
            }
        }

        // spell-check selected columns
        private void btnSpellDialogGrid_Click(object sender, EventArgs e)
        {
            // create spell-checkable wrapper for C1FlexGrid
            FlexGridSpeller editor = new FlexGridSpeller(_flex, "Title", "Notes");

            // spell-check
            int errorCount = _spell.CheckControl(editor);
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

        #endregion

        //------------------------------------------------------------------------------------------------
        #region ** utility / event handlers

        private void ShowErrors(CharRangeList errors)
        {
            DataGridView grid = new DataGridView();
            grid.DataSource = errors;
            grid.Dock = DockStyle.Fill;
            Form f = new Form();
            f.StartPosition = FormStartPosition.CenterParent;
            f.Text = string.Format("{0} Spelling errors detected", errors.Count);
            f.Controls.Add(grid);
            f.ShowDialog();
        }
        private void cmbZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            float zoom = 1f;
            if (float.TryParse(cmbZoom.Text.Replace("%", ""), out zoom))
            {
                zoom = zoom / 100f;
            }
            this.richTextBox1.ZoomFactor = zoom;
            this.richTextBox1.Focus();
        }
        private void btnFont_Click(object sender, EventArgs e)
        {
            using (FontDialog dlg = new FontDialog())
            {
                dlg.Font = textBox1.Font;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Font = dlg.Font;
                }
            }
        }

        #endregion
    }
}