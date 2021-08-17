using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;

namespace PageLayout2
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
            doc.Style.Font = new Font("Tahoma", 15);

            // create the top-level page header for the document
            RenderText rt = new RenderText();
            rt.Text = "Header. Page [PageNo] of [PageCount]";
            rt.Style.Borders.Bottom = LineDef.DefaultBold;
            rt.Style.Spacing.Bottom = "2mm";
            doc.PageLayout.PageHeader = rt;

            // create the top-level page footer for the document
            rt = new RenderText();
            rt.Text = "Footer. Page [PageNo] of [PageCount]";
            rt.Style.Borders.Top = LineDef.DefaultBold;
            rt.Style.Spacing.Top = "2mm";
            doc.PageLayout.PageFooter = rt;

            // add content (text describing this sample) to the document body
            doc.Body.Children.Add(new RenderText(doc,
                "The following object starts with a page break, and changes the page layout. " +
                "The change is nested so the original (current) page layout will be automatically " +
                " restored when the nested object ends."));

            // create the object that changes the page layout
            RenderText content = new RenderText();
            content.Style.TextAlignHorz = AlignHorzEnum.Justify;
            // add dummy text to fill the document
            content.Text = text + text + text + text + text;

            // create the object describing the nested layout.
            // Several types based on LayoutChangeBase are provided,
            // for layouts starting with page/column breaks or no breaks.
            LayoutChangeNewPage lcnp = new LayoutChangeNewPage();
            // Set the LayoutChangeNewPage to the LayoutChangeBefore property
            // of the "content" object:
            content.LayoutChangeBefore = lcnp;

            // setup the properties of the LayoutChangeNewPage. In particular,
            // set Nested to true, it forces restoring of the previous page layout when
            // the object is over
            lcnp.Nested = true;
            // create new page layout on the "layout change" object:
            lcnp.PageLayout = new PageLayout();
            // force landscape
            lcnp.PageLayout.PageSettings = new C1PageSettings();
            lcnp.PageLayout.PageSettings.Landscape = true;
            // add page columns
            lcnp.PageLayout.Columns.Add();
            lcnp.PageLayout.Columns.Add();
            // create the (nested) page header
            rt = new RenderText();
            rt.Text = "This is page header of the nested object.\r\nPage [PageNo] of [PageCount]";
            rt.Style.BackColor = Color.Cornsilk;
            rt.Style.Borders.Bottom = LineDef.DefaultBold;
            rt.Style.Spacing.Bottom = "2mm";
            lcnp.PageLayout.PageHeader = rt;
            // create the (nested) page header
            rt = new RenderText();
            rt.Text = "This is page footer of the nested object.\r\nPage [PageNo] of [PageCount]";
            rt.Style.BackColor = Color.Cornsilk;
            rt.Style.Borders.Top = LineDef.DefaultBold;
            rt.Style.Spacing.Top = "2mm";
            lcnp.PageLayout.PageFooter = rt;

            // add content to the document
            doc.Body.Children.Add(content);

            // add text *after* the "content" object, to demonstrate
            // that the top-level page layout is automatically restored:
            doc.Body.Children.Add(new RenderText(doc,
                "This is the object AFTER the content object with the nested page layout."));
        }

        const string text = "This is the house  that Jack  built.  " +
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
    }
}