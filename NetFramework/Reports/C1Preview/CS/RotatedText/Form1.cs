using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;

namespace RotatedText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BuildText(RenderText rt, int fragmentCount)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < fragmentCount; i++)
                sb.Append(string.Format("fragment{0} ", i));
            if (sb.Length > 0)
                sb.Remove(sb.Length - 1, 1);

            rt.Text = string.Format("Height = {0}, Width = {1}, TextAngle = {2}\r", rt.Height, rt.Width, rt.Style.TextAngle) + sb.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            doc.Style.Font = new Font("Verdana", 14);

            RenderText rt = new RenderText();
            rt.Style.Borders.All = LineDef.Default;
            rt.Style.TextAngle = 46;
            BuildText(rt, 40);
            doc.Body.Children.Add(rt);

            rt = new RenderText();
            rt.Style.Borders.All = LineDef.Default;
            rt.Style.TextAngle = 229;
            BuildText(rt, 40);
            doc.Body.Children.Add(rt);

            rt = new RenderText();
            rt.Style.Borders.All = LineDef.Default;
            rt.Style.TextAngle = 46;
            BuildText(rt, 10);
            doc.Body.Children.Add(rt);

            rt = new RenderText();
            rt.SplitVertBehavior = SplitBehaviorEnum.SplitIfLarge;
            rt.Height = Unit.Auto;
            rt.Width = Unit.Auto;
            rt.Style.Borders.All = LineDef.Default;
            BuildText(rt, 2);
            rt.Style.TextAngle = 46;
            doc.Body.Children.Add(rt);

            rt = new RenderText();
            rt.SplitVertBehavior = SplitBehaviorEnum.SplitIfLarge;
            rt.Height = Unit.Auto;
            rt.Width = Unit.Auto;
            rt.Style.Borders.All = LineDef.Default;
            rt.Style.TextAngle = 229;
            BuildText(rt, 2);
            doc.Body.Children.Add(rt);

            rt = new RenderText();
            rt.SplitVertBehavior = SplitBehaviorEnum.SplitIfLarge;
            rt.Height = Unit.Auto;
            rt.Width = Unit.Auto;
            rt.Style.Borders.All = LineDef.Default;
            rt.Style.TextAngle = 40;
            BuildText(rt, 2);
            doc.Body.Children.Add(rt);

            rt = new RenderText();
            rt.SplitVertBehavior = SplitBehaviorEnum.SplitIfLarge;
            rt.Height = Unit.Auto;
            rt.Width = Unit.Auto;
            rt.Style.Borders.All = LineDef.Default;
            rt.Style.TextAngle = 190;
            BuildText(rt, 2);
            doc.Body.Children.Add(rt);

            rt = new RenderText();
            rt.SplitVertBehavior = SplitBehaviorEnum.SplitIfLarge;
            rt.Height = "100mm";
            rt.Width = Unit.Auto;
            rt.Style.Borders.All = LineDef.Default;
            rt.Style.TextAngle = 270;
            BuildText(rt, 50);
            doc.Body.Children.Add(rt);

            doc.Generate();
        }
    }
}