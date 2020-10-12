using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using C1.Win.C1Ribbon;

namespace C1WordsX
{
    class ReviewTab : C1TextEditorRibbonTab
    {
        //---------------------------------------------------------------------------
        #region ** create tab

        public ReviewTab()
        {
            this.ID = this.Text = "Review";
            Groups.Add(CreateProofingGroup());
        }
        RibbonGroup CreateProofingGroup()
        {
            RibbonGroup g = new RibbonGroup();
            g.Text = g.ID = "Proofing";
            g.HasLauncherButton = true;
            g.Items.Add(CreateButton("Spelling"));
            g.Items.Add(CreateToggleButton("ShowErrors"));
            g.Items.Add(CreateButton("SetLanguage"));
            g.Items.Add(CreateButton("WordCount"));
            return g;
        }
        RibbonGroup CreateCompareGroup()
        {
            RibbonGroup g = new RibbonGroup();
            g.Text = g.ID = "Compare";
            g.Items.Add(CreateButton("Compare"));
            g.Items.Add(CreateButton("CompareVersions"));
            return g;
        }
        RibbonGroup CreateProtectGroup()
        {
            RibbonGroup g = new RibbonGroup();
            g.Text = g.ID = "Protect";
            g.Items.Add(CreateButton("Protect"));
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
                switch (item.ID)
                {
                    case "Spelling":
                        Ribbon.SpellCheck();
                        break;
                    case "ShowErrors":
                        Ribbon.SetActiveSpellChecking(((RibbonToggleButton)item).Pressed);
                        break;
                    case "SetLanguage":
                        Ribbon.SetSpellingLanguage();
                        break;
                    case "WordCount":
                        using (WordCount dlg = new WordCount(Editor.Text))
                        {
                            dlg.Font = Ribbon.Font;
                            dlg.ShowDialog();
                        }
                        break;
                }
            }
        }

        #endregion
    }
}
