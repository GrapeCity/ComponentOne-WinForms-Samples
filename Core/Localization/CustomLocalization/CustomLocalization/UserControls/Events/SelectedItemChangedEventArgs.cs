using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Custom_Localization.UserControls.Events
{
    public class SelectedItemChangedEventArgs : EventArgs
    {
        public TreeNode Item { get; set; }

        public SelectedItemChangedEventArgs(TreeNode item)
        {
            Item = item ?? throw new ArgumentNullException(nameof(item)); ;
        }
    }
}
