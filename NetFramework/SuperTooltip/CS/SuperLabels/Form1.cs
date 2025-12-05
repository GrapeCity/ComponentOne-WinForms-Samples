using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.Win.SuperTooltip;

namespace SuperLabels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // display an existing html file in the c1SuperLabel
        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.FileName = "*.htm";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    StreamReader r = new StreamReader(dlg.FileName);
                    richTextBox1.Text = r.ReadToEnd();
                }
            }
        }

        // use timer to wait a little while user types
        Timer _timer;
        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (_timer == null)
            {
                _timer = new Timer();
                _timer.Interval = 1000;
                _timer.Tick += new EventHandler(_timer_Tick);
            }
            _timer.Enabled = false;
            _timer.Enabled = true;
        }
        void _timer_Tick(object sender, EventArgs e)
        {
            c1SuperLabel1.Text = richTextBox1.Text;
            _timer.Enabled = false;
        }

        // update preview whenever text changes
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (_timer == null || _timer.Enabled == false)
            {
                c1SuperLabel1.Text = richTextBox1.Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // populate combo list with html snippets
            Assembly a = Assembly.GetExecutingAssembly();
            foreach (string res in a.GetManifestResourceNames())
            {
                if (res.EndsWith(".htm"))
                {
                    string[] name = res.Split('.');
                    string item = name[name.Length - 2];
                    this.comboBox1.Items.Add(item);
                }
            }

            // select the first item
            this.comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // load selected html snippet
            if (this.comboBox1.Text.Length > 0)
            {
                string res = string.Format("SuperLabels.Resources.{0}.htm", this.comboBox1.Text);
                Assembly a = Assembly.GetExecutingAssembly();
                using (StreamReader s = new StreamReader(a.GetManifestResourceStream(res)))
                {
                    this.richTextBox1.Text = s.ReadToEnd();
                }
            }
        }
    }
}