using C1.Win.TreeView;
using System.Collections.Generic;

namespace CustomAutoSearch
{
    /// <summary>
    /// The service of search a node by the value. 
    /// </summary>
    public class AutoSearchService
    {
        private C1TreeView _tree;
        private C1TreeNode _goal;
        /// <summary>
        /// The service of search a node by the value. 
        /// </summary>
        /// <param name="tree"></param>
        public AutoSearchService(C1TreeView tree)
        {
            _tree = tree;
            DFS = true;
            ComparisonType = ComparisonType.StartsWith;
        }
        /// <summary>
        /// String comparison type.
        /// </summary>
        public ComparisonType ComparisonType
        {
            get;
            set;
        }
        /// <summary>
        /// Search Type: true - Depth-first search, false - breadth-first search
        /// </summary>
        public bool DFS
        {
            get;
            set;
        }
        /// <summary>
        /// Search for the node containing the specified string.
        /// </summary>
        /// <param name="value">search string.</param>
        /// <param name="columnIndex">Node column index.</param>
        /// <returns>Node is found.</returns>
        public bool Search(string value, int columnIndex = 0)
        {
            _goal = null;

            if (DFS)
                DfsSearch(_tree.Nodes, value, columnIndex);
            else
                BfsSearch(_tree.Nodes, value, columnIndex);

            _tree.CollapseAll();
            if (_goal != null)
            {
                var parentColl = _goal.ParentCollection;
                while(parentColl.Parent != null)
                {
                    parentColl.Parent.Expand();
                    parentColl = parentColl.Parent.ParentCollection;
                }
                _goal.Selected = true;
            }         

            return _goal != null;
        }

        private void DfsSearch(C1TreeNodeCollection nodes, string value, int columnIndex)
        {            
            foreach (var node in nodes)
            {
                if (_goal != null)
                    return;
                if (IsEquals(node.GetValue(columnIndex).ToString(), value))
                {
                    _goal = node;
                    return;
                }
                DfsSearch(node.Nodes, value, columnIndex);
            }            
        }

        private void BfsSearch(C1TreeNodeCollection nodes, string value, int columnIndex)
        {
            var queue = new Queue<C1TreeNode>(nodes);
            while (queue.Count > 0)
            {
                var node = queue.Dequeue();
                if (IsEquals(node.GetValue(columnIndex).ToString(), value))
                {
                    _goal = node;
                    return;
                }
                foreach (var child in node.Nodes)
                    queue.Enqueue(child);
            }
        }

        private bool IsEquals(string source, string sub)
        {
            switch (ComparisonType)
            {
                case ComparisonType.StartsWith:
                    return source.StartsWith(sub, System.StringComparison.InvariantCultureIgnoreCase);
                case ComparisonType.Contains:
                    return source.Contains(sub);
                default:
                    return source.Equals(sub, System.StringComparison.InvariantCultureIgnoreCase);
            }
        }
    }
    /// <summary>
    /// String comparison type.
    /// </summary>
    public enum ComparisonType
    {
        Equal,
        StartsWith,
        Contains
    }
}
