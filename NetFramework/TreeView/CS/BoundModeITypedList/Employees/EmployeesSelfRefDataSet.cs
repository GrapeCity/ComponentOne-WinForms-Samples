using System;
using System.Data;

namespace SamplesData
{
    public class EmployeesSelfRefDataSet
    {
        public static DataSet GetData()
        {
            var dataSet = new DataSet();
            var employees = new DataTable("Employees");

            employees.Columns.Add("ID", Type.GetType("System.Int32"));
            employees.Columns.Add("ChiefID", Type.GetType("System.Int32"));
            employees.Columns.Add("FirstName", Type.GetType("System.String"));
            employees.Columns.Add("LastName", Type.GetType("System.String"));
            employees.Columns.Add("Post", Type.GetType("System.String"));

            employees.Rows.Add(new object[5] { 1, -1, "John", "Doe", "Director of sales" });
            employees.Rows.Add(new object[5] { 10, 1, "Alex", "Red", "Manager" });
            employees.Rows.Add(new object[5] { 100, 10, "Alfred", "Bon", "Manager's assistant" });
            employees.Rows.Add(new object[5] { 11, 1, "Elena", "White", "Manager" });
            employees.Rows.Add(new object[5] { 12, 1, "Eric", "Green", "Manager" });
            employees.Rows.Add(new object[5] { 13, 1, "Sara", "Blue", "Manager" });
            employees.Rows.Add(new object[5] { 130, 12, "Mila", "Vong", "Manager's assistant" });
            employees.Rows.Add(new object[5] { 131, 12, "Alex", "Li", "Manager's assistant" });
            employees.Rows.Add(new object[5] { 14, 1, "Gloria", "Black", "Manager" });

            employees.Rows.Add(new object[5] { 2, -1, "Mary", "Sue", "Marketing director" });
            employees.Rows.Add(new object[5] { 20, 2, "Natalie", "Ming", "Manager" });
            employees.Rows.Add(new object[5] { 201, 20, "Ivan", "Romanov", "Manager's assistant" });
            employees.Rows.Add(new object[5] { 202, 20, "Stan", "Heck", "Manager's assistant" });
            employees.Rows.Add(new object[5] { 203, 20, "Don", "Milman", "Manager's assistant" });
            employees.Rows.Add(new object[5] { 21, 2, "Joseph", "Anderson", "Manager" });
            employees.Rows.Add(new object[5] { 210, 21, "Jack", "Gun", "Manager's assistant" });
            employees.Rows.Add(new object[5] { 22, 2, "Olivia", "Helt", "Manager" });
            employees.Rows.Add(new object[5] { 220, 22, "Caleb", "Iron", "Manager's assistant" });
            employees.Rows.Add(new object[5] { 221, 22, "Dylan", "Gold", "Manager's assistant" });
            employees.Rows.Add(new object[5] { 23, 2, "Samantha", "Silver", "Manager" });
            employees.Rows.Add(new object[5] { 24, 2, "Tyler", "Steel", "Manager" });

            employees.Rows.Add(new object[5] { 3, -1, "Victor", "Smith", "Security director" });
            employees.Rows.Add(new object[5] { 31, 3, "James", "Bond", "Guard" });
            employees.Rows.Add(new object[5] { 32, 3, "Jason", "Bourne", "Guard" });
            employees.Rows.Add(new object[5] { 33, 3, "John", "McClane", "Guard" });
            employees.Rows.Add(new object[5] { 34, 3, "Peter", "Parker", "Guard" });
            employees.Rows.Add(new object[5] { 35, 3, "Tony", "Stark", "Guard" });

            dataSet.Tables.Add(employees);

            return dataSet;
        }
    }
}
