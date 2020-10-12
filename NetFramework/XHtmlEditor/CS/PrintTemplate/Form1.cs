using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PrintTemplate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonPreview_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDesign.Checked)
                c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Design;
            if (radioButtonSource.Checked)
                c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Source;
            if (radioButtonPreview.Checked)
                c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Preview;
            // Template Source
            richTextBox1.Visible = radioButtonTemplateSource.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c1Editor1.LoadXml("samplepage.htm");
            richTextBox1.Visible = false;
            comboBox1.SelectedIndex = 0;
            c1Editor1.Mode = C1.Win.C1Editor.EditorMode.Preview;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.templateName = string.Format("template{0:D}.htm", comboBox1.SelectedIndex+1);
            richTextBox1.LoadFile(this.templateName, RichTextBoxStreamType.PlainText);
            bool previewOnly = comboBox1.SelectedItem.ToString().Contains("Preview Only");
            button2.Enabled = !previewOnly;
            button3.Enabled = !previewOnly;
        }

        private string templateName;


        // Print Preview
        private void button1_Click(object sender, EventArgs e)
        {
            c1Editor1.PrintPreview(System.IO.Path.GetFullPath(this.templateName));
        }

        // Print with Prompt
        private void button2_Click(object sender, EventArgs e)
        {
            c1Editor1.Print(true, System.IO.Path.GetFullPath(this.templateName));
        }

        // Print w/o Prompt
        private void button3_Click(object sender, EventArgs e)
        {
            c1Editor1.Print(false, System.IO.Path.GetFullPath(this.templateName));
        }

    }
}
