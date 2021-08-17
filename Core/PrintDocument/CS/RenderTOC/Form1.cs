using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;

namespace RenderTOC
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
            // create the document title
            RenderParagraph docTitle = new RenderParagraph();
            docTitle.Content.AddText("This document demonstates the use of ");
            docTitle.Content.AddText("RenderToc", Color.Blue);
            docTitle.Content.AddText(" object to create the table of content.");
            doc.Body.Children.Add(docTitle);

            // in this cycle we generate the document chapters, each chapter
            // has some parts, each chapter and part has an entry in the RenderToc object
            const int chapterCount = 10; // chapter count
            const int partCount = 5;     // parts count

            // generate sample text that will serve as introduction to chapter
            StringBuilder chapterIntroduction = new StringBuilder("Introduction");
            for (int i = 0; i < 40; i++)
                chapterIntroduction.Append(" introduction");
            chapterIntroduction.Append(".\r\n");

            // generate sample text that will be displayed as content of part of chapter
            StringBuilder partContent = new StringBuilder("Content of part");
            for (int i = 0; i < 80; i++)
                partContent.Append(" content of part");
            partContent.Append(".\r\n");

            // create an instance of RenderToc object
            RenderToc toc = new RenderToc();
            toc.BreakAfter = BreakEnum.Page;

            // Create styles for chaprters and parts
            Style chapterTitleStyle = doc.Style.Children.Add();
            chapterTitleStyle.Font = new Font("Verdana", 15, FontStyle.Bold);
            chapterTitleStyle.BackColor = Color.LightSteelBlue;
            chapterTitleStyle.Spacing.Bottom = "5mm";
            Style partTitleStyle = doc.Style.Children.Add();
            partTitleStyle.Font = new Font("Tahoma", 13);
            partTitleStyle.Spacing.Top = "3mm";
            partTitleStyle.Spacing.Bottom = "1mm";

            // loop over chapters
            for (int c = 1; c < chapterCount; c++)
            {
                // each chapter will be represented as a RenderArea object
                RenderArea chapter = new RenderArea();
                if (c < chapterCount - 1)
                    chapter.BreakAfter = BreakEnum.Page;

                RenderText chapterTitle = new RenderText(string.Format("Chapter {0}", c), chapterTitleStyle);
                chapter.Children.Add(chapterTitle);
                chapter.Children.Add(new RenderText(chapterIntroduction.ToString(), AlignHorzEnum.Justify));

                // add item for the chapter to the RenderToc
                toc.AddItem(chapterTitle.Text, chapterTitle, 1);

                // loop over the current chapter's parts
                for (int p = 1; p < partCount; p++)
                {
                    RenderText partTitle = new RenderText(string.Format("Chapter {0} part {1}", c, p), partTitleStyle);
                    chapter.Children.Add(partTitle);
                    chapter.Children.Add(new RenderText(partContent.ToString(), AlignHorzEnum.Justify));

                    // add item for the chapter part to the RenderToc
                    toc.AddItem(string.Format("Part {0}", p), partTitle, 2);
                }

                // add the chapter to the document
                doc.Body.Children.Add(chapter);
            }

            // insert the RenderToc into the document immediatedly after the title
            doc.Body.Children.Insert(1, toc);
        }
    }
}
