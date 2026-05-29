using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        protected void OnClick(object? sender, EventArgs args)
        {
            foreach (ToolStripMenuItem item in DropDownItems)
                item.Checked = item == sender;

            if(sender is ToolStripItem toolStripItem)
                SelectedIndex = DropDownItems.IndexOf(toolStripItem);
        }

        [DefaultValue(-1)]
        public int SelectedIndex
        {
            get => selectedIndex;
            set
            {
                if (selectedIndex != value)
                {
                    selectedIndex = value;
                    foreach (ToolStripMenuItem item in DropDownItems)
                        item.Checked = DropDownItems.IndexOf(item) == selectedIndex;

                    SelectionChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        public event EventHandler? SelectionChanged;
    }
}
