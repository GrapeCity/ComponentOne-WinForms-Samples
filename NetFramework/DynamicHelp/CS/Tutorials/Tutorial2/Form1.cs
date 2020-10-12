using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Tutorial2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            c1DynamicHelp1.HelpSource = Path.GetFileName(c1DynamicHelp1.HelpSource);
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            return base.ProcessCmdKey(ref msg, keyData);
        }

        // toggle authoring mode when the user hits ctrl+shift+a
        override protected void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A && e.Control && e.Shift)
            {
                 c1DynamicHelp1.AuthoringMode = !c1DynamicHelp1.AuthoringMode;
            }
            base.OnKeyDown(e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c1DynamicHelp1.TopicMap.Refresh();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (c1DynamicHelp1.TopicMap.HasChanges)
            {
                DialogResult dr = MessageBox.Show("Would you like to save the changes you made to control/topic map?", "C1DynamicHelp Tutorial", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                    c1DynamicHelp1.TopicMap.Save();
                else if (dr == DialogResult.Cancel)
                    e.Cancel = true;
            }
        }
    }
}