using System;
using System.Windows.Forms;

namespace EditorExplorer.Data
{
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
        }

        public string FindText => textBox1.Text;

        public string ReplaceWith => textBox2.Text;

        public FindAction Action { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Action = FindAction.Find;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Action = FindAction.Replace;
            DialogResult = DialogResult.OK;
            Close();
        }

        public enum FindAction
        {
            None,
            Find,
            Replace
        }
    }
}