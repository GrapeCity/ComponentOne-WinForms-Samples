using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;

namespace HyperlinkPageNo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateDoc(C1PrintDocument doc)
        {
            doc.Clear();

            doc.PageLayout.PageSettings.Landscape = true;

            Style codeStyle = doc.Style.Children.Add();
            codeStyle.Font = new Font("Courier New", 12);
            Style captionStyle = doc.Style.Children.Add();
            captionStyle.Font = new Font("Tahoma", 18, FontStyle.Bold);

            RenderParagraph rp = new RenderParagraph();
            rp.Style.Borders.All = new LineDef("1mm", Color.Blue);
            rp.Style.BackColor = Color.LightBlue;
            rp.Style.Font = new Font("Tahoma", 16);
            rp.Content.Add(new ParagraphText("This sample demostrates using of HyperlinkPageNo tag\r\r", captionStyle));
            rp.Content.Add(new ParagraphText("It returns number of page that hyperlink points. For example:\r\r"));
            rp.Content.Add(new ParagraphText("rt = new RenderText();\r", codeStyle));
            rp.Content.Add(new ParagraphText("rt.Text = \"(C1LinkTargetDocumentLocation) Goto page: [HyperlinkPageNo]\";\r", codeStyle));
            rp.Content.Add(new ParagraphText("rt.Hyperlink = new C1Hyperlink(new C1LinkTargetDocumentLocation(rt2));\r", codeStyle));
            rp.Content.Add(new ParagraphText("rt.Style.Borders.All = LineDef.Default;\r", codeStyle));
            rp.Content.Add(new ParagraphText("doc.Body.Children.Add(rt);", codeStyle));
            rp.Content.Add(new ParagraphText("\r\rTag HyperlinkPageNo will be replaced with number of page where object rt2 is.\r"));
            rp.Content.Add(new ParagraphText("It must be taken into consideration that when the document is being resolved, it is not always possible to evaluate HyperlinkPageNo (e.g. if it references an object that has not been resolved yet). "));
            rp.Content.Add(new ParagraphText("In such cases, if the object contains many HyperlinkPageNo tags and has auto width and/or height, the calculated size may differ from the correct size as instead of actual page numbers, the string \"XXX\" is used for size calculation.\r"));
            rp.Content.Add(new ParagraphText("To minimize such errors::\r"));
            rp.Content.Add(new ParagraphText("- use absolute sizes for such objets;\r"));
            rp.Content.Add(new ParagraphText("- place hyperlinks after the objects they reference.\r\r"));
            rp.Content.Add(new ParagraphText("In this sample, the document contains two RenderParagraph objects, each of which has HyperlinkPageNo tags. "));
            rp.Content.Add(new ParagraphText("The first paragraph is placed before the table, and hence its size is slightly bigger. The other paragraph follows the table and hence its size is exactly right."));
            doc.Body.Children.Add(rp);

            doc.Style.Font = new Font("Tahoma", 16);

            // generate siple table (3 x 100)
            RenderTable rt = new RenderTable();
            for (int r = 0; r < 100; r++)
                for (int c = 0; c < 3; c++)
                {
                    rt.Cells[r, c].Text = string.Format("Cell {0}:{1}", r, c);
                }
            rt.Style.GridLines.All = LineDef.DefaultBold;

            // generate RenderParagraph with hyperlinks
            rp = new RenderParagraph();
            rp.Style.Borders.All = new LineDef("1mm", Color.Red);
            rp.Style.Spacing.All = "5mm";
            rp.Style.Padding.All = "1mm";
            rp.RepeatBordersVert = true;
            rp.Content.Add(new ParagraphText("Content:\r\r", new Font("Verdana", 20)));
            for (int r = 0; r < rt.Rows.Count; r++)
            {
                ParagraphText pt = new ParagraphText(string.Format("Row{0} ([HyperlinkPageNo])", r));
                pt.Hyperlink = new C1Hyperlink(new C1LinkTargetDocumentLocation(rt.Cells[r, 0]));
                rp.Content.Add(pt);
                if (r < rt.Rows.Count - 1)
                    rp.Content.Add(new ParagraphText(", "));
            }
            // add paragraph into document BEFORE table
            doc.Body.Children.Add(rp);
            // add table
            doc.Body.Children.Add(rt);

            // add paragraph into document AFTER table
            RenderParagraph rp2 = (RenderParagraph)rp.Clone();
            doc.Body.Children.Add(rp2);

            doc.Generate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateDoc(doc);
        }
    }
}