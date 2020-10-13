using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;

namespace Feature_RenderTextCharSpacing
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
            rt.Text = "New style property:\rUnit Style.CharSpacing { get; set; }\rAllows to define character spacing in text. (The default is zero.)";
            rt.Style.Borders.All = new LineDef("1mm", Color.Red);
            rt.Style.Spacing.Bottom = "10mm";
            doc.Body.Children.Add(rt);


            Unit cs = "2mm";
            doc.Body.Children.Add(new RenderText("CharSpacing: " + cs.ToString()));
            rt = new RenderText();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 30; i++)
                sb.Append(string.Format("Fragment{0} ", i));
            sb.Remove(sb.Length - 1, 1);
            rt.Text = sb.ToString();
            rt.Style.Borders.All = LineDef.Default;
            rt.Style.BackColor = Color.LawnGreen;
            rt.Style.CharSpacing = cs;
            doc.Body.Children.Add(rt);


            cs = "-2pt";
            doc.Body.Children.Add(new RenderText("CharSpacing: " + cs.ToString()));
            rt = new RenderText();
            sb = new StringBuilder();
            for (int i = 0; i < 30; i++)
                sb.Append(string.Format("Fragment{0} ", i));
            sb.Remove(sb.Length - 1, 1);
            rt.Text = sb.ToString();
            rt.Style.Borders.All = LineDef.Default;
            rt.Style.BackColor = Color.LawnGreen;
            rt.Style.CharSpacing = cs;
            doc.Body.Children.Add(rt);

            doc.Generate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateDoc(doc);
        }
    }
}