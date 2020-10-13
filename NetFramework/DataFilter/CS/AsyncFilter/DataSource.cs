using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace AsyncFilter
{
    public class Employee
    {
        private static Random s_rnd = new Random();

        private static string[] s_names = new string[] { "John", "Alex", "Alfred", "Elena", "Eric", "Sara", "Mila", "Gloria", "Mary", "Natalie", "Ivan", "Stan", "Don", "Joseph",
            "Jack", "Olivia", "Caleb", "Dylan", "Samantha", "Tyler", "Victor", "James", "Jason", "Peter","Tony"};

        private static string[] s_lastNames = new string[] { "Doe", "Red", "Bon", "White", "Green", "Blue", "Vong", "Li", "Black", "Sue", "Ming", "Romanov", "Heck", "Milman",
            "Anderson", "Gun", "Helt", "Iron", "Gold", "Silver", "Steel", "Smith", "Bond", "Bourne", "McClane", "Parker", "Stark" };

        public static Post[] Posts { get; } 
            = new Post[]
            {
                new Post() { Id = 0, Title = "Engineer" },
                new Post() { Id = 1, Title = "Manager" },
                new Post() { Id = 2, Title = "Manager's assistant" },
                new Post() { Id = 3, Title = "Security" },
                new Post() { Id = 4, Title = "Secretary" },
                new Post() { Id = 5, Title = "Accountant" },
                new Post() { Id = 6, Title = "HR" },
                new Post() { Id = 7, Title = "Courier" },
                new Post() { Id = 8, Title = "Cleaner" },
            };

        public static Country[] Countries { get; }
            = new Country[]
            {
                new Country() { Id = 0, Name = "Canada" },
                new Country() { Id = 1, Name = "China" },
                new Country() { Id = 2, Name = "Germany" },
                new Country() { Id = 3, Name = "Ireland" },
                new Country() { Id = 4, Name = "Japan" },                
                new Country() { Id = 5, Name = "New Zealand" },
                new Country() { Id = 6, Name = "Poland" },
                new Country() { Id = 7, Name = "United Kingdom" },
                new Country() { Id = 8, Name = "United States" },
            };

        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("Post")]
        public int PostId { get; set; }
        public string Name { get; set; }
        [DisplayName("Last name")]
        public string LastName { get; set; }
        [DisplayName("Employment date")]
        public DateTime EmploymentDate { get; set; }
        [DisplayName("Country")]
        [Range(0,8)]
        public int CountryId { get; set; } 


        public static List<Employee> GenerateData()
        {
            var today = DateTime.Today;
            var list = new List<Employee>();
            for (int i = 0; i < 10000000; i++)
            {
                list.Add(new Employee()
                {
                    Name = s_names[s_rnd.Next(0, s_names.Length)],
                    LastName = s_lastNames[s_rnd.Next(0, s_lastNames.Length)],
                    PostId = s_rnd.Next(0, Posts.Max(x => x.Id) + 1),
                    Id = i,
                    EmploymentDate = today.AddYears(-s_rnd.Next(2, 25)),
                    CountryId = s_rnd.Next(0, 9)
                });
            }
            return list;
        }
    }

    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
