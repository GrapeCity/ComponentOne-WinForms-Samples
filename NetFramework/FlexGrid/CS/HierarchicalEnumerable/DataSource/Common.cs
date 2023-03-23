using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace HierarchicalEnumerable
{
    /// <summary>
    /// Example taken from
    /// http://www.codeproject.com/Articles/19639/Implementing-IHierarchy-Support-Into-Your-Custom-C
    /// </summary>
	public class Common 
    {
		private static CategoryCollection _collection;

		private Common() 
        {
		}

		/// <summary>
		/// Wraper around local data cache to retrieve just root categories from the collection
		/// </summary>
		/// <returns>CategoryCollection containing just categories with a parentId of "root"</returns>
		public static CategoryCollection GetRootCategories() 
        {
			var rootCategories = new CategoryCollection();
			foreach (Category category in GetCategoryData())
            {
				if (category.ParentId == 0)
					rootCategories.Add(category);
			}
			return rootCategories;
		}

		/// <summary>
		/// Method to generate sample data for examples
		/// </summary>
		/// <returns>CategoryCollection containing computer store related categories.</returns>
		public static CategoryCollection GetCategoryData()
        {
			// Simulate going to the database or pulling from a local cache
			if (_collection == null) {

				_collection = new CategoryCollection();
				_collection.Add(new Category(1, 0, "Computer Cases"));
				_collection.Add(new Category(2, 0, "Hard Drives"));
				_collection.Add(new Category(3, 0, "Memory"));
				_collection.Add(new Category(4, 0, "Input Devices"));
				_collection.Add(new Category(5, 0, "Monitors"));

				_collection.Add(new Category(10, 1, "Case Accessories"));
				_collection.Add(new Category(11, 1, "Computer Cases"));
				_collection.Add(new Category(12, 1, "External Enclosures"));
				_collection.Add(new Category(13, 1, "Server Chassis"));

				_collection.Add(new Category(20, 2, "Internal Hard Drives"));
				_collection.Add(new Category(21, 2, "Laptop Hard Drives"));
				_collection.Add(new Category(22, 2, "Network Hard Drives"));

				_collection.Add(new Category(30, 3, "Desktop Memory"));
				_collection.Add(new Category(31, 3, "Laptop Memory"));
				_collection.Add(new Category(32, 3, "Server Memory"));

				_collection.Add(new Category(40, 4, "Keyboards"));
				_collection.Add(new Category(41, 4, "Mouse"));
				_collection.Add(new Category(42, 4, "Tablets"));
				_collection.Add(new Category(43, 4, "Web Cams"));

				_collection.Add(new Category(50, 5, "CRT Monitors"));
				_collection.Add(new Category(51, 5, "LCD Monitors"));
                _collection.Add(new Category(52, 5, "Monitor Accessories"));
				_collection.Add(new Category(53, 5, "Touchscreen Monitors"));

				_collection.Add(new Category(60, 30, "168-Pin SDRAM"));
				_collection.Add(new Category(61, 30, "184-Pin DDR SDRAM"));
				_collection.Add(new Category(62, 30, "184-Pin RDRAM (16bit)"));
				_collection.Add(new Category(63, 30, "240-Pin DDR2 SDRAM"));
				_collection.Add(new Category(64, 30, "240-Pin DDR3 SDRAM"));

				_collection.Add(new Category(70, 63, "DDR2 400 (PC2 3200)"));
				_collection.Add(new Category(71, 63, "DDR2 533 (PC2 4200)"));
				_collection.Add(new Category(72, 63, "DDR2 533 (PC2 4300)"));
				_collection.Add(new Category(73, 63, "DDR2 667 (PC2 5300)"));
				_collection.Add(new Category(74, 63, "DDR2 667 (PC2 5400)"));
				_collection.Add(new Category(75, 63, "DDR2 800 (PC2 6400)"));

			}
			return _collection;
		}
	}
}