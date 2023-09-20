//----------------------------------------------------------------------------
// BindingArrayList.cs
//
// This is a part of the C1FlexReportDesigner application sources.
// Copyright (C) MESCIUS, Inc.
// All rights reserved.
//----------------------------------------------------------------------------
using System;
using System.Reflection;
using System.Collections;
using System.ComponentModel;

namespace SqlBuilder
{
	/// <summary>
    /// Extends ArrayList with a simple IBindingList implementation.
	/// </summary>
	public class BindingArrayList : ArrayList, IBindingList, ITypedList, IComparer
	{
		//---------------------------------------------------------------------
		#region ** fields

		private string	_name			= string.Empty;
		private Type	_itemType		= null;
		private ConstructorInfo _ctorInfo = null;
		private PropertyDescriptorCollection _pdc = null;

		private bool	_allowNew		= true;
		private bool	_allowEdit		= true;
		private bool	_allowRemove	= true;
		private bool	_allowSort		= true;

		#endregion

		//---------------------------------------------------------------------
		#region ** ctor

		public BindingArrayList(string name, Type itemType)
		{
			// store list name
			_name = name;

			// store item type
			_itemType = itemType;

			// store ctor info
			_ctorInfo = itemType.GetConstructor(new Type[0]);

			// store property descriptor collection
			_pdc = new PropertyDescriptorCollection(null);
			foreach (PropertyDescriptor pd in TypeDescriptor.GetProperties(itemType))
			{
				if (!pd.Attributes.Contains(BrowsableAttribute.No))
				{
					_pdc.Add(new BindingArrayListPropertyDescriptor(this, pd));
				}
			}
		}

		#endregion

		//---------------------------------------------------------------------
		#region ** object model

		public bool AllowSort
		{
			get { return _allowSort; }
			set { _allowSort = value; }
		}
		public bool AllowRemove
		{
			get { return _allowRemove; } 
			set { _allowRemove = value; } 
		}
		#endregion

		//---------------------------------------------------------------------
		#region ** notification mechanism

		protected void OnListChanged(ListChangedType change)
		{
			OnListChanged(change, -1);
		}
		protected void OnListChanged(ListChangedType change, int index)
		{
			if (ListChanged != null)
			{
				ListChangedEventArgs e = new ListChangedEventArgs(change, index, -1);
				ListChanged(this, e);
			}
		}
		protected void OnItemChanged(object item)
		{
			if (item == null)
			{
				OnListChanged(ListChangedType.Reset);
				return;
			}
			int index = IndexOf(item);
			if (index > -1)
				OnListChanged(ListChangedType.ItemChanged, index);
		}
		#endregion

		//---------------------------------------------------------------------
		#region ** IBindingList implementation

		// notifications
		public event ListChangedEventHandler ListChanged;
		bool IBindingList.SupportsChangeNotification	{ get { return true; } }

		// sorting
		private PropertyDescriptor _sortProperty;
		private ListSortDirection  _sortDirection;
		public bool SupportsSorting				
		{
			get { return _allowSort; } 
			set { _allowSort = value; } 
		}
		void IBindingList.RemoveSort()
		{
			if (_sortProperty != null)
			{
				_sortProperty = null; 
				OnListChanged(ListChangedType.Reset);
			}
		}
		PropertyDescriptor IBindingList.SortProperty	
		{
			get { return _sortProperty; } 
		}
		ListSortDirection IBindingList.SortDirection
		{
			get { return _sortDirection; } 
		}
		bool IBindingList.IsSorted					
		{
			get { return _sortProperty != null;  }
		}
		void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
		{
			_sortProperty = property;
			_sortDirection = direction;
			if (_sortProperty != null)
				Sort((IComparer)this);
		}

		// add/edit
		public bool AllowNew			
		{
			get { return _allowNew && _ctorInfo != null; } 
			set { _allowNew = value; }
		}
		object IBindingList.AddNew()
		{
			object value = _ctorInfo.Invoke(null);
			Add(value);
			return value;
		}
		public bool AllowEdit				
		{
			get { return _allowEdit; } 
			set { _allowEdit = value; } 
		}

		// indexing (not supported)
		bool IBindingList.SupportsSearching			{ get { return false; } }
		void IBindingList.AddIndex(PropertyDescriptor property) { throw new NotSupportedException(); }
		int  IBindingList.Find(PropertyDescriptor property, object key) { throw new NotSupportedException(); }
		void IBindingList.RemoveIndex(PropertyDescriptor property) { throw new NotSupportedException(); }

		#endregion

		//---------------------------------------------------------------------
		#region ** ITypedList implementation

		PropertyDescriptorCollection ITypedList.GetItemProperties(PropertyDescriptor[] listAccessors)
		{
			return _pdc;
		}
		string ITypedList.GetListName(PropertyDescriptor[] listAccessors)
		{
			return _name;
		}
		#endregion

