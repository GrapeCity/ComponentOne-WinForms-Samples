using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseExplorer
{
    public class CheckBoxEx : CheckBox
    {
        public CheckBoxEx()
        {
            FlatStyle = FlatStyle.Flat;
            ForeColor = System.Drawing.Color.DimGray;
            AutoSize = true;
            Margin = new Padding(5);
        }

        public CheckBoxEx(string name) : this()
        {
            Text = name;
        }
    }
}
