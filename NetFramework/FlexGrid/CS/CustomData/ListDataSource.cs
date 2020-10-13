using System;
using System.Collections;
using System.ComponentModel;

namespace CustomData
{
	/// <summary>
	/// ListDataSource
	/// improved wrapper for IList objects to be used as .NET data sources
	/// 
	/// e.g.
	///		ArrayList al = CreateArrayList();
	///		grid.DataSource = al; 
	///		// works, but no sort/addnew/delete
	///		
	///		ArrayList al = CreateArrayList();
	///		grid.DataSource = new ListDataSource(al);
	///		// works and provides sort/addnew/delete
	///		// (addnew requires ICloneable objects)
	/// 
	/// </summary>
	public class ListDataSource : IBindingList, ITypedList, IList
	{
		private IList _list;
		private PropertyDescriptorCollection _pdc;
		private bool _browsableOnly;
		private string _name;
		private bool _allowEdit, _allowNew, _allowRemove;

		public event ListChangedEventHandler ListChanged;

		// ctor

		public ListDataSource(IList list)
		{
			Init("", list, true);
		}
		public ListDataSource(string name, IList list)
		{
			Init(name, list, true);
		}
		public ListDataSource(IList list, bool browsableOnly)
		{
			Init("", list, browsableOnly);
		}
		public ListDataSource(string name, IList list, bool browsableOnly)
		{
			Init(name, list, browsableOnly);
		}
		private void Init(string name, IList list, bool browsableOnly)
		{
			_name = name;
			_list = list;
			_browsableOnly = browsableOnly;
			_allowEdit = _allowNew = _allowRemove = true;
		}

		// object model
		public bool AllowEdit
		{
			get { return _allowEdit; }
			set { _allowEdit = value; }
		}
		public bool AllowNew
		{
			get { return _allowNew; }
			set { _allowNew = value; }
		}
		public bool AllowRemove
		{
			get { return _allowRemove; }
			set { _allowRemove = value; }
		}

		// IBindingList

		// add/remove items
		bool IBindingList.AllowEdit
		{
			get { return _allowEdit; }
		}
		bool IBindingList.AllowNew
		{
			get
			{
				return _allowNew &&
					_list.Count > 0 && 
					_list[0] is ICloneable;
			}
		}
		bool IBindingList.AllowRemove
		{
			get { return _allowRemove; }
		}
		public virtual object CreateNewValue()
		{
			return ((ICloneable)_list[0]).Clone();
		}
		object IBindingList.AddNew()
		{
			object value = CreateNewValue();
			_addNew = ((IList)this).Add(value);
			return value;
		}

		// handle IEditableObject notifications
		private int _addNew = -1;
		private bool _editing = false;
		internal void BeginEdit()
		{
			_editing = true;
		}
		internal void CancelEdit()
		{
			if (_editing && _addNew > -1 && _addNew < this.Count)
				((IList)this).RemoveAt(_addNew);
			_editing = false;
		}
		internal void EndEdit()
		{
			_editing = false;
		}

		// searching
		bool IBindingList.SupportsSearching
		{
			get { return false; }
		}
		int IBindingList.Find(PropertyDescriptor property, object key)
		{
			return 0;
		}
		void IBindingList.AddIndex(PropertyDescriptor property)
		{
		}
		void IBindingList.RemoveIndex(PropertyDescriptor property)
		{
		}

		// sorting
		private PropertyDescriptor _pdSort;
		private ListSortDirection _sortDir;
		bool IBindingList.SupportsSorting
		{
			get { return _list is Array || _list is ArrayList; }
		}
		void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
			// initialize
			_pdSort = null;

			// sort array/list
			if (_list is Array)
			{
				Array.Sort(_list as Array, new ListItemComparer(property, direction));
				_sortDir = direction;
				_pdSort = property;
				ListSorted();
			}
			else if (_list is ArrayList)
			{
				ArrayList al = _list as ArrayList;
				al.Sort(new ListItemComparer(property, direction));
				_sortDir = direction;
				_pdSort = property;
				ListSorted();
			}
		}
		void IBindingList.RemoveSort()
		{
			_pdSort = null;
		}
		bool IBindingList.IsSorted
		{
			get { return _pdSort != null; }
		}
		ListSortDirection IBindingList.SortDirection 
		{
			get { return _sortDir; }
		}
		PropertyDescriptor IBindingList.SortProperty 
		{
			get { return _pdSort; }
		}

		// notifications
		bool IBindingList.SupportsChangeNotification 
		{
			get { return true; }
		}
		internal void ItemChanged(object component)
		{
			if (ListChanged != null)
			{
				ListChangedEventArgs e = new ListChangedEventArgs(ListChangedType.ItemChanged, _list.IndexOf(component), -1);
				ListChanged(this, e);
			}
		}
		internal void ItemAdded(int index)
		{
			if (ListChanged != null)
			{
				ListChangedEventArgs e = new ListChangedEventArgs(ListChangedType.ItemAdded, index, -1);
				ListChanged(this, e);
			}
		}
		internal void ItemRemoved(int index)
		{
			if (ListChanged != null)
			{
				ListChangedEventArgs e = new ListChangedEventArgs(ListChangedType.ItemDeleted, index, -1);
				ListChanged(this, e);
			}
		}
		internal void ListSorted()
		{
			if (ListChanged != null)
			{
				ListChangedEventArgs e = new ListChangedEventArgs(ListChangedType.Reset, -1, -1);
				ListChanged(this, e);
			}
		}
		internal void ListCleared()
		{
			if(ListChanged != null)
			{
				ListChangedEventArgs e = new ListChangedEventArgs(ListChangedType.Reset, -1, -1);
				ListChanged(this, e);
			}
		}

