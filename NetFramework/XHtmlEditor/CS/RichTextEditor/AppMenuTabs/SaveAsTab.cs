using RichTextEditor.AppMenuTabs.Items;
using System;
using System.Drawing;

namespace RichTextEditor.AppMenuTabs
{
    public partial class SaveAsTab : AppMenuTabFileList
    {
        public SaveAsTab()
        {
            Button.ItemImage = Properties.Resources.Open_large;
            Button.ItemText = Properties.Resources.Browse_txt;
            Caption = GetElementText(Properties.Resources.SaveAsTab_txt);
        }

        #region override
        protected override void OnMenuItemClick(AppMenuTabItem mi)
        {
            var ribbon = (C1TextEditorRibbon)RibbonApplicationMenu.Ribbon;
            ribbon.SaveDocument(System.IO.Path.Combine(mi.Item.SubText, mi.Item.Text));
            mi.Item.Date = DateTime.Now;
        }

        protected override void OnMenuButtonClick()
        {
            var ribbon = (C1TextEditorRibbon)RibbonApplicationMenu.Ribbon;
            ribbon.SaveDocumentAs();
        }
        #endregion  
    }
}
