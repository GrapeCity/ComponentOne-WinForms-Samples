using C1.DataCollection;
using C1.DataEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataFilterExplorer.Data
{
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

    public class Employee
    {
        [Browsable(false)]
        public int Id { get; set; }
        [DisplayName("Post")]
        public int PostId { get; set; }
        public string FirstName { get; set; }
        [DisplayName("Last name")]
        public string LastName { get; set; }
        [DisplayName("Employment date")]
        public DateTime EmploymentDate { get; set; }
        [DisplayName("Country")]
        [Range(0, 8)]
        public int CountryId { get; set; }

        public static readonly string[] Names = new string[] { "John", "Alex", "Alfred", "Elena", "Eric", "Sara", "Mila", "Gloria", "Mary", "Natalie", "Ivan", "Stan", "Don", "Joseph",
            "Jack", "Olivia", "Caleb", "Dylan", "Samantha", "Tyler", "Victor", "James", "Jason", "Peter","Tony"};

        public static readonly string[] LastNames = new string[] { "Doe", "Red", "Bon", "White", "Green", "Blue", "Vong", "Li", "Black", "Sue", "Ming", "Romanov", "Heck", "Milman",
            "Anderson", "Gun", "Helt", "Iron", "Gold", "Silver", "Steel", "Smith", "Bond", "Bourne", "McClane", "Parker", "Stark" };
    }

    public partial class DataService
    {
        private static readonly Random _rnd = new();

        public const string PostTableName = "post";
        public const string EmployeeTableName = "employee";
        public const string CountryTableName = "country";

        public static string PostTablePath => $"{PostTableName}.json";
        public static string EmployeeTablePath => $"{EmployeeTableName}.json";
        public static string CountryTablePath => $"{CountryTableName}.json";

        public static bool TablesExists() => File.Exists(PostTablePath) && File.Exists(EmployeeTablePath) && File.Exists(CountryTablePath);

        public static async Task GenerateData()
        {
                await SerializeData(PostTablePath, Posts);
                await SerializeData(CountryTablePath, Countries);
                await SerializeData(EmployeeTablePath, GenerateEmployee());
        }

        public static async Task<(IDataCollection<object>, int, long)> LoadDataCollection(Workspace workspace,string name)
        {
            var sw = new Stopwatch();
            sw.Start();
            // data engine            
            workspace.Init(name);
            workspace.KeepFiles = KeepFileType.None;
            workspace.ReuseJoins = false;
            workspace.Clear(ClearFileType.All);
            var postList = await DeserializeData<Post>(PostTablePath);
            await Task.Run(() => LoadTable(PostTableName, postList, workspace));
            var employeeList = await DeserializeData<Employee>(EmployeeTablePath);
            await Task.Run(() => LoadTable(EmployeeTableName, employeeList, workspace));
            var countryList = await DeserializeData<Country>(CountryTablePath);
            await Task.Run(() => LoadTable(CountryTableName, countryList, workspace));
            
            dynamic employee = workspace.table(EmployeeTableName);
            dynamic post = workspace.table(PostTableName);
            dynamic country = workspace.table(CountryTableName);
            dynamic join = workspace.join(employee, new
            {
                postTitle = post.Title.As("PostTitle") | employee.PostId == post.Id,
                countryName = country.Name.As("CountryName") | employee.CountryId == country.Id,
            });
            var collection = new C1DataEngineCollection(workspace, join);
            sw.Stop();
            // data collection
            return (collection, employeeList.Count(), sw.ElapsedMilliseconds);
        }

        private static async Task<IEnumerable<T>> DeserializeData<T>(string fileName)
        {
            using FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            var result =  await JsonSerializer.DeserializeAsync<IEnumerable<T>>(stream);
            stream.Close();
            return result;
        }

        private static async Task SerializeData<T>(string fileName, IEnumerable<T> enumerable)
        {
            using FileStream stream = File.Create(fileName, 0, FileOptions.Asynchronous);
            await JsonSerializer.SerializeAsync(stream, enumerable);
            stream.Flush();
            stream.Close();
        }

        private static void LoadTable<T>(string tableName, IEnumerable<T> list, Workspace workspace)
        {
            var connector = new ObjectConnector<T>(workspace, list);
            connector.GetData(tableName);
            workspace.Save();
        }

        private static IEnumerable<Employee> GenerateEmployee()
        {
            var today = DateTime.Today;
            return Enumerable.Range(0, 1000000).Select(i =>
                 new Employee()
                 {
                     FirstName = Employee.Names[_rnd.Next(0, Employee.Names.Length)],
                     LastName = Employee.LastNames[_rnd.Next(0, Employee.LastNames.Length)],
                     PostId = _rnd.Next(0, Posts.Max(x => x.Id) + 1),
                     Id = i,
                     EmploymentDate = today.AddYears(-_rnd.Next(2, 25)),
                     CountryId = _rnd.Next(0, 9)
                 });
        }

        private static Post[] Posts { get; }
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

        private static Country[] Countries { get; }
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

        public static DataTable GetDataSource()
        {
            var dt = new DataTable();
            dt.Columns.Add("Brand");
            dt.Columns.Add("Model");
            dt.Columns.Add("HP", typeof(int));
            dt.Columns.Add("Liter", typeof(double));
            dt.Columns.Add("Cylinder", typeof(int));
            dt.Columns.Add("TransmissionSpeedCount", typeof(int));
            dt.Columns.Add("AutomaticTransmission", typeof(bool));
            dt.Columns.Add("Category");
            dt.Columns.Add("StartSaleDate", typeof(DateTime));
            dt.Columns.Add("Price", typeof(int));

            dt.Rows.Add("Mercedes-Benz", "SLK R172 Cabriolet", 302, 4.966, 8, 5, true, "Sports", new DateTime(2011, 1, 1), 83800);
            dt.Rows.Add("Mercedes-Benz", "SL AMG R231 Cabriolet", 342, 5.439, 8, 5, true, "Sports", new DateTime(2012, 1, 1), 79645);
            dt.Rows.Add("Mercedes-Benz", "SL R231 Cabriolet", 189, 1.796, 4, 5, true, "Sports", new DateTime(2012, 1, 1), 25600);
            dt.Rows.Add("BMW", "M3 F30 Sedan", 225, 3, 6, 6, false, "Saloon", new DateTime(2014, 1, 1), 39450);
            dt.Rows.Add("Rolls-Royce", "Wraith", 325, 6.75, 8, 4, true, "Saloon", new DateTime(2016, 1, 1), 370485);
            dt.Rows.Add("Jaguar", "XFR-S I", 235, 3, 6, 5, false, "Saloon", new DateTime(2012, 1, 1), 44320);
            dt.Rows.Add("Cadillac", "ATS I", 275, 4.6, 8, 4, true, "Saloon", new DateTime(2007, 1, 1), 49600);
            dt.Rows.Add("Cadillac", "CTS III", 275, 4.6, 8, 4, true, "Saloon", new DateTime(2007, 1, 1), 47780);
            dt.Rows.Add("Lexus", "ES VI Sedan", 290, 4.3, 8, 5, true, "Saloon", new DateTime(2005, 1, 1), 54900);
            dt.Rows.Add("Lexus", "IS III", 300, 4.3, 8, 5, true, "Saloon", new DateTime(2008, 1, 1), 41242);
            dt.Rows.Add("Ford", "Ranger VI", 135, 2.3, 4, 5, true, "Truck", new DateTime(2015, 1, 1), 12565);
            dt.Rows.Add("Dodge", "Ram 1500", 215, 3.7, 6, 4, true, "Truck", new DateTime(1981, 1, 1), 17315);
            dt.Rows.Add("GMC", "Envoy", 200, 4.3, 6, 4, true, "Truck", new DateTime(1997, 1, 1), 17748);
            dt.Rows.Add("Nissan", "Navara IV", 143, 2.4, 4, 4, true, "Truck", new DateTime(2014, 6, 1), 12800);
            dt.Rows.Add("Toyota", "HILUX VIII", 190, 3.4, 6, 5, false, "Truck", new DateTime(2015, 1, 1), 20000);
            dt.Rows.Add("Infiniti", "Q50 I", 340, 4.5, 8, 5, true, "Saloon", new DateTime(2013, 1, 1), 62300);
            dt.Rows.Add("Infiniti", "Q60 I Cabriolet", 280, 3.5, 6, 6, true, "Sports", new DateTime(2014, 1, 1), 34000);
            dt.Rows.Add("Jaguar", "F-TYPE I", 294, 4.2, 8, 6, true, "Sports", new DateTime(2013, 1, 1), 73000);
            dt.Rows.Add("Audi", DBNull.Value, 220, 3, 6, 5, true, "Saloon", new DateTime(2012, 1, 1), 38000);
            dt.Rows.Add("Audi", DBNull.Value, DBNull.Value, 1.8, 4, 6, true, "Sports", new DateTime(2014, 1, 1), 45000);
            dt.Rows.Add("BMW", "BMW 7 G11/G12 Sedan", 438, 6, 12, 6, true, "Saloon", new DateTime(2015, 1, 1), 120000);
            dt.Rows.Add(DBNull.Value, "Z4 E89 Roadster", 225, 3, 6, 6, false, "Sports", new DateTime(2013, 1, 1), 45000);
            dt.Rows.Add("Acura", "", 200, 2.4, 4, 6, false, "Sports", new DateTime(2012, 1, 1), 28500);
            dt.Rows.Add("Acura", "TLX I Sedan", DBNull.Value, 3.2, 6, 6, false, "Saloon", DBNull.Value, 95000);

            return dt;
        }

    }
}
