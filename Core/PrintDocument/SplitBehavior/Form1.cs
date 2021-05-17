using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;
using C1.Win.C1Preview;

namespace SplitBehavior
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // create "welcome" document

            //RenderTable rt = new RenderTable();
            //rt.Height = "parent.height";
            //rt.RowSizingMode = TableSizingModeEnum.Fixed;
            //rt.Cells[0, 0].RenderObject = CreateButton("Demo1");
            //rt.Cells[0, 1].RenderObject = CreateDesc("Using the SplitBehaviorEnum.SplitIfLarge vertical splitting mode on top level objects.");
            //rt.Cells[1, 0].RenderObject = CreateButton("Demo2");
            //rt.Cells[1, 1].RenderObject = CreateDesc("Using the SplitBehaviorEnum.SplitIfLarge vertical splitting mode on child objects within a RenderArea.");
            //rt.Cells[2, 0].RenderObject = CreateButton("Demo3");
            //rt.Cells[2, 1].RenderObject = CreateDesc("Using the SplitBehaviorEnum.SplitIfLarge horizontal splitting mode.");
            //rt.Cells[3, 0].RenderObject = CreateButton("Demo4");
            //rt.Cells[3, 1].RenderObject = CreateDesc("Using the SplitBehaviorEnum.SplitIfLarge vertical splitting mode within a RenderTable.");
            //doc.Body.Children.Add(rt);
            //doc.Generate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doc.Clear();

            doc.Style.Font = new Font("Tahoma", 20);
            Style codeStyle = doc.Style.Children.Add();
            codeStyle.Font = new Font("Courier new", 18, FontStyle.Bold);

            // add comment
            RenderParagraph desc = new RenderParagraph();
            desc.Content.Add(new ParagraphText("This document contains top level objects that can be split only if they do not fit on a new page:\r"));
            desc.Content.Add(new ParagraphText("VertSplitBehavior = SplitBehaviorEnum.SplitIfLarge\r\r", codeStyle));
            desc.Content.Add(new ParagraphText("The white background object is less than page high so it is never split, while the green background object cannot fit on a single page so it is split."));
            desc.Style.Spacing.Bottom = "5mm"; // add empty space after comment
            desc.Style.BackColor = Color.LightPink;
            doc.Body.Children.Add(desc);

            for (int i = 0; i < 10; i++)
            {
                RenderText rt = new RenderText();

                // build content of object content will small for even and big for odd objects
                StringBuilder sb = new StringBuilder();
                if (i % 2 == 0)
                    for (int j = 0; j < 15; j++)
                        sb.Append(string.Format("Line line line line {0}\r", j));
                else
                {
                    for (int j = 0; j < 30; j++)
                        sb.Append(string.Format("Line line line line {0}\r", j));
                    // mark "big" object with green background
                    rt.Style.BackColor = Color.LightGreen;
                }
                rt.Text = sb.ToString();

                rt.Style.Borders.All = new LineDef("1mm", Color.Red);
                // set splitting behavior
                rt.SplitVertBehavior = SplitBehaviorEnum.SplitIfLarge;
                doc.Body.Children.Add(rt);
            }

            doc.Generate();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            doc.Clear();

            doc.Style.Font = new Font("Tahoma", 20);
            Style codeStyle = doc.Style.Children.Add();
            codeStyle.Font = new Font("Courier new", 18, FontStyle.Bold);

            // add comment
            RenderParagraph desc = new RenderParagraph();
            desc.Content.Add(new ParagraphText("This document contains a RenderArea object with child RenderText objects that can be split only if they do not fit on a new page:\r"));
            desc.Content.Add(new ParagraphText("VertSplitBehavior = SplitBehaviorEnum.SplitIfLarge\r\r", codeStyle));
            desc.Content.Add(new ParagraphText("The white background object is less than page high so it is never split, while the green background object cannot fit on a single page so it is split."));
            desc.Style.Spacing.Bottom = "5mm"; // add empty space after comment
            desc.Style.BackColor = Color.LightPink;
            doc.Body.Children.Add(desc);

            RenderArea ra = new RenderArea();
            // RenderArea will has border to see its bounds
            ra.Style.Borders.All = new LineDef("2mm", Color.Magenta);
            ra.BordersSplitVertMode = BordersSplitMode.Square;
            for (int i = 0; i < 10; i++)
            {
                RenderText rt = new RenderText();

                // build content of object content will small for even and big for odd objects
                StringBuilder sb = new StringBuilder();
                if (i % 2 == 0)
                    for (int j = 0; j < 15; j++)
                        sb.Append(string.Format("Line line line line {0}\r", j));
                else
                {
                    for (int j = 0; j < 30; j++)
                        sb.Append(string.Format("Line line line line {0}\r", j));
                    // mark "big" object with green background
                    rt.Style.BackColor = Color.LightGreen;
                }
                rt.Text = sb.ToString();

                rt.Style.Borders.All = new LineDef("1mm", Color.Red);
                // set splitting behavior
                rt.SplitVertBehavior = SplitBehaviorEnum.SplitIfLarge;
                ra.Children.Add(rt);
            }

            // add RenderArea to the document
            doc.Body.Children.Add(ra);

            doc.Generate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            doc.Clear();

            doc.Style.Font = new Font("Tahoma", 20);
            Style codeStyle = doc.Style.Children.Add();
            codeStyle.Font = new Font("Courier new", 18, FontStyle.Bold);

            // objects will from left to right
            doc.Stacking = StackingRulesEnum.BlockLeftToRight;

            // add comment
            RenderParagraph desc = new RenderParagraph();
            desc.Content.Add(new ParagraphText("This document demonstrates the effect of SplitBehaviorEnum.SplitIfLarge on horizontal splitting."));
            desc.Style.Spacing.Right = "5mm"; // add empty space after comment
            desc.Width = Unit.Auto;
            desc.Height = "parent.height";
            desc.Style.BackColor = Color.LightPink;
            desc.Style.TextAngle = 90;
            doc.Body.Children.Add(desc);

            for (int i = 0; i < 5; i++)
            {
                RenderText rt = new RenderText();
                rt.Height = "parent.Height";
                rt.Width = Unit.Auto;
                rt.Style.TextAngle = 90;
                StringBuilder sb = new StringBuilder();
                for (int j = 0; j < 15; j++)
                    sb.Append(string.Format("Line line line line {0}", j));
                rt.Text = sb.ToString();
                rt.Style.Borders.All = new LineDef("1mm", Color.Red);
                rt.SplitHorzBehavior = SplitBehaviorEnum.SplitIfLarge;
                doc.Body.Children.Add(rt);
            }

            doc.Generate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            const int colCount = 3;
            const int rowCount = 10;

            doc.Clear();

            doc.Style.Font = new Font("Tahoma", 20);
            Style codeStyle = doc.Style.Children.Add();
            codeStyle.Font = new Font("Courier new", 18, FontStyle.Bold);

            // add comment
            RenderParagraph desc = new RenderParagraph();
            desc.Content.Add(new ParagraphText("This document demostrates the use of VertSplitBehavior property on objects within a table. "));
            desc.Content.Add(new ParagraphText("All objects nested within the table have VertSplitBehavior set to SplitIfLarge. "));
            desc.Content.Add(new ParagraphText("Green rows contain big objects so they are split whereas white rows contain objectst that can fit on a single page so they are not split."));
            desc.Style.Spacing.Bottom = "5mm"; // add empty space after comment
            desc.Style.BackColor = Color.LightPink;
            doc.Body.Children.Add(desc);

            RenderTable rt = new RenderTable();
            rt.Style.GridLines.All = LineDef.Default;

            // add header for RenderTable
            rt.Cells[0, 0].SpanCols = colCount;
            rt.Cells[0, 0].Text = "Page header";
            TableVectorGroup g = rt.RowGroups[0, 1];
            g.PageHeader = true;
            g.Style.BackColor = Color.LightBlue;

            for (int r = 0; r < rowCount; r++)
            {
                // rows should have CanSplit = true otherwise they will NOT split
                rt.Rows[r + 1].SplitBehavior = SplitBehaviorEnum.SplitIfNeeded;
                int lineCount = r % 2 == 0 ? 10 : 30;
                if (lineCount == 30)
                    rt.Rows[r + 1].Style.BackColor = Color.LightGreen;
                for (int c = 0; c < colCount; c++)
                {
                    RenderText txt = new RenderText();
                    // set splitting behavior
                    txt.SplitVertBehavior = SplitBehaviorEnum.SplitIfLarge;
                    // generate content of objects
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < lineCount; i++)
                        sb.Append(string.Format("Line {0}\r", i));
                    txt.Text = sb.ToString();
                    rt.Cells[r + 1, c].RenderObject = txt;
                }
            }

            // add footer for RenderTable
            rt.Cells[rowCount + 1, 0].Text = "Page footer";
            g = rt.RowGroups[rowCount + 1, 1];
            g.PageFooter = true;
            g.Style.BackColor = Color.BlanchedAlmond;

            doc.Body.Children.Add(rt);

            doc.Generate();
        }

        private RenderObject CreateButton(string caption)
        {
            RenderArea ra = new RenderArea();
            RenderInputButton rb = new RenderInputButton(caption);
            rb.Style.Font = new Font("Tahoma", 14);
            rb.X = LengthExp.Predefined.HorzCenterAlign;
            rb.Y = LengthExp.Predefined.VertCenterAlign;
            rb.Width = "35mm";
            rb.Height = "20mm";
            ra.Children.Add(rb);
            return ra;
        }

        private RenderObject CreateDesc(string desc)
        {
            RenderText rt = new RenderText();
            rt.Text = desc;
            rt.Style.Font = new Font("Verdana", 12);
            rt.Style.TextAlignVert = AlignVertEnum.Center;
            return rt;
        }

        private void c1PrintPreviewControl1_PreviewPane_FormsUserAction(object sender, FormsUserActionEventArgs e)
        {
            if (e.UserAction != UserActionEnum.Click)
                return;

            e.Handled = true;
            switch (((RenderInputButton)e.RenderObject).Text)
            {
                case "Demo1":
                    button1_Click(null, null);
                    break;
                case "Demo2":
                    button2_Click(null, null);
                    break;
                case "Demo3":
                    button3_Click(null, null);
                    break;
                case "Demo4":
                    button4_Click(null, null);
                    break;
            }
        }
    }
}