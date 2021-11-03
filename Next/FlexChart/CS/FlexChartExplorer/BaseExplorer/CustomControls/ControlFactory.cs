using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaseExplorer
{
    public class ControlFactory
    {
        public static ComboBoxEx EnumBasedCombo(Type enumType, string comboName)
        {
            var cb = new ComboBoxEx(comboName);
            if (enumType.IsEnum)
                cb.DataSource = Enum.GetValues(enumType);
            return cb;
        }
    }
}
