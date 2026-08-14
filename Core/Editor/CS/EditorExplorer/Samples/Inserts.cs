// Copyright (c) 2023 FIIT B.V. | DeveloperTools (KVK:75050250). All Rights Reserved.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EditorExplorer.Samples
{
    public partial class Inserts : UserControl
    {
        public Inserts()
        {
            InitializeComponent();
            c1Editor1.C1EditorReady += c1Editor1_C1EditorReadyAsync;
            c1Editor1.ClientSizeChanged += C1Editor1_Resize;
            c1Editor1.SizeChanged += C1Editor1_Resize;
        }

        private void C1Editor1_Resize(object sender, EventArgs e)
        {
            c1Editor1.Focus();
        }

        private async void c1Editor1_C1EditorReadyAsync(object sender, EventArgs e)
        {
            string filename = @"Resources\PageForInserts.html";
            if (File.Exists(filename))
            {
                await c1Editor1.LoadDocumentAsync(Path.GetFullPath(filename));
                await c1Editor1.SetDefaultStylesAsync(null, true);
            }
        }

        private void btnInsertBefore_Click(object sender, EventArgs e)
        {
            c1Editor1.InsertBeforeElementAsync("InsertTextBefore", "insert-before-target", null, null);
        }
        private void btnInsertAfter_Click(object sender, EventArgs e)
        {
            c1Editor1.InsertAfterElementAsync("InsertTextAfter", "insert-after-target", null, null);
        }
        private void btnInsertIntoFirst_Click(object sender, EventArgs e)
        {
            c1Editor1.InsertIntoElementAsync("InsertTextInto_First", C1.Win.Editor.ContentInsertMode.First, "sentence-3", null, null);
        }
        private void btnInsertIntoLast_Click(object sender, EventArgs e)
        {
            c1Editor1.InsertIntoElementAsync("InsertTextInto_Last", C1.Win.Editor.ContentInsertMode.Last, "sentence-4", null, null);
        }
        private void btnInsertIntoReplace_Click(object sender, EventArgs e)
        {
            c1Editor1.InsertIntoElementAsync("InsertTextInto_Replace", C1.Win.Editor.ContentInsertMode.Replace, "replace-target", null, null);
        }
    }
}
