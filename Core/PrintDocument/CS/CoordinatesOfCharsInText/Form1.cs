using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;

namespace CoordinatesOfCharsInText
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
            // create the title of document
            RenderParagraph rp = new RenderParagraph();
            rp.Content.AddText("You can get coordinates and sizes of individual characters in a text block using the ");
            rp.Content.AddText("GetCharRect()", Color.Blue);
            rp.Content.AddText(" method of RenderText and RenderParagraph classes.\r\n");
            rp.Content.AddText("In the following example each character has a red rectangle drawn around it.");
            rp.Style.Font = new Font("Verdana", 15);
            rp.Style.Spacing.Bottom = "3mm";
            rp.Style.Borders.Bottom = LineDef.DefaultBold;
            rp.Style.TextAlignHorz = AlignHorzEnum.Justify;
            doc.Body.Children.Add(rp);

            rp = new RenderParagraph();
            rp.Style.Font = new Font("Arial", 36);
            rp.Content.Add(new ParagraphText("Normal text", TextPositionEnum.Normal));
            rp.Content.Add(new ParagraphText("Super script text\r\n", TextPositionEnum.Superscript));
            rp.Content.Add(new ParagraphText("Sub script text\r\n", TextPositionEnum.Subscript));
            rp.Content.Add(new ParagraphText("Normal text. ", TextPositionEnum.Normal));
            rp.Content.Add(new ParagraphText("Sub script. ", TextPositionEnum.Subscript));
            rp.Content.Add(new ParagraphText("Super script. ", TextPositionEnum.Superscript));
            rp.Content.Add(new ParagraphText("Normal text.\r\n"));
            rp.Content.Add(new ParagraphText("Normal text Normal text Normal text Normal text Normal text Normal text Normal text Normal text."));
            doc.Body.Children.Add(rp);

            // To use the GetCharRect method, we must first generate
            // the document so that character positions are calculated.
            // The generation will be later repeated with drawing
            // red rectangles around the individual characters.
            doc.Generate();

            int textLength = rp.TextLength;
            // Fragments contain info about the rendered objects:
            // get the first fragment of rp object
            RenderParagraphFragment rpf = (RenderParagraphFragment)rp.Fragments[0];
            // go over all characters in the text
            for (int i = 0; i < textLength; ++i)
            {
                // get the coordinates of character,
                // they will be returned in C1PrintDocument.ResolvedUnit units
                RectangleD charRect = rpf.GetCharRect(i);

                // make a rectangle around the char
                RenderRectangle r = new RenderRectangle();
                // specify all coordinates of rectangle
                r.X = new Unit(rpf.Bounds.Left + charRect.Left, doc.ResolvedUnit);
                r.Y = new Unit(rpf.Bounds.Top + charRect.Top, doc.ResolvedUnit);
                r.Width = new Unit(charRect.Width, doc.ResolvedUnit);
                r.Height = new Unit(charRect.Height, doc.ResolvedUnit);
                // set shape (rectangle) coordinates, they are specified
                // relative to object
                r.Rectangle.X = 0;
                r.Rectangle.Y = 0;
                r.Rectangle.Width = r.Width;
                r.Rectangle.Height = r.Height;
                r.Style.ShapeLine = new LineDef("1pt", Color.Red);
                // add the rectangle to the object
                doc.Body.Children.Add(r);
            }
        }
    }
}