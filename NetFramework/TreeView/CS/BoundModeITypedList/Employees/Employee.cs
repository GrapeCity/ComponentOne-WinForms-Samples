using System.ComponentModel;

namespace SamplesData
{
    public class Employee
    {
        private int _id;
        private int _chiefID;
        private string _firstName;
        private string _lastName;
        private string _post;

        public Employee()
        { }

        public Employee(int id, int chiefID, string firstName, string lastName, string post)
        {
            _id = id;
            _chiefID = chiefID;
            _firstName = firstName;
            _lastName = lastName;
            _post = post;
        }

        [Browsable(false)]
        public int ID
        {
            get { return _id; }
            set
            {
                if (_id != value)
                {
                    _id = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("ID"));
                }
            }
        }
        [Browsable(false)]
        public int ChiefID
        {
            get { return _chiefID; }
            set
            {
                if (_chiefID != value)
                {
                    _chiefID = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("ChiefID"));
                }
            }
        }
        public string Post
        {
            get { return _post; }
            set
            {
                if (_post != value)
                {
                    _post = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Post"));
                }
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("LastName"));
                }
            }
        }
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("FirstName"));
                }
            }
        }               

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }

        #endregion
    }
}
