using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;
using C1.Win.C1Preview;

namespace Hyperlinks
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
            // setup a page header with links to first|prev|next|last pages:
            RenderTable rtnav = new RenderTable();
            // suppress different display of visited hyperlinks for page navigator:
            rtnav.Style.VisitedHyperlinkAttrs = rtnav.Style.HyperlinkAttrs;
            // space things out
            rtnav.Style.Spacing.Bottom = "5mm";
            // add navigator links
            rtnav.Cells[0, 0].Text = "First page";
            rtnav.Cells[0, 0].RenderObject.Hyperlink = new C1Hyperlink(
                new C1LinkTargetPage(PageJumpTypeEnum.First), "Go to first page");
            rtnav.Cells[0, 1].Text = "Previous page";
            rtnav.Cells[0, 1].RenderObject.Hyperlink = new C1Hyperlink(
                new C1LinkTargetPage(PageJumpTypeEnum.Previous), "Go to previous page");
            rtnav.Cells[0, 2].Text = "Next page";
            rtnav.Cells[0, 2].RenderObject.Hyperlink = new C1Hyperlink(
                new C1LinkTargetPage(PageJumpTypeEnum.Next), "Go to next page");
            rtnav.Cells[0, 3].Text = "Last page";
            rtnav.Cells[0, 3].RenderObject.Hyperlink = new C1Hyperlink(
                new C1LinkTargetPage(PageJumpTypeEnum.Last), "Go to last page");
            doc.PageLayout.PageHeader = rtnav;

            // make the body of the document

            // make an anchor
            RenderText rt1 = new RenderText("This is text with anchor1.");
            // the name ("anchor1") will be used to jump to this link:
            rt1.Anchors.Add(new C1Anchor("anchor1"));
            rt1.Hyperlink = new C1Hyperlink(new C1LinkTargetPage(PageJumpTypeEnum.Last),
                "Go to the last page of the document");
            doc.Body.Children.Add(rt1);

            //--------------------------------------------------------------------
            // make an external document to jump to:
            C1PrintDocument doc2 = new C1PrintDocument();
            RenderText doc2rt = new RenderText("This is Document 2.");
            doc2rt.Style.Spacing.All = "3mm";
            doc2rt.Style.Font = new Font("Arial", 14);
            // anchor names must be unique within the document but not across documents
            doc2rt.Anchors.Add(new C1Anchor("anchor1"));
            doc2.Body.Children.Add(doc2rt);
            // make a button in the new document to go back
            RenderInputButton doc2btn = new RenderInputButton("Go back...");
            doc2btn.Width = "3cm";
            doc2btn.Height = "1cm";
            doc2btn.InputActions.Add(UserActionEnum.Click, new ActionHandlerHistoryPrev());
            doc2.Body.Children.Add(doc2btn);
            doc2.Generate();
            // save the document in our run dir:
            string doc2path = Application.StartupPath + @"\doc2.c1d";
            doc2.Save(doc2path);
            //--------------------------------------------------------------------

            // add a link to open doc2:
            RenderText rt2 = new RenderText("Click here to open Document 2.");
            rt2.Hyperlink = new C1Hyperlink(
                new C1LinkTargetExternalAnchor(doc2path, "anchor1"));
            doc.Body.Children.Add(rt2);

            // add filler
            for (int i = 0; i < 500; ++i)
                doc.Body.Children.Add(new RenderText(string.Format("... filler {0} ...", i)));

            // add hyperlink to anchor1
            RenderText rt3 = new RenderText("Click here to go to anchor1.");
            rt3.Hyperlink = new C1Hyperlink(new C1LinkTargetAnchor("anchor1"),
                "This is status text when the mouse hovers over link to anchor1");
            doc.Body.Children.Add(rt3);

            // to jump to a render object, an anchor is really not needed:
            RenderText rt4 = new RenderText("Click here to go to the middle of document.");
            rt4.Hyperlink = new C1Hyperlink(doc.Body.Children[doc.Body.Children.Count / 2]);
            rt4.Hyperlink.StatusText = "Go to the approximate middle of the document";
            doc.Body.Children.Add(rt4);

            // add image with hyperlink to a URL
            RenderImage ri1 = new RenderImage(global::Hyperlinks.Properties.Resources.google);
            ri1.Hyperlink = new C1Hyperlink(new C1LinkTargetFile("http://www.google.com"),
                "Go googling...");
            doc.Body.Children.Add(ri1);
        }
    }
}