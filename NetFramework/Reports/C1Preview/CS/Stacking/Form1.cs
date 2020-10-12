using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using C1.C1Preview;

namespace Stacking
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

        private RenderObject CreateObj(string text)
        {
            RenderText result = new RenderText();
            result.Text = text;
            result.Style.Borders.All = new LineDef("1mm", Color.Blue);
            result.Style.TextAlignHorz = AlignHorzEnum.Center;
            result.Style.TextAlignVert = AlignVertEnum.Center;
            result.Style.BackColor = Color.LightSkyBlue;
            result.SplitVertBehavior = SplitBehaviorEnum.SplitIfLarge;
            result.Width = "7cm";
            result.Height = "4cm";
            return result;
        }

        private void MakeDoc1(C1PrintDocument doc)
        {
            // title of document
            RenderText rt = new RenderText("Stacking and positioning of objects");
            rt.Style.Borders.Bottom = new LineDef("1mm", Color.Black);
            doc.Body.Children.Add(rt);

            // document will contains the TOC
            RenderToc toc = new RenderToc();

            // 1. Demonstrate StackingRulesEnum.BlockTopToBottom
            RenderText title = new RenderText("Demonstrates StackingRulesEnum.BlockTopToBottom stacking");
            title.BreakBefore = BreakEnum.Page;
            doc.Body.Children.Add(title);
            RenderArea area = new RenderArea();
            area.Stacking = StackingRulesEnum.BlockTopToBottom;
            for (int i = 1; i <= 10; i++)
                area.Children.Add(CreateObj(string.Format("OBJECT {0}", i)));
            doc.Body.Children.Add(area);

            toc.AddItem("Stacking", title, 1);
            toc.AddItem("StackingRulesEnum.BlockTopToBottom", title, 2);

            // 2. Demonstrate the StackingRulesEnum.BlockLeftToRight
            title = new RenderText("Demonstrates StackingRulesEnum.BlockLeftToRight stacking");
            title.BreakBefore = BreakEnum.Page;
            doc.Body.Children.Add(title);
            area = new RenderArea();
            // by default the RenderArea has a width = "parent.width" so we set it to
            // auto to show all child objects
            area.Width = Unit.Auto;
            // by default the RenderArea does not split by horizontally...
            area.SplitHorzBehavior = SplitBehaviorEnum.SplitIfNeeded;
            area.Stacking = StackingRulesEnum.BlockLeftToRight;
            for (int i = 1; i <= 4; i++)
                area.Children.Add(CreateObj(string.Format("OBJECT {0}", i)));
            doc.Body.Children.Add(area);

            toc.AddItem("StackingRulesEnum.BlockLeftToRight", title, 2);

            // 3. Demonstrate the StackingRulesEnum.InlineLeftToRight
            title = new RenderText("Demonstrates StackingRulesEnum.InlineLeftToRight stacking");
            title.BreakBefore = BreakEnum.Page;
            doc.Body.Children.Add(title);
            area = new RenderArea();
            area.Stacking = StackingRulesEnum.InlineLeftToRight;
            for (int i = 1; i <= 10; i++)
                area.Children.Add(CreateObj(string.Format("OBJECT {0}", i)));
            doc.Body.Children.Add(area);

            toc.AddItem("StackingRulesEnum.InlineLeftToRight", title, 2);

            // 4. The positioning of objects
            title = new RenderText("Each object starting with the second one is positioned relative to the previous object.");
            title.BreakBefore = BreakEnum.Page;
            doc.Body.Children.Add(title);

            doc.Body.Children.Add(CreateObj("FIRST OBJECT"));
            for (int i = 2; i <= 5; i++)
            {
                RenderObject ro = CreateObj(string.Format("OBJECT {0}", i));
                ro.X = "prev.Left + 1cm";
                ro.Y = "prev.Top + 1cm";
                doc.Body.Children.Add(ro);
            }

            toc.AddItem("Positioning", title, 1);

            doc.Body.Children.Insert(1, toc);
        }
    }
}