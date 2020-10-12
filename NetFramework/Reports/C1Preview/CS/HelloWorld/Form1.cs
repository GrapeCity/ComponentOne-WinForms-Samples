using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using C1.C1Preview;

namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            c1PrintDocument1.Body.Children.Add(new C1.C1Preview.RenderText("Hello, World!"));

#if skip_this // Uncomment code below to generate a fancier "hello world" string:
            c1PrintDocument1.Body.Children.Clear();
            RenderText rt = new RenderText("Hello, World!");
            rt.X = "2in";
            rt.Y = "3in";
            rt.Width = "4in";
            rt.Height = "3in";
            rt.Style.Borders.All = LineDef.Default;
            rt.Style.FontName = "Arial";
            rt.Style.FontSize = 14;
            rt.Style.TextColor = Color.Red;
            rt.Style.BackColor = Color.PowderBlue;
            rt.Style.TextAlignHorz = AlignHorzEnum.Center;
            rt.Style.TextAlignVert = AlignVertEnum.Center;
            c1PrintDocument1.Body.Children.Add(rt);
#endif

            c1PrintDocument1.Generate();
        }
    }
}