		//---------------------------------------------------------------------
		#region ** IComparer implementation

		int IComparer.Compare(object x, object y)
		{
			x = _sortProperty.GetValue(x);
			y = _sortProperty.GetValue(y);
			int retval = Comparer.Default.Compare(x, y);
			return (_sortDirection == ListSortDirection.Ascending)
				? +retval
				: -retval;
		}

		#endregion

		//---------------------------------------------------------------------
		#region ** overrides (with added notifications)

		public override int Add(object value)
		{
			CheckType(value);
			int index = base.Add(value);
			OnListChanged(ListChangedType.ItemAdded, index);
			return index;
		}
		public override void AddRange(ICollection c)
		{
			foreach (object value in c)
				CheckType(value);
			base.AddRange(c);
			OnListChanged(ListChangedType.Reset);
		}
		public override void Clear()
		{
			base.Clear();
			OnListChanged(ListChangedType.Reset);
		}
		public override void Insert(int index, object value)
		{
			CheckType(value);
			base.Insert(index, value);
			OnListChanged(ListChangedType.ItemAdded, index);
		}
		public override void InsertRange(int index, ICollection c)
		{
			foreach (object value in c)
				CheckType(value);
			base.InsertRange(index, c);
			OnListChanged(ListChangedType.Reset);
		}
		public override void Remove(object obj)
		{
			int index = IndexOf(obj);
			base.Remove(obj);
			OnListChanged(ListChangedType.ItemDeleted, index);
		}
		public override void RemoveAt(int index)
		{
			base.RemoveAt(index);
			OnListChanged(ListChangedType.ItemDeleted, index);
		}
		public override void RemoveRange(int index, int count)
		{
			base.RemoveRange(index, count);
			OnListChanged(ListChangedType.Reset);
		}
		public override void Sort()
		{
			base.Sort();
			OnListChanged(ListChangedType.Reset);
		}
		public override void Sort(int index, int count, IComparer comparer)
		{
			base.Sort(index, count, comparer);
			OnListChanged(ListChangedType.Reset);
		}
		public override void Sort(IComparer comparer)
		{
			base.Sort(comparer);
			OnListChanged(ListChangedType.Reset);
		}
		public override void Reverse()
		{
			base.Reverse();
			OnListChanged(ListChangedType.Reset);
		}
		public override void Reverse(int index, int count)
		{
			base.Reverse(index, count);
			OnListChanged(ListChangedType.Reset);
		}
		public override void SetRange(int index, ICollection c)
		{
			foreach (object value in c)
				CheckType(value);
			base.SetRange(index, c);
			OnListChanged(ListChangedType.Reset);
		}
		public override object this[int index]
		{
			get { return base[index]; }
			set
			{
				if (base[index] != value)
				{
					CheckType(value);
					base[index] = value;
					OnListChanged(ListChangedType.ItemChanged, index);
				}
			}
		}
		private void CheckType(object value)
		{
			if (value.GetType() != _itemType)
				throw new ArgumentException(string.Format("Wrong item type, should be {0}.", _itemType));
		}
		#endregion

		//---------------------------------------------------------------------
		#region ** helper class: BindingArrayListPropertyDescriptor

		/// <summary>
		/// BindingArrayListPropertyDescriptor
		/// extends PropertyDescriptor to notify data source of changes
		/// </summary>
		private class BindingArrayListPropertyDescriptor : PropertyDescriptor
		{
			// ** fields
			private BindingArrayList _list;
			private PropertyDescriptor _pd;

			// ** ctor
			internal BindingArrayListPropertyDescriptor(BindingArrayList list, PropertyDescriptor pd) : base(pd.Name, null)
			{
				
				_list = list;
				_pd = pd;
			}

			// ** overrides
			override public void SetValue(object obj, object value)
			{
				_pd.SetValue(obj, value);
				_list.OnItemChanged(obj);
			}

			// these are abstracts and need to be here
			// they don't do anything, just defer to the wrapped pd...
			override public object GetValue(object obj)		{ return _pd.GetValue(obj); }
			override public void AddValueChanged(object obj, EventHandler handler) { _pd.AddValueChanged(obj, handler); }
			override public bool CanResetValue(object obj)	{ return _pd.CanResetValue(obj); }
			override public Type ComponentType				{ get { return _pd.ComponentType; }}
			override public TypeConverter Converter			{ get { return _pd.Converter; }}
			override public bool IsReadOnly					{ get { return _pd.IsReadOnly; }}
			override public Type PropertyType				{ get { return _pd.PropertyType; }}
			override public void ResetValue(object obj)		{ _pd.ResetValue(obj); }
			override public bool ShouldSerializeValue(object obj) { return _pd.ShouldSerializeValue(obj); }
		}
		#endregion
	}
}
