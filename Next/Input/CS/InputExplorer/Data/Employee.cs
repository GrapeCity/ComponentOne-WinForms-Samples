using System;
using System.Collections.Generic;

namespace InputExplorer.Samples
{
    public class Employee
    {      
        public Employee()
        { }

        public Employee(int id, int chiefID, string firstName, string lastName, string post, int countryId, double yearBonus, DateTime hireDate, bool hasSpecialNeeds = false)
        {
            ID = id;
            ChiefID = chiefID;
            FirstName = firstName;
            LastName = lastName;
            Post = post;
            CountryId = countryId;
            YearBonus = yearBonus;
            HireDate = hireDate;
            HasSpecialNeeds = hasSpecialNeeds;
        }

        public int ID
        {
            get;
            set;
        }
        public int ChiefID
        {
            get;
            set;
        }
        public string Post
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public string FirstName
        {
            get;
            set;
        }
        public int CountryId
        {
            get;
            set;
        }

        public double YearBonus
        {
            get;
            set;
        }

        public DateTime HireDate
        {
            get;
            set;
        }

        public bool HasSpecialNeeds
        {
            get;
            set;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }

        public static List<Employee> GetData()
        {
            var tlist = new List<Employee>();
            tlist.Add(new Employee(1, -1, "John", "Doe", "Director of sales", 0, 15000, DateTime.Today.AddMonths(-25)));
            tlist.Add(new Employee(10, 1, "Alex", "Red", "Manager", 0, 0, DateTime.Today.AddYears(-1)));
            tlist.Add(new Employee(100, 10, "Alfred", "Bon", "Manager's assistant" , 0, 0, DateTime.Today.AddYears(-1)));
            tlist.Add(new Employee(11, 1, "Elena", "White", "Manager", 0, 0, DateTime.Today.AddYears(-1)));
            tlist.Add(new Employee(12, 1, "Eric", "Green", "Manager", 0, 0, DateTime.Today.AddYears(-1)));
            tlist.Add(new Employee(13, 1, "Sara", "Blue", "Manager", 0, 0, DateTime.Today.AddYears(-1)));
            tlist.Add(new Employee(130, 12, "Mila", "Vong", "Manager's assistant", 0, 0, DateTime.Today.AddYears(-1)));
            tlist.Add(new Employee(131, 12, "Alex", "Li", "Manager's assistant", 0, 0, DateTime.Today.AddYears(-1)));
            tlist.Add(new Employee(14, 1, "Gloria", "Black", "Manager", 0, 0, DateTime.Today.AddYears(-1)));

            tlist.Add(new Employee(2, -1, "Mary", "Sue", "Marketing director", 1, 20000, DateTime.Today.AddMonths(-14)));
            tlist.Add(new Employee(20, 2, "Natalie", "Ming", "Manager", 1, 0, DateTime.Today.AddYears(-1)));
            tlist.Add(new Employee(201, 20, "Ivan", "Romanov", "Manager's assistant", 1, 0, DateTime.Today.AddYears(-1), true));
            tlist.Add(new Employee(202, 20, "Stan", "Heck", "Manager's assistant", 1, 0, DateTime.Today.AddYears(-1)));
            tlist.Add(new Employee(203, 20, "Don", "Milman", "Manager's assistant", 1, 0, DateTime.Today.AddYears(-1)));
            tlist.Add(new Employee(21, 2, "Joseph", "Anderson", "Manager", 1, 0, DateTime.Today.AddYears(-1)));
            tlist.Add(new Employee(210, 21, "Jack", "Gun", "Manager's assistant", 1, 0, DateTime.Today.AddYears(-1)));
            tlist.Add(new Employee(22, 2, "Olivia", "Helt", "Manager", 1, 0, DateTime.Today.AddYears(-1)));
            tlist.Add(new Employee(220, 22, "Caleb", "Iron", "Manager's assistant", 1, 0, DateTime.Today.AddYears(-1)));
            tlist.Add(new Employee(221, 22, "Dylan", "Gold", "Manager's assistant", 1, 0, DateTime.Today.AddYears(-1)));
            tlist.Add(new Employee(23, 2, "Samantha", "Silver", "Manager", 1, 0, DateTime.Today.AddYears(-1), true));
            tlist.Add(new Employee(24, 2, "Tyler", "Steel", "Manager", 1, 0, DateTime.Today.AddYears(-1)));

            tlist.Add(new Employee(3, -1, "Victor", "Smith", "Security director", 2, 10000, DateTime.Today.AddYears(-5)));
            tlist.Add(new Employee(31, 3, "James", "Bond", "Guard", 2, 0, DateTime.Today.AddMonths(-36)));
            tlist.Add(new Employee(32, 3, "Jason", "Bourne", "Guard", 2, 0, DateTime.Today.AddMonths(-14)));
            tlist.Add(new Employee(33, 3, "John", "McClane", "Guard", 2, 0, DateTime.Today.AddMonths(-28)));
            tlist.Add(new Employee(34, 3, "Peter", "Parker", "Guard", 2, 1000, DateTime.Today.AddMonths(-40)));
            tlist.Add(new Employee(35, 3, "Tony", "Stark", "Guard", 2, 0, DateTime.Today.AddYears(-1)));

            return tlist;
        }
    }
}
