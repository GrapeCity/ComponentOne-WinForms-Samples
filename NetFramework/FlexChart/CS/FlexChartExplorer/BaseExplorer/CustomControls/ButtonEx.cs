using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseExplorer
{
    public class ButtonEx : Button
    {
        public ButtonEx()
        {
            FlatStyle = FlatStyle.Flat;
            ForeColor = System.Drawing.Color.DimGray;
            Margin = new Padding(5);
            Size = new System.Drawing.Size(130,21);
        }
        public ButtonEx(string text) : this()
        {
            Text = text;            
        }
    }
}
