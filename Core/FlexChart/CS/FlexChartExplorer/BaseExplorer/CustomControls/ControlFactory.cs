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
                cb.ItemsDataSource = Enum.GetValues(enumType);
            cb.SelectedIndex = 1;
            return cb;
        }
    }
}
