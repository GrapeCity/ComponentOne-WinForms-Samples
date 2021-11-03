using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrillDown
{
    public class ComboBoxItem
    {
        public string Text { get; set; }
        public int Value { get; set; }

        string _comboName;

        public ComboBoxItem(string comboName)
        {
            _comboName = comboName;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", _comboName, Text);
        }
    }
}
