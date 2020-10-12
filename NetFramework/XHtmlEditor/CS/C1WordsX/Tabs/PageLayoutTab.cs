using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using C1.Win.C1Ribbon;

namespace C1WordsX
{
    class PageLayoutTab : C1TextEditorRibbonTab
    {
        //---------------------------------------------------------------------------
        #region ** create tab

        public PageLayoutTab()
        {
            this.ID = this.Text = "Page Layout";
            Groups.Add(CreatePageSetupGroup());
            Groups.Add(new RibbonGroup("Paragraph"));
            Groups.Add(new RibbonGroup("Arrange"));
        }
        RibbonGroup CreatePageSetupGroup()
        {
            RibbonGroup g = new RibbonGroup();
            g.Text = g.ID = "Page Setup";
            g.HasLauncherButton = true;
            g.DialogLauncherClick += pageSetup_DialogLauncherClick;

            g.Items.Add(CreateMenu("Margins",
                CreateButton("MarginNormal", "Margins"),
                CreateButton("MarginNarrow", "Margins"),
                CreateButton("MarginModerate", "Margins"),
                CreateButton("MarginWide", "Margins"),
                CreateButton("MarginOffice", "Margins"),
                new RibbonSeparator(),
                CreateButton("CustomMargins")));

            g.Items.Add(CreateMenu("Orientation",
                CreateButton("Portrait"),
                CreateButton("Landscape")));

            RibbonMenu mPaperSize = CreateMenu("Size");
            foreach (PaperSize ps in new PrinterSettings().PaperSizes)
            {
                RibbonButton btn = CreateButton(ps.PaperName);
                btn.Tag = ps;
                mPaperSize.Items.Add(btn);
            }
            mPaperSize.MaxDropDownItems = 12;
            mPaperSize.GripHandleVisible = true;
            g.Items.Add(mPaperSize);

            foreach (RibbonItem mainItem in g.Items)
            {
                RibbonMenu m = mainItem as RibbonMenu;
                if (m != null)
                {
                    foreach (RibbonItem item in m.Items)
                    {
                        RibbonButton btn = item as RibbonButton;
                        if (btn != null)
                        {
                            btn.SupportedGroupSizing = SupportedGroupSizing.LargeImageOnly;
                        }
                    }
                }
            }

            return g;
        }

        #endregion

        //---------------------------------------------------------------------------
        #region ** handle commands

        internal override void HandleItemEvent(RibbonEventArgs e)
        {
            RibbonItem item = (RibbonItem)e.Item;
            if (e.EventType == RibbonEventType.Click)
            {
                PageSettings ps;

                switch (item.ID)
                {
                    // margins
                    case "MarginNormal":
                        ps = Editor.PrintDocument.DefaultPageSettings;
                        ps.Margins = new Margins(100, 100, 100, 100);
                        break;
                    case "MarginNarrow":
                        ps = Editor.PrintDocument.DefaultPageSettings;
                        ps.Margins = new Margins(50, 50, 50, 50);
                        break;
                    case "MarginModerate":
                        ps = Editor.PrintDocument.DefaultPageSettings;
                        ps.Margins = new Margins(75, 75, 100, 100);
                        break;
                    case "MarginWide":
                        ps = Editor.PrintDocument.DefaultPageSettings;
                        ps.Margins = new Margins(200, 200, 200, 200);
                        break;
                    case "MarginOffice":
                        ps = Editor.PrintDocument.DefaultPageSettings;
                        ps.Margins = new Margins(125, 125, 100, 100);
                        break;
                    case "CustomMargins":
                        using (PageSetupDialog dlg = new PageSetupDialog())
                        {
                            dlg.Document = Editor.PrintDocument;
                            dlg.ShowDialog();
                        }
                        break;

                    // orientation
                    case "Landscape":
                        ps = Editor.PrintDocument.DefaultPageSettings;
                        ps.Landscape = true;
                        break;
                    case "Portrait":
                        ps = Editor.PrintDocument.DefaultPageSettings;
                        ps.Landscape = false;
                        break;

                    // paper size
                    default:
                        PaperSize paperSize = item.Tag as PaperSize;
                        if (paperSize != null)
                        {
                            ps = Editor.PrintDocument.DefaultPageSettings;
                            ps.PaperSize = paperSize;
                        }
                        break;
                }
            }
        }
        void pageSetup_DialogLauncherClick(object sender, EventArgs e)
        {
            using (PageSetupDialog dlg = new PageSetupDialog())
            {
                dlg.Document = Editor.PrintDocument;
                dlg.ShowDialog();
            }
        }
        #endregion
    }
}
