using System;
using System.Collections.Generic;
using System.Web.UI;

namespace HierarchicalEnumerable
{
    /// <summary>
    /// Example taken from
    /// http://www.codeproject.com/Articles/19639/Implementing-IHierarchy-Support-Into-Your-Custom-C
    /// </summary>
    public class CategoryCollection : List<Category>, IHierarchicalEnumerable
    {

		public CategoryCollection()
			: base() {
		}

		#region ** IHierarchicalEnumerable Members

		public IHierarchyData GetHierarchyData(object enumeratedItem)
        {
			return enumeratedItem as IHierarchyData;
		}

		#endregion

	}

}