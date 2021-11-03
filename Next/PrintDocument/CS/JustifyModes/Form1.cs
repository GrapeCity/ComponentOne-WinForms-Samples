using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;

namespace JustifyModes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doc.Style.Font = new Font("Verdana", 18);

            RenderText rt;

            rt = new RenderText();
            rt.Text = "New mode of text justification was added: AlignHorzEnum.JustifyChars\r\rJustifies text horizontally, adding white space between all characters.";
            rt.Style.Spacing.Bottom = "5mm";
            rt.Style.BackColor = Color.LightBlue;
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



            rt = new RenderText();
            rt.BreakBefore = BreakEnum.Page;
            rt.Text = "New style property was added:\r Unit CharSpacing { get; set; }\r\rGets or sets the value determining the spacing between text characters. The default value is 0.";
            rt.Style.Spacing.Bottom = "5mm";
            rt.Style.BackColor = Color.LightBlue;
            doc.Body.Children.Add(rt);

            Unit cs = "2mm";
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



            rt = new RenderText();
            rt.BreakBefore = BreakEnum.Page;
            rt.Text = "New style property was added:\r float CharWidth { get; set; }\r\rGets or sets the amount (in percent) by which to increase or decrease the widths of text characters. The default value is 100.";
            rt.Style.Spacing.Bottom = "5mm";
            rt.Style.BackColor = Color.LightBlue;
            doc.Body.Children.Add(rt);

            float cw = 200;
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
    }
}