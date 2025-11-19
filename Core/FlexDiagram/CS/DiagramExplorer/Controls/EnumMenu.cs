using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramExplorer.Controls
{
    public class EnumMenu<T> : ToolStripMenuItem where T : Enum
    {
        int selectedIndex = -1;

        public EnumMenu(string name)
        {
            Init(name);
        }

        virtual protected void Init(string name)
        {
            Text = name;
            var names = Enum.GetNames(typeof(T));
            foreach(var n in names) 
                DropDownItems.Add( n, null, OnClick);
        }

        protected void OnClick(object sender, EventArgs args)
        {
            foreach (ToolStripMenuItem item in DropDownItems)
                item.Checked = item == sender;

            SelectedIndex = DropDownItems.IndexOf(sender as ToolStripItem);
        }

        public int SelectedIndex
        {
            get => selectedIndex;
            set
            {
                if ((selectedIndex != value))
                {
                    selectedIndex = value;
                    foreach (ToolStripMenuItem item in DropDownItems)
                        item.Checked = DropDownItems.IndexOf(item) == selectedIndex;

                    SelectionChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler SelectionChanged;

    }
}
