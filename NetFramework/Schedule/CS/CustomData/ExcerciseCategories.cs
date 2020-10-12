using System;
using System.Collections.Generic;
using System.Text;

namespace TestSchedule
{
	/// <summary>
	/// The ExerciseCategory class describes category of Exercises.
	/// </summary>
	public class ExerciseCategory
	{
		private int _id;
		private string _name;

		/// <summary>
		/// Creates new instance of ExerciseCategory object with specified parameters.
		/// </summary>
		/// <param name="id"></param>
		/// <param name="name"></param>
		public ExerciseCategory(int id, String name) 
		{
			_id = id;
			_name = name;
		}

		/// <summary>
		/// Gets or sets the name of ExerciseCategory.
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
		/// Gets or sets an integer key for ExerciseCategory, which can be used
		/// for identifying ExerciseCategory objects.
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
		/// Overrides the default behaviour.
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return Name;
		}
	}

	/// <summary>
	/// ExerciseCategories list keeps the list of all available ExerciseCategory.
	/// </summary>
	public class ExerciseCategories : List<ExerciseCategory>
	{
		/// <summary>
		/// Creates new instance of ExerciseCategories class and fills it with
		/// the predefined set of ExerciseCategory objects.
		/// </summary>
		public ExerciseCategories()
		{
            LoadDefaults();
		}

		/// <summary>
		/// Fills ExerciseCategories list with the predefined set of 
		/// ExerciseCategory objects.		
		/// </summary>
		public void LoadDefaults()
		{
			Clear();
			Add(new ExerciseCategory(0, "Calorie burning"));
			Add(new ExerciseCategory(1, "Mind and Body"));
			Add(new ExerciseCategory(2, "Body conditioning"));
			Add(new ExerciseCategory(3, "Combination"));
		}
	}
}
