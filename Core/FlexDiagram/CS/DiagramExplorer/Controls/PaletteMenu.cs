using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramExplorer.Controls
{
    class PaletteMenu : EnumMenu<C1.Chart.Palette>
    {
        public PaletteMenu() : base("Palette") { }

        protected override void Init(string name)
        {
            base.Init(name);
            DropDownItems.RemoveAt(DropDownItems.Count - 1);
        }
    }
}