		// ITypedList

		PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			if (_pdc == null && _list != null && _list.Count > 0)
			{
				_pdc = new PropertyDescriptorCollection(null);
				foreach (PropertyDescriptor pd in TypeDescriptor.GetProperties(_list[0]))
				{
					if (_browsableOnly && pd.Attributes.Contains(BrowsableAttribute.No))
						continue;
					_pdc.Add(new ListPropertyDescriptor(this, pd));
				}
			}
			return _pdc;
		}
		string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
		{
			return _name;
		}

		// IList

		public object this [int index]
		{
			get
			{
				return (((IBindingList)this).AllowNew)
					? new ListDataItem(this, _list[index])
					: _list[index];
			}
			set
			{
				_list[index] = (value is ListDataItem)
					? ((ListDataItem)value)._value
					: value;
			}
		}
		
		public int Add(object value)
		{
			int index = _list.Add(value);
			ItemAdded(index);
			return index;
		}
		public void Clear()
		{
			_list.Clear();
			ListCleared();
		}
		public bool Contains(object value)
		{
			return _list.Contains(value);
		}
		public int IndexOf(object value)
		{
			return _list.IndexOf(value);
		}
		public void Insert(int index, object value)
		{
			_list.Insert(index, value);
			ItemAdded(index);
		}
		public bool IsFixedSize
		{
			get { return _list.IsFixedSize; }
		}
		public bool IsReadOnly
		{
			get { return _list.IsReadOnly; }
		}
		public void Remove(object value) 
		{
			int index = _list.IndexOf(value);
			_list.Remove(value);
			ItemRemoved(index);
		}
		void IList.RemoveAt(int index) 
		{
			_list.RemoveAt(index);
			ItemRemoved(index);
		}

		// ICollection

		public void CopyTo(Array array, int index)
		{
			_list.CopyTo(array, index);
		}
		public int Count
		{
			get { return (_list == null)? 0: _list.Count; }
		}
		public bool IsSynchronized
		{
			get { return _list.IsSynchronized; }
		}
		public object SyncRoot
		{
			get { return _list.SyncRoot; }
		}

		// IEnumerable

		IEnumerator IEnumerable.GetEnumerator()
		{
			return _list.GetEnumerator();
		}
	}

	/// <summary>
	/// ListDataItem
	/// wrapper for list items to notify data source of IEditableObject events.
	/// (this is needed for decent AddNew support)
	/// </summary>
	internal class ListDataItem : IEditableObject
	{
		private ListDataSource _ds;
		internal object _value;
		public ListDataItem(ListDataSource ds, object value)
		{
			_ds = ds;
			_value = value;
		}
		void IEditableObject.BeginEdit()
		{
			_ds.BeginEdit();
		}
		void IEditableObject.CancelEdit()
		{
			_ds.CancelEdit();
		}
		void IEditableObject.EndEdit()
		{
			_ds.EndEdit();
		}
	}

	/// <summary>
	/// ListPropertyDescriptor
	/// extends PropertyDescriptor to notify data source of changes
	/// </summary>
	internal class ListPropertyDescriptor : PropertyDescriptor
	{
		private ListDataSource _ds;
		private PropertyDescriptor _pd;
		internal ListPropertyDescriptor(ListDataSource ds, PropertyDescriptor pd) : base(pd.Name, null)
		{
			_ds = ds;
			_pd = pd;
		}

		override public object GetValue(object component)
		{
			if (component is ListDataItem)
				component = ((ListDataItem)component)._value;
			return _pd.GetValue(component);
		}
		override public void SetValue(object component, object value)
		{
			if (component is ListDataItem)
				component = ((ListDataItem)component)._value;
			_pd.SetValue(component, value);
			_ds.ItemChanged(component);
		}

		override public void AddValueChanged(object component, EventHandler handler)
		{
			_pd.AddValueChanged(component, handler);
		}
		override public bool CanResetValue(object component)
		{
			return _pd.CanResetValue(component);
		}
		override public Type ComponentType 
		{
			get { return _pd.ComponentType; }
		}
		override public TypeConverter Converter 
		{
			get { return _pd.Converter; }
		}
		override public bool IsReadOnly
		{
			get { return _pd.IsReadOnly; }
		}
		override public Type PropertyType
		{
			get { return _pd.PropertyType; }
		}
		override public void ResetValue(object component)
		{
			_pd.ResetValue(component);
		}
		override public bool ShouldSerializeValue(object component)
		{
			return _pd.ShouldSerializeValue(component);
		}
	}

	/// <summary>
	/// ListItemComparer
	/// generic comparer for ListDataSource items
	/// </summary>
	internal class ListItemComparer : IComparer
	{
		PropertyDescriptor _pd;
		ListSortDirection _dir;
		internal ListItemComparer(PropertyDescriptor property, ListSortDirection direction)
		{
			_pd = property;
			_dir = direction;
		}
		public int Compare(object x, object y)
		{
			x = _pd.GetValue(x);
			if (x is IComparable)
			{
				y = _pd.GetValue(y);
				int cmp = ((IComparable)x).CompareTo(y);
				return (_dir == ListSortDirection.Ascending)
					? cmp: -cmp;
			}
			return 0;
		}
	}
}