using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SchemaExtenderAndColumnStyles
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = c1DataViewSet1.Views[0].Definition;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            c1DataViewSet1.Views[0].Definition = textBox1.Text;
        }

    }
}