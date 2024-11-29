using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using C1.Win.Ribbon;

namespace RichTextEditor
{
    class MailingsTab : ExtendedC1RibbonTab
    {
        public MailingsTab()
        {
            this.ID = this.Text = "Mailings";
            Groups.Add(new RibbonGroup("Create"));
            Groups.Add(new RibbonGroup("Start Mail Merge"));
            Groups.Add(new RibbonGroup("Write && Insert Fields"));
            Groups.Add(new RibbonGroup("Preview Results"));
            Groups.Add(new RibbonGroup("Finish"));
        }
    }
}
