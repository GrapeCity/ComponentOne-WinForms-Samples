using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using C1.Win.C1Ribbon;

namespace RichTextEditor
{
    class ReferencesTab : C1TextEditorRibbonTab
    {
        public ReferencesTab()
        {
            this.ID = this.Text = "References";
            Groups.Add(new RibbonGroup("Table of Contents"));
            Groups.Add(new RibbonGroup("Index"));
        }
    }
}
