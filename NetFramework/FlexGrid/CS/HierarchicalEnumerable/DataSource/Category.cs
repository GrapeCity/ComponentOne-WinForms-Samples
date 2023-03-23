using System;
using System.Web.UI;

namespace HierarchicalEnumerable
{
    /// <summary>
    /// Example taken from
    /// http://www.codeproject.com/Articles/19639/Implementing-IHierarchy-Support-Into-Your-Custom-C
    /// </summary>
    public class Category : IHierarchyData 
    {
		int _categoryId;
		int _parentId;
		string _name;

        /// <summary>
        /// Public constructor
        /// </summary>
        /// <param name="categoryId">Unique identifier for the category</param>
        /// <param name="parentId">Foreign key to the parent category</param>
        /// <param name="name">Friendly description of the category</param>
        public Category(int categoryId, int parentId, string name)
        {
            _categoryId = categoryId;
            _parentId = parentId;
            _name = name;
        }

        /// <summary>
        /// Hide default constructor
        /// </summary>
        private Category()
        {
        }
        
        /// <summary>
		/// Unique identifier for the category
		/// </summary>
		public int CategoryId
        {
			get { return _categoryId; }
			set { _categoryId = value; }
		}
		/// <summary>
		/// Foreign key to the parent category
		/// </summary>
		public int ParentId
        {
			get { return _parentId; }
			set { _parentId = value; }
		}
		/// <summary>
		/// Friendly description of the category
		/// </summary>
		public string Name
        {
			get { return _name; }
			set { _name = value; }
		}
        public override string ToString()
        {
            return this.Name;
        }

		#region ** IHierarchyData Members

		public IHierarchicalEnumerable GetChildren() 
        {
			var children = new CategoryCollection();

			// Loop through your local data and find any children
			foreach (Category category in Common.GetCategoryData()) 
            {
				if (category.ParentId == this.CategoryId)
                {
					children.Add(category);
				}
			}
			return children;
		}
		public IHierarchyData GetParent() 
        {
			// Loop through your local data and report back with the parent
			foreach (Category category in Common.GetCategoryData())
            {
				if (category.CategoryId == this.ParentId)
					return category;
			}
			return null;
		}
		public bool HasChildren 
        {
			get
            {
				var children = GetChildren() as CategoryCollection;
				return children.Count > 0;
			}
		}
		public object Item
        {
			get { return this; }
		}
		public string Path
        {
			get { return this.CategoryId.ToString(); }
		}
		public string Type
        {
			get { return this.GetType().ToString(); }
		}

		#endregion
	}
}