using System.Collections;
using System.Collections.Generic;

namespace ControlExplorer.Controls
{
    public class StackedNodeCollection : IList<StackNodeControl>, IEnumerable<StackNodeControl>
    {
        #region Private Variables

        private List<StackNodeControl> _nodes;

        #endregion

        #region Internal Methods
        internal event StackNodeEventHandler NodeAdded;
        internal StackedNodeCollection()
        {
            _nodes = new List<StackNodeControl>();
        }
        #endregion

        #region Public Methods

        public StackNodeControl Add(string key, string name, string collapsedImage, string expandedImage)
        {
            StackNodeControl control = new StackNodeControl(); control.Text = name;
            control.Key = key;
            _nodes.Add(control);
            OnCollectionModified(control);
            return control;
        }
        public StackNodeControl Add(string key, string name, string image)
        {
            return Add(key, name, image, image);
        }
        public StackNodeControl Add(string key, string name)
        {
            return Add(key, name, null, null);
        }
        public StackNodeControl Add(string name)
        {
            return Add(name, name, null, null);
        }
        public StackNodeControl this[int index]
        {
            get
            {
                return _nodes[index];
            }
            set
            {
                _nodes[index] = value;
            }
        }
        public bool IsReadOnly { get { return true; } }
        public bool IsFixedSize { get { return false; } }
        public int Count { get { return _nodes.Count; } }
        public object SyncRoot { get { return null; } }
        public bool IsSynchronized { get { return false; } }
        public void Add(StackNodeControl item)
        {
            _nodes.Add(item);
            OnCollectionModified(item);
        }
        public void Clear()
        {
            _nodes.Clear();
        }
        public bool Contains(StackNodeControl item)
        {
            return _nodes.Contains(item);
        }
        public void CopyTo(StackNodeControl[] array, int arrayIndex)
        {
            _nodes.CopyTo(array, arrayIndex);
        }
        public IEnumerator GetEnumerator()
        {
            return _nodes.GetEnumerator();
        }
        public int IndexOf(StackNodeControl item)
        {
            return _nodes.IndexOf(item);
        }
        public void Insert(int index, StackNodeControl item)
        {
            _nodes.Insert(index, item);
        }
        public bool Remove(StackNodeControl item)
        {
            return _nodes.Remove(item);
        }
        public void RemoveAt(int index)
        {
            _nodes.RemoveAt(index);
        }

        #endregion

        #region Private Methods

        private void OnCollectionModified(StackNodeControl node)
        {
            if (NodeAdded != null)
            {
                NodeAdded(this, new StackNodeEventArgs(node));
            }
        }
        #endregion
        IEnumerator<StackNodeControl> IEnumerable<StackNodeControl>.GetEnumerator()
        {
            foreach (var node in _nodes)
                yield return node;
        }
    }
}
