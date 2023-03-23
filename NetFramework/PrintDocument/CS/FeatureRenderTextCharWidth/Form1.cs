using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;

namespace Feature_TestRenderTextCharWidth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateDoc(C1PrintDocument doc)
        {
            doc.Style.Font = new Font("Verdana", 18);

            RenderText rt = new RenderText();
            rt.Text = "New style property:\rfloat Style.CharWidth { get; set; }\rAllows to define the width of text characters, it is define a percent of width relative to normal width i.e. 100 - normal width (default), 200 - 2times wider.";
            rt.Style.Borders.All = new LineDef("1mm", Color.Red);
            rt.Style.Spacing.Bottom = "10mm";
            doc.Body.Children.Add(rt);


            float cw = 200;
            doc.Body.Children.Add(new RenderText("CharWidth: " + cw.ToString()));
            rt = new RenderText();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 30; i++)
                sb.Append(string.Format("Fragment{0} ", i));
            sb.Remove(sb.Length - 1, 1);
            rt.Text = sb.ToString();
            rt.Style.Borders.All = LineDef.Default;
            rt.Style.BackColor = Color.LawnGreen;
            rt.Style.CharWidth = cw;
            doc.Body.Children.Add(rt);


            cw = 50;
            doc.Body.Children.Add(new RenderText("CharWidth: " + cw.ToString()));
            rt = new RenderText();
            sb = new StringBuilder();
            for (int i = 0; i < 30; i++)
                sb.Append(string.Format("Fragment{0} ", i));
            sb.Remove(sb.Length - 1, 1);
            rt.Text = sb.ToString();
            rt.Style.Borders.All = LineDef.Default;
            rt.Style.BackColor = Color.LawnGreen;
            rt.Style.CharWidth = cw;
            doc.Body.Children.Add(rt);

            doc.Generate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateDoc(doc);
        }
    }
}