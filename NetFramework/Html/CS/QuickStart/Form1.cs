using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using C1.Win.C1Html;
using C1.C1Preview;

namespace C1HTMLSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeDoc1(c1PrintDocument1);
        }

        private void MakeDoc1(C1PrintDocument doc)
        {
            doc.Clear();
            //qq XmlDocument xmlDoc = Loader.Load("sample.htm");
            XmlDocument xmlDoc = Loader.Load(@"x:\dev\internal.html");
            PrintDocConverter converter = new PrintDocConverter();
            converter.Convert(xmlDoc, doc);
        }
    }
}
