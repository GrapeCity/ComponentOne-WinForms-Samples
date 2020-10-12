
namespace SamplesData
{
    public class EmployeesTypedList: TypedList<Employee>
    {
        public static TypedList<Employee> GetData()
        {
            var tlist = new TypedList<Employee>();
            tlist.Add(new Employee(1, -1, "John", "Doe", "Director of sales"));
            tlist.Add(new Employee(10, 1, "Alex", "Red", "Manager"));
            tlist.Add(new Employee(100, 10, "Alfred", "Bon", "Manager's assistant"));
            tlist.Add(new Employee(11, 1, "Elena", "White", "Manager"));
            tlist.Add(new Employee(12, 1, "Eric", "Green", "Manager"));
            tlist.Add(new Employee(13, 1, "Sara", "Blue", "Manager"));
            tlist.Add(new Employee(130, 12, "Mila", "Vong", "Manager's assistant"));
            tlist.Add(new Employee(131, 12, "Alex", "Li", "Manager's assistant"));
            tlist.Add(new Employee(14, 1, "Gloria", "Black", "Manager"));

            tlist.Add(new Employee(2, -1, "Mary", "Sue", "Marketing director"));
            tlist.Add(new Employee(20, 2, "Natalie", "Ming", "Manager"));
            tlist.Add(new Employee(201, 20, "Ivan", "Romanov", "Manager's assistant"));
            tlist.Add(new Employee(202, 20, "Stan", "Heck", "Manager's assistant"));
            tlist.Add(new Employee(203, 20, "Don", "Milman", "Manager's assistant"));
            tlist.Add(new Employee(21, 2, "Joseph", "Anderson", "Manager"));
            tlist.Add(new Employee(210, 21, "Jack", "Gun", "Manager's assistant"));
            tlist.Add(new Employee(22, 2, "Olivia", "Helt", "Manager"));
            tlist.Add(new Employee(220, 22, "Caleb", "Iron", "Manager's assistant"));
            tlist.Add(new Employee(221, 22, "Dylan", "Gold", "Manager's assistant"));
            tlist.Add(new Employee(23, 2, "Samantha", "Silver", "Manager"));
            tlist.Add(new Employee(24, 2, "Tyler", "Steel", "Manager"));

            tlist.Add(new Employee(3, -1, "Victor", "Smith", "Security director"));
            tlist.Add(new Employee(31, 3, "James", "Bond", "Guard"));
            tlist.Add(new Employee(32, 3, "Jason", "Bourne", "Guard"));
            tlist.Add(new Employee(33, 3, "John", "McClane", "Guard"));
            tlist.Add(new Employee(34, 3, "Peter", "Parker", "Guard"));
            tlist.Add(new Employee(35, 3, "Tony", "Stark", "Guard"));

            return tlist;
        }
    }
}
