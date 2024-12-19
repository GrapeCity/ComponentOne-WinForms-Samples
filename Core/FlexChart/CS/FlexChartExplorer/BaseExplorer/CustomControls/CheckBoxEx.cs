using BaseExplorer.Core;
using C1.Win.Input;
using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BaseExplorer
{
    public class CheckBoxEx : C1CheckBox
    {
        public CheckBoxEx()
        {
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
