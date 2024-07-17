using RichTextEditor.BackstageTabs.Items;
using System;
using System.Drawing;

namespace RichTextEditor.BackstageTabs
{
    public partial class OpenTab : BackstageTabFileList
    {
        public OpenTab()
        {
            Button.ItemImage = Properties.Resources.Open_large;
            Button.ItemText = Properties.Resources.Browse_txt;
            Caption = GetElementText(Properties.Resources.OpenTab_txt);
        }

        #region override
        protected override void OnMenuItemClick(BackstageTabItem mi)
        {
            var ribbon = (C1TextEditorRibbon)BackstageView.Ribbon;
            ribbon.OpenDocument(System.IO.Path.Combine(mi.Item.SubText, mi.Item.Text));
            mi.Item.Date = DateTime.Now;
        }

        protected override void OnMenuButtonClick()
        {
            var ribbon = (C1TextEditorRibbon)BackstageView.Ribbon;
            ribbon.OpenDocument();
        }
        #endregion        
    }
}
