using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;

namespace CustomData
{
	/// <summary>
	/// This class represents Exercise level (for example, beginning or intermediate).
	/// It is used for coloring Exercises on the time table.
	/// </summary>
	public class Level
	{
		private Guid _id;
		private Color _color;
		private string _levelName;
		private string _description;

		/// <summary>
		/// Creates a new instance of the Level object with the specified properties.
		/// </summary>
		/// <param name="id"></param>
		/// <param name="color"></param>
		/// <param name="name"></param>
		/// <param name="description"></param>
		public Level(Guid id, Color color, String name, String description) 
		{
			_id = id;
			_color = color;
			_levelName = name;
			_description = description;
		}

		/// <summary>
		/// Gets or sets level name. 
		/// </summary>
		public string LevelName
		{
			get
			{
				return _levelName;
			}
			set
			{
				if (_levelName != value)
				{
					_levelName = value;
                }
			}
		}

		/// <summary>
		/// Gets or sets level description. 
		/// </summary>
		public string Description
		{
			get
			{
				return _description;
			}
			set
			{
				if (_description != value)
				{
					_description = value;
                }
			}
		}

		/// <summary>
		/// Gets or sets level color. 
		/// </summary>
		public Color Color
		{
			get
			{
				return _color;
			}
			set
			{
				if (!_color.Equals(value))
				{
					_color = value;
                }
			}
		}

		/// <summary>
		/// Gets or sets argb string, specifying the color of level.
		/// This property necessary for mapping color to the LabelStorage.
		/// </summary>
		public string ColorString
		{
			get
			{
				return _color.A.ToString() + ", " +
						_color.R.ToString() + ", " +
						_color.G.ToString() + ", " +
						_color.B.ToString();
			}
			set
			{
				TypeConverter tc = TypeDescriptor.GetConverter(typeof(Color));
				_color = (Color)tc.ConvertFromInvariantString(value);
			}
		}

		/// <summary>
		/// Unique Id of the Level.
		/// </summary>
		public Guid Id
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
		/// Returns LevelName.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return LevelName;
		}
	}

	/// <summary>
	/// Dictionary of Level objects.
	/// </summary>
	public class LevelCollection : Dictionary<Guid, Level>
	{
		/// <summary>
		/// Creates new LevelCollection object and fills it with the set
		/// of predefines Level objects.
		/// </summary>
		public LevelCollection()
		{
            LoadDefaults();
		}

		/// <summary>
		/// Fills LevelCollection with the set of predefines Level objects.
		/// </summary>
		public void LoadDefaults()
		{
			Clear();
			Level level = new Level(new Guid("{9EFA1881-A29D-461d-BC50-E8027B12DD4C}"),
				Color.White, "All", "All levels");
			Add(level.Id, level);
			level = new Level(new Guid("{DA09A26C-5AB3-460a-BD2C-E992B9E86E2B}"),
				Color.LightGoldenrodYellow,	"Beginner", "Beginner");
			Add(level.Id, level);
			level = new Level(new Guid("{7669CE0F-888C-4c50-BB4C-52E592310DDB}"),
				Color.Orange, "Advanced", "Advanced");
			Add(level.Id, level);
			level = new Level(new Guid("{BF0B75A3-031C-457a-9A21-6B0C095AF673}"),
				Color.YellowGreen, "Intermediate", "Intermediate");
			Add(level.Id, level);
			level = new Level(new Guid("{002DFB0D-46D8-4b87-9B98-9B1D909B0249}"),
				Color.SkyBlue, "Course", "Course");
			Add(level.Id, level);
		}
	}
}
