using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MultipleForms
{
    public partial class Form1 : DHBaseForm
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // show Form2
            Form2 f = new Form2();
            // use the MainForm property to allow the C1DynamicHelp control on Form2 to the control on Form1 as its data source
            f.MainForm = this;
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // show Form3
            Form3 f = new Form3();
            // use the MainForm property to allow the C1DynamicHelp control on Form3 to use the control on Form1 as its data source
            f.MainForm = this;
            f.ShowDialog();
        }
    }
}