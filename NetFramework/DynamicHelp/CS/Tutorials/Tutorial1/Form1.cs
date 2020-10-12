using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tutorial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            c1DynamicHelp1.HelpSource = Path.GetFileName(c1DynamicHelp1.HelpSource);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            c1DynamicHelp1.ShowTopic("WordDocuments/glossaryofterms.htm");
        }
    }
}