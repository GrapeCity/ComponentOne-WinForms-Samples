using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.C1Schedule;
using C1.Win.C1Schedule;

namespace ControlExplorer.Schedule
{
    public partial class CustomDialog : C1DemoForm
    {
        // collection of levels
        LevelCollection _levels;
        // collection of categories
        ExcerciseCategories _categories;
        // array of locations
        ArrayList _locations;
        // array of instructors
        ArrayList _instructors;

        public CustomDialog()
        {
            InitializeComponent();
            // create level and category collections
            _levels = new LevelCollection();
            _categories = new ExcerciseCategories();

            // fill array of locations
            _locations = new ArrayList();
            _locations.Add(new Location(0, "LA Spin"));
            _locations.Add(new Location(1, "Studio 1"));
            _locations.Add(new Location(2, "Studio 2"));
            _locations.Add(new Location(3, "Pool"));
            _locations.Add(new Location(4, "Sauna"));
            _locations.Add(new Location(5, "Studio 3"));

            // fill array of instructors
            _instructors = new ArrayList();
            _instructors.Add(new Instructor(0, "Brenda Lee Arnold"));
            _instructors.Add(new Instructor(1, "Ryan Conover"));
            _instructors.Add(new Instructor(2, "John DiCicco"));
            _instructors.Add(new Instructor(3, "Linda Donkelaar"));
            _instructors.Add(new Instructor(4, "Kimberly Guenther"));
            _instructors.Add(new Instructor(5, "Melissa Sheller"));
            _instructors.Add(new Instructor(6, "Jeff Unterkofler"));
            _instructors.Add(new Instructor(7, "Karen Black"));

            // Set mappings for LabelStorage (map Level to C1.C1Schedule.Label object properties)
            this.c1Schedule1.DataStorage.LabelStorage.Mappings.TextMapping.MappingName = "LevelName";
            this.c1Schedule1.DataStorage.LabelStorage.Mappings.CaptionMapping.MappingName = "Description";
            this.c1Schedule1.DataStorage.LabelStorage.Mappings.ColorMapping.MappingName = "ColorString";
            this.c1Schedule1.DataStorage.LabelStorage.Mappings.IdMapping.MappingName = "Id";
            // Set LabelStorage DataSource
            this.c1Schedule1.DataStorage.LabelStorage.DataSource = _levels.Values;

            // Set mappings for CategoryStorage (map ExcerciseCategory to C1.C1Schedule.Category object properties)
            this.c1Schedule1.DataStorage.CategoryStorage.Mappings.TextMapping.MappingName = "Name";
            this.c1Schedule1.DataStorage.CategoryStorage.Mappings.IndexMapping.MappingName = "Id";
            // Set CategoryStorage DataSource
            this.c1Schedule1.DataStorage.CategoryStorage.DataSource = _categories;// Set mappings for ResourceStorage (map Location to C1.C1Schedule.Resource object properties)
            this.c1Schedule1.DataStorage.ResourceStorage.Mappings.TextMapping.MappingName = "Name";
            this.c1Schedule1.DataStorage.ResourceStorage.Mappings.IndexMapping.MappingName = "Id";
            // Set ResourceStorage DataSource
            this.c1Schedule1.DataStorage.ResourceStorage.DataSource = _locations;

            // Set mappings for ContactStorage (map Instructors to C1.C1Schedule.Contact object properties)
            this.c1Schedule1.DataStorage.ContactStorage.Mappings.TextMapping.MappingName = "Name";
            this.c1Schedule1.DataStorage.ContactStorage.Mappings.IndexMapping.MappingName = "Id";
            // Set ContactStorage DataSource
            this.c1Schedule1.DataStorage.ContactStorage.DataSource = _instructors;
        }

        private void c1Schedule1_BeforeAppointmentCreate(object sender, CancelAppointmentEventArgs e)
        {
            // Don't show built-in form
            e.Cancel = true;
            // Create new Appointment object with currently selected DateTime and default 
            // exercise duration (45 minutes)
            Appointment app = c1Schedule1.DataStorage.AppointmentStorage.Appointments.Add(
                c1Schedule1.CurrentDate, TimeSpan.FromMinutes(45));
            // Create ExcerciseForm for the new appointment
            ExcerciseForm form = new ExcerciseForm(c1Schedule1, app);
            // Show form
            if (form.ShowDialog() != DialogResult.OK)
            {
                // If user closes form without saving, remove appointment
                app.Delete();
            }
        }

        private void c1Schedule1_BeforeViewChange(object sender, BeforeViewChangeEventArgs e)
        {
            // never switch to other views
            e.ViewType = ScheduleViewEnum.WorkWeekView;
        }

        private void c1Schedule1_BeforeAppointmentShow(object sender, CancelAppointmentEventArgs e)
        {
            // Don't show built-in form
            e.Cancel = true;
            // Create ExcerciseForm for selected Appointment
            ExcerciseForm form = new ExcerciseForm(c1Schedule1, e.Appointment);
            // Show form
            form.ShowDialog();
        }
    }

    #region "Exercise Categories"
    /// <summary>
    /// The ExcerciseCategory class describes category of excercises.
    /// </summary>
    public class ExcerciseCategory
    {
        private int _id;
        private string _name;

        /// <summary>
        /// Creates new instance of ExcerciseCategory object with specified parameters.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public ExcerciseCategory(int id, String name)
        {
            _id = id;
            _name = name;
        }

        /// <summary>
        /// Gets or sets the name of ExcerciseCategory.
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
        /// Gets or sets an integer key for ExcerciseCategory, which can be used
        /// for identifying ExcerciseCategory objects.
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
    /// ExcerciseCategories list keeps the list of all available ExcerciseCategory.
    /// </summary>
    public class ExcerciseCategories : List<ExcerciseCategory>
    {
        /// <summary>
        /// Creates new instance of ExcerciseCategories class and fills it with
        /// the predefined set of ExcerciseCategory objects.
        /// </summary>
        public ExcerciseCategories()
        {
            LoadDefaults();
        }

        /// <summary>
        /// Fills ExcerciseCategories list with the predefined set of 
        /// ExcerciseCategory objects.		
        /// </summary>
        public void LoadDefaults()
        {
            Clear();
            Add(new ExcerciseCategory(0, "Calorie burning"));
            Add(new ExcerciseCategory(1, "Mind and Body"));
            Add(new ExcerciseCategory(2, "Body conditioning"));
            Add(new ExcerciseCategory(3, "Combination"));
        }
    }
    #endregion

    #region "Locations"
    /// <summary>
    /// This class represents an excercise location (for example, Studio or Pool).
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
    #endregion

    #region "Instructors"
    /// <summary>
    /// This class represents instructors.
    /// </summary>
    class Instructor
    {
        private int _id;
        private string _name;

        /// <summary>
        /// Creates new instance of Location object whith the specified parameters.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        public Instructor(int id, String name)
        {
            _id = id;
            _name = name;
        }

        /// <summary>
        /// Gets or sets Instructor name.
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
        /// Unique Id of Instructor.
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
        /// Returns Instructor Name.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name;
        }
    }
    #endregion

    #region "Levels"
    /// <summary>
    /// This class represents exercise level (for example, beginning or intermediate).
    /// It is used for coloring exercises on the time table.
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
                Color.LightGoldenrodYellow, "Beginner", "Beginner");
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
    #endregion
}
