﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using C1.Win.Ribbon;

namespace RichTextEditor
{
    class ReferencesTab : ExtendedC1RibbonTab
    {
        public ReferencesTab()
        {
            this.ID = this.Text = "References";
            Groups.Add(new RibbonGroup("Table of Contents"));
            Groups.Add(new RibbonGroup("Index"));
        }
    }
}
