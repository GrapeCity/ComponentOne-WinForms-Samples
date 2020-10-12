using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ControlExplorer.Input
{
    using C1.Win.C1Input;

    public partial class DropDownControls : C1DemoForm
    {

        public DropDownControls()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(AppDomain.CurrentDomain.BaseDirectory + "Resources\\sample.rtf");
            c1SplitButtonSpell.DefaultItem = c1SplitButtonSpell.Items[0];
        }

        private void c1SplitButtonSpell_DropDownItemClicked(object sender, DropDownItemClickedEventArgs e)
        {
            if (e.ClickedItem.Items.Count == 0)
                MessageBox.Show(this, string.Format("Checking the document with the {0} dictionary.", e.ClickedItem.Text));
        }

        private void c1ColorPicker1_ValueChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = (Color)((C1ColorPicker)sender).Value;
        }

        private void c1FontPicker1_ValueChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(((C1FontPicker)sender).Value.ToString(), richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
        }
    }
}
