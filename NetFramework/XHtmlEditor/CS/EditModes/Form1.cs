using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EditModes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Design;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Source;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Preview;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog(this) == DialogResult.OK)
                c1Editor1.SaveXml(saveFileDialog1.FileName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
                c1Editor1.LoadXml(openFileDialog1.FileName);

        }

    }
}