using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1SpellChecker;
using ActiproSoftware.SyntaxEditor;

namespace SpellEditor
{
    public partial class Form1 : Form
    {

        SyntaxEditor _editor;
        C1SpellChecker _spell;
        SyntaxEditorWrapper _wrapper;
        string _fileName;

        public Form1()
        {
            InitializeComponent();
            _editor = this.syntaxEditor1;
            _wrapper = new SyntaxEditorWrapper(_editor);
            _spell = this.c1SpellChecker1;
            _spell.SetActiveSpellChecking(_wrapper, true);
        }

        bool CheckModified()
        {
            if (_editor.Document.Modified)
            {
                var dialogResult = MessageBox.Show("Document is modified. Save Changes?", "SyntaxEditor", MessageBoxButtons.YesNoCancel);
                if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    return Save();
                }
                else if (dialogResult == System.Windows.Forms.DialogResult.Cancel)
                    return false;
            }
            return true;
        }

        bool New()
        {
            if (CheckModified())
            {
                _editor.Document.Text = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\r<root>\r</root>";
                _fileName = "";
                return true;
            }
            return false;
        }

        bool Open()
        {
            if (CheckModified())
            {
                var openDialog = new OpenFileDialog();
                openDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                openDialog.FileName = _fileName;
                if (openDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    _fileName = openDialog.FileName;
                    _editor.Document.LoadFile(_fileName);
                    return true;
                }
                else
                    return false;
            }
            return false;
        }

        bool Save()
        {
            if (_fileName == "")
                return SaveAs();
            _editor.Document.SaveFile(_fileName, LineTerminator.CarriageReturnNewline);
            return true;
        }

        bool SaveAs()
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            saveDialog.FileName = _fileName;
            if (saveDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                _fileName = saveDialog.FileName;
                _editor.Document.SaveFile(_fileName, LineTerminator.CarriageReturnNewline);
                return true;
            }
            else 
                return false;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "New":
                    New();
                    break;
                case "Open":
                    Open();
                    break;
                case "Save":
                    Save();
                    break;
                case "Save As...":
                    SaveAs();
                    break;
                case "Spell Check":
                    _spell.CheckControl(_wrapper);
                    break;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
             _spell.CheckControl(_wrapper);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _fileName = "books.xml";
            _editor.Document.LoadFile("books.xml");
        }

        private void spellAsYouTypeToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            _spell.SetActiveSpellChecking(_wrapper, spellAsYouTypeToolStripMenuItem.Checked);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                e.Cancel = !CheckModified();
        }

        private void command1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This sample demonstrates live spell checking \r\n in Actipro SyntaxEditor control.");
        }


    }
}
