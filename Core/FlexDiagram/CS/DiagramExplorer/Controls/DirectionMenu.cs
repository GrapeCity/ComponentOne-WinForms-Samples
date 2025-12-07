using C1.Diagram;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DiagramExplorer.Controls
{
    class DirectionMenu : EnumMenu<DiagramDirection>
    {
        int selectedIndex = -1;

        public DirectionMenu() : base("Direction") { }

        protected override void Init(string name)
        {
            Text = "Direction";
            DropDownItems.Add("⬇️ TopBottom", null, OnClick);
            DropDownItems.Add("➡️ LeftRight", null, OnClick);
            DropDownItems.Add("⬆️ BottomTop", null, OnClick);
            DropDownItems.Add("⬅️ RightLeft", null, OnClick);
        }
    }
}
