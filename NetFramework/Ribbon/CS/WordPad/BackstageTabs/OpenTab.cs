using System;
using WordPad.BackstageTabs.Items;

namespace WordPad.BackstageTabs
{
    public partial class OpenTab : BackstageTab
    {
        public OpenTab()
        {
            Button.ItemImage = Properties.Resources.Open;
            Button.ItemText = Properties.Resources.Browse_txt;
            Caption = GetElementText(Properties.Resources.OpenTab_txt);
        }

        #region override

        protected override void OnMenuItemClick(ListItem mi)
        {
            Owner.OpenDocument(System.IO.Path.Combine(mi.Item.SubText, mi.Item.Text));
            mi.Item.Date = DateTime.Now;
        }

        protected override void OnMenuButtonClick()
        {
            Owner.OpenDocument();
        }

        #endregion        
    }
}
