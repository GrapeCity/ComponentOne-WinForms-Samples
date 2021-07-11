using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;

namespace Feature_RenderTextJustifyChars
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
            rt.Text = "New mode of horizontal text alignment: AlignHorzEnum.JustifyChars.\rSpaces added between all chars rather than only between words as is the case with AlignHorzEnum.Justify.";
            rt.Style.Borders.All = new LineDef("1mm", Color.Red);
            rt.Style.Spacing.Bottom = "10mm";
            doc.Body.Children.Add(rt);

            doc.Body.Children.Add(new RenderText("AlignHorzEnum.JustifyChars:"));
            rt = new RenderText();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 30; i++)
                sb.Append(string.Format("Fragment{0} ", i));
            sb.Remove(sb.Length - 1, 1);
            rt.Text = sb.ToString();
            rt.Style.Borders.All = LineDef.Default;
            rt.Style.BackColor = Color.LawnGreen;
            rt.Style.TextAlignHorz = AlignHorzEnum.JustifyChars;
            doc.Body.Children.Add(rt);


            doc.Body.Children.Add(new RenderText("AlignHorzEnum.Justify:"));
            rt = new RenderText();
            sb = new StringBuilder();
            for (int i = 0; i < 30; i++)
                sb.Append(string.Format("Fragment{0} ", i));
            sb.Remove(sb.Length - 1, 1);
            rt.Text = sb.ToString();
            rt.Style.Borders.All = LineDef.Default;
            rt.Style.BackColor = Color.LawnGreen;
            rt.Style.TextAlignHorz = AlignHorzEnum.Justify;
            doc.Body.Children.Add(rt);


            doc.Generate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateDoc(doc);
        }
    }
}