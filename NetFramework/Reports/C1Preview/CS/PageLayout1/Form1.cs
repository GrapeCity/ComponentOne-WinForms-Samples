using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

using C1.C1Preview;

namespace PageLayout1
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
            doc.Style.Font = new Font("Verdana", 14);

            // create the title of the document
            RenderParagraph title = new RenderParagraph();
            title.Content.AddText("The new version of C1PrintDocumet provides the ");
            title.Content.AddText("PageLayouts", Color.Blue);
            title.Content.AddText(" property allowing to define separate page layouts for the first page, even pages, and odd pages.");
            title.Style.TextAlignHorz = AlignHorzEnum.Justify;
            title.Style.Borders.Bottom = new LineDef("1mm", Color.Black);
            doc.Body.Children.Add(title);

            // define PageLayout for the first page
            PageLayout pl = new PageLayout();
            pl.PageSettings = new C1PageSettings();
            pl.PageSettings.PaperKind = PaperKind.Legal;
            doc.PageLayouts.FirstPage = pl;

            // define PageLayout for even pages
            pl = new PageLayout();
            pl.PageSettings = new C1PageSettings();
            pl.PageSettings.PaperKind = PaperKind.Letter;
            // create the page header
            RenderText ph = new RenderText();
            ph.Text = "Even page. [PageNo] / [PageCount]";
            ph.Style.Borders.All = LineDef.Default;
            ph.Style.BackColor = Color.Beige;
            pl.PageHeader = ph;
            // even pages will have no page footer, set it to an empty object
            pl.PageFooter = new RenderEmpty();
            doc.PageLayouts.EvenPages = pl;

            // define PageLayout for odd pages
            pl = new PageLayout();
            // odd pages will have 2 columns
            pl.Columns.Add();
            pl.Columns.Add();
            pl.PageSettings = new C1PageSettings();
            pl.PageSettings.PaperKind = PaperKind.Letter;
            pl.PageSettings.Landscape = true;
            // create the page header
            ph = new RenderText();
            ph.Text = "Odd page. [PageNo] / [PageCount]";
            ph.Style.Borders.All = LineDef.DefaultBold;
            ph.Style.BackColor = Color.LightSeaGreen;
            pl.PageHeader = ph;
            // create the page footer
            RenderText pf = new RenderText();
            pf.Text = "Footer of odd page. [PageNo] / [PageCount]";
            pf.Style.Borders.All = LineDef.DefaultBold;
            pf.Style.BackColor = Color.SlateGray;
            pl.PageFooter = pf;
            doc.PageLayouts.OddPages = pl;

            // generate the content of document
            RenderText ro = new RenderText("This is the first page of the document. It has no page header or footer, and has Legal size.");
            ro.BreakAfter = BreakEnum.Page;
            doc.Body.Children.Add(ro);

            // 
            string text = "This is the house  that Jack  built.  " +
        "This is the carrot,  " +
        "That lay in the house  that Jack  built.  " +
        "This is the rat,  " +
        "That ate the carrot,  " +
        "That lay in the house  that Jack  built.  " +
        "This is the cat,  " +
        "That chased the rat , that ate the carrot,  " +
        "That lay in the house  that Jack  built.  " +
        "This is the dog  that worried the cat,  " +
        "That chased the rat , that ate the carrot,  " +
        "That lay in the house  that Jack  built.  " +
        "This is the cow  with the crumbled horn, " +
        "That tossed the dog , that worried the cat,  " +
        "That chased the rat , that ate the carrot,  " +
        "That lay in the house  that Jack  built.  " +
        "This is the maiden  all forlorn,  " +
        "That milked  the cow  with the crumbled horn, " +
        "That tossed the dog , that worried the cat,  " +
        "That chased the rat , that ate the carrot,  " +
        "That lay in the house  that Jack  built.   " +
        "This is the man  all tattered and torn, " +
        "That kissed  the maiden  all forlorn,  " +
        "That milked  the cow  with the crumbled horn, " +
        "That tossed the dog , that worried the cat,  " +
        "That chased the rat , that ate the carrot,  " +
        "That lay in the house  that Jack  built.  " +
        "This is the priest  all shaven and shorn, " +
        "That married the man  all tattered and torn, " +
        "That kissed  the maiden  all forlorn,  " +
        "That milked  the cow  with the crumbled horn, " +
        "That tossed the dog , that worried the cat,  " +
        "That chased the rat , that ate the carrot,  " +
        "That lay in the house  that Jack  built.  " +
        "This is the cock  that crowed  in the morn,  " +
        "That waked the priest  all shaven and shorn, " +
        "That married the man  all tattered and torn, " +
        "That kissed  the maiden  all forlorn,  " +
        "That milked  the cow  with the crumbled horn, " +
        "That tossed the dog , that worried the cat,  " +
        "That chased the rat , that ate the carrot,  " +
        "That lay in the house  that Jack  built.  " +
        "This is the farmer  sowing the corn,   " +
        "That kept the cock  that crowed  in the morn,   " +
        "That waked the priest  all shaven and shorn, " +
        "That married the man  all tattered and torn, " +
        "That kissed  the maiden  all forlorn,  " +
        "That milked  the cow  with the crumbled horn, " +
        "That tossed the dog , that worried the cat,  " +
        "That chased the rat , that ate the carrot,  " +
        "That lay in the house  that Jack  built.  ";

            for (int i = 0; i < 5; ++i)
                doc.Body.Children.Add(new RenderText(text, AlignHorzEnum.Justify));
        }
    }
}
