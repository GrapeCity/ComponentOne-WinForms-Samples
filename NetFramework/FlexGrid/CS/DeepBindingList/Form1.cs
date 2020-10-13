using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeepBindingList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // create a list with deep data
            var list = new DeepBindingList<Person>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new Person());
            }

            // bind data to grid
            _flex.AutoGenerateColumns = false;
            _flex.DataSource = list;

            // specify the columns to bind to
            var cols = new string[] 
            {
                "Name", 
                "Home.Street", "Home.City", "Home.ZipCode" , "Home.Country.Name",
                "Work.Street", "Work.City", "Work.ZipCode" , "Work.Country.Name"
            };

            // bind to specific columns
            _flex.Cols.Count = 0;
            foreach (var name in cols)
            {
                var col = _flex.Cols.Add();
                col.Name = name;
                col.Caption = name;
            }
        }
    }

    // sample data classes
    public class Person : INotifyPropertyChanged
    {
        static Random _rnd = new Random();
        static string[] _names = "Arnold,Dave,Sunny,Gary,Todd,Kevin,Gomez,Chris,Paul,George,John,James,Robert,Jimmy,Ronnie,Tyler".Split(',');

        string _name;
        Address _home, _work;

        public Person()
        {
            Name = _names[_rnd.Next() % _names.Length];
            Home = new Address();
            Work = new Address();
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public Address Home 
        {
            get { return _home; }
            set
            {
                if (_home != null)
                {
                    _home.PropertyChanged -= _subObject_PropertyChanged;
                }
                _home = value;
                if (_home != null)
                {
                    _home.PropertyChanged += _subObject_PropertyChanged;
                }
                OnPropertyChanged("Home");
            }
        }
        public Address Work
        {
            get { return _work; }
            set
            {
                if (_work != null)
                {
                    _work.PropertyChanged -= _subObject_PropertyChanged;
                }
                _work = value;
                if (_work != null)
                {
                    _work.PropertyChanged += _subObject_PropertyChanged;
                }
                OnPropertyChanged("Work");
            }
        }

        //---------------------------------------------------------------------------
        #region ** INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        void _subObject_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(null);
        }

        #endregion
    }
    public class Address : INotifyPropertyChanged
    {
        static Random _rnd = new Random();
        static string[] _streets = "Channing 123,Telegraph 123,Shattuck 123,Hearst 123,Main 123,Broad 123,Alcatraz 123,College 123".Split(',');
        static string[] _cities = "Berkeley,Oakland,Danville,Richmond,Tiburon,Mill Valley,Calistoga,Alameda,Fairfax,Lafayette,Walnut Creek".Split(',');

        string _street, _city, _zipCode;
        Country _country;

        public Address()
        {
            Street = _streets[_rnd.Next() % _streets.Length];
            City = _cities[_rnd.Next() % _cities.Length];
            ZipCode = string.Format("{0:00000}-{1:000}", _rnd.Next() % 10000, _rnd.Next() % 1000);
            Country = new Country();
        }
        public string Street
        {
            get { return _street; }
            set
            {
                _street = value;
                OnPropertyChanged("Street");
            }
        }
        public string City
        {
            get { return _city; }
            set
            {
                _city = value;
                OnPropertyChanged("City");
            }
        }
        public string ZipCode 
        {
            get { return _zipCode; }
            set
            {
                _zipCode = value;
                OnPropertyChanged("ZipCode");
            }
        }
        public Country Country
        {
            get { return _country; }
            set
            {
                if (_country != null)
                {
                    _country.PropertyChanged -= _subObject_PropertyChanged;
                }
                _country = value;
                if (_country != null)
                {
                    _country.PropertyChanged += _subObject_PropertyChanged;
                }
                OnPropertyChanged("Country");
            }
        }

        //---------------------------------------------------------------------------
        #region ** INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
        void _subObject_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(null);
        }

        #endregion
    }
    public class Country : INotifyPropertyChanged
    {
        static string[] _names = "Austria,Belarus,Chile,Denmark,Estonia,Finland,Germany,Hungary,Italy,Japan,Korea,Luxembourg,Malaysia".Split(',');
        static Random _rnd = new Random();

        string _name, _culture;
        int _population;

        public Country()
        {
            Name = _names[_rnd.Next() % _names.Length];
            Population = _rnd.Next(10, 300);
            Culture = Name.Substring(0, 3);
        }
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public int Population
        {
            get { return _population; }
            set
            {
                _population = value;
                OnPropertyChanged("Population");
            }
        }
        public string Culture
        {
            get { return _culture; }
            set
            {
                _culture = value;
                OnPropertyChanged("Culture");
            }
        }

        #region ** INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        #endregion
    }
}
