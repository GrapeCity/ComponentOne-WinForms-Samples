using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ControlExplorer.Tiles
{
    public partial class NameForm : Form
    {
        public NameForm()
        {
            InitializeComponent();
        }

        void okButton_Click(object sender, EventArgs e)
        {
            string s = nameBox.Text.Trim();
            if (s.Length == 0)
            {
                MessageBox.Show("Name can't be empty.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        public static string GetFolderName()
        {
            string result = null;
            NameForm nf = new NameForm();
            if (nf.ShowDialog() == DialogResult.OK)
            {
                result = nf.nameBox.Text;
            }
            nf.Dispose();
            return result;
        }

        public static string RenameItem(string oldName, string title, string prompt)
        {
            string result = null;
            NameForm nf = new NameForm();
            nf.Text = title;
            nf.nameLabel.Text = prompt;
            nf.nameBox.Text = oldName;
            if (nf.ShowDialog() == DialogResult.OK)
            {
                result = nf.nameBox.Text;
            }
            nf.Dispose();
            return result;
        }
    }
}
