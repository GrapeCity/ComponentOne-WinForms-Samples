using RichTextEditor.AppMenuTabs.Items;
using System;
using System.Drawing;

namespace RichTextEditor.AppMenuTabs
{
    public partial class OpenTab : AppMenuTabFileList
    {
        public OpenTab()
        {
            Button.ItemImage = Properties.Resources.Open_large;
            Button.ItemText = Properties.Resources.Browse_txt;
            Caption = GetElementText(Properties.Resources.OpenTab_txt);
        }

        #region override
        protected override void OnMenuItemClick(AppMenuTabItem mi)
        {
            var ribbon = (C1TextEditorRibbon)RibbonApplicationMenu.Ribbon;
            ribbon.OpenDocument(System.IO.Path.Combine(mi.Item.SubText, mi.Item.Text));
            mi.Item.Date = DateTime.Now;
        }

        protected override void OnMenuButtonClick()
        {
            var ribbon = (C1TextEditorRibbon)RibbonApplicationMenu.Ribbon;
            ribbon.OpenDocument();
        }
        #endregion        
    }
}
