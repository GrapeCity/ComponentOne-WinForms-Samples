#region Using directives

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

using C1.C1Preview;
using C1.Win.C1Preview;

#endregion

namespace DemoTables
{
    partial class Form1
    {
        private C1.C1Preview.C1PrintDocument makeDoc_TextStyles()
        {
            C1.C1Preview.C1PrintDocument doc = new C1.C1Preview.C1PrintDocument();

            RenderText rtxt = new RenderText(doc);
            rtxt.Text = "Text styles in the new C1PrintDocument";
            rtxt.Style.Font = new Font("Arial", 18, FontStyle.Bold);
            rtxt.Style.TextAlignHorz = AlignHorzEnum.Center;
            rtxt.Style.Padding.All = new Unit("5mm");
            doc.Body.Children.Add(rtxt);

            // setup some text styles
            Style s1 = doc.Style.Children.Add();
            s1.TextColor = Color.Blue;
            s1.Font = new Font(s1.Font, FontStyle.Bold);

            Style s2 = doc.Style.Children.Add();
            s2.BackColor = Color.Chartreuse;

            Style s3 = doc.Style.Children.Add();
            s3.TextColor = Color.Red;

            Style s4 = doc.Style.Children.Add();
            s4.Font = new Font("Arial", 14, FontStyle.Bold | FontStyle.Italic);

            Style s5 = doc.Style.Children.Add();
            s5.BackColor = s2.BackColor;
            s5.TextColor = s3.TextColor;
            s5.Font = s4.Font;


            RenderParagraph rp = new RenderParagraph(doc);

            ParagraphObject po = new ParagraphText("In the new ");
            rp.Content.Add(po);
            po = new ParagraphText("C1PrintDocument");
            po.Style.AssignNonInheritedFrom(s1);
            rp.Content.Add(po);
            po = new ParagraphText(" multi-style text is fully supported. You can change ", TextPositionEnum.Normal);
            rp.Content.Add(po);
            
            po = new ParagraphText("the background color,");
            // po.Style.AssignNonInheritedFrom(s2);
            po.Style.Parent = s2;
            rp.Content.Add(po);

            po = new ParagraphText(" text color,");
            po.Style.AssignNonInheritedFrom(s3);
            rp.Content.Add(po);

            po = new ParagraphText(" font,");
            po.Style.AssignNonInheritedFrom(s4);
            rp.Content.Add(po);

            po = new ParagraphText(" or all together.");
            po.Style.AssignNonInheritedFrom(s5);
            rp.Content.Add(po);

            po = new ParagraphText(" Superscript", TextPositionEnum.Superscript);
            rp.Content.Add(po);

            po = new ParagraphText(" and ");
            rp.Content.Add(po);

            po = new ParagraphText("Subscript", TextPositionEnum.Subscript);
            rp.Content.Add(po);

            po = new ParagraphText(" text can be rendered.");
            rp.Content.Add(po);

            po = new ParagraphText(" Additionally, images ");
            rp.Content.Add(po);
            po = new ParagraphImage(pictureBox2.Image);
            rp.Content.Add(po);
            po = new ParagraphText(" can be embedded in the text as well.");
            rp.Content.Add(po);

            doc.Body.Children.Add(rp);

            return doc;
        }
    }
}