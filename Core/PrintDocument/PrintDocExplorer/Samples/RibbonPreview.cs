using C1.C1Preview;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrintDocExplorer.Samples
{
    public partial class RibbonPreview : UserControl
    {
        public RibbonPreview()
        {
            InitializeComponent();
        }

        private void RibbonPreview_Load(object sender, EventArgs e)
        {
            MakeDoc1(c1PrintDocument1);
            c1PrintDocument1.Reflow();

        }

        /// <summary>
        /// Creates a document where almost all RenderObject types provided by C1Preview
        /// are used/demonstrated.
        /// </summary>
        /// <param name="doc">The document to add render objects to.</param>
        private void MakeDoc1(C1PrintDocument doc)
        {
            // clear the document
            doc.Clear();

            // Set up basic page headers and footers:
            doc.PageLayout.PageHeader = new RenderText("RibbonPreview sample");
            doc.PageLayout.PageHeader.Style.TextAlignHorz = AlignHorzEnum.Right;
            doc.PageLayout.PageHeader.Style.Spacing.Bottom = "0.5cm";
            doc.PageLayout.PageHeader.Style.Borders.Bottom = LineDef.Default;

            doc.PageLayout.PageFooter = new RenderText("Page [PageNo] of [PageCount]");
            doc.PageLayout.PageFooter.Style.TextAlignHorz = AlignHorzEnum.Right;
            doc.PageLayout.PageFooter.Style.Spacing.Top = "0.5cm";
            doc.PageLayout.PageFooter.Style.Borders.Top = LineDef.Default;


            //-------------
            // RenderArea
            //-------------
            // The general purpose container for other render objects
            // We create an area for a few RenderText objects,
            // and add it to another are which is a container for all elements in the document:
            RenderArea ra1 = new RenderArea();

            RenderArea ra2 = new RenderArea();
            // set the back color for the area so its bounds are visible
            ra2.Style.BackColor = Color.AntiqueWhite;
            // keep the area to 60% of its parent's width
            ra2.Width = "60%";

            // Add the area which will hold the render texts, to
            // the bigger area which will hold all else
            ra1.Children.Add(ra2);

            //-------------
            // RenderText
            //-------------
            // Allows to output a block of text in a single style
            // we also create an outline entry for each RenderText

            // plain text using the default style
            RenderText rt1 = new RenderText(strings.APOLOGIZE);
            doc.Outlines.Add("APOLOGIZE", rt1);

            // different font and color
            RenderText rt2 = new RenderText(strings.APPEAL, new Font("Arial", 16), Color.BlueViolet);
            doc.Outlines.Add("APPEAL", rt2);

            // right-alignged text
            RenderText rt3 = new RenderText(strings.BAROMETER, AlignHorzEnum.Right);
            doc.Outlines.Add("BAROMETER", rt3);

            // justified text in a different font
            RenderText rt4 = new RenderText(strings.BOTANY, new Font("Times New Roman", 14), AlignHorzEnum.Justify);
            doc.Outlines.Add("BOTANY", rt4);

            // text with a different style
            // styles can only exist on an object or as child styles of another style
            Style s1 = doc.Style.Children.Add();
            s1.BackColor = Color.Chartreuse;
            s1.Padding.All = new Unit("3mm");
            s1.LineSpacing = 120;
            RenderText rt5 = new RenderText(strings.CALAMITY, s1);
            doc.Outlines.Add("CALAMITY", rt5);

            // add RenderText's to the nested area
            ra2.Children.Add(rt1);
            ra2.Children.Add(rt2);
            ra2.Children.Add(rt3);
            ra2.Children.Add(rt4);
            ra2.Children.Add(rt5);

            //---------------
            // RenderGraphics
            //---------------
            // Allows to insert arbitrary GDI+ drawings in the document
            // Note that RenderGraphics' size is by default automatically adjusted
            // to the actual size of the drawing.
            RenderGraphics rg1 = new RenderGraphics();
            rg1.Graphics.DrawArc(Pens.Red,
                new Rectangle(0, 0, 30, 40), 0, 135);
            rg1.Graphics.DrawEllipse(Pens.Blue, new Rectangle(20, 20, 90, 45));
            rg1.Style.Borders.All = new LineDef("1mm", Color.CornflowerBlue);
            ra1.Children.Add(rg1);
            // provide an outline entry for the RenderGraphics
            doc.Outlines.Add("RenderGraphics", rg1);

            //-------------
            // RenderEmpty
            //-------------
            // Allows to insert breaks in arbitrary locations w/out affecting other render objects
            RenderEmpty re1 = new RenderEmpty();
            re1.BreakAfter = BreakEnum.Column;
            ra1.Children.Add(re1);

            //---------------
            // RenderImage
            //---------------
            // Allows to insert images in the document. Again, by default the size
            // is determined by the size of the image
            RenderImage ri1 = new RenderImage(Image.FromStream(
                GetType().Assembly.GetManifestResourceStream("PrintDocExplorer.Data.tn_img70.jpg")));
            ra1.Children.Add(ri1);
            doc.Outlines.Add("RenderImage", ri1);

            //---------------
            // RenderRichText
            //---------------
            // Allows to insert RTF in the document
            TextReader tr = new StreamReader(
                GetType().Assembly.GetManifestResourceStream("PrintDocExplorer.Data.Rich_Text_Format.rtf"));
            RenderRichText rrt1 = new RenderRichText(tr.ReadToEnd());
            tr.Close();
            ra1.Children.Add(rrt1);
            doc.Outlines.Add("RenderRichText", rrt1);

            //--------------
            // RenderPolygon
            //--------------
            // A bunch of classes derived from RenderShapeBase provide shapes - 
            // lines, polygons and rectangles. Here we draw a polygon:
            RenderPolygon rpoly1 = new RenderPolygon();
            rpoly1.Line.Points = new UnitPoint[] {
                new UnitPoint("0.5cm", "0.5cm"),
                new UnitPoint("2.0cm", "1cm"),
                new UnitPoint("3.5cm", "0cm"),
                new UnitPoint("6cm", "4cm"),
                new UnitPoint("3cm", "5cm")
            };
            rpoly1.Line.Closed = true;
            // set the fill color
            rpoly1.Style.ShapeFillColor = Color.Gainsboro;
            // pad on all sides, otherwise corners may end up outside of the
            // RenderPolygon area and get clipped:
            rpoly1.Style.Padding.All = "0.5cm";
            rpoly1.Style.BackColor = Color.Cornsilk;
            ra1.Children.Add(rpoly1);
            doc.Outlines.Add("RenderPolygon", rpoly1);

            //------------
            // RenderTable
            //------------
            // Allows to draw tables. Tables are very powerful and can be used
            // both for data presentation and as layout tools. Here we show
            // some very basic tables functionality:
            RenderTable rtbl1 = new RenderTable();
            // tables are logically infinte, just touching a cell creates it:
            for (int row = 0; row < 100; ++row)
                for (int col = 0; col < 4; ++col)
                    rtbl1.Cells[row, col].Text = string.Format("Cell ({0}, {1})", row, col);
            // column (see below, in headers) and row spans are supported,
            // as alignment within cells, borders around cells and more:
            rtbl1.Cells[8, 1].SpanRows = 6;
            rtbl1.Cells[8, 1].Style.BackColor = Color.Gold;
            rtbl1.Cells[8, 1].Style.TextAlignVert = AlignVertEnum.Center;
            rtbl1.Cells[8, 1].Style.TextAlignHorz = AlignHorzEnum.Center;
            rtbl1.Cells[8, 1].Style.Borders.All = LineDef.DefaultBold;

            // table header is just a flag on some rows:
            rtbl1.Rows.Insert(0, 1);
            rtbl1.RowGroups[0, 1].PageHeader = true;
            rtbl1.Cells[0, 0].SpanCols = rtbl1.Cols.Count;
            rtbl1.Cells[0, 0].Text = "This is table header";
            rtbl1.Cells[0, 0].Style.TextAlignHorz = AlignHorzEnum.Center;
            rtbl1.Cells[0, 0].Style.BackColor = Color.LemonChiffon;
            // ditto for the table footer:
            // (again, just touching a row adds it):
            int n = rtbl1.Rows.Count;
            rtbl1.RowGroups[n, 1].PageFooter = true;
            rtbl1.Cells[n, 0].SpanCols = rtbl1.Cols.Count;
            rtbl1.Cells[n, 0].Text = "This is table footer";
            rtbl1.Cells[n, 0].Style.TextAlignHorz = AlignHorzEnum.Center;
            rtbl1.Cells[n, 0].Style.BackColor = Color.LemonChiffon;
            // by default, tables have no grid lines. add some:
            rtbl1.Style.GridLines.All = LineDef.Default;

            // Using RenderEmpty, we can add outline nodes to start and end of table:
            RenderEmpty rtbl1Beg = new RenderEmpty();
            RenderEmpty rtbl1End = new RenderEmpty();
            ra1.Children.Add(rtbl1Beg);
            ra1.Children.Add(rtbl1);
            ra1.Children.Add(rtbl1End);
            doc.Outlines.Add("Table - first row", rtbl1Beg);
            doc.Outlines.Add("Table - last row", rtbl1End);

            //---------------
            // RenderParagraph
            //---------------
            // Allows to render milti-line text, inline images, and hyperlinks within text
            // Create paragraph
            RenderParagraph rpar1 = new RenderParagraph();
            Font f = new Font(rpar1.Style.Font, FontStyle.Bold);
            rpar1.Content.AddText("This is a paragraph. This is normal text. ");
            rpar1.Content.AddText("This text is bold. ", f);
            rpar1.Content.AddText("This text is red. ", Color.Red);
            rpar1.Content.AddText("This text is superscript. ",
                TextPositionEnum.Superscript);
            rpar1.Content.AddText("This text is bold and red. ", f, Color.Red);
            rpar1.Content.AddText("This text is bold and red and subscript. ",
                f, Color.Red, TextPositionEnum.Subscript);
            rpar1.Content.AddText("This is normal text again. ");
            rpar1.Content.AddHyperlink(
                "This is a link to the start of the document.",
                ra1);
            rpar1.Content.AddText("Finally, here is an inline image: ");
            rpar1.Content.AddImage(SystemIcons.Shield.ToBitmap());
            rpar1.Content.AddText(".");
            // Add paragraph to the area
            ra1.Children.Add(rpar1);
            // and an outline entry to point to it:
            doc.Outlines.Add("RenderParagraph", rpar1);

            // we're done. Add the outer RenderArea to the document:
            doc.Body.Children.Add(ra1);
        }

    }
}
