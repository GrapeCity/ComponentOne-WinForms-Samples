using C1.Win.FlexGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexGridExplorer.Samples.AdvancedFilters
{
    internal class CustomConditionFilter : ConditionFilter
    {
        public override IC1ColumnFilterEditor GetEditor()
        {
            return new CustomConditionFilterEditor();
        }
    }
}
