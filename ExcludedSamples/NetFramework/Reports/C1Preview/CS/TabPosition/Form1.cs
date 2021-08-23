using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;

namespace TabPosition
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
            c1PrintDocument1.Generate();
        }

        private void MakeDoc1(C1PrintDocument doc)
        {
            doc.Style.Font = new Font("Tahoma", 16);

            RenderText rt = new RenderText();
            rt.Text =
                "The RenderText and RenderParagraph objects provide the TabPositions property " +
                "that allows to define the positions of tabs in the text. " +
                "This property works similar to tabs in MS Word. " +
                "The following text has 2 tab positions: in the middle of the page, and " +
                "at the right edge of the page.";
            rt.Style.Borders.Bottom = LineDef.DefaultBold;
            rt.Style.Spacing.Bottom = "3mm";
            rt.Style.TextAlignHorz = AlignHorzEnum.Justify;
            doc.Body.Children.Add(rt);

            RenderParagraph rp = new RenderParagraph();
            // add the tab in the middle of object
            rp.TabPositions.Add(new C1.C1Preview.TabPosition("width / 2", TabAlignmentEnum.Center));
            // add the tab at the right edge of object
            rp.TabPositions.Add(new C1.C1Preview.TabPosition("width", TabAlignmentEnum.Right));
            for (int i = 0; i < 3; i++)
            {
                rp.Content.AddText("left text", Color.Red);
                rp.Content.AddText("\t");
                rp.Content.AddText("center text", Color.Green);
                rp.Content.AddText("\t");
                rp.Content.AddText("right text", Color.Blue);
                // forces a new line
                rp.Content.AddText("\r");
            }

            doc.Body.Children.Add(rp);
        }
    }
}