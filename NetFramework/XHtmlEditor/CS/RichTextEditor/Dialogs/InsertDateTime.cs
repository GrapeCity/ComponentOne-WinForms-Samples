using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RichTextEditor
{
    public partial class InsertDateTime : Form
    {
        // ** fields
        C1RibbonEditorXhtml _editor;

        // ** ctor
        public InsertDateTime()
        {
            InitializeComponent();

            string[] formats = new string[]
            {
		        "MMMM dd, yyyy",
		        "M/d/yyyy",
		        "yyyy-MM-dd",
		        "dd-MMM-yy",
		        "M.d.yyyy",
		        "MMM. d, yy",
		        "d MMMM yyyy",
		        "MMMM yy",
		        "MMM-yy",
		        "M/d/yyyy h:mm tt",
		        "M/d/yyyy h:mm:ss tt",
		        "h:mm:ss tt",
		        "H:mm",
		        "H:mm:ss"
            };

            // show current time
            DateTime now = DateTime.Now;

            // clear list
            _list.Items.Clear();

            // predefined formats
            _list.Items.Add(now.ToShortDateString());
            _list.Items.Add(now.ToLongDateString());
            _list.Items.Add(now.ToShortTimeString());
            _list.Items.Add(now.ToLongTimeString());

            // custom formats
            foreach (string fmt in formats)
            {
                _list.Items.Add(now.ToString(fmt));
            }

            // select first item
            _list.SelectedIndex = 0;

            // select item on double-click
            _list.DoubleClick += _btnInsert_Click;
        }


        // ** object model
        public DialogResult ShowDialog(C1RibbonEditorXhtml editor)
        {
            _editor = editor;
            return ShowDialog();
        }
        C1RibbonEditorXhtml Editor
        {
            get { return _editor; }
        }

        // ** event handlers
        private void _btnInsert_Click(object sender, EventArgs e)
        {
            if (_list.SelectedIndex > -1 && Editor != null)
            {
                Editor.SelectedText = _list.Text;
                DialogResult = DialogResult.OK;
            }
        }
    }
}
