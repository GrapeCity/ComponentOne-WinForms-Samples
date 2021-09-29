using WordPad.BackstageTabs.Items;
using System;
using System.Drawing;

namespace WordPad.BackstageTabs
{
    public partial class SaveAsTab : BackstageTab
    {
        public SaveAsTab()
        {
            Button.ItemImage = Properties.Resources.Save;
            Button.ItemText = Properties.Resources.Browse_txt;
            Caption = GetElementText(Properties.Resources.SaveAsTab_txt);
        }

        #region override

        protected override void OnMenuItemClick(ListItem mi)
        {
            Owner.SaveDocument(System.IO.Path.Combine(mi.Item.SubText, mi.Item.Text));
            mi.Item.Date = DateTime.Now;
        }

        protected override void OnMenuButtonClick()
        {
            Owner.SaveDocumentAs();
        }

        #endregion  
    }
}
