using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AutoReplace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // create DataTable with AutoReplace list 
        // (so we can show and edit the list on a grid)
        DataTable _dt = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            // build AutoReplace table
            _dt.Columns.Add("key", typeof(string));
            _dt.Columns.Add("text", typeof(string));
            _dt.Rows.Add("(c)", "©");
            _dt.Rows.Add("(r)", "®");
            _dt.Rows.Add("(tm)", "™");
            _dt.Rows.Add("1/2", "½");
            _dt.Rows.Add("1/4", "¼");
            _dt.Rows.Add("teh", "the");
            _dt.Rows.Add("abouta", "about a");
            _dt.Rows.Add("becuase", "because");
            _dt.Rows.Add("cant", "can't");
            _dt.Rows.Add("decison", "decision");
            _dt.Rows.Add("efort", "effort");
            _dt.Rows.Add("feild", "field");

            // show AutoReplace table on the grid
            this.dataGridView1.DataSource = _dt;

            // update AutoReplaceList now and whenever the table changes
            UpdateAutoReplaceList();
            _dt.DefaultView.ListChanged += new ListChangedEventHandler(DefaultView_ListChanged);
        }

        // update AutoReplaceList when the table changes
        void DefaultView_ListChanged(object sender, ListChangedEventArgs e)
        {
            UpdateAutoReplaceList();
        }

        // update c1SpellChecker's AutoReplaceList from table
        private void UpdateAutoReplaceList()
        {
            c1SpellChecker1.AutoReplaceList.Clear();
            foreach (DataRow dr in _dt.Rows)
            {
                c1SpellChecker1.AutoReplaceList[(string)dr["key"]] = (string)dr["text"];
            }
        }

        // spell-check control when user presses F7
        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F7)
            {
                this.c1SpellChecker1.CheckControl(this.richTextBox1);
            }
        }
    }
}