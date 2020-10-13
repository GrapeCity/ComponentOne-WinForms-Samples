using System;
using System.Collections.Generic;
using System.Text;

namespace TestSchedule
{
	/// <summary>
	/// This class represents an Exercise location (for example, Studio or Pool).
	/// </summary>
	class Location
	{
		private int _id;
		private string _name;

		/// <summary>
		/// Creates new instance of Location object whith the specified parameters.
		/// </summary>
		/// <param name="id"></param>
		/// <param name="name"></param>
		public Location(int id, String name) 
		{
			_id = id;
			_name = name;
		}

		/// <summary>
		/// Gets or sets Location name.
		/// </summary>
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				if (_name != value)
				{
					_name = value;
                }
			}
		}

		/// <summary>
		/// Unique Id of Location.
		/// </summary>
		public int Id
		{
			get
			{
				return _id;
			}
			set
			{
				if (_id != value)
				{
					_id = value;
				}
			}
		}

		/// <summary>
		/// Returns LocationName.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return Name;
		}
	}
}
